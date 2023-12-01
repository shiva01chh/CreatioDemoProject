﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CmpgnPrtcpntEmailTarget

	/// <exclude/>
	public class CmpgnPrtcpntEmailTarget : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public CmpgnPrtcpntEmailTarget(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CmpgnPrtcpntEmailTarget";
		}

		public CmpgnPrtcpntEmailTarget(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "CmpgnPrtcpntEmailTarget";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// MandrillRecipientUId.
		/// </summary>
		public Guid MandrillRecipientUId {
			get {
				return GetTypedColumnValue<Guid>("MandrillRecipientUId");
			}
			set {
				SetColumnValue("MandrillRecipientUId", value);
			}
		}

		/// <summary>
		/// CampaignParticipant.
		/// </summary>
		public Guid CampaignParticipantId {
			get {
				return GetTypedColumnValue<Guid>("CampaignParticipantId");
			}
			set {
				SetColumnValue("CampaignParticipantId", value);
			}
		}

		/// <summary>
		/// WasUsed.
		/// </summary>
		public bool WasUsed {
			get {
				return GetTypedColumnValue<bool>("WasUsed");
			}
			set {
				SetColumnValue("WasUsed", value);
			}
		}

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

		#endregion

	}

	#endregion

}

