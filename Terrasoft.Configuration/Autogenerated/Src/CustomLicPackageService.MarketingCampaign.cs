namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.ServiceModel;
	using System.ServiceModel.Web;
	using System.ServiceModel.Activation;
	using Terrasoft.Core;
	using Terrasoft.Web.Common;

	#region Class: CustomLicPackageServiceResponse

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class CustomLicPackageService : BaseService
	{

		#region Fields: Private

		private IActiveContactsHelper _activeContactsHelper;

		#endregion

		#region Constructors: Public

		public CustomLicPackageService() { }

		public CustomLicPackageService(UserConnection userConnection)
			: base(userConnection) { }

		#endregion

		#region Properties: Public

		public IActiveContactsHelper ActiveContactsHelper {
			get => _activeContactsHelper ?? (_activeContactsHelper = new ActiveContactsHelper());
			set => _activeContactsHelper = value;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Retrieves information about the active contacts license.
		/// </summary>
		/// <returns>Information about the active contacts license.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		public ActualLicenseInfo GetActiveContactsLicInfo() {
			return ActiveContactsHelper.GetActiveContactsLicenseInfo(UserConnection);
		}

		/// <summary>
		/// Retrieves the result of the current condition scalar for a given package name.
		/// </summary>
		/// <param name="packageName">The package name.</param>
		/// <returns>The result of the current condition scalar for the specified package name.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		[Obsolete("8.1 | Method is not in use and will be removed in upcoming builds")]
		public int GetCurrentConditionScalarResult(string packageName) {
			return ActiveContactsHelper.GetCurrentConditionScalarResult(UserConnection, packageName);
		}

		/// <summary>
		/// Finds the full license name by name patterns.
		/// </summary>
		/// <param name="namePatterns">The list of patterns to find the full license name.</param>
		/// <returns>The full license name found by name patterns.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		[Obsolete("8.1 | Method is not in use and will be removed in upcoming builds")]
		public string GetFullPackageNameByNamePatterns(List<string> namePatterns) {
			return ActiveContactsHelper.GetFullPackageNameByNamePatterns(UserConnection, namePatterns);
		}

		/// <summary>
		/// Retrieves the last actualized condition information.
		/// </summary>
		/// <returns>The last actualized condition information.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		public ActualizedCondition GetLastActualizedConditionForMarketingOperation() {
			return ActiveContactsHelper.GetLastActualizedConditionResult(UserConnection);
		}

		/// <summary>
		/// Retrieves the last actualized condition information for a list of package names.
		/// </summary>
		/// <param name="packageNames">The list of package names to retrieve condition information for.</param>
		/// <returns>The last actualized condition information for the specified package names.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		[Obsolete("8.1 | Method is not in use and will be removed in upcoming builds")]
		public List<ActualizedCondition> GetLastActualizedConditionResult(List<string> packageNames) {
			return ActiveContactsHelper.GetLastActualizedConditionResult(UserConnection, packageNames).ToList();
		}

		/// <summary>
		/// Retrieves the maximum condition count information for a list of package names.
		/// </summary>
		/// <param name="packageNames">The list of package names to retrieve condition information for.</param>
		/// <returns>The maximum condition count information for the specified package names.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		[Obsolete("8.1 | Method is not in use and will be removed in upcoming builds")]
		public List<ActualizedCondition> GetMaxConditionCount(List<string> packageNames) {
			return ActiveContactsHelper.GetMaxConditionCount(UserConnection, packageNames).ToList();
		}

		/// <summary>
		/// Retrieves the maximum condition count information.
		/// </summary>
		/// <returns>The maximum condition count information.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		public ActualizedCondition GetMaxConditionCountForMarketingOperation() {
			return ActiveContactsHelper.GetMaxConditionCount(UserConnection);
		}

		#endregion

	}

	#endregion

}





