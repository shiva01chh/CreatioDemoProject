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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,93,107,131,48,20,134,175,21,252,15,7,122,175,247,109,41,148,94,140,130,148,178,238,15,100,201,169,132,105,34,57,113,80,100,255,125,199,207,90,43,27,131,121,33,248,122,242,62,143,137,70,20,72,165,144,8,111,232,156,32,123,245,241,193,154,171,206,42,39,188,182,38,190,88,169,69,158,162,80,47,104,162,176,142,194,160,34,109,50,184,220,200,99,193,211,121,142,178,25,165,152,39,208,105,185,137,66,158,90,57,204,56,133,67,46,136,214,144,106,243,129,234,104,246,106,47,165,173,140,79,53,249,87,134,243,66,108,23,36,73,2,91,170,138,66,184,219,174,127,30,226,100,146,151,213,123,174,37,200,166,247,231,90,88,195,131,62,231,254,236,236,167,86,232,238,232,160,110,241,115,225,177,177,123,59,183,27,244,158,253,30,5,39,53,193,64,26,81,44,83,162,243,26,153,119,110,87,245,3,79,180,17,183,192,27,128,228,93,115,48,35,241,168,160,134,12,253,6,168,185,125,253,103,247,137,127,156,197,246,21,26,213,125,93,23,244,249,60,254,109,7,254,190,221,205,193,111,71,191,221,93,149,150,60,103,62,93,58,13,57,225,235,27,57,55,66,250,32,3,0,0 };
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

