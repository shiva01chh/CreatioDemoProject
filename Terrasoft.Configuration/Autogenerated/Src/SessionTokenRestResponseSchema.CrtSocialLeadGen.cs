namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SessionTokenRestResponseSchema

	/// <exclude/>
	public class SessionTokenRestResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SessionTokenRestResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SessionTokenRestResponseSchema(SessionTokenRestResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6e3a15ec-b9d8-c38d-ff2f-9dd9e4d205ff");
			Name = "SessionTokenRestResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,143,193,106,195,48,12,134,207,13,228,29,4,187,39,247,117,236,146,193,46,131,150,37,47,224,38,74,38,150,88,65,178,59,70,217,187,207,177,211,173,237,152,65,6,253,18,191,190,223,154,9,117,54,45,66,131,34,70,185,119,69,197,182,167,193,139,113,196,182,168,185,37,51,190,160,233,158,209,230,217,41,207,242,108,115,39,56,132,33,84,163,81,189,135,26,85,67,219,240,59,218,87,84,23,106,102,171,24,119,203,178,132,7,245,211,100,228,243,113,237,171,145,125,7,178,174,193,83,179,131,15,114,111,64,182,103,153,226,97,48,7,246,14,52,89,131,91,188,139,179,93,121,225,55,251,195,72,45,180,11,202,191,36,16,32,47,131,44,179,189,240,145,58,148,95,218,77,74,247,19,47,108,204,40,142,48,100,220,199,51,105,126,27,41,10,245,45,233,95,212,51,171,58,33,59,92,193,194,9,6,116,219,144,55,124,95,43,6,218,46,145,196,62,169,215,98,212,150,247,13,128,37,53,144,201,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6e3a15ec-b9d8-c38d-ff2f-9dd9e4d205ff"));
		}

		#endregion

	}

	#endregion

}

