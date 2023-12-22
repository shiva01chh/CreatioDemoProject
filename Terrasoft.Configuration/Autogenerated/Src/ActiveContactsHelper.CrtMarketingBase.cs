namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Common;
	using Core;
	using Core.DB;
	using global::Common.Logging;
	using CoreSysSettings = Core.Configuration.SysSettings;

	/// <summary>
	/// Class for work with active contacts.
	/// </summary>
	public interface IActiveContactsHelper
	{
		/// <summary>
		/// Gets the active contacts license information.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <returns>The active contacts license information.</returns>
		ActualLicenseInfo GetActiveContactsLicenseInfo(UserConnection userConnection);

		/// <summary>
		/// Gets actual result of conditional license check for the package name.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <param name="packageName">The package name.</param>
		/// <returns>Actual result of conditional license check for the package name.</returns>
		int GetCurrentConditionScalarResult(UserConnection userConnection, string packageName);

		/// <summary>
		/// Gets the full license name by name patterns.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <param name="namePatterns">The list of patterns to find the full license name.</param>
		/// <returns>Full license name.</returns>
		string GetFullPackageNameByNamePatterns(UserConnection userConnection, List<string> namePatterns);

		/// <summary>
		/// Retrieves the last actualized condition information for a list of package names.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <param name="packageNames">The list of package names to retrieve condition information for.</param>
		/// <returns>The last actualized condition information for the specified package names.</returns>
		IEnumerable<ActualizedCondition> GetLastActualizedConditionResult(UserConnection userConnection,
			List<string> packageNames);

		/// <summary>
		/// Retrieves the last actualized condition information for a list of package names.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <returns>The last actualized condition information for the specified package names.</returns>
		ActualizedCondition GetLastActualizedConditionResult(UserConnection userConnection);

		/// <summary>
		/// Retrieves the maximum condition count information for a list of package names.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <param name="packageNames">The list of package names to retrieve condition information for.</param>
		/// <returns>The maximum condition count information for the specified package names.</returns>
		IEnumerable<ActualizedCondition> GetMaxConditionCount(UserConnection userConnection, List<string> packageNames);

		/// <summary>
		/// Retrieves the maximum condition count information for a list of package names.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <returns>The maximum condition count information for the specified package names.</returns>
		ActualizedCondition GetMaxConditionCount(UserConnection userConnection);

	}

	#region Class: ActiveContactsHelper

    /// <summary>
    /// Class for work with active contacts.
    /// </summary>
    public class ActiveContactsHelper : IActiveContactsHelper
    {

		#region Constants: Private

		/// <summary>
		/// Name of license package for marketing active contacts.
		/// </summary>
		private static readonly string[] _licensePackageNamePatterns = { "Bpmonline Marketing Creatio.*1000.*", 
			"bpmonline marketing active contacts.*","marketing creatio.*active contacts.*" };
		private const string _activeContactsWarningThresholdSettingsCode = "ActiveContactsWarningThreshold";
		private const string _marketingLicOperationName = "MarketingContacts.Use";

        #endregion

        #region Fields: Private

        private readonly Guid _remindingBulkEmailSysEntitySchemaId = new Guid("95FBCF9C-E36D-4ACD-8B5A-D657DE6E30A8");
		private readonly Guid _actualizeActiveContactsProcessUId = new Guid("dbb0d4cf-3b59-49ea-a1bb-4076ae5f53f3");
		private static readonly ILog _log = LogManager.GetLogger("ActiveContactsHelper");

        #endregion

        #region Methods: Private

		private IEnumerable<ActualizedCondition> GetActualizedConditionInfo(UserConnection userConnection,
			List<string> packageNames, Func<LicConditionModel, int> getCount) {
			foreach (string packageName in packageNames) {
				LicConditionModel licPackageCondition = userConnection.LicHelper.GetLicPackageCondition(packageName);
				DateTime lastActualizationDate = TimeZoneInfo.ConvertTimeFromUtc(
					licPackageCondition.ActualizationDate.ToUniversalTime(), userConnection.CurrentUser.TimeZone);
                DateTime dueDateInLocalTimeZone = TimeZoneInfo.ConvertTimeFromUtc(
						licPackageCondition.DueDate.ToUniversalTime(), userConnection.CurrentUser.TimeZone);
                var condition = new ActualizedCondition {
					PackageName = packageName,
					ConditionCount = getCount(licPackageCondition),
					ConditionDate = DateTimeDataValueType.Serialize(lastActualizationDate, TimeZoneInfo.Utc),
					DueDate = DateTimeDataValueType.Serialize(dueDateInLocalTimeZone, TimeZoneInfo.Utc)
                };
				yield return condition;
			}
		}

		private ActualizedCondition GetActualizedConditionInfo(UserConnection userConnection,
			Func<LicConditionModel, int> getCount) {
			var packageName = GetActualLicensePackageName(userConnection);
			LicConditionModel licPackageCondition = userConnection.LicHelper.GetLicPackageCondition(packageName);
			DateTime lastActualizationDate = TimeZoneInfo.ConvertTimeFromUtc(
				licPackageCondition.ActualizationDate.ToUniversalTime(), userConnection.CurrentUser.TimeZone);
			DateTime dueDateInLocalTimeZone = TimeZoneInfo.ConvertTimeFromUtc(
				licPackageCondition.DueDate.ToUniversalTime(), userConnection.CurrentUser.TimeZone);
			var condition = new ActualizedCondition {
				PackageName = packageName,
				ConditionCount = getCount(licPackageCondition),
				ConditionDate = DateTimeDataValueType.Serialize(lastActualizationDate, TimeZoneInfo.Utc),
				DueDate = DateTimeDataValueType.Serialize(dueDateInLocalTimeZone, TimeZoneInfo.Utc)
			};
			return condition;
		}

		private static string GetActualLicensePackageName(UserConnection userConnection) {
			string newLicensePackageName = userConnection.AppConnection.LicManager
				.GetLicPackageNamesByServerOperation(_marketingLicOperationName)?.FirstOrDefault();
			if (!string.IsNullOrEmpty(newLicensePackageName)) {
				return newLicensePackageName;
			}
            string actualLicenseFullName = null;
			foreach (var packageNamePattern in _licensePackageNamePatterns) {
				actualLicenseFullName = userConnection.LicHelper.GetExistingLicNameByNamePattern(packageNamePattern);
				if (!string.IsNullOrEmpty(actualLicenseFullName)) {
					return actualLicenseFullName;
				}
			}
			return actualLicenseFullName;
		}
		
		private static DateTime GetLicenseStartDate(DateTime dueDate) {
			const int leapDayOfYear = 59;
			var currentDate = DateTime.UtcNow;
			var currentDateDay = currentDate.DayOfYear;
			var dueDateDay = dueDate.DayOfYear;
			if (DateTime.IsLeapYear(currentDate.Year)) {
				currentDateDay = currentDateDay > leapDayOfYear
					? currentDateDay - 1
					: currentDateDay;
			}
			if (DateTime.IsLeapYear(dueDate.Year)) {
				dueDateDay = dueDateDay > leapDayOfYear
					? dueDateDay - 1
					: dueDateDay;
			}
			var startDate = currentDateDay >= dueDateDay
				? new DateTime(currentDate.Year, 1, 1).AddDays(dueDateDay - 1)
				: new DateTime(currentDate.Year - 1, 1, 1).AddDays(dueDateDay - 1);
			return startDate;
		}
		
		private static Select GetCurrentBulkEmailRecipientsSelect(int bulkEmailRId, UserConnection userConnection) {
			var selectCurrentBulkEmailRecipients = new Select(userConnection)
				.Column("c", "Id").As("ContactId")
				.From("MandrillRecipient").As("mr")
				.InnerJoin("Contact").As("c").On("mr", "ContactRId").IsEqual("c", "RId")
				.Where("mr", "BulkEmailRId").IsEqual(Column.Parameter(bulkEmailRId)) as Select;
			selectCurrentBulkEmailRecipients.SpecifyNoLockHints(true);
			return selectCurrentBulkEmailRecipients;
		}
		
		private static Select GetHistoryBulkEmailsRecipientsSelect(DateTime startDate, UserConnection userConnection) {
			var selectHistoryBulkEmailsRecipients = new Select(userConnection)
				.Column("bet", "ContactId")
				.From("BulkEmailTarget").As("bet")
				.InnerJoin("BulkEmail").As("be").On("bet", "BulkEmailId").IsEqual("be", "Id")
				.Where("bet", "BulkEmailResponseId").In(Column.Parameters(MailingConsts.BulkEmailResponseSentId,
					MailingConsts.BulkEmailResponseOpenedId, MailingConsts.BulkEmailResponseClickedId,
					MailingConsts.BulkEmailResponseHardBounceId, MailingConsts.BulkEmailResponseSoftBounceId,
					MailingConsts.BulkEmailResponseSpamId, MailingConsts.BulkEmailResponseUnsubId))
				.And("be", "SendStartDate").IsGreaterOrEqual(Column.Parameter(startDate)) as Select;
			selectHistoryBulkEmailsRecipients.SpecifyNoLockHints(true);
			return selectHistoryBulkEmailsRecipients;
		}
		
		private static Select GetNonHistoryBulkEmailsRecipientsSelect(DateTime startDate,
				UserConnection userConnection) {
			var selectNonHistoryBulkEmailsRecipients = new Select(userConnection)
				.Column("c", "Id").As("ContactId")
				.From("MandrillSentMessage").As("msm")
				.InnerJoin("Contact").As("c").On("msm", "ContactRId").IsEqual("c", "RId")
				.InnerJoin("BulkEmail").As("be").On("msm", "BulkEmailRId").IsEqual("be", "RId")
				.Where("be", "SendStartDate").IsGreaterOrEqual(Column.Parameter(startDate)) as Select;
			selectNonHistoryBulkEmailsRecipients.SpecifyNoLockHints(true);
			return selectNonHistoryBulkEmailsRecipients;
		}
		
		private static Select GetActiveContactsCountSelect(Select selectCurrentBulkEmailRecipients,
				Select selectHistoryBulkEmailsRecipients, Select selectNonHistoryBulkEmailsRecipients,
				UserConnection userConnection) {
			var selectCount = new Select(userConnection)
				.Column(Func.Count("ContactId"))
				.From(new Select(userConnection)
					.Column("main", "ContactId")
					.From(selectCurrentBulkEmailRecipients.UnionAll(selectNonHistoryBulkEmailsRecipients)
						.UnionAll(selectHistoryBulkEmailsRecipients) as Select).As("main")
					.GroupBy("main", "ContactId")).As("t");
			return selectCount;
		}
		
		private static int GetActiveContactsCount(DateTime startDate, int bulkEmailRId,
				UserConnection userConnection) {
			var selectCurrentBulkEmailRecipients = GetCurrentBulkEmailRecipientsSelect(bulkEmailRId, userConnection);
			var selectHistoryBulkEmailsRecipients = GetHistoryBulkEmailsRecipientsSelect(startDate, userConnection);
			var selectNonHistoryBulkEmailsRecipients = GetNonHistoryBulkEmailsRecipientsSelect(startDate, userConnection);
			var selectCount = GetActiveContactsCountSelect(selectCurrentBulkEmailRecipients,
				selectHistoryBulkEmailsRecipients, selectNonHistoryBulkEmailsRecipients, userConnection);
			return selectCount.ExecuteScalar<int>();
		}
		
		private static Select GetLicenseDueDateSelect(UserConnection userConnection, string licensePackageName) {
			return new Select(userConnection)
				.Column("SysLic", "DueDate")
				.From("SysLic")
				.InnerJoin("SysLicPackage").On("SysLic", "SysLicPackageId").IsEqual("SysLicPackage", "Id")
				.Where(new QueryParameter(DateTime.Now.Date)).IsBetween("StartDate").And("DueDate")
				.And("SysLicPackage", "Name").IsLike(Column.Parameter($"{licensePackageName}%"))
				.OrderByDesc("SysLic", "DueDate") as Select;
		}
		
		private static DateTime GetLicenseDueDate(UserConnection userConnection, string licensePackageName) {
			var dueDate = DateTime.MinValue;
			var select = GetLicenseDueDateSelect(userConnection, licensePackageName);
			using (var dbExecutor = userConnection.EnsureDBConnection()) {
				using (var reader = select.ExecuteReader(dbExecutor)) {
					var dueDateColumnIndex = reader.GetOrdinal("DueDate");
					while (reader.Read()) {
						dueDate = reader.GetDateTime(dueDateColumnIndex);
						break;
					}
				}
			}
			return dueDate;
		}

		private static Query CreateOwnerIdSelect(UserConnection userConnection, string tableName,
				DateTime limitPeriodDate) {
			return new Select(userConnection)
				.Column("OwnerId")
				.From(tableName)
				.Where("CreatedOn").IsGreaterOrEqual(Column.Parameter(limitPeriodDate))
				.And("OwnerId").Not().IsNull();
		}

		private Select CreateNotificationRecipientsSelect(UserConnection userConnection, DateTime limitPeriodDate) {
			var bulkEmailOwnerselect = CreateOwnerIdSelect(userConnection, "BulkEmail", limitPeriodDate);
			var eventOwnerselect = CreateOwnerIdSelect(userConnection, "Event", limitPeriodDate);
			var campaignOwnerselect = CreateOwnerIdSelect(userConnection, "Campaign", limitPeriodDate);
			var unionSelect = bulkEmailOwnerselect.Union(eventOwnerselect).Union(campaignOwnerselect) as Select;
			return unionSelect;
		}

		private void CreateRemindings(UserConnection userConnection, List<Guid> recipientIds,
				string remindingSubjectCaption) {
			foreach (var recipientId in recipientIds) {
				var currentUser = userConnection.CurrentUser;
				var remindTime = currentUser.GetCurrentDateTime();
				var reminding = new Reminding(userConnection);
				reminding.SetDefColumnValues();
				reminding.AuthorId = currentUser.ContactId;
				reminding.SourceId = RemindingConsts.RemindingSourceAuthorId;
				reminding.ContactId = recipientId;
				reminding.RemindTime = remindTime;
				reminding.Description = GetLczString(userConnection, "ActiveContactsNotificationDescription");
				reminding.LoaderId = _actualizeActiveContactsProcessUId;
				reminding.SysEntitySchemaId = _remindingBulkEmailSysEntitySchemaId;
				reminding.SubjectCaption = remindingSubjectCaption;
				reminding.SetColumnValue("NotificationTypeId", RemindingConsts.NotificationTypeNotificationId);
				reminding.Save();
			}
		}

		private List<Guid> GetNotificationRecipients(UserConnection userConnection) {
			var recipientIds = new List<Guid>();
			var thirtyDaysAgoDate = DateTime.UtcNow.AddDays(-30);
			var unionSelect = CreateNotificationRecipientsSelect(userConnection, thirtyDaysAgoDate);
			using (var dbExecutor = userConnection.EnsureDBConnection()) {
				using (var dr = unionSelect.ExecuteReader(dbExecutor)) {
					while (dr.Read()) {
						recipientIds.Add(userConnection.DBTypeConverter.DBValueToGuid(dr["OwnerId"]));
					}
				}
			}
			return recipientIds;
		}

		private string GetLczString(UserConnection userConnection, string lczName) {
			string localizableStringName = string.Format("LocalizableStrings.{0}.Value", lczName);
			return new LocalizableString(userConnection.Workspace.ResourceStorage, "ActiveContactsHelper",
				localizableStringName
			);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Returns validation result of active contacts.
		/// </summary>
		/// <param name="bulkEmailRId">RId of bulk email.</param>
		/// <param name="userConnection">User connection instance.</param>
		/// <returns>Validation result of active contacts..</returns>
		[Obsolete("7.18.3 | Method is deprecated. Get actual active contacts count from license package condition.")]
		public static ActiveContactsValidationResult ValidateContactsCount(int bulkEmailRId,
				UserConnection userConnection) {
			var licensePackageName = GetActualLicensePackageName(userConnection);
			var dueDate = GetLicenseDueDate(userConnection, licensePackageName);
			var startDate = GetLicenseStartDate(dueDate);
			var currentActiveContactsCount = GetActiveContactsCount(startDate, bulkEmailRId, userConnection);
			var maxActiveContactsCount = userConnection.LicHelper
				.GetLicPackageMaxConditionCount(licensePackageName);
			var validationResult = new ActiveContactsValidationResult();
			if (currentActiveContactsCount <= maxActiveContactsCount) {
				validationResult.Code = ActiveContactsValidationResult.Success;
				validationResult.Message = string.Empty;
			} else {
				validationResult.Code = ActiveContactsValidationResult.Error;
				validationResult.Message = "ErrorCountContactsMsg";
			}
			return validationResult;
		}

		/// <summary>
		/// Returns validation permission edit BulkEmail entity.
		/// </summary>
		/// <param name="userConnection">User connection instance.</param>
		/// <returns>Validation result of permission edit BulkEmail.</returns>
		public static ActiveContactsValidationResult ValidatePermissionEditBulkEmail(UserConnection userConnection) {
			var validationResult = new ActiveContactsValidationResult();
			var dbSecurityEngine = userConnection.DBSecurityEngine;
			var actualRightLevels = dbSecurityEngine.GetEntitySchemaOperationsRightLevel("BulkEmail");
			if (actualRightLevels.HasFlag(SchemaOperationRightLevels.CanEdit)) {
				validationResult.Code = ActiveContactsValidationResult.Success;
				validationResult.Message = string.Empty;
			} else {
				validationResult.Code = ActiveContactsValidationResult.Error;
				validationResult.Message = "ErrorCountContactsMsg";
			}
			return validationResult;
		}

		/// <summary>
		/// Actualized current active contacts usage and create reminder about ends of limit.
		/// </summary>
		/// <param name="userConnection">User connection instance.</param>
		public void ActualizeActiveContactsWithReminding(UserConnection userConnection) {
			var activeContactsWarningThreshold =
				(int)CoreSysSettings.GetValue(userConnection, _activeContactsWarningThresholdSettingsCode);
			var licHelper = userConnection.LicHelper;
			var licensePackageName = GetActualLicensePackageName(userConnection);
			if (string.IsNullOrEmpty(licensePackageName)) {
				return;
				//TODO: Create notification about license missing
			}
			var maxValue = (double)licHelper.GetLicPackageMaxConditionCount(licensePackageName);
			var lastValue = (double)licHelper.GetLicPackageCurrentConditionResult(licensePackageName);
			licHelper.ActualizeLicPackageOperations(licensePackageName);
			var newValue = (double)licHelper.GetLicPackageCurrentConditionResult(licensePackageName);
			var leftActiveContacts = maxValue - newValue;
			var leftPercent = leftActiveContacts / maxValue * 100;
			if ((leftPercent <= activeContactsWarningThreshold) & (newValue != lastValue)) {
				var recipientIds = GetNotificationRecipients(userConnection);
				var licenceExceded = newValue >= maxValue;
				var licenseExceededSubject = GetLczString(userConnection, "ActiveContactsExceededNotificationSubject");
				var licenceAlmostOverSubject = GetLczString(userConnection, "ActiveContactsAlmostOverNotificationSubject");
				var remindingSubjectCaption = licenceExceded ?
					licenseExceededSubject :
					string.Format(licenceAlmostOverSubject, activeContactsWarningThreshold);
				CreateRemindings(userConnection, recipientIds, remindingSubjectCaption);
			}
		}

		/// <summary>
		/// Gets the active contacts license information.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <returns>The active contacts license information.</returns>
		public static LicConditionModel GetActiveContactsLicInfo(UserConnection userConnection) {
			try {
				string licensePackageName = GetActualLicensePackageName(userConnection);
				return userConnection.LicHelper.GetLicPackageCondition(licensePackageName);
			} catch (Exception exception) {
				_log.Warn($"Failed to get license package information. Exception: {exception}");
				return new LicConditionModel {
					ActualizationDate = DateTime.MinValue,
					Count = 0,
					DueDate = DateTime.MinValue,
					MaxConditionCount = 0
				};
			}
		}

		/// <inheritdoc cref="IActiveContactsHelper.GetActiveContactsLicenseInfo"/>
		public ActualLicenseInfo GetActiveContactsLicenseInfo(UserConnection userConnection) {
			var licInfo = GetActiveContactsLicInfo(userConnection);
			DateTime lastActualizationDate = TimeZoneInfo.ConvertTimeFromUtc(
				licInfo.ActualizationDate.ToUniversalTime(), userConnection.CurrentUser.TimeZone);
			return new ActualLicenseInfo {
				ActiveContactCount = licInfo.Count,
				PaidContactCount = licInfo.MaxConditionCount,
				ActualizationDate = DateTimeDataValueType.Serialize(lastActualizationDate, TimeZoneInfo.Utc)
			};
		}

		/// <inheritdoc cref="IActiveContactsHelper.GetCurrentConditionScalarResult"/>
        public int GetCurrentConditionScalarResult(UserConnection userConnection, string packageName) {
			return userConnection.LicHelper.GetLicPackageCurrentConditionResult(packageName);
		}

		/// <inheritdoc cref="IActiveContactsHelper.GetFullPackageNameByNamePatterns"/>
		public string GetFullPackageNameByNamePatterns(UserConnection userConnection, List<string> namePatterns) {
			string actualLicenseFullName = null;
			foreach (string packageNamePattern in namePatterns) {
				actualLicenseFullName = userConnection.LicHelper.GetExistingLicNameByNamePattern(packageNamePattern);
				if (!string.IsNullOrEmpty(actualLicenseFullName)) {
					return actualLicenseFullName;
				}
			}
			return actualLicenseFullName;
		}

        /// <inheritdoc cref="IActiveContactsHelper.GetLastActualizedConditionResult(UserConnection, List&lt;string&gt;)"/>
        public IEnumerable<ActualizedCondition> GetLastActualizedConditionResult(UserConnection userConnection,
			List<string> packageNames) {
			return GetActualizedConditionInfo(userConnection, packageNames,
				licPackageCondition => licPackageCondition.Count);
		}

        /// <inheritdoc cref="IActiveContactsHelper.GetLastActualizedConditionResult(UserConnection)"/>
        public ActualizedCondition GetLastActualizedConditionResult(UserConnection userConnection) {
			return GetActualizedConditionInfo(userConnection, licPackageCondition => licPackageCondition.Count);
		}

        /// <inheritdoc cref="IActiveContactsHelper.GetMaxConditionCount(UserConnection, List&lt;string&gt;)"/>
        public IEnumerable<ActualizedCondition> GetMaxConditionCount(UserConnection userConnection,
			List<string> packageNames) {
			return GetActualizedConditionInfo(userConnection, packageNames,
				licPackageCondition => licPackageCondition.MaxConditionCount);
		}

        /// <inheritdoc cref="IActiveContactsHelper.GetMaxConditionCount(UserConnection)"/>
        public ActualizedCondition GetMaxConditionCount(UserConnection userConnection) {
			return GetActualizedConditionInfo(userConnection, licPackageCondition => licPackageCondition.MaxConditionCount);
		}

		#endregion

    }

    #endregion
}













