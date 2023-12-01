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

	#region Class: ReferrerTypeSchema

	/// <exclude/>
	public class ReferrerTypeSchema : Terrasoft.Configuration.ReferrerType_CrtWebTrackingBase_TerrasoftSchema
	{

		#region Constructors: Public

		public ReferrerTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ReferrerTypeSchema(ReferrerTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ReferrerTypeSchema(ReferrerTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("44e8a099-0c26-4b3b-8c31-ab666e7cc70b");
			Name = "ReferrerType";
			ParentSchemaUId = new Guid("0aa9fb42-d3d0-4981-841f-eed551db7db5");
			ExtendParent = true;
			CreatedInPackageId = new Guid("4e1d9ea7-02db-418d-a76e-81e3245b4bca");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fd4756b8-d148-64d3-8ffa-d2e31c31b7b7")) == null) {
				Columns.Add(CreateMatomoCodeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateMatomoCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("fd4756b8-d148-64d3-8ffa-d2e31c31b7b7"),
				Name = @"MatomoCode",
				CreatedInSchemaUId = new Guid("44e8a099-0c26-4b3b-8c31-ab666e7cc70b"),
				ModifiedInSchemaUId = new Guid("44e8a099-0c26-4b3b-8c31-ab666e7cc70b"),
				CreatedInPackageId = new Guid("4e1d9ea7-02db-418d-a76e-81e3245b4bca")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ReferrerType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ReferrerType_CrtMatomoConnectorEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ReferrerTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ReferrerTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("44e8a099-0c26-4b3b-8c31-ab666e7cc70b"));
		}

		#endregion

	}

	#endregion

	#region Class: ReferrerType

	/// <summary>
	/// Referrer type.
	/// </summary>
	public class ReferrerType : Terrasoft.Configuration.ReferrerType_CrtWebTrackingBase_Terrasoft
	{

		#region Constructors: Public

		public ReferrerType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ReferrerType";
		}

		public ReferrerType(ReferrerType source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Matomo code.
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
			var process = new ReferrerType_CrtMatomoConnectorEventsProcess(UserConnection);
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
			return new ReferrerType(this);
		}

		#endregion

	}

	#endregion

	#region Class: ReferrerType_CrtMatomoConnectorEventsProcess

	/// <exclude/>
	public partial class ReferrerType_CrtMatomoConnectorEventsProcess<TEntity> : Terrasoft.Configuration.ReferrerType_CrtWebTrackingBaseEventsProcess<TEntity> where TEntity : ReferrerType
	{

		public ReferrerType_CrtMatomoConnectorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ReferrerType_CrtMatomoConnectorEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("44e8a099-0c26-4b3b-8c31-ab666e7cc70b");
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

	#region Class: ReferrerType_CrtMatomoConnectorEventsProcess

	/// <exclude/>
	public class ReferrerType_CrtMatomoConnectorEventsProcess : ReferrerType_CrtMatomoConnectorEventsProcess<ReferrerType>
	{

		public ReferrerType_CrtMatomoConnectorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ReferrerType_CrtMatomoConnectorEventsProcess

	public partial class ReferrerType_CrtMatomoConnectorEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ReferrerTypeEventsProcess

	/// <exclude/>
	public class ReferrerTypeEventsProcess : ReferrerType_CrtMatomoConnectorEventsProcess
	{

		public ReferrerTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

