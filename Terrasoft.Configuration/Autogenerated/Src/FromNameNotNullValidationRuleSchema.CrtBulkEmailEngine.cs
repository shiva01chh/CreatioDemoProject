namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FromNameNotNullValidationRuleSchema

	/// <exclude/>
	public class FromNameNotNullValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FromNameNotNullValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FromNameNotNullValidationRuleSchema(FromNameNotNullValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6d5308f5-73b6-4136-a80d-c0e6af1a6d50");
			Name = "FromNameNotNullValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,75,111,219,48,12,62,167,64,255,3,215,1,69,10,12,242,189,141,123,88,208,21,193,150,96,72,135,222,21,155,78,132,202,146,71,202,25,140,162,255,125,148,252,88,146,195,124,48,172,79,226,247,160,104,167,107,228,70,23,8,191,144,72,179,175,130,90,122,87,153,125,75,58,24,239,224,250,234,253,250,106,214,178,113,123,120,233,56,96,45,7,172,197,34,238,178,122,70,135,100,138,135,203,51,63,140,251,45,160,192,159,9,247,145,104,105,53,243,61,192,55,242,245,70,100,55,62,108,90,107,95,181,53,101,146,218,182,22,83,69,150,101,176,224,182,174,53,117,143,195,122,139,13,33,163,11,12,225,128,80,68,50,248,99,194,1,72,202,24,124,5,199,137,9,42,79,224,68,3,42,17,131,90,23,228,25,118,29,96,221,132,78,141,18,217,137,70,211,238,172,41,6,222,255,90,132,123,248,170,25,47,64,161,120,79,230,167,188,107,12,7,95,74,226,159,228,131,180,11,203,126,255,50,93,2,6,54,236,211,73,206,18,79,19,68,112,52,181,142,105,212,196,148,93,82,45,26,77,186,78,197,249,13,97,97,26,35,109,187,121,220,142,159,177,87,187,214,190,73,55,180,177,106,145,165,130,84,223,140,86,193,31,101,30,76,137,112,244,166,132,149,11,72,78,143,157,192,249,106,141,204,122,143,19,233,202,85,30,38,181,59,136,67,51,155,29,53,197,107,105,113,52,15,57,60,99,72,17,94,71,124,226,152,79,245,95,96,45,214,100,156,100,22,57,176,58,203,254,29,187,187,135,68,111,42,152,159,211,127,202,193,201,141,193,237,237,185,174,74,106,234,159,48,228,57,112,32,145,80,79,113,40,70,199,179,201,131,90,57,19,140,182,91,249,65,196,5,46,125,25,237,207,141,196,27,220,157,110,169,165,118,5,90,44,95,210,229,241,48,63,169,99,189,219,143,248,254,24,134,68,14,245,115,146,214,61,122,14,10,22,159,191,99,89,60,219,162,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6d5308f5-73b6-4136-a80d-c0e6af1a6d50"));
		}

		#endregion

	}

	#endregion

}

