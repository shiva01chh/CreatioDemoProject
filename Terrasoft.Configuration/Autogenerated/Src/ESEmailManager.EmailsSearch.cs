namespace Terrasoft.Configuration.EmailsSearch
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using global::Common.Logging;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.GlobalSearch;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.ElasticSearch;
	using Terrasoft.GlobalSearch;

	#region class: ESEmailManager

	[DefaultBinding(typeof(IESEmailManager))]
	public class ESEmailManager : IESEmailManager
	{
		#region Constants: Private

		private readonly ILog _log = LogManager.GetLogger("EmailsSearch");
		private readonly string _communicationSuffix = "Communication_text";
		private readonly string _detailCommunicationEmailKey = "text";
		private readonly string _detailKey = "details";
		private readonly int _defConfigSize = 15;

		#endregion

		#region Fields: Private

		private readonly IElasticSearchRepository _elasticSearchRepository;
		private readonly IESQueryBuilder _queryBuilder;
		private List<string> _queries = new List<string>();

		#endregion

		#region Constructors: Public

		public ESEmailManager() {}

		public ESEmailManager(IElasticSearchRepository elasticSearchRepository,
			IESQueryBuilder queryBuilder, UserConnection userConnection) {
			_elasticSearchRepository = elasticSearchRepository;
			_queryBuilder = queryBuilder;
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// User connection.
		/// </summary>
		protected UserConnection UserConnection { get; set; }

		/// <summary>
		/// Email with name format string.
		/// </summary>
		protected virtual string ContactFormat { get; set; } = "{0} <{1}>";

		/// <summary>
		/// Email with name and account format string.
		/// </summary>
		protected virtual string AccountFormat { get; set; } = "{0} ({1}) <{2}>";

		/// <summary>
		/// Starting index of data sampling.
		/// </summary>
		protected virtual int ConfigFrom { get; set; } = 0;

		/// <summary>
		/// Maximum number of record returned from response.
		/// </summary>
		protected virtual int ConfigSize {
			get {
				if (_configSize == default) {
					_configSize = Core.Configuration.SysSettings.GetValue(UserConnection,
						"EmailSearchDefConfigSize", _defConfigSize);
				}
				return _configSize;
			} set {
				_configSize = value;
			}
		}
		private int _configSize;

		#endregion

		#region Methods: Private

		/// <summary>
		/// Convert elasticsearch response to client response.
		/// </summary>
		/// <param name="objectCollection">Elasticsearch response.</param>
		/// <param name="schemaName">Schema name.</param>
		/// <returns>Converted elasticsearch response.</returns>
		protected virtual IEnumerable<object> GetCollection(IEnumerable<Dictionary<string, object>> objectCollection,
				string schemaName) {
			foreach (var item in objectCollection) {
				var responseItem = new Dictionary<string, string>();
				string lowerSchemaName = schemaName.ToLowerInvariant();
				string nameProperty = lowerSchemaName + (lowerSchemaName == "lead" ? "_leadname" : "_name");
				string accountProperty = lowerSchemaName + "_account";
				if (GlobalAppSettings.FeatureIndexCommunicationOptionsAndLookupsBy2Symbols) {
					nameProperty = nameProperty + ESConstants.PrimaryColumnsSuffix;
					accountProperty = accountProperty + ESConstants.PrimaryColumnsSuffix;
				}
				string itemName = GetItemValue(item, nameProperty);
				string itemEmail = GetItemValue(item, lowerSchemaName + "_email");
				string itemAccount = GetItemValue(item, accountProperty);
				AddSchemaEmail(responseItem, itemEmail, itemName, itemAccount);
				AddDetailEmails(responseItem, item, schemaName, itemName, itemAccount);
				if (responseItem.Count > 0) {
					yield return responseItem;
				}
			}
		}

		/// <summary>
		/// Add emails from schema details to result collection.
		/// </summary>
		/// <param name="responseItem">Resut collection.</param>
		/// <param name="item">Elasticsearch response item.</param>
		/// <param name="schemaName">Schema name.</param>
		/// <param name="itemName">Response item name.</param>
		/// <param name="itemAccount">Response item account.</param>
		private void AddDetailEmails(Dictionary<string, string> responseItem, Dictionary<string, object> item,
				string schemaName, string itemName, string itemAccount) {
			if (item.ContainsKey(_detailKey)) {
				var json = GetItemValue(item, _detailKey);
				foreach (var email in ParseDetail(json, schemaName)) {
					string emailWithName = GetEmailWithName(email, itemName, itemAccount);
					AddResultItem(responseItem, emailWithName);
				}
			}
		}

		/// <summary>
		/// Add emal from schema to result collection.
		/// </summary>
		/// <param name="responseItem">Resut collection.</param>
		/// <param name="schemaEmail">Response item email.</param>
		/// <param name="schemaName">Response item name.</param>
		/// <param name="itemAccount">Response item account name.</param>
		private void AddSchemaEmail(Dictionary<string, string> responseItem, string schemaEmail, string schemaName,
				string itemAccount) {
			if (schemaName.IsNotNullOrEmpty() && schemaEmail.IsNotNullOrEmpty()) {
				string emailWithName = GetEmailWithName(schemaEmail, schemaName, itemAccount);
				AddResultItem(responseItem, emailWithName);
			}
		}

		/// <summary>
		/// Compare input queries with elasticsearch response value.
		/// </summary>
		/// <param name="esValue">Response value.</param>
		/// <returns>True if input queries containt with elasticsearch response value, false otherwise.</returns>
		private bool IsInputQueriesContainsInResult(string esValue) {
			var esValueLower = esValue.ToLower();
			foreach (var query in _queries) {
				var queryLower = query.ToLower();
				if (!esValueLower.Contains(queryLower)) {
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// Add item to <paramref name="responseItem"/> collection.
		/// </summary>
		/// <param name="responseItem"></param>
		/// <param name="key">Key of <paramref name="responseItem"/> collection</param>
		/// <param name="key">Value of <paramref name="responseItem"/> collection</param>
		private void AddResultItem(Dictionary<string, string> responseItem, string key) {
			if (IsInputQueriesContainsInResult(key) && !responseItem.ContainsKey(key)) {
				responseItem.Add(key, key);
			}
		}

		/// <summary>
		/// Parse emails from <paramref name="json"/>.
		/// </summary>
		/// <param name="json"><see cref="JSON"/> string.</param>
		/// <param name="schemaName">Schema name.</param>
		/// <returns>Emails collection.</returns>
		private List<string> ParseDetail(string json, string schemaName) {
			var result = new List<string>();
			if (json.IsNullOrEmpty()) {
				return result;
			}
			JObject details = JsonConvert.DeserializeObject<JObject>(json);
			JToken detail = details.GetValue(schemaName + _communicationSuffix);
			if (detail != null) {
				JArray emails = detail.Value<JArray>(_detailCommunicationEmailKey);
				foreach (var email in emails) {
					result.Add(email.ToString());
				}
			}
			return result;
		}

		/// <summary>
		/// Get format string from <paramref name="email"/>, <paramref name="name"/> 
		/// and <paramref name="account"/>.
		/// </summary>
		/// <param name="email">Schema email.</param>
		/// <param name="name">Schema name.</param>
		/// <param name="account">Schema account.</param>
		/// <returns>Format string from input params.</returns>
		private string GetEmailWithName(string email, string name, string account = "") {
			return account.IsNullOrEmpty()
				? string.Format(ContactFormat, name, email)
				: string.Format(AccountFormat, name, account, email);
		}

		/// <summary>
		/// Save <see cref="QueryFilter"/> values.
		/// </summary>
		/// <param name="request"><see cref="SearchQuery"/> instance.</param>
		private void SetRequestQueries(SearchQuery request) {
			_queries.Clear();
			foreach (var rule in request.Rules) {
				foreach (var filter in rule.Filters) {
					foreach (var value in filter.Value) {
						if (!_queries.Contains(value)) {
							_queries.Add(value);
						}
					}
				}
			}
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Create default <see cref="SearchQuery"/> queries on request to elasticsearch.
		/// </summary>
		/// <param name="queries">Key requests for elasticsearch.</param>
		/// <returns>Default <see cref="SearchQuery"/> queries.</returns>
		protected List<SearchQuery> CreateESSelectQueries(List<string> queries) {
			SearchQuery contactRequest = CreateContactEsSearchQuery(queries);
			contactRequest.Rules.Add(new SearchQueryRule() {
				Filters = new List<SearchQueryFilter>() {
							new SearchQueryFilter() {
								SchemaName = "Contact",
								ColumnName = "Account",
								Value = queries
							}
						}
			});
			var accountRequest = new SearchQuery() {
				SchemaName = "Account",
				Columns = new List<string> {
					"Name",
					"details"
				},
				Rules = new List<SearchQueryRule>() {
					new SearchQueryRule() {
						Filters = new List<SearchQueryFilter>() {
							new SearchQueryFilter() {
								SchemaName = "AccountCommunication",
								Type = CommunicationTypeConsts.EmailId,
								Value = queries
							}
						}
					},
					new SearchQueryRule() {
						Filters = new List<SearchQueryFilter>() {
							new SearchQueryFilter() {
								SchemaName = "Account",
								ColumnName = "Name",
								Value = queries
							}
						}
					}
				}
			};
			if (UserConnection.EntitySchemaManager.FindItemByName("Lead") == null) {
				return new List<SearchQuery>() {
					contactRequest,
					accountRequest
				};
			}
			var leadRequest = new SearchQuery() {
				SchemaName = "Lead",
				Columns = new List<string> {
					"LeadName",
					"Email"
				},
				Rules = new List<SearchQueryRule>() {
					new SearchQueryRule() {
						Filters = new List<SearchQueryFilter>() {
							new SearchQueryFilter() {
								SchemaName = "Lead",
								ColumnName = "Email",
								Value = queries
							}
						}
					},
					new SearchQueryRule() {
						Filters = new List<SearchQueryFilter>() {
							new SearchQueryFilter() {
								SchemaName = "Lead",
								ColumnName = "LeadName",
								Value = queries
							}
						}
					}
				}
			};

			return new List<SearchQuery>() {
				contactRequest,
				accountRequest,
				leadRequest
			};
		}

		protected SearchQuery CreateContactEsSearchQuery(List<string> queries) {
			return new SearchQuery() {
				SchemaName = "Contact",
				Columns = new List<string> {
					"Name",
					"Email",
					"details"
				},
				Rules = new List<SearchQueryRule>() {
					new SearchQueryRule() {
						Filters = new List<SearchQueryFilter>() {
							new SearchQueryFilter() {
								SchemaName = "ContactCommunication",
								Type = CommunicationTypeConsts.EmailId,
								Value = queries
							}
						}
					},
					new SearchQueryRule() {
						Filters = new List<SearchQueryFilter>() {
							new SearchQueryFilter() {
								SchemaName = "Contact",
								ColumnName = "Name",
								Value = queries
							}
						}
					},
					new SearchQueryRule() {
						Filters = new List<SearchQueryFilter>() {
							new SearchQueryFilter() {
								SchemaName = "Contact",
								ColumnName = "Email",
								Value = queries
							}
						}
					}
				}
			};
		}

		/// <summary>
		/// Get value from <paramref name="item"/> by <paramref name="propertyName"/>
		/// </summary>
		/// <param name="item">Datas container.</param>
		/// <param name="propertyName">Property name.</param>
		/// <returns>Value from <paramref name="propertyName"/> key.</returns>
		protected string GetItemValue(Dictionary<string, object> item, string propertyName) {
			var itemValue = item.GetValueOrDefault(propertyName, string.Empty);
			if (itemValue is Dictionary<string, object>) {
				return JsonConvert.SerializeObject(itemValue);
			}
			return itemValue == null ? string.Empty : itemValue.ToString();
		}

		/// <summary>
		/// Returns first page search results for each query from elasticsearch.
		/// </summary>
		/// <param name="queries">Key requests for elasticsearch.</param>
		/// <returns>Results record found on request.</returns>
		protected IEnumerable<object> GetFirstPages(List<SearchQuery> requests) {
			var resultCollection = new List<object>();
			foreach (var request in requests) {
				request.From = ConfigFrom;
				request.Size = ConfigSize;
				SetRequestQueries(request);
				var query = _queryBuilder.BuildQuery(request);
				if (query == null) {
					_log.Error("There is empty request");
					return null;
				}
				// TODO RND-38847
				query.DocumentName = string.Empty;
				var elasticCollection = _elasticSearchRepository.GetCollection(query);
				var collection = GetCollection(elasticCollection, request.SchemaName);
				resultCollection.AddRange(collection);
			}
			return resultCollection;
		}

		/// <summary>
		/// Returns single page search results from elasticsearch.
		/// Queries called in sequence if found entities count less than required for page.
		/// </summary>
		/// <param name="queries">Key requests for elasticsearch.</param>
		/// <param name="rowCount">Rows to search number.</param>
		/// <param name="rowsOffset">Rows to skip number.</param>
		/// <returns>Results record found on request.</returns>
		protected IEnumerable<object> GetSinglePage(List<SearchQuery> requests, int rowCount, int rowsOffset) {
			var resultCollection = new List<object>();
			foreach (var request in requests) {
				var querySize = rowCount + rowsOffset - resultCollection.Count;
				if (querySize <= 0) {
					break;
				}
				request.From = 0;
				request.Size = querySize;
				SetRequestQueries(request);
				var query = _queryBuilder.BuildQuery(request);
				if (query == null) {
					_log.Error("There is empty request");
					return null;
				}
				query.DocumentName = string.Empty;
				var elasticCollection = _elasticSearchRepository.GetCollection(query);
				var collection = GetCollection(elasticCollection, request.SchemaName);
				resultCollection.AddRange(collection);
			}
			return resultCollection.Skip(rowsOffset).Take(rowCount);
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc cref="IESEmailManager.SearchEmails(List{string}, int, int)"/>
		public virtual IEnumerable<Dictionary<string, string>> SearchEmails(List<string> queries,
				int rowCount = default, int rowsOffset = default) {
			try {
				var requests = CreateESSelectQueries(queries);
				var result = rowCount == default && rowsOffset == default
					? GetFirstPages(requests)
					: GetSinglePage(requests, rowCount, rowsOffset);
				return result.Cast<Dictionary<string, string>>();
			} catch (Exception exp) {
				_log.Error("Error occurred, when search emauls in elastic search.", exp);
				throw;
			}
		}

		#endregion

	}

	#endregion
}




