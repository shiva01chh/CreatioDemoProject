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

	#region Class: UsrRealtyClassicFileSchema

	/// <exclude/>
	public class UsrRealtyClassicFileSchema : Terrasoft.Configuration.FileSchema
	{

		#region Constructors: Public

		public UsrRealtyClassicFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrRealtyClassicFileSchema(UsrRealtyClassicFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrRealtyClassicFileSchema(UsrRealtyClassicFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a98b334c-6924-4689-95d2-e6f7e95c92b8");
			RealUId = new Guid("a98b334c-6924-4689-95d2-e6f7e95c92b8");
			Name = "UsrRealtyClassicFile";
			ParentSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("724478a9-7229-449f-ac05-735255981123")) == null) {
				Columns.Add(CreateUsrRealtyClassicColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUsrRealtyClassicColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("724478a9-7229-449f-ac05-735255981123"),
				Name = @"UsrRealtyClassic",
				ReferenceSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("a98b334c-6924-4689-95d2-e6f7e95c92b8"),
				ModifiedInSchemaUId = new Guid("a98b334c-6924-4689-95d2-e6f7e95c92b8"),
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
			return new UsrRealtyClassicFile(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrRealtyClassicFile_GuidedDevEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrRealtyClassicFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrRealtyClassicFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a98b334c-6924-4689-95d2-e6f7e95c92b8"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyClassicFile

	/// <summary>
	/// Realty (Classic UI) attachment.
	/// </summary>
	public class UsrRealtyClassicFile : Terrasoft.Configuration.File
	{

		#region Constructors: Public

		public UsrRealtyClassicFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrRealtyClassicFile";
		}

		public UsrRealtyClassicFile(UsrRealtyClassicFile source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid UsrRealtyClassicId {
			get {
				return GetTypedColumnValue<Guid>("UsrRealtyClassicId");
			}
			set {
				SetColumnValue("UsrRealtyClassicId", value);
				_usrRealtyClassic = null;
			}
		}

		/// <exclude/>
		public string UsrRealtyClassicUsrName {
			get {
				return GetTypedColumnValue<string>("UsrRealtyClassicUsrName");
			}
			set {
				SetColumnValue("UsrRealtyClassicUsrName", value);
				if (_usrRealtyClassic != null) {
					_usrRealtyClassic.UsrName = value;
				}
			}
		}

		private UsrRealtyClassic _usrRealtyClassic;
		/// <summary>
		/// Realty (Classic UI).
		/// </summary>
		public UsrRealtyClassic UsrRealtyClassic {
			get {
				return _usrRealtyClassic ??
					(_usrRealtyClassic = LookupColumnEntities.GetEntity("UsrRealtyClassic") as UsrRealtyClassic);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrRealtyClassicFile_GuidedDevEventsProcess(UserConnection);
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
			return new UsrRealtyClassicFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyClassicFile_GuidedDevEventsProcess

	/// <exclude/>
	public partial class UsrRealtyClassicFile_GuidedDevEventsProcess<TEntity> : Terrasoft.Configuration.File_PRMPortalEventsProcess<TEntity> where TEntity : UsrRealtyClassicFile
	{

		public UsrRealtyClassicFile_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrRealtyClassicFile_GuidedDevEventsProcess";
			SchemaUId = new Guid("a98b334c-6924-4689-95d2-e6f7e95c92b8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a98b334c-6924-4689-95d2-e6f7e95c92b8");
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

	#region Class: UsrRealtyClassicFile_GuidedDevEventsProcess

	/// <exclude/>
	public class UsrRealtyClassicFile_GuidedDevEventsProcess : UsrRealtyClassicFile_GuidedDevEventsProcess<UsrRealtyClassicFile>
	{

		public UsrRealtyClassicFile_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrRealtyClassicFile_GuidedDevEventsProcess

	public partial class UsrRealtyClassicFile_GuidedDevEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrRealtyClassicFileEventsProcess

	/// <exclude/>
	public class UsrRealtyClassicFileEventsProcess : UsrRealtyClassicFile_GuidedDevEventsProcess
	{

		public UsrRealtyClassicFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

