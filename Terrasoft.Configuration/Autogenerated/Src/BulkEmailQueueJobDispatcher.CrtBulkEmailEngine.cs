namespace Terrasoft.Configuration
{
	using System.Collections.Generic;
	using Terrasoft.Core.Scheduler;
	using Terrasoft.Web.Common;

	#region Class: BulkEmailQueueJobDispatcher

	/// <summary>
	/// Serves bulk email queue with messages for bulk email audience processing.
	/// </summary>
	public class BulkEmailQueueJobDispatcher : BaseBulkEmailQueueJobDispatcher, IAppEventListener
	{

		#region Properties: Protected

		/// <inheritdoc/>
		protected override IEnumerable<BulkEmailQueueMessageType> AllowedMessageTypes =>
			new BulkEmailQueueMessageType[] {
				BulkEmailQueueMessageType.AddAudienceByFilter,
				BulkEmailQueueMessageType.AddAudienceByFolderId,
				BulkEmailQueueMessageType.AddAudienceByList,
				BulkEmailQueueMessageType.RemoveAllAudience,
				BulkEmailQueueMessageType.RemoveAudienceByFilter,
				BulkEmailQueueMessageType.RemoveAudienceByList
			};

		#endregion

		#region Methods: Protected

		/// <inheritdoc/>
		protected override void ScheduleJob(string workspaceName, string userName) {
			AppScheduler.ScheduleMinutelyJob<BulkEmailQueueJobDispatcher>(
				JobGroupName, workspaceName, userName, periodInMinutes: 1,
				isSystemUser: true, scheduler: Scheduler,
				misfireInstruction: AppSchedulerMisfireInstruction.SmartPolicy);
		}

		#endregion

	}

	#endregion

}





