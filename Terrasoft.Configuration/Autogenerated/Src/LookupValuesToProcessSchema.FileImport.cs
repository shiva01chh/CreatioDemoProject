﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LookupValuesToProcessSchema

	/// <exclude/>
	public class LookupValuesToProcessSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LookupValuesToProcessSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LookupValuesToProcessSchema(LookupValuesToProcessSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c11f5401-c0a0-47d1-92f1-7788a37f4b29");
			Name = "LookupValuesToProcess";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,25,219,110,219,54,244,217,5,250,15,172,59,180,50,96,40,219,107,99,59,104,157,164,200,150,102,65,220,238,37,8,2,70,162,19,162,186,184,36,229,204,11,252,239,59,188,72,34,41,217,82,178,98,121,72,34,242,240,220,175,100,134,83,194,87,56,34,232,43,97,12,243,124,41,194,121,158,45,233,125,193,176,160,121,22,158,210,132,156,165,171,156,137,215,175,158,94,191,26,20,156,102,247,104,177,225,130,164,135,222,55,28,77,18,18,201,115,60,252,76,50,194,104,212,128,57,167,217,143,198,226,85,145,9,154,146,112,1,71,112,66,255,81,180,107,168,121,158,166,238,55,35,245,215,5,121,20,64,81,242,254,59,87,96,176,245,150,145,123,192,129,208,60,193,156,127,64,231,121,254,189,88,205,73,146,168,237,131,131,3,52,225,69,154,98,182,153,153,239,143,25,162,25,23,56,3,117,228,75,36,30,40,71,145,60,141,162,60,19,24,246,96,127,153,179,84,113,135,240,93,94,8,20,1,198,176,68,120,96,97,92,21,119,9,141,12,2,155,250,64,170,177,226,15,180,45,73,10,96,241,146,209,53,22,68,241,55,184,150,162,92,178,124,69,152,216,220,200,149,149,222,70,92,48,41,245,109,148,39,69,154,157,101,49,249,251,176,235,12,35,56,206,179,100,131,10,154,9,116,203,242,71,251,220,91,146,197,154,29,243,109,243,198,138,72,228,76,178,167,4,210,16,190,250,212,194,28,168,8,194,93,37,110,86,4,32,9,65,17,35,203,233,176,86,196,16,29,204,194,10,151,173,185,82,117,53,108,160,61,240,4,156,68,108,16,181,62,198,72,111,205,149,50,204,150,254,24,33,165,232,65,37,45,154,58,71,209,116,138,178,34,73,208,17,138,201,18,23,137,8,164,118,70,232,131,3,22,94,213,202,146,216,44,181,87,8,53,193,163,176,134,219,238,215,236,23,34,30,242,184,143,82,63,19,193,149,147,1,175,233,29,97,59,84,166,86,24,17,5,203,248,108,110,129,79,14,202,85,75,179,198,133,0,183,4,189,80,144,193,8,77,103,102,71,230,128,8,139,192,22,118,92,187,205,168,197,111,140,196,158,192,237,81,248,23,78,10,194,191,230,224,170,17,225,92,65,182,132,75,3,204,141,28,116,74,73,18,251,113,211,170,196,179,70,216,98,208,144,212,42,71,143,15,52,122,40,35,28,37,138,50,90,75,210,187,188,211,196,148,113,79,165,33,205,234,228,152,170,228,7,144,19,173,200,49,58,167,92,76,106,79,158,205,102,232,54,169,197,147,107,220,168,115,15,98,133,69,163,148,8,214,174,102,94,28,198,78,160,121,234,14,190,113,194,224,104,166,19,58,42,156,79,229,44,30,196,212,131,233,96,203,36,42,74,122,153,80,115,135,68,142,86,154,191,231,91,199,85,162,39,46,200,163,226,123,224,43,23,29,29,161,160,177,8,169,131,60,118,18,9,32,194,254,32,155,209,168,219,194,253,92,231,220,243,28,105,133,134,59,1,199,90,148,160,185,181,147,239,94,244,125,121,250,153,54,23,224,15,36,46,85,96,62,125,239,241,62,159,208,61,17,135,168,119,30,237,116,32,149,72,77,120,19,187,144,32,157,228,80,6,189,208,190,236,186,194,12,167,10,106,58,140,9,23,52,83,9,101,56,59,115,208,88,91,144,124,213,161,102,134,62,239,224,195,203,218,110,229,7,73,142,107,34,118,253,187,128,163,129,189,96,193,217,140,149,165,113,141,153,225,97,17,61,144,20,127,59,139,193,67,0,255,21,89,18,70,160,134,87,235,129,125,252,176,245,52,28,117,141,24,158,88,187,95,112,134,239,161,32,1,246,51,211,32,124,218,72,196,30,3,22,114,234,137,6,4,108,237,158,210,44,110,72,111,29,231,36,81,158,230,32,48,5,238,140,95,64,233,255,147,157,164,43,177,9,124,66,35,29,63,131,35,71,62,201,58,248,153,244,138,99,202,87,9,222,216,116,205,145,15,13,174,53,67,218,158,45,60,217,237,66,211,208,16,109,193,231,130,198,190,153,198,37,76,84,51,45,147,193,47,195,39,15,114,123,251,84,195,108,135,135,157,189,70,195,141,161,123,52,222,128,184,54,116,145,209,31,5,65,52,150,180,150,116,127,87,178,51,110,230,207,8,152,171,110,22,218,99,70,41,175,221,163,159,25,40,220,10,17,223,13,91,176,27,71,164,75,20,188,169,142,130,223,105,143,27,149,152,43,199,40,65,244,177,109,69,150,185,168,119,196,193,85,19,202,9,5,19,160,198,73,123,134,41,76,102,159,54,10,85,11,19,6,187,173,21,253,127,88,9,209,42,218,182,199,4,225,166,105,227,145,141,41,66,87,46,155,121,109,75,57,89,32,61,26,222,211,53,201,208,119,178,233,235,160,0,58,156,65,208,245,77,221,154,183,29,190,183,159,77,180,88,37,84,5,184,9,101,160,109,251,27,5,245,203,130,45,185,87,160,193,251,219,247,35,71,179,117,45,223,69,68,37,143,240,18,51,78,2,133,240,250,215,155,209,88,227,190,254,237,102,244,115,135,149,143,113,236,116,208,48,10,74,13,153,59,129,190,54,176,167,175,225,204,158,202,245,14,41,179,97,211,72,54,26,109,26,175,60,247,57,162,116,233,151,117,61,17,236,61,253,130,166,192,52,224,235,28,146,20,40,175,247,156,171,209,186,139,138,109,100,137,48,214,209,254,191,245,3,118,235,235,21,58,237,158,22,152,213,86,234,57,76,239,245,233,66,181,41,230,245,161,157,181,190,163,81,106,74,160,146,181,55,24,200,89,88,93,254,200,72,109,86,225,6,221,58,179,183,169,160,108,192,45,85,149,121,122,224,19,150,14,209,131,160,191,166,209,148,72,215,126,239,223,71,197,21,75,254,188,209,159,167,154,174,193,181,69,36,225,164,67,55,190,10,192,130,106,169,151,226,219,36,110,8,240,2,140,219,29,94,166,3,110,106,135,92,168,127,127,133,46,209,105,0,106,158,28,119,106,193,87,187,79,100,15,108,158,133,130,166,176,202,52,45,8,199,58,190,90,173,80,146,168,177,92,183,96,184,177,213,16,85,180,172,65,82,94,209,185,217,74,235,100,100,233,160,205,226,149,50,246,107,66,87,59,155,139,86,100,59,20,48,234,108,59,94,84,182,158,147,186,79,178,34,37,12,223,37,100,98,103,161,153,161,170,191,120,41,239,50,135,54,40,122,64,129,116,57,83,64,170,171,41,15,118,80,195,148,238,232,92,94,202,222,208,210,69,96,236,98,188,71,218,197,57,172,111,68,43,228,3,121,45,70,179,194,204,48,70,249,46,131,246,160,64,203,202,20,90,121,183,230,117,32,245,212,230,39,99,167,108,161,102,98,54,148,183,93,150,132,232,54,215,122,81,158,179,88,34,81,23,210,136,231,5,131,6,98,73,147,189,51,126,217,197,181,222,154,218,102,44,203,156,185,66,229,234,94,148,240,190,179,90,181,164,239,149,236,250,27,61,63,115,69,126,198,82,118,85,120,222,152,59,238,119,239,52,98,72,77,155,10,145,38,62,70,242,66,84,146,78,170,104,230,141,249,196,218,11,23,42,200,20,5,57,115,170,39,16,239,46,217,73,157,101,183,10,140,116,143,0,121,182,38,12,230,80,104,123,193,112,34,111,31,6,112,22,203,11,34,174,46,114,237,216,229,8,188,211,94,117,27,245,30,182,63,239,141,173,211,75,32,199,43,77,95,98,202,38,251,27,245,177,211,19,204,148,103,201,1,140,7,109,51,65,85,19,254,3,133,178,134,56,209,252,221,194,39,227,198,43,200,149,87,40,70,170,50,240,114,46,130,106,8,178,41,135,242,146,209,180,175,131,129,179,99,74,67,139,123,41,150,156,219,20,43,67,95,65,74,1,57,23,2,18,66,208,122,223,253,133,164,68,186,91,170,255,150,146,214,79,154,223,4,5,86,41,20,154,211,156,157,128,198,2,3,26,250,161,170,231,43,25,26,254,206,181,220,144,210,221,200,68,45,255,183,74,84,47,90,30,215,53,41,111,99,47,165,109,247,245,127,169,142,5,94,27,173,169,251,37,127,226,108,192,63,181,55,142,45,9,109,220,218,245,54,155,64,197,240,207,125,113,50,204,170,3,215,199,88,96,217,135,48,28,9,249,104,122,93,61,66,67,8,203,133,238,167,169,10,159,251,66,229,92,131,91,179,179,34,9,103,100,166,52,163,202,208,191,169,31,142,110,44,19,181,52,237,47,124,48,208,247,234,92,221,173,35,101,129,157,99,65,191,39,129,242,45,160,77,40,239,213,164,83,166,253,47,52,230,73,192,240,190,127,154,169,242,75,207,183,74,181,34,127,254,5,115,229,39,150,18,33,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c11f5401-c0a0-47d1-92f1-7788a37f4b29"));
		}

		#endregion

	}

	#endregion

}

