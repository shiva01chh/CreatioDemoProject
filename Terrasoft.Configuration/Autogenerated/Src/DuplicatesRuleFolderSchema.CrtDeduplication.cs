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

	#region Class: DuplicatesRuleFolderSchema

	/// <exclude/>
	public class DuplicatesRuleFolderSchema : Terrasoft.Configuration.BaseFolderSchema
	{

		#region Constructors: Public

		public DuplicatesRuleFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DuplicatesRuleFolderSchema(DuplicatesRuleFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DuplicatesRuleFolderSchema(DuplicatesRuleFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("470793e7-c562-479e-ba33-d6c22808c8d2");
			RealUId = new Guid("470793e7-c562-479e-ba33-d6c22808c8d2");
			Name = "DuplicatesRuleFolder";
			ParentSchemaUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5");
			ExtendParent = false;
			CreatedInPackageId = new Guid("642e1b93-32fe-4cca-aefe-e71452bbfc69");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateParentColumn() {
			EntitySchemaColumn column = base.CreateParentColumn();
			column.ReferenceSchemaUId = new Guid("470793e7-c562-479e-ba33-d6c22808c8d2");
			column.ColumnValueName = @"ParentId";
			column.DisplayColumnValueName = @"ParentName";
			column.ModifiedInSchemaUId = new Guid("470793e7-c562-479e-ba33-d6c22808c8d2");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DuplicatesRuleFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DuplicatesRuleFolder_CrtDeduplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DuplicatesRuleFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DuplicatesRuleFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("470793e7-c562-479e-ba33-d6c22808c8d2"));
		}

		#endregion

	}

	#endregion

	#region Class: DuplicatesRuleFolder

	/// <summary>
	/// "Duplicates rule" section folder.
	/// </summary>
	public class DuplicatesRuleFolder : Terrasoft.Configuration.BaseFolder
	{

		#region Constructors: Public

		public DuplicatesRuleFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DuplicatesRuleFolder";
		}

		public DuplicatesRuleFolder(DuplicatesRuleFolder source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ParentId {
			get {
				return GetTypedColumnValue<Guid>("ParentId");
			}
			set {
				SetColumnValue("ParentId", value);
				_parent = null;
			}
		}

		/// <exclude/>
		public string ParentName {
			get {
				return GetTypedColumnValue<string>("ParentName");
			}
			set {
				SetColumnValue("ParentName", value);
				if (_parent != null) {
					_parent.Name = value;
				}
			}
		}

		private DuplicatesRuleFolder _parent;
		/// <summary>
		/// Parent.
		/// </summary>
		public DuplicatesRuleFolder Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as DuplicatesRuleFolder);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DuplicatesRuleFolder_CrtDeduplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DuplicatesRuleFolderDeleted", e);
			Validating += (s, e) => ThrowEvent("DuplicatesRuleFolderValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DuplicatesRuleFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: DuplicatesRuleFolder_CrtDeduplicationEventsProcess

	/// <exclude/>
	public partial class DuplicatesRuleFolder_CrtDeduplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseFolder_CrtBaseEventsProcess<TEntity> where TEntity : DuplicatesRuleFolder
	{

		public DuplicatesRuleFolder_CrtDeduplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DuplicatesRuleFolder_CrtDeduplicationEventsProcess";
			SchemaUId = new Guid("470793e7-c562-479e-ba33-d6c22808c8d2");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("470793e7-c562-479e-ba33-d6c22808c8d2");
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

	#region Class: DuplicatesRuleFolder_CrtDeduplicationEventsProcess

	/// <exclude/>
	public class DuplicatesRuleFolder_CrtDeduplicationEventsProcess : DuplicatesRuleFolder_CrtDeduplicationEventsProcess<DuplicatesRuleFolder>
	{

		public DuplicatesRuleFolder_CrtDeduplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DuplicatesRuleFolder_CrtDeduplicationEventsProcess

	public partial class DuplicatesRuleFolder_CrtDeduplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: DuplicatesRuleFolderEventsProcess

	/// <exclude/>
	public class DuplicatesRuleFolderEventsProcess : DuplicatesRuleFolder_CrtDeduplicationEventsProcess
	{

		public DuplicatesRuleFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

