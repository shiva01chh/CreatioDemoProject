namespace Terrasoft.Configuration
{
	using System.Net;
	using Terrasoft.Configuration.BpmonlineCloudIntegration;
	using Terrasoft.Core;
	using CoreConfig = Terrasoft.Core.Configuration;
	using Terrasoft.Core.Factories;
	using RestSharp;

	#region Class: AccountServiceApi

	/// <summary>
	/// Provides api to send response to external account service.
	/// </summary>
	public class AccountServiceApi
	{

		#region Constants: Private

		/// <summary>
		/// The webhook account service URL system setting code
		/// </summary>
		private const string AccountServiceUrlSysSettingCode = "SocialAccountServiceUrl";

		#endregion

		#region Fields: Private

		private readonly string _scope;

		private IdentityServerProvider _identityServerProvider;

		private IRestClient _restClient;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Constructor of a class.
		/// </summary>
		/// <param name="userConnection">Instance of UserConnection.</param>
		/// <param name="scope">The name of identity scope.</param>
		public AccountServiceApi(UserConnection userConnection, string scope) {
			_scope = scope;
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Private

		/// <summary>
		/// Identity server provider instance. Returns established provider.
		/// If established is null then create instance of <see cref="IdentityServerProvider"/> 
		/// from <see cref="ClassFactory"/>.
		/// </summary>
		private IdentityServerProvider IdentityServerProvider =>
			_identityServerProvider ?? (_identityServerProvider = CreateIdentityServerProvider());

		#endregion

		#region Properties: Protected

		/// <summary>
		/// Gets the webhook account service URL.
		/// </summary>
		protected string AccountServiceUrl {
			get {
				var webhookAccountServiceUrl = CoreConfig.SysSettings
					.GetValue(UserConnection, AccountServiceUrlSysSettingCode).ToString();
				if (string.IsNullOrEmpty(webhookAccountServiceUrl)) {
					throw new Common.ItemNotFoundException(AccountServiceUrlSysSettingCode);
				}
				return webhookAccountServiceUrl;
			}
		}

		/// <summary>
		/// Gets or sets the rest client for Api calls.
		/// </summary>
		/// <value>
		/// The rest client.
		/// </value>
		protected IRestClient RestClient {
			get {
				if (_restClient != null) {
					return _restClient;
				}
				_restClient = new RestClient();
				_restClient.AddDefaultHeader("Content-Type", "application/json");
				return _restClient;
			}
			set => _restClient = value;
		}

		/// <summary>
		/// User connection.
		/// </summary>
		protected UserConnection UserConnection { get; }

		#endregion

		#region Methods: Private

		private IdentityServerProvider CreateIdentityServerProvider() {
			var userConnectionArg = new ConstructorArgument("userConnection", UserConnection);
			return ClassFactory.Get<IdentityServerProvider>(userConnectionArg);
		}

		private RestRequest CreateRequestWithToken(string url) {
			string token =
				IdentityServerProvider.GetAccessTokenWithExceptionHandle(_scope); //"webhook.creatio.full_access");
			var request = new RestRequest(url);
			request.AddHeader("Authorization", $"Bearer {token}");
			return request;
		}

		private T GetResponseData<T>(IRestResponse<T> response)
			where T : BaseAccountResponse, new() {
			return response?.Data ?? new T();
		}

		private T SendRequest<T>(Method method, string url, object bodyObject = default)
			where T : BaseAccountResponse, new() {
			RestRequest request = CreateRequestWithToken(url);
			request.RequestFormat = DataFormat.Json;
			request.Method = method;
			if (bodyObject != default) {
#if NETFRAMEWORK
				request.AddBody(bodyObject);
#else
				request.AddJsonBody(bodyObject);
#endif
			}
			IRestResponse<T> response = RestClient.Execute<T>(request);
			CheckResponseForError(response);
			return GetResponseData(response);
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Checks response for exceptions occurred.
		/// </summary>
		/// <typeparam name="T">Data provider response type.</typeparam>
		/// <param name="response">Instance of the response.</param>
		protected void CheckResponseForError<T>(IRestResponse<T> response)
			where T : BaseAccountResponse, new() {
			if (response.StatusCode != HttpStatusCode.OK) {
				string errorMessage = response.Data?.ErrorMessage ??
					response.ErrorMessage ?? response.Content ?? response.StatusDescription;
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Sends the post request.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="url">The URL.</param>
		/// <param name="bodyObject">The body object.</param>
		/// <returns>Raw response from API.</returns>
		public T SendPostRequest<T>(string url, object bodyObject)
			where T : BaseAccountResponse, new() {
			return SendRequest<T>(Method.POST, url, bodyObject);
		}

		#endregion

	}

	#endregion

}














