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
	using Terrasoft.Configuration.PRM;
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

	#region Class: Lead_PRMPortalEventsProcess

	public partial class Lead_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void PartnerGrantRight() {
			Guid partnerId =Entity.GetTypedColumnValue<Guid>("PartnerId");
			PRMUtility utility = new PRMUtility(UserConnection);
			Guid recordId = Entity.GetTypedColumnValue<Guid>("Id");
			Guid partnershipRoleId = utility.GetPartnershipRoleByAccount(partnerId);
			if(partnershipRoleId != Guid.Empty) {
				RightsManagerHelper rightsHelper = new RightsManagerHelper(UserConnection, Entity.SchemaName);
				RightsParams param = new RightsParams(recordId, PRMBaseConstants.SysEntitySchemaRecRightSourceLeadPartnerOwner);
				param.SysAdminUnitId = partnershipRoleId;
				param.OperationsRights = new Dictionary<EntitySchemaRecordRightLevel, List<EntitySchemaRecordRightOperation>> { {
								EntitySchemaRecordRightLevel.Allow,
									new List<EntitySchemaRecordRightOperation> {
										EntitySchemaRecordRightOperation.Read,
										EntitySchemaRecordRightOperation.Edit,
										EntitySchemaRecordRightOperation.Delete
									}
								}
							};
				rightsHelper.GrantRightsForRecord(param);
			}
		}

		#endregion

	}

	#endregion

}

