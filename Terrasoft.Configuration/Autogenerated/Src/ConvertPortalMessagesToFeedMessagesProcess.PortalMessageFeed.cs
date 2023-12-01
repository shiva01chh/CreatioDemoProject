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
	using Terrasoft.Configuration.PortalMessageFeed;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: ConvertPortalMessagesToFeedMessagesProcessMethodsWrapper

	/// <exclude/>
	public class ConvertPortalMessagesToFeedMessagesProcessMethodsWrapper : ProcessModel
	{

		public ConvertPortalMessagesToFeedMessagesProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ActualizePortalMessagesExecute", ActualizePortalMessagesExecute);
		}

		#region Methods: Private

		private bool ActualizePortalMessagesExecute(ProcessExecutingContext context) {
			var userConnection = Get<UserConnection>("UserConnection");
			var userConnectionArgument = new ConstructorArgument("userConnection", userConnection);
			var messagesActualizer = ClassFactory.Get<IPortalMessagesActualizer>(userConnectionArgument);
			var dateFrom = Get<DateTime>("DateFrom");
			var dateTo = Get<DateTime>("DateTo");
			messagesActualizer.ActualizePortalMessages(dateFrom, dateTo);
			SendReminding(this.Get<string>("CompleteNotificationText"));
			return true;
		}

			public virtual void SendReminding(string message) {
				var remindEntity = RemindingServerUtilities.GetRemindingByProcess(UserConnection, "ConvertPortalMessagesToFeedMessagesProcess", message);
				remindEntity.Save();
			}

		#endregion

	}

	#endregion

}

