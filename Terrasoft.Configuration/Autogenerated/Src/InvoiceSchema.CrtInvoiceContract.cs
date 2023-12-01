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

	#region Class: Invoice_CrtInvoiceContract_TerrasoftSchema

	/// <exclude/>
	public class Invoice_CrtInvoiceContract_TerrasoftSchema : Terrasoft.Configuration.Invoice_CrtSupplyPayment_TerrasoftSchema
	{

		#region Constructors: Public

		public Invoice_CrtInvoiceContract_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Invoice_CrtInvoiceContract_TerrasoftSchema(Invoice_CrtInvoiceContract_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Invoice_CrtInvoiceContract_TerrasoftSchema(Invoice_CrtInvoiceContract_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("f78de52b-73c0-471f-9a69-d93183ba0fd9");
			Name = "Invoice_CrtInvoiceContract_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = true;
			CreatedInPackageId = new Guid("ccd436d6-0b26-486d-9df7-4fd6de2cb937");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNumberColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeOwnerColumn() {
			base.InitializeOwnerColumn();
			OwnerColumn = CreateOwnerColumn();
			if (Columns.FindByUId(OwnerColumn.UId) == null) {
				Columns.Add(OwnerColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("2467a848-5e0b-4891-8657-0a5776eb4ab9")) == null) {
				Columns.Add(CreateContractColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("f78de52b-73c0-471f-9a69-d93183ba0fd9");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("f78de52b-73c0-471f-9a69-d93183ba0fd9");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("f78de52b-73c0-471f-9a69-d93183ba0fd9");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("f78de52b-73c0-471f-9a69-d93183ba0fd9");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("f78de52b-73c0-471f-9a69-d93183ba0fd9");
			return column;
		}

		protected virtual EntitySchemaColumn CreateContractColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2467a848-5e0b-4891-8657-0a5776eb4ab9"),
				Name = @"Contract",
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f78de52b-73c0-471f-9a69-d93183ba0fd9"),
				ModifiedInSchemaUId = new Guid("f78de52b-73c0-471f-9a69-d93183ba0fd9"),
				CreatedInPackageId = new Guid("ccd436d6-0b26-486d-9df7-4fd6de2cb937")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Invoice_CrtInvoiceContract_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Invoice_CrtInvoiceContractEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Invoice_CrtInvoiceContract_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Invoice_CrtInvoiceContract_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f78de52b-73c0-471f-9a69-d93183ba0fd9"));
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_CrtInvoiceContract_Terrasoft

	/// <summary>
	/// Invoice.
	/// </summary>
	public class Invoice_CrtInvoiceContract_Terrasoft : Terrasoft.Configuration.Invoice_CrtSupplyPayment_Terrasoft
	{

		#region Constructors: Public

		public Invoice_CrtInvoiceContract_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Invoice_CrtInvoiceContract_Terrasoft";
		}

		public Invoice_CrtInvoiceContract_Terrasoft(Invoice_CrtInvoiceContract_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ContractId {
			get {
				return GetTypedColumnValue<Guid>("ContractId");
			}
			set {
				SetColumnValue("ContractId", value);
				_contract = null;
			}
		}

		/// <exclude/>
		public string ContractNumber {
			get {
				return GetTypedColumnValue<string>("ContractNumber");
			}
			set {
				SetColumnValue("ContractNumber", value);
				if (_contract != null) {
					_contract.Number = value;
				}
			}
		}

		private Contract _contract;
		/// <summary>
		/// Contract.
		/// </summary>
		public Contract Contract {
			get {
				return _contract ??
					(_contract = LookupColumnEntities.GetEntity("Contract") as Contract);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Invoice_CrtInvoiceContractEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Invoice_CrtInvoiceContract_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("Invoice_CrtInvoiceContract_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("Invoice_CrtInvoiceContract_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Invoice_CrtInvoiceContract_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_CrtInvoiceContractEventsProcess

	/// <exclude/>
	public partial class Invoice_CrtInvoiceContractEventsProcess<TEntity> : Terrasoft.Configuration.Invoice_CrtSupplyPaymentEventsProcess<TEntity> where TEntity : Invoice_CrtInvoiceContract_Terrasoft
	{

		public Invoice_CrtInvoiceContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Invoice_CrtInvoiceContractEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f78de52b-73c0-471f-9a69-d93183ba0fd9");
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

	#region Class: Invoice_CrtInvoiceContractEventsProcess

	/// <exclude/>
	public class Invoice_CrtInvoiceContractEventsProcess : Invoice_CrtInvoiceContractEventsProcess<Invoice_CrtInvoiceContract_Terrasoft>
	{

		public Invoice_CrtInvoiceContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Invoice_CrtInvoiceContractEventsProcess

	public partial class Invoice_CrtInvoiceContractEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

