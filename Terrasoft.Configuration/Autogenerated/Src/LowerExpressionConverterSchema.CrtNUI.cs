namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LowerExpressionConverterSchema

	/// <exclude/>
	public class LowerExpressionConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LowerExpressionConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LowerExpressionConverterSchema(LowerExpressionConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b69b03e9-3983-48ee-b50b-7df2ea273c76");
			Name = "LowerExpressionConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("75f7d434-56de-4d62-8a8c-9fe090e3ebb1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,77,107,194,64,16,61,71,240,63,12,241,98,160,36,119,181,130,136,7,161,95,160,183,210,195,154,140,105,74,178,9,179,187,182,82,252,239,157,221,100,83,181,54,144,132,121,243,222,219,249,88,41,42,84,141,72,17,182,72,36,84,189,215,241,178,150,251,34,55,36,116,81,203,225,224,123,56,8,140,42,100,14,155,163,210,88,77,135,3,70,70,132,57,167,97,89,10,165,38,240,80,127,34,173,190,26,66,165,24,102,139,3,146,70,178,92,102,39,73,2,51,101,170,74,208,113,222,197,78,2,169,80,8,74,147,245,199,94,15,169,55,128,212,30,16,123,143,228,204,228,245,198,121,11,205,86,59,163,113,28,58,255,48,122,99,102,99,118,101,145,182,86,255,150,10,19,88,223,130,89,111,71,16,216,215,119,253,136,250,189,206,184,239,23,231,236,211,215,109,58,160,115,82,190,203,131,40,13,198,61,61,185,230,207,26,65,162,2,201,155,185,15,29,57,156,111,206,165,179,196,49,110,11,4,229,166,66,169,85,56,135,69,150,21,118,135,162,132,30,254,171,38,212,134,164,154,251,142,179,139,66,65,215,80,246,155,98,181,167,91,125,55,215,142,191,178,2,193,163,175,119,31,152,234,86,127,231,179,125,5,112,15,97,24,129,155,105,208,37,249,199,240,184,141,34,39,156,186,124,177,247,104,188,86,79,166,44,159,105,85,53,250,104,193,200,155,4,109,77,214,165,85,157,220,247,23,141,183,181,219,250,90,30,4,21,66,234,113,228,136,39,119,57,131,17,202,172,93,172,139,91,244,18,100,140,159,31,116,239,85,160,46,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b69b03e9-3983-48ee-b50b-7df2ea273c76"));
		}

		#endregion

	}

	#endregion

}

