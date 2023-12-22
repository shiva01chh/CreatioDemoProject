namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AdminUtilitiesSchema

	/// <exclude/>
	public class AdminUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AdminUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AdminUtilitiesSchema(AdminUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("170e19f8-c937-4f98-aec0-9d08e2acf0d5");
			Name = "AdminUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,201,110,219,48,16,61,211,128,255,129,208,137,58,152,144,208,34,105,96,244,16,91,114,32,160,40,10,199,73,14,69,15,140,52,118,8,80,164,202,197,173,81,244,223,203,197,173,34,183,21,36,141,244,102,230,189,89,232,12,151,7,124,127,50,22,250,229,124,230,226,239,14,180,102,70,237,45,93,171,190,87,242,159,14,13,255,129,105,181,242,158,249,76,178,30,204,192,90,152,248,229,158,31,156,102,150,43,57,159,253,152,207,208,224,158,5,111,177,177,30,107,113,43,152,49,248,182,235,185,124,176,92,112,203,193,248,160,16,120,17,169,129,117,74,138,19,190,115,188,195,21,236,215,74,184,94,110,249,225,197,126,128,35,136,166,195,239,177,132,111,49,128,100,69,113,189,41,222,214,245,162,220,212,229,162,218,148,229,226,230,186,92,45,138,162,172,174,138,250,230,205,187,245,85,150,47,17,66,65,235,111,189,40,115,7,118,171,148,77,245,73,110,155,142,60,24,208,190,45,9,109,232,9,187,201,111,142,99,229,232,30,132,7,176,73,38,149,149,48,114,145,64,119,106,32,101,78,83,55,36,107,186,44,167,27,173,122,146,249,45,253,17,246,96,36,70,79,47,160,97,234,219,157,6,120,100,194,129,15,106,76,253,213,49,65,18,93,152,191,177,164,200,115,122,43,253,76,62,49,13,210,119,36,32,202,52,230,163,19,130,228,152,153,115,117,203,40,146,182,76,142,76,227,238,185,254,14,173,179,74,251,46,166,165,211,90,26,167,161,90,141,16,201,127,15,96,194,193,44,219,250,237,65,224,72,35,161,137,21,18,76,70,149,145,0,241,61,38,99,42,13,230,21,63,66,26,172,211,151,11,240,135,49,140,195,3,71,208,214,167,85,171,56,154,157,138,167,98,228,251,28,38,253,37,95,158,217,126,38,123,54,241,157,190,207,42,33,155,214,253,96,79,49,35,248,252,227,239,215,215,47,12,56,227,247,93,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("170e19f8-c937-4f98-aec0-9d08e2acf0d5"));
		}

		#endregion

	}

	#endregion

}

