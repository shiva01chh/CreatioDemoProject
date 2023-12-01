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

	#region Class: TouchQueueOpSchema

	/// <exclude/>
	public class TouchQueueOpSchema : Terrasoft.Configuration.TouchQueueSchema
	{

		#region Constructors: Public

		public TouchQueueOpSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public TouchQueueOpSchema(TouchQueueOpSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public TouchQueueOpSchema(TouchQueueOpSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b65de3be-f9ee-4013-9012-a02d6648636d");
			RealUId = new Guid("b65de3be-f9ee-4013-9012-a02d6648636d");
			Name = "TouchQueueOp";
			ParentSchemaUId = new Guid("8e06adb6-61a3-48e5-ad4e-908b3909fc32");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a");
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
			return new TouchQueueOp(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new TouchQueueOp_CrtWebTrackingBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new TouchQueueOpSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new TouchQueueOpSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b65de3be-f9ee-4013-9012-a02d6648636d"));
		}

		#endregion

	}

	#endregion

	#region Class: TouchQueueOp

	/// <summary>
	/// TouchQueueOp.
	/// </summary>
	public class TouchQueueOp : Terrasoft.Configuration.TouchQueue
	{

		#region Constructors: Public

		public TouchQueueOp(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "TouchQueueOp";
		}

		public TouchQueueOp(TouchQueueOp source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new TouchQueueOp_CrtWebTrackingBaseEventsProcess(UserConnection);
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
			return new TouchQueueOp(this);
		}

		#endregion

	}

	#endregion

	#region Class: TouchQueueOp_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public partial class TouchQueueOp_CrtWebTrackingBaseEventsProcess<TEntity> : Terrasoft.Configuration.TouchQueue_CrtWebTrackingBaseEventsProcess<TEntity> where TEntity : TouchQueueOp
	{

		public TouchQueueOp_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "TouchQueueOp_CrtWebTrackingBaseEventsProcess";
			SchemaUId = new Guid("b65de3be-f9ee-4013-9012-a02d6648636d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b65de3be-f9ee-4013-9012-a02d6648636d");
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

	#region Class: TouchQueueOp_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public class TouchQueueOp_CrtWebTrackingBaseEventsProcess : TouchQueueOp_CrtWebTrackingBaseEventsProcess<TouchQueueOp>
	{

		public TouchQueueOp_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: TouchQueueOp_CrtWebTrackingBaseEventsProcess

	public partial class TouchQueueOp_CrtWebTrackingBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: TouchQueueOpEventsProcess

	/// <exclude/>
	public class TouchQueueOpEventsProcess : TouchQueueOp_CrtWebTrackingBaseEventsProcess
	{

		public TouchQueueOpEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

