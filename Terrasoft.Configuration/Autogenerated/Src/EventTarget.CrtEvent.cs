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

	#region Class: EventTarget_CrtEventEventsProcess

	public partial class EventTarget_CrtEventEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void UpdateEventRecipientCount(int incCount) {
			var eventId = Entity.GetTypedColumnValue<Guid>("EventId");
			if (eventId == Guid.Empty) {
				return;
			}
			var updateEvent = new Update(UserConnection, "Event")
				.Set("ModifiedOn", Column.Parameter(DateTime.UtcNow))
				.Set("ModifiedById", Column.Parameter(UserConnection.CurrentUser.ContactId))
				.Set("RecipientCount", QueryColumnExpression.Add(new QueryColumnExpression("RecipientCount"),
					Column.Parameter(incCount)))
				.Where("Id").IsEqual(Column.Parameter(eventId)) as Update;
			updateEvent.Execute();
		}

		#endregion

	}

	#endregion

}

