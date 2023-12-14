﻿namespace Terrasoft.Configuration
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

	#region Class: InvoiceSchema

	/// <exclude/>
	public class InvoiceSchema : Terrasoft.Configuration.Invoice_CrtOpportunityInvoice_TerrasoftSchema
	{

		#region Constructors: Public

		public InvoiceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public InvoiceSchema(InvoiceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public InvoiceSchema(InvoiceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("b9290d9b-6832-4a26-8bd6-a0cff5aabc17");
			Name = "Invoice";
			ParentSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
			ExtendParent = true;
			CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("85d0da72-7b6d-43fc-9279-bb96431481e2")) == null) {
				Columns.Add(CreateProjectColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateProjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("85d0da72-7b6d-43fc-9279-bb96431481e2"),
				Name = @"Project",
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("b9290d9b-6832-4a26-8bd6-a0cff5aabc17"),
				ModifiedInSchemaUId = new Guid("b9290d9b-6832-4a26-8bd6-a0cff5aabc17"),
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Invoice(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Invoice_InvoiceInProjectEventsProcess(userConnection);
		}

		public override object Clone() {
			return new InvoiceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new InvoiceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b9290d9b-6832-4a26-8bd6-a0cff5aabc17"));
		}

		#endregion

	}

	#endregion

	#region Class: Invoice

	/// <summary>
	/// Invoice.
	/// </summary>
	public class Invoice : Terrasoft.Configuration.Invoice_CrtOpportunityInvoice_Terrasoft
	{

		#region Constructors: Public

		public Invoice(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Invoice";
		}

		public Invoice(Invoice source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ProjectId {
			get {
				return GetTypedColumnValue<Guid>("ProjectId");
			}
			set {
				SetColumnValue("ProjectId", value);
				_project = null;
			}
		}

		/// <exclude/>
		public string ProjectName {
			get {
				return GetTypedColumnValue<string>("ProjectName");
			}
			set {
				SetColumnValue("ProjectName", value);
				if (_project != null) {
					_project.Name = value;
				}
			}
		}

		private Project _project;
		/// <summary>
		/// Project.
		/// </summary>
		public Project Project {
			get {
				return _project ??
					(_project = LookupColumnEntities.GetEntity("Project") as Project);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Invoice_InvoiceInProjectEventsProcess(UserConnection);
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
			return new Invoice(this);
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_InvoiceInProjectEventsProcess

	/// <exclude/>
	public partial class Invoice_InvoiceInProjectEventsProcess<TEntity> : Terrasoft.Configuration.Invoice_CrtOpportunityInvoiceEventsProcess<TEntity> where TEntity : Invoice
	{

		public Invoice_InvoiceInProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Invoice_InvoiceInProjectEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b9290d9b-6832-4a26-8bd6-a0cff5aabc17");
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

	#region Class: Invoice_InvoiceInProjectEventsProcess

	/// <exclude/>
	public class Invoice_InvoiceInProjectEventsProcess : Invoice_InvoiceInProjectEventsProcess<Invoice>
	{

		public Invoice_InvoiceInProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Invoice_InvoiceInProjectEventsProcess

	public partial class Invoice_InvoiceInProjectEventsProcess<TEntity>
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


	#region Class: InvoiceEventsProcess

	/// <exclude/>
	public class InvoiceEventsProcess : Invoice_InvoiceInProjectEventsProcess
	{

		public InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

