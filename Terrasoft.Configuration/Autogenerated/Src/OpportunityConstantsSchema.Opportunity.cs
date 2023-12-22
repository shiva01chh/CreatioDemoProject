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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,77,107,220,48,16,134,207,54,248,63,136,156,218,195,100,101,75,150,45,146,22,130,83,151,64,66,161,13,228,44,235,99,113,176,165,197,146,9,75,201,127,175,118,29,194,102,161,36,132,213,97,16,51,239,188,243,48,204,236,123,187,70,127,182,62,232,241,34,75,179,212,138,81,251,141,144,26,221,235,105,18,222,153,112,222,56,107,250,245,60,137,208,59,155,165,127,179,52,217,204,221,208,75,228,67,204,73,36,7,225,61,250,181,217,184,41,204,182,15,219,216,17,75,54,248,40,221,201,147,213,106,133,46,253,60,142,98,218,126,95,18,168,25,156,215,10,77,250,81,203,16,63,177,99,173,207,95,213,171,67,249,219,121,147,22,202,217,97,139,126,206,189,122,51,119,111,249,251,197,241,70,161,111,200,234,167,189,236,203,89,69,88,91,210,246,26,126,20,20,3,101,109,13,117,83,53,192,49,99,13,193,87,109,91,242,179,175,251,45,188,3,60,185,249,196,192,139,227,17,48,23,157,41,40,145,96,36,142,192,165,52,80,235,162,6,169,58,198,36,47,112,221,225,143,0,63,57,123,58,214,7,103,143,48,25,86,37,201,177,132,178,211,12,148,201,115,224,85,222,1,198,185,98,88,115,82,75,246,17,204,24,195,233,56,111,163,219,17,168,224,66,24,101,52,20,5,45,128,154,24,106,169,74,40,132,38,29,47,75,166,170,229,0,146,228,127,168,215,218,136,121,8,135,227,238,156,83,168,31,63,135,189,248,237,44,110,118,14,71,192,152,84,134,8,206,65,86,164,6,154,51,3,130,178,14,84,110,48,215,132,114,44,151,3,72,158,179,244,121,183,224,195,247,15,80,253,213,103,220,3,0,0 };
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

