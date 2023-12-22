﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForEveryoneOperatorRoutingRuleSchema

	/// <exclude/>
	public class ForEveryoneOperatorRoutingRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForEveryoneOperatorRoutingRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForEveryoneOperatorRoutingRuleSchema(ForEveryoneOperatorRoutingRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("17ba95b9-0d62-4543-8537-108041329421");
			Name = "ForEveryoneOperatorRoutingRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,219,78,27,65,12,125,14,18,255,224,110,37,180,145,208,236,123,154,68,226,18,80,36,16,148,128,250,60,204,58,97,212,221,153,48,23,74,10,252,123,61,179,179,97,147,114,169,154,135,40,177,143,125,236,99,143,21,175,209,46,185,64,184,70,99,184,213,115,199,142,180,154,203,133,55,220,73,173,216,69,173,164,184,227,74,97,197,206,209,90,190,144,106,177,187,243,180,187,211,243,150,126,194,108,101,29,214,223,182,254,83,150,170,66,17,82,88,118,138,10,141,20,127,97,206,164,186,127,53,118,43,168,107,173,222,246,24,124,207,206,142,15,201,69,206,175,6,23,196,11,71,21,183,118,0,39,218,76,30,208,172,180,194,139,37,82,91,218,92,105,239,40,193,149,175,48,70,20,69,1,67,235,235,154,155,213,56,253,63,69,7,58,225,45,204,181,1,146,193,177,22,93,116,224,75,127,91,73,1,34,240,125,66,55,128,67,110,223,174,163,247,20,107,121,45,159,164,115,198,139,192,63,128,203,200,209,32,182,203,141,134,169,146,78,242,74,254,70,11,10,127,129,164,104,174,104,178,122,78,96,68,16,6,231,163,236,227,242,178,98,204,214,12,197,54,197,112,201,13,175,65,209,210,140,50,111,209,80,137,170,25,114,54,238,112,220,108,186,138,241,186,24,54,44,98,142,152,50,201,246,113,69,249,102,50,216,164,237,195,0,110,73,208,124,219,252,4,47,73,77,84,101,35,232,166,186,231,232,238,116,25,132,53,242,129,59,252,103,180,118,196,129,101,103,18,82,221,209,122,187,82,139,212,255,59,35,102,151,82,252,188,89,158,24,196,239,30,253,26,98,243,83,47,203,125,8,223,125,82,43,106,211,242,128,38,109,140,44,17,206,164,117,195,128,25,195,135,137,226,158,78,83,62,184,15,128,105,73,138,132,180,61,131,206,27,5,51,122,201,212,215,21,46,181,149,20,185,138,206,30,189,84,119,80,85,7,36,226,67,39,107,63,121,127,80,159,152,107,24,141,33,215,236,136,104,34,189,13,39,195,113,154,113,190,102,219,219,131,47,83,27,32,103,178,150,110,242,40,16,75,44,115,221,79,201,122,207,207,160,217,177,52,177,203,0,236,164,105,58,72,200,150,125,134,225,160,52,244,154,133,181,32,8,187,214,65,151,188,31,174,66,239,229,127,166,66,61,7,250,214,149,127,50,134,168,234,91,49,73,247,86,233,104,106,15,200,180,132,17,228,225,89,166,46,54,183,186,109,145,142,166,175,85,158,93,172,195,178,198,197,78,140,174,201,78,199,56,240,102,251,144,105,209,250,154,177,4,3,153,67,8,155,218,201,189,231,85,222,228,99,151,225,201,161,67,211,10,219,4,114,155,170,233,179,201,35,10,239,112,38,120,197,77,179,100,73,210,118,99,94,59,233,42,189,245,94,26,107,215,248,2,187,59,221,207,31,228,78,52,157,113,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("17ba95b9-0d62-4543-8537-108041329421"));
		}

		#endregion

	}

	#endregion

}

