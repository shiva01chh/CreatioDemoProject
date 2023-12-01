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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,209,106,194,48,20,125,110,193,127,184,116,47,10,210,190,187,90,16,149,225,96,48,80,159,198,30,174,233,181,102,164,137,36,169,232,100,255,190,52,85,187,138,236,45,185,231,230,156,123,79,14,72,44,201,236,145,17,172,72,107,52,106,107,227,169,146,91,94,84,26,45,87,178,23,158,123,97,80,25,46,11,88,158,140,165,210,225,66,16,171,65,19,191,144,36,205,217,243,173,231,47,141,38,87,119,200,147,166,194,117,195,84,160,49,35,88,239,133,194,124,98,45,178,93,73,210,154,25,90,156,31,137,85,86,105,255,96,95,109,4,103,192,234,254,255,219,97,4,139,87,181,105,95,7,103,207,112,211,124,35,187,83,185,83,125,247,156,13,152,36,9,164,166,42,75,212,167,236,90,104,56,200,0,29,217,14,101,65,64,37,114,1,216,42,67,238,164,193,156,36,219,105,37,249,183,119,40,190,49,38,247,148,233,30,53,150,80,155,60,142,42,67,218,89,43,27,235,162,44,53,68,192,52,109,199,209,186,11,37,25,112,105,44,74,70,113,154,120,142,199,148,254,76,150,180,137,178,101,119,170,251,41,161,95,235,95,87,202,115,77,206,90,178,44,30,116,36,46,206,31,184,182,21,10,56,40,158,95,141,233,119,167,132,238,62,67,88,204,184,63,57,3,82,99,181,11,195,16,212,230,203,193,25,180,131,14,160,206,83,16,204,47,38,175,45,23,220,158,226,135,191,220,191,215,104,121,62,188,105,243,122,157,73,179,77,244,25,175,212,210,11,247,7,131,58,145,193,207,37,11,36,243,38,14,254,222,84,187,69,95,235,133,97,248,11,42,198,134,235,18,3,0,0 };
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

