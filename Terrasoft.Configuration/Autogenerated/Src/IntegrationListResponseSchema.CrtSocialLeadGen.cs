namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationListResponseSchema

	/// <exclude/>
	public class IntegrationListResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationListResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationListResponseSchema(IntegrationListResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("56543138-4c89-c211-d5b8-8f2545d3e89d");
			Name = "IntegrationListResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d5eec482-a90e-42cc-86d3-ef2673139bae");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,143,205,106,195,48,16,132,207,49,248,29,22,122,183,239,113,200,197,133,80,8,52,52,121,1,85,94,187,2,89,50,187,114,66,48,125,247,174,101,39,117,250,163,139,216,209,104,246,27,167,90,228,78,105,132,19,18,41,246,117,200,74,239,106,211,244,164,130,241,46,59,122,109,148,221,163,170,118,232,210,100,72,147,85,207,198,53,112,188,114,192,86,220,214,162,30,173,156,137,3,201,232,34,77,196,245,68,216,136,10,165,85,204,107,120,113,1,155,41,115,111,56,188,201,90,249,130,209,154,231,57,108,184,111,91,69,215,237,60,151,214,247,21,208,108,131,231,211,43,92,76,248,0,227,106,79,109,204,1,95,203,120,143,5,43,185,217,45,46,95,228,117,253,187,53,26,244,72,242,31,8,172,225,161,170,232,225,64,254,108,42,164,111,216,213,16,129,239,229,196,209,33,5,131,210,240,16,183,76,239,63,27,69,97,135,129,193,19,240,120,255,5,254,155,252,134,62,146,110,22,228,219,101,13,134,1,26,12,197,24,92,192,231,76,136,174,154,32,227,60,169,143,98,212,228,124,1,37,241,226,188,5,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("56543138-4c89-c211-d5b8-8f2545d3e89d"));
		}

		#endregion

	}

	#endregion

}

