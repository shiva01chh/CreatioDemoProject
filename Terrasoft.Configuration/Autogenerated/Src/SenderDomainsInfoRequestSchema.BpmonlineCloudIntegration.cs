namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SenderDomainsInfoRequestSchema

	/// <exclude/>
	public class SenderDomainsInfoRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SenderDomainsInfoRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SenderDomainsInfoRequestSchema(SenderDomainsInfoRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("de4bf405-ea8f-4a2e-9f9c-d9b55688e01f");
			Name = "SenderDomainsInfoRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,61,79,195,48,16,134,103,42,245,63,156,194,2,139,179,247,131,129,22,33,134,162,170,97,67,12,110,122,9,150,98,59,220,57,149,74,197,127,199,31,73,85,138,16,94,172,123,115,247,230,222,199,96,164,70,110,101,137,240,130,68,146,109,229,196,194,154,74,213,29,73,167,172,17,139,135,98,101,119,216,240,120,116,28,143,198,163,171,142,149,169,161,56,176,67,45,54,157,113,74,163,40,144,148,108,212,103,156,153,198,190,107,194,218,23,176,104,36,243,4,10,52,59,164,165,213,82,25,126,50,149,221,224,71,135,236,98,111,158,231,48,227,78,107,73,135,187,190,142,115,80,89,2,74,157,224,44,212,232,128,163,19,236,146,21,40,239,37,6,143,252,194,100,198,136,178,97,11,37,97,53,207,254,13,41,238,37,163,15,179,87,37,246,11,102,144,7,183,215,165,116,210,79,57,146,165,123,243,66,219,109,27,85,66,25,215,252,43,29,76,224,183,163,31,78,40,79,140,214,100,91,36,167,208,131,90,71,223,244,253,146,75,20,30,209,49,120,44,28,110,247,142,208,146,221,171,128,36,188,230,64,105,192,227,1,138,147,213,57,158,148,104,133,122,139,116,243,28,38,231,144,13,86,161,206,110,67,204,33,39,59,10,239,190,62,107,128,99,248,211,52,44,50,133,175,62,145,7,145,66,197,58,169,63,69,175,133,243,13,86,154,163,139,124,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("de4bf405-ea8f-4a2e-9f9c-d9b55688e01f"));
		}

		#endregion

	}

	#endregion

}

