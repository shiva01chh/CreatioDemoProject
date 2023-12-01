﻿namespace Terrasoft.Core.Process
{

	using global::Common.Logging;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: ManualIncidentRegistrationFromEmailProcessMethodsWrapper

	/// <exclude/>
	public class ManualIncidentRegistrationFromEmailProcessMethodsWrapper : ProcessModel
	{

		public ManualIncidentRegistrationFromEmailProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask2Execute", ScriptTask2Execute);
		}

		#region Methods: Private

		private bool ScriptTask2Execute(ProcessExecutingContext context) {
			var mailbox = Get<Guid>("AutoGeneratedPageParameters.SupportMailbox");
			var dateFrom = Get<DateTime>("AutoGeneratedPageParameters.DateFrom");
			var dateTo = Get<DateTime>("AutoGeneratedPageParameters.DateTo");
			var userConnection = Get<UserConnection>("UserConnection");
			
			ProcessEmails(userConnection, dateFrom, dateTo, mailbox);
			
			return true;
		}

			private static readonly ILog _log = LogManager.GetLogger("IncidentRegistration");
			
			public void ProcessEmails(UserConnection userConnection, DateTime dateFrom, DateTime dateTo, Guid mailboxId) {
			try {
				_log.InfoFormat(@"Manual case registration from email: Process was started");
			
				var emailsList = GetActivityRecordsId(userConnection, dateFrom, dateTo, mailboxId);
				var activitySchema = userConnection.EntitySchemaManager.FindInstanceByName("Activity");
				foreach (var email in emailsList) {
					_log.InfoFormat(@"Manual case registration from email: Start register case for ActivityId:{0}", email.ActivityId);
					try {
						if (email.CaseId == default(Guid)) {
							var CaseIdFromCurrentChain = emailsList.FirstOrDefault(e =>
								e.ConversationId != default(Guid) && e.ConversationId == email.ConversationId && e.CaseId != default(Guid));
							if (CaseIdFromCurrentChain != null && CaseIdFromCurrentChain.CaseId != default(Guid)) {
								email.CaseId = CaseIdFromCurrentChain.CaseId;
								Entity entity = activitySchema.CreateEntity(userConnection);
								if (entity.FetchFromDB(email.ActivityId)) {
									entity.SetColumnValue("CaseId", email.CaseId);
									_log.InfoFormat(@"Manual case registration from email: Case wasn't created during this process activity with ActivityId:{0},
						                bound to CaseId:{1}", email.ActivityId, email.CaseId);
									entity.Save();
								}
							} else {
								email.CaseId = RegisterIncidentFromEmail(userConnection, email.ActivityId);
							}
							if (email.CaseId != default(Guid)) {
								var parentEmails = emailsList.Where(emailRecord =>
										emailRecord.ParentMessageId == email.Id);
								foreach (var parentEmail in parentEmails) {
									parentEmail.CaseId = email.CaseId;
									Entity entity = activitySchema.CreateEntity(userConnection);
									if (entity.FetchFromDB(parentEmail.ActivityId)) {
										entity.SetColumnValue("CaseId", email.CaseId);
										_log.InfoFormat(@"Manual case registration from email: Case was created during this process activity with ActivityId:{0},
						                set CaseId:{1}", parentEmail.ActivityId, parentEmail.CaseId);
										entity.Save(false);
									}
								}
							}
						}
					} catch (Exception ex) {
						_log.ErrorFormat(@"Manual case registration from email: Message: {0}, CallStack: {1}, InnerException: {2}",
							ex.Message, ex.StackTrace, ex.InnerException);
					}
					_log.InfoFormat(@"Manual case registration from email: End register case for ActivityId:{0}", email.ActivityId);
				}
				_log.InfoFormat(@"Manual case registration from email: Process was finished");
			} catch (Exception ex) {
				_log.ErrorFormat(@"Manual case registration from email: Message: {0}, CallStack: {1}, InnerException: {2}",
					ex.Message, ex.StackTrace, ex.InnerException);
			}
			}
			
			protected Guid RegisterIncidentFromEmail(UserConnection userConnection, Guid activityId) {
			Guid result = default(Guid);
			bool isNeedToCheckRegistrationEmailsInActivityParticipants = !userConnection.GetIsFeatureEnabled("RegisterCaseFromAnyEmail");
			bool isCategoryFromMailBoxEnabled = userConnection.GetIsFeatureEnabled("CategoryFromMailBox");
			bool getCategoryFromEmailSysSettings = Terrasoft.Core.Configuration.SysSettings.GetValue<bool>(userConnection,
						"DefineCaseCategoryFromMailBox", false);
			IncindentRegistrationMailboxFilter maiboxFilter = new IncindentRegistrationMailboxFilter(userConnection);
			if (isNeedToCheckRegistrationEmailsInActivityParticipants && !maiboxFilter.IsPresentRegistrationEmailsInActivity(activityId)) {
				_log.InfoFormat(@"Manual case registration from email: Incident registration mailboxes does not exists for ActivityId = {0}", activityId);
				return result;
			}
			var helper = ClassFactory.Get<IncidentRegistrationFromEmailHelper>(
				new ConstructorArgument("userConnection", userConnection));
			if (isCategoryFromMailBoxEnabled && getCategoryFromEmailSysSettings) {
				var supportMailBoxStore = ClassFactory.Get<CategoryFromSupportMailBox>(
				new ConstructorArgument("userConnection", userConnection));
				var categoryProvider = ClassFactory.Get<CategoryProvider>(
				new ConstructorArgument("supportMailBoxRepository", supportMailBoxStore));
				var categoryWrapper = ClassFactory.Get<CategoryProviderWrapper>(
				new ConstructorArgument("userConnection", userConnection));
				categoryWrapper.CategoryProvider = categoryProvider;
				helper.CategoryProviderWrapper = categoryWrapper;
			}
			helper.EmailSyncSession = Guid.Empty;
			result = helper.GetRegisterIncidentId(activityId);
			return result;
			}
			
			protected IList<EmailRegistrationData> GetActivityRecordsId(UserConnection userConnection,
				DateTime dateFrom, DateTime dateTo, Guid mailboxId) {
			var activityParticipantRolesList = new List<Guid> {
				CaseServiceConsts.ActivityParticipantRoleTo,
				CaseServiceConsts.ActivityParticipantRoleCc,
				CaseServiceConsts.ActivityParticipantRoleBcc
			};
			var selectQuery = new Select(userConnection).Distinct()
					.Column("emd", "ActivityId")
					.Column("a", "CaseId")
					.Column("cs", "IsFinal")
					.Column("emd", "Id")
					.Column("pc", "Id").As("ParentCaseId")
					.Column("csp", "IsFinal").As("IsParentCaseFinal")
					.Column("emd", "ParentMessageId")
					.Column("emd", "ConversationId")
					.Column("a", "SendDate")
				.From("EmailMessageData").As("emd")
					.InnerJoin("Activity").As("a")
						.On("a", "Id").IsEqual("emd", "ActivityId")
					.InnerJoin("EmailSendStatus").As("ess")
						.On("ess", "Id").IsEqual("a", "EmailSendStatusId")
					.InnerJoin("MailboxForIncidentRegistration").As("im")
						.On("im", "MailboxSyncSettingsId").IsEqual("emd", "MailboxSyncSettings")
					.LeftOuterJoin("Case").As("c").
						On("c", "Id").IsEqual("a", "CaseId")
					.LeftOuterJoin("CaseStatus").As("cs")
						.On("c", "StatusId").IsEqual("cs", "Id")
					.LeftOuterJoin("Case").As("pc").
						On("pc", "Id").IsEqual("c", "ParentCaseId")
					.LeftOuterJoin("CaseStatus").As("csp")
						.On("pc", "StatusId").IsEqual("csp", "Id")
				.Where("ess", "Code").IsEqual(Column.Const("Sended"))
					.And("emd", "RoleId").In(Column.Parameters(activityParticipantRolesList))
					.And("a", "ServiceProcessed").IsEqual(Column.Const(false))
					.And("a", "SendDate").IsGreaterOrEqual(Column.Parameter(dateFrom))
					.And("a", "SendDate").IsLessOrEqual(Column.Parameter(dateTo))
					.And("im", "Id").IsEqual(Column.Parameter(mailboxId))
				.OrderByAsc("a", "SendDate") as Select;
			IList<EmailRegistrationData> result = new List<EmailRegistrationData>();
			selectQuery.BuildParametersAsValue = true;
			_log.DebugFormat(@"Manual case registration from email: Select activity for registration Sql text {0}", selectQuery.GetSqlText());
			using (DBExecutor dbExec = userConnection.EnsureDBConnection()) {
				var casesToReopen = new List<ActivityCaseValuePair>();
				using (IDataReader reader = selectQuery.ExecuteReader(dbExec)) {
					while (reader.Read()) {
						bool isCaseEmptyOrFinal = reader.GetColumnValue<Guid>("CaseId") == default(Guid) || reader.GetColumnValue<bool>("IsFinal") == true;
						bool isParentCaseEmptyOrFinal = reader.GetColumnValue<Guid>("ParentCaseId") == default(Guid) || reader.GetColumnValue<bool>("IsParentCaseFinal") == true;
						_log.InfoFormat(@"Manual case registration from email: isCaseEmptyOrFinal {0}, isParentCaseEmptyOrFinal {1}", isCaseEmptyOrFinal, isParentCaseEmptyOrFinal);
						if (isCaseEmptyOrFinal && isParentCaseEmptyOrFinal) {
							Guid activityId = reader.GetColumnValue<Guid>("ActivityId");
							var emailMessage = new EmailRegistrationData(activityId, reader.GetColumnValue<Guid>("Id"),
							 reader.GetColumnValue<Guid>("ParentMessageId"));
							emailMessage.ConversationId = reader.GetColumnValue<Guid>("ConversationId");
							result.Add(emailMessage);
							_log.InfoFormat(@"Manual case registration from email: Add new activity with ActivityId:{0} in registration collection", activityId);
						} else {
							casesToReopen.Add(new ActivityCaseValuePair() {
								CaseId = isCaseEmptyOrFinal ? reader.GetColumnValue<Guid>("ParentCaseId") : reader.GetColumnValue<Guid>("CaseId"),
								ActivityId = reader.GetColumnValue<Guid>("ActivityId")
							});
						}
					}
				}
				foreach (var @case in casesToReopen) {
					var schema = userConnection.EntitySchemaManager.FindInstanceByName("Activity");
					Entity entity = schema.CreateEntity(userConnection);
					if (entity.FetchFromDB(@case.ActivityId)) {
						entity.SetColumnValue("CaseId", null);
						entity.SetColumnValue("CaseId", @case.CaseId);
						entity.Save(false);
						_log.InfoFormat(@"Manual case registration from email: Reopen case by CaseId = {0}. ActivityId = {1}", @case.CaseId, @case.ActivityId);
					}
				}
			}
			return result;
			}

		#endregion

	}

	#endregion

}
