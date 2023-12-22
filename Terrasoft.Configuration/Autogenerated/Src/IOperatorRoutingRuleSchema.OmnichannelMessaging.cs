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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,82,77,107,220,48,20,60,39,144,255,240,216,94,90,40,246,61,235,26,74,2,139,161,97,211,52,253,1,178,244,228,21,200,146,171,143,150,176,244,191,247,73,90,59,78,154,64,47,133,248,100,63,207,27,205,140,198,176,17,253,196,56,194,61,58,199,188,149,161,186,178,70,170,33,58,22,148,53,213,126,52,138,31,152,49,168,171,27,244,158,13,202,12,23,231,199,139,243,179,232,233,21,190,61,248,128,227,246,217,55,177,104,141,60,81,248,106,135,6,157,226,132,33,212,59,135,3,77,161,51,1,157,164,163,47,161,219,79,72,199,89,119,103,99,32,142,187,168,49,99,167,216,107,197,65,205,208,87,144,103,199,140,94,168,111,157,37,88,80,232,47,225,54,83,148,255,117,93,67,227,227,56,50,247,208,206,131,206,3,249,11,32,148,15,78,245,49,160,128,96,129,105,13,236,39,211,138,245,26,193,158,142,245,32,53,27,170,101,87,2,65,34,66,195,91,201,180,199,166,230,109,161,115,184,16,38,73,218,14,100,228,151,34,214,30,129,77,147,86,40,22,158,166,94,171,234,173,213,36,235,138,104,174,31,69,221,219,207,90,239,23,29,71,24,48,108,225,247,201,57,26,81,204,63,77,226,6,195,193,138,127,137,97,135,97,237,210,186,98,163,220,169,159,144,43,73,6,138,141,252,55,58,135,38,192,11,23,242,138,173,60,153,152,99,35,24,170,221,167,205,152,235,132,155,182,244,10,41,158,112,0,73,25,209,21,36,247,157,0,102,242,107,170,223,215,136,17,59,81,53,117,38,121,228,116,24,162,51,190,237,4,9,34,153,72,6,172,76,69,100,98,84,230,187,81,43,107,180,62,227,19,193,23,10,184,217,69,37,218,148,192,108,166,19,254,253,82,246,89,221,73,238,135,237,219,74,145,231,160,54,109,10,12,212,18,193,223,49,173,151,126,148,44,243,86,202,22,242,224,229,117,248,175,49,167,126,83,54,197,197,71,72,24,56,169,155,147,126,86,238,82,249,167,195,60,91,63,127,0,125,41,164,9,217,4,0,0 };
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

