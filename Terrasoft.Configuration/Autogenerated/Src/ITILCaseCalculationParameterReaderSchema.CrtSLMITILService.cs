namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITILCaseCalculationParameterReaderSchema

	/// <exclude/>
	public class ITILCaseCalculationParameterReaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITILCaseCalculationParameterReaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITILCaseCalculationParameterReaderSchema(ITILCaseCalculationParameterReaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b6eb7ae2-e22e-4845-925b-505d5771ca69");
			Name = "ITILCaseCalculationParameterReader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5be0374d-f3b5-4c63-b887-7fd46e962c93");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,84,223,107,219,48,16,126,118,161,255,195,225,190,164,80,236,247,252,130,145,173,37,144,177,208,102,79,101,15,170,124,78,5,142,100,78,114,70,54,246,191,239,36,219,169,211,101,14,13,125,104,18,8,58,221,247,233,190,239,78,210,98,131,182,20,18,97,133,68,194,154,220,37,51,163,115,181,174,72,56,101,244,229,197,239,203,139,168,178,74,175,225,97,103,29,110,120,191,40,80,250,77,155,220,161,70,82,114,180,207,233,210,16,254,47,158,220,10,233,12,41,180,156,225,191,81,154,166,48,182,213,102,35,104,55,109,214,183,134,54,22,74,65,92,164,67,178,144,27,130,153,176,248,69,59,218,45,141,210,174,69,166,29,232,227,183,45,31,166,50,252,193,139,178,122,42,148,4,89,8,107,97,190,154,47,60,126,38,10,89,21,65,223,178,101,191,71,145,33,13,161,127,159,25,189,31,209,21,225,154,119,129,189,178,142,42,47,198,14,97,25,14,11,122,254,17,20,2,115,173,156,18,133,250,133,22,4,104,252,9,138,241,66,179,255,38,7,247,140,12,65,4,73,152,79,226,211,213,198,233,180,86,150,236,79,236,26,209,138,63,77,52,184,134,32,235,207,199,169,61,68,66,239,65,51,110,18,87,22,137,237,214,245,232,197,211,21,159,232,99,32,247,193,100,156,6,196,27,197,127,63,96,134,195,131,174,61,87,52,132,39,230,24,188,218,58,48,237,10,117,86,79,69,179,110,70,228,43,186,103,147,249,233,32,227,24,136,89,143,201,119,232,160,80,214,121,75,131,148,122,232,229,75,241,125,118,17,186,138,180,157,46,250,25,198,105,155,24,124,106,203,2,211,220,27,248,172,130,62,230,30,243,116,243,245,189,129,250,127,234,11,12,246,217,151,156,118,120,162,30,24,161,173,10,7,147,96,99,114,148,100,20,56,234,196,228,83,150,13,226,7,164,173,146,184,228,183,34,153,103,241,13,116,35,28,56,6,169,202,210,144,91,224,22,139,22,211,9,117,65,222,129,166,174,209,169,217,191,175,253,218,183,166,227,230,235,247,73,122,129,111,232,209,113,170,78,143,162,179,154,212,60,147,202,237,222,165,93,125,116,189,141,59,163,111,103,181,173,123,251,124,140,127,252,249,11,57,234,194,134,223,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b6eb7ae2-e22e-4845-925b-505d5771ca69"));
		}

		#endregion

	}

	#endregion

}

