namespace Terrasoft.Configuration
{
	using System;
	using System.Threading;
	using System.Net.Http;
	using Newtonsoft.Json;
	using Terrasoft.GlobalSearch.Interfaces;
	using System.Threading.Tasks;
	using global::Common.Logging;
	using CoreSysSetting = Core.Configuration.SysSettings;
	using Terrasoft.Core;
	using Terrasoft.Common;
	using Terrasoft.Core.Factories;

	#region Class: IMentionRepository

	[DefaultBinding(typeof(IMentionRepository))]
	public class MentionRepository: IMentionRepository
	{

		#region Fields: Private

		private readonly string _serverUrl;
		private readonly ILog _log = LogManager.GetLogger("MentionRepository");

		#endregion

		private HttpClient _httpClient;
		internal HttpClient HttpClient {
			get {
				if (_httpClient == null) {
					_httpClient = new HttpClient {
						BaseAddress = new Uri(_serverUrl)
					};
				}
				return _httpClient;
			}
			set => _httpClient = value;
		}

		#region Constructors: Public

		public MentionRepository(UserConnection uc) {
			_serverUrl = CoreSysSetting.GetValue(uc, "GlobalSearchUrl", string.Empty);
			if (_serverUrl.IsNullOrEmpty()) {
				throw new ArgumentNullException("GlobalSearchUrl", "Can't find global search url for custom http request.");
			}
		}


		#endregion

		#region Methods: Private

		private string GetSimilarSearchUrl() {
			var uri = new Uri(_serverUrl);
			var address = uri.GetLeftPart(UriPartial.Authority);
			var index = uri.AbsolutePath;
			return $"{address}/v1/similar-search{index}";
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc cref="IMentionRepository.GetAsync{T}(SearchRequest, CancellationToken)"/>
		public async Task<SearchResponse<T>> GetAsync<T>(SearchRequest query) where T : class {
			try {
				var stringDto = JsonConvert.SerializeObject(query);
				var request = new HttpRequestMessage(HttpMethod.Post, GetSimilarSearchUrl()) {
					Content = new StringContent(stringDto, null, "application/json")
				};
				var response = await HttpClient.SendAsync(request);
				response.EnsureSuccessStatusCode();
				var responseString = await response.Content.ReadAsStringAsync();
				var result = JsonConvert.DeserializeObject<SearchResponse<T>>(responseString);
				return result;
			} catch (Exception e) {
				_log.Error("Error occured when contact mention.", e);
				throw;
			}
		}

		#endregion

	}

	#endregion

}





