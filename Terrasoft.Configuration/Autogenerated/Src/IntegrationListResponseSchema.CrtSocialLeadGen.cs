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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,143,205,106,195,48,16,132,207,49,228,29,22,122,183,239,113,200,197,133,80,8,52,52,121,1,85,94,187,11,178,100,118,229,150,96,250,238,149,100,39,117,250,163,139,216,209,104,246,27,171,58,148,94,105,132,51,50,43,113,141,207,43,103,27,106,7,86,158,156,205,79,78,147,50,7,84,245,30,237,58,27,215,217,106,16,178,45,156,46,226,177,11,110,99,80,71,171,228,193,129,76,186,92,103,193,245,192,216,6,21,42,163,68,54,240,100,61,182,83,230,129,196,191,132,181,225,11,38,107,81,20,176,149,161,235,20,95,118,243,92,25,55,212,192,179,13,30,207,207,240,65,254,13,200,54,142,187,148,3,174,9,227,45,22,76,200,205,175,113,197,34,175,31,94,13,105,208,145,228,63,16,216,192,93,213,160,251,35,187,119,170,145,191,97,87,99,2,190,149,11,142,30,217,19,134,134,199,180,101,122,255,217,40,9,123,244,2,142,65,226,253,23,248,111,242,43,122,36,221,46,200,119,203,26,2,35,180,232,203,24,92,194,231,76,136,182,158,32,211,60,169,247,98,210,226,249,2,37,48,111,121,6,2,0,0 };
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

