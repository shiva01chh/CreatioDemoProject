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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,77,107,194,64,16,61,71,240,63,12,233,197,128,36,119,155,6,68,165,88,40,20,212,83,233,97,220,140,201,150,205,174,236,110,68,43,253,239,221,108,252,138,72,115,218,188,55,251,222,204,219,1,137,21,153,45,50,130,37,105,141,70,109,108,60,81,114,195,139,90,163,229,74,246,123,199,126,47,168,13,151,5,44,14,198,82,229,120,33,136,53,164,137,95,73,146,230,236,249,82,115,43,163,201,225,142,121,210,84,184,106,152,8,52,102,4,171,173,80,152,143,173,69,86,86,36,173,153,162,197,217,158,88,109,149,246,23,182,245,90,112,6,172,169,255,191,28,70,48,127,83,235,235,237,224,232,21,46,158,239,100,75,149,59,215,15,175,217,146,73,146,64,106,234,170,66,125,200,206,64,171,65,6,104,207,74,148,5,1,85,200,5,224,213,25,114,103,13,230,32,89,169,149,228,63,62,161,248,162,152,220,75,166,91,212,88,65,19,242,75,88,27,210,46,90,217,70,23,102,169,33,2,166,105,243,18,174,186,84,146,1,151,198,162,100,20,167,137,215,120,44,233,207,100,73,155,48,91,116,187,186,239,18,6,141,255,121,164,60,215,228,162,37,203,226,168,99,113,74,126,199,181,173,81,192,78,241,252,28,204,160,219,37,116,231,25,194,124,202,253,201,5,144,26,171,221,50,12,65,173,191,29,157,193,181,209,8,154,125,10,130,217,41,228,149,229,130,219,67,252,240,149,7,247,30,87,157,79,31,218,172,25,103,220,78,19,126,197,75,181,240,198,131,40,106,54,50,248,61,237,2,201,188,93,7,255,223,162,93,208,99,253,222,205,247,7,83,240,255,233,27,3,0,0 };
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

