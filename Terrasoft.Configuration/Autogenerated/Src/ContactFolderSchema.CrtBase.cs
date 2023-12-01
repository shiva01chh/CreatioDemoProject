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

	#region Class: ContactFolder_CrtBase_TerrasoftSchema

	/// <exclude/>
	public class ContactFolder_CrtBase_TerrasoftSchema : Terrasoft.Configuration.BaseFolderSchema
	{

		#region Constructors: Public

		public ContactFolder_CrtBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactFolder_CrtBase_TerrasoftSchema(ContactFolder_CrtBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactFolder_CrtBase_TerrasoftSchema(ContactFolder_CrtBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8b5c01a2-59e9-40dc-855b-6e3bebddc6ee");
			RealUId = new Guid("8b5c01a2-59e9-40dc-855b-6e3bebddc6ee");
			Name = "ContactFolder_CrtBase_Terrasoft";
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

		protected override EntitySchemaColumn CreateParentColumn() {
			EntitySchemaColumn column = base.CreateParentColumn();
			column.ReferenceSchemaUId = new Guid("8b5c01a2-59e9-40dc-855b-6e3bebddc6ee");
			column.ColumnValueName = @"ParentId";
			column.DisplayColumnValueName = @"ParentName";
			column.ModifiedInSchemaUId = new Guid("8b5c01a2-59e9-40dc-855b-6e3bebddc6ee");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContactFolder_CrtBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactFolder_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactFolder_CrtBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactFolder_CrtBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8b5c01a2-59e9-40dc-855b-6e3bebddc6ee"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactFolder_CrtBase_Terrasoft

	/// <summary>
	/// Contact folder.
	/// </summary>
	public class ContactFolder_CrtBase_Terrasoft : Terrasoft.Configuration.BaseFolder
	{

		#region Constructors: Public

		public ContactFolder_CrtBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactFolder_CrtBase_Terrasoft";
		}

		public ContactFolder_CrtBase_Terrasoft(ContactFolder_CrtBase_Terrasoft source)
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

		private ContactFolder _parent;
		/// <summary>
		/// Parent.
		/// </summary>
		public ContactFolder Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as ContactFolder);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactFolder_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactFolder_CrtBase_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("ContactFolder_CrtBase_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("ContactFolder_CrtBase_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("ContactFolder_CrtBase_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("ContactFolder_CrtBase_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("ContactFolder_CrtBase_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("ContactFolder_CrtBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactFolder_CrtBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactFolder_CrtBaseEventsProcess

	/// <exclude/>
	public partial class ContactFolder_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseFolder_CrtBaseEventsProcess<TEntity> where TEntity : ContactFolder_CrtBase_Terrasoft
	{

		public ContactFolder_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactFolder_CrtBaseEventsProcess";
			SchemaUId = new Guid("8b5c01a2-59e9-40dc-855b-6e3bebddc6ee");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8b5c01a2-59e9-40dc-855b-6e3bebddc6ee");
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

	#region Class: ContactFolder_CrtBaseEventsProcess

	/// <exclude/>
	public class ContactFolder_CrtBaseEventsProcess : ContactFolder_CrtBaseEventsProcess<ContactFolder_CrtBase_Terrasoft>
	{

		public ContactFolder_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactFolder_CrtBaseEventsProcess

	public partial class ContactFolder_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void CheckCanManageLookups() {
			return;
		}

		#endregion

	}

	#endregion

}

