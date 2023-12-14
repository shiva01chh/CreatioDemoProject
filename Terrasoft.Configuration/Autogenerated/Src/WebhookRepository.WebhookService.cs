namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Specialized;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;

	/// <summary>
	/// Represents the interface for webhook saving.
	/// </summary>
	public interface IWebhookRepository
	{
		/// <summary>
		/// Create webhook entity.
		/// </summary>
		/// <param name="webhookParameters">Webhook parameters collection.</param>
		/// <returns>Webhook entity id.</returns>
		Guid SaveWebhook(NameValueCollection webhookParameters);
	}

	/// <summary>
	/// Webhook request to webhook entity adapter 
	/// </summary>
	public class WebhookRepository : IWebhookRepository
	{

		#region Fields: Private

		private readonly UserConnection UserConnection;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="userConnection">Instance of UserConnection</param>
		public WebhookRepository(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private Entity BuildWebhook(NameValueCollection webhookParameters) {
			var webhookSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Webhook");
			var webhook = webhookSchema.CreateEntity(UserConnection);
			SetWebhookValues(webhook, webhookParameters);
			return webhook;
		}

		/// <summary>
		/// Set parameters value to webhook entity
		/// </summary>
		/// <param name="webhook">Webhook entity</param>
		/// <param name="webhookParameters">Webhook parameters collection</param>
		private void SetWebhookValues(Entity webhook, NameValueCollection webhookParameters) {
			var apiKey = webhookParameters["ApiKey"];
			var contentType = webhookParameters["ContentType"];
			var headers = webhookParameters["Headers"];
			var queryParameters = webhookParameters["QueryParameters"];
			var requestBody = webhookParameters["data"];
			var sourceUrl = webhookParameters["SourceUrl"];
			var webhookSource = webhookParameters["WebhookSource"];
			webhook.SetDefColumnValues();
			webhook.SetColumnValue("ApiKey", apiKey);
			webhook.SetColumnValue("ContentType", contentType);
			webhook.SetColumnValue("Headers", headers);
			webhook.SetColumnValue("QueryParameters", queryParameters);
			webhook.SetColumnValue("RequestBody", requestBody);
			webhook.SetColumnValue("SourceUrl", sourceUrl);
			webhook.SetColumnValue("WebhookSource", webhookSource);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Create webhook entity
		/// </summary>
		/// <param name="webhookParameters">Webhook parameters collection</param>
		/// <returns>Webhook entity id</returns>
		public Guid SaveWebhook(NameValueCollection webhookParameters) {
			var webhook = BuildWebhook(webhookParameters);
			webhook.Save();
			return webhook.PrimaryColumnValue;
		}

		#endregion

	}
}




