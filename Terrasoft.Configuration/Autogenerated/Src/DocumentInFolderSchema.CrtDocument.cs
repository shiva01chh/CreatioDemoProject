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

	#region Class: DocumentInFolderSchema

	/// <exclude/>
	public class DocumentInFolderSchema : Terrasoft.Configuration.BaseItemInFolderSchema
	{

		#region Constructors: Public

		public DocumentInFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DocumentInFolderSchema(DocumentInFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DocumentInFolderSchema(DocumentInFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("804e7b16-f6a6-4860-b4f3-5b66f67dbf02");
			RealUId = new Guid("804e7b16-f6a6-4860-b4f3-5b66f67dbf02");
			Name = "DocumentInFolder";
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
			if (Columns.FindByUId(new Guid("745d0675-5132-4168-83a6-7a1894523dbb")) == null) {
				Columns.Add(CreateDocumentColumn());
			}
		}

		protected override EntitySchemaColumn CreateFolderColumn() {
			EntitySchemaColumn column = base.CreateFolderColumn();
			column.ReferenceSchemaUId = new Guid("9fa78bfb-9df5-4382-9242-e7597eea88bc");
			column.ColumnValueName = @"FolderId";
			column.DisplayColumnValueName = @"FolderName";
			column.ModifiedInSchemaUId = new Guid("804e7b16-f6a6-4860-b4f3-5b66f67dbf02");
			return column;
		}

		protected virtual EntitySchemaColumn CreateDocumentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("745d0675-5132-4168-83a6-7a1894523dbb"),
				Name = @"Document",
				ReferenceSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("804e7b16-f6a6-4860-b4f3-5b66f67dbf02"),
				ModifiedInSchemaUId = new Guid("804e7b16-f6a6-4860-b4f3-5b66f67dbf02"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DocumentInFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DocumentInFolder_CrtDocumentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DocumentInFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DocumentInFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("804e7b16-f6a6-4860-b4f3-5b66f67dbf02"));
		}

		#endregion

	}

	#endregion

	#region Class: DocumentInFolder

	/// <summary>
	/// Document in folder.
	/// </summary>
	public class DocumentInFolder : Terrasoft.Configuration.BaseItemInFolder
	{

		#region Constructors: Public

		public DocumentInFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DocumentInFolder";
		}

		public DocumentInFolder(DocumentInFolder source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid DocumentId {
			get {
				return GetTypedColumnValue<Guid>("DocumentId");
			}
			set {
				SetColumnValue("DocumentId", value);
				_document = null;
			}
		}

		/// <exclude/>
		public string DocumentNumber {
			get {
				return GetTypedColumnValue<string>("DocumentNumber");
			}
			set {
				SetColumnValue("DocumentNumber", value);
				if (_document != null) {
					_document.Number = value;
				}
			}
		}

		private Document _document;
		/// <summary>
		/// Document.
		/// </summary>
		public Document Document {
			get {
				return _document ??
					(_document = LookupColumnEntities.GetEntity("Document") as Document);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DocumentInFolder_CrtDocumentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DocumentInFolderDeleted", e);
			Deleting += (s, e) => ThrowEvent("DocumentInFolderDeleting", e);
			Inserted += (s, e) => ThrowEvent("DocumentInFolderInserted", e);
			Inserting += (s, e) => ThrowEvent("DocumentInFolderInserting", e);
			Saved += (s, e) => ThrowEvent("DocumentInFolderSaved", e);
			Saving += (s, e) => ThrowEvent("DocumentInFolderSaving", e);
			Validating += (s, e) => ThrowEvent("DocumentInFolderValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DocumentInFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: DocumentInFolder_CrtDocumentEventsProcess

	/// <exclude/>
	public partial class DocumentInFolder_CrtDocumentEventsProcess<TEntity> : Terrasoft.Configuration.BaseItemInFolder_CrtBaseEventsProcess<TEntity> where TEntity : DocumentInFolder
	{

		public DocumentInFolder_CrtDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DocumentInFolder_CrtDocumentEventsProcess";
			SchemaUId = new Guid("804e7b16-f6a6-4860-b4f3-5b66f67dbf02");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("804e7b16-f6a6-4860-b4f3-5b66f67dbf02");
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

	#region Class: DocumentInFolder_CrtDocumentEventsProcess

	/// <exclude/>
	public class DocumentInFolder_CrtDocumentEventsProcess : DocumentInFolder_CrtDocumentEventsProcess<DocumentInFolder>
	{

		public DocumentInFolder_CrtDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DocumentInFolder_CrtDocumentEventsProcess

	public partial class DocumentInFolder_CrtDocumentEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: DocumentInFolderEventsProcess

	/// <exclude/>
	public class DocumentInFolderEventsProcess : DocumentInFolder_CrtDocumentEventsProcess
	{

		public DocumentInFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

