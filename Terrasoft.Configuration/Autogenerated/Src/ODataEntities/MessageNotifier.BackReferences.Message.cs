﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MessageNotifier

	/// <exclude/>
	public class MessageNotifier : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public MessageNotifier(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MessageNotifier";
		}

		public MessageNotifier(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "MessageNotifier";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<CaseMessageHistory> CaseMessageHistoryCollectionByMessageNotifier {
			get;
			set;
		}

		public IEnumerable<LeadMessageHistory> LeadMessageHistoryCollectionByMessageNotifier {
			get;
			set;
		}

		public IEnumerable<ListenerByNotifier> ListenerByNotifierCollectionByMessageNotifier {
			get;
			set;
		}

		public IEnumerable<MessageNotifier> MessageNotifierCollectionByAliasNotifier {
			get;
			set;
		}

		public IEnumerable<MessageNotifierBySection> MessageNotifierBySectionCollectionByMessageNotifier {
			get;
			set;
		}

		public IEnumerable<VwMobileCaseMessageHistory> VwMobileCaseMessageHistoryCollectionByMessageNotifier {
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
		/// Notifier schema.
		/// </summary>
		public Guid SchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SchemaUId");
			}
			set {
				SetColumnValue("SchemaUId", value);
			}
		}

		/// <summary>
		/// Class name.
		/// </summary>
		public string ClassName {
			get {
				return GetTypedColumnValue<string>("ClassName");
			}
			set {
				SetColumnValue("ClassName", value);
			}
		}

		/// <exclude/>
		public Guid AliasNotifierId {
			get {
				return GetTypedColumnValue<Guid>("AliasNotifierId");
			}
			set {
				SetColumnValue("AliasNotifierId", value);
				_aliasNotifier = null;
			}
		}

		/// <exclude/>
		public string AliasNotifierName {
			get {
				return GetTypedColumnValue<string>("AliasNotifierName");
			}
			set {
				SetColumnValue("AliasNotifierName", value);
				if (_aliasNotifier != null) {
					_aliasNotifier.Name = value;
				}
			}
		}

		private MessageNotifier _aliasNotifier;
		/// <summary>
		/// AliasNotifier.
		/// </summary>
		public MessageNotifier AliasNotifier {
			get {
				return _aliasNotifier ??
					(_aliasNotifier = new MessageNotifier(LookupColumnEntities.GetEntity("AliasNotifier")));
			}
		}

		/// <summary>
		/// Class name for MessageHistoryV2.
		/// </summary>
		public string HistoryV2ClassName {
			get {
				return GetTypedColumnValue<string>("HistoryV2ClassName");
			}
			set {
				SetColumnValue("HistoryV2ClassName", value);
			}
		}

		#endregion

	}

	#endregion

}

