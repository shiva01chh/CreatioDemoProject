namespace Terrasoft.Configuration.GenAI
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Net;
	using global::Common.Logging;
	using RestSharp;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration.Enrichment;
	using Terrasoft.Core;
	using Terrasoft.Core.Applications.GenAI;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Factories;
	using Terrasoft.Enrichment.Interfaces.GenAI;
	using Terrasoft.Enrichment.Interfaces.GenAI.Requests;
	using Terrasoft.Enrichment.Interfaces.GenAI.Responses;
	using Terrasoft.OAuthIntegration;
	using Terrasoft.OAuthIntegration.Exception;

	public interface IGenAIServiceProxy
	{
		List<GenAIEntity> GenerateEntitiesByDescription(string description);

		List<string> GenerateDcmStages(string description);

		List<GenAIEntityData> GenerateData(string description, List<GenAIEntity> entities);
	}

	[DefaultBinding(typeof(IGenAIServiceProxy))]
	public class GenAiServiceProxy: IGenAIServiceProxy
	{

		#region Constants: Private

		private const string ServiceUrlSettingsName = "AccountEnrichmentServiceUrl";
		private const string GenerateEntitiesByDescriptionPath = "/generateEntitiesByDescription";
		private const string GenerateDcmStagesByDescriptionPath = "/generateDcmStagesByDescription";
		private const string GenerateDataPath = "/generateData";
		private const int DefaultTimeoutSec = 240;

		#endregion

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger("Enrichment");
		private readonly UserConnection _userConnection;

		#endregion

		#region Properties: Protected

		private IIdentityServiceWrapper _identityServiceWrapper;
		protected virtual IIdentityServiceWrapper IdentityServiceWrapper =>
			_identityServiceWrapper ?? (_identityServiceWrapper = GlobalAppSettings.FeatureUseSeparateSettingsForOAuth20
				? ClassFactory.Get<IIdentityServiceWrapper>("ExternalAccess")
				: ClassFactory.Get<IIdentityServiceWrapper>());

		#endregion

		#region Constructors: Public

		public GenAiServiceProxy(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private IRestClient CreateClient() {
			string serviceUrl = SysSettings.GetValue(_userConnection, ServiceUrlSettingsName, string.Empty);
			if (serviceUrl.IsNullOrEmpty()) {
				throw new IncorrectConfigurationException(ServiceUrlSettingsName);
			}
			if (!ClassFactory.TryGet("EnrichmentServiceRestClient", out IRestClient restClient)) {
				restClient = RestClientFactory.CreateRestClient();
			}
#if NETFRAMEWORK
			restClient.BaseUrl = serviceUrl;
#else
			restClient.BaseUrl = new Uri(serviceUrl);
#endif
			return restClient;
		}

		private IRestRequest CreateRequest(IRestClient client, string resource) {
			return client.CreateRequest(resource, Method.POST, DataFormat.Json)
				.WithOAuth<EnrichmentFeatures.UseOAuth>(IdentityServiceWrapper, "use_enrichment");
		}

		private LocalizableString GetLocalizedString(string resourceName) {
			var localizableString = $"LocalizableStrings.{resourceName}.Value";
			return new LocalizableString(_userConnection.ResourceStorage, GetType().Name, localizableString);
		}

		private string GetErrorMessage(GenAIServiceError genAIServiceError) {
			var errorMapping = new Dictionary<GenAIServiceError, string> {
				{ GenAIServiceError.MissingApiKey, "Error_401_AuthError" },
				{ GenAIServiceError.InvalidRequest, "Error_401_AuthError" },
				{ GenAIServiceError.ServerError, "Error_500_Unknown" },
				{ GenAIServiceError.RateLimitReached, "Error_508_QuotaExceed" },
				{ GenAIServiceError.InsufficientQuota, "Error_508_QuotaExceed" },
				{ GenAIServiceError.QuotaExceeded, "Error_508_QuotaExceed" },
				{ GenAIServiceError.ModelNotFound, "Error_500_Unknown" },
				{ GenAIServiceError.ModelError, "Error_500_Unknown" },
				{ GenAIServiceError.InvalidResponse, "Error_500_WrongAnswer" },
				{ GenAIServiceError.UnauthorizedClient, "Error_401_AuthError" },
				{ GenAIServiceError.UnsupportedGrantType, "Error_401_AuthError" },
				{ GenAIServiceError.InvalidScope, "Error_401_AuthError" },
				{ GenAIServiceError.RequestTimeout, "Error_504_Timeout" },
				{ GenAIServiceError.NetworkError, "Error_503_GenAIUnavailable" },
				{ GenAIServiceError.InvalidJson, "Error_500_Unknown" },
				{ GenAIServiceError.EngineOverloaded, "Error_503_GenAIUnavailable" },
				{ GenAIServiceError.InvalidApiKey, "Error_401_AuthError" },
				{ GenAIServiceError.Unknown, "Error_500_Unknown" }
			};
			return GetLocalizedString(errorMapping.TryGetValue(genAIServiceError, out string resourceName)
				? resourceName
				: "Error_500_Unknown"
			);
		}

		private void HandleError(IRestResponse response) {
			if (response.StatusCode != HttpStatusCode.OK) {
				GenAIErrorResponse errorResponse = null;
				try {
					errorResponse = Json.Deserialize<GenAIErrorResponse>(response.Content);
				} catch (Exception) {
					// ignored
				}
				if (errorResponse != null) {
					_log.Error($"GenAI error occurred with status code = {response.StatusCode.ToString()}. " +
						$"Error: {errorResponse.Error.ToString()}, message: {errorResponse.Message}");
					if (errorResponse.Error == GenAIServiceError.InternalQuotaExceeded) {
						throw new GenAIException("LimitExceeded", $"You have reached quota limit: " +
							$"{errorResponse.Message} \nTry again later or ask administrator for help");
					}
					string errorMessage = GetErrorMessage(errorResponse.Error);
					throw new GenAIException(errorResponse.Error.ToString(), errorMessage);
				}
			}
			response.HandleError();
		}

		private IRestResponse CreateAndExecutePostRequest(string resource, object body) {
			IRestResponse response = null;
			IRestClient client = null;
			try {
				client = CreateClient();
				IRestRequest request = CreateRequest(client, resource);
				request.AddBody(body);
				request.Timeout = DefaultTimeoutSec * 1000;
				response = client.Post(request);
				HandleError(response);
				return response;
			} catch (GenAIException) {
				throw;
			} catch (IncorrectConfigurationException e) {
				_log.Error(e.Message);
				throw new GenAIException("IncorrectConfiguration", e.Message);
			} catch (ApiServerConnectivityException e) {
				throw new GenAIException(GenAIServiceError.UnauthorizedClient.ToString(), 
					"Incorrect OAuth settings. Check system settings or ask administrator", e);
			} catch (UriFormatException e) {
				_log.Error($"Invalid uri while generating app using '{resource}': {client?.BaseUrl}", e);
				throw new GenAIException("ServerNotAvailable", 
					"Incorrect service URL. Check system settings or ask administrator", e);
			} catch (Exception e) {
				if (e is WebException || response?.StatusCode == HttpStatusCode.NotFound
						|| response?.StatusCode == HttpStatusCode.ServiceUnavailable) {
					string errorMessage = $"Server ({client?.BaseUrl}) is not available while generating app using " +
						$"{resource}. Status code: {response?.StatusCode}. \n\n" +
						$"Check system settings or ask administrator";
					_log.Error(errorMessage, e);
					throw new GenAIException("ServerNotAvailable", errorMessage, e);
				}
				_log.Error($"Unknown error while generating app using '{resource}'", e);
				throw new GenAIException("UnknownError", $"An error occurred while generating app: {e.Message}", e);
			}
		}

		#endregion

		#region Methods: Public

		public List<GenAIEntity> GenerateEntitiesByDescription(string description) {
			IRestResponse response = CreateAndExecutePostRequest(GenerateEntitiesByDescriptionPath,
				new GenerateContentByDescriptionRequest {
					Description = description
				});
			var responseObj = Json.Deserialize<GenerateEntitiesByDescriptionResponse>(response.Content);
			return responseObj.Entities ?? new List<GenAIEntity>();
		}

		public List<string> GenerateDcmStages(string description) {
			IRestResponse response = CreateAndExecutePostRequest(GenerateDcmStagesByDescriptionPath,
				new GenerateContentByDescriptionRequest {
					Description = description
				});
			var responseObj = Json.Deserialize<GenerateDcmStagesByDescriptionResponse>(response.Content);
			return responseObj.DcmStages?.Select(x => x.ToLowerInvariant().ToCamelCase()).ToList() ?? new List<string>();
		}

		public List<GenAIEntityData> GenerateData(string description, List<GenAIEntity> entities) {
			IRestResponse response = CreateAndExecutePostRequest(GenerateDataPath,
				new GenerateDataRequest {
					Description = description,
					Entities = entities
				});
			var responseObj = Json.Deserialize<GenerateDataResponse>(response.Content);
			return responseObj.Data ?? new List<GenAIEntityData>();
		}

		#endregion

	}
}













