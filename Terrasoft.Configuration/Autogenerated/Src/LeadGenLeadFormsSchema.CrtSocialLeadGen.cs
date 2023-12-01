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

	#region Class: LeadGenLeadFormsSchema

	/// <exclude/>
	public class LeadGenLeadFormsSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public LeadGenLeadFormsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadGenLeadFormsSchema(LeadGenLeadFormsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadGenLeadFormsSchema(LeadGenLeadFormsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c9382158-e397-4551-aee4-8712908d08cb");
			RealUId = new Guid("c9382158-e397-4551-aee4-8712908d08cb");
			Name = "LeadGenLeadForms";
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
			if (Columns.FindByUId(new Guid("3e7aa398-44da-e1e8-3f24-7659ee7a1dfe")) == null) {
				Columns.Add(CreateSocialFormIdColumn());
			}
			if (Columns.FindByUId(new Guid("057e2cfe-cd56-4e32-a955-af4fdb7b0626")) == null) {
				Columns.Add(CreateLeadGenNetworkTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSocialFormIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("3e7aa398-44da-e1e8-3f24-7659ee7a1dfe"),
				Name = @"SocialFormId",
				CreatedInSchemaUId = new Guid("c9382158-e397-4551-aee4-8712908d08cb"),
				ModifiedInSchemaUId = new Guid("c9382158-e397-4551-aee4-8712908d08cb"),
				CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31")
			};
		}

		protected virtual EntitySchemaColumn CreateLeadGenNetworkTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("057e2cfe-cd56-4e32-a955-af4fdb7b0626"),
				Name = @"LeadGenNetworkType",
				ReferenceSchemaUId = new Guid("2f219369-8c87-4a6f-bf14-b048b134ea66"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c9382158-e397-4551-aee4-8712908d08cb"),
				ModifiedInSchemaUId = new Guid("c9382158-e397-4551-aee4-8712908d08cb"),
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
			return new LeadGenLeadForms(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadGenLeadForms_CrtSocialLeadGenEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadGenLeadFormsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadGenLeadFormsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c9382158-e397-4551-aee4-8712908d08cb"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadGenLeadForms

	/// <summary>
	/// Lead forms.
	/// </summary>
	public class LeadGenLeadForms : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public LeadGenLeadForms(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadGenLeadForms";
		}

		public LeadGenLeadForms(LeadGenLeadForms source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Social form id.
		/// </summary>
		public string SocialFormId {
			get {
				return GetTypedColumnValue<string>("SocialFormId");
			}
			set {
				SetColumnValue("SocialFormId", value);
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
			var process = new LeadGenLeadForms_CrtSocialLeadGenEventsProcess(UserConnection);
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
			return new LeadGenLeadForms(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadGenLeadForms_CrtSocialLeadGenEventsProcess

	/// <exclude/>
	public partial class LeadGenLeadForms_CrtSocialLeadGenEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : LeadGenLeadForms
	{

		public LeadGenLeadForms_CrtSocialLeadGenEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadGenLeadForms_CrtSocialLeadGenEventsProcess";
			SchemaUId = new Guid("c9382158-e397-4551-aee4-8712908d08cb");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c9382158-e397-4551-aee4-8712908d08cb");
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

	#region Class: LeadGenLeadForms_CrtSocialLeadGenEventsProcess

	/// <exclude/>
	public class LeadGenLeadForms_CrtSocialLeadGenEventsProcess : LeadGenLeadForms_CrtSocialLeadGenEventsProcess<LeadGenLeadForms>
	{

		public LeadGenLeadForms_CrtSocialLeadGenEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadGenLeadForms_CrtSocialLeadGenEventsProcess

	public partial class LeadGenLeadForms_CrtSocialLeadGenEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: LeadGenLeadFormsEventsProcess

	/// <exclude/>
	public class LeadGenLeadFormsEventsProcess : LeadGenLeadForms_CrtSocialLeadGenEventsProcess
	{

		public LeadGenLeadFormsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

