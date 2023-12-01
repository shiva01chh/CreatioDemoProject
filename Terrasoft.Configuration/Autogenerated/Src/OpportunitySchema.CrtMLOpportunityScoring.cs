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

	#region Class: Opportunity_CrtMLOpportunityScoring_TerrasoftSchema

	/// <exclude/>
	public class Opportunity_CrtMLOpportunityScoring_TerrasoftSchema : Terrasoft.Configuration.Opportunity_Opportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public Opportunity_CrtMLOpportunityScoring_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Opportunity_CrtMLOpportunityScoring_TerrasoftSchema(Opportunity_CrtMLOpportunityScoring_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Opportunity_CrtMLOpportunityScoring_TerrasoftSchema(Opportunity_CrtMLOpportunityScoring_TerrasoftSchema source)
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
			RealUId = new Guid("22e75c27-2052-4e89-b61f-76da6e1a0a1d");
			Name = "Opportunity_CrtMLOpportunityScoring_Terrasoft";
			ParentSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			ExtendParent = true;
			CreatedInPackageId = new Guid("cabe91a5-1698-4b47-8e3b-380885462b82");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("9ec83c9d-d3f5-4aa0-a26c-22ae9b2657e0")) == null) {
				Columns.Add(CreatePredictiveProbabilityColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePredictiveProbabilityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("9ec83c9d-d3f5-4aa0-a26c-22ae9b2657e0"),
				Name = @"PredictiveProbability",
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("22e75c27-2052-4e89-b61f-76da6e1a0a1d"),
				ModifiedInSchemaUId = new Guid("22e75c27-2052-4e89-b61f-76da6e1a0a1d"),
				CreatedInPackageId = new Guid("cabe91a5-1698-4b47-8e3b-380885462b82")
			};
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
			return new Opportunity_CrtMLOpportunityScoring_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Opportunity_CrtMLOpportunityScoringEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Opportunity_CrtMLOpportunityScoring_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Opportunity_CrtMLOpportunityScoring_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("22e75c27-2052-4e89-b61f-76da6e1a0a1d"));
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_CrtMLOpportunityScoring_Terrasoft

	/// <summary>
	/// Opportunity.
	/// </summary>
	public class Opportunity_CrtMLOpportunityScoring_Terrasoft : Terrasoft.Configuration.Opportunity_Opportunity_Terrasoft
	{

		#region Constructors: Public

		public Opportunity_CrtMLOpportunityScoring_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Opportunity_CrtMLOpportunityScoring_Terrasoft";
		}

		public Opportunity_CrtMLOpportunityScoring_Terrasoft(Opportunity_CrtMLOpportunityScoring_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Predictive probability.
		/// </summary>
		public int PredictiveProbability {
			get {
				return GetTypedColumnValue<int>("PredictiveProbability");
			}
			set {
				SetColumnValue("PredictiveProbability", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Opportunity_CrtMLOpportunityScoringEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Opportunity_CrtMLOpportunityScoring_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_CrtMLOpportunityScoringEventsProcess

	/// <exclude/>
	public partial class Opportunity_CrtMLOpportunityScoringEventsProcess<TEntity> : Terrasoft.Configuration.Opportunity_OpportunityEventsProcess<TEntity> where TEntity : Opportunity_CrtMLOpportunityScoring_Terrasoft
	{

		public Opportunity_CrtMLOpportunityScoringEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Opportunity_CrtMLOpportunityScoringEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("22e75c27-2052-4e89-b61f-76da6e1a0a1d");
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

	#region Class: Opportunity_CrtMLOpportunityScoringEventsProcess

	/// <exclude/>
	public class Opportunity_CrtMLOpportunityScoringEventsProcess : Opportunity_CrtMLOpportunityScoringEventsProcess<Opportunity_CrtMLOpportunityScoring_Terrasoft>
	{

		public Opportunity_CrtMLOpportunityScoringEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Opportunity_CrtMLOpportunityScoringEventsProcess

	public partial class Opportunity_CrtMLOpportunityScoringEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

