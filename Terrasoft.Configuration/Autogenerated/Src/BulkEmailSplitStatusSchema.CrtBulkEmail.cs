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

	#region Class: BulkEmailSplitStatusSchema

	/// <exclude/>
	public class BulkEmailSplitStatusSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public BulkEmailSplitStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmailSplitStatusSchema(BulkEmailSplitStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmailSplitStatusSchema(BulkEmailSplitStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f91bf1c9-a18d-4446-9a5d-ed7e90d37d98");
			RealUId = new Guid("f91bf1c9-a18d-4446-9a5d-ed7e90d37d98");
			Name = "BulkEmailSplitStatus";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b7874c9a-6e65-41ca-b21f-5fb1f6a22855");
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
			return new BulkEmailSplitStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BulkEmailSplitStatus_CrtBulkEmailEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BulkEmailSplitStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmailSplitStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f91bf1c9-a18d-4446-9a5d-ed7e90d37d98"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailSplitStatus

	/// <summary>
	/// Split test status.
	/// </summary>
	public class BulkEmailSplitStatus : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public BulkEmailSplitStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmailSplitStatus";
		}

		public BulkEmailSplitStatus(BulkEmailSplitStatus source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmailSplitStatus_CrtBulkEmailEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BulkEmailSplitStatusDeleted", e);
			Validating += (s, e) => ThrowEvent("BulkEmailSplitStatusValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BulkEmailSplitStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailSplitStatus_CrtBulkEmailEventsProcess

	/// <exclude/>
	public partial class BulkEmailSplitStatus_CrtBulkEmailEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : BulkEmailSplitStatus
	{

		public BulkEmailSplitStatus_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmailSplitStatus_CrtBulkEmailEventsProcess";
			SchemaUId = new Guid("f91bf1c9-a18d-4446-9a5d-ed7e90d37d98");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f91bf1c9-a18d-4446-9a5d-ed7e90d37d98");
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

	#region Class: BulkEmailSplitStatus_CrtBulkEmailEventsProcess

	/// <exclude/>
	public class BulkEmailSplitStatus_CrtBulkEmailEventsProcess : BulkEmailSplitStatus_CrtBulkEmailEventsProcess<BulkEmailSplitStatus>
	{

		public BulkEmailSplitStatus_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmailSplitStatus_CrtBulkEmailEventsProcess

	public partial class BulkEmailSplitStatus_CrtBulkEmailEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BulkEmailSplitStatusEventsProcess

	/// <exclude/>
	public class BulkEmailSplitStatusEventsProcess : BulkEmailSplitStatus_CrtBulkEmailEventsProcess
	{

		public BulkEmailSplitStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

