﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Currency

	/// <exclude/>
	public class Currency : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public Currency(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Currency";
		}

		public Currency(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "Currency";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AccountForecast> AccountForecastCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<CampaignPlanner> CampaignPlannerCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<Cashflow> CashflowCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<ContactForecast> ContactForecastCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<Contract> ContractCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<CurrencyRate> CurrencyRateCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<Invoice> InvoiceCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<LeadTypeForecast> LeadTypeForecastCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<MktgActivity> MktgActivityCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<OppDepartmentForecast> OppDepartmentForecastCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<Order> OrderCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<OrderProduct> OrderProductCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<Product> ProductCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<ProductForecast> ProductForecastCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<ProductInContract> ProductInContractCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<ProductPrice> ProductPriceCollectionByCurrency {
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
		/// Code.
		/// </summary>
		public string Code {
			get {
				return GetTypedColumnValue<string>("Code");
			}
			set {
				SetColumnValue("Code", value);
			}
		}

		/// <summary>
		/// Short name.
		/// </summary>
		public string ShortName {
			get {
				return GetTypedColumnValue<string>("ShortName");
			}
			set {
				SetColumnValue("ShortName", value);
			}
		}

		/// <summary>
		/// Symbol.
		/// </summary>
		public string Symbol {
			get {
				return GetTypedColumnValue<string>("Symbol");
			}
			set {
				SetColumnValue("Symbol", value);
			}
		}

		/// <summary>
		/// Exchange rate format.
		/// </summary>
		public int RecalcDirection {
			get {
				return GetTypedColumnValue<int>("RecalcDirection");
			}
			set {
				SetColumnValue("RecalcDirection", value);
			}
		}

		/// <summary>
		/// Ratio.
		/// </summary>
		public int Division {
			get {
				return GetTypedColumnValue<int>("Division");
			}
			set {
				SetColumnValue("Division", value);
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
		/// Position of currency sign.
		/// </summary>
		public int CurrecySymbolPosition {
			get {
				return GetTypedColumnValue<int>("CurrecySymbolPosition");
			}
			set {
				SetColumnValue("CurrecySymbolPosition", value);
			}
		}

		/// <summary>
		/// Rate.
		/// </summary>
		public Decimal Rate {
			get {
				return GetTypedColumnValue<Decimal>("Rate");
			}
			set {
				SetColumnValue("Rate", value);
			}
		}

		#endregion

	}

	#endregion

}

