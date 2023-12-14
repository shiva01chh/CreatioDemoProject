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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,80,203,106,195,48,16,60,219,224,127,88,210,187,117,79,210,92,10,5,31,10,129,230,7,84,101,229,10,172,7,187,114,193,132,254,123,21,73,14,105,32,58,237,206,206,206,204,202,73,139,28,164,66,56,33,145,100,175,99,255,230,157,54,227,76,50,26,239,186,246,210,181,205,204,198,141,240,185,112,68,187,235,218,132,188,16,142,105,12,131,139,72,58,9,108,97,248,144,102,74,188,35,249,31,115,70,42,58,153,45,132,128,61,207,214,74,90,14,181,175,52,6,149,121,224,53,196,111,4,91,68,32,84,149,126,93,23,119,251,97,254,154,140,2,179,154,63,245,110,46,217,255,22,55,205,3,82,52,200,91,56,102,145,50,127,12,152,129,193,113,148,46,169,215,104,123,70,4,69,168,95,55,171,223,9,109,152,100,196,119,169,162,167,101,35,14,253,77,238,62,112,243,100,1,30,251,235,111,55,205,136,113,151,11,174,197,111,61,3,221,185,92,146,251,130,254,7,51,118,125,127,195,74,112,34,219,1,0,0 };
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

