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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,77,107,219,64,16,61,43,144,255,48,184,23,11,130,116,175,99,67,73,74,201,37,13,216,233,181,108,164,145,89,42,237,138,217,89,131,49,249,239,29,237,74,142,165,84,174,15,178,118,244,246,205,123,243,97,84,131,174,85,5,194,14,137,148,179,21,103,15,214,84,122,239,73,177,182,38,219,145,42,254,104,179,191,189,57,221,222,36,222,201,235,8,75,184,58,199,187,83,188,13,235,112,24,115,9,80,160,95,8,247,114,128,135,90,57,247,21,6,254,71,197,234,133,236,65,151,72,1,151,231,57,220,59,223,52,138,142,155,254,220,3,64,155,202,82,19,72,161,34,219,0,163,81,134,193,33,29,116,129,217,112,61,191,184,223,250,183,90,23,80,116,105,197,65,135,223,70,248,101,106,152,83,148,156,130,170,179,124,249,210,34,177,70,241,240,66,250,160,24,35,96,170,59,4,182,71,199,216,136,62,102,97,118,96,164,238,32,30,224,77,57,156,168,7,79,117,118,102,186,180,144,180,49,17,56,166,216,135,238,222,183,178,36,116,110,219,115,63,119,212,235,13,44,6,31,17,245,74,245,98,213,91,64,83,70,23,215,44,89,198,130,177,140,144,73,226,223,60,112,174,102,45,239,62,153,130,131,170,61,206,90,235,19,142,205,73,10,232,6,47,73,246,200,253,91,162,43,88,70,84,246,228,158,125,93,255,164,239,77,203,199,229,135,174,52,29,192,201,71,176,159,202,56,148,153,244,100,168,89,246,3,249,87,39,110,249,42,122,229,187,17,41,82,146,187,249,18,167,217,206,110,131,134,101,186,234,51,17,178,39,51,173,78,146,188,3,214,210,230,211,255,96,225,47,60,223,175,119,74,20,138,127,95,176,165,174,87,97,178,175,76,223,5,28,108,5,42,46,193,76,35,66,164,85,164,154,48,165,235,133,31,149,100,177,121,18,50,101,164,165,66,53,46,87,118,159,135,139,177,161,113,223,102,55,109,82,106,24,167,73,101,17,187,221,88,78,195,39,248,119,109,98,116,28,12,49,249,253,5,244,247,21,194,230,4,0,0 };
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

