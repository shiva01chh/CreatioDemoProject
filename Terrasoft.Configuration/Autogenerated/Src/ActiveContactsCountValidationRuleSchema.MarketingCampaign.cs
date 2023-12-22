namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActiveContactsCountValidationRuleSchema

	/// <exclude/>
	public class ActiveContactsCountValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActiveContactsCountValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActiveContactsCountValidationRuleSchema(ActiveContactsCountValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0cfaf6c-8e52-4d6e-9308-ace8e31dafc5");
			Name = "ActiveContactsCountValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,146,77,111,227,32,16,134,207,68,202,127,24,117,47,233,197,233,185,89,71,90,69,253,146,146,85,213,253,184,174,40,30,187,72,4,162,1,170,237,166,253,239,5,108,103,141,219,180,62,88,204,48,243,242,240,50,154,111,209,238,184,64,248,137,68,220,154,218,21,43,163,107,217,120,226,78,26,61,157,236,167,19,230,173,212,77,86,66,184,152,78,194,206,124,62,135,175,214,111,183,156,158,150,93,252,155,43,89,165,110,32,175,16,76,13,92,56,249,136,32,140,118,97,105,195,194,107,87,244,253,243,129,192,206,223,43,41,64,40,110,45,124,75,109,171,174,107,21,155,254,139,223,69,237,115,184,201,51,65,98,159,200,216,23,194,38,50,92,74,84,149,61,135,91,146,143,220,97,187,185,107,3,176,142,226,213,46,136,12,173,197,191,31,41,12,138,30,161,92,194,201,119,227,46,180,241,205,67,78,178,177,205,201,98,40,67,200,43,163,213,19,252,178,72,161,74,163,72,247,255,227,179,120,209,145,161,174,90,184,156,52,20,6,30,47,156,161,200,155,156,232,112,91,87,62,245,99,54,58,63,63,254,20,226,99,50,54,162,130,18,222,96,50,246,242,49,235,45,153,29,146,147,248,62,233,208,87,216,67,131,110,1,7,207,99,240,137,252,6,221,131,169,70,218,227,97,27,78,27,30,159,177,183,67,214,83,222,27,163,14,2,179,222,158,181,20,193,139,74,70,43,54,166,66,5,161,246,70,215,38,24,149,191,192,53,170,96,66,113,133,46,207,175,219,250,217,200,232,211,100,44,147,245,172,19,44,54,252,239,225,168,244,156,80,150,112,6,207,207,253,145,69,155,93,194,209,142,158,154,181,94,151,239,205,114,36,204,51,71,208,24,161,243,164,161,230,202,98,155,122,73,255,46,31,166,19,63,152,142,144,77,27,195,239,21,222,249,147,37,99,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0cfaf6c-8e52-4d6e-9308-ace8e31dafc5"));
		}

		#endregion

	}

	#endregion

}

