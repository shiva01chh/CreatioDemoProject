namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailMacroInfoSchema

	/// <exclude/>
	public class BulkEmailMacroInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailMacroInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailMacroInfoSchema(BulkEmailMacroInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd908fae-7593-41a7-85f2-5a9b52456b8d");
			Name = "BulkEmailMacroInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,77,107,195,48,12,134,207,45,244,63,8,122,79,118,222,198,160,43,59,236,80,90,178,178,187,154,42,169,169,63,130,164,148,141,178,255,62,199,105,70,24,99,196,24,97,201,126,244,190,150,71,71,210,96,73,176,39,102,148,80,105,182,14,190,50,117,203,168,38,248,197,252,186,152,207,242,60,135,71,105,157,67,254,124,186,229,5,53,76,66,94,5,244,68,112,68,69,40,131,87,198,82,161,10,12,135,214,158,129,28,26,11,14,75,14,112,65,219,18,8,94,140,175,179,161,107,62,106,219,180,7,107,74,40,45,138,192,115,196,95,58,122,211,193,175,190,10,241,69,52,19,227,108,201,84,71,115,176,227,208,16,171,33,185,135,93,130,251,251,223,126,83,33,245,17,64,107,80,192,154,51,193,102,181,46,182,111,119,217,15,50,54,51,184,17,229,232,23,86,9,187,66,77,250,0,210,133,175,127,180,182,108,106,227,113,248,185,210,71,156,9,7,23,79,174,177,168,52,73,51,57,222,119,236,84,221,130,164,181,122,155,116,168,122,249,73,90,239,9,249,67,103,73,254,216,143,59,229,177,26,247,120,125,3,195,148,96,4,68,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd908fae-7593-41a7-85f2-5a9b52456b8d"));
		}

		#endregion

	}

	#endregion

}

