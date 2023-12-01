﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OrderVisa

	/// <exclude/>
	public class OrderVisa : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public OrderVisa(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrderVisa";
		}

		public OrderVisa(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "OrderVisa";
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
		/// Approval purpose.
		/// </summary>
		public string Objective {
			get {
				return GetTypedColumnValue<string>("Objective");
			}
			set {
				SetColumnValue("Objective", value);
			}
		}

		/// <exclude/>
		public Guid VisaOwnerId {
			get {
				return GetTypedColumnValue<Guid>("VisaOwnerId");
			}
			set {
				SetColumnValue("VisaOwnerId", value);
				_visaOwner = null;
			}
		}

		/// <exclude/>
		public string VisaOwnerName {
			get {
				return GetTypedColumnValue<string>("VisaOwnerName");
			}
			set {
				SetColumnValue("VisaOwnerName", value);
				if (_visaOwner != null) {
					_visaOwner.Name = value;
				}
			}
		}

		private SysAdminUnit _visaOwner;
		/// <summary>
		/// Approver.
		/// </summary>
		public SysAdminUnit VisaOwner {
			get {
				return _visaOwner ??
					(_visaOwner = new SysAdminUnit(LookupColumnEntities.GetEntity("VisaOwner")));
			}
		}

		/// <summary>
		/// Delegation permitted.
		/// </summary>
		public bool IsAllowedToDelegate {
			get {
				return GetTypedColumnValue<bool>("IsAllowedToDelegate");
			}
			set {
				SetColumnValue("IsAllowedToDelegate", value);
			}
		}

		/// <exclude/>
		public Guid DelegatedFromId {
			get {
				return GetTypedColumnValue<Guid>("DelegatedFromId");
			}
			set {
				SetColumnValue("DelegatedFromId", value);
				_delegatedFrom = null;
			}
		}

		/// <exclude/>
		public string DelegatedFromName {
			get {
				return GetTypedColumnValue<string>("DelegatedFromName");
			}
			set {
				SetColumnValue("DelegatedFromName", value);
				if (_delegatedFrom != null) {
					_delegatedFrom.Name = value;
				}
			}
		}

		private SysAdminUnit _delegatedFrom;
		/// <summary>
		/// Delegated from.
		/// </summary>
		public SysAdminUnit DelegatedFrom {
			get {
				return _delegatedFrom ??
					(_delegatedFrom = new SysAdminUnit(LookupColumnEntities.GetEntity("DelegatedFrom")));
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

		private VisaStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public VisaStatus Status {
			get {
				return _status ??
					(_status = new VisaStatus(LookupColumnEntities.GetEntity("Status")));
			}
		}

		/// <exclude/>
		public Guid SetById {
			get {
				return GetTypedColumnValue<Guid>("SetById");
			}
			set {
				SetColumnValue("SetById", value);
				_setBy = null;
			}
		}

		/// <exclude/>
		public string SetByName {
			get {
				return GetTypedColumnValue<string>("SetByName");
			}
			set {
				SetColumnValue("SetByName", value);
				if (_setBy != null) {
					_setBy.Name = value;
				}
			}
		}

		private Contact _setBy;
		/// <summary>
		/// Set by.
		/// </summary>
		public Contact SetBy {
			get {
				return _setBy ??
					(_setBy = new Contact(LookupColumnEntities.GetEntity("SetBy")));
			}
		}

		/// <summary>
		/// Set on.
		/// </summary>
		public DateTime SetDate {
			get {
				return GetTypedColumnValue<DateTime>("SetDate");
			}
			set {
				SetColumnValue("SetDate", value);
			}
		}

		/// <summary>
		/// Canceled.
		/// </summary>
		public bool IsCanceled {
			get {
				return GetTypedColumnValue<bool>("IsCanceled");
			}
			set {
				SetColumnValue("IsCanceled", value);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Comment {
			get {
				return GetTypedColumnValue<string>("Comment");
			}
			set {
				SetColumnValue("Comment", value);
			}
		}

		/// <summary>
		/// Required of the digital signature.
		/// </summary>
		public bool IsRequiredDigitalSignature {
			get {
				return GetTypedColumnValue<bool>("IsRequiredDigitalSignature");
			}
			set {
				SetColumnValue("IsRequiredDigitalSignature", value);
			}
		}

		/// <exclude/>
		public Guid OrderId {
			get {
				return GetTypedColumnValue<Guid>("OrderId");
			}
			set {
				SetColumnValue("OrderId", value);
				_order = null;
			}
		}

		/// <exclude/>
		public string OrderNumber {
			get {
				return GetTypedColumnValue<string>("OrderNumber");
			}
			set {
				SetColumnValue("OrderNumber", value);
				if (_order != null) {
					_order.Number = value;
				}
			}
		}

		private Order _order;
		/// <summary>
		/// Order.
		/// </summary>
		public Order Order {
			get {
				return _order ??
					(_order = new Order(LookupColumnEntities.GetEntity("Order")));
			}
		}

		#endregion

	}

	#endregion

}

