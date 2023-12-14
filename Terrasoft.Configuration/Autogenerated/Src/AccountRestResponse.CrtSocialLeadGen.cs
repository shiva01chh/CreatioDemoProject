namespace Terrasoft.Configuration.SocialLeadGen
{
	using System;

	#region Class: AccountRestResponse

	/// <summary>
	/// Cloud response DTO with information about account.
	/// </summary>
	public class AccountRestResponse : SocialLeadGenRestProviderResponse
	{

		#region Properties: Public

		/// <summary>
		/// Account id.
		/// </summary>
		public Guid AccountId { get; set; }

		/// <summary>
		/// Is account active.
		/// </summary>
		public bool IsActive { get; set; }

		/// <summary>
		/// Creatio URL.
		/// </summary>
		public string CreatioUrl { get; set; }

		#endregion

	}

	#endregion

}






