namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Project

	/// <exclude/>
	public class Project : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public Project(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Project";
		}

		public Project(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "Project";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByProject {
			get;
			set;
		}

		public IEnumerable<Cashflow> CashflowCollectionByProject {
			get;
			set;
		}

		public IEnumerable<Document> DocumentCollectionByProject {
			get;
			set;
		}

		public IEnumerable<Invoice> InvoiceCollectionByProject {
			get;
			set;
		}

		public IEnumerable<Project> ProjectCollectionByParentProject {
			get;
			set;
		}

		public IEnumerable<ProjectFile> ProjectFileCollectionByProject {
			get;
			set;
		}

		public IEnumerable<ProjectInFolder> ProjectInFolderCollectionByProject {
			get;
			set;
		}

		public IEnumerable<ProjectInTag> ProjectInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<ProjectPlanHistoryItem> ProjectPlanHistoryItemCollectionByProject {
			get;
			set;
		}

		public IEnumerable<ProjectProduct> ProjectProductCollectionByProject {
			get;
			set;
		}

		public IEnumerable<ProjectResourceElement> ProjectResourceElementCollectionByProject {
			get;
			set;
		}

		public IEnumerable<VwProjectHierarchy> VwProjectHierarchyCollectionByBaseProject {
			get;
			set;
		}

		public IEnumerable<VwProjectHierarchy> VwProjectHierarchyCollectionByProject {
			get;
			set;
		}

		public IEnumerable<VwProjectProduct> VwProjectProductCollectionByProject {
			get;
			set;
		}

		public IEnumerable<WorkResourceElement> WorkResourceElementCollectionByProject {
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

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
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

		/// <exclude/>
		public Guid ProjectEntryTypeId {
			get {
				return GetTypedColumnValue<Guid>("ProjectEntryTypeId");
			}
			set {
				SetColumnValue("ProjectEntryTypeId", value);
				_projectEntryType = null;
			}
		}

		/// <exclude/>
		public string ProjectEntryTypeName {
			get {
				return GetTypedColumnValue<string>("ProjectEntryTypeName");
			}
			set {
				SetColumnValue("ProjectEntryTypeName", value);
				if (_projectEntryType != null) {
					_projectEntryType.Name = value;
				}
			}
		}

		private ProjectEntryType _projectEntryType;
		/// <summary>
		/// Project record type.
		/// </summary>
		public ProjectEntryType ProjectEntryType {
			get {
				return _projectEntryType ??
					(_projectEntryType = new ProjectEntryType(LookupColumnEntities.GetEntity("ProjectEntryType")));
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

		private ProjectType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public ProjectType Type {
			get {
				return _type ??
					(_type = new ProjectType(LookupColumnEntities.GetEntity("Type")));
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

		/// <exclude/>
		public Guid StatusId {
			get {
				return GetTypedColumnValue<Guid>("StatusId");
			}
			set {
				SetColumnValue("StatusId", value);
				_status = null;
			}
		}

		/// <exclude/>
		public string StatusName {
			get {
				return GetTypedColumnValue<string>("StatusName");
			}
			set {
				SetColumnValue("StatusName", value);
				if (_status != null) {
					_status.Name = value;
				}
			}
		}

		private ProjectStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public ProjectStatus Status {
			get {
				return _status ??
					(_status = new ProjectStatus(LookupColumnEntities.GetEntity("Status")));
			}
		}

		/// <summary>
		/// Start.
		/// </summary>
		public DateTime StartDate {
			get {
				return GetTypedColumnValue<DateTime>("StartDate");
			}
			set {
				SetColumnValue("StartDate", value);
			}
		}

		/// <summary>
		/// End.
		/// </summary>
		public DateTime EndDate {
			get {
				return GetTypedColumnValue<DateTime>("EndDate");
			}
			set {
				SetColumnValue("EndDate", value);
			}
		}

		/// <summary>
		/// Duration.
		/// </summary>
		public int Duration {
			get {
				return GetTypedColumnValue<int>("Duration");
			}
			set {
				SetColumnValue("Duration", value);
			}
		}

		/// <summary>
		/// Deadline.
		/// </summary>
		public DateTime Deadline {
			get {
				return GetTypedColumnValue<DateTime>("Deadline");
			}
			set {
				SetColumnValue("Deadline", value);
			}
		}

		/// <exclude/>
		public Guid SupplierId {
			get {
				return GetTypedColumnValue<Guid>("SupplierId");
			}
			set {
				SetColumnValue("SupplierId", value);
				_supplier = null;
			}
		}

		/// <exclude/>
		public string SupplierName {
			get {
				return GetTypedColumnValue<string>("SupplierName");
			}
			set {
				SetColumnValue("SupplierName", value);
				if (_supplier != null) {
					_supplier.Name = value;
				}
			}
		}

		private Account _supplier;
		/// <summary>
		/// Supplier.
		/// </summary>
		public Account Supplier {
			get {
				return _supplier ??
					(_supplier = new Account(LookupColumnEntities.GetEntity("Supplier")));
			}
		}

		/// <exclude/>
		public Guid OpportunityId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityId");
			}
			set {
				SetColumnValue("OpportunityId", value);
				_opportunity = null;
			}
		}

		/// <exclude/>
		public string OpportunityTitle {
			get {
				return GetTypedColumnValue<string>("OpportunityTitle");
			}
			set {
				SetColumnValue("OpportunityTitle", value);
				if (_opportunity != null) {
					_opportunity.Title = value;
				}
			}
		}

		private Opportunity _opportunity;
		/// <summary>
		/// Opportunity.
		/// </summary>
		public Opportunity Opportunity {
			get {
				return _opportunity ??
					(_opportunity = new Opportunity(LookupColumnEntities.GetEntity("Opportunity")));
			}
		}

		/// <exclude/>
		public Guid ParentProjectId {
			get {
				return GetTypedColumnValue<Guid>("ParentProjectId");
			}
			set {
				SetColumnValue("ParentProjectId", value);
				_parentProject = null;
			}
		}

		/// <exclude/>
		public string ParentProjectName {
			get {
				return GetTypedColumnValue<string>("ParentProjectName");
			}
			set {
				SetColumnValue("ParentProjectName", value);
				if (_parentProject != null) {
					_parentProject.Name = value;
				}
			}
		}

		private Project _parentProject;
		/// <summary>
		/// Parent item.
		/// </summary>
		public Project ParentProject {
			get {
				return _parentProject ??
					(_parentProject = new Project(LookupColumnEntities.GetEntity("ParentProject")));
			}
		}

		/// <summary>
		/// Completion %.
		/// </summary>
		public Decimal ActualCompletion {
			get {
				return GetTypedColumnValue<Decimal>("ActualCompletion");
			}
			set {
				SetColumnValue("ActualCompletion", value);
			}
		}

		/// <summary>
		/// Calculate automatically.
		/// </summary>
		public bool IsAutoCalcCompletion {
			get {
				return GetTypedColumnValue<bool>("IsAutoCalcCompletion");
			}
			set {
				SetColumnValue("IsAutoCalcCompletion", value);
			}
		}

		/// <summary>
		/// Expected revenue.
		/// </summary>
		public Decimal PlanIncome {
			get {
				return GetTypedColumnValue<Decimal>("PlanIncome");
			}
			set {
				SetColumnValue("PlanIncome", value);
			}
		}

		/// <summary>
		/// Actual revenue.
		/// </summary>
		public Decimal FactIncome {
			get {
				return GetTypedColumnValue<Decimal>("FactIncome");
			}
			set {
				SetColumnValue("FactIncome", value);
			}
		}

		/// <summary>
		/// Revenue deviation.
		/// </summary>
		public Decimal IncomeDev {
			get {
				return GetTypedColumnValue<Decimal>("IncomeDev");
			}
			set {
				SetColumnValue("IncomeDev", value);
			}
		}

		/// <summary>
		/// Revenue deviation, %.
		/// </summary>
		public Decimal IncomeDevPerc {
			get {
				return GetTypedColumnValue<Decimal>("IncomeDevPerc");
			}
			set {
				SetColumnValue("IncomeDevPerc", value);
			}
		}

		/// <summary>
		/// Expected total cost.
		/// </summary>
		public Decimal PlanExternalCost {
			get {
				return GetTypedColumnValue<Decimal>("PlanExternalCost");
			}
			set {
				SetColumnValue("PlanExternalCost", value);
			}
		}

		/// <summary>
		/// Actual total cost.
		/// </summary>
		public Decimal FactExternalCost {
			get {
				return GetTypedColumnValue<Decimal>("FactExternalCost");
			}
			set {
				SetColumnValue("FactExternalCost", value);
			}
		}

		/// <summary>
		/// Total cost deviation.
		/// </summary>
		public Decimal ExternalCostDev {
			get {
				return GetTypedColumnValue<Decimal>("ExternalCostDev");
			}
			set {
				SetColumnValue("ExternalCostDev", value);
			}
		}

		/// <summary>
		/// Total cost deviation, %.
		/// </summary>
		public Decimal PlanExternalDevPerc {
			get {
				return GetTypedColumnValue<Decimal>("PlanExternalDevPerc");
			}
			set {
				SetColumnValue("PlanExternalDevPerc", value);
			}
		}

		/// <summary>
		/// Expected direct expense.
		/// </summary>
		public Decimal PlanExpense {
			get {
				return GetTypedColumnValue<Decimal>("PlanExpense");
			}
			set {
				SetColumnValue("PlanExpense", value);
			}
		}

		/// <summary>
		/// Actual direct expense.
		/// </summary>
		public Decimal FactExpense {
			get {
				return GetTypedColumnValue<Decimal>("FactExpense");
			}
			set {
				SetColumnValue("FactExpense", value);
			}
		}

		/// <summary>
		/// Direct expenses deviation.
		/// </summary>
		public Decimal ExpenseDev {
			get {
				return GetTypedColumnValue<Decimal>("ExpenseDev");
			}
			set {
				SetColumnValue("ExpenseDev", value);
			}
		}

		/// <summary>
		/// Direct expenses deviation, %.
		/// </summary>
		public Decimal ExpenseDevPerc {
			get {
				return GetTypedColumnValue<Decimal>("ExpenseDevPerc");
			}
			set {
				SetColumnValue("ExpenseDevPerc", value);
			}
		}

		/// <summary>
		/// Expected prime cost.
		/// </summary>
		public Decimal PlanInternalCost {
			get {
				return GetTypedColumnValue<Decimal>("PlanInternalCost");
			}
			set {
				SetColumnValue("PlanInternalCost", value);
			}
		}

		/// <summary>
		/// Actual prime cost.
		/// </summary>
		public Decimal FactInternalCost {
			get {
				return GetTypedColumnValue<Decimal>("FactInternalCost");
			}
			set {
				SetColumnValue("FactInternalCost", value);
			}
		}

		/// <summary>
		/// Prime cost deviation.
		/// </summary>
		public Decimal InternalCostDev {
			get {
				return GetTypedColumnValue<Decimal>("InternalCostDev");
			}
			set {
				SetColumnValue("InternalCostDev", value);
			}
		}

		/// <summary>
		/// Prime cost deviation, %.
		/// </summary>
		public Decimal PlanInternalDevPerc {
			get {
				return GetTypedColumnValue<Decimal>("PlanInternalDevPerc");
			}
			set {
				SetColumnValue("PlanInternalDevPerc", value);
			}
		}

		/// <summary>
		/// Expected margin.
		/// </summary>
		public Decimal PlanMargin {
			get {
				return GetTypedColumnValue<Decimal>("PlanMargin");
			}
			set {
				SetColumnValue("PlanMargin", value);
			}
		}

		/// <summary>
		/// Expected margin, %.
		/// </summary>
		public Decimal PlanMarginPerc {
			get {
				return GetTypedColumnValue<Decimal>("PlanMarginPerc");
			}
			set {
				SetColumnValue("PlanMarginPerc", value);
			}
		}

		/// <summary>
		/// Actual margin.
		/// </summary>
		public Decimal FactMargin {
			get {
				return GetTypedColumnValue<Decimal>("FactMargin");
			}
			set {
				SetColumnValue("FactMargin", value);
			}
		}

		/// <summary>
		/// Actual margin, %.
		/// </summary>
		public Decimal FactMarginPerc {
			get {
				return GetTypedColumnValue<Decimal>("FactMarginPerc");
			}
			set {
				SetColumnValue("FactMarginPerc", value);
			}
		}

		/// <summary>
		/// Margin deviation.
		/// </summary>
		public Decimal MarginDev {
			get {
				return GetTypedColumnValue<Decimal>("MarginDev");
			}
			set {
				SetColumnValue("MarginDev", value);
			}
		}

		/// <summary>
		/// Margin deviation, %.
		/// </summary>
		public Decimal MarginDevPerc {
			get {
				return GetTypedColumnValue<Decimal>("MarginDevPerc");
			}
			set {
				SetColumnValue("MarginDevPerc", value);
			}
		}

		/// <summary>
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		#endregion

	}

	#endregion

}

