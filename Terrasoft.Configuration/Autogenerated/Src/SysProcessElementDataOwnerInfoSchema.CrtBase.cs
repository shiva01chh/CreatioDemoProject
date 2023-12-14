namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysProcessElementDataOwnerInfoSchema

	/// <exclude/>
	public class SysProcessElementDataOwnerInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysProcessElementDataOwnerInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysProcessElementDataOwnerInfoSchema(SysProcessElementDataOwnerInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6f11982c-9819-47d8-bc8d-e74e12e283ba");
			Name = "SysProcessElementDataOwnerInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,81,203,106,195,48,16,60,219,224,127,88,200,221,190,55,165,151,52,20,95,146,64,250,3,170,181,114,5,150,100,164,21,198,152,254,123,245,72,130,41,165,41,173,14,66,154,29,205,204,174,52,83,232,70,214,33,188,162,181,204,25,65,245,206,104,33,123,111,25,73,163,171,114,169,202,194,59,169,123,56,207,142,80,109,171,50,32,27,139,125,40,195,110,96,206,61,196,210,201,154,14,157,219,15,168,80,211,51,35,118,156,52,218,86,11,147,94,52,77,3,143,206,43,197,236,252,116,185,159,201,88,116,32,3,199,170,228,7,26,163,74,224,0,25,232,222,153,238,17,76,20,2,35,96,204,30,128,217,4,120,112,169,175,218,205,74,124,244,111,131,236,160,139,233,238,134,43,150,20,240,214,83,32,143,104,73,98,104,236,148,132,114,253,107,7,9,104,121,16,148,66,230,128,241,76,115,125,99,175,51,93,67,189,120,201,97,159,136,45,135,5,122,164,45,184,184,125,220,241,17,146,46,62,102,224,223,14,35,143,234,23,254,199,129,231,9,252,53,129,198,233,127,9,14,56,253,144,96,131,154,231,239,72,247,140,174,193,162,42,3,24,214,39,74,4,221,144,195,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6f11982c-9819-47d8-bc8d-e74e12e283ba"));
		}

		#endregion

	}

	#endregion

}

