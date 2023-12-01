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

	#region Class: TouchPlatformSchema

	/// <exclude/>
	public class TouchPlatformSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public TouchPlatformSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public TouchPlatformSchema(TouchPlatformSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public TouchPlatformSchema(TouchPlatformSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("076b2d45-7daa-4e3a-a63a-7b95ab668afe");
			RealUId = new Guid("076b2d45-7daa-4e3a-a63a-7b95ab668afe");
			Name = "TouchPlatform";
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
			column.ModifiedInSchemaUId = new Guid("076b2d45-7daa-4e3a-a63a-7b95ab668afe");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new TouchPlatform(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new TouchPlatform_CrtWebTrackingBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new TouchPlatformSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new TouchPlatformSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("076b2d45-7daa-4e3a-a63a-7b95ab668afe"));
		}

		#endregion

	}

	#endregion

	#region Class: TouchPlatform

	/// <summary>
	/// Platform.
	/// </summary>
	public class TouchPlatform : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public TouchPlatform(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "TouchPlatform";
		}

		public TouchPlatform(TouchPlatform source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new TouchPlatform_CrtWebTrackingBaseEventsProcess(UserConnection);
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
			return new TouchPlatform(this);
		}

		#endregion

	}

	#endregion

	#region Class: TouchPlatform_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public partial class TouchPlatform_CrtWebTrackingBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : TouchPlatform
	{

		public TouchPlatform_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "TouchPlatform_CrtWebTrackingBaseEventsProcess";
			SchemaUId = new Guid("076b2d45-7daa-4e3a-a63a-7b95ab668afe");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("076b2d45-7daa-4e3a-a63a-7b95ab668afe");
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

	#region Class: TouchPlatform_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public class TouchPlatform_CrtWebTrackingBaseEventsProcess : TouchPlatform_CrtWebTrackingBaseEventsProcess<TouchPlatform>
	{

		public TouchPlatform_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: TouchPlatform_CrtWebTrackingBaseEventsProcess

	public partial class TouchPlatform_CrtWebTrackingBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: TouchPlatformEventsProcess

	/// <exclude/>
	public class TouchPlatformEventsProcess : TouchPlatform_CrtWebTrackingBaseEventsProcess
	{

		public TouchPlatformEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

