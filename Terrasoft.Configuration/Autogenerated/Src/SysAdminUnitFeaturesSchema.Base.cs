namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysAdminUnitFeaturesSchema

	/// <exclude/>
	public class SysAdminUnitFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysAdminUnitFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysAdminUnitFeaturesSchema(SysAdminUnitFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d4b5d629-1e8b-41bd-915a-2e4ffb0cebcd");
			Name = "SysAdminUnitFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,143,193,106,67,33,16,69,215,79,120,255,48,164,155,118,147,15,72,232,162,164,45,100,81,40,52,253,128,137,206,51,130,81,113,148,18,66,254,189,227,243,181,139,82,80,196,235,185,119,174,1,207,196,9,53,193,129,114,70,142,83,89,239,98,152,156,173,25,139,139,97,84,215,81,13,149,93,176,176,203,212,180,245,171,28,53,211,33,90,235,69,223,142,74,144,84,143,222,105,208,30,153,225,227,194,79,230,236,194,103,112,101,161,89,152,22,245,7,60,197,47,153,87,80,151,125,248,181,192,6,22,215,27,21,52,88,176,25,175,243,156,97,184,203,100,165,25,136,143,75,174,186,196,204,27,120,159,99,23,100,153,241,127,250,253,3,204,69,134,97,207,47,1,143,158,12,60,130,36,209,182,203,207,196,58,187,212,190,47,15,171,206,48,24,199,201,227,5,226,4,186,135,2,147,39,61,115,178,202,137,160,50,101,72,104,105,213,179,110,63,157,41,152,94,187,11,162,183,125,131,118,85,234,27,199,123,31,89,135,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d4b5d629-1e8b-41bd-915a-2e4ffb0cebcd"));
		}

		#endregion

	}

	#endregion

}

