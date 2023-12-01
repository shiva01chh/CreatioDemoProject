namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IOperatorRoutingRuleSchema

	/// <exclude/>
	public class IOperatorRoutingRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IOperatorRoutingRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IOperatorRoutingRuleSchema(IOperatorRoutingRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e93c971a-debf-4f24-ad8f-d4b461191ae0");
			Name = "IOperatorRoutingRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,82,77,107,220,48,20,60,39,144,255,240,216,94,26,40,246,61,235,26,66,2,139,161,97,211,52,253,1,178,244,228,21,200,146,171,143,150,176,228,191,231,73,90,59,155,52,129,94,10,241,201,126,158,55,154,25,141,97,35,250,137,113,132,123,116,142,121,43,67,117,101,141,84,67,116,44,40,107,170,237,104,20,223,49,99,80,87,55,232,61,27,148,25,206,78,247,103,167,39,209,211,43,252,120,240,1,199,245,171,111,98,209,26,121,162,240,213,6,13,58,197,9,67,168,79,14,7,154,66,103,2,58,73,71,95,64,183,157,144,142,179,238,206,198,64,28,119,81,99,198,78,177,215,138,131,154,161,239,32,79,246,25,189,80,223,58,75,176,160,208,95,192,109,166,40,255,235,186,134,198,199,113,100,238,161,157,7,157,7,242,23,64,40,31,156,234,99,64,1,193,2,211,26,216,111,166,21,235,53,130,61,28,235,65,106,54,84,203,174,4,130,68,132,134,183,146,105,143,77,205,219,66,231,112,33,76,146,180,29,200,200,31,69,172,61,2,155,38,173,80,44,60,77,125,172,170,183,86,147,172,43,162,185,126,22,117,111,47,181,222,46,58,246,48,96,88,195,227,193,57,26,81,204,191,76,226,6,195,206,138,127,137,97,131,225,216,165,117,197,70,185,83,63,33,87,146,12,20,27,249,111,116,14,77,128,55,46,228,29,91,121,50,49,199,70,48,84,187,175,171,49,215,9,87,109,233,21,82,60,97,7,146,50,162,43,72,238,59,1,204,228,215,84,191,239,17,35,118,162,106,234,76,242,204,233,48,68,103,124,219,9,18,68,50,145,12,88,153,138,200,196,168,204,79,163,142,172,209,250,140,79,4,223,40,224,102,19,149,104,83,2,179,153,78,248,207,75,217,103,117,7,185,231,235,143,149,34,207,65,173,218,20,24,168,37,130,191,99,58,94,250,85,178,204,91,41,91,200,131,183,215,225,191,198,156,250,77,217,20,23,95,32,97,224,160,110,78,250,85,185,75,229,95,14,243,140,158,39,251,98,40,42,208,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e93c971a-debf-4f24-ad8f-d4b461191ae0"));
		}

		#endregion

	}

	#endregion

}

