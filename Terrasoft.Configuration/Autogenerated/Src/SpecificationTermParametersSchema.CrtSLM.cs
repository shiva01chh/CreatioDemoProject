﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SpecificationTermParametersSchema

	/// <exclude/>
	public class SpecificationTermParametersSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SpecificationTermParametersSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SpecificationTermParametersSchema(SpecificationTermParametersSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f5b9acc4-9e43-4a3f-9ba3-749d835e7e43");
			Name = "SpecificationTermParameters";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,90,91,111,219,54,20,126,118,128,252,7,214,125,145,49,67,233,115,147,184,104,188,44,48,138,22,94,237,118,15,69,17,40,50,147,112,179,37,151,164,220,121,67,255,251,14,111,18,69,81,148,28,196,197,250,80,68,228,225,185,126,60,23,201,5,35,217,3,90,236,25,199,155,243,211,147,194,122,140,167,249,122,141,83,78,242,140,197,55,56,195,148,164,37,201,18,83,154,176,252,158,3,21,197,45,203,241,117,198,9,39,152,193,254,233,73,150,108,48,219,38,41,174,81,101,247,228,161,160,137,144,18,47,48,221,145,20,195,246,230,244,228,223,211,147,193,217,217,25,186,96,197,102,147,208,253,68,63,127,196,91,138,25,206,56,67,9,98,91,156,146,123,146,202,243,136,195,65,180,77,40,8,130,63,89,108,56,156,89,44,182,197,221,154,164,40,93,39,140,161,133,125,92,136,157,151,135,209,107,52,11,108,3,39,161,224,224,37,197,15,66,52,24,194,120,2,74,9,75,7,131,45,37,187,132,99,4,107,28,164,81,156,172,242,108,189,135,103,42,220,116,149,48,60,77,214,56,91,37,20,156,189,192,156,195,242,7,224,141,46,209,208,222,29,158,247,96,167,253,54,131,160,45,147,187,53,54,140,172,245,67,248,204,147,148,251,248,136,245,131,244,201,58,24,214,8,122,113,54,110,1,104,22,155,204,176,59,200,89,31,113,34,49,189,36,27,252,41,35,124,154,175,112,157,157,75,17,11,146,131,121,127,78,214,69,128,177,220,238,231,77,224,17,86,216,165,232,175,176,125,210,163,112,99,123,120,174,240,253,18,252,173,144,175,159,245,53,152,83,188,197,84,92,249,250,61,40,229,126,98,24,130,151,101,42,175,160,219,162,246,92,83,249,166,32,43,116,203,42,132,204,86,237,251,206,158,54,239,54,109,224,197,75,70,131,152,232,60,226,120,206,75,207,130,81,236,60,210,20,17,10,131,204,70,180,72,121,78,117,32,220,76,42,23,166,96,4,200,203,240,247,238,68,218,204,164,106,69,82,33,145,219,47,135,105,158,173,136,172,23,195,201,178,198,2,49,44,74,9,42,41,226,139,51,185,233,103,84,71,197,112,34,80,35,206,234,133,218,97,157,208,3,185,58,154,253,74,228,57,80,252,66,57,119,140,242,187,63,129,217,164,210,136,141,93,112,214,181,24,33,153,240,7,14,100,225,154,120,48,60,152,65,136,73,178,38,255,64,208,140,128,168,146,53,146,84,63,194,81,124,143,249,99,190,98,238,13,147,32,9,68,181,18,205,140,219,235,241,180,108,62,118,100,13,164,119,57,220,85,175,79,250,197,198,56,159,220,35,203,139,232,242,18,101,197,122,109,118,7,252,145,230,223,37,158,223,210,135,98,3,77,194,7,216,190,254,59,197,91,113,32,178,237,80,33,16,49,104,240,21,109,9,79,72,198,222,225,125,228,43,174,163,82,98,149,127,0,8,0,57,86,217,22,217,208,242,114,113,53,176,153,93,202,252,22,95,111,182,124,31,176,175,178,237,64,123,106,53,185,105,143,202,183,189,108,170,115,178,180,248,17,0,233,219,213,138,65,124,69,62,99,136,231,10,161,26,74,223,10,76,247,125,145,41,137,135,147,223,229,153,86,232,129,56,1,219,133,20,32,105,85,46,101,145,108,81,247,139,244,17,111,18,185,161,196,151,183,189,89,65,192,41,74,67,96,170,86,163,102,91,50,138,203,180,62,232,40,47,30,126,225,30,165,149,119,179,130,135,24,59,212,53,174,225,106,229,97,28,110,82,90,121,119,107,28,232,80,44,174,157,80,187,39,107,217,213,31,5,106,13,74,125,137,196,181,163,242,34,13,39,250,178,136,156,38,215,16,89,193,245,133,138,133,105,47,94,54,143,150,163,29,136,255,77,185,160,13,241,99,213,80,53,84,175,175,207,86,118,42,110,16,163,23,222,188,165,220,172,21,16,193,141,212,186,222,80,125,136,218,254,131,240,71,171,116,171,197,105,190,1,51,9,3,24,236,183,48,86,126,43,146,181,63,255,140,155,6,140,116,78,58,146,22,246,116,20,47,160,205,46,88,60,99,111,225,154,237,240,112,140,160,13,195,165,6,150,207,90,125,213,174,230,179,120,171,86,129,198,86,88,141,142,199,146,111,79,163,198,79,126,47,169,18,54,160,152,23,52,115,171,90,151,251,142,20,100,184,126,62,103,29,11,82,1,247,116,150,86,89,177,33,211,65,194,68,133,152,6,123,247,120,48,52,78,150,230,24,18,207,205,212,164,162,194,42,58,32,49,107,118,18,50,37,145,197,166,36,40,197,204,83,164,167,28,33,197,4,207,115,134,235,63,206,75,0,188,184,206,138,77,188,164,123,201,46,18,231,161,99,44,42,210,145,167,93,154,101,59,104,60,87,211,132,181,117,76,202,134,186,188,30,94,238,104,134,127,254,232,244,23,134,18,85,246,107,8,30,91,67,88,81,237,68,97,109,9,164,204,254,78,23,216,119,160,210,49,6,37,76,76,118,9,85,210,160,212,87,148,95,128,226,107,21,98,77,240,92,205,189,14,173,76,22,10,52,202,222,101,190,144,250,69,163,94,227,216,156,230,28,44,196,171,0,42,110,48,103,79,111,48,152,172,201,34,49,67,173,151,127,203,141,94,253,193,220,233,51,182,207,214,99,140,91,1,100,58,161,58,108,180,151,208,142,80,14,233,12,53,251,13,240,146,211,155,152,108,80,121,160,222,118,204,131,173,136,0,149,116,52,128,74,224,163,33,49,114,134,246,216,166,120,159,100,201,3,152,105,9,215,240,105,159,26,212,140,208,70,101,58,45,221,87,57,54,84,234,159,219,240,148,196,157,105,71,85,20,246,212,55,52,88,218,61,156,40,251,3,217,221,97,223,21,99,231,221,185,210,210,121,11,163,100,34,165,130,29,186,74,142,142,159,115,112,84,101,6,117,184,145,26,180,11,43,70,246,245,23,34,204,20,39,71,90,197,36,22,40,132,162,171,7,13,57,91,92,8,124,77,34,223,208,247,139,236,1,180,42,130,37,197,108,11,169,166,44,104,102,86,46,11,92,64,140,66,59,8,10,79,134,163,128,184,207,58,137,6,164,144,140,59,34,220,1,170,98,239,14,124,79,178,38,60,53,142,90,196,245,182,36,48,56,106,214,22,98,167,118,196,171,240,55,232,62,106,191,74,188,25,0,190,195,123,41,96,158,16,122,209,236,74,198,72,42,228,134,100,236,15,82,83,55,51,211,62,65,166,235,226,113,211,149,245,180,226,220,137,80,110,169,138,151,117,35,239,204,141,213,233,81,85,164,131,210,141,42,104,215,77,46,135,212,181,99,165,42,93,139,84,40,174,246,74,75,83,142,42,253,125,229,200,87,126,60,165,205,102,226,148,130,91,183,22,200,92,85,126,118,45,95,135,0,87,165,88,245,73,214,45,105,245,168,87,60,226,105,94,100,92,100,204,87,232,141,55,187,162,215,254,124,93,241,248,242,234,235,168,31,122,204,69,179,218,7,129,32,102,53,37,33,236,148,157,105,147,77,103,92,101,124,64,9,115,246,106,111,13,230,209,51,183,10,129,87,159,61,222,13,86,177,54,245,204,141,179,171,197,216,249,16,86,143,118,189,42,66,152,171,185,24,130,219,89,238,60,31,85,237,106,247,212,160,223,37,12,87,123,76,254,166,0,144,32,63,117,255,68,16,72,185,250,11,123,9,3,237,56,249,35,5,231,55,8,229,231,120,241,163,7,149,193,155,209,104,255,128,63,182,95,74,244,241,159,47,227,154,251,66,196,187,146,30,174,122,198,28,40,87,202,187,35,94,214,68,173,189,154,63,119,250,95,52,185,94,145,237,92,75,189,246,190,216,105,171,237,161,104,123,166,192,195,234,97,40,56,125,147,217,209,130,211,72,108,7,4,199,251,211,140,150,44,211,30,41,255,43,184,96,55,222,47,140,182,129,255,67,184,180,190,34,144,223,162,15,131,212,51,64,72,125,1,239,139,159,18,50,14,161,27,47,251,139,164,249,28,216,225,106,7,118,190,92,114,222,130,145,120,198,68,54,78,185,2,44,40,249,198,198,243,107,89,218,252,64,10,74,13,96,200,149,216,15,192,135,2,81,51,115,213,23,247,149,251,85,238,237,69,249,58,212,53,72,88,84,31,106,44,203,66,131,79,139,54,14,161,235,10,175,252,250,128,227,151,223,24,130,218,228,215,9,131,119,180,63,136,218,46,178,245,172,104,228,127,226,223,127,83,18,37,218,42,41,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f5b9acc4-9e43-4a3f-9ba3-749d835e7e43"));
		}

		#endregion

	}

	#endregion

}

