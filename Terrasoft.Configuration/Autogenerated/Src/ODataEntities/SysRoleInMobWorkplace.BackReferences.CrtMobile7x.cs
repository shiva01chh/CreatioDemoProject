﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysRoleInMobWorkplace

	/// <exclude/>
	public class SysRoleInMobWorkplace : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public SysRoleInMobWorkplace(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysRoleInMobWorkplace";
		}

		public SysRoleInMobWorkplace(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "SysRoleInMobWorkplace";
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
		public Guid SysRoleId {
			get {
				return GetTypedColumnValue<Guid>("SysRoleId");
			}
			set {
				SetColumnValue("SysRoleId", value);
				_sysRole = null;
			}
		}

		/// <exclude/>
		public string SysRoleName {
			get {
				return GetTypedColumnValue<string>("SysRoleName");
			}
			set {
				SetColumnValue("SysRoleName", value);
				if (_sysRole != null) {
					_sysRole.Name = value;
				}
			}
		}

		private SysAdminUnit _sysRole;
		/// <summary>
		/// Role.
		/// </summary>
		public SysAdminUnit SysRole {
			get {
				return _sysRole ??
					(_sysRole = new SysAdminUnit(LookupColumnEntities.GetEntity("SysRole")));
			}
		}

		/// <exclude/>
		public Guid SysMobileWorkplaceId {
			get {
				return GetTypedColumnValue<Guid>("SysMobileWorkplaceId");
			}
			set {
				SetColumnValue("SysMobileWorkplaceId", value);
				_sysMobileWorkplace = null;
			}
		}

		/// <exclude/>
		public string SysMobileWorkplaceName {
			get {
				return GetTypedColumnValue<string>("SysMobileWorkplaceName");
			}
			set {
				SetColumnValue("SysMobileWorkplaceName", value);
				if (_sysMobileWorkplace != null) {
					_sysMobileWorkplace.Name = value;
				}
			}
		}

		private SysMobileWorkplace _sysMobileWorkplace;
		/// <summary>
		/// Mobile application workplace.
		/// </summary>
		public SysMobileWorkplace SysMobileWorkplace {
			get {
				return _sysMobileWorkplace ??
					(_sysMobileWorkplace = new SysMobileWorkplace(LookupColumnEntities.GetEntity("SysMobileWorkplace")));
			}
		}

		#endregion

	}

	#endregion

}

