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

	#region Class: Lead_CrtLeadWebForm_TerrasoftSchema

	/// <exclude/>
	public class Lead_CrtLeadWebForm_TerrasoftSchema : Terrasoft.Configuration.Lead_LeadManagement_TerrasoftSchema
	{

		#region Constructors: Public

		public Lead_CrtLeadWebForm_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Lead_CrtLeadWebForm_TerrasoftSchema(Lead_CrtLeadWebForm_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Lead_CrtLeadWebForm_TerrasoftSchema(Lead_CrtLeadWebForm_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIDX_LeadNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("bf3f62f3-5d38-4031-a648-58b036f8f19d");
			index.Name = "IDX_LeadName";
			index.CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			EntitySchemaIndexColumn leadNameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2c3ed9bd-ff44-447d-b4af-c6a4e4090a5a"),
				ColumnUId = new Guid("d06ba9af-faf5-4741-a672-e154ae561a94"),
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(leadNameIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f");
			Name = "Lead_CrtLeadWebForm_Terrasoft";
			ParentSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			ExtendParent = true;
			CreatedInPackageId = new Guid("a46bf3d3-6d35-4c34-bc3d-e73ca3ed6ca5");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("9389d289-6386-48fc-9bd5-2c5872332662")) == null) {
				Columns.Add(CreateWebFormColumn());
			}
			if (Columns.FindByUId(new Guid("33099014-9741-4d65-aec1-8f0fbe5da8b3")) == null) {
				Columns.Add(CreateBpmHrefColumn());
			}
			if (Columns.FindByUId(new Guid("80755b15-6dcc-400e-99ad-cfd9ac5a08a9")) == null) {
				Columns.Add(CreateBpmRefColumn());
			}
			if (Columns.FindByUId(new Guid("d8baa746-82cc-1b55-abcf-13e2db7e2309")) == null) {
				Columns.Add(CreateUtmCampaignStrColumn());
			}
			if (Columns.FindByUId(new Guid("85666068-4c3d-0968-fa27-165985631c70")) == null) {
				Columns.Add(CreateUtmSourceStrColumn());
			}
			if (Columns.FindByUId(new Guid("f8776a9d-498f-ebf3-5441-d2308dbbcf8d")) == null) {
				Columns.Add(CreateUtmMediumStrColumn());
			}
			if (Columns.FindByUId(new Guid("ce01b0f3-cc69-71d5-acdf-3fbedb3b838e")) == null) {
				Columns.Add(CreateUtmContentStrColumn());
			}
			if (Columns.FindByUId(new Guid("83d45e28-1232-b6af-80a6-e14b15399e67")) == null) {
				Columns.Add(CreateUtmTermStrColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateWebFormColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9389d289-6386-48fc-9bd5-2c5872332662"),
				Name = @"WebForm",
				ReferenceSchemaUId = new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f"),
				ModifiedInSchemaUId = new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f"),
				CreatedInPackageId = new Guid("a46bf3d3-6d35-4c34-bc3d-e73ca3ed6ca5")
			};
		}

		protected virtual EntitySchemaColumn CreateBpmHrefColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("33099014-9741-4d65-aec1-8f0fbe5da8b3"),
				Name = @"BpmHref",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f"),
				ModifiedInSchemaUId = new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f"),
				CreatedInPackageId = new Guid("a46bf3d3-6d35-4c34-bc3d-e73ca3ed6ca5")
			};
		}

		protected virtual EntitySchemaColumn CreateBpmRefColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("80755b15-6dcc-400e-99ad-cfd9ac5a08a9"),
				Name = @"BpmRef",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f"),
				ModifiedInSchemaUId = new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f"),
				CreatedInPackageId = new Guid("a46bf3d3-6d35-4c34-bc3d-e73ca3ed6ca5")
			};
		}

		protected virtual EntitySchemaColumn CreateUtmCampaignStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("d8baa746-82cc-1b55-abcf-13e2db7e2309"),
				Name = @"UtmCampaignStr",
				CreatedInSchemaUId = new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f"),
				ModifiedInSchemaUId = new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f"),
				CreatedInPackageId = new Guid("a46bf3d3-6d35-4c34-bc3d-e73ca3ed6ca5")
			};
		}

		protected virtual EntitySchemaColumn CreateUtmSourceStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("85666068-4c3d-0968-fa27-165985631c70"),
				Name = @"UtmSourceStr",
				CreatedInSchemaUId = new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f"),
				ModifiedInSchemaUId = new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f"),
				CreatedInPackageId = new Guid("a46bf3d3-6d35-4c34-bc3d-e73ca3ed6ca5")
			};
		}

		protected virtual EntitySchemaColumn CreateUtmMediumStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("f8776a9d-498f-ebf3-5441-d2308dbbcf8d"),
				Name = @"UtmMediumStr",
				CreatedInSchemaUId = new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f"),
				ModifiedInSchemaUId = new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f"),
				CreatedInPackageId = new Guid("a46bf3d3-6d35-4c34-bc3d-e73ca3ed6ca5")
			};
		}

		protected virtual EntitySchemaColumn CreateUtmContentStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("ce01b0f3-cc69-71d5-acdf-3fbedb3b838e"),
				Name = @"UtmContentStr",
				CreatedInSchemaUId = new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f"),
				ModifiedInSchemaUId = new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f"),
				CreatedInPackageId = new Guid("a46bf3d3-6d35-4c34-bc3d-e73ca3ed6ca5")
			};
		}

		protected virtual EntitySchemaColumn CreateUtmTermStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("83d45e28-1232-b6af-80a6-e14b15399e67"),
				Name = @"UtmTermStr",
				CreatedInSchemaUId = new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f"),
				ModifiedInSchemaUId = new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f"),
				CreatedInPackageId = new Guid("a46bf3d3-6d35-4c34-bc3d-e73ca3ed6ca5")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIDX_LeadNameIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Lead_CrtLeadWebForm_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Lead_CrtLeadWebFormEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Lead_CrtLeadWebForm_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Lead_CrtLeadWebForm_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CrtLeadWebForm_Terrasoft

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead_CrtLeadWebForm_Terrasoft : Terrasoft.Configuration.Lead_LeadManagement_Terrasoft
	{

		#region Constructors: Public

		public Lead_CrtLeadWebForm_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead_CrtLeadWebForm_Terrasoft";
		}

		public Lead_CrtLeadWebForm_Terrasoft(Lead_CrtLeadWebForm_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid WebFormId {
			get {
				return GetTypedColumnValue<Guid>("WebFormId");
			}
			set {
				SetColumnValue("WebFormId", value);
				_webForm = null;
			}
		}

		/// <exclude/>
		public string WebFormName {
			get {
				return GetTypedColumnValue<string>("WebFormName");
			}
			set {
				SetColumnValue("WebFormName", value);
				if (_webForm != null) {
					_webForm.Name = value;
				}
			}
		}

		private GeneratedWebForm _webForm;
		/// <summary>
		/// Landing page.
		/// </summary>
		public GeneratedWebForm WebForm {
			get {
				return _webForm ??
					(_webForm = LookupColumnEntities.GetEntity("WebForm") as GeneratedWebForm);
			}
		}

		/// <summary>
		/// BpmHref.
		/// </summary>
		public string BpmHref {
			get {
				return GetTypedColumnValue<string>("BpmHref");
			}
			set {
				SetColumnValue("BpmHref", value);
			}
		}

		/// <summary>
		/// Redirection website.
		/// </summary>
		public string BpmRef {
			get {
				return GetTypedColumnValue<string>("BpmRef");
			}
			set {
				SetColumnValue("BpmRef", value);
			}
		}

		/// <summary>
		/// utm_campaign.
		/// </summary>
		public string UtmCampaignStr {
			get {
				return GetTypedColumnValue<string>("UtmCampaignStr");
			}
			set {
				SetColumnValue("UtmCampaignStr", value);
			}
		}

		/// <summary>
		/// utm_source.
		/// </summary>
		public string UtmSourceStr {
			get {
				return GetTypedColumnValue<string>("UtmSourceStr");
			}
			set {
				SetColumnValue("UtmSourceStr", value);
			}
		}

		/// <summary>
		/// utm_medium.
		/// </summary>
		public string UtmMediumStr {
			get {
				return GetTypedColumnValue<string>("UtmMediumStr");
			}
			set {
				SetColumnValue("UtmMediumStr", value);
			}
		}

		/// <summary>
		/// utm_content.
		/// </summary>
		public string UtmContentStr {
			get {
				return GetTypedColumnValue<string>("UtmContentStr");
			}
			set {
				SetColumnValue("UtmContentStr", value);
			}
		}

		/// <summary>
		/// utm_term.
		/// </summary>
		public string UtmTermStr {
			get {
				return GetTypedColumnValue<string>("UtmTermStr");
			}
			set {
				SetColumnValue("UtmTermStr", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_CrtLeadWebFormEventsProcess(UserConnection);
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
			return new Lead_CrtLeadWebForm_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CrtLeadWebFormEventsProcess

	/// <exclude/>
	public partial class Lead_CrtLeadWebFormEventsProcess<TEntity> : Terrasoft.Configuration.Lead_LeadManagementEventsProcess<TEntity> where TEntity : Lead_CrtLeadWebForm_Terrasoft
	{

		public Lead_CrtLeadWebFormEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_CrtLeadWebFormEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("09ed5419-9a30-4149-bf0a-2e7861b9c55f");
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

	#region Class: Lead_CrtLeadWebFormEventsProcess

	/// <exclude/>
	public class Lead_CrtLeadWebFormEventsProcess : Lead_CrtLeadWebFormEventsProcess<Lead_CrtLeadWebForm_Terrasoft>
	{

		public Lead_CrtLeadWebFormEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

