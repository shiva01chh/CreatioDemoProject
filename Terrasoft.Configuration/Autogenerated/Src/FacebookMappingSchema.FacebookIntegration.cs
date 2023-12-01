namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FacebookMappingSchema

	/// <exclude/>
	public class FacebookMappingSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FacebookMappingSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FacebookMappingSchema(FacebookMappingSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7d848782-ec7f-4a67-83bd-2846ad8a81d8");
			Name = "FacebookMapping";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("34c57733-6570-402b-8e25-5c50c5be2b38");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,81,107,194,48,20,133,159,43,248,31,2,123,81,24,253,1,202,30,68,230,155,67,208,61,141,49,210,238,90,194,98,18,110,110,28,69,252,239,187,77,179,90,75,237,67,105,79,78,206,249,238,53,242,4,222,201,18,196,1,16,165,183,71,202,215,214,28,85,21,80,146,178,38,223,219,82,73,61,157,92,166,147,44,120,101,42,177,175,61,193,105,57,157,176,242,132,80,177,75,172,181,244,126,33,54,156,84,88,251,179,149,206,177,53,90,62,86,68,168,138,64,240,238,101,5,179,238,247,32,177,2,242,249,14,173,3,164,250,89,172,180,182,191,219,160,73,57,13,226,69,16,6,152,127,114,134,11,133,86,165,40,155,150,97,137,88,136,46,146,173,151,88,122,3,179,198,115,76,73,22,153,111,23,115,90,71,202,28,164,205,216,221,132,26,94,204,92,52,67,103,217,27,127,51,77,35,45,163,176,147,8,134,88,106,205,249,235,201,81,29,143,174,169,29,204,119,11,112,79,147,70,85,48,100,65,117,150,4,41,79,124,117,85,9,50,233,17,164,101,226,205,165,175,12,129,2,154,222,165,134,130,223,254,102,137,103,204,123,150,58,244,61,215,241,122,23,231,27,1,72,131,63,68,232,93,28,129,112,255,107,123,128,209,223,90,210,238,23,201,26,63,127,181,189,229,200,180,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7d848782-ec7f-4a67-83bd-2846ad8a81d8"));
		}

		#endregion

	}

	#endregion

}

