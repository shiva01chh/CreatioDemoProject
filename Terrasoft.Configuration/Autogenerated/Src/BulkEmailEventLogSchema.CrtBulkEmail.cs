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

	#region Class: BulkEmailEventLogSchema

	/// <exclude/>
	public class BulkEmailEventLogSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BulkEmailEventLogSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmailEventLogSchema(BulkEmailEventLogSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmailEventLogSchema(BulkEmailEventLogSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3");
			RealUId = new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3");
			Name = "BulkEmailEventLog";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("047a9257-bd59-41e6-8705-ec422d051419");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6cac66b1-8284-4d91-bc98-befbcdce4216")) == null) {
				Columns.Add(CreateEndDateColumn());
			}
			if (Columns.FindByUId(new Guid("9a743808-284f-40cb-b0d8-60e3a6ed4ba7")) == null) {
				Columns.Add(CreateBulkEmailColumn());
			}
			if (Columns.FindByUId(new Guid("78023ca1-e8e7-47b6-af43-25564c3f889c")) == null) {
				Columns.Add(CreateResultColumn());
			}
			if (Columns.FindByUId(new Guid("550e60c3-f7d6-46c1-826b-459e0eef813a")) == null) {
				Columns.Add(CreateDetailedResultColumn());
			}
			if (Columns.FindByUId(new Guid("5dcf0335-07de-4e52-a868-f12c81ff38eb")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("e5bccda7-6257-4094-0d4e-a0c4af0be02c")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("ed69691b-9afb-3b89-f28f-0d753691280f")) == null) {
				Columns.Add(CreateNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEndDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("6cac66b1-8284-4d91-bc98-befbcdce4216"),
				Name = @"EndDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3"),
				ModifiedInSchemaUId = new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3"),
				CreatedInPackageId = new Guid("047a9257-bd59-41e6-8705-ec422d051419"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateBulkEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9a743808-284f-40cb-b0d8-60e3a6ed4ba7"),
				Name = @"BulkEmail",
				ReferenceSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3"),
				ModifiedInSchemaUId = new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3"),
				CreatedInPackageId = new Guid("047a9257-bd59-41e6-8705-ec422d051419")
			};
		}

		protected virtual EntitySchemaColumn CreateResultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("78023ca1-e8e7-47b6-af43-25564c3f889c"),
				Name = @"Result",
				ReferenceSchemaUId = new Guid("278b8de5-eb1e-4b54-9a1d-c32ae35e033f"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3"),
				ModifiedInSchemaUId = new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3"),
				CreatedInPackageId = new Guid("46753b0a-c766-4331-8bea-51b5327e67bb")
			};
		}

		protected virtual EntitySchemaColumn CreateDetailedResultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("550e60c3-f7d6-46c1-826b-459e0eef813a"),
				Name = @"DetailedResult",
				CreatedInSchemaUId = new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3"),
				ModifiedInSchemaUId = new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3"),
				CreatedInPackageId = new Guid("46753b0a-c766-4331-8bea-51b5327e67bb")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("5dcf0335-07de-4e52-a868-f12c81ff38eb"),
				Name = @"StartDate",
				CreatedInSchemaUId = new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3"),
				ModifiedInSchemaUId = new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("e5bccda7-6257-4094-0d4e-a0c4af0be02c"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3"),
				ModifiedInSchemaUId = new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3"),
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("ed69691b-9afb-3b89-f28f-0d753691280f"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3"),
				ModifiedInSchemaUId = new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3"),
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BulkEmailEventLog(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BulkEmailEventLog_CrtBulkEmailEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BulkEmailEventLogSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmailEventLogSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailEventLog

	/// <summary>
	/// Mailing log.
	/// </summary>
	public class BulkEmailEventLog : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BulkEmailEventLog(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmailEventLog";
		}

		public BulkEmailEventLog(BulkEmailEventLog source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
		public Guid BulkEmailId {
			get {
				return GetTypedColumnValue<Guid>("BulkEmailId");
			}
			set {
				SetColumnValue("BulkEmailId", value);
				_bulkEmail = null;
			}
		}

		/// <exclude/>
		public string BulkEmailName {
			get {
				return GetTypedColumnValue<string>("BulkEmailName");
			}
			set {
				SetColumnValue("BulkEmailName", value);
				if (_bulkEmail != null) {
					_bulkEmail.Name = value;
				}
			}
		}

		private BulkEmail _bulkEmail;
		/// <summary>
		/// Email.
		/// </summary>
		public BulkEmail BulkEmail {
			get {
				return _bulkEmail ??
					(_bulkEmail = LookupColumnEntities.GetEntity("BulkEmail") as BulkEmail);
			}
		}

		/// <exclude/>
		public Guid ResultId {
			get {
				return GetTypedColumnValue<Guid>("ResultId");
			}
			set {
				SetColumnValue("ResultId", value);
				_result = null;
			}
		}

		/// <exclude/>
		public string ResultName {
			get {
				return GetTypedColumnValue<string>("ResultName");
			}
			set {
				SetColumnValue("ResultName", value);
				if (_result != null) {
					_result.Name = value;
				}
			}
		}

		private BulkEmailEventResult _result;
		/// <summary>
		/// Type.
		/// </summary>
		public BulkEmailEventResult Result {
			get {
				return _result ??
					(_result = LookupColumnEntities.GetEntity("Result") as BulkEmailEventResult);
			}
		}

		/// <summary>
		/// Error description.
		/// </summary>
		public string DetailedResult {
			get {
				return GetTypedColumnValue<string>("DetailedResult");
			}
			set {
				SetColumnValue("DetailedResult", value);
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
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		/// <summary>
		/// Event.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmailEventLog_CrtBulkEmailEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BulkEmailEventLogDeleted", e);
			Validating += (s, e) => ThrowEvent("BulkEmailEventLogValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BulkEmailEventLog(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailEventLog_CrtBulkEmailEventsProcess

	/// <exclude/>
	public partial class BulkEmailEventLog_CrtBulkEmailEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : BulkEmailEventLog
	{

		public BulkEmailEventLog_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmailEventLog_CrtBulkEmailEventsProcess";
			SchemaUId = new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("75c7af7f-450f-4d87-b7b4-d22b5f4849b3");
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

	#region Class: BulkEmailEventLog_CrtBulkEmailEventsProcess

	/// <exclude/>
	public class BulkEmailEventLog_CrtBulkEmailEventsProcess : BulkEmailEventLog_CrtBulkEmailEventsProcess<BulkEmailEventLog>
	{

		public BulkEmailEventLog_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmailEventLog_CrtBulkEmailEventsProcess

	public partial class BulkEmailEventLog_CrtBulkEmailEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BulkEmailEventLogEventsProcess

	/// <exclude/>
	public class BulkEmailEventLogEventsProcess : BulkEmailEventLog_CrtBulkEmailEventsProcess
	{

		public BulkEmailEventLogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

