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

	#region Class: InvoicePaymentStatus_CrtInvoice_TerrasoftSchema

	/// <exclude/>
	public class InvoicePaymentStatus_CrtInvoice_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public InvoicePaymentStatus_CrtInvoice_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public InvoicePaymentStatus_CrtInvoice_TerrasoftSchema(InvoicePaymentStatus_CrtInvoice_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public InvoicePaymentStatus_CrtInvoice_TerrasoftSchema(InvoicePaymentStatus_CrtInvoice_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861");
			RealUId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861");
			Name = "InvoicePaymentStatus_CrtInvoice_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColorColumn() {
			base.InitializePrimaryColorColumn();
			PrimaryColorColumn = CreateColorColumn();
			if (Columns.FindByUId(PrimaryColorColumn.UId) == null) {
				Columns.Add(PrimaryColorColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ca97d08a-da88-4e75-a732-6501bc043dcb")) == null) {
				Columns.Add(CreateFinalStatusColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected virtual EntitySchemaColumn CreateFinalStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("ca97d08a-da88-4e75-a732-6501bc043dcb"),
				Name = @"FinalStatus",
				CreatedInSchemaUId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861"),
				ModifiedInSchemaUId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Color")) {
				UId = new Guid("15290056-fbd9-307d-6279-8d82d35a5738"),
				Name = @"Color",
				CreatedInSchemaUId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861"),
				ModifiedInSchemaUId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861"),
				CreatedInPackageId = new Guid("b91ce9ea-207f-42d3-9efa-21ea47a812e2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new InvoicePaymentStatus_CrtInvoice_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new InvoicePaymentStatus_CrtInvoiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new InvoicePaymentStatus_CrtInvoice_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new InvoicePaymentStatus_CrtInvoice_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861"));
		}

		#endregion

	}

	#endregion

	#region Class: InvoicePaymentStatus_CrtInvoice_Terrasoft

	/// <summary>
	/// Invoice payment status.
	/// </summary>
	public class InvoicePaymentStatus_CrtInvoice_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public InvoicePaymentStatus_CrtInvoice_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "InvoicePaymentStatus_CrtInvoice_Terrasoft";
		}

		public InvoicePaymentStatus_CrtInvoice_Terrasoft(InvoicePaymentStatus_CrtInvoice_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Status is final.
		/// </summary>
		public bool FinalStatus {
			get {
				return GetTypedColumnValue<bool>("FinalStatus");
			}
			set {
				SetColumnValue("FinalStatus", value);
			}
		}

		/// <summary>
		/// Color.
		/// </summary>
		public Color Color {
			get {
				return GetTypedColumnValue<Color>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new InvoicePaymentStatus_CrtInvoiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("InvoicePaymentStatus_CrtInvoice_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("InvoicePaymentStatus_CrtInvoice_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("InvoicePaymentStatus_CrtInvoice_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("InvoicePaymentStatus_CrtInvoice_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("InvoicePaymentStatus_CrtInvoice_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("InvoicePaymentStatus_CrtInvoice_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("InvoicePaymentStatus_CrtInvoice_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new InvoicePaymentStatus_CrtInvoice_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: InvoicePaymentStatus_CrtInvoiceEventsProcess

	/// <exclude/>
	public partial class InvoicePaymentStatus_CrtInvoiceEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : InvoicePaymentStatus_CrtInvoice_Terrasoft
	{

		public InvoicePaymentStatus_CrtInvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InvoicePaymentStatus_CrtInvoiceEventsProcess";
			SchemaUId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861");
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

	#region Class: InvoicePaymentStatus_CrtInvoiceEventsProcess

	/// <exclude/>
	public class InvoicePaymentStatus_CrtInvoiceEventsProcess : InvoicePaymentStatus_CrtInvoiceEventsProcess<InvoicePaymentStatus_CrtInvoice_Terrasoft>
	{

		public InvoicePaymentStatus_CrtInvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: InvoicePaymentStatus_CrtInvoiceEventsProcess

	public partial class InvoicePaymentStatus_CrtInvoiceEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

