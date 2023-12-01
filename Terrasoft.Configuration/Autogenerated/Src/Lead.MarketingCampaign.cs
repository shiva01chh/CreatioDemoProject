﻿namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Collections.Specialized;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Web;
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

	#region Class: Lead_MarketingCampaignEventsProcess

	public partial class Lead_MarketingCampaignEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void BindToCampaignAndBulkEmail() {
			if (!Entity.IsColumnValueLoaded("BpmHref")) {
				return;
			}
			string bpmHref = Entity.GetTypedColumnValue<string>("BpmHref");
			if (string.IsNullOrWhiteSpace(bpmHref)) {
				return;
			}
			var utmParser = new MarketingUtmParser();
			var bulkEmailId = utmParser.GetBulkEmailByUtm(Entity.UserConnection, bpmHref);
			if (bulkEmailId.IsNotEmpty()) {
				Entity.SetColumnValue("BulkEmailId", bulkEmailId);
			}
			var campaignId = utmParser.GetCampaignByUtm(Entity.UserConnection, bpmHref);
			if (campaignId.IsNotEmpty()) {
				Entity.SetColumnValue("CampaignId", campaignId);
			}
		}

		public override void LeadInserting() {
			base.LeadInserting();
			BindToCampaignAndBulkEmail();
		}

		#endregion

	}

	#endregion

}

