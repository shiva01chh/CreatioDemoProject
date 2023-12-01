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

	#region Class: VwOpportInStageForAnalysisSchema

	/// <exclude/>
	public class VwOpportInStageForAnalysisSchema : Terrasoft.Configuration.OpportunityInStageSchema
	{

		#region Constructors: Public

		public VwOpportInStageForAnalysisSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwOpportInStageForAnalysisSchema(VwOpportInStageForAnalysisSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwOpportInStageForAnalysisSchema(VwOpportInStageForAnalysisSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cd2400bc-3cb0-448d-81ee-32d9662c9755");
			RealUId = new Guid("cd2400bc-3cb0-448d-81ee-32d9662c9755");
			Name = "VwOpportInStageForAnalysis";
			ParentSchemaUId = new Guid("670a893d-5eed-421d-b5d9-1db15b5d9ab6");
			ExtendParent = false;
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			IsDBView = true;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ce9dbb21-fd5d-4609-8a63-70ccf20deb8c")) == null) {
				Columns.Add(CreateDaysInStageColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateDaysInStageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("ce9dbb21-fd5d-4609-8a63-70ccf20deb8c"),
				Name = @"DaysInStage",
				CreatedInSchemaUId = new Guid("cd2400bc-3cb0-448d-81ee-32d9662c9755"),
				ModifiedInSchemaUId = new Guid("cd2400bc-3cb0-448d-81ee-32d9662c9755"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("10bbec0c-239b-4597-8408-d3e25205c5bf"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("cd2400bc-3cb0-448d-81ee-32d9662c9755"),
				ModifiedInSchemaUId = new Guid("cd2400bc-3cb0-448d-81ee-32d9662c9755"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwOpportInStageForAnalysis(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwOpportInStageForAnalysis_CrtOpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwOpportInStageForAnalysisSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwOpportInStageForAnalysisSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cd2400bc-3cb0-448d-81ee-32d9662c9755"));
		}

		#endregion

	}

	#endregion

	#region Class: VwOpportInStageForAnalysis

	/// <summary>
	/// View for analysis of sales by stages.
	/// </summary>
	public class VwOpportInStageForAnalysis : Terrasoft.Configuration.OpportunityInStage
	{

		#region Constructors: Public

		public VwOpportInStageForAnalysis(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwOpportInStageForAnalysis";
		}

		public VwOpportInStageForAnalysis(VwOpportInStageForAnalysis source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Number of days in the stage.
		/// </summary>
		public int DaysInStage {
			get {
				return GetTypedColumnValue<int>("DaysInStage");
			}
			set {
				SetColumnValue("DaysInStage", value);
			}
		}

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwOpportInStageForAnalysis_CrtOpportunityEventsProcess(UserConnection);
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
			return new VwOpportInStageForAnalysis(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwOpportInStageForAnalysis_CrtOpportunityEventsProcess

	/// <exclude/>
	public partial class VwOpportInStageForAnalysis_CrtOpportunityEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityInStage_PRMPortalEventsProcess<TEntity> where TEntity : VwOpportInStageForAnalysis
	{

		public VwOpportInStageForAnalysis_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwOpportInStageForAnalysis_CrtOpportunityEventsProcess";
			SchemaUId = new Guid("cd2400bc-3cb0-448d-81ee-32d9662c9755");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("cd2400bc-3cb0-448d-81ee-32d9662c9755");
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

	#region Class: VwOpportInStageForAnalysis_CrtOpportunityEventsProcess

	/// <exclude/>
	public class VwOpportInStageForAnalysis_CrtOpportunityEventsProcess : VwOpportInStageForAnalysis_CrtOpportunityEventsProcess<VwOpportInStageForAnalysis>
	{

		public VwOpportInStageForAnalysis_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwOpportInStageForAnalysis_CrtOpportunityEventsProcess

	public partial class VwOpportInStageForAnalysis_CrtOpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwOpportInStageForAnalysisEventsProcess

	/// <exclude/>
	public class VwOpportInStageForAnalysisEventsProcess : VwOpportInStageForAnalysis_CrtOpportunityEventsProcess
	{

		public VwOpportInStageForAnalysisEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

