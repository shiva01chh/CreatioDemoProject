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

	#region Class: SysDcmSettings_CrtBase_TerrasoftSchema

	/// <exclude/>
	public class SysDcmSettings_CrtBase_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysDcmSettings_CrtBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysDcmSettings_CrtBase_TerrasoftSchema(SysDcmSettings_CrtBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysDcmSettings_CrtBase_TerrasoftSchema(SysDcmSettings_CrtBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c");
			RealUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c");
			Name = "SysDcmSettings_CrtBase_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c9089cd6-c7fc-4c89-ae0d-da891132232d");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fa51db91-37a6-4df4-bbcd-8481740c5d8c")) == null) {
				Columns.Add(CreateSysModuleEntityColumn());
			}
			if (Columns.FindByUId(new Guid("beb7f6b2-f338-45ac-80a8-7177238b52a9")) == null) {
				Columns.Add(CreateStageColumnUIdColumn());
			}
			if (Columns.FindByUId(new Guid("42ed2383-1455-49ec-82df-1a184c12a398")) == null) {
				Columns.Add(CreateFiltersColumn());
			}
			if (Columns.FindByUId(new Guid("2bf9d686-2f7e-464b-a049-041c3225dc51")) == null) {
				Columns.Add(CreateDefaultSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("9f9d55c0-0c95-2e4d-3c97-9c1685100f2b")) == null) {
				Columns.Add(CreateSysSchemaUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysModuleEntityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fa51db91-37a6-4df4-bbcd-8481740c5d8c"),
				Name = @"SysModuleEntity",
				ReferenceSchemaUId = new Guid("9c762665-90ad-497b-ac4b-45bb729630a1"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"),
				ModifiedInSchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"),
				CreatedInPackageId = new Guid("c9089cd6-c7fc-4c89-ae0d-da891132232d")
			};
		}

		protected virtual EntitySchemaColumn CreateStageColumnUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("beb7f6b2-f338-45ac-80a8-7177238b52a9"),
				Name = @"StageColumnUId",
				CreatedInSchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"),
				ModifiedInSchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"),
				CreatedInPackageId = new Guid("c9089cd6-c7fc-4c89-ae0d-da891132232d")
			};
		}

		protected virtual EntitySchemaColumn CreateFiltersColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("42ed2383-1455-49ec-82df-1a184c12a398"),
				Name = @"Filters",
				CreatedInSchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"),
				ModifiedInSchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"),
				CreatedInPackageId = new Guid("c9089cd6-c7fc-4c89-ae0d-da891132232d")
			};
		}

		protected virtual EntitySchemaColumn CreateDefaultSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("2bf9d686-2f7e-464b-a049-041c3225dc51"),
				Name = @"DefaultSchemaUId",
				CreatedInSchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"),
				ModifiedInSchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"),
				CreatedInPackageId = new Guid("c9089cd6-c7fc-4c89-ae0d-da891132232d")
			};
		}

		protected virtual EntitySchemaColumn CreateSysSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("9f9d55c0-0c95-2e4d-3c97-9c1685100f2b"),
				Name = @"SysSchemaUId",
				CreatedInSchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"),
				ModifiedInSchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"),
				CreatedInPackageId = new Guid("0ad68bb7-ae4e-4f08-b353-f2785355b74f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysDcmSettings_CrtBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysDcmSettings_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysDcmSettings_CrtBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysDcmSettings_CrtBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c"));
		}

		#endregion

	}

	#endregion

	#region Class: SysDcmSettings_CrtBase_Terrasoft

	/// <summary>
	/// SysDcmSettings.
	/// </summary>
	public class SysDcmSettings_CrtBase_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysDcmSettings_CrtBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysDcmSettings_CrtBase_Terrasoft";
		}

		public SysDcmSettings_CrtBase_Terrasoft(SysDcmSettings_CrtBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysModuleEntityId {
			get {
				return GetTypedColumnValue<Guid>("SysModuleEntityId");
			}
			set {
				SetColumnValue("SysModuleEntityId", value);
				_sysModuleEntity = null;
			}
		}

		private SysModuleEntity _sysModuleEntity;
		/// <summary>
		/// Section object.
		/// </summary>
		public SysModuleEntity SysModuleEntity {
			get {
				return _sysModuleEntity ??
					(_sysModuleEntity = LookupColumnEntities.GetEntity("SysModuleEntity") as SysModuleEntity);
			}
		}

		/// <summary>
		/// Identifier of stage column.
		/// </summary>
		public Guid StageColumnUId {
			get {
				return GetTypedColumnValue<Guid>("StageColumnUId");
			}
			set {
				SetColumnValue("StageColumnUId", value);
			}
		}

		/// <summary>
		/// Filters.
		/// </summary>
		public string Filters {
			get {
				return GetTypedColumnValue<string>("Filters");
			}
			set {
				SetColumnValue("Filters", value);
			}
		}

		/// <summary>
		/// Default case schema.
		/// </summary>
		public Guid DefaultSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("DefaultSchemaUId");
			}
			set {
				SetColumnValue("DefaultSchemaUId", value);
			}
		}

		/// <summary>
		/// Object UId.
		/// </summary>
		public Guid SysSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SysSchemaUId");
			}
			set {
				SetColumnValue("SysSchemaUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysDcmSettings_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysDcmSettings_CrtBase_TerrasoftDeleted", e);
			Validating += (s, e) => ThrowEvent("SysDcmSettings_CrtBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysDcmSettings_CrtBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysDcmSettings_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysDcmSettings_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SysDcmSettings_CrtBase_Terrasoft
	{

		public SysDcmSettings_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysDcmSettings_CrtBaseEventsProcess";
			SchemaUId = new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ee9f7e0e-eab3-45ba-ae0d-67ab41858d5c");
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

	#region Class: SysDcmSettings_CrtBaseEventsProcess

	/// <exclude/>
	public class SysDcmSettings_CrtBaseEventsProcess : SysDcmSettings_CrtBaseEventsProcess<SysDcmSettings_CrtBase_Terrasoft>
	{

		public SysDcmSettings_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysDcmSettings_CrtBaseEventsProcess

	public partial class SysDcmSettings_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

