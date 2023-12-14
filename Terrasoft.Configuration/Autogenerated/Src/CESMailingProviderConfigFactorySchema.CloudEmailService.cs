namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CESMailingProviderConfigFactorySchema

	/// <exclude/>
	public class CESMailingProviderConfigFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CESMailingProviderConfigFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CESMailingProviderConfigFactorySchema(CESMailingProviderConfigFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("21e2f7e7-ec6e-4ec1-a3d8-235df40381e1");
			Name = "CESMailingProviderConfigFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bc5abc6e-45a7-497f-b7c0-68ae441d38e3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,201,106,195,48,16,61,39,208,127,24,210,75,10,197,190,103,49,164,38,45,57,4,74,151,15,80,149,177,35,176,37,51,146,82,66,233,191,87,150,148,196,78,19,10,245,193,198,163,55,111,25,141,100,53,234,134,113,132,55,36,98,90,21,38,201,149,44,68,105,137,25,161,228,205,240,235,102,56,176,90,200,178,7,33,156,94,169,39,143,140,27,69,2,181,67,56,204,45,97,233,136,32,175,152,214,19,200,151,175,107,38,42,215,247,76,106,39,54,72,65,47,116,237,125,75,154,166,48,211,182,174,25,237,179,248,31,209,26,106,52,91,181,209,80,40,2,78,232,92,58,11,66,106,195,36,119,162,160,10,48,91,116,253,136,237,121,49,31,173,46,10,142,210,44,57,104,165,29,177,198,126,84,130,3,111,237,254,229,22,38,112,153,252,152,102,240,229,19,29,167,176,14,238,39,240,236,101,194,225,121,94,95,200,219,108,46,79,140,134,23,130,93,115,23,163,253,206,22,42,13,35,86,131,116,87,63,31,89,237,155,36,242,246,182,71,217,170,163,214,81,122,239,195,28,255,44,245,52,39,86,66,99,73,234,236,37,124,255,235,123,150,30,136,90,230,120,25,151,135,28,71,116,176,60,238,155,132,126,180,59,104,23,121,48,216,49,2,148,165,144,184,160,82,195,28,36,126,130,131,105,67,182,189,51,87,181,53,74,51,62,31,205,253,57,225,244,200,199,43,101,55,75,79,234,8,253,162,199,5,72,158,208,204,30,154,90,73,103,31,243,19,46,27,159,76,116,153,66,176,232,234,202,152,198,177,33,128,147,87,164,157,224,184,104,132,235,235,88,233,28,4,188,127,133,233,70,33,95,255,142,27,138,114,19,150,212,255,135,106,191,232,107,237,243,3,137,35,249,142,55,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("21e2f7e7-ec6e-4ec1-a3d8-235df40381e1"));
		}

		#endregion

	}

	#endregion

}

