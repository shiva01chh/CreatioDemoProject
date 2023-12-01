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
	using Terrasoft.Configuration;
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

	#region Class: Invoice_PassportEventsProcess

	public partial class Invoice_PassportEventsProcess<TEntity>
	{

		#region Methods: Public
		
		public virtual void CleanInvoiceIdInSupplyPayment() {
			var supplyPaymentElementSchema = UserConnection.EntitySchemaManager.GetInstanceByName("SupplyPaymentElement");
				var item = supplyPaymentElementSchema.CreateEntity(UserConnection);
				var invoiceId = Entity.GetTypedColumnValue<Guid>("Id");
				if (item.FetchFromDB(new Dictionary<string, object>{{"Invoice", invoiceId}})) {
					item.SetColumnValue("InvoiceId", null);
					item.SetColumnValue("AmountFact", null);
					item.SetColumnValue("PrimaryAmountFact", null);
					item.SetColumnValue("DateFact", null);
					item.SetColumnValue("StateId", PassportConstants.SupplyPaymentStateNotFinished);
					item.Save(false);
				};
		}

		public override void OnSaved() {
			var orderAmountHelper = GetOrderAmountHelper();
			if (NeedFinRecalc) {
				bool productAmountRecalculated = orderAmountHelper.UpdateInvoiceProductAmountOnCurrencyChange(Entity.PrimaryColumnValue);
				NeedFinRecalc = !productAmountRecalculated;
			}
			base.OnSaved();
			var changedColumnValues = ChangedColumnValues as List<EntityColumnValue>;
			if (changedColumnValues == null) {
				return;
			}
			bool orderPaymentAmountUpdated;
			orderAmountHelper.UpdateSupplyPaymentElementOnInvoiceChanged(Entity.PrimaryColumnValue, changedColumnValues, out orderPaymentAmountUpdated);
			var paymentStatusColumnValue = changedColumnValues.FirstOrDefault(changedColumn => changedColumn.Column.Name == "PaymentStatus");
			if (paymentStatusColumnValue != null && (Guid)paymentStatusColumnValue.Value == PassportConstants.InvoicePaymentStatusCanceled) {
				CleanInvoiceIdInSupplyPayment();
			}
			if (!orderPaymentAmountUpdated && changedColumnValues.ConvertAll(cv => cv.Column.Name).Intersect(new[] { "PrimaryPaymentAmount", "PaymentStatus" }).Any()) {
				orderAmountHelper.UpdateOrderPaymentAmountOnInvoiceChanged(Entity.PrimaryColumnValue);
			}
		}

		public virtual OrderAmountHelper GetOrderAmountHelper() {
			return ClassFactory.Get<OrderAmountHelper>(new ConstructorArgument("userConnection", UserConnection));
		}

		#endregion

	}

	#endregion

}

