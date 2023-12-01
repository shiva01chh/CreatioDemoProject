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

	#region Class: BulkEmailSchema

	/// <exclude/>
	public class BulkEmailSchema : Terrasoft.Configuration.BulkEmail_CrtEmailInCampaignBase_TerrasoftSchema
	{

		#region Constructors: Public

		public BulkEmailSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmailSchema(BulkEmailSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmailSchema(BulkEmailSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("7d99feb4-568c-4a83-b5f3-e66c008fecb8");
			Name = "BulkEmail";
			ParentSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8");
			ExtendParent = true;
			CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ea0bf113-a0a3-4b5c-b3b7-c82f8f10c610")) == null) {
				Columns.Add(CreateNotesColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("ea0bf113-a0a3-4b5c-b3b7-c82f8f10c610"),
				Name = @"Notes",
				CreatedInSchemaUId = new Guid("7d99feb4-568c-4a83-b5f3-e66c008fecb8"),
				ModifiedInSchemaUId = new Guid("7d99feb4-568c-4a83-b5f3-e66c008fecb8"),
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BulkEmail(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BulkEmail_MarketingCampaignEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BulkEmailSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmailSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7d99feb4-568c-4a83-b5f3-e66c008fecb8"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmail

	/// <summary>
	/// Email.
	/// </summary>
	public class BulkEmail : Terrasoft.Configuration.BulkEmail_CrtEmailInCampaignBase_Terrasoft
	{

		#region Constructors: Public

		public BulkEmail(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmail";
		}

		public BulkEmail(BulkEmail source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Notes.
		/// </summary>
		public string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmail_MarketingCampaignEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BulkEmail(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmail_MarketingCampaignEventsProcess

	/// <exclude/>
	public partial class BulkEmail_MarketingCampaignEventsProcess<TEntity> : Terrasoft.Configuration.BulkEmail_CrtEmailInCampaignBaseEventsProcess<TEntity> where TEntity : BulkEmail
	{

		public BulkEmail_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmail_MarketingCampaignEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7d99feb4-568c-4a83-b5f3-e66c008fecb8");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _bulkEmailInsertStartMessageEventSubProcess;
		public ProcessFlowElement BulkEmailInsertStartMessageEventSubProcess {
			get {
				return _bulkEmailInsertStartMessageEventSubProcess ?? (_bulkEmailInsertStartMessageEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BulkEmailInsertStartMessageEventSubProcess",
					SchemaElementUId = new Guid("76334e5e-ff01-43a2-8d27-03c50ab001cd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_69bf1aeea0c54dbaabfd403802c94508;
		public ProcessFlowElement StartMessage3_69bf1aeea0c54dbaabfd403802c94508 {
			get {
				return _startMessage3_69bf1aeea0c54dbaabfd403802c94508 ?? (_startMessage3_69bf1aeea0c54dbaabfd403802c94508 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_69bf1aeea0c54dbaabfd403802c94508",
					SchemaElementUId = new Guid("69bf1aee-a0c5-4dba-abfd-403802c94508"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_609296fa94ab4efab7b37313abe181cf;
		public ProcessScriptTask ScriptTask3_609296fa94ab4efab7b37313abe181cf {
			get {
				return _scriptTask3_609296fa94ab4efab7b37313abe181cf ?? (_scriptTask3_609296fa94ab4efab7b37313abe181cf = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_609296fa94ab4efab7b37313abe181cf",
					SchemaElementUId = new Guid("609296fa-94ab-4efa-b7b3-7313abe181cf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_609296fa94ab4efab7b37313abe181cfExecute,
				});
			}
		}

		private ProcessFlowElement _bulkEmailSavingStartMessageEventSubProcess;
		public ProcessFlowElement BulkEmailSavingStartMessageEventSubProcess {
			get {
				return _bulkEmailSavingStartMessageEventSubProcess ?? (_bulkEmailSavingStartMessageEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BulkEmailSavingStartMessageEventSubProcess",
					SchemaElementUId = new Guid("e3a54638-3132-42ae-b162-6748abcfc75e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_783f5657a9ca4d47b35e7c33882223bf;
		public ProcessFlowElement StartMessage4_783f5657a9ca4d47b35e7c33882223bf {
			get {
				return _startMessage4_783f5657a9ca4d47b35e7c33882223bf ?? (_startMessage4_783f5657a9ca4d47b35e7c33882223bf = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_783f5657a9ca4d47b35e7c33882223bf",
					SchemaElementUId = new Guid("783f5657-a9ca-4d47-b35e-7c33882223bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4_d21001c53ae94008b85469760c732b2a;
		public ProcessScriptTask ScriptTask4_d21001c53ae94008b85469760c732b2a {
			get {
				return _scriptTask4_d21001c53ae94008b85469760c732b2a ?? (_scriptTask4_d21001c53ae94008b85469760c732b2a = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4_d21001c53ae94008b85469760c732b2a",
					SchemaElementUId = new Guid("d21001c5-3ae9-4008-b854-69760c732b2a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4_d21001c53ae94008b85469760c732b2aExecute,
				});
			}
		}

		private ProcessFlowElement _bulkEmailSavedStartMessageEventSubProcess;
		public ProcessFlowElement BulkEmailSavedStartMessageEventSubProcess {
			get {
				return _bulkEmailSavedStartMessageEventSubProcess ?? (_bulkEmailSavedStartMessageEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BulkEmailSavedStartMessageEventSubProcess",
					SchemaElementUId = new Guid("b1d0e8c8-430b-4d63-b307-5a4c12b44615"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage5_c63f9c0886a04f218665437167a2ac44;
		public ProcessFlowElement StartMessage5_c63f9c0886a04f218665437167a2ac44 {
			get {
				return _startMessage5_c63f9c0886a04f218665437167a2ac44 ?? (_startMessage5_c63f9c0886a04f218665437167a2ac44 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage5_c63f9c0886a04f218665437167a2ac44",
					SchemaElementUId = new Guid("c63f9c08-86a0-4f21-8665-437167a2ac44"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask5_27e414ef39c441959636eea9c0f21509;
		public ProcessScriptTask ScriptTask5_27e414ef39c441959636eea9c0f21509 {
			get {
				return _scriptTask5_27e414ef39c441959636eea9c0f21509 ?? (_scriptTask5_27e414ef39c441959636eea9c0f21509 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask5_27e414ef39c441959636eea9c0f21509",
					SchemaElementUId = new Guid("27e414ef-39c4-4195-9636-eea9c0f21509"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5_27e414ef39c441959636eea9c0f21509Execute,
				});
			}
		}

		private ProcessFlowElement _bulkEmailDeletingStartMessageEventSubProcess;
		public ProcessFlowElement BulkEmailDeletingStartMessageEventSubProcess {
			get {
				return _bulkEmailDeletingStartMessageEventSubProcess ?? (_bulkEmailDeletingStartMessageEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BulkEmailDeletingStartMessageEventSubProcess",
					SchemaElementUId = new Guid("05be681e-5dbd-49a1-818c-e5010508a882"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage6_180c8267b0d84ddd94a6e5e80fee98ad;
		public ProcessFlowElement StartMessage6_180c8267b0d84ddd94a6e5e80fee98ad {
			get {
				return _startMessage6_180c8267b0d84ddd94a6e5e80fee98ad ?? (_startMessage6_180c8267b0d84ddd94a6e5e80fee98ad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage6_180c8267b0d84ddd94a6e5e80fee98ad",
					SchemaElementUId = new Guid("180c8267-b0d8-4ddd-94a6-e5e80fee98ad"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask6_a367341d28204b958aaa5949dee82291;
		public ProcessScriptTask ScriptTask6_a367341d28204b958aaa5949dee82291 {
			get {
				return _scriptTask6_a367341d28204b958aaa5949dee82291 ?? (_scriptTask6_a367341d28204b958aaa5949dee82291 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask6_a367341d28204b958aaa5949dee82291",
					SchemaElementUId = new Guid("a367341d-2820-4b95-8aaa-5949dee82291"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask6_a367341d28204b958aaa5949dee82291Execute,
				});
			}
		}

		private ProcessFlowElement _bulkEmailDeletedStartMessageEventSubProcess;
		public ProcessFlowElement BulkEmailDeletedStartMessageEventSubProcess {
			get {
				return _bulkEmailDeletedStartMessageEventSubProcess ?? (_bulkEmailDeletedStartMessageEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BulkEmailDeletedStartMessageEventSubProcess",
					SchemaElementUId = new Guid("a6e305a3-0ffd-4b23-853d-85880fcd3a4b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage7_80d72f730e044180bf2da0b70c8419ba;
		public ProcessFlowElement StartMessage7_80d72f730e044180bf2da0b70c8419ba {
			get {
				return _startMessage7_80d72f730e044180bf2da0b70c8419ba ?? (_startMessage7_80d72f730e044180bf2da0b70c8419ba = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage7_80d72f730e044180bf2da0b70c8419ba",
					SchemaElementUId = new Guid("80d72f73-0e04-4180-bf2d-a0b70c8419ba"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask7_b37fece833ba461694f64b9c396426c6;
		public ProcessScriptTask ScriptTask7_b37fece833ba461694f64b9c396426c6 {
			get {
				return _scriptTask7_b37fece833ba461694f64b9c396426c6 ?? (_scriptTask7_b37fece833ba461694f64b9c396426c6 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask7_b37fece833ba461694f64b9c396426c6",
					SchemaElementUId = new Guid("b37fece8-33ba-4616-94f6-4b9c396426c6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask7_b37fece833ba461694f64b9c396426c6Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[BulkEmailInsertStartMessageEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BulkEmailInsertStartMessageEventSubProcess };
			FlowElements[StartMessage3_69bf1aeea0c54dbaabfd403802c94508.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_69bf1aeea0c54dbaabfd403802c94508 };
			FlowElements[ScriptTask3_609296fa94ab4efab7b37313abe181cf.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_609296fa94ab4efab7b37313abe181cf };
			FlowElements[BulkEmailSavingStartMessageEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BulkEmailSavingStartMessageEventSubProcess };
			FlowElements[StartMessage4_783f5657a9ca4d47b35e7c33882223bf.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_783f5657a9ca4d47b35e7c33882223bf };
			FlowElements[ScriptTask4_d21001c53ae94008b85469760c732b2a.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4_d21001c53ae94008b85469760c732b2a };
			FlowElements[BulkEmailSavedStartMessageEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BulkEmailSavedStartMessageEventSubProcess };
			FlowElements[StartMessage5_c63f9c0886a04f218665437167a2ac44.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5_c63f9c0886a04f218665437167a2ac44 };
			FlowElements[ScriptTask5_27e414ef39c441959636eea9c0f21509.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5_27e414ef39c441959636eea9c0f21509 };
			FlowElements[BulkEmailDeletingStartMessageEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BulkEmailDeletingStartMessageEventSubProcess };
			FlowElements[StartMessage6_180c8267b0d84ddd94a6e5e80fee98ad.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage6_180c8267b0d84ddd94a6e5e80fee98ad };
			FlowElements[ScriptTask6_a367341d28204b958aaa5949dee82291.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask6_a367341d28204b958aaa5949dee82291 };
			FlowElements[BulkEmailDeletedStartMessageEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BulkEmailDeletedStartMessageEventSubProcess };
			FlowElements[StartMessage7_80d72f730e044180bf2da0b70c8419ba.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage7_80d72f730e044180bf2da0b70c8419ba };
			FlowElements[ScriptTask7_b37fece833ba461694f64b9c396426c6.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask7_b37fece833ba461694f64b9c396426c6 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "BulkEmailInsertStartMessageEventSubProcess":
						break;
					case "StartMessage3_69bf1aeea0c54dbaabfd403802c94508":
						e.Context.QueueTasks.Enqueue("ScriptTask3_609296fa94ab4efab7b37313abe181cf");
						break;
					case "ScriptTask3_609296fa94ab4efab7b37313abe181cf":
						break;
					case "BulkEmailSavingStartMessageEventSubProcess":
						break;
					case "StartMessage4_783f5657a9ca4d47b35e7c33882223bf":
						e.Context.QueueTasks.Enqueue("ScriptTask4_d21001c53ae94008b85469760c732b2a");
						break;
					case "ScriptTask4_d21001c53ae94008b85469760c732b2a":
						break;
					case "BulkEmailSavedStartMessageEventSubProcess":
						break;
					case "StartMessage5_c63f9c0886a04f218665437167a2ac44":
						e.Context.QueueTasks.Enqueue("ScriptTask5_27e414ef39c441959636eea9c0f21509");
						break;
					case "ScriptTask5_27e414ef39c441959636eea9c0f21509":
						break;
					case "BulkEmailDeletingStartMessageEventSubProcess":
						break;
					case "StartMessage6_180c8267b0d84ddd94a6e5e80fee98ad":
						e.Context.QueueTasks.Enqueue("ScriptTask6_a367341d28204b958aaa5949dee82291");
						break;
					case "ScriptTask6_a367341d28204b958aaa5949dee82291":
						break;
					case "BulkEmailDeletedStartMessageEventSubProcess":
						break;
					case "StartMessage7_80d72f730e044180bf2da0b70c8419ba":
						e.Context.QueueTasks.Enqueue("ScriptTask7_b37fece833ba461694f64b9c396426c6");
						break;
					case "ScriptTask7_b37fece833ba461694f64b9c396426c6":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_69bf1aeea0c54dbaabfd403802c94508");
			ActivatedEventElements.Add("StartMessage4_783f5657a9ca4d47b35e7c33882223bf");
			ActivatedEventElements.Add("StartMessage5_c63f9c0886a04f218665437167a2ac44");
			ActivatedEventElements.Add("StartMessage6_180c8267b0d84ddd94a6e5e80fee98ad");
			ActivatedEventElements.Add("StartMessage7_80d72f730e044180bf2da0b70c8419ba");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "BulkEmailInsertStartMessageEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_69bf1aeea0c54dbaabfd403802c94508":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_69bf1aeea0c54dbaabfd403802c94508";
					result = StartMessage3_69bf1aeea0c54dbaabfd403802c94508.Execute(context);
					break;
				case "ScriptTask3_609296fa94ab4efab7b37313abe181cf":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_609296fa94ab4efab7b37313abe181cf";
					result = ScriptTask3_609296fa94ab4efab7b37313abe181cf.Execute(context, ScriptTask3_609296fa94ab4efab7b37313abe181cfExecute);
					break;
				case "BulkEmailSavingStartMessageEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4_783f5657a9ca4d47b35e7c33882223bf":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_783f5657a9ca4d47b35e7c33882223bf";
					result = StartMessage4_783f5657a9ca4d47b35e7c33882223bf.Execute(context);
					break;
				case "ScriptTask4_d21001c53ae94008b85469760c732b2a":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4_d21001c53ae94008b85469760c732b2a";
					result = ScriptTask4_d21001c53ae94008b85469760c732b2a.Execute(context, ScriptTask4_d21001c53ae94008b85469760c732b2aExecute);
					break;
				case "BulkEmailSavedStartMessageEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5_c63f9c0886a04f218665437167a2ac44":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5_c63f9c0886a04f218665437167a2ac44";
					result = StartMessage5_c63f9c0886a04f218665437167a2ac44.Execute(context);
					break;
				case "ScriptTask5_27e414ef39c441959636eea9c0f21509":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5_27e414ef39c441959636eea9c0f21509";
					result = ScriptTask5_27e414ef39c441959636eea9c0f21509.Execute(context, ScriptTask5_27e414ef39c441959636eea9c0f21509Execute);
					break;
				case "BulkEmailDeletingStartMessageEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage6_180c8267b0d84ddd94a6e5e80fee98ad":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage6_180c8267b0d84ddd94a6e5e80fee98ad";
					result = StartMessage6_180c8267b0d84ddd94a6e5e80fee98ad.Execute(context);
					break;
				case "ScriptTask6_a367341d28204b958aaa5949dee82291":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask6_a367341d28204b958aaa5949dee82291";
					result = ScriptTask6_a367341d28204b958aaa5949dee82291.Execute(context, ScriptTask6_a367341d28204b958aaa5949dee82291Execute);
					break;
				case "BulkEmailDeletedStartMessageEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage7_80d72f730e044180bf2da0b70c8419ba":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage7_80d72f730e044180bf2da0b70c8419ba";
					result = StartMessage7_80d72f730e044180bf2da0b70c8419ba.Execute(context);
					break;
				case "ScriptTask7_b37fece833ba461694f64b9c396426c6":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask7_b37fece833ba461694f64b9c396426c6";
					result = ScriptTask7_b37fece833ba461694f64b9c396426c6.Execute(context, ScriptTask7_b37fece833ba461694f64b9c396426c6Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3_609296fa94ab4efab7b37313abe181cfExecute(ProcessExecutingContext context) {
			//BulkEmailInserting();
			return true;
		}

		public virtual bool ScriptTask4_d21001c53ae94008b85469760c732b2aExecute(ProcessExecutingContext context) {
			/*
			var bulkEmailId = Entity.GetTypedColumnValue<Guid>("Id");
			var oldBulkEmailId = Entity.GetTypedOldColumnValue<Guid>("Id");
			IsCopy = bulkEmailId != oldBulkEmailId;
			SourceBulkEmailId = IsCopy ? oldBulkEmailId : default(Guid);
			var templateBody = Entity.GetTypedColumnValue<string>("TemplateBody");
			var oldTemplateBody = Entity.GetTypedOldColumnValue<string>("TemplateBody");
			IsTemplateBodyChanged = !templateBody.Equals(oldTemplateBody, StringComparison.OrdinalIgnoreCase);
			if (IsCopy) {
				SetBulkEmailStatus();
			}
			var oldAudienceSchemaId = Entity.GetTypedOldColumnValue<Guid>("AudienceSchemaId");
			var isAudienceInited = Entity.GetTypedColumnValue<bool>("IsAudienceInited");
			if (!isAudienceInited) {
				CheckAudienceSchemaState(bulkEmailId);
			} else {
				Entity.SetColumnValue("AudienceSchemaId", oldAudienceSchemaId);
			}
			*/
			return true;
		}

		public virtual bool ScriptTask5_27e414ef39c441959636eea9c0f21509Execute(ProcessExecutingContext context) {
			//BulkEmailSaved();
			return true;
		}

		public virtual bool ScriptTask6_a367341d28204b958aaa5949dee82291Execute(ProcessExecutingContext context) {
			//BulkEmailDeleting();
			return true;
		}

		public virtual bool ScriptTask7_b37fece833ba461694f64b9c396426c6Execute(ProcessExecutingContext context) {
			//BulkEmailDeleted();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "BulkEmailInserting":
							if (ActivatedEventElements.Contains("StartMessage3_69bf1aeea0c54dbaabfd403802c94508")) {
							context.QueueTasks.Enqueue("StartMessage3_69bf1aeea0c54dbaabfd403802c94508");
							ProcessQueue(context);
							return;
						}
						break;
					case "BulkEmailSaving":
							if (ActivatedEventElements.Contains("StartMessage4_783f5657a9ca4d47b35e7c33882223bf")) {
							context.QueueTasks.Enqueue("StartMessage4_783f5657a9ca4d47b35e7c33882223bf");
							ProcessQueue(context);
							return;
						}
						break;
					case "BulkEmailSaved":
							if (ActivatedEventElements.Contains("StartMessage5_c63f9c0886a04f218665437167a2ac44")) {
							context.QueueTasks.Enqueue("StartMessage5_c63f9c0886a04f218665437167a2ac44");
							ProcessQueue(context);
							return;
						}
						break;
					case "BulkEmailDeleting":
							if (ActivatedEventElements.Contains("StartMessage6_180c8267b0d84ddd94a6e5e80fee98ad")) {
							context.QueueTasks.Enqueue("StartMessage6_180c8267b0d84ddd94a6e5e80fee98ad");
							ProcessQueue(context);
							return;
						}
						break;
					case "BulkEmailDeleted":
							if (ActivatedEventElements.Contains("StartMessage7_80d72f730e044180bf2da0b70c8419ba")) {
							context.QueueTasks.Enqueue("StartMessage7_80d72f730e044180bf2da0b70c8419ba");
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

	#region Class: BulkEmail_MarketingCampaignEventsProcess

	/// <exclude/>
	public class BulkEmail_MarketingCampaignEventsProcess : BulkEmail_MarketingCampaignEventsProcess<BulkEmail>
	{

		public BulkEmail_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: BulkEmailEventsProcess

	/// <exclude/>
	public class BulkEmailEventsProcess : BulkEmail_MarketingCampaignEventsProcess
	{

		public BulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

