namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ServiceTermProviderFactorySchema

	/// <exclude/>
	public class ServiceTermProviderFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ServiceTermProviderFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ServiceTermProviderFactorySchema(ServiceTermProviderFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("af9b1e78-e018-487e-9a15-deed4c262d47");
			Name = "ServiceTermProviderFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,81,110,194,48,12,253,6,137,59,88,124,129,84,181,7,160,171,52,49,13,237,111,18,112,128,16,92,148,169,77,43,59,97,170,166,221,125,78,40,140,178,141,85,109,212,196,239,217,207,207,241,108,236,1,214,29,59,172,211,101,83,85,168,157,105,44,167,43,180,72,70,47,38,99,31,33,27,36,82,220,148,78,80,132,127,28,167,207,74,187,134,12,178,0,38,99,171,106,228,86,105,28,192,108,105,14,158,84,40,147,174,145,142,70,163,132,235,201,248,99,50,30,101,89,6,57,251,186,86,212,21,253,62,68,161,165,230,104,246,72,80,198,18,93,122,6,103,87,232,214,239,42,163,65,87,138,57,210,94,123,214,73,87,39,144,80,228,71,149,120,176,66,199,192,45,106,83,26,29,229,129,139,149,21,73,31,242,203,233,133,155,221,146,243,136,130,208,241,195,84,55,118,111,162,141,211,98,51,72,1,140,193,97,184,32,210,60,139,193,223,19,121,70,18,195,236,105,40,211,98,43,251,192,237,15,126,146,9,157,39,203,197,250,110,27,121,118,198,5,98,111,218,209,144,243,170,130,151,1,55,154,120,97,6,143,238,132,103,79,38,234,18,99,114,118,36,247,35,129,102,247,38,98,139,239,142,57,129,237,160,45,24,118,57,135,56,162,209,73,34,44,195,44,251,241,201,165,116,249,157,250,197,44,50,71,22,223,65,18,138,4,31,120,143,116,240,53,90,55,187,30,76,114,165,104,158,252,195,187,153,67,114,43,121,190,8,9,62,101,145,79,222,240,124,1,198,105,176,56,90,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("af9b1e78-e018-487e-9a15-deed4c262d47"));
		}

		#endregion

	}

	#endregion

}

