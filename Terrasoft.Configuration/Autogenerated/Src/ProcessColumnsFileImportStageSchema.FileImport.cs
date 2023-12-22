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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,77,111,212,48,16,61,167,82,255,195,168,92,178,162,77,238,187,221,162,118,187,21,145,0,85,2,78,136,131,27,79,82,75,137,29,141,109,68,181,226,191,51,137,147,118,179,93,140,32,151,248,227,205,60,191,247,70,139,22,109,39,74,132,47,72,36,172,169,92,182,49,186,82,181,39,225,148,209,217,157,106,176,104,59,67,238,244,100,119,122,146,120,171,116,61,67,19,174,254,112,158,221,137,210,25,82,104,25,193,152,55,132,53,247,4,216,52,194,218,37,220,147,41,209,218,141,105,124,171,237,11,211,103,39,106,28,42,242,60,135,75,165,31,145,148,147,166,132,146,176,90,159,221,8,139,7,232,179,252,106,130,91,223,182,130,158,166,253,246,39,150,222,33,116,129,12,202,192,54,161,243,61,248,183,91,172,132,111,220,141,210,146,213,164,238,169,67,83,165,197,17,190,197,57,124,98,239,96,13,154,127,12,138,106,89,44,190,115,251,206,63,52,138,53,244,226,227,218,97,9,71,56,185,197,110,112,229,217,72,142,202,58,242,189,201,189,157,67,255,128,24,185,162,44,233,87,139,196,45,52,150,125,212,224,103,219,243,190,77,146,20,99,237,117,93,51,169,96,166,107,41,58,135,52,25,57,82,24,90,132,130,37,60,240,211,211,131,102,175,209,176,131,95,163,26,212,50,8,154,171,99,108,135,228,120,124,230,218,254,113,40,38,47,204,15,30,78,37,17,14,80,118,171,125,11,195,178,144,176,190,58,122,159,69,157,92,197,133,124,68,247,104,100,24,120,199,134,160,252,79,33,83,121,92,203,59,40,52,7,164,69,51,62,58,13,136,123,65,60,171,124,99,161,123,94,114,14,67,110,155,131,124,38,193,91,34,67,240,118,13,161,199,7,83,215,72,217,123,161,101,131,195,221,42,90,158,238,49,197,145,129,232,226,111,68,132,206,147,142,102,180,213,78,245,83,243,58,164,36,57,62,114,225,116,126,56,156,237,127,191,1,20,89,173,108,44,5,0,0 };
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

