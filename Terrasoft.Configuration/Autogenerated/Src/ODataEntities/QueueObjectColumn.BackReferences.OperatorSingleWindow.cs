namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: QueueObjectColumn

	/// <exclude/>
	public class QueueObjectColumn : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public QueueObjectColumn(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "QueueObjectColumn";
		}

		public QueueObjectColumn(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "QueueObjectColumn";
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
		/// Title.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
		}

		/// <exclude/>
		public Guid OrderDirectionId {
			get {
				return GetTypedColumnValue<Guid>("OrderDirectionId");
			}
			set {
				SetColumnValue("OrderDirectionId", value);
				_orderDirection = null;
			}
		}

		/// <exclude/>
		public string OrderDirectionName {
			get {
				return GetTypedColumnValue<string>("OrderDirectionName");
			}
			set {
				SetColumnValue("OrderDirectionName", value);
				if (_orderDirection != null) {
					_orderDirection.Name = value;
				}
			}
		}

		private SysOrderDirection _orderDirection;
		/// <summary>
		/// Sorting order.
		/// </summary>
		public SysOrderDirection OrderDirection {
			get {
				return _orderDirection ??
					(_orderDirection = new SysOrderDirection(LookupColumnEntities.GetEntity("OrderDirection")));
			}
		}

		/// <exclude/>
		public Guid QueueObjectId {
			get {
				return GetTypedColumnValue<Guid>("QueueObjectId");
			}
			set {
				SetColumnValue("QueueObjectId", value);
				_queueObject = null;
			}
		}

		/// <exclude/>
		public string QueueObjectEntitySchemaCaption {
			get {
				return GetTypedColumnValue<string>("QueueObjectEntitySchemaCaption");
			}
			set {
				SetColumnValue("QueueObjectEntitySchemaCaption", value);
				if (_queueObject != null) {
					_queueObject.EntitySchemaCaption = value;
				}
			}
		}

		private QueueObject _queueObject;
		/// <summary>
		/// Queue object.
		/// </summary>
		public QueueObject QueueObject {
			get {
				return _queueObject ??
					(_queueObject = new QueueObject(LookupColumnEntities.GetEntity("QueueObject")));
			}
		}

		/// <summary>
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		#endregion

	}

	#endregion

}

