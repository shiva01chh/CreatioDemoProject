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

	#region Class: EmailThrottlingQueueSchema

	/// <exclude/>
	public class EmailThrottlingQueueSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public EmailThrottlingQueueSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmailThrottlingQueueSchema(EmailThrottlingQueueSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmailThrottlingQueueSchema(EmailThrottlingQueueSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eb720e69-12b8-8fe3-e018-7cb960d35698");
			RealUId = new Guid("eb720e69-12b8-8fe3-e018-7cb960d35698");
			Name = "EmailThrottlingQueue";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("4a059dd9-cc23-ee40-f029-178d90853819")) == null) {
				Columns.Add(CreateCodeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("4a059dd9-cc23-ee40-f029-178d90853819"),
				Name = @"Code",
				CreatedInSchemaUId = new Guid("eb720e69-12b8-8fe3-e018-7cb960d35698"),
				ModifiedInSchemaUId = new Guid("eb720e69-12b8-8fe3-e018-7cb960d35698"),
				CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EmailThrottlingQueue(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EmailThrottlingQueue_CrtBulkEmailEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EmailThrottlingQueueSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmailThrottlingQueueSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb720e69-12b8-8fe3-e018-7cb960d35698"));
		}

		#endregion

	}

	#endregion

	#region Class: EmailThrottlingQueue

	/// <summary>
	/// Bulk email throttling queue.
	/// </summary>
	public class EmailThrottlingQueue : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public EmailThrottlingQueue(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EmailThrottlingQueue";
		}

		public EmailThrottlingQueue(EmailThrottlingQueue source)
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EmailThrottlingQueue_CrtBulkEmailEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmailThrottlingQueue(this);
		}

		#endregion

	}

	#endregion

	#region Class: EmailThrottlingQueue_CrtBulkEmailEventsProcess

	/// <exclude/>
	public partial class EmailThrottlingQueue_CrtBulkEmailEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : EmailThrottlingQueue
	{

		public EmailThrottlingQueue_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmailThrottlingQueue_CrtBulkEmailEventsProcess";
			SchemaUId = new Guid("eb720e69-12b8-8fe3-e018-7cb960d35698");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("eb720e69-12b8-8fe3-e018-7cb960d35698");
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

	#region Class: EmailThrottlingQueue_CrtBulkEmailEventsProcess

	/// <exclude/>
	public class EmailThrottlingQueue_CrtBulkEmailEventsProcess : EmailThrottlingQueue_CrtBulkEmailEventsProcess<EmailThrottlingQueue>
	{

		public EmailThrottlingQueue_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmailThrottlingQueue_CrtBulkEmailEventsProcess

	public partial class EmailThrottlingQueue_CrtBulkEmailEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: EmailThrottlingQueueEventsProcess

	/// <exclude/>
	public class EmailThrottlingQueueEventsProcess : EmailThrottlingQueue_CrtBulkEmailEventsProcess
	{

		public EmailThrottlingQueueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

