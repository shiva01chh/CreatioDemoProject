namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PrimeContactInAccountLanguageRuleSchema

	/// <exclude/>
	public class PrimeContactInAccountLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PrimeContactInAccountLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PrimeContactInAccountLanguageRuleSchema(PrimeContactInAccountLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("41844107-7e4d-4d9f-9450-654c0ae6bb86");
			Name = "PrimeContactInAccountLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d5fe5418-b108-401a-ba83-ff1213a966db");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,81,107,219,64,12,199,159,83,232,119,16,222,139,3,193,126,79,147,64,27,74,9,172,35,91,219,189,95,207,178,115,96,223,101,186,187,12,19,246,221,39,159,47,198,241,54,214,144,23,201,210,79,127,253,117,90,52,104,143,66,34,188,34,145,176,166,116,217,214,232,82,85,158,132,83,70,223,222,156,111,111,102,222,42,93,193,75,107,29,54,119,67,60,110,33,252,87,62,123,212,78,57,133,150,11,184,36,207,115,88,89,223,52,130,218,77,140,183,181,176,118,1,71,50,39,85,160,133,90,232,202,139,10,23,80,146,105,64,72,105,188,118,217,165,59,31,181,31,253,123,173,36,200,142,0,123,82,13,178,124,39,164,219,233,251,190,237,115,132,125,243,53,194,18,30,132,197,113,138,25,231,32,108,246,137,176,226,141,129,1,214,145,151,206,144,93,194,62,12,232,43,166,218,123,241,132,194,177,104,197,93,66,179,147,166,228,34,68,144,132,229,58,185,204,218,233,40,108,60,60,201,55,217,0,206,167,228,213,81,144,104,64,243,141,214,137,183,72,76,208,40,187,179,36,155,55,142,65,14,137,108,149,135,234,208,28,77,249,175,29,233,219,21,20,174,103,204,59,212,108,9,239,236,88,58,249,4,103,248,21,93,67,93,244,198,93,187,248,140,238,96,138,143,24,184,159,158,29,56,226,55,83,42,222,112,250,0,62,98,85,44,223,21,201,38,46,13,29,207,181,35,240,149,95,129,160,244,1,73,185,194,72,200,199,46,154,19,63,103,110,132,39,175,10,120,194,193,193,93,145,134,212,48,142,93,9,150,157,4,1,218,31,176,6,141,63,33,60,255,246,69,30,176,17,95,61,82,59,113,61,27,23,60,11,205,100,90,64,18,149,39,243,187,129,121,241,103,107,106,223,232,47,188,43,143,224,65,217,125,81,244,185,52,233,110,206,198,196,171,103,23,173,25,155,49,207,186,150,30,215,207,188,72,119,49,236,105,188,98,31,79,132,46,70,155,246,148,176,126,61,216,193,253,215,192,14,245,218,30,49,170,251,46,106,143,171,174,105,147,254,185,75,100,18,58,79,122,68,13,233,191,63,54,206,242,159,127,191,1,86,81,25,114,199,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("41844107-7e4d-4d9f-9450-654c0ae6bb86"));
		}

		#endregion

	}

	#endregion

}

