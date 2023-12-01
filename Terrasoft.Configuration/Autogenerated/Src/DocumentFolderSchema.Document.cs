namespace Terrasoft.Configuration
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

	#region Class: DocumentFolderSchema

	/// <exclude/>
	public class DocumentFolderSchema : Terrasoft.Configuration.DocumentFolder_CrtDocument_TerrasoftSchema
	{

		#region Constructors: Public

		public DocumentFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DocumentFolderSchema(DocumentFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DocumentFolderSchema(DocumentFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("0d6e9b19-45dc-447a-a811-b72853fcd5d8");
			Name = "DocumentFolder";
			ParentSchemaUId = new Guid("9fa78bfb-9df5-4382-9242-e7597eea88bc");
			ExtendParent = true;
			CreatedInPackageId = new Guid("a4c567a6-b37c-4fa1-91db-ec1c077c3a21");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateFolderTypeColumn() {
			EntitySchemaColumn column = base.CreateFolderTypeColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"9dc5f6e6-2a61-4de8-a059-de30f4e74f24"
			};
			column.ModifiedInSchemaUId = new Guid("0d6e9b19-45dc-447a-a811-b72853fcd5d8");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DocumentFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DocumentFolder_DocumentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DocumentFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DocumentFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0d6e9b19-45dc-447a-a811-b72853fcd5d8"));
		}

		#endregion

	}

	#endregion

	#region Class: DocumentFolder

	/// <summary>
	/// Document folder.
	/// </summary>
	public class DocumentFolder : Terrasoft.Configuration.DocumentFolder_CrtDocument_Terrasoft
	{

		#region Constructors: Public

		public DocumentFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DocumentFolder";
		}

		public DocumentFolder(DocumentFolder source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DocumentFolder_DocumentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DocumentFolderDeleted", e);
			Deleting += (s, e) => ThrowEvent("DocumentFolderDeleting", e);
			Inserted += (s, e) => ThrowEvent("DocumentFolderInserted", e);
			Inserting += (s, e) => ThrowEvent("DocumentFolderInserting", e);
			Saved += (s, e) => ThrowEvent("DocumentFolderSaved", e);
			Saving += (s, e) => ThrowEvent("DocumentFolderSaving", e);
			Validating += (s, e) => ThrowEvent("DocumentFolderValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DocumentFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: DocumentFolder_DocumentEventsProcess

	/// <exclude/>
	public partial class DocumentFolder_DocumentEventsProcess<TEntity> : Terrasoft.Configuration.DocumentFolder_CrtDocumentEventsProcess<TEntity> where TEntity : DocumentFolder
	{

		public DocumentFolder_DocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DocumentFolder_DocumentEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0d6e9b19-45dc-447a-a811-b72853fcd5d8");
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

	#region Class: DocumentFolder_DocumentEventsProcess

	/// <exclude/>
	public class DocumentFolder_DocumentEventsProcess : DocumentFolder_DocumentEventsProcess<DocumentFolder>
	{

		public DocumentFolder_DocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: DocumentFolderEventsProcess

	/// <exclude/>
	public class DocumentFolderEventsProcess : DocumentFolder_DocumentEventsProcess
	{

		public DocumentFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

