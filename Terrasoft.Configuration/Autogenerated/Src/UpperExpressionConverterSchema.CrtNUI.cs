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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,77,139,219,48,16,61,219,144,255,48,168,23,155,46,118,115,205,102,93,150,144,66,160,95,144,236,105,233,65,177,39,142,139,45,155,209,40,109,88,246,191,87,150,108,147,205,166,39,161,55,239,189,153,39,141,146,13,234,78,230,8,59,36,146,186,61,112,178,106,213,161,42,13,73,174,90,53,11,95,102,97,96,116,165,74,216,158,53,99,115,63,11,45,242,129,176,180,101,88,213,82,235,5,60,117,29,210,250,111,71,168,181,133,173,197,9,137,145,28,55,77,83,88,106,211,52,146,206,217,112,119,2,200,165,70,208,76,189,59,78,106,200,71,57,228,189,125,50,122,164,23,38,207,55,186,61,178,181,218,27,198,72,56,127,17,255,178,204,206,236,235,42,247,86,255,29,20,22,176,185,5,91,253,139,11,49,37,254,134,124,108,11,155,249,167,243,245,197,235,136,14,24,92,244,152,240,36,107,131,201,68,79,175,249,203,78,146,108,64,217,63,121,16,142,44,178,237,165,116,153,58,198,109,129,164,210,52,168,88,139,12,30,139,162,234,127,79,214,48,193,239,213,132,108,72,233,108,76,91,188,25,20,184,5,51,253,146,85,143,244,94,63,188,233,192,95,247,2,105,159,189,221,255,198,156,189,254,110,172,78,19,192,3,8,17,67,191,80,65,48,20,237,97,225,200,223,98,39,188,119,245,234,48,162,201,70,127,55,117,253,131,214,77,199,231,30,140,71,147,192,207,212,187,120,213,171,247,254,83,113,126,132,104,234,60,241,221,194,137,47,21,105,94,29,37,137,5,120,252,194,40,217,154,189,111,28,125,186,131,121,156,236,90,183,52,27,117,146,84,73,197,81,12,31,221,108,201,87,84,37,31,33,131,57,124,190,146,206,99,187,81,54,173,31,43,40,240,32,77,205,183,218,189,183,191,136,242,58,236,30,170,194,175,159,187,123,244,45,104,177,48,252,7,119,186,22,68,207,3,0,0 };
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

