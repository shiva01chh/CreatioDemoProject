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

	#region Class: AdCampaignStatusSchema

	/// <exclude/>
	public class AdCampaignStatusSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public AdCampaignStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AdCampaignStatusSchema(AdCampaignStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AdCampaignStatusSchema(AdCampaignStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fa0c29e0-84d9-44dd-9ab7-cd4b39c2efa9");
			RealUId = new Guid("fa0c29e0-84d9-44dd-9ab7-cd4b39c2efa9");
			Name = "AdCampaignStatus";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColorColumn() {
			base.InitializePrimaryColorColumn();
			PrimaryColorColumn = CreateColorColumn();
			if (Columns.FindByUId(PrimaryColorColumn.UId) == null) {
				Columns.Add(PrimaryColorColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected virtual EntitySchemaColumn CreateColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Color")) {
				UId = new Guid("70ccd3db-e7c2-ad59-9c80-7e97701c036c"),
				Name = @"Color",
				CreatedInSchemaUId = new Guid("fa0c29e0-84d9-44dd-9ab7-cd4b39c2efa9"),
				ModifiedInSchemaUId = new Guid("fa0c29e0-84d9-44dd-9ab7-cd4b39c2efa9"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AdCampaignStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AdCampaignStatus_CrtDigitalAdsAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AdCampaignStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AdCampaignStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fa0c29e0-84d9-44dd-9ab7-cd4b39c2efa9"));
		}

		#endregion

	}

	#endregion

	#region Class: AdCampaignStatus

	/// <summary>
	/// Ad campaign status.
	/// </summary>
	public class AdCampaignStatus : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public AdCampaignStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AdCampaignStatus";
		}

		public AdCampaignStatus(AdCampaignStatus source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Color.
		/// </summary>
		public Color Color {
			get {
				return GetTypedColumnValue<Color>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AdCampaignStatus_CrtDigitalAdsAppEventsProcess(UserConnection);
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
			return new AdCampaignStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: AdCampaignStatus_CrtDigitalAdsAppEventsProcess

	/// <exclude/>
	public partial class AdCampaignStatus_CrtDigitalAdsAppEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : AdCampaignStatus
	{

		public AdCampaignStatus_CrtDigitalAdsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdCampaignStatus_CrtDigitalAdsAppEventsProcess";
			SchemaUId = new Guid("fa0c29e0-84d9-44dd-9ab7-cd4b39c2efa9");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fa0c29e0-84d9-44dd-9ab7-cd4b39c2efa9");
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

	#region Class: AdCampaignStatus_CrtDigitalAdsAppEventsProcess

	/// <exclude/>
	public class AdCampaignStatus_CrtDigitalAdsAppEventsProcess : AdCampaignStatus_CrtDigitalAdsAppEventsProcess<AdCampaignStatus>
	{

		public AdCampaignStatus_CrtDigitalAdsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdCampaignStatus_CrtDigitalAdsAppEventsProcess

	public partial class AdCampaignStatus_CrtDigitalAdsAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AdCampaignStatusEventsProcess

	/// <exclude/>
	public class AdCampaignStatusEventsProcess : AdCampaignStatus_CrtDigitalAdsAppEventsProcess
	{

		public AdCampaignStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

