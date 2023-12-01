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

	#region Class: Contract_CrtOrderContract_TerrasoftSchema

	/// <exclude/>
	public class Contract_CrtOrderContract_TerrasoftSchema : Terrasoft.Configuration.Contract_CrtContract_TerrasoftSchema
	{

		#region Constructors: Public

		public Contract_CrtOrderContract_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contract_CrtOrderContract_TerrasoftSchema(Contract_CrtOrderContract_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contract_CrtOrderContract_TerrasoftSchema(Contract_CrtOrderContract_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("045d818c-9760-4555-9b59-7b6158c6b816");
			Name = "Contract_CrtOrderContract_Terrasoft";
			ParentSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810");
			ExtendParent = true;
			CreatedInPackageId = new Guid("2a36bdd9-0ef6-48f3-957f-b7efa409d0a7");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fe23692e-01f1-476d-9605-3a1fede76644")) == null) {
				Columns.Add(CreateOrderColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateOrderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fe23692e-01f1-476d-9605-3a1fede76644"),
				Name = @"Order",
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("045d818c-9760-4555-9b59-7b6158c6b816"),
				ModifiedInSchemaUId = new Guid("045d818c-9760-4555-9b59-7b6158c6b816"),
				CreatedInPackageId = new Guid("2a36bdd9-0ef6-48f3-957f-b7efa409d0a7")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contract_CrtOrderContract_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contract_CrtOrderContractEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contract_CrtOrderContract_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contract_CrtOrderContract_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("045d818c-9760-4555-9b59-7b6158c6b816"));
		}

		#endregion

	}

	#endregion

	#region Class: Contract_CrtOrderContract_Terrasoft

	/// <summary>
	/// Contract.
	/// </summary>
	public class Contract_CrtOrderContract_Terrasoft : Terrasoft.Configuration.Contract_CrtContract_Terrasoft
	{

		#region Constructors: Public

		public Contract_CrtOrderContract_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contract_CrtOrderContract_Terrasoft";
		}

		public Contract_CrtOrderContract_Terrasoft(Contract_CrtOrderContract_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid OrderId {
			get {
				return GetTypedColumnValue<Guid>("OrderId");
			}
			set {
				SetColumnValue("OrderId", value);
				_order = null;
			}
		}

		/// <exclude/>
		public string OrderNumber {
			get {
				return GetTypedColumnValue<string>("OrderNumber");
			}
			set {
				SetColumnValue("OrderNumber", value);
				if (_order != null) {
					_order.Number = value;
				}
			}
		}

		private Order _order;
		/// <summary>
		/// Order.
		/// </summary>
		public Order Order {
			get {
				return _order ??
					(_order = LookupColumnEntities.GetEntity("Order") as Order);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contract_CrtOrderContractEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Contract_CrtOrderContract_TerrasoftDeleted", e);
			Validating += (s, e) => ThrowEvent("Contract_CrtOrderContract_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Contract_CrtOrderContract_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contract_CrtOrderContractEventsProcess

	/// <exclude/>
	public partial class Contract_CrtOrderContractEventsProcess<TEntity> : Terrasoft.Configuration.Contract_CrtContractEventsProcess<TEntity> where TEntity : Contract_CrtOrderContract_Terrasoft
	{

		public Contract_CrtOrderContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contract_CrtOrderContractEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("045d818c-9760-4555-9b59-7b6158c6b816");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid oldOrderId {
			get;
			set;
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

	#region Class: Contract_CrtOrderContractEventsProcess

	/// <exclude/>
	public class Contract_CrtOrderContractEventsProcess : Contract_CrtOrderContractEventsProcess<Contract_CrtOrderContract_Terrasoft>
	{

		public Contract_CrtOrderContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contract_CrtOrderContractEventsProcess

	public partial class Contract_CrtOrderContractEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

