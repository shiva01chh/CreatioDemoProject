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

	#region Class: Lead_PRMBaseEventsProcess

	public partial class Lead_PRMBaseEventsProcess<TEntity>
	{

		#region Methods: Private

		private void SetComputedColumnValue(string columnName, Guid computedValue, bool useDefaultLeadSourceValue) {
			if (computedValue == Guid.Empty) {
				return;
			}
			var value = Entity.IsColumnValueLoaded(columnName)
				? Entity.GetTypedColumnValue<Guid>(columnName) : Guid.Empty;
			if (useDefaultLeadSourceValue && value != Guid.Empty) {
				return;
			}
			Entity.SetColumnValue(columnName, computedValue);
		}

		#endregion

		#region Methods: Public

		public override void LeadInserted() {
			base.LeadInserted();
			if (Entity.GetIsColumnValueLoaded("QualifiedContactId") && Guid.Empty != Entity.QualifiedContactId ||
					Entity.GetIsColumnValueLoaded("WebFormId") && Guid.Empty == Entity.WebFormId) {	
				return;
			}
			ProcessSchema schema = UserConnection.ProcessSchemaManager
				.GetInstanceByName("LeadManagementIdentification");
			var parameterValues = new Dictionary<string, string>();
			parameterValues.Add("LeadId", Entity.Id.ToString());
			RunProcess(schema.UId, parameterValues);
		}

		public override void LeadInserting() {
			base.LeadInserting();
			string bpmHrefColumnName = "BpmHref";
			string bpmRefColumnName = "BpmRef";
			string bpmHref = Entity.IsColumnValueLoaded(bpmHrefColumnName) 
				? Entity.GetTypedColumnValue<string>(bpmHrefColumnName)
				: String.Empty;
			string bpmRef = Entity.IsColumnValueLoaded(bpmRefColumnName) 
				? Entity.GetTypedColumnValue<string>(bpmRefColumnName)
				: String.Empty;
			var lsh = new LeadSourceHelper(UserConnection, bpmHref, bpmRef);
			lsh.ComputeMediumAndSource();
			var useDefaultLeadSourceValue = UserConnection.GetIsFeatureEnabled("UseDefaultLeadSourceValue");
			SetComputedColumnValue("LeadMediumId", lsh.ResultLeadMediumId, useDefaultLeadSourceValue);
			SetComputedColumnValue("LeadSourceId", lsh.ResultLeadSourceId, useDefaultLeadSourceValue);
		}

		#endregion

	}

	#endregion

}

