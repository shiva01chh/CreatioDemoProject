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

	#region Class: Opportunity_CrtLeadOppMgmtApp_TerrasoftSchema

	/// <exclude/>
	public class Opportunity_CrtLeadOppMgmtApp_TerrasoftSchema : Terrasoft.Configuration.Opportunity_CrtMLOpportunityScoring_TerrasoftSchema
	{

		#region Constructors: Public

		public Opportunity_CrtLeadOppMgmtApp_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Opportunity_CrtLeadOppMgmtApp_TerrasoftSchema(Opportunity_CrtLeadOppMgmtApp_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Opportunity_CrtLeadOppMgmtApp_TerrasoftSchema(Opportunity_CrtLeadOppMgmtApp_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22");
			Name = "Opportunity_CrtLeadOppMgmtApp_Terrasoft";
			ParentSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			ExtendParent = true;
			CreatedInPackageId = new Guid("cabe91a5-1698-4b47-8e3b-380885462b82");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5699743b-e4af-80ae-5c85-b5c5d579ff40")) == null) {
				Columns.Add(CreateGroupColumn());
			}
			if (Columns.FindByUId(new Guid("f5062653-cb42-84b9-4a90-f98c62c1e24d")) == null) {
				Columns.Add(CreateProductSuggestionsColumn());
			}
			if (Columns.FindByUId(new Guid("9fd4767a-12a6-6bab-7580-cb7a9b56da48")) == null) {
				Columns.Add(CreateBuyingProcessColumn());
			}
			if (Columns.FindByUId(new Guid("19795861-c6fb-6422-5df1-300248b6c007")) == null) {
				Columns.Add(CreateWhyNowColumn());
			}
			if (Columns.FindByUId(new Guid("771088f2-cc14-d3be-386b-7ca3567ff28c")) == null) {
				Columns.Add(CreateWhyColumn());
			}
			if (Columns.FindByUId(new Guid("5ba0c129-ad9e-99b8-24a4-0cdd1cb40054")) == null) {
				Columns.Add(CreateWhatColumn());
			}
			if (Columns.FindByUId(new Guid("3b23494a-545e-e315-0291-8662f803c238")) == null) {
				Columns.Add(CreateEngagementTacticColumn());
			}
			if (Columns.FindByUId(new Guid("4d118ec6-2265-2476-0c00-0daf529b8a9f")) == null) {
				Columns.Add(CreateWhyOurCompanyColumn());
			}
			if (Columns.FindByUId(new Guid("c1dc3a52-1307-a542-c3dd-80019885b826")) == null) {
				Columns.Add(CreateForecastCommitColumn());
			}
			if (Columns.FindByUId(new Guid("8065917d-c17c-b91d-927e-3efb9c8ae041")) == null) {
				Columns.Add(CreateDecisionMakerColumn());
			}
			if (Columns.FindByUId(new Guid("67a48a64-5b7a-6e66-af67-23b1ba41b033")) == null) {
				Columns.Add(CreateClosingDetailsColumn());
			}
		}

		protected override EntitySchemaColumn CreateDueDateColumn() {
			EntitySchemaColumn column = base.CreateDueDateColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("Date");
			column.ModifiedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22");
			return column;
		}

		protected virtual EntitySchemaColumn CreateGroupColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5699743b-e4af-80ae-5c85-b5c5d579ff40"),
				Name = @"Group",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				ModifiedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				CreatedInPackageId = new Guid("bde8fa0e-315d-4047-bd73-a14f85bea5e9")
			};
		}

		protected virtual EntitySchemaColumn CreateProductSuggestionsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("f5062653-cb42-84b9-4a90-f98c62c1e24d"),
				Name = @"ProductSuggestions",
				CreatedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				ModifiedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				CreatedInPackageId = new Guid("b57f0923-97ad-4ee8-8a57-36c03d15acf5"),
				IsFormatValidated = true
			};
		}

		protected virtual EntitySchemaColumn CreateBuyingProcessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("9fd4767a-12a6-6bab-7580-cb7a9b56da48"),
				Name = @"BuyingProcess",
				CreatedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				ModifiedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				CreatedInPackageId = new Guid("97e8197a-4e52-433f-8b0e-821d5460b988"),
				IsFormatValidated = true
			};
		}

		protected virtual EntitySchemaColumn CreateWhyNowColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("19795861-c6fb-6422-5df1-300248b6c007"),
				Name = @"WhyNow",
				CreatedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				ModifiedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				CreatedInPackageId = new Guid("97e8197a-4e52-433f-8b0e-821d5460b988"),
				IsFormatValidated = true
			};
		}

		protected virtual EntitySchemaColumn CreateWhyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("771088f2-cc14-d3be-386b-7ca3567ff28c"),
				Name = @"Why",
				CreatedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				ModifiedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				CreatedInPackageId = new Guid("97e8197a-4e52-433f-8b0e-821d5460b988"),
				IsFormatValidated = true
			};
		}

		protected virtual EntitySchemaColumn CreateWhatColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("5ba0c129-ad9e-99b8-24a4-0cdd1cb40054"),
				Name = @"What",
				CreatedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				ModifiedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				CreatedInPackageId = new Guid("97e8197a-4e52-433f-8b0e-821d5460b988"),
				IsFormatValidated = true
			};
		}

		protected virtual EntitySchemaColumn CreateEngagementTacticColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("3b23494a-545e-e315-0291-8662f803c238"),
				Name = @"EngagementTactic",
				CreatedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				ModifiedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				CreatedInPackageId = new Guid("97e8197a-4e52-433f-8b0e-821d5460b988"),
				IsFormatValidated = true
			};
		}

		protected virtual EntitySchemaColumn CreateWhyOurCompanyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("4d118ec6-2265-2476-0c00-0daf529b8a9f"),
				Name = @"WhyOurCompany",
				CreatedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				ModifiedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				CreatedInPackageId = new Guid("97e8197a-4e52-433f-8b0e-821d5460b988"),
				IsFormatValidated = true
			};
		}

		protected virtual EntitySchemaColumn CreateForecastCommitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c1dc3a52-1307-a542-c3dd-80019885b826"),
				Name = @"ForecastCommit",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				ModifiedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				CreatedInPackageId = new Guid("6a8500f8-2d54-40a9-9bda-ba1658549a5b")
			};
		}

		protected virtual EntitySchemaColumn CreateDecisionMakerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8065917d-c17c-b91d-927e-3efb9c8ae041"),
				Name = @"DecisionMaker",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				ModifiedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				CreatedInPackageId = new Guid("6a8500f8-2d54-40a9-9bda-ba1658549a5b")
			};
		}

		protected virtual EntitySchemaColumn CreateClosingDetailsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("67a48a64-5b7a-6e66-af67-23b1ba41b033"),
				Name = @"ClosingDetails",
				CreatedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				ModifiedInSchemaUId = new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"),
				CreatedInPackageId = new Guid("3c209e29-b321-47ed-99ea-a5265dc0773f"),
				IsFormatValidated = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Opportunity_CrtLeadOppMgmtApp_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Opportunity_CrtLeadOppMgmtAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Opportunity_CrtLeadOppMgmtApp_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Opportunity_CrtLeadOppMgmtApp_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22"));
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_CrtLeadOppMgmtApp_Terrasoft

	/// <summary>
	/// Opportunity.
	/// </summary>
	public class Opportunity_CrtLeadOppMgmtApp_Terrasoft : Terrasoft.Configuration.Opportunity_CrtMLOpportunityScoring_Terrasoft
	{

		#region Constructors: Public

		public Opportunity_CrtLeadOppMgmtApp_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Opportunity_CrtLeadOppMgmtApp_Terrasoft";
		}

		public Opportunity_CrtLeadOppMgmtApp_Terrasoft(Opportunity_CrtLeadOppMgmtApp_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid GroupId {
			get {
				return GetTypedColumnValue<Guid>("GroupId");
			}
			set {
				SetColumnValue("GroupId", value);
				_group = null;
			}
		}

		/// <exclude/>
		public string GroupName {
			get {
				return GetTypedColumnValue<string>("GroupName");
			}
			set {
				SetColumnValue("GroupName", value);
				if (_group != null) {
					_group.Name = value;
				}
			}
		}

		private SysAdminUnit _group;
		/// <summary>
		/// Assignees group.
		/// </summary>
		public SysAdminUnit Group {
			get {
				return _group ??
					(_group = LookupColumnEntities.GetEntity("Group") as SysAdminUnit);
			}
		}

		/// <summary>
		/// Product suggestions.
		/// </summary>
		public string ProductSuggestions {
			get {
				return GetTypedColumnValue<string>("ProductSuggestions");
			}
			set {
				SetColumnValue("ProductSuggestions", value);
			}
		}

		/// <summary>
		/// Buying process.
		/// </summary>
		public string BuyingProcess {
			get {
				return GetTypedColumnValue<string>("BuyingProcess");
			}
			set {
				SetColumnValue("BuyingProcess", value);
			}
		}

		/// <summary>
		/// Why now?.
		/// </summary>
		public string WhyNow {
			get {
				return GetTypedColumnValue<string>("WhyNow");
			}
			set {
				SetColumnValue("WhyNow", value);
			}
		}

		/// <summary>
		/// Why?.
		/// </summary>
		public string Why {
			get {
				return GetTypedColumnValue<string>("Why");
			}
			set {
				SetColumnValue("Why", value);
			}
		}

		/// <summary>
		/// What?.
		/// </summary>
		public string What {
			get {
				return GetTypedColumnValue<string>("What");
			}
			set {
				SetColumnValue("What", value);
			}
		}

		/// <summary>
		/// Engagement tactic.
		/// </summary>
		public string EngagementTactic {
			get {
				return GetTypedColumnValue<string>("EngagementTactic");
			}
			set {
				SetColumnValue("EngagementTactic", value);
			}
		}

		/// <summary>
		/// Why our company?.
		/// </summary>
		public string WhyOurCompany {
			get {
				return GetTypedColumnValue<string>("WhyOurCompany");
			}
			set {
				SetColumnValue("WhyOurCompany", value);
			}
		}

		/// <summary>
		/// Commit to forecast.
		/// </summary>
		public bool ForecastCommit {
			get {
				return GetTypedColumnValue<bool>("ForecastCommit");
			}
			set {
				SetColumnValue("ForecastCommit", value);
			}
		}

		/// <exclude/>
		public Guid DecisionMakerId {
			get {
				return GetTypedColumnValue<Guid>("DecisionMakerId");
			}
			set {
				SetColumnValue("DecisionMakerId", value);
				_decisionMaker = null;
			}
		}

		/// <exclude/>
		public string DecisionMakerName {
			get {
				return GetTypedColumnValue<string>("DecisionMakerName");
			}
			set {
				SetColumnValue("DecisionMakerName", value);
				if (_decisionMaker != null) {
					_decisionMaker.Name = value;
				}
			}
		}

		private Contact _decisionMaker;
		/// <summary>
		/// Decision maker.
		/// </summary>
		public Contact DecisionMaker {
			get {
				return _decisionMaker ??
					(_decisionMaker = LookupColumnEntities.GetEntity("DecisionMaker") as Contact);
			}
		}

		/// <summary>
		/// Closing details.
		/// </summary>
		public string ClosingDetails {
			get {
				return GetTypedColumnValue<string>("ClosingDetails");
			}
			set {
				SetColumnValue("ClosingDetails", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Opportunity_CrtLeadOppMgmtAppEventsProcess(UserConnection);
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
			return new Opportunity_CrtLeadOppMgmtApp_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_CrtLeadOppMgmtAppEventsProcess

	/// <exclude/>
	public partial class Opportunity_CrtLeadOppMgmtAppEventsProcess<TEntity> : Terrasoft.Configuration.Opportunity_CrtMLOpportunityScoringEventsProcess<TEntity> where TEntity : Opportunity_CrtLeadOppMgmtApp_Terrasoft
	{

		public Opportunity_CrtLeadOppMgmtAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Opportunity_CrtLeadOppMgmtAppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("10bd2f77-11ed-45de-90e1-e464b9cb9c22");
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

	#region Class: Opportunity_CrtLeadOppMgmtAppEventsProcess

	/// <exclude/>
	public class Opportunity_CrtLeadOppMgmtAppEventsProcess : Opportunity_CrtLeadOppMgmtAppEventsProcess<Opportunity_CrtLeadOppMgmtApp_Terrasoft>
	{

		public Opportunity_CrtLeadOppMgmtAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Opportunity_CrtLeadOppMgmtAppEventsProcess

	public partial class Opportunity_CrtLeadOppMgmtAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

