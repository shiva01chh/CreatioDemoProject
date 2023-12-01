namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetAvailableProvidersRequestSchema

	/// <exclude/>
	public class GetAvailableProvidersRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetAvailableProvidersRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetAvailableProvidersRequestSchema(GetAvailableProvidersRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7d23b130-a0c9-4a16-9005-a52b09ec2d91");
			Name = "GetAvailableProvidersRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,65,79,2,49,16,133,207,144,240,31,38,120,209,203,238,93,212,132,160,49,198,96,8,120,51,30,134,101,88,27,183,237,58,51,75,178,18,255,187,109,151,37,224,197,94,218,121,157,190,126,175,117,104,73,106,44,8,94,137,25,197,111,53,155,121,183,53,101,195,168,198,187,108,246,176,154,251,13,85,50,26,238,71,195,65,35,198,149,176,106,69,201,102,203,198,169,177,148,173,136,13,86,230,59,157,152,140,134,161,239,130,169,12,5,204,42,20,185,134,71,210,233,14,77,133,235,138,22,236,119,102,67,44,75,250,106,72,52,245,231,121,14,55,210,88,139,220,222,29,234,37,213,76,66,78,5,184,107,5,245,80,146,2,246,94,96,195,34,18,213,189,105,214,155,229,39,110,111,247,168,24,114,41,99,161,239,65,168,155,117,101,10,40,34,221,63,112,131,125,2,60,38,10,29,53,177,26,10,177,22,201,166,219,255,155,32,9,193,90,192,51,72,156,245,131,96,186,120,130,79,106,179,227,137,83,204,142,115,78,118,77,124,249,18,190,6,110,97,140,181,121,166,118,124,21,177,123,110,81,142,161,167,105,11,246,241,77,38,241,142,9,252,28,96,201,109,58,222,84,119,234,185,24,180,48,126,1,189,126,25,130,1,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7d23b130-a0c9-4a16-9005-a52b09ec2d91"));
		}

		#endregion

	}

	#endregion

}

