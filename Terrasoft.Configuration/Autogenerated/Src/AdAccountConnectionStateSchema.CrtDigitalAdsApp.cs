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

	#region Class: AdAccountConnectionStateSchema

	/// <exclude/>
	public class AdAccountConnectionStateSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public AdAccountConnectionStateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AdAccountConnectionStateSchema(AdAccountConnectionStateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AdAccountConnectionStateSchema(AdAccountConnectionStateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("78a7290c-b94f-4b21-ae98-5967c6529b62");
			RealUId = new Guid("78a7290c-b94f-4b21-ae98-5967c6529b62");
			Name = "AdAccountConnectionState";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColorColumn() {
			base.InitializePrimaryColorColumn();
			PrimaryColorColumn = CreateColorColumn();
			if (Columns.FindByUId(PrimaryColorColumn.UId) == null) {
				Columns.Add(PrimaryColorColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected virtual EntitySchemaColumn CreateColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Color")) {
				UId = new Guid("d829f5dc-5a94-d052-f7a8-8f76e2b20040"),
				Name = @"Color",
				CreatedInSchemaUId = new Guid("78a7290c-b94f-4b21-ae98-5967c6529b62"),
				ModifiedInSchemaUId = new Guid("78a7290c-b94f-4b21-ae98-5967c6529b62"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AdAccountConnectionState(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AdAccountConnectionState_CrtDigitalAdsAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AdAccountConnectionStateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AdAccountConnectionStateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("78a7290c-b94f-4b21-ae98-5967c6529b62"));
		}

		#endregion

	}

	#endregion

	#region Class: AdAccountConnectionState

	/// <summary>
	/// Connection state.
	/// </summary>
	public class AdAccountConnectionState : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public AdAccountConnectionState(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AdAccountConnectionState";
		}

		public AdAccountConnectionState(AdAccountConnectionState source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Color.
		/// </summary>
		public Color Color {
			get {
				return GetTypedColumnValue<Color>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AdAccountConnectionState_CrtDigitalAdsAppEventsProcess(UserConnection);
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
			return new AdAccountConnectionState(this);
		}

		#endregion

	}

	#endregion

	#region Class: AdAccountConnectionState_CrtDigitalAdsAppEventsProcess

	/// <exclude/>
	public partial class AdAccountConnectionState_CrtDigitalAdsAppEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : AdAccountConnectionState
	{

		public AdAccountConnectionState_CrtDigitalAdsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdAccountConnectionState_CrtDigitalAdsAppEventsProcess";
			SchemaUId = new Guid("78a7290c-b94f-4b21-ae98-5967c6529b62");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("78a7290c-b94f-4b21-ae98-5967c6529b62");
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

	#region Class: AdAccountConnectionState_CrtDigitalAdsAppEventsProcess

	/// <exclude/>
	public class AdAccountConnectionState_CrtDigitalAdsAppEventsProcess : AdAccountConnectionState_CrtDigitalAdsAppEventsProcess<AdAccountConnectionState>
	{

		public AdAccountConnectionState_CrtDigitalAdsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdAccountConnectionState_CrtDigitalAdsAppEventsProcess

	public partial class AdAccountConnectionState_CrtDigitalAdsAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AdAccountConnectionStateEventsProcess

	/// <exclude/>
	public class AdAccountConnectionStateEventsProcess : AdAccountConnectionState_CrtDigitalAdsAppEventsProcess
	{

		public AdAccountConnectionStateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

