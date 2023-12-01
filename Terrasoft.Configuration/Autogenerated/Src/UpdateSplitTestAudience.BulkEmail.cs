namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.MandrillService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: UpdateSplitTestAudienceMethodsWrapper

	/// <exclude/>
	public class UpdateSplitTestAudienceMethodsWrapper : ProcessModel
	{

		public UpdateSplitTestAudienceMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("MainScriptTaskExecute", MainScriptTaskExecute);
		}

		#region Methods: Private

		private bool MainScriptTaskExecute(ProcessExecutingContext context) {
			Main();
			return true;
		}

			
			private void Main() {
				var recordId = Get<Guid>("RecordId");
				var data = new UpdateTargetAudienceData(null, "BulkEmailSplit", recordId, false);
				Core.Tasks.Task.StartNewWithUserConnection<UpdateAudienceBackgroundTask, UpdateTargetAudienceData>(data);
			}
			

		#endregion

	}

	#endregion

}

