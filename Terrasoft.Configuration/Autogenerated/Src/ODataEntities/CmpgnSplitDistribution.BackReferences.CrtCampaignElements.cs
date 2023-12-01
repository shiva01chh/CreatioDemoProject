namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CmpgnSplitDistribution

	/// <exclude/>
	public class CmpgnSplitDistribution : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public CmpgnSplitDistribution(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CmpgnSplitDistribution";
		}

		public CmpgnSplitDistribution(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "CmpgnSplitDistribution";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// TransitionId.
		/// </summary>
		/// <remarks>
		/// Defines unique transition index per campaign schema. TransitionId not equals to CampaignItemId.
		/// </remarks>
		public Guid TransitionId {
			get {
				return GetTypedColumnValue<Guid>("TransitionId");
			}
			set {
				SetColumnValue("TransitionId", value);
			}
		}

		/// <summary>
		/// CampaignParticipantId.
		/// </summary>
		public Guid CampaignParticipantId {
			get {
				return GetTypedColumnValue<Guid>("CampaignParticipantId");
			}
			set {
				SetColumnValue("CampaignParticipantId", value);
			}
		}

		#endregion

	}

	#endregion

}

