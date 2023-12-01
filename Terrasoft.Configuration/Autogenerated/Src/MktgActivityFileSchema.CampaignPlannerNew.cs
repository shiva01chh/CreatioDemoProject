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
	using Terrasoft.Configuration;
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

	#region Class: MktgActivityFile_CampaignPlannerNew_TerrasoftSchema

	/// <exclude/>
	public class MktgActivityFile_CampaignPlannerNew_TerrasoftSchema : Terrasoft.Configuration.FileSchema
	{

		#region Constructors: Public

		public MktgActivityFile_CampaignPlannerNew_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MktgActivityFile_CampaignPlannerNew_TerrasoftSchema(MktgActivityFile_CampaignPlannerNew_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MktgActivityFile_CampaignPlannerNew_TerrasoftSchema(MktgActivityFile_CampaignPlannerNew_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ba59209a-538e-48a3-b031-7b77800155b9");
			RealUId = new Guid("ba59209a-538e-48a3-b031-7b77800155b9");
			Name = "MktgActivityFile_CampaignPlannerNew_Terrasoft";
			ParentSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			ExtendParent = false;
			CreatedInPackageId = new Guid("8a6b5719-da97-4634-8f04-4375bc29ffcf");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d73d1157-8639-4302-b2bc-159f44c35fec")) == null) {
				Columns.Add(CreateMktgActivityColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateMktgActivityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d73d1157-8639-4302-b2bc-159f44c35fec"),
				Name = @"MktgActivity",
				ReferenceSchemaUId = new Guid("8cd7510b-6e4b-487a-8c2b-d0289eaed375"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ba59209a-538e-48a3-b031-7b77800155b9"),
				ModifiedInSchemaUId = new Guid("ba59209a-538e-48a3-b031-7b77800155b9"),
				CreatedInPackageId = new Guid("9b5a87df-8af2-4dd9-9224-84934acee8ef")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MktgActivityFile_CampaignPlannerNew_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MktgActivityFile_CampaignPlannerNewEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MktgActivityFile_CampaignPlannerNew_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MktgActivityFile_CampaignPlannerNew_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba59209a-538e-48a3-b031-7b77800155b9"));
		}

		#endregion

	}

	#endregion

	#region Class: MktgActivityFile_CampaignPlannerNew_Terrasoft

	/// <summary>
	/// File and link of the marketing activity.
	/// </summary>
	public class MktgActivityFile_CampaignPlannerNew_Terrasoft : Terrasoft.Configuration.File
	{

		#region Constructors: Public

		public MktgActivityFile_CampaignPlannerNew_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MktgActivityFile_CampaignPlannerNew_Terrasoft";
		}

		public MktgActivityFile_CampaignPlannerNew_Terrasoft(MktgActivityFile_CampaignPlannerNew_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid MktgActivityId {
			get {
				return GetTypedColumnValue<Guid>("MktgActivityId");
			}
			set {
				SetColumnValue("MktgActivityId", value);
				_mktgActivity = null;
			}
		}

		/// <exclude/>
		public string MktgActivityName {
			get {
				return GetTypedColumnValue<string>("MktgActivityName");
			}
			set {
				SetColumnValue("MktgActivityName", value);
				if (_mktgActivity != null) {
					_mktgActivity.Name = value;
				}
			}
		}

		private MktgActivity _mktgActivity;
		/// <summary>
		/// MarketingActivities.
		/// </summary>
		public MktgActivity MktgActivity {
			get {
				return _mktgActivity ??
					(_mktgActivity = LookupColumnEntities.GetEntity("MktgActivity") as MktgActivity);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MktgActivityFile_CampaignPlannerNewEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MktgActivityFile_CampaignPlannerNew_TerrasoftDeleted", e);
			Updated += (s, e) => ThrowEvent("MktgActivityFile_CampaignPlannerNew_TerrasoftUpdated", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MktgActivityFile_CampaignPlannerNew_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: MktgActivityFile_CampaignPlannerNewEventsProcess

	/// <exclude/>
	public partial class MktgActivityFile_CampaignPlannerNewEventsProcess<TEntity> : Terrasoft.Configuration.File_PRMPortalEventsProcess<TEntity> where TEntity : MktgActivityFile_CampaignPlannerNew_Terrasoft
	{

		public MktgActivityFile_CampaignPlannerNewEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MktgActivityFile_CampaignPlannerNewEventsProcess";
			SchemaUId = new Guid("ba59209a-538e-48a3-b031-7b77800155b9");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ba59209a-538e-48a3-b031-7b77800155b9");
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

	#region Class: MktgActivityFile_CampaignPlannerNewEventsProcess

	/// <exclude/>
	public class MktgActivityFile_CampaignPlannerNewEventsProcess : MktgActivityFile_CampaignPlannerNewEventsProcess<MktgActivityFile_CampaignPlannerNew_Terrasoft>
	{

		public MktgActivityFile_CampaignPlannerNewEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MktgActivityFile_CampaignPlannerNewEventsProcess

	public partial class MktgActivityFile_CampaignPlannerNewEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void OnFileSaved() {
			base.OnFileSaved();
			
			if (!UserConnection.GetIsFeatureEnabled("LinkPreview")) {
				return;
			}
			
			var fileType = Entity.GetTypedColumnValue<Guid>("TypeId");
			if (fileType == Terrasoft.WebApp.FileConsts.LinkTypeUId) {
				var url = Entity.GetTypedColumnValue<string>("Name").Trim();
				if (IsURLValid(url)) {
					LinkPreview linkPreview = new LinkPreview();
					LinkPreviewInfo linkPreviewInfo = linkPreview.GetWebPageLinkPreview(url);
					if (linkPreviewInfo != null) {
						LinkPreviewProvider linkPreviewProvider = new LinkPreviewProvider(UserConnection);
						linkPreviewProvider.SaveLinkPreviewInfo(linkPreviewInfo, Entity.PrimaryColumnValue);
					}
				}
			}
		}

		public override void OnFileDeleted() {
			base.OnFileDeleted();
			
			if (!UserConnection.GetIsFeatureEnabled("LinkPreview")) {
				return;
			}
			
			var fileType = Entity.GetTypedColumnValue<Guid>("TypeId");
			if (fileType == Terrasoft.WebApp.FileConsts.LinkTypeUId) {
				LinkPreviewProvider linkPreviewProvider = new LinkPreviewProvider(UserConnection);
				linkPreviewProvider.DeleteLinkPreviewInfo(Entity.PrimaryColumnValue);
			}
		}

		public override void OnFileUpdated() {
			base.OnFileUpdated();
			
			if (!UserConnection.GetIsFeatureEnabled("LinkPreview")) {
				return;
			}
			
			var fileType = Entity.GetTypedColumnValue<Guid>("TypeId");
			string oldUrl = (string)Entity.GetColumnOldValue("Name");
			if (fileType == Terrasoft.WebApp.FileConsts.LinkTypeUId && IsURLValid(oldUrl)) {
				LinkPreviewProvider linkPreviewProvider = new LinkPreviewProvider(UserConnection);
				linkPreviewProvider.DeleteLinkPreviewInfo(Entity.PrimaryColumnValue);
			}
		}

		#endregion

	}

	#endregion

}

