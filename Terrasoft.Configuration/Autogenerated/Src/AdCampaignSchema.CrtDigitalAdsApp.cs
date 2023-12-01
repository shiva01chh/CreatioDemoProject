namespace Terrasoft.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: AdCampaign_CrtDigitalAdsApp_TerrasoftSchema

	/// <exclude/>
	public class AdCampaign_CrtDigitalAdsApp_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public AdCampaign_CrtDigitalAdsApp_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AdCampaign_CrtDigitalAdsApp_TerrasoftSchema(AdCampaign_CrtDigitalAdsApp_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AdCampaign_CrtDigitalAdsApp_TerrasoftSchema(AdCampaign_CrtDigitalAdsApp_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0b416432-4385-432a-94ad-c30262cd14da");
			RealUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da");
			Name = "AdCampaign_CrtDigitalAdsApp_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6f71e54c-1960-40c9-94f6-073fd67699ab");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateCampaignNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f6abfc72-4a5e-b343-b8c3-2823bc1acbf1")) == null) {
				Columns.Add(CreatePlatformColumn());
			}
			if (Columns.FindByUId(new Guid("3611441c-7635-f85d-2095-5a8e3f5479f5")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("be0128c3-f66e-d9a2-43e9-60dd2cfa41bb")) == null) {
				Columns.Add(CreateReachColumn());
			}
			if (Columns.FindByUId(new Guid("5d243541-508c-dc33-f874-846b41313ac7")) == null) {
				Columns.Add(CreateImpressionsColumn());
			}
			if (Columns.FindByUId(new Guid("6b2b9338-449f-f90a-a406-6f54b5cce048")) == null) {
				Columns.Add(CreateAdCampaignIdColumn());
			}
			if (Columns.FindByUId(new Guid("66f2b583-f108-421a-da14-330055448447")) == null) {
				Columns.Add(CreateFrequencyColumn());
			}
			if (Columns.FindByUId(new Guid("d1377aeb-56b8-5004-c9bd-88daea2b8df1")) == null) {
				Columns.Add(CreateCTRColumn());
			}
			if (Columns.FindByUId(new Guid("d929ee0c-41dc-ea27-7746-e2c4290ecdf1")) == null) {
				Columns.Add(CreateEndDateColumn());
			}
			if (Columns.FindByUId(new Guid("e034a113-1e22-c3b6-28bf-980cebf80447")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("51248ad3-729b-470f-6d67-12828d5614de")) == null) {
				Columns.Add(CreateCreatedDateColumn());
			}
			if (Columns.FindByUId(new Guid("87358965-c57f-fa54-f4bb-661ad93c6c54")) == null) {
				Columns.Add(CreateCPMColumn());
			}
			if (Columns.FindByUId(new Guid("2427e7fc-0ed0-841b-3438-88efbed462d1")) == null) {
				Columns.Add(CreateCPCColumn());
			}
			if (Columns.FindByUId(new Guid("a03b9cbe-622f-0585-a229-21cc6d0e7284")) == null) {
				Columns.Add(CreateClicksColumn());
			}
			if (Columns.FindByUId(new Guid("8474f79a-30ef-2933-e219-875d8e5e431c")) == null) {
				Columns.Add(CreateAmountSpentColumn());
			}
			if (Columns.FindByUId(new Guid("4074fddc-8655-5c25-c647-c0a054d4fb94")) == null) {
				Columns.Add(CreateAdAccountColumn());
			}
			if (Columns.FindByUId(new Guid("25e693c0-dad8-5f27-fe41-016e1527f78c")) == null) {
				Columns.Add(CreatePrimaryAmountSpentColumn());
			}
			if (Columns.FindByUId(new Guid("d76971ec-0ae1-c4ae-2cba-656863efb581")) == null) {
				Columns.Add(CreateAdAccountCurrencyColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCampaignNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("22d97f89-649b-4724-a9ec-8e6b6837fa86"),
				Name = @"CampaignName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				ModifiedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				CreatedInPackageId = new Guid("6f71e54c-1960-40c9-94f6-073fd67699ab")
			};
		}

		protected virtual EntitySchemaColumn CreatePlatformColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f6abfc72-4a5e-b343-b8c3-2823bc1acbf1"),
				Name = @"Platform",
				ReferenceSchemaUId = new Guid("57abc67c-e4ca-4dad-b9c7-1fd34e68b183"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				ModifiedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3611441c-7635-f85d-2095-5a8e3f5479f5"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("fa0c29e0-84d9-44dd-9ab7-cd4b39c2efa9"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				ModifiedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreateReachColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("be0128c3-f66e-d9a2-43e9-60dd2cfa41bb"),
				Name = @"Reach",
				CreatedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				ModifiedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreateImpressionsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("5d243541-508c-dc33-f874-846b41313ac7"),
				Name = @"Impressions",
				CreatedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				ModifiedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreateAdCampaignIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("6b2b9338-449f-f90a-a406-6f54b5cce048"),
				Name = @"AdCampaignId",
				CreatedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				ModifiedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreateFrequencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("66f2b583-f108-421a-da14-330055448447"),
				Name = @"Frequency",
				CreatedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				ModifiedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreateCTRColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("d1377aeb-56b8-5004-c9bd-88daea2b8df1"),
				Name = @"CTR",
				CreatedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				ModifiedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreateEndDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("d929ee0c-41dc-ea27-7746-e2c4290ecdf1"),
				Name = @"EndDate",
				CreatedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				ModifiedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("e034a113-1e22-c3b6-28bf-980cebf80447"),
				Name = @"StartDate",
				CreatedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				ModifiedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreateCreatedDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("51248ad3-729b-470f-6d67-12828d5614de"),
				Name = @"CreatedDate",
				CreatedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				ModifiedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreateCPMColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("87358965-c57f-fa54-f4bb-661ad93c6c54"),
				Name = @"CPM",
				CreatedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				ModifiedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreateCPCColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("2427e7fc-0ed0-841b-3438-88efbed462d1"),
				Name = @"CPC",
				CreatedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				ModifiedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreateClicksColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("a03b9cbe-622f-0585-a229-21cc6d0e7284"),
				Name = @"Clicks",
				CreatedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				ModifiedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountSpentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("8474f79a-30ef-2933-e219-875d8e5e431c"),
				Name = @"AmountSpent",
				CreatedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				ModifiedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreateAdAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4074fddc-8655-5c25-c647-c0a054d4fb94"),
				Name = @"AdAccount",
				ReferenceSchemaUId = new Guid("e80e87aa-bdcf-4b46-92aa-ecefca3d0ddc"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				ModifiedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryAmountSpentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("25e693c0-dad8-5f27-fe41-016e1527f78c"),
				Name = @"PrimaryAmountSpent",
				CreatedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				ModifiedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				CreatedInPackageId = new Guid("eb423f4c-c6c3-4c28-83dc-7dab90d05d91")
			};
		}

		protected virtual EntitySchemaColumn CreateAdAccountCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("d76971ec-0ae1-c4ae-2cba-656863efb581"),
				Name = @"AdAccountCurrency",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				ModifiedInSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				CreatedInPackageId = new Guid("832a38ef-5557-4852-84cf-750f124efbd5")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AdCampaign_CrtDigitalAdsApp_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AdCampaign_CrtDigitalAdsAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AdCampaign_CrtDigitalAdsApp_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AdCampaign_CrtDigitalAdsApp_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0b416432-4385-432a-94ad-c30262cd14da"));
		}

		#endregion

	}

	#endregion

	#region Class: AdCampaign_CrtDigitalAdsApp_Terrasoft

	/// <summary>
	/// Ad campaign.
	/// </summary>
	/// <remarks>
	/// The list of ad campaigns with performance indexes in the context of all life cycle.
	/// </remarks>
	public class AdCampaign_CrtDigitalAdsApp_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public AdCampaign_CrtDigitalAdsApp_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AdCampaign_CrtDigitalAdsApp_Terrasoft";
		}

		public AdCampaign_CrtDigitalAdsApp_Terrasoft(AdCampaign_CrtDigitalAdsApp_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Campaign name.
		/// </summary>
		/// <remarks>
		/// The name of the ad campaign.
		/// </remarks>
		public string CampaignName {
			get {
				return GetTypedColumnValue<string>("CampaignName");
			}
			set {
				SetColumnValue("CampaignName", value);
			}
		}

		/// <exclude/>
		public Guid PlatformId {
			get {
				return GetTypedColumnValue<Guid>("PlatformId");
			}
			set {
				SetColumnValue("PlatformId", value);
				_platform = null;
			}
		}

		/// <exclude/>
		public string PlatformName {
			get {
				return GetTypedColumnValue<string>("PlatformName");
			}
			set {
				SetColumnValue("PlatformName", value);
				if (_platform != null) {
					_platform.Name = value;
				}
			}
		}

		private AdPlatform _platform;
		/// <summary>
		/// Platform.
		/// </summary>
		/// <remarks>
		/// The ad platform name.
		/// </remarks>
		public AdPlatform Platform {
			get {
				return _platform ??
					(_platform = LookupColumnEntities.GetEntity("Platform") as AdPlatform);
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

		private AdCampaignStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		/// <remarks>
		/// The current status of your campaign.
		/// </remarks>
		public AdCampaignStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as AdCampaignStatus);
			}
		}

		/// <summary>
		/// Reach.
		/// </summary>
		/// <remarks>
		/// The total number of people who see your content. Calculated by the formula:  Impressions ÷ Frequency.
		/// </remarks>
		public int Reach {
			get {
				return GetTypedColumnValue<int>("Reach");
			}
			set {
				SetColumnValue("Reach", value);
			}
		}

		/// <summary>
		/// Impressions.
		/// </summary>
		/// <remarks>
		/// The number of times your content is displayed.
		/// </remarks>
		public int Impressions {
			get {
				return GetTypedColumnValue<int>("Impressions");
			}
			set {
				SetColumnValue("Impressions", value);
			}
		}

		/// <summary>
		/// Campaign Id.
		/// </summary>
		/// <remarks>
		/// The unique code of the campaign generated by the ad platform.
		/// </remarks>
		public string AdCampaignId {
			get {
				return GetTypedColumnValue<string>("AdCampaignId");
			}
			set {
				SetColumnValue("AdCampaignId", value);
			}
		}

		/// <summary>
		/// Frequency.
		/// </summary>
		/// <remarks>
		/// The number of times a user sees ads in your campaign over a given time period. Calculated by the formula:  Impressions ÷ Reach.
		/// </remarks>
		public Decimal Frequency {
			get {
				return GetTypedColumnValue<Decimal>("Frequency");
			}
			set {
				SetColumnValue("Frequency", value);
			}
		}

		/// <summary>
		/// Clickthrough rate.
		/// </summary>
		/// <remarks>
		/// The percentage of times that people saw your ad and performed a click. Calculated by the formula: (Clicks ÷  Impressions) × 100.
		/// </remarks>
		public Decimal CTR {
			get {
				return GetTypedColumnValue<Decimal>("CTR");
			}
			set {
				SetColumnValue("CTR", value);
			}
		}

		/// <summary>
		/// End date.
		/// </summary>
		/// <remarks>
		/// The date when the campaign was ended.
		/// </remarks>
		public DateTime EndDate {
			get {
				return GetTypedColumnValue<DateTime>("EndDate");
			}
			set {
				SetColumnValue("EndDate", value);
			}
		}

		/// <summary>
		/// Start date.
		/// </summary>
		/// <remarks>
		/// The date when the campaign was started.
		/// </remarks>
		public DateTime StartDate {
			get {
				return GetTypedColumnValue<DateTime>("StartDate");
			}
			set {
				SetColumnValue("StartDate", value);
			}
		}

		/// <summary>
		/// Created date.
		/// </summary>
		/// <remarks>
		/// The date when the campaign was created.
		/// </remarks>
		public DateTime CreatedDate {
			get {
				return GetTypedColumnValue<DateTime>("CreatedDate");
			}
			set {
				SetColumnValue("CreatedDate", value);
			}
		}

		/// <summary>
		/// Cost per mille.
		/// </summary>
		/// <remarks>
		/// The cost for 1,000 impressions. Calculated by the formula: (Amount spent ÷ Impressions) × 1000.
		/// </remarks>
		public Decimal CPM {
			get {
				return GetTypedColumnValue<Decimal>("CPM");
			}
			set {
				SetColumnValue("CPM", value);
			}
		}

		/// <summary>
		/// Cost per click.
		/// </summary>
		/// <remarks>
		/// The cost for each click. Calculated by the formula: Amount spent ÷ Clicks.
		/// </remarks>
		public Decimal CPC {
			get {
				return GetTypedColumnValue<Decimal>("CPC");
			}
			set {
				SetColumnValue("CPC", value);
			}
		}

		/// <summary>
		/// Clicks.
		/// </summary>
		/// <remarks>
		/// The amount of clicks on your ads.
		/// </remarks>
		public int Clicks {
			get {
				return GetTypedColumnValue<int>("Clicks");
			}
			set {
				SetColumnValue("Clicks", value);
			}
		}

		/// <summary>
		/// Amount spent.
		/// </summary>
		/// <remarks>
		/// The estimated total amount of money you've spent on your campaign.
		/// </remarks>
		public Decimal AmountSpent {
			get {
				return GetTypedColumnValue<Decimal>("AmountSpent");
			}
			set {
				SetColumnValue("AmountSpent", value);
			}
		}

		/// <exclude/>
		public Guid AdAccountId {
			get {
				return GetTypedColumnValue<Guid>("AdAccountId");
			}
			set {
				SetColumnValue("AdAccountId", value);
				_adAccount = null;
			}
		}

		/// <exclude/>
		public string AdAccountName {
			get {
				return GetTypedColumnValue<string>("AdAccountName");
			}
			set {
				SetColumnValue("AdAccountName", value);
				if (_adAccount != null) {
					_adAccount.Name = value;
				}
			}
		}

		private AdAccount _adAccount;
		/// <summary>
		/// Ad account.
		/// </summary>
		/// <remarks>
		/// The ad account.
		/// </remarks>
		public AdAccount AdAccount {
			get {
				return _adAccount ??
					(_adAccount = LookupColumnEntities.GetEntity("AdAccount") as AdAccount);
			}
		}

		/// <summary>
		/// Amount spent, base currency.
		/// </summary>
		/// <remarks>
		/// The estimated total amount of money you've spent on your campaign in the base currency.
		/// </remarks>
		public Decimal PrimaryAmountSpent {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryAmountSpent");
			}
			set {
				SetColumnValue("PrimaryAmountSpent", value);
			}
		}

		/// <summary>
		/// Currency.
		/// </summary>
		/// <remarks>
		/// Current currency from each Ad account.
		/// </remarks>
		public string AdAccountCurrency {
			get {
				return GetTypedColumnValue<string>("AdAccountCurrency");
			}
			set {
				SetColumnValue("AdAccountCurrency", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AdCampaign_CrtDigitalAdsAppEventsProcess(UserConnection);
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
			return new AdCampaign_CrtDigitalAdsApp_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: AdCampaign_CrtDigitalAdsAppEventsProcess

	/// <exclude/>
	public partial class AdCampaign_CrtDigitalAdsAppEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : AdCampaign_CrtDigitalAdsApp_Terrasoft
	{

		public AdCampaign_CrtDigitalAdsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdCampaign_CrtDigitalAdsAppEventsProcess";
			SchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0b416432-4385-432a-94ad-c30262cd14da");
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

	#region Class: AdCampaign_CrtDigitalAdsAppEventsProcess

	/// <exclude/>
	public class AdCampaign_CrtDigitalAdsAppEventsProcess : AdCampaign_CrtDigitalAdsAppEventsProcess<AdCampaign_CrtDigitalAdsApp_Terrasoft>
	{

		public AdCampaign_CrtDigitalAdsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdCampaign_CrtDigitalAdsAppEventsProcess

	public partial class AdCampaign_CrtDigitalAdsAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

