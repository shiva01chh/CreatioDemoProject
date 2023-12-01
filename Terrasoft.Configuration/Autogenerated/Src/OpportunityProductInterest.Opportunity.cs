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

	#region Class: OpportunityProductInterest_OpportunityEventsProcess

	public partial class OpportunityProductInterest_OpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void CalckOpportunityAmount(Guid opportunityId) {
			var select = new Select(UserConnection)
				.Column(Func.Sum("Amount")).As("Amount")
				.From("OpportunityProductInterest")
			 	.Where("OpportunityId").IsEqual(Column.Parameter(opportunityId)) as Select;
			double amount = 0;
			select.ExecuteReader((reader => {
				amount = reader.GetColumnValue<double>("Amount");
			}));
			var opportunity = UserConnection.EntitySchemaManager.GetInstanceByName("Opportunity")
				.CreateEntity(UserConnection);
			opportunity.FetchFromDB(opportunityId);
			opportunity.SetColumnValue("Amount", amount);
			opportunity.Save(false);
		}

		#endregion

	}

	#endregion

}

