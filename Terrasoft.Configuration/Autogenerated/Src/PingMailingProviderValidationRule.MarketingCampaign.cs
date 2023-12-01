namespace Terrasoft.Configuration
{
	using Terrasoft.Core;

	/// <summary>
	/// Validation rule for mailing provider.
	/// </summary>
	public class PingMailingProviderValidationRule : IValidationRule
	{

		#region Fields: Private

		private string ErrorLczStringValue => "PingFailedMessage";
		private readonly MailingService _mailingService;
		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		public PingMailingProviderValidationRule(UserConnection userConnection, MailingService mailingService) {
			_mailingService = mailingService;
			_userConnection = userConnection;
		}

		#endregion

		#region Properties: Public

		public string Error { get; private set; }

		#endregion

		#region Methods: Public

		/// <summary>
		/// Validate mailing provider.
		/// </summary>
		public bool Validate() {
			if(!_mailingService.PingProvider()) {
				Error = ErrorLczStringValue.GetLczStringValue(_userConnection);
				return false;
			}
			return true;
		}

		#endregion

	}
}




