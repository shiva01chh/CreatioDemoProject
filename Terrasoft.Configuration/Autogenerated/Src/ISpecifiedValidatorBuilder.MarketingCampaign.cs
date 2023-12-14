namespace Terrasoft.Configuration
{
	using System.Collections.Generic;

	/// <summary>
	/// Builder for specific validation rule.
	/// </summary>
	/// <typeparam name="T">Specified model</typeparam>
	public interface ISpecificValidatorBuilder<T> : IValidatorBuilder
	{
		/// <summary>
		/// Create specific validation rule list.
		/// </summary>
		/// <returns>Specific validation rules</returns>
		IEnumerable<ISpecificValidationRule<T>> InitSpecificRules();
	}
}






