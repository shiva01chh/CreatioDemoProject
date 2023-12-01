namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingProviderConfigSchema

	/// <exclude/>
	public class IMailingProviderConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingProviderConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingProviderConfigSchema(IMailingProviderConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6ab8d5ed-b75b-496a-b8f0-ba3fbf460468");
			Name = "IMailingProviderConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,80,203,106,195,48,16,60,219,224,127,88,210,187,117,79,210,92,10,5,31,2,129,230,7,84,101,229,10,172,7,187,114,193,132,254,123,85,73,14,105,32,58,237,206,206,206,204,202,73,139,28,164,66,56,35,145,100,175,99,255,230,157,54,227,76,50,26,239,186,246,218,181,205,204,198,141,240,177,112,68,187,235,218,132,188,16,142,105,12,131,139,72,58,9,108,97,56,74,51,37,222,137,252,183,185,32,21,157,204,22,66,192,158,103,107,37,45,135,218,87,26,131,202,60,240,26,226,23,130,45,34,16,170,74,191,174,139,187,253,48,127,78,70,129,89,205,159,122,55,215,236,127,139,155,230,1,41,26,228,45,156,178,72,153,63,6,204,192,224,56,74,151,212,107,180,61,35,130,34,212,175,155,213,239,140,54,76,50,226,187,84,209,211,178,17,135,254,38,119,31,184,121,178,0,143,253,223,111,55,205,136,113,151,11,174,197,79,61,3,221,165,92,146,251,130,254,7,51,150,222,47,154,10,54,125,218,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6ab8d5ed-b75b-496a-b8f0-ba3fbf460468"));
		}

		#endregion

	}

	#endregion

}

