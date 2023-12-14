namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UploadAttachmentsDataExecutorSchema

	/// <exclude/>
	public class UploadAttachmentsDataExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UploadAttachmentsDataExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UploadAttachmentsDataExecutorSchema(UploadAttachmentsDataExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2e5d4ef8-77c1-49cb-9a08-7abb85fd5ce3");
			Name = "UploadAttachmentsDataExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,193,106,194,64,16,61,71,240,31,134,244,98,64,146,187,141,1,81,41,22,10,5,245,84,122,24,55,163,110,217,236,202,238,70,76,165,255,222,205,70,77,35,210,156,54,239,205,190,55,243,118,64,98,65,230,128,140,96,69,90,163,81,91,27,79,149,220,242,93,169,209,114,37,251,189,115,191,23,148,134,203,29,44,43,99,169,112,188,16,196,106,210,196,47,36,73,115,246,124,171,249,43,163,201,225,142,121,210,180,115,213,48,21,104,204,8,214,7,161,48,159,88,139,108,95,144,180,102,134,22,231,39,98,165,85,218,95,56,148,27,193,25,176,186,254,255,114,24,193,226,85,109,218,219,193,217,43,220,60,223,200,238,85,238,92,223,189,102,67,38,73,2,169,41,139,2,117,149,93,129,70,131,12,208,137,237,81,238,8,168,64,46,0,91,103,200,157,53,152,74,178,189,86,146,127,251,132,226,155,98,114,47,153,30,80,99,1,117,200,227,176,52,164,93,180,178,137,46,204,82,67,4,76,211,118,28,174,187,84,146,1,151,198,162,100,20,167,137,215,120,44,233,207,100,73,155,48,91,118,187,186,239,18,6,181,255,117,164,60,215,228,162,37,203,226,168,99,113,73,254,200,181,45,81,192,81,241,252,26,204,160,219,37,116,231,25,194,98,198,253,201,5,144,26,171,221,50,12,65,109,190,28,157,65,219,104,4,245,62,5,193,252,18,242,218,114,193,109,21,63,124,229,193,189,71,171,243,225,67,155,215,227,76,154,105,194,207,120,165,150,222,120,16,69,245,70,6,63,151,93,32,153,55,235,224,255,27,180,11,122,172,223,115,223,47,131,73,135,233,19,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2e5d4ef8-77c1-49cb-9a08-7abb85fd5ce3"));
		}

		#endregion

	}

	#endregion

}

