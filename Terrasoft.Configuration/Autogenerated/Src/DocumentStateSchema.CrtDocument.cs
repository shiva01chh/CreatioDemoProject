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

	#region Class: DocumentStateSchema

	/// <exclude/>
	public class DocumentStateSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public DocumentStateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DocumentStateSchema(DocumentStateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DocumentStateSchema(DocumentStateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3fa49baa-57d4-40d7-9293-1e6742b1b0dd");
			RealUId = new Guid("3fa49baa-57d4-40d7-9293-1e6742b1b0dd");
			Name = "DocumentState";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("93f2b0e4-b421-42dc-86e5-35e5b932239c");
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
			if (Columns.FindByUId(new Guid("9e97b79d-5d55-4b98-bfb0-c803e3d1467f")) == null) {
				Columns.Add(CreatePositionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("9e97b79d-5d55-4b98-bfb0-c803e3d1467f"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("3fa49baa-57d4-40d7-9293-1e6742b1b0dd"),
				ModifiedInSchemaUId = new Guid("3fa49baa-57d4-40d7-9293-1e6742b1b0dd"),
				CreatedInPackageId = new Guid("93f2b0e4-b421-42dc-86e5-35e5b932239c")
			};
		}

		protected virtual EntitySchemaColumn CreateColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Color")) {
				UId = new Guid("b45d89df-57d4-7698-3601-17c9253e34b8"),
				Name = @"Color",
				CreatedInSchemaUId = new Guid("3fa49baa-57d4-40d7-9293-1e6742b1b0dd"),
				ModifiedInSchemaUId = new Guid("3fa49baa-57d4-40d7-9293-1e6742b1b0dd"),
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
			return new DocumentState(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DocumentState_CrtDocumentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DocumentStateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DocumentStateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3fa49baa-57d4-40d7-9293-1e6742b1b0dd"));
		}

		#endregion

	}

	#endregion

	#region Class: DocumentState

	/// <summary>
	/// Document status.
	/// </summary>
	public class DocumentState : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public DocumentState(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DocumentState";
		}

		public DocumentState(DocumentState source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
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
			var process = new DocumentState_CrtDocumentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DocumentStateDeleted", e);
			Validating += (s, e) => ThrowEvent("DocumentStateValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DocumentState(this);
		}

		#endregion

	}

	#endregion

	#region Class: DocumentState_CrtDocumentEventsProcess

	/// <exclude/>
	public partial class DocumentState_CrtDocumentEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : DocumentState
	{

		public DocumentState_CrtDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DocumentState_CrtDocumentEventsProcess";
			SchemaUId = new Guid("3fa49baa-57d4-40d7-9293-1e6742b1b0dd");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3fa49baa-57d4-40d7-9293-1e6742b1b0dd");
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

	#region Class: DocumentState_CrtDocumentEventsProcess

	/// <exclude/>
	public class DocumentState_CrtDocumentEventsProcess : DocumentState_CrtDocumentEventsProcess<DocumentState>
	{

		public DocumentState_CrtDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DocumentState_CrtDocumentEventsProcess

	public partial class DocumentState_CrtDocumentEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: DocumentStateEventsProcess

	/// <exclude/>
	public class DocumentStateEventsProcess : DocumentState_CrtDocumentEventsProcess
	{

		public DocumentStateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

