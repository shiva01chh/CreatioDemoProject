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

	#region Class: CampaignLogItemTypeSchema

	/// <exclude/>
	public class CampaignLogItemTypeSchema : Terrasoft.Configuration.LookupSchema
	{

		#region Constructors: Public

		public CampaignLogItemTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CampaignLogItemTypeSchema(CampaignLogItemTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CampaignLogItemTypeSchema(CampaignLogItemTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("41879c50-004a-4a40-9080-fe06a2f6b1c3");
			RealUId = new Guid("41879c50-004a-4a40-9080-fe06a2f6b1c3");
			Name = "CampaignLogItemType";
			ParentSchemaUId = new Guid("2aecdb97-990e-4c17-96f4-240ca6531c84");
			ExtendParent = false;
			CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067");
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
			return new CampaignLogItemType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CampaignLogItemType_CrtCampaignEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CampaignLogItemTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CampaignLogItemTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("41879c50-004a-4a40-9080-fe06a2f6b1c3"));
		}

		#endregion

	}

	#endregion

	#region Class: CampaignLogItemType

	/// <summary>
	/// Campaign log item type.
	/// </summary>
	public class CampaignLogItemType : Terrasoft.Configuration.Lookup
	{

		#region Constructors: Public

		public CampaignLogItemType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CampaignLogItemType";
		}

		public CampaignLogItemType(CampaignLogItemType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CampaignLogItemType_CrtCampaignEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CampaignLogItemTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("CampaignLogItemTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CampaignLogItemType(this);
		}

		#endregion

	}

	#endregion

	#region Class: CampaignLogItemType_CrtCampaignEventsProcess

	/// <exclude/>
	public partial class CampaignLogItemType_CrtCampaignEventsProcess<TEntity> : Terrasoft.Configuration.Lookup_CrtBaseEventsProcess<TEntity> where TEntity : CampaignLogItemType
	{

		public CampaignLogItemType_CrtCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CampaignLogItemType_CrtCampaignEventsProcess";
			SchemaUId = new Guid("41879c50-004a-4a40-9080-fe06a2f6b1c3");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("41879c50-004a-4a40-9080-fe06a2f6b1c3");
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

	#region Class: CampaignLogItemType_CrtCampaignEventsProcess

	/// <exclude/>
	public class CampaignLogItemType_CrtCampaignEventsProcess : CampaignLogItemType_CrtCampaignEventsProcess<CampaignLogItemType>
	{

		public CampaignLogItemType_CrtCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CampaignLogItemType_CrtCampaignEventsProcess

	public partial class CampaignLogItemType_CrtCampaignEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CampaignLogItemTypeEventsProcess

	/// <exclude/>
	public class CampaignLogItemTypeEventsProcess : CampaignLogItemType_CrtCampaignEventsProcess
	{

		public CampaignLogItemTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

