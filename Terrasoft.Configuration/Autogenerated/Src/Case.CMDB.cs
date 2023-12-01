namespace Terrasoft.Configuration
{

	using CoreSysSettings = Terrasoft.Core.Configuration.SysSettings;
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
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
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

	#region Class: Case_CMDBEventsProcess

	public partial class Case_CMDBEventsProcess<TEntity>
	{

		#region Methods: Public
		
		public override void SetProcessParameters() {
			base.SetProcessParameters();
			NewConfItemId = Entity.GetTypedColumnValue<Guid>("ConfItemId");
			OldConfItemId = Entity.GetTypedOldColumnValue<Guid>("ConfItemId");
		}

		public virtual void ActulizeConfItemsInCase() {
			if (NewConfItemId == OldConfItemId) {
				return;
			}
			var caseId = Entity.PrimaryColumnValue;
			var query = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ConfItemInCase");
			query.PrimaryQueryColumn.IsAlwaysSelect = true;
			query.AddColumn("Major");
			var confItemColumn = query.AddColumn("ConfItem");
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "Case", caseId));
			var collection = query.GetEntityCollection(UserConnection);
			bool addNewItem = true;
			if (collection.Count > 0) {
				foreach(var entity in collection) {
					var currentConfItem  = entity.GetTypedColumnValue<Guid>(confItemColumn.Name + "Id");
					var isMajor = currentConfItem == NewConfItemId;
					if (isMajor) {
						addNewItem = false;
					}
					entity.SetColumnValue("Major", isMajor);
					entity.Save();
				}
			}
			if (!addNewItem || NewConfItemId == Guid.Empty) {
				return;
			}
			var schema = UserConnection.EntitySchemaManager.FindInstanceByName("ConfItemInCase");
			var сonfItemInCaseEntity = schema.CreateEntity(UserConnection);
			сonfItemInCaseEntity.SetDefColumnValues(); 
			сonfItemInCaseEntity.SetColumnValue("CaseId", caseId); 
			сonfItemInCaseEntity.SetColumnValue("ConfItemId", NewConfItemId);
			сonfItemInCaseEntity.SetColumnValue("Major", true);
			сonfItemInCaseEntity.Save(); 
		}

		#endregion

	}

	#endregion

}

