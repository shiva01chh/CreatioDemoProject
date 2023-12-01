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

	#region Class: FormSubmit_CrtTouchPointEventsProcess

	public partial class FormSubmit_CrtTouchPointEventsProcess<TEntity>
	{

		#region Methods: Private

		private LeadSourceHelper GetLeadSourceHelper() {
			const string landingPageUrlColumnName = "LandingPageURL";
			const string referrerColumnName = "Referrer";
			string landingPageUrl = Entity.IsColumnValueLoaded(landingPageUrlColumnName)
				? Entity.GetTypedColumnValue<string>(landingPageUrlColumnName) : string.Empty;
			string referrer = Entity.IsColumnValueLoaded(referrerColumnName)
				? Entity.GetTypedColumnValue<string>(referrerColumnName) : string.Empty;
			var leadSourceHelper = new LeadSourceHelper(UserConnection, landingPageUrl, referrer);
			return leadSourceHelper;
		}

		private void SetColumnValue(string columnName, string value) {
			if (string.IsNullOrWhiteSpace(value) || 
				!string.IsNullOrEmpty(Entity.GetColumnValue(columnName).ToString())) {
				return;
			}
			Entity.SetColumnValue(columnName, value);
		}

		private void SetComputedColumnValue(string columnName, Guid computedValue, bool useDefaultLeadSourceValue) {
			if (computedValue == Guid.Empty) {
				return;
			}
			Guid value = Entity.IsColumnValueLoaded(columnName) ? Entity.GetTypedColumnValue<Guid>(columnName)
				: Guid.Empty;
			if (useDefaultLeadSourceValue && value != Guid.Empty) {
				return;
			}
			Entity.SetColumnValue(columnName, computedValue);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Handles the before inserting action.
		/// </summary>
		public virtual void FormSubmitInserting() {
			LeadSourceHelper leadSourceHelper = GetLeadSourceHelper();
			leadSourceHelper.ComputeMediumAndSource();
			bool useDefaultLeadSourceValue = UserConnection.GetIsFeatureEnabled("UseDefaultLeadSourceValue");
			SetComputedColumnValue("ChannelId", leadSourceHelper.ResultLeadMediumId, useDefaultLeadSourceValue);
			SetComputedColumnValue("SourceId", leadSourceHelper.ResultLeadSourceId, useDefaultLeadSourceValue);
			SetColumnValue("UtmMediumStr", leadSourceHelper.BpmHrefParameters["utm_medium"]);
			SetColumnValue("UtmSourceStr", leadSourceHelper.BpmHrefParameters["utm_source"]);
			SetColumnValue("UtmCampaignStr", leadSourceHelper.BpmHrefParameters["utm_campaign"]);
			SetColumnValue("UtmTermStr", leadSourceHelper.BpmHrefParameters["utm_term"]);
			SetColumnValue("UtmContentStr", leadSourceHelper.BpmHrefParameters["utm_content"]);
		}

		#endregion

	}

	#endregion

}

