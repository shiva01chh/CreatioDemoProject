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

	#region Class: VwSysPageSchemaInWorkspaceSchema

	/// <exclude/>
	public class VwSysPageSchemaInWorkspaceSchema : Terrasoft.Configuration.VwSysSchemaInWorkspaceSchema
	{

		#region Constructors: Public

		public VwSysPageSchemaInWorkspaceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysPageSchemaInWorkspaceSchema(VwSysPageSchemaInWorkspaceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysPageSchemaInWorkspaceSchema(VwSysPageSchemaInWorkspaceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8d21eaba-8f38-4015-aea0-37204380c093");
			RealUId = new Guid("8d21eaba-8f38-4015-aea0-37204380c093");
			Name = "VwSysPageSchemaInWorkspace";
			ParentSchemaUId = new Guid("4fe60977-c711-48b2-8499-1cebbecf7868");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = true;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
			DesignLocalizationSchemaName = @"VwSysPageInWorkspaceLcz";
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysPageSchemaInWorkspace(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysPageSchemaInWorkspace_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysPageSchemaInWorkspaceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysPageSchemaInWorkspaceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8d21eaba-8f38-4015-aea0-37204380c093"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysPageSchemaInWorkspace

	/// <summary>
	/// Page in workspace (view).
	/// </summary>
	public class VwSysPageSchemaInWorkspace : Terrasoft.Configuration.VwSysSchemaInWorkspace
	{

		#region Constructors: Public

		public VwSysPageSchemaInWorkspace(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysPageSchemaInWorkspace";
		}

		public VwSysPageSchemaInWorkspace(VwSysPageSchemaInWorkspace source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysPageSchemaInWorkspace_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwSysPageSchemaInWorkspaceDeleted", e);
			Deleting += (s, e) => ThrowEvent("VwSysPageSchemaInWorkspaceDeleting", e);
			Inserted += (s, e) => ThrowEvent("VwSysPageSchemaInWorkspaceInserted", e);
			Inserting += (s, e) => ThrowEvent("VwSysPageSchemaInWorkspaceInserting", e);
			Saved += (s, e) => ThrowEvent("VwSysPageSchemaInWorkspaceSaved", e);
			Saving += (s, e) => ThrowEvent("VwSysPageSchemaInWorkspaceSaving", e);
			Validating += (s, e) => ThrowEvent("VwSysPageSchemaInWorkspaceValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysPageSchemaInWorkspace(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysPageSchemaInWorkspace_CrtBaseEventsProcess

	/// <exclude/>
	public partial class VwSysPageSchemaInWorkspace_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.VwSysSchemaInWorkspace_CrtBaseEventsProcess<TEntity> where TEntity : VwSysPageSchemaInWorkspace
	{

		public VwSysPageSchemaInWorkspace_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysPageSchemaInWorkspace_CrtBaseEventsProcess";
			SchemaUId = new Guid("8d21eaba-8f38-4015-aea0-37204380c093");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8d21eaba-8f38-4015-aea0-37204380c093");
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

	#region Class: VwSysPageSchemaInWorkspace_CrtBaseEventsProcess

	/// <exclude/>
	public class VwSysPageSchemaInWorkspace_CrtBaseEventsProcess : VwSysPageSchemaInWorkspace_CrtBaseEventsProcess<VwSysPageSchemaInWorkspace>
	{

		public VwSysPageSchemaInWorkspace_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysPageSchemaInWorkspace_CrtBaseEventsProcess

	public partial class VwSysPageSchemaInWorkspace_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwSysPageSchemaInWorkspaceEventsProcess

	/// <exclude/>
	public class VwSysPageSchemaInWorkspaceEventsProcess : VwSysPageSchemaInWorkspace_CrtBaseEventsProcess
	{

		public VwSysPageSchemaInWorkspaceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

