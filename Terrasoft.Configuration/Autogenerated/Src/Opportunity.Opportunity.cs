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

	#region Class: Opportunity_OpportunityEventsProcess

	public partial class Opportunity_OpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual bool IsOpportunityInStageNotEmpty() {
			var entitySchemaColumnName = "Opportunity";
			var entitySchemaName = "OpportunityInStage";
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var entitySchema = entitySchemaManager.GetInstanceByName(entitySchemaName);
			var entitySchemaQueryFilterParameterName = "Opportunity";
			var entitySchemaQueryFilterParameterValue = Entity.PrimaryColumnValue;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, entitySchemaName);
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(
				FilterComparisonType.Equal, entitySchemaQueryFilterParameterName, entitySchemaQueryFilterParameterValue));
			var entitySchemaColumn = entitySchemaQuery.AddColumn(entitySchemaColumnName);
			var queryResult = entitySchemaQuery.GetEntityCollection(UserConnection);
			return queryResult.Count > 0;
		}

		public virtual decimal CalculatePotential(Guid Probability, decimal Revenue) {
			 if (!Probability.Equals(Guid.Empty) && Revenue != 0) {
				var probabilityESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "OpportunityProbability");
				var valueColumn = probabilityESQ.AddColumn("Value");
				var probabilityEntity = probabilityESQ.GetEntity(UserConnection, Probability);
				return Revenue * probabilityEntity.GetTypedColumnValue<int>(valueColumn.Name) / 100;
			} else {
				return 0;
			}
		}

		public virtual void UpdateOpportunityTacticHistory() {
			var tactic = Entity.GetTypedColumnValue<string>("Tactic");
			var oldTactic = Entity.GetTypedOldColumnValue<string>("Tactic");
			var checkDateobj = Entity.GetColumnValue("CheckDate");
			var oldCheckDate = Entity.GetTypedOldColumnValue<DateTime>("CheckDate");
			if(checkDateobj != null) {
				var checkDate = Convert.ToDateTime(checkDateobj);
				if (tactic != oldTactic || checkDate != oldCheckDate || (CampaignOldValue == Guid.Empty && tactic != "")) {
					var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
					var opportunityTacticHist = entitySchemaManager.GetInstanceByName("OpportunityTacticHist").CreateEntity(UserConnection);
					opportunityTacticHist.SetDefColumnValues();
					opportunityTacticHist.SetColumnValue("Tactics", tactic);
					opportunityTacticHist.SetColumnValue("CheckDate", checkDate);
					opportunityTacticHist.SetColumnValue("ModifyDate", DateTime.Now);
					opportunityTacticHist.SetColumnValue("OpportunityId", Entity.GetTypedOldColumnValue<Guid>("Id"));
					opportunityTacticHist.Save();
				}
			} else {
				if (tactic != oldTactic || (CampaignOldValue == Guid.Empty && tactic != "")) {
					var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
					var opportunityTacticHist = entitySchemaManager.GetInstanceByName("OpportunityTacticHist").CreateEntity(UserConnection);
					opportunityTacticHist.SetDefColumnValues();
					opportunityTacticHist.SetColumnValue("Tactics", tactic);
					opportunityTacticHist.SetColumnValue("CheckDate", null);
					opportunityTacticHist.SetColumnValue("ModifyDate", DateTime.Now);
					opportunityTacticHist.SetColumnValue("OpportunityId", Entity.GetTypedOldColumnValue<Guid>("Id"));
					opportunityTacticHist.Save();
				}
			}
		}

		public virtual void SetOpportunityWinner() {
			var setOpportunityWinnerOperation = Terrasoft.Core.Factories.ClassFactory.Get<SetOpportunityWinnerOperation>(
				new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection));
			setOpportunityWinnerOperation.DoOperation(Entity);
		}

		public virtual void SynchronizeOpportunityStage() {
			if (UserConnection.GetIsFeatureEnabled("DisableOldOpportunityStageSynchronizers")) {
				return;
			}
			if (UserConnection.GetIsFeatureEnabled("NewOpportunityStageManager")) {
				var opportunityStageRepository =
					Terrasoft.Core.Factories.ClassFactory.Get<Terrasoft.Configuration.OpportunityStageRepository>(
						new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection));
				var opportunityInStageRepository =
					Terrasoft.Core.Factories.ClassFactory.Get<Terrasoft.Configuration.OpportunityInStageRepository>(
						new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection));
				var opportunityStageManager =
					Terrasoft.Core.Factories.ClassFactory.Get<Terrasoft.Configuration.OpportunityStageManager>(
						new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection),
						new Terrasoft.Core.Factories.ConstructorArgument("opportunityStageRepository", opportunityStageRepository),
						new Terrasoft.Core.Factories.ConstructorArgument("opportunityInStageRepository", opportunityInStageRepository));
				#pragma warning disable CS0618
				opportunityStageManager.SynchronizeStage(StageOldValue, OldOwnerId, Entity);
				#pragma warning restore CS0618
			} else {
				var oppInStageSchema = UserConnection.EntitySchemaManager.GetInstanceByName("OpportunityInStage");
				#pragma warning disable CS0618
				var stageHelper = Terrasoft.Core.Factories.ClassFactory.Get<Terrasoft.Configuration.OpportunityStageHelper>(
					new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection),
					new Terrasoft.Core.Factories.ConstructorArgument("oppInStageSchema", oppInStageSchema));
				stageHelper.SynchronizeStage(StageOldValue, OldOwnerId, Entity);
				#pragma warning restore CS0618
			}
		}

		public virtual void InitCanGenerateAnniversaryReminding() {
			bool isNew = Entity.StoringState == StoringObjectState.New;
			var columns = GetAnniversaryDependentColumns();
			var changedColumns = Entity.GetChangedColumnValues();
			EntityChangedColumns = changedColumns.ToList();
			bool anniversaryColumnsChanged = changedColumns.Any(col => columns.Contains(col.Name));
			CanGenerateAnniversaryReminding = anniversaryColumnsChanged;
		}

		public virtual void ExecuteUpdateRemindings() {
			if (!CanGenerateAnniversaryReminding) {
				return;
			}
			Guid id = Entity.GetTypedColumnValue<Guid>("Id");
			OpportunityAnniversaryReminding remindingsGenerator = new OpportunityAnniversaryReminding(UserConnection, id);
			remindingsGenerator.Options = GetRemindingOptions();
			remindingsGenerator.GenerateActualRemindings();
		}

		public virtual IEnumerable<string> GetAnniversaryDependentColumns() {
			return new[] { "ContactId", "AccountId", "OwnerId" };
		}

		public virtual IEnumerable<string> GetRemindingOptions() {
			var options = new List<string>();
			var changedColumns = EntityChangedColumns as List<EntityColumnValue> ?? new List<EntityColumnValue>();
			if (changedColumns.Any(col => col.Name == "OwnerId")) {
				options.AddRange(new[] {
					OpportunityAnniversaryReminding.AccountOption,
					OpportunityAnniversaryReminding.ContactOption,
					OpportunityAnniversaryReminding.ParticipantOption
				});
				return options;
			}
			if (changedColumns.Any(col => col.Name == "ContactId")) {
				options.Add(OpportunityAnniversaryReminding.ContactOption);
			}
			if (changedColumns.Any(col => col.Name == "AccountId")) {
				options.Add(OpportunityAnniversaryReminding.AccountOption);
			}
			return options;
		}

		#endregion

	}

	#endregion

}

