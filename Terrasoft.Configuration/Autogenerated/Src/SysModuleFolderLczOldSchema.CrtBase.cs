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

	#region Class: SysModuleFolderLczOldSchema

	/// <exclude/>
	public class SysModuleFolderLczOldSchema : Terrasoft.Configuration.BaseLczEntitySchema
	{

		#region Constructors: Public

		public SysModuleFolderLczOldSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysModuleFolderLczOldSchema(SysModuleFolderLczOldSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysModuleFolderLczOldSchema(SysModuleFolderLczOldSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4a16bf19-1e23-4978-86d9-0f8a71dd0428");
			RealUId = new Guid("4a16bf19-1e23-4978-86d9-0f8a71dd0428");
			Name = "SysModuleFolderLczOld";
			ParentSchemaUId = new Guid("b7cd8e8f-a017-4f73-b1fe-efb9e938e1d2");
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

		protected override EntitySchemaColumn CreateRecordColumn() {
			EntitySchemaColumn column = base.CreateRecordColumn();
			column.ReferenceSchemaUId = new Guid("88fa8985-5bbd-4975-95b1-51caec10987a");
			column.ColumnValueName = @"RecordId";
			column.DisplayColumnValueName = @"RecordCaption";
			column.ModifiedInSchemaUId = new Guid("4a16bf19-1e23-4978-86d9-0f8a71dd0428");
			return column;
		}

		protected override EntitySchemaColumn CreateColumnUIdColumn() {
			EntitySchemaColumn column = base.CreateColumnUIdColumn();
			column.ModifiedInSchemaUId = new Guid("4a16bf19-1e23-4978-86d9-0f8a71dd0428");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysModuleFolderLczOld(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysModuleFolderLczOld_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysModuleFolderLczOldSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysModuleFolderLczOldSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4a16bf19-1e23-4978-86d9-0f8a71dd0428"));
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleFolderLczOld

	/// <summary>
	/// SysModuleFolder Localization Table.
	/// </summary>
	public class SysModuleFolderLczOld : Terrasoft.Configuration.BaseLczEntity
	{

		#region Constructors: Public

		public SysModuleFolderLczOld(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysModuleFolderLczOld";
		}

		public SysModuleFolderLczOld(SysModuleFolderLczOld source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysModuleFolderLczOld_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysModuleFolderLczOldDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysModuleFolderLczOldInserting", e);
			Validating += (s, e) => ThrowEvent("SysModuleFolderLczOldValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleFolderLczOld(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleFolderLczOld_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysModuleFolderLczOld_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLczEntity_CrtBaseEventsProcess<TEntity> where TEntity : SysModuleFolderLczOld
	{

		public SysModuleFolderLczOld_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleFolderLczOld_CrtBaseEventsProcess";
			SchemaUId = new Guid("4a16bf19-1e23-4978-86d9-0f8a71dd0428");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4a16bf19-1e23-4978-86d9-0f8a71dd0428");
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

	#region Class: SysModuleFolderLczOld_CrtBaseEventsProcess

	/// <exclude/>
	public class SysModuleFolderLczOld_CrtBaseEventsProcess : SysModuleFolderLczOld_CrtBaseEventsProcess<SysModuleFolderLczOld>
	{

		public SysModuleFolderLczOld_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleFolderLczOld_CrtBaseEventsProcess

	public partial class SysModuleFolderLczOld_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysModuleFolderLczOldEventsProcess

	/// <exclude/>
	public class SysModuleFolderLczOldEventsProcess : SysModuleFolderLczOld_CrtBaseEventsProcess
	{

		public SysModuleFolderLczOldEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

