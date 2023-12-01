namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Release

	/// <exclude/>
	public class Release : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public Release(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Release";
		}

		public Release(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "Release";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByRelease {
			get;
			set;
		}

		public IEnumerable<Change> ChangeCollectionByRelease {
			get;
			set;
		}

		public IEnumerable<ReleaseConfItem> ReleaseConfItemCollectionByRelease {
			get;
			set;
		}

		public IEnumerable<ReleaseFile> ReleaseFileCollectionByRelease {
			get;
			set;
		}

		public IEnumerable<ReleaseInFolder> ReleaseInFolderCollectionByRelease {
			get;
			set;
		}

		public IEnumerable<ReleaseInTag> ReleaseInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<ReleaseServiceItem> ReleaseServiceItemCollectionByRelease {
			get;
			set;
		}

		public IEnumerable<ReleaseTeam> ReleaseTeamCollectionByRelease {
			get;
			set;
		}

		public IEnumerable<ScheduledDate> ScheduledDateCollectionByRelease {
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
		/// Title.
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
		/// Number.
		/// </summary>
		public string Number {
			get {
				return GetTypedColumnValue<string>("Number");
			}
			set {
				SetColumnValue("Number", value);
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
		/// Scheduled release date.
		/// </summary>
		public DateTime ScheduledReleaseDate {
			get {
				return GetTypedColumnValue<DateTime>("ScheduledReleaseDate");
			}
			set {
				SetColumnValue("ScheduledReleaseDate", value);
			}
		}

		/// <summary>
		/// Estimated working time (hours).
		/// </summary>
		public int PlannedLabor {
			get {
				return GetTypedColumnValue<int>("PlannedLabor");
			}
			set {
				SetColumnValue("PlannedLabor", value);
			}
		}

		/// <summary>
		/// Actual release date.
		/// </summary>
		public DateTime ReleasedOn {
			get {
				return GetTypedColumnValue<DateTime>("ReleasedOn");
			}
			set {
				SetColumnValue("ReleasedOn", value);
			}
		}

		/// <summary>
		/// Actual end of development.
		/// </summary>
		public DateTime DevelopmentFinishedOn {
			get {
				return GetTypedColumnValue<DateTime>("DevelopmentFinishedOn");
			}
			set {
				SetColumnValue("DevelopmentFinishedOn", value);
			}
		}

		/// <summary>
		/// Actual end of testing.
		/// </summary>
		public DateTime TestingFinishedOn {
			get {
				return GetTypedColumnValue<DateTime>("TestingFinishedOn");
			}
			set {
				SetColumnValue("TestingFinishedOn", value);
			}
		}

		/// <summary>
		/// Actual end of deployment.
		/// </summary>
		public DateTime DeploymentFinishedOn {
			get {
				return GetTypedColumnValue<DateTime>("DeploymentFinishedOn");
			}
			set {
				SetColumnValue("DeploymentFinishedOn", value);
			}
		}

		/// <summary>
		/// Actual working time.
		/// </summary>
		public int ActualLabor {
			get {
				return GetTypedColumnValue<int>("ActualLabor");
			}
			set {
				SetColumnValue("ActualLabor", value);
			}
		}

		/// <summary>
		/// Actual development time.
		/// </summary>
		public int ActualDevelopmentLabor {
			get {
				return GetTypedColumnValue<int>("ActualDevelopmentLabor");
			}
			set {
				SetColumnValue("ActualDevelopmentLabor", value);
			}
		}

		/// <summary>
		/// Actual testing time.
		/// </summary>
		public int ActualTestingLabor {
			get {
				return GetTypedColumnValue<int>("ActualTestingLabor");
			}
			set {
				SetColumnValue("ActualTestingLabor", value);
			}
		}

		/// <summary>
		/// Actual deployment time.
		/// </summary>
		public int ActualDeploymentLabor {
			get {
				return GetTypedColumnValue<int>("ActualDeploymentLabor");
			}
			set {
				SetColumnValue("ActualDeploymentLabor", value);
			}
		}

		/// <exclude/>
		public Guid StatusId {
			get {
				return GetTypedColumnValue<Guid>("StatusId");
			}
			set {
				SetColumnValue("StatusId", value);
				_status = null;
			}
		}

		/// <exclude/>
		public string StatusName {
			get {
				return GetTypedColumnValue<string>("StatusName");
			}
			set {
				SetColumnValue("StatusName", value);
				if (_status != null) {
					_status.Name = value;
				}
			}
		}

		private ReleaseStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public ReleaseStatus Status {
			get {
				return _status ??
					(_status = new ReleaseStatus(LookupColumnEntities.GetEntity("Status")));
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private ReleaseType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public ReleaseType Type {
			get {
				return _type ??
					(_type = new ReleaseType(LookupColumnEntities.GetEntity("Type")));
			}
		}

		/// <exclude/>
		public Guid PriorityId {
			get {
				return GetTypedColumnValue<Guid>("PriorityId");
			}
			set {
				SetColumnValue("PriorityId", value);
				_priority = null;
			}
		}

		/// <exclude/>
		public string PriorityName {
			get {
				return GetTypedColumnValue<string>("PriorityName");
			}
			set {
				SetColumnValue("PriorityName", value);
				if (_priority != null) {
					_priority.Name = value;
				}
			}
		}

		private ReleasePriority _priority;
		/// <summary>
		/// Priority.
		/// </summary>
		public ReleasePriority Priority {
			get {
				return _priority ??
					(_priority = new ReleasePriority(LookupColumnEntities.GetEntity("Priority")));
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
			}
		}

		#endregion

	}

	#endregion

}

