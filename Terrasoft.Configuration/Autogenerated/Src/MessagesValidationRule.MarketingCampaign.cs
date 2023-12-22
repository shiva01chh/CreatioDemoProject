namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;

	/// <summary>
	/// Validation rule for bulk email massages.
	/// </summary>
	public class MessagesValidationRule : ISpecificValidationRule<Guid>
	{

		#region Fields: Private

		private readonly MailingService _mailingService;
		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		public MessagesValidationRule(MailingService mailingService, UserConnection userConnection) {
			_mailingService = mailingService;
			_userConnection = userConnection;
		}

		#endregion

		#region Properties: Public

		public string Error { get; private set; }

		#endregion

		#region Methods: Private

		private IEnumerable<Guid> GetBulkEmailIdentifiers(Guid splitTestId) {
			var resultCollection = new List<Guid>();
			var bulkEmailSelect = new Select(_userConnection).Column("Id").From(nameof(BulkEmail)).Where("SplitTestId")
				.IsEqual(Column.Parameter(splitTestId)) as Select;
			bulkEmailSelect.SpecifyNoLockHints();
			bulkEmailSelect.ExecuteReader(reader => {
				resultCollection.Add(reader.GetColumnValue<Guid>("Id"));
			});
			return resultCollection;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Validate bulk email messages
		/// </summary>
		/// <param name="splitTestId">Unique identifier of split test to validate</param>
		public bool Validate(Guid splitTestId) {
			IEnumerable<Guid> identifiers = GetBulkEmailIdentifiers(splitTestId);
			ConfigurationServiceResponse response = _mailingService.ValidateMessages(identifiers.ToArray());
			if(!response.Success) {
				Error = response.ErrorInfo.Message;
				return false;
			}
			return true;
		}

		#endregion

	}
}













