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

	#region Class: InvoiceFile_CrtInvoice_TerrasoftSchema

	/// <exclude/>
	public class InvoiceFile_CrtInvoice_TerrasoftSchema : Terrasoft.Configuration.FileSchema
	{

		#region Constructors: Public

		public InvoiceFile_CrtInvoice_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public InvoiceFile_CrtInvoice_TerrasoftSchema(InvoiceFile_CrtInvoice_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public InvoiceFile_CrtInvoice_TerrasoftSchema(InvoiceFile_CrtInvoice_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e7d51836-a27a-4e52-979c-29d114414085");
			RealUId = new Guid("e7d51836-a27a-4e52-979c-29d114414085");
			Name = "InvoiceFile_CrtInvoice_Terrasoft";
			ParentSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			ExtendParent = false;
			CreatedInPackageId = new Guid("8a6b5719-da97-4634-8f04-4375bc29ffcf");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("68b6e313-9f26-471f-9dcc-ca8200b57895")) == null) {
				Columns.Add(CreateInvoiceColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateInvoiceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("68b6e313-9f26-471f-9dcc-ca8200b57895"),
				Name = @"Invoice",
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("e7d51836-a27a-4e52-979c-29d114414085"),
				ModifiedInSchemaUId = new Guid("e7d51836-a27a-4e52-979c-29d114414085"),
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
			return new InvoiceFile_CrtInvoice_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new InvoiceFile_CrtInvoiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new InvoiceFile_CrtInvoice_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new InvoiceFile_CrtInvoice_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e7d51836-a27a-4e52-979c-29d114414085"));
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceFile_CrtInvoice_Terrasoft

	/// <summary>
	/// File and link of invoice.
	/// </summary>
	public class InvoiceFile_CrtInvoice_Terrasoft : Terrasoft.Configuration.File
	{

		#region Constructors: Public

		public InvoiceFile_CrtInvoice_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "InvoiceFile_CrtInvoice_Terrasoft";
		}

		public InvoiceFile_CrtInvoice_Terrasoft(InvoiceFile_CrtInvoice_Terrasoft source)
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
			var process = new InvoiceFile_CrtInvoiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("InvoiceFile_CrtInvoice_TerrasoftDeleted", e);
			Updated += (s, e) => ThrowEvent("InvoiceFile_CrtInvoice_TerrasoftUpdated", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new InvoiceFile_CrtInvoice_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceFile_CrtInvoiceEventsProcess

	/// <exclude/>
	public partial class InvoiceFile_CrtInvoiceEventsProcess<TEntity> : Terrasoft.Configuration.File_PRMPortalEventsProcess<TEntity> where TEntity : InvoiceFile_CrtInvoice_Terrasoft
	{

		public InvoiceFile_CrtInvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InvoiceFile_CrtInvoiceEventsProcess";
			SchemaUId = new Guid("e7d51836-a27a-4e52-979c-29d114414085");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e7d51836-a27a-4e52-979c-29d114414085");
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

	#region Class: InvoiceFile_CrtInvoiceEventsProcess

	/// <exclude/>
	public class InvoiceFile_CrtInvoiceEventsProcess : InvoiceFile_CrtInvoiceEventsProcess<InvoiceFile_CrtInvoice_Terrasoft>
	{

		public InvoiceFile_CrtInvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

