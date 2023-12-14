namespace Terrasoft.Configuration
{

    #region Class: ActiveContactsValidationResult

    /// <summary>
    /// Base validation result.
    /// </summary>
    public class ActiveContactsValidationResult
	{

		/// <summary>
		/// Validation success.
		/// </summary>
		public const int Success = 0;

		/// <summary>
		/// Validation error.
		/// </summary>
		public const int Error = 1;

		#region Properties: Public

		/// <summary>
		/// Validation code.
		/// </summary>
		public int Code { get; set; }

		/// <summary>
		/// Validation message.
		/// </summary>
		public string Message { get; set; }

		#endregion

	}

	#endregion

}






