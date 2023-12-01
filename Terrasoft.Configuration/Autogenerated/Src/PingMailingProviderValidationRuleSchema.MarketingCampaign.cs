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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,146,77,107,194,64,16,134,207,43,248,31,166,246,18,161,36,119,173,94,74,45,133,10,161,182,189,150,53,153,164,11,155,108,152,221,21,172,248,223,187,249,208,38,49,104,8,129,217,204,59,59,207,59,147,243,12,117,193,35,132,15,36,226,90,37,198,127,82,121,34,82,75,220,8,149,143,71,135,241,136,89,45,242,180,147,66,56,31,143,220,159,32,8,224,81,219,44,227,180,95,54,241,23,151,34,174,212,64,86,34,36,138,32,227,66,150,53,10,82,59,17,35,249,39,109,208,18,23,118,43,69,4,145,228,90,67,232,210,215,181,42,108,68,255,133,223,203,186,51,120,237,158,184,18,135,170,43,118,79,152,150,247,175,4,202,88,207,32,36,177,227,6,235,159,69,29,128,54,84,182,244,76,164,232,45,250,221,84,161,171,104,17,22,75,152,148,13,172,92,3,24,175,81,107,158,226,100,222,86,19,242,88,229,114,15,77,147,27,164,157,112,70,126,103,157,120,88,243,169,145,156,207,57,70,149,77,223,182,19,207,27,8,204,227,154,163,11,229,18,93,235,54,50,138,74,180,202,180,134,172,54,240,166,117,94,239,254,238,245,15,125,164,46,209,20,202,149,96,172,7,10,11,24,32,103,61,52,151,117,193,202,216,241,58,176,131,40,144,140,192,97,220,246,28,225,0,41,154,57,156,103,92,6,55,202,175,209,252,168,184,87,187,191,216,237,205,198,193,117,190,220,231,83,131,91,165,228,89,235,157,252,19,137,119,215,243,208,15,91,35,243,166,167,76,86,163,45,134,86,213,127,65,211,61,241,122,150,79,235,65,48,66,99,41,135,132,75,221,204,230,88,125,155,115,183,81,120,101,24,238,212,189,238,249,3,228,7,96,84,51,4,0,0 };
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

