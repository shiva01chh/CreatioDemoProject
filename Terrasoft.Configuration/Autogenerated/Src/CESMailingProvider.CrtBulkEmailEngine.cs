namespace Terrasoft.Configuration
{
	using Terrasoft.Configuration.DynamicContent;
	using Terrasoft.Configuration.DynamicContent.Models;
	using System;
	using System.Collections.Generic;
	using System.Data.SqlClient;
	using System.Globalization;
	using System.Linq;
	using System.Text.RegularExpressions;
	using System.Threading;
	using Terrasoft.Common;
	using Terrasoft.Configuration.CES;
	using Terrasoft.Configuration.CESResponses;
	using Terrasoft.Configuration.Mailing;
	using Terrasoft.Configuration.Marketing.Utilities;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Tasks;
	using Terrasoft.Configuration.Utils;
	using System.Reflection;


	#region Class: DcSendActionData
	/// <summary>
	/// Represents data to be used for async sending.
	/// </summary>
	public class DcSendActionData
	{

		#region Properties: Public

		/// <summary>
		/// Bulk email id to sent.
		/// </summary>
		public Guid BulkEmailId { get; set; }

		/// <summary>
		/// Current user culture info.
		/// </summary>
		public string CultureInfo { get; set; }

		/// <summary>
		/// The date and time to start sending.
		/// </summary>
		public DateTime StartSendingTime { get; set; }

		#endregion

	}

	/// <summary>
	/// Class for work with cloud email service.
	/// </summary>
	public class CESMailingProvider : ISessionedMailingProvider, IConfigurableMailingProvider, ITestMessageProvider,
		IBackgroundTask<DcSendActionData>, IUserConnectionRequired, IThrottlingSchedulesProvider, IEmailLimitValidator,
		IMailingCesApiProvider
	{

		#region Constants: Private

		private const int MailingServicePingAttemptsCount = 3;

		private const int MailingServicePingTimeout = 10000;

		#endregion

		#region Fields: Private

		private BulkEmailEventLogger _bulkEmailEventLogger;

		private BulkEmailMacroParser _bulkEmailMacroParser;

		private BpmonlineCloudEngine _cloudEngine;

		private Guid _mailingSessionId = Guid.Empty;

		private ISendingEmailProgressRepository _sendingRepo;

		#endregion

		#region Fields: Protected

		protected string _linkedEntitySchemaName;

		protected ICESApi _serviceApi;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="CESMailingProvider"/> class.
		/// </summary>
		public CESMailingProvider(): this(null) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="CESMailingProvider"/> class.
		/// Instance of the provider will be configured by calling Configure method.
		/// </summary>
		/// <param name="userConnection">Current user connection.</param>
		public CESMailingProvider(UserConnection userConnection)
			: this(userConnection, null) {
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CESMailingProvider"/> class.
		/// Use this constructor to initialize instance by provider config parameter.
		/// </summary>
		/// <param name="userConnection">Current user connection.</param>
		/// <param name="configFactory">The configuration factory, instance of the <see cref="IMailingProviderConfigFactory"/></param>
		public CESMailingProvider(UserConnection userConnection, IMailingProviderConfigFactory configFactory) {
			UserConnection = userConnection;
			if(configFactory == null) {
				return;
			}
			IMailingProviderConfig providerConfig = configFactory.CreateInstance(userConnection);
			if (providerConfig is CESMailingProviderConfig cesConfig) {
				_serviceApi = cesConfig.ServiceApi;
			}
		}

		#endregion

		#region Properties: Private

		private BpmonlineCloudEngine CloudEngine =>
			_cloudEngine ?? (_cloudEngine = ClassFactory.Get<BpmonlineCloudEngine>(
				new ConstructorArgument("userConnection", UserConnection)));

		#endregion

		#region Properties: Protected

		protected ISendingEmailProgressRepository SendingEmailProgressRepository {
			get =>
				_sendingRepo ?? ClassFactory.Get<SendingEmailProgressRepository>(
					new ConstructorArgument("userConnection", UserConnection));
			set => _sendingRepo = value;
		}

		protected CESMailingTemplateFactory TemplateFactory { get; set; }

		protected TemplateSizeValidator TemplateSizeValidator { get; set; }

		#endregion

		#region Properties: Public

		/// <summary>
		/// Gets instance of <see cref="ICESApi"/> to access cloud email service.
		/// </summary>
		public ICESApi ServiceApi => _serviceApi ?? (_serviceApi = CloudEngine.ServiceApi);

		/// <summary>
		/// Instance of current user connection.
		/// </summary>
		public UserConnection UserConnection { get; set; }

		/// <summary>
		/// Instance of BulkEmailEventLogger. 
		/// </summary>
		public BulkEmailEventLogger BulkEmailEventLogger =>
			_bulkEmailEventLogger ?? (_bulkEmailEventLogger = new BulkEmailEventLogger(UserConnection));

		public BulkEmailMacroParser BulkEmailMacroParser {
			get => _bulkEmailMacroParser ?? (_bulkEmailMacroParser = GetMacroParser());
			set => _bulkEmailMacroParser = value;
		}

		public BulkEmailValidator Validator { get; set; }

		#endregion

		#region Methods: Private

		private MailingResponse CreateErrorMailingResponse() {
			return new MailingResponse {
				Success = false,
				StatusId = MailingConsts.BulkEmailStatusErrorId
			};
		}

		private void CreateEventLogErrorMessage(BulkEmail bulkEmail, MailingStateExecutionResult stepResult,
			string lczEventName, IEnumerable<string> lczEventValues) {
			IEnumerable<string> notEmptyLczEvents = lczEventValues.Where(x => !x.IsNullOrEmpty());
			foreach (string lczEventValue in notEmptyLczEvents) {
				BulkEmailEventLogger.LogError(bulkEmail.Id, DateTime.UtcNow, GetLczStringValue(lczEventName),
					stepResult.Exception, GetLczStringValue(lczEventValue), UserConnection.CurrentUser.ContactId);
			}
		}

		private MailingContext CreateMailingContext(BulkEmail bulkEmail) {
			return new MailingContext(UserConnection, bulkEmail) {
				ServiceApi = ServiceApi,
				SessionId = _mailingSessionId
			};
		}

		private void CreateReminders(BulkEmail bulkEmail, MailingStateExecutionResult stepResult) {
			foreach (string lczString in stepResult.NotificationLcsStringCodes) {
				if (!string.IsNullOrEmpty(lczString)) {
					CreateReminding(bulkEmail, lczString);
				}
			}
		}

		private void ExecuteMailingStates(BulkEmail bulkEmail) {
			var states = new MailingState[] {
				new InitialSendingMailingState(),
				new AudienceSegmentationMailingState(),
				new PreparingTemplateState(),
				new SendingMailingState(),
				new StopMailingState(),
				new ExpiredMailingState()
			};
			var listResults = new List<MailingStateExecutionResult>();
			bool anyStepProcessed;
			MailingContext mailingContext = CreateMailingContext(bulkEmail);
			do {
				anyStepProcessed = false;
				mailingContext.StartedOn = DateTime.UtcNow;
				foreach (MailingState state in states) {
					mailingContext.ChangeState(state);
					MailingStateExecutionResult stateExecutionResult = mailingContext.Execute();
					listResults.Add(stateExecutionResult);
					if (!HandleMailingStepResult(bulkEmail, stateExecutionResult)) {
						break;
					}
					anyStepProcessed = anyStepProcessed ||
						stateExecutionResult.Status == MailingStateExecutionStatus.Continue;
				}
			} while (anyStepProcessed);
			if (!listResults.Any() || listResults.All(r => r.Status == MailingStateExecutionStatus.Skipped)) {
				throw new MailingStateHandleException("No one state has been finished with success status. ");
			}
		}
		
		private BulkEmail GetBulkEmailFromDB(Guid bulkEmailId) {
			var bulkEmail = new BulkEmail(UserConnection);
			bool fetchBulkEmailResult = bulkEmail.FetchFromDB("Id", bulkEmailId,
				new[] {
					"Id",
					"Owner",
					"Name",
					"TemplateBody",
					"UseUtm",
					"StartDate",
					"Category",
					"Domains",
					"UtmSource",
					"UtmMedium",
					"UtmCampaign",
					"UtmTerm",
					"UtmContent",
					"TemplateSubject",
					"SenderName",
					"SenderEmail",
					"SplitTest",
					"Status",
					"LaunchOption",
					"SegmentsStatus",
					"AudienceSchema",
					"SendStartDate",
					"IsSystemEmail",
					"Type",
					"Priority",
					"BusinessTimeStart",
					"BusinessTimeEnd",
					"ExpirationDate",
					"DeliverySchedule",
					"DeliveryScheduleDays",
					"ThrottlingMode",
					"ThrottlingQueue",
					"TimeZone",
					"StoppedManuallyCount",
					"StoppedSummaryCount",
					"StoppedInProviderCount",
					"DelayBetweenEmail",
					"DailyLimit",
					"ProviderName",
					"IsAudienceInited"
				});
			bulkEmail.Priority.FetchFromDB("Id", bulkEmail.PriorityId, new[] { "Priority" });
			bulkEmail.ThrottlingQueue.FetchFromDB("Id", bulkEmail.ThrottlingQueueId, new[] { "Code" });
			bulkEmail.ThrottlingMode.FetchFromDB("Id", bulkEmail.ThrottlingModeId, new[] { "Code" });
			bulkEmail.TimeZone.FetchFromDB("Id", bulkEmail.TimeZoneId, new[] { "Code" });
			if (!fetchBulkEmailResult) {
				MailingUtilities.Log.WarnFormat(
					"[CESMailingProvider.GetBulkEmailFromDB]: FetchFromDB BulkEmail: {0} fails.", bulkEmailId);
				throw new Exception(
					$"[CESMailingProvider.GetBulkEmailFromDB]: FetchFromDB BulkEmail: {bulkEmailId} fails.");
			}
			return bulkEmail;
		}

		private Dictionary<Guid, Guid> GetBulkEmailStopStatusMapping() {
			var bulkEmailStatusMapping = new Dictionary<Guid, Guid> {
				{ MailingConsts.BulkEmailStatusWaitingBeforeSendId, MailingConsts.BulkEmailStatusStoppedId },
				{ MailingConsts.BulkEmailStatusStartPlanedId, MailingConsts.BulkEmailStatusStoppedId }
			};
			if (UserConnection.GetIsFeatureEnabled("BulkEmailStop")) {
				bulkEmailStatusMapping.Add(MailingConsts.BulkEmailStatusStartsId,
					MailingConsts.BulkEmailStatusBreakingId);
				bulkEmailStatusMapping.Add(MailingConsts.BulkEmailStatusLaunchedId,
					MailingConsts.BulkEmailStatusBreakingId);
				bulkEmailStatusMapping.Add(MailingConsts.BulkEmailStatusQueuedId,
					MailingConsts.BulkEmailStatusHardStoppedId);
				bulkEmailStatusMapping.Add(MailingConsts.BulkEmailStatusActiveId,
					MailingConsts.BulkEmailStatusHardStoppedId);
			}
			return bulkEmailStatusMapping;
		}
		
		private string GetLczStringValue(string lczName) {
			string localizableStringName = $"LocalizableStrings.{lczName}.Value";
			var localizableString = new LocalizableString(UserConnection.Workspace.ResourceStorage,
				"CESMailingProvider", localizableStringName);
			string value = localizableString.Value ?? localizableString.GetCultureValue(GeneralResourceStorage.DefCulture, false);
			return value;
		}

		private BulkEmailMacroParser GetMacroParser() {
			var macrosHelper = ClassFactory.Get<MacrosHelperV2>();
			macrosHelper.UserConnection = UserConnection;
			return ClassFactory.Get<BulkEmailMacroParser>(new ConstructorArgument("macrosHelper", macrosHelper),
				new ConstructorArgument("linkedEntitySchemaName", _linkedEntitySchemaName));
		}
		
		private IEnumerable<DCReplicaModel> GetReplicasByMasks(DCTemplateModel template,
			IEnumerable<int> replicaMasks = null) {
			IEnumerable<DCReplicaModel> replicas = template.Replicas;
			if (replicaMasks != null && replicaMasks.Any()) {
				replicas = replicas.Where(x => replicaMasks.Contains(x.Mask));
			}
			return replicas;
		}

		private string GetStartDateString(DateTime startDate) {
			var startDateString = startDate.ToString("yyyy-MM-dd HH:mm:ss");
			TimeZoneInfo currentUserTimeZone = UserConnection.CurrentUser.TimeZone;
			string timeZoneString = $" GMT{(currentUserTimeZone.BaseUtcOffset < TimeSpan.Zero ? "-" : "+")}" +
				$"{currentUserTimeZone.BaseUtcOffset:hh\\:mm}";
			startDateString += timeZoneString;
			return startDateString;
		}


		private bool HandleMailingStepResult(BulkEmail bulkEmail, MailingStateExecutionResult stepResult,
			bool isSendingProcessFailed = true) {
			if (stepResult.Success) {
				return stepResult.Success;
			}
			if (isSendingProcessFailed) {
				SetBulkEmailErrorStatus(bulkEmail);
			}
			CreateReminders(bulkEmail, stepResult);
			IEnumerable<string> messages = stepResult.NotificationLcsStringCodes;
			string lczEventName = stepResult.EventLczStringCode;
			CreateEventLogErrorMessage(bulkEmail, stepResult, lczEventName, messages);
			return stepResult.Success;
		}

		private void InitMacroParser(Guid bulkEmailId) {
			EntitySchema targetSchema = UserConnection.EntitySchemaManager.GetInstanceByName(nameof(BulkEmail));
			var esq = new EntitySchemaQuery(targetSchema);
			esq.AddColumn("AudienceSchema.EntityObject.Id");
			Entity bulkEmail = esq.GetEntity(UserConnection, bulkEmailId);
			var linkedEntitySchemaUId = bulkEmail.GetTypedColumnValue<Guid>("AudienceSchema_EntityObject_Id");
			if (linkedEntitySchemaUId.IsNotEmpty()) {
				_linkedEntitySchemaName = UserConnection.EntitySchemaManager
					.FindInstanceByUId(linkedEntitySchemaUId)?.Name;
			}
			BulkEmailMacroParser = GetMacroParser();
		}

		protected virtual void PerformWaitBeforeSend(BulkEmail bulkEmail) {
			var sendDelayInSeconds =
				(int)Core.Configuration.SysSettings.GetValue(UserConnection, "MandrillMailingDelayInSeconds");
			bool isTriggeredCategory = bulkEmail.CategoryId == MailingConsts.TriggeredEmailBulkEmailCategoryId;
			if (!isTriggeredCategory) {
				Thread.Sleep(sendDelayInSeconds * 1000);
			}
		}

		private bool PingProvider(Guid emailId) {
			DateTime startPingTime = DateTime.UtcNow;
			try {
				bool result = Utilities.TryExecute(() => ServiceApi.Ping(UserConnection),
					MailingServicePingAttemptsCount, MailingServicePingTimeout, out object _);
				BulkEmailEventLogger.LogInfo(emailId, startPingTime, GetLczStringValue("PingCes"),
					GetLczStringValue("PingCesDescription"), UserConnection.CurrentUser.ContactId);
				return result;
			} catch (Exception e) {
				BulkEmailEventLogger.LogError(emailId, startPingTime, GetLczStringValue("PingCes"), e,
					GetLczStringValue("PingCesDescription"), UserConnection.CurrentUser.ContactId);
				return false;
			}
		}
		
		private void ProcessRecipientResponseGroup(IGrouping<int, IMessageRecipientInfo> recipientsByResponse,
			int batchSize) {
			var processedCount = 0;
			int groupCount = recipientsByResponse.Count();
			while (processedCount < groupCount) {
				IEnumerable<IMessageRecipientInfo> recipientsToUpdate =
					recipientsByResponse.Skip(processedCount).Take(batchSize);
				Guid responseId =
					BulkEmailResponseMapping.GetResponseIdByCode(UserConnection, recipientsByResponse.Key);
				var updateInitialResponse = (Update)new Update(UserConnection, "BulkEmailTarget")
					.Set("BulkEmailResponseId", Column.Parameter(responseId)).Where("MandrillId")
					.In(Column.Parameters(recipientsToUpdate.Select(x => x.Id)));
				updateInitialResponse.WithHints(new RowLockHint());
				processedCount += updateInitialResponse.Execute();
			}
		}

		private void RegisterSenderDomain(string senderEmail) {
			try {
				string domain = new Regex("^.*@").Replace(senderEmail, "");
				CloudEngine.RegisterSenderDomain(domain);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMailingProvider.RegisterSenderDomain]: Error while registering domain for email: {0}", e,
					senderEmail);
			}
		}

		private void RunDcSendActionAsync(DcSendActionData sendActionData) {
			MethodInfo method = typeof(Core.Tasks.Task).GetMethod("StartNewWithUserConnection");
			var mailingProviderType = this.GetType();
			MethodInfo genericMethod = method.MakeGenericMethod(mailingProviderType, typeof(DcSendActionData));
			genericMethod.Invoke(null, new[] { sendActionData });
		}

		private void SendDcMessage(BulkEmail bulkEmail, CultureInfo culture) {
			MailingUtilities.Log.InfoFormat(
				"[CESMailingProvider.CreateSendAction]: Start action for send. " + "BulkEmail.Id: {0}", bulkEmail.Id);
			Thread.CurrentThread.CurrentCulture = culture;
			ExecuteMailingStates(bulkEmail);
		}

		private Guid SetBulkEmailBreakingStatus(BulkEmail bulkEmail) {
			DateTime startOperationDate = DateTime.UtcNow;
			Guid defaultResult = bulkEmail.StatusId;
			var eventLcz = "MailingPausedManually";
			var eventDescriptionLcz = "MailingPausedManuallyDescription";
			try {
				Dictionary<Guid, Guid> bulkEmailStatusMapping = GetBulkEmailStopStatusMapping();
				if (!bulkEmailStatusMapping.TryGetValue(bulkEmail.StatusId, out Guid stoppedStatusId)) {
					return defaultResult;
				}
				Query bulkEmailUpdate = new Update(UserConnection, "BulkEmail")
					.Set("StatusId", Column.Parameter(stoppedStatusId)).Set("StartDate", Column.Const(null)).Where("Id")
					.IsEqual(Column.Parameter(bulkEmail.Id));
				int updatedCount = bulkEmailUpdate.Execute();
				if (stoppedStatusId == MailingConsts.BulkEmailStatusBreakingId ||
					(stoppedStatusId == MailingConsts.BulkEmailStatusHardStoppedId && updatedCount > 0)) {
					eventLcz = "MailingPrepareStopManually";
					eventDescriptionLcz = "MailingPrepareStopManuallyDescription";
				}
				BulkEmailEventLogger.LogInfo(bulkEmail.Id, startOperationDate, GetLczStringValue(eventLcz),
					GetLczStringValue(eventDescriptionLcz), UserConnection.CurrentUser.ContactId);
				return stoppedStatusId;
			} catch (SqlException e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMailingProvider.SetBulkEmailBreakingStatus]: " +
					"Update Breaking Status: BulkEmail: {0} fails.", e, bulkEmail.Id);
				BulkEmailEventLogger.LogError(bulkEmail.Id, DateTime.UtcNow,
					GetLczStringValue("BulkEmailStatusUpdateEvent"), e, GetLczStringValue("StateUpdateErrorMsg"),
					UserConnection.CurrentUser.ContactId);
			}
			return defaultResult;
		}

		private void SetBulkEmailErrorStatus(BulkEmail bulkEmail) {
			try {
				Guid status;
				if (MailingConsts.TriggeredEmailBulkEmailCategoryId.Equals(bulkEmail.CategoryId)) {
					status = MailingConsts.BulkEmailStatusActiveId;
				} else if (MailingConsts.MassmailingBulkEmailCategoryId.Equals(bulkEmail.CategoryId)) {
					status = MailingConsts.BulkEmailStatusErrorId;
				} else {
					throw new ArgumentException($"Unknown BulkEmail category: {bulkEmail.CategoryId}.");
				}
				SetBulkEmailStatus(bulkEmail, status);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMailingProvider.SetBulkEmailErrorStatus]: " + "Update Error Status: BulkEmail: {0} fails.", e,
					bulkEmail.Id);
				BulkEmailEventLogger.LogError(bulkEmail.Id, DateTime.UtcNow,
					GetLczStringValue("BulkEmailStatusUpdateEvent"), e,
					GetLczStringValue("SetBulkEmailErrorStatusErrorMsg"), UserConnection.CurrentUser.ContactId);
				throw;
			}
		}

		private void SetBulkEmailSplitStatus(Guid splitTestId, Guid bulkEmailStatusId) {
			try {
				var bulkEmailSplit = new BulkEmailSplit(UserConnection);
				if (!bulkEmailSplit.FetchFromDB(splitTestId)) {
					MailingUtilities.Log.ErrorFormat(
						"[CESMailingProvider.SetBulkEmailSplitStatus]: Failed to fetch BulkEmailSplit from DB." +
						"Id: {0}", splitTestId);
					return;
				}
				if (bulkEmailStatusId == MailingConsts.BulkEmailStatusStartsId &&
					bulkEmailSplit.StatusId == MailingConsts.BulkEmailSplitStatusStartPlanedId) {
					bulkEmailSplit.SetColumnValue("StatusId", MailingConsts.BulkEmailSplitStatusLaunchedId);
				}
				if (bulkEmailStatusId == MailingConsts.BulkEmailStatusFinishedId) {
					var selectCount = (Select)new Select(UserConnection).Column(Func.Count("Id")).From("BulkEmail")
						.Where("SplitTestId").IsEqual(Column.Parameter(splitTestId)).And("StatusId")
						.IsNotEqual(Column.Parameter(MailingConsts.BulkEmailStatusFinishedId)) ;
					var count = selectCount.ExecuteScalar<int>();
					if (count == 0) {
						bulkEmailSplit.SetColumnValue("StatusId", MailingConsts.BulkEmailSplitStatusFinishedId);
						string tableName = $"ST_{splitTestId.ToBase36()}";
						Utilities.DropTable(tableName, UserConnection, true);
					}
				}
				bulkEmailSplit.Save();
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMailingProvider.SetBulkEmailSplitStatus]: Error while saving BulkEmailSplit with Id: {0}", e,
					splitTestId);
			}
		}

		private void SetBulkEmailStatus(BulkEmail bulkEmail, Guid statusId) {
			var bulkEmailId = Guid.Empty;
			try {
				bulkEmailId = bulkEmail.Id;
				bulkEmail.SetColumnValue("StatusId", statusId);
				bulkEmail.Save();
				bulkEmail.StatusId = statusId;
				if (bulkEmail.SplitTestId != Guid.Empty) {
					SetBulkEmailSplitStatus(bulkEmail.SplitTestId, statusId);
				}
				MailingUtilities.Log.InfoFormat("BulkEmail with Id: {0} set to {1} status.", bulkEmailId, statusId);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMailingProvider.SetBulkEmailStatus]: Error while saving BulkEmail with Id: {0}", e,
					bulkEmailId);
				BulkEmailEventLogger.LogError(bulkEmailId, DateTime.UtcNow,
					GetLczStringValue("BulkEmailStatusUpdateEvent"), e, GetLczStringValue("SaveErrorMsg"),
					UserConnection.CurrentUser.ContactId);
				throw;
			}
		}
		
		private void SetSendStartDate(BulkEmail bulkEmail) {
			DateTime sendStartDate = DateTime.UtcNow;
			BulkEmailQueryHelper.UpdateBulkEmail(bulkEmail.Id, UserConnection,
				new KeyValuePair<string, object>("SendStartDate", sendStartDate));
			bulkEmail.SendStartDate = sendStartDate;
		}

		private void StartSendBulkEmail(BulkEmail bulkEmail, CultureInfo culture, DateTime startSendingTime) {
			var sendActionData = new DcSendActionData {
				CultureInfo = culture.Name,
				BulkEmailId = bulkEmail.Id,
				StartSendingTime = startSendingTime
			};
			RunDcSendActionAsync(sendActionData);
		}

		private bool StopBulkEmailInProvider(Guid bulkEmailId) {
			if (!UserConnection.GetIsFeatureEnabled("BulkEmailStop")) {
				return true;
			}
			try {
				Utilities.RetryOnFailure(() => ServiceApi.StopBulkEmail(bulkEmailId), 15, 5);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMailingProvider.StopBulkEmailInCes]: BulkEmail with " + "Id: {0} stop email execution error",
					e, bulkEmailId);
				BulkEmailEventLogger.LogError(bulkEmailId, DateTime.UtcNow, GetLczStringValue("MailingStoppedManually"),
					e, GetLczStringValue("MailingStoppedManuallyErrorMsg"), UserConnection.CurrentUser.ContactId);
				return false;
			}
			return true;
		}

		#endregion

		#region Methods: Protected

		protected void CreateReminding(Entity entity, string lczStringName, params object[] parameters) {
			CreateReminding(entity, lczStringName, GetLczStringValue("RemindingMsgCaption"), parameters);
		}

		protected void CreateReminding(Entity entity, string lczStringName, string caption,
			params object[] parameters) {
			string description = parameters.Any() ? string.Format(GetLczStringValue(lczStringName), parameters)
				: GetLczStringValue(lczStringName);
			MailingUtilities.CreateReminding(UserConnection, entity, description, caption);
		}

		protected IMailingTemplate CreateTemplate(BulkEmail bulkEmail, CESMacrosHelper macrosHelper) {
			IMailingTemplate template = TemplateFactory.CreateInstance(UserConnection, bulkEmail, BulkEmailMacroParser);
			template.Init();
			return template;
		}

		protected IEnumerable<IMailingTemplate> CreateTemplates(BulkEmail bulkEmail, BulkEmailMacroParser macroParser,
			IEnumerable<DCReplicaModel> replicasToProcess) {
			if (replicasToProcess == null) {
				var templateCollection = new List<IMailingTemplate>();
				IMailingTemplate mailingTemplate =
					TemplateFactory.CreateInstance(UserConnection, bulkEmail, macroParser);
				mailingTemplate.Init();
				templateCollection.Add(mailingTemplate);
				return templateCollection;
			}
			return TemplateFactory.CreateInstances(UserConnection, bulkEmail, replicasToProcess, macroParser);
		}

		protected IEnumerable<IMailingTemplate> CreateTemplates(BulkEmail bulkEmail, BulkEmailMacroParser macroParser,
			IEnumerable<int> replicaMasksToProcess = null) {
			var templateRepository = new DCTemplateRepository<DCTemplateModel>(UserConnection);
			var templateReadOptions = new DCRepositoryReadOptions<DCTemplateModel, DCReplicaModel> {
				TemplateReadOptions = DCTemplateReadOption.None
			};
			DCTemplateModel template = templateRepository.ReadByRecordId(bulkEmail.Id, templateReadOptions);
			IEnumerable<DCReplicaModel> replicas = null;
			if (template != null) {
				replicas = GetReplicasByMasks(template, replicaMasksToProcess);
			}
			return CreateTemplates(bulkEmail, macroParser, replicas);
		}

		protected void HandleEmailResult(int bulkEmailRId, IEnumerable<IMessageRecipientInfo> recipients) {
			var batchSize = 500;
			IEnumerable<IGrouping<int, IMessageRecipientInfo>> groupedRecipients =
				recipients.GroupBy(r => r.InitialResponseCode);
			foreach (IGrouping<int, IMessageRecipientInfo> recipientsByResponse in groupedRecipients) {
				ProcessRecipientResponseGroup(recipientsByResponse, batchSize);
			}
		}

		protected virtual void InitTemplateFactory() {
			if (TemplateFactory == null) {
				TemplateFactory = new CESMailingTemplateFactory();
			}
		}

		protected bool ValidateBulkEmail(Guid bulkEmailId, BulkEmail bulkEmail, MailingResponse stateExecutionResult) {
			MailingContext context = CreateMailingContext(bulkEmail);
			context.ChangeState(new ValidationMailingState());
			MailingStateExecutionResult executionResult = context.Execute();
			return HandleMailingStepResult(bulkEmail, executionResult, false);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Breaks process of sending.
		/// </summary>
		/// <param name="bulkEmailId">Unique identifier of the bulk email.</param>
		/// <returns>Returns status of bulk email.</returns>
		public MailingResponse BreakMailing(Guid bulkEmailId) {
			var bulkEmail = new BulkEmail(UserConnection);
			var response = new MailingResponse {
				Success = false,
				StatusId = Guid.Empty
			};
			if (!bulkEmail.FetchFromDB("Id", bulkEmailId, new[] { "Id", "Status" })) {
				MailingUtilities.Log.InfoFormat("Cannot access record with Id: {0}.", bulkEmailId);
				return response;
			}
			bool providerStopResult = StopBulkEmailInProvider(bulkEmail.Id);
			if (!providerStopResult) {
				return response;
			}
			Guid newBulkEmailStatusId = SetBulkEmailBreakingStatus(bulkEmail);
			response.Success = true;
			response.StatusId = newBulkEmailStatusId;
			return response;
		}

		/// <summary>
		/// Configures properties of current instance.
		/// </summary>
		public virtual void Configure() {
			Validator = new BulkEmailValidator(UserConnection, ServiceApi);
			TemplateSizeValidator = new TemplateSizeValidator();
			InitTemplateFactory();
		}

		/// <summary>
		/// Gets throttling schedules for the current user by the required strategy.
		/// </summary>
		/// <param name="getThrottlingScheduleRequest">Request instance with the required service id.</param>
		/// <returns>Throttling for the current user by the required strategy.</returns>
		public GetThrottlingSchedulesResponse GetThrottlingSchedules(
			GetThrottlingScheduleRequest getThrottlingScheduleRequest) {
			getThrottlingScheduleRequest.ApiKey = _serviceApi.ApiKey;
			return _serviceApi.GetThrottlingSchedules(getThrottlingScheduleRequest);
		}

		/// <summary>
		/// Ping provider's service.
		/// </summary>
		public bool PingProvider() {
			try {
				if (string.IsNullOrWhiteSpace(ServiceApi.BaseUrl)) {
					return false;
				}
				ServiceApi.Ping(UserConnection);
				return true;
			} catch (Exception) {
				return false;
			}
		}

		/// <summary>
		/// Method to run async send action with user connection.
		/// </summary>
		/// <param name="data"><see cref="DcSendActionData"/>Data to be used for async sending.</param>
		public void Run(DcSendActionData data) {
			BulkEmail bulkEmail = GetBulkEmailFromDB(data.BulkEmailId);
			var culture = CultureInfo.GetCultureInfo(data.CultureInfo);
			PerformWaitBeforeSend(bulkEmail);
			Guid currentBulkEmailStatus = BulkEmailQueryHelper.GetBulkEmailStatus(bulkEmail.Id, UserConnection);
			if (currentBulkEmailStatus == MailingConsts.BulkEmailStatusStoppedId) {
				MailingUtilities.Log.InfoFormat(
					"[CESMailingProvider.ExecuteSendMessageTask]: Break iterations. " +
					"BulkEmail.Id {0} has status 'Stopped'.", bulkEmail.Id);
			} else {
				BulkEmailQueryHelper.UpdateBulkEmail(bulkEmail.Id, UserConnection,
					new KeyValuePair<string, object>("StartDate", DateTime.UtcNow));
				Configure();
				SendDcMessage(bulkEmail, culture);
			}
		}

		/// <summary>
		/// Sends test bulk email message with dynamic content. Sends all replicas if 
		/// <see cref="SendTestMessageData.ReplicaMasks"/> property of the parameter <paramref name="data"/>
		/// is null or empty, or chosen replicas in another case.
		/// </summary>
		/// <param name="data">Data required for test message sending.</param>
		/// <returns>Results of successful sending for each replica.</returns>
		public SendTestMessageResult SendDCTestMessage(SendTestMessageData data) {
			if (!PingProvider(data.BulkEmailId)) {
				BulkEmailEventLogger.LogInfo(data.BulkEmailId, DateTime.UtcNow, GetLczStringValue("PingCes"),
					GetLczStringValue("PingCesDescription"), UserConnection.CurrentUser.ContactId);
				return new SendTestMessageResult {
					Success = false
				};
			}
			InitMacroParser(data.BulkEmailId);
			var executor = new ImmediateEmailExecutor(UserConnection) {
				TemplateFactory = TemplateFactory,
				CloudEngine = CloudEngine,
				ServiceApi = ServiceApi,
				Validator = Validator,
				BulkEmailMacroParser = BulkEmailMacroParser,
				TemplateRepository = new DCTemplateRepository<DCTemplateModel>(UserConnection)
			};
			return executor.Send(data);
		}

		/// <summary>
		/// Starts sending of the bulk email with the sessionId.
		/// </summary>
		/// <param name="bulkEmailId">Unique identifier of the bulk email.</param>
		/// <param name="sessionId">Guid identifier of the current trigger mailing session</param>
		/// <param name="isDelayedStart">Delay sending.</param>
		/// <returns>Returns status of bulk email.</returns>
		public MailingResponse SendMessage(Guid bulkEmailId, Guid sessionId, bool isDelayedStart = false,
			string applicationUrl = "") {
			_mailingSessionId = sessionId;
			return SendMessage(bulkEmailId, isDelayedStart, applicationUrl);
		}

		/// <summary>
		/// Starts sending of the bulk email.
		/// </summary>
		/// <param name="bulkEmailId">Unique identifier of the bulk email.</param>
		/// <param name="isDelayedStart">Delay sending.</param>
		/// <returns>Returns status of bulk email.</returns>
		public MailingResponse SendMessage(Guid bulkEmailId, bool isDelayedStart = false, string applicationUrl = "") {
			DateTime startSendingTime = DateTime.UtcNow;
			BulkEmail bulkEmail = GetBulkEmailFromDB(bulkEmailId);
			MailingResponse response = CreateErrorMailingResponse();
			if (!ValidateBulkEmail(bulkEmailId, bulkEmail, response)) {
				return response;
			}
			RegisterSenderDomain(bulkEmail.SenderEmail);
			if (bulkEmail.StartDate != DateTime.MinValue && !isDelayedStart) {
				BulkEmailEventLogger.LogInfo(bulkEmail.Id, startSendingTime, GetLczStringValue("StartSendingEmail"),
					GetLczStringValue("StartSendingScheduledEmailDescription"), UserConnection.CurrentUser.ContactId,
					GetStartDateString(bulkEmail.StartDate));
				SetBulkEmailStatus(bulkEmail, MailingConsts.BulkEmailStatusStartPlanedId);
			} else {
				CultureInfo culture = Thread.CurrentThread.CurrentCulture;
				SetSendStartDate(bulkEmail);
				SendingEmailProgressRepository.IncrementReceivedInitialResponses(bulkEmail.Id);
				if (bulkEmail.CategoryId == MailingConsts.MassmailingBulkEmailCategoryId &&
					bulkEmail.LaunchOptionId == MailingConsts.BulkEmailManaulLaunchOptionId) {
					SetBulkEmailStatus(bulkEmail, MailingConsts.BulkEmailStatusWaitingBeforeSendId);
					StartSendBulkEmail(bulkEmail, culture, startSendingTime);
				} else {
					try {
						SendDcMessage(bulkEmail, culture);
					} catch (Exception e) {
						MailingUtilities.Log.ErrorFormat(
							"[CESMailingProvider.SendMessage]: BulkEmail with " + "Id: {0} sendAction execution error",
							e, bulkEmail.Id);
						BulkEmailEventLogger.LogError(bulkEmail.Id, DateTime.UtcNow,
							GetLczStringValue("BatchSendEvent"), e, GetLczStringValue("SendEmailErroMsg"),
							UserConnection.CurrentUser.ContactId);
						return response;
					}
				}
			}
			response.Success = true;
			response.StatusId = bulkEmail.StatusId;
			return response;
		}

		/// <summary>
		/// Starts sending of the message.
		/// </summary>
		/// <param name="messageInfo">Object that holds information about message.</param>
		/// <returns>Status of message.</returns>
		[Obsolete("Will be removed after 7.17.3")]
		public virtual MailingResponse SendMessage(IMessageInfo messageInfo) {
			throw new NotImplementedException("removed after 7.17.3");
		}

		/// <summary>
		/// Sends test email.
		/// </summary>
		/// <param name="bulkEmailId">Unique identifier of the bulk email.</param>
		/// <param name="contactId">Unique identifier of the contact from audience.</param>
		/// <param name="emailRecipient">Email address of the recipient.</param>
		/// <returns>Returns result of successful sending.</returns>
		public bool SendTestMessage(Guid bulkEmailId, Guid contactId, string emailRecipient) {
			SendTestMessageResult result = SendDCTestMessage(new SendTestMessageData {
				ContactId = contactId,
				EmailRecipients = emailRecipient,
				BulkEmailId = bulkEmailId
			});
			return result.Success;
		}

		/// <summary>
		/// Method to set user connection when run async task.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		public virtual void SetUserConnection(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		/// <summary>
		/// Validates status of bulk emails.
		/// </summary>
		/// <param name="bulkEmailIds">Unique identifiers of the message.</param>
		/// <returns>Validation result.</returns>
		public ConfigurationServiceResponse ValidateDraftStatus(Guid[] bulkEmailIds) {
			return Validator.ValidateDraftStatus(bulkEmailIds);
		}

		/// <summary>
		/// Validates message.
		/// </summary>
		/// <param name="messageId">Unique identifier of the message.</param>
		/// <returns>Validation result.</returns>
		public ConfigurationServiceResponse ValidateMessage(Guid messageId) {
			return ValidateMessages(new[] { messageId });
		}

		/// <summary>
		/// Validates single email.
		/// </summary>
		/// <param name="messageId">Unique identifiers of the message.</param>
		/// <param name="recipientsCount">Recipients count to validate for sending limit.
		/// If 0 - counts recipients from audience with "Ready to send" response.</param>
		/// <returns>Validation result.</returns>
		public ConfigurationServiceResponse ValidateMessage(Guid messageId, int recipientsCount) {
			return Validator.ValidateMessages(new[] { messageId }, recipientsCount);
		}

		/// <summary>
		/// Validates messages.
		/// </summary>
		/// <param name="messageIds">Unique identifiers of the message.</param>
		/// <returns>Validation result.</returns>
		public ConfigurationServiceResponse ValidateMessages(Guid[] messageIds) {
			return Validator.ValidateMessages(messageIds);
		}

		#endregion

	}

	#endregion

}





