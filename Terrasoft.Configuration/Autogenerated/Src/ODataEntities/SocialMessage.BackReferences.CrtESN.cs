﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SocialMessage

	/// <exclude/>
	public class SocialMessage : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public SocialMessage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SocialMessage";
		}

		public SocialMessage(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "SocialMessage";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ESNNotification> ESNNotificationCollectionBySocialMessage {
			get;
			set;
		}

		public IEnumerable<SocialLike> SocialLikeCollectionBySocialMessage {
			get;
			set;
		}

		public IEnumerable<SocialMention> SocialMentionCollectionBySocialMessage {
			get;
			set;
		}

		public IEnumerable<SocialMessage> SocialMessageCollectionByParent {
			get;
			set;
		}

		public IEnumerable<SocialMessageEntity> SocialMessageEntityCollectionBySocialMessage {
			get;
			set;
		}

		public IEnumerable<VwSocialSubscription> VwSocialSubscriptionCollectionBySocialMessage {
			get;
			set;
		}

		public IEnumerable<VwSocialUnsubscription> VwSocialUnsubscriptionCollectionBySocialMessage {
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
		/// Contact.
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
		/// Schema.
		/// </summary>
		public Guid EntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaUId");
			}
			set {
				SetColumnValue("EntitySchemaUId", value);
			}
		}

		/// <summary>
		/// Object instance.
		/// </summary>
		public Guid EntityId {
			get {
				return GetTypedColumnValue<Guid>("EntityId");
			}
			set {
				SetColumnValue("EntityId", value);
			}
		}

		/// <summary>
		/// Message/comment.
		/// </summary>
		public string Message {
			get {
				return GetTypedColumnValue<string>("Message");
			}
			set {
				SetColumnValue("Message", value);
			}
		}

		/// <exclude/>
		public Guid ParentId {
			get {
				return GetTypedColumnValue<Guid>("ParentId");
			}
			set {
				SetColumnValue("ParentId", value);
				_parent = null;
			}
		}

		/// <exclude/>
		public string ParentMessage {
			get {
				return GetTypedColumnValue<string>("ParentMessage");
			}
			set {
				SetColumnValue("ParentMessage", value);
				if (_parent != null) {
					_parent.Message = value;
				}
			}
		}

		private SocialMessage _parent;
		/// <summary>
		/// Parent message.
		/// </summary>
		public SocialMessage Parent {
			get {
				return _parent ??
					(_parent = new SocialMessage(LookupColumnEntities.GetEntity("Parent")));
			}
		}

		/// <summary>
		/// Number of likes.
		/// </summary>
		public int LikeCount {
			get {
				return GetTypedColumnValue<int>("LikeCount");
			}
			set {
				SetColumnValue("LikeCount", value);
			}
		}

		/// <summary>
		/// Number of comments.
		/// </summary>
		public int CommentCount {
			get {
				return GetTypedColumnValue<int>("CommentCount");
			}
			set {
				SetColumnValue("CommentCount", value);
			}
		}

		/// <summary>
		/// Last action.
		/// </summary>
		public DateTime LastActionOn {
			get {
				return GetTypedColumnValue<DateTime>("LastActionOn");
			}
			set {
				SetColumnValue("LastActionOn", value);
			}
		}

		/// <summary>
		/// UserAccess.
		/// </summary>
		public int UserAccess {
			get {
				return GetTypedColumnValue<int>("UserAccess");
			}
			set {
				SetColumnValue("UserAccess", value);
			}
		}

		/// <summary>
		/// Number of external comments.
		/// </summary>
		public int ExternalCommentCount {
			get {
				return GetTypedColumnValue<int>("ExternalCommentCount");
			}
			set {
				SetColumnValue("ExternalCommentCount", value);
			}
		}

		#endregion

	}

	#endregion

}

