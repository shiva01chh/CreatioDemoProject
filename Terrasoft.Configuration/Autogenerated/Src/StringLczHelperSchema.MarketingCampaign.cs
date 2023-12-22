namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StringLczHelperSchema

	/// <exclude/>
	public class StringLczHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StringLczHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StringLczHelperSchema(StringLczHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6f3f34d7-0318-4d6e-85df-0dbdd9ff8f22");
			Name = "StringLczHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,193,110,219,48,12,61,167,64,255,129,240,118,72,0,195,190,175,105,10,44,27,186,67,59,12,203,218,157,21,133,78,180,202,146,65,201,9,150,160,255,62,90,178,179,58,246,230,131,33,145,212,227,123,124,146,17,37,186,74,72,132,31,72,36,156,45,124,182,180,166,80,219,154,132,87,214,92,95,157,174,175,38,181,83,102,219,43,41,75,107,110,70,51,132,28,231,204,59,194,45,3,192,82,11,231,62,192,202,19,87,62,200,227,23,212,21,82,40,201,243,28,230,174,46,75,65,191,23,237,62,166,161,176,4,7,75,47,112,80,126,7,218,74,161,213,17,193,5,20,151,117,135,243,55,167,171,122,173,149,228,18,38,46,65,54,109,135,93,39,167,208,249,204,238,17,253,206,110,152,223,183,112,58,38,47,121,133,192,61,250,75,30,217,185,56,191,172,158,87,130,68,9,134,231,123,155,104,121,252,202,139,100,241,16,207,139,181,198,200,204,65,168,67,207,146,97,47,116,141,243,60,68,198,129,106,135,196,246,24,148,141,55,201,226,137,247,32,207,1,224,237,94,201,255,99,16,58,91,147,196,71,97,196,22,41,18,107,254,96,11,232,146,13,168,23,202,128,93,255,98,236,1,32,161,175,201,184,197,60,239,86,77,170,239,64,156,81,51,55,158,127,148,251,220,40,156,250,157,114,93,182,29,77,10,79,61,105,208,87,154,118,229,35,228,225,54,8,179,197,244,99,173,95,62,151,66,233,85,165,149,231,94,106,35,188,165,217,12,154,59,60,153,236,5,117,14,254,117,160,133,120,159,12,189,201,78,45,187,215,44,16,79,110,254,13,211,176,192,3,12,64,166,125,33,217,79,190,211,225,193,101,223,91,41,43,166,200,90,210,128,61,25,17,152,142,147,158,69,54,237,96,194,221,97,18,131,210,72,29,238,238,70,82,108,205,178,214,236,31,70,99,238,209,32,9,125,193,44,251,132,69,91,150,66,33,180,235,90,71,235,99,235,16,121,109,223,22,154,77,124,94,97,31,163,253,96,136,189,253,254,0,4,238,72,235,137,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6f3f34d7-0318-4d6e-85df-0dbdd9ff8f22"));
		}

		#endregion

	}

	#endregion

}

