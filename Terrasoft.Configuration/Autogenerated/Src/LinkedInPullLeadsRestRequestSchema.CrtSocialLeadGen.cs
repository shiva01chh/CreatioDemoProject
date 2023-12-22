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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,83,221,106,194,48,20,190,174,224,59,28,216,197,238,236,253,20,189,112,78,2,194,68,125,129,216,156,102,97,233,73,151,159,13,145,189,251,210,84,103,29,67,29,44,23,45,61,253,254,78,114,66,188,66,87,243,2,97,131,214,114,103,74,63,152,26,42,149,12,150,123,101,104,176,54,133,226,122,129,92,204,145,250,189,125,191,151,5,167,72,194,122,231,60,86,195,126,15,226,234,150,162,128,214,88,52,108,55,136,36,180,170,136,176,22,120,103,81,198,31,48,213,220,185,7,88,40,122,69,193,104,25,116,242,112,43,116,126,133,111,33,190,142,148,60,207,97,228,66,85,113,187,27,159,74,83,109,130,0,219,98,225,113,243,12,31,202,191,128,162,210,216,42,101,7,190,53,193,67,29,181,65,55,226,80,164,214,58,178,249,185,110,29,182,90,21,80,52,225,174,100,203,154,157,200,142,237,44,173,169,209,122,133,177,167,101,18,105,210,103,217,143,236,109,97,237,185,245,32,184,199,111,72,222,197,28,82,56,111,211,166,54,232,199,8,134,61,72,244,67,112,205,227,243,223,244,103,36,254,164,206,168,208,65,96,220,104,30,207,248,29,193,114,146,232,46,90,109,141,209,71,34,59,240,86,137,118,179,237,66,197,83,54,37,40,73,198,34,184,52,150,233,88,65,137,251,203,246,108,70,161,66,203,183,26,71,109,215,99,96,73,231,52,221,76,220,158,133,145,71,217,222,143,104,126,209,122,30,148,152,116,9,76,220,108,243,20,7,249,154,190,54,36,39,9,249,155,112,26,81,36,209,78,105,250,110,13,207,139,177,214,93,95,40,22,119,119,21,4,0,0 };
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

