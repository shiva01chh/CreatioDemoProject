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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,143,209,106,3,33,16,69,159,93,216,127,24,210,151,246,37,31,144,208,135,146,166,144,135,66,33,233,7,76,220,89,35,24,21,71,9,33,228,223,59,174,219,82,74,23,23,241,122,238,157,171,199,51,113,68,77,112,160,148,144,195,152,151,155,224,71,107,74,194,108,131,239,187,91,223,169,194,214,27,216,36,170,218,242,77,182,146,232,16,140,113,162,175,251,78,144,88,142,206,106,208,14,153,97,127,229,151,225,108,253,167,183,121,166,89,152,26,245,7,60,133,139,204,203,168,243,206,255,88,96,5,179,235,157,50,14,152,177,26,111,211,28,165,30,18,25,105,6,226,227,156,138,206,33,241,10,62,166,216,25,153,103,252,159,254,248,4,83,17,165,118,188,245,120,116,52,192,51,72,18,173,155,252,74,172,147,141,245,249,114,177,104,12,195,96,57,58,188,66,24,65,183,80,96,114,164,39,78,86,62,17,20,166,4,17,13,45,90,214,253,187,51,249,161,213,110,130,232,245,191,67,61,254,250,190,0,8,212,39,66,144,1,0,0 };
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

