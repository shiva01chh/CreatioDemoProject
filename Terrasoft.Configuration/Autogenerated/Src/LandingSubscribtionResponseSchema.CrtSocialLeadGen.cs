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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,193,106,195,48,12,61,55,144,127,16,244,158,220,215,177,75,199,70,161,172,97,233,15,40,142,26,12,142,29,36,231,48,202,254,125,78,156,134,108,140,53,243,193,32,233,189,167,135,36,139,45,73,135,138,224,76,204,40,238,226,179,189,179,23,221,244,140,94,59,155,149,78,105,52,71,194,250,149,108,154,92,211,36,77,54,91,166,38,20,97,111,80,228,1,142,104,107,109,155,178,175,68,177,174,6,222,123,144,117,86,104,132,231,121,14,143,210,183,45,242,199,211,20,63,159,79,192,19,8,176,114,189,7,89,240,179,27,45,95,240,186,190,50,90,129,26,186,254,221,116,19,125,206,70,11,118,29,177,215,20,220,22,163,74,172,255,116,54,38,10,108,8,116,157,205,128,165,135,155,9,241,28,186,143,216,67,13,87,104,200,239,64,134,239,243,158,180,13,67,95,45,254,22,192,171,229,95,28,183,235,229,7,244,191,228,15,2,38,28,66,64,91,138,231,49,239,140,238,140,171,114,206,4,254,116,71,229,204,250,173,247,150,108,29,247,54,198,49,251,61,25,114,195,251,2,88,202,239,51,191,2,0,0 };
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

