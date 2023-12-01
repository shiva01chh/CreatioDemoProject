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

	#region Class: FormSubmit_CrtTouchInWebForm_TerrasoftSchema

	/// <exclude/>
	public class FormSubmit_CrtTouchInWebForm_TerrasoftSchema : Terrasoft.Configuration.FormSubmit_CrtTouchPoint_TerrasoftSchema
	{

		#region Constructors: Public

		public FormSubmit_CrtTouchInWebForm_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FormSubmit_CrtTouchInWebForm_TerrasoftSchema(FormSubmit_CrtTouchInWebForm_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FormSubmit_CrtTouchInWebForm_TerrasoftSchema(FormSubmit_CrtTouchInWebForm_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("9136edb0-9021-45c2-9982-9ce1e664ebca");
			Name = "FormSubmit_CrtTouchInWebForm_Terrasoft";
			ParentSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015");
			ExtendParent = true;
			CreatedInPackageId = new Guid("c959612d-84e9-4226-95a0-fadcec8d0836");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("932ed00e-939a-45dd-5927-cdbd22b2555b")) == null) {
				Columns.Add(CreateWebFormColumn());
			}
			if (Columns.FindByUId(new Guid("bbb89b2c-6155-490f-8f42-c9ab1f84a39a")) == null) {
				Columns.Add(CreateWebFormDataColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateWebFormColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("932ed00e-939a-45dd-5927-cdbd22b2555b"),
				Name = @"WebForm",
				ReferenceSchemaUId = new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9136edb0-9021-45c2-9982-9ce1e664ebca"),
				ModifiedInSchemaUId = new Guid("9136edb0-9021-45c2-9982-9ce1e664ebca"),
				CreatedInPackageId = new Guid("c959612d-84e9-4226-95a0-fadcec8d0836")
			};
		}

		protected virtual EntitySchemaColumn CreateWebFormDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bbb89b2c-6155-490f-8f42-c9ab1f84a39a"),
				Name = @"WebFormData",
				ReferenceSchemaUId = new Guid("0abcc957-0829-4261-8dd0-a428d64fa80f"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9136edb0-9021-45c2-9982-9ce1e664ebca"),
				ModifiedInSchemaUId = new Guid("9136edb0-9021-45c2-9982-9ce1e664ebca"),
				CreatedInPackageId = new Guid("c959612d-84e9-4226-95a0-fadcec8d0836")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FormSubmit_CrtTouchInWebForm_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FormSubmit_CrtTouchInWebFormEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FormSubmit_CrtTouchInWebForm_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FormSubmit_CrtTouchInWebForm_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9136edb0-9021-45c2-9982-9ce1e664ebca"));
		}

		#endregion

	}

	#endregion

	#region Class: FormSubmit_CrtTouchInWebForm_Terrasoft

	/// <summary>
	/// Submitted form.
	/// </summary>
	public class FormSubmit_CrtTouchInWebForm_Terrasoft : Terrasoft.Configuration.FormSubmit_CrtTouchPoint_Terrasoft
	{

		#region Constructors: Public

		public FormSubmit_CrtTouchInWebForm_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FormSubmit_CrtTouchInWebForm_Terrasoft";
		}

		public FormSubmit_CrtTouchInWebForm_Terrasoft(FormSubmit_CrtTouchInWebForm_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid WebFormId {
			get {
				return GetTypedColumnValue<Guid>("WebFormId");
			}
			set {
				SetColumnValue("WebFormId", value);
				_webForm = null;
			}
		}

		/// <exclude/>
		public string WebFormName {
			get {
				return GetTypedColumnValue<string>("WebFormName");
			}
			set {
				SetColumnValue("WebFormName", value);
				if (_webForm != null) {
					_webForm.Name = value;
				}
			}
		}

		private GeneratedWebForm _webForm;
		/// <summary>
		/// Web form.
		/// </summary>
		public GeneratedWebForm WebForm {
			get {
				return _webForm ??
					(_webForm = LookupColumnEntities.GetEntity("WebForm") as GeneratedWebForm);
			}
		}

		/// <exclude/>
		public Guid WebFormDataId {
			get {
				return GetTypedColumnValue<Guid>("WebFormDataId");
			}
			set {
				SetColumnValue("WebFormDataId", value);
				_webFormData = null;
			}
		}

		private WebFormData _webFormData;
		/// <summary>
		/// Data from web form.
		/// </summary>
		public WebFormData WebFormData {
			get {
				return _webFormData ??
					(_webFormData = LookupColumnEntities.GetEntity("WebFormData") as WebFormData);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FormSubmit_CrtTouchInWebFormEventsProcess(UserConnection);
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
			return new FormSubmit_CrtTouchInWebForm_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: FormSubmit_CrtTouchInWebFormEventsProcess

	/// <exclude/>
	public partial class FormSubmit_CrtTouchInWebFormEventsProcess<TEntity> : Terrasoft.Configuration.FormSubmit_CrtTouchPointEventsProcess<TEntity> where TEntity : FormSubmit_CrtTouchInWebForm_Terrasoft
	{

		public FormSubmit_CrtTouchInWebFormEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FormSubmit_CrtTouchInWebFormEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9136edb0-9021-45c2-9982-9ce1e664ebca");
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

	#region Class: FormSubmit_CrtTouchInWebFormEventsProcess

	/// <exclude/>
	public class FormSubmit_CrtTouchInWebFormEventsProcess : FormSubmit_CrtTouchInWebFormEventsProcess<FormSubmit_CrtTouchInWebForm_Terrasoft>
	{

		public FormSubmit_CrtTouchInWebFormEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FormSubmit_CrtTouchInWebFormEventsProcess

	public partial class FormSubmit_CrtTouchInWebFormEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

