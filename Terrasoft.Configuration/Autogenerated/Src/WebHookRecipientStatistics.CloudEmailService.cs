namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	using Core;
	using Core.DB;
	using Terrasoft.Common;
	using Terrasoft.Core.Entities;

	#region Class: RecipientStatistics

	public class RecipientStatistics : BaseWebHook
	{
		#region Properties: Private

		private UserConnection UserConnection {
			get;
			set;
		}

		#endregion

		#region Properties: Public

		public Guid RecipientUId {
			get;
			set;
		}

		public Guid EmailId {
			get;
			set;
		}

		private int _responseCode;
		public string ResponseCode {
			get => _responseCode.ToString();
			set => _responseCode = Convert.ToInt32(value);
		}
		
		public string ResponseReason {
			get;
			set;
		}
		
		public string ResponseDetails {
			get;
			set;
		}

		public int Opens {
			get;
			set;
		}

		public int Clicks {
			get;
			set;
		}
		
		public string ProviderName {
			get;
			set;
		}

		#endregion

		#region Methods: Private

		private void UpdateNonActualContactCommunication(Guid nonActualReasonId, string recipientEmail) {
			var emailUpper = recipientEmail.ToUpper();
			var update = new Update(UserConnection, "ContactCommunication")
				.Set("NonActual", Column.Parameter(true))
				.Set("NonActualReasonId", Column.Parameter(nonActualReasonId))
				.Set("DateSetNonActual", Column.Parameter(DateTime.UtcNow))
				.Where(Func.Upper("Number")).IsEqual(Column.Parameter(emailUpper))
				.And("CommunicationTypeId").IsEqual(Column.Parameter(Guid.Parse(CommunicationTypeConsts.EmailId))) as Update;
			update.WithHints(new RowLockHint());
			update.Execute();
		}

		private Select GetContactsWithActualCommunicationExistsSelect(string recipientEmail) {
			var upperEmail = recipientEmail.ToUpper();
			var communicationExistsSelect = new Select(UserConnection).Column(Column.Parameter(1))
				.From("ContactCommunication").As("cmn")
				.Where(Func.Upper("cmn", "Number")).IsNotEqual(Column.Parameter(upperEmail))
				.And("cmn", "CommunicationTypeId").IsEqual(Column.Parameter(Guid.Parse(CommunicationTypeConsts.EmailId)))
				.And("cmn", "NonActual").IsEqual(Column.Parameter(false))
				.And("cmn", "ContactId").IsEqual("c", "Id")
				.And("c", "Email").IsEqual(Column.Parameter(recipientEmail)) as Select;
			communicationExistsSelect.SpecifyNoLockHints();
			var hardBouncedContacts = new Select(UserConnection)
				.Column("Id").As("HardBouncedContactId")
				.From("Contact").As("c")
				.Where().Exists(communicationExistsSelect) as Select;
			hardBouncedContacts.SpecifyNoLockHints();
			return hardBouncedContacts;
		}

		private void SetActualEmailToContactById(Guid contactId, string recipientEmail) {
			var upperEmail = recipientEmail.ToUpper();
			var emailSubSelect = new Select(UserConnection).Top(1)
				.Column("Number")
				.From("ContactCommunication").As("cc")
				.Where("cc", "ContactId").IsEqual(Column.Parameter(contactId))
				.And(Func.Upper("cc", "Number")).IsNotEqual(Column.Parameter(upperEmail))
				.And("cc", "NonActual").IsEqual(Column.Parameter(false))
				.And("cc", "CommunicationTypeId").IsEqual(Column.Parameter(Guid.Parse(CommunicationTypeConsts.EmailId)))
				.OrderByDesc("cc", "ModifiedOn") as Select;
			emailSubSelect.SpecifyNoLockHints();
			var update = new Update(UserConnection, "Contact")
				.Set("Email", emailSubSelect)
				.Where("Id").IsEqual(Column.Parameter(contactId)) as Update;
			update.WithHints(new RowLockHint());
			update.Execute();
		}

		private IEnumerable<Guid> GetLastReasons(int reasonsCount) {
			var emailAddress = GetRecipientEmailAddress().ToUpper();
			var select = new Select(UserConnection)
				.Top(reasonsCount)
				.Column("details", "ReasonId").As("ReasonId")
				.From("BulkEmailTarget", "bet")
				.LeftOuterJoin("BulkEmailResponseDetails").As("details")
					.On("details", "Id").IsEqual("bet", "ResponseDetailsId")
				.LeftOuterJoin("BulkEmailResponseReason").As("reason")
					.On("details", "ReasonId").IsEqual("reason", "Id")
				.Where(Func.Upper("bet", "EmailAddress")).IsEqual(Column.Parameter(emailAddress))
				.OrderByDesc("bet", "ModifiedOn") as Select;
			select.SpecifyNoLockHints();
			return select.ExecuteEnumerable(r => r.GetColumnValue<Guid>("ReasonId"));
		}

		private void SetActualEmailToContact(string recipientEmail) {
			var possibleActualContactsSelect = GetContactsWithActualCommunicationExistsSelect(recipientEmail);
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader reader = possibleActualContactsSelect.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						var contactId = reader.GetColumnValue<Guid>("HardBouncedContactId");
						SetActualEmailToContactById(contactId, recipientEmail);
					}
				}
			}
		}

		private void UpdateNonActualContactEmail(string recipientEmail) {
			var upperEmail = recipientEmail.ToUpper();
			var update = new Update(UserConnection, "Contact")
				.Set("IsNonActualEmail", Column.Parameter(true))
				.Where(Func.Upper("Email")).IsEqual(Column.Parameter(upperEmail)) as Update;
			update.WithHints(new RowLockHint());
			update.Execute();
		}

		private string GetRecipientEmailAddress() {
			var select = new Select(UserConnection)
				.Column("EmailAddress")
				.From("BulkEmailTarget")
				.Where("MandrillId").IsEqual(Column.Parameter(RecipientUId)) as Select;
			select.SpecifyNoLockHints();
			return select.ExecuteScalar<string>();
		}

		private void HandleSpamResponse() {
			var recipientEmail = GetRecipientEmailAddress();
			var subSelectQuery = new Select(UserConnection)
				.Column(Column.Parameter(1))
				.From("ContactCommunication")
				.Where("ContactId").IsEqual("Contact", "Id")
				.And("CommunicationTypeId")
				.IsEqual(Column.Parameter(Guid.Parse(CommunicationTypeConsts.EmailId)))
				.And("Number").IsEqual(Column.Parameter(recipientEmail)) as Select;
			subSelectQuery.SpecifyNoLockHints();
			var update = new Update(UserConnection, "Contact")
				.Set("DoNotUseEmail", Column.Parameter(true))
				.Where()
				.Exists(subSelectQuery) as Update;
			update.WithHints(new RowLockHint());
			update.Execute();
		}

		private void HandleNonActualEmailState(Guid nonActualReasonId) {
			var recipientEmail = GetRecipientEmailAddress();
			UpdateNonActualContactCommunication(nonActualReasonId, recipientEmail);
			SetActualEmailToContact(recipientEmail);
			UpdateNonActualContactEmail(recipientEmail);
		}

		private int GetOpensCount() {
			return Opens == 0 && Clicks > 0 ? 1 : Opens;
		}

		private void HandlePersonalResponse() {
			var opensCount = GetOpensCount();
			var update = GetBETUpdateQuery(opensCount);
			HandleResponseReason(update);
			update.WithHints(new RowLockHint());
			update.Execute();
		}

		private void HandleResponseReason(Update update) {
			Guid? responseDetailsIdToSave = null;
			if (!string.IsNullOrEmpty(ResponseReason)) {
				BulkEmailResponseDetails currentResponseDetails = GetCurrentResponseDetailsFromDB();
				if (GetIsLeaveOldDetails(currentResponseDetails)) {
					return;
				}
				responseDetailsIdToSave = SaveOrUpdateResponseDetails(currentResponseDetails);
			}
			if (responseDetailsIdToSave.HasValue) {
				update.Set("ResponseDetailsId", Column.Parameter(responseDetailsIdToSave));
			} else {
				QueryColumnExpression nullParameter =
					Column.Parameter(DBNull.Value, new GuidDataValueType(UserConnection.DataValueTypeManager));
				update.Set("ResponseDetailsId", nullParameter);
			}
		}

		private bool GetIsLeaveOldDetails(BulkEmailResponseDetails responseDetails) {
			if (responseDetails.LoadState != EntityLoadState.NotLoaded) {
				var reasonId = responseDetails.GetTypedColumnValue<Guid>("ReasonId");
				var reason = new BulkEmailResponseReason(UserConnection);
				reason.FetchFromDB(reasonId);
				var reasonName = reason.GetTypedColumnValue<string>("Name");
				return string.Equals(reasonName, ResponseReason, StringComparison.InvariantCultureIgnoreCase) 
					&& string.IsNullOrEmpty(ResponseDetails);
			}
			return false;
		}

		private BulkEmailResponseDetails GetCurrentResponseDetailsFromDB() {
			var bet = new BulkEmailTarget(UserConnection);
			var responseDetails = new BulkEmailResponseDetails(UserConnection);
			var responseExists = bet.FetchFromDB("MandrillId", RecipientUId);
			if (responseExists) {
				var detailsId = bet.GetTypedColumnValue<Guid>("ResponseDetailsId");
				responseDetails.FetchFromDB(detailsId);
			}
			return responseDetails;
		}

		private Update GetBETUpdateQuery(int opensCount) {
			var responseId = BulkEmailResponseMapping.GetResponseIdByCode(UserConnection, _responseCode);
			return new Update(UserConnection, "BulkEmailTarget")
				.Set("ProviderName", Column.Parameter(ProviderName))
				.Set("Opens", Column.Parameter(opensCount))
				.Set("Clicks", Column.Parameter(Clicks))
				.Set("ModifiedOn", Column.Parameter(EventDate))
				.Set("BulkEmailResponseId", Column.Parameter(responseId))
				.Where("MandrillId").IsEqual(Column.Parameter(RecipientUId))
					.And("ModifiedOn").IsLess(Column.Parameter(EventDate)) as Update;
		}

		private Guid SaveOrUpdateResponseDetails(BulkEmailResponseDetails currentDetails) {
			Guid detailsId;
			var reason = GetResponseReasonByName(ResponseReason);
			var responseDetails = ResponseDetails?.Substring(0, Math.Min(ResponseDetails.Length, 500)) ?? string.Empty;
			if (currentDetails.LoadState == EntityLoadState.NotLoaded) {
				detailsId = Guid.NewGuid();
				new Insert(UserConnection)
					.Into("BulkEmailResponseDetails")
					.Set("Id", Column.Parameter(detailsId))
					.Set("Details", Column.Parameter(responseDetails))
					.Set("ReasonId", Column.Parameter(reason.Id))
					.Set("ModifiedOn", Column.Parameter(EventDate))
					.Execute();
			} else {
				detailsId = currentDetails.Id;
				new Update(UserConnection, "BulkEmailResponseDetails")
					.Set("Details", Column.Parameter(responseDetails))
					.Set("ReasonId", Column.Parameter(reason.Id))
					.Set("ModifiedOn", Column.Parameter(EventDate))
					.Where("Id").IsEqual(Column.Parameter(detailsId))
					.Execute();
			}
			return detailsId;
		}
		
		private BulkEmailResponseReason GetResponseReasonByName(string reasonName) {
			reasonName = reasonName ?? ResponseReason;
			var upperReasonName = reasonName.ToUpper();
			var query = new Select(UserConnection)
				.Column("Id")
				.From("BulkEmailResponseReason")
				.Where(Func.Upper("Name")).IsEqual(Column.Parameter(upperReasonName)) as Select;
			var responseReasonId = query.ExecuteScalar<Guid>();
			if (responseReasonId == default) {
				ResponseDetails = string.IsNullOrEmpty(ResponseDetails)
					? "Non known reason provided: " + reasonName
					: $"Reason: {reasonName}. Details: {ResponseDetails}";
				responseReasonId = MailingConsts.OtherResponseReason;
			}
			var reason = new BulkEmailResponseReason(UserConnection);
			reason.FetchFromDB(responseReasonId);
			return reason;
		}

		private void HandleHardBounceResponse() {
			if (string.IsNullOrEmpty(ResponseReason)) {
				return;
			}
			var reason = GetResponseReasonByName(ResponseReason);
			if (reason.CountToSetIsNonActualEmail == -1) {
				return;
			}
			var reasonThreshold = reason.CountToSetIsNonActualEmail;
			var lastResponses = GetLastReasons(reasonThreshold);
			if (lastResponses.IsNotEmpty()
				&& lastResponses.Count() == reasonThreshold
				&& lastResponses.All(x => x == reason.Id)) {
				HandleNonActualEmailState(MailingConsts.HardBounceNonActualReasonId);
			}
		}

		private void HandleInvalidEmailResponse() {
			HandleNonActualEmailState(MailingConsts.InvalidEmailNonActualReasonId);
		}

		#endregion

		#region Methods: Public

		public override string GetGroupKey() {
			return base.GetGroupKey() + RecipientUId.ToString();
		}

		public override void HandleWebHook(UserConnection userConnection) {
			this.UserConnection = userConnection;
			HandlePersonalResponse();
			var handlersByResponseCode = new Dictionary<int, Action> {
				{(int)MailingResponseCode.Spam, HandleSpamResponse},
				{(int)MailingResponseCode.HardBounce, HandleHardBounceResponse},
				{(int)MailingResponseCode.Invalid, HandleInvalidEmailResponse}
			};
			if (handlersByResponseCode.TryGetValue(_responseCode, out Action handler)) {
				handler();
			}
		}

		#endregion

	}

	#endregion

}












