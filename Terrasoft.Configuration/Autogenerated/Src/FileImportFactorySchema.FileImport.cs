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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,145,209,75,195,48,16,198,159,59,216,255,112,108,47,45,140,237,125,115,194,156,171,244,65,25,168,79,226,67,150,94,187,64,155,148,75,138,14,217,255,238,53,21,183,90,7,26,104,66,174,31,191,251,190,156,22,37,218,74,72,132,39,36,18,214,100,110,186,54,58,83,121,77,194,41,163,167,177,42,48,41,43,67,14,134,131,143,225,32,168,173,210,121,71,78,184,184,80,159,198,66,58,67,10,45,43,88,51,38,204,25,10,176,46,132,181,115,56,193,91,225,193,171,102,179,217,149,210,123,36,229,82,35,65,18,102,203,81,210,211,142,102,215,44,126,185,197,76,212,133,187,81,58,101,3,161,59,84,104,178,176,47,143,38,240,192,105,97,9,154,15,150,244,21,209,235,112,0,188,170,122,87,40,110,220,152,236,123,156,67,31,206,70,154,183,249,14,120,143,110,111,82,78,184,245,40,31,235,31,185,130,70,254,229,34,217,146,42,5,29,54,218,41,119,136,57,38,18,220,161,251,165,28,62,91,36,30,159,70,217,204,14,234,206,117,2,201,218,20,117,169,237,42,207,217,167,224,102,171,84,84,142,121,178,253,177,37,35,209,90,67,17,248,56,205,23,168,12,194,46,105,202,237,19,27,163,112,53,225,70,139,93,129,105,56,226,230,49,58,185,143,13,61,162,32,185,223,188,43,235,90,127,137,62,197,28,69,145,231,250,14,65,64,200,20,13,26,223,160,27,169,97,113,166,159,33,122,86,23,158,115,244,187,223,46,18,219,71,250,27,240,216,206,108,140,58,109,103,202,183,182,118,94,226,202,249,250,4,223,19,247,232,79,3,0,0 };
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

