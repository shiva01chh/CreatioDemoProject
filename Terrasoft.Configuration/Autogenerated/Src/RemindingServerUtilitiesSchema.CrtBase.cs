﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RemindingServerUtilitiesSchema

	/// <exclude/>
	public class RemindingServerUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RemindingServerUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RemindingServerUtilitiesSchema(RemindingServerUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ef2215fb-53ef-462c-baa4-4d3784c96c58");
			Name = "RemindingServerUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe3149b2-9704-43d8-935e-39b7af42f452");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,88,75,111,227,54,16,62,123,129,253,15,92,229,34,3,134,140,30,122,105,18,3,113,236,164,1,146,141,17,39,187,103,70,26,219,106,37,202,37,41,39,70,55,255,189,195,135,36,234,97,197,41,122,216,67,29,32,22,201,153,111,222,195,145,25,77,65,108,105,8,228,17,56,167,34,91,201,224,50,99,171,120,157,115,42,227,140,125,254,244,247,231,79,131,92,196,108,77,150,123,33,33,61,109,172,145,62,73,32,84,196,34,184,6,6,60,14,91,52,143,240,42,91,155,51,42,105,181,233,42,192,225,208,126,48,103,50,150,49,136,131,4,11,158,133,32,14,156,167,105,198,14,114,206,166,120,132,135,39,28,214,104,13,185,76,168,16,191,145,7,72,99,22,33,253,18,248,14,248,147,140,19,173,129,166,29,143,199,228,76,228,105,74,249,126,98,215,39,246,83,62,20,79,196,125,116,78,231,175,225,134,178,53,16,35,33,40,112,199,14,240,54,127,78,226,144,8,137,97,9,73,168,84,235,209,108,160,162,86,26,114,7,114,147,69,104,202,66,131,104,197,91,154,235,141,7,144,57,103,130,196,12,5,49,76,139,108,69,120,33,37,40,217,198,77,190,179,45,229,52,37,12,211,233,220,203,5,112,76,34,102,146,194,155,220,56,96,234,140,132,229,97,112,54,214,156,221,64,91,19,202,175,184,240,38,234,191,66,144,27,32,246,160,159,91,228,207,127,160,20,111,114,73,183,74,86,221,150,94,214,8,68,200,227,173,81,127,86,45,62,0,145,97,64,120,28,65,25,35,111,178,140,215,140,200,140,20,71,4,94,99,33,85,34,246,96,114,19,145,154,19,93,242,226,92,49,212,115,68,87,202,158,92,131,44,117,152,238,109,117,248,79,181,24,145,122,200,70,8,193,149,94,78,0,202,61,235,214,145,18,56,24,216,77,199,97,228,156,176,60,73,70,228,57,203,18,210,114,3,30,175,104,34,96,72,116,138,14,172,66,203,112,3,41,45,4,218,213,121,67,175,160,70,124,71,25,93,99,181,92,33,112,225,157,233,94,233,234,59,122,15,79,181,24,227,140,186,148,219,108,125,72,144,75,222,35,199,251,246,130,189,108,81,194,121,86,218,117,30,71,142,148,7,8,51,30,221,68,40,7,163,177,104,237,251,77,247,215,220,96,49,227,21,241,187,32,17,19,165,5,243,116,43,247,133,83,7,38,43,116,32,12,247,155,227,133,42,127,236,250,40,243,81,243,166,245,85,110,15,141,216,224,146,3,149,96,216,27,86,89,51,118,84,215,127,20,23,185,2,47,100,22,107,10,108,40,103,38,159,70,36,211,73,54,41,236,177,95,3,239,34,199,86,198,189,81,83,227,203,156,115,96,82,165,181,186,192,36,13,229,77,100,152,222,70,164,100,183,71,255,154,127,153,229,60,4,100,47,77,71,98,33,69,80,181,98,77,97,212,236,68,48,229,99,123,18,34,217,122,234,160,220,11,55,14,94,35,45,130,167,10,222,132,216,56,216,86,228,134,138,141,201,183,82,181,223,113,203,47,125,239,164,213,23,195,19,220,136,175,152,48,247,92,231,146,239,212,244,176,76,44,171,45,34,91,30,180,63,164,210,47,186,2,241,8,42,234,178,186,249,167,133,181,91,194,143,31,214,230,47,141,204,12,174,64,134,155,43,158,165,179,169,255,94,166,224,159,167,76,68,249,218,248,55,130,222,52,189,198,169,139,58,254,18,228,12,86,56,193,228,41,251,70,147,28,132,95,83,184,131,222,33,246,189,34,206,71,38,148,197,126,15,181,164,255,111,97,77,106,106,212,35,211,247,72,96,195,253,24,167,208,175,48,38,163,93,226,232,7,138,222,31,30,41,194,185,132,59,243,235,93,219,15,148,221,177,236,245,90,212,62,108,222,34,170,32,63,166,77,3,166,232,233,71,130,56,185,94,114,232,174,223,96,212,103,111,61,67,159,105,218,255,15,125,63,197,208,87,159,225,118,25,14,18,38,62,63,243,16,119,104,174,48,240,221,19,232,129,153,199,170,89,92,39,142,78,163,182,30,206,29,214,146,109,44,104,76,68,189,189,157,238,192,118,127,91,45,39,192,34,243,10,101,215,173,247,41,30,239,48,52,230,116,107,22,69,232,244,12,216,61,238,189,19,183,158,145,184,48,71,131,115,133,103,166,202,114,2,172,134,44,116,225,18,18,115,87,171,171,211,44,154,67,153,189,120,213,232,166,123,11,246,166,197,18,187,138,135,189,201,57,84,87,176,238,130,133,110,104,99,46,188,97,112,33,12,135,67,251,125,3,28,106,56,56,88,204,255,202,105,162,54,111,213,166,97,175,139,184,96,81,201,164,59,156,195,103,116,11,22,170,74,64,2,247,127,41,238,13,107,162,120,223,210,224,49,219,34,95,151,193,183,165,162,202,156,34,76,125,246,235,89,223,26,127,219,105,188,177,115,47,190,103,252,79,253,11,75,205,17,45,131,26,183,102,201,21,224,117,208,118,146,6,191,127,97,192,63,132,218,61,60,28,128,215,13,184,7,187,62,140,218,118,139,78,94,234,102,130,23,123,3,119,24,204,85,231,19,126,153,152,14,193,61,143,128,79,247,190,254,158,197,220,40,172,160,66,25,168,94,12,186,82,149,75,141,118,166,39,70,247,204,27,18,42,108,200,77,74,152,223,118,252,217,116,254,10,97,46,51,78,162,231,242,177,227,85,71,228,28,102,211,106,203,175,198,69,11,117,163,126,169,122,0,138,186,97,209,233,175,115,155,114,129,65,6,115,234,87,146,42,16,219,158,212,121,160,200,28,124,213,132,138,26,182,20,215,181,91,254,76,85,246,196,205,201,83,203,249,102,103,255,90,67,179,215,191,134,116,27,89,163,53,217,126,223,122,55,232,153,174,163,242,168,80,94,247,24,201,139,154,211,244,211,60,78,148,27,172,150,171,12,141,10,55,196,55,40,100,167,76,194,49,195,65,11,204,212,93,189,95,72,30,92,108,183,24,110,95,83,55,166,113,109,224,85,156,64,249,91,151,114,216,221,236,87,173,255,156,133,153,190,80,159,88,140,79,160,206,166,123,28,109,124,5,235,166,102,79,151,55,187,245,77,189,231,126,254,1,80,96,209,105,56,21,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ef2215fb-53ef-462c-baa4-4d3784c96c58"));
		}

		#endregion

	}

	#endregion

}

