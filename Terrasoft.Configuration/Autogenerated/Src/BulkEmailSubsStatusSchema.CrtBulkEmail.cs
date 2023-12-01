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

	#region Class: BulkEmailSubsStatusSchema

	/// <exclude/>
	public class BulkEmailSubsStatusSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public BulkEmailSubsStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmailSubsStatusSchema(BulkEmailSubsStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmailSubsStatusSchema(BulkEmailSubsStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("40516046-e9f2-4922-8e85-01c5251329f7");
			RealUId = new Guid("40516046-e9f2-4922-8e85-01c5251329f7");
			Name = "BulkEmailSubsStatus";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95");
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
			column.ModifiedInSchemaUId = new Guid("40516046-e9f2-4922-8e85-01c5251329f7");
			column.CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("40516046-e9f2-4922-8e85-01c5251329f7");
			column.CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("40516046-e9f2-4922-8e85-01c5251329f7");
			column.CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("40516046-e9f2-4922-8e85-01c5251329f7");
			column.CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("40516046-e9f2-4922-8e85-01c5251329f7");
			column.CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("40516046-e9f2-4922-8e85-01c5251329f7");
			column.CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("40516046-e9f2-4922-8e85-01c5251329f7");
			column.CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("40516046-e9f2-4922-8e85-01c5251329f7");
			column.CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BulkEmailSubsStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BulkEmailSubsStatus_CrtBulkEmailEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BulkEmailSubsStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmailSubsStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("40516046-e9f2-4922-8e85-01c5251329f7"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailSubsStatus

	/// <summary>
	/// Subscription status.
	/// </summary>
	public class BulkEmailSubsStatus : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public BulkEmailSubsStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmailSubsStatus";
		}

		public BulkEmailSubsStatus(BulkEmailSubsStatus source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmailSubsStatus_CrtBulkEmailEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BulkEmailSubsStatusDeleted", e);
			Inserting += (s, e) => ThrowEvent("BulkEmailSubsStatusInserting", e);
			Validating += (s, e) => ThrowEvent("BulkEmailSubsStatusValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BulkEmailSubsStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailSubsStatus_CrtBulkEmailEventsProcess

	/// <exclude/>
	public partial class BulkEmailSubsStatus_CrtBulkEmailEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : BulkEmailSubsStatus
	{

		public BulkEmailSubsStatus_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmailSubsStatus_CrtBulkEmailEventsProcess";
			SchemaUId = new Guid("40516046-e9f2-4922-8e85-01c5251329f7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("40516046-e9f2-4922-8e85-01c5251329f7");
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

	#region Class: BulkEmailSubsStatus_CrtBulkEmailEventsProcess

	/// <exclude/>
	public class BulkEmailSubsStatus_CrtBulkEmailEventsProcess : BulkEmailSubsStatus_CrtBulkEmailEventsProcess<BulkEmailSubsStatus>
	{

		public BulkEmailSubsStatus_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmailSubsStatus_CrtBulkEmailEventsProcess

	public partial class BulkEmailSubsStatus_CrtBulkEmailEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BulkEmailSubsStatusEventsProcess

	/// <exclude/>
	public class BulkEmailSubsStatusEventsProcess : BulkEmailSubsStatus_CrtBulkEmailEventsProcess
	{

		public BulkEmailSubsStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

