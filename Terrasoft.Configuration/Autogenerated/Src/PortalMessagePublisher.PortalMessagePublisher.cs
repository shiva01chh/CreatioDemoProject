using System.Collections.Generic;
using Terrasoft.Core;

namespace Terrasoft.Configuration
{
	
	#region Class: PortalMessagePublisher

	public class PortalMessagePublisher : BaseMessagePublisher
	{

		#region Constructor: Public

		public PortalMessagePublisher(UserConnection userConnection, Dictionary<string, string> entityFieldsData)
			: base(userConnection, entityFieldsData) {
			EntitySchemaName = "PortalMessage";
		}

		#endregion

	}

	#endregion

}





