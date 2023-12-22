namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFullPipelineDataRetrieverSchema

	/// <exclude/>
	public class IFullPipelineDataRetrieverSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFullPipelineDataRetrieverSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFullPipelineDataRetrieverSchema(IFullPipelineDataRetrieverSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bab0b7d8-fd3f-4488-b7c0-eec4053f33c3");
			Name = "IFullPipelineDataRetriever";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eccc4091-3404-497f-94e5-8c10d0f3a0d7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,146,77,110,194,48,16,133,215,32,113,135,81,186,105,55,241,30,66,54,45,173,88,84,66,148,11,152,100,18,44,57,118,52,182,169,16,234,221,235,56,9,184,180,197,59,207,207,167,247,158,173,120,131,166,229,5,194,14,137,184,209,149,77,159,181,170,68,237,136,91,161,213,108,122,158,77,39,206,8,85,195,199,201,88,108,124,95,74,44,186,166,73,223,80,33,137,98,49,155,250,169,7,194,218,87,97,173,44,82,229,161,115,88,191,58,41,55,162,69,41,20,190,112,203,183,104,73,224,17,41,108,48,198,32,51,174,105,56,157,242,225,190,33,125,20,37,26,16,35,6,116,5,212,239,113,9,149,39,66,59,32,161,244,204,116,36,177,8,213,186,189,20,69,4,185,39,101,114,14,114,46,14,222,209,30,116,105,230,176,9,148,190,121,43,54,20,70,200,69,200,111,37,125,165,229,196,27,80,62,239,101,50,170,95,41,43,236,169,207,219,36,249,238,128,87,99,24,122,80,196,143,97,210,140,5,206,21,235,115,113,164,76,126,125,148,46,173,204,32,66,65,88,45,147,216,245,86,127,38,44,207,216,184,212,81,214,43,229,26,36,190,151,152,221,204,230,16,199,244,248,223,100,236,34,135,63,189,61,45,134,124,81,149,125,196,225,254,213,127,155,31,69,95,139,207,55,242,184,13,226,161,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bab0b7d8-fd3f-4488-b7c0-eec4053f33c3"));
		}

		#endregion

	}

	#endregion

}

