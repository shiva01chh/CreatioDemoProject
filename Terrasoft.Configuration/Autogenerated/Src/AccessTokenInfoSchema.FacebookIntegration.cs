namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccessTokenInfoSchema

	/// <exclude/>
	public class AccessTokenInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccessTokenInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccessTokenInfoSchema(AccessTokenInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("edcf69f4-2a5f-419d-9855-0d3c0ba8478a");
			Name = "AccessTokenInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("34c57733-6570-402b-8e25-5c50c5be2b38");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,148,219,78,195,48,12,134,175,55,137,119,136,198,13,220,244,1,24,32,161,113,80,37,134,38,54,184,65,83,149,102,94,21,150,37,81,156,34,14,226,221,113,211,118,231,14,169,189,74,237,223,254,108,231,160,249,18,208,114,1,108,2,206,113,52,115,31,13,140,158,203,44,119,220,75,163,163,177,17,146,171,147,238,207,73,183,147,163,212,25,27,127,161,135,101,127,231,159,194,148,2,81,196,96,244,0,26,156,20,123,154,231,92,123,185,132,104,76,94,174,228,119,64,172,85,247,84,72,106,204,130,44,100,59,117,144,145,155,13,20,71,188,96,55,66,0,226,196,44,64,199,122,110,130,228,109,149,40,85,48,45,12,183,220,115,106,192,59,46,124,97,176,121,170,164,96,162,200,177,159,162,243,19,210,172,80,35,103,44,56,47,129,120,163,16,89,250,67,218,33,44,83,112,103,79,52,50,118,197,122,124,157,172,119,62,13,170,186,254,33,183,150,250,57,171,52,137,223,16,85,5,161,119,69,199,27,21,177,98,194,157,78,6,190,31,22,88,45,126,143,148,96,109,60,107,134,91,155,200,217,97,108,17,216,14,72,89,194,174,29,195,238,104,246,216,181,191,69,5,240,105,165,3,188,241,141,252,74,145,112,191,141,87,134,224,119,117,120,123,116,220,220,122,141,150,186,25,29,183,233,90,226,43,157,242,230,173,150,152,124,108,8,42,44,73,20,139,203,208,86,80,204,97,118,100,210,165,224,240,160,227,42,184,5,23,5,93,66,108,164,110,185,43,228,163,68,127,105,210,119,122,127,174,217,56,8,90,128,195,53,157,124,89,104,100,7,69,226,215,146,237,163,61,169,19,180,128,231,8,238,200,101,46,220,77,183,249,37,132,254,195,60,5,61,43,95,185,240,95,90,183,141,100,219,252,254,0,79,234,133,117,28,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("edcf69f4-2a5f-419d-9855-0d3c0ba8478a"));
		}

		#endregion

	}

	#endregion

}

