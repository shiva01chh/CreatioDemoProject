namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Order

	/// <exclude/>
	public class Order : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public Order(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Order";
		}

		public Order(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "Order";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<Call> CallCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<Contract> ContractCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<Document> DocumentCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<Invoice> InvoiceCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<OrderFile> OrderFileCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<OrderInFolder> OrderInFolderCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<OrderInTag> OrderInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<OrderProduct> OrderProductCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<OrderVisa> OrderVisaCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<SupplyPaymentElement> SupplyPaymentElementCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<VwQueueItem> VwQueueItemCollectionByOrder {
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

		private OrderStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public OrderStatus Status {
			get {
				return _status ??
					(_status = new OrderStatus(LookupColumnEntities.GetEntity("Status")));
			}
		}

		/// <exclude/>
		public Guid PaymentStatusId {
			get {
				return GetTypedColumnValue<Guid>("PaymentStatusId");
			}
			set {
				SetColumnValue("PaymentStatusId", value);
				_paymentStatus = null;
			}
		}

		/// <exclude/>
		public string PaymentStatusName {
			get {
				return GetTypedColumnValue<string>("PaymentStatusName");
			}
			set {
				SetColumnValue("PaymentStatusName", value);
				if (_paymentStatus != null) {
					_paymentStatus.Name = value;
				}
			}
		}

		private OrderPaymentStatus _paymentStatus;
		/// <summary>
		/// Payment status.
		/// </summary>
		public OrderPaymentStatus PaymentStatus {
			get {
				return _paymentStatus ??
					(_paymentStatus = new OrderPaymentStatus(LookupColumnEntities.GetEntity("PaymentStatus")));
			}
		}

		/// <exclude/>
		public Guid DeliveryStatusId {
			get {
				return GetTypedColumnValue<Guid>("DeliveryStatusId");
			}
			set {
				SetColumnValue("DeliveryStatusId", value);
				_deliveryStatus = null;
			}
		}

		/// <exclude/>
		public string DeliveryStatusName {
			get {
				return GetTypedColumnValue<string>("DeliveryStatusName");
			}
			set {
				SetColumnValue("DeliveryStatusName", value);
				if (_deliveryStatus != null) {
					_deliveryStatus.Name = value;
				}
			}
		}

		private OrderDeliveryStatus _deliveryStatus;
		/// <summary>
		/// Delivery status.
		/// </summary>
		public OrderDeliveryStatus DeliveryStatus {
			get {
				return _deliveryStatus ??
					(_deliveryStatus = new OrderDeliveryStatus(LookupColumnEntities.GetEntity("DeliveryStatus")));
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

		/// <summary>
		/// Planned end date.
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
		/// Actual end date.
		/// </summary>
		public DateTime ActualDate {
			get {
				return GetTypedColumnValue<DateTime>("ActualDate");
			}
			set {
				SetColumnValue("ActualDate", value);
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

		/// <summary>
		/// Total.
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
		/// Payment amount.
		/// </summary>
		public Decimal PaymentAmount {
			get {
				return GetTypedColumnValue<Decimal>("PaymentAmount");
			}
			set {
				SetColumnValue("PaymentAmount", value);
			}
		}

		/// <summary>
		/// Total, base currency.
		/// </summary>
		public Decimal PrimaryAmount {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryAmount");
			}
			set {
				SetColumnValue("PrimaryAmount", value);
			}
		}

		/// <summary>
		/// Payment amount, base currency.
		/// </summary>
		public Decimal PrimaryPaymentAmount {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryPaymentAmount");
			}
			set {
				SetColumnValue("PrimaryPaymentAmount", value);
			}
		}

		/// <exclude/>
		public Guid SourceOrderId {
			get {
				return GetTypedColumnValue<Guid>("SourceOrderId");
			}
			set {
				SetColumnValue("SourceOrderId", value);
				_sourceOrder = null;
			}
		}

		/// <exclude/>
		public string SourceOrderName {
			get {
				return GetTypedColumnValue<string>("SourceOrderName");
			}
			set {
				SetColumnValue("SourceOrderName", value);
				if (_sourceOrder != null) {
					_sourceOrder.Name = value;
				}
			}
		}

		private SourceOrder _sourceOrder;
		/// <summary>
		/// Order channel.
		/// </summary>
		public SourceOrder SourceOrder {
			get {
				return _sourceOrder ??
					(_sourceOrder = new SourceOrder(LookupColumnEntities.GetEntity("SourceOrder")));
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
		public Guid OpportunityId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityId");
			}
			set {
				SetColumnValue("OpportunityId", value);
				_opportunity = null;
			}
		}

		/// <exclude/>
		public string OpportunityTitle {
			get {
				return GetTypedColumnValue<string>("OpportunityTitle");
			}
			set {
				SetColumnValue("OpportunityTitle", value);
				if (_opportunity != null) {
					_opportunity.Title = value;
				}
			}
		}

		private Opportunity _opportunity;
		/// <summary>
		/// Opportunity.
		/// </summary>
		public Opportunity Opportunity {
			get {
				return _opportunity ??
					(_opportunity = new Opportunity(LookupColumnEntities.GetEntity("Opportunity")));
			}
		}

		/// <summary>
		/// Delivery address.
		/// </summary>
		public string DeliveryAddress {
			get {
				return GetTypedColumnValue<string>("DeliveryAddress");
			}
			set {
				SetColumnValue("DeliveryAddress", value);
			}
		}

		/// <exclude/>
		public Guid DeliveryTypeId {
			get {
				return GetTypedColumnValue<Guid>("DeliveryTypeId");
			}
			set {
				SetColumnValue("DeliveryTypeId", value);
				_deliveryType = null;
			}
		}

		/// <exclude/>
		public string DeliveryTypeName {
			get {
				return GetTypedColumnValue<string>("DeliveryTypeName");
			}
			set {
				SetColumnValue("DeliveryTypeName", value);
				if (_deliveryType != null) {
					_deliveryType.Name = value;
				}
			}
		}

		private DeliveryType _deliveryType;
		/// <summary>
		/// Delivery type.
		/// </summary>
		public DeliveryType DeliveryType {
			get {
				return _deliveryType ??
					(_deliveryType = new DeliveryType(LookupColumnEntities.GetEntity("DeliveryType")));
			}
		}

		/// <exclude/>
		public Guid PaymentTypeId {
			get {
				return GetTypedColumnValue<Guid>("PaymentTypeId");
			}
			set {
				SetColumnValue("PaymentTypeId", value);
				_paymentType = null;
			}
		}

		/// <exclude/>
		public string PaymentTypeName {
			get {
				return GetTypedColumnValue<string>("PaymentTypeName");
			}
			set {
				SetColumnValue("PaymentTypeName", value);
				if (_paymentType != null) {
					_paymentType.Name = value;
				}
			}
		}

		private PaymentType _paymentType;
		/// <summary>
		/// Payment type.
		/// </summary>
		public PaymentType PaymentType {
			get {
				return _paymentType ??
					(_paymentType = new PaymentType(LookupColumnEntities.GetEntity("PaymentType")));
			}
		}

		/// <summary>
		/// Recipient's name.
		/// </summary>
		public string ReceiverName {
			get {
				return GetTypedColumnValue<string>("ReceiverName");
			}
			set {
				SetColumnValue("ReceiverName", value);
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
		/// Phone.
		/// </summary>
		public string ContactNumber {
			get {
				return GetTypedColumnValue<string>("ContactNumber");
			}
			set {
				SetColumnValue("ContactNumber", value);
			}
		}

		#endregion

	}

	#endregion

}

