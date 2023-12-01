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

	#region Class: WSysAccountRoleSchema

	/// <exclude/>
	public class WSysAccountRoleSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public WSysAccountRoleSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public WSysAccountRoleSchema(WSysAccountRoleSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public WSysAccountRoleSchema(WSysAccountRoleSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3367e5f9-0903-4702-8444-537f67ee2fc9");
			RealUId = new Guid("3367e5f9-0903-4702-8444-537f67ee2fc9");
			Name = "WSysAccountRole";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("3367e5f9-0903-4702-8444-537f67ee2fc9");
			column.CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("3367e5f9-0903-4702-8444-537f67ee2fc9");
			column.CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("3367e5f9-0903-4702-8444-537f67ee2fc9");
			column.CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("3367e5f9-0903-4702-8444-537f67ee2fc9");
			column.CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("3367e5f9-0903-4702-8444-537f67ee2fc9");
			column.CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("3367e5f9-0903-4702-8444-537f67ee2fc9");
			column.CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("3367e5f9-0903-4702-8444-537f67ee2fc9");
			column.CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98");
			return column;
		}

		protected override EntitySchemaColumn CreateCodeColumn() {
			EntitySchemaColumn column = base.CreateCodeColumn();
			column.ModifiedInSchemaUId = new Guid("3367e5f9-0903-4702-8444-537f67ee2fc9");
			column.CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("3367e5f9-0903-4702-8444-537f67ee2fc9");
			column.CreatedInPackageId = new Guid("1303b630-da63-4ee7-9918-95b9adb4dd98");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new WSysAccountRole(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new WSysAccountRole_WebitelCollaborationsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new WSysAccountRoleSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new WSysAccountRoleSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3367e5f9-0903-4702-8444-537f67ee2fc9"));
		}

		#endregion

	}

	#endregion

	#region Class: WSysAccountRole

	/// <summary>
	/// Webitel user role.
	/// </summary>
	public class WSysAccountRole : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public WSysAccountRole(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WSysAccountRole";
		}

		public WSysAccountRole(WSysAccountRole source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new WSysAccountRole_WebitelCollaborationsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("WSysAccountRoleDeleted", e);
			Inserting += (s, e) => ThrowEvent("WSysAccountRoleInserting", e);
			Validating += (s, e) => ThrowEvent("WSysAccountRoleValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new WSysAccountRole(this);
		}

		#endregion

	}

	#endregion

	#region Class: WSysAccountRole_WebitelCollaborationsEventsProcess

	/// <exclude/>
	public partial class WSysAccountRole_WebitelCollaborationsEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_CrtBaseEventsProcess<TEntity> where TEntity : WSysAccountRole
	{

		public WSysAccountRole_WebitelCollaborationsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WSysAccountRole_WebitelCollaborationsEventsProcess";
			SchemaUId = new Guid("3367e5f9-0903-4702-8444-537f67ee2fc9");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3367e5f9-0903-4702-8444-537f67ee2fc9");
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

	#region Class: WSysAccountRole_WebitelCollaborationsEventsProcess

	/// <exclude/>
	public class WSysAccountRole_WebitelCollaborationsEventsProcess : WSysAccountRole_WebitelCollaborationsEventsProcess<WSysAccountRole>
	{

		public WSysAccountRole_WebitelCollaborationsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: WSysAccountRole_WebitelCollaborationsEventsProcess

	public partial class WSysAccountRole_WebitelCollaborationsEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: WSysAccountRoleEventsProcess

	/// <exclude/>
	public class WSysAccountRoleEventsProcess : WSysAccountRole_WebitelCollaborationsEventsProcess
	{

		public WSysAccountRoleEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

