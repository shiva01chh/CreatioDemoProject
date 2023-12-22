namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RuleEntityConnBindingModelSchema

	/// <exclude/>
	public class RuleEntityConnBindingModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RuleEntityConnBindingModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RuleEntityConnBindingModelSchema(RuleEntityConnBindingModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("97585371-05d4-46c8-a8c6-2e53c1842cc8");
			Name = "RuleEntityConnBindingModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,84,203,78,195,48,16,60,183,82,255,97,5,215,202,249,0,10,82,41,15,245,128,132,40,124,128,107,111,90,11,199,174,252,0,42,196,191,179,137,147,42,21,105,80,121,68,57,196,246,238,204,236,206,58,134,23,232,55,92,32,60,162,115,220,219,60,176,153,53,185,90,69,199,131,178,134,77,99,176,215,5,87,250,1,117,181,51,26,190,143,134,131,232,149,89,193,98,235,3,22,103,180,166,247,212,225,138,206,97,166,185,247,240,16,53,94,155,160,194,150,240,204,165,50,146,18,238,172,68,157,162,179,44,131,137,143,69,193,221,246,98,102,117,44,140,135,101,10,243,99,136,30,37,4,11,185,210,26,184,148,170,164,230,26,180,242,1,108,14,174,86,227,217,36,107,80,26,84,135,180,124,246,205,250,198,58,192,55,94,108,52,142,65,81,42,41,75,184,19,143,8,194,97,126,126,50,21,65,189,144,88,54,21,194,70,19,78,178,11,16,149,42,224,70,238,71,86,1,236,222,169,146,149,170,11,92,84,241,202,87,176,40,199,53,115,88,163,57,204,212,202,172,153,94,85,88,195,62,46,188,112,29,145,213,128,115,67,152,68,83,151,211,5,91,194,61,205,37,97,17,237,114,47,228,176,37,236,145,187,21,134,116,184,16,107,106,32,97,16,212,120,231,84,175,254,191,32,76,51,208,67,187,243,229,105,126,117,36,219,194,70,39,240,107,121,165,183,7,169,58,28,254,11,230,118,157,172,99,100,55,113,169,149,0,241,253,45,42,239,225,254,61,106,54,82,119,219,18,219,10,106,199,216,46,189,125,131,26,254,219,168,36,116,142,5,84,188,3,58,56,171,62,124,253,241,49,26,254,80,80,106,201,111,100,237,154,218,35,110,48,56,40,47,185,244,251,126,117,206,217,127,72,58,182,99,61,99,216,39,47,89,122,138,70,166,127,251,104,72,59,237,231,19,98,90,64,13,64,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("97585371-05d4-46c8-a8c6-2e53c1842cc8"));
		}

		#endregion

	}

	#endregion

}

