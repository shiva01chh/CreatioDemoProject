namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Opportunity

	/// <exclude/>
	public class Opportunity : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public Opportunity(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Opportunity";
		}

		public Opportunity(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "Opportunity";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<Call> CallCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<Document> DocumentCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettingCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<Invoice> InvoiceCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityCompetitor> OpportunityCompetitorCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityContact> OpportunityContactCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityFile> OpportunityFileCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityInFolder> OpportunityInFolderCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityInStage> OpportunityInStageCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityInTag> OpportunityInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<OpportunityKeyAction> OpportunityKeyActionCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityParticipant> OpportunityParticipantCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityProductInterest> OpportunityProductInterestCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityTacticHist> OpportunityTacticHistCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityVisa> OpportunityVisaCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<Order> OrderCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<Project> ProjectCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<VwOpportFunnelData> VwOpportFunnelDataCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<VwOpportInStageForAnalysis> VwOpportInStageForAnalysisCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<VwOpportunityInStage> VwOpportunityInStageCollectionByOpportunity {
			get;
			set;
		}

		/// <summary>
		/// Id.
		/// </summary>
		public Guid Id {
			get {
				return GetTypedColumnValue<Guid>("Id");
			}
			set {
				SetColumnValue("Id", value);
			}
		}

		/// <summary>
		/// Name.
		/// </summary>
		public string Title {
			get {
				return GetTypedColumnValue<string>("Title");
			}
			set {
				SetColumnValue("Title", value);
			}
		}

		/// <summary>
		/// Created on.
		/// </summary>
		public DateTime CreatedOn {
			get {
				return GetTypedColumnValue<DateTime>("CreatedOn");
			}
			set {
				SetColumnValue("CreatedOn", value);
			}
		}

		/// <exclude/>
		public Guid CreatedById {
			get {
				return GetTypedColumnValue<Guid>("CreatedById");
			}
			set {
				SetColumnValue("CreatedById", value);
				_createdBy = null;
			}
		}

		/// <exclude/>
		public string CreatedByName {
			get {
				return GetTypedColumnValue<string>("CreatedByName");
			}
			set {
				SetColumnValue("CreatedByName", value);
				if (_createdBy != null) {
					_createdBy.Name = value;
				}
			}
		}

		private Contact _createdBy;
		/// <summary>
		/// Created by.
		/// </summary>
		public Contact CreatedBy {
			get {
				return _createdBy ??
					(_createdBy = new Contact(LookupColumnEntities.GetEntity("CreatedBy")));
			}
		}

		/// <summary>
		/// Modified on.
		/// </summary>
		public DateTime ModifiedOn {
			get {
				return GetTypedColumnValue<DateTime>("ModifiedOn");
			}
			set {
				SetColumnValue("ModifiedOn", value);
			}
		}

		/// <exclude/>
		public Guid ModifiedById {
			get {
				return GetTypedColumnValue<Guid>("ModifiedById");
			}
			set {
				SetColumnValue("ModifiedById", value);
				_modifiedBy = null;
			}
		}

		/// <exclude/>
		public string ModifiedByName {
			get {
				return GetTypedColumnValue<string>("ModifiedByName");
			}
			set {
				SetColumnValue("ModifiedByName", value);
				if (_modifiedBy != null) {
					_modifiedBy.Name = value;
				}
			}
		}

		private Contact _modifiedBy;
		/// <summary>
		/// Modified by.
		/// </summary>
		public Contact ModifiedBy {
			get {
				return _modifiedBy ??
					(_modifiedBy = new Contact(LookupColumnEntities.GetEntity("ModifiedBy")));
			}
		}

		/// <summary>
		/// Active processes.
		/// </summary>
		public int ProcessListeners {
			get {
				return GetTypedColumnValue<int>("ProcessListeners");
			}
			set {
				SetColumnValue("ProcessListeners", value);
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private OpportunityType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public OpportunityType Type {
			get {
				return _type ??
					(_type = new OpportunityType(LookupColumnEntities.GetEntity("Type")));
			}
		}

		/// <exclude/>
		public Guid StageId {
			get {
				return GetTypedColumnValue<Guid>("StageId");
			}
			set {
				SetColumnValue("StageId", value);
				_stage = null;
			}
		}

		/// <exclude/>
		public string StageName {
			get {
				return GetTypedColumnValue<string>("StageName");
			}
			set {
				SetColumnValue("StageName", value);
				if (_stage != null) {
					_stage.Name = value;
				}
			}
		}

		private OpportunityStage _stage;
		/// <summary>
		/// Stage.
		/// </summary>
		public OpportunityStage Stage {
			get {
				return _stage ??
					(_stage = new OpportunityStage(LookupColumnEntities.GetEntity("Stage")));
			}
		}

		/// <summary>
		/// Closed on.
		/// </summary>
		public DateTime DueDate {
			get {
				return GetTypedColumnValue<DateTime>("DueDate");
			}
			set {
				SetColumnValue("DueDate", value);
			}
		}

		/// <exclude/>
		public Guid CloseReasonId {
			get {
				return GetTypedColumnValue<Guid>("CloseReasonId");
			}
			set {
				SetColumnValue("CloseReasonId", value);
				_closeReason = null;
			}
		}

		/// <exclude/>
		public string CloseReasonName {
			get {
				return GetTypedColumnValue<string>("CloseReasonName");
			}
			set {
				SetColumnValue("CloseReasonName", value);
				if (_closeReason != null) {
					_closeReason.Name = value;
				}
			}
		}

		private OpportunityCloseReason _closeReason;
		/// <summary>
		/// Reason for closing.
		/// </summary>
		public OpportunityCloseReason CloseReason {
			get {
				return _closeReason ??
					(_closeReason = new OpportunityCloseReason(LookupColumnEntities.GetEntity("CloseReason")));
			}
		}

		/// <exclude/>
		public Guid OwnerId {
			get {
				return GetTypedColumnValue<Guid>("OwnerId");
			}
			set {
				SetColumnValue("OwnerId", value);
				_owner = null;
			}
		}

		/// <exclude/>
		public string OwnerName {
			get {
				return GetTypedColumnValue<string>("OwnerName");
			}
			set {
				SetColumnValue("OwnerName", value);
				if (_owner != null) {
					_owner.Name = value;
				}
			}
		}

		private Contact _owner;
		/// <summary>
		/// Owner.
		/// </summary>
		public Contact Owner {
			get {
				return _owner ??
					(_owner = new Contact(LookupColumnEntities.GetEntity("Owner")));
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
			}
		}

		/// <exclude/>
		public Guid AccountId {
			get {
				return GetTypedColumnValue<Guid>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
				_account = null;
			}
		}

		/// <exclude/>
		public string AccountName {
			get {
				return GetTypedColumnValue<string>("AccountName");
			}
			set {
				SetColumnValue("AccountName", value);
				if (_account != null) {
					_account.Name = value;
				}
			}
		}

		private Account _account;
		/// <summary>
		/// Account.
		/// </summary>
		public Account Account {
			get {
				return _account ??
					(_account = new Account(LookupColumnEntities.GetEntity("Account")));
			}
		}

		/// <exclude/>
		public Guid CategoryId {
			get {
				return GetTypedColumnValue<Guid>("CategoryId");
			}
			set {
				SetColumnValue("CategoryId", value);
				_category = null;
			}
		}

		/// <exclude/>
		public string CategoryName {
			get {
				return GetTypedColumnValue<string>("CategoryName");
			}
			set {
				SetColumnValue("CategoryName", value);
				if (_category != null) {
					_category.Name = value;
				}
			}
		}

		private OpportunityCategory _category;
		/// <summary>
		/// Category.
		/// </summary>
		public OpportunityCategory Category {
			get {
				return _category ??
					(_category = new OpportunityCategory(LookupColumnEntities.GetEntity("Category")));
			}
		}

		/// <exclude/>
		public Guid MoodId {
			get {
				return GetTypedColumnValue<Guid>("MoodId");
			}
			set {
				SetColumnValue("MoodId", value);
				_mood = null;
			}
		}

		/// <exclude/>
		public string MoodName {
			get {
				return GetTypedColumnValue<string>("MoodName");
			}
			set {
				SetColumnValue("MoodName", value);
				if (_mood != null) {
					_mood.Name = value;
				}
			}
		}

		private OpportunityMood _mood;
		/// <summary>
		/// Mood.
		/// </summary>
		public OpportunityMood Mood {
			get {
				return _mood ??
					(_mood = new OpportunityMood(LookupColumnEntities.GetEntity("Mood")));
			}
		}

		/// <summary>
		/// New customer.
		/// </summary>
		public bool IsPrimary {
			get {
				return GetTypedColumnValue<bool>("IsPrimary");
			}
			set {
				SetColumnValue("IsPrimary", value);
			}
		}

		/// <exclude/>
		public Guid PartnerId {
			get {
				return GetTypedColumnValue<Guid>("PartnerId");
			}
			set {
				SetColumnValue("PartnerId", value);
				_partner = null;
			}
		}

		/// <exclude/>
		public string PartnerName {
			get {
				return GetTypedColumnValue<string>("PartnerName");
			}
			set {
				SetColumnValue("PartnerName", value);
				if (_partner != null) {
					_partner.Name = value;
				}
			}
		}

		private Account _partner;
		/// <summary>
		/// Partner.
		/// </summary>
		public Account Partner {
			get {
				return _partner ??
					(_partner = new Account(LookupColumnEntities.GetEntity("Partner")));
			}
		}

		/// <summary>
		/// Budget.
		/// </summary>
		public Decimal Budget {
			get {
				return GetTypedColumnValue<Decimal>("Budget");
			}
			set {
				SetColumnValue("Budget", value);
			}
		}

		/// <summary>
		/// Probability, %.
		/// </summary>
		public int Probability {
			get {
				return GetTypedColumnValue<int>("Probability");
			}
			set {
				SetColumnValue("Probability", value);
			}
		}

		/// <summary>
		/// Opportunity amount.
		/// </summary>
		public Decimal Amount {
			get {
				return GetTypedColumnValue<Decimal>("Amount");
			}
			set {
				SetColumnValue("Amount", value);
			}
		}

		/// <exclude/>
		public Guid SourceId {
			get {
				return GetTypedColumnValue<Guid>("SourceId");
			}
			set {
				SetColumnValue("SourceId", value);
				_source = null;
			}
		}

		/// <exclude/>
		public string SourceName {
			get {
				return GetTypedColumnValue<string>("SourceName");
			}
			set {
				SetColumnValue("SourceName", value);
				if (_source != null) {
					_source.Name = value;
				}
			}
		}

		private OpportunitySource _source;
		/// <summary>
		/// Source.
		/// </summary>
		public OpportunitySource Source {
			get {
				return _source ??
					(_source = new OpportunitySource(LookupColumnEntities.GetEntity("Source")));
			}
		}

		/// <exclude/>
		public Guid ResponsibleDepartmentId {
			get {
				return GetTypedColumnValue<Guid>("ResponsibleDepartmentId");
			}
			set {
				SetColumnValue("ResponsibleDepartmentId", value);
				_responsibleDepartment = null;
			}
		}

		/// <exclude/>
		public string ResponsibleDepartmentName {
			get {
				return GetTypedColumnValue<string>("ResponsibleDepartmentName");
			}
			set {
				SetColumnValue("ResponsibleDepartmentName", value);
				if (_responsibleDepartment != null) {
					_responsibleDepartment.Name = value;
				}
			}
		}

		private OpportunityDepartment _responsibleDepartment;
		/// <summary>
		/// Division.
		/// </summary>
		public OpportunityDepartment ResponsibleDepartment {
			get {
				return _responsibleDepartment ??
					(_responsibleDepartment = new OpportunityDepartment(LookupColumnEntities.GetEntity("ResponsibleDepartment")));
			}
		}

		/// <summary>
		/// Our weaknesses.
		/// </summary>
		public string Weaknesses {
			get {
				return GetTypedColumnValue<string>("Weaknesses");
			}
			set {
				SetColumnValue("Weaknesses", value);
			}
		}

		/// <summary>
		/// Our strengths.
		/// </summary>
		public string Strength {
			get {
				return GetTypedColumnValue<string>("Strength");
			}
			set {
				SetColumnValue("Strength", value);
			}
		}

		/// <summary>
		/// Sales tactics.
		/// </summary>
		public string Tactic {
			get {
				return GetTypedColumnValue<string>("Tactic");
			}
			set {
				SetColumnValue("Tactic", value);
			}
		}

		/// <summary>
		/// Verified on.
		/// </summary>
		public DateTime CheckDate {
			get {
				return GetTypedColumnValue<DateTime>("CheckDate");
			}
			set {
				SetColumnValue("CheckDate", value);
			}
		}

		/// <summary>
		/// Process Id.
		/// </summary>
		public Guid ProcessId {
			get {
				return GetTypedColumnValue<Guid>("ProcessId");
			}
			set {
				SetColumnValue("ProcessId", value);
			}
		}

		/// <exclude/>
		public Guid WinnerId {
			get {
				return GetTypedColumnValue<Guid>("WinnerId");
			}
			set {
				SetColumnValue("WinnerId", value);
				_winner = null;
			}
		}

		/// <exclude/>
		public string WinnerName {
			get {
				return GetTypedColumnValue<string>("WinnerName");
			}
			set {
				SetColumnValue("WinnerName", value);
				if (_winner != null) {
					_winner.Name = value;
				}
			}
		}

		private Account _winner;
		/// <summary>
		/// Winner.
		/// </summary>
		public Account Winner {
			get {
				return _winner ??
					(_winner = new Account(LookupColumnEntities.GetEntity("Winner")));
			}
		}

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = new Contact(LookupColumnEntities.GetEntity("Contact")));
			}
		}

		/// <summary>
		/// Completeness.
		/// </summary>
		public int Completeness {
			get {
				return GetTypedColumnValue<int>("Completeness");
			}
			set {
				SetColumnValue("Completeness", value);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		/// <exclude/>
		public Guid LeadTypeId {
			get {
				return GetTypedColumnValue<Guid>("LeadTypeId");
			}
			set {
				SetColumnValue("LeadTypeId", value);
				_leadType = null;
			}
		}

		/// <exclude/>
		public string LeadTypeName {
			get {
				return GetTypedColumnValue<string>("LeadTypeName");
			}
			set {
				SetColumnValue("LeadTypeName", value);
				if (_leadType != null) {
					_leadType.Name = value;
				}
			}
		}

		private LeadType _leadType;
		/// <summary>
		/// Customer need.
		/// </summary>
		public LeadType LeadType {
			get {
				return _leadType ??
					(_leadType = new LeadType(LookupColumnEntities.GetEntity("LeadType")));
			}
		}

		/// <summary>
		/// Predictive probability.
		/// </summary>
		public int PredictiveProbability {
			get {
				return GetTypedColumnValue<int>("PredictiveProbability");
			}
			set {
				SetColumnValue("PredictiveProbability", value);
			}
		}

		/// <summary>
		/// Manager's mood value.
		/// </summary>
		public int MoodValue {
			get {
				return GetTypedColumnValue<int>("MoodValue");
			}
			set {
				SetColumnValue("MoodValue", value);
			}
		}

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
					(_group = new SysAdminUnit(LookupColumnEntities.GetEntity("Group")));
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
					(_decisionMaker = new Contact(LookupColumnEntities.GetEntity("DecisionMaker")));
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

		/// <summary>
		/// By process.
		/// </summary>
		public bool ByProcess {
			get {
				return GetTypedColumnValue<bool>("ByProcess");
			}
			set {
				SetColumnValue("ByProcess", value);
			}
		}

		#endregion

	}

	#endregion

}

