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

	#region Class: DayOfWeek_CalendarBase_TerrasoftSchema

	/// <exclude/>
	public class DayOfWeek_CalendarBase_TerrasoftSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public DayOfWeek_CalendarBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DayOfWeek_CalendarBase_TerrasoftSchema(DayOfWeek_CalendarBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DayOfWeek_CalendarBase_TerrasoftSchema(DayOfWeek_CalendarBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("95592cd1-f2aa-4d34-a109-aa046cd5bbd5");
			RealUId = new Guid("95592cd1-f2aa-4d34-a109-aa046cd5bbd5");
			Name = "DayOfWeek_CalendarBase_Terrasoft";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6b55da77-5feb-42c3-9e00-d65c9cfab753")) == null) {
				Columns.Add(CreateNumberColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("95592cd1-f2aa-4d34-a109-aa046cd5bbd5");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("95592cd1-f2aa-4d34-a109-aa046cd5bbd5");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("95592cd1-f2aa-4d34-a109-aa046cd5bbd5");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("95592cd1-f2aa-4d34-a109-aa046cd5bbd5");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("95592cd1-f2aa-4d34-a109-aa046cd5bbd5");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("95592cd1-f2aa-4d34-a109-aa046cd5bbd5");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("95592cd1-f2aa-4d34-a109-aa046cd5bbd5");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateCodeColumn() {
			EntitySchemaColumn column = base.CreateCodeColumn();
			column.ModifiedInSchemaUId = new Guid("95592cd1-f2aa-4d34-a109-aa046cd5bbd5");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("95592cd1-f2aa-4d34-a109-aa046cd5bbd5");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("6b55da77-5feb-42c3-9e00-d65c9cfab753"),
				Name = @"Number",
				CreatedInSchemaUId = new Guid("95592cd1-f2aa-4d34-a109-aa046cd5bbd5"),
				ModifiedInSchemaUId = new Guid("95592cd1-f2aa-4d34-a109-aa046cd5bbd5"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DayOfWeek_CalendarBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DayOfWeek_CalendarBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DayOfWeek_CalendarBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DayOfWeek_CalendarBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95592cd1-f2aa-4d34-a109-aa046cd5bbd5"));
		}

		#endregion

	}

	#endregion

	#region Class: DayOfWeek_CalendarBase_Terrasoft

	/// <summary>
	/// Day of the week.
	/// </summary>
	public class DayOfWeek_CalendarBase_Terrasoft : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public DayOfWeek_CalendarBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DayOfWeek_CalendarBase_Terrasoft";
		}

		public DayOfWeek_CalendarBase_Terrasoft(DayOfWeek_CalendarBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Number.
		/// </summary>
		public int Number {
			get {
				return GetTypedColumnValue<int>("Number");
			}
			set {
				SetColumnValue("Number", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DayOfWeek_CalendarBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DayOfWeek_CalendarBase_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("DayOfWeek_CalendarBase_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("DayOfWeek_CalendarBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DayOfWeek_CalendarBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: DayOfWeek_CalendarBaseEventsProcess

	/// <exclude/>
	public partial class DayOfWeek_CalendarBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_CrtBaseEventsProcess<TEntity> where TEntity : DayOfWeek_CalendarBase_Terrasoft
	{

		public DayOfWeek_CalendarBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DayOfWeek_CalendarBaseEventsProcess";
			SchemaUId = new Guid("95592cd1-f2aa-4d34-a109-aa046cd5bbd5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("95592cd1-f2aa-4d34-a109-aa046cd5bbd5");
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

	#region Class: DayOfWeek_CalendarBaseEventsProcess

	/// <exclude/>
	public class DayOfWeek_CalendarBaseEventsProcess : DayOfWeek_CalendarBaseEventsProcess<DayOfWeek_CalendarBase_Terrasoft>
	{

		public DayOfWeek_CalendarBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DayOfWeek_CalendarBaseEventsProcess

	public partial class DayOfWeek_CalendarBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

