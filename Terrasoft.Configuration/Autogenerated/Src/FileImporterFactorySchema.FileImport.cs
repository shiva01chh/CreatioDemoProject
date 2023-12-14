namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImporterFactorySchema

	/// <exclude/>
	public class FileImporterFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImporterFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImporterFactorySchema(FileImporterFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a32b6e83-4c3b-c886-59ec-834898926b24");
			Name = "FileImporterFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,145,77,79,195,48,12,134,207,155,180,255,96,245,212,74,83,123,103,27,18,27,12,245,130,56,192,9,113,200,58,103,68,106,147,202,78,64,19,226,191,227,140,85,251,160,147,160,234,151,147,215,143,223,216,86,53,200,173,170,16,158,144,72,177,211,62,95,56,171,205,38,144,242,198,217,124,105,106,44,155,214,145,31,13,63,71,195,65,96,99,55,39,106,194,201,133,245,124,169,42,239,200,32,139,66,52,69,81,192,212,216,55,36,227,215,174,130,138,80,207,146,242,80,2,233,39,99,155,20,215,157,158,67,211,40,218,118,177,8,107,108,208,122,6,99,37,65,71,243,218,81,132,41,47,191,2,3,179,167,117,140,226,8,242,114,139,90,133,218,207,141,93,139,229,212,111,91,116,58,237,115,145,141,225,65,26,4,51,176,242,17,81,159,38,123,21,104,27,86,181,145,3,213,138,25,122,84,112,5,125,5,36,51,246,244,223,141,233,234,149,115,197,120,172,130,123,244,199,113,250,204,72,50,80,139,85,156,38,132,147,48,131,93,245,193,187,162,179,157,27,218,112,60,54,126,128,44,178,167,16,171,203,106,136,173,79,147,83,117,50,62,7,79,118,92,163,33,61,221,200,197,95,201,75,153,84,32,188,179,106,85,227,58,77,196,228,35,18,27,246,2,63,216,79,178,206,224,128,80,18,44,44,98,127,247,157,136,168,105,217,151,135,116,157,254,62,206,222,211,215,238,125,145,247,55,74,132,200,35,119,188,190,1,110,90,83,222,69,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a32b6e83-4c3b-c886-59ec-834898926b24"));
		}

		#endregion

	}

	#endregion

}

