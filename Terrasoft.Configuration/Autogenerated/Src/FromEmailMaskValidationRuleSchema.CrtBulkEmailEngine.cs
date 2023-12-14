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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,75,111,219,48,12,62,167,64,255,3,219,1,69,2,12,242,189,77,122,104,182,21,193,150,97,72,183,220,25,155,78,132,200,146,39,202,25,130,162,255,125,148,252,88,230,67,125,144,37,138,252,30,18,101,177,34,174,49,39,248,73,222,35,187,50,168,165,179,165,222,55,30,131,118,22,174,175,94,175,175,38,13,107,187,135,151,51,7,170,36,193,24,202,227,46,171,103,178,228,117,254,48,206,249,166,237,111,9,74,248,131,167,125,4,90,26,100,190,7,248,226,93,245,185,66,109,214,200,199,45,26,93,36,162,77,99,40,229,103,89,6,115,110,170,10,253,249,177,91,111,168,246,196,100,3,67,56,16,228,17,10,254,232,112,104,7,47,181,12,174,132,211,0,7,165,243,64,145,134,161,20,70,168,48,247,142,97,119,150,25,31,85,79,148,93,48,213,205,206,232,188,67,127,71,38,220,195,19,50,141,130,2,240,154,12,12,142,215,20,14,174,16,207,63,188,11,114,96,84,180,251,99,135,41,208,161,81,235,80,188,22,212,25,104,245,199,232,133,38,49,163,6,172,108,12,54,175,209,99,5,86,110,119,113,235,41,215,181,150,195,187,125,220,244,211,120,88,187,198,28,91,6,53,207,82,65,170,175,123,177,224,78,210,19,186,32,56,57,93,192,202,6,242,22,77,47,116,186,90,19,51,238,105,0,93,217,210,193,192,54,131,216,56,147,201,9,125,188,151,134,6,245,176,128,103,10,201,195,182,223,24,64,166,3,192,71,88,75,178,244,148,52,36,7,86,255,187,255,74,231,217,67,34,208,37,76,71,4,55,11,176,141,49,112,119,7,55,29,200,175,32,191,160,137,85,111,32,165,142,42,85,18,164,254,105,155,245,54,38,131,46,181,178,2,132,102,35,47,71,148,209,210,201,17,45,96,170,197,115,71,118,185,165,150,104,115,50,84,188,164,59,229,79,78,136,236,119,23,182,242,112,74,77,69,235,226,45,142,111,93,3,73,102,219,67,105,221,70,47,131,18,137,223,95,243,146,26,53,190,3,0,0 };
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

