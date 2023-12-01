namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SiteEventType

	/// <exclude/>
	public class SiteEventType : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public SiteEventType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SiteEventType";
		}

		public SiteEventType(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "SiteEventType";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SiteEvent> SiteEventCollectionBySiteEventType {
			get;
			set;
		}

		public IEnumerable<SiteEventTypeFile> SiteEventTypeFileCollectionBySiteEventType {
			get;
			set;
		}

		public IEnumerable<SiteEventTypeInFolder> SiteEventTypeInFolderCollectionBySiteEventType {
			get;
			set;
		}

		public IEnumerable<SiteEventTypeInTag> SiteEventTypeInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<VwSiteEvent> VwSiteEventCollectionBySiteEventType {
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
		public Guid SelectorTypeId {
			get {
				return GetTypedColumnValue<Guid>("SelectorTypeId");
			}
			set {
				SetColumnValue("SelectorTypeId", value);
				_selectorType = null;
			}
		}

		/// <exclude/>
		public string SelectorTypeName {
			get {
				return GetTypedColumnValue<string>("SelectorTypeName");
			}
			set {
				SetColumnValue("SelectorTypeName", value);
				if (_selectorType != null) {
					_selectorType.Name = value;
				}
			}
		}

		private SelectorType _selectorType;
		/// <summary>
		/// How to identify elements.
		/// </summary>
		public SelectorType SelectorType {
			get {
				return _selectorType ??
					(_selectorType = new SelectorType(LookupColumnEntities.GetEntity("SelectorType")));
			}
		}

		/// <exclude/>
		public Guid WebsiteEventTypeId {
			get {
				return GetTypedColumnValue<Guid>("WebsiteEventTypeId");
			}
			set {
				SetColumnValue("WebsiteEventTypeId", value);
				_websiteEventType = null;
			}
		}

		/// <exclude/>
		public string WebsiteEventTypeName {
			get {
				return GetTypedColumnValue<string>("WebsiteEventTypeName");
			}
			set {
				SetColumnValue("WebsiteEventTypeName", value);
				if (_websiteEventType != null) {
					_websiteEventType.Name = value;
				}
			}
		}

		private WebsiteEventType _websiteEventType;
		/// <summary>
		/// Website event type.
		/// </summary>
		public WebsiteEventType WebsiteEventType {
			get {
				return _websiteEventType ??
					(_websiteEventType = new WebsiteEventType(LookupColumnEntities.GetEntity("WebsiteEventType")));
			}
		}

		/// <summary>
		/// Active.
		/// </summary>
		public bool IsActive {
			get {
				return GetTypedColumnValue<bool>("IsActive");
			}
			set {
				SetColumnValue("IsActive", value);
			}
		}

		/// <summary>
		/// Element identifier.
		/// </summary>
		public string Identifier {
			get {
				return GetTypedColumnValue<string>("Identifier");
			}
			set {
				SetColumnValue("Identifier", value);
			}
		}

		#endregion

	}

	#endregion

}

