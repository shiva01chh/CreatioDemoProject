namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationRequestSchema

	/// <exclude/>
	public class IntegrationRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationRequestSchema(IntegrationRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f58b6f1c-5c09-4a6d-a367-9cc43d2b20d0");
			Name = "IntegrationRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,79,193,106,195,48,12,61,47,144,127,16,236,158,220,219,177,75,10,101,48,88,233,250,3,90,162,100,134,196,206,36,121,99,148,253,251,28,187,13,238,152,47,150,158,158,158,222,179,56,145,204,216,18,156,136,25,197,245,90,53,206,246,102,240,140,106,156,173,94,93,107,112,124,38,236,246,100,203,226,92,22,101,113,119,207,52,132,33,52,35,138,108,224,201,42,13,137,127,164,15,79,162,145,85,215,53,60,136,159,38,228,239,199,75,223,140,206,119,192,137,5,187,211,11,124,25,125,7,99,123,199,83,84,0,215,135,118,21,172,174,66,117,166,52,251,183,209,180,208,46,231,255,185,14,27,184,177,125,12,216,129,221,167,233,136,67,61,59,43,20,84,82,150,53,76,96,204,196,106,40,36,58,196,3,105,254,55,70,4,246,164,2,142,65,150,63,179,11,163,17,173,214,181,220,244,213,117,230,55,175,119,168,8,103,24,72,183,139,234,22,126,46,246,200,118,201,97,236,19,122,11,70,44,127,191,137,126,233,59,215,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f58b6f1c-5c09-4a6d-a367-9cc43d2b20d0"));
		}

		#endregion

	}

	#endregion

}

