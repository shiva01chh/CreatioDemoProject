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

	#region Class: Lead_WebLeadFormEventsProcess

	public partial class Lead_WebLeadFormEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void LeadInserted() {
			base.LeadInserted();
			if (Entity.GetIsColumnValueLoaded("QualifiedContactId") && Guid.Empty != Entity.QualifiedContactId ||
					Entity.GetIsColumnValueLoaded("WebFormId") && Guid.Empty == Entity.WebFormId) {	
				return;
			}
			ProcessSchema schema = UserConnection.ProcessSchemaManager
				.GetInstanceByName("LeadManagementIdentification");
			var parameterValues = new Dictionary<string, string>();
			parameterValues.Add("LeadId", Entity.Id.ToString());
			RunProcess(schema.UId, parameterValues);
		}

		#endregion

	}

	#endregion

}

