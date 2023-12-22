namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.ServiceModel;
	using System.ServiceModel.Web;
	using System.ServiceModel.Activation;
	using System.Text.RegularExpressions;
	using System.Threading;
	using Terrasoft.Core;
	using Terrasoft.Common;
	using Terrasoft.Configuration.CESModels;
	using Terrasoft.Configuration.CESResponses;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Web.Common;

	#region Class: MailingService

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class MailingService : BaseService
	{

		#region Fields: Private

		/// <summary>
		/// Regular expresion pattern for splitting email addresses string.
		/// </summary>
		private readonly string _emailSplitRegexPattern = @"[;,\s]\s*";

		private readonly IMailingProvider _mailingProvider;

		#endregion

		#region Constructors: Public

		public MailingService() {
			Init();
			_mailingProvider = MailingProviderBuilder.Build();
		}

		public MailingService(UserConnection userConnection) {
			UserConnection = userConnection;
			Init();
			_mailingProvider = MailingProviderBuilder.Build();
		}

		public MailingService(UserConnection userConnection, IMailingProvider mailingProvider) {
			UserConnection = userConnection;
			_mailingProvider = mailingProvider;
			Init();
		}

		#endregion

		#region Properties: Private

		private IMailingProviderBuilder MailingProviderBuilder =>
			ClassFactory.Get<IMailingProviderBuilder>(new ConstructorArgument("userConnection", UserConnection));

		#endregion

		#region Methods: Private

		private static string GetGmtOffset(TimeZoneInfo timeZoneInfo) {
			TimeSpan offset = timeZoneInfo.GetUtcOffset(DateTime.Now);
			if (offset.TotalMilliseconds == 0) {
				return "GMT";
			}
			string symbol = offset.TotalMinutes > 0 ? "+" : "-";
			return $"GMT{symbol}{timeZoneInfo.GetUtcOffset(DateTime.Now):hh\\:mm}";
		}

		private SendTestMessageData CreateSendTestMessageData(SendTestMessageRequest requestData) {
			return new SendTestMessageData {
				BulkEmailId = requestData.BulkEmailId,
				ContactId = requestData.ContactId,
				LinkedEntityId = requestData.LinkedEntityId,
				EmailRecipients = requestData.EmailRecipients,
				ReplicaMasks = requestData.ReplicaMasks
			};
		}

		private SendTestMessageResponse CreateSendTestMessageResponse(bool success, int replicasCount,
			int sentReplicasCount, string message = null) {
			return new SendTestMessageResponse {
				Success = success,
				ReplicasCount = replicasCount,
				SentReplicasCount = sentReplicasCount,
				Message = message
			};
		}

		private string GetFormattedDisplayName(string displayName, string gmtOffset) {
			if (displayName.Contains(gmtOffset)) {
				return displayName;
			}
			int firstBracket = displayName.IndexOf('(');
			int lastBracket = displayName.LastIndexOf(')');
			if (firstBracket == 0) {
				return $"{displayName.Substring(lastBracket).Replace(") ", "")} ({gmtOffset})";
			}
			return $"{displayName.Substring(0, firstBracket).Replace(") ", "")} ({gmtOffset})";
		}

		private TimeZone GetTimeZone(string timeZoneId) {
			var schema = UserConnection.EntitySchemaManager.GetInstanceByName("TimeZone").Clone() as EntitySchema;
			var esq = new EntitySchemaQuery(schema) {
				UseAdminRights = false,
			};
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			esq.AddColumn("Name");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Code", timeZoneId));
			var timezone = esq.GetEntityCollection(UserConnection).FirstOrDefault() as TimeZone;
			return timezone;
		}

		private void Init() {
			if (UserConnection == null) {
				return;
			}
			string userName = UserConnection.CurrentUser.Name;
			Thread.CurrentPrincipal = TerrasoftPrincipal.Create(userName);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Breaks process of sending.
		/// </summary>
		/// <param name="messageId">Unique identifier of the message.</param>
		/// <returns>Status of bulk email.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "BreakMailing", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public MailingResponse BreakMailing(Guid messageId) {
			return _mailingProvider.BreakMailing(messageId);
		}

		/// <summary>
		/// Connects mailing provider for account.
		/// </summary>
		/// <param name="request">Request instance with info about cloud account services.</param>
		/// <returns>The <see cref="BaseCloudResponse"/> with code, status and message.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "ConnectMailingProvider", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public BaseCloudResponse ConnectMailingProvider(UpdateCloudAccountServiceRequest request) {
			if (_mailingProvider is IMailingCesApiProvider mailingProvider) {
				return mailingProvider.ConnectMailingProvider(request);
			}
			return new BaseCloudResponse();
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "GetAvailableProviders",
			BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		public GetAvailableProvidersResponse GetAvailableProviders() {
			if (_mailingProvider is IMailingCesApiProvider mailingProvider) {
				return mailingProvider.GetAvailableProviders();
			}
			return new GetAvailableProvidersResponse();
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "GetEmailFirstScheduledDate",
			BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		public EmailFirstScheduleDateResponse GetEmailFirstScheduledDate(EmailScheduleSettings data) {
			var validator = new EmailScheduleCalculator();
			DateTime firstLaunchDate = validator.GetFirstLaunchDate(DateTime.UtcNow, data);
			return new EmailFirstScheduleDateResponse {
				FirstLaunchDate = firstLaunchDate
			};
		}

		/// <summary>
		/// Gets throttling schedules from the repository.
		/// </summary>
		/// <param name="getThrottlingScheduleRequest">Request instance with the required service id.</param>
		/// <returns>Object with list of the required throttling schedules.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "GetThrottlingSchedules", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public GetThrottlingSchedulesResponse GetThrottlingSchedules(
			GetThrottlingScheduleRequest getThrottlingScheduleRequest) {
			var throttlingSchedulesProvider = _mailingProvider as IThrottlingSchedulesProvider;
			GetThrottlingSchedulesResponse throttlingSchedulesResponse =
				throttlingSchedulesProvider?.GetThrottlingSchedules(getThrottlingScheduleRequest);
			return throttlingSchedulesResponse;
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "GetTimeZoneInfo", BodyStyle = WebMessageBodyStyle.WrappedRequest,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public CurrentTimeZoneInfo GetTimeZoneInfo(string timeZoneId) {
			string timeZoneIdToLookup =
				!string.IsNullOrEmpty(timeZoneId) ? timeZoneId : UserConnection.CurrentUser.TimeZoneId;
			TimeZoneInfo timeZoneInfo = TimeZoneUtilities.GetTimeZoneInfo(timeZoneIdToLookup);
			string gmtOffset = GetGmtOffset(timeZoneInfo);
			TimeZone timezone = GetTimeZone(timeZoneIdToLookup) ?? GetTimeZone(timeZoneInfo.StandardName);
			string displayName = GetFormattedDisplayName(timezone.Name, gmtOffset);
			return new CurrentTimeZoneInfo {
				Id = timezone.Id,
				DisplayName = displayName,
				GmtOffset = gmtOffset,
				OffsetValue = timeZoneInfo.GetUtcOffset(DateTime.Now).TotalMinutes,
				TimeZoneId = timeZoneIdToLookup
			};
		}

		/// <summary>
		/// Ping provider's service.
		/// </summary>
		/// <returns>Result of ping.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "PingProvider", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public bool PingProvider() {
			return _mailingProvider.PingProvider();
		}

		/// <summary>
		/// Sends a test email that may contain dynamic content.
		/// </summary>
		/// <param name="data">Object with data for test message sending.</param>
		/// <returns>Object with information about completion of test message sending.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "SendDCTestMessage", BodyStyle = WebMessageBodyStyle.WrappedRequest,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public SendTestMessageResponse SendDCTestMessage(SendTestMessageRequest data) {
			SendTestMessageResponse response;
			if (_mailingProvider is ITestMessageProvider testMessageProvider) {
				SendTestMessageData sendTestMessageData = CreateSendTestMessageData(data);
				SendTestMessageResult result = testMessageProvider.SendDCTestMessage(sendTestMessageData);
				int sentReplicasCount = result.SentReplicaMasks?.Length ?? 0;
				int failedReplicasCount = result.FailedReplicaMasks?.Length ?? 0;
				response = CreateSendTestMessageResponse(result.Success, sentReplicasCount + failedReplicasCount,
					sentReplicasCount);
			} else {
				bool result = SendTestMessage(data.BulkEmailId, data.ContactId, data.EmailRecipients);
				string message = result ? new LocalizableString(UserConnection.Workspace.ResourceStorage,
					"MailingService", "LocalizableStrings.TestMessageProviderErrorMessage.Value") : null;
				response = CreateSendTestMessageResponse(result, 0, 0, message);
			}
			return response;
		}

		/// <summary>
		/// Starts sending of the message.
		/// </summary>
		/// <param name="messageId">Unique identifier of the message.</param>
		/// <param name="isDelayedStart">Deelay sending.</param>
		/// <returns>Status of message.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "SendMessage", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public MailingResponse SendMessage(Guid messageId, bool isDelayedStart = false, string applicationUrl = "") {
			return _mailingProvider.SendMessage(messageId, isDelayedStart, applicationUrl);
		}

		/// <summary>
		/// Starts sending of the message.
		/// </summary>
		/// <param name="messageInfo">Object that holds information about message.</param>
		/// <returns>Status of message.</returns>
		public MailingResponse SendMessage(IMessageInfo messageInfo) {
			return SendMessage(messageInfo.MessageId);
		}

		/// <summary>
		/// Starts sending the message with the mailing session identifier.
		/// </summary>
		/// <param name="messageId">Unique identifier of the message.</param>
		/// <param name="sessionId">Trigger mailing session identifier.</param>
		/// <param name="isDelayedStart">Deelay sending.</param>
		/// <returns>Status of message.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "SendSessionedMessage", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public virtual MailingResponse SendSessionedMessage(Guid messageId, Guid sessionId, bool isDelayedStart = false,
			string applicationUrl = "") {
			var sessionedProvider = _mailingProvider as ISessionedMailingProvider;
			return sessionedProvider.SendMessage(messageId, sessionId, isDelayedStart, applicationUrl);
		}

		/// <summary>
		/// Sends test email.
		/// </summary>
		/// <param name="messageId">Unique identifier of the message.</param>
		/// <param name="contactId">Unique identifier of the contact from audience.</param>
		/// <param name="emailRecipient">Email address of the recipient.</param>
		/// <returns>Result of successful sending.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "SendTestMessage", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public bool SendTestMessage(Guid messageId, Guid contactId, string emailRecipient) {
			IEnumerable<string> emailRecipients = emailRecipient == null ? Enumerable.Empty<string>()
				: Regex.Split(emailRecipient, _emailSplitRegexPattern).Where(x => x.IsNotNullOrWhiteSpace())
					.Select(x => x.Trim());
			return emailRecipients.AsParallel().All(x => _mailingProvider.SendTestMessage(messageId, contactId, x));
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "UpdateEmailSchedule", BodyStyle = WebMessageBodyStyle.WrappedRequest,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public ConfigurationServiceResponse UpdateEmailSchedule(UpdateEmailScheduleRequest data) {
			if (_mailingProvider is IMailingCesApiProvider mailingProvider) {
				return mailingProvider.UpdateEmailSchedule(data);
			}
			return new ConfigurationServiceResponse();
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "UpdateThrottlingSchedule",
			BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		public ConfigurationServiceResponse UpdateThrottlingSchedule(ThrottlingScheduleRequest data) {
			if (_mailingProvider is IMailingCesApiProvider mailingProvider) {
				return mailingProvider.UpdateThrottlingSchedule(data);
			}
			return new ConfigurationServiceResponse();
		}

		/// <summary>
		/// Validates the sender domain by the current provider.
		/// </summary>
		/// <param name="validateSenderDomainRequest">The validate sender domain request.</param>
		/// <returns>Validation result.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		[return: MessageParameter(Name = "ValidateDomains")]
		public ValidateSenderDomainResponse ValidateDomains(ValidateSenderDomainRequest validateSenderDomainRequest) {
			if (_mailingProvider is IMailingCesApiProvider mailingProvider) {
				return mailingProvider.ValidateDomains(validateSenderDomainRequest);
			}
			return new ValidateSenderDomainResponse();
		}

		/// <summary>
		/// Validates messages.
		/// </summary>
		/// <param name="messageIds">Unique identifiers of the message.</param>
		/// <returns>Validation result.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "ValidateDraftStatus", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public ConfigurationServiceResponse ValidateDraftStatus(Guid[] messageIds) {
			return _mailingProvider.ValidateDraftStatus(messageIds);
		}

		/// <summary>
		/// Validates message.
		/// </summary>
		/// <param name="messageId">Unique identifier of the message.</param>
		/// <returns>Validation result.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "ValidateMessage", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public ConfigurationServiceResponse ValidateMessage(Guid messageId) {
			return _mailingProvider.ValidateMessage(messageId);
		}

		/// <summary>
		/// Validates messages.
		/// </summary>
		/// <param name="messageIds">Unique identifiers of the message.</param>
		/// <returns>Validation result.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "ValidateMessages", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public ConfigurationServiceResponse ValidateMessages(Guid[] messageIds) {
			return _mailingProvider.ValidateMessages(messageIds);
		}

		/// <summary>
		/// Validates message.
		/// </summary>
		/// <param name="messageId">Unique identifier of the message.</param>
		/// <param name="recipientsCount">Recipients count to send.</param>
		/// <returns>Validation result.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "ValidateTestMessage", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public ConfigurationServiceResponse ValidateTestMessage(Guid messageId, int recipientsCount) {
			return _mailingProvider is IEmailLimitValidator validator
				? validator.ValidateMessage(messageId, recipientsCount) : _mailingProvider.ValidateMessage(messageId);
		}

		#endregion

	}

	#endregion

}














