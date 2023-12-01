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

	#region Class: WebFormDataSchema

	/// <exclude/>
	public class WebFormDataSchema : Terrasoft.Configuration.WebFormData_CrtWebForm_TerrasoftSchema
	{

		#region Constructors: Public

		public WebFormDataSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public WebFormDataSchema(WebFormDataSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public WebFormDataSchema(WebFormDataSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("9d16dea2-9df8-4667-a3f1-eb0f066c5915");
			Name = "WebFormData";
			ParentSchemaUId = new Guid("0abcc957-0829-4261-8dd0-a428d64fa80f");
			ExtendParent = true;
			CreatedInPackageId = new Guid("e707ff24-9ed4-4750-ae4b-3027f2f2a5bc");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e63b4cf9-7ead-727f-64a8-6053a7347e34")) == null) {
				Columns.Add(CreateMatomoVisitorIdColumn());
			}
			if (Columns.FindByUId(new Guid("893dc792-44de-e43e-8318-988180bb003c")) == null) {
				Columns.Add(CreateMatomoUserIdColumn());
			}
			if (Columns.FindByUId(new Guid("bbb0d909-2356-c16b-503b-08429b8d1be5")) == null) {
				Columns.Add(CreateIsMatomoDataUpdatedColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateMatomoVisitorIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("e63b4cf9-7ead-727f-64a8-6053a7347e34"),
				Name = @"MatomoVisitorId",
				CreatedInSchemaUId = new Guid("9d16dea2-9df8-4667-a3f1-eb0f066c5915"),
				ModifiedInSchemaUId = new Guid("9d16dea2-9df8-4667-a3f1-eb0f066c5915"),
				CreatedInPackageId = new Guid("e707ff24-9ed4-4750-ae4b-3027f2f2a5bc"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateMatomoUserIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("893dc792-44de-e43e-8318-988180bb003c"),
				Name = @"MatomoUserId",
				CreatedInSchemaUId = new Guid("9d16dea2-9df8-4667-a3f1-eb0f066c5915"),
				ModifiedInSchemaUId = new Guid("9d16dea2-9df8-4667-a3f1-eb0f066c5915"),
				CreatedInPackageId = new Guid("e707ff24-9ed4-4750-ae4b-3027f2f2a5bc"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateIsMatomoDataUpdatedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("bbb0d909-2356-c16b-503b-08429b8d1be5"),
				Name = @"IsMatomoDataUpdated",
				CreatedInSchemaUId = new Guid("9d16dea2-9df8-4667-a3f1-eb0f066c5915"),
				ModifiedInSchemaUId = new Guid("9d16dea2-9df8-4667-a3f1-eb0f066c5915"),
				CreatedInPackageId = new Guid("e707ff24-9ed4-4750-ae4b-3027f2f2a5bc"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new WebFormData(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new WebFormData_CrtMatomoConnectorEventsProcess(userConnection);
		}

		public override object Clone() {
			return new WebFormDataSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new WebFormDataSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9d16dea2-9df8-4667-a3f1-eb0f066c5915"));
		}

		#endregion

	}

	#endregion

	#region Class: WebFormData

	/// <summary>
	/// Data from web form.
	/// </summary>
	public class WebFormData : Terrasoft.Configuration.WebFormData_CrtWebForm_Terrasoft
	{

		#region Constructors: Public

		public WebFormData(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WebFormData";
		}

		public WebFormData(WebFormData source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Matomo visitor identifier.
		/// </summary>
		public string MatomoVisitorId {
			get {
				return GetTypedColumnValue<string>("MatomoVisitorId");
			}
			set {
				SetColumnValue("MatomoVisitorId", value);
			}
		}

		/// <summary>
		/// Matomo user identifier.
		/// </summary>
		public string MatomoUserId {
			get {
				return GetTypedColumnValue<string>("MatomoUserId");
			}
			set {
				SetColumnValue("MatomoUserId", value);
			}
		}

		/// <summary>
		/// Matomo data updated.
		/// </summary>
		public bool IsMatomoDataUpdated {
			get {
				return GetTypedColumnValue<bool>("IsMatomoDataUpdated");
			}
			set {
				SetColumnValue("IsMatomoDataUpdated", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new WebFormData_CrtMatomoConnectorEventsProcess(UserConnection);
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
			return new WebFormData(this);
		}

		#endregion

	}

	#endregion

	#region Class: WebFormData_CrtMatomoConnectorEventsProcess

	/// <exclude/>
	public partial class WebFormData_CrtMatomoConnectorEventsProcess<TEntity> : Terrasoft.Configuration.WebFormData_CrtWebFormEventsProcess<TEntity> where TEntity : WebFormData
	{

		public WebFormData_CrtMatomoConnectorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WebFormData_CrtMatomoConnectorEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9d16dea2-9df8-4667-a3f1-eb0f066c5915");
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

	#region Class: WebFormData_CrtMatomoConnectorEventsProcess

	/// <exclude/>
	public class WebFormData_CrtMatomoConnectorEventsProcess : WebFormData_CrtMatomoConnectorEventsProcess<WebFormData>
	{

		public WebFormData_CrtMatomoConnectorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: WebFormData_CrtMatomoConnectorEventsProcess

	public partial class WebFormData_CrtMatomoConnectorEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: WebFormDataEventsProcess

	/// <exclude/>
	public class WebFormDataEventsProcess : WebFormData_CrtMatomoConnectorEventsProcess
	{

		public WebFormDataEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

