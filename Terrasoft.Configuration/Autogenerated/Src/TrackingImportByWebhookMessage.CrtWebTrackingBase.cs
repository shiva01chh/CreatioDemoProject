namespace Terrasoft.Configuration
{
	using System;
	using Newtonsoft.Json;

	#region Class: TrackingImportByWebhookMessage

	/// <summary>
	/// Class to represent matomo data import by form submit action message.
	/// </summary>
	public class TrackingImportByWebhookMessage : TouchQueueMessage
	{

		#region Constants: Private
		
		private const string TrackingCode = "BDD28F17-0CA2-4D40-92A8-82A11E77896E";
		
		#endregion
		
		#region Constructors: Public

		/// <summary>
		/// Constructor for <see cref="TrackingImportByWebhookMessage"/>.
		/// </summary>
		/// <param name="contactId">Contact unique identifier from Creatio.</param>
		/// <param name="trackingUserId">Tracking system user id.</param>
		/// <param name="pageUrl">Webhook landing page url.</param>
		public TrackingImportByWebhookMessage(Guid contactId, string trackingUserId, string pageUrl) {
			Type = TouchQueueMessageType.Import;
			ContactId = contactId;
			TrackingUserId = trackingUserId;
			PageUrl = pageUrl;
			RequiresDeduplication = true;
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Contains contact id or <see cref="Guid.Empty"/>.
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Guid ContactId { get; set; }

		/// <summary>
		/// Contains tracking user id.
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string TrackingUserId { get; set; }

		/// <summary>
		/// Contains landing page Url.
		/// </summary>
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string PageUrl { get; set; }

		#endregion

		#region Methods: Public

		/// <summary>
		/// Defines priority of current message. Messages with highest priority will be processed first.
		/// </summary>
		public override int GetPriority() => 12;
		
		/// <summary>
		/// Returns identifier of tracking system <see cref="TouchEventTracking"/>.
		/// </summary>
		/// <returns>Identifier of Tracking system. <see cref="Guid.Empty"/> by default.</returns>
		public override Guid GetTracking() => Guid.Parse(TrackingCode);

		/// <summary>
		/// Defines number of retries in case of crash or error.
		/// </summary>
		/// <returns>Number of retries.</returns>
		public override int GetMaxRetryCount() => 2;

		#endregion

	}
	#endregion

}





