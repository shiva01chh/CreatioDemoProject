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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,193,110,219,48,12,61,167,64,255,129,240,118,72,0,195,190,175,105,10,44,27,186,67,59,12,203,186,157,21,133,78,180,202,146,65,201,9,150,160,255,62,90,178,179,57,118,235,131,33,145,212,227,123,124,146,17,37,186,74,72,132,31,72,36,156,45,124,182,180,166,80,219,154,132,87,214,92,95,157,174,175,38,181,83,102,219,43,41,75,107,110,70,51,132,28,231,204,59,194,45,3,192,82,11,231,62,192,202,19,87,62,200,227,23,212,21,82,40,201,243,28,230,174,46,75,65,127,22,237,62,166,161,176,4,7,75,207,112,80,126,7,218,74,161,213,17,193,5,20,151,117,135,243,255,78,87,245,90,43,201,37,76,92,130,108,218,14,187,78,78,161,243,153,221,35,250,157,221,48,191,111,225,116,76,94,242,10,129,123,244,151,60,178,115,113,126,89,61,175,4,137,18,12,207,247,54,209,242,248,149,23,201,226,33,158,23,107,141,145,153,131,80,135,158,37,195,94,232,26,231,121,136,140,3,213,14,137,237,49,40,27,111,146,197,19,239,65,158,3,192,219,189,146,111,99,16,58,91,147,196,71,97,196,22,41,18,107,254,96,11,232,146,13,168,23,202,128,93,255,102,236,1,32,161,175,201,184,197,60,239,86,77,170,239,64,156,81,51,55,158,127,148,251,179,81,56,245,59,229,186,108,59,154,20,158,122,210,160,175,52,237,202,71,200,195,109,16,102,139,233,199,90,63,127,46,133,210,171,74,43,207,189,212,70,120,75,179,25,52,119,120,50,217,11,234,28,252,231,64,11,241,62,25,122,147,157,90,118,47,89,32,158,220,188,14,211,176,192,3,12,64,166,125,33,217,47,190,211,225,193,101,223,91,41,43,166,200,90,210,128,61,25,17,152,142,147,158,69,54,237,96,194,221,97,18,131,210,72,29,238,238,70,82,108,205,178,214,236,31,70,99,238,209,32,9,125,193,44,251,132,69,91,150,66,33,180,235,90,71,235,99,235,16,121,105,223,22,154,77,124,94,97,31,163,253,96,136,241,247,23,140,161,4,121,128,4,0,0 };
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

