namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Configuration.SocialLeadGen;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using global::Common.Logging;

	#region Class: ActualizeFacebookWebFormsExecutor

	public class ActualizeFacebookWebFormsExecutor : IInstallScriptExecutor
	{

		#region Fields: Private

		private UserConnection _userConnection;

		private Guid _activeLandingStateId = Guid.Parse("FBE29614-C02C-446E-AC8C-E7F62C4899EC");

		private static readonly ILog _logger = LogManager.GetLogger("WebToObject");

		#endregion

		#region Properties: Public

		private SocialLeadGenService _service;

		public SocialLeadGenService LeadGenService {
			get => _service ?? (_service = new SocialLeadGenService());
			set => _service = value;
		}

		private ILog _log;
		public ILog Log {
			get => _log ?? (_log = _logger);
			set => _log = value;
		}

		#endregion

		#region Methods: Private

		private bool HasFbIntergations() {
			var account = LeadGenService.GetAccount();
			if (account == null || !account.IsAccountExists || !account.IsActive) {
				return false;
			}
			return true;
		}

		private IEnumerable<Guid> GetDbWebFormIds() {
			var activeStateId = _activeLandingStateId;
			var select = new Select(_userConnection)
				.Column("Id")
				.From("GeneratedWebForm")
				.Where("StateId").IsEqual(Column.Parameter(activeStateId)) as Select;
			select.SpecifyNoLockHints();
			return select.ExecuteEnumerable(reader => reader.GetColumnValue<Guid>("Id"));
		}

		private bool UpdateIsFbWebForm() {
			var result = true;
			try {
				if (!HasFbIntergations()) {
					return result;
				}
				var landingsWithFbIntegration = new Dictionary<Guid, string>();
				var formIds = GetDbWebFormIds();
				formIds.ForEach(formId => {
					var res = LeadGenService.GetSubscribtion(new LandingSubscriptionRequest {
						LandingId = formId
					});
					if (res.IsLeadGenSubscribed) {
						landingsWithFbIntegration.Add(formId, res.PageName);
					}
				});
				if (!landingsWithFbIntegration.Any()) {
					return true;
				}
				foreach (var record in landingsWithFbIntegration) {
					new Update(_userConnection, "GeneratedWebForm")
						.Set("IsFbWebForm", Column.Parameter(true))
						.Set("WebPageName", Column.Parameter(record.Value))
						.Where("Id").IsEqual(Column.Parameter(record.Key))
						.Execute();
				}
			}
			catch (Exception ex) {
				Log.Error("Error when migrate column IsFbWebForm", ex);
				result = false;
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public void Execute(UserConnection userConnection) {
			_userConnection = userConnection;
			var result = UpdateIsFbWebForm();
			if (!result) {
				Log.Error("Exception when migrate column IsFbWebForm. See more info in logs");
				return;
			}
			Log.Info("Successfully migrate column IsFbWebForm");
		}

		#endregion

	}

	#endregion

}




