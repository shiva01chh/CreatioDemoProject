namespace OmnichannelMessaging.Telegram
{
	using Common.Logging;
	using CreatioTelegramConnector;
	using CreatioTelegramConnector.Contracts;
	using global::Telegram.Bot;
	using global::Telegram.Bot.Polling;
	using global::Telegram.Bot.Types;
	using OmnichannelProviders.Domain.Entities;
	using System;
	using System.Collections.Generic;
	using System.Threading;
	using System.Threading.Tasks;
	using Terrasoft.Configuration.Omnichannel.Messaging;
	using Terrasoft.Core;

	#region Class : SizedQueue<T>

	public sealed class FixedSizeQueue<T> : Queue<T>
	{

		#region Properties: Protected

		private int _size { get; }

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes new instance of <see cref="FixedSizeQueue<T>"/>.
		/// </summary>
		/// <param name="fixedSize">Size of queue.</param>
		public FixedSizeQueue(int fixedSize) {
			_size = fixedSize;
		}

		#endregion

		/// <summary>
		/// If the total number of item exceed the capacity, the oldest ones automatically dequeues.
		/// </summary>
		/// <returns>The dequeued value, if any.</returns>
		public new T Enqueue(T item) {
			base.Enqueue(item);
			if (base.Count > _size) {
				return base.Dequeue();
			}
			return default;
		}
	}

	#endregion

	/// <summary>
	/// Receive messages from telegram bot api.
	/// </summary>
	public class TelegramMessageReceiver : IUpdateHandler
	{
		#region Constants: Private

		private int _messagesCount = 10;

		#endregion

		#region Properties: Protected

		/// <summary>
		/// User connection.
		/// </summary>
		protected UserConnection UserConnection {
			get;
		}

		/// <summary>
		/// Last messages data received through the channel.
		/// </summary>
		protected Dictionary<string, FixedSizeQueue<string>> LastChannelMessages = new Dictionary<string, FixedSizeQueue<string>>();

		/// <summary>
		/// User connection.
		/// </summary>
		protected TelegramOmnichannelMessagingService TelegramService {
			get;
		}

		private ILog _log;
		/// <summary>
		/// Creatio logger.
		/// </summary>
		protected ILog Log {
			get {
				return _log ?? (_log = LogManager.GetLogger("OmnichannelMessageHandler"));
			}
		}

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes new instance of <see cref="TelegramOmnichannelMessagingService"/>.
		/// </summary>
		public TelegramMessageReceiver(UserConnection userConnection) {
			UserConnection = userConnection;
			TelegramService = new TelegramOmnichannelMessagingService(UserConnection);
		}

		/// <summary>
		/// Initializes new instance of <see cref="TelegramOmnichannelMessagingService"/>.
		/// </summary>
		public TelegramMessageReceiver(UserConnection userConnection, ILog logger) : this(userConnection) {
			_log = logger;
		}

		#endregion

		#region Methods: Private

		/// <summary>
		/// Sends message to Creatio.
		/// </summary>
		/// <param name="message">Message <see cref="IncomingMessage"/>.</param>
		private void OnReceivedMessage(IncomingMessage message) {
			TelegramService.ReceiveMessage(TelegramIncomeMessageWorker.Convert(message));
		}

		/// <summary>
		/// Sends message to Creatio.
		/// </summary>
		/// <param name="message">Message <see cref="FileIncomingMessage"/>.</param>
		private void OnReceivedFile(FileIncomingMessage message) {
			TelegramService.ReceiveMessage(TelegramIncomeMessageWorker.Convert(message));
			if (!string.IsNullOrEmpty(message.Text)) {
				var textMessage = TelegramIncomeMessageWorker.Convert((IncomingMessage)message);
				textMessage.MessageType = MessageType.Text;
				TelegramService.ReceiveMessage(textMessage);
			}
		}

		private void ProccessMessage(FileIncomingMessage message, bool isMessageTypeAvaliable) {
			if (TelegramUtilities.IsTextMessageType(message)) {
				OnReceivedMessage(message);
			} else if (isMessageTypeAvaliable) {
				OnReceivedFile(message);
			}
		}

		private bool IsMessageNotDuplicate(FileIncomingMessage message) {
			string messageData = GetUniqueMessageData(message);
			var result = true;
			if (LastChannelMessages.TryGetValue(message.ChannelId, out FixedSizeQueue<string> messages)) {
				result = !messages.Contains(messageData);
				messages.Enqueue(messageData);
				LastChannelMessages[message.ChannelId] = messages;
			} else {
				var channelMessages = new FixedSizeQueue<string>(_messagesCount);
				channelMessages.Enqueue(messageData);
				LastChannelMessages.Add(message.ChannelId, channelMessages);
			}
			return result;
		}

		private string GetUniqueMessageData(FileIncomingMessage message) {
			if (message.FileId != null) {
				return message.FileId;
			}
			return message.Date.ToString() + message.UserId.ToString() + message.Text;
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc cref="IUpdateHandler"/>
		public Task HandleUpdateAsync(ITelegramBotClient botClient, Update e, CancellationToken cancellationToken) {
			var message = TelegramUtilities.GetIncomnigMessage(botClient, e, out bool isMessageTypeAvaliable);
			if (IsMessageNotDuplicate(message)) {
				ProccessMessage(message, isMessageTypeAvaliable);
			} else {
				Log.Info($"Duplicate message in channel {message.ChannelId}: {message.Text}");
			}
			return Task.CompletedTask;
		}


		/// <inheritdoc cref="IUpdateHandler"/>
		public Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken) {
			Log.ErrorFormat("Error while receiving the message in Telegram channel, botId: {0}. Error message: {1}",
				botClient.BotId, exception.Message);
			return Task.CompletedTask;
		}

		#endregion

	}
}













