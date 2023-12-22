﻿namespace Terrasoft.Core.Process.Configuration
{
	using Terrasoft.Configuration.ProcessDesigner;
	using Terrasoft.Core.Entities;

	#region Class: EmailProcessTemplateUserTaskMessageProvider

	public class EmailProcessTemplateUserTaskMessageProvider : BaseProcessEmailMessageProvider
	{

		#region Constructors: Public

		public EmailProcessTemplateUserTaskMessageProvider(EmailTemplateUserTask userTask)
			: base(userTask) {
		}

		#endregion

		#region Methods: Protected

		protected override string GetEmailBody() {
			return EmailUserTask.Body;
		}

		protected override EntitySchemaQuery GetSenderEsq() {
			EntitySchemaQuery esq = base.GetSenderEsq();
			if (EmailUserTask.SendEmailType == (int)SendEmailType.Auto) {
				esq.UseAdminRights = false;
			}
			return esq;
		}

		#endregion

	}

	#endregion

}













