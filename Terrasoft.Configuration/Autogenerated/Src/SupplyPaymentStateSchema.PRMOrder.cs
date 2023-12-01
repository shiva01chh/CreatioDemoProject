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

	#region Class: SupplyPaymentStateSchema

	/// <exclude/>
	public class SupplyPaymentStateSchema : Terrasoft.Configuration.SupplyPaymentState_CrtSupplyPayment_TerrasoftSchema
	{

		#region Constructors: Public

		public SupplyPaymentStateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SupplyPaymentStateSchema(SupplyPaymentStateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SupplyPaymentStateSchema(SupplyPaymentStateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("8dd32ae1-2132-4991-b2f9-9c7ce5825c12");
			Name = "SupplyPaymentState";
			ParentSchemaUId = new Guid("270f817e-6b26-499c-8a5a-61d02846ee36");
			ExtendParent = true;
			CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
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
			return new SupplyPaymentState(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SupplyPaymentState_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SupplyPaymentStateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SupplyPaymentStateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8dd32ae1-2132-4991-b2f9-9c7ce5825c12"));
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentState

	/// <summary>
	/// Installment plan state.
	/// </summary>
	public class SupplyPaymentState : Terrasoft.Configuration.SupplyPaymentState_CrtSupplyPayment_Terrasoft
	{

		#region Constructors: Public

		public SupplyPaymentState(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SupplyPaymentState";
		}

		public SupplyPaymentState(SupplyPaymentState source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SupplyPaymentState_PRMOrderEventsProcess(UserConnection);
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
			return new SupplyPaymentState(this);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentState_PRMOrderEventsProcess

	/// <exclude/>
	public partial class SupplyPaymentState_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.SupplyPaymentState_CrtSupplyPaymentEventsProcess<TEntity> where TEntity : SupplyPaymentState
	{

		public SupplyPaymentState_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SupplyPaymentState_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8dd32ae1-2132-4991-b2f9-9c7ce5825c12");
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

	#region Class: SupplyPaymentState_PRMOrderEventsProcess

	/// <exclude/>
	public class SupplyPaymentState_PRMOrderEventsProcess : SupplyPaymentState_PRMOrderEventsProcess<SupplyPaymentState>
	{

		public SupplyPaymentState_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SupplyPaymentState_PRMOrderEventsProcess

	public partial class SupplyPaymentState_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SupplyPaymentStateEventsProcess

	/// <exclude/>
	public class SupplyPaymentStateEventsProcess : SupplyPaymentState_PRMOrderEventsProcess
	{

		public SupplyPaymentStateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

