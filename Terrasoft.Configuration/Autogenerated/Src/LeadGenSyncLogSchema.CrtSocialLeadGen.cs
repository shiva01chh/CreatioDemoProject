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

	#region Class: LeadGenSyncLogSchema

	/// <exclude/>
	public class LeadGenSyncLogSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public LeadGenSyncLogSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadGenSyncLogSchema(LeadGenSyncLogSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadGenSyncLogSchema(LeadGenSyncLogSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6431976b-6095-4922-af35-f748645c1107");
			RealUId = new Guid("6431976b-6095-4922-af35-f748645c1107");
			Name = "LeadGenSyncLog";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e287644e-be62-6459-7367-180a4e0b46c4")) == null) {
				Columns.Add(CreateProcessNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateProcessNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("e287644e-be62-6459-7367-180a4e0b46c4"),
				Name = @"ProcessName",
				CreatedInSchemaUId = new Guid("6431976b-6095-4922-af35-f748645c1107"),
				ModifiedInSchemaUId = new Guid("6431976b-6095-4922-af35-f748645c1107"),
				CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LeadGenSyncLog(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadGenSyncLog_CrtSocialLeadGenEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadGenSyncLogSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadGenSyncLogSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6431976b-6095-4922-af35-f748645c1107"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadGenSyncLog

	/// <summary>
	/// Data consistency check log.
	/// </summary>
	public class LeadGenSyncLog : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public LeadGenSyncLog(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadGenSyncLog";
		}

		public LeadGenSyncLog(LeadGenSyncLog source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Process name.
		/// </summary>
		public string ProcessName {
			get {
				return GetTypedColumnValue<string>("ProcessName");
			}
			set {
				SetColumnValue("ProcessName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadGenSyncLog_CrtSocialLeadGenEventsProcess(UserConnection);
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
			return new LeadGenSyncLog(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadGenSyncLog_CrtSocialLeadGenEventsProcess

	/// <exclude/>
	public partial class LeadGenSyncLog_CrtSocialLeadGenEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : LeadGenSyncLog
	{

		public LeadGenSyncLog_CrtSocialLeadGenEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadGenSyncLog_CrtSocialLeadGenEventsProcess";
			SchemaUId = new Guid("6431976b-6095-4922-af35-f748645c1107");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6431976b-6095-4922-af35-f748645c1107");
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

	#region Class: LeadGenSyncLog_CrtSocialLeadGenEventsProcess

	/// <exclude/>
	public class LeadGenSyncLog_CrtSocialLeadGenEventsProcess : LeadGenSyncLog_CrtSocialLeadGenEventsProcess<LeadGenSyncLog>
	{

		public LeadGenSyncLog_CrtSocialLeadGenEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadGenSyncLog_CrtSocialLeadGenEventsProcess

	public partial class LeadGenSyncLog_CrtSocialLeadGenEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: LeadGenSyncLogEventsProcess

	/// <exclude/>
	public class LeadGenSyncLogEventsProcess : LeadGenSyncLog_CrtSocialLeadGenEventsProcess
	{

		public LeadGenSyncLogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

