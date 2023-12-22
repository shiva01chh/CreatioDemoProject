namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FacebookEntityMetadataSchema

	/// <exclude/>
	public class FacebookEntityMetadataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FacebookEntityMetadataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FacebookEntityMetadataSchema(FacebookEntityMetadataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e3e1645a-bfb9-4c64-806f-498f877105d0");
			Name = "FacebookEntityMetadata";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eff9ab8e-fb1d-46f5-bbeb-f2b4e8220404");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,81,193,106,195,48,12,61,167,208,127,48,237,165,131,145,15,88,217,97,116,235,97,144,17,150,222,70,15,74,162,4,179,196,54,178,114,200,202,254,125,138,147,118,91,33,212,39,249,61,189,167,103,217,64,139,222,65,129,234,128,68,224,109,197,241,206,154,74,215,29,1,107,107,226,204,22,26,154,229,226,180,92,68,157,215,166,86,89,239,25,219,237,213,61,126,239,12,235,22,227,12,73,4,250,43,200,127,187,246,50,36,183,246,83,16,193,214,132,181,208,106,215,128,247,15,23,242,69,44,184,79,144,161,4,134,208,249,241,44,149,68,98,130,130,143,2,184,46,111,116,161,138,65,57,35,84,215,142,34,59,5,183,203,224,148,172,67,98,141,50,61,13,142,35,31,198,37,216,230,72,155,55,89,142,122,84,171,74,99,83,250,213,221,49,52,156,157,19,112,78,30,182,57,211,247,42,5,66,195,131,162,157,130,76,154,41,242,171,183,230,73,182,220,171,125,144,168,97,167,81,84,35,111,67,225,167,226,123,62,10,247,14,103,131,4,242,118,12,207,52,124,200,65,186,111,36,88,163,41,199,125,133,251,136,254,7,5,251,123,126,0,115,81,143,114,80,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e3e1645a-bfb9-4c64-806f-498f877105d0"));
		}

		#endregion

	}

	#endregion

}

