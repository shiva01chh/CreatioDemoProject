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

	#region Class: FileTypeSchema

	/// <exclude/>
	public class FileTypeSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public FileTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FileTypeSchema(FileTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FileTypeSchema(FileTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3c6fc826-bca3-49a7-ae4c-7e9454b386a5");
			RealUId = new Guid("3c6fc826-bca3-49a7-ae4c-7e9454b386a5");
			Name = "FileType";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
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

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FileType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FileType_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FileTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FileTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3c6fc826-bca3-49a7-ae4c-7e9454b386a5"));
		}

		#endregion

	}

	#endregion

	#region Class: FileType

	/// <summary>
	/// Attachment Type.
	/// </summary>
	public class FileType : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public FileType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FileType";
		}

		public FileType(FileType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FileType_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("FileTypeDeleted", e);
			Deleting += (s, e) => ThrowEvent("FileTypeDeleting", e);
			Inserted += (s, e) => ThrowEvent("FileTypeInserted", e);
			Inserting += (s, e) => ThrowEvent("FileTypeInserting", e);
			Saved += (s, e) => ThrowEvent("FileTypeSaved", e);
			Saving += (s, e) => ThrowEvent("FileTypeSaving", e);
			Validating += (s, e) => ThrowEvent("FileTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FileType(this);
		}

		#endregion

	}

	#endregion

	#region Class: FileType_CrtBaseEventsProcess

	/// <exclude/>
	public partial class FileType_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_CrtBaseEventsProcess<TEntity> where TEntity : FileType
	{

		public FileType_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FileType_CrtBaseEventsProcess";
			SchemaUId = new Guid("3c6fc826-bca3-49a7-ae4c-7e9454b386a5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3c6fc826-bca3-49a7-ae4c-7e9454b386a5");
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

	#region Class: FileType_CrtBaseEventsProcess

	/// <exclude/>
	public class FileType_CrtBaseEventsProcess : FileType_CrtBaseEventsProcess<FileType>
	{

		public FileType_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FileType_CrtBaseEventsProcess

	public partial class FileType_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: FileTypeEventsProcess

	/// <exclude/>
	public class FileTypeEventsProcess : FileType_CrtBaseEventsProcess
	{

		public FileTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

