﻿namespace Terrasoft.Configuration.Enrichment
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Net;
	using System.Runtime.Serialization;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using System.Threading.Tasks;
	using Core.Configuration;
	using Core.DB;
	using Core.Entities;
	using Core.Factories;
	using EnrichmentDto;
	using global::Common.Logging;
	using RestSharp;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.OAuthIntegration;
	using Terrasoft.Web.Common;
	using Terrasoft.Web.Http.Abstractions;

	#region Class: EnrichmentService

	/// <summary>
	/// Enrichment cloud service proxy.
	/// </summary>
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class EnrichmentService : BaseService, System.Web.SessionState.IReadOnlySessionState
	{

		#region Class: AccountData

		private class AccountData
		{
			public AccountData(string name, List<string> urls, List<string> emails) {
				Name = name;
				Urls = urls;
				Emails = emails;
			}

			public string Name { get; }
			public List<string> Urls { get; }
			public List<string> Emails { get; }
			public bool IsEnoughData => Urls.Count > 0 || Emails.Count > 0;

			public void MapSearchInfoRequestData(SearchInfoRequest request) {
				request.Name = Name;
				request.Urls = Urls;
				request.Emails = Emails;
			}
		}

		#endregion

		#region Constants: Private

		private const string CompanyNameParameter = "companyName";
		private const string ApiKeyParameter = "key";
		private const string SuggestCompaniesMethodName = "suggest";
		private const string SearchMethodName = "search";
		private const string AccountEnrichedDataSchemaName = "AccountEnrichedData";

		#endregion

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger("Enrichment");
		private readonly List<string> _socialDomainList = new List<string> {
			"facebook.com",
			"twitter.com",
			"linkedin.com",
			"plus.google.com",
			"youtube.com",
			"instagram.com",
			"slideshare.net",
			"pinterest.com"
		};
		private IRestClient _restClient;

		#endregion

		#region Constructors: Public

		public EnrichmentService() {
			Initialize();
		}

		#endregion

		#region Properties: Protected

		private IIdentityServiceWrapper _identityServiceWrapper;
		protected virtual IIdentityServiceWrapper IdentityServiceWrapper =>
			_identityServiceWrapper ?? (_identityServiceWrapper = GlobalAppSettings.FeatureUseSeparateSettingsForOAuth20
				? ClassFactory.Get<IIdentityServiceWrapper>("ExternalAccess")
				: ClassFactory.Get<IIdentityServiceWrapper>());

		#endregion

		#region Methods: Private

		private void Initialize() {
			ServicePointManager.UseNagleAlgorithm = false;
			if (!ClassFactory.TryGet("EnrichmentServiceRestClient", out _restClient)) {
				_restClient = RestClientFactory.CreateRestClient();
			}
		}

		private bool IsSocialLink(string url) {
			try {
				var uriBuilder = new UriBuilder(url);
				string domain = uriBuilder.Host;
				bool result = _socialDomainList.Any(domain.Contains);
				return result;
			} catch (Exception) {
				return false;
			}
		}

		private AccountData SetupAccountData(Guid accountId) {
			var schema = UserConnection.EntitySchemaManager.GetInstanceByName("Account");
			var esq = new EntitySchemaQuery(schema);
			var accountColumn = esq.AddColumn("Name");
			var mainContactEmailColumn = esq.AddColumn("PrimaryContact.Email");
			var numberColumn = esq.AddColumn("[AccountCommunication:Account:Id].Number");
			var commTypeColumn = esq.AddColumn("[AccountCommunication:Account:Id].CommunicationType");
			var accountIdFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", accountId);
			esq.Filters.Add(accountIdFilter);
			var commTypeGroup = new EntitySchemaQueryFilterCollection(esq, LogicalOperationStrict.Or);
			commTypeGroup.Add(esq.CreateIsNullFilter("[AccountCommunication:Account:Id].CommunicationType"));
			var commTypeFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal,
				"[AccountCommunication:Account:Id].CommunicationType",
				CommunicationTypeConsts.WebId, CommunicationTypeConsts.EmailId);
			commTypeGroup.Add(commTypeFilter);
			esq.Filters.Add(commTypeGroup);
			var list = esq.GetEntityCollection(UserConnection);
			string accountName = string.Empty;
			string primaryContactEmail = string.Empty;
			var urls = new List<string>();
			var emails = new List<string>();
			var webCommunicationTypeId = new Guid(CommunicationTypeConsts.WebId);
			foreach (var item in list) {
				if (string.IsNullOrEmpty(accountName)) {
					accountName = item.GetTypedColumnValue<string>(accountColumn.Name);
				}
				if (string.IsNullOrEmpty(primaryContactEmail)) {
					primaryContactEmail = item.GetTypedColumnValue<string>(mainContactEmailColumn.Name);
				}
				var value = item.GetTypedColumnValue<string>(numberColumn.Name);
				if (string.IsNullOrEmpty(value)) {
					continue;
				}
				if (item.GetTypedColumnValue<Guid>(commTypeColumn.Name + "Id") == webCommunicationTypeId) {
					if (!IsSocialLink(value)) {
						urls.Add(value);
					}
				} else {
					emails.Add(value);
				}
			}
			if (urls.Count == 0 && emails.Count == 0 && primaryContactEmail.IsNotNullOrEmpty()) {
				emails.Add(primaryContactEmail);
			}
			return new AccountData(accountName, urls, emails);
		}

		private void ClearPreviousSearchData(Guid accountId) {
			var delete = (Delete)new Delete(UserConnection)
				.From(AccountEnrichedDataSchemaName)
				.Where("AccountId").IsEqual(new QueryParameter(accountId));
			delete.Execute();
		}

		private bool UpdateEnrichedData(Guid accountId, IList<CommunicationInfo> data) {
			data.CheckArgumentNull(nameof(data));
			ClearPreviousSearchData(accountId);
			DateTime date = UserConnection.CurrentUser.GetCurrentDateTime();
			foreach (var info in data) {
				EntitySchema enrichedSchema =
					UserConnection.EntitySchemaManager.GetInstanceByName(AccountEnrichedDataSchemaName);
				Entity entity = enrichedSchema.CreateEntity(UserConnection);
				entity.SetDefColumnValues();
				entity.SetColumnValue("SearchDate", date);
				entity.SetColumnValue("CategoryTag", info.Type);
				entity.SetColumnValue("Value", info.Value);
				entity.SetColumnValue("AccountId", accountId);
				entity.Save();
			}
			return data.Count > 0;
		}

		private SearchInfoRequest PrepareEnrichmentRequest(AccountData accountData) {
			GetRequiredParameters(out string serviceUrl, out string apiKey);
#if NETFRAMEWORK
			_restClient.BaseUrl = serviceUrl;
#else
			_restClient.BaseUrl = new Uri(serviceUrl);
#endif
			_restClient.AddDefaultHeader("ApiKey", apiKey);
			int maxSocialLinksCount = SysSettings.GetValue(UserConnection, "EnrichmentSocialLinksLimit", 3);
			int maxPhoneNumbersCount = SysSettings.GetValue(UserConnection, "EnrichmentPhoneNumbersLimit", 3);
			int maxEmailsCount = SysSettings.GetValue(UserConnection, "EnrichmentEmailsLimit", 3);
			var requestBody = new SearchInfoRequest {
				ApiKey = apiKey,
				Config = new SearchInfoConfiguration {
					MaxSocialLinksCount = maxSocialLinksCount,
					MaxPhoneNumberCount = maxPhoneNumbersCount,
					MaxEmailsCount = maxEmailsCount
				}
			};
			accountData.MapSearchInfoRequestData(requestBody);
			return requestBody;
		}

		private bool EnrichAccountData(Guid accountId, SearchInfoRequest requestBody) {
			IRestRequest request = _restClient.CreateJsonRequest(SearchMethodName, requestBody)
				.WithOAuth<EnrichmentFeatures.UseOAuth>(IdentityServiceWrapper,
					EnrichmentConstants.EnrichmentOAuthScope);
			IRestResponse response;
			try {
				response = _restClient.Post(request);
			} catch (Exception ex) {
				throw new HttpException((int)HttpStatusCode.InternalServerError, ex.Message);
			}
			response.HandleError();
			SearchInfoResponse responseInfo = ServiceStackTextHelper.Deserialize<SearchInfoResponse>(response.Content);
			if (responseInfo.Status == "error") {
				throw new HttpException((int)HttpStatusCode.InternalServerError, responseInfo.Message);
			}
			if (responseInfo.CommunicationInfo == null) {
				var message = $"CommunicationInfo is null. StatusCode = '{response.StatusCode}' " +
					$"ResponseStatus = '{response.ResponseStatus}' ErrorMessage = '{response.ErrorMessage}' " +
					$"Content: {response.Content}";
				throw new HttpException((int)HttpStatusCode.InternalServerError, message);
			}
			bool result = UpdateEnrichedData(accountId, responseInfo.CommunicationInfo);
			return result;
		}

		/// <summary>
		/// Gets the API key.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <returns>Api key without leading and trailing whitespaces.</returns>
		private static string GetAPIKey(UserConnection userConnection) {
			var key = (string)SysSettings.GetValue(userConnection, "CloudServicesAPIKey");
			if (key.IsNotNullOrEmpty()) {
				key = key.Trim();
			}
			return key;
		}

		private void GetRequiredParameters(out string serviceUrl, out string apiKey) {
			serviceUrl = SysSettings.GetValue(UserConnection, "AccountEnrichmentServiceUrl", string.Empty);
			if (serviceUrl.IsNullOrEmpty()) {
				throw new HttpException((int)HttpStatusCode.InternalServerError,
					"Enrichment account service url not set");
			}
			apiKey = GetAPIKey(UserConnection);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Gets companies list by partial name.
		/// </summary>
		/// <param name="name">Partial company name.</param>
		/// <returns>Collection of companies info.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped,
			ResponseFormat = WebMessageFormat.Json)]
		[return: MessageParameter(Name = "result")]
		public async Task<SuggestCompaniesResult> SuggestCompanies(string name) {
			GetRequiredParameters(out string serviceUrl, out string apiKey);
#if NETFRAMEWORK
			_restClient.BaseUrl = serviceUrl;
#else
			_restClient.BaseUrl = new Uri(serviceUrl);
#endif
			_restClient.AddDefaultHeader("ApiKey", apiKey);
			IRestRequest request;
			try {
				request = _restClient.CreateRequest(SuggestCompaniesMethodName)
					.WithOAuth<EnrichmentFeatures.UseOAuth>(IdentityServiceWrapper, EnrichmentConstants.EnrichmentOAuthScope);
			} catch (OAuthIntegration.Exception.ApiServerException e) {
				return new SuggestCompaniesResult {
					ResultType = EnrichmentServiceResultType.AuthenticationError,
					ErrorMessage = e.Message
				};
			}
			request.AddParameter(CompanyNameParameter, name);
			request.AddParameter(ApiKeyParameter, apiKey);
			IRestResponse response;
			try {
				response = await _restClient.ExecutePostTaskAsync(request).ConfigureAwait(false);
			} catch (Exception ex) {
				return new SuggestCompaniesResult {
					ResultType = ex is UnauthorizedAccessException
						? EnrichmentServiceResultType.AuthenticationError
						: EnrichmentServiceResultType.InternalError,
					ErrorMessage = ex.Message
				};
			}
#if !NETFRAMEWORK
			if (!response.IsSuccessful) {
				string message = response.Content.IsNotNullOrEmpty() ? response.Content : response.StatusDescription;
				return new SuggestCompaniesResult {
					ResultType = response.StatusCode == HttpStatusCode.Unauthorized
						? EnrichmentServiceResultType.AuthenticationError
						: EnrichmentServiceResultType.InternalError,
					ErrorMessage = message
				};
			}
#endif
			var responseInfo = ServiceStackTextHelper.Deserialize<CloudRestResponse>(response.Content);
			if (responseInfo?.CompaniesInfo == null) {
				return new SuggestCompaniesResult {
					ResultType = EnrichmentServiceResultType.InternalError,
					ErrorMessage = response.Content
				};
			}
			return new SuggestCompaniesResult {
				CompanyInfos = responseInfo.CompaniesInfo
			};
		}

		/// <summary>
		/// Does data enrichment for account.
		/// </summary>
		/// <param name="accountId">Target account id for enrichment process.</param>
		/// <returns>Collection of found info.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped,
			ResponseFormat = WebMessageFormat.Json)]
		[return: MessageParameter(Name = "result")]
		public SearchAccountInfoResult SearchAccountInfo(Guid accountId) {
			AccountData accountData = SetupAccountData(accountId);
			if (!accountData.IsEnoughData) {
				return new SearchAccountInfoResult {
					IsSuccessSearch = false,
					IsEnoughDataForEnrichment = false,
					ResultType = EnrichmentServiceResultType.Success
				};
			}
			bool success;
			try {
				SearchInfoRequest requestBody = PrepareEnrichmentRequest(accountData);
				success = EnrichAccountData(accountId, requestBody);
			} catch (Exception e) {
				_log.Error($"Error while executing SearchAccountInfo for {accountId}", e);
				return new SearchAccountInfoResult {
					IsSuccessSearch = false,
					ResultType = e is UnauthorizedAccessException || e is OAuthIntegration.Exception.ApiServerException
						? EnrichmentServiceResultType.AuthenticationError
						: EnrichmentServiceResultType.InternalError,
					ErrorMessage = e.Message
				};
			}
			var result = new SearchAccountInfoResult {
				IsSuccessSearch = success,
				IsEnoughDataForEnrichment = true,
				ResultType = EnrichmentServiceResultType.Success
			};
			return result;
		}

		#endregion

	}

	#endregion

	#region Class: SearchAccountInfoResult

	/// <summary>
	/// Represents response of company autocomplete service.
	/// </summary>
	[DataContract]
	public class SearchAccountInfoResult
	{

		#region Properties: Public

		/// <summary>
		/// Returns true if any new information where found.
		/// </summary>
		[DataMember(Name = "isSuccessSearch")]
		public bool IsSuccessSearch { get; set; }

		/// <summary>
		/// Returns true if enrichment is impossible due to lack of data.
		/// </summary>
		[DataMember(Name = "isEnoughDataForEnrichment")]
		public bool IsEnoughDataForEnrichment { get; set; }

		/// <summary>
		/// Returns result type <see cref="EnrichmentServiceResultType"/>.
		/// </summary>
		[DataMember(Name = "resultType")]
		public string ResultType { get; set; } = EnrichmentServiceResultType.Success;

		/// <summary>
		/// Error message.
		/// </summary>
		[DataMember(Name="errorMessage")]
		public string ErrorMessage { get; set; }

		#endregion

	}

	#endregion

	/// <summary>
	/// Represents response of company suggestions service.
	/// </summary>
	[DataContract]
	public class SuggestCompaniesResult
	{

		/// <summary>
		/// Info about companies.
		/// </summary>
		[DataMember(Name = "companyInfos")]
		public List<ShortCompanyInfo> CompanyInfos { get; set; } = new List<ShortCompanyInfo>();

		/// <summary>
		/// Returns result type <see cref="EnrichmentServiceResultType"/>.
		/// </summary>
		[DataMember(Name = "resultType")]
		public string ResultType { get; set; } = EnrichmentServiceResultType.Success;

		/// <summary>
		/// Error message.
		/// </summary>
		[DataMember(Name="errorMessage")]
		public string ErrorMessage { get; set; }
	}

	public static class EnrichmentServiceResultType
	{
		public const string Success = nameof(Success);
		public const string AuthenticationError = nameof(AuthenticationError);
		public const string InternalError = nameof(InternalError);
	}

}














