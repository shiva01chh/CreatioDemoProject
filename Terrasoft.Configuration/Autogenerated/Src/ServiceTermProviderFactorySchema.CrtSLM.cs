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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,81,110,194,48,12,253,166,18,119,176,248,2,169,106,15,64,87,105,98,26,218,223,36,224,0,33,184,40,83,155,86,118,194,132,166,221,125,78,40,140,178,141,85,109,212,196,239,217,207,207,241,108,236,30,86,71,118,216,100,139,182,174,81,59,211,90,206,150,104,145,140,158,143,19,31,33,107,36,82,220,86,78,80,132,127,28,103,207,74,187,150,12,178,0,198,137,85,13,114,167,52,14,96,182,50,123,79,42,148,201,86,72,7,163,81,194,205,56,249,24,39,163,60,207,161,96,223,52,138,142,101,191,15,81,232,168,61,152,29,18,84,177,196,49,59,131,243,43,116,231,183,181,209,160,107,197,28,105,175,61,235,164,235,40,144,80,228,71,149,120,176,68,199,192,29,106,83,25,29,229,129,139,149,21,73,31,242,203,217,133,155,223,146,139,136,130,208,241,195,68,183,118,103,162,141,147,114,61,72,1,140,193,97,184,32,178,34,143,193,223,19,121,70,18,195,236,105,40,147,114,35,251,192,237,15,126,146,9,157,39,203,229,234,110,27,69,126,198,5,98,111,218,193,144,243,170,134,151,1,55,154,120,97,6,143,238,132,167,79,38,234,18,99,10,118,36,247,35,133,118,251,38,98,203,239,142,57,133,205,160,45,24,118,57,131,56,162,209,73,34,44,194,44,251,241,201,165,116,197,157,250,229,52,50,71,22,223,65,18,138,4,31,120,143,180,247,13,90,55,189,30,76,122,165,104,150,254,195,187,153,67,122,43,121,54,15,9,62,101,145,79,222,235,231,11,186,100,213,234,98,3,0,0 };
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

