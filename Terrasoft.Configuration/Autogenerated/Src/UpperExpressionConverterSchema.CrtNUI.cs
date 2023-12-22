namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpperExpressionConverterSchema

	/// <exclude/>
	public class UpperExpressionConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpperExpressionConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpperExpressionConverterSchema(UpperExpressionConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("610a8b86-38e8-423a-9fde-cc03471e6042");
			Name = "UpperExpressionConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("75f7d434-56de-4d62-8a8c-9fe090e3ebb1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,77,143,155,48,16,61,19,41,255,97,228,94,64,93,65,115,205,102,169,86,81,42,69,234,151,148,236,105,213,131,3,19,66,5,6,141,199,105,163,213,254,247,26,27,16,155,77,185,32,191,121,239,205,60,123,148,172,81,183,50,67,216,35,145,212,205,145,227,117,163,142,101,97,72,114,217,168,249,236,101,62,11,140,46,85,1,187,139,102,172,239,231,51,139,124,32,44,108,25,214,149,212,122,9,79,109,139,180,249,219,18,106,109,97,107,113,70,98,36,199,77,146,4,86,218,212,181,164,75,218,159,157,0,50,169,17,52,83,231,142,163,26,178,65,14,89,103,31,15,30,201,196,228,249,70,183,71,182,86,7,195,24,10,231,47,162,95,150,217,154,67,85,102,222,234,191,131,194,18,182,183,96,171,127,113,33,198,196,223,144,79,77,110,51,255,116,190,190,120,29,209,1,189,139,30,18,158,101,101,48,30,233,201,53,127,213,74,146,53,40,251,38,15,194,145,69,186,155,74,87,137,99,220,22,72,42,76,141,138,181,72,225,49,207,203,238,245,100,5,35,252,94,77,200,134,148,78,135,180,249,155,65,129,27,48,227,43,89,245,64,239,244,253,157,246,252,77,39,144,246,218,155,195,111,204,216,235,239,134,234,56,1,60,128,16,17,116,11,21,4,125,209,254,44,28,250,83,228,132,247,174,94,30,7,52,222,234,239,166,170,126,208,166,110,249,210,129,209,96,18,248,153,58,23,175,122,245,222,127,74,206,78,16,142,157,71,190,91,56,241,165,36,205,235,147,36,177,4,143,79,140,226,157,57,248,198,225,167,59,88,68,241,190,113,75,179,85,103,73,165,84,28,70,240,209,205,22,127,69,85,240,9,82,88,192,231,43,233,34,178,27,101,211,250,177,130,28,143,210,84,124,171,221,123,251,73,148,215,126,247,80,229,126,253,220,217,163,111,65,139,77,190,127,170,7,159,150,216,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("610a8b86-38e8-423a-9fde-cc03471e6042"));
		}

		#endregion

	}

	#endregion

}

