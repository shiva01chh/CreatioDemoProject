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
	using Terrasoft.Configuration.Passport;
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

	#region Class: Invoice_Passport_TerrasoftSchema

	/// <exclude/>
	public class Invoice_Passport_TerrasoftSchema : Terrasoft.Configuration.Invoice_Invoice_TerrasoftSchema
	{

		#region Constructors: Public

		public Invoice_Passport_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Invoice_Passport_TerrasoftSchema(Invoice_Passport_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Invoice_Passport_TerrasoftSchema(Invoice_Passport_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("d1222632-c692-403c-b1fe-02d3fd566a8c");
			Name = "Invoice_Passport_Terrasoft";
			ParentSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
			ExtendParent = true;
			CreatedInPackageId = new Guid("0e488ac0-fe51-4dc3-8d9a-11caac414976");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
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
			return new Invoice_Passport_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Invoice_PassportEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Invoice_Passport_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Invoice_Passport_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d1222632-c692-403c-b1fe-02d3fd566a8c"));
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_Passport_Terrasoft

	/// <summary>
	/// Invoice.
	/// </summary>
	public class Invoice_Passport_Terrasoft : Terrasoft.Configuration.Invoice_Invoice_Terrasoft
	{

		#region Constructors: Public

		public Invoice_Passport_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Invoice_Passport_Terrasoft";
		}

		public Invoice_Passport_Terrasoft(Invoice_Passport_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Invoice_PassportEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Invoice_Passport_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Invoice_Passport_TerrasoftDeleting", e);
			Saved += (s, e) => ThrowEvent("Invoice_Passport_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Invoice_Passport_TerrasoftSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Invoice_Passport_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_PassportEventsProcess

	/// <exclude/>
	public partial class Invoice_PassportEventsProcess<TEntity> : Terrasoft.Configuration.Invoice_InvoiceEventsProcess<TEntity> where TEntity : Invoice_Passport_Terrasoft
	{

		public Invoice_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Invoice_PassportEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d1222632-c692-403c-b1fe-02d3fd566a8c");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("e684c37e-96b5-4ef9-a3a9-0d083c0311eb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_af7d565c9d1943f18e1393fe1766af58;
		public ProcessFlowElement StartMessage3_af7d565c9d1943f18e1393fe1766af58 {
			get {
				return _startMessage3_af7d565c9d1943f18e1393fe1766af58 ?? (_startMessage3_af7d565c9d1943f18e1393fe1766af58 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_af7d565c9d1943f18e1393fe1766af58",
					SchemaElementUId = new Guid("af7d565c-9d19-43f1-8e13-93fe1766af58"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _isPaymentStatusCanceled;
		public ProcessScriptTask IsPaymentStatusCanceled {
			get {
				return _isPaymentStatusCanceled ?? (_isPaymentStatusCanceled = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "IsPaymentStatusCanceled",
					SchemaElementUId = new Guid("aecd2977-8e8c-4f36-b24b-f6ecb3cdabcf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = IsPaymentStatusCanceledExecute,
				});
			}
		}

		private ProcessFlowElement _deletedEventSubProcess;
		public ProcessFlowElement DeletedEventSubProcess {
			get {
				return _deletedEventSubProcess ?? (_deletedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "DeletedEventSubProcess",
					SchemaElementUId = new Guid("746f8b86-3358-4094-8a10-68ccc60c5e1a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_8c6e40cfe8724a3c8c45034fe2f6a61e;
		public ProcessFlowElement StartMessage4_8c6e40cfe8724a3c8c45034fe2f6a61e {
			get {
				return _startMessage4_8c6e40cfe8724a3c8c45034fe2f6a61e ?? (_startMessage4_8c6e40cfe8724a3c8c45034fe2f6a61e = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_8c6e40cfe8724a3c8c45034fe2f6a61e",
					SchemaElementUId = new Guid("8c6e40cf-e872-4a3c-8c45-034fe2f6a61e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _onDeletedScriptTask;
		public ProcessScriptTask OnDeletedScriptTask {
			get {
				return _onDeletedScriptTask ?? (_onDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OnDeletedScriptTask",
					SchemaElementUId = new Guid("034b77b8-5bb8-48b5-bf0b-6f68cc7571d4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OnDeletedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage3_af7d565c9d1943f18e1393fe1766af58.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_af7d565c9d1943f18e1393fe1766af58 };
			FlowElements[IsPaymentStatusCanceled.SchemaElementUId] = new Collection<ProcessFlowElement> { IsPaymentStatusCanceled };
			FlowElements[DeletedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { DeletedEventSubProcess };
			FlowElements[StartMessage4_8c6e40cfe8724a3c8c45034fe2f6a61e.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_8c6e40cfe8724a3c8c45034fe2f6a61e };
			FlowElements[OnDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OnDeletedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess2":
						break;
					case "StartMessage3_af7d565c9d1943f18e1393fe1766af58":
						e.Context.QueueTasks.Enqueue("IsPaymentStatusCanceled");
						break;
					case "IsPaymentStatusCanceled":
						break;
					case "DeletedEventSubProcess":
						break;
					case "StartMessage4_8c6e40cfe8724a3c8c45034fe2f6a61e":
						e.Context.QueueTasks.Enqueue("OnDeletedScriptTask");
						break;
					case "OnDeletedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_af7d565c9d1943f18e1393fe1766af58");
			ActivatedEventElements.Add("StartMessage4_8c6e40cfe8724a3c8c45034fe2f6a61e");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_af7d565c9d1943f18e1393fe1766af58":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_af7d565c9d1943f18e1393fe1766af58";
					result = StartMessage3_af7d565c9d1943f18e1393fe1766af58.Execute(context);
					break;
				case "IsPaymentStatusCanceled":
					context.QueueTasks.Dequeue();
					context.SenderName = "IsPaymentStatusCanceled";
					result = IsPaymentStatusCanceled.Execute(context, IsPaymentStatusCanceledExecute);
					break;
				case "DeletedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4_8c6e40cfe8724a3c8c45034fe2f6a61e":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_8c6e40cfe8724a3c8c45034fe2f6a61e";
					result = StartMessage4_8c6e40cfe8724a3c8c45034fe2f6a61e.Execute(context);
					break;
				case "OnDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnDeletedScriptTask";
					result = OnDeletedScriptTask.Execute(context, OnDeletedScriptTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool IsPaymentStatusCanceledExecute(ProcessExecutingContext context) {
			ChangedColumnValues = new List<EntityColumnValue>(Entity.GetChangedColumnValues());
			return true;
		}

		public virtual bool OnDeletedScriptTaskExecute(ProcessExecutingContext context) {
			var orderAmountHelper = ClassFactory.Get<OrderAmountHelper>(new ConstructorArgument("userConnection", UserConnection));
			orderAmountHelper.UpdateOrderPaymentAmountOnInvoiceDeleted(Entity.GetTypedColumnValue<Guid>("OrderId"));
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Invoice_Passport_TerrasoftSaving":
							if (ActivatedEventElements.Contains("StartMessage3_af7d565c9d1943f18e1393fe1766af58")) {
							context.QueueTasks.Enqueue("StartMessage3_af7d565c9d1943f18e1393fe1766af58");
							ProcessQueue(context);
							return;
						}
						break;
					case "Invoice_Passport_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("StartMessage4_8c6e40cfe8724a3c8c45034fe2f6a61e")) {
							context.QueueTasks.Enqueue("StartMessage4_8c6e40cfe8724a3c8c45034fe2f6a61e");
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

	#region Class: Invoice_PassportEventsProcess

	/// <exclude/>
	public class Invoice_PassportEventsProcess : Invoice_PassportEventsProcess<Invoice_Passport_Terrasoft>
	{

		public Invoice_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

