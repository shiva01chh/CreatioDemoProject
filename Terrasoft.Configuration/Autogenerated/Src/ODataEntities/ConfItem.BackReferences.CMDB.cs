namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ConfItem

	/// <exclude/>
	public class ConfItem : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public ConfItem(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ConfItem";
		}

		public ConfItem(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "ConfItem";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByConfItem {
			get;
			set;
		}

		public IEnumerable<Case> CaseCollectionByConfItem {
			get;
			set;
		}

		public IEnumerable<ChangeConfItem> ChangeConfItemCollectionByConfItem {
			get;
			set;
		}

		public IEnumerable<ConfItem> ConfItemCollectionByParentConfItem {
			get;
			set;
		}

		public IEnumerable<ConfItemAddress> ConfItemAddressCollectionByConfItem {
			get;
			set;
		}

		public IEnumerable<ConfItemFile> ConfItemFileCollectionByConfItem {
			get;
			set;
		}

		public IEnumerable<ConfItemInCase> ConfItemInCaseCollectionByConfItem {
			get;
			set;
		}

		public IEnumerable<ConfItemInFolder> ConfItemInFolderCollectionByConfItem {
			get;
			set;
		}

		public IEnumerable<ConfItemInTag> ConfItemInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<ConfItemRelationship> ConfItemRelationshipCollectionByConfItemA {
			get;
			set;
		}

		public IEnumerable<ConfItemRelationship> ConfItemRelationshipCollectionByConfItemB {
			get;
			set;
		}

		public IEnumerable<ConfItemUser> ConfItemUserCollectionByConfItem {
			get;
			set;
		}

		public IEnumerable<Problem> ProblemCollectionByConfItem {
			get;
			set;
		}

		public IEnumerable<ReleaseConfItem> ReleaseConfItemCollectionByConfItem {
			get;
			set;
		}

		public IEnumerable<ServiceInConfItem> ServiceInConfItemCollectionByConfItem {
			get;
			set;
		}

		public IEnumerable<VwConfItemRelationship> VwConfItemRelationshipCollectionByConfItemA {
			get;
			set;
		}

		public IEnumerable<VwConfItemRelationship> VwConfItemRelationshipCollectionByConfItemB {
			get;
			set;
		}

		public IEnumerable<VwServiceInConfItem> VwServiceInConfItemCollectionByConfItem {
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
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
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

		private ConfigItemType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public ConfigItemType Type {
			get {
				return _type ??
					(_type = new ConfigItemType(LookupColumnEntities.GetEntity("Type")));
			}
		}

		/// <exclude/>
		public Guid ModelId {
			get {
				return GetTypedColumnValue<Guid>("ModelId");
			}
			set {
				SetColumnValue("ModelId", value);
				_model = null;
			}
		}

		/// <exclude/>
		public string ModelName {
			get {
				return GetTypedColumnValue<string>("ModelName");
			}
			set {
				SetColumnValue("ModelName", value);
				if (_model != null) {
					_model.Name = value;
				}
			}
		}

		private ConfigItemModel _model;
		/// <summary>
		/// Model.
		/// </summary>
		public ConfigItemModel Model {
			get {
				return _model ??
					(_model = new ConfigItemModel(LookupColumnEntities.GetEntity("Model")));
			}
		}

		/// <summary>
		/// Serial number.
		/// </summary>
		public string SerialNumber {
			get {
				return GetTypedColumnValue<string>("SerialNumber");
			}
			set {
				SetColumnValue("SerialNumber", value);
			}
		}

		/// <summary>
		/// Inventory number.
		/// </summary>
		public string InventoryNumber {
			get {
				return GetTypedColumnValue<string>("InventoryNumber");
			}
			set {
				SetColumnValue("InventoryNumber", value);
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

		private ConfigItemStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public ConfigItemStatus Status {
			get {
				return _status ??
					(_status = new ConfigItemStatus(LookupColumnEntities.GetEntity("Status")));
			}
		}

		/// <summary>
		/// Purchased on.
		/// </summary>
		public DateTime PurchaseDate {
			get {
				return GetTypedColumnValue<DateTime>("PurchaseDate");
			}
			set {
				SetColumnValue("PurchaseDate", value);
			}
		}

		/// <summary>
		/// Retired on.
		/// </summary>
		public DateTime CancelDate {
			get {
				return GetTypedColumnValue<DateTime>("CancelDate");
			}
			set {
				SetColumnValue("CancelDate", value);
			}
		}

		/// <summary>
		/// Warranty valid until.
		/// </summary>
		public DateTime WarrantyUntil {
			get {
				return GetTypedColumnValue<DateTime>("WarrantyUntil");
			}
			set {
				SetColumnValue("WarrantyUntil", value);
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
		public Guid ParentConfItemId {
			get {
				return GetTypedColumnValue<Guid>("ParentConfItemId");
			}
			set {
				SetColumnValue("ParentConfItemId", value);
				_parentConfItem = null;
			}
		}

		/// <exclude/>
		public string ParentConfItemName {
			get {
				return GetTypedColumnValue<string>("ParentConfItemName");
			}
			set {
				SetColumnValue("ParentConfItemName", value);
				if (_parentConfItem != null) {
					_parentConfItem.Name = value;
				}
			}
		}

		private ConfItem _parentConfItem;
		/// <summary>
		/// Parent CI.
		/// </summary>
		public ConfItem ParentConfItem {
			get {
				return _parentConfItem ??
					(_parentConfItem = new ConfItem(LookupColumnEntities.GetEntity("ParentConfItem")));
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

		private ConfigItemCategory _category;
		/// <summary>
		/// Category.
		/// </summary>
		public ConfigItemCategory Category {
			get {
				return _category ??
					(_category = new ConfigItemCategory(LookupColumnEntities.GetEntity("Category")));
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
		public Guid CountryId {
			get {
				return GetTypedColumnValue<Guid>("CountryId");
			}
			set {
				SetColumnValue("CountryId", value);
				_country = null;
			}
		}

		/// <exclude/>
		public string CountryName {
			get {
				return GetTypedColumnValue<string>("CountryName");
			}
			set {
				SetColumnValue("CountryName", value);
				if (_country != null) {
					_country.Name = value;
				}
			}
		}

		private Country _country;
		/// <summary>
		/// Country.
		/// </summary>
		public Country Country {
			get {
				return _country ??
					(_country = new Country(LookupColumnEntities.GetEntity("Country")));
			}
		}

		/// <exclude/>
		public Guid RegionId {
			get {
				return GetTypedColumnValue<Guid>("RegionId");
			}
			set {
				SetColumnValue("RegionId", value);
				_region = null;
			}
		}

		/// <exclude/>
		public string RegionName {
			get {
				return GetTypedColumnValue<string>("RegionName");
			}
			set {
				SetColumnValue("RegionName", value);
				if (_region != null) {
					_region.Name = value;
				}
			}
		}

		private Region _region;
		/// <summary>
		/// Region.
		/// </summary>
		public Region Region {
			get {
				return _region ??
					(_region = new Region(LookupColumnEntities.GetEntity("Region")));
			}
		}

		/// <exclude/>
		public Guid CityId {
			get {
				return GetTypedColumnValue<Guid>("CityId");
			}
			set {
				SetColumnValue("CityId", value);
				_city = null;
			}
		}

		/// <exclude/>
		public string CityName {
			get {
				return GetTypedColumnValue<string>("CityName");
			}
			set {
				SetColumnValue("CityName", value);
				if (_city != null) {
					_city.Name = value;
				}
			}
		}

		private City _city;
		/// <summary>
		/// City.
		/// </summary>
		public City City {
			get {
				return _city ??
					(_city = new City(LookupColumnEntities.GetEntity("City")));
			}
		}

		/// <summary>
		/// Street.
		/// </summary>
		public string Street {
			get {
				return GetTypedColumnValue<string>("Street");
			}
			set {
				SetColumnValue("Street", value);
			}
		}

		/// <summary>
		/// Address.
		/// </summary>
		public string Address {
			get {
				return GetTypedColumnValue<string>("Address");
			}
			set {
				SetColumnValue("Address", value);
			}
		}

		#endregion

	}

	#endregion

}

