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

	#region Class: OpportunityStageSchema

	/// <exclude/>
	public class OpportunityStageSchema : Terrasoft.Configuration.OpportunityStage_Opportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public OpportunityStageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityStageSchema(OpportunityStageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityStageSchema(OpportunityStageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("f7abfecd-3bfe-43a7-9d94-f29ea1161c9f");
			Name = "OpportunityStage";
			ParentSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f");
			ExtendParent = true;
			CreatedInPackageId = new Guid("2b000645-6072-461d-8963-11edfee86881");
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

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OpportunityStage(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityStage_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityStageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityStageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f7abfecd-3bfe-43a7-9d94-f29ea1161c9f"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityStage

	/// <summary>
	/// Opportunity stage.
	/// </summary>
	public class OpportunityStage : Terrasoft.Configuration.OpportunityStage_Opportunity_Terrasoft
	{

		#region Constructors: Public

		public OpportunityStage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityStage";
		}

		public OpportunityStage(OpportunityStage source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityStage_PRMPortalEventsProcess(UserConnection);
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
			return new OpportunityStage(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityStage_PRMPortalEventsProcess

	/// <exclude/>
	public partial class OpportunityStage_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityStage_OpportunityEventsProcess<TEntity> where TEntity : OpportunityStage
	{

		public OpportunityStage_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityStage_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f7abfecd-3bfe-43a7-9d94-f29ea1161c9f");
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

	#region Class: OpportunityStage_PRMPortalEventsProcess

	/// <exclude/>
	public class OpportunityStage_PRMPortalEventsProcess : OpportunityStage_PRMPortalEventsProcess<OpportunityStage>
	{

		public OpportunityStage_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityStage_PRMPortalEventsProcess

	public partial class OpportunityStage_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OpportunityStageEventsProcess

	/// <exclude/>
	public class OpportunityStageEventsProcess : OpportunityStage_PRMPortalEventsProcess
	{

		public OpportunityStageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

