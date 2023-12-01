namespace Terrasoft.Configuration.GlobalSearch
{
	using System;
	using System.Collections.Generic;
	using System.Text.RegularExpressions;
	using global::Common.Logging;
	using Newtonsoft.Json;
	using RestSharp;
	using Terrasoft.Core;
	using SysSettingsCore = Terrasoft.Core.Configuration.SysSettings;
	using Terrasoft.Core.Factories;
	using Terrasoft.GlobalSearch.Interfaces;
	using Terrasoft.OAuthIntegration;

	#region Class: IndexingConfigSender

	/// <summary>
	/// Sends indexed entities to the indexing service.
	/// </summary>
	public class IndexingConfigSender
	{

		#region Fields: Private

		/// <summary>
		/// Elastic delimiter pattern.
		/// </summary>
		private static readonly Regex _elasticDelimiterPattern = new Regex("(.*)/([^/]+)$");

		/// <summary>
		/// <see cref="UserConnection"/> instance.
		/// </summary>
		private readonly UserConnection _userConnection;

		/// <summary>
		/// Log manager.
		/// </summary>
		private static readonly ILog _log = LogManager.GetLogger("GlobalSearch");

		#endregion

		#region Properties: Private

		private IIdentityServiceWrapper _identityServiceWrapper;
		private IIdentityServiceWrapper IdentityServiceWrapper =>
			_identityServiceWrapper ?? (_identityServiceWrapper = GlobalAppSettings.FeatureUseSeparateSettingsForOAuth20
				? ClassFactory.Get<IIdentityServiceWrapper>("ExternalAccess")
				: ClassFactory.Get<IIdentityServiceWrapper>());

		#endregion

		#region Properties: Protected

		/// <summary>
		/// ElasticSearch host address.
		/// </summary>
		protected string ElasticHost => _elasticDelimiterPattern.Replace(ElasticUrl, "$1");

		/// <summary>
		/// ElasticSearch index name.
		/// </summary>
		protected string ElasticIndex => _elasticDelimiterPattern.Replace(ElasticUrl, "$2");

		/// <summary>
		/// ElasticSearch full url address.
		/// </summary>
		protected string _elasticUrl;
		protected virtual string ElasticUrl => _elasticUrl ??
			SysSettingsCore.GetValue(_userConnection, "GlobalSearchUrl", string.Empty);

		/// <summary>
		/// Global search config service url address.
		/// </summary>
		protected string _globalSearchServiceUrl;
		protected virtual string GlobalSearchServiceUrl => _globalSearchServiceUrl ?? (_globalSearchServiceUrl =
			SysSettingsCore.GetValue(_userConnection, "GlobalSearchConfigServiceUrl", string.Empty));

		/// <summary>
		/// Indexing entity list manager.
		/// </summary>
		protected IndexingEntityListManager _indexingEntityListManager;
		protected virtual IndexingEntityListManager IndexingEntityListManager => 
			_indexingEntityListManager ?? (_indexingEntityListManager =
				ClassFactory.Get<IndexingEntityListManager>(
					new ConstructorArgument("userConnection", _userConnection)));

		/// <summary>
		/// Implemented instance of <see cref="IRestClient"/>.
		/// </summary>
		private IRestClient _restClient;
		public virtual IRestClient RestClient =>
			_restClient ?? (_restClient = !ClassFactory.TryGet("GlobalSearchServiceRestClient", out IRestClient client)
				? RestClientFactory.CreateRestClient()
				: client);

		#endregion
		
		#region Constructors: Public

		/// <summary>Initializes a new instance of the <see cref="UserConnection" /> class.</summary>
		public IndexingConfigSender(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private void SaveConfigsCallback(IRestResponse restResponse) {
			if (restResponse.StatusCode != System.Net.HttpStatusCode.OK) {
				_log.Error(restResponse.ErrorMessage);
			} else {
				_log.Info(string.Format("Sending indexings configs finished with " +
						"ResponseStatus: {0}, StatusCode: {1}, Content: {2}",
						restResponse.ResponseStatus, restResponse.StatusCode, restResponse.Content));
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Sends indexation configs to indexing service.
		/// </summary>
		public void Send() {
			if (string.IsNullOrEmpty(GlobalSearchServiceUrl) && string.IsNullOrEmpty(ElasticUrl)) {
				_log.Info("GlobalSearch connection settings are empty.");
				return;
			}
			List<IndexingEntityConfig> indexingEntityList = IndexingEntityListManager.GetIndexingEntities();
#if NETSTANDARD2_0
			RestClient.BaseUrl = new Uri($"{GlobalSearchServiceUrl.TrimEnd('/')}/saveConfigs");
#else
			RestClient.BaseUrl = new Uri($"{GlobalSearchServiceUrl.TrimEnd('/')}/saveConfigs").ToString();
#endif
			string scope = GlobalSearchOAuthScopes.GetScopeForCurrentUser(_userConnection);
			IRestRequest request = new RestRequest {
				Method = Method.POST
			}.WithOAuth<GlobalSearchFeatures.UseOAuth>(IdentityServiceWrapper, scope);
			request.AddParameter("IndexationConfigs", JsonConvert.SerializeObject(indexingEntityList));
			request.AddParameter("IndexName", ElasticIndex);
			_log.Info("Sending indexation configs started.");
			RestClient.ExecuteAsync(request, SaveConfigsCallback);
		}

		#endregion
	}
	
	#endregion
}





