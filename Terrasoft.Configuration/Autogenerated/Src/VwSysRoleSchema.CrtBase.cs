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

	#region Class: VwSysRoleSchema

	/// <exclude/>
	public class VwSysRoleSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public VwSysRoleSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysRoleSchema(VwSysRoleSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysRoleSchema(VwSysRoleSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1f424900-3d1a-4ffe-badd-a76e62ed952b");
			RealUId = new Guid("1f424900-3d1a-4ffe-badd-a76e62ed952b");
			Name = "VwSysRole";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("007e35de-a16f-46c9-8e07-22ead3f1a8d9");
			IsDBView = true;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("1f424900-3d1a-4ffe-badd-a76e62ed952b");
			column.IsLocalizable = false;
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("1f424900-3d1a-4ffe-badd-a76e62ed952b");
			column.IsLocalizable = false;
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysRole(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysRole_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysRoleSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysRoleSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1f424900-3d1a-4ffe-badd-a76e62ed952b"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysRole

	/// <summary>
	/// Roles (view).
	/// </summary>
	public class VwSysRole : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public VwSysRole(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysRole";
		}

		public VwSysRole(VwSysRole source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysRole_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwSysRoleDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysRole(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysRole_CrtBaseEventsProcess

	/// <exclude/>
	public partial class VwSysRole_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : VwSysRole
	{

		public VwSysRole_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysRole_CrtBaseEventsProcess";
			SchemaUId = new Guid("1f424900-3d1a-4ffe-badd-a76e62ed952b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1f424900-3d1a-4ffe-badd-a76e62ed952b");
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

	#region Class: VwSysRole_CrtBaseEventsProcess

	/// <exclude/>
	public class VwSysRole_CrtBaseEventsProcess : VwSysRole_CrtBaseEventsProcess<VwSysRole>
	{

		public VwSysRole_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysRole_CrtBaseEventsProcess

	public partial class VwSysRole_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwSysRoleEventsProcess

	/// <exclude/>
	public class VwSysRoleEventsProcess : VwSysRole_CrtBaseEventsProcess
	{

		public VwSysRoleEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

