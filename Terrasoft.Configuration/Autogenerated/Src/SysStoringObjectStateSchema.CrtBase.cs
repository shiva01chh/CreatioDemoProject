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

	#region Class: SysStoringObjectStateSchema

	/// <exclude/>
	public class SysStoringObjectStateSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public SysStoringObjectStateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysStoringObjectStateSchema(SysStoringObjectStateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysStoringObjectStateSchema(SysStoringObjectStateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e4fa976c-9880-4a93-b3ad-50ea19d5d807");
			RealUId = new Guid("e4fa976c-9880-4a93-b3ad-50ea19d5d807");
			Name = "SysStoringObjectState";
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

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.None,
				ValueSource = @""
			};
			column.ModifiedInSchemaUId = new Guid("e4fa976c-9880-4a93-b3ad-50ea19d5d807");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.None,
				ValueSource = @""
			};
			column.ModifiedInSchemaUId = new Guid("e4fa976c-9880-4a93-b3ad-50ea19d5d807");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.None,
				ValueSource = @""
			};
			column.ModifiedInSchemaUId = new Guid("e4fa976c-9880-4a93-b3ad-50ea19d5d807");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.None,
				ValueSource = @""
			};
			column.ModifiedInSchemaUId = new Guid("e4fa976c-9880-4a93-b3ad-50ea19d5d807");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysStoringObjectState(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysStoringObjectState_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysStoringObjectStateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysStoringObjectStateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e4fa976c-9880-4a93-b3ad-50ea19d5d807"));
		}

		#endregion

	}

	#endregion

	#region Class: SysStoringObjectState

	/// <summary>
	/// Object Status.
	/// </summary>
	public class SysStoringObjectState : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public SysStoringObjectState(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysStoringObjectState";
		}

		public SysStoringObjectState(SysStoringObjectState source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysStoringObjectState_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysStoringObjectStateDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysStoringObjectStateDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysStoringObjectStateInserted", e);
			Inserting += (s, e) => ThrowEvent("SysStoringObjectStateInserting", e);
			Saved += (s, e) => ThrowEvent("SysStoringObjectStateSaved", e);
			Saving += (s, e) => ThrowEvent("SysStoringObjectStateSaving", e);
			Validating += (s, e) => ThrowEvent("SysStoringObjectStateValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysStoringObjectState(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysStoringObjectState_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysStoringObjectState_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_CrtBaseEventsProcess<TEntity> where TEntity : SysStoringObjectState
	{

		public SysStoringObjectState_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysStoringObjectState_CrtBaseEventsProcess";
			SchemaUId = new Guid("e4fa976c-9880-4a93-b3ad-50ea19d5d807");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e4fa976c-9880-4a93-b3ad-50ea19d5d807");
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

	#region Class: SysStoringObjectState_CrtBaseEventsProcess

	/// <exclude/>
	public class SysStoringObjectState_CrtBaseEventsProcess : SysStoringObjectState_CrtBaseEventsProcess<SysStoringObjectState>
	{

		public SysStoringObjectState_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysStoringObjectState_CrtBaseEventsProcess

	public partial class SysStoringObjectState_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysStoringObjectStateEventsProcess

	/// <exclude/>
	public class SysStoringObjectStateEventsProcess : SysStoringObjectState_CrtBaseEventsProcess
	{

		public SysStoringObjectStateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

