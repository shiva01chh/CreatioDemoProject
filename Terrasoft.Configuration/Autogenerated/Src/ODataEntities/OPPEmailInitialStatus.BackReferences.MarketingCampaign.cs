namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OPPEmailInitialStatus

	/// <exclude/>
	public class OPPEmailInitialStatus : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public OPPEmailInitialStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OPPEmailInitialStatus";
		}

		public OPPEmailInitialStatus(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "OPPEmailInitialStatus";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// BulkEmailId.
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
		/// EmailAddress.
		/// </summary>
		public string EmailAddress {
			get {
				return GetTypedColumnValue<string>("EmailAddress");
			}
			set {
				SetColumnValue("EmailAddress", value);
			}
		}

		/// <summary>
		/// MandrillId.
		/// </summary>
		public Guid MandrillId {
			get {
				return GetTypedColumnValue<Guid>("MandrillId");
			}
			set {
				SetColumnValue("MandrillId", value);
			}
		}

		/// <summary>
		/// EmailResponseId.
		/// </summary>
		public Guid EmailResponseId {
			get {
				return GetTypedColumnValue<Guid>("EmailResponseId");
			}
			set {
				SetColumnValue("EmailResponseId", value);
			}
		}

		#endregion

	}

	#endregion

}

