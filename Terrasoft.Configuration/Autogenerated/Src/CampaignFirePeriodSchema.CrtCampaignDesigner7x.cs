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

	#region Class: CampaignFirePeriodSchema

	/// <exclude/>
	public class CampaignFirePeriodSchema : Terrasoft.Configuration.BaseValueLookupSchema
	{

		#region Constructors: Public

		public CampaignFirePeriodSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CampaignFirePeriodSchema(CampaignFirePeriodSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CampaignFirePeriodSchema(CampaignFirePeriodSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f913db0b-2734-4b46-8a7a-fbe9c6244ad9");
			RealUId = new Guid("f913db0b-2734-4b46-8a7a-fbe9c6244ad9");
			Name = "CampaignFirePeriod";
			ParentSchemaUId = new Guid("04f67f0c-0a27-4616-987e-60e378854b0f");
			ExtendParent = false;
			CreatedInPackageId = new Guid("ef1d1d78-1c12-4a7c-8c82-0ea80dfcc2c0");
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
			return new CampaignFirePeriod(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CampaignFirePeriod_CrtCampaignDesigner7xEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CampaignFirePeriodSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CampaignFirePeriodSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f913db0b-2734-4b46-8a7a-fbe9c6244ad9"));
		}

		#endregion

	}

	#endregion

	#region Class: CampaignFirePeriod

	/// <summary>
	/// Campaign fire period.
	/// </summary>
	public class CampaignFirePeriod : Terrasoft.Configuration.BaseValueLookup
	{

		#region Constructors: Public

		public CampaignFirePeriod(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CampaignFirePeriod";
		}

		public CampaignFirePeriod(CampaignFirePeriod source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CampaignFirePeriod_CrtCampaignDesigner7xEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CampaignFirePeriodDeleted", e);
			Validating += (s, e) => ThrowEvent("CampaignFirePeriodValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CampaignFirePeriod(this);
		}

		#endregion

	}

	#endregion

	#region Class: CampaignFirePeriod_CrtCampaignDesigner7xEventsProcess

	/// <exclude/>
	public partial class CampaignFirePeriod_CrtCampaignDesigner7xEventsProcess<TEntity> : Terrasoft.Configuration.BaseValueLookup_CrtBaseEventsProcess<TEntity> where TEntity : CampaignFirePeriod
	{

		public CampaignFirePeriod_CrtCampaignDesigner7xEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CampaignFirePeriod_CrtCampaignDesigner7xEventsProcess";
			SchemaUId = new Guid("f913db0b-2734-4b46-8a7a-fbe9c6244ad9");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f913db0b-2734-4b46-8a7a-fbe9c6244ad9");
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

	#region Class: CampaignFirePeriod_CrtCampaignDesigner7xEventsProcess

	/// <exclude/>
	public class CampaignFirePeriod_CrtCampaignDesigner7xEventsProcess : CampaignFirePeriod_CrtCampaignDesigner7xEventsProcess<CampaignFirePeriod>
	{

		public CampaignFirePeriod_CrtCampaignDesigner7xEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CampaignFirePeriod_CrtCampaignDesigner7xEventsProcess

	public partial class CampaignFirePeriod_CrtCampaignDesigner7xEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CampaignFirePeriodEventsProcess

	/// <exclude/>
	public class CampaignFirePeriodEventsProcess : CampaignFirePeriod_CrtCampaignDesigner7xEventsProcess
	{

		public CampaignFirePeriodEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

