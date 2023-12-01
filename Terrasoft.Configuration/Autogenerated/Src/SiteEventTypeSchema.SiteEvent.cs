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

	#region Class: SiteEventType_SiteEvent_TerrasoftSchema

	/// <exclude/>
	public class SiteEventType_SiteEvent_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public SiteEventType_SiteEvent_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SiteEventType_SiteEvent_TerrasoftSchema(SiteEventType_SiteEvent_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SiteEventType_SiteEvent_TerrasoftSchema(SiteEventType_SiteEvent_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e7274000-f0ef-4995-991a-37f0ace69fe3");
			RealUId = new Guid("e7274000-f0ef-4995-991a-37f0ace69fe3");
			Name = "SiteEventType_SiteEvent_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a");
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
			column.ModifiedInSchemaUId = new Guid("e7274000-f0ef-4995-991a-37f0ace69fe3");
			column.CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("e7274000-f0ef-4995-991a-37f0ace69fe3");
			column.CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("e7274000-f0ef-4995-991a-37f0ace69fe3");
			column.CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("e7274000-f0ef-4995-991a-37f0ace69fe3");
			column.CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("e7274000-f0ef-4995-991a-37f0ace69fe3");
			column.CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("e7274000-f0ef-4995-991a-37f0ace69fe3");
			column.CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("e7274000-f0ef-4995-991a-37f0ace69fe3");
			column.CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("e7274000-f0ef-4995-991a-37f0ace69fe3");
			column.CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SiteEventType_SiteEvent_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SiteEventType_SiteEventEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SiteEventType_SiteEvent_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SiteEventType_SiteEvent_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e7274000-f0ef-4995-991a-37f0ace69fe3"));
		}

		#endregion

	}

	#endregion

	#region Class: SiteEventType_SiteEvent_Terrasoft

	/// <summary>
	/// Website event type.
	/// </summary>
	public class SiteEventType_SiteEvent_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public SiteEventType_SiteEvent_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SiteEventType_SiteEvent_Terrasoft";
		}

		public SiteEventType_SiteEvent_Terrasoft(SiteEventType_SiteEvent_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SiteEventType_SiteEventEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SiteEventType_SiteEvent_TerrasoftDeleted", e);
			Validating += (s, e) => ThrowEvent("SiteEventType_SiteEvent_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SiteEventType_SiteEvent_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SiteEventType_SiteEventEventsProcess

	/// <exclude/>
	public partial class SiteEventType_SiteEventEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : SiteEventType_SiteEvent_Terrasoft
	{

		public SiteEventType_SiteEventEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SiteEventType_SiteEventEventsProcess";
			SchemaUId = new Guid("e7274000-f0ef-4995-991a-37f0ace69fe3");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e7274000-f0ef-4995-991a-37f0ace69fe3");
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

	#region Class: SiteEventType_SiteEventEventsProcess

	/// <exclude/>
	public class SiteEventType_SiteEventEventsProcess : SiteEventType_SiteEventEventsProcess<SiteEventType_SiteEvent_Terrasoft>
	{

		public SiteEventType_SiteEventEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SiteEventType_SiteEventEventsProcess

	public partial class SiteEventType_SiteEventEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

