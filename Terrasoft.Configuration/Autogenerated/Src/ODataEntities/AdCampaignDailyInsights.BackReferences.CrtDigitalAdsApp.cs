namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AdCampaignDailyInsights

	/// <exclude/>
	public class AdCampaignDailyInsights : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public AdCampaignDailyInsights(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AdCampaignDailyInsights";
		}

		public AdCampaignDailyInsights(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "AdCampaignDailyInsights";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

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
		/// Reach.
		/// </summary>
		/// <remarks>
		/// The total number of people who see your content. Calculated by the formula: Impressions ÷ Frequency.
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

		/// <exclude/>
		public Guid AdCampaignId {
			get {
				return GetTypedColumnValue<Guid>("AdCampaignId");
			}
			set {
				SetColumnValue("AdCampaignId", value);
				_adCampaign = null;
			}
		}

		/// <exclude/>
		public string AdCampaignCampaignName {
			get {
				return GetTypedColumnValue<string>("AdCampaignCampaignName");
			}
			set {
				SetColumnValue("AdCampaignCampaignName", value);
				if (_adCampaign != null) {
					_adCampaign.CampaignName = value;
				}
			}
		}

		private AdCampaign _adCampaign;
		/// <summary>
		/// Ad campaign.
		/// </summary>
		/// <remarks>
		/// The unique code of the ad campaign connected with daily insights.
		/// </remarks>
		public AdCampaign AdCampaign {
			get {
				return _adCampaign ??
					(_adCampaign = new AdCampaign(LookupColumnEntities.GetEntity("AdCampaign")));
			}
		}

		/// <summary>
		/// Frequency.
		/// </summary>
		/// <remarks>
		/// The number of times a user sees ads in your campaign over a given time period. Calculated by the formula: Impressions ÷ Reach.
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
		/// The percentage of times that people saw your ad and performed a click. Calculated by the formula: (Clicks ÷ Impressions) × 100.
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
		/// Data range date.
		/// </summary>
		/// <remarks>
		/// The date when the daily data was created.
		/// </remarks>
		public DateTime DataRangeDate {
			get {
				return GetTypedColumnValue<DateTime>("DataRangeDate");
			}
			set {
				SetColumnValue("DataRangeDate", value);
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

	}

	#endregion

}

