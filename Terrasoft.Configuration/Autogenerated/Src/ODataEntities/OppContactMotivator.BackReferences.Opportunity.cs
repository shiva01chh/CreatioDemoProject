namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OppContactMotivator

	/// <exclude/>
	public class OppContactMotivator : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public OppContactMotivator(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OppContactMotivator";
		}

		public OppContactMotivator(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "OppContactMotivator";
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
		public Guid ContactMotivatorId {
			get {
				return GetTypedColumnValue<Guid>("ContactMotivatorId");
			}
			set {
				SetColumnValue("ContactMotivatorId", value);
				_contactMotivator = null;
			}
		}

		/// <exclude/>
		public string ContactMotivatorName {
			get {
				return GetTypedColumnValue<string>("ContactMotivatorName");
			}
			set {
				SetColumnValue("ContactMotivatorName", value);
				if (_contactMotivator != null) {
					_contactMotivator.Name = value;
				}
			}
		}

		private OppContactMotivators _contactMotivator;
		/// <summary>
		/// Decision-making factor.
		/// </summary>
		public OppContactMotivators ContactMotivator {
			get {
				return _contactMotivator ??
					(_contactMotivator = new OppContactMotivators(LookupColumnEntities.GetEntity("ContactMotivator")));
			}
		}

		/// <exclude/>
		public Guid OpportunityContactId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityContactId");
			}
			set {
				SetColumnValue("OpportunityContactId", value);
				_opportunityContact = null;
			}
		}

		private OpportunityContact _opportunityContact;
		/// <summary>
		/// Opportunity contact.
		/// </summary>
		public OpportunityContact OpportunityContact {
			get {
				return _opportunityContact ??
					(_opportunityContact = new OpportunityContact(LookupColumnEntities.GetEntity("OpportunityContact")));
			}
		}

		#endregion

	}

	#endregion

}

