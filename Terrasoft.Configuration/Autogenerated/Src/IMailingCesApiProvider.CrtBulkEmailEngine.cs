namespace Terrasoft.Configuration
{
	using System;
	using Core;
	using Terrasoft.Configuration.CES;

	#region Interface: IMailingCesApiProvider

	/// <summary>
	/// Provides interface to operate with ICESApi instance.
	/// </summary>
	public interface IMailingCesApiProvider: IMailingProvider
	{

		#region Properties: Public
		
		/// <summary>
		/// Instance of <see cref="BulkEmailEventLogger"/>, provides logging to BulkEmailEventLog table in DB.
		/// </summary>
		BulkEmailEventLogger BulkEmailEventLogger { get; }

		/// <summary>
		/// Gets or sets instance of <see cref="ICESApi"/>
		/// </summary>
		ICESApi ServiceApi { get;}
		
		#endregion

	}

	#endregion
}





