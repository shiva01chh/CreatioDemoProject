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

	#region Class: SysModuleActionTypeSchema

	/// <exclude/>
	public class SysModuleActionTypeSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public SysModuleActionTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysModuleActionTypeSchema(SysModuleActionTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysModuleActionTypeSchema(SysModuleActionTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2286fa11-92f8-4c30-9aa7-0d9c20ddb599");
			RealUId = new Guid("2286fa11-92f8-4c30-9aa7-0d9c20ddb599");
			Name = "SysModuleActionType";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
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
			column.ModifiedInSchemaUId = new Guid("2286fa11-92f8-4c30-9aa7-0d9c20ddb599");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("2286fa11-92f8-4c30-9aa7-0d9c20ddb599");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateCodeColumn() {
			EntitySchemaColumn column = base.CreateCodeColumn();
			column.ModifiedInSchemaUId = new Guid("2286fa11-92f8-4c30-9aa7-0d9c20ddb599");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysModuleActionType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysModuleActionType_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysModuleActionTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysModuleActionTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2286fa11-92f8-4c30-9aa7-0d9c20ddb599"));
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleActionType

	/// <summary>
	/// Type of Action in Section.
	/// </summary>
	public class SysModuleActionType : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public SysModuleActionType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysModuleActionType";
		}

		public SysModuleActionType(SysModuleActionType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysModuleActionType_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysModuleActionTypeDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysModuleActionTypeDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysModuleActionTypeInserted", e);
			Inserting += (s, e) => ThrowEvent("SysModuleActionTypeInserting", e);
			Saved += (s, e) => ThrowEvent("SysModuleActionTypeSaved", e);
			Saving += (s, e) => ThrowEvent("SysModuleActionTypeSaving", e);
			Validating += (s, e) => ThrowEvent("SysModuleActionTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleActionType(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleActionType_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysModuleActionType_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_CrtBaseEventsProcess<TEntity> where TEntity : SysModuleActionType
	{

		public SysModuleActionType_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleActionType_CrtBaseEventsProcess";
			SchemaUId = new Guid("2286fa11-92f8-4c30-9aa7-0d9c20ddb599");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2286fa11-92f8-4c30-9aa7-0d9c20ddb599");
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

	#region Class: SysModuleActionType_CrtBaseEventsProcess

	/// <exclude/>
	public class SysModuleActionType_CrtBaseEventsProcess : SysModuleActionType_CrtBaseEventsProcess<SysModuleActionType>
	{

		public SysModuleActionType_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleActionType_CrtBaseEventsProcess

	public partial class SysModuleActionType_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysModuleActionTypeEventsProcess

	/// <exclude/>
	public class SysModuleActionTypeEventsProcess : SysModuleActionType_CrtBaseEventsProcess
	{

		public SysModuleActionTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

