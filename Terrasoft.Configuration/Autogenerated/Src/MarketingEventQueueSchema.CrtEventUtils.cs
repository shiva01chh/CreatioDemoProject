﻿namespace Terrasoft.Configuration
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

	#region Class: MarketingEventQueueSchema

	/// <exclude/>
	public class MarketingEventQueueSchema : Terrasoft.Configuration.BaseTaskQueueSchema
	{

		#region Constructors: Public

		public MarketingEventQueueSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MarketingEventQueueSchema(MarketingEventQueueSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MarketingEventQueueSchema(MarketingEventQueueSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("446a6f90-aa50-1451-56bb-23db66d83dee");
			RealUId = new Guid("446a6f90-aa50-1451-56bb-23db66d83dee");
			Name = "MarketingEventQueue";
			ParentSchemaUId = new Guid("de97f161-117b-49b0-b08a-38ae2a77cdd1");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("4a6d2d51-5382-5ffc-a067-4243a7150583")) == null) {
				Columns.Add(CreateEventColumn());
			}
			if (Columns.FindByUId(new Guid("ed63ee37-e860-919c-d10f-a737af510686")) == null) {
				Columns.Add(CreateEstimatedRowsCountColumn());
			}
			if (Columns.FindByUId(new Guid("8aed5dd0-9705-1557-bfe1-cb29f50e33e3")) == null) {
				Columns.Add(CreateEstimatedTimeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEventColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4a6d2d51-5382-5ffc-a067-4243a7150583"),
				Name = @"Event",
				ReferenceSchemaUId = new Guid("5b4fdfc7-12b6-4b4f-a9bd-b6f1b6e4447f"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("446a6f90-aa50-1451-56bb-23db66d83dee"),
				ModifiedInSchemaUId = new Guid("446a6f90-aa50-1451-56bb-23db66d83dee"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e")
			};
		}

		protected virtual EntitySchemaColumn CreateEstimatedRowsCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("ed63ee37-e860-919c-d10f-a737af510686"),
				Name = @"EstimatedRowsCount",
				CreatedInSchemaUId = new Guid("446a6f90-aa50-1451-56bb-23db66d83dee"),
				ModifiedInSchemaUId = new Guid("446a6f90-aa50-1451-56bb-23db66d83dee"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e")
			};
		}

		protected virtual EntitySchemaColumn CreateEstimatedTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("8aed5dd0-9705-1557-bfe1-cb29f50e33e3"),
				Name = @"EstimatedTime",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("446a6f90-aa50-1451-56bb-23db66d83dee"),
				ModifiedInSchemaUId = new Guid("446a6f90-aa50-1451-56bb-23db66d83dee"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"1"
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
			return new MarketingEventQueue(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MarketingEventQueue_CrtEventUtilsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MarketingEventQueueSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MarketingEventQueueSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("446a6f90-aa50-1451-56bb-23db66d83dee"));
		}

		#endregion

	}

	#endregion

	#region Class: MarketingEventQueue

	/// <summary>
	/// Marketing event queue.
	/// </summary>
	public class MarketingEventQueue : Terrasoft.Configuration.BaseTaskQueue
	{

		#region Constructors: Public

		public MarketingEventQueue(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MarketingEventQueue";
		}

		public MarketingEventQueue(MarketingEventQueue source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid EventId {
			get {
				return GetTypedColumnValue<Guid>("EventId");
			}
			set {
				SetColumnValue("EventId", value);
				_event = null;
			}
		}

		/// <exclude/>
		public string EventName {
			get {
				return GetTypedColumnValue<string>("EventName");
			}
			set {
				SetColumnValue("EventName", value);
				if (_event != null) {
					_event.Name = value;
				}
			}
		}

		private Event _event;
		/// <summary>
		/// Event.
		/// </summary>
		public Event Event {
			get {
				return _event ??
					(_event = LookupColumnEntities.GetEntity("Event") as Event);
			}
		}

		/// <summary>
		/// Estimated rows count.
		/// </summary>
		public int EstimatedRowsCount {
			get {
				return GetTypedColumnValue<int>("EstimatedRowsCount");
			}
			set {
				SetColumnValue("EstimatedRowsCount", value);
			}
		}

		/// <summary>
		/// ETA (seconds).
		/// </summary>
		public int EstimatedTime {
			get {
				return GetTypedColumnValue<int>("EstimatedTime");
			}
			set {
				SetColumnValue("EstimatedTime", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MarketingEventQueue_CrtEventUtilsEventsProcess(UserConnection);
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
			return new MarketingEventQueue(this);
		}

		#endregion

	}

	#endregion

	#region Class: MarketingEventQueue_CrtEventUtilsEventsProcess

	/// <exclude/>
	public partial class MarketingEventQueue_CrtEventUtilsEventsProcess<TEntity> : Terrasoft.Configuration.BaseTaskQueue_CrtMarketingBaseEventsProcess<TEntity> where TEntity : MarketingEventQueue
	{

		public MarketingEventQueue_CrtEventUtilsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MarketingEventQueue_CrtEventUtilsEventsProcess";
			SchemaUId = new Guid("446a6f90-aa50-1451-56bb-23db66d83dee");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("446a6f90-aa50-1451-56bb-23db66d83dee");
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

	#region Class: MarketingEventQueue_CrtEventUtilsEventsProcess

	/// <exclude/>
	public class MarketingEventQueue_CrtEventUtilsEventsProcess : MarketingEventQueue_CrtEventUtilsEventsProcess<MarketingEventQueue>
	{

		public MarketingEventQueue_CrtEventUtilsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MarketingEventQueue_CrtEventUtilsEventsProcess

	public partial class MarketingEventQueue_CrtEventUtilsEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: MarketingEventQueueEventsProcess

	/// <exclude/>
	public class MarketingEventQueueEventsProcess : MarketingEventQueue_CrtEventUtilsEventsProcess
	{

		public MarketingEventQueueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

