namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	using System.Text;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;

	/// <summary>
	/// Validation rule for bulk email statuses.
	/// </summary>
	public class BulkEmailStatusesValidationRule : ISpecificValidationRule<Guid>
	{

		#region Fields: Private

		private string MessageDraftEmailNamesAny => "StartTestEmailDraftMessage";
		private string MessageWithIncorrectStatus => "StartTestEmailAlreadyRunMessage";
		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		public BulkEmailStatusesValidationRule(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Properties: Public

		public string Error { get; private set; }

		#endregion

		#region Methods: Private

		private IEnumerable<string> GetBulkEmailsNamesInDraftStatus(Guid splitTestId) {
			var selectCount = new Select(_userConnection).Column("Name").From("BulkEmail").Where("SplitTestId")
				.IsEqual(Column.Parameter(splitTestId)).And("StatusId")
				.IsEqual(Column.Parameter(MarketingConsts.BulkEmailStatusDraftId)) as Select;
			selectCount.SpecifyNoLockHints();
			var result = new List<string>();
			using(DBExecutor dbExecutor = _userConnection.EnsureDBConnection()) {
				using(IDataReader reader = selectCount.ExecuteReader(dbExecutor)) {
					int uidColumnIndex = reader.GetOrdinal("Name");
					while(reader.Read()) {
						string name = reader.GetString(uidColumnIndex);
						result.Add(name);
					}
				}
			}
			return result;
		}

		private string GetFormattedNamesForMessage(IEnumerable<string> draftEmailNames) {
			var formattedNames = new StringBuilder();
			var nameSplitter = ", ";
			foreach(string draftEmailName in draftEmailNames) {
				formattedNames.Append($"\"{draftEmailName}\"{nameSplitter}");
			}
			formattedNames.Remove(formattedNames.Length - nameSplitter.Length, nameSplitter.Length);
			return formattedNames.ToString();
		}

		private bool HasBulkEmailsWithIncorrectStatus(Guid splitTestId) {
			var selectCount = new Select(_userConnection).Column(Func.Count("Id")).From("BulkEmail")
				.Where("SplitTestId").IsEqual(Column.Parameter(splitTestId)).And().OpenBlock("StatusId")
				.IsNotEqual(Column.Parameter(MarketingConsts.BulkEmailStatusPlannedId)).And("StatusId")
				.IsNotEqual(Column.Parameter(MarketingConsts.BulkEmailStatusStartPlanedId)).CloseBlock() as Select;
			selectCount.SpecifyNoLockHints();
			var count = selectCount.ExecuteScalar<int>();
			return count > 0;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Validate bulk email statuses
		/// </summary>
		/// <param name="splitTestId">Unique identifier of split test to validate</param>
		public bool Validate(Guid splitTestId) {
			IEnumerable<string> draftEmailNames = GetBulkEmailsNamesInDraftStatus(splitTestId);
			if(draftEmailNames.Any()) {
				string statusErrorMessage = MessageDraftEmailNamesAny.GetLczStringValue(_userConnection);
				string formattedNames = GetFormattedNamesForMessage(draftEmailNames);
				Error = string.Format(statusErrorMessage, formattedNames);
				return false;
			}
			if(HasBulkEmailsWithIncorrectStatus(splitTestId)) {
				string statusErrorMessage = MessageWithIncorrectStatus.GetLczStringValue(_userConnection);
				Error = statusErrorMessage;
				return false;
			}
			return true;
		}

		#endregion

	}
}













