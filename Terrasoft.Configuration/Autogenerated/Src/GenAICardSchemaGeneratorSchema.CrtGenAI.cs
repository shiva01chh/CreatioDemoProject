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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,84,77,107,219,64,16,61,59,144,255,48,77,47,50,132,37,231,4,31,28,37,14,58,184,132,38,62,133,80,54,210,200,89,144,119,197,236,42,212,24,255,247,206,238,74,169,45,36,19,10,245,193,246,124,190,55,111,70,2,45,55,104,107,153,35,60,35,145,180,166,116,34,53,186,84,235,134,164,83,70,139,7,212,243,236,252,12,118,231,103,147,198,42,189,62,202,36,188,25,241,139,121,93,87,42,15,77,172,152,191,89,71,50,143,70,74,24,220,163,165,11,206,52,164,208,114,6,231,124,39,92,115,58,100,218,33,149,76,246,26,178,64,43,149,84,60,229,239,184,145,108,34,19,54,20,10,234,230,141,161,65,117,249,167,210,39,187,80,242,9,178,68,247,110,10,123,13,143,161,73,12,126,24,85,64,91,132,190,141,77,14,198,107,3,252,239,39,218,166,114,144,27,70,214,174,239,191,4,22,193,143,43,235,58,53,5,78,111,90,104,212,69,68,15,246,62,14,125,236,236,232,165,149,180,76,238,228,248,47,119,88,74,198,187,85,186,96,184,196,109,107,52,101,50,42,194,116,250,250,87,180,220,3,140,246,135,147,210,247,181,228,75,178,78,106,231,213,36,245,193,218,197,120,29,13,175,147,117,157,40,143,114,141,63,248,28,159,113,83,87,62,58,131,139,221,213,254,215,194,208,198,199,46,134,213,26,88,220,16,84,11,242,128,174,195,73,122,203,8,23,62,153,180,94,255,96,48,131,104,9,207,65,186,164,79,241,242,112,147,92,171,74,72,86,22,137,231,214,24,142,93,164,13,17,159,130,72,43,197,63,43,173,92,84,109,41,53,55,35,177,224,29,101,65,165,28,111,183,129,151,135,158,194,183,25,232,166,170,58,90,147,127,34,180,15,223,132,174,33,29,70,10,238,253,87,133,60,120,2,218,235,248,79,15,66,59,228,177,118,208,28,155,51,24,214,54,142,218,23,24,240,183,178,142,65,150,82,233,123,237,148,219,122,190,48,139,114,54,189,86,95,95,207,225,9,117,252,91,185,71,198,21,79,17,197,190,92,189,10,95,27,49,86,25,179,25,161,41,56,120,98,87,67,175,8,246,249,207,31,189,85,164,119,211,5,0,0 };
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

