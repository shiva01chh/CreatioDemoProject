namespace Terrasoft.Configuration
{

	#region Class: ActualizedCondition

	/// <summary>
	/// Class contains information about active contact license.
	/// </summary>
	public class ActualLicenseInfo
	{

		#region Properties: Public

		/// <summary>
		/// The number of paid contacts in the license.
		/// </summary>
		public int PaidContactCount { get; set; }

		/// <summary>
		/// The number of active contacts in the license.
		/// </summary>
		public int ActiveContactCount { get; set; }

		/// <summary>
		/// The date of last license values actualization.
		/// </summary>
		public string ActualizationDate { get; set; }

		#endregion

	}

	#endregion

}













