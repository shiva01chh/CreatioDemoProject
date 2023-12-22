 namespace Terrasoft.Configuration
{
	using System.Collections.Generic;

	/// <summary>
	/// Builder for base validation rule.
	/// </summary>
	public interface IValidatorBuilder
	{
		/// <summary>
		/// Create validation rule list.
		/// </summary>
		/// <returns>Validation rules</returns>
		IEnumerable<IValidationRule> InitRules();
	}
}














