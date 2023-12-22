namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GenAICardSchemaGeneratorSchema

	/// <exclude/>
	public class GenAICardSchemaGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GenAICardSchemaGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GenAICardSchemaGeneratorSchema(GenAICardSchemaGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6cbc09fe-7a42-47c9-aeda-e4c59cd9ad7d");
			Name = "GenAICardSchemaGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ecaffa2e-7d24-4fa3-bf71-1610bb70ac02");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,84,77,107,227,48,16,61,187,208,255,48,219,189,56,80,68,207,45,57,164,110,83,124,200,82,182,205,169,148,69,181,199,169,192,145,132,36,151,13,33,255,125,71,146,221,117,140,29,202,194,230,144,100,62,223,155,55,99,131,228,91,180,154,23,8,207,104,12,183,170,114,44,83,178,18,155,198,112,39,148,100,15,40,23,249,249,25,236,207,207,146,198,10,185,57,202,52,120,51,225,103,11,173,107,81,132,38,150,45,222,172,51,188,136,70,102,48,184,39,75,151,148,169,140,64,75,25,148,243,221,224,134,210,33,151,14,77,69,100,175,33,15,180,50,110,202,167,226,29,183,156,76,36,194,202,132,2,221,188,17,52,136,46,255,84,122,178,15,37,159,32,43,116,239,170,180,215,240,24,154,196,224,135,18,37,180,69,232,219,216,180,55,94,27,160,127,63,209,54,181,131,66,17,178,116,67,255,37,144,8,126,92,174,117,166,74,156,221,180,208,40,203,136,30,236,67,28,250,216,217,209,203,106,110,137,220,201,241,95,238,176,226,132,119,43,100,73,112,169,219,105,84,85,58,41,194,108,246,250,87,180,194,3,76,246,135,147,210,15,181,164,75,178,142,75,231,213,52,226,131,180,139,113,29,13,175,147,117,157,40,143,124,131,63,232,28,159,113,171,107,31,157,195,197,254,234,240,107,169,204,214,199,46,198,213,26,89,220,24,84,11,242,128,174,195,73,7,203,8,23,158,36,173,215,63,24,196,32,90,204,115,224,46,29,82,188,236,111,146,106,69,5,233,218,162,161,185,37,134,99,103,89,99,12,157,2,203,106,65,63,107,41,92,84,109,197,37,53,51,108,73,59,202,131,74,5,222,238,2,47,15,61,131,111,115,144,77,93,119,180,146,127,34,116,8,223,6,93,99,100,24,41,184,15,95,21,178,247,4,180,215,241,159,30,132,118,200,99,237,160,57,54,231,48,174,109,28,117,40,48,224,111,97,29,129,172,184,144,247,210,9,183,243,124,97,30,229,108,6,173,190,190,158,254,9,117,252,91,185,39,198,101,79,17,197,190,92,189,50,95,27,49,214,57,177,153,160,201,40,120,98,87,99,175,8,242,245,63,127,0,79,169,200,54,219,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6cbc09fe-7a42-47c9-aeda-e4c59cd9ad7d"));
		}

		#endregion

	}

	#endregion

}

