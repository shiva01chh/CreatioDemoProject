namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImportFactorySchema

	/// <exclude/>
	public class FileImportFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImportFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImportFactorySchema(FileImportFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4c7625a4-8130-4b80-a086-770eb086519c");
			Name = "FileImportFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,145,209,75,195,48,16,198,159,59,216,255,112,108,47,45,140,238,125,115,194,156,171,244,65,25,168,79,226,67,150,94,219,64,155,148,75,138,14,217,255,238,53,21,117,214,129,6,154,144,235,199,239,190,47,167,69,141,182,17,18,225,1,137,132,53,185,139,55,70,231,170,104,73,56,101,116,156,168,10,211,186,49,228,96,60,122,27,143,130,214,42,93,156,200,9,151,103,234,113,34,164,51,164,208,178,130,53,83,194,130,161,0,155,74,88,187,128,47,120,47,60,120,213,124,62,191,80,186,68,82,46,51,18,36,97,190,154,164,3,237,100,126,201,226,167,107,204,69,91,185,43,165,51,54,16,186,67,131,38,15,135,242,104,6,119,156,22,86,160,249,96,201,80,17,61,143,71,192,171,105,247,149,226,198,157,201,161,199,5,12,225,108,164,123,155,207,128,183,232,74,147,113,194,157,71,249,88,255,200,21,116,242,15,23,233,142,84,45,232,176,213,78,185,67,194,49,145,224,6,221,47,229,240,209,34,241,248,52,202,110,118,208,158,92,103,144,110,76,213,214,218,174,139,130,125,10,110,182,206,68,227,152,39,251,31,59,50,18,173,53,20,129,143,211,125,129,202,33,60,37,197,220,62,181,9,10,215,18,110,181,216,87,152,133,19,110,158,160,147,101,98,232,30,5,201,114,251,170,172,235,253,165,250,43,230,36,138,60,215,119,8,2,66,166,104,208,248,2,167,145,58,22,103,250,25,98,96,117,233,57,71,191,251,237,44,177,127,164,191,1,143,253,204,166,168,179,126,166,124,235,107,223,75,92,233,214,59,93,22,205,220,71,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4c7625a4-8130-4b80-a086-770eb086519c"));
		}

		#endregion

	}

	#endregion

}

