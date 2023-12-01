﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ESQueryBuilderSchema

	/// <exclude/>
	public class ESQueryBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ESQueryBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ESQueryBuilderSchema(ESQueryBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("95706987-bc3f-4ed6-b63e-293af26f6611");
			Name = "ESQueryBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c3a921b-299a-4f38-a040-5c0154a25bee");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,87,219,110,219,56,16,125,86,129,254,3,235,5,10,25,40,228,238,107,92,167,64,211,36,40,16,7,105,28,236,107,192,200,99,155,0,37,185,36,229,110,182,205,191,119,120,145,121,177,165,117,252,96,155,156,195,185,158,17,71,53,173,64,110,105,9,228,1,132,160,178,89,169,226,162,169,87,108,221,10,170,88,83,23,215,188,121,162,124,1,84,148,155,183,111,126,189,125,147,181,146,213,107,178,120,150,10,42,4,115,14,165,70,202,226,26,106,16,172,156,238,49,107,115,246,236,236,162,169,42,84,117,211,172,215,184,237,229,183,32,149,95,121,15,46,57,149,138,149,214,40,2,16,242,151,128,53,26,33,23,40,146,103,228,114,241,189,5,241,252,165,101,124,9,194,32,38,147,9,249,36,219,170,162,226,249,220,173,157,34,34,141,38,242,67,159,33,79,246,80,209,157,153,4,135,182,237,19,71,124,169,173,36,70,200,25,249,150,154,205,126,25,211,123,239,174,24,240,37,186,119,39,216,142,42,176,194,173,93,16,169,132,14,243,81,150,27,168,232,45,102,126,26,139,169,118,85,0,93,54,53,127,38,223,48,93,228,145,227,215,140,224,223,57,173,233,26,189,190,6,165,243,8,34,31,133,165,25,141,35,101,94,139,21,99,153,218,170,214,54,239,68,179,99,58,156,71,217,35,153,186,152,160,94,218,176,226,24,17,182,5,161,24,152,56,27,133,213,135,101,23,169,91,146,29,19,170,165,156,176,90,145,175,176,162,45,87,87,162,169,200,236,156,124,156,158,0,94,176,255,64,131,255,254,56,12,159,179,154,85,109,181,216,52,45,95,206,169,42,55,119,32,74,168,21,230,42,62,127,82,56,166,250,86,158,210,201,108,220,32,157,28,127,150,164,210,230,44,167,138,253,137,144,76,251,106,24,199,12,115,176,160,168,194,242,103,233,183,109,237,44,247,2,240,205,49,172,14,171,87,203,80,164,216,215,72,193,182,84,141,72,98,117,150,99,118,231,253,212,233,99,206,152,232,231,67,150,245,82,11,169,60,192,186,44,123,25,142,96,14,106,211,244,246,87,232,46,193,54,9,215,185,93,152,248,174,24,87,232,202,202,252,116,46,11,80,173,168,73,13,63,99,61,86,154,121,127,49,4,123,178,240,123,31,44,232,30,86,32,160,46,97,177,239,112,68,7,253,238,112,145,216,41,91,164,160,135,231,109,32,214,43,179,255,18,230,233,8,191,76,241,252,186,55,238,15,221,227,104,71,121,11,93,22,118,52,46,46,58,144,38,210,165,109,186,199,151,97,106,122,43,95,36,122,180,44,15,193,129,198,42,224,186,169,72,16,159,171,71,39,53,222,187,140,29,62,11,16,112,184,89,248,39,68,62,244,248,24,59,181,230,153,238,28,49,255,115,31,241,56,168,73,118,188,41,241,100,21,247,121,199,181,100,59,169,169,17,96,203,42,202,240,86,181,117,181,21,28,46,108,88,74,147,29,233,175,104,207,167,127,180,196,122,99,47,223,124,143,191,172,219,10,240,242,111,68,151,223,64,131,46,163,7,228,227,206,90,150,28,45,230,205,14,110,225,95,149,187,186,90,170,180,2,251,67,25,227,157,242,224,204,133,21,7,7,86,62,96,87,129,56,45,123,237,108,69,242,72,251,59,132,183,156,239,253,203,98,85,105,155,116,77,17,234,232,116,191,216,159,159,27,198,65,231,169,47,80,111,235,85,113,158,224,123,226,124,184,250,253,251,85,177,116,193,184,31,199,196,64,161,197,189,156,72,200,5,82,135,195,125,203,193,151,36,32,166,22,16,129,95,33,41,173,49,137,113,104,73,97,201,43,15,184,104,97,17,25,221,201,94,14,166,71,6,73,232,154,102,118,96,232,8,13,5,72,156,73,124,236,179,195,118,140,180,118,230,28,101,6,252,58,224,204,169,110,101,135,62,165,59,239,223,159,232,102,76,134,68,205,235,8,145,180,231,13,147,234,83,66,136,115,83,119,217,69,30,148,220,236,71,21,55,59,189,245,78,240,131,229,54,84,156,165,38,146,164,6,157,104,241,105,35,234,113,188,184,20,2,221,24,61,108,240,178,39,76,146,186,177,106,113,32,37,106,131,27,2,112,40,148,106,52,246,181,178,195,5,234,138,83,62,64,174,99,173,21,248,150,80,172,63,21,7,12,59,41,19,39,208,171,123,242,156,232,232,43,73,246,255,35,96,58,171,179,26,11,194,212,178,193,215,55,1,171,217,40,121,91,43,60,65,71,147,243,96,236,189,195,203,158,62,113,112,47,139,193,28,117,112,211,186,225,200,252,247,195,110,56,206,5,128,96,166,243,179,205,143,184,105,102,71,219,38,84,114,111,154,197,42,208,252,76,20,164,119,69,48,199,30,141,171,35,131,125,27,139,220,53,91,159,63,135,239,107,110,4,202,236,235,88,28,156,222,242,104,189,236,208,95,155,18,105,85,171,193,148,116,224,239,105,66,226,0,29,121,2,130,28,116,211,113,198,216,221,120,19,247,240,243,7,196,195,40,44,244,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95706987-bc3f-4ed6-b63e-293af26f6611"));
		}

		#endregion

	}

	#endregion

}
