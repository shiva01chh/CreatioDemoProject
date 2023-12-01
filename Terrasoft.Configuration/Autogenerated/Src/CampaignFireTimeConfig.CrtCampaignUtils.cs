namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core.Campaign.Enums;

	#region Class: CampaignFireTimeConfig

	/// <summary>
	/// Class that contains parameters for schedule next campaign job.
	/// </summary>
	public class CampaignFireTimeConfig
	{

		#region Properties: Public

		/// <summary>
		/// Job start time. Instance of <see cref="DateTime"/>.
		/// </summary>
		public DateTime Time {
			get;
			set;
		}

		/// <summary>
		/// Strategy for <see cref="Terrasoft.Core.Campaign.FlowGenerator.CampaignFlowSchemaGenerator"/>.
		/// Generator generates sets of steps depends on this property.
		/// </summary>
		public CampaignSchemaExecutionStrategy ExecutionStrategy {
			get;
			set;
		}

		/// <summary>
		/// Action that deescribes what job should do whith a campaign.
		/// </summary>
		public CampaignScheduledAction ScheduledAction {
			get;
			set;
		}

		#endregion

	}

	#endregion

}





