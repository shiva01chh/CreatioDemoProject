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

	#region Class: FormSubmit_CrtEngagementInCampaignBase_TerrasoftSchema

	/// <exclude/>
	public class FormSubmit_CrtEngagementInCampaignBase_TerrasoftSchema : Terrasoft.Configuration.FormSubmit_CrtTouchInWebForm_TerrasoftSchema
	{

		#region Constructors: Public

		public FormSubmit_CrtEngagementInCampaignBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FormSubmit_CrtEngagementInCampaignBase_TerrasoftSchema(FormSubmit_CrtEngagementInCampaignBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FormSubmit_CrtEngagementInCampaignBase_TerrasoftSchema(FormSubmit_CrtEngagementInCampaignBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("328e56bc-1e94-4fed-bf1f-167311d995ea");
			Name = "FormSubmit_CrtEngagementInCampaignBase_Terrasoft";
			ParentSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015");
			ExtendParent = true;
			CreatedInPackageId = new Guid("694e3852-cf42-4b0c-9493-6f4b666c751c");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("0f3eb59b-a64c-17c8-9fb8-cc40c2903530")) == null) {
				Columns.Add(CreateCampaignColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCampaignColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0f3eb59b-a64c-17c8-9fb8-cc40c2903530"),
				Name = @"Campaign",
				ReferenceSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("328e56bc-1e94-4fed-bf1f-167311d995ea"),
				ModifiedInSchemaUId = new Guid("328e56bc-1e94-4fed-bf1f-167311d995ea"),
				CreatedInPackageId = new Guid("694e3852-cf42-4b0c-9493-6f4b666c751c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FormSubmit_CrtEngagementInCampaignBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FormSubmit_CrtEngagementInCampaignBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FormSubmit_CrtEngagementInCampaignBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FormSubmit_CrtEngagementInCampaignBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("328e56bc-1e94-4fed-bf1f-167311d995ea"));
		}

		#endregion

	}

	#endregion

	#region Class: FormSubmit_CrtEngagementInCampaignBase_Terrasoft

	/// <summary>
	/// Submitted form.
	/// </summary>
	public class FormSubmit_CrtEngagementInCampaignBase_Terrasoft : Terrasoft.Configuration.FormSubmit_CrtTouchInWebForm_Terrasoft
	{

		#region Constructors: Public

		public FormSubmit_CrtEngagementInCampaignBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FormSubmit_CrtEngagementInCampaignBase_Terrasoft";
		}

		public FormSubmit_CrtEngagementInCampaignBase_Terrasoft(FormSubmit_CrtEngagementInCampaignBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CampaignId {
			get {
				return GetTypedColumnValue<Guid>("CampaignId");
			}
			set {
				SetColumnValue("CampaignId", value);
				_campaign = null;
			}
		}

		/// <exclude/>
		public string CampaignName {
			get {
				return GetTypedColumnValue<string>("CampaignName");
			}
			set {
				SetColumnValue("CampaignName", value);
				if (_campaign != null) {
					_campaign.Name = value;
				}
			}
		}

		private Campaign _campaign;
		/// <summary>
		/// Campaign.
		/// </summary>
		public Campaign Campaign {
			get {
				return _campaign ??
					(_campaign = LookupColumnEntities.GetEntity("Campaign") as Campaign);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FormSubmit_CrtEngagementInCampaignBaseEventsProcess(UserConnection);
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
			return new FormSubmit_CrtEngagementInCampaignBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: FormSubmit_CrtEngagementInCampaignBaseEventsProcess

	/// <exclude/>
	public partial class FormSubmit_CrtEngagementInCampaignBaseEventsProcess<TEntity> : Terrasoft.Configuration.FormSubmit_CrtTouchInWebFormEventsProcess<TEntity> where TEntity : FormSubmit_CrtEngagementInCampaignBase_Terrasoft
	{

		public FormSubmit_CrtEngagementInCampaignBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FormSubmit_CrtEngagementInCampaignBaseEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("328e56bc-1e94-4fed-bf1f-167311d995ea");
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

	#region Class: FormSubmit_CrtEngagementInCampaignBaseEventsProcess

	/// <exclude/>
	public class FormSubmit_CrtEngagementInCampaignBaseEventsProcess : FormSubmit_CrtEngagementInCampaignBaseEventsProcess<FormSubmit_CrtEngagementInCampaignBase_Terrasoft>
	{

		public FormSubmit_CrtEngagementInCampaignBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FormSubmit_CrtEngagementInCampaignBaseEventsProcess

	public partial class FormSubmit_CrtEngagementInCampaignBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

