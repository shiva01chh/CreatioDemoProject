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
	using Terrasoft.Configuration;
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

	#region Class: Invoice_CrtInvoiceOrder_TerrasoftSchema

	/// <exclude/>
	public class Invoice_CrtInvoiceOrder_TerrasoftSchema : Terrasoft.Configuration.Invoice_CrtInvoice_TerrasoftSchema
	{

		#region Constructors: Public

		public Invoice_CrtInvoiceOrder_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Invoice_CrtInvoiceOrder_TerrasoftSchema(Invoice_CrtInvoiceOrder_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Invoice_CrtInvoiceOrder_TerrasoftSchema(Invoice_CrtInvoiceOrder_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("0cd1b612-1b9a-4681-883d-9b076c21cec3");
			Name = "Invoice_CrtInvoiceOrder_Terrasoft";
			ParentSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
			ExtendParent = true;
			CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("4e473dd6-40a8-463b-8ae4-9af8afe2599e")) == null) {
				Columns.Add(CreateOrderColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateOrderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4e473dd6-40a8-463b-8ae4-9af8afe2599e"),
				Name = @"Order",
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0cd1b612-1b9a-4681-883d-9b076c21cec3"),
				ModifiedInSchemaUId = new Guid("0cd1b612-1b9a-4681-883d-9b076c21cec3"),
				CreatedInPackageId = new Guid("52964353-9e8f-48e5-896c-d741fb4f3eb4")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Invoice_CrtInvoiceOrder_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Invoice_CrtInvoiceOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Invoice_CrtInvoiceOrder_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Invoice_CrtInvoiceOrder_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0cd1b612-1b9a-4681-883d-9b076c21cec3"));
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_CrtInvoiceOrder_Terrasoft

	/// <summary>
	/// Invoice.
	/// </summary>
	public class Invoice_CrtInvoiceOrder_Terrasoft : Terrasoft.Configuration.Invoice_CrtInvoice_Terrasoft
	{

		#region Constructors: Public

		public Invoice_CrtInvoiceOrder_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Invoice_CrtInvoiceOrder_Terrasoft";
		}

		public Invoice_CrtInvoiceOrder_Terrasoft(Invoice_CrtInvoiceOrder_Terrasoft source)
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
			var process = new Invoice_CrtInvoiceOrderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Invoice_CrtInvoiceOrder_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("Invoice_CrtInvoiceOrder_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("Invoice_CrtInvoiceOrder_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Invoice_CrtInvoiceOrder_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_CrtInvoiceOrderEventsProcess

	/// <exclude/>
	public partial class Invoice_CrtInvoiceOrderEventsProcess<TEntity> : Terrasoft.Configuration.Invoice_CrtInvoiceEventsProcess<TEntity> where TEntity : Invoice_CrtInvoiceOrder_Terrasoft
	{

		public Invoice_CrtInvoiceOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Invoice_CrtInvoiceOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0cd1b612-1b9a-4681-883d-9b076c21cec3");
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

	#region Class: Invoice_CrtInvoiceOrderEventsProcess

	/// <exclude/>
	public class Invoice_CrtInvoiceOrderEventsProcess : Invoice_CrtInvoiceOrderEventsProcess<Invoice_CrtInvoiceOrder_Terrasoft>
	{

		public Invoice_CrtInvoiceOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Invoice_CrtInvoiceOrderEventsProcess

	public partial class Invoice_CrtInvoiceOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

