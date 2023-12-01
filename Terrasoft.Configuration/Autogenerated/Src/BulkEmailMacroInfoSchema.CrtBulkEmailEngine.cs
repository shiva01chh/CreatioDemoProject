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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,77,107,195,48,12,134,207,45,244,63,8,122,111,118,222,198,160,43,59,236,80,90,178,178,187,234,42,169,169,63,130,164,148,141,178,255,62,199,105,70,25,99,196,24,97,201,126,244,190,86,64,79,210,160,33,216,17,51,74,172,116,177,138,161,178,117,203,168,54,134,217,244,50,155,78,138,162,128,71,105,189,71,254,124,186,230,37,53,76,66,65,5,244,72,112,64,69,48,49,40,163,81,168,34,195,190,117,39,32,143,214,129,71,195,17,206,232,90,2,193,179,13,245,98,232,90,220,180,109,218,189,179,6,140,67,17,120,78,248,75,71,175,59,248,53,84,49,189,72,102,82,156,204,153,234,100,14,182,28,27,98,181,36,247,176,205,112,127,255,219,111,46,228,62,2,232,44,10,56,123,34,88,47,87,229,230,237,110,241,131,220,154,25,220,136,114,242,11,203,140,93,160,38,125,0,233,194,215,63,90,27,182,181,13,56,252,92,233,35,205,132,163,79,39,223,56,84,26,165,153,29,239,58,118,172,110,73,210,58,189,78,58,86,189,252,40,173,247,140,252,161,51,167,112,232,199,157,243,84,77,59,173,111,133,128,226,14,59,2,0,0 };
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

