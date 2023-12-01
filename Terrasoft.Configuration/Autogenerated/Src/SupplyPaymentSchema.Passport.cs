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

	#region Class: SupplyPaymentSchema

	/// <exclude/>
	[IsVirtual]
	public class SupplyPaymentSchema : Terrasoft.Configuration.SupplyPayment_CrtSupplyPayment_TerrasoftSchema
	{

		#region Constructors: Public

		public SupplyPaymentSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SupplyPaymentSchema(SupplyPaymentSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SupplyPaymentSchema(SupplyPaymentSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("c7eba94e-d6d2-4f06-bd14-b2f757be88c3");
			Name = "SupplyPayment";
			ParentSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			ExtendParent = true;
			CreatedInPackageId = new Guid("0e488ac0-fe51-4dc3-8d9a-11caac414976");
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
			return new SupplyPayment(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SupplyPayment_PassportEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SupplyPaymentSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SupplyPaymentSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c7eba94e-d6d2-4f06-bd14-b2f757be88c3"));
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPayment

	/// <summary>
	/// Installment plan.
	/// </summary>
	public class SupplyPayment : Terrasoft.Configuration.SupplyPayment_CrtSupplyPayment_Terrasoft
	{

		#region Constructors: Public

		public SupplyPayment(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SupplyPayment";
		}

		public SupplyPayment(SupplyPayment source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SupplyPayment_PassportEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saving += (s, e) => ThrowEvent("SupplyPaymentSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SupplyPayment(this);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPayment_PassportEventsProcess

	/// <exclude/>
	public partial class SupplyPayment_PassportEventsProcess<TEntity> : Terrasoft.Configuration.SupplyPayment_CrtSupplyPaymentEventsProcess<TEntity> where TEntity : SupplyPayment
	{

		public SupplyPayment_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SupplyPayment_PassportEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c7eba94e-d6d2-4f06-bd14-b2f757be88c3");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_5e10f47c97e54575bd10300cccd1029d;
		public ProcessFlowElement EventSubProcess3_5e10f47c97e54575bd10300cccd1029d {
			get {
				return _eventSubProcess3_5e10f47c97e54575bd10300cccd1029d ?? (_eventSubProcess3_5e10f47c97e54575bd10300cccd1029d = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_5e10f47c97e54575bd10300cccd1029d",
					SchemaElementUId = new Guid("5e10f47c-97e5-4575-bd10-300cccd1029d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _supplyPaymentSavingStartMessage;
		public ProcessFlowElement SupplyPaymentSavingStartMessage {
			get {
				return _supplyPaymentSavingStartMessage ?? (_supplyPaymentSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SupplyPaymentSavingStartMessage",
					SchemaElementUId = new Guid("08065cea-e258-4da5-982c-754adc31169d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _supplyPaymentOnSavingScriptTask;
		public ProcessScriptTask SupplyPaymentOnSavingScriptTask {
			get {
				return _supplyPaymentOnSavingScriptTask ?? (_supplyPaymentOnSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SupplyPaymentOnSavingScriptTask",
					SchemaElementUId = new Guid("e5d6d5ac-8a11-4020-a57b-5a147993f020"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SupplyPaymentOnSavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_5e10f47c97e54575bd10300cccd1029d.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_5e10f47c97e54575bd10300cccd1029d };
			FlowElements[SupplyPaymentSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SupplyPaymentSavingStartMessage };
			FlowElements[SupplyPaymentOnSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SupplyPaymentOnSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_5e10f47c97e54575bd10300cccd1029d":
						break;
					case "SupplyPaymentSavingStartMessage":
						e.Context.QueueTasks.Enqueue("SupplyPaymentOnSavingScriptTask");
						break;
					case "SupplyPaymentOnSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SupplyPaymentSavingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_5e10f47c97e54575bd10300cccd1029d":
					context.QueueTasks.Dequeue();
					break;
				case "SupplyPaymentSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SupplyPaymentSavingStartMessage";
					result = SupplyPaymentSavingStartMessage.Execute(context);
					break;
				case "SupplyPaymentOnSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SupplyPaymentOnSavingScriptTask";
					result = SupplyPaymentOnSavingScriptTask.Execute(context, SupplyPaymentOnSavingScriptTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool SupplyPaymentOnSavingScriptTaskExecute(ProcessExecutingContext context) {
			CheckCascadeCycle();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SupplyPaymentSaving":
							if (ActivatedEventElements.Contains("SupplyPaymentSavingStartMessage")) {
							context.QueueTasks.Enqueue("SupplyPaymentSavingStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPayment_PassportEventsProcess

	/// <exclude/>
	public class SupplyPayment_PassportEventsProcess : SupplyPayment_PassportEventsProcess<SupplyPayment>
	{

		public SupplyPayment_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: SupplyPaymentEventsProcess

	/// <exclude/>
	public class SupplyPaymentEventsProcess : SupplyPayment_PassportEventsProcess
	{

		public SupplyPaymentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

