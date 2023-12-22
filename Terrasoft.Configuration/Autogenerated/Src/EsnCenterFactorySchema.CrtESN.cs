namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsnCenterFactorySchema

	/// <exclude/>
	public class EsnCenterFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsnCenterFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsnCenterFactorySchema(EsnCenterFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("04389b5a-20dc-4773-ad27-ab521c1b58a1");
			Name = "EsnCenterFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,148,193,78,227,48,16,134,207,69,226,29,172,114,73,36,148,222,41,84,130,208,162,74,128,208,194,158,86,28,76,50,9,22,193,174,198,54,80,173,120,119,198,113,155,212,105,11,193,167,248,247,204,231,241,228,183,37,127,5,189,224,25,176,7,64,228,90,21,38,73,149,44,68,105,145,27,161,100,50,189,191,61,60,248,127,120,48,176,90,200,146,165,10,97,28,204,146,25,207,140,66,1,154,116,90,57,66,40,41,145,177,180,226,90,159,176,169,150,41,72,3,232,227,150,117,208,104,52,98,167,66,62,3,10,147,171,140,141,38,36,254,187,132,130,219,202,92,8,153,19,61,50,203,5,168,34,154,119,9,113,252,72,209,11,251,84,137,140,101,110,151,173,77,216,9,219,74,163,28,119,142,166,192,27,48,207,42,167,10,239,106,82,93,215,238,194,214,123,181,72,150,34,112,3,205,60,250,171,1,169,113,18,50,215,53,102,131,105,204,234,141,7,111,28,59,43,231,88,218,87,34,176,51,38,225,157,250,41,181,65,235,202,93,175,68,195,48,99,120,220,133,143,27,118,37,94,224,15,44,148,22,117,15,206,252,47,88,29,63,185,2,115,234,78,112,29,68,77,162,221,21,109,96,11,81,245,192,206,130,168,30,88,208,242,6,180,230,37,165,241,156,122,186,7,28,4,253,146,155,215,172,31,201,62,172,31,251,30,50,75,230,88,78,101,41,36,236,67,135,81,61,200,149,42,105,221,192,199,218,11,238,79,181,154,55,80,61,72,157,74,254,84,65,78,145,33,215,109,63,215,51,178,166,69,88,5,69,195,198,165,148,89,2,174,244,97,124,220,50,157,125,231,59,120,169,69,164,84,183,156,204,243,78,194,45,61,30,223,167,184,136,54,231,115,188,254,70,160,2,229,118,231,154,74,39,209,222,235,0,93,7,211,141,8,141,191,121,176,193,119,156,192,89,132,233,74,191,7,121,35,117,80,94,236,13,11,173,227,89,161,214,15,21,94,91,226,132,66,63,72,107,75,215,230,102,18,123,231,126,250,71,243,8,100,238,31,85,154,121,109,83,170,149,205,241,5,238,94,30,14,118,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("04389b5a-20dc-4773-ad27-ab521c1b58a1"));
		}

		#endregion

	}

	#endregion

}

