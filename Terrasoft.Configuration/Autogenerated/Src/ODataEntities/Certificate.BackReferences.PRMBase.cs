﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Certificate

	/// <exclude/>
	public class Certificate : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public Certificate(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Certificate";
		}

		public Certificate(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "Certificate";
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
		public Guid EducationActivityId {
			get {
				return GetTypedColumnValue<Guid>("EducationActivityId");
			}
			set {
				SetColumnValue("EducationActivityId", value);
				_educationActivity = null;
			}
		}

		/// <exclude/>
		public string EducationActivityName {
			get {
				return GetTypedColumnValue<string>("EducationActivityName");
			}
			set {
				SetColumnValue("EducationActivityName", value);
				if (_educationActivity != null) {
					_educationActivity.Name = value;
				}
			}
		}

		private EducationActivity _educationActivity;
		/// <summary>
		/// Education activity.
		/// </summary>
		public EducationActivity EducationActivity {
			get {
				return _educationActivity ??
					(_educationActivity = new EducationActivity(LookupColumnEntities.GetEntity("EducationActivity")));
			}
		}

		/// <summary>
		/// Issue date.
		/// </summary>
		public DateTime IssueDate {
			get {
				return GetTypedColumnValue<DateTime>("IssueDate");
			}
			set {
				SetColumnValue("IssueDate", value);
			}
		}

		/// <summary>
		/// Expire date.
		/// </summary>
		public DateTime ExpireDate {
			get {
				return GetTypedColumnValue<DateTime>("ExpireDate");
			}
			set {
				SetColumnValue("ExpireDate", value);
			}
		}

		/// <exclude/>
		public Guid CompetenceLevelId {
			get {
				return GetTypedColumnValue<Guid>("CompetenceLevelId");
			}
			set {
				SetColumnValue("CompetenceLevelId", value);
				_competenceLevel = null;
			}
		}

		/// <exclude/>
		public string CompetenceLevelName {
			get {
				return GetTypedColumnValue<string>("CompetenceLevelName");
			}
			set {
				SetColumnValue("CompetenceLevelName", value);
				if (_competenceLevel != null) {
					_competenceLevel.Name = value;
				}
			}
		}

		private CompetenceLevel _competenceLevel;
		/// <summary>
		/// Competence level.
		/// </summary>
		public CompetenceLevel CompetenceLevel {
			get {
				return _competenceLevel ??
					(_competenceLevel = new CompetenceLevel(LookupColumnEntities.GetEntity("CompetenceLevel")));
			}
		}

		/// <summary>
		/// Result score.
		/// </summary>
		public Decimal ResultScore {
			get {
				return GetTypedColumnValue<Decimal>("ResultScore");
			}
			set {
				SetColumnValue("ResultScore", value);
			}
		}

		/// <summary>
		/// Number.
		/// </summary>
		public string CertificateNumber {
			get {
				return GetTypedColumnValue<string>("CertificateNumber");
			}
			set {
				SetColumnValue("CertificateNumber", value);
			}
		}

		/// <summary>
		/// Comments.
		/// </summary>
		public string Comments {
			get {
				return GetTypedColumnValue<string>("Comments");
			}
			set {
				SetColumnValue("Comments", value);
			}
		}

		/// <summary>
		/// Notification of expiration has been sent.
		/// </summary>
		public bool NotificationSent {
			get {
				return GetTypedColumnValue<bool>("NotificationSent");
			}
			set {
				SetColumnValue("NotificationSent", value);
			}
		}

		/// <summary>
		/// Date of notification.
		/// </summary>
		public DateTime DateOfNotification {
			get {
				return GetTypedColumnValue<DateTime>("DateOfNotification");
			}
			set {
				SetColumnValue("DateOfNotification", value);
			}
		}

		#endregion

	}

	#endregion

}

