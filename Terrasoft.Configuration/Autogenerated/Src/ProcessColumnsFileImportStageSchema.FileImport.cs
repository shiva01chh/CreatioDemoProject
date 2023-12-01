namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProcessColumnsFileImportStageSchema

	/// <exclude/>
	public class ProcessColumnsFileImportStageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProcessColumnsFileImportStageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProcessColumnsFileImportStageSchema(ProcessColumnsFileImportStageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7af17616-4f9f-4644-894a-b58b57826cf5");
			Name = "ProcessColumnsFileImportStage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,77,79,220,48,16,61,7,137,255,48,162,151,172,10,201,125,151,165,130,101,81,35,181,21,82,203,9,245,96,226,73,176,148,216,209,216,174,138,86,253,239,157,196,9,144,101,235,170,205,37,254,120,51,207,239,189,209,162,69,219,137,18,225,27,18,9,107,42,151,109,140,174,84,237,73,56,101,116,118,163,26,44,218,206,144,59,62,218,29,31,37,222,42,93,207,208,132,171,63,156,103,55,162,116,134,20,90,70,48,230,29,97,205,61,1,54,141,176,118,9,183,100,74,180,118,99,26,223,106,251,194,244,213,137,26,135,138,60,207,225,92,233,71,36,229,164,41,161,36,172,214,39,87,194,226,30,250,36,191,152,224,214,183,173,160,167,105,191,253,137,165,119,8,93,32,131,50,176,77,232,252,21,252,254,26,43,225,27,119,165,180,100,53,169,123,234,208,84,105,113,128,111,113,10,95,216,59,88,131,230,31,131,162,90,22,139,239,220,190,243,15,141,98,13,189,248,184,118,88,194,1,78,110,177,27,92,121,54,146,163,178,142,124,111,114,111,231,208,63,32,70,174,40,75,122,103,145,184,133,198,178,143,26,252,108,123,218,183,73,146,98,172,189,172,107,38,21,204,116,41,69,231,144,38,35,71,10,67,139,80,176,132,7,126,122,186,215,236,45,26,118,240,107,84,131,90,6,65,115,117,140,237,144,28,143,207,92,219,63,14,197,228,133,249,193,195,169,36,194,30,202,110,181,111,97,88,22,18,214,23,7,239,179,168,147,171,184,144,207,232,30,141,12,3,239,216,16,148,255,41,100,42,143,107,249,0,133,230,128,180,104,198,71,167,1,113,43,136,103,149,111,44,116,207,75,206,97,200,109,179,151,207,36,120,75,100,8,222,175,33,244,248,100,234,26,41,251,40,180,108,112,184,91,69,203,211,87,76,113,100,32,58,251,27,17,161,243,164,163,25,109,181,83,253,212,188,13,41,73,14,143,92,56,157,31,14,103,252,253,6,194,153,98,16,35,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7af17616-4f9f-4644-894a-b58b57826cf5"));
		}

		#endregion

	}

	#endregion

}

