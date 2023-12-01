﻿namespace Terrasoft.Configuration
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

	#region Class: PartnershipParameter_PRMOrderEventsProcess

	public partial class PartnershipParameter_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public
		public override string getLookupNameByParamCategory(Guid PartnerParamCategoryId) {
			if (PartnerParamCategoryId.Equals(PRMOrderConstants.PricelistPartnerParamCategory)) {
				return "Pricelist";
			};
			return base.getLookupNameByParamCategory(PartnerParamCategoryId);
		}
			#endregion

	}

	#endregion

}

