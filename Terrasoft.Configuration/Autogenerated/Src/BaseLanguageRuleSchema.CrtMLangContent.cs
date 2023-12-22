namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseLanguageRuleSchema

	/// <exclude/>
	public class BaseLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseLanguageRuleSchema(BaseLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("baa8372c-43b1-4ee1-aa11-be1c27d2f168");
			Name = "BaseLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2659875a-4670-491c-9c1f-f4641a7bae64");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,65,110,131,48,16,60,39,82,254,176,34,151,228,18,238,105,146,67,57,68,72,61,68,105,251,128,141,89,144,37,176,209,218,62,68,85,255,94,99,2,2,71,173,202,109,135,217,97,102,88,133,13,153,22,5,193,7,49,163,209,165,221,101,90,149,178,114,140,86,106,181,90,126,173,150,11,103,164,170,224,253,110,44,53,47,227,60,93,97,242,184,127,179,102,170,252,26,100,53,26,179,135,87,52,244,134,170,114,88,209,213,213,20,56,105,154,194,193,184,166,65,190,159,30,115,71,4,188,25,203,40,44,136,110,27,74,205,158,71,4,130,169,60,38,249,84,40,73,79,32,155,182,166,134,148,13,78,205,110,144,78,39,218,173,187,213,82,196,202,177,45,216,67,62,183,185,232,98,143,105,46,172,91,98,43,201,71,186,4,197,16,228,41,73,0,62,13,49,8,173,20,137,206,215,110,36,78,125,13,198,58,114,54,114,227,49,152,88,84,100,187,210,23,223,253,71,215,164,138,222,215,99,30,42,247,29,88,118,194,106,254,143,205,140,9,45,25,144,126,11,149,191,0,93,78,219,142,43,242,133,255,146,36,32,45,50,54,160,252,57,29,19,55,11,145,156,226,66,14,105,96,247,53,176,182,30,166,226,233,159,108,162,46,230,170,219,71,55,17,233,24,209,254,234,45,62,141,179,147,5,156,201,14,38,242,98,19,32,127,96,210,222,175,36,52,23,121,177,237,36,123,197,185,160,199,166,207,15,122,118,240,219,90,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("baa8372c-43b1-4ee1-aa11-be1c27d2f168"));
		}

		#endregion

	}

	#endregion

}

