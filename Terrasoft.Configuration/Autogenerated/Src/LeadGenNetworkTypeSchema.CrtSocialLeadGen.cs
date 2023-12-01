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

	#region Class: LeadGenNetworkTypeSchema

	/// <exclude/>
	public class LeadGenNetworkTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public LeadGenNetworkTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadGenNetworkTypeSchema(LeadGenNetworkTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadGenNetworkTypeSchema(LeadGenNetworkTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2f219369-8c87-4a6f-bf14-b048b134ea66");
			RealUId = new Guid("2f219369-8c87-4a6f-bf14-b048b134ea66");
			Name = "LeadGenNetworkType";
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
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LeadGenNetworkType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadGenNetworkType_CrtSocialLeadGenEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadGenNetworkTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadGenNetworkTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f219369-8c87-4a6f-bf14-b048b134ea66"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadGenNetworkType

	/// <summary>
	/// Social network type.
	/// </summary>
	public class LeadGenNetworkType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public LeadGenNetworkType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadGenNetworkType";
		}

		public LeadGenNetworkType(LeadGenNetworkType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadGenNetworkType_CrtSocialLeadGenEventsProcess(UserConnection);
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
			return new LeadGenNetworkType(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadGenNetworkType_CrtSocialLeadGenEventsProcess

	/// <exclude/>
	public partial class LeadGenNetworkType_CrtSocialLeadGenEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : LeadGenNetworkType
	{

		public LeadGenNetworkType_CrtSocialLeadGenEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadGenNetworkType_CrtSocialLeadGenEventsProcess";
			SchemaUId = new Guid("2f219369-8c87-4a6f-bf14-b048b134ea66");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2f219369-8c87-4a6f-bf14-b048b134ea66");
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

	#region Class: LeadGenNetworkType_CrtSocialLeadGenEventsProcess

	/// <exclude/>
	public class LeadGenNetworkType_CrtSocialLeadGenEventsProcess : LeadGenNetworkType_CrtSocialLeadGenEventsProcess<LeadGenNetworkType>
	{

		public LeadGenNetworkType_CrtSocialLeadGenEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadGenNetworkType_CrtSocialLeadGenEventsProcess

	public partial class LeadGenNetworkType_CrtSocialLeadGenEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: LeadGenNetworkTypeEventsProcess

	/// <exclude/>
	public class LeadGenNetworkTypeEventsProcess : LeadGenNetworkType_CrtSocialLeadGenEventsProcess
	{

		public LeadGenNetworkTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

