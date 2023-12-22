﻿namespace Terrasoft.Configuration.Omnichannel.Messaging
{
	using global::Common.Logging;
	using OmnichannelMessaging;
	using OmnichannelProviders.Domain.Entities;
	using Direction = OmnichannelProviders.Domain.Entities.MessageDirection;
	using System;
	using System.Collections.Generic;
	using System.Runtime.Serialization;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core;
	using Terrasoft.Core.Requests;
	using Terrasoft.Monitoring;
	using Terrasoft.Web.Common;
	using System.Diagnostics;
	using Terrasoft.Configuration.BpmonlineCloudIntegration;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Store;
	using Newtonsoft.Json;
	using OmnichannelMessaging.Exceptions;
	using MessageType = OmnichannelProviders.Domain.Entities.MessageType;

	#region Class : ErrorGenerator

	/// <summary>
	/// Class for error keys generation
	/// </summary>
	public class ErrorKeysGenerator
	{
		/// <summary>
		/// Formats sending error key
		/// </summary>
		/// <param name="errorJson">Service response as JSON object</param>
		/// <returns>Error key, depends on errorJson</returns>
		public virtual string GetSendingErrorKey(string errorJson = null) {
			return "SendError";
		}
	}
	
	#endregion
	
	#region Class: OmnichannelMessagingService

	/// <summary>
	/// BaseService for sending and receiving messages from messaging integration api.
	/// </summary>
	public class OmnichannelMessagingService : BaseService
	{

		#region Class: OmnichannelMessagingServiceResponse

		[DataContract]
		public class OmnichannelMessagingServiceResponse
		{
			[DataMember]
			public bool Success { get; set; } = true;
			[DataMember]
			public string ErrorMessage { get; set; }
		}

		#endregion

		#region Class: AccountRestResponse

		[DataContract]
		public class AccountRestResponse : OmnichannelMessagingServiceResponse
		{

			#region Properties: Public

			/// <summary>
			/// Account id.
			/// </summary>
			[DataMember]
			public Guid AccountId { get; set; }

			/// <summary>
			/// Is account active.
			/// </summary>
			[DataMember]
			public bool IsActive { get; set; }

			/// <summary>
			/// Creatio URL.
			/// </summary>
			[DataMember]
			public string CreatioUrl { get; set; }

			#endregion

		}

		#endregion

		#region Class: MessageSendingError

		public enum MessageSendingError
		{
			None,
			Internal,
			Messenger
		}

		#endregion

		#region Class: OmnichannelMessagingMessageMetric

		/// <summary>
		/// Implementation of <see cref="IMetric"/> for messaging monitoring.
		/// </summary>
		public class OmnichannelMessagingMessageMetric : IMetric
		{

			#region Properties: Public

			/// <summary>
			/// Message source.
			/// </summary>
			public ChannelType Source { get; set; }

			/// <summary>
			/// Message source.
			/// </summary>
			public OmnichannelProviders.Domain.Entities.MessageType Type { get; set; }

			/// <summary>
			/// Sending message duration.
			/// </summary>
			public long Duration { get; set; }

			/// <summary>
			/// Sending message size.
			/// </summary>
			public long Size { get; set; }

			/// <summary>
			/// Direction of message.
			/// </summary>
			public OmnichannelProviders.Domain.Entities.MessageDirection Direction { get; set; }

			/// <summary>
			/// Error type.
			/// </summary>
			public MessageSendingError ErrorType { get; set; }

			/// <summary>
			/// Metric name according to topic https://prometheus.io/docs/practices/naming/.
			/// </summary>
			public string Name => "omnichannel_messaging_message";

			#endregion

			#region Methods: Public

			/// <summary>
			/// Get metric values.
			/// </summary>
			public IDictionary<string, object> GetFieldValues() {
				return new Dictionary<string, object> {
					{ "duration", Duration },
					{ "size", Size },
					{ "direction", (int)Direction },
					{ "type", Type.ToString().ToLowerInvariant() },
					{ "error", (int)ErrorType }
				};
			}

			/// <summary>
			/// Get additional metric tags.
			/// </summary>
			public IDictionary<string, object> GetTags() {
				return new Dictionary<string, object> {
					{ "source", Source.ToString().ToLowerInvariant() }
				};
			}

			#endregion

		}
		
		#region Class: CacheMessage
	
		/// <summary>
		/// Object to store short message info in cache
		/// </summary>
		[Serializable]
		public class CacheMessage
		{

			#region Properties: Public

			public string SourceId { get; set; }
			public long Timestamp { get; set; }

			#endregion

		}
	
		#endregion

		#endregion

		#region Properties: Private

		private readonly ICacheStore _applicationCache;
		private const string _messageCachePrefix = "CacheMessage_";
		
		#endregion
		
		#region Properties: Protected

		protected static IMetricReporter MetricReporter;

		private ILog _log;
		protected ILog Log {
			get {
				return _log ?? (_log = LogManager.GetLogger("OmnichannelMessageHandler"));
			}
		}

		private OmnichannelChatProvider _chatProvider;
		protected OmnichannelChatProvider ChatProvider {
			get {
				return _chatProvider = _chatProvider ?? new OmnichannelChatProvider(UserConnection);
			}
		}

		private IdentityServerProvider _identityServerProvider;
		/// <summary>
		/// Identity server provider instance. Returns established provider.
		/// If established is null then create instance of <see cref="IdentityServerProvider"/> 
		/// from <see cref="ClassFactory"/>.
		/// </summary>
		protected IdentityServerProvider IdentityServerProvider {
			get {
				return _identityServerProvider = _identityServerProvider ?? CreateIdentityServerProvider();
			}
			set {
				_identityServerProvider = value;
			}
		}

		private IHttpRequestClient _requestClient;
		/// <summary>
		/// Gets or sets the rest client for Api calls.
		/// </summary>
		/// <value>
		/// The rest client.
		/// </value>
		private IHttpRequestClient RequestClient {
			get {
				if (_requestClient == null) {
					_requestClient = ClassFactory.Get<IHttpRequestClient>();
				}
				return _requestClient;
			}
			set {
				_requestClient = value;
			}
		}

		private ChatLocksRepository _chatLockRepository;
		/// <summary>
		/// Class to manage chat quick locks.
		/// </summary>
		protected ChatLocksRepository ChatLocksRepository {
			get {
				return _chatLockRepository = _chatLockRepository ?? new ChatLocksRepository(UserConnection);
			}
		}

		#endregion

		#region Properties: Public 

		private OmnichannelContactIdentifier _contactIdentifier;
		/// <summary>
		/// Contact identifier instance of <see cref="OmnichannelContactIdentifier"/> class.
		/// </summary>
		public OmnichannelContactIdentifier ContactIdentifier {
			get {
				return _contactIdentifier ?? (_contactIdentifier = new OmnichannelContactIdentifier(UserConnection));
			}
		}

		private MessageManager _messageManager;
		/// <summary>
		/// Class which save and send messages <see cref="MessageManager"/> class.
		/// </summary>
		protected MessageManager MessageManager {
			get {
				_messageManager = _messageManager ?? new MessageManager(UserConnection);
				return _messageManager;
			}
		}

		private ChatRepository _chatRepository;
		/// <summary>
		/// Chat repository instance of <see cref="ChatRepository"/> class.
		/// </summary>
		public ChatRepository ChatRepository {
			get {
				return _chatRepository ?? (_chatRepository = new ChatRepository(UserConnection));
			}
		}

		private ChatQueueDistributor _chatQueueDistributor;
		/// <summary>
		/// Chat queue distributor instance of <see cref="ChatQueueDistributor"/> class.
		/// </summary>
		public ChatQueueDistributor ChatQueueDistributor {
			get {
				return _chatQueueDistributor ?? (_chatQueueDistributor = new ChatQueueDistributor(UserConnection));
			}
		}

		private OperatorManager _operatorManager;
		/// <summary>
		/// Chat repository instance of <see cref="OperatorManager"/> class.
		/// </summary>
		public OperatorManager OperatorManager {
			get {
				return _operatorManager ?? (_operatorManager = new OperatorManager(UserConnection));
			}
		}

		private ChatOperatorNotifier _operatorNotifier;
		/// <summary>
		/// Instance of <see cref="ChatOperatorNotifier"/> class.
		/// </summary>
		public ChatOperatorNotifier OperatorNotifier {
			get {
				return _operatorNotifier ?? (_operatorNotifier = new ChatOperatorNotifier(UserConnection));
			}
		}

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes new instance of <see cref="OmnichannelMessagingService"/>.
		/// </summary>
		public OmnichannelMessagingService() {
			UserConnection = UserConnection ?? AppConnection?.SystemUserConnection;
			if (UserConnection.Current == null) {
				UserConnection.Current = UserConnection;
			}
			_applicationCache = UserConnection.ApplicationCache;
		}

		public OmnichannelMessagingService(UserConnection userConnection) : base(userConnection) {
			if (UserConnection.Current == null) {
				UserConnection.Current = UserConnection;
			}
			_applicationCache = userConnection.ApplicationCache;
		}

		/// <summary>
		/// Initializes new instance of <see cref="OmnichannelMessagingService"/>.
		/// </summary>
		static OmnichannelMessagingService() {
			MetricReporter = ClassFactory.Get<IMetricReporter>();
		}

		#endregion

		#region Methods: Private

		private IdentityServerProvider CreateIdentityServerProvider() {
			var userConnectionArg = new ConstructorArgument("userConnection", UserConnection);
			return ClassFactory.Get<IdentityServerProvider>(userConnectionArg);
		}

		private HttpRequestConfig CreateRequestConfig(HttpRequestMethod method, string url, string token) {
			return new HttpRequestConfig {
				Url = new Uri(url),
				Method = method,
				Headers = {
					{ "Authorization", $"Bearer {token}" }
				},
				RequestTimeout = 30
			};
		}

		private OmnichannelMessagingServiceResponse CreateErrorResponse<T>(string key) {
			return new OmnichannelMessagingServiceResponse {
				Success = false,
				ErrorMessage = new Common.LocalizableString(UserConnection.Workspace.ResourceStorage, typeof(T).Name,
					$"LocalizableStrings.{key}.Value").ToString()
			};
		}

		private ErrorKeysGenerator GetErrorGenerator(ChannelType channelType) {
			switch (channelType) {
				case ChannelType.Facebook:
					return new FacebookErrorKeysKeysGenerator();
			}
			
			return new ErrorKeysGenerator();
		}
		
		private bool AddMessage(MessagingMessage messagingMessage) {
			bool isNewChat;
			if (UserConnection.GetIsFeatureEnabled("FixChatMessageId")) {
				messagingMessage.ChatId = FixChatIdIfNeeded(messagingMessage, out isNewChat);
			} else {
				messagingMessage.ChatId = ChatRepository.AddMessage(messagingMessage, out isNewChat).ToString();
			}
			MessageManager.Receive(messagingMessage, messagingMessage.ChannelName);
			if (!messagingMessage.IsStandBy) {
				ChatProvider.DistributeChat(messagingMessage.ChatId, messagingMessage.ChannelQueueId, isNewChat, messagingMessage);
			}
			return isNewChat;
		}

		private void AddErrorMessageToChat(MessagingMessage messagingMessage, string errorMessage) {
			messagingMessage.Attachments = null;
			messagingMessage.MessageType = MessageType.Text;
			messagingMessage.Message += errorMessage;
			AddMessage(messagingMessage);
		}
		
		private string FixChatIdIfNeeded(MessagingMessage message, out bool isNewChat) {
			isNewChat = false;
			string chatId;
			string messageSourceId = message.MessageDirection == Direction.Incoming ? message.Sender : message.Recipient;
			CacheMessage previousMessage = _applicationCache[_messageCachePrefix + messageSourceId] as CacheMessage;
			if (previousMessage?.Timestamp > message.Timestamp) {
				Log.Info($"Found message with wrong time consistency. Message source ID: {messageSourceId}. Current timestamp = {message.Timestamp}, previous timestamp = {previousMessage.Timestamp}");
				chatId = MessageManager.GetNearestMessageChatIdBySender(messageSourceId, message.Timestamp);
				Log.Info($"Set correct chat ID = {chatId} for message source ID {messageSourceId}");
			} else {
				chatId = ChatRepository.AddMessage(message, out isNewChat).ToString();
				UpdateCacheMessage(previousMessage ?? new CacheMessage(), messageSourceId, message.Timestamp);
			}
			return chatId;
		}
		
		private void UpdateCacheMessage(CacheMessage message, string messageSourceId, long timestamp) {
			message.Timestamp = timestamp;
			message.SourceId = messageSourceId;
			_applicationCache[_messageCachePrefix + messageSourceId] = message;
		}
		
		#endregion

		#region Properties: Protected

		protected virtual string MessageReceiverUrl { get; set; }

		protected virtual string MessageRouterUrl { get; set; }


		#endregion

		#region Methods: Protected

		protected string GetIdentityToken() {
			return IdentityServerProvider.GetAccessToken("social_leadgen_api");
		}

		protected void InternalReceive(MessagingMessage messagingMessage) {
			Stopwatch stopWatch = new Stopwatch();
			var metric = new OmnichannelMessagingMessageMetric {
				Direction = messagingMessage.IsEcho ? Direction.Outcoming : Direction.Incoming,
				Size = messagingMessage.GetSize(),
				Source = messagingMessage.Source,
				Type = messagingMessage.MessageType
			};
			try {
				stopWatch.Start();
				messagingMessage.ContactId = ContactIdentifier.GetContactId(messagingMessage);
				if (messagingMessage.ContactId != null) {
					messagingMessage.ContactDisplayValue = ContactIdentifier.GetContactDisplayValue((Guid)messagingMessage.ContactId);
				}
				ChatLocksRepository.TryLockChat(messagingMessage.ChannelId, messagingMessage.SenderIfEcho, out bool lockAquired);
				if (!lockAquired) {
					ChatLocksRepository.EnqueueMessage(messagingMessage.ChannelId, messagingMessage.SenderIfEcho, messagingMessage);
					Log.Debug($"Chat message was enqueued: {messagingMessage.Message}");
					return;
				}
				AddMessage(messagingMessage);
			} catch (FileTooBigException e) {
				Log.Warn(e.Message, e);
				AddErrorMessageToChat(messagingMessage, new LocalizableString(UserConnection.Workspace.ResourceStorage, "OmnichannelMessagingService",
					"LocalizableStrings.FileTooBigError").Value);
			}
			catch (Exception e) {
				metric.ErrorType = MessageSendingError.Internal;
				Log.ErrorFormat("Error while receiving the message. Error info: {0}, StackTrace {1}", e.Message, e.StackTrace);
			} finally {
				List<object> queueItems = ChatLocksRepository
					.DequeueLockedChatsQueue(messagingMessage.ChannelId, messagingMessage.SenderIfEcho);
				while (queueItems != null) {
					foreach (var item in queueItems) {
						if (item is MessagingMessage message) {
							AddMessage(message);
							Log.Debug($"Chat message was dequeued: {message.Message}");
						} else if (item is List<Guid> list) {
							TransferChatsToQueue(list);
							Log.Debug($"Chat transfer signal from chatId={list.FirstOrDefault()} was dequeued.");
						}
					}
					queueItems = ChatLocksRepository
						.DequeueLockedChatsQueue(messagingMessage.ChannelId, messagingMessage.SenderIfEcho);
				}
				ChatLocksRepository.ReleaseChatLock(messagingMessage.ChannelId, messagingMessage.SenderIfEcho);
			}
			stopWatch.Stop();
			metric.Duration = stopWatch.ElapsedMilliseconds;
			MetricReporter.Report(metric);
		}
		protected string InternalSend(MessagingMessage messagingMessage) {
			var findChat = ChatRepository.AddOutcomingMessage(messagingMessage);
			string result;
			if (findChat.Success) {
				if(findChat.IsLastChatCompleted) {
					OperatorNotifier.NewChatCreatedNotify(new List<Guid>() { UserConnection.CurrentUser.Id }, findChat.LastChatId.ToString());
				}
				messagingMessage.ChatId = findChat.LastChatId.ToString();
				result = MessageManager.Send(messagingMessage, messagingMessage.ChannelName);
				OperatorNotifier.NewConversationMessageNotify(messagingMessage as UnifiedMessage);
			} else {
				result = findChat.ErrorInfo.Message;
			}
			return result;
		}

		protected T SendRequestWithToken<T>(HttpRequestMethod method, string url, object bodyObject = default)
			where T : OmnichannelMessagingServiceResponse, new() {
			var requestConfig = CreateRequestConfig(method, url, GetIdentityToken());
			if (bodyObject != default) {
				requestConfig.Body = bodyObject;
			}
			var response = bodyObject != default
				? RequestClient.SendWithJsonBody<T>(requestConfig)
				: RequestClient.Send<T>(requestConfig);
			if (response == null) {
				Log.Error($"OmnichannelMessagingService.SendRequestWithToken: request to url '{url}' returns null");
				return default;
			}
			Log.Debug($"OmnichannelMessagingService.SendRequestWithToken: response.Data = {JsonConvert.SerializeObject(response)}");
			return response;
		}

		protected void TransferMessageToQueue(Guid channelId, string sender) {
			string channelIdStr = channelId.ToString();
			var chats = ChatRepository.GetBotProcessingChatIds(channelId, sender);

			ChatLocksRepository.TryLockChat(channelIdStr, sender, out bool lockAquired);
			if (!lockAquired) {
				ChatLocksRepository.EnqueueMessage(channelIdStr, sender, chats);
				Log.Debug($"Chat transfer signal message was enqueued. Sender: {sender} Chat: {chats.FirstOrDefault()}");
				return;
			}
			TransferChatsToQueue(chats);
			List<object> queueItems = ChatLocksRepository.DequeueLockedChatsQueue(channelIdStr, sender);
			while (queueItems != null) {
				foreach (var item in queueItems) {
					if (item is MessagingMessage message) {
						AddMessage(item as MessagingMessage);
						Log.Debug($"Chat message was dequeued: {message.Message}");
					} else if (item is List<Guid> list) {
						TransferChatsToQueue(list);
						Log.Debug($"Chat transfer signal from chatId={list.FirstOrDefault()} was dequeued.");
					}
				}
				queueItems = ChatLocksRepository
					.DequeueLockedChatsQueue(channelIdStr, sender);
			}
			ChatLocksRepository.ReleaseChatLock(channelIdStr, sender);
		}

		protected void TransferChatsToQueue(List<Guid> chats) {
			Guid chatId = chats.FirstOrDefault();
			if (chats.Count > 1) {
				MessageManager.UpdateChatIdInMessagesByChats(chats, chatId);
				ChatRepository.DeleteUnnecessaryChats(chats.Skip(1).ToList());
			}
			ChatRepository.CloseActiveChat(chatId);
			var queueId = ChatRepository.GetChatQueueId(chatId);
			var childChatId = ChatRepository.CreateChildChat(chatId, new Dictionary<string, object> {
				{ "QueueId", queueId },
				{ "StatusId", OmnichannelMessagingConsts.WaitingForProcessing }
			});
			ChatQueueDistributor.DistributeQueueChatsByChatId(childChatId);
		}

		protected void RegisterAccount() {
			Log.Info($"RegisterAccount: OmnichannelMessagingIntegrationApiUrl is '{GlobalAppSettings.OmnichannelMessagingIntegrationApiUrl}'");
			string url = $"{GlobalAppSettings.OmnichannelMessagingIntegrationApiUrl.TrimEnd('/')}/api/account/create";
			var cretaioUrl = WebUtilities.GetBaseApplicationUrl(HttpContextAccessor.GetInstance().Request);
			Log.Info($"RegisterAccount: cretaioUrl is '{cretaioUrl}'");
			var data = new {
				CreatioUrl = cretaioUrl,
				IsActive = true
			};
			SendRequestWithToken<OmnichannelMessagingServiceResponse>(HttpRequestMethod.POST, url, data);
			Log.Info($"RegisterAccount: done");
		}

		protected AccountRestResponse GetMyAccount() {
			string url = $"{GlobalAppSettings.OmnichannelMessagingIntegrationApiUrl.TrimEnd('/')}/api/account/me";
			var response = SendRequestWithToken<AccountRestResponse>(HttpRequestMethod.POST, url, null);
			return response;
		}

		protected void RegisterAccountIfNotExists() {
			try {
				var account = GetMyAccount();
				if (account != null && account.AccountId != null && account.AccountId.IsNotEmpty()) {
					Log.Info($"Account was already found in account service. AccountId={account.AccountId}");
					return;
				}
				if (account.CreatioUrl == null) {
					throw new ArgumentNullException("CreatioUrl");
				}
				Log.Info("Registering new account in account service");
				RegisterAccount();
			} catch (Exception ex) {
				Log.ErrorFormat("Could not register account {0}", ex);
			}

		}

		protected string GetMessageReceiverUrl() {
			string url =  WebUtilities.GetBaseApplicationUrl(HttpContextAccessor.GetInstance().Request);
			return string.Concat(url.TrimEnd('/'), MessageReceiverUrl);
		}

		protected string GetMessageRouterUrl(string path) {
			string url = GlobalAppSettings.OmnichannelMessagingIntegrationApiUrl;
			return string.Concat(url.TrimEnd('/'), MessageRouterUrl, path);
		}

		protected void GetChannelAndQueueBySettingsId(Guid settingsId, MessagingMessage message) {
			Select channelSelect = new Select(UserConnection)
				.Top(1).Column("Id")
				.From("Channel")
				.Where("MsgSettingsId").IsEqual(Column.Parameter(settingsId))
				.And("IsActive").IsEqual(Column.Parameter(true)) as Select;
			channelSelect.ExecuteReader(reader => {
				message.ChannelId = reader.GetColumnValue<Guid>("Id").ToString();
			});
		}

		protected ErrorKeysGenerator GetErrorKeysGenerator(ChannelType channelType) {
			switch (channelType) {
				case ChannelType.Facebook:
					return new FacebookErrorKeysKeysGenerator();
			}

			return new ErrorKeysGenerator();
		}
		
		protected OmnichannelMessagingServiceResponse GetSendingError(ChannelType? channelType = null, string errorJson = null) {
			string errorKey = "SendError";
			if (!string.IsNullOrEmpty(errorJson) && channelType.HasValue) {
				errorKey = GetErrorGenerator(channelType.Value).GetSendingErrorKey(errorJson);
			}
			
			return CreateErrorResponse<OmnichannelOutcomeMessagingService>(errorKey);
		}

		#endregion
		
	}

	#endregion

}














