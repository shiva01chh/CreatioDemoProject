namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CaseNotificationRule

	/// <exclude/>
	public class CaseNotificationRule : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public CaseNotificationRule(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CaseNotificationRule";
		}

		public CaseNotificationRule(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "CaseNotificationRule";
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
		public Guid CaseStatusId {
			get {
				return GetTypedColumnValue<Guid>("CaseStatusId");
			}
			set {
				SetColumnValue("CaseStatusId", value);
				_caseStatus = null;
			}
		}

		/// <exclude/>
		public string CaseStatusName {
			get {
				return GetTypedColumnValue<string>("CaseStatusName");
			}
			set {
				SetColumnValue("CaseStatusName", value);
				if (_caseStatus != null) {
					_caseStatus.Name = value;
				}
			}
		}

		private CaseStatus _caseStatus;
		/// <summary>
		/// Case status.
		/// </summary>
		public CaseStatus CaseStatus {
			get {
				return _caseStatus ??
					(_caseStatus = new CaseStatus(LookupColumnEntities.GetEntity("CaseStatus")));
			}
		}

		/// <exclude/>
		public Guid CaseCategoryId {
			get {
				return GetTypedColumnValue<Guid>("CaseCategoryId");
			}
			set {
				SetColumnValue("CaseCategoryId", value);
				_caseCategory = null;
			}
		}

		/// <exclude/>
		public string CaseCategoryName {
			get {
				return GetTypedColumnValue<string>("CaseCategoryName");
			}
			set {
				SetColumnValue("CaseCategoryName", value);
				if (_caseCategory != null) {
					_caseCategory.Name = value;
				}
			}
		}

		private CaseCategory _caseCategory;
		/// <summary>
		/// Case category.
		/// </summary>
		public CaseCategory CaseCategory {
			get {
				return _caseCategory ??
					(_caseCategory = new CaseCategory(LookupColumnEntities.GetEntity("CaseCategory")));
			}
		}

		/// <exclude/>
		public Guid EmailTemplateId {
			get {
				return GetTypedColumnValue<Guid>("EmailTemplateId");
			}
			set {
				SetColumnValue("EmailTemplateId", value);
				_emailTemplate = null;
			}
		}

		/// <exclude/>
		public string EmailTemplateName {
			get {
				return GetTypedColumnValue<string>("EmailTemplateName");
			}
			set {
				SetColumnValue("EmailTemplateName", value);
				if (_emailTemplate != null) {
					_emailTemplate.Name = value;
				}
			}
		}

		private EmailTemplate _emailTemplate;
		/// <summary>
		/// Email message template.
		/// </summary>
		public EmailTemplate EmailTemplate {
			get {
				return _emailTemplate ??
					(_emailTemplate = new EmailTemplate(LookupColumnEntities.GetEntity("EmailTemplate")));
			}
		}

		/// <exclude/>
		public Guid RuleUsageId {
			get {
				return GetTypedColumnValue<Guid>("RuleUsageId");
			}
			set {
				SetColumnValue("RuleUsageId", value);
				_ruleUsage = null;
			}
		}

		/// <exclude/>
		public string RuleUsageName {
			get {
				return GetTypedColumnValue<string>("RuleUsageName");
			}
			set {
				SetColumnValue("RuleUsageName", value);
				if (_ruleUsage != null) {
					_ruleUsage.Name = value;
				}
			}
		}

		private NotificationRuleUsage _ruleUsage;
		/// <summary>
		/// Usage rule.
		/// </summary>
		public NotificationRuleUsage RuleUsage {
			get {
				return _ruleUsage ??
					(_ruleUsage = new NotificationRuleUsage(LookupColumnEntities.GetEntity("RuleUsage")));
			}
		}

		/// <summary>
		/// Sending delay, minutes.
		/// </summary>
		public int Delay {
			get {
				return GetTypedColumnValue<int>("Delay");
			}
			set {
				SetColumnValue("Delay", value);
			}
		}

		/// <summary>
		/// Quote original email.
		/// </summary>
		public bool IsQuoteOriginalEmail {
			get {
				return GetTypedColumnValue<bool>("IsQuoteOriginalEmail");
			}
			set {
				SetColumnValue("IsQuoteOriginalEmail", value);
			}
		}

		#endregion

	}

	#endregion

}

