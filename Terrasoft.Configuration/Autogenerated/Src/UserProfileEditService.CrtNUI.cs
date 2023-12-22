namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Web.Common;

	#region Class: UserProfileEditService

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class UserProfileEditService : BaseService
	{

		#region Fields: Private
		
		/// <summary>
		/// ####### ########## ####### ##### ####### "VwSysAdminUnit".
		/// #### - ### ######## ####### #######, ######## - ### ######## #######.
		/// </summary>
		private Dictionary<string, object> changedValues;
		
		#endregion

		#region Methods: Private

		private void SaveUser() {
			object primaryColumnValue = UserConnection.CurrentUser.Id;
			EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByName("VwSysAdminUnit");
			Entity entity = entitySchema.CreateEntity(UserConnection);
			entity.UseAdminRights = false;
			entity.FetchFromDB(primaryColumnValue);
			foreach (KeyValuePair<string, object> item in changedValues) {
				EntitySchemaColumn column = entitySchema.Columns.GetByName(item.Key);
				object columnValue = DataTypeUtilities.ValueAsType(item.Value, column.ValueType);
				if (column.ColumnValueName != entitySchema.PrimaryColumn.ColumnValueName) {
					entity.SetColumnValue(column, columnValue);
				}
			}
			entity.Save(false);
		}
		
		#endregion

		#region Methods: Public
		
		/// <summary>
		/// ######### ######### # ####### SysAdminUnit ####### #############.
		/// </summary>
		/// <param name="jsonObject">############### ###### ########## ####### ##### "VwSysAdminUnit".</param>
		/// <returns>##### ##########, #### ### #### ##########, ##### ###### ######.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public string UpdateUserProfile(string jsonObject) {
			string errorMessage = string.Empty;
			changedValues = Json.Deserialize<Dictionary<string, object>>(jsonObject);
			try {
				SaveUser();
			} catch (Exception e) {
				errorMessage = e.Message;
			}
			return errorMessage;
		}
		
		#endregion
	}

	#endregion
}












