 namespace Terrasoft.Configuration
{
	/// <summary>
	/// Specific validation rule.
	/// </summary>
	/// <typeparam name="T">Specific model</typeparam>
	public interface ISpecificValidationRule<T>
	{
		/// <summary>
		/// Contain the error massage if invalid rule.
		/// </summary>
		string Error { get; }

		/// <summary>
		/// Check the rule.
		/// </summary>
		/// <returns>Validation result</returns>
		bool Validate(T parameters);
	}
}





