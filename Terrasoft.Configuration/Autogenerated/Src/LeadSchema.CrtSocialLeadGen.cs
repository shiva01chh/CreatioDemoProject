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

	#region Class: Lead_CrtSocialLeadGen_TerrasoftSchema

	/// <exclude/>
	public class Lead_CrtSocialLeadGen_TerrasoftSchema : Terrasoft.Configuration.Lead_MarketingCampaign_TerrasoftSchema
	{

		#region Constructors: Public

		public Lead_CrtSocialLeadGen_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Lead_CrtSocialLeadGen_TerrasoftSchema(Lead_CrtSocialLeadGen_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Lead_CrtSocialLeadGen_TerrasoftSchema(Lead_CrtSocialLeadGen_TerrasoftSchema source)
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
			RealUId = new Guid("e7e8cb16-15e2-b2ad-bfdc-208093ffd700");
			Name = "Lead_CrtSocialLeadGen_Terrasoft";
			ParentSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			ExtendParent = true;
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a6468ddc-9b5d-4416-4e74-06965d13566b")) == null) {
				Columns.Add(CreateLeadGenExtendedLeadInfoColumn());
			}
			if (Columns.FindByUId(new Guid("f7875c95-5490-e1f3-b1de-68c7f9cef845")) == null) {
				Columns.Add(CreateSocialMetadataColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateLeadGenExtendedLeadInfoColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a6468ddc-9b5d-4416-4e74-06965d13566b"),
				Name = @"LeadGenExtendedLeadInfo",
				ReferenceSchemaUId = new Guid("a94aecd6-9df6-48fa-90ec-fbb726b26d47"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e7e8cb16-15e2-b2ad-bfdc-208093ffd700"),
				ModifiedInSchemaUId = new Guid("e7e8cb16-15e2-b2ad-bfdc-208093ffd700"),
				CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31")
			};
		}

		protected virtual EntitySchemaColumn CreateSocialMetadataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("f7875c95-5490-e1f3-b1de-68c7f9cef845"),
				Name = @"SocialMetadata",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("e7e8cb16-15e2-b2ad-bfdc-208093ffd700"),
				ModifiedInSchemaUId = new Guid("e7e8cb16-15e2-b2ad-bfdc-208093ffd700"),
				CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31")
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
			return new Lead_CrtSocialLeadGen_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Lead_CrtSocialLeadGenEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Lead_CrtSocialLeadGen_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Lead_CrtSocialLeadGen_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e7e8cb16-15e2-b2ad-bfdc-208093ffd700"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CrtSocialLeadGen_Terrasoft

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead_CrtSocialLeadGen_Terrasoft : Terrasoft.Configuration.Lead_MarketingCampaign_Terrasoft
	{

		#region Constructors: Public

		public Lead_CrtSocialLeadGen_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead_CrtSocialLeadGen_Terrasoft";
		}

		public Lead_CrtSocialLeadGen_Terrasoft(Lead_CrtSocialLeadGen_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid LeadGenExtendedLeadInfoId {
			get {
				return GetTypedColumnValue<Guid>("LeadGenExtendedLeadInfoId");
			}
			set {
				SetColumnValue("LeadGenExtendedLeadInfoId", value);
				_leadGenExtendedLeadInfo = null;
			}
		}

		private LeadGenExtendedLeadInformation _leadGenExtendedLeadInfo;
		/// <summary>
		/// Extended lead information.
		/// </summary>
		public LeadGenExtendedLeadInformation LeadGenExtendedLeadInfo {
			get {
				return _leadGenExtendedLeadInfo ??
					(_leadGenExtendedLeadInfo = LookupColumnEntities.GetEntity("LeadGenExtendedLeadInfo") as LeadGenExtendedLeadInformation);
			}
		}

		/// <summary>
		/// Social metadata.
		/// </summary>
		public string SocialMetadata {
			get {
				return GetTypedColumnValue<string>("SocialMetadata");
			}
			set {
				SetColumnValue("SocialMetadata", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_CrtSocialLeadGenEventsProcess(UserConnection);
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
			return new Lead_CrtSocialLeadGen_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CrtSocialLeadGenEventsProcess

	/// <exclude/>
	public partial class Lead_CrtSocialLeadGenEventsProcess<TEntity> : Terrasoft.Configuration.Lead_MarketingCampaignEventsProcess<TEntity> where TEntity : Lead_CrtSocialLeadGen_Terrasoft
	{

		public Lead_CrtSocialLeadGenEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_CrtSocialLeadGenEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e7e8cb16-15e2-b2ad-bfdc-208093ffd700");
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

	#region Class: Lead_CrtSocialLeadGenEventsProcess

	/// <exclude/>
	public class Lead_CrtSocialLeadGenEventsProcess : Lead_CrtSocialLeadGenEventsProcess<Lead_CrtSocialLeadGen_Terrasoft>
	{

		public Lead_CrtSocialLeadGenEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Lead_CrtSocialLeadGenEventsProcess

	public partial class Lead_CrtSocialLeadGenEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

