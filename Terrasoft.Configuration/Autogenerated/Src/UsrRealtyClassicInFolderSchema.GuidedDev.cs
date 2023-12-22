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

	#region Class: UsrRealtyClassicInFolderSchema

	/// <exclude/>
	public class UsrRealtyClassicInFolderSchema : Terrasoft.Configuration.BaseItemInFolderSchema
	{

		#region Constructors: Public

		public UsrRealtyClassicInFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrRealtyClassicInFolderSchema(UsrRealtyClassicInFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrRealtyClassicInFolderSchema(UsrRealtyClassicInFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d58dc468-1844-4a08-87b8-5726b699d38d");
			RealUId = new Guid("d58dc468-1844-4a08-87b8-5726b699d38d");
			Name = "UsrRealtyClassicInFolder";
			ParentSchemaUId = new Guid("4f63bafb-e9e7-4082-b92e-66b97c14017c");
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
			if (Columns.FindByUId(new Guid("ad39843f-379e-44ca-a64f-1446a6cb8d7a")) == null) {
				Columns.Add(CreateUsrRealtyClassicColumn());
			}
		}

		protected override EntitySchemaColumn CreateFolderColumn() {
			EntitySchemaColumn column = base.CreateFolderColumn();
			column.ReferenceSchemaUId = new Guid("eba3ce54-7c73-4939-9e83-e41f259e57d2");
			column.ColumnValueName = @"FolderId";
			column.DisplayColumnValueName = @"FolderName";
			column.ModifiedInSchemaUId = new Guid("d58dc468-1844-4a08-87b8-5726b699d38d");
			return column;
		}

		protected virtual EntitySchemaColumn CreateUsrRealtyClassicColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ad39843f-379e-44ca-a64f-1446a6cb8d7a"),
				Name = @"UsrRealtyClassic",
				ReferenceSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("d58dc468-1844-4a08-87b8-5726b699d38d"),
				ModifiedInSchemaUId = new Guid("d58dc468-1844-4a08-87b8-5726b699d38d"),
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
			return new UsrRealtyClassicInFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrRealtyClassicInFolder_GuidedDevEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrRealtyClassicInFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrRealtyClassicInFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d58dc468-1844-4a08-87b8-5726b699d38d"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyClassicInFolder

	/// <summary>
	/// Realty (Classic UI) in Folder.
	/// </summary>
	public class UsrRealtyClassicInFolder : Terrasoft.Configuration.BaseItemInFolder
	{

		#region Constructors: Public

		public UsrRealtyClassicInFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrRealtyClassicInFolder";
		}

		public UsrRealtyClassicInFolder(UsrRealtyClassicInFolder source)
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
			var process = new UsrRealtyClassicInFolder_GuidedDevEventsProcess(UserConnection);
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
			return new UsrRealtyClassicInFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyClassicInFolder_GuidedDevEventsProcess

	/// <exclude/>
	public partial class UsrRealtyClassicInFolder_GuidedDevEventsProcess<TEntity> : Terrasoft.Configuration.BaseItemInFolder_CrtBaseEventsProcess<TEntity> where TEntity : UsrRealtyClassicInFolder
	{

		public UsrRealtyClassicInFolder_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrRealtyClassicInFolder_GuidedDevEventsProcess";
			SchemaUId = new Guid("d58dc468-1844-4a08-87b8-5726b699d38d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d58dc468-1844-4a08-87b8-5726b699d38d");
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

	#region Class: UsrRealtyClassicInFolder_GuidedDevEventsProcess

	/// <exclude/>
	public class UsrRealtyClassicInFolder_GuidedDevEventsProcess : UsrRealtyClassicInFolder_GuidedDevEventsProcess<UsrRealtyClassicInFolder>
	{

		public UsrRealtyClassicInFolder_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrRealtyClassicInFolder_GuidedDevEventsProcess

	public partial class UsrRealtyClassicInFolder_GuidedDevEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrRealtyClassicInFolderEventsProcess

	/// <exclude/>
	public class UsrRealtyClassicInFolderEventsProcess : UsrRealtyClassicInFolder_GuidedDevEventsProcess
	{

		public UsrRealtyClassicInFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

