﻿namespace Terrasoft.Configuration {
	using System;
	using System.Collections.Generic;
	using IntegrationApi.Calendar.DTO;
	using IntegrationApi.Interfaces;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region Class: ActivityUtilsWrap

	[DefaultBinding(typeof(IActivityUtils))]
	public class ActivityUtilsWrap : IActivityUtils {

		#region Methods: Public

		/// <inheritdoc cref="IActivityUtils.FixActivityTitle(string, UserConnection)"/>
		public string FixActivityTitle(string value, UserConnection userConnection) {
			return ActivityUtils.FixActivityTitle(value, userConnection);
		}

		/// <inheritdoc cref="IActivityUtils.GetAttachmentName(UserConnection, string)"/>
		public string GetAttachmentName(UserConnection userConnection, string attachmentName) {
			return ActivityUtils.GetAttachmentName(userConnection, attachmentName);
		}

		/// <inheritdoc cref="IActivityUtils.GetExistingEmaisIds(UserConnection, DateTime, string, string, TimeZoneInfo)"/>
		public List<Guid> GetExistingEmaisIds(UserConnection userConnection, DateTime sendDate, string subject, string body,
				TimeZoneInfo timeZoneInfo) {
			return ActivityUtils.GetExistingEmaisIds(userConnection, sendDate, subject, body, timeZoneInfo);
		}

		/// <inheritdoc cref="IActivityUtils.GetEmailHash(UserConnection, DateTime, string, string, TimeZoneInfo)"/>
		public string GetEmailHash(UserConnection userConnection,  DateTime sendDate, string title, string body,
				TimeZoneInfo timeZoneInfo) {
			return ActivityUtils.GetEmailHash(userConnection, sendDate, title, body, timeZoneInfo);
		}

		/// <inheritdoc cref="IActivityUtils.GetSendDateFromTicks(UserConnection, long)"/>
		public DateTime GetSendDateFromTicks(UserConnection userConnection, long ticks) {
			return ActivityUtils.GetSendDateFromTicks(userConnection, ticks);
		}

		/// <inheritdoc cref="IActivityUtils.GetSendDateTicks(UserConnection, Entity)"/>
		public long GetSendDateTicks(UserConnection userConnection, Entity activity) {
			return ActivityUtils.GetSendDateTicks(userConnection, activity);
		}

		/// <inheritdoc cref="IActivityUtils.GetActivityHash(string, string, DateTime, DateTime, Guid, string, TimeZoneInfo)"/>
		public string GetActivityHash(string title, string location, DateTime startDate, DateTime dueDate, Guid priorityId, string notes,
				TimeZoneInfo timeZoneInfo) {
			return ActivityUtils.GetActivityHash(title, location, startDate, dueDate, priorityId, notes, timeZoneInfo);
		}

		/// <inheritdoc cref="IActivityUtils.GetActivityHash(ActivityHashDataSet)"/>
		public string GetActivityHash(ActivityHashDataSet activityHashDataSet) {
			return ActivityUtils.GetActivityHash(activityHashDataSet);
		}

		/// <inheritdoc cref="IActivityUtils.GetLczPrivateMeeting(UserConnection)
		public string GetLczPrivateMeeting(UserConnection userConnection) {
			return ActivityUtils.GetLczPrivateMeeting(userConnection);
		}

		#endregion

	}

	#endregion
}




