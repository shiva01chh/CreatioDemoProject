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

	#region Class: UsrVwContactAgeDaysSchema

	/// <exclude/>
	public class UsrVwContactAgeDaysSchema : Terrasoft.Core.Entities.EntitySchema
	{

		#region Constructors: Public

		public UsrVwContactAgeDaysSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrVwContactAgeDaysSchema(UsrVwContactAgeDaysSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrVwContactAgeDaysSchema(UsrVwContactAgeDaysSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a024b02d-289f-40f9-94c1-4a1b2bf8287b");
			RealUId = new Guid("a024b02d-289f-40f9-94c1-4a1b2bf8287b");
			Name = "UsrVwContactAgeDays";
			ParentSchemaUId = new Guid("1b56b061-4e91-4974-9038-df8340e534f2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111");
			IsDBView = true;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColumn() {
			base.InitializePrimaryColumn();
			PrimaryColumn = CreateUsrIdColumn();
			if (Columns.FindByUId(PrimaryColumn.UId) == null) {
				Columns.Add(PrimaryColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("4146a47b-8e7f-f6d3-c9cb-7f339c3eee2c")) == null) {
				Columns.Add(CreateUsrAgeDateColumn());
			}
			if (Columns.FindByUId(new Guid("4fca4519-bf54-56ca-bb52-33e23a0bf90b")) == null) {
				Columns.Add(CreateUsrBirthDateColumn());
			}
			if (Columns.FindByUId(new Guid("093a4397-0d06-7fea-f09e-10571db14610")) == null) {
				Columns.Add(CreateUsrNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUsrAgeDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("4146a47b-8e7f-f6d3-c9cb-7f339c3eee2c"),
				Name = @"UsrAgeDate",
				CreatedInSchemaUId = new Guid("a024b02d-289f-40f9-94c1-4a1b2bf8287b"),
				ModifiedInSchemaUId = new Guid("a024b02d-289f-40f9-94c1-4a1b2bf8287b"),
				CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrBirthDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("4fca4519-bf54-56ca-bb52-33e23a0bf90b"),
				Name = @"UsrBirthDate",
				CreatedInSchemaUId = new Guid("a024b02d-289f-40f9-94c1-4a1b2bf8287b"),
				ModifiedInSchemaUId = new Guid("a024b02d-289f-40f9-94c1-4a1b2bf8287b"),
				CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("093a4397-0d06-7fea-f09e-10571db14610"),
				Name = @"UsrName",
				CreatedInSchemaUId = new Guid("a024b02d-289f-40f9-94c1-4a1b2bf8287b"),
				ModifiedInSchemaUId = new Guid("a024b02d-289f-40f9-94c1-4a1b2bf8287b"),
				CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("be43d9d5-294b-efdf-338e-96c7769b0ddc"),
				Name = @"UsrId",
				CreatedInSchemaUId = new Guid("a024b02d-289f-40f9-94c1-4a1b2bf8287b"),
				ModifiedInSchemaUId = new Guid("a024b02d-289f-40f9-94c1-4a1b2bf8287b"),
				CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new UsrVwContactAgeDays(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrVwContactAgeDays_GuidedDevEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrVwContactAgeDaysSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrVwContactAgeDaysSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a024b02d-289f-40f9-94c1-4a1b2bf8287b"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrVwContactAgeDays

	/// <summary>
	/// UsrVwContactAgeDays.
	/// </summary>
	public class UsrVwContactAgeDays : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public UsrVwContactAgeDays(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrVwContactAgeDays";
		}

		public UsrVwContactAgeDays(UsrVwContactAgeDays source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Age in days.
		/// </summary>
		public int UsrAgeDate {
			get {
				return GetTypedColumnValue<int>("UsrAgeDate");
			}
			set {
				SetColumnValue("UsrAgeDate", value);
			}
		}

		/// <summary>
		/// Birth date.
		/// </summary>
		public DateTime UsrBirthDate {
			get {
				return GetTypedColumnValue<DateTime>("UsrBirthDate");
			}
			set {
				SetColumnValue("UsrBirthDate", value);
			}
		}

		/// <summary>
		/// Name.
		/// </summary>
		public string UsrName {
			get {
				return GetTypedColumnValue<string>("UsrName");
			}
			set {
				SetColumnValue("UsrName", value);
			}
		}

		/// <summary>
		/// Id.
		/// </summary>
		public Guid UsrId {
			get {
				return GetTypedColumnValue<Guid>("UsrId");
			}
			set {
				SetColumnValue("UsrId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrVwContactAgeDays_GuidedDevEventsProcess(UserConnection);
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
			return new UsrVwContactAgeDays(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrVwContactAgeDays_GuidedDevEventsProcess

	/// <exclude/>
	public partial class UsrVwContactAgeDays_GuidedDevEventsProcess<TEntity> : Terrasoft.Core.Process.EmbeddedProcess where TEntity : UsrVwContactAgeDays
	{

		private TEntity _entity;
		public TEntity Entity {
			get {
				return _entity;
			}
			set {
				_entity = value;
			}
		}

		public UsrVwContactAgeDays_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrVwContactAgeDays_GuidedDevEventsProcess";
			SchemaUId = new Guid("a024b02d-289f-40f9-94c1-4a1b2bf8287b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a024b02d-289f-40f9-94c1-4a1b2bf8287b");
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

	#region Class: UsrVwContactAgeDays_GuidedDevEventsProcess

	/// <exclude/>
	public class UsrVwContactAgeDays_GuidedDevEventsProcess : UsrVwContactAgeDays_GuidedDevEventsProcess<UsrVwContactAgeDays>
	{

		public UsrVwContactAgeDays_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrVwContactAgeDays_GuidedDevEventsProcess

	public partial class UsrVwContactAgeDays_GuidedDevEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrVwContactAgeDaysEventsProcess

	/// <exclude/>
	public class UsrVwContactAgeDaysEventsProcess : UsrVwContactAgeDays_GuidedDevEventsProcess
	{

		public UsrVwContactAgeDaysEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

