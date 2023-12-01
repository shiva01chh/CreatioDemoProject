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

	#region Class: BulkEmailSplitInFolderSchema

	/// <exclude/>
	public class BulkEmailSplitInFolderSchema : Terrasoft.Configuration.BaseItemInFolderSchema
	{

		#region Constructors: Public

		public BulkEmailSplitInFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmailSplitInFolderSchema(BulkEmailSplitInFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmailSplitInFolderSchema(BulkEmailSplitInFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("021b4368-fae5-47c4-a2fa-b84fc4df6b3e");
			RealUId = new Guid("021b4368-fae5-47c4-a2fa-b84fc4df6b3e");
			Name = "BulkEmailSplitInFolder";
			ParentSchemaUId = new Guid("4f63bafb-e9e7-4082-b92e-66b97c14017c");
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
			if (Columns.FindByUId(new Guid("803614f5-f9da-4e86-9623-3018fe12a96f")) == null) {
				Columns.Add(CreateBulkEmailSplitColumn());
			}
		}

		protected override EntitySchemaColumn CreateFolderColumn() {
			EntitySchemaColumn column = base.CreateFolderColumn();
			column.ReferenceSchemaUId = new Guid("5c961be4-e117-4f3f-b70b-8fb91285f371");
			column.ColumnValueName = @"FolderId";
			column.DisplayColumnValueName = @"FolderName";
			column.ModifiedInSchemaUId = new Guid("021b4368-fae5-47c4-a2fa-b84fc4df6b3e");
			return column;
		}

		protected virtual EntitySchemaColumn CreateBulkEmailSplitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("803614f5-f9da-4e86-9623-3018fe12a96f"),
				Name = @"BulkEmailSplit",
				ReferenceSchemaUId = new Guid("9682719a-2ac0-47c8-af3a-f988a778988b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("021b4368-fae5-47c4-a2fa-b84fc4df6b3e"),
				ModifiedInSchemaUId = new Guid("021b4368-fae5-47c4-a2fa-b84fc4df6b3e"),
				CreatedInPackageId = new Guid("b7874c9a-6e65-41ca-b21f-5fb1f6a22855")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BulkEmailSplitInFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BulkEmailSplitInFolder_CrtBulkEmailEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BulkEmailSplitInFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmailSplitInFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("021b4368-fae5-47c4-a2fa-b84fc4df6b3e"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailSplitInFolder

	/// <summary>
	/// Object "Email: split tests" in folder.
	/// </summary>
	public class BulkEmailSplitInFolder : Terrasoft.Configuration.BaseItemInFolder
	{

		#region Constructors: Public

		public BulkEmailSplitInFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmailSplitInFolder";
		}

		public BulkEmailSplitInFolder(BulkEmailSplitInFolder source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid BulkEmailSplitId {
			get {
				return GetTypedColumnValue<Guid>("BulkEmailSplitId");
			}
			set {
				SetColumnValue("BulkEmailSplitId", value);
				_bulkEmailSplit = null;
			}
		}

		/// <exclude/>
		public string BulkEmailSplitName {
			get {
				return GetTypedColumnValue<string>("BulkEmailSplitName");
			}
			set {
				SetColumnValue("BulkEmailSplitName", value);
				if (_bulkEmailSplit != null) {
					_bulkEmailSplit.Name = value;
				}
			}
		}

		private BulkEmailSplit _bulkEmailSplit;
		/// <summary>
		/// Email: Split tests.
		/// </summary>
		public BulkEmailSplit BulkEmailSplit {
			get {
				return _bulkEmailSplit ??
					(_bulkEmailSplit = LookupColumnEntities.GetEntity("BulkEmailSplit") as BulkEmailSplit);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmailSplitInFolder_CrtBulkEmailEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BulkEmailSplitInFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailSplitInFolder_CrtBulkEmailEventsProcess

	/// <exclude/>
	public partial class BulkEmailSplitInFolder_CrtBulkEmailEventsProcess<TEntity> : Terrasoft.Configuration.BaseItemInFolder_CrtBaseEventsProcess<TEntity> where TEntity : BulkEmailSplitInFolder
	{

		public BulkEmailSplitInFolder_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmailSplitInFolder_CrtBulkEmailEventsProcess";
			SchemaUId = new Guid("021b4368-fae5-47c4-a2fa-b84fc4df6b3e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("021b4368-fae5-47c4-a2fa-b84fc4df6b3e");
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

	#region Class: BulkEmailSplitInFolder_CrtBulkEmailEventsProcess

	/// <exclude/>
	public class BulkEmailSplitInFolder_CrtBulkEmailEventsProcess : BulkEmailSplitInFolder_CrtBulkEmailEventsProcess<BulkEmailSplitInFolder>
	{

		public BulkEmailSplitInFolder_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmailSplitInFolder_CrtBulkEmailEventsProcess

	public partial class BulkEmailSplitInFolder_CrtBulkEmailEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BulkEmailSplitInFolderEventsProcess

	/// <exclude/>
	public class BulkEmailSplitInFolderEventsProcess : BulkEmailSplitInFolder_CrtBulkEmailEventsProcess
	{

		public BulkEmailSplitInFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

