namespace Terrasoft.Configuration.LandingiIntegration
{
	using System;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using global::Common.Logging;
	using Terrasoft.Common;
	using Terrasoft.Configuration.BpmonlineCloudIntegration;
	using Terrasoft.Nui.ServiceModel.DataContract;
	using Terrasoft.Web.Common;

	#region Class: ApiKeyProvider

    /// <summary>
    /// Api key provider.
    /// </summary>
    [ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class ApiKeyProvider : BaseService
	{

		#region Constants: Private

		private const string AccountServiceUrlIsNotFilledCode = "AccountServiceUrlIsNotFilledErrorMsg";
		private const string ErrorMessagePrefixCode = "ErrorMessagePrefix";
		private const string GetCreatioUrlErrorCode = "GetCreatioUrlErrorMsg";
        private const string IdentitySettingsAreNotFilledErrorCode = "IdentitySettingsAreNotFilledErrorMsg";
		private const string OtherErrorCode = "OtherErrorMsg";
		private const string WebhookAccountServiceIdentityErrorCode = "WebhookAccountServiceIdentityErrorMsg";

		#endregion

		#region Fields: Private

		private ILog _logger;
		private IOAuthIntegrationReader _oAuthIntegrationReader;
		private IRootAccountProvider _rootAccountProvider;
		private ISubAccountProviderFactory _subAccountProviderFactory;

		#endregion

		#region Properties: Private

		private string ErrorMessagePrefix => GetLczString(ErrorMessagePrefixCode);

		#endregion

		#region Properties: Public

		/// <summary>
		/// Gets or sets the logger.
		/// </summary>
		public ILog Logger {
			get => _logger ?? (_logger = LogManager.GetLogger("ApiKeyProvider"));
			set => _logger = value;
		}
		private const string Scope= "webhook.creatio.full_access";

		/// <summary>
		/// The root account provider.
		/// </summary>
		public IRootAccountProvider RootAccountProvider {
			get => _rootAccountProvider ?? (_rootAccountProvider = new RootAccountProvider(UserConnection, Scope));
			set => _rootAccountProvider = value;
		}

		/// <summary>
		/// The root account provider.
		/// </summary>
		public IOAuthIntegrationReader OAuthIntegrationReader {
			get => _oAuthIntegrationReader ?? (_oAuthIntegrationReader = new OAuthIntegrationReader());
			set => _oAuthIntegrationReader = value;
		}

		/// <summary>
		/// Gets or sets the sub account provider factory.
		/// </summary>
		public ISubAccountProviderFactory SubAccountProviderFactory {
			get =>
				_subAccountProviderFactory ??
				(_subAccountProviderFactory = new SubAccountProviderFactory());
			set => _subAccountProviderFactory = value;
		}

		#endregion

		#region Methods: Private

		private string GetLczString(string localizableCode) {
			var localizableStringName = $"LocalizableStrings.{localizableCode}.Value";
			return new LocalizableString(UserConnection.Workspace.ResourceStorage, "ApiKeyProvider",
				localizableStringName);
		}

		private WebhookApiKeyResponse ProcessError(string errorMessageCode, string message) {
			var errorMessage = $"{ErrorMessagePrefix} {GetLczString(errorMessageCode)}";
			Logger.Error($"Error message: {errorMessage} Exception message: {message}");
			var errorResponse = new WebhookApiKeyResponse {
				RowsAffected = 1,
				ResponseStatus = new ResponseStatus("500", errorMessage),
				Success = false
			};
			return errorResponse;
		}

		private bool TryGetIntegrationInfo(string integrationName, out IntegrationInfo integrationInfo,
			out string errorMessage) {
			try {
				integrationInfo =
					OAuthIntegrationReader.GetIntegrationInfo(UserConnection.AppConnection.SystemUserConnection,
						integrationName);
				errorMessage = null;
				return integrationInfo.Success;
			} catch (Exception e) {
				integrationInfo = null;
				errorMessage = e.Message;
				return false;
			}
		}

		private bool TryGetSocialRootAccount(out string actualErrorCode,
			out string errorMessage) {
			try {
				RootAccountInfoResponse account = RootAccountProvider.GetOrCreateSocialRootAccount();
				actualErrorCode = OtherErrorCode;
				errorMessage = account.ErrorMessage;
				return string.IsNullOrEmpty(account.ErrorMessage);
			} catch (ItemNotFoundException e) {
				actualErrorCode = AccountServiceUrlIsNotFilledCode;
				errorMessage = e.Message;
				return false;
			} catch (GetCreatioUrlException e) {
				actualErrorCode = GetCreatioUrlErrorCode;
				errorMessage = e.Message;
				return false;
			} catch (InvalidIdentityServerSettingsException e) {
				actualErrorCode = IdentitySettingsAreNotFilledErrorCode;
				errorMessage = e.Message;
				return false;
			} catch (Exception e) {
				actualErrorCode = OtherErrorCode;
				errorMessage = e.Message;
				return false;
			}
		}

		private bool TryGetSubAccount(string webhookSource, IntegrationInfo integrationInfo, out string apiKey, out string actualErrorCode,
			out string errorMessage) {
			try {
				IWebhookAccountProvider subAccountProvider =
					SubAccountProviderFactory.GetWebhookAccountProvider(webhookSource, true);
				apiKey = subAccountProvider.GetOrCreateWebhookServiceApiKey(webhookSource, integrationInfo);
				actualErrorCode = OtherErrorCode;
				errorMessage = null;
				return !string.IsNullOrEmpty(apiKey);
			} catch (Exception e) {
				apiKey = null;
				actualErrorCode = OtherErrorCode;
				errorMessage = e.Message;
				return false;
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Gets the or create webhook API key.
		/// </summary>
		/// <param name="integrationName">Name of the integration.</param>
		/// <param name="webhookSource">The webhook source.</param>
		/// <returns>Base response with Api key.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.WrappedRequest)]
		public WebhookApiKeyResponse GetOrCreateWebhookApiKey(string integrationName, string webhookSource) {
			if (!TryGetIntegrationInfo(integrationName, out IntegrationInfo integrationInfo, out string errorMessage)) {
				return ProcessError(WebhookAccountServiceIdentityErrorCode, errorMessage);
			}
			if (!TryGetSocialRootAccount(out string actualErrorCode, out errorMessage)) {
				return ProcessError(actualErrorCode, errorMessage);
			}
			if (!TryGetSubAccount(webhookSource, integrationInfo, out string apiKey, out actualErrorCode, out errorMessage)) {
				return ProcessError(actualErrorCode, errorMessage);
			}
			return new WebhookApiKeyResponse {
				ApiKey = apiKey,
				Success = true
			};
		}

		#endregion

	}

	#endregion

}














