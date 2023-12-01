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

	#region Class: LeadGenWebhookStatusSchema

	/// <exclude/>
	public class LeadGenWebhookStatusSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public LeadGenWebhookStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadGenWebhookStatusSchema(LeadGenWebhookStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadGenWebhookStatusSchema(LeadGenWebhookStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1b63dd98-ab55-4b21-bd81-2419b32d2c09");
			RealUId = new Guid("1b63dd98-ab55-4b21-bd81-2419b32d2c09");
			Name = "LeadGenWebhookStatus";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
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
			return new LeadGenWebhookStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadGenWebhookStatus_CrtSocialLeadGenEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadGenWebhookStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadGenWebhookStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1b63dd98-ab55-4b21-bd81-2419b32d2c09"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadGenWebhookStatus

	/// <summary>
	/// Webhook creation status.
	/// </summary>
	public class LeadGenWebhookStatus : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public LeadGenWebhookStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadGenWebhookStatus";
		}

		public LeadGenWebhookStatus(LeadGenWebhookStatus source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadGenWebhookStatus_CrtSocialLeadGenEventsProcess(UserConnection);
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
			return new LeadGenWebhookStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadGenWebhookStatus_CrtSocialLeadGenEventsProcess

	/// <exclude/>
	public partial class LeadGenWebhookStatus_CrtSocialLeadGenEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : LeadGenWebhookStatus
	{

		public LeadGenWebhookStatus_CrtSocialLeadGenEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadGenWebhookStatus_CrtSocialLeadGenEventsProcess";
			SchemaUId = new Guid("1b63dd98-ab55-4b21-bd81-2419b32d2c09");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1b63dd98-ab55-4b21-bd81-2419b32d2c09");
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

	#region Class: LeadGenWebhookStatus_CrtSocialLeadGenEventsProcess

	/// <exclude/>
	public class LeadGenWebhookStatus_CrtSocialLeadGenEventsProcess : LeadGenWebhookStatus_CrtSocialLeadGenEventsProcess<LeadGenWebhookStatus>
	{

		public LeadGenWebhookStatus_CrtSocialLeadGenEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadGenWebhookStatus_CrtSocialLeadGenEventsProcess

	public partial class LeadGenWebhookStatus_CrtSocialLeadGenEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: LeadGenWebhookStatusEventsProcess

	/// <exclude/>
	public class LeadGenWebhookStatusEventsProcess : LeadGenWebhookStatus_CrtSocialLeadGenEventsProcess
	{

		public LeadGenWebhookStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

