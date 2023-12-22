namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RootAccountInfoResponseSchema

	/// <exclude/>
	public class RootAccountInfoResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RootAccountInfoResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RootAccountInfoResponseSchema(RootAccountInfoResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8c2134ec-81df-40a8-823f-e035797122bd");
			Name = "RootAccountInfoResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,223,106,131,48,20,198,175,43,248,14,7,122,175,247,221,24,108,14,134,48,88,177,237,3,164,241,104,3,154,200,201,113,163,148,189,251,98,162,157,27,116,80,86,47,2,231,207,247,157,223,73,212,162,69,219,9,137,176,69,34,97,77,197,73,102,116,165,234,158,4,43,163,227,232,20,71,113,180,88,18,214,46,132,172,17,214,174,160,48,134,31,165,52,189,230,92,87,166,112,38,70,91,244,173,105,154,194,189,237,219,86,208,241,97,140,179,198,244,37,208,216,6,207,219,55,248,80,124,0,229,196,212,250,73,32,246,166,103,16,193,53,153,140,210,153,83,215,239,27,37,65,14,12,151,16,96,5,79,194,226,88,249,6,91,132,61,206,139,172,201,116,72,172,208,109,179,246,190,161,254,155,62,224,19,14,140,176,43,94,147,115,211,156,108,66,179,76,74,215,83,255,142,26,56,65,141,124,7,118,56,62,255,24,241,130,108,193,208,208,104,129,15,8,114,156,41,27,133,154,65,149,238,84,149,66,186,134,32,243,226,188,188,25,134,69,151,224,235,17,54,94,247,127,140,112,13,124,116,21,122,71,186,246,69,242,81,190,241,234,11,239,179,68,93,134,191,196,199,33,251,51,233,115,243,239,11,250,28,244,121,73,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8c2134ec-81df-40a8-823f-e035797122bd"));
		}

		#endregion

	}

	#endregion

}

