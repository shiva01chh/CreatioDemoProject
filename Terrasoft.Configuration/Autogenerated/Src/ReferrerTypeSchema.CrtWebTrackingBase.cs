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

	#region Class: ReferrerType_CrtWebTrackingBase_TerrasoftSchema

	/// <exclude/>
	public class ReferrerType_CrtWebTrackingBase_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public ReferrerType_CrtWebTrackingBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ReferrerType_CrtWebTrackingBase_TerrasoftSchema(ReferrerType_CrtWebTrackingBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ReferrerType_CrtWebTrackingBase_TerrasoftSchema(ReferrerType_CrtWebTrackingBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0aa9fb42-d3d0-4981-841f-eed551db7db5");
			RealUId = new Guid("0aa9fb42-d3d0-4981-841f-eed551db7db5");
			Name = "ReferrerType_CrtWebTrackingBase_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ReferrerType_CrtWebTrackingBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ReferrerType_CrtWebTrackingBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ReferrerType_CrtWebTrackingBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ReferrerType_CrtWebTrackingBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0aa9fb42-d3d0-4981-841f-eed551db7db5"));
		}

		#endregion

	}

	#endregion

	#region Class: ReferrerType_CrtWebTrackingBase_Terrasoft

	/// <summary>
	/// Referrer type.
	/// </summary>
	public class ReferrerType_CrtWebTrackingBase_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public ReferrerType_CrtWebTrackingBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ReferrerType_CrtWebTrackingBase_Terrasoft";
		}

		public ReferrerType_CrtWebTrackingBase_Terrasoft(ReferrerType_CrtWebTrackingBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ReferrerType_CrtWebTrackingBaseEventsProcess(UserConnection);
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
			return new ReferrerType_CrtWebTrackingBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ReferrerType_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public partial class ReferrerType_CrtWebTrackingBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : ReferrerType_CrtWebTrackingBase_Terrasoft
	{

		public ReferrerType_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ReferrerType_CrtWebTrackingBaseEventsProcess";
			SchemaUId = new Guid("0aa9fb42-d3d0-4981-841f-eed551db7db5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0aa9fb42-d3d0-4981-841f-eed551db7db5");
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

	#region Class: ReferrerType_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public class ReferrerType_CrtWebTrackingBaseEventsProcess : ReferrerType_CrtWebTrackingBaseEventsProcess<ReferrerType_CrtWebTrackingBase_Terrasoft>
	{

		public ReferrerType_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ReferrerType_CrtWebTrackingBaseEventsProcess

	public partial class ReferrerType_CrtWebTrackingBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

