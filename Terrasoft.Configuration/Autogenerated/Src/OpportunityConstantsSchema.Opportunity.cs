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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,223,75,228,48,16,199,159,91,232,255,16,124,58,31,198,77,155,52,109,240,20,142,122,21,193,67,80,193,231,52,63,150,30,109,178,52,41,178,28,254,239,151,221,202,161,11,114,34,155,135,33,204,124,231,59,31,134,153,125,111,215,232,97,235,131,30,207,179,52,75,173,24,181,223,8,169,209,163,158,38,225,157,9,103,141,179,166,95,207,147,8,189,179,89,250,39,75,147,205,220,13,189,68,62,196,156,68,114,16,222,163,187,205,198,77,97,182,125,216,198,142,88,178,193,71,233,78,158,172,86,43,244,221,207,227,40,166,237,229,146,64,205,224,188,86,104,210,191,181,12,241,19,59,214,250,236,159,122,245,86,254,126,222,164,133,114,118,216,162,235,185,87,239,230,238,45,239,95,29,111,20,186,64,86,63,239,101,223,78,42,194,218,146,182,87,240,179,160,24,40,107,107,168,155,170,1,142,25,107,8,254,209,182,37,63,57,221,111,225,63,192,147,155,143,12,188,56,30,0,115,209,153,130,18,9,70,226,8,92,74,3,181,46,106,144,170,99,76,242,2,215,29,254,12,240,179,179,199,99,125,114,246,0,147,97,85,146,28,75,40,59,205,64,153,60,7,94,229,29,96,156,43,134,53,39,181,100,159,193,140,49,28,143,243,54,186,29,128,10,46,132,81,70,67,81,208,2,168,137,161,150,170,132,66,104,210,241,178,100,170,90,14,32,73,62,66,189,210,70,204,67,120,59,238,151,115,10,245,227,215,176,23,191,157,197,205,206,225,0,24,147,202,16,193,57,200,138,212,64,115,102,64,80,214,129,202,13,230,154,80,142,229,114,0,201,75,150,190,236,22,28,223,95,109,255,245,64,211,3,0,0 };
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

