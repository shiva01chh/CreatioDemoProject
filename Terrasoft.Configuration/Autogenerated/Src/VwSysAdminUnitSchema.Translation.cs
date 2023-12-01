﻿namespace Terrasoft.Configuration
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

	#region Class: VwSysAdminUnit_Translation_TerrasoftSchema

	/// <exclude/>
	public class VwSysAdminUnit_Translation_TerrasoftSchema : Terrasoft.Configuration.VwSysAdminUnit_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public VwSysAdminUnit_Translation_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysAdminUnit_Translation_TerrasoftSchema(VwSysAdminUnit_Translation_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysAdminUnit_Translation_TerrasoftSchema(VwSysAdminUnit_Translation_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("83ef3898-2ff3-4587-99f5-566b544023f5");
			Name = "VwSysAdminUnit_Translation_Terrasoft";
			ParentSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364");
			ExtendParent = true;
			CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013");
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
			return new VwSysAdminUnit_Translation_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysAdminUnit_TranslationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysAdminUnit_Translation_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysAdminUnit_Translation_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83ef3898-2ff3-4587-99f5-566b544023f5"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysAdminUnit_Translation_Terrasoft

	/// <summary>
	/// Users/roles (view).
	/// </summary>
	public class VwSysAdminUnit_Translation_Terrasoft : Terrasoft.Configuration.VwSysAdminUnit_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public VwSysAdminUnit_Translation_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysAdminUnit_Translation_Terrasoft";
		}

		public VwSysAdminUnit_Translation_Terrasoft(VwSysAdminUnit_Translation_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysAdminUnit_TranslationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saving += (s, e) => ThrowEvent("VwSysAdminUnit_Translation_TerrasoftSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysAdminUnit_Translation_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysAdminUnit_TranslationEventsProcess

	/// <exclude/>
	public partial class VwSysAdminUnit_TranslationEventsProcess<TEntity> : Terrasoft.Configuration.VwSysAdminUnit_CrtBaseEventsProcess<TEntity> where TEntity : VwSysAdminUnit_Translation_Terrasoft
	{

		public VwSysAdminUnit_TranslationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysAdminUnit_TranslationEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("83ef3898-2ff3-4587-99f5-566b544023f5");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_c6053b7c72914c9aa2918330fa10ab85;
		public ProcessFlowElement EventSubProcess3_c6053b7c72914c9aa2918330fa10ab85 {
			get {
				return _eventSubProcess3_c6053b7c72914c9aa2918330fa10ab85 ?? (_eventSubProcess3_c6053b7c72914c9aa2918330fa10ab85 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_c6053b7c72914c9aa2918330fa10ab85",
					SchemaElementUId = new Guid("c6053b7c-7291-4c9a-a291-8330fa10ab85"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _vwSysAdminUnitSavingStartMessage;
		public ProcessFlowElement VwSysAdminUnitSavingStartMessage {
			get {
				return _vwSysAdminUnitSavingStartMessage ?? (_vwSysAdminUnitSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "VwSysAdminUnitSavingStartMessage",
					SchemaElementUId = new Guid("b642d1d0-3b18-4fb1-a688-7908a9b6fbd2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _vwSysAdminUnitSavingScriptTask;
		public ProcessScriptTask VwSysAdminUnitSavingScriptTask {
			get {
				return _vwSysAdminUnitSavingScriptTask ?? (_vwSysAdminUnitSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "VwSysAdminUnitSavingScriptTask",
					SchemaElementUId = new Guid("0e465ea1-55e4-40c6-8cef-f7d8bc89b3c8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = VwSysAdminUnitSavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_c6053b7c72914c9aa2918330fa10ab85.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_c6053b7c72914c9aa2918330fa10ab85 };
			FlowElements[VwSysAdminUnitSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysAdminUnitSavingStartMessage };
			FlowElements[VwSysAdminUnitSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysAdminUnitSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_c6053b7c72914c9aa2918330fa10ab85":
						break;
					case "VwSysAdminUnitSavingStartMessage":
						e.Context.QueueTasks.Enqueue("VwSysAdminUnitSavingScriptTask");
						break;
					case "VwSysAdminUnitSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("VwSysAdminUnitSavingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_c6053b7c72914c9aa2918330fa10ab85":
					context.QueueTasks.Dequeue();
					break;
				case "VwSysAdminUnitSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "VwSysAdminUnitSavingStartMessage";
					result = VwSysAdminUnitSavingStartMessage.Execute(context);
					break;
				case "VwSysAdminUnitSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "VwSysAdminUnitSavingScriptTask";
					result = VwSysAdminUnitSavingScriptTask.Execute(context, VwSysAdminUnitSavingScriptTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool VwSysAdminUnitSavingScriptTaskExecute(ProcessExecutingContext context) {
			EntitySchemaColumn sysCultureColumn = Entity.Schema.Columns.GetByName("SysCulture");
			var sysCultureId = Entity.GetTypedColumnValue<Guid>(sysCultureColumn.ColumnValueName);
			if (sysCultureId == Guid.Empty) {
				var sysCultureUtilities = new SysCultureUtilities(UserConnection);
				Guid sysDefaultCultureId = sysCultureUtilities.GetDefaultCulture();
				Entity.SetColumnValue(sysCultureColumn.ColumnValueName, sysDefaultCultureId);
			} 
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "VwSysAdminUnit_Translation_TerrasoftSaving":
							if (ActivatedEventElements.Contains("VwSysAdminUnitSavingStartMessage")) {
							context.QueueTasks.Enqueue("VwSysAdminUnitSavingStartMessage");
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

	#region Class: VwSysAdminUnit_TranslationEventsProcess

	/// <exclude/>
	public class VwSysAdminUnit_TranslationEventsProcess : VwSysAdminUnit_TranslationEventsProcess<VwSysAdminUnit_Translation_Terrasoft>
	{

		public VwSysAdminUnit_TranslationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysAdminUnit_TranslationEventsProcess

	public partial class VwSysAdminUnit_TranslationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

