namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration.RightsService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Mail;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: ContractVisa_CoreContractsEventsProcess

	public partial class ContractVisa_CoreContractsEventsProcess<TEntity>
	{

		#region Methods: Public

		public override INotificationInfo GetNotificationInfo() {
			Entity.Contract.FetchFromDB(Entity.ContractId);
			var contract = Entity.Contract;
			var contractDateString = contract.StartDate == default(DateTime) 
				? string.Empty
				: contract.StartDate.ToString(PopupBodyDateFormat);
			var accountName = contract.AccountName;
			var contactName = contract.ContactName;
			var accountContactString = string.Join(", ", new[] {accountName, contactName}.Where(s => s.IsNotEmpty()));
			var body = contractDateString.IsNullOrEmpty()
				? string.Format(PopupBodyTemplateWithoutDate, contract.Number, accountContactString)
				: string.Format(PopupBodyTemplate, contract.Number, contractDateString, accountContactString);
			var notificationInfo = base.GetNotificationInfo();
			notificationInfo.EntityId = contract.Id;
			notificationInfo.Body = body;
			return notificationInfo;
		}

		#endregion

	}

	#endregion

}

