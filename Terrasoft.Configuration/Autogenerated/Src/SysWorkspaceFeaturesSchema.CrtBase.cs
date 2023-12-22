namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysWorkspaceFeaturesSchema

	/// <exclude/>
	public class SysWorkspaceFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysWorkspaceFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysWorkspaceFeaturesSchema(SysWorkspaceFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f433f309-ae33-4c7e-b563-db6b55384ed9");
			Name = "SysWorkspaceFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,80,93,75,3,49,16,124,190,66,255,195,210,39,5,219,190,91,21,244,192,82,144,250,80,209,71,73,115,123,53,152,203,30,187,123,74,16,255,187,185,179,167,253,10,33,144,157,157,25,102,130,169,80,106,99,17,158,144,217,8,149,58,201,41,148,110,211,176,81,71,97,56,248,26,14,178,70,92,216,192,42,138,98,149,112,239,209,182,160,76,230,24,144,157,157,253,237,236,202,48,166,121,66,234,102,237,157,5,235,141,8,188,16,191,119,142,247,104,180,97,20,184,132,69,78,85,157,236,214,206,59,141,61,144,152,173,119,86,179,251,48,138,32,154,86,44,48,154,130,130,143,176,120,112,162,87,162,156,124,111,224,181,236,245,174,33,224,39,236,129,157,78,54,157,142,30,3,230,68,126,107,49,186,232,231,43,180,20,10,88,38,226,17,118,27,72,223,144,79,242,150,164,227,103,228,56,62,137,182,177,60,42,250,120,103,138,99,238,161,217,247,111,93,125,95,251,249,230,168,125,49,103,231,219,64,140,233,31,254,163,207,58,149,78,36,189,233,238,156,31,201,157,18,64,234,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f433f309-ae33-4c7e-b563-db6b55384ed9"));
		}

		#endregion

	}

	#endregion

}

