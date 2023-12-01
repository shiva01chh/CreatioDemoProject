﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysSqlScriptDependency

	/// <exclude/>
	public class SysSqlScriptDependency : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public SysSqlScriptDependency(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysSqlScriptDependency";
		}

		public SysSqlScriptDependency(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "SysSqlScriptDependency";
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
		public Guid SysSqlScriptId {
			get {
				return GetTypedColumnValue<Guid>("SysSqlScriptId");
			}
			set {
				SetColumnValue("SysSqlScriptId", value);
				_sysSqlScript = null;
			}
		}

		/// <exclude/>
		public string SysSqlScriptName {
			get {
				return GetTypedColumnValue<string>("SysSqlScriptName");
			}
			set {
				SetColumnValue("SysSqlScriptName", value);
				if (_sysSqlScript != null) {
					_sysSqlScript.Name = value;
				}
			}
		}

		private SysPackageSqlScript _sysSqlScript;
		/// <summary>
		/// SQL script.
		/// </summary>
		public SysPackageSqlScript SysSqlScript {
			get {
				return _sysSqlScript ??
					(_sysSqlScript = new SysPackageSqlScript(LookupColumnEntities.GetEntity("SysSqlScript")));
			}
		}

		/// <exclude/>
		public Guid DependOnSqlScriptId {
			get {
				return GetTypedColumnValue<Guid>("DependOnSqlScriptId");
			}
			set {
				SetColumnValue("DependOnSqlScriptId", value);
				_dependOnSqlScript = null;
			}
		}

		/// <exclude/>
		public string DependOnSqlScriptName {
			get {
				return GetTypedColumnValue<string>("DependOnSqlScriptName");
			}
			set {
				SetColumnValue("DependOnSqlScriptName", value);
				if (_dependOnSqlScript != null) {
					_dependOnSqlScript.Name = value;
				}
			}
		}

		private SysPackageSqlScript _dependOnSqlScript;
		/// <summary>
		/// Depends on SQL script.
		/// </summary>
		public SysPackageSqlScript DependOnSqlScript {
			get {
				return _dependOnSqlScript ??
					(_dependOnSqlScript = new SysPackageSqlScript(LookupColumnEntities.GetEntity("DependOnSqlScript")));
			}
		}

		#endregion

	}

	#endregion

}

