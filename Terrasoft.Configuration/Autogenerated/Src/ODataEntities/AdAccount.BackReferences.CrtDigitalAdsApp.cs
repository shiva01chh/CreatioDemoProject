namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AdAccount

	/// <exclude/>
	public class AdAccount : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public AdAccount(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AdAccount";
		}

		public AdAccount(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "AdAccount";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AdCampaign> AdCampaignCollectionByAdAccount {
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
		/// Account Id.
		/// </summary>
		public string AccountId {
			get {
				return GetTypedColumnValue<string>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
			}
		}

		/// <exclude/>
		public Guid ConnectionStatusId {
			get {
				return GetTypedColumnValue<Guid>("ConnectionStatusId");
			}
			set {
				SetColumnValue("ConnectionStatusId", value);
				_connectionStatus = null;
			}
		}

		/// <exclude/>
		public string ConnectionStatusName {
			get {
				return GetTypedColumnValue<string>("ConnectionStatusName");
			}
			set {
				SetColumnValue("ConnectionStatusName", value);
				if (_connectionStatus != null) {
					_connectionStatus.Name = value;
				}
			}
		}

		private AdAccountConnectionState _connectionStatus;
		/// <summary>
		/// Connection status.
		/// </summary>
		public AdAccountConnectionState ConnectionStatus {
			get {
				return _connectionStatus ??
					(_connectionStatus = new AdAccountConnectionState(LookupColumnEntities.GetEntity("ConnectionStatus")));
			}
		}

		/// <exclude/>
		public Guid AdPlatformId {
			get {
				return GetTypedColumnValue<Guid>("AdPlatformId");
			}
			set {
				SetColumnValue("AdPlatformId", value);
				_adPlatform = null;
			}
		}

		/// <exclude/>
		public string AdPlatformName {
			get {
				return GetTypedColumnValue<string>("AdPlatformName");
			}
			set {
				SetColumnValue("AdPlatformName", value);
				if (_adPlatform != null) {
					_adPlatform.Name = value;
				}
			}
		}

		private AdPlatform _adPlatform;
		/// <summary>
		/// Platform.
		/// </summary>
		public AdPlatform AdPlatform {
			get {
				return _adPlatform ??
					(_adPlatform = new AdPlatform(LookupColumnEntities.GetEntity("AdPlatform")));
			}
		}

		/// <summary>
		/// Ad account link.
		/// </summary>
		/// <remarks>
		/// Link to ad account in ad platform.
		/// </remarks>
		public string AdAccountUrl {
			get {
				return GetTypedColumnValue<string>("AdAccountUrl");
			}
			set {
				SetColumnValue("AdAccountUrl", value);
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

		#endregion

	}

	#endregion

}

