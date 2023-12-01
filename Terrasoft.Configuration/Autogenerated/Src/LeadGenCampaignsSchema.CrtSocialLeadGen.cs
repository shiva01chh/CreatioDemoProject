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

	#region Class: LeadGenCampaignsSchema

	/// <exclude/>
	public class LeadGenCampaignsSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public LeadGenCampaignsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadGenCampaignsSchema(LeadGenCampaignsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadGenCampaignsSchema(LeadGenCampaignsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ef54d5f4-63e2-4f5f-b222-f12f6b9aa6c0");
			RealUId = new Guid("ef54d5f4-63e2-4f5f-b222-f12f6b9aa6c0");
			Name = "LeadGenCampaigns";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a9a0305e-6536-60d4-c49a-682fed0e20e4")) == null) {
				Columns.Add(CreateSocialCampaignIdColumn());
			}
			if (Columns.FindByUId(new Guid("b0b33026-5169-6602-ab80-caf5467aad91")) == null) {
				Columns.Add(CreateLeadGenNetworkTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSocialCampaignIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a9a0305e-6536-60d4-c49a-682fed0e20e4"),
				Name = @"SocialCampaignId",
				CreatedInSchemaUId = new Guid("ef54d5f4-63e2-4f5f-b222-f12f6b9aa6c0"),
				ModifiedInSchemaUId = new Guid("ef54d5f4-63e2-4f5f-b222-f12f6b9aa6c0"),
				CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31")
			};
		}

		protected virtual EntitySchemaColumn CreateLeadGenNetworkTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b0b33026-5169-6602-ab80-caf5467aad91"),
				Name = @"LeadGenNetworkType",
				ReferenceSchemaUId = new Guid("2f219369-8c87-4a6f-bf14-b048b134ea66"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ef54d5f4-63e2-4f5f-b222-f12f6b9aa6c0"),
				ModifiedInSchemaUId = new Guid("ef54d5f4-63e2-4f5f-b222-f12f6b9aa6c0"),
				CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LeadGenCampaigns(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadGenCampaigns_CrtSocialLeadGenEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadGenCampaignsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadGenCampaignsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ef54d5f4-63e2-4f5f-b222-f12f6b9aa6c0"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadGenCampaigns

	/// <summary>
	/// Campaigns.
	/// </summary>
	public class LeadGenCampaigns : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public LeadGenCampaigns(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadGenCampaigns";
		}

		public LeadGenCampaigns(LeadGenCampaigns source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Social campaign id.
		/// </summary>
		public string SocialCampaignId {
			get {
				return GetTypedColumnValue<string>("SocialCampaignId");
			}
			set {
				SetColumnValue("SocialCampaignId", value);
			}
		}

		/// <exclude/>
		public Guid LeadGenNetworkTypeId {
			get {
				return GetTypedColumnValue<Guid>("LeadGenNetworkTypeId");
			}
			set {
				SetColumnValue("LeadGenNetworkTypeId", value);
				_leadGenNetworkType = null;
			}
		}

		/// <exclude/>
		public string LeadGenNetworkTypeName {
			get {
				return GetTypedColumnValue<string>("LeadGenNetworkTypeName");
			}
			set {
				SetColumnValue("LeadGenNetworkTypeName", value);
				if (_leadGenNetworkType != null) {
					_leadGenNetworkType.Name = value;
				}
			}
		}

		private LeadGenNetworkType _leadGenNetworkType;
		/// <summary>
		/// Network type.
		/// </summary>
		public LeadGenNetworkType LeadGenNetworkType {
			get {
				return _leadGenNetworkType ??
					(_leadGenNetworkType = LookupColumnEntities.GetEntity("LeadGenNetworkType") as LeadGenNetworkType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadGenCampaigns_CrtSocialLeadGenEventsProcess(UserConnection);
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
			return new LeadGenCampaigns(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadGenCampaigns_CrtSocialLeadGenEventsProcess

	/// <exclude/>
	public partial class LeadGenCampaigns_CrtSocialLeadGenEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : LeadGenCampaigns
	{

		public LeadGenCampaigns_CrtSocialLeadGenEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadGenCampaigns_CrtSocialLeadGenEventsProcess";
			SchemaUId = new Guid("ef54d5f4-63e2-4f5f-b222-f12f6b9aa6c0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ef54d5f4-63e2-4f5f-b222-f12f6b9aa6c0");
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

	#region Class: LeadGenCampaigns_CrtSocialLeadGenEventsProcess

	/// <exclude/>
	public class LeadGenCampaigns_CrtSocialLeadGenEventsProcess : LeadGenCampaigns_CrtSocialLeadGenEventsProcess<LeadGenCampaigns>
	{

		public LeadGenCampaigns_CrtSocialLeadGenEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadGenCampaigns_CrtSocialLeadGenEventsProcess

	public partial class LeadGenCampaigns_CrtSocialLeadGenEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: LeadGenCampaignsEventsProcess

	/// <exclude/>
	public class LeadGenCampaignsEventsProcess : LeadGenCampaigns_CrtSocialLeadGenEventsProcess
	{

		public LeadGenCampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

