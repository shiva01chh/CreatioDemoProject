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

	#region Class: BulkEmail_CrtEmailInCampaignBase_TerrasoftSchema

	/// <exclude/>
	public class BulkEmail_CrtEmailInCampaignBase_TerrasoftSchema : Terrasoft.Configuration.BulkEmail_CrtBulkEmail_TerrasoftSchema
	{

		#region Constructors: Public

		public BulkEmail_CrtEmailInCampaignBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmail_CrtEmailInCampaignBase_TerrasoftSchema(BulkEmail_CrtEmailInCampaignBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmail_CrtEmailInCampaignBase_TerrasoftSchema(BulkEmail_CrtEmailInCampaignBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("caf9e312-e49c-41ab-ab20-5022fee33fd4");
			Name = "BulkEmail_CrtEmailInCampaignBase_Terrasoft";
			ParentSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8");
			ExtendParent = true;
			CreatedInPackageId = new Guid("1302752e-c11a-484e-8943-f1a15c49996f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6f3b2c62-03a2-4a6a-802b-5c3445e6b534")) == null) {
				Columns.Add(CreateCampaignColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCampaignColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6f3b2c62-03a2-4a6a-802b-5c3445e6b534"),
				Name = @"Campaign",
				ReferenceSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("caf9e312-e49c-41ab-ab20-5022fee33fd4"),
				ModifiedInSchemaUId = new Guid("caf9e312-e49c-41ab-ab20-5022fee33fd4"),
				CreatedInPackageId = new Guid("1302752e-c11a-484e-8943-f1a15c49996f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BulkEmail_CrtEmailInCampaignBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BulkEmail_CrtEmailInCampaignBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BulkEmail_CrtEmailInCampaignBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmail_CrtEmailInCampaignBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("caf9e312-e49c-41ab-ab20-5022fee33fd4"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmail_CrtEmailInCampaignBase_Terrasoft

	/// <summary>
	/// Email.
	/// </summary>
	public class BulkEmail_CrtEmailInCampaignBase_Terrasoft : Terrasoft.Configuration.BulkEmail_CrtBulkEmail_Terrasoft
	{

		#region Constructors: Public

		public BulkEmail_CrtEmailInCampaignBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmail_CrtEmailInCampaignBase_Terrasoft";
		}

		public BulkEmail_CrtEmailInCampaignBase_Terrasoft(BulkEmail_CrtEmailInCampaignBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CampaignId {
			get {
				return GetTypedColumnValue<Guid>("CampaignId");
			}
			set {
				SetColumnValue("CampaignId", value);
				_campaign = null;
			}
		}

		/// <exclude/>
		public string CampaignName {
			get {
				return GetTypedColumnValue<string>("CampaignName");
			}
			set {
				SetColumnValue("CampaignName", value);
				if (_campaign != null) {
					_campaign.Name = value;
				}
			}
		}

		private Campaign _campaign;
		/// <summary>
		/// Campaign.
		/// </summary>
		public Campaign Campaign {
			get {
				return _campaign ??
					(_campaign = LookupColumnEntities.GetEntity("Campaign") as Campaign);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmail_CrtEmailInCampaignBaseEventsProcess(UserConnection);
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
			return new BulkEmail_CrtEmailInCampaignBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmail_CrtEmailInCampaignBaseEventsProcess

	/// <exclude/>
	public partial class BulkEmail_CrtEmailInCampaignBaseEventsProcess<TEntity> : Terrasoft.Configuration.BulkEmail_CrtBulkEmailEventsProcess<TEntity> where TEntity : BulkEmail_CrtEmailInCampaignBase_Terrasoft
	{

		public BulkEmail_CrtEmailInCampaignBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmail_CrtEmailInCampaignBaseEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("caf9e312-e49c-41ab-ab20-5022fee33fd4");
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

	#region Class: BulkEmail_CrtEmailInCampaignBaseEventsProcess

	/// <exclude/>
	public class BulkEmail_CrtEmailInCampaignBaseEventsProcess : BulkEmail_CrtEmailInCampaignBaseEventsProcess<BulkEmail_CrtEmailInCampaignBase_Terrasoft>
	{

		public BulkEmail_CrtEmailInCampaignBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmail_CrtEmailInCampaignBaseEventsProcess

	public partial class BulkEmail_CrtEmailInCampaignBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

