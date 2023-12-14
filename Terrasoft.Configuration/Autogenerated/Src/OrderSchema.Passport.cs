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

	#region Class: Order_Passport_TerrasoftSchema

	/// <exclude/>
	public class Order_Passport_TerrasoftSchema : Terrasoft.Configuration.Order_Order_TerrasoftSchema
	{

		#region Constructors: Public

		public Order_Passport_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Order_Passport_TerrasoftSchema(Order_Passport_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Order_Passport_TerrasoftSchema(Order_Passport_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("f2688517-820b-4f01-9361-0ce31cc5a1d2");
			Name = "Order_Passport_Terrasoft";
			ParentSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			ExtendParent = true;
			CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a");
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
			return new Order_Passport_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Order_PassportEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Order_Passport_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Order_Passport_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f2688517-820b-4f01-9361-0ce31cc5a1d2"));
		}

		#endregion

	}

	#endregion

	#region Class: Order_Passport_Terrasoft

	/// <summary>
	/// Order.
	/// </summary>
	public class Order_Passport_Terrasoft : Terrasoft.Configuration.Order_Order_Terrasoft
	{

		#region Constructors: Public

		public Order_Passport_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Order_Passport_Terrasoft";
		}

		public Order_Passport_Terrasoft(Order_Passport_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Order_PassportEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Order_Passport_TerrasoftDeleted", e);
			Inserted += (s, e) => ThrowEvent("Order_Passport_TerrasoftInserted", e);
			Saved += (s, e) => ThrowEvent("Order_Passport_TerrasoftSaved", e);
			Validating += (s, e) => ThrowEvent("Order_Passport_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Order_Passport_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Order_PassportEventsProcess

	/// <exclude/>
	public partial class Order_PassportEventsProcess<TEntity> : Terrasoft.Configuration.Order_OrderEventsProcess<TEntity> where TEntity : Order_Passport_Terrasoft
	{

		public Order_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Order_PassportEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f2688517-820b-4f01-9361-0ce31cc5a1d2");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _passportOrderInsertedEventSubProcess;
		public ProcessFlowElement PassportOrderInsertedEventSubProcess {
			get {
				return _passportOrderInsertedEventSubProcess ?? (_passportOrderInsertedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PassportOrderInsertedEventSubProcess",
					SchemaElementUId = new Guid("66b3c66b-41b1-4a0f-85a2-1163185506b0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _passportOrderInsertedStartMessage;
		public ProcessFlowElement PassportOrderInsertedStartMessage {
			get {
				return _passportOrderInsertedStartMessage ?? (_passportOrderInsertedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PassportOrderInsertedStartMessage",
					SchemaElementUId = new Guid("5b3e219b-6442-427d-ac11-126c4e9845c4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _createSupplyPaymentItemsScriptTask;
		public ProcessScriptTask CreateSupplyPaymentItemsScriptTask {
			get {
				return _createSupplyPaymentItemsScriptTask ?? (_createSupplyPaymentItemsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CreateSupplyPaymentItemsScriptTask",
					SchemaElementUId = new Guid("83042d05-8267-4714-8415-ad1468ddb281"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CreateSupplyPaymentItemsScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[PassportOrderInsertedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PassportOrderInsertedEventSubProcess };
			FlowElements[PassportOrderInsertedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PassportOrderInsertedStartMessage };
			FlowElements[CreateSupplyPaymentItemsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateSupplyPaymentItemsScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "PassportOrderInsertedEventSubProcess":
						break;
					case "PassportOrderInsertedStartMessage":
						e.Context.QueueTasks.Enqueue("CreateSupplyPaymentItemsScriptTask");
						break;
					case "CreateSupplyPaymentItemsScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PassportOrderInsertedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "PassportOrderInsertedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "PassportOrderInsertedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PassportOrderInsertedStartMessage";
					result = PassportOrderInsertedStartMessage.Execute(context);
					break;
				case "CreateSupplyPaymentItemsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CreateSupplyPaymentItemsScriptTask";
					result = CreateSupplyPaymentItemsScriptTask.Execute(context, CreateSupplyPaymentItemsScriptTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool CreateSupplyPaymentItemsScriptTaskExecute(ProcessExecutingContext context) {
			CreateDefSupplyPaymentItems();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Order_Passport_TerrasoftInserted":
							if (ActivatedEventElements.Contains("PassportOrderInsertedStartMessage")) {
							context.QueueTasks.Enqueue("PassportOrderInsertedStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: Order_PassportEventsProcess

	/// <exclude/>
	public class Order_PassportEventsProcess : Order_PassportEventsProcess<Order_Passport_Terrasoft>
	{

		public Order_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Order_PassportEventsProcess

	public partial class Order_PassportEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void CreateDefSupplyPaymentItems() {
			var passportHelper = ClassFactory.Get<Terrasoft.Configuration.Passport.OrderPassportHelper>(new ConstructorArgument("userConnection", UserConnection));
			passportHelper.SetTemplate(Entity.PrimaryColumnValue);
		}

		public override void UpdateProductAmounts() {
			base.UpdateProductAmounts();
			if (NeedFinRecalc) {
				var orderAmountHelper = ClassFactory.Get<Terrasoft.Configuration.Passport.OrderAmountHelper>(new ConstructorArgument("userConnection", UserConnection));
				orderAmountHelper.UpdateAmountsByOrderId(Entity.GetTypedColumnValue<Guid>("Id"));
			}
		}

		#endregion

	}

	#endregion

}

