namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FromEmailMaskValidationRuleSchema

	/// <exclude/>
	public class FromEmailMaskValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FromEmailMaskValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FromEmailMaskValidationRuleSchema(FromEmailMaskValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c4a873c4-bfd7-48e3-ac0b-3c4de968c246");
			Name = "FromEmailMaskValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,205,110,219,48,12,62,167,64,223,129,237,128,34,1,6,249,222,38,61,52,219,138,96,203,48,164,91,238,140,77,39,66,100,201,19,229,12,65,209,119,31,45,219,90,230,67,125,144,37,138,252,126,36,202,98,69,92,99,78,240,147,188,71,118,101,80,75,103,75,189,111,60,6,237,44,92,95,189,94,95,77,26,214,118,15,47,103,14,84,73,130,49,148,183,187,172,158,201,146,215,249,195,56,231,155,182,191,37,40,225,15,158,246,45,208,210,32,243,61,192,23,239,170,207,21,106,179,70,62,110,209,232,34,18,109,26,67,49,63,203,50,152,115,83,85,232,207,143,253,122,67,181,39,38,27,24,194,129,32,111,161,224,143,14,135,110,240,82,203,224,74,56,37,56,40,157,7,106,105,24,74,97,132,10,115,239,24,118,103,153,241,81,13,68,217,5,83,221,236,140,206,123,244,119,100,194,61,60,33,211,40,40,0,175,209,64,114,188,166,112,112,133,120,254,225,93,144,3,163,162,219,31,59,140,129,30,141,58,135,226,181,160,222,64,167,191,141,94,104,18,51,42,97,101,99,176,121,141,30,43,176,114,187,139,91,79,185,174,181,28,222,237,227,102,152,182,135,181,107,204,177,99,80,243,44,22,196,250,122,16,11,238,36,61,161,11,130,147,211,5,172,108,32,111,209,12,66,167,171,53,49,227,158,18,232,202,150,14,18,219,12,218,198,153,76,78,232,219,123,105,40,169,135,5,60,83,136,30,182,195,70,2,153,38,128,143,176,150,100,233,41,105,72,14,172,254,119,255,149,206,179,135,72,160,75,152,142,8,110,22,96,27,99,224,238,14,110,122,144,95,65,126,65,19,171,193,64,76,29,85,170,40,72,253,211,54,27,108,76,146,46,181,178,2,132,102,35,47,71,148,209,210,201,17,45,96,170,197,115,79,118,185,165,150,104,115,50,84,188,196,59,229,79,78,136,236,119,23,182,242,112,74,77,69,231,226,173,29,223,250,6,146,204,174,135,226,186,139,94,6,37,34,223,95,4,121,80,160,189,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c4a873c4-bfd7-48e3-ac0b-3c4de968c246"));
		}

		#endregion

	}

	#endregion

}

