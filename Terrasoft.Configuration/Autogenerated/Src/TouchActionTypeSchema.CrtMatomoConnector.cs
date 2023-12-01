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

	#region Class: TouchActionTypeSchema

	/// <exclude/>
	public class TouchActionTypeSchema : Terrasoft.Configuration.TouchActionType_CrtWebTrackingBase_TerrasoftSchema
	{

		#region Constructors: Public

		public TouchActionTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public TouchActionTypeSchema(TouchActionTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public TouchActionTypeSchema(TouchActionTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("68f23508-3e7e-4985-a9ae-994797bf5959");
			Name = "TouchActionType";
			ParentSchemaUId = new Guid("480fa5f1-106f-4df5-9e1a-987204c8e9e9");
			ExtendParent = true;
			CreatedInPackageId = new Guid("25c82bcb-0c61-4059-9171-fb69fa07bed8");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("02ea18af-d14d-3510-4a05-10bfdc75d25e")) == null) {
				Columns.Add(CreateMatomoCodeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateMatomoCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("02ea18af-d14d-3510-4a05-10bfdc75d25e"),
				Name = @"MatomoCode",
				CreatedInSchemaUId = new Guid("68f23508-3e7e-4985-a9ae-994797bf5959"),
				ModifiedInSchemaUId = new Guid("68f23508-3e7e-4985-a9ae-994797bf5959"),
				CreatedInPackageId = new Guid("25c82bcb-0c61-4059-9171-fb69fa07bed8")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new TouchActionType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new TouchActionType_CrtMatomoConnectorEventsProcess(userConnection);
		}

		public override object Clone() {
			return new TouchActionTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new TouchActionTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("68f23508-3e7e-4985-a9ae-994797bf5959"));
		}

		#endregion

	}

	#endregion

	#region Class: TouchActionType

	/// <summary>
	/// Web action type.
	/// </summary>
	public class TouchActionType : Terrasoft.Configuration.TouchActionType_CrtWebTrackingBase_Terrasoft
	{

		#region Constructors: Public

		public TouchActionType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "TouchActionType";
		}

		public TouchActionType(TouchActionType source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Matomo Code.
		/// </summary>
		public string MatomoCode {
			get {
				return GetTypedColumnValue<string>("MatomoCode");
			}
			set {
				SetColumnValue("MatomoCode", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new TouchActionType_CrtMatomoConnectorEventsProcess(UserConnection);
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
			return new TouchActionType(this);
		}

		#endregion

	}

	#endregion

	#region Class: TouchActionType_CrtMatomoConnectorEventsProcess

	/// <exclude/>
	public partial class TouchActionType_CrtMatomoConnectorEventsProcess<TEntity> : Terrasoft.Configuration.TouchActionType_CrtWebTrackingBaseEventsProcess<TEntity> where TEntity : TouchActionType
	{

		public TouchActionType_CrtMatomoConnectorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "TouchActionType_CrtMatomoConnectorEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("68f23508-3e7e-4985-a9ae-994797bf5959");
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

	#region Class: TouchActionType_CrtMatomoConnectorEventsProcess

	/// <exclude/>
	public class TouchActionType_CrtMatomoConnectorEventsProcess : TouchActionType_CrtMatomoConnectorEventsProcess<TouchActionType>
	{

		public TouchActionType_CrtMatomoConnectorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: TouchActionType_CrtMatomoConnectorEventsProcess

	public partial class TouchActionType_CrtMatomoConnectorEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: TouchActionTypeEventsProcess

	/// <exclude/>
	public class TouchActionTypeEventsProcess : TouchActionType_CrtMatomoConnectorEventsProcess
	{

		public TouchActionTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

