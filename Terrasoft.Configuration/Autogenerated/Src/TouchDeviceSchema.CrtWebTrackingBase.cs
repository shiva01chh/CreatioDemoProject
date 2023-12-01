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

	#region Class: TouchDeviceSchema

	/// <exclude/>
	public class TouchDeviceSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public TouchDeviceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public TouchDeviceSchema(TouchDeviceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public TouchDeviceSchema(TouchDeviceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3c07afc6-fb87-493c-9303-7d3dbab690ad");
			RealUId = new Guid("3c07afc6-fb87-493c-9303-7d3dbab690ad");
			Name = "TouchDevice";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("dac8d4c0-e3d8-417b-b0d8-e55cf21b295e");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.IsSensitiveData = true;
			column.ModifiedInSchemaUId = new Guid("3c07afc6-fb87-493c-9303-7d3dbab690ad");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new TouchDevice(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new TouchDevice_CrtWebTrackingBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new TouchDeviceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new TouchDeviceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3c07afc6-fb87-493c-9303-7d3dbab690ad"));
		}

		#endregion

	}

	#endregion

	#region Class: TouchDevice

	/// <summary>
	/// Device.
	/// </summary>
	public class TouchDevice : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public TouchDevice(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "TouchDevice";
		}

		public TouchDevice(TouchDevice source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new TouchDevice_CrtWebTrackingBaseEventsProcess(UserConnection);
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
			return new TouchDevice(this);
		}

		#endregion

	}

	#endregion

	#region Class: TouchDevice_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public partial class TouchDevice_CrtWebTrackingBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : TouchDevice
	{

		public TouchDevice_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "TouchDevice_CrtWebTrackingBaseEventsProcess";
			SchemaUId = new Guid("3c07afc6-fb87-493c-9303-7d3dbab690ad");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3c07afc6-fb87-493c-9303-7d3dbab690ad");
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

	#region Class: TouchDevice_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public class TouchDevice_CrtWebTrackingBaseEventsProcess : TouchDevice_CrtWebTrackingBaseEventsProcess<TouchDevice>
	{

		public TouchDevice_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: TouchDevice_CrtWebTrackingBaseEventsProcess

	public partial class TouchDevice_CrtWebTrackingBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: TouchDeviceEventsProcess

	/// <exclude/>
	public class TouchDeviceEventsProcess : TouchDevice_CrtWebTrackingBaseEventsProcess
	{

		public TouchDeviceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

