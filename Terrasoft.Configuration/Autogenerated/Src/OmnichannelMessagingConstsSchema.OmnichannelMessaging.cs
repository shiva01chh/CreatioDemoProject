﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OmnichannelMessagingConstsSchema

	/// <exclude/>
	public class OmnichannelMessagingConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OmnichannelMessagingConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OmnichannelMessagingConstsSchema(OmnichannelMessagingConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5e86ae68-80ed-4867-b9da-72eed6375810");
			Name = "OmnichannelMessagingConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("92ff52b6-dfba-4556-90d8-6f4c37f69c5d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,85,223,111,155,48,16,126,94,165,254,15,40,79,219,131,43,108,108,12,170,246,96,27,168,186,169,235,214,68,218,99,229,128,147,162,18,64,96,50,69,85,255,247,29,249,209,38,81,210,166,211,162,60,0,190,251,62,223,221,119,119,165,158,153,182,214,169,113,70,166,105,116,91,77,236,133,170,202,73,62,237,26,109,243,170,188,184,157,149,121,250,160,203,210,20,23,55,166,109,245,52,47,167,231,103,79,231,103,159,186,22,30,157,225,162,181,102,118,121,126,6,95,234,110,92,228,169,211,90,240,77,157,180,208,109,235,108,1,188,248,3,69,107,91,112,120,90,186,237,249,53,70,103,85,89,44,156,171,46,207,28,85,205,234,194,88,147,169,7,109,135,96,209,181,206,87,167,52,127,150,199,159,7,2,75,23,7,84,34,87,48,138,168,160,28,73,225,6,72,48,206,9,118,89,228,73,50,248,114,249,30,205,111,157,91,184,89,82,53,63,155,42,133,139,246,177,109,243,240,80,42,149,36,2,5,42,144,136,6,190,135,164,199,125,36,252,48,34,132,82,28,16,121,2,207,117,9,248,211,6,8,142,196,19,96,238,113,25,69,200,119,21,71,52,78,32,30,201,25,98,68,49,47,98,202,11,20,62,129,71,86,246,53,144,35,84,210,101,137,76,56,65,126,24,71,136,98,1,84,49,87,72,36,94,172,176,39,221,64,241,93,170,180,47,28,16,54,125,118,126,117,166,51,183,181,1,165,84,77,171,116,250,96,190,155,5,48,12,182,106,190,107,52,56,10,22,153,137,238,10,187,99,126,87,117,125,77,238,186,194,244,168,80,155,120,110,154,69,85,154,227,56,199,0,182,156,255,7,86,210,152,13,78,255,248,113,140,147,242,181,109,127,156,162,175,238,210,109,3,121,163,219,199,30,246,229,224,254,201,125,30,28,144,204,186,67,215,108,189,66,140,211,119,246,97,59,145,218,124,190,49,56,124,147,42,91,102,101,101,185,98,124,167,29,178,221,102,38,33,33,113,140,17,52,27,52,51,35,20,133,60,20,40,242,227,192,165,137,194,9,243,215,138,220,187,193,184,170,138,151,72,196,92,231,133,30,47,101,99,155,206,172,28,158,143,70,118,93,234,147,99,219,216,254,67,116,30,166,74,197,152,161,48,128,41,69,35,9,35,36,244,20,138,112,236,199,2,115,38,137,247,193,232,38,186,104,183,195,123,62,86,228,33,72,35,3,29,53,111,20,120,67,48,202,103,6,148,247,173,26,191,149,16,56,190,106,170,174,222,8,184,87,219,30,194,224,80,44,175,238,63,96,251,140,234,226,16,192,125,255,242,42,219,195,16,107,150,161,177,118,185,84,86,5,218,135,18,105,106,106,219,127,121,235,86,121,105,251,25,180,23,192,117,121,147,151,157,53,253,220,100,187,105,126,111,0,143,76,97,166,141,158,193,20,158,231,25,228,125,91,9,62,101,152,187,122,140,82,159,107,68,179,52,69,97,102,38,40,117,13,35,158,63,206,38,198,61,97,200,39,176,185,65,26,143,7,57,152,75,67,172,124,144,23,108,38,68,101,224,195,194,10,20,10,67,226,147,8,99,193,132,58,101,49,66,226,90,93,215,7,57,176,23,6,145,226,160,99,74,2,88,86,4,131,162,185,64,10,75,233,75,42,149,79,214,203,10,50,6,255,237,223,95,92,242,169,230,124,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5e86ae68-80ed-4867-b9da-72eed6375810"));
		}

		#endregion

	}

	#endregion

}

