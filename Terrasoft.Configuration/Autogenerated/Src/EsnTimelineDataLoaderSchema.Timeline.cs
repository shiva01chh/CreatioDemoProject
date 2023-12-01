﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsnTimelineDataLoaderSchema

	/// <exclude/>
	public class EsnTimelineDataLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsnTimelineDataLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsnTimelineDataLoaderSchema(EsnTimelineDataLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f4470d48-8806-4912-8773-4b0ab359402a");
			Name = "EsnTimelineDataLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0f0b57ce-3155-4876-a7bb-8a901e434b75");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,88,221,111,219,54,16,127,118,129,254,15,172,247,34,99,134,242,222,36,6,154,56,45,60,36,113,22,39,123,25,134,129,149,206,9,87,89,114,73,42,173,23,248,127,223,145,60,74,212,87,144,52,93,129,34,214,221,241,238,119,31,60,30,153,243,13,168,45,79,128,221,128,148,92,21,107,29,159,22,249,90,220,149,146,107,81,228,241,141,216,64,38,114,120,251,230,241,237,155,81,169,68,126,199,46,225,155,46,114,43,252,155,42,242,195,138,177,218,41,13,155,246,55,106,204,50,72,140,58,21,127,130,28,164,72,58,50,231,34,255,90,19,67,52,155,77,104,98,8,231,217,234,178,95,72,194,16,61,62,203,181,208,2,212,160,192,71,158,232,66,14,72,92,150,34,94,129,124,16,9,92,20,41,100,241,156,107,142,160,180,196,85,245,2,67,253,131,103,37,220,236,182,192,142,217,147,203,226,134,52,42,65,53,191,72,184,67,15,217,153,202,125,50,140,212,121,193,83,144,86,226,224,224,128,29,169,114,179,225,114,55,163,111,47,202,82,148,101,153,21,102,235,2,255,3,164,177,95,116,16,172,250,115,14,107,94,102,250,68,228,41,2,143,52,34,40,214,209,162,107,116,50,101,151,88,56,232,204,248,35,106,27,79,254,194,229,219,242,115,38,18,150,100,92,169,126,172,236,61,235,81,134,75,31,173,23,149,163,24,12,165,101,105,66,175,222,179,43,171,215,73,144,141,94,237,209,173,2,137,75,115,87,105,172,108,124,78,152,41,223,209,168,37,116,220,18,51,105,27,237,9,14,228,169,67,212,132,119,37,139,45,72,83,55,45,112,82,60,112,13,108,129,240,78,33,215,232,240,223,224,127,30,6,240,3,129,250,151,131,119,7,154,126,141,196,154,69,245,122,118,124,204,242,50,203,188,31,163,209,3,151,44,177,60,87,165,59,116,230,212,4,159,62,113,167,233,163,218,20,81,103,209,228,144,20,132,202,155,154,226,83,9,232,73,181,182,21,90,175,97,239,254,72,208,165,204,219,190,18,87,213,14,53,236,61,152,26,15,4,95,18,115,89,104,4,2,169,15,59,125,178,86,110,91,159,85,128,159,147,227,11,208,247,69,106,141,217,164,54,51,252,169,20,41,195,240,94,112,108,93,210,118,145,221,42,185,135,13,191,93,164,17,214,174,217,247,155,14,211,236,25,159,63,10,90,19,99,28,74,95,240,156,223,129,52,105,92,96,131,60,217,153,229,209,128,214,24,13,135,126,121,164,39,69,153,167,126,175,184,85,6,120,147,18,97,162,175,129,167,23,160,20,154,156,223,44,217,198,253,156,86,109,196,42,34,5,96,255,180,60,201,225,91,175,53,74,126,141,21,147,239,20,196,53,109,234,132,2,35,77,201,22,131,196,23,41,74,16,210,120,145,18,213,137,53,120,158,68,18,120,28,149,155,220,118,89,133,82,24,143,144,18,209,170,9,73,127,40,177,20,76,201,26,15,207,139,226,75,185,13,196,171,237,232,190,106,155,110,11,165,39,187,216,114,72,217,104,46,212,54,227,187,97,233,80,192,47,194,34,52,77,122,177,65,209,225,149,29,41,218,165,164,101,110,234,161,179,110,153,19,123,85,72,10,67,159,144,219,168,125,21,214,76,119,125,210,119,194,58,88,100,61,133,52,168,244,177,174,179,138,103,32,251,44,184,79,127,56,145,173,241,180,193,245,17,28,200,39,107,71,152,180,176,125,83,141,57,121,232,72,15,33,183,152,143,157,243,191,241,29,95,240,239,43,241,47,220,192,119,205,246,62,97,47,114,114,145,190,210,191,69,26,223,20,43,219,180,162,9,219,179,233,15,193,104,183,164,151,128,234,98,106,107,251,41,176,78,249,214,20,209,207,67,70,10,171,202,120,5,182,219,151,165,241,105,92,183,173,148,254,16,58,51,120,99,251,61,69,113,253,58,104,161,166,215,227,58,23,95,224,39,128,170,212,188,30,145,57,196,63,36,9,42,126,29,164,90,79,47,166,222,246,123,46,148,62,234,180,214,153,157,78,220,167,138,124,107,186,134,175,216,136,181,187,55,177,196,254,121,206,9,111,199,29,229,43,203,157,152,253,163,143,211,25,119,153,118,72,57,172,181,185,49,230,26,146,66,166,78,37,82,227,43,46,21,52,149,120,17,90,108,134,98,226,87,139,223,181,38,99,51,24,155,155,87,6,190,115,31,215,115,118,28,4,42,170,124,242,105,107,194,154,246,160,170,240,248,33,56,56,181,6,114,129,57,124,108,1,218,135,35,178,193,139,231,108,186,180,205,68,81,189,52,245,120,30,185,24,112,108,13,155,1,158,240,21,223,28,229,87,79,89,174,215,56,132,147,135,75,137,55,165,185,144,213,245,199,11,53,232,211,224,184,183,33,127,231,102,218,120,161,46,49,210,75,121,182,217,226,216,72,195,217,71,145,97,208,212,164,74,64,224,140,103,162,37,243,82,128,165,247,128,99,124,60,7,44,117,193,51,60,249,150,159,255,65,163,71,36,55,107,43,13,3,245,33,77,87,192,101,114,239,152,145,175,224,192,30,201,83,82,154,89,119,245,56,148,251,118,234,67,165,241,234,139,216,70,141,120,78,112,139,154,124,211,117,170,181,43,31,10,172,241,54,220,167,183,97,127,190,67,20,20,222,96,11,56,245,38,43,133,14,19,51,105,236,133,181,53,79,101,229,176,84,141,204,125,62,235,101,162,22,53,13,125,203,37,56,74,221,242,12,81,96,150,73,157,99,55,201,230,209,70,115,225,135,206,209,57,172,245,217,247,173,68,175,93,61,218,190,203,21,4,68,143,117,84,211,200,66,216,97,126,47,65,238,154,18,116,193,112,61,215,91,164,214,124,197,245,125,56,34,18,183,154,241,174,197,221,253,255,136,12,123,10,118,196,32,122,163,138,66,166,234,239,202,202,232,233,81,210,204,144,149,186,234,62,210,40,149,138,189,247,254,210,225,114,88,191,57,244,238,222,246,227,67,255,22,175,11,76,69,181,236,200,92,95,61,123,46,108,135,193,123,202,145,235,41,83,90,129,109,210,99,106,63,47,116,76,197,86,99,140,27,44,26,43,235,216,120,74,101,30,54,140,103,223,241,131,71,156,246,83,154,37,152,7,38,213,122,81,11,159,210,186,111,105,142,178,53,57,100,57,230,241,120,236,250,218,120,70,253,237,232,192,50,251,101,93,206,198,179,202,162,121,190,243,153,12,87,210,131,146,61,120,122,46,223,51,139,220,84,73,52,124,202,215,19,64,95,99,242,105,28,154,51,104,118,161,123,116,53,114,248,174,70,131,196,97,112,208,169,50,211,126,38,26,194,237,31,169,48,200,192,147,123,22,153,165,100,138,137,188,178,26,28,57,70,173,173,136,238,243,70,245,152,65,104,26,135,10,29,21,78,193,19,79,67,142,218,36,34,13,255,253,7,75,146,125,26,68,23,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f4470d48-8806-4912-8773-4b0ab359402a"));
		}

		#endregion

	}

	#endregion

}

