namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISearchProviderSchema

	/// <exclude/>
	public class ISearchProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISearchProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISearchProviderSchema(ISearchProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ce4a57cc-37d9-4a85-b56a-a7ea95f370e8");
			Name = "ISearchProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,145,193,110,131,48,12,134,207,69,234,59,88,221,101,147,38,114,111,25,151,109,154,56,76,234,196,94,32,128,161,145,72,96,118,50,9,85,123,247,133,0,45,235,114,137,98,127,254,127,199,54,82,35,247,178,68,248,68,34,201,93,109,227,231,206,212,170,113,36,173,234,204,54,58,111,163,141,99,101,26,200,7,182,168,125,190,109,177,28,147,28,191,161,65,82,229,97,27,121,234,142,176,241,81,200,140,69,170,189,232,30,178,28,37,149,167,35,117,223,170,66,10,152,16,2,18,118,90,75,26,210,249,61,97,208,207,92,188,96,98,197,245,174,104,85,9,106,81,255,47,190,57,7,131,75,35,239,104,79,93,197,123,56,134,210,41,121,107,191,242,103,40,6,248,114,72,67,124,33,197,45,154,244,146,164,6,227,39,247,180,227,80,247,49,150,236,210,249,19,147,64,34,2,119,45,35,180,142,12,47,20,33,187,214,178,231,150,196,72,102,175,198,105,36,89,180,152,188,168,48,100,239,157,176,37,191,128,71,152,238,52,157,251,189,207,175,246,176,106,229,225,48,207,1,77,53,141,34,188,127,166,45,253,9,250,216,250,252,2,109,125,105,250,16,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ce4a57cc-37d9-4a85-b56a-a7ea95f370e8"));
		}

		#endregion

	}

	#endregion

}

