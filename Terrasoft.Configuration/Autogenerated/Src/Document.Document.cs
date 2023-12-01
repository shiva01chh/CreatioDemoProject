namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Document_DocumentEventsProcess

	public partial class Document_DocumentEventsProcess<TEntity>
	{

		#region Methods: Public
		
		public virtual decimal Multiply(decimal arg1, decimal arg2) {
			return Math.Round(arg1 * arg2,2);
		}

		public virtual decimal Division(decimal arg1, decimal arg2) {
			decimal result = 0;
			if(arg2 > 0){
				result = Math.Round(arg1 / arg2, 2);
			}
			return result;
		}

		public virtual void AddWrightRights(Guid documentOwnerId) {
			var dbSecurityEngine = UserConnection.DBSecurityEngine;
			var sysAdminUnitESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysAdminUnit");
			var primaryColumn = sysAdminUnitESQ.AddColumn(sysAdminUnitESQ.RootSchema.GetPrimaryColumnName()); 
			sysAdminUnitESQ.Filters.Add(sysAdminUnitESQ.CreateFilterWithParameters(FilterComparisonType.Equal, "Contact", documentOwnerId));
			var sysAdminUnits = sysAdminUnitESQ.GetEntityCollection(UserConnection);
			if (sysAdminUnits.Count > 0) {
				var adminUnitId = Guid.Empty;
				foreach (var sysAdminUnit in sysAdminUnits) {
					adminUnitId = sysAdminUnit.GetTypedColumnValue<Guid>(primaryColumn.Name);
					if (dbSecurityEngine.GetIsEntitySchemaAdministratedByRecords("Document")) {
						dbSecurityEngine.SetEntitySchemaRecordRightLevel(adminUnitId, Entity.Schema.Name, Entity.PrimaryColumnValue,
								EntitySchemaRecordRightOperation.Read, EntitySchemaRecordRightLevel.AllowAndGrant, Guid.Empty, true);
						dbSecurityEngine.SetEntitySchemaRecordRightLevel(adminUnitId, Entity.Schema.Name, Entity.PrimaryColumnValue,
								EntitySchemaRecordRightOperation.Edit, EntitySchemaRecordRightLevel.AllowAndGrant, Guid.Empty, true);
					}
				}
			}
			
		}

		public virtual void RemoveWrightRights(Guid documentOwnerId) {
			var dbSecurityEngine = UserConnection.DBSecurityEngine;
			var sysAdminUnitESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysAdminUnit");
			var primaryColumn = sysAdminUnitESQ.AddColumn(sysAdminUnitESQ.RootSchema.GetPrimaryColumnName()); 
			sysAdminUnitESQ.Filters.Add(sysAdminUnitESQ.CreateFilterWithParameters(FilterComparisonType.Equal, "Contact", documentOwnerId));
			var sysAdminUnits = sysAdminUnitESQ.GetEntityCollection(UserConnection);
			if (sysAdminUnits.Count > 0) {
				var adminUnitId = Guid.Empty;
				foreach (var sysAdminUnit in sysAdminUnits) {
					adminUnitId = sysAdminUnit.GetTypedColumnValue<Guid>(primaryColumn.Name);
					if (UserConnection.DBSecurityEngine.GetIsEntitySchemaAdministratedByRecords("Document")) {
						UserConnection.DBSecurityEngine.SetEntitySchemaRecordRightLevel(adminUnitId, Entity.Schema.Name, Entity.PrimaryColumnValue,
										EntitySchemaRecordRightOperation.Edit, EntitySchemaRecordRightLevel.Deny, Guid.Empty, true);
					}
				}
			}
		}

		#endregion

	}

	#endregion

}

