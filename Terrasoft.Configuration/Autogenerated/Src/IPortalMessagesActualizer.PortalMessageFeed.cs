 namespace Terrasoft.Configuration.PortalMessageFeed
{
	using System;

	#region  Interface: IPortalMessagesActualizer

	/// <summary>
	/// Provides methods for work with portal messages actualizer.
	/// </summary>
	public interface IPortalMessagesActualizer
	{
		/// <summary>
        /// Adds old portal messages to new timeline.
		/// <param name="dateFrom">Start date.</param>
		/// <param name="dateTo">End date.</param>
        /// </summary>
        void ActualizePortalMessages(DateTime dateFrom, DateTime dateTo);
    }

	#endregion
}






