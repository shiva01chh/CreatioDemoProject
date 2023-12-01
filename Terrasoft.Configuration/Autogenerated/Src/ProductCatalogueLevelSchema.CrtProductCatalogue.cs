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

	#region Class: ProductCatalogueLevel_CrtProductCatalogue_TerrasoftSchema

	/// <exclude/>
	public class ProductCatalogueLevel_CrtProductCatalogue_TerrasoftSchema : Terrasoft.Configuration.BaseEntityWithPositionSchema
	{

		#region Constructors: Public

		public ProductCatalogueLevel_CrtProductCatalogue_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductCatalogueLevel_CrtProductCatalogue_TerrasoftSchema(ProductCatalogueLevel_CrtProductCatalogue_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductCatalogueLevel_CrtProductCatalogue_TerrasoftSchema(ProductCatalogueLevel_CrtProductCatalogue_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			RealUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			Name = "ProductCatalogueLevel_CrtProductCatalogue_Terrasoft";
			ParentSchemaUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializePrimaryOrderColumn() {
			base.InitializePrimaryOrderColumn();
			PrimaryOrderColumn = CreatePositionColumn();
			if (Columns.FindByUId(PrimaryOrderColumn.UId) == null) {
				Columns.Add(PrimaryOrderColumn);
			}
		}

		protected override void InitializeOwnerColumn() {
			base.InitializeOwnerColumn();
			OwnerColumn = CreateCreatedByColumn();
			if (Columns.FindByUId(OwnerColumn.UId) == null) {
				Columns.Add(OwnerColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("11536eea-7fb7-4afe-826f-8111a5490a74")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("c0388918-b497-4635-a136-cd125a6474ce")) == null) {
				Columns.Add(CreateColumnCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("7e2a9c23-8528-4e3c-acc0-c4ed42bd9c65")) == null) {
				Columns.Add(CreateColumnPathColumn());
			}
			if (Columns.FindByUId(new Guid("015b2058-0373-438a-86bb-e690d5164fbc")) == null) {
				Columns.Add(CreateReferenceSchemaNameColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreatePositionColumn() {
			EntitySchemaColumn column = base.CreatePositionColumn();
			column.ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("06940a6e-2b82-480b-b530-8a9b838ca679"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("11536eea-7fb7-4afe-826f-8111a5490a74"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("c0388918-b497-4635-a136-cd125a6474ce"),
				Name = @"ColumnCaption",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateColumnPathColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("7e2a9c23-8528-4e3c-acc0-c4ed42bd9c65"),
				Name = @"ColumnPath",
				CreatedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateReferenceSchemaNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("015b2058-0373-438a-86bb-e690d5164fbc"),
				Name = @"ReferenceSchemaName",
				CreatedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				ModifiedInSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProductCatalogueLevel_CrtProductCatalogue_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductCatalogueLevel_CrtProductCatalogueEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductCatalogueLevel_CrtProductCatalogue_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductCatalogueLevel_CrtProductCatalogue_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductCatalogueLevel_CrtProductCatalogue_Terrasoft

	/// <summary>
	/// Product catalog level.
	/// </summary>
	public class ProductCatalogueLevel_CrtProductCatalogue_Terrasoft : Terrasoft.Configuration.BaseEntityWithPosition
	{

		#region Constructors: Public

		public ProductCatalogueLevel_CrtProductCatalogue_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductCatalogueLevel_CrtProductCatalogue_Terrasoft";
		}

		public ProductCatalogueLevel_CrtProductCatalogue_Terrasoft(ProductCatalogueLevel_CrtProductCatalogue_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		/// <summary>
		/// Product field.
		/// </summary>
		public string ColumnCaption {
			get {
				return GetTypedColumnValue<string>("ColumnCaption");
			}
			set {
				SetColumnValue("ColumnCaption", value);
			}
		}

		/// <summary>
		/// Column path.
		/// </summary>
		public string ColumnPath {
			get {
				return GetTypedColumnValue<string>("ColumnPath");
			}
			set {
				SetColumnValue("ColumnPath", value);
			}
		}

		/// <summary>
		/// Schema.
		/// </summary>
		public string ReferenceSchemaName {
			get {
				return GetTypedColumnValue<string>("ReferenceSchemaName");
			}
			set {
				SetColumnValue("ReferenceSchemaName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductCatalogueLevel_CrtProductCatalogueEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("ProductCatalogueLevel_CrtProductCatalogue_TerrasoftDeleting", e);
			Inserting += (s, e) => ThrowEvent("ProductCatalogueLevel_CrtProductCatalogue_TerrasoftInserting", e);
			Saving += (s, e) => ThrowEvent("ProductCatalogueLevel_CrtProductCatalogue_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("ProductCatalogueLevel_CrtProductCatalogue_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductCatalogueLevel_CrtProductCatalogue_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductCatalogueLevel_CrtProductCatalogueEventsProcess

	/// <exclude/>
	public partial class ProductCatalogueLevel_CrtProductCatalogueEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityWithPosition_CrtBaseEventsProcess<TEntity> where TEntity : ProductCatalogueLevel_CrtProductCatalogue_Terrasoft
	{

		public ProductCatalogueLevel_CrtProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductCatalogueLevel_CrtProductCatalogueEventsProcess";
			SchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _productCatalogueLevelEventSubProcess;
		public ProcessFlowElement ProductCatalogueLevelEventSubProcess {
			get {
				return _productCatalogueLevelEventSubProcess ?? (_productCatalogueLevelEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ProductCatalogueLevelEventSubProcess",
					SchemaElementUId = new Guid("87a96c21-c10c-427f-9dcb-c09d28470339"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _productCatalogueLevelInsertingStartMessage;
		public ProcessFlowElement ProductCatalogueLevelInsertingStartMessage {
			get {
				return _productCatalogueLevelInsertingStartMessage ?? (_productCatalogueLevelInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProductCatalogueLevelInsertingStartMessage",
					SchemaElementUId = new Guid("b8b62284-30e3-4e5d-acda-44dd0e66e827"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _productCatalogueLevelSavingStartMessage;
		public ProcessFlowElement ProductCatalogueLevelSavingStartMessage {
			get {
				return _productCatalogueLevelSavingStartMessage ?? (_productCatalogueLevelSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProductCatalogueLevelSavingStartMessage",
					SchemaElementUId = new Guid("e6e35e08-df7a-4e9c-bcce-1f94baf92a0e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _productCatalogueLevelDeletingStartMessage;
		public ProcessFlowElement ProductCatalogueLevelDeletingStartMessage {
			get {
				return _productCatalogueLevelDeletingStartMessage ?? (_productCatalogueLevelDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProductCatalogueLevelDeletingStartMessage",
					SchemaElementUId = new Guid("77bb370c-ce35-474d-9678-da4756e2383d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkCanManageLookupsScriptTask;
		public ProcessScriptTask CheckCanManageLookupsScriptTask {
			get {
				return _checkCanManageLookupsScriptTask ?? (_checkCanManageLookupsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckCanManageLookupsScriptTask",
					SchemaElementUId = new Guid("695aee0d-20d6-40fc-b4f9-89906aa4eeec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckCanManageLookupsScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ProductCatalogueLevelEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ProductCatalogueLevelEventSubProcess };
			FlowElements[ProductCatalogueLevelInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ProductCatalogueLevelInsertingStartMessage };
			FlowElements[ProductCatalogueLevelSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ProductCatalogueLevelSavingStartMessage };
			FlowElements[ProductCatalogueLevelDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ProductCatalogueLevelDeletingStartMessage };
			FlowElements[CheckCanManageLookupsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckCanManageLookupsScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ProductCatalogueLevelEventSubProcess":
						break;
					case "ProductCatalogueLevelInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageLookupsScriptTask");
						break;
					case "ProductCatalogueLevelSavingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageLookupsScriptTask");
						break;
					case "ProductCatalogueLevelDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageLookupsScriptTask");
						break;
					case "CheckCanManageLookupsScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ProductCatalogueLevelInsertingStartMessage");
			ActivatedEventElements.Add("ProductCatalogueLevelSavingStartMessage");
			ActivatedEventElements.Add("ProductCatalogueLevelDeletingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ProductCatalogueLevelEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ProductCatalogueLevelInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProductCatalogueLevelInsertingStartMessage";
					result = ProductCatalogueLevelInsertingStartMessage.Execute(context);
					break;
				case "ProductCatalogueLevelSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProductCatalogueLevelSavingStartMessage";
					result = ProductCatalogueLevelSavingStartMessage.Execute(context);
					break;
				case "ProductCatalogueLevelDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProductCatalogueLevelDeletingStartMessage";
					result = ProductCatalogueLevelDeletingStartMessage.Execute(context);
					break;
				case "CheckCanManageLookupsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckCanManageLookupsScriptTask";
					result = CheckCanManageLookupsScriptTask.Execute(context, CheckCanManageLookupsScriptTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool CheckCanManageLookupsScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageLookups");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ProductCatalogueLevel_CrtProductCatalogue_TerrasoftInserting":
							if (ActivatedEventElements.Contains("ProductCatalogueLevelInsertingStartMessage")) {
							context.QueueTasks.Enqueue("ProductCatalogueLevelInsertingStartMessage");
						}
						break;
					case "ProductCatalogueLevel_CrtProductCatalogue_TerrasoftSaving":
							if (ActivatedEventElements.Contains("ProductCatalogueLevelSavingStartMessage")) {
							context.QueueTasks.Enqueue("ProductCatalogueLevelSavingStartMessage");
						}
						break;
					case "ProductCatalogueLevel_CrtProductCatalogue_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("ProductCatalogueLevelDeletingStartMessage")) {
							context.QueueTasks.Enqueue("ProductCatalogueLevelDeletingStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: ProductCatalogueLevel_CrtProductCatalogueEventsProcess

	/// <exclude/>
	public class ProductCatalogueLevel_CrtProductCatalogueEventsProcess : ProductCatalogueLevel_CrtProductCatalogueEventsProcess<ProductCatalogueLevel_CrtProductCatalogue_Terrasoft>
	{

		public ProductCatalogueLevel_CrtProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductCatalogueLevel_CrtProductCatalogueEventsProcess

	public partial class ProductCatalogueLevel_CrtProductCatalogueEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

