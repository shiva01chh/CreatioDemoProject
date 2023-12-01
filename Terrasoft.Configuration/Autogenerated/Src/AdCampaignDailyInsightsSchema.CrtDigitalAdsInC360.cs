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

	#region Class: AdCampaignDailyInsightsSchema

	/// <exclude/>
	public class AdCampaignDailyInsightsSchema : Terrasoft.Configuration.AdCampaignDailyInsights_CrtDigitalAdsApp_TerrasoftSchema
	{

		#region Constructors: Public

		public AdCampaignDailyInsightsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AdCampaignDailyInsightsSchema(AdCampaignDailyInsightsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AdCampaignDailyInsightsSchema(AdCampaignDailyInsightsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("b3a145b5-3e70-4373-853a-5622c0b003c1");
			Name = "AdCampaignDailyInsights";
			ParentSchemaUId = new Guid("cfb6f45d-cba1-4654-a569-26706df96805");
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
			if (Columns.FindByUId(new Guid("288fcffe-b867-ce99-4346-e6ec91160487")) == null) {
				Columns.Add(CreateSubmissionsColumn());
			}
			if (Columns.FindByUId(new Guid("39f07b02-ee24-fcca-9ca0-fc99dce7f39b")) == null) {
				Columns.Add(CreateContactsColumn());
			}
			if (Columns.FindByUId(new Guid("8ff17f48-a4ca-006e-bcf7-5dd9e46b0943")) == null) {
				Columns.Add(CreateCostPerSubmissionColumn());
			}
			if (Columns.FindByUId(new Guid("3cca6676-06cd-f9fb-bc38-55f890c75de2")) == null) {
				Columns.Add(CreateCostPerContactColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSubmissionsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("288fcffe-b867-ce99-4346-e6ec91160487"),
				Name = @"Submissions",
				CreatedInSchemaUId = new Guid("b3a145b5-3e70-4373-853a-5622c0b003c1"),
				ModifiedInSchemaUId = new Guid("b3a145b5-3e70-4373-853a-5622c0b003c1"),
				CreatedInPackageId = new Guid("1f624e01-f284-4287-8a23-f115d1bf140b")
			};
		}

		protected virtual EntitySchemaColumn CreateContactsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("39f07b02-ee24-fcca-9ca0-fc99dce7f39b"),
				Name = @"Contacts",
				CreatedInSchemaUId = new Guid("b3a145b5-3e70-4373-853a-5622c0b003c1"),
				ModifiedInSchemaUId = new Guid("b3a145b5-3e70-4373-853a-5622c0b003c1"),
				CreatedInPackageId = new Guid("1f624e01-f284-4287-8a23-f115d1bf140b")
			};
		}

		protected virtual EntitySchemaColumn CreateCostPerSubmissionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("8ff17f48-a4ca-006e-bcf7-5dd9e46b0943"),
				Name = @"CostPerSubmission",
				CreatedInSchemaUId = new Guid("b3a145b5-3e70-4373-853a-5622c0b003c1"),
				ModifiedInSchemaUId = new Guid("b3a145b5-3e70-4373-853a-5622c0b003c1"),
				CreatedInPackageId = new Guid("1f624e01-f284-4287-8a23-f115d1bf140b")
			};
		}

		protected virtual EntitySchemaColumn CreateCostPerContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("3cca6676-06cd-f9fb-bc38-55f890c75de2"),
				Name = @"CostPerContact",
				CreatedInSchemaUId = new Guid("b3a145b5-3e70-4373-853a-5622c0b003c1"),
				ModifiedInSchemaUId = new Guid("b3a145b5-3e70-4373-853a-5622c0b003c1"),
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
			return new AdCampaignDailyInsights(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AdCampaignDailyInsights_CrtDigitalAdsInC360EventsProcess(userConnection);
		}

		public override object Clone() {
			return new AdCampaignDailyInsightsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AdCampaignDailyInsightsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b3a145b5-3e70-4373-853a-5622c0b003c1"));
		}

		#endregion

	}

	#endregion

	#region Class: AdCampaignDailyInsights

	/// <summary>
	/// Ad campaign daily insights.
	/// </summary>
	/// <remarks>
	/// Performance indexes of ad campaign by day.
	/// </remarks>
	public class AdCampaignDailyInsights : Terrasoft.Configuration.AdCampaignDailyInsights_CrtDigitalAdsApp_Terrasoft
	{

		#region Constructors: Public

		public AdCampaignDailyInsights(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AdCampaignDailyInsights";
		}

		public AdCampaignDailyInsights(AdCampaignDailyInsights source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Number of submissions.
		/// </summary>
		/// <remarks>
		/// The number of submission in Creatio generated by your Ad campaign.
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
		/// Number of Contacts.
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
			var process = new AdCampaignDailyInsights_CrtDigitalAdsInC360EventsProcess(UserConnection);
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
			return new AdCampaignDailyInsights(this);
		}

		#endregion

	}

	#endregion

	#region Class: AdCampaignDailyInsights_CrtDigitalAdsInC360EventsProcess

	/// <exclude/>
	public partial class AdCampaignDailyInsights_CrtDigitalAdsInC360EventsProcess<TEntity> : Terrasoft.Configuration.AdCampaignDailyInsights_CrtDigitalAdsAppEventsProcess<TEntity> where TEntity : AdCampaignDailyInsights
	{

		public AdCampaignDailyInsights_CrtDigitalAdsInC360EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdCampaignDailyInsights_CrtDigitalAdsInC360EventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b3a145b5-3e70-4373-853a-5622c0b003c1");
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

	#region Class: AdCampaignDailyInsights_CrtDigitalAdsInC360EventsProcess

	/// <exclude/>
	public class AdCampaignDailyInsights_CrtDigitalAdsInC360EventsProcess : AdCampaignDailyInsights_CrtDigitalAdsInC360EventsProcess<AdCampaignDailyInsights>
	{

		public AdCampaignDailyInsights_CrtDigitalAdsInC360EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdCampaignDailyInsights_CrtDigitalAdsInC360EventsProcess

	public partial class AdCampaignDailyInsights_CrtDigitalAdsInC360EventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AdCampaignDailyInsightsEventsProcess

	/// <exclude/>
	public class AdCampaignDailyInsightsEventsProcess : AdCampaignDailyInsights_CrtDigitalAdsInC360EventsProcess
	{

		public AdCampaignDailyInsightsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

