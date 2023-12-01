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
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: MailingHandlersProcessMethodsWrapper

	/// <exclude/>
	public class MailingHandlersProcessMethodsWrapper : ProcessModel
	{

		public MailingHandlersProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("MainScriptTaskExecute", MainScriptTaskExecute);
		}

		#region Methods: Private

		private bool MainScriptTaskExecute(ProcessExecutingContext context) {
			Main();
			return true;
		}

		private void Main() {
			var userConnection = Get<UserConnection>("UserConnection");
			string operation = Get<string>("Operation");
			switch (operation) {
				case "EnableActiveProviderHandlers":
					MailingHandlersUtilities.EnableActiveProviderHandlers(userConnection);
					break;
			}
		}

		#endregion

	}

	#endregion

}

