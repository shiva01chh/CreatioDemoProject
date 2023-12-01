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

	#region Class: ServiceInServicePact_SLMITILServiceEventsProcess

	public partial class ServiceInServicePact_SLMITILServiceEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual string GetServiceItemName() {
			var serviceItemId = Entity.GetTypedColumnValue<Guid>("ServiceItemId");
			var serviceItemNameSelect = new Select(UserConnection)
					.Column("Name")
					.From("ServiceItem")
					.Where("Id").IsEqual(Column.Parameter(serviceItemId)) as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = serviceItemNameSelect.ExecuteReader(dbExecutor)) {
					if(dr.Read()){
						return dr.GetColumnValue<string>("Name");
					} else {
						return null;
					}
				}
			}
		}

		public virtual string GetServicePactName() {
			var servicePactId = Entity.GetTypedColumnValue<Guid>("ServicePactId");
			var servicePactNameSelect = new Select(UserConnection)
					.Column("Name")
					.From("ServicePact")
					.Where("Id").IsEqual(Column.Parameter(servicePactId)) as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = servicePactNameSelect.ExecuteReader(dbExecutor)) {
					if(dr.Read()){
						return dr.GetColumnValue<string>("Name");
					} else {
						return null;
					}
				}
			}
		}

		#endregion

	}

	#endregion

}

