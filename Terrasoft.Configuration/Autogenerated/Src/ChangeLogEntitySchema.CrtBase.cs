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

	#region Class: ChangeLogEntitySchema

	/// <exclude/>
	public class ChangeLogEntitySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ChangeLogEntitySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ChangeLogEntitySchema(ChangeLogEntitySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ChangeLogEntitySchema(ChangeLogEntitySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("62db7a92-030f-4fd5-8402-911554830f9d");
			RealUId = new Guid("62db7a92-030f-4fd5-8402-911554830f9d");
			Name = "ChangeLogEntity";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
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
			if (Columns.FindByUId(new Guid("25684e6e-383d-4da3-b493-88b33e29f9d7")) == null) {
				Columns.Add(CreateNameColumn());
			}
			if (Columns.FindByUId(new Guid("472b5c93-9dcb-4b97-ac6b-514b59e831dd")) == null) {
				Columns.Add(CreateOperationColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("25684e6e-383d-4da3-b493-88b33e29f9d7"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("62db7a92-030f-4fd5-8402-911554830f9d"),
				ModifiedInSchemaUId = new Guid("62db7a92-030f-4fd5-8402-911554830f9d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateOperationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("472b5c93-9dcb-4b97-ac6b-514b59e831dd"),
				Name = @"Operation",
				CreatedInSchemaUId = new Guid("62db7a92-030f-4fd5-8402-911554830f9d"),
				ModifiedInSchemaUId = new Guid("62db7a92-030f-4fd5-8402-911554830f9d"),
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
			return new ChangeLogEntity(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ChangeLogEntity_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ChangeLogEntitySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ChangeLogEntitySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("62db7a92-030f-4fd5-8402-911554830f9d"));
		}

		#endregion

	}

	#endregion

	#region Class: ChangeLogEntity

	/// <summary>
	/// Change log object.
	/// </summary>
	public class ChangeLogEntity : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ChangeLogEntity(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ChangeLogEntity";
		}

		public ChangeLogEntity(ChangeLogEntity source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Title.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <summary>
		/// Operation.
		/// </summary>
		public string Operation {
			get {
				return GetTypedColumnValue<string>("Operation");
			}
			set {
				SetColumnValue("Operation", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ChangeLogEntity_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ChangeLogEntityDeleted", e);
			Deleting += (s, e) => ThrowEvent("ChangeLogEntityDeleting", e);
			Inserted += (s, e) => ThrowEvent("ChangeLogEntityInserted", e);
			Inserting += (s, e) => ThrowEvent("ChangeLogEntityInserting", e);
			Saving += (s, e) => ThrowEvent("ChangeLogEntitySaving", e);
			Validating += (s, e) => ThrowEvent("ChangeLogEntityValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ChangeLogEntity(this);
		}

		#endregion

	}

	#endregion

	#region Class: ChangeLogEntity_CrtBaseEventsProcess

	/// <exclude/>
	public partial class ChangeLogEntity_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ChangeLogEntity
	{

		public ChangeLogEntity_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ChangeLogEntity_CrtBaseEventsProcess";
			SchemaUId = new Guid("62db7a92-030f-4fd5-8402-911554830f9d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("62db7a92-030f-4fd5-8402-911554830f9d");
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

	#region Class: ChangeLogEntity_CrtBaseEventsProcess

	/// <exclude/>
	public class ChangeLogEntity_CrtBaseEventsProcess : ChangeLogEntity_CrtBaseEventsProcess<ChangeLogEntity>
	{

		public ChangeLogEntity_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ChangeLogEntity_CrtBaseEventsProcess

	public partial class ChangeLogEntity_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ChangeLogEntityEventsProcess

	/// <exclude/>
	public class ChangeLogEntityEventsProcess : ChangeLogEntity_CrtBaseEventsProcess
	{

		public ChangeLogEntityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

