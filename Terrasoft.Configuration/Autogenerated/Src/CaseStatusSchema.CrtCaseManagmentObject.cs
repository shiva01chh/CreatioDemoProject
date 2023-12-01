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

	#region Class: CaseStatusSchema

	/// <exclude/>
	public class CaseStatusSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public CaseStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CaseStatusSchema(CaseStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CaseStatusSchema(CaseStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c");
			RealUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c");
			Name = "CaseStatus";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryImageColumn() {
			base.InitializePrimaryImageColumn();
			PrimaryImageColumn = CreateImageColumn();
			if (Columns.FindByUId(PrimaryImageColumn.UId) == null) {
				Columns.Add(PrimaryImageColumn);
			}
		}

		protected override void InitializePrimaryColorColumn() {
			base.InitializePrimaryColorColumn();
			PrimaryColorColumn = CreateStatusColorColumn();
			if (Columns.FindByUId(PrimaryColorColumn.UId) == null) {
				Columns.Add(PrimaryColorColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b78647f6-76db-4d25-b665-00fce475324e")) == null) {
				Columns.Add(CreateIsFinalColumn());
			}
			if (Columns.FindByUId(new Guid("98771b3f-7dbe-4b12-a017-0ab8d406a02a")) == null) {
				Columns.Add(CreateIsResolvedColumn());
			}
			if (Columns.FindByUId(new Guid("0a97a9ee-3cf1-4e17-ae9c-b06583f4b46e")) == null) {
				Columns.Add(CreateIsPausedColumn());
			}
			if (Columns.FindByUId(new Guid("d9eb669f-19ca-4666-bafd-031771bb5f10")) == null) {
				Columns.Add(CreateButtonCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("6c9aee5b-b638-4271-adcc-ed4725905bf8")) == null) {
				Columns.Add(CreateClosureCodeColumn());
			}
			if (Columns.FindByUId(new Guid("c2180cbe-13ad-4ad0-bbc5-ae229f8c1526")) == null) {
				Columns.Add(CreateIsCloseOnSaveColumn());
			}
			if (Columns.FindByUId(new Guid("ae2d9da9-d348-4102-b873-3cfee70fa119")) == null) {
				Columns.Add(CreateColorColumn());
			}
			if (Columns.FindByUId(new Guid("5cafa2ad-ff58-42a8-964a-d500c00a5387")) == null) {
				Columns.Add(CreateIsDisplayedColumn());
			}
			if (Columns.FindByUId(new Guid("bf194ba2-93db-48f8-9bb6-5cb160bf8869")) == null) {
				Columns.Add(CreateStageNumberColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected virtual EntitySchemaColumn CreateIsFinalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("b78647f6-76db-4d25-b665-00fce475324e"),
				Name = @"IsFinal",
				CreatedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			};
		}

		protected virtual EntitySchemaColumn CreateIsResolvedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("98771b3f-7dbe-4b12-a017-0ab8d406a02a"),
				Name = @"IsResolved",
				CreatedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateIsPausedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("0a97a9ee-3cf1-4e17-ae9c-b06583f4b46e"),
				Name = @"IsPaused",
				CreatedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				CreatedInPackageId = new Guid("d7034329-b0c9-4f8a-ab80-129b052eadf0")
			};
		}

		protected virtual EntitySchemaColumn CreateButtonCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("d9eb669f-19ca-4666-bafd-031771bb5f10"),
				Name = @"ButtonCaption",
				CreatedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateClosureCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6c9aee5b-b638-4271-adcc-ed4725905bf8"),
				Name = @"ClosureCode",
				ReferenceSchemaUId = new Guid("66827e0a-27d4-4616-b69a-ac6321b7be52"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f")
			};
		}

		protected virtual EntitySchemaColumn CreateIsCloseOnSaveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c2180cbe-13ad-4ad0-bbc5-ae229f8c1526"),
				Name = @"IsCloseOnSave",
				CreatedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f")
			};
		}

		protected virtual EntitySchemaColumn CreateImageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ImageLookup")) {
				UId = new Guid("88e06ee3-f590-4e50-bc54-565b2958a71a"),
				Name = @"Image",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				CreatedInPackageId = new Guid("929cabc0-d698-46a7-abcf-c0c1bddab661")
			};
		}

		protected virtual EntitySchemaColumn CreateColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("ae2d9da9-d348-4102-b873-3cfee70fa119"),
				Name = @"Color",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f")
			};
		}

		protected virtual EntitySchemaColumn CreateIsDisplayedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5cafa2ad-ff58-42a8-964a-d500c00a5387"),
				Name = @"IsDisplayed",
				CreatedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f")
			};
		}

		protected virtual EntitySchemaColumn CreateStageNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("bf194ba2-93db-48f8-9bb6-5cb160bf8869"),
				Name = @"StageNumber",
				CreatedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Color")) {
				UId = new Guid("4bcd583f-cc07-c72f-ae51-b6665ba7570b"),
				Name = @"StatusColor",
				CreatedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				ModifiedInSchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"),
				CreatedInPackageId = new Guid("0d3d36e6-4bde-4001-82d8-c1ab3fe448d1")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CaseStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CaseStatus_CrtCaseManagmentObjectEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CaseStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CaseStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c"));
		}

		#endregion

	}

	#endregion

	#region Class: CaseStatus

	/// <summary>
	/// Case status.
	/// </summary>
	public class CaseStatus : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public CaseStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CaseStatus";
		}

		public CaseStatus(CaseStatus source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Status is final.
		/// </summary>
		public bool IsFinal {
			get {
				return GetTypedColumnValue<bool>("IsFinal");
			}
			set {
				SetColumnValue("IsFinal", value);
			}
		}

		/// <summary>
		/// Resolved status.
		/// </summary>
		public bool IsResolved {
			get {
				return GetTypedColumnValue<bool>("IsResolved");
			}
			set {
				SetColumnValue("IsResolved", value);
			}
		}

		/// <summary>
		/// Paused status.
		/// </summary>
		public bool IsPaused {
			get {
				return GetTypedColumnValue<bool>("IsPaused");
			}
			set {
				SetColumnValue("IsPaused", value);
			}
		}

		/// <summary>
		/// Button caption.
		/// </summary>
		public string ButtonCaption {
			get {
				return GetTypedColumnValue<string>("ButtonCaption");
			}
			set {
				SetColumnValue("ButtonCaption", value);
			}
		}

		/// <exclude/>
		public Guid ClosureCodeId {
			get {
				return GetTypedColumnValue<Guid>("ClosureCodeId");
			}
			set {
				SetColumnValue("ClosureCodeId", value);
				_closureCode = null;
			}
		}

		/// <exclude/>
		public string ClosureCodeName {
			get {
				return GetTypedColumnValue<string>("ClosureCodeName");
			}
			set {
				SetColumnValue("ClosureCodeName", value);
				if (_closureCode != null) {
					_closureCode.Name = value;
				}
			}
		}

		private ClosureCode _closureCode;
		/// <summary>
		/// Reason for closing.
		/// </summary>
		public ClosureCode ClosureCode {
			get {
				return _closureCode ??
					(_closureCode = LookupColumnEntities.GetEntity("ClosureCode") as ClosureCode);
			}
		}

		/// <summary>
		/// Close after saving.
		/// </summary>
		public bool IsCloseOnSave {
			get {
				return GetTypedColumnValue<bool>("IsCloseOnSave");
			}
			set {
				SetColumnValue("IsCloseOnSave", value);
			}
		}

		/// <exclude/>
		public Guid ImageId {
			get {
				return GetTypedColumnValue<Guid>("ImageId");
			}
			set {
				SetColumnValue("ImageId", value);
				_image = null;
			}
		}

		/// <exclude/>
		public string ImageName {
			get {
				return GetTypedColumnValue<string>("ImageName");
			}
			set {
				SetColumnValue("ImageName", value);
				if (_image != null) {
					_image.Name = value;
				}
			}
		}

		private SysImage _image;
		/// <summary>
		/// Image.
		/// </summary>
		public SysImage Image {
			get {
				return _image ??
					(_image = LookupColumnEntities.GetEntity("Image") as SysImage);
			}
		}

		/// <summary>
		/// Color.
		/// </summary>
		public string Color {
			get {
				return GetTypedColumnValue<string>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		/// <summary>
		/// IsDisplayed.
		/// </summary>
		public bool IsDisplayed {
			get {
				return GetTypedColumnValue<bool>("IsDisplayed");
			}
			set {
				SetColumnValue("IsDisplayed", value);
			}
		}

		/// <summary>
		/// StageNumber.
		/// </summary>
		public int StageNumber {
			get {
				return GetTypedColumnValue<int>("StageNumber");
			}
			set {
				SetColumnValue("StageNumber", value);
			}
		}

		/// <summary>
		/// Status Color.
		/// </summary>
		public Color StatusColor {
			get {
				return GetTypedColumnValue<Color>("StatusColor");
			}
			set {
				SetColumnValue("StatusColor", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CaseStatus_CrtCaseManagmentObjectEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CaseStatusDeleted", e);
			Inserting += (s, e) => ThrowEvent("CaseStatusInserting", e);
			Validating += (s, e) => ThrowEvent("CaseStatusValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CaseStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: CaseStatus_CrtCaseManagmentObjectEventsProcess

	/// <exclude/>
	public partial class CaseStatus_CrtCaseManagmentObjectEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : CaseStatus
	{

		public CaseStatus_CrtCaseManagmentObjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CaseStatus_CrtCaseManagmentObjectEventsProcess";
			SchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c");
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

	#region Class: CaseStatus_CrtCaseManagmentObjectEventsProcess

	/// <exclude/>
	public class CaseStatus_CrtCaseManagmentObjectEventsProcess : CaseStatus_CrtCaseManagmentObjectEventsProcess<CaseStatus>
	{

		public CaseStatus_CrtCaseManagmentObjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CaseStatus_CrtCaseManagmentObjectEventsProcess

	public partial class CaseStatus_CrtCaseManagmentObjectEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CaseStatusEventsProcess

	/// <exclude/>
	public class CaseStatusEventsProcess : CaseStatus_CrtCaseManagmentObjectEventsProcess
	{

		public CaseStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

