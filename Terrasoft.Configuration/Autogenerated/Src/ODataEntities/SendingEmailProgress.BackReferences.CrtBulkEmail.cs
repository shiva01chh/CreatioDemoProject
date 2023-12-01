namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SendingEmailProgress

	/// <exclude/>
	public class SendingEmailProgress : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public SendingEmailProgress(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SendingEmailProgress";
		}

		public SendingEmailProgress(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "SendingEmailProgress";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Prepared recipients count.
		/// </summary>
		public int PreparedRecipientsCount {
			get {
				return GetTypedColumnValue<int>("PreparedRecipientsCount");
			}
			set {
				SetColumnValue("PreparedRecipientsCount", value);
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
		public Guid BulkEmailId {
			get {
				return GetTypedColumnValue<Guid>("BulkEmailId");
			}
			set {
				SetColumnValue("BulkEmailId", value);
				_bulkEmail = null;
			}
		}

		/// <exclude/>
		public string BulkEmailName {
			get {
				return GetTypedColumnValue<string>("BulkEmailName");
			}
			set {
				SetColumnValue("BulkEmailName", value);
				if (_bulkEmail != null) {
					_bulkEmail.Name = value;
				}
			}
		}

		private BulkEmail _bulkEmail;
		/// <summary>
		/// Email.
		/// </summary>
		public BulkEmail BulkEmail {
			get {
				return _bulkEmail ??
					(_bulkEmail = new BulkEmail(LookupColumnEntities.GetEntity("BulkEmail")));
			}
		}

		/// <summary>
		/// Processed recipients count.
		/// </summary>
		public int ProcessedRecipientCount {
			get {
				return GetTypedColumnValue<int>("ProcessedRecipientCount");
			}
			set {
				SetColumnValue("ProcessedRecipientCount", value);
			}
		}

		/// <summary>
		/// Received initial responce count.
		/// </summary>
		public int ReceivedInitialResponseCount {
			get {
				return GetTypedColumnValue<int>("ReceivedInitialResponseCount");
			}
			set {
				SetColumnValue("ReceivedInitialResponseCount", value);
			}
		}

		#endregion

	}

	#endregion

}

