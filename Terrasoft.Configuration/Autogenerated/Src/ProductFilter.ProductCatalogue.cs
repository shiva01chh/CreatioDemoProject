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

	#region Class: ProductFilter_ProductCatalogueEventsProcess

	public partial class ProductFilter_ProductCatalogueEventsProcess<TEntity>
	{

		#region Methods: Public
		
		public override EntitySchemaQueryFilterCollection GetDetailFilter(Entity entity, EntitySchemaQuery esq) {
			var productTypeId = entity.GetTypedColumnValue<Guid>("ProductTypeId");
			if (productTypeId != null && productTypeId!=Guid.Empty) {
				var filterValues = new object[] { productTypeId };
				var resultFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "ProductType", filterValues);
				var resultCollection = new EntitySchemaQueryFilterCollection(esq, resultFilter);
				return resultCollection;
			} else return null;
		}

		public override string GetGrouppingColumnNames() {
			return "ProductTypeId";
		}

		#endregion

	}

	#endregion

}

