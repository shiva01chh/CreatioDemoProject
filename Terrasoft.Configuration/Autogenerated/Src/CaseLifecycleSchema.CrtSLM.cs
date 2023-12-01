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

	#region Class: CaseLifecycle_CrtSLM_TerrasoftSchema

	/// <exclude/>
	public class CaseLifecycle_CrtSLM_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CaseLifecycle_CrtSLM_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CaseLifecycle_CrtSLM_TerrasoftSchema(CaseLifecycle_CrtSLM_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CaseLifecycle_CrtSLM_TerrasoftSchema(CaseLifecycle_CrtSLM_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_CaseLifecycle_CreatedOnIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("66b2ba77-5d12-4752-ba4b-33e03efc2e22");
			index.Name = "IX_CaseLifecycle_CreatedOn";
			index.CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf");
			index.ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf");
			index.CreatedInPackageId = new Guid("257e6d26-f107-468c-8558-d77af0cbc8ac");
			EntitySchemaIndexColumn createdOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("df737bbc-8103-75e8-cdb5-892c25a4dc36"),
				ColumnUId = new Guid("e80190a5-03b2-4095-90f7-a193a960adee"),
				CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				CreatedInPackageId = new Guid("257e6d26-f107-468c-8558-d77af0cbc8ac"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(createdOnIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf");
			RealUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf");
			Name = "CaseLifecycle_CrtSLM_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("364dbe81-f3a7-457e-852c-656d87a9f035")) == null) {
				Columns.Add(CreateCaseColumn());
			}
			if (Columns.FindByUId(new Guid("8cc3e833-3a00-4d76-b1a4-b387766aefc9")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("4b0f983b-62bc-4312-b5c8-ef3f4777a648")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("7ab897fc-723d-4308-a5d5-7a14c468b68a")) == null) {
				Columns.Add(CreateEndDateColumn());
			}
			if (Columns.FindByUId(new Guid("9d844746-0912-4ddb-af41-8b9505156e58")) == null) {
				Columns.Add(CreateStateDurationInMinutesColumn());
			}
			if (Columns.FindByUId(new Guid("4d5400f3-8d80-4143-997f-1c516a4b53e3")) == null) {
				Columns.Add(CreateStateDurationInHoursColumn());
			}
			if (Columns.FindByUId(new Guid("73eab705-d1e4-41ab-8c47-8a67c2c2d17d")) == null) {
				Columns.Add(CreateStateDurationInDaysColumn());
			}
			if (Columns.FindByUId(new Guid("48111028-c4c6-4dba-9628-dcd94520bbc2")) == null) {
				Columns.Add(CreatePriorityColumn());
			}
			if (Columns.FindByUId(new Guid("d63beda7-1095-4e44-8752-2e2510cb834f")) == null) {
				Columns.Add(CreateServiceItemColumn());
			}
			if (Columns.FindByUId(new Guid("a69f0071-b870-40ec-a586-91a9525b17e1")) == null) {
				Columns.Add(CreateOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("8aad72d4-4c32-4a23-93e1-7644983e6227")) == null) {
				Columns.Add(CreateResponseOverdueColumn());
			}
			if (Columns.FindByUId(new Guid("d9fa88c9-2ebe-432c-80b1-c9fcef226169")) == null) {
				Columns.Add(CreateSolutionOverdueColumn());
			}
			if (Columns.FindByUId(new Guid("a3b3d3dd-20d0-410f-9c3b-a2cc8033a2fc")) == null) {
				Columns.Add(CreateGroupColumn());
			}
			if (Columns.FindByUId(new Guid("a0518029-d0d8-4979-9b77-d911461da6d6")) == null) {
				Columns.Add(CreateSolutionProvidedOnColumn());
			}
			if (Columns.FindByUId(new Guid("86da069d-cf8b-4226-8430-8e23d7469d08")) == null) {
				Columns.Add(CreateSolutionDateColumn());
			}
			if (Columns.FindByUId(new Guid("bb326767-708c-4218-803e-3c27a854b4a5")) == null) {
				Columns.Add(CreateCaseRecordIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCaseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("364dbe81-f3a7-457e-852c-656d87a9f035"),
				Name = @"Case",
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8cc3e833-3a00-4d76-b1a4-b387766aefc9"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("4b0f983b-62bc-4312-b5c8-ef3f4777a648"),
				Name = @"StartDate",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			};
		}

		protected virtual EntitySchemaColumn CreateEndDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("7ab897fc-723d-4308-a5d5-7a14c468b68a"),
				Name = @"EndDate",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			};
		}

		protected virtual EntitySchemaColumn CreateStateDurationInMinutesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("9d844746-0912-4ddb-af41-8b9505156e58"),
				Name = @"StateDurationInMinutes",
				CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			};
		}

		protected virtual EntitySchemaColumn CreateStateDurationInHoursColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float1")) {
				UId = new Guid("4d5400f3-8d80-4143-997f-1c516a4b53e3"),
				Name = @"StateDurationInHours",
				CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			};
		}

		protected virtual EntitySchemaColumn CreateStateDurationInDaysColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("73eab705-d1e4-41ab-8c47-8a67c2c2d17d"),
				Name = @"StateDurationInDays",
				CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			};
		}

		protected virtual EntitySchemaColumn CreatePriorityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("48111028-c4c6-4dba-9628-dcd94520bbc2"),
				Name = @"Priority",
				ReferenceSchemaUId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			};
		}

		protected virtual EntitySchemaColumn CreateServiceItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d63beda7-1095-4e44-8752-2e2510cb834f"),
				Name = @"ServiceItem",
				ReferenceSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a69f0071-b870-40ec-a586-91a9525b17e1"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			};
		}

		protected virtual EntitySchemaColumn CreateResponseOverdueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("8aad72d4-4c32-4a23-93e1-7644983e6227"),
				Name = @"ResponseOverdue",
				CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			};
		}

		protected virtual EntitySchemaColumn CreateSolutionOverdueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("d9fa88c9-2ebe-432c-80b1-c9fcef226169"),
				Name = @"SolutionOverdue",
				CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			};
		}

		protected virtual EntitySchemaColumn CreateGroupColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a3b3d3dd-20d0-410f-9c3b-a2cc8033a2fc"),
				Name = @"Group",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			};
		}

		protected virtual EntitySchemaColumn CreateSolutionProvidedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("a0518029-d0d8-4979-9b77-d911461da6d6"),
				Name = @"SolutionProvidedOn",
				CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf")
			};
		}

		protected virtual EntitySchemaColumn CreateSolutionDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("86da069d-cf8b-4226-8430-8e23d7469d08"),
				Name = @"SolutionDate",
				CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf")
			};
		}

		protected virtual EntitySchemaColumn CreateCaseRecordIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("bb326767-708c-4218-803e-3c27a854b4a5"),
				Name = @"CaseRecordId",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_CaseLifecycle_CreatedOnIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CaseLifecycle_CrtSLM_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CaseLifecycle_CrtSLMEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CaseLifecycle_CrtSLM_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CaseLifecycle_CrtSLM_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"));
		}

		#endregion

	}

	#endregion

	#region Class: CaseLifecycle_CrtSLM_Terrasoft

	/// <summary>
	/// Case Lifecycle.
	/// </summary>
	public class CaseLifecycle_CrtSLM_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CaseLifecycle_CrtSLM_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CaseLifecycle_CrtSLM_Terrasoft";
		}

		public CaseLifecycle_CrtSLM_Terrasoft(CaseLifecycle_CrtSLM_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CaseId {
			get {
				return GetTypedColumnValue<Guid>("CaseId");
			}
			set {
				SetColumnValue("CaseId", value);
				_case = null;
			}
		}

		/// <exclude/>
		public string CaseNumber {
			get {
				return GetTypedColumnValue<string>("CaseNumber");
			}
			set {
				SetColumnValue("CaseNumber", value);
				if (_case != null) {
					_case.Number = value;
				}
			}
		}

		private Case _case;
		/// <summary>
		/// Case.
		/// </summary>
		public Case Case {
			get {
				return _case ??
					(_case = LookupColumnEntities.GetEntity("Case") as Case);
			}
		}

		/// <exclude/>
		public Guid StatusId {
			get {
				return GetTypedColumnValue<Guid>("StatusId");
			}
			set {
				SetColumnValue("StatusId", value);
				_status = null;
			}
		}

		/// <exclude/>
		public string StatusName {
			get {
				return GetTypedColumnValue<string>("StatusName");
			}
			set {
				SetColumnValue("StatusName", value);
				if (_status != null) {
					_status.Name = value;
				}
			}
		}

		private CaseStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public CaseStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as CaseStatus);
			}
		}

		/// <summary>
		/// Date begin.
		/// </summary>
		public DateTime StartDate {
			get {
				return GetTypedColumnValue<DateTime>("StartDate");
			}
			set {
				SetColumnValue("StartDate", value);
			}
		}

		/// <summary>
		/// Date end.
		/// </summary>
		public DateTime EndDate {
			get {
				return GetTypedColumnValue<DateTime>("EndDate");
			}
			set {
				SetColumnValue("EndDate", value);
			}
		}

		/// <summary>
		/// Duration (minutes).
		/// </summary>
		public int StateDurationInMinutes {
			get {
				return GetTypedColumnValue<int>("StateDurationInMinutes");
			}
			set {
				SetColumnValue("StateDurationInMinutes", value);
			}
		}

		/// <summary>
		/// Duration (hours).
		/// </summary>
		public Decimal StateDurationInHours {
			get {
				return GetTypedColumnValue<Decimal>("StateDurationInHours");
			}
			set {
				SetColumnValue("StateDurationInHours", value);
			}
		}

		/// <summary>
		/// Duration (days).
		/// </summary>
		public Decimal StateDurationInDays {
			get {
				return GetTypedColumnValue<Decimal>("StateDurationInDays");
			}
			set {
				SetColumnValue("StateDurationInDays", value);
			}
		}

		/// <exclude/>
		public Guid PriorityId {
			get {
				return GetTypedColumnValue<Guid>("PriorityId");
			}
			set {
				SetColumnValue("PriorityId", value);
				_priority = null;
			}
		}

		/// <exclude/>
		public string PriorityName {
			get {
				return GetTypedColumnValue<string>("PriorityName");
			}
			set {
				SetColumnValue("PriorityName", value);
				if (_priority != null) {
					_priority.Name = value;
				}
			}
		}

		private CasePriority _priority;
		/// <summary>
		/// Priority.
		/// </summary>
		public CasePriority Priority {
			get {
				return _priority ??
					(_priority = LookupColumnEntities.GetEntity("Priority") as CasePriority);
			}
		}

		/// <exclude/>
		public Guid ServiceItemId {
			get {
				return GetTypedColumnValue<Guid>("ServiceItemId");
			}
			set {
				SetColumnValue("ServiceItemId", value);
				_serviceItem = null;
			}
		}

		/// <exclude/>
		public string ServiceItemName {
			get {
				return GetTypedColumnValue<string>("ServiceItemName");
			}
			set {
				SetColumnValue("ServiceItemName", value);
				if (_serviceItem != null) {
					_serviceItem.Name = value;
				}
			}
		}

		private ServiceItem _serviceItem;
		/// <summary>
		/// Service item.
		/// </summary>
		public ServiceItem ServiceItem {
			get {
				return _serviceItem ??
					(_serviceItem = LookupColumnEntities.GetEntity("ServiceItem") as ServiceItem);
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
		/// Assignee.
		/// </summary>
		public Contact Owner {
			get {
				return _owner ??
					(_owner = LookupColumnEntities.GetEntity("Owner") as Contact);
			}
		}

		/// <summary>
		/// Overdue response.
		/// </summary>
		public bool ResponseOverdue {
			get {
				return GetTypedColumnValue<bool>("ResponseOverdue");
			}
			set {
				SetColumnValue("ResponseOverdue", value);
			}
		}

		/// <summary>
		/// Overdue resolution.
		/// </summary>
		public bool SolutionOverdue {
			get {
				return GetTypedColumnValue<bool>("SolutionOverdue");
			}
			set {
				SetColumnValue("SolutionOverdue", value);
			}
		}

		/// <exclude/>
		public Guid GroupId {
			get {
				return GetTypedColumnValue<Guid>("GroupId");
			}
			set {
				SetColumnValue("GroupId", value);
				_group = null;
			}
		}

		/// <exclude/>
		public string GroupName {
			get {
				return GetTypedColumnValue<string>("GroupName");
			}
			set {
				SetColumnValue("GroupName", value);
				if (_group != null) {
					_group.Name = value;
				}
			}
		}

		private SysAdminUnit _group;
		/// <summary>
		/// Assignees group.
		/// </summary>
		public SysAdminUnit Group {
			get {
				return _group ??
					(_group = LookupColumnEntities.GetEntity("Group") as SysAdminUnit);
			}
		}

		/// <summary>
		/// Actual resolution time.
		/// </summary>
		public DateTime SolutionProvidedOn {
			get {
				return GetTypedColumnValue<DateTime>("SolutionProvidedOn");
			}
			set {
				SetColumnValue("SolutionProvidedOn", value);
			}
		}

		/// <summary>
		/// Resolution time.
		/// </summary>
		public DateTime SolutionDate {
			get {
				return GetTypedColumnValue<DateTime>("SolutionDate");
			}
			set {
				SetColumnValue("SolutionDate", value);
			}
		}

		/// <summary>
		/// Case record identifier.
		/// </summary>
		public Guid CaseRecordId {
			get {
				return GetTypedColumnValue<Guid>("CaseRecordId");
			}
			set {
				SetColumnValue("CaseRecordId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CaseLifecycle_CrtSLMEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CaseLifecycle_CrtSLM_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("CaseLifecycle_CrtSLM_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("CaseLifecycle_CrtSLM_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("CaseLifecycle_CrtSLM_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("CaseLifecycle_CrtSLM_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("CaseLifecycle_CrtSLM_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("CaseLifecycle_CrtSLM_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CaseLifecycle_CrtSLM_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: CaseLifecycle_CrtSLMEventsProcess

	/// <exclude/>
	public partial class CaseLifecycle_CrtSLMEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : CaseLifecycle_CrtSLM_Terrasoft
	{

		public CaseLifecycle_CrtSLMEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CaseLifecycle_CrtSLMEventsProcess";
			SchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf");
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

	#region Class: CaseLifecycle_CrtSLMEventsProcess

	/// <exclude/>
	public class CaseLifecycle_CrtSLMEventsProcess : CaseLifecycle_CrtSLMEventsProcess<CaseLifecycle_CrtSLM_Terrasoft>
	{

		public CaseLifecycle_CrtSLMEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CaseLifecycle_CrtSLMEventsProcess

	public partial class CaseLifecycle_CrtSLMEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

