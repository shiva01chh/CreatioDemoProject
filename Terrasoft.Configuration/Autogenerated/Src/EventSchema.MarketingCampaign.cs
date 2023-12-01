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

	#region Class: EventSchema

	/// <exclude/>
	public class EventSchema : Terrasoft.Configuration.Event_CrtEvent_TerrasoftSchema
	{

		#region Constructors: Public

		public EventSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EventSchema(EventSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EventSchema(EventSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("663313ad-a1ad-4743-908c-964f71a59b7d");
			Name = "Event";
			ParentSchemaUId = new Guid("5b4fdfc7-12b6-4b4f-a9bd-b6f1b6e4447f");
			ExtendParent = true;
			CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("7002a672-92e0-4371-56ad-d50fe6b750fb")) == null) {
				Columns.Add(CreateActualizeStatusColumn());
			}
			if (Columns.FindByUId(new Guid("09f607c1-c707-5db1-6376-a6e7f045fb56")) == null) {
				Columns.Add(CreateCampaignColumn());
			}
			if (Columns.FindByUId(new Guid("e8a0dedf-fcd5-fc5e-95ef-588d3aa6a474")) == null) {
				Columns.Add(CreateSegmentsStatusColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateActualizeStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7002a672-92e0-4371-56ad-d50fe6b750fb"),
				Name = @"ActualizeStatus",
				ReferenceSchemaUId = new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("663313ad-a1ad-4743-908c-964f71a59b7d"),
				ModifiedInSchemaUId = new Guid("663313ad-a1ad-4743-908c-964f71a59b7d"),
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5")
			};
		}

		protected virtual EntitySchemaColumn CreateCampaignColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("09f607c1-c707-5db1-6376-a6e7f045fb56"),
				Name = @"Campaign",
				ReferenceSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("663313ad-a1ad-4743-908c-964f71a59b7d"),
				ModifiedInSchemaUId = new Guid("663313ad-a1ad-4743-908c-964f71a59b7d"),
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5")
			};
		}

		protected virtual EntitySchemaColumn CreateSegmentsStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e8a0dedf-fcd5-fc5e-95ef-588d3aa6a474"),
				Name = @"SegmentsStatus",
				ReferenceSchemaUId = new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("663313ad-a1ad-4743-908c-964f71a59b7d"),
				ModifiedInSchemaUId = new Guid("663313ad-a1ad-4743-908c-964f71a59b7d"),
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"fa360d2c-1658-49ad-9152-22479fdc0c12"
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
			return new Event(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Event_MarketingCampaignEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EventSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EventSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("663313ad-a1ad-4743-908c-964f71a59b7d"));
		}

		#endregion

	}

	#endregion

	#region Class: Event

	/// <summary>
	/// Event.
	/// </summary>
	public class Event : Terrasoft.Configuration.Event_CrtEvent_Terrasoft
	{

		#region Constructors: Public

		public Event(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Event";
		}

		public Event(Event source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ActualizeStatusId {
			get {
				return GetTypedColumnValue<Guid>("ActualizeStatusId");
			}
			set {
				SetColumnValue("ActualizeStatusId", value);
				_actualizeStatus = null;
			}
		}

		/// <exclude/>
		public string ActualizeStatusName {
			get {
				return GetTypedColumnValue<string>("ActualizeStatusName");
			}
			set {
				SetColumnValue("ActualizeStatusName", value);
				if (_actualizeStatus != null) {
					_actualizeStatus.Name = value;
				}
			}
		}

		private SegmentStatus _actualizeStatus;
		/// <summary>
		/// Segment update status.
		/// </summary>
		public SegmentStatus ActualizeStatus {
			get {
				return _actualizeStatus ??
					(_actualizeStatus = LookupColumnEntities.GetEntity("ActualizeStatus") as SegmentStatus);
			}
		}

		/// <exclude/>
		public Guid CampaignId {
			get {
				return GetTypedColumnValue<Guid>("CampaignId");
			}
			set {
				SetColumnValue("CampaignId", value);
				_campaign = null;
			}
		}

		/// <exclude/>
		public string CampaignName {
			get {
				return GetTypedColumnValue<string>("CampaignName");
			}
			set {
				SetColumnValue("CampaignName", value);
				if (_campaign != null) {
					_campaign.Name = value;
				}
			}
		}

		private Campaign _campaign;
		/// <summary>
		/// Campaign.
		/// </summary>
		public Campaign Campaign {
			get {
				return _campaign ??
					(_campaign = LookupColumnEntities.GetEntity("Campaign") as Campaign);
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
		/// List of leads.
		/// </summary>
		public SegmentStatus SegmentsStatus {
			get {
				return _segmentsStatus ??
					(_segmentsStatus = LookupColumnEntities.GetEntity("SegmentsStatus") as SegmentStatus);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Event_MarketingCampaignEventsProcess(UserConnection);
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
			return new Event(this);
		}

		#endregion

	}

	#endregion

	#region Class: Event_MarketingCampaignEventsProcess

	/// <exclude/>
	public partial class Event_MarketingCampaignEventsProcess<TEntity> : Terrasoft.Configuration.Event_CrtEventEventsProcess<TEntity> where TEntity : Event
	{

		public Event_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Event_MarketingCampaignEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("663313ad-a1ad-4743-908c-964f71a59b7d");
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

	#region Class: Event_MarketingCampaignEventsProcess

	/// <exclude/>
	public class Event_MarketingCampaignEventsProcess : Event_MarketingCampaignEventsProcess<Event>
	{

		public Event_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Event_MarketingCampaignEventsProcess

	public partial class Event_MarketingCampaignEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: EventEventsProcess

	/// <exclude/>
	public class EventEventsProcess : Event_MarketingCampaignEventsProcess
	{

		public EventEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

