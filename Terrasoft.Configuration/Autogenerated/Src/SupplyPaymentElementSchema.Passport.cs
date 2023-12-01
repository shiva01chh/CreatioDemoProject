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

	#region Class: SupplyPaymentElement_Passport_TerrasoftSchema

	/// <exclude/>
	public class SupplyPaymentElement_Passport_TerrasoftSchema : Terrasoft.Configuration.SupplyPaymentElement_CrtSupplyPayment_TerrasoftSchema
	{

		#region Constructors: Public

		public SupplyPaymentElement_Passport_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SupplyPaymentElement_Passport_TerrasoftSchema(SupplyPaymentElement_Passport_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SupplyPaymentElement_Passport_TerrasoftSchema(SupplyPaymentElement_Passport_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIeY97HvuWyT8xw8jpwkpEpPnhiUsIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("3bd175a6-d977-41b0-9091-566ad73135f7");
			index.Name = "IeY97HvuWyT8xw8jpwkpEpPnhiUs";
			index.CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			index.ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			index.CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a");
			EntitySchemaIndexColumn idIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("4f208c25-99a7-4192-a03e-fcb48d4a9abc"),
				ColumnUId = new Guid("ae0e45ca-c495-4fe7-a39d-3ab7278e1617"),
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(idIndexColumn);
			EntitySchemaIndexColumn typeIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("6ff85e23-059a-44f7-b128-f5e452ca9c05"),
				ColumnUId = new Guid("dd703360-9b62-47fe-abb5-2f3ff6a57911"),
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(typeIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("91761913-02c7-4489-92b2-b166d95b446d");
			Name = "SupplyPaymentElement_Passport_Terrasoft";
			ParentSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
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
			if (Columns.FindByUId(new Guid("66261c3c-a0a6-4a54-8e50-39752634604e")) == null) {
				Columns.Add(CreateContractColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateContractColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("66261c3c-a0a6-4a54-8e50-39752634604e"),
				Name = @"Contract",
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("91761913-02c7-4489-92b2-b166d95b446d"),
				ModifiedInSchemaUId = new Guid("91761913-02c7-4489-92b2-b166d95b446d"),
				CreatedInPackageId = new Guid("0e488ac0-fe51-4dc3-8d9a-11caac414976")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIeY97HvuWyT8xw8jpwkpEpPnhiUsIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SupplyPaymentElement_Passport_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SupplyPaymentElement_PassportEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SupplyPaymentElement_Passport_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SupplyPaymentElement_Passport_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91761913-02c7-4489-92b2-b166d95b446d"));
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentElement_Passport_Terrasoft

	/// <summary>
	/// Installment plan: new entry.
	/// </summary>
	public class SupplyPaymentElement_Passport_Terrasoft : Terrasoft.Configuration.SupplyPaymentElement_CrtSupplyPayment_Terrasoft
	{

		#region Constructors: Public

		public SupplyPaymentElement_Passport_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SupplyPaymentElement_Passport_Terrasoft";
		}

		public SupplyPaymentElement_Passport_Terrasoft(SupplyPaymentElement_Passport_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ContractId {
			get {
				return GetTypedColumnValue<Guid>("ContractId");
			}
			set {
				SetColumnValue("ContractId", value);
				_contract = null;
			}
		}

		/// <exclude/>
		public string ContractNumber {
			get {
				return GetTypedColumnValue<string>("ContractNumber");
			}
			set {
				SetColumnValue("ContractNumber", value);
				if (_contract != null) {
					_contract.Number = value;
				}
			}
		}

		private Contract _contract;
		/// <summary>
		/// Contract.
		/// </summary>
		public Contract Contract {
			get {
				return _contract ??
					(_contract = LookupColumnEntities.GetEntity("Contract") as Contract);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SupplyPaymentElement_PassportEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SupplyPaymentElement_Passport_TerrasoftDeleted", e);
			Saved += (s, e) => ThrowEvent("SupplyPaymentElement_Passport_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("SupplyPaymentElement_Passport_TerrasoftSaving", e);
			Updated += (s, e) => ThrowEvent("SupplyPaymentElement_Passport_TerrasoftUpdated", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SupplyPaymentElement_Passport_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentElement_PassportEventsProcess

	/// <exclude/>
	public partial class SupplyPaymentElement_PassportEventsProcess<TEntity> : Terrasoft.Configuration.SupplyPaymentElement_CrtSupplyPaymentEventsProcess<TEntity> where TEntity : SupplyPaymentElement_Passport_Terrasoft
	{

		public SupplyPaymentElement_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SupplyPaymentElement_PassportEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("91761913-02c7-4489-92b2-b166d95b446d");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess4_508cb51f36164caaa73f0ac0ba8aa68d;
		public ProcessFlowElement EventSubProcess4_508cb51f36164caaa73f0ac0ba8aa68d {
			get {
				return _eventSubProcess4_508cb51f36164caaa73f0ac0ba8aa68d ?? (_eventSubProcess4_508cb51f36164caaa73f0ac0ba8aa68d = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4_508cb51f36164caaa73f0ac0ba8aa68d",
					SchemaElementUId = new Guid("508cb51f-3616-4caa-a73f-0ac0ba8aa68d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _supplyPaymentElementSavingStartMessage;
		public ProcessFlowElement SupplyPaymentElementSavingStartMessage {
			get {
				return _supplyPaymentElementSavingStartMessage ?? (_supplyPaymentElementSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SupplyPaymentElementSavingStartMessage",
					SchemaElementUId = new Guid("4d796b37-0e45-4764-add9-f570f85b954a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkInvoiceNeedUpdateScriptTask;
		public ProcessScriptTask CheckInvoiceNeedUpdateScriptTask {
			get {
				return _checkInvoiceNeedUpdateScriptTask ?? (_checkInvoiceNeedUpdateScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckInvoiceNeedUpdateScriptTask",
					SchemaElementUId = new Guid("2740ec62-f6a5-49f9-b0ac-76e6308f52f0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckInvoiceNeedUpdateScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess5_5e647f1234af42ae9c46c76258835c51;
		public ProcessFlowElement EventSubProcess5_5e647f1234af42ae9c46c76258835c51 {
			get {
				return _eventSubProcess5_5e647f1234af42ae9c46c76258835c51 ?? (_eventSubProcess5_5e647f1234af42ae9c46c76258835c51 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess5_5e647f1234af42ae9c46c76258835c51",
					SchemaElementUId = new Guid("5e647f12-34af-42ae-9c46-c76258835c51"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _supplyPaymentElementSaved;
		public ProcessFlowElement SupplyPaymentElementSaved {
			get {
				return _supplyPaymentElementSaved ?? (_supplyPaymentElementSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SupplyPaymentElementSaved",
					SchemaElementUId = new Guid("4be34b07-0cc9-4a0e-8673-32a2727cb27f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("7c930cf3-052f-4706-992b-b0c83c692c4f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess6_8ac6074fae524ec5a0fb4a7cc6093824;
		public ProcessFlowElement EventSubProcess6_8ac6074fae524ec5a0fb4a7cc6093824 {
			get {
				return _eventSubProcess6_8ac6074fae524ec5a0fb4a7cc6093824 ?? (_eventSubProcess6_8ac6074fae524ec5a0fb4a7cc6093824 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess6_8ac6074fae524ec5a0fb4a7cc6093824",
					SchemaElementUId = new Guid("8ac6074f-ae52-4ec5-a0fb-4a7cc6093824"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_53d7f47c41274e0fb1ee96cc0619f7d2;
		public ProcessFlowElement StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2 {
			get {
				return _startMessage3_53d7f47c41274e0fb1ee96cc0619f7d2 ?? (_startMessage3_53d7f47c41274e0fb1ee96cc0619f7d2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2",
					SchemaElementUId = new Guid("9a5dc3bd-e998-4b26-8e29-3e35e4f00fad"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _updateSupplyPaymentInvoiceScriptTask;
		public ProcessScriptTask UpdateSupplyPaymentInvoiceScriptTask {
			get {
				return _updateSupplyPaymentInvoiceScriptTask ?? (_updateSupplyPaymentInvoiceScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateSupplyPaymentInvoiceScriptTask",
					SchemaElementUId = new Guid("3ee32e0a-0ebe-4b69-8899-2118f6358af3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateSupplyPaymentInvoiceScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess7_e365688fde944b00b11dc99b61f8d745;
		public ProcessFlowElement EventSubProcess7_e365688fde944b00b11dc99b61f8d745 {
			get {
				return _eventSubProcess7_e365688fde944b00b11dc99b61f8d745 ?? (_eventSubProcess7_e365688fde944b00b11dc99b61f8d745 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess7_e365688fde944b00b11dc99b61f8d745",
					SchemaElementUId = new Guid("e365688f-de94-4b00-b11d-c99b61f8d745"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _supplyPaymentElementDeletedStartMessage;
		public ProcessFlowElement SupplyPaymentElementDeletedStartMessage {
			get {
				return _supplyPaymentElementDeletedStartMessage ?? (_supplyPaymentElementDeletedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SupplyPaymentElementDeletedStartMessage",
					SchemaElementUId = new Guid("d1383d83-0e51-439b-be9d-115cca30de1b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _onDeleteScriptTask;
		public ProcessScriptTask OnDeleteScriptTask {
			get {
				return _onDeleteScriptTask ?? (_onDeleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OnDeleteScriptTask",
					SchemaElementUId = new Guid("70232d2b-6581-4a1d-a38e-b5569fb3a7d3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OnDeleteScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess4_508cb51f36164caaa73f0ac0ba8aa68d.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4_508cb51f36164caaa73f0ac0ba8aa68d };
			FlowElements[SupplyPaymentElementSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SupplyPaymentElementSavingStartMessage };
			FlowElements[CheckInvoiceNeedUpdateScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckInvoiceNeedUpdateScriptTask };
			FlowElements[EventSubProcess5_5e647f1234af42ae9c46c76258835c51.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5_5e647f1234af42ae9c46c76258835c51 };
			FlowElements[SupplyPaymentElementSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { SupplyPaymentElementSaved };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess6_8ac6074fae524ec5a0fb4a7cc6093824.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6_8ac6074fae524ec5a0fb4a7cc6093824 };
			FlowElements[StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2 };
			FlowElements[UpdateSupplyPaymentInvoiceScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateSupplyPaymentInvoiceScriptTask };
			FlowElements[EventSubProcess7_e365688fde944b00b11dc99b61f8d745.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7_e365688fde944b00b11dc99b61f8d745 };
			FlowElements[SupplyPaymentElementDeletedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SupplyPaymentElementDeletedStartMessage };
			FlowElements[OnDeleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OnDeleteScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess4_508cb51f36164caaa73f0ac0ba8aa68d":
						break;
					case "SupplyPaymentElementSavingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckInvoiceNeedUpdateScriptTask");
						break;
					case "CheckInvoiceNeedUpdateScriptTask":
						break;
					case "EventSubProcess5_5e647f1234af42ae9c46c76258835c51":
						break;
					case "SupplyPaymentElementSaved":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
					case "EventSubProcess6_8ac6074fae524ec5a0fb4a7cc6093824":
						break;
					case "StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2":
						e.Context.QueueTasks.Enqueue("UpdateSupplyPaymentInvoiceScriptTask");
						break;
					case "UpdateSupplyPaymentInvoiceScriptTask":
						break;
					case "EventSubProcess7_e365688fde944b00b11dc99b61f8d745":
						break;
					case "SupplyPaymentElementDeletedStartMessage":
						e.Context.QueueTasks.Enqueue("OnDeleteScriptTask");
						break;
					case "OnDeleteScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SupplyPaymentElementSavingStartMessage");
			ActivatedEventElements.Add("SupplyPaymentElementSaved");
			ActivatedEventElements.Add("StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2");
			ActivatedEventElements.Add("SupplyPaymentElementDeletedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess4_508cb51f36164caaa73f0ac0ba8aa68d":
					context.QueueTasks.Dequeue();
					break;
				case "SupplyPaymentElementSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SupplyPaymentElementSavingStartMessage";
					result = SupplyPaymentElementSavingStartMessage.Execute(context);
					break;
				case "CheckInvoiceNeedUpdateScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckInvoiceNeedUpdateScriptTask";
					result = CheckInvoiceNeedUpdateScriptTask.Execute(context, CheckInvoiceNeedUpdateScriptTaskExecute);
					break;
				case "EventSubProcess5_5e647f1234af42ae9c46c76258835c51":
					context.QueueTasks.Dequeue();
					break;
				case "SupplyPaymentElementSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "SupplyPaymentElementSaved";
					result = SupplyPaymentElementSaved.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "EventSubProcess6_8ac6074fae524ec5a0fb4a7cc6093824":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2";
					result = StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2.Execute(context);
					break;
				case "UpdateSupplyPaymentInvoiceScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateSupplyPaymentInvoiceScriptTask";
					result = UpdateSupplyPaymentInvoiceScriptTask.Execute(context, UpdateSupplyPaymentInvoiceScriptTaskExecute);
					break;
				case "EventSubProcess7_e365688fde944b00b11dc99b61f8d745":
					context.QueueTasks.Dequeue();
					break;
				case "SupplyPaymentElementDeletedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SupplyPaymentElementDeletedStartMessage";
					result = SupplyPaymentElementDeletedStartMessage.Execute(context);
					break;
				case "OnDeleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OnDeleteScriptTask";
					result = OnDeleteScriptTask.Execute(context, OnDeleteScriptTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool CheckInvoiceNeedUpdateScriptTaskExecute(ProcessExecutingContext context) {
			CheckNeedToUpdateInvoice();
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			UpdateLinkedElements();
			OnSaved();
			return true;
		}

		public virtual bool UpdateSupplyPaymentInvoiceScriptTaskExecute(ProcessExecutingContext context) {
			Guid invoiceId = Entity.GetTypedColumnValue<Guid>("InvoiceId");
			Guid invoiceOldId = Entity.GetTypedOldColumnValue<Guid>("InvoiceId");
			if (invoiceId != invoiceOldId) {
				var orderPassportHelper = ClassFactory.Get<OrderPassportHelper>(new ConstructorArgument("userConnection", UserConnection));
				var orderAmountHelper = ClassFactory.Get<OrderAmountHelper>(new ConstructorArgument("userConnection", UserConnection));
				var supplyPaymentElementId = Entity.GetTypedColumnValue<Guid>("Id");
				if (IsInvoiceExists) {
					invoiceId = Entity.GetTypedColumnValue<Guid>("InvoiceId");
					orderPassportHelper.BindSupplyPaymentElementInvoice(supplyPaymentElementId, invoiceId);
				}
				else {
					invoiceId = Entity.GetTypedOldColumnValue<Guid>("InvoiceId");
					orderPassportHelper.UnbindSupplyPaymentElementInvoice(supplyPaymentElementId, invoiceOldId);
					orderAmountHelper.UpdateOrderPaymentAmountOnSPEChanged(Entity.PrimaryColumnValue);
				}
			}
			return true;
		}

		public virtual bool OnDeleteScriptTaskExecute(ProcessExecutingContext context) {
			OnDeleted();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SupplyPaymentElement_Passport_TerrasoftSaving":
							if (ActivatedEventElements.Contains("SupplyPaymentElementSavingStartMessage")) {
							context.QueueTasks.Enqueue("SupplyPaymentElementSavingStartMessage");
						}
						break;
					case "SupplyPaymentElement_Passport_TerrasoftSaved":
							if (ActivatedEventElements.Contains("SupplyPaymentElementSaved")) {
							context.QueueTasks.Enqueue("SupplyPaymentElementSaved");
						}
						break;
					case "SupplyPaymentElement_Passport_TerrasoftUpdated":
							if (ActivatedEventElements.Contains("StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2")) {
							context.QueueTasks.Enqueue("StartMessage3_53d7f47c41274e0fb1ee96cc0619f7d2");
						}
						break;
					case "SupplyPaymentElement_Passport_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("SupplyPaymentElementDeletedStartMessage")) {
							context.QueueTasks.Enqueue("SupplyPaymentElementDeletedStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentElement_PassportEventsProcess

	/// <exclude/>
	public class SupplyPaymentElement_PassportEventsProcess : SupplyPaymentElement_PassportEventsProcess<SupplyPaymentElement_Passport_Terrasoft>
	{

		public SupplyPaymentElement_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

