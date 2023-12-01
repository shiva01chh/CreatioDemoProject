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
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Nui.ServiceModel.WebService;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Campaign_CrtCampaign_TerrasoftSchema

	/// <exclude/>
	public class Campaign_CrtCampaign_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public Campaign_CrtCampaign_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Campaign_CrtCampaign_TerrasoftSchema(Campaign_CrtCampaign_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Campaign_CrtCampaign_TerrasoftSchema(Campaign_CrtCampaign_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8");
			RealUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8");
			Name = "Campaign_CrtCampaign_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("da323fb1-f216-4cb7-8a4c-e785dda94b8a")) == null) {
				Columns.Add(CreateCampaignStatusColumn());
			}
			if (Columns.FindByUId(new Guid("fc244e14-7755-4afb-85bf-b52dee45082f")) == null) {
				Columns.Add(CreateTargetDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("200745d2-e08f-4375-9510-a56f6ec2ef68")) == null) {
				Columns.Add(CreateTargetTotalColumn());
			}
			if (Columns.FindByUId(new Guid("ddaedc58-c72e-4027-b6a4-49e8e1779d18")) == null) {
				Columns.Add(CreateTargetAchieveColumn());
			}
			if (Columns.FindByUId(new Guid("42be20e4-c94e-49c8-b5aa-8ebd934e402d")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("ca4b78ea-def8-47f4-ab1a-5a886f374021")) == null) {
				Columns.Add(CreateEndDateColumn());
			}
			if (Columns.FindByUId(new Guid("d02e2ad3-6260-4fda-bdf7-6f36c8d72ee1")) == null) {
				Columns.Add(CreateOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("e8bce7c6-2069-431b-9468-44d3bb0853c6")) == null) {
				Columns.Add(CreateUtmCampaignColumn());
			}
			if (Columns.FindByUId(new Guid("d5626c7f-75cd-4e01-8b4c-b87f18c0116c")) == null) {
				Columns.Add(CreateNextFireTimeColumn());
			}
			if (Columns.FindByUId(new Guid("1e3155d5-4d30-4251-9702-c2e1f26604be")) == null) {
				Columns.Add(CreateFirePeriodColumn());
			}
			if (Columns.FindByUId(new Guid("9d8bfd00-c71e-4b1d-9c46-bf271d18ef8f")) == null) {
				Columns.Add(CreateCampaignSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("056c8a67-d92e-419f-aa9c-66a9c951ecaa")) == null) {
				Columns.Add(CreateScheduledStartModeColumn());
			}
			if (Columns.FindByUId(new Guid("e36a7fc0-326d-4dd8-ace7-78adc5fcd3bd")) == null) {
				Columns.Add(CreateScheduledStopModeColumn());
			}
			if (Columns.FindByUId(new Guid("5b85977f-dfdb-4d0b-b273-b36934d188e0")) == null) {
				Columns.Add(CreateScheduledStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("aa365456-c611-43df-9d05-12b828091983")) == null) {
				Columns.Add(CreateScheduledStopDateColumn());
			}
			if (Columns.FindByUId(new Guid("80b80b2f-8cae-4b3b-b449-a647a503f3a6")) == null) {
				Columns.Add(CreatePrevExecutedOnColumn());
			}
			if (Columns.FindByUId(new Guid("6bb1e198-a9f2-44a7-a1eb-1ca3d38fc56c")) == null) {
				Columns.Add(CreateInProgressColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("64744600-327d-4490-9dd8-2ed70e4ecb16"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1")
			};
		}

		protected virtual EntitySchemaColumn CreateCampaignStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("da323fb1-f216-4cb7-8a4c-e785dda94b8a"),
				Name = @"CampaignStatus",
				ReferenceSchemaUId = new Guid("24e4fd5c-7bd2-436e-90b3-01d658f659e5"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"24b80784-2172-4903-94ad-ca1fddf368dd"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateTargetDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("fc244e14-7755-4afb-85bf-b52dee45082f"),
				Name = @"TargetDescription",
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("4599b6ca-e1c5-4079-81de-c3db847907d5")
			};
		}

		protected virtual EntitySchemaColumn CreateTargetTotalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("200745d2-e08f-4375-9510-a56f6ec2ef68"),
				Name = @"TargetTotal",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("4599b6ca-e1c5-4079-81de-c3db847907d5")
			};
		}

		protected virtual EntitySchemaColumn CreateTargetAchieveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("ddaedc58-c72e-4027-b6a4-49e8e1779d18"),
				Name = @"TargetAchieve",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("4599b6ca-e1c5-4079-81de-c3db847907d5")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("42be20e4-c94e-49c8-b5aa-8ebd934e402d"),
				Name = @"StartDate",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("42d0960f-8407-46cb-ba61-91a196c15c22")
			};
		}

		protected virtual EntitySchemaColumn CreateEndDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("ca4b78ea-def8-47f4-ab1a-5a886f374021"),
				Name = @"EndDate",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("42d0960f-8407-46cb-ba61-91a196c15c22")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d02e2ad3-6260-4fda-bdf7-6f36c8d72ee1"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("0de0e6ea-5e2d-4477-ae5d-f5fee951a20a"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateUtmCampaignColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("e8bce7c6-2069-431b-9468-44d3bb0853c6"),
				Name = @"UtmCampaign",
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("f0968537-4bb9-4c0d-9a09-6db8469be2f9")
			};
		}

		protected virtual EntitySchemaColumn CreateNextFireTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("d5626c7f-75cd-4e01-8b4c-b87f18c0116c"),
				Name = @"NextFireTime",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("d85e35ee-2806-46ef-b091-5e59d47f9067")
			};
		}

		protected virtual EntitySchemaColumn CreateFirePeriodColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("1e3155d5-4d30-4251-9702-c2e1f26604be"),
				Name = @"FirePeriod",
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("d85e35ee-2806-46ef-b091-5e59d47f9067")
			};
		}

		protected virtual EntitySchemaColumn CreateCampaignSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("9d8bfd00-c71e-4b1d-9c46-bf271d18ef8f"),
				Name = @"CampaignSchemaUId",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190")
			};
		}

		protected virtual EntitySchemaColumn CreateScheduledStartModeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("056c8a67-d92e-419f-aa9c-66a9c951ecaa"),
				Name = @"ScheduledStartMode",
				ReferenceSchemaUId = new Guid("5335288b-38c7-456e-902b-e5768c03b448"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"229d71cf-80c8-4158-ae9d-b0da644ed6a8"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateScheduledStopModeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e36a7fc0-326d-4dd8-ace7-78adc5fcd3bd"),
				Name = @"ScheduledStopMode",
				ReferenceSchemaUId = new Guid("5335288b-38c7-456e-902b-e5768c03b448"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"229d71cf-80c8-4158-ae9d-b0da644ed6a8"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateScheduledStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("5b85977f-dfdb-4d0b-b273-b36934d188e0"),
				Name = @"ScheduledStartDate",
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected virtual EntitySchemaColumn CreateScheduledStopDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("aa365456-c611-43df-9d05-12b828091983"),
				Name = @"ScheduledStopDate",
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected virtual EntitySchemaColumn CreatePrevExecutedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("80b80b2f-8cae-4b3b-b449-a647a503f3a6"),
				Name = @"PrevExecutedOn",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected virtual EntitySchemaColumn CreateInProgressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("6bb1e198-a9f2-44a7-a1eb-1ca3d38fc56c"),
				Name = @"InProgress",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("39cd20db-d7e1-477a-9ed0-ff03ab957af4")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Campaign_CrtCampaign_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Campaign_CrtCampaignEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Campaign_CrtCampaign_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Campaign_CrtCampaign_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"));
		}

		#endregion

	}

	#endregion

	#region Class: Campaign_CrtCampaign_Terrasoft

	/// <summary>
	/// Campaign.
	/// </summary>
	public class Campaign_CrtCampaign_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Campaign_CrtCampaign_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Campaign_CrtCampaign_Terrasoft";
		}

		public Campaign_CrtCampaign_Terrasoft(Campaign_CrtCampaign_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <exclude/>
		public Guid CampaignStatusId {
			get {
				return GetTypedColumnValue<Guid>("CampaignStatusId");
			}
			set {
				SetColumnValue("CampaignStatusId", value);
				_campaignStatus = null;
			}
		}

		/// <exclude/>
		public string CampaignStatusName {
			get {
				return GetTypedColumnValue<string>("CampaignStatusName");
			}
			set {
				SetColumnValue("CampaignStatusName", value);
				if (_campaignStatus != null) {
					_campaignStatus.Name = value;
				}
			}
		}

		private CampaignStatus _campaignStatus;
		/// <summary>
		/// Status.
		/// </summary>
		public CampaignStatus CampaignStatus {
			get {
				return _campaignStatus ??
					(_campaignStatus = LookupColumnEntities.GetEntity("CampaignStatus") as CampaignStatus);
			}
		}

		/// <summary>
		/// Goal description.
		/// </summary>
		public string TargetDescription {
			get {
				return GetTypedColumnValue<string>("TargetDescription");
			}
			set {
				SetColumnValue("TargetDescription", value);
			}
		}

		/// <summary>
		/// Participants.
		/// </summary>
		public int TargetTotal {
			get {
				return GetTypedColumnValue<int>("TargetTotal");
			}
			set {
				SetColumnValue("TargetTotal", value);
			}
		}

		/// <summary>
		/// Reached the goal.
		/// </summary>
		public int TargetAchieve {
			get {
				return GetTypedColumnValue<int>("TargetAchieve");
			}
			set {
				SetColumnValue("TargetAchieve", value);
			}
		}

		/// <summary>
		/// Start date.
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
		/// End date.
		/// </summary>
		public DateTime EndDate {
			get {
				return GetTypedColumnValue<DateTime>("EndDate");
			}
			set {
				SetColumnValue("EndDate", value);
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
		/// utm_campaign.
		/// </summary>
		public string UtmCampaign {
			get {
				return GetTypedColumnValue<string>("UtmCampaign");
			}
			set {
				SetColumnValue("UtmCampaign", value);
			}
		}

		/// <summary>
		/// Next run.
		/// </summary>
		public DateTime NextFireTime {
			get {
				return GetTypedColumnValue<DateTime>("NextFireTime");
			}
			set {
				SetColumnValue("NextFireTime", value);
			}
		}

		/// <summary>
		/// Fire Period (min).
		/// </summary>
		public int FirePeriod {
			get {
				return GetTypedColumnValue<int>("FirePeriod");
			}
			set {
				SetColumnValue("FirePeriod", value);
			}
		}

		/// <summary>
		/// CampaignSchemaUId.
		/// </summary>
		public Guid CampaignSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("CampaignSchemaUId");
			}
			set {
				SetColumnValue("CampaignSchemaUId", value);
			}
		}

		/// <exclude/>
		public Guid ScheduledStartModeId {
			get {
				return GetTypedColumnValue<Guid>("ScheduledStartModeId");
			}
			set {
				SetColumnValue("ScheduledStartModeId", value);
				_scheduledStartMode = null;
			}
		}

		/// <exclude/>
		public string ScheduledStartModeName {
			get {
				return GetTypedColumnValue<string>("ScheduledStartModeName");
			}
			set {
				SetColumnValue("ScheduledStartModeName", value);
				if (_scheduledStartMode != null) {
					_scheduledStartMode.Name = value;
				}
			}
		}

		private CampaignScheduledMode _scheduledStartMode;
		/// <summary>
		/// Start mode.
		/// </summary>
		public CampaignScheduledMode ScheduledStartMode {
			get {
				return _scheduledStartMode ??
					(_scheduledStartMode = LookupColumnEntities.GetEntity("ScheduledStartMode") as CampaignScheduledMode);
			}
		}

		/// <exclude/>
		public Guid ScheduledStopModeId {
			get {
				return GetTypedColumnValue<Guid>("ScheduledStopModeId");
			}
			set {
				SetColumnValue("ScheduledStopModeId", value);
				_scheduledStopMode = null;
			}
		}

		/// <exclude/>
		public string ScheduledStopModeName {
			get {
				return GetTypedColumnValue<string>("ScheduledStopModeName");
			}
			set {
				SetColumnValue("ScheduledStopModeName", value);
				if (_scheduledStopMode != null) {
					_scheduledStopMode.Name = value;
				}
			}
		}

		private CampaignScheduledMode _scheduledStopMode;
		/// <summary>
		/// End mode.
		/// </summary>
		public CampaignScheduledMode ScheduledStopMode {
			get {
				return _scheduledStopMode ??
					(_scheduledStopMode = LookupColumnEntities.GetEntity("ScheduledStopMode") as CampaignScheduledMode);
			}
		}

		/// <summary>
		/// Scheduled start date.
		/// </summary>
		public DateTime ScheduledStartDate {
			get {
				return GetTypedColumnValue<DateTime>("ScheduledStartDate");
			}
			set {
				SetColumnValue("ScheduledStartDate", value);
			}
		}

		/// <summary>
		/// Scheduled end date.
		/// </summary>
		public DateTime ScheduledStopDate {
			get {
				return GetTypedColumnValue<DateTime>("ScheduledStopDate");
			}
			set {
				SetColumnValue("ScheduledStopDate", value);
			}
		}

		/// <summary>
		/// Last run.
		/// </summary>
		public DateTime PrevExecutedOn {
			get {
				return GetTypedColumnValue<DateTime>("PrevExecutedOn");
			}
			set {
				SetColumnValue("PrevExecutedOn", value);
			}
		}

		/// <summary>
		/// In progress.
		/// </summary>
		public bool InProgress {
			get {
				return GetTypedColumnValue<bool>("InProgress");
			}
			set {
				SetColumnValue("InProgress", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Campaign_CrtCampaignEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Campaign_CrtCampaign_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Campaign_CrtCampaign_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Campaign_CrtCampaign_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Campaign_CrtCampaign_TerrasoftInserting", e);
			Saving += (s, e) => ThrowEvent("Campaign_CrtCampaign_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Campaign_CrtCampaign_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Campaign_CrtCampaign_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Campaign_CrtCampaignEventsProcess

	/// <exclude/>
	public partial class Campaign_CrtCampaignEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : Campaign_CrtCampaign_Terrasoft
	{

		public Campaign_CrtCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Campaign_CrtCampaignEventsProcess";
			SchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Object ChangedValues {
			get;
			set;
		}

		private ProcessFlowElement _beforeAddSubProcess;
		public ProcessFlowElement BeforeAddSubProcess {
			get {
				return _beforeAddSubProcess ?? (_beforeAddSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BeforeAddSubProcess",
					SchemaElementUId = new Guid("1839d90c-fdf8-4763-a021-de4d40d3443f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addCampaignMessage;
		public ProcessFlowElement AddCampaignMessage {
			get {
				return _addCampaignMessage ?? (_addCampaignMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddCampaignMessage",
					SchemaElementUId = new Guid("71fbf84f-7523-4d12-ae3c-a8fb62712df9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _insertingTask;
		public ProcessScriptTask InsertingTask {
			get {
				return _insertingTask ?? (_insertingTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InsertingTask",
					SchemaElementUId = new Guid("b534212c-fe1b-4502-80d4-821437900ab6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InsertingTaskExecute,
				});
			}
		}

		private ProcessFlowElement _afterDeletedCampaignSubProcess;
		public ProcessFlowElement AfterDeletedCampaignSubProcess {
			get {
				return _afterDeletedCampaignSubProcess ?? (_afterDeletedCampaignSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AfterDeletedCampaignSubProcess",
					SchemaElementUId = new Guid("c9bea1c7-ebb4-41f4-bc87-8b54f7bbbcb9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deletedMessage;
		public ProcessFlowElement DeletedMessage {
			get {
				return _deletedMessage ?? (_deletedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeletedMessage",
					SchemaElementUId = new Guid("80ae56f4-8c9e-45a4-98fe-2ad251accaa0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deletedScriptTask;
		public ProcessScriptTask DeletedScriptTask {
			get {
				return _deletedScriptTask ?? (_deletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeletedScriptTask",
					SchemaElementUId = new Guid("16c11682-2a43-4c2c-8efe-1d80cd2f6041"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeletedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _beforeDeletedCampaignSubProcess;
		public ProcessFlowElement BeforeDeletedCampaignSubProcess {
			get {
				return _beforeDeletedCampaignSubProcess ?? (_beforeDeletedCampaignSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BeforeDeletedCampaignSubProcess",
					SchemaElementUId = new Guid("f1cf7144-651d-4eb5-9cb3-f77d6686006d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deletingScriptTask;
		public ProcessScriptTask DeletingScriptTask {
			get {
				return _deletingScriptTask ?? (_deletingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeletingScriptTask",
					SchemaElementUId = new Guid("4f5a130b-6f93-43d7-b853-7a02a4a6f754"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeletingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _deletingMessage;
		public ProcessFlowElement DeletingMessage {
			get {
				return _deletingMessage ?? (_deletingMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeletingMessage",
					SchemaElementUId = new Guid("9c973651-bfaf-413a-b592-0d055892aec5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _afterAddSubProcess;
		public ProcessFlowElement AfterAddSubProcess {
			get {
				return _afterAddSubProcess ?? (_afterAddSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AfterAddSubProcess",
					SchemaElementUId = new Guid("8a8d2cc0-9cfe-40ea-b3b6-ad5881a724dc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _insertedCampaignMessage;
		public ProcessFlowElement InsertedCampaignMessage {
			get {
				return _insertedCampaignMessage ?? (_insertedCampaignMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InsertedCampaignMessage",
					SchemaElementUId = new Guid("95a614a2-3afd-4db2-b114-a2257ce2cf93"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _insertedTask;
		public ProcessScriptTask InsertedTask {
			get {
				return _insertedTask ?? (_insertedTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InsertedTask",
					SchemaElementUId = new Guid("4ccc1b15-e1d5-4695-ad32-cb850c503495"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InsertedTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[BeforeAddSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeAddSubProcess };
			FlowElements[AddCampaignMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddCampaignMessage };
			FlowElements[InsertingTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InsertingTask };
			FlowElements[AfterDeletedCampaignSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AfterDeletedCampaignSubProcess };
			FlowElements[DeletedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeletedMessage };
			FlowElements[DeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeletedScriptTask };
			FlowElements[BeforeDeletedCampaignSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeDeletedCampaignSubProcess };
			FlowElements[DeletingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeletingScriptTask };
			FlowElements[DeletingMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeletingMessage };
			FlowElements[AfterAddSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AfterAddSubProcess };
			FlowElements[InsertedCampaignMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InsertedCampaignMessage };
			FlowElements[InsertedTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InsertedTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "BeforeAddSubProcess":
						break;
					case "AddCampaignMessage":
						e.Context.QueueTasks.Enqueue("InsertingTask");
						break;
					case "InsertingTask":
						break;
					case "AfterDeletedCampaignSubProcess":
						break;
					case "DeletedMessage":
						e.Context.QueueTasks.Enqueue("DeletedScriptTask");
						break;
					case "DeletedScriptTask":
						break;
					case "BeforeDeletedCampaignSubProcess":
						break;
					case "DeletingScriptTask":
						break;
					case "DeletingMessage":
						e.Context.QueueTasks.Enqueue("DeletingScriptTask");
						break;
					case "AfterAddSubProcess":
						break;
					case "InsertedCampaignMessage":
						e.Context.QueueTasks.Enqueue("InsertedTask");
						break;
					case "InsertedTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("AddCampaignMessage");
			ActivatedEventElements.Add("DeletedMessage");
			ActivatedEventElements.Add("DeletingMessage");
			ActivatedEventElements.Add("InsertedCampaignMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "BeforeAddSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "AddCampaignMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddCampaignMessage";
					result = AddCampaignMessage.Execute(context);
					break;
				case "InsertingTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InsertingTask";
					result = InsertingTask.Execute(context, InsertingTaskExecute);
					break;
				case "AfterDeletedCampaignSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "DeletedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeletedMessage";
					result = DeletedMessage.Execute(context);
					break;
				case "DeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeletedScriptTask";
					result = DeletedScriptTask.Execute(context, DeletedScriptTaskExecute);
					break;
				case "BeforeDeletedCampaignSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "DeletingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeletingScriptTask";
					result = DeletingScriptTask.Execute(context, DeletingScriptTaskExecute);
					break;
				case "DeletingMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeletingMessage";
					result = DeletingMessage.Execute(context);
					break;
				case "AfterAddSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "InsertedCampaignMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InsertedCampaignMessage";
					result = InsertedCampaignMessage.Execute(context);
					break;
				case "InsertedTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InsertedTask";
					result = InsertedTask.Execute(context, InsertedTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool InsertingTaskExecute(ProcessExecutingContext context) {
			OnCampaignInserting();
			return true;
		}

		public virtual bool DeletedScriptTaskExecute(ProcessExecutingContext context) {
			DeleteCampaignSchema();
			return true;
		}

		public virtual bool DeletingScriptTaskExecute(ProcessExecutingContext context) {
			UnlinkCampaignSchemaElements();
			return true;
		}

		public virtual bool InsertedTaskExecute(ProcessExecutingContext context) {
			OnCampaignInserted();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Campaign_CrtCampaign_TerrasoftInserting":
							if (ActivatedEventElements.Contains("AddCampaignMessage")) {
							context.QueueTasks.Enqueue("AddCampaignMessage");
						}
						break;
					case "Campaign_CrtCampaign_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("DeletedMessage")) {
							context.QueueTasks.Enqueue("DeletedMessage");
						}
						break;
					case "Campaign_CrtCampaign_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("DeletingMessage")) {
							context.QueueTasks.Enqueue("DeletingMessage");
						}
						break;
					case "Campaign_CrtCampaign_TerrasoftInserted":
							if (ActivatedEventElements.Contains("InsertedCampaignMessage")) {
							context.QueueTasks.Enqueue("InsertedCampaignMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: Campaign_CrtCampaignEventsProcess

	/// <exclude/>
	public class Campaign_CrtCampaignEventsProcess : Campaign_CrtCampaignEventsProcess<Campaign_CrtCampaign_Terrasoft>
	{

		public Campaign_CrtCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

