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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,143,193,106,3,33,16,134,207,46,236,59,12,233,165,189,228,1,18,122,40,105,11,57,20,10,77,31,96,162,179,70,48,42,142,82,66,200,187,119,92,183,61,148,46,46,226,239,247,255,243,27,240,76,156,80,19,28,40,103,228,56,149,245,46,134,201,217,154,177,184,24,198,225,58,14,170,178,11,22,118,153,154,182,126,149,173,102,58,68,107,189,232,219,113,16,36,213,163,119,26,180,71,102,248,184,240,147,57,187,240,25,92,89,104,22,166,69,253,1,79,241,75,230,21,212,101,31,126,45,176,129,197,245,70,5,13,22,108,198,235,60,71,169,187,76,86,154,129,248,184,228,170,75,204,188,129,247,57,118,65,150,25,255,167,223,63,192,92,68,169,61,191,4,60,122,50,240,8,146,68,219,46,63,19,235,236,82,123,190,92,172,58,195,96,28,39,143,23,136,19,232,30,10,76,158,244,204,201,42,39,130,202,148,33,161,165,85,207,186,253,116,166,96,122,237,46,136,222,254,27,180,163,124,223,251,78,142,55,136,1,0,0 };
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

