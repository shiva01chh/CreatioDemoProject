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

	#region Class: UsrRealtyClassicFolderSchema

	/// <exclude/>
	public class UsrRealtyClassicFolderSchema : Terrasoft.Configuration.BaseFolderSchema
	{

		#region Constructors: Public

		public UsrRealtyClassicFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrRealtyClassicFolderSchema(UsrRealtyClassicFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrRealtyClassicFolderSchema(UsrRealtyClassicFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eba3ce54-7c73-4939-9e83-e41f259e57d2");
			RealUId = new Guid("eba3ce54-7c73-4939-9e83-e41f259e57d2");
			Name = "UsrRealtyClassicFolder";
			ParentSchemaUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5");
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
		}

		protected override EntitySchemaColumn CreateParentColumn() {
			EntitySchemaColumn column = base.CreateParentColumn();
			column.ReferenceSchemaUId = new Guid("eba3ce54-7c73-4939-9e83-e41f259e57d2");
			column.ColumnValueName = @"ParentId";
			column.DisplayColumnValueName = @"ParentName";
			column.ModifiedInSchemaUId = new Guid("eba3ce54-7c73-4939-9e83-e41f259e57d2");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new UsrRealtyClassicFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrRealtyClassicFolder_GuidedDevEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrRealtyClassicFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrRealtyClassicFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eba3ce54-7c73-4939-9e83-e41f259e57d2"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyClassicFolder

	/// <summary>
	/// Realty (Classic UI) folder.
	/// </summary>
	public class UsrRealtyClassicFolder : Terrasoft.Configuration.BaseFolder
	{

		#region Constructors: Public

		public UsrRealtyClassicFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrRealtyClassicFolder";
		}

		public UsrRealtyClassicFolder(UsrRealtyClassicFolder source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ParentId {
			get {
				return GetTypedColumnValue<Guid>("ParentId");
			}
			set {
				SetColumnValue("ParentId", value);
				_parent = null;
			}
		}

		/// <exclude/>
		public string ParentName {
			get {
				return GetTypedColumnValue<string>("ParentName");
			}
			set {
				SetColumnValue("ParentName", value);
				if (_parent != null) {
					_parent.Name = value;
				}
			}
		}

		private UsrRealtyClassicFolder _parent;
		/// <summary>
		/// Parent.
		/// </summary>
		public UsrRealtyClassicFolder Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as UsrRealtyClassicFolder);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrRealtyClassicFolder_GuidedDevEventsProcess(UserConnection);
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
			return new UsrRealtyClassicFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyClassicFolder_GuidedDevEventsProcess

	/// <exclude/>
	public partial class UsrRealtyClassicFolder_GuidedDevEventsProcess<TEntity> : Terrasoft.Configuration.BaseFolder_CrtBaseEventsProcess<TEntity> where TEntity : UsrRealtyClassicFolder
	{

		public UsrRealtyClassicFolder_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrRealtyClassicFolder_GuidedDevEventsProcess";
			SchemaUId = new Guid("eba3ce54-7c73-4939-9e83-e41f259e57d2");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("eba3ce54-7c73-4939-9e83-e41f259e57d2");
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

	#region Class: UsrRealtyClassicFolder_GuidedDevEventsProcess

	/// <exclude/>
	public class UsrRealtyClassicFolder_GuidedDevEventsProcess : UsrRealtyClassicFolder_GuidedDevEventsProcess<UsrRealtyClassicFolder>
	{

		public UsrRealtyClassicFolder_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrRealtyClassicFolder_GuidedDevEventsProcess

	public partial class UsrRealtyClassicFolder_GuidedDevEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrRealtyClassicFolderEventsProcess

	/// <exclude/>
	public class UsrRealtyClassicFolderEventsProcess : UsrRealtyClassicFolder_GuidedDevEventsProcess
	{

		public UsrRealtyClassicFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

