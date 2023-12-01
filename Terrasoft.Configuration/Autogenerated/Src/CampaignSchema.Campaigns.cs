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

	#region Class: CampaignSchema

	/// <exclude/>
	public class CampaignSchema : Terrasoft.Configuration.Campaign_CrtCampaign_TerrasoftSchema
	{

		#region Constructors: Public

		public CampaignSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CampaignSchema(CampaignSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CampaignSchema(CampaignSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("ea93f775-ce2a-4ad1-bc92-0975dc3534a3");
			Name = "Campaign";
			ParentSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8");
			ExtendParent = true;
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("876c6749-2c05-4861-856e-efd51b847904")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("814b1db4-05bf-46a1-9dbf-78f4000f35e6")) == null) {
				Columns.Add(CreateSegmentsStatusColumn());
			}
			if (Columns.FindByUId(new Guid("6bfcc02e-0a48-450d-af48-78fb42719710")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("5346e7fe-738c-4806-8fb5-131b63df3659")) == null) {
				Columns.Add(CreateSchemaDataColumn());
			}
			if (Columns.FindByUId(new Guid("7f7bacd5-5a9f-4ba6-b189-f8ee9cad5bbc")) == null) {
				Columns.Add(CreateTargetPercentColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("876c6749-2c05-4861-856e-efd51b847904"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("c108f0cd-e885-45c8-8f15-3a0929c05a70"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ea93f775-ce2a-4ad1-bc92-0975dc3534a3"),
				ModifiedInSchemaUId = new Guid("ea93f775-ce2a-4ad1-bc92-0975dc3534a3"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected virtual EntitySchemaColumn CreateSegmentsStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("814b1db4-05bf-46a1-9dbf-78f4000f35e6"),
				Name = @"SegmentsStatus",
				ReferenceSchemaUId = new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ea93f775-ce2a-4ad1-bc92-0975dc3534a3"),
				ModifiedInSchemaUId = new Guid("ea93f775-ce2a-4ad1-bc92-0975dc3534a3"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("6bfcc02e-0a48-450d-af48-78fb42719710"),
				Name = @"Notes",
				CreatedInSchemaUId = new Guid("ea93f775-ce2a-4ad1-bc92-0975dc3534a3"),
				ModifiedInSchemaUId = new Guid("ea93f775-ce2a-4ad1-bc92-0975dc3534a3"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected virtual EntitySchemaColumn CreateSchemaDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("5346e7fe-738c-4806-8fb5-131b63df3659"),
				Name = @"SchemaData",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ea93f775-ce2a-4ad1-bc92-0975dc3534a3"),
				ModifiedInSchemaUId = new Guid("ea93f775-ce2a-4ad1-bc92-0975dc3534a3"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected virtual EntitySchemaColumn CreateTargetPercentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float1")) {
				UId = new Guid("7f7bacd5-5a9f-4ba6-b189-f8ee9cad5bbc"),
				Name = @"TargetPercent",
				CreatedInSchemaUId = new Guid("ea93f775-ce2a-4ad1-bc92-0975dc3534a3"),
				ModifiedInSchemaUId = new Guid("ea93f775-ce2a-4ad1-bc92-0975dc3534a3"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"20"
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
			return new Campaign(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Campaign_CampaignsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CampaignSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CampaignSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ea93f775-ce2a-4ad1-bc92-0975dc3534a3"));
		}

		#endregion

	}

	#endregion

	#region Class: Campaign

	/// <summary>
	/// Campaign.
	/// </summary>
	public class Campaign : Terrasoft.Configuration.Campaign_CrtCampaign_Terrasoft
	{

		#region Constructors: Public

		public Campaign(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Campaign";
		}

		public Campaign(Campaign source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		private CampaignType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public CampaignType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as CampaignType);
			}
		}

		/// <exclude/>
		public Guid SegmentsStatusId {
			get {
				return GetTypedColumnValue<Guid>("SegmentsStatusId");
			}
			set {
				SetColumnValue("SegmentsStatusId", value);
				_segmentsStatus = null;
			}
		}

		/// <exclude/>
		public string SegmentsStatusName {
			get {
				return GetTypedColumnValue<string>("SegmentsStatusName");
			}
			set {
				SetColumnValue("SegmentsStatusName", value);
				if (_segmentsStatus != null) {
					_segmentsStatus.Name = value;
				}
			}
		}

		private SegmentStatus _segmentsStatus;
		/// <summary>
		/// List of contacts.
		/// </summary>
		public SegmentStatus SegmentsStatus {
			get {
				return _segmentsStatus ??
					(_segmentsStatus = LookupColumnEntities.GetEntity("SegmentsStatus") as SegmentStatus);
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
		/// Campaign workflow.
		/// </summary>
		public string SchemaData {
			get {
				return GetTypedColumnValue<string>("SchemaData");
			}
			set {
				SetColumnValue("SchemaData", value);
			}
		}

		/// <summary>
		/// Goal.
		/// </summary>
		public Decimal TargetPercent {
			get {
				return GetTypedColumnValue<Decimal>("TargetPercent");
			}
			set {
				SetColumnValue("TargetPercent", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Campaign_CampaignsEventsProcess(UserConnection);
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
			return new Campaign(this);
		}

		#endregion

	}

	#endregion

	#region Class: Campaign_CampaignsEventsProcess

	/// <exclude/>
	public partial class Campaign_CampaignsEventsProcess<TEntity> : Terrasoft.Configuration.Campaign_CrtCampaignEventsProcess<TEntity> where TEntity : Campaign
	{

		public Campaign_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Campaign_CampaignsEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ea93f775-ce2a-4ad1-bc92-0975dc3534a3");
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

	#region Class: Campaign_CampaignsEventsProcess

	/// <exclude/>
	public class Campaign_CampaignsEventsProcess : Campaign_CampaignsEventsProcess<Campaign>
	{

		public Campaign_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: CampaignEventsProcess

	/// <exclude/>
	public class CampaignEventsProcess : Campaign_CampaignsEventsProcess
	{

		public CampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

