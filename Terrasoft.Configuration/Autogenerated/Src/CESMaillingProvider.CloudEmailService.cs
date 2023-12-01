namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Globalization;
	using System.Linq;
	using System.Text.RegularExpressions;
	using System.Threading;
	using Terrasoft.Common;
	using Terrasoft.Configuration.CESModels;
	using Terrasoft.Configuration.Marketing.Utilities;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Factories;
	using Utils;


	#region Class: CESMaillingProvider

	/// <summary>
	/// Class for work with cloud email service.
	/// </summary>
	public class CESMaillingProvider : CESMailingProvider
	{

		#region Constants: Private

		private const int PreparationRecipientsBatchSize = 20000;

		private const string MassMailingTag = "mass_mailing";

		private const string TriggeredEmailTag = "triggered_email";

		private const int MailingMaxTemplateSize = 5242880;

		#endregion

		#region Fields: Private

		private Guid _mailingSessionId = Guid.Empty;

		private bool? _isDcBulkEmail = null;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="CESMaillingProvider"/> class.
		/// </summary>
		public CESMaillingProvider(): this(null) {
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CESMaillingProvider"/> class.
		/// Instance of the provider will be configured by calling Configure method.
		/// </summary>
		/// <param name="userConnection">Current user connection.</param>
		public CESMaillingProvider(UserConnection userConnection): this(userConnection, null) {
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CESMaillingProvider"/> class.
		/// Use this constructor to initialize instnce by provider config parameter.
		/// </summary>
		/// <param name="userConnection">Current user connection.</param>
		/// <param name="configFactory">The configuration factory, instance of the <see cref="IMailingProviderConfigFactory"/></param>
		public CESMaillingProvider(UserConnection userConnection, IMailingProviderConfigFactory configFactory)
			: base(userConnection, configFactory) {
		}

		#endregion

		#region Properties: Private

		private BpmonlineCloudEngine _cloudEngine;
		private BpmonlineCloudEngine CloudEngine {
			get {
				if (_cloudEngine == null) {
					_cloudEngine = ClassFactory.Get<BpmonlineCloudEngine>(
						new ConstructorArgument("userConnection", UserConnection));
				}
				return _cloudEngine;
			}
		}

		#endregion

		#region Properties: Protected

		[Obsolete("Will be removed after 7.17.3")]
		protected IMailingAudienceDataSourceFactory AudienceDataSourceFactory { get; set; }

		#endregion

		#region Methods: Private

		private MailingContext CreateMailingContext(BulkEmail bulkEmail) {
			return new MailingContext(UserConnection, bulkEmail) {
				ServiceApi = ServiceApi,
				SessionId = _mailingSessionId
			};
		}
		

		private BulkEmailMacroParser GetMacroParser() {
			var macrosHelper = ClassFactory.Get<MacrosHelperV2>();
			macrosHelper.UserConnection = UserConnection;
			return ClassFactory.Get<BulkEmailMacroParser>(
				new ConstructorArgument("macrosHelper", macrosHelper),
				new ConstructorArgument("linkedEntitySchemaName", _linkedEntitySchemaName));
		}

		private CESMacrosHelper GetMacrosHelper(Guid contactId, Guid bulkEmailId) {
			return ClassFactory.Get<CESMacrosHelper>(
				new ConstructorArgument("userConnection", UserConnection),
				new ConstructorArgument("contactId", contactId),
				new ConstructorArgument("bulkEmailId", bulkEmailId));
		}

		private string GetLczStringValue(string lczName) {
			string localizableStringName = string.Format("LocalizableStrings.{0}.Value", lczName);
			var localizableString = new LocalizableString(
				UserConnection.Workspace.ResourceStorage, "CESMailingProvider", localizableStringName);
			string value = localizableString.Value;
			if (value == null) {
				value = localizableString.GetCultureValue(GeneralResourceStorage.DefCulture, false);
			}
			return value;
		}
		
		[Obsolete("Will be removed after 7.17.3")]
		private IEnumerable<EmailAddress> GetEmailMesageTo(IEnumerable<IMessageRecipientInfo> recipients,
				CESMacrosHelper macrosHelper, IMailingTemplate template, Guid bulkEmailId) {
			var validRecipients = GetValidRecipient(recipients);
			var personalMergeVars = GetMergeVars(macrosHelper, template, validRecipients, bulkEmailId);
			IEnumerable<EmailAddress> recipientEmailAddress = GetRecipientEmailAddress(personalMergeVars);
			return recipientEmailAddress;
		}

		[Obsolete("Will be removed after 7.17.3")]
		private void PrepareRecipients(IMessageInfo messageInfo, CESMacrosHelper macrosHelper,
				EmailMessage emailMessage, IMailingTemplate template, Guid bulkEmailId) {
			IEnumerable<EmailAddress> recipientEmailAddress =
				GetEmailMesageTo(messageInfo.Recipients, macrosHelper, template, bulkEmailId);
			emailMessage.to = recipientEmailAddress;
		}

		private List<string> GetBulkEmailCategoryTags(BulkEmail bulkEmail) {
			var tags = new List<string>();
			Guid categoryId = bulkEmail.CategoryId;
			if (categoryId == MailingConsts.MassmailingBulkEmailCategoryId) {
				tags.Add(MassMailingTag);
			} else if (categoryId == MailingConsts.TriggeredEmailBulkEmailCategoryId) {
				tags.Add(TriggeredEmailTag);
			}
			return tags;
		}

		[Obsolete("Will be removed after 7.17.3")]
		private EmailMessage InitEmailMessage(IMessageInfo messageInfo) {
			var instantMessageInfo = messageInfo as InstantMessageInfo;
			BulkEmail bulkEmail = instantMessageInfo.BulkEmail;
			CESMacrosHelper macrosHelper = GetMacrosHelper(bulkEmail.OwnerId, bulkEmail.Id);
			IMailingTemplate template = CreateTemplate(bulkEmail, macrosHelper);
			try {
				var message = new EmailMessage {
					subject = template.TemplateSubject,
					from_email = bulkEmail.SenderEmail,
					from_name = bulkEmail.SenderName,
					html = bulkEmail.TemplateBody,
					track_clicks = true,
					track_opens = true,
					inline_css = true,
					important = true
				};
				var bulkEmailId = bulkEmail.GetTypedColumnValue<Guid>("Id");
				PrepareRecipients(messageInfo, macrosHelper, message, template, bulkEmailId);
				MailingUtilities.Log.InfoFormat("CESMaillingProvider.GetRecipients. Bulk email with Id={0} "
					+ "executed successfully", bulkEmailId);
				message.tags = GetBulkEmailCategoryTags(bulkEmail);
				message.html = template.Content;
				message.images = template.InlineImages.ToCESImage();
				List<merge_var> globalMergeVars = macrosHelper.GetGlobalMergeVars(template.MacrosCollection);
				if (globalMergeVars.Any()) {
					message.InitGlobalVariable();
					message.global_merge_vars.AddRange(globalMergeVars);
				}
				return message;
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.InitEmailMessage]: Error while init message for BulkEmail with Id: {0}",
					e, bulkEmail.Id);
				throw;
			}
		}


		private void SetInvalidBulkEmailCounters(Guid bulkEmailId, int invalidAddresseeCount) {
			QueryColumnExpression actualInvalidAdresseeExpression
				= MailingDbUtilities.GetAddCountColumnExpression("InvalidAddresseeCount", invalidAddresseeCount);
			BulkEmailQueryHelper.UpdateBulkEmail(bulkEmailId, UserConnection,
				new KeyValuePair<string, object>("SendDueDate", Column.Const(null)),
				new KeyValuePair<string, object>("InvalidAddresseeCount", actualInvalidAdresseeExpression));

		}
		
		private void SetBulkEmailStatus(BulkEmail bulkEmail, Guid statusId) {
			Guid bulkEmailId = Guid.Empty;
			try {
				bulkEmailId = bulkEmail.Id;
				var bulkEmailStatusUpdate =
					new Update(UserConnection, "BulkEmail").Set("StatusId", Column.Parameter(statusId))
						.Where("Id").IsEqual(Column.Parameter(bulkEmailId)) as Update;
				bulkEmailStatusUpdate.WithHints(new RowLockHint());
				bulkEmailStatusUpdate.Execute();
				bulkEmail.StatusId = statusId;
				if (bulkEmail.SplitTestId != Guid.Empty) {
					SetBulkEmailSplitStatus(bulkEmail.SplitTestId, statusId);
				}
				MailingUtilities.Log.InfoFormat(
					"BulkEmail with Id: {0} set to {1} status.", bulkEmailId, statusId);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.SetBulkEmailStatus]: Error while saving BulkEmail with Id: {0}",
					e, bulkEmailId);
				BulkEmailEventLogger.LogError(bulkEmailId, DateTime.UtcNow,
					GetLczStringValue("BulkEmailStatusUpdateEvent"), e, GetLczStringValue("SaveErrorMsg"),
					UserConnection.CurrentUser.ContactId);
				throw;
			}
		}

		private void SetBulkEmailSplitStatus(Guid splitTestId, Guid bulkEmailStatusId) {
			try {
				var bulkEmailSplit = new BulkEmailSplit(UserConnection);
				if (!bulkEmailSplit.FetchFromDB(splitTestId)) {
					MailingUtilities.Log.ErrorFormat(
						"[CESMaillingProvider.SetBulkEmailSplitStatus]: Failed to fetch BulkEmailSplit from DB." +
						"Id: {0}", splitTestId);
					return;
				}
				if (bulkEmailStatusId == MailingConsts.BulkEmailStatusStartsId &&
						bulkEmailSplit.StatusId == MailingConsts.BulkEmailSplitStatusStartPlanedId) {
					bulkEmailSplit.SetColumnValue("StatusId", MailingConsts.BulkEmailSplitStatusLaunchedId);
				}
				if (bulkEmailStatusId == MailingConsts.BulkEmailStatusFinishedId) {
					var selectCount = new Select(UserConnection)
						.Column(Func.Count("Id"))
						.From("BulkEmail")
						.Where("SplitTestId").IsEqual(Column.Parameter(splitTestId))
							.And("StatusId").IsNotEqual(Column.Parameter(MailingConsts.BulkEmailStatusFinishedId)) as Select;
					var count = selectCount.ExecuteScalar<int>();
					if (count == 0) {
						bulkEmailSplit.SetColumnValue("StatusId", MailingConsts.BulkEmailSplitStatusFinishedId);
						string tableName = string.Format("ST_{0}", splitTestId.ToBase36());
						Utilities.DropTable(tableName, UserConnection, true);
					}
				}
				bulkEmailSplit.Save();
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.SetBulkEmailSplitStatus]: Error while saving BulkEmailSplit with Id: {0}",
					e, splitTestId);
			}
		}

		private void SetBulkEmailErrorStatus(BulkEmail bulkEmail) {
			Guid status;
			try {
				if (MailingConsts.TriggeredEmailBulkEmailCategoryId.Equals(bulkEmail.CategoryId)) {
					status = MailingConsts.BulkEmailStatusActiveId;
				} else if (MailingConsts.MassmailingBulkEmailCategoryId.Equals(bulkEmail.CategoryId)) {
					status = MailingConsts.BulkEmailStatusErrorId;
				} else {
					throw new ArgumentException(string.Format("Unknown BulkEmail category: {0}.", bulkEmail.CategoryId));
				}
				SetBulkEmailStatus(bulkEmail, status);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.SetBulkEmailErrorStatus]: "
					+ "Update Error Status: BulkEmail: {0} fails.", e, bulkEmail.Id);
				BulkEmailEventLogger.LogError(bulkEmail.Id, DateTime.UtcNow,
					GetLczStringValue("BulkEmailStatusUpdateEvent"), e,
					GetLczStringValue("SetBulkEmailErrorStatusErrorMsg"), UserConnection.CurrentUser.ContactId);
				throw;
			}
		}
		
		private IEnumerable<IMessageRecipientInfo> GetValidRecipient(IEnumerable<IMessageRecipientInfo> recipientsBatch) {
			var validRecipients = recipientsBatch.Where(item =>
				item.InitialResponseCode == (int)MailingResponseCode.PostedProvider);
			return validRecipients;
		}

		private IEnumerable<EmailAddress> GetRecipientEmailAddress(
				Dictionary<IMessageRecipientInfo, rcpt_merge_var> recipientsBatch) {
			var emailAddresses = new List<EmailAddress>();
			foreach (var recipientPair in recipientsBatch) {
				var recipientInfo = recipientPair.Key;
				var emailAddress = new EmailAddress(recipientInfo.Id, recipientInfo.EmailAddress);
				emailAddress.rcpt_merge_var = recipientPair.Value;
				emailAddresses.Add(emailAddress);
			}
			return emailAddresses;
		}

		private int GetInitialResponseCodeByContactRId(int contactRId) {
			var responseCase = new QueryCase();
			var trueValue = 1;
			MailingDbUtilities.AddWhenCondition(
				responseCase, "Contact", "IsNonActualEmail", QueryConditionType.Equal, trueValue,
				(int)MailingResponseCode.CanceledInvalidEmail);
			MailingDbUtilities.AddWhenCondition(
				responseCase, "Contact", "DoNotUseEmail", QueryConditionType.Equal, trueValue,
				(int)MailingResponseCode.CanceledDoNotUseEmail);
			responseCase.ElseExpression =
				new QueryColumnExpression(Column.Parameter((int)MailingResponseCode.PostedProvider));
			var select = new Select(UserConnection)
				.Column(responseCase).As("InitialResponseCode")
				.From("Contact")
				.Where("RId").IsEqual(Column.Const(contactRId)) as Select;
			return select.ExecuteScalar<int>();
		}

		private void PrepareInitialResponses(IEnumerable<IMessageRecipientInfo> recipients) {
			foreach (IMessageRecipientInfo recipient in recipients) {
				if (string.IsNullOrEmpty(recipient.EmailAddress)) {
					recipient.InitialResponseCode = (int)MailingResponseCode.CanceledBlankEmail;
				} else if (!MailingUtilities.ValidateEmail(recipient.EmailAddress)) {
					recipient.InitialResponseCode = (int)MailingResponseCode.CanceledIncorrectEmail;
				} else {
					recipient.InitialResponseCode = GetInitialResponseCodeByContactRId(recipient.ContactRId);
				}
			}
		}

		private void RegisterSenderDomain(string senderEmail) {
			try {
				var domain = new Regex("^.*@").Replace(senderEmail, "");
				CloudEngine.RegisterSenderDomain(domain);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.RegisterSenderDomain]: Error while registering domain for email: {0}",
					e, senderEmail);
			}
		}

		[Obsolete("Will be removed after 7.17.3")]
		private IMailingAudienceDataSource InitializeAudienceDataSource(Guid bulkEmailId, int recipientsBatchSize) {
			IMailingAudienceDataSource audienceDataSource = null;
			if (_mailingSessionId.Equals(Guid.Empty)) {
				audienceDataSource = AudienceDataSourceFactory.CreateInstance(UserConnection, bulkEmailId,
					recipientsBatchSize);
			} else {
				var sessionedFactory = AudienceDataSourceFactory as IMailingAudienceSessionedDataSourceFactory;
				audienceDataSource = sessionedFactory.CreateSessionedInstance(UserConnection, bulkEmailId,
					recipientsBatchSize, _mailingSessionId);
			}
			var dcAudienceDataSource = (IDCAudienceDataSource)audienceDataSource;
			if (_isDcBulkEmail.HasValue && dcAudienceDataSource != null) {
				dcAudienceDataSource.IsDCBulkEmail = _isDcBulkEmail.Value;
			}
			return audienceDataSource;
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
			var messages = stepResult.NotificationLcsStringCodes;
			string lczEventName = stepResult.EventLczStringCode;
			CreateEventLogErrorMessage(bulkEmail, stepResult, lczEventName, messages);
			return stepResult.Success;
		}

		private void CreateEventLogErrorMessage(BulkEmail bulkEmail, MailingStateExecutionResult stepResult,
			string lczEventName, IEnumerable<string> lczEventValues) {
			var notEmptyLczEvents = lczEventValues.Where(x => !x.IsNullOrEmpty());
			foreach (string lczEventValue in notEmptyLczEvents) {
				BulkEmailEventLogger.LogError(bulkEmail.Id, DateTime.UtcNow, GetLczStringValue(lczEventName),
					stepResult.Exception, GetLczStringValue(lczEventValue), UserConnection.CurrentUser.ContactId);
			}
		}

		private void CreateReminders(BulkEmail bulkEmail, MailingStateExecutionResult stepResult) {
			foreach (var lczString in stepResult.NotificationLcsStringCodes) {
				if (!string.IsNullOrEmpty(lczString)) {
					CreateReminding(bulkEmail, lczString);
				}
			}
		}

		private void SendDCMessage(BulkEmail bulkEmail, CultureInfo culture) {
			MailingUtilities.Log.InfoFormat("[CESMaillingProvider.CreateSendAction]: Start action for send. " +
				"BulkEmail.Id: {0}", bulkEmail.Id);
			Thread.CurrentThread.CurrentCulture = culture;
			ExecuteMailingStates(bulkEmail);
		}

		private void ExecuteMailingStates(BulkEmail bulkEmail) {
			var states = new MailingState[] {
				new InitialSendingMailingState(), new AudienceSegmentationMailingState(), new PreparingTemplateState(),
				new SendingMailingState(), new StopMailingState(), new ExpiredMailingState()
			};
			var listResults = new List<MailingStateExecutionResult>();
			bool anyStepProcessed;
			var mailingContext = CreateMailingContext(bulkEmail);
			do {
				anyStepProcessed = false;
				mailingContext.StartedOn = DateTime.UtcNow;
				foreach (var state in states) {
					mailingContext.ChangeState(state);
					var stateExecutionResult = mailingContext.Execute();
					listResults.Add(stateExecutionResult);
					if (!HandleMailingStepResult(bulkEmail, stateExecutionResult)) {
						break;
					}
					anyStepProcessed = anyStepProcessed ||
						stateExecutionResult.Status == MailingStateExecutionStatus.Continue;
				}
			} while (anyStepProcessed);
			if (!listResults.Any() || listResults.All(r => r.Status == MailingStateExecutionStatus.Skipped)) {
				throw new MailingStateHandleException($"No one state has been finished with success status. ");
			}
		}

		#endregion

		#region Methods: Protected

		[Obsolete("Will be removed after 7.17.3")]
		protected void ActualizeRecipientsBeforeSend(int bulkEmailRId) {
			try {
				var update = new Update(UserConnection, "MandrillRecipient")
					.Set("IsSent", Column.Const(true))
				.Where().Exists(new Select(UserConnection).Column("Id")
					.From("MandrillSentMessage")
					.Where("BulkEmailRId").IsEqual("MandrillRecipient", "BulkEmailRId")
					.And("ContactRId").IsEqual("MandrillRecipient", "ContactRId")
				).And("BulkEmailRId").IsEqual(Column.Parameter(bulkEmailRId))
				.And("IsSent").IsEqual(Column.Const(false)) as Update;
				update.Execute();
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat("[CESMaillingProvider.ActualizeRecipientsBeforeSend]: "
					+ "Update of BulkEmail: {0} fails.", e, bulkEmailRId);
				throw;
			}
		}

		[Obsolete("Will be removed after 7.17.3")]
		protected void SaveTemplate(IMailingTemplate template, BulkEmail bulkEmail) {
			if (!TemplateSizeValidator.ValidateTemplateSize(template, out var templateSize)) {
				throw new Exception(string.Format("Template {0} have size {1} more than {2}.", template.Name,
					MailingMaxTemplateSize));
			}
			IEnumerable<image> images = template.InlineImages.ToCESImage();
			string checksum = string.Empty;
			string replicaId = null;
			string senderEmail;
			string senderName;
			if (template is IMailingTemplateWithHeaders templateReplica) {
				checksum = templateReplica.Checksum;
				replicaId = templateReplica.ReplicaId.ToString();
				senderEmail = templateReplica.SenderEmail;
				senderName = templateReplica.SenderName;
			} else {
				senderEmail = bulkEmail.SenderEmail;
				senderName = bulkEmail.SenderName;
			}
			Utilities.RetryOnFailure(() => ServiceApi.AddTemplate(
				template.Name,
				senderEmail,
				senderName,
				template.TemplateSubject,
				template.Content,
				string.Empty,
				bulkEmail.Id,
				images,
				checksum,
				replicaId));
		}

		[Obsolete("7.17.1 | Sending bulk email moved to Terrasoft.Configuration.SendingMailingState.")]
		protected Action CreateDCSendAction(BulkEmail bulkEmail, CultureInfo culture, DateTime startSendingTime) {
			return () => SendDCMessage(bulkEmail, culture);
		}
		

		[Obsolete("Will be removed after 7.17.3")]
		protected void ExecuteSendMessagePostProcessing(SendMessageData sendMessageData,
				List<TypedCounter<MailingResponseCode>> sendResults, SendMessageTaskData sendMessageTaskData) {
			BulkEmail bulkEmail = sendMessageData.BulkEmail;
			Guid sessionId = sendMessageData.SessionId;
			int blankEmailCount = sendResults.Sum("BlankEmail");
			int doNotUseEmailCount = sendResults.Sum("DoNotUseEmail");
			int unsubscribedByTypeCount = sendResults.Sum("UnsubscribedByType");
			int incorrectEmailCount = sendResults.Sum("IncorrectEmail");
			int unreachableEmailCount = sendResults.Sum("UnreachableEmail");
			int communicationLimitCount = sendResults.Sum("CommunicationLimit");
			int duplicateEmailCount = sendResults.Sum("DuplicateEmail");
			int templateNotFoundCount= sendResults.Sum("TemplateNotFound");
			int sendersDomainNotVerifiedCount = sendResults.Sum("SendersDomainNotVerified");
			int sendersNameNotValidCount = sendResults.Sum("SendersNameNotValid");
			int invalidAddresseeCount = sendResults.Sum("InvalidAddressee");
			if (sendMessageTaskData.IsBreaking) {
				SetBulkEmailStatus(bulkEmail, MailingConsts.BulkEmailStatusStoppedId);
				BulkEmailEventLogger.LogInfo(bulkEmail.Id, DateTime.UtcNow,
					GetLczStringValue("MailingStoppedManually"), GetLczStringValue("MailingStoppedManuallyDescription"),
					UserConnection.CurrentUser.ContactId);
				SetInvalidBulkEmailCounters(bulkEmail.Id, invalidAddresseeCount);
				CreateReminding(bulkEmail, "CESStoppedMailingMsg");
				MailingUtilities.Log.InfoFormat("BulkEmail with Id: {0} Was stopped manually.", bulkEmail.Id);
				return;
			}
			BulkEmailQueryHelper.UpdateBulkEmail(bulkEmail.Id, UserConnection,
				new KeyValuePair<string, object>("SendDueDate", DateTime.UtcNow),
				new KeyValuePair<string, object>("BlankEmailCount", blankEmailCount),
				new KeyValuePair<string, object>("DoNotUseEmailCount", doNotUseEmailCount),
				new KeyValuePair<string, object>("UnsubscribedByTypeCount", unsubscribedByTypeCount),
				new KeyValuePair<string, object>("IncorrectEmailCount", incorrectEmailCount),
				new KeyValuePair<string, object>("UnreachableEmailCount", unreachableEmailCount),
				new KeyValuePair<string, object>("CommunicationLimitCount", communicationLimitCount),
				new KeyValuePair<string, object>("DuplicateEmailCount", duplicateEmailCount),
				new KeyValuePair<string, object>("TemplateNotFoundCount", templateNotFoundCount),
				new KeyValuePair<string, object>("SendersDomainNotVerifiedCount", sendersDomainNotVerifiedCount),
				new KeyValuePair<string, object>("SendersNameNotValidCount", sendersNameNotValidCount),
				new KeyValuePair<string, object>("InvalidAddresseeCount", invalidAddresseeCount));
			MailingUtilities.Log.InfoFormat(
				"[CESMaillingProvider.ExecuteSendMessage]: Finished: BulkEmail.Id: {0}, SessionId: {1}",
				bulkEmail.Id, sessionId);
			if (sendMessageTaskData.ProcessedGroupsCounter == 0) {
				SetBulkEmailErrorStatus(bulkEmail);
				CreateReminding(bulkEmail, "CESNoRecipientsMsg");
				MailingUtilities.Log.InfoFormat("BulkEmail with Id: {0} Has no recipients.", bulkEmail.Id);
			}
		}

		[Obsolete("Will be removed after 7.17.3")]
		protected bool ExecuteSendMessage(IMessageInfo messageInfo) {
			var instatntMessageInfo = messageInfo as InstantMessageInfo;
			var bulkEmail = instatntMessageInfo.BulkEmail;
			RegisterSenderDomain(bulkEmail.SenderEmail);
			var emailMessage = InitEmailMessage(messageInfo);
			try {
				ServiceApi.SendMessage(emailMessage, bulkEmail.Id);
				HandleEmailResult(messageInfo.MessageRId, messageInfo.Recipients);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat("[ExecuteSendMessage]: Error while sending message", e);
				BulkEmailEventLogger.LogError(bulkEmail.Id, DateTime.UtcNow, GetLczStringValue("BatchSendEvent"), e,
					GetLczStringValue("SendToCloudErrorMsg"), UserConnection.CurrentUser.ContactId);
				return false;
			} finally {
				emailMessage = null;
			}
			return true;
		}

		[Obsolete("Will be removed after 7.17.3")]
		protected List<IMessageRecipientInfo> GetRecipients(IMailingAudienceDataSource audienceDataSource) {
			return audienceDataSource.GetAudience();
		}

		[Obsolete("Will be removed after 7.17.3")]
		protected Dictionary<IMessageRecipientInfo, rcpt_merge_var> GetMergeVars(CESMacrosHelper macrosHelper,
				IMailingTemplate template, IEnumerable<IMessageRecipientInfo> recipientsBatch, Guid bulkEmailId) {
			var audienceDataSource = InitializeAudienceDataSource(bulkEmailId, PreparationRecipientsBatchSize);
			Select recipientSelect = audienceDataSource.GetRecipientsSelectQuery();
			Dictionary<Guid, IMessageRecipientInfo> contactCollection = recipientsBatch.GroupBy(p => p.ContactId)
				.Select(p => p.First()).ToDictionary(p => p.ContactId, p => p);
			var contactIdSelect = new Select(UserConnection).Column("ContactId").From(recipientSelect).As("IdSubSelect");
			return macrosHelper.GetRecipientMergeVars(contactIdSelect, contactCollection, template.MacrosCollection);
		}

		protected override void PerformWaitBeforeSend(BulkEmail bulkEmail) {
			base.PerformWaitBeforeSend(bulkEmail);
			var sendDelayInSeconds =
				(int)Core.Configuration.SysSettings.GetValue(UserConnection, "MandrillMailingDelayInSeconds");
			bool isTriggeredCategory = bulkEmail.CategoryId == MailingConsts.TriggeredEmailBulkEmailCategoryId;
			if(!isTriggeredCategory) {
				Thread.Sleep(sendDelayInSeconds * 1000);
			}
		}

		[Obsolete("Will be removed after 7.17.3")]
		protected void UpdateResultCounter(IEnumerable<IMessageRecipientInfo> recipients,
				TypedCounter<MailingResponseCode> resultsCounter) {
			foreach (IMessageRecipientInfo recipient in recipients) {
				resultsCounter.Count((MailingResponseCode)recipient.InitialResponseCode);
			}
		}

		[Obsolete("Will be removed after 7.17.3")]
		protected bool SendBatch(SendMessageData messageData, int recipientCount) {
			MailingUtilities.Log.InfoFormat("[CESMaillingProvider.SendBatch]: Start: BulkEmailId: {0}. GroupId {1}.",
					messageData.BulkEmail.Id, messageData.BatchId);
			bool sendResult = false;
			try {
				DateTime startSendingTime = DateTime.UtcNow;
				Utilities.RetryOnFailure(() => ServiceApi.SendTemplate(messageData.EmailMessage,
					messageData.TemplateName, null, messageData.BulkEmail.Id));
				sendResult = true;
				BulkEmailEventLogger.LogInfo(messageData.BulkEmail.Id, startSendingTime,
					GetLczStringValue("SentBatchStatus"), GetLczStringValue("SentBatchStatusDescription"),
					UserConnection.CurrentUser.ContactId, messageData.BatchId);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.SendBatch]: Error while sending BulkEmail with Id: {0}. "
					+ "SessionId: {1}. GroupId {2}.", e, messageData.BulkEmail.Id, messageData.SessionId,
					messageData.BatchId);
				BulkEmailEventLogger.LogError(messageData.BulkEmail.Id, DateTime.UtcNow,
					GetLczStringValue("BatchSendEvent"), e, GetLczStringValue("BatchSendErrorMsg"),
					UserConnection.CurrentUser.ContactId, messageData.BulkEmail);
				sendResult = false;
			}
			return sendResult;
		}

		[Obsolete("Will be removed after 7.17.3")]
		protected void UpdateSendEmailIterationResult(SendMessageData messageData, IEnumerable<IMessageRecipientInfo> recipients,
				TypedCounter<MailingResponseCode> resultsCounter) {
			try {
				HandleEmailResult(messageData.BulkEmailRId, recipients);
				UpdateResultCounter(recipients, resultsCounter);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.SendBatch]: Error while handling result of BulkEmail with Id: {0}",
					e, messageData.BulkEmail.Id);
				BulkEmailEventLogger.LogError(messageData.BulkEmail.Id, DateTime.UtcNow,
					GetLczStringValue("BatchSendEvent"), e, GetLczStringValue("HandleResultErrorMsg"),
					UserConnection.CurrentUser.ContactId);
			} finally {
				messageData.EmailMessage = null;
			}
			MailingUtilities.Log.InfoFormat("[CESMaillingProvider.SendBatch]: Success: BulkEmailId: {0}. GroupId {1}.",
				messageData.BulkEmail.Id, messageData.BatchId);
		}

		[Obsolete("Will be removed after 7.17.3")]
		protected void AddContactToBulkEmailAudience(IMessageInfo messageInfo) {
			foreach (IMessageRecipientInfo recipientInfo in messageInfo.Recipients) {
				var insert = new Insert(UserConnection)
				.Into("BulkEmailTarget")
				.Set("BulkEmailId", Column.Parameter(messageInfo.MessageId))
				.Set("ContactId", Column.Parameter(recipientInfo.ContactId))
				.Set("EmailAddress", Column.Parameter(recipientInfo.EmailAddress))
				.Set("MandrillId", Column.Parameter(recipientInfo.Id))
				.Set("BulkEmailResponseId", Column.Parameter(MailingConsts.BulkEmailResponseReadyToSendId));
				insert.Execute();
			}
		}

		#endregion

		#region Methods: Public
		

		/// <summary>
		/// Starts sending of the message.
		/// </summary>
		/// <param name="messageInfo">Object that holds information about message.</param>
		/// <returns>Status of message.</returns>
		[Obsolete("Will be removed after 7.17.3")]
		public override MailingResponse SendMessage(IMessageInfo messageInfo) {
			messageInfo.PrepareMessage(UserConnection);
			if (!messageInfo.Validate()) {
				return new MailingResponse {
					StatusId = MailingConsts.BulkEmailStatusErrorId,
					Success = false
				};
			}
			bool sendMessageResult = false;
			try {
				PrepareInitialResponses(messageInfo.Recipients);
				sendMessageResult = ExecuteSendMessage(messageInfo);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat("[CESMailingProvider.SendMessage]: "
					+ "Error occurred while send message", e);
				return new MailingResponse {
					StatusId = MailingConsts.BulkEmailStatusErrorId,
					Success = false
				};
			}
			AddContactToBulkEmailAudience(messageInfo);
			messageInfo.UpdateMessageInfo(UserConnection, !sendMessageResult);
			return new MailingResponse {
				StatusId = MailingConsts.BulkEmailStatusFinishedId,
				Success = true
			};
		}

		#endregion

	}

	#endregion

}




