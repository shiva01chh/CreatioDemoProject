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
	using Terrasoft.Configuration;
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

	#region Class: DocumentFileSchema

	/// <exclude/>
	public class DocumentFileSchema : Terrasoft.Configuration.DocumentFile_CrtDocument_TerrasoftSchema
	{

		#region Constructors: Public

		public DocumentFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DocumentFileSchema(DocumentFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DocumentFileSchema(DocumentFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("726affff-80b1-42c8-80b6-3b3394272e04");
			Name = "DocumentFile";
			ParentSchemaUId = new Guid("7b332db9-3993-4136-ac32-09353333cc7a");
			ExtendParent = true;
			CreatedInPackageId = new Guid("a4c567a6-b37c-4fa1-91db-ec1c077c3a21");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DocumentFile(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DocumentFile_DocumentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DocumentFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DocumentFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("726affff-80b1-42c8-80b6-3b3394272e04"));
		}

		#endregion

	}

	#endregion

	#region Class: DocumentFile

	/// <summary>
	/// Document attachment.
	/// </summary>
	public class DocumentFile : Terrasoft.Configuration.DocumentFile_CrtDocument_Terrasoft
	{

		#region Constructors: Public

		public DocumentFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DocumentFile";
		}

		public DocumentFile(DocumentFile source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DocumentFile_DocumentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DocumentFileDeleted", e);
			Updated += (s, e) => ThrowEvent("DocumentFileUpdated", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DocumentFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: DocumentFile_DocumentEventsProcess

	/// <exclude/>
	public partial class DocumentFile_DocumentEventsProcess<TEntity> : Terrasoft.Configuration.DocumentFile_CrtDocumentEventsProcess<TEntity> where TEntity : DocumentFile
	{

		public DocumentFile_DocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DocumentFile_DocumentEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("726affff-80b1-42c8-80b6-3b3394272e04");
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

	#region Class: DocumentFile_DocumentEventsProcess

	/// <exclude/>
	public class DocumentFile_DocumentEventsProcess : DocumentFile_DocumentEventsProcess<DocumentFile>
	{

		public DocumentFile_DocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: DocumentFileEventsProcess

	/// <exclude/>
	public class DocumentFileEventsProcess : DocumentFile_DocumentEventsProcess
	{

		public DocumentFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

