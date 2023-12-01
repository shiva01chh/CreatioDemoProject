﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: QueueItem

	/// <exclude/>
	public class QueueItem : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public QueueItem(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "QueueItem";
		}

		public QueueItem(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "QueueItem";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<VwLastActivityByQueue> VwLastActivityByQueueCollectionByQueueItem {
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

		/// <exclude/>
		public Guid QueueId {
			get {
				return GetTypedColumnValue<Guid>("QueueId");
			}
			set {
				SetColumnValue("QueueId", value);
				_queue = null;
			}
		}

		/// <exclude/>
		public string QueueName {
			get {
				return GetTypedColumnValue<string>("QueueName");
			}
			set {
				SetColumnValue("QueueName", value);
				if (_queue != null) {
					_queue.Name = value;
				}
			}
		}

		private Queue _queue;
		/// <summary>
		/// Queue.
		/// </summary>
		public Queue Queue {
			get {
				return _queue ??
					(_queue = new Queue(LookupColumnEntities.GetEntity("Queue")));
			}
		}

		/// <summary>
		/// Related object record Id.
		/// </summary>
		public Guid EntityRecordId {
			get {
				return GetTypedColumnValue<Guid>("EntityRecordId");
			}
			set {
				SetColumnValue("EntityRecordId", value);
			}
		}

		/// <summary>
		/// Item of running process.
		/// </summary>
		public Guid SysProcessDataId {
			get {
				return GetTypedColumnValue<Guid>("SysProcessDataId");
			}
			set {
				SetColumnValue("SysProcessDataId", value);
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

		private QueueItemStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public QueueItemStatus Status {
			get {
				return _status ??
					(_status = new QueueItemStatus(LookupColumnEntities.GetEntity("Status")));
			}
		}

		/// <exclude/>
		public Guid OperatorId {
			get {
				return GetTypedColumnValue<Guid>("OperatorId");
			}
			set {
				SetColumnValue("OperatorId", value);
				_operator = null;
			}
		}

		/// <exclude/>
		public string OperatorName {
			get {
				return GetTypedColumnValue<string>("OperatorName");
			}
			set {
				SetColumnValue("OperatorName", value);
				if (_operator != null) {
					_operator.Name = value;
				}
			}
		}

		private Contact _operator;
		/// <summary>
		/// Operator.
		/// </summary>
		public Contact Operator {
			get {
				return _operator ??
					(_operator = new Contact(LookupColumnEntities.GetEntity("Operator")));
			}
		}

		/// <summary>
		/// Date.
		/// </summary>
		public DateTime NextProcessingDate {
			get {
				return GetTypedColumnValue<DateTime>("NextProcessingDate");
			}
			set {
				SetColumnValue("NextProcessingDate", value);
			}
		}

		/// <summary>
		/// Postponements.
		/// </summary>
		public int PostponesCount {
			get {
				return GetTypedColumnValue<int>("PostponesCount");
			}
			set {
				SetColumnValue("PostponesCount", value);
			}
		}

		/// <summary>
		/// Sorting order - Processing date.
		/// </summary>
		public int NextProcessingDateOrder {
			get {
				return GetTypedColumnValue<int>("NextProcessingDateOrder");
			}
			set {
				SetColumnValue("NextProcessingDateOrder", value);
			}
		}

		/// <summary>
		/// Caption.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
		}

		#endregion

	}

	#endregion

}

