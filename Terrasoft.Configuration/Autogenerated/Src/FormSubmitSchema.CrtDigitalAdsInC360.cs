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

	#region Class: FormSubmitSchema

	/// <exclude/>
	public class FormSubmitSchema : Terrasoft.Configuration.FormSubmit_CrtEngagementInBulkEmail_TerrasoftSchema
	{

		#region Constructors: Public

		public FormSubmitSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FormSubmitSchema(FormSubmitSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FormSubmitSchema(FormSubmitSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("08f35090-1cac-41f5-a449-2c460cd72af3");
			Name = "FormSubmit";
			ParentSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015");
			ExtendParent = true;
			CreatedInPackageId = new Guid("1f624e01-f284-4287-8a23-f115d1bf140b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("4b012dd0-0497-0e64-ded7-c6011b6405a2")) == null) {
				Columns.Add(CreateAdCampaignColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAdCampaignColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4b012dd0-0497-0e64-ded7-c6011b6405a2"),
				Name = @"AdCampaign",
				ReferenceSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("08f35090-1cac-41f5-a449-2c460cd72af3"),
				ModifiedInSchemaUId = new Guid("08f35090-1cac-41f5-a449-2c460cd72af3"),
				CreatedInPackageId = new Guid("1f624e01-f284-4287-8a23-f115d1bf140b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FormSubmit(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FormSubmit_CrtDigitalAdsInC360EventsProcess(userConnection);
		}

		public override object Clone() {
			return new FormSubmitSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FormSubmitSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("08f35090-1cac-41f5-a449-2c460cd72af3"));
		}

		#endregion

	}

	#endregion

	#region Class: FormSubmit

	/// <summary>
	/// Submitted form.
	/// </summary>
	public class FormSubmit : Terrasoft.Configuration.FormSubmit_CrtEngagementInBulkEmail_Terrasoft
	{

		#region Constructors: Public

		public FormSubmit(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FormSubmit";
		}

		public FormSubmit(FormSubmit source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid AdCampaignId {
			get {
				return GetTypedColumnValue<Guid>("AdCampaignId");
			}
			set {
				SetColumnValue("AdCampaignId", value);
				_adCampaign = null;
			}
		}

		/// <exclude/>
		public string AdCampaignCampaignName {
			get {
				return GetTypedColumnValue<string>("AdCampaignCampaignName");
			}
			set {
				SetColumnValue("AdCampaignCampaignName", value);
				if (_adCampaign != null) {
					_adCampaign.CampaignName = value;
				}
			}
		}

		private AdCampaign _adCampaign;
		/// <summary>
		/// Ad campaign.
		/// </summary>
		public AdCampaign AdCampaign {
			get {
				return _adCampaign ??
					(_adCampaign = LookupColumnEntities.GetEntity("AdCampaign") as AdCampaign);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FormSubmit_CrtDigitalAdsInC360EventsProcess(UserConnection);
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
			return new FormSubmit(this);
		}

		#endregion

	}

	#endregion

	#region Class: FormSubmit_CrtDigitalAdsInC360EventsProcess

	/// <exclude/>
	public partial class FormSubmit_CrtDigitalAdsInC360EventsProcess<TEntity> : Terrasoft.Configuration.FormSubmit_CrtEngagementInBulkEmailEventsProcess<TEntity> where TEntity : FormSubmit
	{

		public FormSubmit_CrtDigitalAdsInC360EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FormSubmit_CrtDigitalAdsInC360EventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("08f35090-1cac-41f5-a449-2c460cd72af3");
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

	#region Class: FormSubmit_CrtDigitalAdsInC360EventsProcess

	/// <exclude/>
	public class FormSubmit_CrtDigitalAdsInC360EventsProcess : FormSubmit_CrtDigitalAdsInC360EventsProcess<FormSubmit>
	{

		public FormSubmit_CrtDigitalAdsInC360EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FormSubmit_CrtDigitalAdsInC360EventsProcess

	public partial class FormSubmit_CrtDigitalAdsInC360EventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: FormSubmitEventsProcess

	/// <exclude/>
	public class FormSubmitEventsProcess : FormSubmit_CrtDigitalAdsInC360EventsProcess
	{

		public FormSubmitEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

