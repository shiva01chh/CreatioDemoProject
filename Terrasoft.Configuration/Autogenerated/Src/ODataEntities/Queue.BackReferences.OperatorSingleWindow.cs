namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Queue

	/// <exclude/>
	public class Queue : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public Queue(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Queue";
		}

		public Queue(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "Queue";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<QueueFilteredItem> QueueFilteredItemCollectionByQueue {
			get;
			set;
		}

		public IEnumerable<QueueInFolder> QueueInFolderCollectionByQueue {
			get;
			set;
		}

		public IEnumerable<QueueInTag> QueueInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<QueueItem> QueueItemCollectionByQueue {
			get;
			set;
		}

		public IEnumerable<QueueOperator> QueueOperatorCollectionByQueue {
			get;
			set;
		}

		public IEnumerable<VwQueueItem> VwQueueItemCollectionByQueue {
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

		/// <summary>
		/// Deprecated queue.
		/// </summary>
		public Guid EntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaUId");
			}
			set {
				SetColumnValue("EntitySchemaUId", value);
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

		private QueuePriority _priority;
		/// <summary>
		/// Priority.
		/// </summary>
		public QueuePriority Priority {
			get {
				return _priority ??
					(_priority = new QueuePriority(LookupColumnEntities.GetEntity("Priority")));
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

		private QueueStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public QueueStatus Status {
			get {
				return _status ??
					(_status = new QueueStatus(LookupColumnEntities.GetEntity("Status")));
			}
		}

		/// <summary>
		/// Deprecated process.
		/// </summary>
		public Guid ProcessSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("ProcessSchemaUId");
			}
			set {
				SetColumnValue("ProcessSchemaUId", value);
			}
		}

		/// <summary>
		/// Deprecated queue title.
		/// </summary>
		public string EntitySchemaCaption {
			get {
				return GetTypedColumnValue<string>("EntitySchemaCaption");
			}
			set {
				SetColumnValue("EntitySchemaCaption", value);
			}
		}

		/// <summary>
		/// Deprecated process title.
		/// </summary>
		public string ProcessSchemaCaption {
			get {
				return GetTypedColumnValue<string>("ProcessSchemaCaption");
			}
			set {
				SetColumnValue("ProcessSchemaCaption", value);
			}
		}

		/// <summary>
		/// Queue object filter.
		/// </summary>
		public string FilterData {
			get {
				return GetTypedColumnValue<string>("FilterData");
			}
			set {
				SetColumnValue("FilterData", value);
			}
		}

		/// <summary>
		/// Filtering object - Queue object.
		/// </summary>
		public string FilterEditData {
			get {
				return GetTypedColumnValue<string>("FilterEditData");
			}
			set {
				SetColumnValue("FilterEditData", value);
			}
		}

		/// <summary>
		/// Fill in manually.
		/// </summary>
		public bool IsManuallyFilling {
			get {
				return GetTypedColumnValue<bool>("IsManuallyFilling");
			}
			set {
				SetColumnValue("IsManuallyFilling", value);
			}
		}

		/// <exclude/>
		public Guid QueueEntitySchemaId {
			get {
				return GetTypedColumnValue<Guid>("QueueEntitySchemaId");
			}
			set {
				SetColumnValue("QueueEntitySchemaId", value);
				_queueEntitySchema = null;
			}
		}

		/// <exclude/>
		public string QueueEntitySchemaCaption {
			get {
				return GetTypedColumnValue<string>("QueueEntitySchemaCaption");
			}
			set {
				SetColumnValue("QueueEntitySchemaCaption", value);
				if (_queueEntitySchema != null) {
					_queueEntitySchema.Caption = value;
				}
			}
		}

		private VwQueueSysSchema _queueEntitySchema;
		/// <summary>
		/// Queue type.
		/// </summary>
		public VwQueueSysSchema QueueEntitySchema {
			get {
				return _queueEntitySchema ??
					(_queueEntitySchema = new VwQueueSysSchema(LookupColumnEntities.GetEntity("QueueEntitySchema")));
			}
		}

		/// <exclude/>
		public Guid BusinessProcessSchemaId {
			get {
				return GetTypedColumnValue<Guid>("BusinessProcessSchemaId");
			}
			set {
				SetColumnValue("BusinessProcessSchemaId", value);
				_businessProcessSchema = null;
			}
		}

		/// <exclude/>
		public string BusinessProcessSchemaCaption {
			get {
				return GetTypedColumnValue<string>("BusinessProcessSchemaCaption");
			}
			set {
				SetColumnValue("BusinessProcessSchemaCaption", value);
				if (_businessProcessSchema != null) {
					_businessProcessSchema.Caption = value;
				}
			}
		}

		private VwQueueSysProcess _businessProcessSchema;
		/// <summary>
		/// Business process.
		/// </summary>
		public VwQueueSysProcess BusinessProcessSchema {
			get {
				return _businessProcessSchema ??
					(_businessProcessSchema = new VwQueueSysProcess(LookupColumnEntities.GetEntity("BusinessProcessSchema")));
			}
		}

		/// <exclude/>
		public Guid QueueUpdateFrequencyId {
			get {
				return GetTypedColumnValue<Guid>("QueueUpdateFrequencyId");
			}
			set {
				SetColumnValue("QueueUpdateFrequencyId", value);
				_queueUpdateFrequency = null;
			}
		}

		/// <exclude/>
		public string QueueUpdateFrequencyName {
			get {
				return GetTypedColumnValue<string>("QueueUpdateFrequencyName");
			}
			set {
				SetColumnValue("QueueUpdateFrequencyName", value);
				if (_queueUpdateFrequency != null) {
					_queueUpdateFrequency.Name = value;
				}
			}
		}

		private QueueUpdateFrequency _queueUpdateFrequency;
		/// <summary>
		/// Update frequency.
		/// </summary>
		public QueueUpdateFrequency QueueUpdateFrequency {
			get {
				return _queueUpdateFrequency ??
					(_queueUpdateFrequency = new QueueUpdateFrequency(LookupColumnEntities.GetEntity("QueueUpdateFrequency")));
			}
		}

		#endregion

	}

	#endregion

}

