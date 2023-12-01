﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EnrchFoundAccount

	/// <exclude/>
	public class EnrchFoundAccount : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public EnrchFoundAccount(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EnrchFoundAccount";
		}

		public EnrchFoundAccount(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "EnrchFoundAccount";
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
		public Guid EnrchTextEntityId {
			get {
				return GetTypedColumnValue<Guid>("EnrchTextEntityId");
			}
			set {
				SetColumnValue("EnrchTextEntityId", value);
				_enrchTextEntity = null;
			}
		}

		/// <exclude/>
		public string EnrchTextEntityHash {
			get {
				return GetTypedColumnValue<string>("EnrchTextEntityHash");
			}
			set {
				SetColumnValue("EnrchTextEntityHash", value);
				if (_enrchTextEntity != null) {
					_enrchTextEntity.Hash = value;
				}
			}
		}

		private EnrchTextEntity _enrchTextEntity;
		/// <summary>
		/// Mined entity.
		/// </summary>
		public EnrchTextEntity EnrchTextEntity {
			get {
				return _enrchTextEntity ??
					(_enrchTextEntity = new EnrchTextEntity(LookupColumnEntities.GetEntity("EnrchTextEntity")));
			}
		}

		/// <exclude/>
		public Guid AccountId {
			get {
				return GetTypedColumnValue<Guid>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
				_account = null;
			}
		}

		/// <exclude/>
		public string AccountName {
			get {
				return GetTypedColumnValue<string>("AccountName");
			}
			set {
				SetColumnValue("AccountName", value);
				if (_account != null) {
					_account.Name = value;
				}
			}
		}

		private Account _account;
		/// <summary>
		/// Account.
		/// </summary>
		public Account Account {
			get {
				return _account ??
					(_account = new Account(LookupColumnEntities.GetEntity("Account")));
			}
		}

		/// <summary>
		/// Identification type.
		/// </summary>
		public string IdentificationType {
			get {
				return GetTypedColumnValue<string>("IdentificationType");
			}
			set {
				SetColumnValue("IdentificationType", value);
			}
		}

		#endregion

	}

	#endregion

}

