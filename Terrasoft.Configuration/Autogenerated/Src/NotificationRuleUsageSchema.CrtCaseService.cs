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

	#region Class: NotificationRuleUsageSchema

	/// <exclude/>
	public class NotificationRuleUsageSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public NotificationRuleUsageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public NotificationRuleUsageSchema(NotificationRuleUsageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public NotificationRuleUsageSchema(NotificationRuleUsageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f175dd0b-0652-48ef-a515-c8608452ed40");
			RealUId = new Guid("f175dd0b-0652-48ef-a515-c8608452ed40");
			Name = "NotificationRuleUsage";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
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
			return new NotificationRuleUsage(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new NotificationRuleUsage_CrtCaseServiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new NotificationRuleUsageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new NotificationRuleUsageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f175dd0b-0652-48ef-a515-c8608452ed40"));
		}

		#endregion

	}

	#endregion

	#region Class: NotificationRuleUsage

	/// <summary>
	/// Notification rule usage.
	/// </summary>
	public class NotificationRuleUsage : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public NotificationRuleUsage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "NotificationRuleUsage";
		}

		public NotificationRuleUsage(NotificationRuleUsage source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new NotificationRuleUsage_CrtCaseServiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("NotificationRuleUsageDeleted", e);
			Deleting += (s, e) => ThrowEvent("NotificationRuleUsageDeleting", e);
			Inserted += (s, e) => ThrowEvent("NotificationRuleUsageInserted", e);
			Inserting += (s, e) => ThrowEvent("NotificationRuleUsageInserting", e);
			Saved += (s, e) => ThrowEvent("NotificationRuleUsageSaved", e);
			Saving += (s, e) => ThrowEvent("NotificationRuleUsageSaving", e);
			Validating += (s, e) => ThrowEvent("NotificationRuleUsageValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new NotificationRuleUsage(this);
		}

		#endregion

	}

	#endregion

	#region Class: NotificationRuleUsage_CrtCaseServiceEventsProcess

	/// <exclude/>
	public partial class NotificationRuleUsage_CrtCaseServiceEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_CrtBaseEventsProcess<TEntity> where TEntity : NotificationRuleUsage
	{

		public NotificationRuleUsage_CrtCaseServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "NotificationRuleUsage_CrtCaseServiceEventsProcess";
			SchemaUId = new Guid("f175dd0b-0652-48ef-a515-c8608452ed40");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f175dd0b-0652-48ef-a515-c8608452ed40");
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

	#region Class: NotificationRuleUsage_CrtCaseServiceEventsProcess

	/// <exclude/>
	public class NotificationRuleUsage_CrtCaseServiceEventsProcess : NotificationRuleUsage_CrtCaseServiceEventsProcess<NotificationRuleUsage>
	{

		public NotificationRuleUsage_CrtCaseServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: NotificationRuleUsage_CrtCaseServiceEventsProcess

	public partial class NotificationRuleUsage_CrtCaseServiceEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: NotificationRuleUsageEventsProcess

	/// <exclude/>
	public class NotificationRuleUsageEventsProcess : NotificationRuleUsage_CrtCaseServiceEventsProcess
	{

		public NotificationRuleUsageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

