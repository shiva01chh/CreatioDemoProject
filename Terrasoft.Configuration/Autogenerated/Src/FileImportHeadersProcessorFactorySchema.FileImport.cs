namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImportHeadersProcessorFactorySchema

	/// <exclude/>
	public class FileImportHeadersProcessorFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImportHeadersProcessorFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImportHeadersProcessorFactorySchema(FileImportHeadersProcessorFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f308309d-78f0-4eae-9765-b45ee0dd84b7");
			Name = "FileImportHeadersProcessorFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,93,75,195,48,20,125,174,224,127,184,244,169,133,209,190,187,15,208,233,116,47,34,108,62,137,15,49,189,221,2,109,82,110,146,73,145,253,119,211,47,103,55,74,65,75,73,155,228,158,115,79,206,189,145,44,71,93,48,142,176,69,34,166,85,106,162,165,146,169,216,89,98,70,40,25,173,68,134,235,188,80,100,224,235,250,202,179,90,200,93,47,152,112,58,176,30,61,72,35,140,64,61,24,176,98,220,40,106,34,92,76,28,199,48,211,54,207,25,149,139,110,46,228,30,73,152,68,113,224,132,233,220,95,159,36,61,33,75,144,244,11,41,142,90,43,106,248,74,63,238,208,110,231,32,18,4,158,49,173,33,85,84,113,48,131,176,175,145,80,116,200,46,91,252,43,253,219,61,166,204,102,230,78,200,196,137,15,76,89,160,74,131,241,252,225,4,158,157,177,48,7,233,62,14,50,142,8,223,93,194,194,126,100,130,183,98,71,49,55,48,174,164,174,153,123,47,172,253,167,183,151,102,117,226,47,25,150,149,227,206,249,71,52,63,100,193,171,70,114,141,38,145,87,93,6,182,55,157,64,221,57,229,134,239,49,103,64,74,153,230,55,172,207,227,121,7,70,103,144,91,218,233,202,111,252,4,183,168,13,217,74,173,91,181,57,74,19,248,253,104,127,114,6,15,167,53,175,72,33,56,101,139,154,34,206,193,223,148,122,75,76,234,172,190,19,126,39,195,35,52,150,36,44,171,130,181,254,68,238,152,179,126,252,176,167,139,224,242,20,173,148,99,61,14,37,104,59,243,47,204,21,241,177,186,110,110,112,207,55,159,69,175,78,2,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f308309d-78f0-4eae-9765-b45ee0dd84b7"));
		}

		#endregion

	}

	#endregion

}

