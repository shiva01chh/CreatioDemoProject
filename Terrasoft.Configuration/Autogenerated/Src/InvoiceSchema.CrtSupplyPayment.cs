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

	#region Class: Invoice_CrtSupplyPayment_TerrasoftSchema

	/// <exclude/>
	public class Invoice_CrtSupplyPayment_TerrasoftSchema : Terrasoft.Configuration.Invoice_CrtInvoiceOrder_TerrasoftSchema
	{

		#region Constructors: Public

		public Invoice_CrtSupplyPayment_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Invoice_CrtSupplyPayment_TerrasoftSchema(Invoice_CrtSupplyPayment_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Invoice_CrtSupplyPayment_TerrasoftSchema(Invoice_CrtSupplyPayment_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b");
			Name = "Invoice_CrtSupplyPayment_Terrasoft";
			ParentSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
			ExtendParent = true;
			CreatedInPackageId = new Guid("c4bef748-df1b-4c41-878a-658ffe06f804");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b419c3b3-22c7-44ad-8fc8-c02618d362dc")) == null) {
				Columns.Add(CreateAmountWithoutTaxColumn());
			}
			if (Columns.FindByUId(new Guid("08be4ee9-724d-45ee-b01a-1906f7e9670c")) == null) {
				Columns.Add(CreatePrimaryAmountWithoutTaxColumn());
			}
			if (Columns.FindByUId(new Guid("a7a263e8-7fc8-409c-9ada-14d2d38ba1d1")) == null) {
				Columns.Add(CreatePaymentAmountWithoutTaxColumn());
			}
			if (Columns.FindByUId(new Guid("f6182f6b-cf24-4858-b9e2-5377f59fa07a")) == null) {
				Columns.Add(CreatePrimaryPaymentAmountWithoutTaxColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAmountWithoutTaxColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("b419c3b3-22c7-44ad-8fc8-c02618d362dc"),
				Name = @"AmountWithoutTax",
				CreatedInSchemaUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"),
				ModifiedInSchemaUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"),
				CreatedInPackageId = new Guid("a002bd5f-14f1-4196-ac19-0a0feddeb334")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryAmountWithoutTaxColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("08be4ee9-724d-45ee-b01a-1906f7e9670c"),
				Name = @"PrimaryAmountWithoutTax",
				CreatedInSchemaUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"),
				ModifiedInSchemaUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"),
				CreatedInPackageId = new Guid("a002bd5f-14f1-4196-ac19-0a0feddeb334")
			};
		}

		protected virtual EntitySchemaColumn CreatePaymentAmountWithoutTaxColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("a7a263e8-7fc8-409c-9ada-14d2d38ba1d1"),
				Name = @"PaymentAmountWithoutTax",
				CreatedInSchemaUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"),
				ModifiedInSchemaUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"),
				CreatedInPackageId = new Guid("a002bd5f-14f1-4196-ac19-0a0feddeb334")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryPaymentAmountWithoutTaxColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("f6182f6b-cf24-4858-b9e2-5377f59fa07a"),
				Name = @"PrimaryPaymentAmountWithoutTax",
				CreatedInSchemaUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"),
				ModifiedInSchemaUId = new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"),
				CreatedInPackageId = new Guid("a002bd5f-14f1-4196-ac19-0a0feddeb334")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Invoice_CrtSupplyPayment_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Invoice_CrtSupplyPaymentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Invoice_CrtSupplyPayment_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Invoice_CrtSupplyPayment_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7a364256-ee50-4219-aed1-dfe247a7832b"));
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_CrtSupplyPayment_Terrasoft

	/// <summary>
	/// Invoice.
	/// </summary>
	public class Invoice_CrtSupplyPayment_Terrasoft : Terrasoft.Configuration.Invoice_CrtInvoiceOrder_Terrasoft
	{

		#region Constructors: Public

		public Invoice_CrtSupplyPayment_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Invoice_CrtSupplyPayment_Terrasoft";
		}

		public Invoice_CrtSupplyPayment_Terrasoft(Invoice_CrtSupplyPayment_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Amount not including taxes.
		/// </summary>
		public Decimal AmountWithoutTax {
			get {
				return GetTypedColumnValue<Decimal>("AmountWithoutTax");
			}
			set {
				SetColumnValue("AmountWithoutTax", value);
			}
		}

		/// <summary>
		/// Amount not including taxes, base currency.
		/// </summary>
		public Decimal PrimaryAmountWithoutTax {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryAmountWithoutTax");
			}
			set {
				SetColumnValue("PrimaryAmountWithoutTax", value);
			}
		}

		/// <summary>
		/// Payment amount not including taxes.
		/// </summary>
		public Decimal PaymentAmountWithoutTax {
			get {
				return GetTypedColumnValue<Decimal>("PaymentAmountWithoutTax");
			}
			set {
				SetColumnValue("PaymentAmountWithoutTax", value);
			}
		}

		/// <summary>
		/// Payment amount not including taxes, base currency.
		/// </summary>
		public Decimal PrimaryPaymentAmountWithoutTax {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryPaymentAmountWithoutTax");
			}
			set {
				SetColumnValue("PrimaryPaymentAmountWithoutTax", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Invoice_CrtSupplyPaymentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Invoice_CrtSupplyPayment_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Invoice_CrtSupplyPayment_TerrasoftDeleting", e);
			Saved += (s, e) => ThrowEvent("Invoice_CrtSupplyPayment_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Invoice_CrtSupplyPayment_TerrasoftSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Invoice_CrtSupplyPayment_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_CrtSupplyPaymentEventsProcess

	/// <exclude/>
	public partial class Invoice_CrtSupplyPaymentEventsProcess<TEntity> : Terrasoft.Configuration.Invoice_CrtInvoiceOrderEventsProcess<TEntity> where TEntity : Invoice_CrtSupplyPayment_Terrasoft
	{

		public Invoice_CrtSupplyPaymentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Invoice_CrtSupplyPaymentEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			_isInvoiceCanceled = () => {{ return false; }};
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7a364256-ee50-4219-aed1-dfe247a7832b");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private Func<bool> _isInvoiceCanceled;
		public virtual bool IsInvoiceCanceled {
			get {
				return (_isInvoiceCanceled ?? (_isInvoiceCanceled = () => false)).Invoke();
			}
			set {
				_isInvoiceCanceled = () => { return value; };
			}
		}

		public virtual Object ChangedColumnValues {
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

	#region Class: Invoice_CrtSupplyPaymentEventsProcess

	/// <exclude/>
	public class Invoice_CrtSupplyPaymentEventsProcess : Invoice_CrtSupplyPaymentEventsProcess<Invoice_CrtSupplyPayment_Terrasoft>
	{

		public Invoice_CrtSupplyPaymentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

