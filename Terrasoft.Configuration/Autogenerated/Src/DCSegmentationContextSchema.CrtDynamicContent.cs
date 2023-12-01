﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCSegmentationContextSchema

	/// <exclude/>
	public class DCSegmentationContextSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCSegmentationContextSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCSegmentationContextSchema(DCSegmentationContextSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a05c2795-d9c4-4291-a385-04644e22aa30");
			Name = "DCSegmentationContext";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("41c9b305-ccaa-4408-abc9-8158dd3fa84a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,89,205,111,219,54,20,63,187,64,255,7,194,189,196,128,97,223,151,196,64,98,39,69,14,205,186,218,221,206,180,244,108,19,149,68,141,164,146,186,197,254,247,61,82,164,44,202,180,36,59,61,108,57,4,17,245,190,249,123,95,74,70,83,144,57,141,128,172,64,8,42,249,70,77,230,60,219,176,109,33,168,98,60,155,44,246,25,77,89,132,135,10,50,245,254,221,207,247,239,6,133,100,217,150,44,247,82,65,122,93,61,207,121,154,242,236,240,220,79,226,228,19,143,33,145,97,54,1,167,206,39,139,123,124,133,47,63,8,216,162,84,50,79,168,148,191,145,197,124,9,219,20,229,26,93,70,199,119,101,8,167,211,41,185,145,69,154,82,177,159,217,231,47,144,11,144,72,45,137,218,1,137,74,114,178,225,130,176,76,42,154,69,32,9,223,32,31,224,91,1,155,219,161,175,96,169,208,41,216,238,239,169,132,225,116,54,113,122,166,53,69,121,177,78,88,68,34,109,224,41,251,6,63,141,141,7,111,56,170,23,69,164,184,64,167,62,27,9,37,69,211,13,115,176,100,105,158,24,251,29,151,241,33,42,164,226,41,186,194,20,163,9,251,81,198,191,146,50,109,138,185,201,169,160,41,193,235,129,219,97,33,65,160,25,25,68,154,107,56,187,203,170,152,52,66,242,213,167,196,48,220,76,141,36,35,216,186,31,116,252,202,103,37,190,206,17,209,96,27,12,26,68,183,13,50,13,145,193,63,45,209,153,11,192,75,146,132,250,30,216,219,30,19,196,0,154,11,177,137,25,37,146,109,51,12,38,154,202,212,158,200,154,213,125,67,135,105,145,39,168,178,45,104,139,249,202,81,97,192,16,137,27,16,160,201,180,17,91,193,139,92,27,28,147,117,194,163,111,210,139,104,231,85,205,11,129,178,212,101,247,117,36,189,12,196,83,60,156,61,197,250,239,13,3,161,37,154,72,85,129,26,99,6,81,69,118,244,5,136,226,100,13,46,114,16,247,135,195,33,40,166,42,16,23,200,49,105,5,202,152,124,44,88,76,156,161,14,55,78,22,34,198,9,186,238,13,168,193,146,23,34,130,7,43,19,137,156,248,250,235,187,34,102,230,214,110,73,86,36,201,47,134,98,70,168,147,255,127,128,161,244,66,50,156,253,81,128,216,147,87,166,118,136,149,132,73,165,117,179,10,67,178,47,100,78,41,74,24,149,198,55,170,255,178,144,52,175,136,162,235,4,166,47,12,94,251,72,154,243,164,72,49,111,86,216,3,244,185,17,149,145,167,133,19,23,25,130,254,162,30,185,120,100,137,2,209,144,233,203,211,78,211,60,79,246,100,99,136,201,122,223,174,66,81,177,5,181,210,190,53,5,151,175,74,191,181,92,44,252,2,240,28,219,91,145,152,192,123,8,234,149,240,43,35,51,24,28,167,207,58,162,193,98,235,229,211,162,93,56,2,28,243,159,158,43,221,178,245,16,31,113,17,159,43,93,55,127,1,58,11,98,82,74,104,42,186,176,108,45,33,193,154,66,252,204,24,227,237,8,61,210,212,112,60,54,69,101,224,189,40,173,111,80,55,0,86,189,173,97,163,58,11,93,164,175,40,120,27,21,127,40,152,157,197,245,168,48,250,206,123,68,38,111,111,235,113,56,81,160,125,25,147,175,129,122,237,42,245,178,22,166,138,179,124,172,235,110,196,177,65,89,157,151,44,171,67,112,181,191,135,39,95,117,61,78,181,134,81,63,46,25,190,132,194,142,28,193,235,112,44,199,119,97,56,142,143,235,93,232,3,100,113,57,83,250,3,230,103,193,115,16,138,65,175,241,178,172,90,85,51,250,91,23,246,73,5,238,29,47,146,216,244,48,202,50,91,56,109,114,217,226,111,203,158,169,211,39,186,151,77,48,43,179,1,162,159,4,157,187,198,18,134,191,218,218,107,87,47,104,85,109,65,95,135,230,69,122,117,175,69,228,100,52,33,203,98,109,29,50,157,206,134,72,214,27,112,16,141,118,149,56,199,214,26,146,103,245,115,189,124,69,84,61,109,158,185,122,72,115,181,191,26,62,14,93,134,79,204,201,232,186,251,238,15,213,189,213,46,51,135,53,38,167,183,95,158,155,134,42,92,245,10,142,95,16,206,187,208,103,219,44,14,72,222,8,220,164,124,179,46,176,194,230,109,95,51,206,28,30,250,67,166,89,253,122,223,209,137,145,163,151,234,122,21,61,247,34,42,252,57,247,47,51,33,88,169,207,181,229,48,139,188,205,152,112,23,56,223,154,198,220,226,140,162,202,204,53,23,152,21,232,52,103,36,113,125,211,208,6,4,183,13,51,40,117,150,185,230,96,85,13,29,191,198,28,243,33,233,120,27,110,53,169,49,154,52,30,3,118,89,62,236,9,228,158,170,104,183,100,63,130,246,159,234,212,159,64,237,120,172,219,180,96,47,232,187,149,90,62,144,23,142,5,247,79,172,155,49,62,185,240,252,133,93,119,1,57,10,196,238,137,45,254,170,57,180,77,230,59,136,190,85,36,251,103,220,93,175,134,213,38,56,186,246,169,239,203,229,175,149,201,18,29,241,126,52,59,100,7,111,73,116,196,123,167,16,145,235,2,23,230,14,254,3,225,145,12,155,100,93,18,28,153,229,239,125,39,93,163,147,187,26,137,171,189,155,184,72,6,16,187,29,255,220,5,31,190,71,144,27,172,149,24,190,19,219,66,51,106,127,126,23,166,159,63,56,18,189,248,8,254,42,201,235,14,176,72,101,38,7,204,78,3,88,244,37,97,210,124,181,32,122,123,211,140,184,241,84,226,235,152,247,64,134,77,195,205,101,245,93,168,194,88,55,24,67,123,66,121,61,117,103,174,134,62,133,187,89,63,227,66,124,141,140,30,29,173,28,45,202,204,55,133,209,233,141,34,196,26,162,243,181,54,218,237,105,253,205,57,112,116,180,127,132,120,107,175,155,182,215,139,120,155,237,222,190,60,106,217,82,66,66,130,132,7,41,199,237,36,44,36,176,185,143,58,191,168,117,37,152,254,223,193,249,95,115,255,11,89,182,52,150,151,23,244,166,76,123,91,198,56,132,156,6,173,163,104,173,157,229,169,127,104,206,240,231,95,165,171,249,166,134,26,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a05c2795-d9c4-4291-a385-04644e22aa30"));
		}

		#endregion

	}

	#endregion

}
