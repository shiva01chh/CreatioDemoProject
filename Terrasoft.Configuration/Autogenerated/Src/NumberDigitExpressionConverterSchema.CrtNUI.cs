namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NumberDigitExpressionConverterSchema

	/// <exclude/>
	public class NumberDigitExpressionConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NumberDigitExpressionConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NumberDigitExpressionConverterSchema(NumberDigitExpressionConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f1dacd9b-b93b-430e-89f3-3ee26a40f8d8");
			Name = "NumberDigitExpressionConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("75f7d434-56de-4d62-8a8c-9fe090e3ebb1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,75,111,218,64,16,62,19,41,255,97,106,46,182,132,214,61,39,132,40,162,20,113,104,26,9,110,81,15,139,61,152,141,236,93,107,31,105,105,148,255,222,217,93,219,226,37,21,9,204,124,51,223,55,79,75,222,160,105,121,129,176,65,173,185,81,59,203,230,74,238,68,229,52,183,66,201,219,155,143,219,155,145,51,66,86,176,62,24,139,205,253,153,205,150,181,218,242,90,252,13,241,23,222,205,94,35,47,9,32,15,249,198,26,43,10,131,121,205,141,185,131,103,215,108,81,127,19,149,176,139,63,173,70,99,200,73,5,188,163,182,168,3,35,207,115,152,26,215,52,92,31,102,157,29,105,80,122,30,224,64,132,162,103,66,225,245,89,79,207,143,248,175,87,18,61,89,171,197,214,89,76,147,163,138,146,236,23,197,183,110,91,139,34,10,254,167,94,184,131,213,53,152,84,62,66,47,67,251,63,208,238,85,73,3,120,9,234,209,121,222,105,0,214,216,114,90,5,26,32,134,51,92,150,6,126,11,187,7,25,103,80,105,229,90,48,49,74,105,54,8,229,231,74,83,31,210,128,164,149,63,36,239,188,118,152,204,186,65,6,139,77,243,16,113,157,192,117,229,26,148,214,36,51,120,42,75,225,151,205,107,24,224,75,182,70,235,180,52,179,126,14,101,95,165,255,71,243,166,27,233,243,246,161,158,219,205,187,139,88,248,16,162,164,106,251,134,133,141,140,73,239,29,178,195,3,36,144,100,224,143,117,52,42,177,16,13,21,71,207,251,0,136,29,164,95,58,148,109,244,225,133,107,131,105,26,85,178,78,83,57,235,25,89,175,50,138,85,117,185,216,162,105,237,33,202,125,134,223,56,187,239,74,55,220,174,228,78,1,189,54,84,199,57,204,150,72,79,99,185,44,48,141,111,3,155,59,173,169,236,83,107,238,106,202,135,25,155,215,74,98,154,1,55,23,98,49,63,37,98,209,179,244,219,95,247,203,167,236,93,177,43,243,236,234,250,167,14,69,167,195,152,50,120,244,115,162,59,29,160,168,216,181,74,237,179,141,90,7,141,52,25,143,199,147,211,239,87,118,134,37,19,223,117,70,51,21,77,154,5,173,207,238,210,81,150,241,216,131,29,209,83,144,176,227,207,63,47,228,229,227,140,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f1dacd9b-b93b-430e-89f3-3ee26a40f8d8"));
		}

		#endregion

	}

	#endregion

}

