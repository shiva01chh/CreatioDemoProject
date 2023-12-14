﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadRightsServiceSchema

	/// <exclude/>
	public class LeadRightsServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadRightsServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadRightsServiceSchema(LeadRightsServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5b084013-5ff3-4e80-8c44-e8bdc131e3d5");
			Name = "LeadRightsService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("de8ae9a8-a9a7-4323-ba50-b61a787183b3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,87,75,111,219,56,16,62,187,64,255,3,225,94,108,192,144,239,109,226,34,207,54,139,166,49,236,4,61,4,69,150,145,198,54,81,73,212,146,84,82,109,144,255,190,195,135,36,90,15,39,69,54,151,221,22,72,101,13,103,134,51,195,249,190,161,82,154,128,204,104,8,228,18,132,160,146,175,84,112,196,211,21,91,231,130,42,198,211,183,111,30,222,190,25,228,146,165,107,178,44,164,130,4,215,227,24,66,189,40,131,79,144,130,96,225,135,93,58,203,12,66,70,99,246,55,68,45,189,179,139,150,232,43,168,150,236,18,126,182,133,223,224,182,41,107,233,44,242,84,177,4,130,37,70,169,67,48,57,181,180,112,245,142,133,112,206,35,136,119,46,118,237,185,173,112,128,73,223,53,119,177,10,75,69,195,31,141,84,252,170,11,232,147,7,199,135,189,75,39,152,160,98,32,123,21,78,105,168,184,232,213,72,18,63,212,134,237,86,43,116,105,125,205,217,118,254,199,84,81,180,82,2,119,237,118,235,121,12,230,139,243,90,233,68,8,46,206,210,21,39,251,205,56,252,45,74,239,65,165,143,46,208,201,59,1,107,244,73,142,98,42,229,123,242,5,104,180,96,235,141,146,206,216,40,77,167,83,178,39,243,36,161,162,152,185,119,183,78,86,92,144,181,160,88,79,12,134,166,17,9,99,160,169,126,193,103,244,167,36,130,173,213,70,26,189,140,10,133,157,47,131,210,231,212,115,122,237,60,150,145,126,215,178,3,153,97,103,99,189,51,76,253,150,197,76,21,11,248,43,103,2,18,72,149,28,249,47,58,79,44,194,19,38,90,43,112,130,104,172,55,201,242,219,152,133,24,55,86,160,171,0,3,141,229,170,80,167,12,226,8,43,53,23,186,99,109,125,6,153,125,33,2,173,121,26,23,228,83,206,34,114,19,193,138,230,177,50,254,150,60,23,33,216,162,15,222,65,26,89,127,238,189,60,5,68,190,18,185,110,61,189,133,9,204,106,52,143,192,8,142,173,127,18,214,102,65,165,236,215,182,204,177,149,221,104,76,76,118,131,142,88,177,150,216,105,135,84,130,9,11,143,24,89,169,144,6,58,197,50,220,64,66,23,16,122,6,218,251,220,30,241,197,61,254,167,155,116,240,184,35,126,47,93,114,207,212,134,228,18,132,206,38,181,44,216,147,140,145,96,47,209,132,164,200,196,251,67,109,118,84,89,13,103,123,18,128,132,2,86,251,195,171,237,165,233,140,48,147,75,8,123,83,227,98,119,121,182,205,201,246,70,99,242,158,168,13,147,117,17,183,215,177,128,219,2,191,32,125,45,48,23,60,3,161,185,169,209,99,157,21,124,86,166,125,61,225,154,182,145,227,77,71,204,61,170,141,87,91,132,53,40,247,107,32,64,229,162,229,145,124,252,72,70,237,82,125,86,42,211,216,71,166,15,142,114,33,16,172,200,96,82,226,234,117,51,185,239,132,202,198,238,99,19,168,174,238,238,158,243,42,102,143,250,156,166,116,13,226,51,196,88,247,95,40,91,135,53,185,217,152,231,135,167,244,220,163,183,96,214,141,45,148,251,189,111,41,218,206,165,2,175,16,106,175,195,243,108,100,29,13,82,184,247,225,117,32,214,185,166,191,81,19,43,147,102,25,39,164,215,84,26,204,127,69,200,161,217,80,131,101,56,30,119,212,189,175,181,207,65,109,120,47,119,218,108,230,26,147,146,96,122,53,24,173,236,148,139,79,122,206,92,114,199,49,35,67,178,122,202,156,69,19,203,184,110,192,156,69,37,34,239,168,208,3,168,118,188,111,210,243,253,142,74,15,29,20,232,146,67,26,188,82,102,146,144,220,61,173,159,122,97,212,217,141,254,214,154,59,15,162,132,165,87,41,83,103,145,38,7,107,170,207,210,165,36,55,44,91,240,24,14,139,131,48,228,120,11,27,213,25,117,120,188,192,19,55,87,2,105,19,114,81,29,51,19,3,54,236,94,131,172,185,176,37,253,2,119,16,79,200,23,38,85,159,74,229,123,54,35,15,101,127,14,118,249,11,14,226,152,223,79,156,166,233,192,231,109,80,121,239,245,95,233,226,228,166,120,84,79,170,157,68,76,149,78,31,221,15,247,124,116,133,180,80,243,235,249,28,122,174,123,248,169,225,92,94,144,18,99,129,131,130,42,146,9,126,199,34,144,245,141,73,55,159,185,54,76,1,67,118,225,180,46,75,207,25,130,182,141,135,179,203,13,16,132,2,95,25,223,254,148,107,153,84,205,229,91,57,97,203,208,22,76,206,78,126,134,144,25,206,198,143,32,137,212,67,216,138,96,232,60,12,115,33,247,166,165,158,54,188,174,78,196,191,213,13,174,241,131,224,44,189,227,63,96,100,235,137,141,59,156,95,44,47,145,87,14,121,84,44,85,17,235,235,7,170,157,219,61,42,105,240,77,208,44,131,200,182,153,190,199,129,84,72,13,9,86,215,55,176,162,224,15,201,211,9,89,224,215,26,130,4,118,235,153,203,96,121,21,208,215,158,210,140,24,222,49,124,132,127,186,181,44,220,208,246,23,168,72,137,162,108,244,14,86,122,22,225,149,27,52,73,97,128,39,48,218,201,53,251,38,168,224,36,201,84,49,174,240,230,48,160,145,186,149,239,3,89,230,97,136,5,194,192,86,52,70,137,3,77,137,33,59,108,2,19,94,85,11,11,196,173,56,202,225,64,66,170,194,13,25,213,189,3,227,198,204,107,7,225,130,108,132,50,33,37,21,121,31,62,218,184,126,175,232,196,157,49,42,64,224,126,119,114,193,163,207,8,125,129,212,113,224,96,180,126,30,159,188,225,238,36,1,252,34,193,95,21,9,188,58,244,255,199,8,94,232,82,67,57,101,107,164,249,192,237,0,170,235,115,107,237,13,26,121,88,216,11,66,5,201,151,125,41,253,198,73,7,78,4,100,49,13,91,248,16,60,33,60,174,8,150,40,110,66,113,175,175,56,45,113,151,121,215,192,244,118,255,13,57,31,114,250,248,158,192,156,27,150,126,105,95,4,195,254,59,252,139,135,238,86,140,175,52,119,75,64,54,176,92,130,241,191,61,132,241,239,223,224,23,255,230,238,100,190,200,72,244,191,127,0,57,246,65,149,197,23,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5b084013-5ff3-4e80-8c44-e8bdc131e3d5"));
		}

		#endregion

	}

	#endregion

}

