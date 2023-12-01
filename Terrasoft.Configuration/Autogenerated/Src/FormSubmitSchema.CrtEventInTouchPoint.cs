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

	#region Class: FormSubmit_CrtEventInTouchPoint_TerrasoftSchema

	/// <exclude/>
	public class FormSubmit_CrtEventInTouchPoint_TerrasoftSchema : Terrasoft.Configuration.FormSubmit_CrtEngagementInBulkEmail_TerrasoftSchema
	{

		#region Constructors: Public

		public FormSubmit_CrtEventInTouchPoint_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FormSubmit_CrtEventInTouchPoint_TerrasoftSchema(FormSubmit_CrtEventInTouchPoint_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FormSubmit_CrtEventInTouchPoint_TerrasoftSchema(FormSubmit_CrtEventInTouchPoint_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("f29c49ff-67be-43be-a441-3c4dadf4ec81");
			Name = "FormSubmit_CrtEventInTouchPoint_Terrasoft";
			ParentSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015");
			ExtendParent = true;
			CreatedInPackageId = new Guid("2e5d5640-970c-4a67-8e3e-aab48f687fae");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c3fdcfad-f1e9-dee1-60d7-883b9362e057")) == null) {
				Columns.Add(CreateEventColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEventColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c3fdcfad-f1e9-dee1-60d7-883b9362e057"),
				Name = @"Event",
				ReferenceSchemaUId = new Guid("5b4fdfc7-12b6-4b4f-a9bd-b6f1b6e4447f"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f29c49ff-67be-43be-a441-3c4dadf4ec81"),
				ModifiedInSchemaUId = new Guid("f29c49ff-67be-43be-a441-3c4dadf4ec81"),
				CreatedInPackageId = new Guid("2e5d5640-970c-4a67-8e3e-aab48f687fae")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FormSubmit_CrtEventInTouchPoint_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FormSubmit_CrtEventInTouchPointEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FormSubmit_CrtEventInTouchPoint_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FormSubmit_CrtEventInTouchPoint_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f29c49ff-67be-43be-a441-3c4dadf4ec81"));
		}

		#endregion

	}

	#endregion

	#region Class: FormSubmit_CrtEventInTouchPoint_Terrasoft

	/// <summary>
	/// Submitted form.
	/// </summary>
	public class FormSubmit_CrtEventInTouchPoint_Terrasoft : Terrasoft.Configuration.FormSubmit_CrtEngagementInBulkEmail_Terrasoft
	{

		#region Constructors: Public

		public FormSubmit_CrtEventInTouchPoint_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FormSubmit_CrtEventInTouchPoint_Terrasoft";
		}

		public FormSubmit_CrtEventInTouchPoint_Terrasoft(FormSubmit_CrtEventInTouchPoint_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid EventId {
			get {
				return GetTypedColumnValue<Guid>("EventId");
			}
			set {
				SetColumnValue("EventId", value);
				_event = null;
			}
		}

		/// <exclude/>
		public string EventName {
			get {
				return GetTypedColumnValue<string>("EventName");
			}
			set {
				SetColumnValue("EventName", value);
				if (_event != null) {
					_event.Name = value;
				}
			}
		}

		private Event _event;
		/// <summary>
		/// Event.
		/// </summary>
		public Event Event {
			get {
				return _event ??
					(_event = LookupColumnEntities.GetEntity("Event") as Event);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FormSubmit_CrtEventInTouchPointEventsProcess(UserConnection);
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
			return new FormSubmit_CrtEventInTouchPoint_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: FormSubmit_CrtEventInTouchPointEventsProcess

	/// <exclude/>
	public partial class FormSubmit_CrtEventInTouchPointEventsProcess<TEntity> : Terrasoft.Configuration.FormSubmit_CrtEngagementInBulkEmailEventsProcess<TEntity> where TEntity : FormSubmit_CrtEventInTouchPoint_Terrasoft
	{

		public FormSubmit_CrtEventInTouchPointEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FormSubmit_CrtEventInTouchPointEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f29c49ff-67be-43be-a441-3c4dadf4ec81");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: FormSubmit_CrtEventInTouchPointEventsProcess

	/// <exclude/>
	public class FormSubmit_CrtEventInTouchPointEventsProcess : FormSubmit_CrtEventInTouchPointEventsProcess<FormSubmit_CrtEventInTouchPoint_Terrasoft>
	{

		public FormSubmit_CrtEventInTouchPointEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FormSubmit_CrtEventInTouchPointEventsProcess

	public partial class FormSubmit_CrtEventInTouchPointEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

