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
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Mail;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: OrderVisa_OrderEventsProcess

	public partial class OrderVisa_OrderEventsProcess<TEntity>
	{

		#region Methods: Public

		public override List<string> GetVisaTemplateSchemaQueryColumns() {
			List<string> columns = base.GetVisaTemplateSchemaQueryColumns();
			columns.AddRange( new string[] {
				"Order.Number",
				"Order.Date",
				"Order.Currency.ShortName",
				"Order.Amount",
				"Order.Owner.Name",
				"Order.Contact.Name",
				"Order.Account.Name"
			});
			return columns;
		}

		public override INotificationInfo GetNotificationInfo() {
			Entity.Order.FetchFromDB(Entity.OrderId);
			var order = Entity.Order;
			var orderDate = order.Date.ToString(PopupBodyDateFormat);
			var accountName = order.AccountName;
			var contactName = order.ContactName;
			var accountContactString = string.Join(", ", new[] {accountName, contactName}.Where(s => s.IsNotEmpty()));
			var body = string.Format(PopupBodyTemplate, order.Number, orderDate, accountContactString);
			var notificationInfo = base.GetNotificationInfo();
			notificationInfo.EntityId = order.Id;
			notificationInfo.Body = body;
			return notificationInfo;
		}

		#endregion



	}

	#endregion

}

