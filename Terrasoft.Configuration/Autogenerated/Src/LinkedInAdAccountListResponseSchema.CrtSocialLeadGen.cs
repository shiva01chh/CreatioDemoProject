namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LinkedInAdAccountListResponseSchema

	/// <exclude/>
	public class LinkedInAdAccountListResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LinkedInAdAccountListResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LinkedInAdAccountListResponseSchema(LinkedInAdAccountListResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("26f7958d-2eef-c66c-ca40-74d11543a381");
			Name = "LinkedInAdAccountListResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d5eec482-a90e-42cc-86d3-ef2673139bae");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,93,107,131,48,20,134,175,21,252,15,129,222,235,125,91,10,165,23,163,32,165,172,251,3,89,114,42,97,154,72,78,28,20,217,127,223,137,31,169,181,178,49,152,23,130,175,39,239,243,152,168,121,5,88,115,1,236,13,172,229,104,174,46,61,24,125,85,69,99,185,83,70,167,23,35,20,47,115,224,242,5,116,18,183,73,28,53,168,116,193,46,55,116,80,209,116,89,130,240,163,152,210,4,88,37,54,73,76,83,43,11,5,165,236,80,114,196,53,203,149,254,0,121,212,123,185,23,194,52,218,229,10,221,43,193,105,33,116,11,178,44,99,91,108,170,138,219,219,110,120,30,227,108,146,215,205,123,169,4,19,190,247,231,90,182,102,15,250,148,187,179,53,159,74,130,189,163,163,182,195,207,133,67,99,255,118,110,55,234,61,251,61,10,78,106,162,145,20,80,36,83,131,117,10,136,119,238,86,13,3,79,180,128,91,224,141,64,116,214,31,76,32,30,37,107,89,1,110,195,208,223,190,254,179,251,68,63,206,98,251,10,180,236,191,174,15,134,124,30,255,182,3,127,223,110,127,240,219,224,183,187,171,226,146,231,204,167,79,167,33,37,254,250,6,172,204,40,109,33,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("26f7958d-2eef-c66c-ca40-74d11543a381"));
		}

		#endregion

	}

	#endregion

}

