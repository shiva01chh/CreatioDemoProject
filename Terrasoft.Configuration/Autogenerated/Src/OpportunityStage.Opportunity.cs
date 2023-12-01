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
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: OpportunityStage_OpportunityEventsProcess

	public partial class OpportunityStage_OpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void ClearCache() {
			#pragma warning disable CS0618
			Store.Cache[CacheLevel.Application]
				.ExpireGroup(UserConnection.GetIsFeatureEnabled("NewOpportunityStageManager")
					? Terrasoft.Configuration.OpportunityStageRepository.OpportunityCacheGroupName
					: Terrasoft.Configuration.OpportunityStageHelper.OppInStageCacheGroupName);
			#pragma warning restore CS0618
		}

		#endregion

	}

	#endregion

}

