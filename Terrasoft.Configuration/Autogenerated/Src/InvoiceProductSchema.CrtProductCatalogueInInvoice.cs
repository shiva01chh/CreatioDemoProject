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

	#region Class: InvoiceProduct_CrtProductCatalogueInInvoice_TerrasoftSchema

	/// <exclude/>
	public class InvoiceProduct_CrtProductCatalogueInInvoice_TerrasoftSchema : Terrasoft.Configuration.InvoiceProduct_CrtInvoice_TerrasoftSchema
	{

		#region Constructors: Public

		public InvoiceProduct_CrtProductCatalogueInInvoice_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public InvoiceProduct_CrtProductCatalogueInInvoice_TerrasoftSchema(InvoiceProduct_CrtProductCatalogueInInvoice_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public InvoiceProduct_CrtProductCatalogueInInvoice_TerrasoftSchema(InvoiceProduct_CrtProductCatalogueInInvoice_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("d47664c3-91ea-4cab-aa3f-d7932591e1dc");
			Name = "InvoiceProduct_CrtProductCatalogueInInvoice_Terrasoft";
			ParentSchemaUId = new Guid("732baa21-890b-4894-a457-623630e33a6f");
			ExtendParent = true;
			CreatedInPackageId = new Guid("4a4ef5d1-f987-4ea2-a7d3-caa8317588e4");
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
			return new InvoiceProduct_CrtProductCatalogueInInvoice_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new InvoiceProduct_CrtProductCatalogueInInvoiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new InvoiceProduct_CrtProductCatalogueInInvoice_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new InvoiceProduct_CrtProductCatalogueInInvoice_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d47664c3-91ea-4cab-aa3f-d7932591e1dc"));
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceProduct_CrtProductCatalogueInInvoice_Terrasoft

	/// <summary>
	/// Product in invoice.
	/// </summary>
	public class InvoiceProduct_CrtProductCatalogueInInvoice_Terrasoft : Terrasoft.Configuration.InvoiceProduct_CrtInvoice_Terrasoft
	{

		#region Constructors: Public

		public InvoiceProduct_CrtProductCatalogueInInvoice_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "InvoiceProduct_CrtProductCatalogueInInvoice_Terrasoft";
		}

		public InvoiceProduct_CrtProductCatalogueInInvoice_Terrasoft(InvoiceProduct_CrtProductCatalogueInInvoice_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new InvoiceProduct_CrtProductCatalogueInInvoiceEventsProcess(UserConnection);
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
			return new InvoiceProduct_CrtProductCatalogueInInvoice_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceProduct_CrtProductCatalogueInInvoiceEventsProcess

	/// <exclude/>
	public partial class InvoiceProduct_CrtProductCatalogueInInvoiceEventsProcess<TEntity> : Terrasoft.Configuration.InvoiceProduct_CrtInvoiceEventsProcess<TEntity> where TEntity : InvoiceProduct_CrtProductCatalogueInInvoice_Terrasoft
	{

		public InvoiceProduct_CrtProductCatalogueInInvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InvoiceProduct_CrtProductCatalogueInInvoiceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d47664c3-91ea-4cab-aa3f-d7932591e1dc");
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

	#region Class: InvoiceProduct_CrtProductCatalogueInInvoiceEventsProcess

	/// <exclude/>
	public class InvoiceProduct_CrtProductCatalogueInInvoiceEventsProcess : InvoiceProduct_CrtProductCatalogueInInvoiceEventsProcess<InvoiceProduct_CrtProductCatalogueInInvoice_Terrasoft>
	{

		public InvoiceProduct_CrtProductCatalogueInInvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: InvoiceProduct_CrtProductCatalogueInInvoiceEventsProcess

	public partial class InvoiceProduct_CrtProductCatalogueInInvoiceEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

