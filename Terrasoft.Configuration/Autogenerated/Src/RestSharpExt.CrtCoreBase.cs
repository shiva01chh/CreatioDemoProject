namespace Terrasoft.Configuration
{
	using System;
	using System.Net;
	using System.Web;
	using Creatio.FeatureToggling;
	using global::Common.Logging;
	using RestSharp;
	using RestSharp.Deserializers;
	using Terrasoft.Common;
	using Terrasoft.OAuthIntegration;

	/// <summary>
	/// Provides utility extension methods for RestSharp classes.
	/// </summary>
	public static class RestSharpExt
	{

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger("HttpRequest");

		#endregion

		#region Methods: Public

		/// <summary>
		/// Adds deserialization handlers to the given REST client.
		/// </summary>
		/// <param name="restClient">REST client to setup.</param>
		public static void SetupDeserializationHandlers(this RestClient restClient) {
#if NETFRAMEWORK
			IDeserializer deserializer = new RestSharpJsonConverter();
			restClient.AddHandler("application/json", deserializer);
			restClient.AddHandler("text/json", deserializer);
			restClient.AddHandler("text/x-json", deserializer);
			restClient.AddHandler("text/javascript", deserializer);
			restClient.AddHandler("*+json", deserializer);
#else
			IDeserializer deserializerInstance = new RestSharpJsonConverter();
			IDeserializer getDeserializerAction() => deserializerInstance;
			restClient.AddHandler("application/json", getDeserializerAction);
			restClient.AddHandler("text/json", getDeserializerAction);
			restClient.AddHandler("text/x-json", getDeserializerAction);
			restClient.AddHandler("text/javascript", getDeserializerAction);
			restClient.AddHandler("*+json", getDeserializerAction);
#endif
		}

		/// <summary>
		/// Creates REST request with JSON content.
		/// </summary>
		/// <param name="restClient">REST client to setup.</param>
		/// <param name="resource">URI of the request.</param>
		/// <param name="body">Body of the request.</param>
		/// <param name="method">HTTP method to use.</param>
		/// <returns>REST request.</returns>
		public static IRestRequest CreateJsonRequest(this IRestClient restClient, string resource, object body,
				Method method = Method.POST) {
			var restRequest = restClient.CreateRequest(resource, method, DataFormat.Json);
			restRequest.JsonSerializer = new RestSharpJsonConverter();
#if NETFRAMEWORK
			restRequest.AddBody(body);
#else
			restRequest.AddJsonBody(body);
#endif
			return restRequest;
		}

		/// <summary>
		/// Creates REST request.
		/// </summary>
		/// <param name="restClient">REST client to setup.</param>
		/// <param name="resource">URI of the request.</param>
		/// <param name="method">HTTP method to use.</param>
		/// <param name="dataFormat">The data format.</param>
		/// <returns>
		/// REST request.
		/// </returns>
		public static IRestRequest CreateRequest(this IRestClient restClient, string resource,
				Method method = Method.POST, DataFormat? dataFormat = null) {
			var restRequest = new RestRequest {
				Resource = resource,
				Method = method
			};
			if (dataFormat.HasValue) {
				restRequest.RequestFormat = dataFormat.Value;
			}
			return restRequest;
		}

		/// <summary>
		/// Use OAuth to authenticate and authorize current request.
		/// </summary>
		/// <param name="restRequest">Request instance.</param>
		/// <param name="identityServiceWrapper">Wrapper for interacting with identity provider.</param>
		/// <param name="scopes">Needed OAuth scopes.</param>
		/// <typeparam name="TFeature">Feature toggling class for conditional authentication.</typeparam>
		public static IRestRequest WithOAuth<TFeature>(this IRestRequest restRequest,
				IIdentityServiceWrapper identityServiceWrapper, string scopes) where TFeature: FeatureMetadata, new() {
			if (Features.GetIsDisabled<TFeature>()) {
				return restRequest;
			}
			if (!identityServiceWrapper.IsIdentityClientInitialized()) {
				_log.Warn("Identity client is not initialized. Access token won't be used for the request");
				return restRequest;
			}
			string accessToken = identityServiceWrapper.GetAccessToken(scopes);
			restRequest.AddHeader("Authorization", $"Bearer {accessToken}");
			return restRequest;
		}

		/// <summary>
		/// Handles <see cref="IRestClient"/> response error.
		/// </summary>
		public static void HandleError(this IRestResponse response) {
			if (response.ErrorException != null) {
				throw response.ErrorException;
			}
			if (response.ResponseStatus != ResponseStatus.Completed && response.ErrorMessage.IsNotNullOrEmpty()) {
				var message = $"[{response.ResponseStatus}]: {response.ErrorMessage}";
				throw new HttpException((int)HttpStatusCode.InternalServerError, message);
			}
			bool isErrorStatusCode = (int)response.StatusCode >= 300;
			if (isErrorStatusCode) {
				string errorMessage = null;
				HttpStatusCode statusCode = HttpStatusCode.InternalServerError; 
				switch (response.StatusCode) {
					case HttpStatusCode.Unauthorized:
						errorMessage = response.Content.ToNullIfEmpty()
							?? "Authentication error. Check auth settings or ask administrator";
						throw new UnauthorizedAccessException(errorMessage);
					case HttpStatusCode.NotFound:
						errorMessage = $"Service not found by address {response.ResponseUri}";
						statusCode = HttpStatusCode.NotFound;
						break;
				}
				throw new HttpException((int)statusCode, $"[{response.StatusCode}] {errorMessage ?? response.Content}");
			}
		}

		#endregion

	}
}














