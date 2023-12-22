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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,145,77,79,195,48,12,134,207,155,180,255,96,245,148,74,83,123,103,27,18,27,12,245,130,56,192,9,113,200,58,103,68,106,147,202,73,64,19,226,191,227,140,85,107,71,39,65,213,47,39,175,31,191,177,141,172,209,53,178,68,120,66,34,233,172,242,217,202,26,165,119,129,164,215,214,100,107,93,97,81,55,150,252,100,252,57,25,143,130,211,102,215,83,19,206,46,172,103,107,89,122,75,26,29,43,88,147,231,57,204,181,121,67,210,126,107,75,40,9,213,34,41,78,37,144,126,50,246,73,126,221,234,93,168,107,73,251,54,102,97,133,53,26,239,64,27,78,80,209,188,178,20,97,210,243,47,195,64,31,105,45,35,239,64,94,110,81,201,80,249,165,54,91,182,44,252,190,65,171,196,144,139,116,10,15,220,32,88,128,225,15,139,134,52,233,43,67,155,176,169,52,31,168,146,206,193,128,10,174,96,168,0,103,198,158,254,187,49,109,189,98,41,29,118,85,112,143,190,27,139,103,135,196,3,53,88,198,105,66,232,133,41,28,170,143,222,37,157,237,220,208,206,197,99,227,7,240,162,243,20,98,117,94,13,177,245,34,233,171,147,233,57,120,118,224,106,5,162,191,145,177,191,194,173,121,82,129,240,206,200,77,133,91,145,176,201,71,36,167,157,103,248,201,126,146,182,6,71,132,156,96,96,21,251,123,236,68,68,205,139,161,60,164,107,241,251,56,71,79,95,135,247,69,222,223,40,17,194,15,223,221,235,27,31,124,178,61,77,3,0,0 };
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

