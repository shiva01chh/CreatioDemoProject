﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChildImportEntitiesGetterSchema

	/// <exclude/>
	public class ChildImportEntitiesGetterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChildImportEntitiesGetterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChildImportEntitiesGetterSchema(ChildImportEntitiesGetterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6eb9e4aa-52ba-4b23-94c6-bb6fb8b15ae0");
			Name = "ChildImportEntitiesGetter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,89,91,111,219,54,20,126,118,129,254,7,214,123,145,1,67,126,79,98,23,169,219,20,65,219,33,75,122,121,24,134,129,145,105,155,155,44,57,36,149,213,40,242,223,119,120,147,72,138,244,165,237,214,135,212,162,14,207,229,59,23,158,67,85,120,67,248,22,23,4,125,36,140,97,94,47,69,62,175,171,37,93,53,12,11,90,87,249,21,45,201,245,102,91,51,241,252,217,183,231,207,6,13,167,213,10,221,237,184,32,155,243,224,25,182,150,37,41,228,62,158,191,37,21,97,180,232,209,188,167,213,67,183,232,138,101,36,181,158,191,169,4,21,148,240,36,193,21,46,68,205,52,5,208,252,194,200,10,180,64,243,18,115,126,134,230,107,90,46,180,21,150,211,91,34,4,97,138,120,50,153,160,11,222,108,54,152,237,102,230,249,178,66,180,226,2,87,0,77,189,68,98,77,57,42,36,51,4,63,24,96,6,38,210,251,146,160,101,205,208,10,120,73,157,10,41,6,81,37,7,17,35,40,183,18,38,142,136,223,95,147,37,110,74,241,138,86,11,216,153,137,221,150,212,203,236,58,169,232,104,140,126,5,95,161,41,170,224,63,32,77,83,142,254,0,1,219,230,190,164,133,81,57,73,139,206,80,108,121,140,210,138,0,239,111,10,181,14,99,128,66,176,70,226,15,80,223,40,193,154,34,4,86,45,204,25,193,130,112,31,94,48,31,40,9,65,5,35,203,233,240,134,81,185,39,38,127,56,153,229,45,239,73,200,252,98,139,25,222,40,140,166,195,134,19,6,202,85,58,34,135,179,79,240,140,138,118,33,191,152,40,234,248,230,162,46,155,77,197,111,88,93,16,206,107,54,156,205,245,10,218,218,37,143,129,1,60,137,91,246,201,211,6,249,202,73,196,53,251,203,213,10,112,197,0,230,229,2,111,133,210,216,215,100,36,197,13,206,208,61,230,36,11,217,244,136,145,76,218,193,147,113,25,169,22,218,107,190,11,129,124,75,152,84,246,76,254,22,192,141,44,52,201,150,209,71,240,23,122,77,149,4,0,251,66,25,182,187,43,214,100,131,199,200,125,250,173,33,224,12,244,167,74,4,107,191,92,108,19,51,17,19,42,113,108,198,32,78,48,43,214,232,65,111,76,184,123,107,245,60,73,181,121,68,51,13,209,0,178,216,252,26,48,34,26,86,197,237,64,47,95,34,77,53,200,226,4,144,163,228,159,83,180,202,70,163,115,197,242,233,8,95,125,32,98,93,47,148,163,148,103,246,192,10,145,199,209,130,112,40,78,170,152,35,44,4,163,247,13,184,83,199,137,138,245,99,211,201,97,52,156,233,16,183,108,156,87,251,179,138,43,171,135,51,23,131,254,14,13,63,159,189,62,168,250,197,196,210,186,177,10,229,72,150,99,48,223,225,112,105,25,232,68,147,213,52,211,86,232,5,87,152,99,143,239,47,164,13,48,89,53,48,130,176,207,250,51,46,27,98,170,181,139,204,21,20,251,203,4,105,102,34,192,68,158,22,147,155,154,160,195,45,255,178,38,140,100,198,252,233,204,0,145,7,156,242,55,15,13,46,121,150,82,106,52,50,236,238,136,60,171,251,252,20,145,161,185,162,140,11,163,219,211,17,69,189,232,18,121,135,150,180,132,250,149,202,223,94,108,16,254,96,3,195,216,175,42,192,110,127,68,209,174,214,238,218,176,212,10,236,223,248,51,194,249,81,130,122,85,179,59,252,72,134,51,5,177,106,8,56,60,167,195,122,30,3,41,30,201,189,90,113,165,200,187,62,203,32,223,149,53,67,193,179,222,86,4,0,143,181,95,157,3,106,135,92,4,199,110,217,210,209,61,70,245,253,95,32,108,134,254,38,59,19,144,202,82,110,179,224,176,146,198,72,83,25,15,210,103,160,169,201,7,64,147,96,56,11,178,119,100,167,164,222,96,202,210,154,105,23,208,42,169,235,224,58,33,253,26,122,83,163,167,250,57,149,112,229,26,93,77,241,133,138,245,141,244,40,81,248,90,165,55,224,101,202,235,234,35,244,48,58,247,12,200,3,95,171,28,44,24,7,154,230,234,175,49,117,96,67,225,114,177,200,58,77,220,163,193,150,7,67,121,48,45,213,1,160,115,137,75,209,182,61,64,42,112,143,206,204,109,107,117,155,41,221,210,79,76,79,155,1,119,105,141,227,105,98,54,188,11,156,46,237,79,188,202,220,68,232,188,234,216,53,70,201,44,177,193,244,136,153,69,183,39,90,135,122,74,122,24,221,238,65,100,171,16,68,177,131,178,217,223,197,177,179,67,71,125,225,252,158,122,250,170,147,199,33,53,53,223,198,29,93,162,204,219,12,186,55,101,217,138,26,64,207,12,245,176,33,134,254,201,132,107,76,249,196,41,42,141,49,199,139,67,209,89,51,120,219,208,133,193,242,211,245,34,56,56,239,236,186,81,64,105,220,18,219,3,207,1,235,182,174,69,187,105,212,73,9,45,177,166,12,116,33,65,110,61,7,29,230,65,51,173,112,252,236,208,100,94,163,224,96,56,114,53,245,185,134,224,38,117,138,244,29,160,147,63,70,228,46,209,7,92,225,21,97,48,121,139,107,51,92,189,218,1,0,29,84,173,90,182,101,237,133,45,73,188,112,237,121,145,136,249,252,35,219,129,108,29,98,220,116,187,117,35,146,76,93,207,164,104,220,51,35,242,58,107,77,26,164,180,146,229,212,106,147,212,36,4,159,86,194,13,193,235,106,65,190,6,81,169,96,134,229,78,5,19,69,177,206,235,200,86,176,227,101,90,75,103,19,232,12,92,244,186,188,164,41,176,200,66,21,199,81,225,45,211,30,184,225,49,233,185,57,5,150,231,103,95,65,237,239,222,225,235,248,57,124,103,252,187,199,175,73,53,164,99,67,241,61,209,161,99,67,130,144,75,222,141,7,99,175,30,132,158,193,253,121,2,108,57,60,115,120,37,195,140,19,30,236,61,13,193,215,2,211,74,2,16,118,245,186,161,79,163,171,172,139,236,57,16,39,177,18,212,30,78,182,246,152,133,224,168,1,0,110,201,18,6,21,168,62,154,34,11,140,52,248,133,140,12,128,225,178,26,71,142,199,39,198,213,5,72,157,51,91,125,189,228,167,167,103,133,185,128,242,159,28,250,243,189,128,199,148,24,71,164,134,120,63,245,59,189,68,81,59,216,249,129,26,222,52,38,239,37,212,52,117,234,84,246,127,245,126,253,91,130,158,209,195,253,141,161,115,23,103,218,194,199,26,156,13,72,244,46,125,218,33,233,251,250,63,211,224,167,186,206,132,250,54,10,219,190,169,107,31,123,44,104,210,243,109,44,199,219,131,56,63,57,123,156,247,183,181,99,161,211,8,190,136,221,144,165,79,118,24,212,186,236,130,39,217,53,169,153,201,114,184,83,119,121,74,82,88,8,162,146,188,211,186,29,3,123,61,167,196,46,217,50,180,232,245,112,208,105,215,42,124,194,176,43,7,194,212,65,228,149,132,83,166,225,228,240,46,71,245,88,200,245,11,78,139,166,28,87,175,122,19,36,247,1,60,237,130,49,188,202,167,213,26,156,36,22,117,97,238,233,211,159,9,134,19,247,86,252,145,50,1,61,58,130,225,187,217,16,134,239,75,98,46,69,103,242,196,220,151,134,214,89,239,41,23,237,158,182,164,233,230,193,125,151,24,173,34,89,28,12,88,86,255,54,58,100,54,164,15,133,99,167,164,19,139,4,154,218,129,40,61,186,186,53,202,27,75,141,228,189,21,47,181,121,156,44,56,231,65,234,69,43,136,4,51,154,207,65,213,82,168,186,161,58,175,27,104,181,103,83,212,125,104,84,3,142,156,95,4,207,63,224,175,74,134,226,109,246,168,45,206,153,174,21,114,18,140,132,11,250,50,7,32,13,73,131,175,50,253,166,83,166,210,45,174,86,36,11,153,58,180,192,251,150,112,112,152,186,81,213,181,206,127,221,90,91,66,57,204,246,157,251,63,7,230,16,229,203,10,52,234,32,251,15,16,59,30,176,72,151,99,55,159,31,81,158,204,39,221,48,76,247,245,66,201,111,185,140,108,25,56,14,2,237,248,219,49,219,92,104,14,189,252,61,219,115,131,42,183,31,243,57,206,152,152,154,121,127,212,212,182,122,126,167,205,201,203,131,168,237,33,213,169,40,36,170,224,143,130,112,242,173,168,143,65,170,172,159,29,248,238,23,129,237,16,32,122,213,95,132,53,248,247,47,253,170,170,74,190,33,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6eb9e4aa-52ba-4b23-94c6-bb6fb8b15ae0"));
		}

		#endregion

	}

	#endregion

}

