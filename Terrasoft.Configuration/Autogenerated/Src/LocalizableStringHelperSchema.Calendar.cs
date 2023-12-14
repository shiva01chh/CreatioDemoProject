namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LocalizableStringHelperSchema

	/// <exclude/>
	public class LocalizableStringHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LocalizableStringHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LocalizableStringHelperSchema(LocalizableStringHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("372a558a-906c-4891-8361-c65204ffc892");
			Name = "LocalizableStringHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,201,78,195,48,16,61,7,137,127,24,194,165,21,200,185,67,219,75,133,0,137,77,172,103,55,157,150,8,199,142,102,108,16,84,252,59,142,147,148,38,77,193,7,203,179,61,191,121,99,107,153,35,23,50,69,120,68,34,201,102,97,197,212,232,69,182,116,36,109,102,244,254,222,106,127,47,114,156,233,101,43,37,207,141,62,237,141,16,122,191,143,28,18,46,61,0,76,149,100,62,129,43,147,74,149,125,201,153,194,7,75,190,232,2,85,129,20,82,147,36,129,17,187,60,151,244,57,169,237,195,246,130,102,135,198,134,190,4,191,68,3,152,108,32,22,110,166,178,20,216,250,166,82,72,75,74,187,25,69,171,192,106,221,193,53,218,87,51,247,61,220,5,148,42,216,229,220,34,189,125,216,180,196,186,62,233,2,140,10,73,50,7,237,199,50,142,29,35,249,97,104,76,203,73,196,147,190,110,203,53,74,66,85,63,8,167,175,152,203,27,127,14,0,85,225,49,236,128,106,172,63,33,85,87,184,14,250,127,88,132,214,145,230,73,39,175,91,213,164,149,117,237,249,113,184,21,206,209,62,75,229,112,240,212,18,10,218,186,29,55,233,191,74,172,93,189,157,12,161,124,242,81,244,46,9,8,217,41,11,227,186,64,156,229,133,253,60,13,225,108,1,131,131,218,125,201,55,78,169,91,10,225,65,63,106,3,27,53,119,243,187,199,141,183,94,33,139,24,142,250,153,121,127,44,66,203,113,197,33,112,84,236,113,52,126,108,63,232,65,91,9,241,98,232,45,252,118,113,143,108,28,165,62,207,144,92,150,130,108,136,227,153,13,107,252,117,255,138,197,163,169,81,235,224,119,216,171,41,213,66,133,192,119,253,123,80,207,171,15,20,236,202,219,118,122,95,185,126,0,110,173,236,228,133,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("372a558a-906c-4891-8361-c65204ffc892"));
		}

		#endregion

	}

	#endregion

}

