namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PingMailingProviderValidationRuleSchema

	/// <exclude/>
	public class PingMailingProviderValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PingMailingProviderValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PingMailingProviderValidationRuleSchema(PingMailingProviderValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("245550c8-e406-4a0d-af79-0307b61b4d65");
			Name = "PingMailingProviderValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,146,81,107,194,48,16,199,159,35,248,29,110,238,165,194,168,239,58,125,25,115,12,38,200,220,246,58,98,123,237,2,105,83,46,137,224,196,239,190,164,173,174,173,69,75,41,92,122,255,203,253,254,119,57,207,80,23,60,66,248,64,34,174,85,98,194,39,149,39,34,181,196,141,80,249,112,112,24,14,152,213,34,79,91,41,132,179,225,192,253,153,76,38,240,168,109,150,113,218,47,234,248,139,75,17,151,106,32,43,17,18,69,144,113,33,125,141,130,212,78,196,72,225,73,59,105,136,11,187,149,34,130,72,114,173,97,237,210,87,149,106,93,139,254,11,191,251,186,83,120,109,159,184,18,135,178,43,118,79,152,250,251,151,2,101,172,167,176,38,177,227,6,171,159,69,21,128,54,228,91,122,38,82,244,22,253,110,202,208,85,180,8,243,5,140,124,3,75,215,0,198,43,212,154,167,56,154,53,213,132,60,86,185,220,67,221,228,6,105,39,156,145,223,89,43,238,215,124,106,36,231,115,142,81,105,211,183,109,197,179,26,2,243,184,226,104,67,185,68,215,186,141,140,34,143,86,154,86,147,85,6,222,180,46,232,220,223,190,254,161,139,212,38,26,131,95,9,198,58,160,48,135,30,114,214,65,115,89,23,172,140,29,175,3,59,136,2,201,8,236,199,109,206,17,14,144,162,153,193,121,198,62,184,81,126,133,230,71,197,157,218,221,197,110,110,54,246,174,243,229,62,159,26,220,42,37,207,218,224,228,159,72,130,187,142,135,225,186,49,178,96,124,202,100,21,218,188,111,85,195,23,52,237,147,160,99,249,184,26,4,35,52,150,114,72,184,212,245,108,142,229,183,62,119,27,133,87,134,225,78,221,235,159,63,245,64,228,149,52,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("245550c8-e406-4a0d-af79-0307b61b4d65"));
		}

		#endregion

	}

	#endregion

}

