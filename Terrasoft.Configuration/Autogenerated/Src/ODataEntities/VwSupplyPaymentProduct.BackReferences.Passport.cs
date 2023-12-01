namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSupplyPaymentProduct

	/// <exclude/>
	public class VwSupplyPaymentProduct : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public VwSupplyPaymentProduct(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSupplyPaymentProduct";
		}

		public VwSupplyPaymentProduct(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "VwSupplyPaymentProduct";
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
		public Guid SupplyPaymentElementId {
			get {
				return GetTypedColumnValue<Guid>("SupplyPaymentElementId");
			}
			set {
				SetColumnValue("SupplyPaymentElementId", value);
				_supplyPaymentElement = null;
			}
		}

		/// <exclude/>
		public string SupplyPaymentElementName {
			get {
				return GetTypedColumnValue<string>("SupplyPaymentElementName");
			}
			set {
				SetColumnValue("SupplyPaymentElementName", value);
				if (_supplyPaymentElement != null) {
					_supplyPaymentElement.Name = value;
				}
			}
		}

		private SupplyPaymentElement _supplyPaymentElement;
		/// <summary>
		/// Installment plan.
		/// </summary>
		public SupplyPaymentElement SupplyPaymentElement {
			get {
				return _supplyPaymentElement ??
					(_supplyPaymentElement = new SupplyPaymentElement(LookupColumnEntities.GetEntity("SupplyPaymentElement")));
			}
		}

		/// <exclude/>
		public Guid SupplyPaymentProductId {
			get {
				return GetTypedColumnValue<Guid>("SupplyPaymentProductId");
			}
			set {
				SetColumnValue("SupplyPaymentProductId", value);
				_supplyPaymentProduct = null;
			}
		}

		private SupplyPaymentProduct _supplyPaymentProduct;
		/// <summary>
		/// Product in the installment plan.
		/// </summary>
		public SupplyPaymentProduct SupplyPaymentProduct {
			get {
				return _supplyPaymentProduct ??
					(_supplyPaymentProduct = new SupplyPaymentProduct(LookupColumnEntities.GetEntity("SupplyPaymentProduct")));
			}
		}

		/// <exclude/>
		public Guid OrderProductId {
			get {
				return GetTypedColumnValue<Guid>("OrderProductId");
			}
			set {
				SetColumnValue("OrderProductId", value);
				_orderProduct = null;
			}
		}

		/// <exclude/>
		public string OrderProductName {
			get {
				return GetTypedColumnValue<string>("OrderProductName");
			}
			set {
				SetColumnValue("OrderProductName", value);
				if (_orderProduct != null) {
					_orderProduct.Name = value;
				}
			}
		}

		private OrderProduct _orderProduct;
		/// <summary>
		/// Product.
		/// </summary>
		public OrderProduct OrderProduct {
			get {
				return _orderProduct ??
					(_orderProduct = new OrderProduct(LookupColumnEntities.GetEntity("OrderProduct")));
			}
		}

		/// <summary>
		/// Quantity.
		/// </summary>
		public Decimal UsedQuantity {
			get {
				return GetTypedColumnValue<Decimal>("UsedQuantity");
			}
			set {
				SetColumnValue("UsedQuantity", value);
			}
		}

		/// <summary>
		/// Amount.
		/// </summary>
		public Decimal UsedAmount {
			get {
				return GetTypedColumnValue<Decimal>("UsedAmount");
			}
			set {
				SetColumnValue("UsedAmount", value);
			}
		}

		/// <summary>
		/// Available.
		/// </summary>
		public Decimal MaxQuantity {
			get {
				return GetTypedColumnValue<Decimal>("MaxQuantity");
			}
			set {
				SetColumnValue("MaxQuantity", value);
			}
		}

		/// <summary>
		/// Distributed.
		/// </summary>
		public int IsDistributed {
			get {
				return GetTypedColumnValue<int>("IsDistributed");
			}
			set {
				SetColumnValue("IsDistributed", value);
			}
		}

		/// <summary>
		/// Price.
		/// </summary>
		public Decimal Price {
			get {
				return GetTypedColumnValue<Decimal>("Price");
			}
			set {
				SetColumnValue("Price", value);
			}
		}

		/// <summary>
		/// Discount, %.
		/// </summary>
		public Decimal DiscountPercent {
			get {
				return GetTypedColumnValue<Decimal>("DiscountPercent");
			}
			set {
				SetColumnValue("DiscountPercent", value);
			}
		}

		/// <summary>
		/// Discount amount.
		/// </summary>
		public Decimal DiscountAmount {
			get {
				return GetTypedColumnValue<Decimal>("DiscountAmount");
			}
			set {
				SetColumnValue("DiscountAmount", value);
			}
		}

		#endregion

	}

	#endregion

}

