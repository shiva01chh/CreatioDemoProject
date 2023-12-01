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
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: CurrencyRate_CrtUIv2_TerrasoftSchema

	/// <exclude/>
	public class CurrencyRate_CrtUIv2_TerrasoftSchema : Terrasoft.Configuration.CurrencyRate_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public CurrencyRate_CrtUIv2_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CurrencyRate_CrtUIv2_TerrasoftSchema(CurrencyRate_CrtUIv2_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CurrencyRate_CrtUIv2_TerrasoftSchema(CurrencyRate_CrtUIv2_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("cc08a45a-98c8-476e-bd71-daf623698665");
			Name = "CurrencyRate_CrtUIv2_Terrasoft";
			ParentSchemaUId = new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f");
			ExtendParent = true;
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6c9f3250-8758-4e5a-9a49-c8aa0726fe30")) == null) {
				Columns.Add(CreateRateMantissaColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateRateMantissaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("6c9f3250-8758-4e5a-9a49-c8aa0726fe30"),
				Name = @"RateMantissa",
				CreatedInSchemaUId = new Guid("cc08a45a-98c8-476e-bd71-daf623698665"),
				ModifiedInSchemaUId = new Guid("cc08a45a-98c8-476e-bd71-daf623698665"),
				CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CurrencyRate_CrtUIv2_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CurrencyRate_CrtUIv2EventsProcess(userConnection);
		}

		public override object Clone() {
			return new CurrencyRate_CrtUIv2_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CurrencyRate_CrtUIv2_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cc08a45a-98c8-476e-bd71-daf623698665"));
		}

		#endregion

	}

	#endregion

	#region Class: CurrencyRate_CrtUIv2_Terrasoft

	/// <summary>
	/// Exchange rate.
	/// </summary>
	public class CurrencyRate_CrtUIv2_Terrasoft : Terrasoft.Configuration.CurrencyRate_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public CurrencyRate_CrtUIv2_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CurrencyRate_CrtUIv2_Terrasoft";
		}

		public CurrencyRate_CrtUIv2_Terrasoft(CurrencyRate_CrtUIv2_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		public string RateMantissa {
			get {
				return GetTypedColumnValue<string>("RateMantissa");
			}
			set {
				SetColumnValue("RateMantissa", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CurrencyRate_CrtUIv2EventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saving += (s, e) => ThrowEvent("CurrencyRate_CrtUIv2_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("CurrencyRate_CrtUIv2_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CurrencyRate_CrtUIv2_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: CurrencyRate_CrtUIv2EventsProcess

	/// <exclude/>
	public partial class CurrencyRate_CrtUIv2EventsProcess<TEntity> : Terrasoft.Configuration.CurrencyRate_CrtBaseEventsProcess<TEntity> where TEntity : CurrencyRate_CrtUIv2_Terrasoft
	{

		public CurrencyRate_CrtUIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CurrencyRate_CrtUIv2EventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("cc08a45a-98c8-476e-bd71-daf623698665");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("df11dc2b-a610-4c9f-9e38-90b65bea4c19"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _currencyRateSavingMessage;
		public ProcessFlowElement CurrencyRateSavingMessage {
			get {
				return _currencyRateSavingMessage ?? (_currencyRateSavingMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CurrencyRateSavingMessage",
					SchemaElementUId = new Guid("5c0e8c0b-adf0-46e1-9ca6-6fd52b39f541"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _currencyRateSavingTask;
		public ProcessScriptTask CurrencyRateSavingTask {
			get {
				return _currencyRateSavingTask ?? (_currencyRateSavingTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CurrencyRateSavingTask",
					SchemaElementUId = new Guid("d4c169eb-978c-4536-aec2-dd7ce24e3dad"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CurrencyRateSavingTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[CurrencyRateSavingMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateSavingMessage };
			FlowElements[CurrencyRateSavingTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CurrencyRateSavingTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3":
						break;
					case "CurrencyRateSavingMessage":
						e.Context.QueueTasks.Enqueue("CurrencyRateSavingTask");
						break;
					case "CurrencyRateSavingTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CurrencyRateSavingMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "CurrencyRateSavingMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencyRateSavingMessage";
					result = CurrencyRateSavingMessage.Execute(context);
					break;
				case "CurrencyRateSavingTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CurrencyRateSavingTask";
					result = CurrencyRateSavingTask.Execute(context, CurrencyRateSavingTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool CurrencyRateSavingTaskExecute(ProcessExecutingContext context) {
			var changedColumns = Entity.GetChangedColumnValues();
			if (changedColumns.Any(c => c.Name == "Rate")) {
				EntitySchemaColumn rateColumn = Entity.Schema.Columns.FindByName("Rate");
				FloatDataValueType dataValueType = rateColumn.DataValueType as FloatDataValueType;
				decimal currencyRate = Entity.GetTypedColumnValue<decimal>("Rate");
				string mantissa = CurrencyRateHelper.GetRateMantissa(currencyRate);
				Entity.SetColumnValue("RateMantissa", mantissa);
				Entity.SetColumnValue("Rate", Math.Round(currencyRate, dataValueType.DBPrecision,
					MidpointRounding.AwayFromZero));
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CurrencyRate_CrtUIv2_TerrasoftSaving":
							if (ActivatedEventElements.Contains("CurrencyRateSavingMessage")) {
							context.QueueTasks.Enqueue("CurrencyRateSavingMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: CurrencyRate_CrtUIv2EventsProcess

	/// <exclude/>
	public class CurrencyRate_CrtUIv2EventsProcess : CurrencyRate_CrtUIv2EventsProcess<CurrencyRate_CrtUIv2_Terrasoft>
	{

		public CurrencyRate_CrtUIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CurrencyRate_CrtUIv2EventsProcess

	public partial class CurrencyRate_CrtUIv2EventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

