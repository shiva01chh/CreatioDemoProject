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

	#region Class: VwSysModuleEntity_CrtBase_TerrasoftSchema

	/// <exclude/>
	public class VwSysModuleEntity_CrtBase_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwSysModuleEntity_CrtBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysModuleEntity_CrtBase_TerrasoftSchema(VwSysModuleEntity_CrtBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysModuleEntity_CrtBase_TerrasoftSchema(VwSysModuleEntity_CrtBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a2d407a1-cda4-4344-ac71-88a4e2bf9c28");
			RealUId = new Guid("a2d407a1-cda4-4344-ac71-88a4e2bf9c28");
			Name = "VwSysModuleEntity_CrtBase_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = true;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("263a6289-c8e3-4d64-a465-569041b923f0")) == null) {
				Columns.Add(CreateImageColumn());
			}
			if (Columns.FindByUId(new Guid("cb53eded-c8d6-4ea6-a788-aaf3705fddad")) == null) {
				Columns.Add(CreateSysWorkspaceColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateImageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Image")) {
				UId = new Guid("263a6289-c8e3-4d64-a465-569041b923f0"),
				Name = @"Image",
				CreatedInSchemaUId = new Guid("a2d407a1-cda4-4344-ac71-88a4e2bf9c28"),
				ModifiedInSchemaUId = new Guid("a2d407a1-cda4-4344-ac71-88a4e2bf9c28"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("5dafe7e6-c53d-478d-9c6e-997f5af8f8c9"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("a2d407a1-cda4-4344-ac71-88a4e2bf9c28"),
				ModifiedInSchemaUId = new Guid("a2d407a1-cda4-4344-ac71-88a4e2bf9c28"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSysWorkspaceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cb53eded-c8d6-4ea6-a788-aaf3705fddad"),
				Name = @"SysWorkspace",
				ReferenceSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a2d407a1-cda4-4344-ac71-88a4e2bf9c28"),
				ModifiedInSchemaUId = new Guid("a2d407a1-cda4-4344-ac71-88a4e2bf9c28"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysModuleEntity_CrtBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysModuleEntity_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysModuleEntity_CrtBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysModuleEntity_CrtBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a2d407a1-cda4-4344-ac71-88a4e2bf9c28"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysModuleEntity_CrtBase_Terrasoft

	/// <summary>
	/// Section object (view).
	/// </summary>
	public class VwSysModuleEntity_CrtBase_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwSysModuleEntity_CrtBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysModuleEntity_CrtBase_Terrasoft";
		}

		public VwSysModuleEntity_CrtBase_Terrasoft(VwSysModuleEntity_CrtBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <exclude/>
		public Guid SysWorkspaceId {
			get {
				return GetTypedColumnValue<Guid>("SysWorkspaceId");
			}
			set {
				SetColumnValue("SysWorkspaceId", value);
				_sysWorkspace = null;
			}
		}

		/// <exclude/>
		public string SysWorkspaceName {
			get {
				return GetTypedColumnValue<string>("SysWorkspaceName");
			}
			set {
				SetColumnValue("SysWorkspaceName", value);
				if (_sysWorkspace != null) {
					_sysWorkspace.Name = value;
				}
			}
		}

		private SysWorkspace _sysWorkspace;
		/// <summary>
		/// User workspace.
		/// </summary>
		public SysWorkspace SysWorkspace {
			get {
				return _sysWorkspace ??
					(_sysWorkspace = LookupColumnEntities.GetEntity("SysWorkspace") as SysWorkspace);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysModuleEntity_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwSysModuleEntity_CrtBase_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("VwSysModuleEntity_CrtBase_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("VwSysModuleEntity_CrtBase_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("VwSysModuleEntity_CrtBase_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("VwSysModuleEntity_CrtBase_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("VwSysModuleEntity_CrtBase_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("VwSysModuleEntity_CrtBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysModuleEntity_CrtBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysModuleEntity_CrtBaseEventsProcess

	/// <exclude/>
	public partial class VwSysModuleEntity_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : VwSysModuleEntity_CrtBase_Terrasoft
	{

		public VwSysModuleEntity_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysModuleEntity_CrtBaseEventsProcess";
			SchemaUId = new Guid("a2d407a1-cda4-4344-ac71-88a4e2bf9c28");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a2d407a1-cda4-4344-ac71-88a4e2bf9c28");
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

	#region Class: VwSysModuleEntity_CrtBaseEventsProcess

	/// <exclude/>
	public class VwSysModuleEntity_CrtBaseEventsProcess : VwSysModuleEntity_CrtBaseEventsProcess<VwSysModuleEntity_CrtBase_Terrasoft>
	{

		public VwSysModuleEntity_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysModuleEntity_CrtBaseEventsProcess

	public partial class VwSysModuleEntity_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

