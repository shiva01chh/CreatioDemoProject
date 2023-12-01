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

	#region Class: DocumentTypeSchema

	/// <exclude/>
	public class DocumentTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public DocumentTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DocumentTypeSchema(DocumentTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DocumentTypeSchema(DocumentTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fe5e6306-c1ae-454f-87fb-108461dd71f5");
			RealUId = new Guid("fe5e6306-c1ae-454f-87fb-108461dd71f5");
			Name = "DocumentType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColorColumn() {
			base.InitializePrimaryColorColumn();
			PrimaryColorColumn = CreateColorColumn();
			if (Columns.FindByUId(PrimaryColorColumn.UId) == null) {
				Columns.Add(PrimaryColorColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6efed541-ddcf-4af4-8908-63d697ea324d")) == null) {
				Columns.Add(CreateCodeColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("fe5e6306-c1ae-454f-87fb-108461dd71f5");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("fe5e6306-c1ae-454f-87fb-108461dd71f5");
			column.CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e");
			return column;
		}

		protected virtual EntitySchemaColumn CreateCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("6efed541-ddcf-4af4-8908-63d697ea324d"),
				Name = @"Code",
				CreatedInSchemaUId = new Guid("fe5e6306-c1ae-454f-87fb-108461dd71f5"),
				ModifiedInSchemaUId = new Guid("fe5e6306-c1ae-454f-87fb-108461dd71f5"),
				CreatedInPackageId = new Guid("c465b70f-ad74-4d3f-9db3-cd6ec97b116e")
			};
		}

		protected virtual EntitySchemaColumn CreateColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Color")) {
				UId = new Guid("22b6f1c0-3886-848a-9f46-2774cbfd52c5"),
				Name = @"Color",
				CreatedInSchemaUId = new Guid("fe5e6306-c1ae-454f-87fb-108461dd71f5"),
				ModifiedInSchemaUId = new Guid("fe5e6306-c1ae-454f-87fb-108461dd71f5"),
				CreatedInPackageId = new Guid("d4e21e63-02b9-4a53-ba3e-05ada96e84c3")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DocumentType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DocumentType_CrtDocumentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DocumentTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DocumentTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fe5e6306-c1ae-454f-87fb-108461dd71f5"));
		}

		#endregion

	}

	#endregion

	#region Class: DocumentType

	/// <summary>
	/// Document type.
	/// </summary>
	public class DocumentType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public DocumentType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DocumentType";
		}

		public DocumentType(DocumentType source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Code.
		/// </summary>
		public string Code {
			get {
				return GetTypedColumnValue<string>("Code");
			}
			set {
				SetColumnValue("Code", value);
			}
		}

		/// <summary>
		/// Color.
		/// </summary>
		public Color Color {
			get {
				return GetTypedColumnValue<Color>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DocumentType_CrtDocumentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DocumentTypeDeleted", e);
			Deleting += (s, e) => ThrowEvent("DocumentTypeDeleting", e);
			Inserted += (s, e) => ThrowEvent("DocumentTypeInserted", e);
			Inserting += (s, e) => ThrowEvent("DocumentTypeInserting", e);
			Saved += (s, e) => ThrowEvent("DocumentTypeSaved", e);
			Saving += (s, e) => ThrowEvent("DocumentTypeSaving", e);
			Validating += (s, e) => ThrowEvent("DocumentTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DocumentType(this);
		}

		#endregion

	}

	#endregion

	#region Class: DocumentType_CrtDocumentEventsProcess

	/// <exclude/>
	public partial class DocumentType_CrtDocumentEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : DocumentType
	{

		public DocumentType_CrtDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DocumentType_CrtDocumentEventsProcess";
			SchemaUId = new Guid("fe5e6306-c1ae-454f-87fb-108461dd71f5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fe5e6306-c1ae-454f-87fb-108461dd71f5");
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

	#region Class: DocumentType_CrtDocumentEventsProcess

	/// <exclude/>
	public class DocumentType_CrtDocumentEventsProcess : DocumentType_CrtDocumentEventsProcess<DocumentType>
	{

		public DocumentType_CrtDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DocumentType_CrtDocumentEventsProcess

	public partial class DocumentType_CrtDocumentEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: DocumentTypeEventsProcess

	/// <exclude/>
	public class DocumentTypeEventsProcess : DocumentType_CrtDocumentEventsProcess
	{

		public DocumentTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

