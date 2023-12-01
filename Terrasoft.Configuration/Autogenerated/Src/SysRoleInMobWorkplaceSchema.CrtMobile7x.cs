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

	#region Class: SysRoleInMobWorkplaceSchema

	/// <exclude/>
	public class SysRoleInMobWorkplaceSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysRoleInMobWorkplaceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysRoleInMobWorkplaceSchema(SysRoleInMobWorkplaceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysRoleInMobWorkplaceSchema(SysRoleInMobWorkplaceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9ae19253-237b-4118-9a52-00457a54cd2c");
			RealUId = new Guid("9ae19253-237b-4118-9a52-00457a54cd2c");
			Name = "SysRoleInMobWorkplace";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c1cb05bd-938c-4278-baef-f070f0a69ab7");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6228e93a-cf49-4f31-b0f6-1451f369561d")) == null) {
				Columns.Add(CreateSysRoleColumn());
			}
			if (Columns.FindByUId(new Guid("f44ceed8-218c-49a0-8148-9fff988ec938")) == null) {
				Columns.Add(CreateSysMobileWorkplaceColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6228e93a-cf49-4f31-b0f6-1451f369561d"),
				Name = @"SysRole",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("9ae19253-237b-4118-9a52-00457a54cd2c"),
				ModifiedInSchemaUId = new Guid("9ae19253-237b-4118-9a52-00457a54cd2c"),
				CreatedInPackageId = new Guid("c1cb05bd-938c-4278-baef-f070f0a69ab7")
			};
		}

		protected virtual EntitySchemaColumn CreateSysMobileWorkplaceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f44ceed8-218c-49a0-8148-9fff988ec938"),
				Name = @"SysMobileWorkplace",
				ReferenceSchemaUId = new Guid("5149a215-3fff-4d7e-ac0e-43816e19cce5"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("9ae19253-237b-4118-9a52-00457a54cd2c"),
				ModifiedInSchemaUId = new Guid("9ae19253-237b-4118-9a52-00457a54cd2c"),
				CreatedInPackageId = new Guid("c1cb05bd-938c-4278-baef-f070f0a69ab7")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysRoleInMobWorkplace(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysRoleInMobWorkplace_CrtMobile7xEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysRoleInMobWorkplaceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysRoleInMobWorkplaceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9ae19253-237b-4118-9a52-00457a54cd2c"));
		}

		#endregion

	}

	#endregion

	#region Class: SysRoleInMobWorkplace

	/// <summary>
	/// Mobile application workplace roles.
	/// </summary>
	public class SysRoleInMobWorkplace : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysRoleInMobWorkplace(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysRoleInMobWorkplace";
		}

		public SysRoleInMobWorkplace(SysRoleInMobWorkplace source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysRoleId {
			get {
				return GetTypedColumnValue<Guid>("SysRoleId");
			}
			set {
				SetColumnValue("SysRoleId", value);
				_sysRole = null;
			}
		}

		/// <exclude/>
		public string SysRoleName {
			get {
				return GetTypedColumnValue<string>("SysRoleName");
			}
			set {
				SetColumnValue("SysRoleName", value);
				if (_sysRole != null) {
					_sysRole.Name = value;
				}
			}
		}

		private SysAdminUnit _sysRole;
		/// <summary>
		/// Role.
		/// </summary>
		public SysAdminUnit SysRole {
			get {
				return _sysRole ??
					(_sysRole = LookupColumnEntities.GetEntity("SysRole") as SysAdminUnit);
			}
		}

		/// <exclude/>
		public Guid SysMobileWorkplaceId {
			get {
				return GetTypedColumnValue<Guid>("SysMobileWorkplaceId");
			}
			set {
				SetColumnValue("SysMobileWorkplaceId", value);
				_sysMobileWorkplace = null;
			}
		}

		/// <exclude/>
		public string SysMobileWorkplaceName {
			get {
				return GetTypedColumnValue<string>("SysMobileWorkplaceName");
			}
			set {
				SetColumnValue("SysMobileWorkplaceName", value);
				if (_sysMobileWorkplace != null) {
					_sysMobileWorkplace.Name = value;
				}
			}
		}

		private SysMobileWorkplace _sysMobileWorkplace;
		/// <summary>
		/// Mobile application workplace.
		/// </summary>
		public SysMobileWorkplace SysMobileWorkplace {
			get {
				return _sysMobileWorkplace ??
					(_sysMobileWorkplace = LookupColumnEntities.GetEntity("SysMobileWorkplace") as SysMobileWorkplace);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysRoleInMobWorkplace_CrtMobile7xEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysRoleInMobWorkplaceDeleted", e);
			Validating += (s, e) => ThrowEvent("SysRoleInMobWorkplaceValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysRoleInMobWorkplace(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysRoleInMobWorkplace_CrtMobile7xEventsProcess

	/// <exclude/>
	public partial class SysRoleInMobWorkplace_CrtMobile7xEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SysRoleInMobWorkplace
	{

		public SysRoleInMobWorkplace_CrtMobile7xEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysRoleInMobWorkplace_CrtMobile7xEventsProcess";
			SchemaUId = new Guid("9ae19253-237b-4118-9a52-00457a54cd2c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9ae19253-237b-4118-9a52-00457a54cd2c");
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

	#region Class: SysRoleInMobWorkplace_CrtMobile7xEventsProcess

	/// <exclude/>
	public class SysRoleInMobWorkplace_CrtMobile7xEventsProcess : SysRoleInMobWorkplace_CrtMobile7xEventsProcess<SysRoleInMobWorkplace>
	{

		public SysRoleInMobWorkplace_CrtMobile7xEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysRoleInMobWorkplace_CrtMobile7xEventsProcess

	public partial class SysRoleInMobWorkplace_CrtMobile7xEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysRoleInMobWorkplaceEventsProcess

	/// <exclude/>
	public class SysRoleInMobWorkplaceEventsProcess : SysRoleInMobWorkplace_CrtMobile7xEventsProcess
	{

		public SysRoleInMobWorkplaceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

