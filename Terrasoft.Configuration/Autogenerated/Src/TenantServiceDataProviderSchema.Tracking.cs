namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TenantServiceDataProviderSchema

	/// <exclude/>
	public class TenantServiceDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TenantServiceDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TenantServiceDataProviderSchema(TenantServiceDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("187f0e27-7e57-4243-a537-36ca44a321f2");
			Name = "TenantServiceDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,77,107,219,64,16,61,43,144,255,48,184,23,9,130,116,175,99,67,73,74,201,37,13,216,233,181,108,164,145,89,42,237,138,217,93,131,49,249,239,157,221,149,28,73,169,92,31,100,237,232,237,155,247,230,67,137,22,77,39,74,132,61,18,9,163,107,155,63,104,85,203,131,35,97,165,86,249,158,68,249,71,170,195,237,205,249,246,38,113,134,95,39,88,194,245,37,238,79,241,54,108,194,97,202,197,64,134,126,33,60,240,1,30,26,97,204,87,24,248,31,133,21,47,164,143,178,66,10,184,162,40,224,222,184,182,21,116,218,246,231,30,0,82,213,154,218,64,10,53,233,22,44,42,161,44,24,164,163,44,49,31,174,23,163,251,157,123,107,100,9,165,79,203,14,60,126,23,225,227,212,176,164,40,57,7,85,23,249,252,165,67,178,18,217,195,11,201,163,176,24,1,115,221,33,176,59,25,139,45,235,179,150,153,13,40,174,59,176,7,120,19,6,103,234,193,81,147,95,152,198,22,146,46,38,2,99,41,246,193,223,251,86,85,132,198,236,122,238,103,79,189,217,194,106,240,17,81,175,212,172,214,189,5,84,85,116,113,205,146,182,88,90,172,34,100,150,248,183,29,56,215,139,150,247,159,76,193,81,52,14,23,173,245,9,167,230,56,5,248,193,75,146,3,218,254,45,145,53,164,17,149,63,153,103,215,52,63,233,123,219,217,83,250,161,43,203,6,112,242,17,236,167,50,14,101,206,61,25,106,150,255,64,251,203,139,75,95,89,47,127,87,44,133,75,114,183,92,226,44,223,235,93,208,144,102,235,62,19,161,117,164,230,213,73,146,119,192,134,219,124,254,31,44,252,133,231,251,245,78,177,66,246,239,74,171,201,247,42,76,246,149,233,27,193,65,215,32,226,18,44,52,34,68,58,65,162,13,83,186,89,185,73,73,86,219,39,38,19,138,91,202,84,211,114,229,247,69,184,24,27,26,247,109,113,211,102,165,134,105,154,140,23,209,239,70,58,15,159,225,223,181,137,209,105,48,196,70,191,191,122,245,159,217,238,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("187f0e27-7e57-4243-a537-36ca44a321f2"));
		}

		#endregion

	}

	#endregion

}

