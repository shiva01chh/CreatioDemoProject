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

	#region Class: Invoice_PRMPortal_TerrasoftSchema

	/// <exclude/>
	public class Invoice_PRMPortal_TerrasoftSchema : Terrasoft.Configuration.Invoice_CrtOpportunityInvoice_TerrasoftSchema
	{

		#region Constructors: Public

		public Invoice_PRMPortal_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Invoice_PRMPortal_TerrasoftSchema(Invoice_PRMPortal_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Invoice_PRMPortal_TerrasoftSchema(Invoice_PRMPortal_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("ee2e8e67-a932-4897-9f22-53b8bcdaf300");
			Name = "Invoice_PRMPortal_Terrasoft";
			ParentSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
			ExtendParent = true;
			CreatedInPackageId = new Guid("2b000645-6072-461d-8963-11edfee86881");
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
			return new Invoice_PRMPortal_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Invoice_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Invoice_PRMPortal_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Invoice_PRMPortal_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ee2e8e67-a932-4897-9f22-53b8bcdaf300"));
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_PRMPortal_Terrasoft

	/// <summary>
	/// Invoice.
	/// </summary>
	public class Invoice_PRMPortal_Terrasoft : Terrasoft.Configuration.Invoice_CrtOpportunityInvoice_Terrasoft
	{

		#region Constructors: Public

		public Invoice_PRMPortal_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Invoice_PRMPortal_Terrasoft";
		}

		public Invoice_PRMPortal_Terrasoft(Invoice_PRMPortal_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Invoice_PRMPortalEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("Invoice_PRMPortal_TerrasoftDeleting", e);
			Saved += (s, e) => ThrowEvent("Invoice_PRMPortal_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Invoice_PRMPortal_TerrasoftSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Invoice_PRMPortal_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_PRMPortalEventsProcess

	/// <exclude/>
	public partial class Invoice_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.Invoice_CrtOpportunityInvoiceEventsProcess<TEntity> where TEntity : Invoice_PRMPortal_Terrasoft
	{

		public Invoice_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Invoice_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ee2e8e67-a932-4897-9f22-53b8bcdaf300");
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

	#region Class: Invoice_PRMPortalEventsProcess

	/// <exclude/>
	public class Invoice_PRMPortalEventsProcess : Invoice_PRMPortalEventsProcess<Invoice_PRMPortal_Terrasoft>
	{

		public Invoice_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Invoice_PRMPortalEventsProcess

	public partial class Invoice_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void OnSaved() {
			var orderAmountHelper = GetOrderAmountHelper();
			if (NeedFinRecalc) {
				bool productAmountRecalculated = orderAmountHelper.UpdateInvoiceProductAmountOnCurrencyChange(Entity.PrimaryColumnValue);
				NeedFinRecalc = !productAmountRecalculated;
			}
			base.OnSaved();
			var changedColumnValues = ChangedColumnValues as List<EntityColumnValue>;
			if (changedColumnValues == null) {
				return;
			}
			bool orderPaymentAmountUpdated;
			orderAmountHelper.UpdateSupplyPaymentElementOnInvoiceChanged(Entity.PrimaryColumnValue, changedColumnValues, out orderPaymentAmountUpdated);
			var paymentStatusColumnValue = changedColumnValues.FirstOrDefault(changedColumn => changedColumn.Column.Name == "PaymentStatus");
			if (paymentStatusColumnValue != null && (Guid)paymentStatusColumnValue.Value == PassportConstants.InvoicePaymentStatusCanceled) {
				CleanInvoiceIdInSupplyPayment();
			}
			if (!orderPaymentAmountUpdated && changedColumnValues.ConvertAll(cv => cv.Column.Name).Intersect(new[] { "PrimaryPaymentAmount", "PaymentStatus" }).Any()) {
				orderAmountHelper.UpdateOrderPaymentAmountOnInvoiceChanged(Entity.PrimaryColumnValue);
			}
		}

		#endregion

	}

	#endregion

}

