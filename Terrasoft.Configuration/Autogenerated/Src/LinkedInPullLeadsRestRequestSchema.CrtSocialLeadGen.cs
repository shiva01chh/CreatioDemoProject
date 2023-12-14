namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LinkedInPullLeadsRestRequestSchema

	/// <exclude/>
	public class LinkedInPullLeadsRestRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LinkedInPullLeadsRestRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LinkedInPullLeadsRestRequestSchema(LinkedInPullLeadsRestRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6413fce5-0d56-4454-a110-907134c1fae3");
			Name = "LinkedInPullLeadsRestRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,83,205,106,2,49,16,62,175,224,59,12,244,208,155,123,175,162,7,107,37,32,84,212,23,200,38,179,105,104,54,217,230,167,69,164,239,222,36,171,85,75,81,11,205,97,151,157,253,254,38,153,104,218,160,107,41,67,216,160,181,212,153,218,15,166,70,215,82,4,75,189,52,122,176,54,76,82,181,64,202,231,168,251,189,93,191,87,4,39,181,128,245,214,121,108,134,253,30,196,117,90,138,2,74,33,75,108,55,136,36,180,146,69,88,7,188,179,40,226,15,152,42,234,220,3,44,164,126,69,78,244,50,168,236,225,86,232,252,10,223,66,124,29,40,101,89,194,200,133,166,161,118,59,62,150,166,202,4,14,182,195,194,227,230,25,62,164,127,1,169,107,99,155,156,29,104,101,130,135,54,106,131,74,226,192,114,107,39,178,229,185,110,27,42,37,25,176,20,238,74,182,34,237,68,113,104,103,105,77,139,214,75,140,61,45,179,72,74,95,20,63,178,119,133,181,167,214,3,167,30,191,33,229,41,102,159,194,121,155,55,53,161,31,35,24,118,32,208,15,193,165,199,231,191,233,207,52,255,147,58,209,76,5,142,113,163,105,60,227,119,4,75,181,64,119,209,170,50,70,29,136,100,207,91,101,218,205,182,11,25,79,217,212,32,133,54,22,193,229,177,204,199,10,146,223,95,182,39,51,29,26,180,180,82,56,234,186,30,3,201,58,199,233,38,252,246,44,68,123,20,221,253,136,230,23,173,231,65,242,201,41,129,240,155,109,158,226,32,95,211,87,70,139,73,70,254,38,156,71,20,53,239,166,52,127,119,134,231,197,88,75,235,11,80,30,172,165,13,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6413fce5-0d56-4454-a110-907134c1fae3"));
		}

		#endregion

	}

	#endregion

}

