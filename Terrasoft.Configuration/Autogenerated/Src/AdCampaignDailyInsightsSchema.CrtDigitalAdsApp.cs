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

	#region Class: AdCampaignDailyInsights_CrtDigitalAdsApp_TerrasoftSchema

	/// <exclude/>
	public class AdCampaignDailyInsights_CrtDigitalAdsApp_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public AdCampaignDailyInsights_CrtDigitalAdsApp_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AdCampaignDailyInsights_CrtDigitalAdsApp_TerrasoftSchema(AdCampaignDailyInsights_CrtDigitalAdsApp_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AdCampaignDailyInsights_CrtDigitalAdsApp_TerrasoftSchema(AdCampaignDailyInsights_CrtDigitalAdsApp_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805");
			RealUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805");
			Name = "AdCampaignDailyInsights_CrtDigitalAdsApp_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("eb423f4c-c6c3-4c28-83dc-7dab90d05d91");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("16fc88ac-879f-adde-e040-a99fcf2c0a01")) == null) {
				Columns.Add(CreateReachColumn());
			}
			if (Columns.FindByUId(new Guid("a6aecad4-94e0-1fa8-6e71-c0f57b66c932")) == null) {
				Columns.Add(CreateImpressionsColumn());
			}
			if (Columns.FindByUId(new Guid("6e6b7468-ca0e-f667-63e1-e7db1c336db7")) == null) {
				Columns.Add(CreateAdCampaignColumn());
			}
			if (Columns.FindByUId(new Guid("f8e92e18-5124-2aeb-3c6f-344bac636a0f")) == null) {
				Columns.Add(CreateFrequencyColumn());
			}
			if (Columns.FindByUId(new Guid("3d74e710-f574-9746-7e46-6c80a881db55")) == null) {
				Columns.Add(CreateCTRColumn());
			}
			if (Columns.FindByUId(new Guid("3bdbd201-5e84-28dd-992a-f47ef89911e4")) == null) {
				Columns.Add(CreateDataRangeDateColumn());
			}
			if (Columns.FindByUId(new Guid("2b4da3fe-ea96-32b6-5b50-b273c9f161e9")) == null) {
				Columns.Add(CreateCPMColumn());
			}
			if (Columns.FindByUId(new Guid("ccf671f7-e8c8-9484-0a26-cbdb0d76c663")) == null) {
				Columns.Add(CreateCPCColumn());
			}
			if (Columns.FindByUId(new Guid("79ed1dd4-c735-f54a-31cd-2fbd03eb9b20")) == null) {
				Columns.Add(CreateClicksColumn());
			}
			if (Columns.FindByUId(new Guid("87a095e1-23b5-5436-7092-6343ef5d0b10")) == null) {
				Columns.Add(CreateAmountSpentColumn());
			}
			if (Columns.FindByUId(new Guid("0a9ea231-af65-e8a6-102d-6a42617fc134")) == null) {
				Columns.Add(CreatePrimaryAmountSpentColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateReachColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("16fc88ac-879f-adde-e040-a99fcf2c0a01"),
				Name = @"Reach",
				CreatedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				ModifiedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				CreatedInPackageId = new Guid("eb423f4c-c6c3-4c28-83dc-7dab90d05d91")
			};
		}

		protected virtual EntitySchemaColumn CreateImpressionsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("a6aecad4-94e0-1fa8-6e71-c0f57b66c932"),
				Name = @"Impressions",
				CreatedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				ModifiedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				CreatedInPackageId = new Guid("eb423f4c-c6c3-4c28-83dc-7dab90d05d91")
			};
		}

		protected virtual EntitySchemaColumn CreateAdCampaignColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6e6b7468-ca0e-f667-63e1-e7db1c336db7"),
				Name = @"AdCampaign",
				ReferenceSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				ModifiedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				CreatedInPackageId = new Guid("eb423f4c-c6c3-4c28-83dc-7dab90d05d91")
			};
		}

		protected virtual EntitySchemaColumn CreateFrequencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("f8e92e18-5124-2aeb-3c6f-344bac636a0f"),
				Name = @"Frequency",
				CreatedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				ModifiedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				CreatedInPackageId = new Guid("eb423f4c-c6c3-4c28-83dc-7dab90d05d91")
			};
		}

		protected virtual EntitySchemaColumn CreateCTRColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("3d74e710-f574-9746-7e46-6c80a881db55"),
				Name = @"CTR",
				CreatedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				ModifiedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				CreatedInPackageId = new Guid("eb423f4c-c6c3-4c28-83dc-7dab90d05d91")
			};
		}

		protected virtual EntitySchemaColumn CreateDataRangeDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("3bdbd201-5e84-28dd-992a-f47ef89911e4"),
				Name = @"DataRangeDate",
				CreatedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				ModifiedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				CreatedInPackageId = new Guid("eb423f4c-c6c3-4c28-83dc-7dab90d05d91")
			};
		}

		protected virtual EntitySchemaColumn CreateCPMColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("2b4da3fe-ea96-32b6-5b50-b273c9f161e9"),
				Name = @"CPM",
				CreatedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				ModifiedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				CreatedInPackageId = new Guid("eb423f4c-c6c3-4c28-83dc-7dab90d05d91")
			};
		}

		protected virtual EntitySchemaColumn CreateCPCColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("ccf671f7-e8c8-9484-0a26-cbdb0d76c663"),
				Name = @"CPC",
				CreatedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				ModifiedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				CreatedInPackageId = new Guid("eb423f4c-c6c3-4c28-83dc-7dab90d05d91")
			};
		}

		protected virtual EntitySchemaColumn CreateClicksColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("79ed1dd4-c735-f54a-31cd-2fbd03eb9b20"),
				Name = @"Clicks",
				CreatedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				ModifiedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				CreatedInPackageId = new Guid("eb423f4c-c6c3-4c28-83dc-7dab90d05d91")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountSpentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("87a095e1-23b5-5436-7092-6343ef5d0b10"),
				Name = @"AmountSpent",
				CreatedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				ModifiedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				CreatedInPackageId = new Guid("eb423f4c-c6c3-4c28-83dc-7dab90d05d91")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryAmountSpentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("0a9ea231-af65-e8a6-102d-6a42617fc134"),
				Name = @"PrimaryAmountSpent",
				CreatedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				ModifiedInSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805"),
				CreatedInPackageId = new Guid("eb423f4c-c6c3-4c28-83dc-7dab90d05d91")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AdCampaignDailyInsights_CrtDigitalAdsApp_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AdCampaignDailyInsights_CrtDigitalAdsAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AdCampaignDailyInsights_CrtDigitalAdsApp_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AdCampaignDailyInsights_CrtDigitalAdsApp_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cfb6f45d-cba1-4654-a569-26706df96805"));
		}

		#endregion

	}

	#endregion

	#region Class: AdCampaignDailyInsights_CrtDigitalAdsApp_Terrasoft

	/// <summary>
	/// Ad campaign daily insights.
	/// </summary>
	/// <remarks>
	/// Performance indexes of ad campaign by day.
	/// </remarks>
	public class AdCampaignDailyInsights_CrtDigitalAdsApp_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public AdCampaignDailyInsights_CrtDigitalAdsApp_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AdCampaignDailyInsights_CrtDigitalAdsApp_Terrasoft";
		}

		public AdCampaignDailyInsights_CrtDigitalAdsApp_Terrasoft(AdCampaignDailyInsights_CrtDigitalAdsApp_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Reach.
		/// </summary>
		/// <remarks>
		/// The total number of people who see your content. Calculated by the formula: Impressions ÷ Frequency.
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

		/// <exclude/>
		public Guid AdCampaignId {
			get {
				return GetTypedColumnValue<Guid>("AdCampaignId");
			}
			set {
				SetColumnValue("AdCampaignId", value);
				_adCampaign = null;
			}
		}

		/// <exclude/>
		public string AdCampaignCampaignName {
			get {
				return GetTypedColumnValue<string>("AdCampaignCampaignName");
			}
			set {
				SetColumnValue("AdCampaignCampaignName", value);
				if (_adCampaign != null) {
					_adCampaign.CampaignName = value;
				}
			}
		}

		private AdCampaign _adCampaign;
		/// <summary>
		/// Ad campaign.
		/// </summary>
		/// <remarks>
		/// The unique code of the ad campaign connected with daily insights.
		/// </remarks>
		public AdCampaign AdCampaign {
			get {
				return _adCampaign ??
					(_adCampaign = LookupColumnEntities.GetEntity("AdCampaign") as AdCampaign);
			}
		}

		/// <summary>
		/// Frequency.
		/// </summary>
		/// <remarks>
		/// The number of times a user sees ads in your campaign over a given time period. Calculated by the formula: Impressions ÷ Reach.
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
		/// The percentage of times that people saw your ad and performed a click. Calculated by the formula: (Clicks ÷ Impressions) × 100.
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
		/// Data range date.
		/// </summary>
		/// <remarks>
		/// The date when the daily data was created.
		/// </remarks>
		public DateTime DataRangeDate {
			get {
				return GetTypedColumnValue<DateTime>("DataRangeDate");
			}
			set {
				SetColumnValue("DataRangeDate", value);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AdCampaignDailyInsights_CrtDigitalAdsAppEventsProcess(UserConnection);
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
			return new AdCampaignDailyInsights_CrtDigitalAdsApp_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: AdCampaignDailyInsights_CrtDigitalAdsAppEventsProcess

	/// <exclude/>
	public partial class AdCampaignDailyInsights_CrtDigitalAdsAppEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : AdCampaignDailyInsights_CrtDigitalAdsApp_Terrasoft
	{

		public AdCampaignDailyInsights_CrtDigitalAdsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdCampaignDailyInsights_CrtDigitalAdsAppEventsProcess";
			SchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("cfb6f45d-cba1-4654-a569-26706df96805");
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

	#region Class: AdCampaignDailyInsights_CrtDigitalAdsAppEventsProcess

	/// <exclude/>
	public class AdCampaignDailyInsights_CrtDigitalAdsAppEventsProcess : AdCampaignDailyInsights_CrtDigitalAdsAppEventsProcess<AdCampaignDailyInsights_CrtDigitalAdsApp_Terrasoft>
	{

		public AdCampaignDailyInsights_CrtDigitalAdsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdCampaignDailyInsights_CrtDigitalAdsAppEventsProcess

	public partial class AdCampaignDailyInsights_CrtDigitalAdsAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

