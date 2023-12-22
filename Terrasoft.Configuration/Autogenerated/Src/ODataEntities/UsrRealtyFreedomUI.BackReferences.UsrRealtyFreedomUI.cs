namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: UsrRealtyFreedomUI

	/// <exclude/>
	public class UsrRealtyFreedomUI : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public UsrRealtyFreedomUI(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrRealtyFreedomUI";
		}

		public UsrRealtyFreedomUI(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "UsrRealtyFreedomUI";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<UsrRealtyVisitFreedomUI> UsrRealtyVisitFreedomUICollectionByUsrParentRealty {
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
		/// Name.
		/// </summary>
		public string UsrName {
			get {
				return GetTypedColumnValue<string>("UsrName");
			}
			set {
				SetColumnValue("UsrName", value);
			}
		}

		/// <summary>
		/// Area, sqft.
		/// </summary>
		public Decimal UsrArea {
			get {
				return GetTypedColumnValue<Decimal>("UsrArea");
			}
			set {
				SetColumnValue("UsrArea", value);
			}
		}

		/// <summary>
		/// Price USD.
		/// </summary>
		public Decimal UsrPriceUSD {
			get {
				return GetTypedColumnValue<Decimal>("UsrPriceUSD");
			}
			set {
				SetColumnValue("UsrPriceUSD", value);
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
		public Guid UsrOfferTypeId {
			get {
				return GetTypedColumnValue<Guid>("UsrOfferTypeId");
			}
			set {
				SetColumnValue("UsrOfferTypeId", value);
				_usrOfferType = null;
			}
		}

		/// <exclude/>
		public string UsrOfferTypeName {
			get {
				return GetTypedColumnValue<string>("UsrOfferTypeName");
			}
			set {
				SetColumnValue("UsrOfferTypeName", value);
				if (_usrOfferType != null) {
					_usrOfferType.Name = value;
				}
			}
		}

		private UsrRealtyOfferTypeFreedomUI _usrOfferType;
		/// <summary>
		/// Offer type.
		/// </summary>
		public UsrRealtyOfferTypeFreedomUI UsrOfferType {
			get {
				return _usrOfferType ??
					(_usrOfferType = new UsrRealtyOfferTypeFreedomUI(LookupColumnEntities.GetEntity("UsrOfferType")));
			}
		}

		/// <exclude/>
		public Guid UsrTypeId {
			get {
				return GetTypedColumnValue<Guid>("UsrTypeId");
			}
			set {
				SetColumnValue("UsrTypeId", value);
				_usrType = null;
			}
		}

		/// <exclude/>
		public string UsrTypeName {
			get {
				return GetTypedColumnValue<string>("UsrTypeName");
			}
			set {
				SetColumnValue("UsrTypeName", value);
				if (_usrType != null) {
					_usrType.Name = value;
				}
			}
		}

		private UsrRealtyTypeFreedomUI _usrType;
		/// <summary>
		/// Type.
		/// </summary>
		public UsrRealtyTypeFreedomUI UsrType {
			get {
				return _usrType ??
					(_usrType = new UsrRealtyTypeFreedomUI(LookupColumnEntities.GetEntity("UsrType")));
			}
		}

		/// <exclude/>
		public Guid UsrCityId {
			get {
				return GetTypedColumnValue<Guid>("UsrCityId");
			}
			set {
				SetColumnValue("UsrCityId", value);
				_usrCity = null;
			}
		}

		/// <exclude/>
		public string UsrCityName {
			get {
				return GetTypedColumnValue<string>("UsrCityName");
			}
			set {
				SetColumnValue("UsrCityName", value);
				if (_usrCity != null) {
					_usrCity.Name = value;
				}
			}
		}

		private City _usrCity;
		/// <summary>
		/// City.
		/// </summary>
		public City UsrCity {
			get {
				return _usrCity ??
					(_usrCity = new City(LookupColumnEntities.GetEntity("UsrCity")));
			}
		}

		/// <exclude/>
		public Guid UsrCountryId {
			get {
				return GetTypedColumnValue<Guid>("UsrCountryId");
			}
			set {
				SetColumnValue("UsrCountryId", value);
				_usrCountry = null;
			}
		}

		/// <exclude/>
		public string UsrCountryName {
			get {
				return GetTypedColumnValue<string>("UsrCountryName");
			}
			set {
				SetColumnValue("UsrCountryName", value);
				if (_usrCountry != null) {
					_usrCountry.Name = value;
				}
			}
		}

		private Country _usrCountry;
		/// <summary>
		/// Country.
		/// </summary>
		public Country UsrCountry {
			get {
				return _usrCountry ??
					(_usrCountry = new Country(LookupColumnEntities.GetEntity("UsrCountry")));
			}
		}

		/// <summary>
		/// Commission, USD.
		/// </summary>
		public Decimal UsrCommissionUSD {
			get {
				return GetTypedColumnValue<Decimal>("UsrCommissionUSD");
			}
			set {
				SetColumnValue("UsrCommissionUSD", value);
			}
		}

		#endregion

	}

	#endregion

}

