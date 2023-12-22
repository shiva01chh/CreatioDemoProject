namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationServiceResponseSchema

	/// <exclude/>
	public class TranslationServiceResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationServiceResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationServiceResponseSchema(TranslationServiceResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5fe50c86-213a-4ba1-9a12-4686b15dab3c");
			Name = "TranslationServiceResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2c48a34f-0c95-44d9-a69e-4bfc769a17b3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,82,201,110,194,48,16,61,7,137,127,176,232,133,92,242,1,208,246,194,82,85,42,85,5,220,170,170,114,204,144,90,114,236,104,108,211,5,245,223,59,89,64,9,148,8,68,78,241,120,222,50,207,163,121,10,54,227,2,216,18,16,185,53,107,23,141,140,94,203,196,35,119,210,232,104,137,92,91,85,252,119,59,219,110,39,240,86,234,132,45,190,173,131,116,120,112,38,172,82,32,242,102,27,61,128,6,148,226,168,103,238,181,147,41,68,11,186,229,74,254,20,220,212,69,125,55,8,9,29,216,72,113,107,7,172,166,77,205,27,41,96,78,110,137,27,138,238,215,49,119,156,220,58,228,194,189,81,33,243,177,146,130,137,28,221,2,102,3,214,152,241,136,59,216,22,252,123,59,83,9,106,69,126,94,80,110,184,43,197,75,245,25,164,49,96,255,153,98,100,119,172,103,50,40,41,159,76,210,11,115,75,65,86,98,216,227,68,251,148,110,99,5,183,214,33,229,113,207,222,235,253,195,74,19,244,170,148,109,122,32,199,4,243,194,25,60,116,178,147,56,61,113,63,100,249,211,5,191,103,3,38,95,2,178,252,130,65,72,121,197,156,106,112,49,203,127,67,215,103,174,8,131,70,16,20,228,65,46,123,201,83,225,204,192,125,152,226,133,138,13,168,252,149,219,96,29,49,137,182,117,24,33,208,28,11,47,4,88,75,85,175,220,46,176,0,193,121,212,76,195,103,107,188,117,147,87,233,158,155,216,121,190,26,200,43,60,78,185,84,30,161,242,216,216,141,75,236,64,216,242,152,101,181,89,44,106,181,239,15,172,80,216,66,175,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5fe50c86-213a-4ba1-9a12-4686b15dab3c"));
		}

		#endregion

	}

	#endregion

}

