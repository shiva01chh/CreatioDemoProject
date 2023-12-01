﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CESWebHooksServiceSchema

	/// <exclude/>
	public class CESWebHooksServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CESWebHooksServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CESWebHooksServiceSchema(CESWebHooksServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a4bc741d-81c4-4bf8-bf55-41e73ef154e9");
			Name = "CESWebHooksService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("06435d27-8c1b-4953-b634-242d1f4c8b8a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,88,95,111,219,54,16,127,246,128,125,7,78,5,6,25,112,149,2,195,134,161,77,58,56,174,219,100,107,154,44,118,183,135,32,15,180,116,182,133,202,162,74,81,113,189,33,223,125,199,127,50,41,209,73,138,46,15,145,73,222,253,238,120,119,60,222,177,164,27,168,43,154,2,153,3,231,180,102,75,145,76,88,185,204,87,13,167,34,103,229,247,223,253,251,253,119,131,166,206,203,21,153,237,106,1,155,87,157,49,210,23,5,164,146,184,78,102,21,164,57,45,242,127,32,235,209,157,95,246,166,222,231,229,231,222,228,7,16,189,185,57,124,233,79,206,32,109,120,46,118,201,184,17,107,40,69,158,42,149,3,116,252,46,79,225,130,101,80,60,184,152,140,113,27,119,143,131,36,127,195,98,79,176,183,28,78,39,103,66,84,201,120,81,11,78,181,77,66,132,19,198,225,208,124,242,230,244,16,246,132,109,54,174,106,82,214,71,145,23,104,3,114,98,21,181,74,152,133,7,221,245,14,74,224,121,26,86,197,200,194,181,103,28,86,72,79,38,5,173,235,151,100,50,157,161,144,51,198,62,213,198,42,138,234,232,232,232,184,110,54,27,202,119,175,205,60,89,50,78,56,164,144,223,73,244,45,44,214,146,139,44,57,219,16,244,25,89,84,40,164,200,75,32,105,193,154,44,57,62,178,8,8,120,99,80,48,32,149,53,111,229,220,184,174,48,64,80,187,10,253,180,80,91,188,134,207,77,206,97,131,33,80,199,238,64,58,11,13,243,8,139,164,74,204,68,54,148,66,170,102,81,228,41,170,132,219,13,236,150,188,36,167,180,134,118,239,3,121,68,246,70,66,195,10,138,184,47,201,21,151,209,164,173,51,168,244,128,164,114,157,228,165,32,51,193,129,110,174,129,102,192,79,155,229,18,248,12,15,14,42,252,203,207,63,255,244,203,171,62,19,6,149,52,163,85,231,138,114,60,190,2,248,7,252,32,91,100,237,27,61,206,59,223,85,208,227,23,56,233,243,162,130,25,58,104,103,217,207,104,153,21,96,65,222,179,213,21,21,8,80,74,238,155,190,165,18,159,254,150,252,251,226,62,210,49,53,120,6,101,166,77,102,198,198,126,87,156,85,192,69,14,135,12,248,177,6,142,70,46,117,16,119,134,51,186,4,162,252,49,88,129,144,191,158,229,75,242,97,58,127,123,61,190,152,254,125,121,253,135,90,27,112,16,13,239,50,147,223,126,35,227,170,218,79,36,250,204,248,84,168,255,51,40,106,240,128,158,200,86,102,249,82,241,221,203,255,247,254,198,22,140,21,196,177,237,10,45,62,45,233,162,128,140,156,188,86,108,177,164,25,118,18,134,151,176,165,236,25,8,129,188,242,124,139,191,104,209,64,220,55,210,136,68,26,187,35,48,26,62,226,159,11,16,107,150,29,114,206,29,203,51,114,94,162,56,97,128,99,19,58,91,61,156,222,225,153,251,189,102,229,136,236,23,100,212,202,136,28,26,215,45,118,2,110,110,49,114,55,21,135,186,134,76,50,96,140,93,80,60,189,229,74,167,54,140,16,153,165,20,69,220,69,31,170,48,30,220,81,142,71,77,106,131,220,37,108,141,106,1,123,12,181,59,147,243,82,176,56,186,166,91,107,151,200,174,160,85,227,232,60,139,70,120,196,139,102,83,38,237,249,137,223,53,121,134,247,214,86,126,227,225,208,227,144,218,188,161,130,134,248,252,13,14,141,210,24,176,177,99,20,242,3,170,222,20,5,249,241,71,153,54,146,57,223,33,66,13,46,205,136,176,70,16,185,91,121,134,135,214,142,3,189,119,173,136,164,11,41,161,57,94,237,195,210,114,77,191,224,5,43,32,214,107,247,1,71,99,204,156,151,75,102,93,140,181,68,77,87,173,23,205,16,45,175,215,147,183,140,111,168,136,15,37,145,81,11,160,149,233,121,219,176,32,71,162,196,122,228,7,244,155,114,206,120,71,193,17,153,126,73,161,82,71,30,218,95,218,202,255,151,242,210,137,14,182,15,254,224,214,180,198,62,218,61,145,25,231,171,185,71,251,237,185,14,126,208,84,1,211,88,181,59,230,76,166,155,74,236,122,50,58,232,242,114,81,73,104,95,120,16,21,191,127,54,160,34,89,135,97,29,235,235,80,154,27,63,86,164,12,105,78,183,87,172,22,242,16,153,83,60,83,242,79,155,188,192,171,211,196,231,32,93,83,142,73,99,161,110,82,67,168,230,194,247,236,173,230,210,117,79,236,210,24,21,204,160,149,216,78,197,70,69,231,148,9,117,83,190,135,114,37,214,200,241,66,99,15,182,235,188,0,18,199,222,162,139,158,200,207,105,193,210,79,177,214,123,68,94,140,14,20,6,40,239,53,121,209,10,85,17,230,0,31,31,98,107,25,124,11,189,167,181,76,138,122,144,204,233,39,112,208,134,201,156,141,241,146,217,89,227,202,155,110,239,134,4,175,59,188,30,226,61,210,158,204,67,151,65,111,87,252,24,126,0,175,197,210,217,200,124,244,255,189,119,91,228,80,128,125,246,99,11,233,157,146,56,217,135,159,14,164,216,85,101,206,204,228,16,211,68,153,178,76,70,250,199,249,219,95,141,90,46,237,164,0,218,198,159,169,4,58,162,15,230,38,167,105,129,88,106,39,75,80,168,101,36,169,175,245,155,223,220,92,67,221,20,130,208,208,228,9,57,181,229,244,68,86,211,211,18,47,116,72,60,65,6,124,20,40,155,156,196,245,67,8,63,153,53,105,138,121,165,13,168,54,29,4,169,47,188,4,54,16,107,206,182,230,10,190,195,14,49,155,96,181,45,153,104,209,102,156,167,0,133,18,88,40,2,176,244,49,6,221,251,226,45,182,29,50,141,199,242,159,67,139,93,138,151,112,202,0,158,78,3,1,73,214,253,1,166,100,156,101,113,176,90,31,41,153,55,193,181,219,39,2,246,74,248,14,104,111,253,214,15,212,0,254,83,243,119,200,184,126,254,30,145,67,33,29,172,199,141,74,193,123,193,100,91,175,236,54,244,15,58,217,8,85,23,247,208,171,190,239,159,92,225,50,129,59,134,204,90,196,12,201,93,206,69,67,11,125,144,175,56,84,148,163,121,120,125,166,114,111,29,31,222,40,58,231,18,219,27,21,223,178,175,133,47,130,176,238,196,9,9,144,37,147,134,115,60,28,175,44,142,22,230,120,5,75,192,21,195,108,133,231,166,194,158,15,140,54,8,215,149,144,92,118,72,19,67,171,193,77,181,148,99,246,219,40,34,101,200,75,158,99,62,9,161,157,251,132,22,236,38,210,44,145,185,106,15,232,167,130,58,26,171,220,242,92,245,250,172,120,62,46,10,182,125,110,248,71,97,85,252,144,144,241,102,13,184,118,126,235,212,111,70,90,10,227,178,51,58,87,125,122,106,235,219,199,118,237,96,38,143,108,212,39,53,22,198,93,106,242,111,216,235,87,7,176,122,200,208,139,71,71,71,228,216,121,93,81,19,82,35,44,92,37,185,121,171,209,7,86,176,78,171,159,180,16,238,11,205,224,198,139,82,251,72,51,144,57,8,211,60,195,154,66,235,34,223,7,206,166,227,55,184,189,143,60,159,195,166,42,100,110,145,179,158,152,72,189,191,216,7,24,117,188,124,2,169,112,108,115,117,232,228,185,41,44,188,101,133,87,183,102,110,95,165,14,108,81,205,84,50,189,168,140,121,18,233,124,20,189,182,201,109,193,178,93,114,124,164,72,190,218,40,87,151,179,249,55,27,37,92,58,219,230,44,154,9,202,49,107,69,38,206,191,249,160,120,5,69,224,88,56,189,119,191,14,11,94,29,246,206,120,24,204,244,248,181,121,12,232,96,31,184,76,61,246,182,165,62,204,221,191,53,247,101,145,105,123,206,235,15,88,124,94,114,213,254,196,174,86,195,126,109,20,41,42,66,249,170,70,63,203,26,98,204,87,141,124,120,148,32,251,210,39,168,189,109,203,205,125,231,245,232,168,79,248,173,200,213,193,233,206,109,3,27,201,202,245,165,122,137,27,17,95,121,23,191,99,31,191,212,21,124,103,133,248,111,61,46,222,200,123,217,177,125,44,6,77,186,38,110,151,217,183,89,167,104,4,87,175,54,170,229,211,79,1,242,54,174,117,93,186,68,123,238,34,47,1,184,9,210,204,185,83,106,6,255,254,3,87,160,146,82,6,25,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a4bc741d-81c4-4bf8-bf55-41e73ef154e9"));
		}

		#endregion

	}

	#endregion

}
