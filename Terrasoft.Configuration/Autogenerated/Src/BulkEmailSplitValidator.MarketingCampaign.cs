namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Core;

	#region Class: BulkEmailSplitValidator

	/// <summary>
	///     Class that invoke validation rule in series.
	/// </summary>
	public sealed class BulkEmailSplitValidator
	{

		#region Fields: Private

		private readonly UserConnection _userConnection;

		private readonly ISpecificValidatorBuilder<Guid> _validatorBuilder;

		#endregion

		public IEnumerable<IValidationRule> BaseValidationRules { get; }

		public IEnumerable<ISpecificValidationRule<Guid>> SpecifiedValidationRules { get; }

		#region Constructors: Public

		/// <summary>
		///     Constructor to create instance of <see cref="BulkEmailSplitValidator"/>.
		/// </summary>
		/// <param name="userConnection">Current user connection instance.</param>
		/// <param name="validatorBuilder">Builder for validation rule.</param>
		public BulkEmailSplitValidator(UserConnection userConnection, ISpecificValidatorBuilder<Guid> validatorBuilder = null) {
			_userConnection = userConnection;
			_validatorBuilder = validatorBuilder ?? new BulkEmailSplitValidatorBuilder(_userConnection);
			BaseValidationRules = _validatorBuilder.InitRules();
			SpecifiedValidationRules = _validatorBuilder.InitSpecificRules();
		}

		#endregion

		#region Methods: Public

		/// <summary>
		///     Validates by current rules.
		/// </summary>
		/// <param name="splitTestId">Unique identifier of split test to validate.</param>
		/// <returns>Returns success result if all parameters are valid. Otherwise returns error result.</returns>
		public bool Validate(Guid splitTestId, out string errorMassage) {
			errorMassage = null;
			foreach (IValidationRule rule in BaseValidationRules) {
				if (!rule.Validate()) {
					errorMassage = rule.Error;
					return false;
				}
			}
			foreach (ISpecificValidationRule<Guid> rule in SpecifiedValidationRules) {
				if (!rule.Validate(splitTestId)) {
					errorMassage = rule.Error;
					return false;
				}
			}
			return true;
		}

		#endregion

	}

	#endregion
}













