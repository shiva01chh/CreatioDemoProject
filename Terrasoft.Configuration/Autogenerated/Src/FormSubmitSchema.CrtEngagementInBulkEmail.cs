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

	#region Class: FormSubmit_CrtEngagementInBulkEmail_TerrasoftSchema

	/// <exclude/>
	public class FormSubmit_CrtEngagementInBulkEmail_TerrasoftSchema : Terrasoft.Configuration.FormSubmit_CrtEventInTouchPoint_TerrasoftSchema
	{

		#region Constructors: Public

		public FormSubmit_CrtEngagementInBulkEmail_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FormSubmit_CrtEngagementInBulkEmail_TerrasoftSchema(FormSubmit_CrtEngagementInBulkEmail_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FormSubmit_CrtEngagementInBulkEmail_TerrasoftSchema(FormSubmit_CrtEngagementInBulkEmail_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("0987af13-b373-48cf-9eb5-679da8c5bb31");
			Name = "FormSubmit_CrtEngagementInBulkEmail_Terrasoft";
			ParentSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015");
			ExtendParent = true;
			CreatedInPackageId = new Guid("1d561c9f-c9ca-4727-b788-d69dbba5c4dc");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("941af094-54cd-3d00-3543-12b2cb1ac35d")) == null) {
				Columns.Add(CreateBulkEmailColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateBulkEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("941af094-54cd-3d00-3543-12b2cb1ac35d"),
				Name = @"BulkEmail",
				ReferenceSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0987af13-b373-48cf-9eb5-679da8c5bb31"),
				ModifiedInSchemaUId = new Guid("0987af13-b373-48cf-9eb5-679da8c5bb31"),
				CreatedInPackageId = new Guid("1d561c9f-c9ca-4727-b788-d69dbba5c4dc")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FormSubmit_CrtEngagementInBulkEmail_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FormSubmit_CrtEngagementInBulkEmailEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FormSubmit_CrtEngagementInBulkEmail_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FormSubmit_CrtEngagementInBulkEmail_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0987af13-b373-48cf-9eb5-679da8c5bb31"));
		}

		#endregion

	}

	#endregion

	#region Class: FormSubmit_CrtEngagementInBulkEmail_Terrasoft

	/// <summary>
	/// Submitted form.
	/// </summary>
	public class FormSubmit_CrtEngagementInBulkEmail_Terrasoft : Terrasoft.Configuration.FormSubmit_CrtEventInTouchPoint_Terrasoft
	{

		#region Constructors: Public

		public FormSubmit_CrtEngagementInBulkEmail_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FormSubmit_CrtEngagementInBulkEmail_Terrasoft";
		}

		public FormSubmit_CrtEngagementInBulkEmail_Terrasoft(FormSubmit_CrtEngagementInBulkEmail_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid BulkEmailId {
			get {
				return GetTypedColumnValue<Guid>("BulkEmailId");
			}
			set {
				SetColumnValue("BulkEmailId", value);
				_bulkEmail = null;
			}
		}

		/// <exclude/>
		public string BulkEmailName {
			get {
				return GetTypedColumnValue<string>("BulkEmailName");
			}
			set {
				SetColumnValue("BulkEmailName", value);
				if (_bulkEmail != null) {
					_bulkEmail.Name = value;
				}
			}
		}

		private BulkEmail _bulkEmail;
		/// <summary>
		/// Bulk email.
		/// </summary>
		public BulkEmail BulkEmail {
			get {
				return _bulkEmail ??
					(_bulkEmail = LookupColumnEntities.GetEntity("BulkEmail") as BulkEmail);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FormSubmit_CrtEngagementInBulkEmailEventsProcess(UserConnection);
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
			return new FormSubmit_CrtEngagementInBulkEmail_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: FormSubmit_CrtEngagementInBulkEmailEventsProcess

	/// <exclude/>
	public partial class FormSubmit_CrtEngagementInBulkEmailEventsProcess<TEntity> : Terrasoft.Configuration.FormSubmit_CrtEventInTouchPointEventsProcess<TEntity> where TEntity : FormSubmit_CrtEngagementInBulkEmail_Terrasoft
	{

		public FormSubmit_CrtEngagementInBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FormSubmit_CrtEngagementInBulkEmailEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0987af13-b373-48cf-9eb5-679da8c5bb31");
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

	#region Class: FormSubmit_CrtEngagementInBulkEmailEventsProcess

	/// <exclude/>
	public class FormSubmit_CrtEngagementInBulkEmailEventsProcess : FormSubmit_CrtEngagementInBulkEmailEventsProcess<FormSubmit_CrtEngagementInBulkEmail_Terrasoft>
	{

		public FormSubmit_CrtEngagementInBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FormSubmit_CrtEngagementInBulkEmailEventsProcess

	public partial class FormSubmit_CrtEngagementInBulkEmailEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

