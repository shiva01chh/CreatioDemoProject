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
	using Terrasoft.Configuration.Passport;
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

	#region Class: SupplyPaymentElement_PassportEventsProcess

	public partial class SupplyPaymentElement_PassportEventsProcess<TEntity>
	{

		#region Methods: Public
		
		public virtual void UpdateLinkedElements() {
			var passportHelper = ClassFactory.Get<OrderPassportHelper>(new ConstructorArgument("userConnection", UserConnection));
			passportHelper.UpdateLinkedElements(Entity);
		}

		public virtual void CheckNeedToUpdateInvoice() {
			List<string> changedColumnNames = Entity.GetChangedColumnValues().ToList().ConvertAll(cv => cv.Column.Name);
			IsInvoiceExists = Entity.GetTypedColumnValue<Guid>("InvoiceId") != Guid.Empty;
			NeedToUpdateInvoice = IsInvoiceExists && changedColumnNames.Any(c => c == "PrimaryAmountPlan");
			NeedToUpdateOrderPaymentAmount = changedColumnNames.Any(c => c == "PrimaryAmountFact");
		}

		public virtual void OnDeleted() {
			var orderAmountHelper = ClassFactory.Get<OrderAmountHelper>(new ConstructorArgument("userConnection", UserConnection));
			orderAmountHelper.UpdateOrderPaymentAmountOnSupplyPaymentElementDeleted(Entity.GetTypedColumnValue<Guid>("OrderId"));
		}

		public virtual void OnSaved() {
			var orderAmountHelper = ClassFactory.Get<OrderAmountHelper>(new ConstructorArgument("userConnection", UserConnection));
			if (NeedToUpdateInvoice) {
				EntitySchemaColumn invoiceColumn = Entity.Schema.Columns.GetByName("Invoice");
				if (!Entity.GetIsColumnValueLoaded(invoiceColumn) || Entity.GetTypedColumnValue<Guid>(invoiceColumn) != Guid.Empty) {
					orderAmountHelper.UpdateInvoiceBySupplyPaymentElementId(Entity.PrimaryColumnValue);
				}
			}
			if (NeedToUpdateOrderPaymentAmount) {
				orderAmountHelper.UpdateOrderPaymentAmountOnSPEChanged(Entity.PrimaryColumnValue);
			}
		}

		#endregion

	}

	#endregion

}

