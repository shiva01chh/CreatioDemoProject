namespace Terrasoft.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: AdCampaignSchema

	/// <exclude/>
	public class AdCampaignSchema : Terrasoft.Configuration.AdCampaign_CrtDigitalAdsApp_TerrasoftSchema
	{

		#region Constructors: Public

		public AdCampaignSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AdCampaignSchema(AdCampaignSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AdCampaignSchema(AdCampaignSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("7b2f4a0c-87e1-4e49-a20f-a8e0fe26f686");
			Name = "AdCampaign";
			ParentSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da");
			ExtendParent = true;
			CreatedInPackageId = new Guid("1f624e01-f284-4287-8a23-f115d1bf140b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("db5700b3-f3f4-3fb4-5675-ac0853b9196b")) == null) {
				Columns.Add(CreateSubmissionsColumn());
			}
			if (Columns.FindByUId(new Guid("585d1f89-77ad-cd1a-dd11-329728a9b6fc")) == null) {
				Columns.Add(CreateContactsColumn());
			}
			if (Columns.FindByUId(new Guid("f2d36502-7f87-7c00-b93d-95335de6e5f3")) == null) {
				Columns.Add(CreateCostPerSubmissionColumn());
			}
			if (Columns.FindByUId(new Guid("8f2a96da-e1b4-6949-025a-2cf695726710")) == null) {
				Columns.Add(CreateCostPerContactColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSubmissionsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("db5700b3-f3f4-3fb4-5675-ac0853b9196b"),
				Name = @"Submissions",
				CreatedInSchemaUId = new Guid("7b2f4a0c-87e1-4e49-a20f-a8e0fe26f686"),
				ModifiedInSchemaUId = new Guid("7b2f4a0c-87e1-4e49-a20f-a8e0fe26f686"),
				CreatedInPackageId = new Guid("1f624e01-f284-4287-8a23-f115d1bf140b")
			};
		}

		protected virtual EntitySchemaColumn CreateContactsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("585d1f89-77ad-cd1a-dd11-329728a9b6fc"),
				Name = @"Contacts",
				CreatedInSchemaUId = new Guid("7b2f4a0c-87e1-4e49-a20f-a8e0fe26f686"),
				ModifiedInSchemaUId = new Guid("7b2f4a0c-87e1-4e49-a20f-a8e0fe26f686"),
				CreatedInPackageId = new Guid("1f624e01-f284-4287-8a23-f115d1bf140b")
			};
		}

		protected virtual EntitySchemaColumn CreateCostPerSubmissionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("f2d36502-7f87-7c00-b93d-95335de6e5f3"),
				Name = @"CostPerSubmission",
				CreatedInSchemaUId = new Guid("7b2f4a0c-87e1-4e49-a20f-a8e0fe26f686"),
				ModifiedInSchemaUId = new Guid("7b2f4a0c-87e1-4e49-a20f-a8e0fe26f686"),
				CreatedInPackageId = new Guid("1f624e01-f284-4287-8a23-f115d1bf140b")
			};
		}

		protected virtual EntitySchemaColumn CreateCostPerContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("8f2a96da-e1b4-6949-025a-2cf695726710"),
				Name = @"CostPerContact",
				CreatedInSchemaUId = new Guid("7b2f4a0c-87e1-4e49-a20f-a8e0fe26f686"),
				ModifiedInSchemaUId = new Guid("7b2f4a0c-87e1-4e49-a20f-a8e0fe26f686"),
				CreatedInPackageId = new Guid("1f624e01-f284-4287-8a23-f115d1bf140b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AdCampaign(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AdCampaign_CrtDigitalAdsInC360EventsProcess(userConnection);
		}

		public override object Clone() {
			return new AdCampaignSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AdCampaignSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7b2f4a0c-87e1-4e49-a20f-a8e0fe26f686"));
		}

		#endregion

	}

	#endregion

	#region Class: AdCampaign

	/// <summary>
	/// Ad campaign.
	/// </summary>
	/// <remarks>
	/// The list of ad campaigns with performance indexes in the context of all life cycle.
	/// </remarks>
	public class AdCampaign : Terrasoft.Configuration.AdCampaign_CrtDigitalAdsApp_Terrasoft
	{

		#region Constructors: Public

		public AdCampaign(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AdCampaign";
		}

		public AdCampaign(AdCampaign source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Number of submissions.
		/// </summary>
		/// <remarks>
		/// Cost per submission measures how much you’ve spent to acquire a submitted form. Calculated by the formula: Amount spent ÷ Submissions.
		/// </remarks>
		public int Submissions {
			get {
				return GetTypedColumnValue<int>("Submissions");
			}
			set {
				SetColumnValue("Submissions", value);
			}
		}

		/// <summary>
		/// Number of contacts.
		/// </summary>
		/// <remarks>
		/// The number of contacts in Creatio engaged with your Ad campaign.
		/// </remarks>
		public int Contacts {
			get {
				return GetTypedColumnValue<int>("Contacts");
			}
			set {
				SetColumnValue("Contacts", value);
			}
		}

		/// <summary>
		/// Cost per Submission.
		/// </summary>
		/// <remarks>
		/// Cost per submission measures how much you’ve spent to acquire a submitted form. Calculated by the formula: Amount spent ÷ Submissions.
		/// </remarks>
		public Decimal CostPerSubmission {
			get {
				return GetTypedColumnValue<Decimal>("CostPerSubmission");
			}
			set {
				SetColumnValue("CostPerSubmission", value);
			}
		}

		/// <summary>
		/// Cost per Contact.
		/// </summary>
		/// <remarks>
		/// Cost per contact measures how much you’ve spent to acquire a new contact. Calculated by the formula: Amount spent ÷ Contacts.
		/// </remarks>
		public Decimal CostPerContact {
			get {
				return GetTypedColumnValue<Decimal>("CostPerContact");
			}
			set {
				SetColumnValue("CostPerContact", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AdCampaign_CrtDigitalAdsInC360EventsProcess(UserConnection);
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
			return new AdCampaign(this);
		}

		#endregion

	}

	#endregion

	#region Class: AdCampaign_CrtDigitalAdsInC360EventsProcess

	/// <exclude/>
	public partial class AdCampaign_CrtDigitalAdsInC360EventsProcess<TEntity> : Terrasoft.Configuration.AdCampaign_CrtDigitalAdsAppEventsProcess<TEntity> where TEntity : AdCampaign
	{

		public AdCampaign_CrtDigitalAdsInC360EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdCampaign_CrtDigitalAdsInC360EventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7b2f4a0c-87e1-4e49-a20f-a8e0fe26f686");
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

	#region Class: AdCampaign_CrtDigitalAdsInC360EventsProcess

	/// <exclude/>
	public class AdCampaign_CrtDigitalAdsInC360EventsProcess : AdCampaign_CrtDigitalAdsInC360EventsProcess<AdCampaign>
	{

		public AdCampaign_CrtDigitalAdsInC360EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdCampaign_CrtDigitalAdsInC360EventsProcess

	public partial class AdCampaign_CrtDigitalAdsInC360EventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AdCampaignEventsProcess

	/// <exclude/>
	public class AdCampaignEventsProcess : AdCampaign_CrtDigitalAdsInC360EventsProcess
	{

		public AdCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

