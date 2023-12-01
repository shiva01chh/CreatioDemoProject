﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SecurityTokenUtilitiesSchema

	/// <exclude/>
	public class SecurityTokenUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SecurityTokenUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SecurityTokenUtilitiesSchema(SecurityTokenUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7ff4823a-8dfb-4ed7-9789-13b943f03711");
			Name = "SecurityTokenUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,87,109,79,27,57,16,254,156,74,253,15,163,244,62,108,116,104,161,234,55,32,160,43,208,10,93,65,109,9,119,31,78,167,147,179,59,9,171,110,214,169,237,37,68,81,254,251,141,61,54,251,146,77,8,69,10,201,218,243,254,60,51,94,23,98,134,122,46,18,132,17,42,37,180,156,152,248,66,22,147,108,90,42,97,50,89,188,125,179,122,251,166,87,234,172,152,194,221,82,27,156,157,180,158,227,75,97,68,181,56,205,229,88,228,199,199,23,114,54,147,69,252,69,78,167,180,92,237,215,253,40,220,182,30,95,126,236,222,178,70,105,135,246,222,41,156,82,128,112,145,11,173,143,225,14,147,82,101,102,57,146,63,176,184,55,89,158,153,12,181,147,156,151,227,60,75,32,177,130,91,229,122,43,39,91,153,149,133,54,162,48,100,250,171,146,6,19,131,169,221,183,159,195,195,67,56,213,229,108,38,212,242,44,44,220,136,39,80,114,161,193,60,8,3,137,40,96,140,144,98,142,164,8,227,37,216,84,114,132,159,37,170,101,252,108,229,176,110,102,30,28,65,98,189,67,86,24,107,246,210,25,249,46,23,23,178,164,149,33,188,63,58,226,26,116,71,114,137,19,81,230,6,82,177,212,100,201,234,208,39,203,193,216,156,1,159,230,153,66,253,138,24,188,65,87,178,43,167,125,73,166,67,52,31,66,48,239,176,72,185,122,29,165,84,101,98,164,178,213,116,104,176,132,71,166,27,147,232,94,163,34,221,130,194,177,102,202,198,227,0,44,49,123,189,150,208,176,37,102,89,212,91,239,142,143,240,157,163,178,46,27,88,55,171,209,242,211,122,92,129,11,102,138,198,57,236,105,255,99,29,204,100,143,194,32,92,83,59,192,127,185,116,253,80,51,238,214,237,103,21,204,248,95,61,133,166,84,133,211,129,243,115,136,220,143,161,149,189,17,133,152,162,138,63,163,177,77,134,42,234,55,234,216,31,12,56,150,245,30,37,184,65,243,32,83,151,191,139,116,7,187,200,31,147,24,38,82,49,193,109,147,50,171,82,230,216,54,114,185,21,78,73,159,49,173,189,173,204,117,91,130,241,233,97,216,175,23,206,203,146,111,254,197,44,76,93,162,250,155,181,16,5,66,52,204,14,161,192,133,215,110,241,105,192,5,142,63,41,57,219,40,157,223,251,251,1,21,70,253,192,121,131,207,59,215,250,11,106,29,93,200,188,156,21,241,87,161,104,144,26,194,192,10,141,178,25,198,247,38,185,149,139,193,0,132,246,254,25,13,238,255,90,51,111,52,56,203,121,224,157,120,160,18,79,159,61,48,108,112,120,11,138,5,42,91,89,91,31,158,11,63,112,219,92,106,192,118,103,148,197,187,210,105,35,22,72,253,152,41,83,138,28,52,43,4,143,174,194,127,98,5,152,207,244,115,153,165,241,45,46,236,119,52,136,71,146,29,69,253,219,254,160,222,75,123,144,146,99,35,74,217,174,166,67,104,71,86,115,139,28,20,132,222,176,79,201,244,207,70,181,188,220,102,183,108,74,135,94,16,30,103,5,217,4,187,180,91,9,43,30,121,85,183,226,14,90,171,142,155,234,161,180,215,46,153,151,154,165,93,122,175,69,213,113,238,248,145,219,197,163,66,137,30,208,233,100,240,159,127,93,2,7,16,24,12,85,180,1,169,71,161,124,85,125,99,177,193,45,141,117,93,24,185,173,177,238,208,68,125,94,58,128,141,38,162,160,6,13,73,251,138,209,37,104,35,110,74,214,90,181,67,190,150,210,160,209,102,156,213,47,209,76,83,243,38,191,78,51,178,226,77,108,7,255,206,237,191,22,124,175,21,192,231,199,54,248,117,104,57,12,15,45,139,111,129,118,36,231,209,251,240,192,85,246,32,189,98,170,250,69,26,165,87,63,41,222,205,89,234,104,96,231,39,199,210,0,76,87,75,123,31,109,155,47,30,173,17,117,161,48,12,168,168,214,19,207,39,203,102,103,80,177,90,19,63,254,35,77,237,219,81,180,227,165,169,201,189,186,215,202,242,1,187,222,131,146,126,144,139,34,5,45,30,235,19,125,145,153,135,250,116,114,50,237,145,179,39,107,127,97,118,237,49,47,183,83,254,133,83,230,69,252,58,192,106,12,186,0,106,213,10,132,229,230,25,117,178,57,248,186,166,169,27,163,60,63,107,51,134,149,233,237,140,102,225,68,70,108,33,190,122,162,174,160,215,145,1,12,135,112,196,61,113,14,191,61,55,139,79,154,174,12,54,168,21,253,91,195,130,186,160,144,6,68,154,98,26,247,89,233,120,15,37,167,192,68,224,192,28,86,176,170,162,92,199,253,38,31,73,119,175,65,104,201,150,6,191,181,35,112,79,66,57,197,87,158,183,159,208,36,15,207,78,187,15,220,64,147,145,42,17,178,73,104,5,170,197,132,122,47,5,105,104,252,44,50,141,48,17,185,222,24,163,77,98,141,165,204,97,164,150,1,115,59,227,194,244,116,134,15,64,150,166,139,87,141,129,218,53,131,157,186,175,60,223,115,35,171,147,142,153,31,116,190,12,91,183,140,248,170,208,37,129,246,177,90,138,6,193,95,176,113,109,67,252,142,34,69,178,101,109,248,195,197,179,142,119,162,202,75,101,160,71,197,138,82,21,91,145,154,221,94,207,141,142,33,89,179,119,13,158,210,127,137,188,196,83,78,251,44,140,254,147,160,224,137,68,119,62,12,107,107,254,94,87,55,146,96,182,40,243,188,193,63,7,203,139,12,244,175,249,205,107,135,229,255,92,186,151,190,87,92,65,82,190,183,187,155,114,55,29,248,18,188,113,241,136,234,96,243,85,255,155,191,118,236,188,169,112,186,214,168,145,70,228,62,10,122,255,127,190,83,31,85,34,34,177,76,108,203,240,126,42,3,74,221,82,22,181,42,172,106,242,120,84,186,189,255,62,220,233,147,230,202,67,150,35,68,91,92,158,193,81,115,158,116,122,169,225,219,58,184,55,23,105,133,254,254,7,250,210,175,198,171,18,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7ff4823a-8dfb-4ed7-9789-13b943f03711"));
		}

		#endregion

	}

	#endregion

}

