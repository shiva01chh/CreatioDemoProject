namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingSubscribtionResponseSchema

	/// <exclude/>
	public class LandingSubscribtionResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingSubscribtionResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingSubscribtionResponseSchema(LandingSubscribtionResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("da97b47f-924c-f15e-42df-bea8ad415e53");
			Name = "LandingSubscribtionResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,193,106,195,48,12,61,55,144,127,16,244,158,220,215,177,75,199,70,161,172,97,233,15,40,137,26,12,142,29,36,231,48,202,254,125,142,157,134,108,140,53,243,193,32,233,189,167,135,36,131,29,73,143,53,193,153,152,81,236,197,101,123,107,46,170,29,24,157,178,38,43,109,173,80,31,9,155,87,50,105,114,77,147,52,217,108,153,90,95,132,189,70,145,7,56,162,105,148,105,203,161,146,154,85,53,242,222,189,172,53,66,1,158,231,57,60,202,208,117,200,31,79,83,252,124,62,1,79,32,192,202,14,14,100,193,207,110,180,124,193,235,135,74,171,26,234,177,235,223,77,55,209,231,108,180,96,219,19,59,69,222,109,17,84,98,253,167,179,144,40,176,37,80,77,54,3,150,30,110,38,196,177,239,30,176,135,6,174,208,146,219,129,140,223,231,61,105,227,135,190,90,252,205,131,87,203,191,88,238,214,203,143,232,127,201,31,4,180,63,4,143,54,20,207,99,222,25,221,25,87,101,173,246,252,233,142,202,153,245,91,239,45,153,38,238,45,196,49,251,61,233,115,203,247,5,185,128,148,44,199,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("da97b47f-924c-f15e-42df-bea8ad415e53"));
		}

		#endregion

	}

	#endregion

}

