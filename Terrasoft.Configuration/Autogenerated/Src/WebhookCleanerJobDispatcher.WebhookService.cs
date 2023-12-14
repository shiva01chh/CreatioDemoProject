﻿namespace Terrasoft.Configuration
{
	using System;
	using System.Linq;
	using global::Common.Logging;
	using Quartz;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Scheduler;
	using Terrasoft.Web.Common;
	using SysSettingsCore = Terrasoft.Core.Configuration.SysSettings;

	#region Class: WebhookCleanerJobDispatcher

	/// <summary>
	/// Provides methods to schedule job and cleanup old webhooks.
	/// </summary>
	public class WebhookCleanerJobDispatcher : BaseQueueJobDispatcher, IAppEventListener
	{

		#region Properties: Public

		/// <summary>
		/// Instance of <see cref="IScheduler"/> with name "WebhooksQuartzScheduler" or default.
		/// </summary>
		public IScheduler WebhooksScheduler => DefaultScheduler.FindScheduler("WebhooksQuartzScheduler")
			?? DefaultScheduler.Instance;

		/// <summary>
		/// Name of job group.
		/// </summary>
		public override string JobGroupName => "Webhooks";

		#endregion

		#region Methods: Private

		private EntityCollection GetWebhookStatusesToClean() {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "WebhookStatus");
			IEntitySchemaQueryFilterItem filter =
				esq.CreateFilterWithParameters(FilterComparisonType.Greater, "DeleteAfterDays", 0);
			esq.Filters.Add(filter);
			esq.AddColumn("DeleteAfterDays");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			return esq.GetEntityCollection(UserConnection);
		}

		private void RemoveWebhooks(Guid statusId, int deleteAfterDays) {
			if (deleteAfterDays <= 0) {
				return;
			}
			DateTime checkTime = DateTime.UtcNow.AddDays(-deleteAfterDays);
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Webhook");
			IEntitySchemaQueryFilterItem dateFilter =
				esq.CreateFilterWithParameters(FilterComparisonType.LessOrEqual, "ModifiedOn", checkTime);
			IEntitySchemaQueryFilterItem statusFiler =
				esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Status", statusId);
			esq.Filters.Add(dateFilter);
			esq.Filters.Add(statusFiler);
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			esq.AddColumn("ModifiedOn");
			esq.AddColumn("Status");
			esq.GetEntityCollection(UserConnection)
				.ToList()
				.ForEach(entity => entity.Delete());
		}

		#endregion

		#region Methods: Protected

		/// <inheritdoc/>
		protected override ILog GetLogger() => LogManager.GetLogger("Webhooks");

		/// <inheritdoc/>
		protected override IScheduler GetScheduler() => WebhooksScheduler;

		/// <summary>
		/// Schedules job.
		/// </summary>
		/// <param name="workspaceName">Name of current workspace.</param>
		/// <param name="userName">Current user name.</param>
		protected override void ScheduleJob(string workspaceName, string userName) {
			SysUserInfo currentUser = UserConnection.CurrentUser;
			int periodInMinutes = (int)SysSettingsCore.GetValue(UserConnection, "WebhookCleanerJobInterval");
			bool isSystemUser = true;
			var misfirePolicy = AppSchedulerMisfireInstruction.RescheduleNowWithRemainingRepeatCount;
			AppScheduler.ScheduleMinutelyJob<WebhookCleanerJobDispatcher>(JobGroupName, UserConnection.Workspace.Name,
				currentUser.Name, periodInMinutes, null, isSystemUser, misfirePolicy);
		}

		/// <summary>
		/// Provides logic to be executed in job thread.
		/// </summary>
		protected override void InternalExecute() {
			EntityCollection statusesToClean = GetWebhookStatusesToClean();
			foreach (Entity entity in statusesToClean) {
				var statusId = entity.PrimaryColumnValue;
				var deleteAfterDays = entity.GetTypedColumnValue<int>("DeleteAfterDays");
				RemoveWebhooks(statusId, deleteAfterDays);
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Schedules minutely job for old webhooks cleaning and tries to reschedule broken triggers.
		/// </summary>
		/// <param name="context">Instance of <see cref="AppEventContext"/>.</param>
		public void OnAppStart(AppEventContext context) {
			GetUserConnection(context);
			TryRescheduleJob();
		}

		public void OnAppEnd(AppEventContext context) { }

		public void OnSessionStart(AppEventContext context)  { }

		public void OnSessionEnd(AppEventContext context)  { }

		#endregion

	}

	#endregion

}




