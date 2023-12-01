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

	#region Class: MktgActivityStatus_CampaignPlannerNew_TerrasoftSchema

	/// <exclude/>
	public class MktgActivityStatus_CampaignPlannerNew_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public MktgActivityStatus_CampaignPlannerNew_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MktgActivityStatus_CampaignPlannerNew_TerrasoftSchema(MktgActivityStatus_CampaignPlannerNew_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MktgActivityStatus_CampaignPlannerNew_TerrasoftSchema(MktgActivityStatus_CampaignPlannerNew_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("80b0b33e-3dc6-4900-b7fe-844446c56a53");
			RealUId = new Guid("80b0b33e-3dc6-4900-b7fe-844446c56a53");
			Name = "MktgActivityStatus_CampaignPlannerNew_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			return new MktgActivityStatus_CampaignPlannerNew_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MktgActivityStatus_CampaignPlannerNewEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MktgActivityStatus_CampaignPlannerNew_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MktgActivityStatus_CampaignPlannerNew_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("80b0b33e-3dc6-4900-b7fe-844446c56a53"));
		}

		#endregion

	}

	#endregion

	#region Class: MktgActivityStatus_CampaignPlannerNew_Terrasoft

	/// <summary>
	/// Marketing activity status.
	/// </summary>
	public class MktgActivityStatus_CampaignPlannerNew_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public MktgActivityStatus_CampaignPlannerNew_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MktgActivityStatus_CampaignPlannerNew_Terrasoft";
		}

		public MktgActivityStatus_CampaignPlannerNew_Terrasoft(MktgActivityStatus_CampaignPlannerNew_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MktgActivityStatus_CampaignPlannerNewEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MktgActivityStatus_CampaignPlannerNew_TerrasoftDeleted", e);
			Validating += (s, e) => ThrowEvent("MktgActivityStatus_CampaignPlannerNew_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MktgActivityStatus_CampaignPlannerNew_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: MktgActivityStatus_CampaignPlannerNewEventsProcess

	/// <exclude/>
	public partial class MktgActivityStatus_CampaignPlannerNewEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : MktgActivityStatus_CampaignPlannerNew_Terrasoft
	{

		public MktgActivityStatus_CampaignPlannerNewEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MktgActivityStatus_CampaignPlannerNewEventsProcess";
			SchemaUId = new Guid("80b0b33e-3dc6-4900-b7fe-844446c56a53");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("80b0b33e-3dc6-4900-b7fe-844446c56a53");
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

	#region Class: MktgActivityStatus_CampaignPlannerNewEventsProcess

	/// <exclude/>
	public class MktgActivityStatus_CampaignPlannerNewEventsProcess : MktgActivityStatus_CampaignPlannerNewEventsProcess<MktgActivityStatus_CampaignPlannerNew_Terrasoft>
	{

		public MktgActivityStatus_CampaignPlannerNewEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MktgActivityStatus_CampaignPlannerNewEventsProcess

	public partial class MktgActivityStatus_CampaignPlannerNewEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

