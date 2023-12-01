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

	#region Class: Opportunity_Opportunity_TerrasoftSchema

	/// <exclude/>
	public class Opportunity_Opportunity_TerrasoftSchema : Terrasoft.Configuration.Opportunity_CrtOpportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public Opportunity_Opportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Opportunity_Opportunity_TerrasoftSchema(Opportunity_Opportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Opportunity_Opportunity_TerrasoftSchema(Opportunity_Opportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIDX_OpportunityTitleIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("538d5288-c406-4b69-8f00-7b42c02cbdf3");
			index.Name = "IDX_OpportunityTitle";
			index.CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			index.ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			index.CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			EntitySchemaIndexColumn titleIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("7a45b5d6-7ce5-4417-8995-a0f6d21a272b"),
				ColumnUId = new Guid("790563cf-fd14-4d5d-a5fd-b6eddb10d6d3"),
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(titleIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("2f7102db-6e5b-4d97-a4bc-9cc523fb19f8");
			Name = "Opportunity_Opportunity_Terrasoft";
			ParentSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			ExtendParent = true;
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIDX_OpportunityTitleIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Opportunity_Opportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Opportunity_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Opportunity_Opportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Opportunity_Opportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f7102db-6e5b-4d97-a4bc-9cc523fb19f8"));
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_Opportunity_Terrasoft

	/// <summary>
	/// Opportunity.
	/// </summary>
	public class Opportunity_Opportunity_Terrasoft : Terrasoft.Configuration.Opportunity_CrtOpportunity_Terrasoft
	{

		#region Constructors: Public

		public Opportunity_Opportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Opportunity_Opportunity_Terrasoft";
		}

		public Opportunity_Opportunity_Terrasoft(Opportunity_Opportunity_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Opportunity_OpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Opportunity_Opportunity_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Opportunity_Opportunity_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Opportunity_Opportunity_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Opportunity_Opportunity_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Opportunity_Opportunity_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Opportunity_Opportunity_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Opportunity_Opportunity_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Opportunity_Opportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_OpportunityEventsProcess

	/// <exclude/>
	public partial class Opportunity_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.Opportunity_CrtOpportunityEventsProcess<TEntity> where TEntity : Opportunity_Opportunity_Terrasoft
	{

		public Opportunity_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Opportunity_OpportunityEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2f7102db-6e5b-4d97-a4bc-9cc523fb19f8");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_1f14401c945241759915a6b5a0111349;
		public ProcessFlowElement EventSubProcess3_1f14401c945241759915a6b5a0111349 {
			get {
				return _eventSubProcess3_1f14401c945241759915a6b5a0111349 ?? (_eventSubProcess3_1f14401c945241759915a6b5a0111349 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_1f14401c945241759915a6b5a0111349",
					SchemaElementUId = new Guid("1f14401c-9452-4175-9915-a6b5a0111349"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_430fb70d47b54e719df50c87a22e7719;
		public ProcessFlowElement StartMessage3_430fb70d47b54e719df50c87a22e7719 {
			get {
				return _startMessage3_430fb70d47b54e719df50c87a22e7719 ?? (_startMessage3_430fb70d47b54e719df50c87a22e7719 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_430fb70d47b54e719df50c87a22e7719",
					SchemaElementUId = new Guid("430fb70d-47b5-4e71-9df5-0c87a22e7719"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_fc333190e5de42d79bd108546e141afb;
		public ProcessScriptTask ScriptTask3_fc333190e5de42d79bd108546e141afb {
			get {
				return _scriptTask3_fc333190e5de42d79bd108546e141afb ?? (_scriptTask3_fc333190e5de42d79bd108546e141afb = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_fc333190e5de42d79bd108546e141afb",
					SchemaElementUId = new Guid("fc333190-e5de-42d7-9bd1-08546e141afb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_fc333190e5de42d79bd108546e141afbExecute,
				});
			}
		}

		private ProcessScriptTask _scriptTask4_6356b2f3dce945e9a283e606fab6eb67;
		public ProcessScriptTask ScriptTask4_6356b2f3dce945e9a283e606fab6eb67 {
			get {
				return _scriptTask4_6356b2f3dce945e9a283e606fab6eb67 ?? (_scriptTask4_6356b2f3dce945e9a283e606fab6eb67 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4_6356b2f3dce945e9a283e606fab6eb67",
					SchemaElementUId = new Guid("6356b2f3-dce9-45e9-a283-e606fab6eb67"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4_6356b2f3dce945e9a283e606fab6eb67Execute,
				});
			}
		}

		private ProcessScriptTask _scriptTask5_4d40abc00c604febacb058e576bcb553;
		public ProcessScriptTask ScriptTask5_4d40abc00c604febacb058e576bcb553 {
			get {
				return _scriptTask5_4d40abc00c604febacb058e576bcb553 ?? (_scriptTask5_4d40abc00c604febacb058e576bcb553 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask5_4d40abc00c604febacb058e576bcb553",
					SchemaElementUId = new Guid("4d40abc0-0c60-4feb-acb0-58e576bcb553"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5_4d40abc00c604febacb058e576bcb553Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess4_0c02029693a94331a5d5bd18b3f965b9;
		public ProcessFlowElement EventSubProcess4_0c02029693a94331a5d5bd18b3f965b9 {
			get {
				return _eventSubProcess4_0c02029693a94331a5d5bd18b3f965b9 ?? (_eventSubProcess4_0c02029693a94331a5d5bd18b3f965b9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4_0c02029693a94331a5d5bd18b3f965b9",
					SchemaElementUId = new Guid("0c020296-93a9-4331-a5d5-bd18b3f965b9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_6b77ae32e552426c8fecb5fed20ffd68;
		public ProcessFlowElement StartMessage4_6b77ae32e552426c8fecb5fed20ffd68 {
			get {
				return _startMessage4_6b77ae32e552426c8fecb5fed20ffd68 ?? (_startMessage4_6b77ae32e552426c8fecb5fed20ffd68 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_6b77ae32e552426c8fecb5fed20ffd68",
					SchemaElementUId = new Guid("6b77ae32-e552-426c-8fec-b5fed20ffd68"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptOpportunitySaving;
		public ProcessScriptTask ScriptOpportunitySaving {
			get {
				return _scriptOpportunitySaving ?? (_scriptOpportunitySaving = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptOpportunitySaving",
					SchemaElementUId = new Guid("5ea9ecc7-f319-4fac-9974-5defb7b1eb88"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptOpportunitySavingExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_1f14401c945241759915a6b5a0111349.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_1f14401c945241759915a6b5a0111349 };
			FlowElements[StartMessage3_430fb70d47b54e719df50c87a22e7719.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_430fb70d47b54e719df50c87a22e7719 };
			FlowElements[ScriptTask3_fc333190e5de42d79bd108546e141afb.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_fc333190e5de42d79bd108546e141afb };
			FlowElements[ScriptTask4_6356b2f3dce945e9a283e606fab6eb67.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4_6356b2f3dce945e9a283e606fab6eb67 };
			FlowElements[ScriptTask5_4d40abc00c604febacb058e576bcb553.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5_4d40abc00c604febacb058e576bcb553 };
			FlowElements[EventSubProcess4_0c02029693a94331a5d5bd18b3f965b9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4_0c02029693a94331a5d5bd18b3f965b9 };
			FlowElements[StartMessage4_6b77ae32e552426c8fecb5fed20ffd68.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_6b77ae32e552426c8fecb5fed20ffd68 };
			FlowElements[ScriptOpportunitySaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptOpportunitySaving };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_1f14401c945241759915a6b5a0111349":
						break;
					case "StartMessage3_430fb70d47b54e719df50c87a22e7719":
						e.Context.QueueTasks.Enqueue("ScriptTask3_fc333190e5de42d79bd108546e141afb");
						e.Context.QueueTasks.Enqueue("ScriptTask4_6356b2f3dce945e9a283e606fab6eb67");
						break;
					case "ScriptTask3_fc333190e5de42d79bd108546e141afb":
						e.Context.QueueTasks.Enqueue("ScriptTask5_4d40abc00c604febacb058e576bcb553");
						break;
					case "ScriptTask4_6356b2f3dce945e9a283e606fab6eb67":
						break;
					case "ScriptTask5_4d40abc00c604febacb058e576bcb553":
						break;
					case "EventSubProcess4_0c02029693a94331a5d5bd18b3f965b9":
						break;
					case "StartMessage4_6b77ae32e552426c8fecb5fed20ffd68":
						e.Context.QueueTasks.Enqueue("ScriptOpportunitySaving");
						break;
					case "ScriptOpportunitySaving":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_430fb70d47b54e719df50c87a22e7719");
			ActivatedEventElements.Add("StartMessage4_6b77ae32e552426c8fecb5fed20ffd68");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_1f14401c945241759915a6b5a0111349":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_430fb70d47b54e719df50c87a22e7719":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_430fb70d47b54e719df50c87a22e7719";
					result = StartMessage3_430fb70d47b54e719df50c87a22e7719.Execute(context);
					break;
				case "ScriptTask3_fc333190e5de42d79bd108546e141afb":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_fc333190e5de42d79bd108546e141afb";
					result = ScriptTask3_fc333190e5de42d79bd108546e141afb.Execute(context, ScriptTask3_fc333190e5de42d79bd108546e141afbExecute);
					break;
				case "ScriptTask4_6356b2f3dce945e9a283e606fab6eb67":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4_6356b2f3dce945e9a283e606fab6eb67";
					result = ScriptTask4_6356b2f3dce945e9a283e606fab6eb67.Execute(context, ScriptTask4_6356b2f3dce945e9a283e606fab6eb67Execute);
					break;
				case "ScriptTask5_4d40abc00c604febacb058e576bcb553":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5_4d40abc00c604febacb058e576bcb553";
					result = ScriptTask5_4d40abc00c604febacb058e576bcb553.Execute(context, ScriptTask5_4d40abc00c604febacb058e576bcb553Execute);
					break;
				case "EventSubProcess4_0c02029693a94331a5d5bd18b3f965b9":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4_6b77ae32e552426c8fecb5fed20ffd68":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_6b77ae32e552426c8fecb5fed20ffd68";
					result = StartMessage4_6b77ae32e552426c8fecb5fed20ffd68.Execute(context);
					break;
				case "ScriptOpportunitySaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptOpportunitySaving";
					result = ScriptOpportunitySaving.Execute(context, ScriptOpportunitySavingExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3_fc333190e5de42d79bd108546e141afbExecute(ProcessExecutingContext context) {
			if (CampaignOldValue.Equals(Guid.Empty) && IsTacticChanged) {
				var tacticHelper = Terrasoft.Core.Factories.ClassFactory.Get<Terrasoft.Configuration.OpportunityTacticsHelper>(
					new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection));
				tacticHelper.UpdateOpportunityTacticHistory(Entity);
			}
			SynchronizeOpportunityStage();
			return true;
		}

		public virtual bool ScriptTask4_6356b2f3dce945e9a283e606fab6eb67Execute(ProcessExecutingContext context) {
			ExecuteUpdateRemindings();
			return true;
		}

		public virtual bool ScriptTask5_4d40abc00c604febacb058e576bcb553Execute(ProcessExecutingContext context) {
			if(IsStageChanged && Entity.GetTypedColumnValue<Guid>("StageId") == new Guid("60D5310C-5BE6-DF11-971B-001D60E938C6")) {
				var update = new Update(UserConnection, "OpportunityCompetitor")
					.Set("IsWinner", Column.Parameter(false))
					.Where("OpportunityId").IsEqual(Column.Parameter(Entity.PrimaryColumnValue))
					.And("IsWinner").IsEqual(Column.Parameter(true));
				update.Execute();
			}
			return true;
		}

		public virtual bool ScriptOpportunitySavingExecute(ProcessExecutingContext context) {
			/*CampaignOldValue = Entity.GetTypedOldColumnValue<Guid>(Entity.Schema.Columns.GetByName("Campaign").ColumnValueName);
			if (CampaignOldValue.Equals(Guid.Empty)) {
				return true;
			}*/
			var columns = Entity.GetChangedColumnValues();
			InitCanGenerateAnniversaryReminding();
			string ownerColumnName = Entity.Schema.Columns.GetByName("Owner").ColumnValueName;
			IsOwnerChanged = columns.Any(c => c.Name == ownerColumnName);
			string stageColumnName = Entity.Schema.Columns.GetByName("Stage").ColumnValueName;
			bool isTacticChanged = columns.Any(c => c.Name == "Tactic");
			bool isCheckDateChanged = columns.Any(c => c.Name == "CheckDate");
			bool isStageColumnLoaded = Entity.IsColumnValueLoaded(stageColumnName);
			string dueDateColumnName = "DueDate";
			IsTacticChanged = isTacticChanged || isCheckDateChanged;
			OldOwnerId = Entity.GetTypedOldColumnValue<Guid>(ownerColumnName);
			StageOldValue = isStageColumnLoaded ? Entity.GetTypedOldColumnValue<Guid>(stageColumnName) : Guid.Empty;
			var stageId = isStageColumnLoaded ? Entity.GetTypedColumnValue<Guid>(stageColumnName) : Guid.Empty;
			var dueDate = Entity.IsColumnValueLoaded(dueDateColumnName) ?
				Entity.GetTypedColumnValue<DateTime>(dueDateColumnName) :
				new DateTime();
			IsStageChanged = StageOldValue != stageId;
			
			if (IsStageChanged) {
				IsNewStageEnd = false;
				var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
				var stageSchemaQuery = new EntitySchemaQuery(entitySchemaManager, "OpportunityStage");
				stageSchemaQuery.AddColumn("End");				
				var stageIdFilter = stageSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", stageId);
				stageSchemaQuery.Filters.Add(stageIdFilter);	
				var stages = stageSchemaQuery.GetEntityCollection(UserConnection);
				if (stages.Count > 0) {
					IsNewStageEnd = stages[0].GetTypedColumnValue<bool>("End");
				}
				if(IsNewStageEnd) {
					Entity.SetColumnValue("DueDate", UserConnection.CurrentUser.GetCurrentDateTime());
				}
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Opportunity_Opportunity_TerrasoftSaved":
							if (ActivatedEventElements.Contains("StartMessage3_430fb70d47b54e719df50c87a22e7719")) {
							context.QueueTasks.Enqueue("StartMessage3_430fb70d47b54e719df50c87a22e7719");
						}
						break;
					case "Opportunity_Opportunity_TerrasoftSaving":
							if (ActivatedEventElements.Contains("StartMessage4_6b77ae32e552426c8fecb5fed20ffd68")) {
							context.QueueTasks.Enqueue("StartMessage4_6b77ae32e552426c8fecb5fed20ffd68");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_OpportunityEventsProcess

	/// <exclude/>
	public class Opportunity_OpportunityEventsProcess : Opportunity_OpportunityEventsProcess<Opportunity_Opportunity_Terrasoft>
	{

		public Opportunity_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

