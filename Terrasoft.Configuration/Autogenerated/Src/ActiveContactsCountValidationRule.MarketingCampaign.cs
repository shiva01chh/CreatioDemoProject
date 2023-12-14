namespace Terrasoft.Configuration
{
	using Terrasoft.Core;

	/// <summary>
	/// Validation rule of active contacts count.
	/// </summary>
	public class ActiveContactsCountValidationRule : IValidationRule
	{

		#region Fields: Private

		private string ErrorLczStringValue => "NotEnoughActiveContactsMsg";
		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		public ActiveContactsCountValidationRule(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Properties: Public

		public string Error { get; private set; }

		#endregion

		#region Methods: Public

		/// <summary>
		/// Validate active contacts count.
		/// </summary>
		public bool Validate() {
			LicConditionModel licInfo = ActiveContactsHelper.GetActiveContactsLicInfo(_userConnection);
			if(licInfo.MaxConditionCount == 0 || licInfo.Count > licInfo.MaxConditionCount) {
				Error = ErrorLczStringValue.GetLczStringValue(_userConnection);
				return false;
			}
			return true;
		}

		#endregion

	}
}






