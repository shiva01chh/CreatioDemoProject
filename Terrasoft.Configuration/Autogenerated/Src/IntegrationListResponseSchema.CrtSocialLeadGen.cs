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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,143,205,106,195,48,16,132,207,49,248,29,22,122,183,239,113,200,197,133,80,8,52,52,121,1,85,94,187,11,178,100,118,229,132,96,250,238,149,101,39,117,250,163,139,216,209,104,246,27,171,90,148,78,105,132,19,50,43,113,181,207,74,103,107,106,122,86,158,156,205,142,78,147,50,123,84,213,14,109,154,12,105,178,234,133,108,3,199,171,120,108,131,219,24,212,163,85,178,224,64,38,93,164,73,112,61,49,54,65,133,210,40,145,53,188,88,143,205,148,185,39,241,111,97,109,248,130,209,154,231,57,108,164,111,91,197,215,237,60,151,198,245,21,240,108,131,231,211,43,92,200,127,0,217,218,113,27,115,192,213,97,188,199,130,9,185,217,45,46,95,228,117,253,187,33,13,122,36,249,15,4,214,240,80,53,232,254,192,238,76,21,242,55,236,106,136,192,247,114,193,209,33,123,194,208,240,16,183,76,239,63,27,69,97,135,94,192,49,200,120,255,5,254,155,252,134,62,146,110,22,228,219,101,13,129,1,26,244,197,24,92,192,231,76,136,182,154,32,227,60,169,143,98,212,150,231,11,95,53,60,215,14,2,0,0 };
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

