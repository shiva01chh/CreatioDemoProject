﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PRMTransaction

	/// <exclude/>
	public class PRMTransaction : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public PRMTransaction(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PRMTransaction";
		}

		public PRMTransaction(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "PRMTransaction";
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
		/// Amount.
		/// </summary>
		public Decimal Amount {
			get {
				return GetTypedColumnValue<Decimal>("Amount");
			}
			set {
				SetColumnValue("Amount", value);
			}
		}

		/// <summary>
		/// Date.
		/// </summary>
		public DateTime Date {
			get {
				return GetTypedColumnValue<DateTime>("Date");
			}
			set {
				SetColumnValue("Date", value);
			}
		}

		/// <summary>
		/// Record identifier.
		/// </summary>
		public Guid RecordId {
			get {
				return GetTypedColumnValue<Guid>("RecordId");
			}
			set {
				SetColumnValue("RecordId", value);
			}
		}

		/// <summary>
		/// Entity identifier.
		/// </summary>
		public Guid EntityId {
			get {
				return GetTypedColumnValue<Guid>("EntityId");
			}
			set {
				SetColumnValue("EntityId", value);
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
		public Guid TransactionTypeId {
			get {
				return GetTypedColumnValue<Guid>("TransactionTypeId");
			}
			set {
				SetColumnValue("TransactionTypeId", value);
				_transactionType = null;
			}
		}

		/// <exclude/>
		public string TransactionTypeName {
			get {
				return GetTypedColumnValue<string>("TransactionTypeName");
			}
			set {
				SetColumnValue("TransactionTypeName", value);
				if (_transactionType != null) {
					_transactionType.Name = value;
				}
			}
		}

		private PRMTransactionType _transactionType;
		/// <summary>
		/// Type.
		/// </summary>
		public PRMTransactionType TransactionType {
			get {
				return _transactionType ??
					(_transactionType = new PRMTransactionType(LookupColumnEntities.GetEntity("TransactionType")));
			}
		}

		#endregion

	}

	#endregion

}

