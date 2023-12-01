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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,83,221,106,194,48,20,190,174,224,59,28,216,197,238,236,253,20,189,112,78,2,194,68,125,129,180,57,205,194,210,164,203,207,134,200,222,125,167,169,78,29,67,29,44,23,45,61,253,254,78,114,98,120,141,190,225,37,194,6,157,227,222,86,97,48,181,166,82,50,58,30,148,53,131,181,45,21,215,11,228,98,142,166,223,219,245,123,89,244,202,72,88,111,125,192,122,216,239,1,173,211,18,9,104,141,101,203,246,3,34,161,83,37,193,58,224,157,67,73,63,96,170,185,247,15,176,80,230,21,5,51,203,168,147,135,95,161,15,43,124,139,244,58,80,242,60,135,145,143,117,205,221,118,124,44,77,181,141,2,92,135,133,199,205,51,124,168,240,2,202,84,214,213,41,59,240,194,198,0,13,105,131,110,197,161,76,173,157,200,230,231,186,77,44,180,42,161,108,195,93,201,150,181,59,145,29,218,89,58,219,160,11,10,169,167,101,18,105,211,103,217,143,236,93,97,29,184,11,32,120,192,111,72,126,138,217,167,240,193,165,77,109,209,143,4,134,29,72,12,67,240,237,227,243,223,244,103,70,252,73,157,153,82,71,129,180,209,156,206,248,29,193,113,35,209,95,180,42,172,213,7,34,219,243,86,137,118,179,237,66,209,41,219,10,148,52,214,33,248,52,150,233,88,65,137,251,203,246,108,102,98,141,142,23,26,71,93,215,99,96,73,231,56,221,76,220,158,133,153,128,178,187,31,100,126,209,122,30,149,152,156,18,152,184,217,230,137,6,249,154,190,182,70,78,18,242,55,225,52,162,104,68,55,165,233,187,51,60,47,82,141,214,23,11,75,193,169,12,4,0,0 };
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

