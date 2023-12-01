namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwOrderProductFilter

	/// <exclude/>
	public class VwOrderProductFilter : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public VwOrderProductFilter(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwOrderProductFilter";
		}

		public VwOrderProductFilter(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "VwOrderProductFilter";
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

		/// <exclude/>
		public Guid ProductId {
			get {
				return GetTypedColumnValue<Guid>("ProductId");
			}
			set {
				SetColumnValue("ProductId", value);
				_product = null;
			}
		}

		/// <exclude/>
		public string ProductName {
			get {
				return GetTypedColumnValue<string>("ProductName");
			}
			set {
				SetColumnValue("ProductName", value);
				if (_product != null) {
					_product.Name = value;
				}
			}
		}

		private OrderProduct _product;
		/// <summary>
		/// Id.
		/// </summary>
		public OrderProduct Product {
			get {
				return _product ??
					(_product = new OrderProduct(LookupColumnEntities.GetEntity("Product")));
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private SupplyPaymentType _type;
		/// <summary>
		/// Installment plan item type.
		/// </summary>
		public SupplyPaymentType Type {
			get {
				return _type ??
					(_type = new SupplyPaymentType(LookupColumnEntities.GetEntity("Type")));
			}
		}

		#endregion

	}

	#endregion

}

