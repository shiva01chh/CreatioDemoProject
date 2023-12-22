﻿namespace Terrasoft.Configuration.UserManagementService
{
	using System;
	using System.Globalization;
	using System.Security;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Terrasoft.Common;
	using Terrasoft.Configuration.RegistrationHelper;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.ExternalUsers;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Web.Common;
	using Terrasoft.Web.Http.Abstractions;
	using Newtonsoft.Json;


	#region Class: UserManagementServiceToken

	public class UserManagementServiceToken
	{

		#region Properties: Public

		public string FirstName {
			get;
			set;
		}

		public string Surname {
			get;
			set;
		}

		public string AdditionalName {
			get;
			set;
		}

		public string Email {
			get;
			set;
		}

		public string Password {
			get;
			set;
		}

		public string WorkspaceBaseUrl {
			get;
			set;
		}

		#endregion

	}

	#endregion

	#region Class: RecoveryPasswordToken

	public class RecoveryPasswordToken
	{

		#region Properties: Public

		public string EmailOrLogin {
			get;
			set;
		}

		#endregion

	}

	#endregion

	#region Class: UserManagementService

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class UserManagementService : BaseService {

		#region Constructors: Public

		public UserManagementService() {
			GeneralResourceStorage.SetCurentCulture(PreferredUserCulture);
		}

		#endregion

		#region Properties: Private

		private CultureInfo _preferredUserCulture;

		/// <summary>
		/// Preferred user culture from Http context.
		/// </summary>
		private CultureInfo PreferredUserCulture {
			get => _preferredUserCulture ??
				   (_preferredUserCulture =
					   CultureUtilities.GetPriorityContextCulture(HttpContext.Current.Request.UserLanguages,
						   GeneralResourceStorage.DefCulture));
			set => _preferredUserCulture = value;
		}

		private IUserSessionManager _userSessionManager;
		private IUserSessionManager UserSessionManager {
			get => _userSessionManager ??
				   (_userSessionManager = ClassFactory.Get<IUserSessionManager>());
			set => _userSessionManager = value;
		}

		#endregion

		#region Methods: Private

		private bool IsExistingSysAdminUnit(Guid contactId) {
			var select = new Select(UserConnection)
				.Column(Func.Count(Column.Const(1)))
				.From("SysAdminUnit")
				.Where("ContactId")
				.IsEqual(Column.Const(contactId)) as Select;
			return select.ExecuteScalar<int>() > 0;
		}

		private Guid GetExistingContactId(string email) {
			var select = new Select(UserConnection)
				.Column("Id")
				.From("Contact")
				.Where("Email")
				.IsEqual(Column.Const(email)) as Select;
			return select.ExecuteScalar<Guid>();
		}
		
		private void AddIsAgreedColumn(Entity contact) {
			bool checkTermsAndConditionsSettingsValue = 
				Core.Configuration.SysSettings.GetValue<bool>(contact.UserConnection, "CheckTermsAndConditions", false);
			if (checkTermsAndConditionsSettingsValue) {
				var schema = contact.Schema;
				var columnName = "IsAgreed";
				EntitySchemaColumn column = schema.Columns.FindByName(columnName);
				if (column == null) {
					column = schema.AddColumn("Boolean", columnName);
					column.IsVirtual = true;
				}
				contact.SetColumnValue(columnName, true);
			}
		}

		private Guid CreateContact(UserManagementServiceToken token) {
			UserConnection systemUserConnection = UserConnection.AppConnection.SystemUserConnection;
			var contact = new Terrasoft.Configuration.Contact(systemUserConnection);
			contact.SetDefColumnValues();
			contact.Surname = token.Surname;
			contact.GivenName = token.FirstName;
			contact.MiddleName = token.AdditionalName;
			contact.Email = token.Email;
			contact.Confirmed = false;
			AddIsAgreedColumn(contact);
			contact.Save(false);
			return contact.Id;
		}

		#endregion

		#region Methods: Public

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "Register", BodyStyle = WebMessageBodyStyle.Bare,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public string Register(UserManagementServiceToken token) {
			object returnObject;
			bool isAvailablePortalSelfRegistration = GlobalAppSettings.ShowPortalSelfRegistrationLink;
			if (!isAvailablePortalSelfRegistration) {
				returnObject = new {
					ResultCode = "Error",
					ResultMessage = new LocalizableString(UserConnection.Workspace.ResourceStorage,
						"UserManagementService", "LocalizableStrings.RegistrationLinkNotSent.Value")
				};
				return JsonConvert.SerializeObject(returnObject);
			}
			string email = token.Email;
			var emailDomainValidator = ClassFactory.Get<IExternalUserEmailDomainValidator>();
			if (!emailDomainValidator.IsValidEmailDomainForExternalUser(email)) {
				returnObject = new {
					ResultCode = "Error",
					ResultMessage = new LocalizableString("Terrasoft.Core", "Exception.EmailDomainIsRestrictedOnLogin")
				};
				return JsonConvert.SerializeObject(returnObject);
			}
			var contactId = GetExistingContactId(email);
			if (!contactId.IsEmpty() && IsExistingSysAdminUnit(contactId)) {
				returnObject = new {
					ResultCode = "ExistingSysAdminUnit",
					ResultMessage = new LocalizableString(UserConnection.Workspace.ResourceStorage,
						"UserManagementService", "LocalizableStrings.ExistingSysAdminUnit.Value")
				};
			} else {
				try {
					if (contactId.IsEmpty()) {
						contactId = CreateContact(token);
					}
					string password = token.Password;
					UserConnection systemUserConnection = UserConnection.AppConnection.SystemUserConnection;
					password.ValidatePassword(systemUserConnection, email);
					string registrationLinkUrl = LoginUtilities.CreateRegistrationLink(systemUserConnection, contactId,
						password, token.WorkspaceBaseUrl);
					if (systemUserConnection.GetIsFeatureEnabled("MultilanguageRegistrationEmail")) {
						RegistrationHelper.SendRegistrationEmail(systemUserConnection, contactId,
							registrationLinkUrl, HttpContext.Current.Request.UserLanguages);
					} else {
						RegistrationHelper.SendEmail(systemUserConnection, contactId, registrationLinkUrl);
					}
					returnObject = new {
						ResultCode = "Success"
					};
				} catch (SecurityException e) {
					returnObject = new {
						ResultCode = "Error",
						ResultMessage = e.Message
					};
				} catch {
					returnObject = new {
						ResultCode = "Error",
						ResultMessage = new LocalizableString(UserConnection.Workspace.ResourceStorage,
							"UserManagementService", "LocalizableStrings.RegistrationLinkNotSent.Value")
					};
				}
			}
			return JsonConvert.SerializeObject(returnObject);
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "RemindPassword", BodyStyle = WebMessageBodyStyle.Bare,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public string RemindPassword(RecoveryPasswordToken token) {
			string emailOrLogin = token.EmailOrLogin;
			string baseApplicationUrl = WebUtilities.GetParentApplicationUrl(HttpContext.Current.Request);
			UserConnection systemUserConnection = UserConnection.AppConnection.SystemUserConnection;
			RecoveryPasswordInfo recoveryPasswordInfo =
				LoginUtilities.GetRecoveryPasswordResponseData(systemUserConnection, emailOrLogin, baseApplicationUrl);
			object returnObject;
			if (recoveryPasswordInfo == null) {
				returnObject = new {
					ResultCode = "Error",
					ResultMessage = new LocalizableString(UserConnection.Workspace.ResourceStorage,
						"UserManagementService", "LocalizableStrings.RecoveryPasswordLinkNotSent.Value")
				};
			} else {
				if (recoveryPasswordInfo.PasswordChangeUrl == null) {
					returnObject = new {
						ResultCode = "Error",
						ResultMessage = recoveryPasswordInfo.Message
					};
				} else {
					try {
						string subject;
						string body;
						if (systemUserConnection.GetIsFeatureEnabled("MultilanguageRegistrationEmail")) {
							var template = RegistrationHelper.GetTemplateByUserCulture(systemUserConnection,
								HttpContext.Current.Request.UserLanguages,
								RegistrationHelper.GetRecoveryPasswordEmailTemplateId(systemUserConnection));
							subject = template.GetTypedColumnValue<string>("Subject");
							body = template.GetTypedColumnValue<string>("Body")
								.Replace("#RecoveryLinkUrl#", recoveryPasswordInfo.PasswordChangeUrl);
						} else {
							subject = new LocalizableString("Terrasoft.WebApp.Loader", "RecoveryPasswordMailSubject");
							body = string.Format(
								new LocalizableString("Terrasoft.WebApp.Loader", "RecoveryPasswordMailBody"),
								recoveryPasswordInfo.PasswordChangeUrl);
						}
						RegistrationHelper.SendRecoveryPasswordLink(systemUserConnection,
							recoveryPasswordInfo.EmailAddress, subject, body);
						returnObject = new {
							ResultCode = "Success"
						};
					} catch (SecurityException e) {
						returnObject = new {
							ResultCode = "Error",
							ResultMessage = e.Message
						};
					} catch {
						returnObject = new {
							ResultCode = "Error",
							ResultMessage = new LocalizableString(UserConnection.Workspace.ResourceStorage,
								"UserManagementService", "LocalizableStrings.RecoveryPasswordLinkNotSent.Value")
						};
					}
				}
			}
			return JsonConvert.SerializeObject(returnObject);
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "Logout", BodyStyle = WebMessageBodyStyle.Bare,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public string Logout() {
			UserSessionManager.Logout();
			object returnObject = new {
				ResultCode = "Success"
			};
			return JsonConvert.SerializeObject(returnObject);
		}

		#endregion

	}

	#endregion

}












