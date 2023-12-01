namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BulkEmailCountLimit

	/// <exclude/>
	public class BulkEmailCountLimit : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public BulkEmailCountLimit(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmailCountLimit";
		}

		public BulkEmailCountLimit(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "BulkEmailCountLimit";
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
		/// Maximum sending.
		/// </summary>
		public int MailingLimitCount {
			get {
				return GetTypedColumnValue<int>("MailingLimitCount");
			}
			set {
				SetColumnValue("MailingLimitCount", value);
			}
		}

		/// <summary>
		/// Period, days.
		/// </summary>
		public int MailingLimitPeriod {
			get {
				return GetTypedColumnValue<int>("MailingLimitPeriod");
			}
			set {
				SetColumnValue("MailingLimitPeriod", value);
			}
		}

		/// <exclude/>
		public Guid OverlimitResponseId {
			get {
				return GetTypedColumnValue<Guid>("OverlimitResponseId");
			}
			set {
				SetColumnValue("OverlimitResponseId", value);
				_overlimitResponse = null;
			}
		}

		/// <exclude/>
		public string OverlimitResponseName {
			get {
				return GetTypedColumnValue<string>("OverlimitResponseName");
			}
			set {
				SetColumnValue("OverlimitResponseName", value);
				if (_overlimitResponse != null) {
					_overlimitResponse.Name = value;
				}
			}
		}

		private BulkEmailResponse _overlimitResponse;
		/// <summary>
		/// Response.
		/// </summary>
		public BulkEmailResponse OverlimitResponse {
			get {
				return _overlimitResponse ??
					(_overlimitResponse = new BulkEmailResponse(LookupColumnEntities.GetEntity("OverlimitResponse")));
			}
		}

		/// <summary>
		/// Name.
		/// </summary>
		public string Title {
			get {
				return GetTypedColumnValue<string>("Title");
			}
			set {
				SetColumnValue("Title", value);
			}
		}

		/// <exclude/>
		public Guid EmailCategoryId {
			get {
				return GetTypedColumnValue<Guid>("EmailCategoryId");
			}
			set {
				SetColumnValue("EmailCategoryId", value);
				_emailCategory = null;
			}
		}

		/// <exclude/>
		public string EmailCategoryName {
			get {
				return GetTypedColumnValue<string>("EmailCategoryName");
			}
			set {
				SetColumnValue("EmailCategoryName", value);
				if (_emailCategory != null) {
					_emailCategory.Name = value;
				}
			}
		}

		private BulkEmailCategory _emailCategory;
		/// <summary>
		/// Email category.
		/// </summary>
		public BulkEmailCategory EmailCategory {
			get {
				return _emailCategory ??
					(_emailCategory = new BulkEmailCategory(LookupColumnEntities.GetEntity("EmailCategory")));
			}
		}

		/// <exclude/>
		public Guid EmailTypeId {
			get {
				return GetTypedColumnValue<Guid>("EmailTypeId");
			}
			set {
				SetColumnValue("EmailTypeId", value);
				_emailType = null;
			}
		}

		/// <exclude/>
		public string EmailTypeName {
			get {
				return GetTypedColumnValue<string>("EmailTypeName");
			}
			set {
				SetColumnValue("EmailTypeName", value);
				if (_emailType != null) {
					_emailType.Name = value;
				}
			}
		}

		private BulkEmailType _emailType;
		/// <summary>
		/// Email type.
		/// </summary>
		public BulkEmailType EmailType {
			get {
				return _emailType ??
					(_emailType = new BulkEmailType(LookupColumnEntities.GetEntity("EmailType")));
			}
		}

		#endregion

	}

	#endregion

}

