namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BulkEmailInProgress

	/// <exclude/>
	public class BulkEmailInProgress : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public BulkEmailInProgress(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmailInProgress";
		}

		public BulkEmailInProgress(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "BulkEmailInProgress";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Session.
		/// </summary>
		public Guid SessionId {
			get {
				return GetTypedColumnValue<Guid>("SessionId");
			}
			set {
				SetColumnValue("SessionId", value);
			}
		}

		/// <summary>
		/// BulkEmail.
		/// </summary>
		public Guid BulkEmailId {
			get {
				return GetTypedColumnValue<Guid>("BulkEmailId");
			}
			set {
				SetColumnValue("BulkEmailId", value);
			}
		}

		/// <summary>
		/// CreatedOn.
		/// </summary>
		public DateTime CreatedOn {
			get {
				return GetTypedColumnValue<DateTime>("CreatedOn");
			}
			set {
				SetColumnValue("CreatedOn", value);
			}
		}

		/// <summary>
		/// Prepared.
		/// </summary>
		public int PreparedToSendCount {
			get {
				return GetTypedColumnValue<int>("PreparedToSendCount");
			}
			set {
				SetColumnValue("PreparedToSendCount", value);
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
		/// Send.
		/// </summary>
		public int SendCount {
			get {
				return GetTypedColumnValue<int>("SendCount");
			}
			set {
				SetColumnValue("SendCount", value);
			}
		}

		#endregion

	}

	#endregion

}

