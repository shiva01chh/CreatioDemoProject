﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SsoSamlSettings

	/// <exclude/>
	public class SsoSamlSettings : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public SsoSamlSettings(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SsoSamlSettings";
		}

		public SsoSamlSettings(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "SsoSamlSettings";
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
		public Guid SsoProviderId {
			get {
				return GetTypedColumnValue<Guid>("SsoProviderId");
			}
			set {
				SetColumnValue("SsoProviderId", value);
				_ssoProvider = null;
			}
		}

		/// <exclude/>
		public string SsoProviderName {
			get {
				return GetTypedColumnValue<string>("SsoProviderName");
			}
			set {
				SetColumnValue("SsoProviderName", value);
				if (_ssoProvider != null) {
					_ssoProvider.Name = value;
				}
			}
		}

		private SsoProvider _ssoProvider;
		/// <summary>
		/// Sso identity provider.
		/// </summary>
		public SsoProvider SsoProvider {
			get {
				return _ssoProvider ??
					(_ssoProvider = new SsoProvider(LookupColumnEntities.GetEntity("SsoProvider")));
			}
		}

		/// <summary>
		/// Additional parameters.
		/// </summary>
		public string AdditionalParams {
			get {
				return GetTypedColumnValue<string>("AdditionalParams");
			}
			set {
				SetColumnValue("AdditionalParams", value);
			}
		}

		/// <summary>
		/// Partner certificate thumbprint.
		/// </summary>
		public string PartnerCertificateThumbprint {
			get {
				return GetTypedColumnValue<string>("PartnerCertificateThumbprint");
			}
			set {
				SetColumnValue("PartnerCertificateThumbprint", value);
			}
		}

		/// <summary>
		/// Single Sign On URL.
		/// </summary>
		public string SingleSignOnServiceUrl {
			get {
				return GetTypedColumnValue<string>("SingleSignOnServiceUrl");
			}
			set {
				SetColumnValue("SingleSignOnServiceUrl", value);
			}
		}

		/// <summary>
		/// Single Logout URL.
		/// </summary>
		public string SingleLogoutServiceUrl {
			get {
				return GetTypedColumnValue<string>("SingleLogoutServiceUrl");
			}
			set {
				SetColumnValue("SingleLogoutServiceUrl", value);
			}
		}

		/// <summary>
		/// Entity ID.
		/// </summary>
		public string EntityID {
			get {
				return GetTypedColumnValue<string>("EntityID");
			}
			set {
				SetColumnValue("EntityID", value);
			}
		}

		#endregion

	}

	#endregion

}

