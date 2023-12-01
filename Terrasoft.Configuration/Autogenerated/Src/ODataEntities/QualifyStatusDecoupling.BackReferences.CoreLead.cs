namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: QualifyStatusDecoupling

	/// <exclude/>
	public class QualifyStatusDecoupling : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public QualifyStatusDecoupling(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "QualifyStatusDecoupling";
		}

		public QualifyStatusDecoupling(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "QualifyStatusDecoupling";
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

		/// <exclude/>
		public Guid CurrentStatusId {
			get {
				return GetTypedColumnValue<Guid>("CurrentStatusId");
			}
			set {
				SetColumnValue("CurrentStatusId", value);
				_currentStatus = null;
			}
		}

		/// <exclude/>
		public string CurrentStatusName {
			get {
				return GetTypedColumnValue<string>("CurrentStatusName");
			}
			set {
				SetColumnValue("CurrentStatusName", value);
				if (_currentStatus != null) {
					_currentStatus.Name = value;
				}
			}
		}

		private QualifyStatus _currentStatus;
		/// <summary>
		/// Transition from.
		/// </summary>
		public QualifyStatus CurrentStatus {
			get {
				return _currentStatus ??
					(_currentStatus = new QualifyStatus(LookupColumnEntities.GetEntity("CurrentStatus")));
			}
		}

		/// <exclude/>
		public Guid AvailableStatusId {
			get {
				return GetTypedColumnValue<Guid>("AvailableStatusId");
			}
			set {
				SetColumnValue("AvailableStatusId", value);
				_availableStatus = null;
			}
		}

		/// <exclude/>
		public string AvailableStatusName {
			get {
				return GetTypedColumnValue<string>("AvailableStatusName");
			}
			set {
				SetColumnValue("AvailableStatusName", value);
				if (_availableStatus != null) {
					_availableStatus.Name = value;
				}
			}
		}

		private QualifyStatus _availableStatus;
		/// <summary>
		/// Transition to.
		/// </summary>
		public QualifyStatus AvailableStatus {
			get {
				return _availableStatus ??
					(_availableStatus = new QualifyStatus(LookupColumnEntities.GetEntity("AvailableStatus")));
			}
		}

		#endregion

	}

	#endregion

}

