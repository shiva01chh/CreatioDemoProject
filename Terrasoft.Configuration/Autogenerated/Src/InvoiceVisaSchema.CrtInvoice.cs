namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration.RightsService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Mail;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: InvoiceVisa_CrtInvoice_TerrasoftSchema

	/// <exclude/>
	public class InvoiceVisa_CrtInvoice_TerrasoftSchema : Terrasoft.Configuration.BaseVisaSchema
	{

		#region Constructors: Public

		public InvoiceVisa_CrtInvoice_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public InvoiceVisa_CrtInvoice_TerrasoftSchema(InvoiceVisa_CrtInvoice_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public InvoiceVisa_CrtInvoice_TerrasoftSchema(InvoiceVisa_CrtInvoice_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ec034d19-5185-497d-9066-29f2973037f1");
			RealUId = new Guid("ec034d19-5185-497d-9066-29f2973037f1");
			Name = "InvoiceVisa_CrtInvoice_Terrasoft";
			ParentSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66");
			ExtendParent = false;
			CreatedInPackageId = new Guid("8b1c57bf-1ff6-4af0-890b-4cc1ace5ccaa");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a77a54ba-d2b3-4ddb-b195-2c2d14a375b6")) == null) {
				Columns.Add(CreateInvoiceColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateInvoiceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a77a54ba-d2b3-4ddb-b195-2c2d14a375b6"),
				Name = @"Invoice",
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("ec034d19-5185-497d-9066-29f2973037f1"),
				ModifiedInSchemaUId = new Guid("ec034d19-5185-497d-9066-29f2973037f1"),
				CreatedInPackageId = new Guid("30bec7d4-5068-42a2-ab31-4d4a3fc4e524")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new InvoiceVisa_CrtInvoice_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new InvoiceVisa_CrtInvoiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new InvoiceVisa_CrtInvoice_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new InvoiceVisa_CrtInvoice_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ec034d19-5185-497d-9066-29f2973037f1"));
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceVisa_CrtInvoice_Terrasoft

	/// <summary>
	/// Invoice approval .
	/// </summary>
	public class InvoiceVisa_CrtInvoice_Terrasoft : Terrasoft.Configuration.BaseVisa
	{

		#region Constructors: Public

		public InvoiceVisa_CrtInvoice_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "InvoiceVisa_CrtInvoice_Terrasoft";
		}

		public InvoiceVisa_CrtInvoice_Terrasoft(InvoiceVisa_CrtInvoice_Terrasoft source)
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
			var process = new InvoiceVisa_CrtInvoiceEventsProcess(UserConnection);
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
			return new InvoiceVisa_CrtInvoice_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceVisa_CrtInvoiceEventsProcess

	/// <exclude/>
	public partial class InvoiceVisa_CrtInvoiceEventsProcess<TEntity> : Terrasoft.Configuration.BaseVisa_CrtProcessDesignerEventsProcess<TEntity> where TEntity : InvoiceVisa_CrtInvoice_Terrasoft
	{

		public InvoiceVisa_CrtInvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InvoiceVisa_CrtInvoiceEventsProcess";
			SchemaUId = new Guid("ec034d19-5185-497d-9066-29f2973037f1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ec034d19-5185-497d-9066-29f2973037f1");
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

	#region Class: InvoiceVisa_CrtInvoiceEventsProcess

	/// <exclude/>
	public class InvoiceVisa_CrtInvoiceEventsProcess : InvoiceVisa_CrtInvoiceEventsProcess<InvoiceVisa_CrtInvoice_Terrasoft>
	{

		public InvoiceVisa_CrtInvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

