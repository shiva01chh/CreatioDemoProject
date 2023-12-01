namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MktgActivity

	/// <exclude/>
	public class MktgActivity : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public MktgActivity(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MktgActivity";
		}

		public MktgActivity(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "MktgActivity";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<MktgActivityFile> MktgActivityFileCollectionByMktgActivity {
			get;
			set;
		}

		public IEnumerable<MktgActivityInFolder> MktgActivityInFolderCollectionByMktgActivity {
			get;
			set;
		}

		public IEnumerable<MktgActivityInTag> MktgActivityInTagCollectionByEntity {
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
		/// Title.
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
		public Guid ChannelId {
			get {
				return GetTypedColumnValue<Guid>("ChannelId");
			}
			set {
				SetColumnValue("ChannelId", value);
				_channel = null;
			}
		}

		/// <exclude/>
		public string ChannelName {
			get {
				return GetTypedColumnValue<string>("ChannelName");
			}
			set {
				SetColumnValue("ChannelName", value);
				if (_channel != null) {
					_channel.Name = value;
				}
			}
		}

		private LeadMedium _channel;
		/// <summary>
		/// Channel.
		/// </summary>
		public LeadMedium Channel {
			get {
				return _channel ??
					(_channel = new LeadMedium(LookupColumnEntities.GetEntity("Channel")));
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

		private MktgActivityStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public MktgActivityStatus Status {
			get {
				return _status ??
					(_status = new MktgActivityStatus(LookupColumnEntities.GetEntity("Status")));
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
		/// Planned budget.
		/// </summary>
		public Decimal PlannedBudget {
			get {
				return GetTypedColumnValue<Decimal>("PlannedBudget");
			}
			set {
				SetColumnValue("PlannedBudget", value);
			}
		}

		/// <summary>
		/// Actual budget.
		/// </summary>
		public Decimal SpentBudget {
			get {
				return GetTypedColumnValue<Decimal>("SpentBudget");
			}
			set {
				SetColumnValue("SpentBudget", value);
			}
		}

		/// <summary>
		/// Start date.
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
		/// Due date.
		/// </summary>
		public DateTime DueDate {
			get {
				return GetTypedColumnValue<DateTime>("DueDate");
			}
			set {
				SetColumnValue("DueDate", value);
			}
		}

		/// <summary>
		/// Planned budget, base currency.
		/// </summary>
		public Decimal PrimaryPlannedBudget {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryPlannedBudget");
			}
			set {
				SetColumnValue("PrimaryPlannedBudget", value);
			}
		}

		/// <summary>
		/// Actual budget, base currency.
		/// </summary>
		public Decimal PrimarySpentBudget {
			get {
				return GetTypedColumnValue<Decimal>("PrimarySpentBudget");
			}
			set {
				SetColumnValue("PrimarySpentBudget", value);
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
		public Guid CurrencyId {
			get {
				return GetTypedColumnValue<Guid>("CurrencyId");
			}
			set {
				SetColumnValue("CurrencyId", value);
				_currency = null;
			}
		}

		/// <exclude/>
		public string CurrencyName {
			get {
				return GetTypedColumnValue<string>("CurrencyName");
			}
			set {
				SetColumnValue("CurrencyName", value);
				if (_currency != null) {
					_currency.Name = value;
				}
			}
		}

		private Currency _currency;
		/// <summary>
		/// Currency.
		/// </summary>
		public Currency Currency {
			get {
				return _currency ??
					(_currency = new Currency(LookupColumnEntities.GetEntity("Currency")));
			}
		}

		/// <summary>
		/// Exchange rate.
		/// </summary>
		public Decimal CurrencyRate {
			get {
				return GetTypedColumnValue<Decimal>("CurrencyRate");
			}
			set {
				SetColumnValue("CurrencyRate", value);
			}
		}

		/// <exclude/>
		public Guid CampaignPlannerId {
			get {
				return GetTypedColumnValue<Guid>("CampaignPlannerId");
			}
			set {
				SetColumnValue("CampaignPlannerId", value);
				_campaignPlanner = null;
			}
		}

		/// <exclude/>
		public string CampaignPlannerName {
			get {
				return GetTypedColumnValue<string>("CampaignPlannerName");
			}
			set {
				SetColumnValue("CampaignPlannerName", value);
				if (_campaignPlanner != null) {
					_campaignPlanner.Name = value;
				}
			}
		}

		private CampaignPlanner _campaignPlanner;
		/// <summary>
		/// Marketing plan.
		/// </summary>
		public CampaignPlanner CampaignPlanner {
			get {
				return _campaignPlanner ??
					(_campaignPlanner = new CampaignPlanner(LookupColumnEntities.GetEntity("CampaignPlanner")));
			}
		}

		/// <exclude/>
		public Guid FundId {
			get {
				return GetTypedColumnValue<Guid>("FundId");
			}
			set {
				SetColumnValue("FundId", value);
				_fund = null;
			}
		}

		/// <exclude/>
		public string FundName {
			get {
				return GetTypedColumnValue<string>("FundName");
			}
			set {
				SetColumnValue("FundName", value);
				if (_fund != null) {
					_fund.Name = value;
				}
			}
		}

		private Fund _fund;
		/// <summary>
		/// Fund.
		/// </summary>
		public Fund Fund {
			get {
				return _fund ??
					(_fund = new Fund(LookupColumnEntities.GetEntity("Fund")));
			}
		}

		/// <summary>
		/// Url.
		/// </summary>
		public string Url {
			get {
				return GetTypedColumnValue<string>("Url");
			}
			set {
				SetColumnValue("Url", value);
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
		public Guid PartnershipId {
			get {
				return GetTypedColumnValue<Guid>("PartnershipId");
			}
			set {
				SetColumnValue("PartnershipId", value);
				_partnership = null;
			}
		}

		/// <exclude/>
		public string PartnershipName {
			get {
				return GetTypedColumnValue<string>("PartnershipName");
			}
			set {
				SetColumnValue("PartnershipName", value);
				if (_partnership != null) {
					_partnership.Name = value;
				}
			}
		}

		private Partnership _partnership;
		/// <summary>
		/// Partnership.
		/// </summary>
		public Partnership Partnership {
			get {
				return _partnership ??
					(_partnership = new Partnership(LookupColumnEntities.GetEntity("Partnership")));
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
		/// Partner.
		/// </summary>
		public Account Account {
			get {
				return _account ??
					(_account = new Account(LookupColumnEntities.GetEntity("Account")));
			}
		}

		/// <exclude/>
		public Guid MktgActivityTypeId {
			get {
				return GetTypedColumnValue<Guid>("MktgActivityTypeId");
			}
			set {
				SetColumnValue("MktgActivityTypeId", value);
				_mktgActivityType = null;
			}
		}

		/// <exclude/>
		public string MktgActivityTypeName {
			get {
				return GetTypedColumnValue<string>("MktgActivityTypeName");
			}
			set {
				SetColumnValue("MktgActivityTypeName", value);
				if (_mktgActivityType != null) {
					_mktgActivityType.Name = value;
				}
			}
		}

		private MktgActivityType _mktgActivityType;
		/// <summary>
		/// Type.
		/// </summary>
		public MktgActivityType MktgActivityType {
			get {
				return _mktgActivityType ??
					(_mktgActivityType = new MktgActivityType(LookupColumnEntities.GetEntity("MktgActivityType")));
			}
		}

		#endregion

	}

	#endregion

}

