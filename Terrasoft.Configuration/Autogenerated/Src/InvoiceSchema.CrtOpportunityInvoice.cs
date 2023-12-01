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

	#region Class: Invoice_CrtOpportunityInvoice_TerrasoftSchema

	/// <exclude/>
	public class Invoice_CrtOpportunityInvoice_TerrasoftSchema : Terrasoft.Configuration.Invoice_Passport_TerrasoftSchema
	{

		#region Constructors: Public

		public Invoice_CrtOpportunityInvoice_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Invoice_CrtOpportunityInvoice_TerrasoftSchema(Invoice_CrtOpportunityInvoice_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Invoice_CrtOpportunityInvoice_TerrasoftSchema(Invoice_CrtOpportunityInvoice_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("c6db0f6f-90d6-4108-9123-69731551db81");
			Name = "Invoice_CrtOpportunityInvoice_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = true;
			CreatedInPackageId = new Guid("799efff9-f266-416d-bc26-c9f1f14c064c");
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
			if (Columns.FindByUId(new Guid("4566ed19-07f2-4836-9fda-eb24b2112208")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("c6db0f6f-90d6-4108-9123-69731551db81");
			column.CreatedInPackageId = new Guid("799efff9-f266-416d-bc26-c9f1f14c064c");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("c6db0f6f-90d6-4108-9123-69731551db81");
			column.CreatedInPackageId = new Guid("799efff9-f266-416d-bc26-c9f1f14c064c");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("c6db0f6f-90d6-4108-9123-69731551db81");
			column.CreatedInPackageId = new Guid("799efff9-f266-416d-bc26-c9f1f14c064c");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("c6db0f6f-90d6-4108-9123-69731551db81");
			column.CreatedInPackageId = new Guid("799efff9-f266-416d-bc26-c9f1f14c064c");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("c6db0f6f-90d6-4108-9123-69731551db81");
			column.CreatedInPackageId = new Guid("799efff9-f266-416d-bc26-c9f1f14c064c");
			return column;
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4566ed19-07f2-4836-9fda-eb24b2112208"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c6db0f6f-90d6-4108-9123-69731551db81"),
				ModifiedInSchemaUId = new Guid("c6db0f6f-90d6-4108-9123-69731551db81"),
				CreatedInPackageId = new Guid("799efff9-f266-416d-bc26-c9f1f14c064c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Invoice_CrtOpportunityInvoice_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Invoice_CrtOpportunityInvoiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Invoice_CrtOpportunityInvoice_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Invoice_CrtOpportunityInvoice_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c6db0f6f-90d6-4108-9123-69731551db81"));
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_CrtOpportunityInvoice_Terrasoft

	/// <summary>
	/// Invoice.
	/// </summary>
	public class Invoice_CrtOpportunityInvoice_Terrasoft : Terrasoft.Configuration.Invoice_Passport_Terrasoft
	{

		#region Constructors: Public

		public Invoice_CrtOpportunityInvoice_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Invoice_CrtOpportunityInvoice_Terrasoft";
		}

		public Invoice_CrtOpportunityInvoice_Terrasoft(Invoice_CrtOpportunityInvoice_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid OpportunityId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityId");
			}
			set {
				SetColumnValue("OpportunityId", value);
				_opportunity = null;
			}
		}

		/// <exclude/>
		public string OpportunityTitle {
			get {
				return GetTypedColumnValue<string>("OpportunityTitle");
			}
			set {
				SetColumnValue("OpportunityTitle", value);
				if (_opportunity != null) {
					_opportunity.Title = value;
				}
			}
		}

		private Opportunity _opportunity;
		/// <summary>
		/// Opportunity.
		/// </summary>
		public Opportunity Opportunity {
			get {
				return _opportunity ??
					(_opportunity = LookupColumnEntities.GetEntity("Opportunity") as Opportunity);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Invoice_CrtOpportunityInvoiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Invoice_CrtOpportunityInvoice_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("Invoice_CrtOpportunityInvoice_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("Invoice_CrtOpportunityInvoice_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Invoice_CrtOpportunityInvoice_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_CrtOpportunityInvoiceEventsProcess

	/// <exclude/>
	public partial class Invoice_CrtOpportunityInvoiceEventsProcess<TEntity> : Terrasoft.Configuration.Invoice_PassportEventsProcess<TEntity> where TEntity : Invoice_CrtOpportunityInvoice_Terrasoft
	{

		public Invoice_CrtOpportunityInvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Invoice_CrtOpportunityInvoiceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c6db0f6f-90d6-4108-9123-69731551db81");
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

	#region Class: Invoice_CrtOpportunityInvoiceEventsProcess

	/// <exclude/>
	public class Invoice_CrtOpportunityInvoiceEventsProcess : Invoice_CrtOpportunityInvoiceEventsProcess<Invoice_CrtOpportunityInvoice_Terrasoft>
	{

		public Invoice_CrtOpportunityInvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Invoice_CrtOpportunityInvoiceEventsProcess

	public partial class Invoice_CrtOpportunityInvoiceEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

