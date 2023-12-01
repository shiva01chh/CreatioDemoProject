﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysEditPage

	/// <exclude/>
	public class SysEditPage : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public SysEditPage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysEditPage";
		}

		public SysEditPage(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "SysEditPage";
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
		public Guid SysPageSchemaId {
			get {
				return GetTypedColumnValue<Guid>("SysPageSchemaId");
			}
			set {
				SetColumnValue("SysPageSchemaId", value);
				_sysPageSchema = null;
			}
		}

		/// <exclude/>
		public string SysPageSchemaCaption {
			get {
				return GetTypedColumnValue<string>("SysPageSchemaCaption");
			}
			set {
				SetColumnValue("SysPageSchemaCaption", value);
				if (_sysPageSchema != null) {
					_sysPageSchema.Caption = value;
				}
			}
		}

		private SysSchema _sysPageSchema;
		/// <summary>
		/// Page.
		/// </summary>
		public SysSchema SysPageSchema {
			get {
				return _sysPageSchema ??
					(_sysPageSchema = new SysSchema(LookupColumnEntities.GetEntity("SysPageSchema")));
			}
		}

		/// <exclude/>
		public Guid SysGridPageId {
			get {
				return GetTypedColumnValue<Guid>("SysGridPageId");
			}
			set {
				SetColumnValue("SysGridPageId", value);
				_sysGridPage = null;
			}
		}

		private SysGridPage _sysGridPage;
		/// <summary>
		/// List page.
		/// </summary>
		public SysGridPage SysGridPage {
			get {
				return _sysGridPage ??
					(_sysGridPage = new SysGridPage(LookupColumnEntities.GetEntity("SysGridPage")));
			}
		}

		/// <exclude/>
		public Guid SysEntitySchemaId {
			get {
				return GetTypedColumnValue<Guid>("SysEntitySchemaId");
			}
			set {
				SetColumnValue("SysEntitySchemaId", value);
				_sysEntitySchema = null;
			}
		}

		/// <exclude/>
		public string SysEntitySchemaCaption {
			get {
				return GetTypedColumnValue<string>("SysEntitySchemaCaption");
			}
			set {
				SetColumnValue("SysEntitySchemaCaption", value);
				if (_sysEntitySchema != null) {
					_sysEntitySchema.Caption = value;
				}
			}
		}

		private SysSchema _sysEntitySchema;
		/// <summary>
		/// Object.
		/// </summary>
		public SysSchema SysEntitySchema {
			get {
				return _sysEntitySchema ??
					(_sysEntitySchema = new SysSchema(LookupColumnEntities.GetEntity("SysEntitySchema")));
			}
		}

		/// <summary>
		/// Type.
		/// </summary>
		public Guid TypeColumnValue {
			get {
				return GetTypedColumnValue<Guid>("TypeColumnValue");
			}
			set {
				SetColumnValue("TypeColumnValue", value);
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

		#endregion

	}

	#endregion

}

