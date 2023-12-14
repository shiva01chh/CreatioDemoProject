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
	using Terrasoft.Core.OperationLog;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using Terrasoft.Web.Common;

	#region Class: VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema

	/// <exclude/>
	public class VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema : Terrasoft.Configuration.VwSysAdminUnit_Translation_TerrasoftSchema
	{

		#region Constructors: Public

		public VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema(VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema(VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("8b7a054d-e633-4373-8d37-249a9920694e");
			Name = "VwSysAdminUnit_WebitelCollaborations_Terrasoft";
			ParentSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364");
			ExtendParent = true;
			CreatedInPackageId = new Guid("b7fb6e74-77cf-499f-8e71-7072f74ac64a");
			IsDBView = true;
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
			return new VwSysAdminUnit_WebitelCollaborations_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysAdminUnit_WebitelCollaborationsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysAdminUnit_WebitelCollaborations_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8b7a054d-e633-4373-8d37-249a9920694e"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysAdminUnit_WebitelCollaborations_Terrasoft

	/// <summary>
	/// Users/roles (view).
	/// </summary>
	public class VwSysAdminUnit_WebitelCollaborations_Terrasoft : Terrasoft.Configuration.VwSysAdminUnit_Translation_Terrasoft
	{

		#region Constructors: Public

		public VwSysAdminUnit_WebitelCollaborations_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysAdminUnit_WebitelCollaborations_Terrasoft";
		}

		public VwSysAdminUnit_WebitelCollaborations_Terrasoft(VwSysAdminUnit_WebitelCollaborations_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysAdminUnit_WebitelCollaborationsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserted += (s, e) => ThrowEvent("VwSysAdminUnit_WebitelCollaborations_TerrasoftInserted", e);
			Validating += (s, e) => ThrowEvent("VwSysAdminUnit_WebitelCollaborations_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysAdminUnit_WebitelCollaborations_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysAdminUnit_WebitelCollaborationsEventsProcess

	/// <exclude/>
	public partial class VwSysAdminUnit_WebitelCollaborationsEventsProcess<TEntity> : Terrasoft.Configuration.VwSysAdminUnit_TranslationEventsProcess<TEntity> where TEntity : VwSysAdminUnit_WebitelCollaborations_Terrasoft
	{

		public VwSysAdminUnit_WebitelCollaborationsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysAdminUnit_WebitelCollaborationsEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			_webitelSymMsgLibId = () => {{ return new Guid("DDA88D7D-19D0-4009-A3EE-192069FD7E64"); }};
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8b7a054d-e633-4373-8d37-249a9920694e");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private Func<Guid> _webitelSymMsgLibId;
		public virtual Guid WebitelSymMsgLibId {
			get {
				return (_webitelSymMsgLibId ?? (_webitelSymMsgLibId = () => Guid.Empty)).Invoke();
			}
			set {
				_webitelSymMsgLibId = () => { return value; };
			}
		}

		private ProcessFlowElement _childVwSysAdminUnitInsertedEventSubProcess;
		public ProcessFlowElement ChildVwSysAdminUnitInsertedEventSubProcess {
			get {
				return _childVwSysAdminUnitInsertedEventSubProcess ?? (_childVwSysAdminUnitInsertedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ChildVwSysAdminUnitInsertedEventSubProcess",
					SchemaElementUId = new Guid("c45333cd-0ad0-42fd-a61c-aef8b5208ac5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childVwSysAdminUnitInsertedStartMessage;
		public ProcessFlowElement ChildVwSysAdminUnitInsertedStartMessage {
			get {
				return _childVwSysAdminUnitInsertedStartMessage ?? (_childVwSysAdminUnitInsertedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildVwSysAdminUnitInsertedStartMessage",
					SchemaElementUId = new Guid("d9ceba15-ad97-4418-bec7-aa8d137fbe3e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _childVwSysAdminUnitInsertedIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent ChildVwSysAdminUnitInsertedIntermediateThrowMessageEvent {
			get {
				return _childVwSysAdminUnitInsertedIntermediateThrowMessageEvent ?? (_childVwSysAdminUnitInsertedIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ChildVwSysAdminUnitInsertedIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("7ac28609-190e-42e4-9dfc-096cbd3cec33"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "VwSysAdminUnitInserted",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _childVwSysAdminUnitScriptTask;
		public ProcessScriptTask ChildVwSysAdminUnitScriptTask {
			get {
				return _childVwSysAdminUnitScriptTask ?? (_childVwSysAdminUnitScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChildVwSysAdminUnitScriptTask",
					SchemaElementUId = new Guid("9fb32ee2-1575-4a71-aff2-1846987cd7ec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChildVwSysAdminUnitScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ChildVwSysAdminUnitInsertedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildVwSysAdminUnitInsertedEventSubProcess };
			FlowElements[ChildVwSysAdminUnitInsertedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildVwSysAdminUnitInsertedStartMessage };
			FlowElements[ChildVwSysAdminUnitInsertedIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildVwSysAdminUnitInsertedIntermediateThrowMessageEvent };
			FlowElements[ChildVwSysAdminUnitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildVwSysAdminUnitScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ChildVwSysAdminUnitInsertedEventSubProcess":
						break;
					case "ChildVwSysAdminUnitInsertedStartMessage":
						e.Context.QueueTasks.Enqueue("ChildVwSysAdminUnitScriptTask");
						break;
					case "ChildVwSysAdminUnitInsertedIntermediateThrowMessageEvent":
						break;
					case "ChildVwSysAdminUnitScriptTask":
						e.Context.QueueTasks.Enqueue("ChildVwSysAdminUnitInsertedIntermediateThrowMessageEvent");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ChildVwSysAdminUnitInsertedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ChildVwSysAdminUnitInsertedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ChildVwSysAdminUnitInsertedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildVwSysAdminUnitInsertedStartMessage";
					result = ChildVwSysAdminUnitInsertedStartMessage.Execute(context);
					break;
				case "ChildVwSysAdminUnitInsertedIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "VwSysAdminUnitInserted");
					result = ChildVwSysAdminUnitInsertedIntermediateThrowMessageEvent.Execute(context);
					break;
				case "ChildVwSysAdminUnitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildVwSysAdminUnitScriptTask";
					result = ChildVwSysAdminUnitScriptTask.Execute(context, ChildVwSysAdminUnitScriptTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ChildVwSysAdminUnitScriptTaskExecute(ProcessExecutingContext context) {
			const int allEmployeesConnectionType = 0;
			if (Entity.ConnectionType != allEmployeesConnectionType) {
				return true;
			}
			SetDefaultSysMsgUserSettings();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "VwSysAdminUnit_WebitelCollaborations_TerrasoftInserted":
							if (ActivatedEventElements.Contains("ChildVwSysAdminUnitInsertedStartMessage")) {
							context.QueueTasks.Enqueue("ChildVwSysAdminUnitInsertedStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysAdminUnit_WebitelCollaborationsEventsProcess

	/// <exclude/>
	public class VwSysAdminUnit_WebitelCollaborationsEventsProcess : VwSysAdminUnit_WebitelCollaborationsEventsProcess<VwSysAdminUnit_WebitelCollaborations_Terrasoft>
	{

		public VwSysAdminUnit_WebitelCollaborationsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysAdminUnit_WebitelCollaborationsEventsProcess

	public partial class VwSysAdminUnit_WebitelCollaborationsEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void SetDefaultSysMsgUserSettings() {
			var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			EntitySchema wSysAccountSchema = entitySchemaManager.GetInstanceByName("WSysAccount");
			Entity wSysAccountEntity = wSysAccountSchema.CreateEntity(UserConnection);
			EntitySchema sysMsgUserSettingsSchema = entitySchemaManager.GetInstanceByName("SysMsgUserSettings");
			Entity sysMsgUserSettingsEntity = sysMsgUserSettingsSchema.CreateEntity(UserConnection);
			sysMsgUserSettingsEntity.SetDefColumnValues();
			sysMsgUserSettingsEntity.SetColumnValue("UserId", Entity.PrimaryColumnValue);
			sysMsgUserSettingsEntity.SetColumnValue("SysMsgLibId", WebitelSymMsgLibId);
			Dictionary<string, object> connectionParamsDictionary = new Dictionary<string, object>() {
				{ "isWrapUpDisabled", false }, 
				{ "debugMode", false },
				{ "disableCallCentre", false },
				{ "isAutoLogin", true },
				{ "useWebitelCti", false },
				{ "useWebPhone", true },
				{ "useVideo", false }
			};
			string connectionParams = ServiceStackTextHelper.Serialize(connectionParamsDictionary);
			sysMsgUserSettingsEntity.SetColumnValue("ConnectionParams", connectionParams);
			sysMsgUserSettingsEntity.Save();
		}

		public override void CheckCanManageLookups() {
		}

		#endregion

	}

	#endregion

}

