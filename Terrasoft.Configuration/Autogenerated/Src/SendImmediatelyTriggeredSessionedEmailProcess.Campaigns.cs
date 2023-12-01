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
	using System.Web;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: SendImmediatelyTriggeredSessionedEmailProcessMethodsWrapper

	/// <exclude/>
	public class SendImmediatelyTriggeredSessionedEmailProcessMethodsWrapper : ProcessModel
	{

		public SendImmediatelyTriggeredSessionedEmailProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			SendMailing();
			return true;
		}

			public virtual void SendMailing() {
			
				var userConnection = this.Get<UserConnection>("UserConnection");
				var bulkEmailId = this.Get<Guid>("BulkEmailId");
				var applicationUrl = this.Get<string>("ApplicationUrl");
				var sessionId = this.Get<Guid>("SessionUId");
				
				try {
					var mailingService = ClassFactory.Get<MailingService>(new ConstructorArgument("userConnection", userConnection));
					var isDelayedStart = true;
					mailingService.SendSessionedMessage(bulkEmailId, sessionId, isDelayedStart, applicationUrl);
				} catch (Exception e) {
					MailingUtilities.Log.ErrorFormat(
						"[SendImmediatelyTriggeredSessionedEmailProcess]: "
						+ "Failed to trigger. Params bulkEmailId: {0} sessionId: {1} applicationUrl: {2}.",
							e, bulkEmailId, sessionId, applicationUrl);
					throw e;
				}
					
			}

		#endregion

	}

	#endregion

}

