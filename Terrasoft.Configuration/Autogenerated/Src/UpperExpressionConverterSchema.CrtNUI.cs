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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,77,139,219,48,16,61,59,144,255,48,168,23,155,46,118,115,205,102,93,150,144,66,160,95,144,237,169,244,160,216,19,71,197,150,205,104,148,54,44,251,223,43,75,182,201,102,83,95,140,222,188,247,102,158,52,90,54,104,58,89,32,60,33,145,52,237,129,211,117,171,15,170,178,36,89,181,122,62,123,158,207,34,107,148,174,96,119,54,140,205,253,124,230,144,119,132,149,43,195,186,150,198,44,225,71,215,33,109,254,118,132,198,56,216,89,156,144,24,201,115,179,44,131,149,177,77,35,233,156,15,103,47,128,66,26,4,195,212,187,227,164,134,98,148,67,209,219,167,163,71,118,97,242,243,70,183,71,118,86,123,203,24,11,239,47,146,95,142,217,217,125,173,138,96,245,223,65,97,9,219,91,176,211,63,251,16,83,226,47,200,199,182,116,153,191,123,223,80,188,142,232,129,193,197,140,9,79,178,182,152,78,244,236,154,191,234,36,201,6,180,123,147,7,225,201,34,223,93,74,87,153,103,220,22,72,170,108,131,154,141,200,225,177,44,85,255,122,178,134,9,126,171,38,100,75,218,228,99,218,242,213,160,192,45,216,233,149,156,122,164,247,250,225,78,7,254,166,23,72,119,237,237,254,55,22,28,244,119,99,117,154,0,30,64,136,4,250,133,138,162,161,232,126,14,142,195,41,241,194,123,95,87,135,17,77,183,230,171,173,235,111,180,105,58,62,247,96,50,154,68,97,166,222,37,168,94,130,247,31,197,197,17,226,169,243,196,247,11,39,62,41,50,188,62,74,18,75,8,248,133,81,186,179,251,208,56,254,112,7,139,36,125,106,253,210,108,245,73,146,146,154,227,4,222,251,217,210,207,168,43,62,66,14,11,248,120,37,93,36,110,163,92,218,48,86,84,226,65,218,154,111,181,123,107,127,17,229,101,216,61,212,101,88,63,127,14,232,107,208,97,238,251,7,182,244,242,252,208,3,0,0 };
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

