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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,201,110,219,48,16,61,203,128,255,129,208,137,60,152,144,208,34,105,96,244,16,91,114,32,160,40,10,199,105,14,65,15,140,52,118,8,80,164,202,197,173,81,244,223,195,197,173,42,183,21,36,141,244,102,230,189,89,232,12,151,7,116,127,50,22,250,229,124,230,226,239,14,180,102,70,237,45,93,171,190,87,242,159,14,13,255,129,105,181,242,158,249,76,178,30,204,192,90,152,248,229,158,31,156,102,150,43,57,159,253,152,207,178,193,61,11,222,34,99,61,214,162,86,48,99,208,109,215,115,249,96,185,224,150,131,241,65,33,240,34,82,3,235,148,20,39,116,231,120,135,42,216,175,149,112,189,220,242,195,139,253,0,71,16,77,135,222,35,9,223,98,0,206,139,226,122,83,188,173,235,69,185,169,203,69,181,41,203,197,205,117,185,90,20,69,89,93,21,245,205,155,119,235,171,156,44,179,44,11,90,127,235,69,153,59,176,91,165,108,170,79,114,219,116,248,193,128,246,109,73,104,67,79,200,77,126,9,138,149,103,247,32,60,128,76,50,169,172,132,225,139,4,186,83,3,46,9,77,221,224,188,233,114,66,55,90,245,56,247,91,250,45,236,193,72,156,61,190,128,134,169,111,119,26,224,51,19,14,124,80,99,234,175,142,9,156,232,194,252,141,197,5,33,244,86,250,153,124,98,26,164,239,72,64,148,105,204,71,39,4,38,136,153,115,117,203,40,146,182,140,143,76,163,238,185,254,14,173,179,74,251,46,166,165,211,90,26,167,161,90,141,16,38,191,6,48,225,96,150,109,253,246,32,112,164,145,208,196,10,9,198,163,202,72,144,241,61,194,99,42,13,230,15,254,44,211,96,157,190,92,128,63,140,97,28,30,56,130,182,62,173,90,197,209,236,84,60,21,35,223,83,152,244,23,178,60,179,253,76,246,108,226,59,125,159,85,66,54,173,251,193,158,98,70,240,249,199,223,225,122,5,246,196,179,104,85,3,0,0 };
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

