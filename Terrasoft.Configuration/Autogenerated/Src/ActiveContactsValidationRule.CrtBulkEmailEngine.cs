namespace Terrasoft.Configuration
{
	using Core;

	/// <summary>
	/// Represents the active contact validation rule.
	/// </summary>
	public class ActiveContactsValidationRule : IMailingStateValidationRule
	{

		#region Consts: Private

		private const string LicCountNotEnoughMsgCode = "ErrorCountContactsMsg";

		#endregion
		
		#region Methods: Public

		/// <summary>
		///	Execute validation for active contact rule.
		/// </summary>
		/// <param name="state">The state for validation.</param>
		/// <returns>Instance of <see cref="ValidationResponse"/> represents validation results.</returns>
		public ValidationResponse Validate(MailingState state) {
			MailingContext context = state.Context;
			LicConditionModel licInfo =
				ActiveContactsHelper.GetActiveContactsLicInfo(context.UserConnection);
			if (licInfo.MaxConditionCount == 0 || licInfo.MaxConditionCount < licInfo.Count) {
				MailingUtilities.Log.ErrorFormat("[ActiveContactsValidationRule.Validate]: License count not enough. " +
					"Available: {0}, Used: {1}", licInfo.MaxConditionCount, licInfo.Count);
				return new ValidationResponse {
					Success = false,
					LczStringCode = LicCountNotEnoughMsgCode
				};
			}
			return new ValidationResponse {
				Success = true
			};
		}

		#endregion

	}

}




