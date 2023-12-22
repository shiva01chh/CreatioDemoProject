namespace Terrasoft.Configuration
{
	/// <summary>
	/// Base validation rule.
	/// </summary>
	public interface IValidationRule
	{
		/// <summary>
		/// Contain the error massage if invalid rule.
		/// </summary>
		string Error { get; }

		/// <summary>
		/// Check the rule.
		/// </summary>
		/// <returns>Validation result</returns>
		bool Validate();
	}
}














