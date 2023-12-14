﻿namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Polly;
	using Terrasoft.Common;
	using Terrasoft.Configuration.CES;
	using Terrasoft.Configuration.CESModels;
	using Terrasoft.Configuration.DynamicContent;
	using Terrasoft.Configuration.DynamicContent.Models;
	using Terrasoft.Configuration.Mailing;
	using Terrasoft.Configuration.Utils;
	using Terrasoft.Core.Factories;
	using Terrasoft.Configuration.Marketing.Utilities;
	using CoreSysSettings = Terrasoft.Core.Configuration.SysSettings;

	#region Class: PreparingTemplateState

	public class PreparingTemplateState : MailingState
	{

		#region Constants: Private

		private const int MailingMaxTemplateSize = 5242880;
		private const string BulkEmailIdPropertyName = "bulkEmailId";

		#endregion

		#region Fields: Private

		private BulkEmailMacroParser _bulkEmailMacroParser;
		private string _linkedEntitySchemaName;
		private CESMailingTemplateFactory _templateFactory;
		private TemplateSizeValidator _validator;
		private static readonly int _retryCount = 3;
		private static readonly int _retryDelay  = 60;
		private readonly Context _retryTemplateSendContext;
		private readonly Context _retryThrottlingScheduleSendContext;
		private readonly Policy _retryPolicy;

		#endregion

		#region Constructors: Public

		public PreparingTemplateState() {
			_retryPolicy = Policy.Handle<Exception>().WaitAndRetry(_retryCount,
				retryAttempt => TimeSpan.FromSeconds(_retryDelay),
				(exception, timeSpan, retryIteration, context) => OnRetry(context, retryIteration, exception));
			_retryTemplateSendContext = new Context("RetryTemplateSendContext");
			_retryThrottlingScheduleSendContext = new Context("RetryThrottlingScheduleSendContext");
		}

		#endregion

		#region Properties: Protected

		protected override string ErrorMessageStringCode => "CESTemplateFailsMsg";

		protected override string EventLczStringCode => "BatchSendEvent";

		#endregion

		#region Properties: Public

		public BulkEmailMacroParser BulkEmailMacroParser {
			get => _bulkEmailMacroParser ?? (_bulkEmailMacroParser = GetMacroParser());
			set => _bulkEmailMacroParser = value;
		}

		public CESMailingTemplateFactory TemplateFactory {
			get => _templateFactory ?? (_templateFactory = new CESMailingTemplateFactory());
			set => _templateFactory = value;
		}

		public TemplateSizeValidator Validator {
			get => _validator ?? (_validator = new TemplateSizeValidator());
			set => _validator = value;
		}

		public override Guid[] AvailableForExecutionStatuses => new[] { MailingConsts.BulkEmailStatusStartsId };

		#endregion

		#region Methods: Private

		private static void OnRetry(Context context, int retryIteration, Exception exception) {
			MailingUtilities.Log.WarnFormat(
				$"[{context.ExecutionKey}]: Error while preparing template. Email: {context[BulkEmailIdPropertyName]} " +
				$"and iteration {retryIteration - 1}. ", exception);
		}

		private IEnumerable<IMailingTemplate> CreateTemplates(BulkEmail bulkEmail, BulkEmailMacroParser macroParser,
			IEnumerable<int> replicaMasksToProcess = null) {
			var templateRepository = new DCTemplateRepository<DCTemplateModel>(Context.UserConnection);
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

		private IEnumerable<IMailingTemplate> CreateTemplates(BulkEmail bulkEmail, BulkEmailMacroParser macroParser,
			IEnumerable<DCReplicaModel> replicasToProcess) {
			if (replicasToProcess == null) {
				var templateCollection = new List<IMailingTemplate>();
				IMailingTemplate mailingTemplate =
					TemplateFactory.CreateInstance(Context.UserConnection, bulkEmail, macroParser);
				mailingTemplate.Init();
				templateCollection.Add(mailingTemplate);
				return templateCollection;
			}
			return TemplateFactory.CreateInstances(Context.UserConnection, bulkEmail, replicasToProcess, macroParser);
		}

		private BulkEmailMacroComposer GetMacroComposer(BulkEmail bulkEmail) {
			var bulkEmailMacroComposer = ClassFactory.Get<BulkEmailMacroComposer>(
				new ConstructorArgument("userConnection", Context.UserConnection),
				new ConstructorArgument("bulkEmail", bulkEmail),
				new ConstructorArgument("linkedEntitySchemaName", _linkedEntitySchemaName));
			bulkEmailMacroComposer.MacrosHelper.UserConnection = Context.UserConnection;
			return bulkEmailMacroComposer;
		}

		private BulkEmailMacroParser GetMacroParser() {
			var macrosHelper = ClassFactory.Get<MacrosHelperV2>();
			macrosHelper.UserConnection = Context.UserConnection;
			return ClassFactory.Get<BulkEmailMacroParser>(new ConstructorArgument("macrosHelper", macrosHelper),
				new ConstructorArgument("linkedEntitySchemaName", _linkedEntitySchemaName));
		}

		private IEnumerable<DCReplicaModel> GetReplicasByMasks(DCTemplateModel template,
			IEnumerable<int> replicaMasks = null) {
			var replicas = template.Replicas;
			if (replicaMasks != null && replicaMasks.Any()) {
				replicas = replicas.Where(x => replicaMasks.Contains(x.Mask));
			}
			return replicas;
		}

		private ThrottlingScheduleRequest GetThrottlingScheduleRequest(BulkEmail bulkEmail) {
			var throttlingSchedule = new ThrottlingSchedule {
				DelayPerEmail = bulkEmail.DelayBetweenEmail,
				EmailsPerDay = bulkEmail.DailyLimit
			};
			return new ThrottlingScheduleRequest {
				EmailId = bulkEmail.Id,
				StrategyId = bulkEmail.ThrottlingMode.Code,
				Schedule = new[] { throttlingSchedule }
			};
		}

		private void InitLinkedEntitySchemaName(Guid audienceSchemaId) {
			var audienceSchema = new BulkEmailAudienceSchema(Context.UserConnection);
			audienceSchema.FetchFromDB("Id", audienceSchemaId, new[] { "EntityObject" });
			_linkedEntitySchemaName = Context.UserConnection.EntitySchemaManager
				.GetInstanceByUId(audienceSchema.EntityObjectId).Name;
			Context.LinkedEntitySchemaName = _linkedEntitySchemaName;
		}

		private void PrepareRecipientsMacros(BulkEmail bulkEmail, IEnumerable<IMailingTemplate> templateReplicas) {
			if (!CoreSysSettings.GetValue(Context.UserConnection, "SaveEmailRecipientMacros", true)) {
				return;
			}
			BulkEmailMacroComposer macroComposer = GetMacroComposer(bulkEmail);
			foreach (IMailingTemplate replica in templateReplicas.Where(x => x.MacrosCollection.Any())) {
				macroComposer.TrackedAliases = (replica as CESMailingTemplate)?.TrackedAliases;
				Guid replicaId = (replica as IMailingTemplateReplica).ReplicaId;
				macroComposer.PrepareMacros(replicaId, replica.MacrosCollection, CanHandle);
			}
		}

		private void SaveTemplate(IMailingTemplate template, BulkEmail bulkEmail) {
			if (!Validator.ValidateTemplateSize(template, out int templateSize)) {
				throw new Exception(string.Format("Template {0} have size {1} more than {2}.", template.Name,
					MailingMaxTemplateSize));
			}
			var templateReplica = template as IMailingTemplateWithHeaders;
			AddTemplateRequest addTemplateRequest = GetAddTemplateRequest(bulkEmail, templateReplica);
			_retryTemplateSendContext[BulkEmailIdPropertyName] = bulkEmail.Id;
			_retryPolicy.Execute(() => Context.ServiceApi.AddTemplate(addTemplateRequest), _retryTemplateSendContext);
		}

		private void SetThrottlingSchedule(BulkEmail bulkEmail) {
			if (bulkEmail.ThrottlingModeId != MailingConsts.ManualLimitThrottlingMode) {
				return;
			}
			ThrottlingScheduleRequest throttlingScheduleRequest = GetThrottlingScheduleRequest(bulkEmail);
			_retryThrottlingScheduleSendContext[BulkEmailIdPropertyName] = bulkEmail.Id;
			_retryPolicy.Execute(() => Context.ServiceApi.SetThrottlingSchedule(throttlingScheduleRequest),
				_retryThrottlingScheduleSendContext);
		}

		private AddTemplateRequest GetAddTemplateRequest(BulkEmail bulkEmail,
			IMailingTemplateWithHeaders templateReplica) {
			var addTemplateRequest = new AddTemplateRequest {
				Name = templateReplica.Name,
				FromEmail = templateReplica.SenderEmail,
				FromName = templateReplica.SenderName,
				Subject = templateReplica.TemplateSubject,
				Code = templateReplica.Content,
				Text = string.Empty,
				EmailId = bulkEmail.Id,
				Images = templateReplica.InlineImages.ToCESImage(),
				ReplicaChecksum = templateReplica.Checksum,
				ReplicaId = templateReplica.ReplicaId.ToString(),
				ExpirationDate = bulkEmail.ExpirationDate.ToUniversalTime(),
				DeliveryScheduleDays = bulkEmail.DeliveryScheduleDays,
				BusinessTimeStart = bulkEmail.BusinessTimeStart.TimeOfDay.Ticks,
				BusinessTimeEnd = bulkEmail.BusinessTimeEnd.TimeOfDay.Ticks,
				TargetTimeZoneId = Context.UserConnection.CurrentUser.TimeZone.Id,
				ProviderName = bulkEmail.ProviderName
			};
			if (bulkEmail.PriorityId != Guid.Empty) {
				addTemplateRequest.Priority = bulkEmail.Priority.Priority;
			}
			if (bulkEmail.ThrottlingModeId != Guid.Empty && bulkEmail.ThrottlingQueueId != Guid.Empty) {
				addTemplateRequest.SendingStrategyId = bulkEmail.ThrottlingMode.Code;
				addTemplateRequest.ScopeName = bulkEmail.ThrottlingQueue.Code;
			}
			if (bulkEmail.TimeZoneId != Guid.Empty) {
				addTemplateRequest.TargetTimeZoneId = bulkEmail.TimeZone.Code;
			}
			return addTemplateRequest;
		}

		#endregion

		#region Methods: Protected

		protected override MailingStateExecutionResult HandleStepInternal() {
			var bulkEmail = (BulkEmail)Context.BulkEmailEntity;
			if (!bulkEmail.AudienceSchemaId.IsEmpty()) {
				InitLinkedEntitySchemaName(bulkEmail.AudienceSchemaId);
			}
			var templateReplicas = CreateTemplates(bulkEmail, BulkEmailMacroParser);
			foreach (IMailingTemplate template in templateReplicas) {
				SaveTemplate(template, bulkEmail);
			}
			SetThrottlingSchedule(bulkEmail);
			PrepareRecipientsMacros(bulkEmail, templateReplicas);
			Context.MailingTemplates = templateReplicas;
			return new MailingStateExecutionResult(this.GetType()) {
				Success = true,
				Status = MailingStateExecutionStatus.Done
			};
		}

		#endregion

	}

	#endregion

}





