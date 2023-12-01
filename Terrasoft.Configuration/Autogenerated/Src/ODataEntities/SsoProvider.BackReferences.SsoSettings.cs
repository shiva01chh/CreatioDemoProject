namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SsoProvider

	/// <exclude/>
	public class SsoProvider : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public SsoProvider(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SsoProvider";
		}

		public SsoProvider(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "SsoProvider";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SsoOpenIdSettings> SsoOpenIdSettingsCollectionBySsoProvider {
			get;
			set;
		}

		public IEnumerable<SsoSamlSettings> SsoSamlSettingsCollectionBySsoProvider {
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
		/// Display name.
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
		public Guid SsoSettingsTemplateId {
			get {
				return GetTypedColumnValue<Guid>("SsoSettingsTemplateId");
			}
			set {
				SetColumnValue("SsoSettingsTemplateId", value);
				_ssoSettingsTemplate = null;
			}
		}

		/// <exclude/>
		public string SsoSettingsTemplateName {
			get {
				return GetTypedColumnValue<string>("SsoSettingsTemplateName");
			}
			set {
				SetColumnValue("SsoSettingsTemplateName", value);
				if (_ssoSettingsTemplate != null) {
					_ssoSettingsTemplate.Name = value;
				}
			}
		}

		private SsoSettingsTemplate _ssoSettingsTemplate;
		/// <summary>
		/// Settings template.
		/// </summary>
		public SsoSettingsTemplate SsoSettingsTemplate {
			get {
				return _ssoSettingsTemplate ??
					(_ssoSettingsTemplate = new SsoSettingsTemplate(LookupColumnEntities.GetEntity("SsoSettingsTemplate")));
			}
		}

		#endregion

	}

	#endregion

}

