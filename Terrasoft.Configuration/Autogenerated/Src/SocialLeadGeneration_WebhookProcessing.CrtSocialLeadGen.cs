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
	using Terrasoft.Configuration.SocialLeadGen;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: SocialLeadGeneration_WebhookProcessingMethodsWrapper

	/// <exclude/>
	public class SocialLeadGeneration_WebhookProcessingMethodsWrapper : ProcessModel
	{

		public SocialLeadGeneration_WebhookProcessingMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			const string facebookSocialType = "Facebook";
			const string linkedInSocialType = "LinkedIn";
			try {
				var webhookMetadata = Get<string>("WebhookMetadata");
				var leadNotifyWebhook = WebhookParser.ParseLeadNotify(webhookMetadata);
				var socialType = leadNotifyWebhook.Metadata.Facebook == null ? linkedInSocialType : facebookSocialType;
				var formId = string.Empty;
				switch (socialType) {
					case linkedInSocialType:
						formId = leadNotifyWebhook.Metadata.LinkedIn.Form.Id.ToString();
						break;
				}
				Set("FormId", formId);
				Set("SocialLeadId", leadNotifyWebhook.SocialLeadId);
				Set("SocialNetworkCreatedOn", leadNotifyWebhook.SubmittedAt);
				Set("NetworkType", socialType);
				Set("IntegrationId", leadNotifyWebhook.IntegrationId);
				Set("ParsingResult", true);
			} catch (Exception exception) {
				Set("ErrorMessage", exception.ToString());
				Set("ParsingResult", false);
				return true;
			}
			return true;
		}

		#endregion

	}

	#endregion

}

