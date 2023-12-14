namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportHeadersProcessorSchema

	/// <exclude/>
	public class IFileImportHeadersProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportHeadersProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportHeadersProcessorSchema(IFileImportHeadersProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f6a6f9f3-e056-43f4-b54a-65bfa522f74f");
			Name = "IFileImportHeadersProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,81,221,106,195,32,20,190,110,161,239,112,200,205,54,24,201,3,44,245,38,116,91,175,59,118,111,237,177,21,162,134,115,116,80,198,222,125,106,218,38,176,53,8,65,253,206,247,167,147,22,121,144,10,225,3,137,36,123,29,234,206,59,109,142,145,100,48,222,213,175,166,199,173,29,60,5,248,94,45,23,145,141,59,194,238,204,1,109,66,246,61,170,12,227,250,13,29,146,81,47,55,204,156,144,176,222,184,96,130,65,206,128,180,134,184,239,141,2,227,2,146,206,250,219,73,232,29,229,1,137,59,66,25,60,21,217,5,52,77,3,45,71,107,37,157,197,237,164,96,144,193,140,14,149,239,163,117,12,58,141,13,228,21,50,227,1,78,133,239,129,225,75,246,17,185,158,248,154,63,132,237,32,73,90,112,169,151,117,69,222,135,157,58,161,149,149,104,25,17,20,161,94,87,37,202,249,114,209,8,246,145,82,0,46,251,34,173,138,171,171,155,186,109,10,233,29,145,17,245,89,172,85,98,252,131,38,111,65,167,70,254,25,38,12,145,28,139,169,125,240,26,102,254,198,22,187,194,155,252,181,205,117,34,115,108,55,46,90,36,185,239,177,157,3,197,165,203,177,252,241,140,31,231,81,97,170,227,57,51,221,165,42,25,4,204,131,61,229,103,255,89,45,211,90,45,243,247,11,228,148,170,238,121,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f6a6f9f3-e056-43f4-b54a-65bfa522f74f"));
		}

		#endregion

	}

	#endregion

}

