namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RootAccountInfoResponseSchema

	/// <exclude/>
	public class RootAccountInfoResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RootAccountInfoResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RootAccountInfoResponseSchema(RootAccountInfoResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8c2134ec-81df-40a8-823f-e035797122bd");
			Name = "RootAccountInfoResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,223,106,131,48,20,198,175,43,248,14,7,122,175,247,221,24,108,14,134,48,88,177,237,3,164,241,104,3,154,200,201,113,163,148,189,251,98,162,93,55,232,64,86,47,2,231,207,247,157,223,73,212,162,69,219,9,137,176,69,34,97,77,197,73,102,116,165,234,158,4,43,163,227,232,20,71,113,180,88,18,214,46,132,172,17,214,174,160,48,134,31,165,52,189,230,92,87,166,112,38,70,91,244,173,105,154,194,189,237,219,86,208,241,97,140,179,198,244,37,208,216,6,207,219,55,248,80,124,0,229,196,212,250,73,32,246,166,103,16,193,53,153,140,210,11,167,174,223,55,74,130,28,24,174,33,192,10,158,132,197,177,242,13,182,8,123,156,23,89,147,233,144,88,161,219,102,237,125,67,253,55,125,192,39,28,24,97,87,188,38,231,166,75,178,9,205,50,41,93,79,253,59,106,224,4,53,242,29,216,225,248,252,99,196,11,178,5,67,67,163,5,62,32,200,113,166,108,20,106,6,85,186,83,85,10,105,14,65,230,197,121,121,51,12,139,46,193,243,17,54,94,247,127,140,112,13,124,116,21,122,71,154,251,34,249,40,223,120,245,149,247,89,162,46,195,95,226,227,144,253,153,244,185,225,251,2,143,247,92,71,65,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8c2134ec-81df-40a8-823f-e035797122bd"));
		}

		#endregion

	}

	#endregion

}

