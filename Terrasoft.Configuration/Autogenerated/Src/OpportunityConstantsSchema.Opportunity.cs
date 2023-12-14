namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityConstantsSchema

	/// <exclude/>
	public class OpportunityConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityConstantsSchema(OpportunityConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ff91c21e-dcda-4052-875f-3134d07a6a12");
			Name = "OpportunityConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,77,107,220,48,16,134,207,54,248,63,136,156,154,195,100,101,75,150,45,250,1,193,169,67,32,165,144,20,122,150,245,177,184,216,210,98,201,132,165,228,191,87,94,135,178,89,40,9,101,117,24,196,204,59,239,60,12,51,251,222,110,209,227,222,7,61,126,204,210,44,181,98,212,126,39,164,70,63,244,52,9,239,76,184,106,156,53,253,118,158,68,232,157,205,210,223,89,154,236,230,110,232,37,242,33,230,36,146,131,240,30,125,223,237,220,20,102,219,135,125,236,136,37,27,124,148,46,242,100,179,217,160,79,126,30,71,49,237,191,172,9,212,12,206,107,133,38,253,75,203,16,63,177,99,171,175,254,170,55,199,242,215,243,38,45,148,179,195,30,221,206,189,122,53,247,96,249,240,226,120,167,208,103,100,245,211,65,246,225,162,34,172,45,105,123,3,95,11,138,129,178,182,134,186,169,26,224,152,177,134,224,235,182,45,249,197,229,97,11,111,0,79,110,62,51,240,234,120,2,204,69,103,10,74,36,24,137,35,112,41,13,212,186,168,65,170,142,49,201,11,92,119,248,61,192,79,206,158,143,245,167,179,39,152,12,171,146,228,88,66,217,105,6,202,228,57,240,42,239,0,227,92,49,172,57,169,37,123,15,102,140,225,124,156,247,209,237,4,84,112,33,140,50,26,138,130,22,64,77,12,181,84,37,20,66,147,142,151,37,83,213,122,0,73,242,47,212,27,109,196,60,132,227,113,223,156,83,168,31,255,15,123,245,91,44,238,22,135,19,96,76,42,67,4,231,32,43,82,3,205,153,1,65,89,7,42,55,152,107,66,57,150,235,1,36,207,89,250,188,44,120,121,127,0,137,238,148,1,212,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ff91c21e-dcda-4052-875f-3134d07a6a12"));
		}

		#endregion

	}

	#endregion

}

