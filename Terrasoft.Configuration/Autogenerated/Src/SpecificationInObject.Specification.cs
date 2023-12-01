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

	#region Class: SpecificationInObject_SpecificationEventsProcess

	public partial class SpecificationInObject_SpecificationEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual bool UpdateStringValueMethod() {
			// Convert specification value to StringValue
			
			var specificationTypeId = string.Empty;
			var specificationValue = string.Empty;
			
			if (Entity.SpecificationId == Guid.Empty) {
				return true;
			};
			
			var esqResult = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Specification");
			esqResult.AddColumn("Type");
			var specEntity = esqResult.GetEntity(UserConnection, Entity.SpecificationId);
			specificationTypeId = specEntity.GetTypedColumnValue<string>("TypeId");
			
			// if not string value
			if (specificationTypeId != "7aad419a-9e7a-4785-8d13-c7ff1402e13d") {
				Entity.SetColumnValue("StringValue", string.Empty);
			};
			
			switch(specificationTypeId) {
				// string type
				case ("7aad419a-9e7a-4785-8d13-c7ff1402e13d"):
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ListItemValueId", null);
					return true;
				// int type
				case ("2212241a-71eb-468b-a3d5-c0f39dfe51c9"):
					specificationValue = Entity.GetTypedColumnValue<string>("IntValue");
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ListItemValueId", null);
					break;
				// float type
				case ("beb46531-4f29-452c-be18-1ed5f1aa8b80"):
					specificationValue = Entity.GetTypedColumnValue<string>("FloatValue");
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ListItemValueId", null);
					break;
				// boolean type
				case ("359e0e35-bb39-4f07-9b9f-aec6ad076828"):
					if (Entity.GetTypedColumnValue<bool>("BooleanValue")) {
						specificationValue = Yes.ToString();
					} else {
						specificationValue = No.ToString();
					}
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("ListItemValueId", null);
					break;
				// list item value
				case ("ecf578a0-4b4d-40e6-909c-39af2a798d32"):
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("BooleanValue", false);
					if (Entity.ListItemValueId != Guid.Empty ) {
						var listItemResult = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SpecificationListItem");
						listItemResult.AddColumn("Name");
						var listItem = listItemResult.GetEntity(UserConnection, Entity.ListItemValueId);
						specificationValue = listItem.GetTypedColumnValue<string>("Name");
					} 
					break;
				default: return true;
			};
			
			Entity.SetColumnValue("StringValue", specificationValue);
			
			return true;
		}

		#endregion

	}

	#endregion

}

