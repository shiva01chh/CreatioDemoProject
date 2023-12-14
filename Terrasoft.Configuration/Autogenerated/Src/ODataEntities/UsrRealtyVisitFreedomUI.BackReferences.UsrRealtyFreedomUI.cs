namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: UsrRealtyVisitFreedomUI

	/// <exclude/>
	public class UsrRealtyVisitFreedomUI : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public UsrRealtyVisitFreedomUI(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrRealtyVisitFreedomUI";
		}

		public UsrRealtyVisitFreedomUI(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "UsrRealtyVisitFreedomUI";
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
		public Guid UsrParentRealtyId {
			get {
				return GetTypedColumnValue<Guid>("UsrParentRealtyId");
			}
			set {
				SetColumnValue("UsrParentRealtyId", value);
				_usrParentRealty = null;
			}
		}

		/// <exclude/>
		public string UsrParentRealtyUsrName {
			get {
				return GetTypedColumnValue<string>("UsrParentRealtyUsrName");
			}
			set {
				SetColumnValue("UsrParentRealtyUsrName", value);
				if (_usrParentRealty != null) {
					_usrParentRealty.UsrName = value;
				}
			}
		}

		private UsrRealtyFreedomUI _usrParentRealty;
		/// <summary>
		/// Parent realty.
		/// </summary>
		public UsrRealtyFreedomUI UsrParentRealty {
			get {
				return _usrParentRealty ??
					(_usrParentRealty = new UsrRealtyFreedomUI(LookupColumnEntities.GetEntity("UsrParentRealty")));
			}
		}

		/// <summary>
		/// Visit date and time.
		/// </summary>
		public DateTime UsrVisitDateTime {
			get {
				return GetTypedColumnValue<DateTime>("UsrVisitDateTime");
			}
			set {
				SetColumnValue("UsrVisitDateTime", value);
			}
		}

		/// <summary>
		/// Comment.
		/// </summary>
		public string UsrComment {
			get {
				return GetTypedColumnValue<string>("UsrComment");
			}
			set {
				SetColumnValue("UsrComment", value);
			}
		}

		/// <exclude/>
		public Guid UsrManagerId {
			get {
				return GetTypedColumnValue<Guid>("UsrManagerId");
			}
			set {
				SetColumnValue("UsrManagerId", value);
				_usrManager = null;
			}
		}

		/// <exclude/>
		public string UsrManagerName {
			get {
				return GetTypedColumnValue<string>("UsrManagerName");
			}
			set {
				SetColumnValue("UsrManagerName", value);
				if (_usrManager != null) {
					_usrManager.Name = value;
				}
			}
		}

		private Contact _usrManager;
		/// <summary>
		/// Manager.
		/// </summary>
		public Contact UsrManager {
			get {
				return _usrManager ??
					(_usrManager = new Contact(LookupColumnEntities.GetEntity("UsrManager")));
			}
		}

		/// <exclude/>
		public Guid UsrPotentialCustomerId {
			get {
				return GetTypedColumnValue<Guid>("UsrPotentialCustomerId");
			}
			set {
				SetColumnValue("UsrPotentialCustomerId", value);
				_usrPotentialCustomer = null;
			}
		}

		/// <exclude/>
		public string UsrPotentialCustomerName {
			get {
				return GetTypedColumnValue<string>("UsrPotentialCustomerName");
			}
			set {
				SetColumnValue("UsrPotentialCustomerName", value);
				if (_usrPotentialCustomer != null) {
					_usrPotentialCustomer.Name = value;
				}
			}
		}

		private Contact _usrPotentialCustomer;
		/// <summary>
		/// Potential customer.
		/// </summary>
		public Contact UsrPotentialCustomer {
			get {
				return _usrPotentialCustomer ??
					(_usrPotentialCustomer = new Contact(LookupColumnEntities.GetEntity("UsrPotentialCustomer")));
			}
		}

		#endregion

	}

	#endregion

}

