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

	#region Class: InvoiceProduct_InvoiceEventsProcess

	public partial class InvoiceProduct_InvoiceEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void UpdateInvoiceAmount(UserConnection userConnection) {
			decimal sumTotalAmount = 0; 
			decimal sumPrimaryTotalAmount = 0; 
			var esq = new EntitySchemaQuery(userConnection.EntitySchemaManager, "InvoiceProduct");
			var totalAmountColumn = esq.AddColumn("TotalAmount");
			var primaryTotalAmountColumn = esq.AddColumn("PrimaryTotalAmount");
			var invoiceId = this.Entity.GetTypedColumnValue<Guid>("InvoiceId");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Invoice", invoiceId));
			var entityCollection = esq.GetEntityCollection(userConnection);
			if (entityCollection.Count > 0) {
				foreach(var entity in entityCollection) {
					sumTotalAmount += entity.GetTypedColumnValue<decimal>(totalAmountColumn.Name);
					sumPrimaryTotalAmount += entity.GetTypedColumnValue<decimal>(primaryTotalAmountColumn.Name);
				}
			}
			var update = new Update(userConnection, "Invoice")
				.Set("Amount",Column.Parameter(sumTotalAmount))
				.Set("PrimaryAmount",Column.Parameter(sumPrimaryTotalAmount))
				.Where("Id").IsEqual(Column.Parameter(invoiceId)) as Update;
			update.Execute();
		}

		#endregion

	}

	#endregion

}

