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
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Lead_CoreLeadEventsProcess

	public partial class Lead_CoreLeadEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void LeadInserted() {
			base.LeadInserted();
			if (CanStartQualificationProcess()) {
				StartQualificationProcess();
			}
		}

		public override void LeadSavingMethod() {
			base.LeadSavingMethod();
			DisqualifyLeadOnFinalStage();
		}

		public virtual void StartQualificationProcess() {
			Guid leadManagementProcessUId = (Guid)Terrasoft.Core.Configuration.SysSettings.GetValue(
				UserConnection, "LeadManagementProcess");
			ProcessSchema schema;
			if (leadManagementProcessUId.IsEmpty()) {
				schema = UserConnection.ProcessSchemaManager.GetInstanceByName("LeadManagement");
			} else {
				schema = UserConnection.ProcessSchemaManager.GetInstanceByUId(leadManagementProcessUId);
			}
			var parameterValues = new Dictionary<string, string>();
			parameterValues.Add("LeadId", Entity.Id.ToString());
			RunProcess(schema.UId, parameterValues);
		}

		public virtual void DisqualifyLeadOnFinalStage() {
			if (!Entity.GetIsColumnValueLoaded("QualifyStatusId")) {
				return;
			}
			Guid qualifyStatusId = Entity.GetTypedColumnValue<Guid>("QualifyStatusId");
			Select isStatusFinalSelect = new Select(UserConnection)
				.Column("IsFinal")
				.From("QualifyStatus")
				.Where("Id")
				.IsEqual(Column.Parameter(qualifyStatusId)) as Select;
			bool isStatusFinal = isStatusFinalSelect.ExecuteScalar<bool>();
			if (!isStatusFinal) {
				return;
			}
			Guid qualificationProcessId = Entity.GetTypedColumnValue<Guid>("QualificationProcessId");
			if (qualificationProcessId.IsEmpty()) {
				return;
			}
			Process process = UserConnection.ProcessEngine.FindProcessByUId(qualificationProcessId.ToString(), true);
			if (process == null) {
				return;
			}
			if (process.Status == ProcessStatus.Running) {
				process.CancelExecution();
				Entity.SetColumnValue("QualificationProcessId", null);
			};
		}

		public virtual bool CanStartQualificationProcess() {
			if (Entity.GetIsColumnValueLoaded("QualifyStatusId")) {
				Guid qualifyStatusId = Entity.GetTypedColumnValue<Guid>("QualifyStatusId");
				if (qualifyStatusId == LeadConsts.QualificationUId) {
					return false;
				}
			}
			bool startLeadManagementProcess = true;
			if (Entity.IsColumnValueLoaded("StartLeadManagementProcess")) {
				startLeadManagementProcess = Entity.GetTypedColumnValue<bool>("StartLeadManagementProcess");
			}
			bool useLeadManagementProcess = (bool)Terrasoft.Core.Configuration.SysSettings.GetValue(
				UserConnection, "UseProcessLeadManagement");
			if (!useLeadManagementProcess || !startLeadManagementProcess) {
				return false;
			}
			return true;
		}

		#endregion

	}

	#endregion

}

