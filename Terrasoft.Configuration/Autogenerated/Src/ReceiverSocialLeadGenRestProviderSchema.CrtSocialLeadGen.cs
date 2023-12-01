﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReceiverSocialLeadGenRestProviderSchema

	/// <exclude/>
	public class ReceiverSocialLeadGenRestProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReceiverSocialLeadGenRestProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReceiverSocialLeadGenRestProviderSchema(ReceiverSocialLeadGenRestProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e6789141-f710-43ad-8bb1-a41f21802a85");
			Name = "ReceiverSocialLeadGenRestProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,85,223,111,218,48,16,126,166,82,255,135,19,155,42,144,80,216,115,41,173,166,174,101,145,58,9,1,221,203,52,77,38,57,50,171,142,205,108,39,19,67,252,239,59,219,9,144,22,74,181,229,161,170,207,247,235,251,238,59,35,89,142,102,201,18,132,25,106,205,140,90,216,232,86,201,5,207,10,205,44,87,50,154,170,132,51,241,128,44,29,161,60,63,91,159,159,181,10,195,101,6,211,149,177,152,15,206,207,128,190,125,83,52,18,106,206,4,255,227,19,52,28,246,139,104,28,108,115,185,83,40,11,67,127,104,54,65,142,228,250,78,99,70,7,184,21,204,152,75,152,96,130,188,68,221,104,112,130,198,142,181,42,121,138,218,7,245,251,125,184,50,69,158,51,189,186,174,206,149,3,112,185,80,58,247,21,96,161,85,14,186,74,9,6,117,201,19,140,234,4,253,189,12,203,98,46,120,2,137,235,226,116,19,112,9,175,52,216,90,251,38,183,208,232,102,137,218,114,36,124,99,205,75,102,49,56,60,135,225,13,129,110,106,214,90,34,209,128,164,97,2,65,130,57,51,248,2,12,20,90,68,219,92,251,136,90,203,80,138,66,88,170,164,88,129,177,218,141,229,135,241,173,111,65,134,68,143,90,80,229,105,168,122,171,136,200,33,180,167,71,60,219,131,10,33,202,52,128,252,31,196,147,3,152,160,100,162,192,19,200,42,64,199,186,132,117,80,105,253,101,104,97,13,46,65,171,165,209,22,90,238,73,52,218,161,55,209,8,237,87,87,191,243,72,45,209,189,196,196,233,169,247,86,238,186,209,76,77,125,115,157,238,192,23,220,184,191,155,215,89,163,66,132,168,72,172,210,142,55,175,200,87,104,219,115,7,181,0,22,196,123,132,50,111,89,50,205,114,47,168,97,187,104,32,107,95,199,148,140,73,34,159,82,53,81,71,87,125,31,24,168,15,123,114,114,67,158,49,7,205,114,93,207,201,165,151,116,231,217,21,141,232,4,79,95,208,254,84,233,155,40,98,66,24,248,56,142,29,170,23,171,227,150,138,116,160,57,150,8,130,27,235,188,4,97,57,70,98,5,190,84,60,165,218,66,60,112,249,132,105,44,29,126,211,249,68,146,156,241,220,201,146,105,235,78,61,216,218,8,74,176,4,205,126,251,14,60,147,36,190,29,129,113,106,122,48,87,74,208,11,150,136,34,197,88,50,98,164,196,9,147,25,26,90,199,5,19,134,50,140,10,42,127,67,94,22,179,240,146,198,41,221,166,184,96,133,176,61,16,74,102,55,14,92,190,111,239,186,109,32,210,171,157,113,43,54,132,247,237,245,177,229,217,244,217,146,247,29,202,9,254,42,104,178,166,47,60,92,46,219,65,210,37,211,144,50,203,40,143,196,223,80,147,225,137,113,132,56,57,84,177,85,237,214,180,102,134,98,182,44,237,118,165,109,218,59,202,238,253,43,30,211,107,30,197,146,106,113,38,253,169,219,11,185,238,2,163,148,169,226,246,31,243,196,71,216,62,56,133,58,230,229,236,92,196,129,137,214,53,154,179,234,52,134,23,125,102,198,63,55,112,113,209,28,107,20,204,195,161,31,122,116,151,47,237,138,70,47,137,98,250,9,106,184,214,112,238,235,185,119,130,2,26,201,107,81,12,225,195,46,77,48,134,149,220,132,209,78,137,210,153,122,66,201,255,96,58,86,219,57,94,29,221,119,250,127,73,239,17,94,119,72,89,61,175,139,240,242,29,222,229,96,109,26,201,70,223,95,70,128,117,78,188,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e6789141-f710-43ad-8bb1-a41f21802a85"));
		}

		#endregion

	}

	#endregion

}
