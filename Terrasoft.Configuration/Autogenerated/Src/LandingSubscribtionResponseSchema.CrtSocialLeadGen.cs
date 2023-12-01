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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,203,106,195,64,12,60,199,224,127,16,228,110,223,155,210,75,74,75,32,52,166,206,15,200,182,98,22,214,187,70,90,31,74,232,191,87,126,196,184,165,52,238,30,22,36,205,140,6,73,14,27,146,22,75,130,51,49,163,248,75,72,246,222,93,76,221,49,6,227,93,146,251,210,160,61,18,86,175,228,226,232,26,71,113,180,217,50,213,90,132,189,69,145,7,56,162,171,140,171,243,174,144,146,77,209,243,222,85,214,59,161,1,158,166,41,60,74,215,52,200,31,79,83,252,124,62,1,79,32,192,194,119,1,100,193,79,110,180,116,193,107,187,194,154,18,202,190,235,223,77,55,163,207,217,104,198,190,37,14,134,212,109,54,168,140,245,159,206,134,68,134,53,129,169,146,25,176,244,112,51,33,129,181,251,128,61,84,112,133,154,194,14,164,255,62,239,73,59,29,250,106,241,55,5,175,150,127,241,220,172,151,239,209,255,146,63,8,88,61,4,69,59,26,207,99,222,25,221,25,87,225,189,85,254,116,71,249,204,250,173,247,150,92,53,238,109,136,199,236,247,164,230,244,125,1,65,205,189,227,190,2,0,0 };
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

