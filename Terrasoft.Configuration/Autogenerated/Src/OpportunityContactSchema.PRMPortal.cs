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

	#region Class: OpportunityContactSchema

	/// <exclude/>
	public class OpportunityContactSchema : Terrasoft.Configuration.OpportunityContact_Opportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public OpportunityContactSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityContactSchema(OpportunityContactSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityContactSchema(OpportunityContactSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("ca315f96-0684-454e-acd1-3b4c23afd133");
			Name = "OpportunityContact";
			ParentSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			ExtendParent = true;
			CreatedInPackageId = new Guid("580620fc-064a-4cdc-95d9-80175a4d3b0d");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
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
			return new OpportunityContact(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityContact_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityContactSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityContactSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ca315f96-0684-454e-acd1-3b4c23afd133"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityContact

	/// <summary>
	/// Contact in opportunity.
	/// </summary>
	public class OpportunityContact : Terrasoft.Configuration.OpportunityContact_Opportunity_Terrasoft
	{

		#region Constructors: Public

		public OpportunityContact(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityContact";
		}

		public OpportunityContact(OpportunityContact source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityContact_PRMPortalEventsProcess(UserConnection);
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
			return new OpportunityContact(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityContact_PRMPortalEventsProcess

	/// <exclude/>
	public partial class OpportunityContact_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityContact_OpportunityEventsProcess<TEntity> where TEntity : OpportunityContact
	{

		public OpportunityContact_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityContact_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ca315f96-0684-454e-acd1-3b4c23afd133");
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

	#region Class: OpportunityContact_PRMPortalEventsProcess

	/// <exclude/>
	public class OpportunityContact_PRMPortalEventsProcess : OpportunityContact_PRMPortalEventsProcess<OpportunityContact>
	{

		public OpportunityContact_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityContact_PRMPortalEventsProcess

	public partial class OpportunityContact_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OpportunityContactEventsProcess

	/// <exclude/>
	public class OpportunityContactEventsProcess : OpportunityContact_PRMPortalEventsProcess
	{

		public OpportunityContactEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

