﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SendingLimitValidationRuleSchema

	/// <exclude/>
	public class SendingLimitValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SendingLimitValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SendingLimitValidationRuleSchema(SendingLimitValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("99b5f416-c59e-435b-8afa-329e08b76089");
			Name = "SendingLimitValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,75,79,219,64,16,62,27,137,255,176,77,47,142,84,109,122,6,18,169,164,65,141,20,10,74,160,23,196,97,177,199,97,213,245,174,187,15,74,132,242,223,153,125,56,54,73,42,53,135,216,251,205,235,155,111,102,77,36,171,193,52,172,0,114,7,90,51,163,42,75,167,74,86,124,237,52,179,92,201,211,147,183,211,147,204,25,46,215,100,181,49,22,106,186,224,242,207,249,14,236,199,213,181,146,104,65,219,104,52,34,23,198,213,53,211,155,73,58,47,161,209,96,64,90,67,236,51,16,124,43,125,2,193,107,142,208,11,19,188,12,37,137,118,2,104,155,100,212,203,210,184,39,193,11,82,8,102,12,89,197,248,133,15,255,181,11,94,98,44,57,35,243,107,198,5,90,87,150,89,248,104,197,60,111,129,99,246,89,195,218,215,187,6,251,172,74,115,70,110,67,254,104,220,239,192,3,217,236,21,10,103,161,79,182,82,122,191,21,46,67,131,133,80,174,68,155,126,225,69,232,231,176,161,136,52,76,179,154,248,81,140,7,198,19,30,76,238,188,64,254,53,228,239,202,209,139,81,240,238,130,53,88,167,165,153,204,37,250,75,28,164,170,144,55,96,121,13,213,120,208,235,29,7,173,164,129,193,104,66,116,55,138,190,238,96,156,176,6,107,180,73,125,149,36,250,97,162,22,130,188,47,118,164,61,36,126,109,178,44,89,112,165,44,188,90,82,164,231,56,122,209,132,159,7,223,23,182,235,20,123,30,19,9,127,201,172,198,4,71,38,173,116,62,236,162,158,156,248,29,60,49,42,191,108,15,195,84,141,238,144,153,180,220,110,142,196,77,119,188,124,209,203,125,56,246,146,221,227,44,17,146,80,4,185,198,109,59,244,163,225,75,244,94,197,193,127,107,120,207,179,3,147,215,53,24,195,214,48,47,77,44,254,240,72,222,58,94,244,86,115,191,43,83,37,92,45,177,119,7,100,155,34,151,80,240,134,227,12,167,202,73,79,253,107,192,183,7,98,34,165,84,5,157,118,2,211,31,76,150,162,119,55,242,125,53,134,244,138,107,99,111,244,119,168,24,46,70,171,56,175,72,254,233,32,55,157,155,159,78,136,27,61,171,27,187,201,135,237,6,180,43,112,111,241,97,57,24,186,80,107,58,211,90,233,43,165,107,102,243,193,195,191,175,50,109,119,236,241,172,189,240,241,150,17,120,45,0,74,40,233,32,209,202,226,210,134,9,30,89,214,196,38,91,185,162,64,198,40,69,197,132,129,136,38,209,182,225,255,191,242,116,105,172,118,208,83,126,155,190,45,72,54,126,94,194,25,209,96,192,223,59,206,132,14,85,116,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("99b5f416-c59e-435b-8afa-329e08b76089"));
		}

		#endregion

	}

	#endregion

}
