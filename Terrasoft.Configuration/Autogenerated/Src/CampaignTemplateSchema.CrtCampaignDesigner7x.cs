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

	#region Class: CampaignTemplateSchema

	/// <exclude/>
	public class CampaignTemplateSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CampaignTemplateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CampaignTemplateSchema(CampaignTemplateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CampaignTemplateSchema(CampaignTemplateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1707d5fd-0541-7856-cd1c-959205347eec");
			RealUId = new Guid("1707d5fd-0541-7856-cd1c-959205347eec");
			Name = "CampaignTemplate";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("119e3feb-c272-4d8b-b291-c4ee68498e16");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c8d033c9-8202-d61a-7d24-a7492faf5396")) == null) {
				Columns.Add(CreatePreviewImageColumn());
			}
			if (Columns.FindByUId(new Guid("a9a60e0d-2067-329a-75b2-823cac792cab")) == null) {
				Columns.Add(CreateTemplateConfigColumn());
			}
			if (Columns.FindByUId(new Guid("e3b7ca55-c0fd-090a-e5e1-48d216f738a6")) == null) {
				Columns.Add(CreateCaptionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePreviewImageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c8d033c9-8202-d61a-7d24-a7492faf5396"),
				Name = @"PreviewImage",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1707d5fd-0541-7856-cd1c-959205347eec"),
				ModifiedInSchemaUId = new Guid("1707d5fd-0541-7856-cd1c-959205347eec"),
				CreatedInPackageId = new Guid("119e3feb-c272-4d8b-b291-c4ee68498e16")
			};
		}

		protected virtual EntitySchemaColumn CreateTemplateConfigColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("a9a60e0d-2067-329a-75b2-823cac792cab"),
				Name = @"TemplateConfig",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("1707d5fd-0541-7856-cd1c-959205347eec"),
				ModifiedInSchemaUId = new Guid("1707d5fd-0541-7856-cd1c-959205347eec"),
				CreatedInPackageId = new Guid("119e3feb-c272-4d8b-b291-c4ee68498e16")
			};
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("e3b7ca55-c0fd-090a-e5e1-48d216f738a6"),
				Name = @"Caption",
				CreatedInSchemaUId = new Guid("1707d5fd-0541-7856-cd1c-959205347eec"),
				ModifiedInSchemaUId = new Guid("1707d5fd-0541-7856-cd1c-959205347eec"),
				CreatedInPackageId = new Guid("119e3feb-c272-4d8b-b291-c4ee68498e16")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CampaignTemplate(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CampaignTemplate_CrtCampaignDesigner7xEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CampaignTemplateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CampaignTemplateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1707d5fd-0541-7856-cd1c-959205347eec"));
		}

		#endregion

	}

	#endregion

	#region Class: CampaignTemplate

	/// <summary>
	/// Campaign template.
	/// </summary>
	public class CampaignTemplate : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CampaignTemplate(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CampaignTemplate";
		}

		public CampaignTemplate(CampaignTemplate source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid PreviewImageId {
			get {
				return GetTypedColumnValue<Guid>("PreviewImageId");
			}
			set {
				SetColumnValue("PreviewImageId", value);
				_previewImage = null;
			}
		}

		/// <exclude/>
		public string PreviewImageName {
			get {
				return GetTypedColumnValue<string>("PreviewImageName");
			}
			set {
				SetColumnValue("PreviewImageName", value);
				if (_previewImage != null) {
					_previewImage.Name = value;
				}
			}
		}

		private SysImage _previewImage;
		/// <summary>
		/// PreviewImage.
		/// </summary>
		public SysImage PreviewImage {
			get {
				return _previewImage ??
					(_previewImage = LookupColumnEntities.GetEntity("PreviewImage") as SysImage);
			}
		}

		/// <summary>
		/// TemplateConfig.
		/// </summary>
		public string TemplateConfig {
			get {
				return GetTypedColumnValue<string>("TemplateConfig");
			}
			set {
				SetColumnValue("TemplateConfig", value);
			}
		}

		/// <summary>
		/// Caption.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CampaignTemplate_CrtCampaignDesigner7xEventsProcess(UserConnection);
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
			return new CampaignTemplate(this);
		}

		#endregion

	}

	#endregion

	#region Class: CampaignTemplate_CrtCampaignDesigner7xEventsProcess

	/// <exclude/>
	public partial class CampaignTemplate_CrtCampaignDesigner7xEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : CampaignTemplate
	{

		public CampaignTemplate_CrtCampaignDesigner7xEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CampaignTemplate_CrtCampaignDesigner7xEventsProcess";
			SchemaUId = new Guid("1707d5fd-0541-7856-cd1c-959205347eec");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1707d5fd-0541-7856-cd1c-959205347eec");
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

	#region Class: CampaignTemplate_CrtCampaignDesigner7xEventsProcess

	/// <exclude/>
	public class CampaignTemplate_CrtCampaignDesigner7xEventsProcess : CampaignTemplate_CrtCampaignDesigner7xEventsProcess<CampaignTemplate>
	{

		public CampaignTemplate_CrtCampaignDesigner7xEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CampaignTemplate_CrtCampaignDesigner7xEventsProcess

	public partial class CampaignTemplate_CrtCampaignDesigner7xEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CampaignTemplateEventsProcess

	/// <exclude/>
	public class CampaignTemplateEventsProcess : CampaignTemplate_CrtCampaignDesigner7xEventsProcess
	{

		public CampaignTemplateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

