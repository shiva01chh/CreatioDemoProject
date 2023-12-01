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

	#region Class: EmailDeliveryScheduleSchema

	/// <exclude/>
	public class EmailDeliveryScheduleSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public EmailDeliveryScheduleSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmailDeliveryScheduleSchema(EmailDeliveryScheduleSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmailDeliveryScheduleSchema(EmailDeliveryScheduleSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2c09efb4-f805-4eb0-172a-2df5f83c68e2");
			RealUId = new Guid("2c09efb4-f805-4eb0-172a-2df5f83c68e2");
			Name = "EmailDeliverySchedule";
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
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EmailDeliverySchedule(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EmailDeliverySchedule_CrtBulkEmailEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EmailDeliveryScheduleSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmailDeliveryScheduleSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2c09efb4-f805-4eb0-172a-2df5f83c68e2"));
		}

		#endregion

	}

	#endregion

	#region Class: EmailDeliverySchedule

	/// <summary>
	/// Bulk email delivery schedule.
	/// </summary>
	public class EmailDeliverySchedule : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public EmailDeliverySchedule(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EmailDeliverySchedule";
		}

		public EmailDeliverySchedule(EmailDeliverySchedule source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EmailDeliverySchedule_CrtBulkEmailEventsProcess(UserConnection);
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
			return new EmailDeliverySchedule(this);
		}

		#endregion

	}

	#endregion

	#region Class: EmailDeliverySchedule_CrtBulkEmailEventsProcess

	/// <exclude/>
	public partial class EmailDeliverySchedule_CrtBulkEmailEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : EmailDeliverySchedule
	{

		public EmailDeliverySchedule_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmailDeliverySchedule_CrtBulkEmailEventsProcess";
			SchemaUId = new Guid("2c09efb4-f805-4eb0-172a-2df5f83c68e2");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2c09efb4-f805-4eb0-172a-2df5f83c68e2");
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

	#region Class: EmailDeliverySchedule_CrtBulkEmailEventsProcess

	/// <exclude/>
	public class EmailDeliverySchedule_CrtBulkEmailEventsProcess : EmailDeliverySchedule_CrtBulkEmailEventsProcess<EmailDeliverySchedule>
	{

		public EmailDeliverySchedule_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmailDeliverySchedule_CrtBulkEmailEventsProcess

	public partial class EmailDeliverySchedule_CrtBulkEmailEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: EmailDeliveryScheduleEventsProcess

	/// <exclude/>
	public class EmailDeliveryScheduleEventsProcess : EmailDeliverySchedule_CrtBulkEmailEventsProcess
	{

		public EmailDeliveryScheduleEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

