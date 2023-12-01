namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetAvailableProvidersResponseSchema

	/// <exclude/>
	public class GetAvailableProvidersResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetAvailableProvidersResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetAvailableProvidersResponseSchema(GetAvailableProvidersResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a32e2754-ebd1-43a6-8c8d-70af49bb850d");
			Name = "GetAvailableProvidersResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,84,193,110,219,48,12,61,59,64,254,129,232,46,27,80,216,247,37,11,48,164,69,145,67,135,32,217,109,216,65,145,233,68,128,44,25,162,148,162,11,246,239,163,20,59,113,146,22,67,139,0,245,73,164,200,199,247,72,90,70,212,72,141,144,8,63,209,57,65,182,242,249,212,154,74,173,131,19,94,89,147,79,239,151,143,182,68,77,195,193,110,56,200,2,41,179,134,229,51,121,172,57,82,107,148,49,140,242,7,52,232,148,28,157,199,44,130,241,170,198,124,201,183,66,171,63,9,149,163,56,238,147,195,53,27,48,213,130,232,43,60,160,255,190,21,74,139,149,198,185,179,91,85,162,163,5,211,99,120,76,9,69,81,192,152,66,93,11,247,60,105,237,5,54,14,9,141,39,240,27,4,62,7,237,193,86,201,242,27,103,189,215,145,14,201,13,150,65,99,222,225,20,61,160,95,119,194,11,214,237,157,144,254,55,59,154,176,210,74,130,140,204,254,71,44,219,37,114,7,57,28,210,160,243,10,89,211,60,225,236,239,207,217,39,7,99,19,88,7,132,173,0,121,232,105,20,33,186,186,80,243,33,234,104,58,2,249,1,179,175,100,47,229,17,235,21,186,207,63,120,186,240,13,110,196,5,251,155,47,81,101,39,115,118,111,66,141,46,70,140,187,144,153,169,236,4,46,117,195,14,214,232,71,145,240,8,254,182,202,209,148,123,241,201,222,123,251,206,236,114,218,253,58,31,57,220,83,30,215,155,165,128,173,208,1,65,153,82,73,94,122,102,249,180,65,230,237,18,249,110,140,160,136,71,110,12,143,28,203,87,70,154,60,9,237,104,202,137,119,1,199,133,156,128,170,94,71,28,129,141,37,159,20,225,109,76,170,132,166,148,213,43,117,68,126,105,119,20,77,59,176,211,165,89,89,171,97,118,188,61,95,140,44,187,122,163,74,172,68,92,128,138,115,15,18,65,72,105,249,145,185,90,243,218,42,215,104,221,221,30,234,197,198,181,119,239,109,91,100,109,98,33,123,170,224,13,207,66,151,18,237,83,138,228,93,156,195,188,23,240,174,255,126,56,96,31,127,255,0,69,195,1,187,103,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a32e2754-ebd1-43a6-8c8d-70af49bb850d"));
		}

		#endregion

	}

	#endregion

}

