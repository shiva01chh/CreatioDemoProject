﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseCase

	/// <exclude/>
	public class BaseCase : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public BaseCase(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BaseCase";
		}

		public BaseCase(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "BaseCase";
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
		/// Number.
		/// </summary>
		public string Number {
			get {
				return GetTypedColumnValue<string>("Number");
			}
			set {
				SetColumnValue("Number", value);
			}
		}

		/// <summary>
		/// Registration date.
		/// </summary>
		public DateTime RegisteredOn {
			get {
				return GetTypedColumnValue<DateTime>("RegisteredOn");
			}
			set {
				SetColumnValue("RegisteredOn", value);
			}
		}

		/// <summary>
		/// Subject.
		/// </summary>
		public string Subject {
			get {
				return GetTypedColumnValue<string>("Subject");
			}
			set {
				SetColumnValue("Subject", value);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Symptoms {
			get {
				return GetTypedColumnValue<string>("Symptoms");
			}
			set {
				SetColumnValue("Symptoms", value);
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
		/// Response time.
		/// </summary>
		public DateTime ResponseDate {
			get {
				return GetTypedColumnValue<DateTime>("ResponseDate");
			}
			set {
				SetColumnValue("ResponseDate", value);
			}
		}

		/// <summary>
		/// Resolution time.
		/// </summary>
		public DateTime SolutionDate {
			get {
				return GetTypedColumnValue<DateTime>("SolutionDate");
			}
			set {
				SetColumnValue("SolutionDate", value);
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

		private CaseStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public CaseStatus Status {
			get {
				return _status ??
					(_status = new CaseStatus(LookupColumnEntities.GetEntity("Status")));
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
		public Guid PriorityId {
			get {
				return GetTypedColumnValue<Guid>("PriorityId");
			}
			set {
				SetColumnValue("PriorityId", value);
				_priority = null;
			}
		}

		/// <exclude/>
		public string PriorityName {
			get {
				return GetTypedColumnValue<string>("PriorityName");
			}
			set {
				SetColumnValue("PriorityName", value);
				if (_priority != null) {
					_priority.Name = value;
				}
			}
		}

		private CasePriority _priority;
		/// <summary>
		/// Priority.
		/// </summary>
		public CasePriority Priority {
			get {
				return _priority ??
					(_priority = new CasePriority(LookupColumnEntities.GetEntity("Priority")));
			}
		}

		/// <exclude/>
		public Guid OriginId {
			get {
				return GetTypedColumnValue<Guid>("OriginId");
			}
			set {
				SetColumnValue("OriginId", value);
				_origin = null;
			}
		}

		/// <exclude/>
		public string OriginName {
			get {
				return GetTypedColumnValue<string>("OriginName");
			}
			set {
				SetColumnValue("OriginName", value);
				if (_origin != null) {
					_origin.Name = value;
				}
			}
		}

		private CaseOrigin _origin;
		/// <summary>
		/// Source.
		/// </summary>
		public CaseOrigin Origin {
			get {
				return _origin ??
					(_origin = new CaseOrigin(LookupColumnEntities.GetEntity("Origin")));
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
		/// Group.
		/// </summary>
		public SysAdminUnit Group {
			get {
				return _group ??
					(_group = new SysAdminUnit(LookupColumnEntities.GetEntity("Group")));
			}
		}

		/// <summary>
		/// Actual response time.
		/// </summary>
		public DateTime RespondedOn {
			get {
				return GetTypedColumnValue<DateTime>("RespondedOn");
			}
			set {
				SetColumnValue("RespondedOn", value);
			}
		}

		/// <summary>
		/// First resolution time.
		/// </summary>
		public DateTime FirstSolutionProvidedOn {
			get {
				return GetTypedColumnValue<DateTime>("FirstSolutionProvidedOn");
			}
			set {
				SetColumnValue("FirstSolutionProvidedOn", value);
			}
		}

		/// <summary>
		/// Actual resolution time.
		/// </summary>
		public DateTime SolutionProvidedOn {
			get {
				return GetTypedColumnValue<DateTime>("SolutionProvidedOn");
			}
			set {
				SetColumnValue("SolutionProvidedOn", value);
			}
		}

		/// <summary>
		/// Closed on.
		/// </summary>
		public DateTime ClosureDate {
			get {
				return GetTypedColumnValue<DateTime>("ClosureDate");
			}
			set {
				SetColumnValue("ClosureDate", value);
			}
		}

		/// <exclude/>
		public Guid ClosureCodeId {
			get {
				return GetTypedColumnValue<Guid>("ClosureCodeId");
			}
			set {
				SetColumnValue("ClosureCodeId", value);
				_closureCode = null;
			}
		}

		/// <exclude/>
		public string ClosureCodeName {
			get {
				return GetTypedColumnValue<string>("ClosureCodeName");
			}
			set {
				SetColumnValue("ClosureCodeName", value);
				if (_closureCode != null) {
					_closureCode.Name = value;
				}
			}
		}

		private ClosureCode _closureCode;
		/// <summary>
		/// Reason for closing.
		/// </summary>
		public ClosureCode ClosureCode {
			get {
				return _closureCode ??
					(_closureCode = new ClosureCode(LookupColumnEntities.GetEntity("ClosureCode")));
			}
		}

		/// <summary>
		/// Resolution.
		/// </summary>
		public string Solution {
			get {
				return GetTypedColumnValue<string>("Solution");
			}
			set {
				SetColumnValue("Solution", value);
			}
		}

		/// <exclude/>
		public Guid SatisfactionLevelId {
			get {
				return GetTypedColumnValue<Guid>("SatisfactionLevelId");
			}
			set {
				SetColumnValue("SatisfactionLevelId", value);
				_satisfactionLevel = null;
			}
		}

		/// <exclude/>
		public string SatisfactionLevelName {
			get {
				return GetTypedColumnValue<string>("SatisfactionLevelName");
			}
			set {
				SetColumnValue("SatisfactionLevelName", value);
				if (_satisfactionLevel != null) {
					_satisfactionLevel.Name = value;
				}
			}
		}

		private SatisfactionLevel _satisfactionLevel;
		/// <summary>
		/// Satisfaction level.
		/// </summary>
		public SatisfactionLevel SatisfactionLevel {
			get {
				return _satisfactionLevel ??
					(_satisfactionLevel = new SatisfactionLevel(LookupColumnEntities.GetEntity("SatisfactionLevel")));
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

		private CaseCategory _category;
		/// <summary>
		/// Category.
		/// </summary>
		public CaseCategory Category {
			get {
				return _category ??
					(_category = new CaseCategory(LookupColumnEntities.GetEntity("Category")));
			}
		}

		/// <summary>
		/// Overdue response.
		/// </summary>
		public bool ResponseOverdue {
			get {
				return GetTypedColumnValue<bool>("ResponseOverdue");
			}
			set {
				SetColumnValue("ResponseOverdue", value);
			}
		}

		/// <summary>
		/// Overdue resolution.
		/// </summary>
		public bool SolutionOverdue {
			get {
				return GetTypedColumnValue<bool>("SolutionOverdue");
			}
			set {
				SetColumnValue("SolutionOverdue", value);
			}
		}

		/// <summary>
		/// Feedback notes.
		/// </summary>
		public string SatisfactionLevelComment {
			get {
				return GetTypedColumnValue<string>("SatisfactionLevelComment");
			}
			set {
				SetColumnValue("SatisfactionLevelComment", value);
			}
		}

		/// <summary>
		/// Remaining until resolution time.
		/// </summary>
		public Decimal SolutionRemains {
			get {
				return GetTypedColumnValue<Decimal>("SolutionRemains");
			}
			set {
				SetColumnValue("SolutionRemains", value);
			}
		}

		#endregion

	}

	#endregion

}

