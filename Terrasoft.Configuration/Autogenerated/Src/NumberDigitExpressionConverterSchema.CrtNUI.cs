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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,75,107,219,64,16,62,59,144,255,48,149,47,18,152,85,207,137,227,18,84,215,248,208,52,96,223,66,15,107,105,44,111,145,118,197,62,210,186,33,255,189,179,187,146,136,31,80,131,45,207,55,243,125,243,148,228,45,154,142,151,8,91,212,154,27,181,183,172,80,114,47,106,167,185,21,74,222,222,188,221,222,76,156,17,178,134,205,209,88,108,239,207,108,182,106,212,142,55,226,111,136,191,240,110,15,26,121,69,0,121,200,55,213,88,83,24,20,13,55,230,14,158,92,187,67,253,85,212,194,46,255,116,26,141,33,39,21,240,138,218,162,14,140,60,207,97,110,92,219,114,125,92,244,118,164,65,229,121,128,35,17,202,129,9,165,215,103,3,61,255,192,127,185,146,232,209,90,45,118,206,98,154,124,168,40,201,126,82,124,231,118,141,40,163,224,127,234,133,59,88,95,131,73,229,45,244,50,182,255,29,237,65,85,52,128,231,160,30,157,231,157,6,96,131,29,167,85,160,1,98,56,195,101,101,224,183,176,7,144,113,6,181,86,174,3,19,163,148,102,163,80,126,174,52,247,33,45,72,90,249,67,242,202,27,135,201,162,31,100,176,216,60,15,17,215,9,92,215,174,69,105,77,178,128,199,170,18,126,217,188,129,17,190,100,107,180,78,75,179,24,230,80,13,85,250,127,52,111,186,145,33,239,16,234,185,253,188,251,136,165,15,33,74,170,118,191,176,180,145,49,27,188,99,118,120,128,4,146,12,252,177,78,38,21,150,162,165,226,232,121,31,0,177,135,244,83,143,178,173,62,62,115,109,48,77,163,74,214,107,42,103,61,35,27,84,38,177,170,62,23,91,182,157,61,70,185,247,240,27,103,247,77,233,150,219,181,220,43,160,215,134,234,56,135,217,10,233,105,44,151,37,166,241,109,96,133,211,154,202,62,181,10,215,80,62,204,88,209,40,137,105,6,220,92,136,197,252,148,136,69,207,202,111,127,51,44,159,178,247,197,174,205,147,107,154,31,58,20,157,142,99,202,224,139,159,19,221,233,8,69,197,190,85,106,159,109,213,38,104,164,201,116,58,157,157,126,63,179,51,44,153,249,174,51,154,169,104,211,44,104,189,247,151,142,178,138,199,30,236,136,158,130,132,249,207,63,243,6,234,164,132,4,0,0 };
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

