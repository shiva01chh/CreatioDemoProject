namespace Terrasoft.Configuration
{

    #region Class: ActualizedCondition

    /// <summary>
    /// Class contains information about active contact.
    /// </summary>
    public class ActualizedCondition
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets the name of license.
		/// </summary>
		public string PackageName { get; set; }

		/// <summary>
		/// Gets or sets the count of active contact.
		/// </summary>
		public int ConditionCount { get; set; }

		/// <summary>
		/// Gets or sets the date/time of update.
		/// </summary>
		public string ConditionDate { get; set; }

		/// <summary>
		/// Gets or sets the license due date.
		/// </summary>
		public string DueDate { get; set; }

		#endregion

	}

    #endregion

}





