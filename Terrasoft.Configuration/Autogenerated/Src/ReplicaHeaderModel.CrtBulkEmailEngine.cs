namespace Terrasoft.Configuration
{
	using System;
	
	#region Class: ReplicaHeaderModel

	/// <summary>
	/// Represents DTO of headers for the bulk email template replica.
	/// </summary>
	public class ReplicaHeaderModel : EmailHeaderModel
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets the replica mask.
		/// </summary>
		public int ReplicaMask { get; set; }

		/// <summary>
		/// Gets or sets the replica identifier.
		/// </summary>
		public Guid ReplicaId { get; set; }

		#endregion

	}

	#endregion
}













