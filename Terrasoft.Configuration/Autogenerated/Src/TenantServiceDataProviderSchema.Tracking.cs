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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,193,110,219,48,12,61,59,64,255,129,200,46,49,48,216,247,165,9,48,116,195,208,75,87,32,233,174,131,106,211,129,48,91,50,40,42,64,16,244,223,71,75,118,26,187,115,118,177,45,250,241,241,61,146,50,170,65,215,170,2,97,143,68,202,217,138,179,7,107,42,125,240,164,88,91,147,237,73,21,127,180,57,220,45,206,119,139,196,59,249,28,97,9,215,151,120,119,138,217,176,9,135,49,151,0,5,250,137,240,32,7,120,168,149,115,95,96,224,255,166,88,61,147,61,234,18,41,224,242,60,135,123,231,155,70,209,105,219,159,123,0,104,83,89,106,2,41,84,100,27,96,52,202,48,56,164,163,46,48,27,210,243,171,252,214,191,214,186,128,162,43,43,14,58,252,46,194,175,75,195,156,162,228,28,84,93,228,203,159,22,137,53,138,135,103,210,71,197,24,1,83,221,33,176,59,57,198,70,244,49,11,179,3,35,125,7,241,0,175,202,225,68,61,120,170,179,11,211,181,133,164,141,133,192,49,197,57,116,121,95,203,146,208,185,93,207,253,212,81,111,182,176,28,124,68,212,11,213,203,117,111,1,77,25,93,220,178,100,25,11,198,50,66,38,133,127,243,192,185,158,181,188,255,96,10,142,170,246,56,107,173,47,56,54,39,37,160,91,188,36,57,32,247,95,137,174,96,21,81,217,163,123,242,117,253,147,190,55,45,159,86,239,186,210,116,0,39,239,193,126,43,227,82,102,50,147,161,103,217,15,228,95,157,184,213,139,232,149,255,70,164,72,75,62,207,183,56,205,246,118,23,52,172,210,117,95,137,144,61,153,105,119,146,228,13,176,150,49,159,255,7,11,175,240,124,187,61,41,81,40,254,125,193,150,186,89,133,205,190,177,125,87,112,176,21,168,120,9,102,6,17,34,173,34,213,132,45,221,44,253,168,37,203,237,163,144,41,35,35,21,170,113,187,178,251,60,36,198,129,198,251,54,123,211,38,173,134,113,153,84,46,98,119,55,86,211,240,25,254,221,155,24,29,7,67,108,177,248,11,144,35,98,205,229,4,0,0 };
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

