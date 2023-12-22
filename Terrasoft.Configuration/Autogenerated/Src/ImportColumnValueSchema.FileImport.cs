namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportColumnValueSchema

	/// <exclude/>
	public class ImportColumnValueSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportColumnValueSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportColumnValueSchema(ImportColumnValueSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f8ae54ba-7ca1-412e-af1f-79f7b6e20f3d");
			Name = "ImportColumnValue";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("52abf94a-4a51-4e9b-afae-86480a04ff1e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,77,107,219,64,16,61,43,144,255,48,40,23,155,22,233,94,71,130,98,19,200,33,33,56,37,151,210,195,90,30,169,11,251,33,102,87,77,93,147,255,222,213,174,36,75,177,99,28,31,12,251,102,230,205,188,153,103,43,38,209,212,172,64,248,129,68,204,232,210,38,75,173,74,94,53,196,44,215,42,185,227,2,239,101,173,201,94,95,237,175,175,162,198,112,85,193,243,206,88,148,139,119,239,100,197,89,165,180,177,188,48,71,177,117,163,44,151,152,60,35,113,38,248,63,79,239,178,92,222,13,97,229,30,176,20,204,152,111,16,218,45,181,104,164,122,97,162,65,159,148,166,41,220,154,70,74,70,187,188,123,127,87,192,149,177,76,57,1,186,4,251,155,27,40,90,18,32,172,9,13,42,107,128,123,58,40,60,31,252,105,9,147,158,47,29,17,254,92,225,166,169,42,164,21,55,181,96,187,89,236,155,103,251,24,190,128,114,139,210,229,204,35,115,247,142,223,226,249,175,182,104,144,179,17,216,2,117,179,17,188,232,166,56,161,36,218,123,53,131,230,59,142,98,235,68,63,249,186,16,123,47,213,3,129,197,233,221,226,223,100,200,26,11,112,10,152,101,15,40,55,72,179,71,55,48,100,16,7,217,247,109,85,152,184,159,208,88,106,175,179,60,196,23,103,186,175,245,235,167,91,147,126,253,184,239,186,11,118,77,111,80,109,195,70,166,235,121,34,93,35,89,142,151,172,232,165,191,237,133,3,122,47,156,156,206,51,193,30,42,180,11,48,237,215,219,249,57,221,143,198,149,54,133,213,116,209,49,9,153,69,51,117,239,174,70,151,137,8,5,97,153,197,71,230,137,211,252,3,113,30,169,25,49,233,141,154,117,202,242,176,144,219,212,135,78,103,142,253,145,79,60,118,182,108,184,109,126,112,198,184,160,91,231,145,134,89,183,96,63,224,215,126,221,163,33,6,172,239,208,30,42,158,67,251,223,19,69,35,183,58,188,152,120,215,133,195,217,178,192,30,160,245,129,134,14,150,139,162,19,247,236,176,233,137,29,54,254,252,7,20,229,82,142,49,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f8ae54ba-7ca1-412e-af1f-79f7b6e20f3d"));
		}

		#endregion

	}

	#endregion

}

