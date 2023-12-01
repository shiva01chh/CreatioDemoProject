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

	#region Class: SysModuleEditLczOldSchema

	/// <exclude/>
	public class SysModuleEditLczOldSchema : Terrasoft.Configuration.BaseLczEntitySchema
	{

		#region Constructors: Public

		public SysModuleEditLczOldSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysModuleEditLczOldSchema(SysModuleEditLczOldSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysModuleEditLczOldSchema(SysModuleEditLczOldSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			RealUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			Name = "SysModuleEditLczOld";
			ParentSchemaUId = new Guid("b7cd8e8f-a017-4f73-b1fe-efb9e938e1d2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateRecordColumn() {
			EntitySchemaColumn column = base.CreateRecordColumn();
			column.ReferenceSchemaUId = new Guid("24666f2d-049f-4867-ae2c-db681c40c001");
			column.ColumnValueName = @"RecordId";
			column.DisplayColumnValueName = @"RecordPageCaption";
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateColumnUIdColumn() {
			EntitySchemaColumn column = base.CreateColumnUIdColumn();
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateSysCultureColumn() {
			EntitySchemaColumn column = base.CreateSysCultureColumn();
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateValueColumn() {
			EntitySchemaColumn column = base.CreateValueColumn();
			column.ModifiedInSchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysModuleEditLczOld(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysModuleEditLczOld_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysModuleEditLczOldSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysModuleEditLczOldSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f"));
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEditLczOld

	/// <summary>
	/// SysModuleEdit localization table.
	/// </summary>
	public class SysModuleEditLczOld : Terrasoft.Configuration.BaseLczEntity
	{

		#region Constructors: Public

		public SysModuleEditLczOld(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysModuleEditLczOld";
		}

		public SysModuleEditLczOld(SysModuleEditLczOld source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysModuleEditLczOld_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysModuleEditLczOldDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysModuleEditLczOldInserting", e);
			Validating += (s, e) => ThrowEvent("SysModuleEditLczOldValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleEditLczOld(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEditLczOld_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysModuleEditLczOld_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLczEntity_CrtBaseEventsProcess<TEntity> where TEntity : SysModuleEditLczOld
	{

		public SysModuleEditLczOld_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleEditLczOld_CrtBaseEventsProcess";
			SchemaUId = new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6d4d8d3e-1673-483a-a8e0-73b19dbb7d9f");
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

	#region Class: SysModuleEditLczOld_CrtBaseEventsProcess

	/// <exclude/>
	public class SysModuleEditLczOld_CrtBaseEventsProcess : SysModuleEditLczOld_CrtBaseEventsProcess<SysModuleEditLczOld>
	{

		public SysModuleEditLczOld_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleEditLczOld_CrtBaseEventsProcess

	public partial class SysModuleEditLczOld_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysModuleEditLczOldEventsProcess

	/// <exclude/>
	public class SysModuleEditLczOldEventsProcess : SysModuleEditLczOld_CrtBaseEventsProcess
	{

		public SysModuleEditLczOldEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

