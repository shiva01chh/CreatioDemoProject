namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwProjectHierarchy

	/// <exclude/>
	public class VwProjectHierarchy : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public VwProjectHierarchy(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwProjectHierarchy";
		}

		public VwProjectHierarchy(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "VwProjectHierarchy";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ProjectId {
			get {
				return GetTypedColumnValue<Guid>("ProjectId");
			}
			set {
				SetColumnValue("ProjectId", value);
				_project = null;
			}
		}

		/// <exclude/>
		public string ProjectName {
			get {
				return GetTypedColumnValue<string>("ProjectName");
			}
			set {
				SetColumnValue("ProjectName", value);
				if (_project != null) {
					_project.Name = value;
				}
			}
		}

		private Project _project;
		/// <summary>
		/// Project.
		/// </summary>
		public Project Project {
			get {
				return _project ??
					(_project = new Project(LookupColumnEntities.GetEntity("Project")));
			}
		}

		/// <exclude/>
		public Guid BaseProjectId {
			get {
				return GetTypedColumnValue<Guid>("BaseProjectId");
			}
			set {
				SetColumnValue("BaseProjectId", value);
				_baseProject = null;
			}
		}

		/// <exclude/>
		public string BaseProjectName {
			get {
				return GetTypedColumnValue<string>("BaseProjectName");
			}
			set {
				SetColumnValue("BaseProjectName", value);
				if (_baseProject != null) {
					_baseProject.Name = value;
				}
			}
		}

		private Project _baseProject;
		/// <summary>
		/// Base project.
		/// </summary>
		public Project BaseProject {
			get {
				return _baseProject ??
					(_baseProject = new Project(LookupColumnEntities.GetEntity("BaseProject")));
			}
		}

		/// <summary>
		/// First item in project.
		/// </summary>
		public bool IsFirst {
			get {
				return GetTypedColumnValue<bool>("IsFirst");
			}
			set {
				SetColumnValue("IsFirst", value);
			}
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

		#endregion

	}

	#endregion

}

