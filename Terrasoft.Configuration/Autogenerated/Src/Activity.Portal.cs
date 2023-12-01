namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Web;
	using SystemSettings = Terrasoft.Core.Configuration.SysSettings;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration.Packages.Case;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Activity_PortalEventsProcess

	public partial class Activity_PortalEventsProcess<TEntity>
	{

		#region Methods: Public

		public override bool OnActivitySaved(ProcessExecutingContext context) {
			var isBaseSavedSuccess = base.OnActivitySaved(context);
			if (isBaseSavedSuccess && Entity.GetTypedColumnValue<Guid>("TypeId") == ActivityConsts.EmailTypeUId) {
				Guid caseId = Entity.GetTypedColumnValue<Guid>("CaseId");
				if (caseId != Guid.Empty) {
					bool isUniqueMessage = IsUniquePortalEmailMessage(Entity);
					bool isNeedShowEmail =
									Entity.GetTypedColumnValue<DateTime>("SendDate") != default(DateTime)
									&& !Entity.GetTypedColumnValue<bool>("IsAutoSubmitted")
									&& Entity.UserConnection.GetIsFeatureEnabled("ShowEmailOnPortalByCaseContact")
									&& isUniqueMessage;
					if (isNeedShowEmail) {
						PortalEmailMessageUtilities.ShowOnPortal(Entity);
					} else {
						PortalEmailMessageUtilities.Log.DebugFormat($"Email {Entity.GetTypedColumnValue<Guid>("Id")} was not added to the portal. Reasons: " +
							$"CaseId - {Entity.GetTypedColumnValue<Guid>("CaseId")} " +
							$"SendDate - {Entity.GetTypedColumnValue<DateTime>("SendDate")} " +
							$"IsAutoSubmitted - {Entity.GetTypedColumnValue<bool>("IsAutoSubmitted")} " +
							$"IsUniqueMessage - {isUniqueMessage}" +
							$"ShowEmailOnPortalByCaseContact - {Entity.UserConnection.GetIsFeatureEnabled("ShowEmailOnPortalByCaseContact")} ");
					}
				}
				if (caseId == Guid.Empty) {
					PortalEmailMessageUtilities.Log.DebugFormat($"Email {Entity.GetTypedColumnValue<Guid>("Id")} was not added to the portal. CaseId is empty");
				}
			}
			return isBaseSavedSuccess;
		}

		public virtual bool IsUniquePortalEmailMessage(Entity activity) {
			var select = new Select(activity.UserConnection)
							.Column(Func.Count("PortalEmailMessage", "Id"))
							.From("PortalEmailMessage")
							.Join(JoinType.Inner, "CaseMessageHistory")
								.On("PortalEmailMessage", "CaseMessageHistoryId")
								.IsEqual("CaseMessageHistory", "Id")
							.Where("CaseMessageHistory", "RecordId")
								.IsEqual(Column.Parameter(activity.PrimaryColumnValue)) as Select;
			var count = select.ExecuteScalar<int>();
			return count == 0;
		}

		#endregion

	}

	#endregion

}

