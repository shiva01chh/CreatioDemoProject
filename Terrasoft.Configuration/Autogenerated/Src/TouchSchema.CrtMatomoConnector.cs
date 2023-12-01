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

	#region Class: TouchSchema

	/// <exclude/>
	public class TouchSchema : Terrasoft.Configuration.Touch_CrtWebTrackingBase_TerrasoftSchema
	{

		#region Constructors: Public

		public TouchSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public TouchSchema(TouchSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public TouchSchema(TouchSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("2a9265b4-61bd-479c-8149-f7745b194643");
			Name = "Touch";
			ParentSchemaUId = new Guid("6895c8a8-7407-460a-90ec-5e5bfbda0fda");
			ExtendParent = true;
			CreatedInPackageId = new Guid("e707ff24-9ed4-4750-ae4b-3027f2f2a5bc");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a661c187-cbd0-0b96-a965-baa85f0bb258")) == null) {
				Columns.Add(CreateMatomoVisitorIdColumn());
			}
			if (Columns.FindByUId(new Guid("d75ed5ed-434d-e63d-240e-3d0035ce0b68")) == null) {
				Columns.Add(CreateMatomoUserIdColumn());
			}
			if (Columns.FindByUId(new Guid("beb4babe-f44b-d526-ea4a-9e3e9f879fa5")) == null) {
				Columns.Add(CreateLastActionDateTimeColumn());
			}
			if (Columns.FindByUId(new Guid("a2de0570-0a88-cc56-94ac-90e720f661bf")) == null) {
				Columns.Add(CreateMatomoSiteIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateMatomoVisitorIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("a661c187-cbd0-0b96-a965-baa85f0bb258"),
				Name = @"MatomoVisitorId",
				CreatedInSchemaUId = new Guid("2a9265b4-61bd-479c-8149-f7745b194643"),
				ModifiedInSchemaUId = new Guid("2a9265b4-61bd-479c-8149-f7745b194643"),
				CreatedInPackageId = new Guid("e707ff24-9ed4-4750-ae4b-3027f2f2a5bc"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateMatomoUserIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("d75ed5ed-434d-e63d-240e-3d0035ce0b68"),
				Name = @"MatomoUserId",
				CreatedInSchemaUId = new Guid("2a9265b4-61bd-479c-8149-f7745b194643"),
				ModifiedInSchemaUId = new Guid("2a9265b4-61bd-479c-8149-f7745b194643"),
				CreatedInPackageId = new Guid("e707ff24-9ed4-4750-ae4b-3027f2f2a5bc"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateLastActionDateTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("beb4babe-f44b-d526-ea4a-9e3e9f879fa5"),
				Name = @"LastActionDateTime",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2a9265b4-61bd-479c-8149-f7745b194643"),
				ModifiedInSchemaUId = new Guid("2a9265b4-61bd-479c-8149-f7745b194643"),
				CreatedInPackageId = new Guid("25c82bcb-0c61-4059-9171-fb69fa07bed8")
			};
		}

		protected virtual EntitySchemaColumn CreateMatomoSiteIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("a2de0570-0a88-cc56-94ac-90e720f661bf"),
				Name = @"MatomoSiteId",
				CreatedInSchemaUId = new Guid("2a9265b4-61bd-479c-8149-f7745b194643"),
				ModifiedInSchemaUId = new Guid("2a9265b4-61bd-479c-8149-f7745b194643"),
				CreatedInPackageId = new Guid("26e17fc2-b6f1-49f0-a198-84ce5d5974ce")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Touch(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Touch_CrtMatomoConnectorEventsProcess(userConnection);
		}

		public override object Clone() {
			return new TouchSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new TouchSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2a9265b4-61bd-479c-8149-f7745b194643"));
		}

		#endregion

	}

	#endregion

	#region Class: Touch

	/// <summary>
	/// Web sessions.
	/// </summary>
	public class Touch : Terrasoft.Configuration.Touch_CrtWebTrackingBase_Terrasoft
	{

		#region Constructors: Public

		public Touch(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Touch";
		}

		public Touch(Touch source)
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
		/// Last action date.
		/// </summary>
		public DateTime LastActionDateTime {
			get {
				return GetTypedColumnValue<DateTime>("LastActionDateTime");
			}
			set {
				SetColumnValue("LastActionDateTime", value);
			}
		}

		/// <summary>
		/// Matomo website identifier.
		/// </summary>
		/// <remarks>
		/// The Matomo tracking system website identifier.
		/// </remarks>
		public int MatomoSiteId {
			get {
				return GetTypedColumnValue<int>("MatomoSiteId");
			}
			set {
				SetColumnValue("MatomoSiteId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Touch_CrtMatomoConnectorEventsProcess(UserConnection);
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
			return new Touch(this);
		}

		#endregion

	}

	#endregion

	#region Class: Touch_CrtMatomoConnectorEventsProcess

	/// <exclude/>
	public partial class Touch_CrtMatomoConnectorEventsProcess<TEntity> : Terrasoft.Configuration.Touch_CrtWebTrackingBaseEventsProcess<TEntity> where TEntity : Touch
	{

		public Touch_CrtMatomoConnectorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Touch_CrtMatomoConnectorEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2a9265b4-61bd-479c-8149-f7745b194643");
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

	#region Class: Touch_CrtMatomoConnectorEventsProcess

	/// <exclude/>
	public class Touch_CrtMatomoConnectorEventsProcess : Touch_CrtMatomoConnectorEventsProcess<Touch>
	{

		public Touch_CrtMatomoConnectorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Touch_CrtMatomoConnectorEventsProcess

	public partial class Touch_CrtMatomoConnectorEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: TouchEventsProcess

	/// <exclude/>
	public class TouchEventsProcess : Touch_CrtMatomoConnectorEventsProcess
	{

		public TouchEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

