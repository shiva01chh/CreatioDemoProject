namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AdCampaign

	/// <exclude/>
	public class AdCampaign : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public AdCampaign(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AdCampaign";
		}

		public AdCampaign(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "AdCampaign";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AdCampaignDailyInsights> AdCampaignDailyInsightsCollectionByAdCampaign {
			get;
			set;
		}

		public IEnumerable<Contact> ContactCollectionByAdCampaign {
			get;
			set;
		}

		public IEnumerable<FormSubmit> FormSubmitCollectionByAdCampaign {
			get;
			set;
		}

		/// <summary>
		/// Id.
		/// </summary>
		/// <remarks>
		/// The unique code of the record in Creatio database.
		/// </remarks>
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
		/// Campaign name.
		/// </summary>
		/// <remarks>
		/// The name of the ad campaign.
		/// </remarks>
		public string CampaignName {
			get {
				return GetTypedColumnValue<string>("CampaignName");
			}
			set {
				SetColumnValue("CampaignName", value);
			}
		}

		/// <exclude/>
		public Guid PlatformId {
			get {
				return GetTypedColumnValue<Guid>("PlatformId");
			}
			set {
				SetColumnValue("PlatformId", value);
				_platform = null;
			}
		}

		/// <exclude/>
		public string PlatformName {
			get {
				return GetTypedColumnValue<string>("PlatformName");
			}
			set {
				SetColumnValue("PlatformName", value);
				if (_platform != null) {
					_platform.Name = value;
				}
			}
		}

		private AdPlatform _platform;
		/// <summary>
		/// Platform.
		/// </summary>
		/// <remarks>
		/// The ad platform name.
		/// </remarks>
		public AdPlatform Platform {
			get {
				return _platform ??
					(_platform = new AdPlatform(LookupColumnEntities.GetEntity("Platform")));
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

		private AdCampaignStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		/// <remarks>
		/// The current status of your campaign.
		/// </remarks>
		public AdCampaignStatus Status {
			get {
				return _status ??
					(_status = new AdCampaignStatus(LookupColumnEntities.GetEntity("Status")));
			}
		}

		/// <summary>
		/// Reach.
		/// </summary>
		/// <remarks>
		/// The total number of people who see your content. Calculated by the formula:  Impressions ÷ Frequency.
		/// </remarks>
		public int Reach {
			get {
				return GetTypedColumnValue<int>("Reach");
			}
			set {
				SetColumnValue("Reach", value);
			}
		}

		/// <summary>
		/// Impressions.
		/// </summary>
		/// <remarks>
		/// The number of times your content is displayed.
		/// </remarks>
		public int Impressions {
			get {
				return GetTypedColumnValue<int>("Impressions");
			}
			set {
				SetColumnValue("Impressions", value);
			}
		}

		/// <summary>
		/// Campaign Id.
		/// </summary>
		/// <remarks>
		/// The unique code of the campaign generated by the ad platform.
		/// </remarks>
		public string AdCampaignId {
			get {
				return GetTypedColumnValue<string>("AdCampaignId");
			}
			set {
				SetColumnValue("AdCampaignId", value);
			}
		}

		/// <summary>
		/// Frequency.
		/// </summary>
		/// <remarks>
		/// The number of times a user sees ads in your campaign over a given time period. Calculated by the formula:  Impressions ÷ Reach.
		/// </remarks>
		public Decimal Frequency {
			get {
				return GetTypedColumnValue<Decimal>("Frequency");
			}
			set {
				SetColumnValue("Frequency", value);
			}
		}

		/// <summary>
		/// Clickthrough rate.
		/// </summary>
		/// <remarks>
		/// The percentage of times that people saw your ad and performed a click. Calculated by the formula: (Clicks ÷  Impressions) × 100.
		/// </remarks>
		public Decimal CTR {
			get {
				return GetTypedColumnValue<Decimal>("CTR");
			}
			set {
				SetColumnValue("CTR", value);
			}
		}

		/// <summary>
		/// End date.
		/// </summary>
		/// <remarks>
		/// The date when the campaign was ended.
		/// </remarks>
		public DateTime EndDate {
			get {
				return GetTypedColumnValue<DateTime>("EndDate");
			}
			set {
				SetColumnValue("EndDate", value);
			}
		}

		/// <summary>
		/// Start date.
		/// </summary>
		/// <remarks>
		/// The date when the campaign was started.
		/// </remarks>
		public DateTime StartDate {
			get {
				return GetTypedColumnValue<DateTime>("StartDate");
			}
			set {
				SetColumnValue("StartDate", value);
			}
		}

		/// <summary>
		/// Created date.
		/// </summary>
		/// <remarks>
		/// The date when the campaign was created.
		/// </remarks>
		public DateTime CreatedDate {
			get {
				return GetTypedColumnValue<DateTime>("CreatedDate");
			}
			set {
				SetColumnValue("CreatedDate", value);
			}
		}

		/// <summary>
		/// Cost per mille.
		/// </summary>
		/// <remarks>
		/// The cost for 1,000 impressions. Calculated by the formula: (Amount spent ÷ Impressions) × 1000.
		/// </remarks>
		public Decimal CPM {
			get {
				return GetTypedColumnValue<Decimal>("CPM");
			}
			set {
				SetColumnValue("CPM", value);
			}
		}

		/// <summary>
		/// Cost per click.
		/// </summary>
		/// <remarks>
		/// The cost for each click. Calculated by the formula: Amount spent ÷ Clicks.
		/// </remarks>
		public Decimal CPC {
			get {
				return GetTypedColumnValue<Decimal>("CPC");
			}
			set {
				SetColumnValue("CPC", value);
			}
		}

		/// <summary>
		/// Clicks.
		/// </summary>
		/// <remarks>
		/// The amount of clicks on your ads.
		/// </remarks>
		public int Clicks {
			get {
				return GetTypedColumnValue<int>("Clicks");
			}
			set {
				SetColumnValue("Clicks", value);
			}
		}

		/// <summary>
		/// Amount spent.
		/// </summary>
		/// <remarks>
		/// The estimated total amount of money you've spent on your campaign.
		/// </remarks>
		public Decimal AmountSpent {
			get {
				return GetTypedColumnValue<Decimal>("AmountSpent");
			}
			set {
				SetColumnValue("AmountSpent", value);
			}
		}

		/// <exclude/>
		public Guid AdAccountId {
			get {
				return GetTypedColumnValue<Guid>("AdAccountId");
			}
			set {
				SetColumnValue("AdAccountId", value);
				_adAccount = null;
			}
		}

		/// <exclude/>
		public string AdAccountName {
			get {
				return GetTypedColumnValue<string>("AdAccountName");
			}
			set {
				SetColumnValue("AdAccountName", value);
				if (_adAccount != null) {
					_adAccount.Name = value;
				}
			}
		}

		private AdAccount _adAccount;
		/// <summary>
		/// Ad account.
		/// </summary>
		/// <remarks>
		/// The ad account.
		/// </remarks>
		public AdAccount AdAccount {
			get {
				return _adAccount ??
					(_adAccount = new AdAccount(LookupColumnEntities.GetEntity("AdAccount")));
			}
		}

		/// <summary>
		/// Amount spent, base currency.
		/// </summary>
		/// <remarks>
		/// The estimated total amount of money you've spent on your campaign in the base currency.
		/// </remarks>
		public Decimal PrimaryAmountSpent {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryAmountSpent");
			}
			set {
				SetColumnValue("PrimaryAmountSpent", value);
			}
		}

		/// <summary>
		/// Currency.
		/// </summary>
		/// <remarks>
		/// Current currency from each Ad account.
		/// </remarks>
		public string AdAccountCurrency {
			get {
				return GetTypedColumnValue<string>("AdAccountCurrency");
			}
			set {
				SetColumnValue("AdAccountCurrency", value);
			}
		}

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

	}

	#endregion

}

