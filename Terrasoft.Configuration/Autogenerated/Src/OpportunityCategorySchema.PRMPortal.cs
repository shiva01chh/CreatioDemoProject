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

	#region Class: OpportunityCategorySchema

	/// <exclude/>
	public class OpportunityCategorySchema : Terrasoft.Configuration.OpportunityCategory_CrtOpportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public OpportunityCategorySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityCategorySchema(OpportunityCategorySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityCategorySchema(OpportunityCategorySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("28614d0e-1585-467a-b814-b1eee5dd54ee");
			Name = "OpportunityCategory";
			ParentSchemaUId = new Guid("98f95046-8a53-4d6d-be56-91d68e624e6a");
			ExtendParent = true;
			CreatedInPackageId = new Guid("580620fc-064a-4cdc-95d9-80175a4d3b0d");
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
			return new OpportunityCategory(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityCategory_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityCategorySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityCategorySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("28614d0e-1585-467a-b814-b1eee5dd54ee"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityCategory

	/// <summary>
	/// Opportunity category.
	/// </summary>
	public class OpportunityCategory : Terrasoft.Configuration.OpportunityCategory_CrtOpportunity_Terrasoft
	{

		#region Constructors: Public

		public OpportunityCategory(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityCategory";
		}

		public OpportunityCategory(OpportunityCategory source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityCategory_PRMPortalEventsProcess(UserConnection);
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
			return new OpportunityCategory(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityCategory_PRMPortalEventsProcess

	/// <exclude/>
	public partial class OpportunityCategory_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityCategory_CrtOpportunityEventsProcess<TEntity> where TEntity : OpportunityCategory
	{

		public OpportunityCategory_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityCategory_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("28614d0e-1585-467a-b814-b1eee5dd54ee");
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

	#region Class: OpportunityCategory_PRMPortalEventsProcess

	/// <exclude/>
	public class OpportunityCategory_PRMPortalEventsProcess : OpportunityCategory_PRMPortalEventsProcess<OpportunityCategory>
	{

		public OpportunityCategory_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityCategory_PRMPortalEventsProcess

	public partial class OpportunityCategory_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OpportunityCategoryEventsProcess

	/// <exclude/>
	public class OpportunityCategoryEventsProcess : OpportunityCategory_PRMPortalEventsProcess
	{

		public OpportunityCategoryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

