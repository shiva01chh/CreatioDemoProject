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

	#region Class: Document_CrtDocument_TerrasoftSchema

	/// <exclude/>
	public class Document_CrtDocument_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public Document_CrtDocument_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Document_CrtDocument_TerrasoftSchema(Document_CrtDocument_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Document_CrtDocument_TerrasoftSchema(Document_CrtDocument_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			RealUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			Name = "Document_CrtDocument_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
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
			if (Columns.FindByUId(new Guid("964aedc1-7673-4d96-8b3f-8bc8f2829fff")) == null) {
				Columns.Add(CreateDateColumn());
			}
			if (Columns.FindByUId(new Guid("923d55f5-b690-46ae-9337-0400d63814d1")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("6f97a26f-a592-40f0-a233-d4363a35f471")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("cf24fdae-dd9e-43d8-a5d6-47b6fd9e4daa")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("3a5ca495-43bc-4b03-af8a-c297f9166fd0")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("e2596e4a-8da7-47f5-9898-e6cce28fc2f8")) == null) {
				Columns.Add(CreatePaymentAmountColumn());
			}
			if (Columns.FindByUId(new Guid("570b8a4d-9d3e-49b6-8e71-a77e27b2dad3")) == null) {
				Columns.Add(CreatePrimaryPaymentAmountColumn());
			}
			if (Columns.FindByUId(new Guid("03791254-7218-4176-8e38-7c053da06e40")) == null) {
				Columns.Add(CreatePaymentDateColumn());
			}
			if (Columns.FindByUId(new Guid("b02642bd-8ec6-45af-9998-ea803ca5c9c3")) == null) {
				Columns.Add(CreateStateColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.IsTrackChangesInDB = true;
			column.ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.IsTrackChangesInDB = true;
			column.ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.IsTrackChangesInDB = true;
			column.ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("927e4338-f861-42c1-8b0b-7bbb78ffff4b"),
				Name = @"Number",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("964aedc1-7673-4d96-8b3f-8bc8f2829fff"),
				Name = @"Date",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDate")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("923d55f5-b690-46ae-9337-0400d63814d1"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("fe5e6306-c1ae-454f-87fb-108461dd71f5"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsSimpleLookup = true,
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6f97a26f-a592-40f0-a233-d4363a35f471"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cf24fdae-dd9e-43d8-a5d6-47b6fd9e4daa"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8f214196-e457-4163-90b3-3b397961215c"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("3a5ca495-43bc-4b03-af8a-c297f9166fd0"),
				Name = @"Notes",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePaymentAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("e2596e4a-8da7-47f5-9898-e6cce28fc2f8"),
				Name = @"PaymentAmount",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("648f05a8-9401-440d-98ee-c77984ac3b4b")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryPaymentAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("570b8a4d-9d3e-49b6-8e71-a77e27b2dad3"),
				Name = @"PrimaryPaymentAmount",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("648f05a8-9401-440d-98ee-c77984ac3b4b")
			};
		}

		protected virtual EntitySchemaColumn CreatePaymentDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("03791254-7218-4176-8e38-7c053da06e40"),
				Name = @"PaymentDate",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("648f05a8-9401-440d-98ee-c77984ac3b4b")
			};
		}

		protected virtual EntitySchemaColumn CreateStateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b02642bd-8ec6-45af-9998-ea803ca5c9c3"),
				Name = @"State",
				ReferenceSchemaUId = new Guid("3fa49baa-57d4-40d7-9293-1e6742b1b0dd"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				ModifiedInSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				CreatedInPackageId = new Guid("93f2b0e4-b421-42dc-86e5-35e5b932239c"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"2144d9a6-b446-4afd-a52d-41f1b1910546"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Document_CrtDocument_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Document_CrtDocumentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Document_CrtDocument_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Document_CrtDocument_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"));
		}

		#endregion

	}

	#endregion

	#region Class: Document_CrtDocument_Terrasoft

	/// <summary>
	/// Document.
	/// </summary>
	public class Document_CrtDocument_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Document_CrtDocument_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Document_CrtDocument_Terrasoft";
		}

		public Document_CrtDocument_Terrasoft(Document_CrtDocument_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Number.
		/// </summary>
		public string Number {
			get {
				return GetTypedColumnValue<string>("Number");
			}
			set {
				SetColumnValue("Number", value);
			}
		}

		/// <summary>
		/// Date.
		/// </summary>
		public DateTime Date {
			get {
				return GetTypedColumnValue<DateTime>("Date");
			}
			set {
				SetColumnValue("Date", value);
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private DocumentType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public DocumentType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as DocumentType);
			}
		}

		/// <exclude/>
		public Guid AccountId {
			get {
				return GetTypedColumnValue<Guid>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
				_account = null;
			}
		}

		/// <exclude/>
		public string AccountName {
			get {
				return GetTypedColumnValue<string>("AccountName");
			}
			set {
				SetColumnValue("AccountName", value);
				if (_account != null) {
					_account.Name = value;
				}
			}
		}

		private Account _account;
		/// <summary>
		/// Account.
		/// </summary>
		public Account Account {
			get {
				return _account ??
					(_account = LookupColumnEntities.GetEntity("Account") as Account);
			}
		}

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <exclude/>
		public Guid OwnerId {
			get {
				return GetTypedColumnValue<Guid>("OwnerId");
			}
			set {
				SetColumnValue("OwnerId", value);
				_owner = null;
			}
		}

		/// <exclude/>
		public string OwnerName {
			get {
				return GetTypedColumnValue<string>("OwnerName");
			}
			set {
				SetColumnValue("OwnerName", value);
				if (_owner != null) {
					_owner.Name = value;
				}
			}
		}

		private Contact _owner;
		/// <summary>
		/// Owner.
		/// </summary>
		public Contact Owner {
			get {
				return _owner ??
					(_owner = LookupColumnEntities.GetEntity("Owner") as Contact);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
			}
		}

		/// <summary>
		/// Payment amount.
		/// </summary>
		public Decimal PaymentAmount {
			get {
				return GetTypedColumnValue<Decimal>("PaymentAmount");
			}
			set {
				SetColumnValue("PaymentAmount", value);
			}
		}

		/// <summary>
		/// Payment amount, base currency.
		/// </summary>
		public Decimal PrimaryPaymentAmount {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryPaymentAmount");
			}
			set {
				SetColumnValue("PrimaryPaymentAmount", value);
			}
		}

		/// <summary>
		/// Paid on.
		/// </summary>
		public DateTime PaymentDate {
			get {
				return GetTypedColumnValue<DateTime>("PaymentDate");
			}
			set {
				SetColumnValue("PaymentDate", value);
			}
		}

		/// <exclude/>
		public Guid StateId {
			get {
				return GetTypedColumnValue<Guid>("StateId");
			}
			set {
				SetColumnValue("StateId", value);
				_state = null;
			}
		}

		/// <exclude/>
		public string StateName {
			get {
				return GetTypedColumnValue<string>("StateName");
			}
			set {
				SetColumnValue("StateName", value);
				if (_state != null) {
					_state.Name = value;
				}
			}
		}

		private DocumentState _state;
		/// <summary>
		/// Status.
		/// </summary>
		public DocumentState State {
			get {
				return _state ??
					(_state = LookupColumnEntities.GetEntity("State") as DocumentState);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Document_CrtDocumentEventsProcess(UserConnection);
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
			return new Document_CrtDocument_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Document_CrtDocumentEventsProcess

	/// <exclude/>
	public partial class Document_CrtDocumentEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : Document_CrtDocument_Terrasoft
	{

		public Document_CrtDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Document_CrtDocumentEventsProcess";
			SchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool IsNew {
			get;
			set;
		}

		public virtual bool NeedFinRecalc {
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

	#region Class: Document_CrtDocumentEventsProcess

	/// <exclude/>
	public class Document_CrtDocumentEventsProcess : Document_CrtDocumentEventsProcess<Document_CrtDocument_Terrasoft>
	{

		public Document_CrtDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

