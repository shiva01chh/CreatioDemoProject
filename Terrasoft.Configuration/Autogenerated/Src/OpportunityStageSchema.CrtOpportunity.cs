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

	#region Class: OpportunityStage_CrtOpportunity_TerrasoftSchema

	/// <exclude/>
	public class OpportunityStage_CrtOpportunity_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public OpportunityStage_CrtOpportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityStage_CrtOpportunity_TerrasoftSchema(OpportunityStage_CrtOpportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityStage_CrtOpportunity_TerrasoftSchema(OpportunityStage_CrtOpportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f");
			RealUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f");
			Name = "OpportunityStage_CrtOpportunity_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("146e7f2e-a20d-4cc2-9c5c-bcc8dde6ed63")) == null) {
				Columns.Add(CreateEndColumn());
			}
			if (Columns.FindByUId(new Guid("9d36f697-56db-4539-9809-b07f01dfe9a0")) == null) {
				Columns.Add(CreateSuccessfulColumn());
			}
			if (Columns.FindByUId(new Guid("5cff1d37-c039-46ce-ac3e-a4d7abe49c5f")) == null) {
				Columns.Add(CreateNumberColumn());
			}
			if (Columns.FindByUId(new Guid("388070cb-b942-4af8-a6fb-4b722d30847e")) == null) {
				Columns.Add(CreateMaxProbabilityColumn());
			}
			if (Columns.FindByUId(new Guid("5112d458-569f-445a-90a9-a4c8e0041b28")) == null) {
				Columns.Add(CreateNextStepTermColumn());
			}
			if (Columns.FindByUId(new Guid("875d786d-74b6-4f1c-b885-5fb7da04453b")) == null) {
				Columns.Add(CreateShowInFunnelColumn());
			}
			if (Columns.FindByUId(new Guid("d463f315-b9c9-41ee-a625-60669d205559")) == null) {
				Columns.Add(CreateColorColumn());
			}
			if (Columns.FindByUId(new Guid("ce321ce4-c2fd-43e9-b4ca-26a3aca754c4")) == null) {
				Columns.Add(CreateShowInProgressBarColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected virtual EntitySchemaColumn CreateEndColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("146e7f2e-a20d-4cc2-9c5c-bcc8dde6ed63"),
				Name = @"End",
				CreatedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateSuccessfulColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("9d36f697-56db-4539-9809-b07f01dfe9a0"),
				Name = @"Successful",
				CreatedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("5cff1d37-c039-46ce-ac3e-a4d7abe49c5f"),
				Name = @"Number",
				CreatedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateMaxProbabilityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("388070cb-b942-4af8-a6fb-4b722d30847e"),
				Name = @"MaxProbability",
				CreatedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateNextStepTermColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("5112d458-569f-445a-90a9-a4c8e0041b28"),
				Name = @"NextStepTerm",
				CreatedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateShowInFunnelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("875d786d-74b6-4f1c-b885-5fb7da04453b"),
				Name = @"ShowInFunnel",
				CreatedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340")
			};
		}

		protected virtual EntitySchemaColumn CreateColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("d463f315-b9c9-41ee-a625-60669d205559"),
				Name = @"Color",
				CreatedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340")
			};
		}

		protected virtual EntitySchemaColumn CreateShowInProgressBarColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("ce321ce4-c2fd-43e9-b4ca-26a3aca754c4"),
				Name = @"ShowInProgressBar",
				CreatedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				ModifiedInSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OpportunityStage_CrtOpportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityStage_CrtOpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityStage_CrtOpportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityStage_CrtOpportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityStage_CrtOpportunity_Terrasoft

	/// <summary>
	/// Opportunity stage.
	/// </summary>
	public class OpportunityStage_CrtOpportunity_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public OpportunityStage_CrtOpportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityStage_CrtOpportunity_Terrasoft";
		}

		public OpportunityStage_CrtOpportunity_Terrasoft(OpportunityStage_CrtOpportunity_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Final.
		/// </summary>
		public bool End {
			get {
				return GetTypedColumnValue<bool>("End");
			}
			set {
				SetColumnValue("End", value);
			}
		}

		/// <summary>
		/// Successful.
		/// </summary>
		public bool Successful {
			get {
				return GetTypedColumnValue<bool>("Successful");
			}
			set {
				SetColumnValue("Successful", value);
			}
		}

		/// <summary>
		/// Number.
		/// </summary>
		public int Number {
			get {
				return GetTypedColumnValue<int>("Number");
			}
			set {
				SetColumnValue("Number", value);
			}
		}

		/// <summary>
		/// Maximum probability.
		/// </summary>
		public int MaxProbability {
			get {
				return GetTypedColumnValue<int>("MaxProbability");
			}
			set {
				SetColumnValue("MaxProbability", value);
			}
		}

		/// <summary>
		/// Period for planning the next step, days.
		/// </summary>
		public int NextStepTerm {
			get {
				return GetTypedColumnValue<int>("NextStepTerm");
			}
			set {
				SetColumnValue("NextStepTerm", value);
			}
		}

		/// <summary>
		/// Show in funnel.
		/// </summary>
		public bool ShowInFunnel {
			get {
				return GetTypedColumnValue<bool>("ShowInFunnel");
			}
			set {
				SetColumnValue("ShowInFunnel", value);
			}
		}

		/// <summary>
		/// Color.
		/// </summary>
		public string Color {
			get {
				return GetTypedColumnValue<string>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		/// <summary>
		/// Show in progress bar.
		/// </summary>
		public bool ShowInProgressBar {
			get {
				return GetTypedColumnValue<bool>("ShowInProgressBar");
			}
			set {
				SetColumnValue("ShowInProgressBar", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityStage_CrtOpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityStage_CrtOpportunity_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("OpportunityStage_CrtOpportunity_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("OpportunityStage_CrtOpportunity_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("OpportunityStage_CrtOpportunity_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("OpportunityStage_CrtOpportunity_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("OpportunityStage_CrtOpportunity_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("OpportunityStage_CrtOpportunity_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityStage_CrtOpportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityStage_CrtOpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityStage_CrtOpportunityEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : OpportunityStage_CrtOpportunity_Terrasoft
	{

		public OpportunityStage_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityStage_CrtOpportunityEventsProcess";
			SchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityStage_CrtOpportunityEventsProcess

	/// <exclude/>
	public class OpportunityStage_CrtOpportunityEventsProcess : OpportunityStage_CrtOpportunityEventsProcess<OpportunityStage_CrtOpportunity_Terrasoft>
	{

		public OpportunityStage_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

