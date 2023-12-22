namespace Terrasoft.Configuration
{
	using System.IO;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Terrasoft.Nui.ServiceModel.DataContract;
	using Terrasoft.Web.Common;

	/// <summary>
	/// Webhook receive service
	/// </summary>
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class WebhookService : BaseService
	{

		#region Fields: Private

		private readonly WebhookParametersParser _webhookParametersParser;
		private readonly IWebhookRepository _webhookRepository;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Default constructor
		/// </summary>
		public WebhookService() {
			_webhookParametersParser = new WebhookParametersParser();
			_webhookRepository = new WebhookRepository(UserConnection);
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="webhookParametersParser">Parser for webhook body</param>
		/// <param name="webhookRepository">Webhook request to webhook entity adapter </param>
		public WebhookService(WebhookParametersParser webhookParametersParser,
			IWebhookRepository webhookRepository) {
			_webhookParametersParser = webhookParametersParser;
			_webhookRepository = webhookRepository;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Api method for receive webhook
		/// </summary>
		/// <param name="streamContent">body of POST request</param>
		/// <returns>Base responce</returns>
		[OperationContract]
		[WebInvoke(Method = "POST",
			BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json)]
		public BaseResponse HandleWebhooks(Stream streamContent) {
			var httpContext = HttpContextAccessor.GetInstance();
			var webhookParameters = _webhookParametersParser.ParseWebhookParameters(streamContent, httpContext.Request);
			var webhookId = _webhookRepository.SaveWebhook(webhookParameters);
			return new BaseResponse {
				RowsAffected = 1,
				Success = true,
				ResponseStatus = new ResponseStatus()
			};
		}

		#endregion

	}
}












