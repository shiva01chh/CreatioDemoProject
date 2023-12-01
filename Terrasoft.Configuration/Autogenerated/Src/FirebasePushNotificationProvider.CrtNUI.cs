namespace Terrasoft.Configuration
{
	using System;
	using System.Net;
	using System.Runtime.Serialization;
	using System.Text;
	using System.Collections.Generic;
	using global::Common.Logging;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region Class: FirebasePushNotificationProvider

	/// <summary>
	/// Firebase push notification provider.
	/// </summary>
	public class FirebasePushNotificationProvider : IPushNotificationProvider
	{
		private const string FCM_NotRegistered = "NotRegistered";
		private const string FCM_InvalidRegistration = "InvalidRegistration";

		#region Class: FCMResponse

		[Serializable]
		private class FCMResponseResult
		{
			[JsonProperty("message_id")]
			public string MessageId { get; set; }

			[JsonProperty("error")]
			public string Error { get; set; }
		}

		[Serializable]
		private class FCMResponse
		{
			[JsonProperty("multicast_id")]
			public long MulticastId { get; set; }

			[JsonProperty("canonical_ids")]
			public long CanonicalIds { get; set; }

			[JsonProperty("success")]
			public long Success { get; set; }

			[JsonProperty("failure")]
			public long Failure { get; set; }

			[JsonProperty("results")]
			public List<FCMResponseResult> Results { get; set; }
		}

		#endregion

		#region Class: FCMRequest

		/// <summary>
		/// Represents push notification request.
		/// </summary>
		[DataContract]
		private class FCMRequest
		{

			#region Properties: Public

			/// <summary>
			/// Device token.
			/// </summary>
			[JsonProperty("to")]
			public string Token { get; set; }

			/// <summary>
			/// Devices tokens.
			/// </summary>
			[JsonProperty("registration_ids")]
			public string[] Tokens { get; set; }

			/// <summary>
			/// Message.
			/// </summary>
			[JsonProperty("notification")]
			public NotificationData Notification { get; set; }

			/// <summary>
			/// Message.
			/// </summary>
			[JsonProperty("data")]
			public Dictionary<string, string> Data { get; set; }

			#endregion

		}

		/// <summary>
		/// Represents push notification request data.
		/// </summary>
		[DataContract]
		private class NotificationData
		{

			#region Properties: Public

			/// <summary>
			/// Message.
			/// </summary>
			[JsonProperty("body")]
			public string Message { get; set; }

			/// <summary>
			/// Title.
			/// </summary>
			[JsonProperty("title")]
			public string Title { get; set; }

			/// <summary>
			/// Title.
			/// </summary>
			[JsonProperty("sound")]
			public string Sound { get; set; }

			/// <summary>
			/// Title.
			/// </summary>
			[JsonProperty("icon")]
			public string Icon { get; set; }

			#endregion

		}

		#endregion

		#region Constructors: Public

		public FirebasePushNotificationProvider(string settings) {
			_settings = JObject.Parse(settings);
			_userConnection = ClassFactory.Get<UserConnection>();
		}

		#endregion

		#region Properties: Private

		private readonly JObject _settings;
		private readonly UserConnection _userConnection;

		private static readonly ILog _log = LogManager.GetLogger("PushNotification.Firebase");
		private static readonly int _maxTokenCount = 999;
		private static readonly Guid _firebaseServiceId = new Guid("24B535DE-3424-4294-BEBB-C5E4F8E48D75");

		private string Url {
			get { return (string)_settings["url"]; }
		}

		private string ApiKey {
			get { return (string)_settings["apiKey"]; }
		}

		#endregion

		#region Methods: Private

		private string[] GetTokens(Guid sysAdminUnitId) {
			EntitySchema schema = _userConnection.EntitySchemaManager.GetInstanceByName("PushNotificationToken");
			var esq = new EntitySchemaQuery(schema);
			EntitySchemaQueryColumn tokenColumn = esq.AddColumn("Token");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Service", _firebaseServiceId));
			if (IsUser(sysAdminUnitId)) {
				esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "SysAdminUnit.Id", sysAdminUnitId));
			} else {
				esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal,
					"[SysAdminUnitInRole:SysAdminUnit:SysAdminUnit].SysAdminUnitRoleId", sysAdminUnitId));
			}
			esq.IsDistinct = true;
			EntityCollection entityCollection = esq.GetEntityCollection(_userConnection);
			string[] tokens = new string[entityCollection.Count];
			for (int i = 0; i < entityCollection.Count; i++) {
				Entity item = entityCollection[i];
				var token = item.GetTypedColumnValue<string>(tokenColumn.Name);
				tokens[i] = token;
			}
			_log.DebugFormat("Received {0} tokens for SysAdminUnitId", tokens.Length.ToString(), sysAdminUnitId);
			return tokens;
		}
		
		private bool IsUser(Guid sysAdminUnitId) {
			var sysAdminUnitSelect = new Select(_userConnection).Column("SAU", "Id")
				.From("SysAdminUnit").As("SAU")
				.Where("Id").IsEqual(Column.Const(sysAdminUnitId))
				.And()
				.OpenBlock("SAU", "SysAdminUnitTypeValue")
				.IsEqual(Column.Const((int)Terrasoft.Core.DB.SysAdminUnitType.User))
				.Or("SAU", "SysAdminUnitTypeValue")
				.IsEqual(Column.Const((int)Terrasoft.Core.DB.SysAdminUnitType.SelfServicePortalUser))
				.CloseBlock() as Select;
			return sysAdminUnitSelect.ExecuteScalar<Guid>().IsNotEmpty();
		}

		private void PostData(string[] tokens, string title, string message,
			Dictionary<string, string> additionalData) {
			NotificationData notificationData = new NotificationData {
				Message = message,
				Title = title,
				Sound = "default"
			};
			for (int i = 0; i < tokens.Length; i += _maxTokenCount) {
				int length = Math.Min(_maxTokenCount, tokens.Length - i);
				var buffer = new string[length];
				Array.Copy(tokens, i, buffer, 0, length);
				var request = new FCMRequest {
					Tokens = buffer,
					Notification = notificationData,
					Data = additionalData
				};
				SendData(request);
			}
		}

		private void SendData(FCMRequest request) {
			var uriAddress = new Uri(new Uri(Url), "send");
			string postData = JsonConvert.SerializeObject(request);
			string responseBody = PostRequest(uriAddress, ApiKey, postData);
			FCMResponse response = JsonConvert.DeserializeObject<FCMResponse>(responseBody);
			for (var i = 0; i < response.Results.Count; i++) {
				FCMResponseResult item = response.Results[i];
				if (item.Error != null) {
					string badToken = request.Tokens[i];
					if (item.Error == FCM_InvalidRegistration || item.Error == FCM_NotRegistered) {
						var deleteQuery = new Delete(_userConnection).From("PushNotificationToken").Where("Token")
							.IsEqual(Column.Parameter(badToken));
						deleteQuery.Execute();
						_log.InfoFormat("Deleting a token({0}) due to its inactivity({1})",
							anonymizeToken(badToken), item.Error);
					} else {
						_log.ErrorFormat("Can't deliver push notification message to token ({0})." + " Error: {1}",
							anonymizeToken(badToken), item.Error);
					}
				}
			}
		}

		private string anonymizeToken(string token) {
			return token.Substring(0, token.Length > 20 ? 20 : token.Length);
		}

		#endregion

		#region Methods: Protected

		protected virtual string PostRequest(Uri uriAddress, string apiKey, string postData) {
			using (var webClient = new WebClient()) {
				webClient.Encoding = Encoding.UTF8;
				webClient.Headers.Add("Authorization", "key=" + apiKey);
				webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
				try {
					return webClient.UploadString(uriAddress, "POST", postData);
				} catch (Exception e) {
					_log.Debug("Can't send push notification:" + e.Message, e);
					throw;
				}
			}
		}

		#endregion

		#region Methods: Public

		public void Send(PushNotificationData data) {
			if (_userConnection == null) {
				_log.ErrorFormat("Can't send push({0}). UserConnection is null", data.Title);
				return;
			}
			string[] tokens;
			if (data.SysAdminUnitId == null) {
				_log.Warn("Sending messages directly through the FirebasePushNotificationProvider is not allowed." +
					" Please use the Push Notification.Send method instead.");
				#pragma warning disable CS0618
				_log.DebugFormat("Sending push({0}) for Token:{1}", data.Title, anonymizeToken(data.Token));
				tokens = new[] { data.Token };
				#pragma warning restore CS0618
			} else {
				_log.DebugFormat("Sending push({0}) for SysAdminUnitId:{1}", data.Title,
					data.SysAdminUnitId.ToString());
				tokens = GetTokens((Guid)data.SysAdminUnitId);
			}
			PostData(tokens, data.Title, data.Message, data.AdditionalData);
		}

		#endregion

	}

	#endregion

}





