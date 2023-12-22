namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: UsrRealtyClassic

	/// <exclude/>
	public class UsrRealtyClassic : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public UsrRealtyClassic(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrRealtyClassic";
		}

		public UsrRealtyClassic(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "UsrRealtyClassic";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<UsrRealtyClassicFile> UsrRealtyClassicFileCollectionByUsrRealtyClassic {
			get;
			set;
		}

		public IEnumerable<UsrRealtyClassicInFolder> UsrRealtyClassicInFolderCollectionByUsrRealtyClassic {
			get;
			set;
		}

		public IEnumerable<UsrRealtyClassicInTag> UsrRealtyClassicInTagCollectionByEntity {
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
		/// Notes.
		/// </summary>
		public string UsrNotes {
			get {
				return GetTypedColumnValue<string>("UsrNotes");
			}
			set {
				SetColumnValue("UsrNotes", value);
			}
		}

		/// <summary>
		/// Price, USD.
		/// </summary>
		public Decimal UsrPriceUSD {
			get {
				return GetTypedColumnValue<Decimal>("UsrPriceUSD");
			}
			set {
				SetColumnValue("UsrPriceUSD", value);
			}
		}

		/// <summary>
		/// Area, sq ft.
		/// </summary>
		public Decimal UsrArea {
			get {
				return GetTypedColumnValue<Decimal>("UsrArea");
			}
			set {
				SetColumnValue("UsrArea", value);
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

		private UsrRealtyTypeClassic _usrType;
		/// <summary>
		/// Type.
		/// </summary>
		public UsrRealtyTypeClassic UsrType {
			get {
				return _usrType ??
					(_usrType = new UsrRealtyTypeClassic(LookupColumnEntities.GetEntity("UsrType")));
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

		private UsrRealtyOfferTypeClassic _usrOfferType;
		/// <summary>
		/// Offer type.
		/// </summary>
		public UsrRealtyOfferTypeClassic UsrOfferType {
			get {
				return _usrOfferType ??
					(_usrOfferType = new UsrRealtyOfferTypeClassic(LookupColumnEntities.GetEntity("UsrOfferType")));
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

		#endregion

	}

	#endregion

}

