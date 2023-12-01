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
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.EntitySynchronization;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Contact_RelationshipDesigner_TerrasoftSchema

	/// <exclude/>
	public class Contact_RelationshipDesigner_TerrasoftSchema : Terrasoft.Configuration.Contact_Completeness_TerrasoftSchema
	{

		#region Constructors: Public

		public Contact_RelationshipDesigner_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contact_RelationshipDesigner_TerrasoftSchema(Contact_RelationshipDesigner_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contact_RelationshipDesigner_TerrasoftSchema(Contact_RelationshipDesigner_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("4bf667d6-7530-420e-b4ef-12c6b0c67a44");
			Name = "Contact_RelationshipDesigner_Terrasoft";
			ParentSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("ac9dec01-f305-4a8c-bd6f-7a943e292d3e");
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
			return new Contact_RelationshipDesigner_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contact_RelationshipDesignerEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contact_RelationshipDesigner_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contact_RelationshipDesigner_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4bf667d6-7530-420e-b4ef-12c6b0c67a44"));
		}

		#endregion

	}

	#endregion

	#region Class: Contact_RelationshipDesigner_Terrasoft

	/// <summary>
	/// Contact.
	/// </summary>
	public class Contact_RelationshipDesigner_Terrasoft : Terrasoft.Configuration.Contact_Completeness_Terrasoft
	{

		#region Constructors: Public

		public Contact_RelationshipDesigner_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contact_RelationshipDesigner_Terrasoft";
		}

		public Contact_RelationshipDesigner_Terrasoft(Contact_RelationshipDesigner_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contact_RelationshipDesignerEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Contact_RelationshipDesigner_TerrasoftDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Contact_RelationshipDesigner_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contact_RelationshipDesignerEventsProcess

	/// <exclude/>
	public partial class Contact_RelationshipDesignerEventsProcess<TEntity> : Terrasoft.Configuration.Contact_CompletenessEventsProcess<TEntity> where TEntity : Contact_RelationshipDesigner_Terrasoft
	{

		public Contact_RelationshipDesignerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contact_RelationshipDesignerEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4bf667d6-7530-420e-b4ef-12c6b0c67a44");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_daf6a3f45d524b49beff480baa8b27ec;
		public ProcessFlowElement EventSubProcess3_daf6a3f45d524b49beff480baa8b27ec {
			get {
				return _eventSubProcess3_daf6a3f45d524b49beff480baa8b27ec ?? (_eventSubProcess3_daf6a3f45d524b49beff480baa8b27ec = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_daf6a3f45d524b49beff480baa8b27ec",
					SchemaElementUId = new Guid("daf6a3f4-5d52-4b49-beff-480baa8b27ec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_d2d291d7036e4fbd82b42ab45f34ec81;
		public ProcessFlowElement StartMessage3_d2d291d7036e4fbd82b42ab45f34ec81 {
			get {
				return _startMessage3_d2d291d7036e4fbd82b42ab45f34ec81 ?? (_startMessage3_d2d291d7036e4fbd82b42ab45f34ec81 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_d2d291d7036e4fbd82b42ab45f34ec81",
					SchemaElementUId = new Guid("d2d291d7-036e-4fbd-82b4-2ab45f34ec81"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_64c7552c697d40269bb7cafe8513a56d;
		public ProcessScriptTask ScriptTask3_64c7552c697d40269bb7cafe8513a56d {
			get {
				return _scriptTask3_64c7552c697d40269bb7cafe8513a56d ?? (_scriptTask3_64c7552c697d40269bb7cafe8513a56d = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_64c7552c697d40269bb7cafe8513a56d",
					SchemaElementUId = new Guid("64c7552c-697d-4026-9bb7-cafe8513a56d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_64c7552c697d40269bb7cafe8513a56dExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_daf6a3f45d524b49beff480baa8b27ec.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_daf6a3f45d524b49beff480baa8b27ec };
			FlowElements[StartMessage3_d2d291d7036e4fbd82b42ab45f34ec81.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_d2d291d7036e4fbd82b42ab45f34ec81 };
			FlowElements[ScriptTask3_64c7552c697d40269bb7cafe8513a56d.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_64c7552c697d40269bb7cafe8513a56d };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_daf6a3f45d524b49beff480baa8b27ec":
						break;
					case "StartMessage3_d2d291d7036e4fbd82b42ab45f34ec81":
						e.Context.QueueTasks.Enqueue("ScriptTask3_64c7552c697d40269bb7cafe8513a56d");
						break;
					case "ScriptTask3_64c7552c697d40269bb7cafe8513a56d":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_d2d291d7036e4fbd82b42ab45f34ec81");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_daf6a3f45d524b49beff480baa8b27ec":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_d2d291d7036e4fbd82b42ab45f34ec81":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_d2d291d7036e4fbd82b42ab45f34ec81";
					result = StartMessage3_d2d291d7036e4fbd82b42ab45f34ec81.Execute(context);
					break;
				case "ScriptTask3_64c7552c697d40269bb7cafe8513a56d":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_64c7552c697d40269bb7cafe8513a56d";
					result = ScriptTask3_64c7552c697d40269bb7cafe8513a56d.Execute(context, ScriptTask3_64c7552c697d40269bb7cafe8513a56dExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3_64c7552c697d40269bb7cafe8513a56dExecute(ProcessExecutingContext context) {
			return DeleteRelationshipEntity();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Contact_RelationshipDesigner_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("StartMessage3_d2d291d7036e4fbd82b42ab45f34ec81")) {
							context.QueueTasks.Enqueue("StartMessage3_d2d291d7036e4fbd82b42ab45f34ec81");
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

	#region Class: Contact_RelationshipDesignerEventsProcess

	/// <exclude/>
	public class Contact_RelationshipDesignerEventsProcess : Contact_RelationshipDesignerEventsProcess<Contact_RelationshipDesigner_Terrasoft>
	{

		public Contact_RelationshipDesignerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

