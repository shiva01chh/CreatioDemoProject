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

	#region Class: InvoiceProduct_CrtInvoice_TerrasoftSchema

	/// <exclude/>
	public class InvoiceProduct_CrtInvoice_TerrasoftSchema : Terrasoft.Configuration.BaseProductEntrySchema
	{

		#region Constructors: Public

		public InvoiceProduct_CrtInvoice_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public InvoiceProduct_CrtInvoice_TerrasoftSchema(InvoiceProduct_CrtInvoice_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public InvoiceProduct_CrtInvoice_TerrasoftSchema(InvoiceProduct_CrtInvoice_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("732baa21-890b-4894-a457-623630e33a6f");
			RealUId = new Guid("732baa21-890b-4894-a457-623630e33a6f");
			Name = "InvoiceProduct_CrtInvoice_Terrasoft";
			ParentSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("86bbc99f-1967-4f26-8394-3720e7d22144")) == null) {
				Columns.Add(CreateInvoiceColumn());
			}
		}

		protected override EntitySchemaColumn CreateUnitColumn() {
			EntitySchemaColumn column = base.CreateUnitColumn();
			column.IsSimpleLookup = true;
			column.ModifiedInSchemaUId = new Guid("732baa21-890b-4894-a457-623630e33a6f");
			return column;
		}

		protected override EntitySchemaColumn CreateTaxColumn() {
			EntitySchemaColumn column = base.CreateTaxColumn();
			column.IsSimpleLookup = true;
			column.ModifiedInSchemaUId = new Guid("732baa21-890b-4894-a457-623630e33a6f");
			return column;
		}

		protected virtual EntitySchemaColumn CreateInvoiceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("86bbc99f-1967-4f26-8394-3720e7d22144"),
				Name = @"Invoice",
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("732baa21-890b-4894-a457-623630e33a6f"),
				ModifiedInSchemaUId = new Guid("732baa21-890b-4894-a457-623630e33a6f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new InvoiceProduct_CrtInvoice_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new InvoiceProduct_CrtInvoiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new InvoiceProduct_CrtInvoice_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new InvoiceProduct_CrtInvoice_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("732baa21-890b-4894-a457-623630e33a6f"));
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceProduct_CrtInvoice_Terrasoft

	/// <summary>
	/// Product in invoice.
	/// </summary>
	public class InvoiceProduct_CrtInvoice_Terrasoft : Terrasoft.Configuration.BaseProductEntry
	{

		#region Constructors: Public

		public InvoiceProduct_CrtInvoice_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "InvoiceProduct_CrtInvoice_Terrasoft";
		}

		public InvoiceProduct_CrtInvoice_Terrasoft(InvoiceProduct_CrtInvoice_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid InvoiceId {
			get {
				return GetTypedColumnValue<Guid>("InvoiceId");
			}
			set {
				SetColumnValue("InvoiceId", value);
				_invoice = null;
			}
		}

		/// <exclude/>
		public string InvoiceNumber {
			get {
				return GetTypedColumnValue<string>("InvoiceNumber");
			}
			set {
				SetColumnValue("InvoiceNumber", value);
				if (_invoice != null) {
					_invoice.Number = value;
				}
			}
		}

		private Invoice _invoice;
		/// <summary>
		/// Invoice.
		/// </summary>
		public Invoice Invoice {
			get {
				return _invoice ??
					(_invoice = LookupColumnEntities.GetEntity("Invoice") as Invoice);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new InvoiceProduct_CrtInvoiceEventsProcess(UserConnection);
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
			return new InvoiceProduct_CrtInvoice_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceProduct_CrtInvoiceEventsProcess

	/// <exclude/>
	public partial class InvoiceProduct_CrtInvoiceEventsProcess<TEntity> : Terrasoft.Configuration.BaseProductEntry_CrtProductCatalogueEventsProcess<TEntity> where TEntity : InvoiceProduct_CrtInvoice_Terrasoft
	{

		public InvoiceProduct_CrtInvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InvoiceProduct_CrtInvoiceEventsProcess";
			SchemaUId = new Guid("732baa21-890b-4894-a457-623630e33a6f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("732baa21-890b-4894-a457-623630e33a6f");
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

	#region Class: InvoiceProduct_CrtInvoiceEventsProcess

	/// <exclude/>
	public class InvoiceProduct_CrtInvoiceEventsProcess : InvoiceProduct_CrtInvoiceEventsProcess<InvoiceProduct_CrtInvoice_Terrasoft>
	{

		public InvoiceProduct_CrtInvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

