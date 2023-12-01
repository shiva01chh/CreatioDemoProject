namespace Terrasoft.Configuration.NavigationMenu
{
	using System;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using System.Web.SessionState;
	using global::Common.Logging;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.ServiceModelContract;
	using Terrasoft.Web.Common;
	using Terrasoft.Web.Common.ServiceRouting;

	[DefaultServiceRoute]
	[SspServiceRoute]
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class WorkplaceNavigationPanelService : BaseService, IReadOnlySessionState
	{

		#region Fields: Private

		private ILog _log;
		private ILog Log => _log ?? (_log = LogManager.GetLogger(typeof(WorkplaceNavigationPanelService)));
		private readonly IWorkplaceNavigationPanelProvider _navigationPanelProvider;

		#endregion

		#region Constructor: Public

		public WorkplaceNavigationPanelService() {
			_navigationPanelProvider = ClassFactory.Get<IWorkplaceNavigationPanelProvider>(
				new ConstructorArgument("userConnection", UserConnection));
		}

		public WorkplaceNavigationPanelService(IWorkplaceNavigationPanelProvider navigationPanelProvider) {
			_navigationPanelProvider = navigationPanelProvider;
		}
		
		#endregion

		#region Methods: Public

		[OperationContract]
		[WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public GetNavigationMenuGroupsResponse GetGroups() {
			var response = new GetNavigationMenuGroupsResponse();
			try {
				response.Workplaces = _navigationPanelProvider.Load();
			} catch(Exception e) {
				string errorMessage = e.Message;
				Log.Error(errorMessage);
				response.Success = false;
				response.ErrorInfo = new ErrorInfo {
					Message = errorMessage
				};
			}
			return response;
		}

		#endregion

	}
}




