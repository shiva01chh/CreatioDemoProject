namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TagConstantsSchema

	/// <exclude/>
	public class TagConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TagConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TagConstantsSchema(TagConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ae28a44b-17af-49d1-987b-2e02f87bc1ca");
			Name = "TagConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,79,77,107,132,48,16,61,111,192,255,16,214,75,123,152,174,171,73,84,150,30,52,31,165,183,133,218,31,144,106,86,4,87,197,104,139,148,254,247,102,237,169,7,105,135,97,6,230,205,204,123,111,182,77,87,227,151,197,78,230,122,242,144,135,58,125,53,118,208,165,193,133,25,71,109,251,203,244,192,251,238,210,212,243,168,167,166,239,60,244,233,161,221,48,191,181,77,137,237,228,102,37,46,91,109,45,46,116,237,54,237,100,29,126,219,217,29,14,190,239,99,255,86,96,109,107,220,144,223,231,163,209,85,223,181,11,126,154,155,10,159,87,204,61,43,150,193,188,62,87,248,17,119,230,99,197,238,246,130,169,156,8,201,32,72,130,20,200,81,73,200,18,162,128,137,144,80,158,115,170,162,112,127,127,218,102,255,143,2,222,143,67,239,220,154,13,17,84,196,169,140,210,8,84,34,3,32,73,20,64,22,179,28,84,196,227,156,75,26,166,82,108,139,248,211,255,216,188,111,115,39,34,86,76,48,14,132,103,20,72,78,34,200,133,72,33,163,50,56,102,52,9,67,22,252,112,127,121,200,37,66,223,87,26,52,141,227,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae28a44b-17af-49d1-987b-2e02f87bc1ca"));
		}

		#endregion

	}

	#endregion

}

