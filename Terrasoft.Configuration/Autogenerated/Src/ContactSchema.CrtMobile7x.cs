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
	using Terrasoft.Core.ImageAPI;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Contact_CrtMobile7x_TerrasoftSchema

	/// <exclude/>
	public class Contact_CrtMobile7x_TerrasoftSchema : Terrasoft.Configuration.Contact_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public Contact_CrtMobile7x_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contact_CrtMobile7x_TerrasoftSchema(Contact_CrtMobile7x_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contact_CrtMobile7x_TerrasoftSchema(Contact_CrtMobile7x_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("f9ede072-a4c8-47ed-8ab0-30a8f7150d18");
			Name = "Contact_CrtMobile7x_Terrasoft";
			ParentSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5");
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
			return new Contact_CrtMobile7x_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contact_CrtMobile7xEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contact_CrtMobile7x_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contact_CrtMobile7x_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f9ede072-a4c8-47ed-8ab0-30a8f7150d18"));
		}

		#endregion

	}

	#endregion

	#region Class: Contact_CrtMobile7x_Terrasoft

	/// <summary>
	/// Contact.
	/// </summary>
	public class Contact_CrtMobile7x_Terrasoft : Terrasoft.Configuration.Contact_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public Contact_CrtMobile7x_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contact_CrtMobile7x_Terrasoft";
		}

		public Contact_CrtMobile7x_Terrasoft(Contact_CrtMobile7x_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contact_CrtMobile7xEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Contact_CrtMobile7x_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Contact_CrtMobile7x_TerrasoftDeleting", e);
			Inserting += (s, e) => ThrowEvent("Contact_CrtMobile7x_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Contact_CrtMobile7x_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Contact_CrtMobile7x_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Contact_CrtMobile7x_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Contact_CrtMobile7x_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contact_CrtMobile7xEventsProcess

	/// <exclude/>
	public partial class Contact_CrtMobile7xEventsProcess<TEntity> : Terrasoft.Configuration.Contact_CrtBaseEventsProcess<TEntity> where TEntity : Contact_CrtMobile7x_Terrasoft
	{

		public Contact_CrtMobile7xEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contact_CrtMobile7xEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f9ede072-a4c8-47ed-8ab0-30a8f7150d18");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool PhotoHasChanged {
			get;
			set;
		}

		private ProcessFlowElement _afterContactSavedSubProcess;
		public ProcessFlowElement AfterContactSavedSubProcess {
			get {
				return _afterContactSavedSubProcess ?? (_afterContactSavedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AfterContactSavedSubProcess",
					SchemaElementUId = new Guid("2c97aaf4-5182-4b15-b835-75ec33ee5521"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _afterContactSavedScriptTask;
		public ProcessScriptTask AfterContactSavedScriptTask {
			get {
				return _afterContactSavedScriptTask ?? (_afterContactSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AfterContactSavedScriptTask",
					SchemaElementUId = new Guid("3c54a5d6-8af4-404e-9d53-69c1edc927e0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AfterContactSavedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _afterContactSaved;
		public ProcessFlowElement AfterContactSaved {
			get {
				return _afterContactSaved ?? (_afterContactSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AfterContactSaved",
					SchemaElementUId = new Guid("1865f3ed-b02b-4930-bbf0-b4cf6905c009"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _beforeContactSavingScriptTaskSubProcess;
		public ProcessFlowElement BeforeContactSavingScriptTaskSubProcess {
			get {
				return _beforeContactSavingScriptTaskSubProcess ?? (_beforeContactSavingScriptTaskSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BeforeContactSavingScriptTaskSubProcess",
					SchemaElementUId = new Guid("5ad7c733-cd63-4655-bf51-8687d8ef19bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _beforeContactSaving;
		public ProcessFlowElement BeforeContactSaving {
			get {
				return _beforeContactSaving ?? (_beforeContactSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BeforeContactSaving",
					SchemaElementUId = new Guid("278bfb7b-88df-4a5f-a4f2-47138e41c417"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _beforeContactSavingScriptTask;
		public ProcessScriptTask BeforeContactSavingScriptTask {
			get {
				return _beforeContactSavingScriptTask ?? (_beforeContactSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BeforeContactSavingScriptTask",
					SchemaElementUId = new Guid("9b206c93-d7ce-4779-9555-54f2b5881509"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BeforeContactSavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[AfterContactSavedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AfterContactSavedSubProcess };
			FlowElements[AfterContactSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AfterContactSavedScriptTask };
			FlowElements[AfterContactSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { AfterContactSaved };
			FlowElements[BeforeContactSavingScriptTaskSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeContactSavingScriptTaskSubProcess };
			FlowElements[BeforeContactSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeContactSaving };
			FlowElements[BeforeContactSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeContactSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "AfterContactSavedSubProcess":
						break;
					case "AfterContactSavedScriptTask":
						break;
					case "AfterContactSaved":
						e.Context.QueueTasks.Enqueue("AfterContactSavedScriptTask");
						break;
					case "BeforeContactSavingScriptTaskSubProcess":
						break;
					case "BeforeContactSaving":
						e.Context.QueueTasks.Enqueue("BeforeContactSavingScriptTask");
						break;
					case "BeforeContactSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("AfterContactSaved");
			ActivatedEventElements.Add("BeforeContactSaving");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "AfterContactSavedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "AfterContactSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AfterContactSavedScriptTask";
					result = AfterContactSavedScriptTask.Execute(context, AfterContactSavedScriptTaskExecute);
					break;
				case "AfterContactSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "AfterContactSaved";
					result = AfterContactSaved.Execute(context);
					break;
				case "BeforeContactSavingScriptTaskSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BeforeContactSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "BeforeContactSaving";
					result = BeforeContactSaving.Execute(context);
					break;
				case "BeforeContactSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BeforeContactSavingScriptTask";
					result = BeforeContactSavingScriptTask.Execute(context, BeforeContactSavingScriptTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool AfterContactSavedScriptTaskExecute(ProcessExecutingContext context) {
			if (PhotoHasChanged) {
				Guid photoId = Entity.GetTypedColumnValue<Guid>("PhotoId");
				if (photoId != Guid.Empty) {
					ImageAPI imageApi = new ImageAPI(UserConnection);
					ImageData imageData = imageApi.Get(photoId);
					if (imageData.Stream.Length == 0) {
						imageApi.Save(imageData.PreviewStream, photoId);
					} else {
						imageApi.SaveThumbnail(photoId, 256, 256, null, 75);
					}
				}
			}
			return true;
		}

		public virtual bool BeforeContactSavingScriptTaskExecute(ProcessExecutingContext context) {
			PhotoHasChanged = Entity.GetChangedColumnValues().ToArray().Any(x => x.Name == "PhotoId");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Contact_CrtMobile7x_TerrasoftSaved":
							if (ActivatedEventElements.Contains("AfterContactSaved")) {
							context.QueueTasks.Enqueue("AfterContactSaved");
							ProcessQueue(context);
							return;
						}
						break;
					case "Contact_CrtMobile7x_TerrasoftSaving":
							if (ActivatedEventElements.Contains("BeforeContactSaving")) {
							context.QueueTasks.Enqueue("BeforeContactSaving");
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

	#region Class: Contact_CrtMobile7xEventsProcess

	/// <exclude/>
	public class Contact_CrtMobile7xEventsProcess : Contact_CrtMobile7xEventsProcess<Contact_CrtMobile7x_Terrasoft>
	{

		public Contact_CrtMobile7xEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contact_CrtMobile7xEventsProcess

	public partial class Contact_CrtMobile7xEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

