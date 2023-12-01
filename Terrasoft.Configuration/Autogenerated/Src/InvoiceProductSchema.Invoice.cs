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

	#region Class: InvoiceProduct_Invoice_TerrasoftSchema

	/// <exclude/>
	public class InvoiceProduct_Invoice_TerrasoftSchema : Terrasoft.Configuration.InvoiceProduct_CrtProductCatalogueInInvoice_TerrasoftSchema
	{

		#region Constructors: Public

		public InvoiceProduct_Invoice_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public InvoiceProduct_Invoice_TerrasoftSchema(InvoiceProduct_Invoice_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public InvoiceProduct_Invoice_TerrasoftSchema(InvoiceProduct_Invoice_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("fd497c90-e89e-4e2b-b127-2125e928ee6a");
			Name = "InvoiceProduct_Invoice_Terrasoft";
			ParentSchemaUId = new Guid("732baa21-890b-4894-a457-623630e33a6f");
			ExtendParent = true;
			CreatedInPackageId = new Guid("0831ed7d-04c4-455d-af2c-3fdb5376a294");
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
			return new InvoiceProduct_Invoice_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new InvoiceProduct_InvoiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new InvoiceProduct_Invoice_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new InvoiceProduct_Invoice_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd497c90-e89e-4e2b-b127-2125e928ee6a"));
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceProduct_Invoice_Terrasoft

	/// <summary>
	/// Product in invoice.
	/// </summary>
	public class InvoiceProduct_Invoice_Terrasoft : Terrasoft.Configuration.InvoiceProduct_CrtProductCatalogueInInvoice_Terrasoft
	{

		#region Constructors: Public

		public InvoiceProduct_Invoice_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "InvoiceProduct_Invoice_Terrasoft";
		}

		public InvoiceProduct_Invoice_Terrasoft(InvoiceProduct_Invoice_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new InvoiceProduct_InvoiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("InvoiceProduct_Invoice_TerrasoftDeleted", e);
			Saved += (s, e) => ThrowEvent("InvoiceProduct_Invoice_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("InvoiceProduct_Invoice_TerrasoftSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new InvoiceProduct_Invoice_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceProduct_InvoiceEventsProcess

	/// <exclude/>
	public partial class InvoiceProduct_InvoiceEventsProcess<TEntity> : Terrasoft.Configuration.InvoiceProduct_CrtProductCatalogueInInvoiceEventsProcess<TEntity> where TEntity : InvoiceProduct_Invoice_Terrasoft
	{

		public InvoiceProduct_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InvoiceProduct_InvoiceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fd497c90-e89e-4e2b-b127-2125e928ee6a");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_2f984c562e994fb69e583e2e9cca97aa;
		public ProcessFlowElement EventSubProcess3_2f984c562e994fb69e583e2e9cca97aa {
			get {
				return _eventSubProcess3_2f984c562e994fb69e583e2e9cca97aa ?? (_eventSubProcess3_2f984c562e994fb69e583e2e9cca97aa = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_2f984c562e994fb69e583e2e9cca97aa",
					SchemaElementUId = new Guid("2f984c56-2e99-4fb6-9e58-3e2e9cca97aa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_d2f25613674543c2a8fbdb995444c0fa;
		public ProcessFlowElement StartMessage3_d2f25613674543c2a8fbdb995444c0fa {
			get {
				return _startMessage3_d2f25613674543c2a8fbdb995444c0fa ?? (_startMessage3_d2f25613674543c2a8fbdb995444c0fa = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_d2f25613674543c2a8fbdb995444c0fa",
					SchemaElementUId = new Guid("d2f25613-6745-43c2-a8fb-db995444c0fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAmountChange;
		public ProcessScriptTask ScriptAmountChange {
			get {
				return _scriptAmountChange ?? (_scriptAmountChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAmountChange",
					SchemaElementUId = new Guid("dc730cc0-5da3-46ab-b423-1be2575b315a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAmountChangeExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess4_4a2f740e115046598019ae290b2089b8;
		public ProcessFlowElement EventSubProcess4_4a2f740e115046598019ae290b2089b8 {
			get {
				return _eventSubProcess4_4a2f740e115046598019ae290b2089b8 ?? (_eventSubProcess4_4a2f740e115046598019ae290b2089b8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4_4a2f740e115046598019ae290b2089b8",
					SchemaElementUId = new Guid("4a2f740e-1150-4659-8019-ae290b2089b8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_791f7aa35ec04e3999c82373df4928f7;
		public ProcessFlowElement StartMessage4_791f7aa35ec04e3999c82373df4928f7 {
			get {
				return _startMessage4_791f7aa35ec04e3999c82373df4928f7 ?? (_startMessage4_791f7aa35ec04e3999c82373df4928f7 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_791f7aa35ec04e3999c82373df4928f7",
					SchemaElementUId = new Guid("791f7aa3-5ec0-4e39-99c8-2373df4928f7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAmountChangeDeleted;
		public ProcessScriptTask ScriptAmountChangeDeleted {
			get {
				return _scriptAmountChangeDeleted ?? (_scriptAmountChangeDeleted = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAmountChangeDeleted",
					SchemaElementUId = new Guid("2465014e-756e-466a-8f6e-8e9b311e273e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAmountChangeDeletedExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess5_16ebb8b08e684ad084478d9a7c89b738;
		public ProcessFlowElement EventSubProcess5_16ebb8b08e684ad084478d9a7c89b738 {
			get {
				return _eventSubProcess5_16ebb8b08e684ad084478d9a7c89b738 ?? (_eventSubProcess5_16ebb8b08e684ad084478d9a7c89b738 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess5_16ebb8b08e684ad084478d9a7c89b738",
					SchemaElementUId = new Guid("16ebb8b0-8e68-4ad0-8447-8d9a7c89b738"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage5_b90d58aa26db46938d99ef4261ed62de;
		public ProcessFlowElement StartMessage5_b90d58aa26db46938d99ef4261ed62de {
			get {
				return _startMessage5_b90d58aa26db46938d99ef4261ed62de ?? (_startMessage5_b90d58aa26db46938d99ef4261ed62de = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage5_b90d58aa26db46938d99ef4261ed62de",
					SchemaElementUId = new Guid("b90d58aa-26db-4693-8d99-ef4261ed62de"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _invoiceProductSavingScriptTask;
		public ProcessScriptTask InvoiceProductSavingScriptTask {
			get {
				return _invoiceProductSavingScriptTask ?? (_invoiceProductSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InvoiceProductSavingScriptTask",
					SchemaElementUId = new Guid("dc1e263a-9427-4912-ad7a-baa281172f04"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InvoiceProductSavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_2f984c562e994fb69e583e2e9cca97aa.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_2f984c562e994fb69e583e2e9cca97aa };
			FlowElements[StartMessage3_d2f25613674543c2a8fbdb995444c0fa.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_d2f25613674543c2a8fbdb995444c0fa };
			FlowElements[ScriptAmountChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAmountChange };
			FlowElements[EventSubProcess4_4a2f740e115046598019ae290b2089b8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4_4a2f740e115046598019ae290b2089b8 };
			FlowElements[StartMessage4_791f7aa35ec04e3999c82373df4928f7.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_791f7aa35ec04e3999c82373df4928f7 };
			FlowElements[ScriptAmountChangeDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAmountChangeDeleted };
			FlowElements[EventSubProcess5_16ebb8b08e684ad084478d9a7c89b738.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5_16ebb8b08e684ad084478d9a7c89b738 };
			FlowElements[StartMessage5_b90d58aa26db46938d99ef4261ed62de.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5_b90d58aa26db46938d99ef4261ed62de };
			FlowElements[InvoiceProductSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InvoiceProductSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_2f984c562e994fb69e583e2e9cca97aa":
						break;
					case "StartMessage3_d2f25613674543c2a8fbdb995444c0fa":
						e.Context.QueueTasks.Enqueue("ScriptAmountChange");
						break;
					case "ScriptAmountChange":
						break;
					case "EventSubProcess4_4a2f740e115046598019ae290b2089b8":
						break;
					case "StartMessage4_791f7aa35ec04e3999c82373df4928f7":
						e.Context.QueueTasks.Enqueue("ScriptAmountChangeDeleted");
						break;
					case "ScriptAmountChangeDeleted":
						break;
					case "EventSubProcess5_16ebb8b08e684ad084478d9a7c89b738":
						break;
					case "StartMessage5_b90d58aa26db46938d99ef4261ed62de":
						e.Context.QueueTasks.Enqueue("InvoiceProductSavingScriptTask");
						break;
					case "InvoiceProductSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_d2f25613674543c2a8fbdb995444c0fa");
			ActivatedEventElements.Add("StartMessage4_791f7aa35ec04e3999c82373df4928f7");
			ActivatedEventElements.Add("StartMessage5_b90d58aa26db46938d99ef4261ed62de");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_2f984c562e994fb69e583e2e9cca97aa":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_d2f25613674543c2a8fbdb995444c0fa":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_d2f25613674543c2a8fbdb995444c0fa";
					result = StartMessage3_d2f25613674543c2a8fbdb995444c0fa.Execute(context);
					break;
				case "ScriptAmountChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAmountChange";
					result = ScriptAmountChange.Execute(context, ScriptAmountChangeExecute);
					break;
				case "EventSubProcess4_4a2f740e115046598019ae290b2089b8":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4_791f7aa35ec04e3999c82373df4928f7":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_791f7aa35ec04e3999c82373df4928f7";
					result = StartMessage4_791f7aa35ec04e3999c82373df4928f7.Execute(context);
					break;
				case "ScriptAmountChangeDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAmountChangeDeleted";
					result = ScriptAmountChangeDeleted.Execute(context, ScriptAmountChangeDeletedExecute);
					break;
				case "EventSubProcess5_16ebb8b08e684ad084478d9a7c89b738":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5_b90d58aa26db46938d99ef4261ed62de":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5_b90d58aa26db46938d99ef4261ed62de";
					result = StartMessage5_b90d58aa26db46938d99ef4261ed62de.Execute(context);
					break;
				case "InvoiceProductSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InvoiceProductSavingScriptTask";
					result = InvoiceProductSavingScriptTask.Execute(context, InvoiceProductSavingScriptTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptAmountChangeExecute(ProcessExecutingContext context) {
			UpdateInvoiceAmount(UserConnection);
			return true;
		}

		public virtual bool ScriptAmountChangeDeletedExecute(ProcessExecutingContext context) {
			UpdateInvoiceAmount(UserConnection);
			return true;
		}

		public virtual bool InvoiceProductSavingScriptTaskExecute(ProcessExecutingContext context) {
			var invoiceId = Entity.GetColumnValue("InvoiceId");
			if (invoiceId != null) {
				Select productFinanceSelect = new Select(UserConnection)
								.Column("Invoice", "CurrencyId")
								.Column("Invoice", "CurrencyRate")
								.Column("c", "Division")
								.From("Invoice").As("Invoice")
								.LeftOuterJoin("Currency").As("c").On("Invoice", "CurrencyId").IsEqual("c", "Id")
					.Where("Invoice", "Id").IsEqual(Column.Parameter(invoiceId)) as Select;
				using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
							using (var dataReader = productFinanceSelect.ExecuteReader(dbExecutor)) {
								while (dataReader.Read()) {
									var rate = UserConnection.DBTypeConverter.DBValueToDecimal(dataReader[1]);
									var division = UserConnection.DBTypeConverter.DBValueToDecimal(dataReader[2]);
									CurrencyRate = rate / (division != 0 ? division : 1);
								}
								
							}
						}
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "InvoiceProduct_Invoice_TerrasoftSaved":
							if (ActivatedEventElements.Contains("StartMessage3_d2f25613674543c2a8fbdb995444c0fa")) {
							context.QueueTasks.Enqueue("StartMessage3_d2f25613674543c2a8fbdb995444c0fa");
							ProcessQueue(context);
							return;
						}
						break;
					case "InvoiceProduct_Invoice_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("StartMessage4_791f7aa35ec04e3999c82373df4928f7")) {
							context.QueueTasks.Enqueue("StartMessage4_791f7aa35ec04e3999c82373df4928f7");
							ProcessQueue(context);
							return;
						}
						break;
					case "InvoiceProduct_Invoice_TerrasoftSaving":
							if (ActivatedEventElements.Contains("StartMessage5_b90d58aa26db46938d99ef4261ed62de")) {
							context.QueueTasks.Enqueue("StartMessage5_b90d58aa26db46938d99ef4261ed62de");
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

	#region Class: InvoiceProduct_InvoiceEventsProcess

	/// <exclude/>
	public class InvoiceProduct_InvoiceEventsProcess : InvoiceProduct_InvoiceEventsProcess<InvoiceProduct_Invoice_Terrasoft>
	{

		public InvoiceProduct_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

