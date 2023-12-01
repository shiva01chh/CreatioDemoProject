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
	using System.Security;
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
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: BaseTag_CrtBase_TerrasoftSchema

	/// <exclude/>
	[IsVirtual]
	public class BaseTag_CrtBase_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BaseTag_CrtBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BaseTag_CrtBase_TerrasoftSchema(BaseTag_CrtBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BaseTag_CrtBase_TerrasoftSchema(BaseTag_CrtBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439");
			RealUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439");
			Name = "BaseTag_CrtBase_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704");
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

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f2e0d52d-58a4-4d49-aa03-89f023007a40")) == null) {
				Columns.Add(CreateTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f2e0d52d-58a4-4d49-aa03-89f023007a40"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("10970fa5-3714-4d73-968c-4e411dd7d691"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439"),
				ModifiedInSchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439"),
				CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"8d7f6d6c-4ca5-4b43-bdd9-a5e01a582260"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("43733df0-6000-45de-861c-88d3b8821a46"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439"),
				ModifiedInSchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439"),
				CreatedInPackageId = new Guid("33fd549c-d822-4724-9446-a45b07d23a52")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BaseTag_CrtBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BaseTag_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BaseTag_CrtBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BaseTag_CrtBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9e3f203c-e905-4de5-9468-335b193f2439"));
		}

		#endregion

	}

	#endregion

	#region Class: BaseTag_CrtBase_Terrasoft

	/// <summary>
	/// Base tag.
	/// </summary>
	public class BaseTag_CrtBase_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BaseTag_CrtBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BaseTag_CrtBase_Terrasoft";
		}

		public BaseTag_CrtBase_Terrasoft(BaseTag_CrtBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private TagType _type;
		/// <summary>
		/// Tag type.
		/// </summary>
		public TagType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as TagType);
			}
		}

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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BaseTag_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BaseTag_CrtBase_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("BaseTag_CrtBase_TerrasoftDeleting", e);
			Inserting += (s, e) => ThrowEvent("BaseTag_CrtBase_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("BaseTag_CrtBase_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("BaseTag_CrtBase_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("BaseTag_CrtBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseTag_CrtBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: BaseTag_CrtBaseEventsProcess

	/// <exclude/>
	public partial class BaseTag_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : BaseTag_CrtBase_Terrasoft
	{

		public BaseTag_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseTag_CrtBaseEventsProcess";
			SchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9e3f203c-e905-4de5-9468-335b193f2439");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _baseTagEventSubProcess;
		public ProcessFlowElement BaseTagEventSubProcess {
			get {
				return _baseTagEventSubProcess ?? (_baseTagEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseTagEventSubProcess",
					SchemaElementUId = new Guid("6dbf5dda-4d64-4099-884a-494cd8f0c095"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseTagInsertingStartMessage;
		public ProcessFlowElement BaseTagInsertingStartMessage {
			get {
				return _baseTagInsertingStartMessage ?? (_baseTagInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseTagInsertingStartMessage",
					SchemaElementUId = new Guid("a1b270cb-8f4b-4c6e-b4e1-b9f9b340d7ff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseTagSavingStartMessage;
		public ProcessFlowElement BaseTagSavingStartMessage {
			get {
				return _baseTagSavingStartMessage ?? (_baseTagSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseTagSavingStartMessage",
					SchemaElementUId = new Guid("b8e4b061-3d27-4de5-b413-6456b12b2046"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseTagDeletingStartMessage;
		public ProcessFlowElement BaseTagDeletingStartMessage {
			get {
				return _baseTagDeletingStartMessage ?? (_baseTagDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseTagDeletingStartMessage",
					SchemaElementUId = new Guid("ec4af0d1-59ee-437e-9c22-02846b20380f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkCanManageTagsScriptTask;
		public ProcessScriptTask CheckCanManageTagsScriptTask {
			get {
				return _checkCanManageTagsScriptTask ?? (_checkCanManageTagsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckCanManageTagsScriptTask",
					SchemaElementUId = new Guid("8aad90ac-cf62-4d8f-86f6-b492225d55aa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckCanManageTagsScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _baseTagOnSavedSubProcess;
		public ProcessFlowElement BaseTagOnSavedSubProcess {
			get {
				return _baseTagOnSavedSubProcess ?? (_baseTagOnSavedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BaseTagOnSavedSubProcess",
					SchemaElementUId = new Guid("d0c19376-5f7e-406f-9882-6638ea199785"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseTagSavedStartMessage;
		public ProcessFlowElement BaseTagSavedStartMessage {
			get {
				return _baseTagSavedStartMessage ?? (_baseTagSavedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseTagSavedStartMessage",
					SchemaElementUId = new Guid("e8b4239f-7a04-462c-b2c3-afecdf60306d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkTagTypeAndGrantAdditionalRightsScript;
		public ProcessScriptTask CheckTagTypeAndGrantAdditionalRightsScript {
			get {
				return _checkTagTypeAndGrantAdditionalRightsScript ?? (_checkTagTypeAndGrantAdditionalRightsScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckTagTypeAndGrantAdditionalRightsScript",
					SchemaElementUId = new Guid("723ea0a4-edc3-4c98-b16e-06efc59d5608"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckTagTypeAndGrantAdditionalRightsScriptExecute,
				});
			}
		}

		private LocalizableString _changeTypeFailMsg;
		public LocalizableString ChangeTypeFailMsg {
			get {
				return _changeTypeFailMsg ?? (_changeTypeFailMsg = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ChangeTypeFailMsg.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[BaseTagEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseTagEventSubProcess };
			FlowElements[BaseTagInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseTagInsertingStartMessage };
			FlowElements[BaseTagSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseTagSavingStartMessage };
			FlowElements[BaseTagDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseTagDeletingStartMessage };
			FlowElements[CheckCanManageTagsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckCanManageTagsScriptTask };
			FlowElements[BaseTagOnSavedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseTagOnSavedSubProcess };
			FlowElements[BaseTagSavedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseTagSavedStartMessage };
			FlowElements[CheckTagTypeAndGrantAdditionalRightsScript.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckTagTypeAndGrantAdditionalRightsScript };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "BaseTagEventSubProcess":
						break;
					case "BaseTagInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageTagsScriptTask");
						break;
					case "BaseTagSavingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageTagsScriptTask");
						break;
					case "BaseTagDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageTagsScriptTask");
						break;
					case "CheckCanManageTagsScriptTask":
						break;
					case "BaseTagOnSavedSubProcess":
						break;
					case "BaseTagSavedStartMessage":
						e.Context.QueueTasks.Enqueue("CheckTagTypeAndGrantAdditionalRightsScript");
						break;
					case "CheckTagTypeAndGrantAdditionalRightsScript":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("BaseTagInsertingStartMessage");
			ActivatedEventElements.Add("BaseTagSavingStartMessage");
			ActivatedEventElements.Add("BaseTagDeletingStartMessage");
			ActivatedEventElements.Add("BaseTagSavedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "BaseTagEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseTagInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseTagInsertingStartMessage";
					result = BaseTagInsertingStartMessage.Execute(context);
					break;
				case "BaseTagSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseTagSavingStartMessage";
					result = BaseTagSavingStartMessage.Execute(context);
					break;
				case "BaseTagDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseTagDeletingStartMessage";
					result = BaseTagDeletingStartMessage.Execute(context);
					break;
				case "CheckCanManageTagsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckCanManageTagsScriptTask";
					result = CheckCanManageTagsScriptTask.Execute(context, CheckCanManageTagsScriptTaskExecute);
					break;
				case "BaseTagOnSavedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseTagSavedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseTagSavedStartMessage";
					result = BaseTagSavedStartMessage.Execute(context);
					break;
				case "CheckTagTypeAndGrantAdditionalRightsScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckTagTypeAndGrantAdditionalRightsScript";
					result = CheckTagTypeAndGrantAdditionalRightsScript.Execute(context, CheckTagTypeAndGrantAdditionalRightsScriptExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool CheckCanManageTagsScriptTaskExecute(ProcessExecutingContext context) {
			CheckCanManageTags();
			return true;
		}

		public virtual bool CheckTagTypeAndGrantAdditionalRightsScriptExecute(ProcessExecutingContext context) {
			CheckTagTypeAndGrantAdditionalRights();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "BaseTag_CrtBase_TerrasoftInserting":
							if (ActivatedEventElements.Contains("BaseTagInsertingStartMessage")) {
							context.QueueTasks.Enqueue("BaseTagInsertingStartMessage");
						}
						break;
					case "BaseTag_CrtBase_TerrasoftSaving":
							if (ActivatedEventElements.Contains("BaseTagSavingStartMessage")) {
							context.QueueTasks.Enqueue("BaseTagSavingStartMessage");
						}
						break;
					case "BaseTag_CrtBase_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("BaseTagDeletingStartMessage")) {
							context.QueueTasks.Enqueue("BaseTagDeletingStartMessage");
						}
						break;
					case "BaseTag_CrtBase_TerrasoftSaved":
							if (ActivatedEventElements.Contains("BaseTagSavedStartMessage")) {
							context.QueueTasks.Enqueue("BaseTagSavedStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: BaseTag_CrtBaseEventsProcess

	/// <exclude/>
	public class BaseTag_CrtBaseEventsProcess : BaseTag_CrtBaseEventsProcess<BaseTag_CrtBase_Terrasoft>
	{

		public BaseTag_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseTag_CrtBaseEventsProcess

	public partial class BaseTag_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void CheckCanManageTags() {
			Guid typeOldId = Entity.GetTypedOldColumnValue<Guid>("TypeId");
			Guid typeId = Entity.GetTypedColumnValue<Guid>("TypeId");
			if (typeOldId != Guid.Empty && typeOldId != TSConfiguration.TagConsts.PrivateTagTypeUId && typeOldId != typeId) {
				throw new SecurityException(ChangeTypeFailMsg);
			}
			if (typeId == TSConfiguration.TagConsts.CorporateTagTypeUId) {
				UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageCorporateTags");
			}
			if (typeId == TSConfiguration.TagConsts.PublicTagTypeUId) {
				UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManagePublicTags");
			}
		}

		public virtual void CheckTagTypeAndGrantAdditionalRights() {
			Guid typeId = Entity.GetTypedColumnValue<Guid>("TypeId");
			if (typeId == TSConfiguration.TagConsts.CorporateTagTypeUId) {
				UserConnection.DBSecurityEngine.SetEntitySchemaRecordRightLevel(TSConfiguration.BaseConsts.AllEmployersSysAdminUnitUId, 
						Entity.Schema, Entity.PrimaryColumnValue, SchemaRecordRightLevels.All); 
			}
			if (typeId == TSConfiguration.TagConsts.PublicTagTypeUId) {
				UserConnection.DBSecurityEngine.SetEntitySchemaRecordRightLevel(TSConfiguration.BaseConsts.AllEmployersSysAdminUnitUId, 
						Entity.Schema, Entity.PrimaryColumnValue, SchemaRecordRightLevels.All);
			}
		}

		#endregion

	}

	#endregion

}

