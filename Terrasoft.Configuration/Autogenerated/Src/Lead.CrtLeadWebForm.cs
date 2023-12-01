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

	#region Class: Lead_CrtLeadWebFormEventsProcess

	public partial class Lead_CrtLeadWebFormEventsProcess<TEntity>
	{

		#region Methods: Private
		
		private void SetColumnValue(string columnName, string value) {
			if (string.IsNullOrWhiteSpace(value)) {
				return;
			}
			Entity.SetColumnValue(columnName, value);
		}

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

		public override void LeadInserting() {
			base.LeadInserting();
			string bpmHrefColumnName = "BpmHref";
			string bpmRefColumnName = "BpmRef";
			string bpmHref = Entity.IsColumnValueLoaded(bpmHrefColumnName) 
				? Entity.GetTypedColumnValue<string>(bpmHrefColumnName) : String.Empty;
			string bpmRef = Entity.IsColumnValueLoaded(bpmRefColumnName) 
				? Entity.GetTypedColumnValue<string>(bpmRefColumnName) : String.Empty;
			var lsh = new LeadSourceHelper(UserConnection, bpmHref, bpmRef);
			lsh.ComputeMediumAndSource();
			var useDefaultLeadSourceValue = UserConnection.GetIsFeatureEnabled("UseDefaultLeadSourceValue");
			SetComputedColumnValue("LeadMediumId", lsh.ResultLeadMediumId, useDefaultLeadSourceValue);
			SetComputedColumnValue("LeadSourceId", lsh.ResultLeadSourceId, useDefaultLeadSourceValue);
			SetColumnValue("UtmMediumStr", lsh.BpmHrefParameters["utm_medium"]);
			SetColumnValue("UtmSourceStr", lsh.BpmHrefParameters["utm_source"]);
			SetColumnValue("UtmCampaignStr", lsh.BpmHrefParameters["utm_campaign"]);
			SetColumnValue("UtmTermStr", lsh.BpmHrefParameters["utm_term"]);
			SetColumnValue("UtmContentStr", lsh.BpmHrefParameters["utm_content"]);
		}

		#endregion

	}

	#endregion

}

