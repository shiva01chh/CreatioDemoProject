namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingInfoRestResponseSchema

	/// <exclude/>
	public class LandingInfoRestResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingInfoRestResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingInfoRestResponseSchema(LandingInfoRestResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ff0d71e4-de6c-c97e-7e4b-bdc6aecbd4a2");
			Name = "LandingInfoRestResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,81,107,194,48,20,133,159,45,244,63,92,240,221,190,235,216,75,199,68,144,173,76,255,64,218,220,118,129,54,41,247,38,27,82,246,223,151,164,234,116,108,88,11,41,228,228,112,242,29,110,180,232,144,123,81,33,236,145,72,176,169,237,34,55,186,86,141,35,97,149,209,139,157,169,148,104,183,40,228,26,117,154,12,105,50,115,172,116,3,187,3,91,236,86,105,226,149,57,97,227,205,144,183,130,121,9,91,161,165,183,108,116,109,222,144,173,95,189,209,140,209,154,101,25,60,176,235,58,65,135,199,227,62,111,141,147,64,71,27,60,237,95,225,83,217,119,80,62,128,186,200,1,162,52,206,66,59,38,3,187,146,43,82,101,68,60,165,102,23,177,189,43,91,85,65,21,128,254,227,129,37,92,181,11,103,5,153,15,37,145,126,152,103,67,228,62,119,244,142,30,201,42,244,69,139,120,203,120,254,187,88,20,158,61,63,40,185,56,27,46,25,79,144,108,41,116,10,222,141,132,1,26,180,43,224,240,251,186,21,173,253,252,38,135,191,120,243,228,248,66,52,56,149,60,120,239,32,143,209,147,201,131,251,46,242,227,180,111,194,175,157,146,231,167,241,39,253,28,181,28,167,30,247,163,122,45,70,45,124,223,55,198,147,0,74,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ff0d71e4-de6c-c97e-7e4b-bdc6aecbd4a2"));
		}

		#endregion

	}

	#endregion

}

