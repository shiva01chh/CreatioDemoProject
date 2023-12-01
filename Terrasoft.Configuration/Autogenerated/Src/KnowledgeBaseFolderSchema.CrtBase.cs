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

	#region Class: KnowledgeBaseFolderSchema

	/// <exclude/>
	public class KnowledgeBaseFolderSchema : Terrasoft.Configuration.BaseFolderSchema
	{

		#region Constructors: Public

		public KnowledgeBaseFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public KnowledgeBaseFolderSchema(KnowledgeBaseFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public KnowledgeBaseFolderSchema(KnowledgeBaseFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("54157b05-88d4-46c0-aa54-effc7c79cb86");
			RealUId = new Guid("54157b05-88d4-46c0-aa54-effc7c79cb86");
			Name = "KnowledgeBaseFolder";
			ParentSchemaUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5");
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
			column.ModifiedInSchemaUId = new Guid("54157b05-88d4-46c0-aa54-effc7c79cb86");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("54157b05-88d4-46c0-aa54-effc7c79cb86");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateParentColumn() {
			EntitySchemaColumn column = base.CreateParentColumn();
			column.ReferenceSchemaUId = new Guid("54157b05-88d4-46c0-aa54-effc7c79cb86");
			column.ColumnValueName = @"ParentId";
			column.DisplayColumnValueName = @"ParentName";
			column.ModifiedInSchemaUId = new Guid("54157b05-88d4-46c0-aa54-effc7c79cb86");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateFolderTypeColumn() {
			EntitySchemaColumn column = base.CreateFolderTypeColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"9dc5f6e6-2a61-4de8-a059-de30f4e74f24"
			};
			column.ModifiedInSchemaUId = new Guid("54157b05-88d4-46c0-aa54-effc7c79cb86");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateSearchDataColumn() {
			EntitySchemaColumn column = base.CreateSearchDataColumn();
			column.ModifiedInSchemaUId = new Guid("54157b05-88d4-46c0-aa54-effc7c79cb86");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new KnowledgeBaseFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new KnowledgeBaseFolder_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new KnowledgeBaseFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new KnowledgeBaseFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("54157b05-88d4-46c0-aa54-effc7c79cb86"));
		}

		#endregion

	}

	#endregion

	#region Class: KnowledgeBaseFolder

	/// <summary>
	/// Knowledge base folder.
	/// </summary>
	public class KnowledgeBaseFolder : Terrasoft.Configuration.BaseFolder
	{

		#region Constructors: Public

		public KnowledgeBaseFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "KnowledgeBaseFolder";
		}

		public KnowledgeBaseFolder(KnowledgeBaseFolder source)
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

		private KnowledgeBaseFolder _parent;
		/// <summary>
		/// Parent.
		/// </summary>
		public KnowledgeBaseFolder Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as KnowledgeBaseFolder);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new KnowledgeBaseFolder_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("KnowledgeBaseFolderDeleted", e);
			Deleting += (s, e) => ThrowEvent("KnowledgeBaseFolderDeleting", e);
			Inserted += (s, e) => ThrowEvent("KnowledgeBaseFolderInserted", e);
			Inserting += (s, e) => ThrowEvent("KnowledgeBaseFolderInserting", e);
			Saved += (s, e) => ThrowEvent("KnowledgeBaseFolderSaved", e);
			Saving += (s, e) => ThrowEvent("KnowledgeBaseFolderSaving", e);
			Validating += (s, e) => ThrowEvent("KnowledgeBaseFolderValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new KnowledgeBaseFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: KnowledgeBaseFolder_CrtBaseEventsProcess

	/// <exclude/>
	public partial class KnowledgeBaseFolder_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseFolder_CrtBaseEventsProcess<TEntity> where TEntity : KnowledgeBaseFolder
	{

		public KnowledgeBaseFolder_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "KnowledgeBaseFolder_CrtBaseEventsProcess";
			SchemaUId = new Guid("54157b05-88d4-46c0-aa54-effc7c79cb86");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("54157b05-88d4-46c0-aa54-effc7c79cb86");
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

	#region Class: KnowledgeBaseFolder_CrtBaseEventsProcess

	/// <exclude/>
	public class KnowledgeBaseFolder_CrtBaseEventsProcess : KnowledgeBaseFolder_CrtBaseEventsProcess<KnowledgeBaseFolder>
	{

		public KnowledgeBaseFolder_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: KnowledgeBaseFolder_CrtBaseEventsProcess

	public partial class KnowledgeBaseFolder_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void CheckCanManageLookups() {
			return;
		}

		#endregion

	}

	#endregion


	#region Class: KnowledgeBaseFolderEventsProcess

	/// <exclude/>
	public class KnowledgeBaseFolderEventsProcess : KnowledgeBaseFolder_CrtBaseEventsProcess
	{

		public KnowledgeBaseFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

