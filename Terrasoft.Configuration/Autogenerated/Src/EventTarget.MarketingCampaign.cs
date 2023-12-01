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
	using Terrasoft.Configuration.MarketingCampaign;
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

	#region Class: EventTarget_MarketingCampaignEventsProcess

	public partial class EventTarget_MarketingCampaignEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void OnInserting() {
			if (UserConnection.GetIsFeatureEnabled("EventAudienceImport")) {
				return;
			}
			var conditions = new Dictionary<string, object>();
			conditions.Add("Event", Entity.EventId);
			conditions.Add("Contact", Entity.ContactId);
			if (Entity.ExistInDB(conditions)) {
				throw new SaveDuplicatedEntityException(UniqueConstraintMessageText.Value);
			}
		}
		#endregion

	}

	#endregion

}

