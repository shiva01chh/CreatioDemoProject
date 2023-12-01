 namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Common;
	using Terrasoft.Configuration.RightsService;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Factories;

	/// <summary>
	/// Represents the user permissions validation rule.
	/// </summary>
	public class UserPermissionsValidationRule : IMailingStateValidationRule
	{

		#region Consts: Private

		private const string NoRightsToEditMsgCode = "NoRightToEditBulkEmailMsg";
		private const string LicenseMissingMsgCode = "ErrorLicPackageMsg";

		#endregion
		
		#region Methods: Private
		
		private RightsHelper GetRightsServiceHelper(UserConnection userConnection) {
			return ClassFactory.Get<RightsHelper>(new ConstructorArgument("userConnection", userConnection));
		}

		private string CheckUserRights(UserConnection userConnection, string schemaName, Guid primaryColumnValue) {
			var rightsHelper = GetRightsServiceHelper(userConnection);
			SchemaOperationRightLevels rightLevels = userConnection.LicHelper.GetSchemaLicRights(schemaName, true);
			bool canEditByLicRight = (rightLevels & SchemaOperationRightLevels.CanEdit) == SchemaOperationRightLevels.CanEdit;
			bool canEditSchemaRecord = rightsHelper.GetCanEditSchemaRecordRight(schemaName, primaryColumnValue);
			if (rightsHelper.GetCanEditSchemaOperationRight(schemaName) && canEditSchemaRecord) {
				return string.Empty;
			}
			if (!canEditSchemaRecord) {
				return NoRightsToEditMsgCode;
			}
			return canEditByLicRight 
				? NoRightsToEditMsgCode
				: LicenseMissingMsgCode;
		}
		
		#endregion
		
		#region Methods: Public

		/// <summary>
		///	Execute user permission validation.
		/// </summary>
		/// <param name="state">The state for validation.</param>
		/// <returns>Instance of <see cref="ValidationResponse"/> represents validation results.</returns>
		public ValidationResponse Validate(MailingState state) {
			MailingContext context = state.Context;
			var validationLczCode = CheckUserRights(context.UserConnection, context.BulkEmailEntity.SchemaName,
				context.BulkEmailEntity.PrimaryColumnValue);
			var isValidResult = string.IsNullOrEmpty(validationLczCode);
			if (isValidResult) {
				return new ValidationResponse {
					Success = true
				};
			}
			MailingUtilities.Log.ErrorFormat("[UserPermissionsValidationRule.Validate]: User {0} doesn't have " +
				"sufficient permissions or marketing license is missing.", context.UserConnection.CurrentUser.Name);
			return new ValidationResponse {
				Success = false,
				LczStringCode = validationLczCode
			};
		}

		#endregion

	}

}



