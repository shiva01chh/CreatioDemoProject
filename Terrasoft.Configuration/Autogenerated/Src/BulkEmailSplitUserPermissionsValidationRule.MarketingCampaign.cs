namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using Terrasoft.Configuration.RightsService;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Factories;

	#region Class: BulkEmailSplitUserPermissionsValidationRule

	/// <summary>
	/// Validation rule for bulk email split user permissions.
	/// </summary>
	public class BulkEmailSplitUserPermissionsValidationRule : ISpecificValidationRule<Guid>
	{

		#region Constants: Private

		private const string LicenseMissingMsgCode = "LicenseMissingMsgCode";
		private const string NoRightsToEditMsgCode = "NoRightToEditBulkEmailMsg";
		private const string SchemaName = "BulkEmail";

		#endregion

		#region Fields: Private

		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		public BulkEmailSplitUserPermissionsValidationRule(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Properties: Public

		public string Error { get; private set; }

		#endregion

		#region Methods: Private

		private string CheckUserRights(Guid splitTestId) {
			RightsHelper rightsHelper = GetRightsServiceHelper(_userConnection);
			SchemaOperationRightLevels rightLevels = _userConnection.LicHelper.GetSchemaLicRights(SchemaName, true);
			bool canEditByLicRight =
				(rightLevels & SchemaOperationRightLevels.CanEdit) == SchemaOperationRightLevels.CanEdit;
			bool canEditSchemaRecord = GetCanEditSchemaRecordRight(rightsHelper, splitTestId);
			if (rightsHelper.GetCanEditSchemaOperationRight(SchemaName) && canEditSchemaRecord) {
				return string.Empty;
			}
			if (!canEditSchemaRecord) {
				return NoRightsToEditMsgCode;
			}
			return canEditByLicRight ? NoRightsToEditMsgCode : LicenseMissingMsgCode;
		}

		private IEnumerable<Guid> GetBulkEmailIds(Guid splitTestId) {
			var result = new List<Guid>();
			var select = new Select(_userConnection).Column("Id").From(SchemaName)
				.Where("SplitTestId").IsEqual(Column.Parameter(splitTestId)) as Select;
			using (DBExecutor dbExecutor = _userConnection.EnsureDBConnection()) {
				using (IDataReader reader = select.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						result.Add(reader.GetGuid(0));
					}
				}
			}
			return result;
		}

		private bool GetCanEditSchemaRecordRight(RightsHelper rightsHelper, Guid splitTestId) {
			IEnumerable<Guid> primaryColumnValues = GetBulkEmailIds(splitTestId);
			foreach (Guid id in primaryColumnValues) {
				if (!rightsHelper.GetCanEditSchemaRecordRight(SchemaName, id)) {
					return false;
				}
			}
			return true;
		}

		private RightsHelper GetRightsServiceHelper(UserConnection userConnection) {
			return ClassFactory.Get<RightsHelper>(new ConstructorArgument("userConnection", userConnection));
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Validate user permissions.
		/// </summary>
		/// <param name="splitTestId">Unique identifier of split test to validate</param>
		public bool Validate(Guid splitTestId) {
			string validationLczCode = CheckUserRights(splitTestId);
			bool isValidResult = string.IsNullOrEmpty(validationLczCode);
			if (!isValidResult) {
				Error = validationLczCode.GetLczStringValue(_userConnection);
				return false;
			}
			return true;
		}

		#endregion

	}

	#endregion

}






