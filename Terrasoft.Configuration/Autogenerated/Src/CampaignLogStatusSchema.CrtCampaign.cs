﻿namespace Terrasoft.Configuration
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

	#region Class: CampaignLogStatusSchema

	/// <exclude/>
	public class CampaignLogStatusSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public CampaignLogStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CampaignLogStatusSchema(CampaignLogStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CampaignLogStatusSchema(CampaignLogStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("05938a8b-b4ed-4a29-85df-478ca8d8adfd");
			RealUId = new Guid("05938a8b-b4ed-4a29-85df-478ca8d8adfd");
			Name = "CampaignLogStatus";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
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
			return new CampaignLogStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CampaignLogStatus_CrtCampaignEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CampaignLogStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CampaignLogStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("05938a8b-b4ed-4a29-85df-478ca8d8adfd"));
		}

		#endregion

	}

	#endregion

	#region Class: CampaignLogStatus

	/// <summary>
	/// Campaign log status.
	/// </summary>
	public class CampaignLogStatus : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public CampaignLogStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CampaignLogStatus";
		}

		public CampaignLogStatus(CampaignLogStatus source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CampaignLogStatus_CrtCampaignEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CampaignLogStatusDeleted", e);
			Validating += (s, e) => ThrowEvent("CampaignLogStatusValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CampaignLogStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: CampaignLogStatus_CrtCampaignEventsProcess

	/// <exclude/>
	public partial class CampaignLogStatus_CrtCampaignEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : CampaignLogStatus
	{

		public CampaignLogStatus_CrtCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CampaignLogStatus_CrtCampaignEventsProcess";
			SchemaUId = new Guid("05938a8b-b4ed-4a29-85df-478ca8d8adfd");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("05938a8b-b4ed-4a29-85df-478ca8d8adfd");
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

	#region Class: CampaignLogStatus_CrtCampaignEventsProcess

	/// <exclude/>
	public class CampaignLogStatus_CrtCampaignEventsProcess : CampaignLogStatus_CrtCampaignEventsProcess<CampaignLogStatus>
	{

		public CampaignLogStatus_CrtCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CampaignLogStatus_CrtCampaignEventsProcess

	public partial class CampaignLogStatus_CrtCampaignEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CampaignLogStatusEventsProcess

	/// <exclude/>
	public class CampaignLogStatusEventsProcess : CampaignLogStatus_CrtCampaignEventsProcess
	{

		public CampaignLogStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

