namespace Terrasoft.Configuration.LandingiIntegration
{
	using Terrasoft.Core;

	#region Class: WebhookAccountServiceApi

	/// <inheritdoc cref="IWebhookAccountServiceApi"/>
	public class WebhookAccountServiceApi : AccountServiceApi, IWebhookAccountServiceApi
	{

		#region Constants: Private

		private const string Scope = "webhook.creatio.full_access";

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Constructor of the class.
		/// </summary>
		/// <param name="userConnection">Instance of UserConnection.</param>
		public WebhookAccountServiceApi(UserConnection userConnection)
			: base(userConnection, Scope) { }

		#endregion

		#region Methods: Public

		/// <inheritdoc cref="IWebhookAccountServiceApi.CreateAccount"/>
		public BaseWebhookAccountResponse CreateAccount(WebhookAccountRequest accountCreateRequest) {
			var url = $"{AccountServiceUrl}/api/webhooksaccount/create";
			var response = SendPostRequest<BaseWebhookAccountResponse>(url, accountCreateRequest);
			return response;
		}

		/// <inheritdoc cref="IWebhookAccountServiceApi.GetSubAccounts"/>
		public WebhookSubAccountsResponse GetSubAccounts() {
			var url = $"{AccountServiceUrl}/api/webhooksaccount/get/subAccounts";
			var response = SendPostRequest<WebhookSubAccountsResponse>(url, null);
			return response;
		}

		#endregion

	}

	#endregion

	/// <summary>
	/// Provide information from webhooks account service.
	/// </summary>
	public interface IWebhookAccountServiceApi
	{

		#region Methods: Public

		/// <summary>
		/// Creates the webhook service subaccount.
		/// </summary>
		/// <param name="accountCreateRequest">The account create request.</param>
		BaseWebhookAccountResponse CreateAccount(WebhookAccountRequest accountCreateRequest);

		/// <summary>
		/// Gets the list of associated with webhook service subaccounts.
		/// </summary>
		/// <returns>The existing webhook service subaccounts.</returns>
		WebhookSubAccountsResponse GetSubAccounts();

		#endregion

	}
}













