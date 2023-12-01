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

	#region Class: VwSysClientUnitSchemaInPackageSchema

	/// <exclude/>
	public class VwSysClientUnitSchemaInPackageSchema : Terrasoft.Configuration.VwSysSchemaInPackageSchema
	{

		#region Constructors: Public

		public VwSysClientUnitSchemaInPackageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysClientUnitSchemaInPackageSchema(VwSysClientUnitSchemaInPackageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysClientUnitSchemaInPackageSchema(VwSysClientUnitSchemaInPackageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			RealUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			Name = "VwSysClientUnitSchemaInPackage";
			ParentSchemaUId = new Guid("a594c3c0-91bd-400f-a209-6d38cf0d7548");
			ExtendParent = false;
			CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			IsDBView = true;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1bcba5f4-edae-45ad-a07e-288d3e439755")) == null) {
				Columns.Add(CreateExtendParentColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateUIdColumn() {
			EntitySchemaColumn column = base.CreateUIdColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateCaptionColumn() {
			EntitySchemaColumn column = base.CreateCaptionColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateManagerNameColumn() {
			EntitySchemaColumn column = base.CreateManagerNameColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateParentColumn() {
			EntitySchemaColumn column = base.CreateParentColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateSysWorkspaceColumn() {
			EntitySchemaColumn column = base.CreateSysWorkspaceColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateSysPackageColumn() {
			EntitySchemaColumn column = base.CreateSysPackageColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateSysPackageUIdColumn() {
			EntitySchemaColumn column = base.CreateSysPackageUIdColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected override EntitySchemaColumn CreateSysPackageLevelColumn() {
			EntitySchemaColumn column = base.CreateSysPackageLevelColumn();
			column.ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			column.CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d");
			return column;
		}

		protected virtual EntitySchemaColumn CreateExtendParentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("1bcba5f4-edae-45ad-a07e-288d3e439755"),
				Name = @"ExtendParent",
				CreatedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e"),
				ModifiedInSchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysClientUnitSchemaInPackage(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysClientUnitSchemaInPackage_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysClientUnitSchemaInPackageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysClientUnitSchemaInPackageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysClientUnitSchemaInPackage

	/// <summary>
	/// Custom workspace module in package (view).
	/// </summary>
	public class VwSysClientUnitSchemaInPackage : Terrasoft.Configuration.VwSysSchemaInPackage
	{

		#region Constructors: Public

		public VwSysClientUnitSchemaInPackage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysClientUnitSchemaInPackage";
		}

		public VwSysClientUnitSchemaInPackage(VwSysClientUnitSchemaInPackage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// ExtendParent.
		/// </summary>
		public bool ExtendParent {
			get {
				return GetTypedColumnValue<bool>("ExtendParent");
			}
			set {
				SetColumnValue("ExtendParent", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysClientUnitSchemaInPackage_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwSysClientUnitSchemaInPackageDeleted", e);
			Inserting += (s, e) => ThrowEvent("VwSysClientUnitSchemaInPackageInserting", e);
			Validating += (s, e) => ThrowEvent("VwSysClientUnitSchemaInPackageValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysClientUnitSchemaInPackage(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysClientUnitSchemaInPackage_CrtBaseEventsProcess

	/// <exclude/>
	public partial class VwSysClientUnitSchemaInPackage_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.VwSysSchemaInPackage_CrtBaseEventsProcess<TEntity> where TEntity : VwSysClientUnitSchemaInPackage
	{

		public VwSysClientUnitSchemaInPackage_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysClientUnitSchemaInPackage_CrtBaseEventsProcess";
			SchemaUId = new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7cd84c9d-b12a-47ac-a0da-25337e1f067e");
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

	#region Class: VwSysClientUnitSchemaInPackage_CrtBaseEventsProcess

	/// <exclude/>
	public class VwSysClientUnitSchemaInPackage_CrtBaseEventsProcess : VwSysClientUnitSchemaInPackage_CrtBaseEventsProcess<VwSysClientUnitSchemaInPackage>
	{

		public VwSysClientUnitSchemaInPackage_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysClientUnitSchemaInPackage_CrtBaseEventsProcess

	public partial class VwSysClientUnitSchemaInPackage_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwSysClientUnitSchemaInPackageEventsProcess

	/// <exclude/>
	public class VwSysClientUnitSchemaInPackageEventsProcess : VwSysClientUnitSchemaInPackage_CrtBaseEventsProcess
	{

		public VwSysClientUnitSchemaInPackageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

