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

	#region Class: Invoice_InvoiceEventsProcess

	public partial class Invoice_InvoiceEventsProcess<TEntity>
	{

		#region Methods: Public
		
		public virtual decimal Multiply(decimal arg1, decimal arg2) {
			return Math.Round(arg1 * arg2,2);
		}

		public virtual decimal Division(decimal arg1, decimal arg2) {
			decimal result = 0;
			if(arg2 > 0){
				result = Math.Round(arg1 / arg2, 2);
			}
			return result;
		}

		public virtual bool IsFinalStatus() {
			var statusId = Entity.GetTypedColumnValue<Guid>("PaymentStatusId");
			var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "InvoicePaymentStatus");
			var finalColumnName = entitySchemaQuery.AddColumn("FinalStatus").Name;
			var entity = entitySchemaQuery.GetEntity(UserConnection, statusId);
			if (entity != null) {
				return entity.GetTypedColumnValue<bool>(finalColumnName);
			}
			return false;
		}

		public virtual void OnSaving() {
			if (Entity.StoringState == StoringObjectState.New) {
				return;
			}
			NeedFinRecalc = false;
			var oldCurrencyRate = Entity.GetTypedOldColumnValue<decimal>("CurrencyRate");
			var newCurrencyRate = Entity.GetTypedColumnValue<decimal>("CurrencyRate");
			var oldCurrency = Entity.GetTypedOldColumnValue<Guid>("CurrencyId");
			var newCurrency = Entity.GetTypedColumnValue<Guid>("CurrencyId");
			NeedFinRecalc = (oldCurrencyRate != newCurrencyRate) || (oldCurrency != newCurrency);
			
			var oldOwnerId = Entity.GetTypedOldColumnValue<Guid>("OwnerId");
			var newOwnerId = Entity.GetTypedColumnValue<Guid>("OwnerId");
			if (!oldOwnerId.Equals(newOwnerId)) {
				IsOwnerChanged = true;
			}
		}

		public virtual void OnSaved() {
			if (NeedFinRecalc) {
				ProductEntryUtils utils = Core.Factories.ClassFactory.Get<ProductEntryUtils>(new Core.Factories.ConstructorArgument("userConnection", UserConnection));
				utils.UpdateRecordProductAmounts(Entity);
			}
		}

		public virtual bool UpdatePrimaryAmount() {
			var amount = Entity.GetTypedColumnValue<decimal>("Amount");
			var primaryAmount = Entity.GetTypedColumnValue<decimal>("PrimaryAmount");
			if (primaryAmount != 0 || amount == 0) {
				return true;
			}
			Guid currencyId = Entity.GetTypedColumnValue<Guid>("CurrencyId");
			DateTime startDate = Entity.GetTypedColumnValue<DateTime>("StartDate");
			var currencyRateStorage = Terrasoft.Core.Factories.ClassFactory.Get<Terrasoft.Configuration.CurrencyRateStorage>(
				new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection));
			var currencyInfo = currencyRateStorage.GetActualCurrencyRates(currencyId).FirstOrDefault();
			if (currencyInfo != null) {
				decimal currencyRate = Terrasoft.Configuration.CurrencyRateHelper.SetMantissaToRate(currencyInfo.Rate, currencyInfo.RateMantissa);
				int currencyDivision = currencyInfo.Division;
				if (currencyDivision != 0) {
					primaryAmount = amount * currencyDivision / currencyRate;
					Entity.SetColumnValue("PrimaryAmount", primaryAmount);
					Entity.SetColumnValue("CurrencyRate", currencyRate);
				}
			}
			return true;
		}

		public virtual string GetLookupDisplayColumnValue(Entity entity, string lookupName) {
			var rootEntitySchema = entity.Schema;
			var result = string.Empty;
			try {
				var rootEntityColumn = rootEntitySchema.Columns.GetByName(lookupName);
				var recordId = entity.GetTypedColumnValue<Guid>(rootEntityColumn.ColumnValueName);
				result = recordId.IsNotEmpty() 
					? GetFetchedDisplayColumnValue(entity, lookupName, recordId)
					: string.Empty;
			} catch (Exception ex) {
				result = string.Empty;
			}
			return result;
		}

		public virtual string GetFetchedDisplayColumnValue(Entity entity, string lookupName, Guid recordId) {
			var userConnection = entity.UserConnection;
			var lookupEntitySchema = userConnection.EntitySchemaManager.FindInstanceByName(lookupName);
			var lookupEntity = lookupEntitySchema.CreateEntity(userConnection);
			lookupEntity.FetchPrimaryInfoFromDB(lookupEntitySchema.GetPrimaryColumnName(), recordId);
			return lookupEntity.PrimaryDisplayColumnValue;
		}

		#endregion

	}

	#endregion

}

