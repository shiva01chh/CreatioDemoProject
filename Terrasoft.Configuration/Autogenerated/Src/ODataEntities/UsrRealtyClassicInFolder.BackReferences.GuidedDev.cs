﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: UsrRealtyClassicInFolder

	/// <exclude/>
	public class UsrRealtyClassicInFolder : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public UsrRealtyClassicInFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrRealtyClassicInFolder";
		}

		public UsrRealtyClassicInFolder(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "UsrRealtyClassicInFolder";
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

		/// <exclude/>
		public Guid FolderId {
			get {
				return GetTypedColumnValue<Guid>("FolderId");
			}
			set {
				SetColumnValue("FolderId", value);
				_folder = null;
			}
		}

		/// <exclude/>
		public string FolderName {
			get {
				return GetTypedColumnValue<string>("FolderName");
			}
			set {
				SetColumnValue("FolderName", value);
				if (_folder != null) {
					_folder.Name = value;
				}
			}
		}

		private UsrRealtyClassicFolder _folder;
		/// <summary>
		/// Realty (Classic UI) folder.
		/// </summary>
		public UsrRealtyClassicFolder Folder {
			get {
				return _folder ??
					(_folder = new UsrRealtyClassicFolder(LookupColumnEntities.GetEntity("Folder")));
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
		public Guid UsrRealtyClassicId {
			get {
				return GetTypedColumnValue<Guid>("UsrRealtyClassicId");
			}
			set {
				SetColumnValue("UsrRealtyClassicId", value);
				_usrRealtyClassic = null;
			}
		}

		/// <exclude/>
		public string UsrRealtyClassicUsrName {
			get {
				return GetTypedColumnValue<string>("UsrRealtyClassicUsrName");
			}
			set {
				SetColumnValue("UsrRealtyClassicUsrName", value);
				if (_usrRealtyClassic != null) {
					_usrRealtyClassic.UsrName = value;
				}
			}
		}

		private UsrRealtyClassic _usrRealtyClassic;
		/// <summary>
		/// Realty (Classic UI).
		/// </summary>
		public UsrRealtyClassic UsrRealtyClassic {
			get {
				return _usrRealtyClassic ??
					(_usrRealtyClassic = new UsrRealtyClassic(LookupColumnEntities.GetEntity("UsrRealtyClassic")));
			}
		}

		#endregion

	}

	#endregion

}

