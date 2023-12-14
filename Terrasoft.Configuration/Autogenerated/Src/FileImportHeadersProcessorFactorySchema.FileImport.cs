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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,93,75,195,48,20,125,158,224,127,184,244,169,133,209,190,187,15,208,233,116,47,34,108,62,137,15,49,189,221,2,109,82,110,146,73,145,253,119,147,118,117,118,163,20,180,148,180,73,238,57,247,228,220,27,201,10,212,37,227,8,27,36,98,90,101,38,94,40,153,137,173,37,102,132,146,241,82,228,184,42,74,69,6,190,174,175,70,86,11,185,237,4,19,78,122,214,227,7,105,132,17,168,123,3,150,140,27,69,77,132,139,73,146,4,166,218,22,5,163,106,222,206,133,220,33,9,147,42,14,156,48,155,5,171,147,164,39,100,41,146,126,33,197,81,107,69,13,95,21,36,45,218,237,236,69,138,192,115,166,53,100,138,60,7,51,8,187,26,9,101,139,108,179,37,191,210,191,221,99,198,108,110,238,132,76,157,248,208,84,37,170,44,28,206,31,141,225,217,25,11,51,144,238,227,32,195,136,232,221,37,44,237,71,46,248,81,236,32,230,6,134,149,212,53,115,239,133,181,255,244,246,210,172,86,252,37,195,194,59,238,156,127,68,243,67,22,190,106,36,215,104,18,185,239,50,176,157,233,24,234,206,169,214,124,135,5,3,82,202,52,191,81,125,158,209,104,207,232,12,114,75,91,237,253,198,79,112,139,218,144,245,106,221,170,45,80,154,48,232,70,7,227,51,120,52,169,121,69,6,225,41,91,220,20,113,6,193,186,210,27,98,82,231,245,157,8,90,25,35,66,99,73,194,194,23,236,232,79,236,142,57,237,198,247,123,58,15,47,79,113,148,114,168,199,190,4,199,206,252,11,179,39,62,248,235,230,6,255,124,3,3,39,41,82,3,4,0,0 };
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

