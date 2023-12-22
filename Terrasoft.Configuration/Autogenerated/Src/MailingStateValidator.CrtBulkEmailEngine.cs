namespace Terrasoft.Configuration
{
	using System.Collections.Generic;

	/// <summary>
	/// Represents the validator for mailing states according to the rules.
	/// </summary>
	public class MailingStateValidator
	{
		private readonly IEnumerable<IMailingStateValidationRule> _rules;

		/// <summary>
		/// Create instanse with specified builder.
		/// </summary>
		/// <param name="ruleBuilder">The mailing state rule bulder.</param>
		public MailingStateValidator(IMailingStateValidationBuilder ruleBuilder) {
			_rules = ruleBuilder.GetRules();
		}

		/// <summary>
		/// Validates the states according to the specified rules.
		/// </summary>
		/// <param name="state">State for validation.</param>
		public virtual IEnumerable<ValidationResponse> Validate(MailingState state) {
			foreach (IMailingStateValidationRule rule in _rules) {
				var result = rule.Validate(state);
				yield return result;
				if (!result.Success) {
					yield break;
				}
				
			}
		}
	}
}













