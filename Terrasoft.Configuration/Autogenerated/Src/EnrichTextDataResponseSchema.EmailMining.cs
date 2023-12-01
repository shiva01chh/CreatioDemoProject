namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EnrichTextDataResponseSchema

	/// <exclude/>
	public class EnrichTextDataResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EnrichTextDataResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EnrichTextDataResponseSchema(EnrichTextDataResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("292254cb-473a-40ba-91c0-ffcaaa382dcd");
			Name = "EnrichTextDataResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c9ff5cbb-cb0e-4041-b483-395260757ab0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,77,79,227,48,16,61,183,18,255,97,20,46,237,37,185,47,109,36,196,46,104,165,178,66,192,13,113,48,206,164,181,214,177,35,123,220,229,67,252,119,198,78,168,210,66,11,155,147,61,121,243,252,230,205,51,162,65,223,10,137,112,139,206,9,111,107,202,207,172,169,213,50,56,65,202,154,163,241,203,209,120,20,188,50,75,184,121,242,132,205,201,206,157,241,90,163,140,96,159,95,160,65,167,228,7,204,117,48,164,26,204,111,248,175,208,234,57,113,51,138,113,199,14,151,124,129,51,45,188,255,1,191,12,247,175,110,241,145,126,10,18,215,172,142,121,49,33,139,162,128,153,15,77,35,220,83,217,223,59,56,16,227,161,226,6,64,141,13,26,242,32,55,178,242,247,222,98,208,124,23,233,121,84,114,66,210,61,23,218,240,160,149,4,25,101,236,85,49,122,73,74,54,162,175,156,109,209,145,66,86,126,149,8,186,255,187,82,251,2,34,72,135,245,60,235,248,227,243,252,250,111,118,40,131,162,4,197,7,15,90,121,202,55,61,67,205,157,232,75,108,30,208,77,254,240,234,96,14,89,156,58,155,198,9,222,71,88,48,193,108,123,130,248,68,9,241,4,113,159,163,209,18,233,36,29,124,127,120,61,32,124,97,237,223,208,194,90,232,128,30,108,13,66,74,27,162,201,180,18,4,14,53,239,115,141,64,150,93,79,35,253,135,254,154,153,170,211,158,112,239,32,61,160,155,227,124,216,242,197,64,199,104,170,110,89,219,155,99,239,61,185,32,201,186,157,221,245,143,127,30,129,201,180,127,47,121,57,7,131,255,246,250,61,153,126,71,200,37,210,202,86,223,201,207,105,85,121,152,181,194,137,134,67,4,134,13,156,103,49,51,25,103,135,189,31,228,43,106,136,213,3,89,74,149,68,54,100,42,15,134,52,102,148,109,19,70,98,62,43,82,115,57,176,108,109,85,21,85,78,62,154,145,178,61,244,46,143,184,84,220,103,82,95,219,246,141,107,252,189,1,142,201,131,130,183,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("292254cb-473a-40ba-91c0-ffcaaa382dcd"));
		}

		#endregion

	}

	#endregion

}

