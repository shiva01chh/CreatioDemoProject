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
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Web;
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
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Activity_OperatorSingleWindow_TerrasoftSchema

	/// <exclude/>
	public class Activity_OperatorSingleWindow_TerrasoftSchema : Terrasoft.Configuration.Activity_CrtOpportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public Activity_OperatorSingleWindow_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_OperatorSingleWindow_TerrasoftSchema(Activity_OperatorSingleWindow_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_OperatorSingleWindow_TerrasoftSchema(Activity_OperatorSingleWindow_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIMBQHMXCKGjle42hQVBJkGeeQSBAIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("cfe2f65b-f8e3-4b11-a0cd-25fdc94133b8");
			index.Name = "IMBQHMXCKGjle42hQVBJkGeeQSBA";
			index.CreatedInSchemaUId = new Guid("9be065d4-2265-401d-a052-a4af3beb90ba");
			index.ModifiedInSchemaUId = new Guid("9be065d4-2265-401d-a052-a4af3beb90ba");
			index.CreatedInPackageId = new Guid("5e667a77-85ba-48fd-906c-e2f7f26b8e6d");
			EntitySchemaIndexColumn createdOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("149ae115-9ed5-42dc-9fdb-ec2cd31bcc9e"),
				ColumnUId = new Guid("e80190a5-03b2-4095-90f7-a193a960adee"),
				CreatedInSchemaUId = new Guid("9be065d4-2265-401d-a052-a4af3beb90ba"),
				ModifiedInSchemaUId = new Guid("9be065d4-2265-401d-a052-a4af3beb90ba"),
				CreatedInPackageId = new Guid("5e667a77-85ba-48fd-906c-e2f7f26b8e6d"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(createdOnIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("9be065d4-2265-401d-a052-a4af3beb90ba");
			Name = "Activity_OperatorSingleWindow_Terrasoft";
			ParentSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			ExtendParent = true;
			CreatedInPackageId = new Guid("5e667a77-85ba-48fd-906c-e2f7f26b8e6d");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8235b9b7-a369-44f2-98e4-aa7d291da2c9")) == null) {
				Columns.Add(CreateQueueItemColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateQueueItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8235b9b7-a369-44f2-98e4-aa7d291da2c9"),
				Name = @"QueueItem",
				ReferenceSchemaUId = new Guid("aadf2fcd-684b-4414-8317-bf9879e97569"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("9be065d4-2265-401d-a052-a4af3beb90ba"),
				ModifiedInSchemaUId = new Guid("9be065d4-2265-401d-a052-a4af3beb90ba"),
				CreatedInPackageId = new Guid("5e667a77-85ba-48fd-906c-e2f7f26b8e6d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIMBQHMXCKGjle42hQVBJkGeeQSBAIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Activity_OperatorSingleWindow_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Activity_OperatorSingleWindowEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Activity_OperatorSingleWindow_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_OperatorSingleWindow_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9be065d4-2265-401d-a052-a4af3beb90ba"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_OperatorSingleWindow_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_OperatorSingleWindow_Terrasoft : Terrasoft.Configuration.Activity_CrtOpportunity_Terrasoft
	{

		#region Constructors: Public

		public Activity_OperatorSingleWindow_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_OperatorSingleWindow_Terrasoft";
		}

		public Activity_OperatorSingleWindow_Terrasoft(Activity_OperatorSingleWindow_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid QueueItemId {
			get {
				return GetTypedColumnValue<Guid>("QueueItemId");
			}
			set {
				SetColumnValue("QueueItemId", value);
				_queueItem = null;
			}
		}

		/// <exclude/>
		public string QueueItemCaption {
			get {
				return GetTypedColumnValue<string>("QueueItemCaption");
			}
			set {
				SetColumnValue("QueueItemCaption", value);
				if (_queueItem != null) {
					_queueItem.Caption = value;
				}
			}
		}

		private VwQueueItem _queueItem;
		/// <summary>
		/// Queue item.
		/// </summary>
		public VwQueueItem QueueItem {
			get {
				return _queueItem ??
					(_queueItem = LookupColumnEntities.GetEntity("QueueItem") as VwQueueItem);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_OperatorSingleWindowEventsProcess(UserConnection);
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
			return new Activity_OperatorSingleWindow_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_OperatorSingleWindowEventsProcess

	/// <exclude/>
	public partial class Activity_OperatorSingleWindowEventsProcess<TEntity> : Terrasoft.Configuration.Activity_CrtOpportunityEventsProcess<TEntity> where TEntity : Activity_OperatorSingleWindow_Terrasoft
	{

		public Activity_OperatorSingleWindowEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_OperatorSingleWindowEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9be065d4-2265-401d-a052-a4af3beb90ba");
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

	#region Class: Activity_OperatorSingleWindowEventsProcess

	/// <exclude/>
	public class Activity_OperatorSingleWindowEventsProcess : Activity_OperatorSingleWindowEventsProcess<Activity_OperatorSingleWindow_Terrasoft>
	{

		public Activity_OperatorSingleWindowEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Activity_OperatorSingleWindowEventsProcess

	public partial class Activity_OperatorSingleWindowEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

