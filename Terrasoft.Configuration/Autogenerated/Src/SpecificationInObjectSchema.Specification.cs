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

	#region Class: SpecificationInObjectSchema

	/// <exclude/>
	public class SpecificationInObjectSchema : Terrasoft.Configuration.SpecificationInObject_CrtSpecification_TerrasoftSchema
	{

		#region Constructors: Public

		public SpecificationInObjectSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecificationInObjectSchema(SpecificationInObjectSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecificationInObjectSchema(SpecificationInObjectSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("b1c1b584-6646-4697-8351-147120056217");
			Name = "SpecificationInObject";
			ParentSchemaUId = new Guid("1777f489-6dbf-40c7-8d45-7be4d658d8e6");
			ExtendParent = true;
			CreatedInPackageId = new Guid("25b95d5d-60b5-4791-b4ab-0eb703af71b6");
			IsDBView = false;
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
			return new SpecificationInObject(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SpecificationInObject_SpecificationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecificationInObjectSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecificationInObjectSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b1c1b584-6646-4697-8351-147120056217"));
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInObject

	/// <summary>
	/// Feature in object.
	/// </summary>
	public class SpecificationInObject : Terrasoft.Configuration.SpecificationInObject_CrtSpecification_Terrasoft
	{

		#region Constructors: Public

		public SpecificationInObject(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SpecificationInObject";
		}

		public SpecificationInObject(SpecificationInObject source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SpecificationInObject_SpecificationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecificationInObjectDeleted", e);
			Inserting += (s, e) => ThrowEvent("SpecificationInObjectInserting", e);
			Saving += (s, e) => ThrowEvent("SpecificationInObjectSaving", e);
			Validating += (s, e) => ThrowEvent("SpecificationInObjectValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecificationInObject(this);
		}

		#endregion

	}

	#endregion

	#region Class: SpecificationInObject_SpecificationEventsProcess

	/// <exclude/>
	public partial class SpecificationInObject_SpecificationEventsProcess<TEntity> : Terrasoft.Configuration.SpecificationInObject_CrtSpecificationEventsProcess<TEntity> where TEntity : SpecificationInObject
	{

		public SpecificationInObject_SpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecificationInObject_SpecificationEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b1c1b584-6646-4697-8351-147120056217");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _savingEventSubProcess;
		public ProcessFlowElement SavingEventSubProcess {
			get {
				return _savingEventSubProcess ?? (_savingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SavingEventSubProcess",
					SchemaElementUId = new Guid("b1a6f6fc-a951-4bb1-8493-d9511638a06e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_0f7ca457c444433dbd8ad6a6b6b0c4d3;
		public ProcessFlowElement StartMessage3_0f7ca457c444433dbd8ad6a6b6b0c4d3 {
			get {
				return _startMessage3_0f7ca457c444433dbd8ad6a6b6b0c4d3 ?? (_startMessage3_0f7ca457c444433dbd8ad6a6b6b0c4d3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_0f7ca457c444433dbd8ad6a6b6b0c4d3",
					SchemaElementUId = new Guid("0f7ca457-c444-433d-bd8a-d6a6b6b0c4d3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _updateStringValueScriptTask;
		public ProcessScriptTask UpdateStringValueScriptTask {
			get {
				return _updateStringValueScriptTask ?? (_updateStringValueScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateStringValueScriptTask",
					SchemaElementUId = new Guid("fd3503d5-72c2-46a5-a90a-663516ff36ec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateStringValueScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SavingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SavingEventSubProcess };
			FlowElements[StartMessage3_0f7ca457c444433dbd8ad6a6b6b0c4d3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_0f7ca457c444433dbd8ad6a6b6b0c4d3 };
			FlowElements[UpdateStringValueScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateStringValueScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SavingEventSubProcess":
						break;
					case "StartMessage3_0f7ca457c444433dbd8ad6a6b6b0c4d3":
						e.Context.QueueTasks.Enqueue("UpdateStringValueScriptTask");
						break;
					case "UpdateStringValueScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_0f7ca457c444433dbd8ad6a6b6b0c4d3");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SavingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_0f7ca457c444433dbd8ad6a6b6b0c4d3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_0f7ca457c444433dbd8ad6a6b6b0c4d3";
					result = StartMessage3_0f7ca457c444433dbd8ad6a6b6b0c4d3.Execute(context);
					break;
				case "UpdateStringValueScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateStringValueScriptTask";
					result = UpdateStringValueScriptTask.Execute(context, UpdateStringValueScriptTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool UpdateStringValueScriptTaskExecute(ProcessExecutingContext context) {
			return UpdateStringValueMethod();
			/*
			// Convert specification value to StringValue
			
			var specificationTypeId = string.Empty;
			var specificationValue = string.Empty;
			
			if (Entity.SpecificationId == Guid.Empty) {
				return true;
			};
			
			var esqResult = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Specification");
			esqResult.AddColumn("Type");
			var specEntity = esqResult.GetEntity(UserConnection, Entity.SpecificationId);
			specificationTypeId = specEntity.GetTypedColumnValue<string>("TypeId");
			
			// if not string value
			if (specificationTypeId != "7aad419a-9e7a-4785-8d13-c7ff1402e13d") {
				Entity.SetColumnValue("StringValue", string.Empty);
			};
			
			switch(specificationTypeId) {
				// string type
				case ("7aad419a-9e7a-4785-8d13-c7ff1402e13d"):
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ListItemValue", null);
					return true;
				// int type
				case ("2212241a-71eb-468b-a3d5-c0f39dfe51c9"):
					specificationValue = Entity.GetTypedColumnValue<string>("IntValue");
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ListItemValue", null);
					break;
				// float type
				case ("beb46531-4f29-452c-be18-1ed5f1aa8b80"):
					specificationValue = Entity.GetTypedColumnValue<string>("FloatValue");
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ListItemValue", null);
					break;
				// boolean type
				case ("359e0e35-bb39-4f07-9b9f-aec6ad076828"):
					if (Entity.GetTypedColumnValue<bool>("BooleanValue")) {
						specificationValue = Yes.ToString();
					} else {
						specificationValue = No.ToString();
					}
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("ListItemValue", null);
					break;
				// list item value
				case ("ecf578a0-4b4d-40e6-909c-39af2a798d32"):
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("BooleanValue", false);
					if (Entity.ListItemValueId != Guid.Empty ) {
						specificationValue = Entity.ListItemValueName;
					} 
					break;
				default: return true;
			};
			
			Entity.SetColumnValue("StringValue", specificationValue);
			
			return true;
			*/
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SpecificationInObjectSaving":
							if (ActivatedEventElements.Contains("StartMessage3_0f7ca457c444433dbd8ad6a6b6b0c4d3")) {
							context.QueueTasks.Enqueue("StartMessage3_0f7ca457c444433dbd8ad6a6b6b0c4d3");
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

	#region Class: SpecificationInObject_SpecificationEventsProcess

	/// <exclude/>
	public class SpecificationInObject_SpecificationEventsProcess : SpecificationInObject_SpecificationEventsProcess<SpecificationInObject>
	{

		public SpecificationInObject_SpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: SpecificationInObjectEventsProcess

	/// <exclude/>
	public class SpecificationInObjectEventsProcess : SpecificationInObject_SpecificationEventsProcess
	{

		public SpecificationInObjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

