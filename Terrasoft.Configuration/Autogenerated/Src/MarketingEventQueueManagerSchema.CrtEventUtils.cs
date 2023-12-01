﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MarketingEventQueueManagerSchema

	/// <exclude/>
	public class MarketingEventQueueManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MarketingEventQueueManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MarketingEventQueueManagerSchema(MarketingEventQueueManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("984528d6-3e46-5218-86cd-4ff4eca30139");
			Name = "MarketingEventQueueManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,84,77,111,218,64,16,61,19,41,255,97,68,47,182,132,204,29,2,81,67,171,40,82,211,164,77,218,107,181,216,131,217,198,222,117,247,131,8,69,249,239,157,253,48,152,0,81,147,114,193,59,51,111,230,205,155,217,21,172,70,221,176,28,225,30,149,98,90,46,76,54,147,98,193,75,171,152,225,82,156,158,60,157,158,244,172,230,162,132,187,181,54,88,143,55,231,46,68,225,214,94,86,114,206,170,209,104,38,235,90,138,236,139,44,75,50,31,195,101,159,46,200,69,206,15,10,75,170,8,179,138,105,61,130,107,166,30,208,80,252,231,21,10,243,205,162,197,107,38,88,137,202,71,15,135,67,56,211,182,174,153,90,79,227,153,152,27,198,133,134,26,205,82,22,26,140,132,71,169,30,224,145,155,37,69,35,66,174,112,49,233,31,200,221,31,78,225,143,251,200,98,178,155,6,73,2,212,123,224,14,31,212,154,8,17,180,5,157,13,59,148,26,59,175,120,14,185,235,231,149,118,96,4,23,76,227,71,91,112,20,57,118,93,103,123,181,92,222,39,47,192,86,47,41,180,81,54,55,82,145,108,183,190,104,136,136,4,142,151,78,126,104,84,132,23,152,187,97,131,221,57,166,196,108,78,204,146,151,230,39,120,142,20,80,20,129,197,46,165,91,37,73,61,195,209,17,82,210,16,16,139,16,226,85,226,98,137,138,155,66,230,48,156,122,166,109,16,200,21,109,7,47,16,168,39,183,44,158,238,93,190,196,154,125,165,101,133,201,20,4,253,203,69,114,160,173,116,252,31,69,110,154,127,45,115,211,188,183,208,119,204,165,42,102,178,178,181,104,235,236,205,56,11,81,206,63,126,131,206,157,193,191,188,28,222,224,238,33,170,108,227,239,174,42,81,230,43,218,118,184,162,40,248,85,249,208,113,103,135,54,141,248,128,144,10,220,211,208,235,149,104,92,27,17,4,231,231,144,180,223,19,23,25,119,45,187,68,19,112,201,139,251,23,172,253,52,245,5,123,122,55,223,4,86,172,178,254,121,233,29,92,187,174,32,215,225,226,191,127,235,246,134,1,51,133,36,76,60,37,151,150,23,192,139,65,59,208,223,90,138,1,112,97,64,33,89,80,167,196,221,183,177,63,214,144,41,113,232,0,107,33,111,93,166,43,65,23,210,0,9,26,190,98,1,42,166,214,247,88,55,149,43,51,151,178,2,174,195,51,70,218,176,202,251,211,56,181,21,83,68,219,231,153,248,91,158,189,158,238,64,166,48,46,106,194,42,17,115,101,119,104,146,240,66,94,21,253,1,8,124,4,31,124,203,20,173,179,113,195,239,120,109,85,13,160,239,52,109,167,255,252,70,41,86,146,230,65,69,119,139,232,132,94,234,86,166,192,108,112,96,180,117,248,111,37,241,42,28,201,213,38,105,33,227,141,136,205,38,144,132,140,42,108,193,33,110,27,227,84,190,88,187,171,189,21,34,205,126,186,13,39,120,204,158,69,207,241,157,143,214,93,163,183,209,239,47,135,77,194,153,213,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("984528d6-3e46-5218-86cd-4ff4eca30139"));
		}

		#endregion

	}

	#endregion

}
