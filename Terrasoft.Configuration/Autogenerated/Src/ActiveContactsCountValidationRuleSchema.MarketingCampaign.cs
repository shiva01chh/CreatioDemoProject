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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,146,193,78,227,48,16,134,207,174,212,119,24,177,151,114,73,247,76,73,37,84,1,139,212,34,180,236,114,69,198,153,4,75,174,93,141,109,4,91,120,247,181,157,164,212,129,66,14,145,103,60,243,251,243,239,209,124,141,118,195,5,194,31,36,226,214,212,174,88,24,93,203,198,19,119,210,232,241,104,59,30,49,111,165,110,178,18,194,217,120,20,118,166,211,41,156,90,191,94,115,122,153,119,241,29,87,178,74,221,64,94,33,152,26,184,112,242,9,65,24,237,194,210,134,133,215,174,232,251,167,123,2,27,255,160,164,0,161,184,181,112,150,218,22,93,215,34,54,189,139,255,142,218,39,112,149,103,130,196,54,145,177,31,132,77,100,184,144,168,42,123,2,55,36,159,184,195,118,115,211,6,96,29,197,171,157,19,25,90,138,127,183,41,12,138,30,161,156,195,209,181,113,231,218,248,230,49,39,89,217,230,104,182,47,67,200,43,163,213,11,252,181,72,161,74,163,72,247,191,247,89,60,235,200,80,87,45,92,78,26,10,3,143,23,206,80,228,77,78,116,184,173,43,223,250,49,25,156,159,31,127,12,241,49,25,27,80,65,9,31,48,25,123,251,154,245,134,204,6,201,73,252,156,116,223,87,216,66,131,110,6,59,207,99,240,141,252,10,221,163,169,6,218,195,97,219,159,54,60,60,99,31,135,172,167,124,48,70,237,4,38,189,61,75,41,130,23,149,140,86,172,76,133,10,66,237,149,174,77,48,42,127,129,95,168,130,9,197,37,186,60,191,108,235,39,3,163,143,147,177,76,214,147,78,176,88,241,231,221,81,233,57,161,44,225,39,188,190,246,71,22,109,118,14,7,59,122,106,214,122,93,126,54,203,145,48,207,28,64,99,132,206,147,134,154,43,139,109,234,45,253,187,124,152,78,252,98,58,66,54,109,196,239,63,30,150,214,246,91,4,0,0 };
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

