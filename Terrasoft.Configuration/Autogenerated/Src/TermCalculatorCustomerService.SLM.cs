using System;
using System.Linq;
using Terrasoft.Core;
using Terrasoft.Core.Entities;

namespace Terrasoft.Configuration
{

	#region Class: TermCalculatorCustomerService

	public class TermCalculatorCustomerService : TermCalculator
	{
		#region Constructors: Public

		public TermCalculatorCustomerService(UserConnection userConnection, Guid serviceItemId, Guid priorityId) 
			: base(userConnection, serviceItemId, priorityId) {
		}

		#endregion
		
		#region Methods: Protected

		protected override Guid GetCalendarId() {
			return ServiceItem != null && ServiceItem.GetTypedColumnValue<Guid>("CalendarId") != Guid.Empty
				? ServiceItem.GetTypedColumnValue<Guid>("CalendarId")
				: base.GetCalendarId();
		}

		#endregion

		#region Methods: Public

		public override ResponseTime GetMinResponseTime(ResponseTimeColumnsConfig respondTimeColumnsConfig) {
			ResponseTime serviceResponse = base.GetMinResponseTime(respondTimeColumnsConfig);
			return GetMinResponseTimeByPriority(serviceResponse, respondTimeColumnsConfig);
		}

		#endregion
	}

	#endregion
}












