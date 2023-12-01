namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportHeadersProcessorFactorySchema

	/// <exclude/>
	public class IFileImportHeadersProcessorFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportHeadersProcessorFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportHeadersProcessorFactorySchema(IFileImportHeadersProcessorFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0f82a9d-1f0d-4e82-bc54-fa38907c8a4f");
			Name = "IFileImportHeadersProcessorFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,207,110,194,48,12,198,207,32,241,14,86,119,217,164,137,220,71,233,5,141,141,195,36,36,198,3,100,193,45,145,104,82,217,206,1,77,188,251,210,240,175,221,64,90,79,141,243,249,247,57,159,157,174,145,27,109,16,62,145,72,179,47,101,60,243,174,180,85,32,45,214,187,241,220,238,112,81,55,158,4,190,71,195,65,96,235,170,158,152,112,114,167,62,126,117,98,197,34,71,65,148,52,225,107,103,13,88,39,72,101,107,185,184,178,223,81,111,144,120,73,222,32,179,167,185,54,226,105,223,90,198,206,193,3,97,21,135,129,15,148,173,223,240,11,44,19,235,120,169,148,130,156,67,93,107,218,23,231,194,140,80,11,194,54,113,161,57,115,163,16,17,12,97,57,205,254,218,167,38,79,153,42,160,140,90,246,129,226,152,108,182,88,107,184,88,169,223,94,121,163,73,215,224,98,150,211,44,48,82,76,208,161,105,227,203,138,117,60,131,185,20,58,254,235,190,82,21,185,74,160,219,92,242,94,86,105,146,172,88,117,7,235,16,83,222,251,147,234,6,143,80,2,57,46,22,142,69,187,72,240,229,127,3,201,213,185,185,165,221,85,194,27,202,101,137,143,253,23,66,63,154,103,232,142,11,215,247,61,77,78,75,71,183,57,238,61,157,15,163,225,161,253,137,223,15,139,135,236,173,182,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0f82a9d-1f0d-4e82-bc54-fa38907c8a4f"));
		}

		#endregion

	}

	#endregion

}

