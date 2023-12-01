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

	#region Class: OrderProduct_OrderEventsProcess

	public partial class OrderProduct_OrderEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void RecalculateOrderAmount() {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "OrderProduct");
			var totalAmountColumn = esq.AddColumn(esq.CreateAggregationFunction(AggregationTypeStrict.Sum, "TotalAmount"));
			var primaryTotalAmountColumn = esq.AddColumn(esq.CreateAggregationFunction(AggregationTypeStrict.Sum, "PrimaryTotalAmount"));
			var orderId = Entity.GetTypedColumnValue<Guid>("OrderId");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Order", orderId));
			var entity = esq.GetEntityCollection(UserConnection).FirstOrDefault();
			if (entity == null) {
				return;
			}
			var order = UserConnection.EntitySchemaManager.GetInstanceByName("Order").CreateEntity(UserConnection);
			if (order.FetchFromDB(orderId)) {
				var amount = entity.GetTypedColumnValue<decimal>(totalAmountColumn.Name);
				var primaryAmount = entity.GetTypedColumnValue<decimal>(primaryTotalAmountColumn.Name);
				order.SetColumnValue("Amount", amount);
				order.SetColumnValue("PrimaryAmount", primaryAmount);
				order.Save(false);
			}
		}

		public virtual void LoadCurrencyFromOrder() {
			var currencyId = Entity.GetColumnValue("CurrencyId");
			if (currencyId == null) {
				var orderId = Entity.GetTypedColumnValue<Guid>("OrderId");
				if (orderId == Guid.Empty) {
					return;
				}
				var orderEsq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Order");
				var currnecyIdColumn = orderEsq.AddColumn("Currency.Id");
				var currnecyDivisionColumn = orderEsq.AddColumn("Currency.Division");
				var currnecyRateColumn = orderEsq.AddColumn("CurrencyRate");
				var order = orderEsq.GetEntity(UserConnection, orderId);
				if (order != null) {
					var division = order.GetTypedColumnValue<decimal>(currnecyDivisionColumn.Name);
					var currencyRate = order.GetTypedColumnValue<decimal>(currnecyRateColumn.Name);
					Entity.SetColumnValue("CurrencyId", order.GetTypedColumnValue<Guid>(currnecyIdColumn.Name));
					Entity.SetColumnValue("CurrencyRate", currencyRate);
					CurrencyRate = currencyRate / (division != 0 ? division : 1);
					NeedRecalcPrimaryValues = true;
				}
			}
			return;
		}

		public override void UpdatePrimaryAmounts() {
			if (NeedRecalcPrimaryValues){
				base.UpdatePrimaryAmounts();
			}
		}

		#endregion


	}

	#endregion

}

