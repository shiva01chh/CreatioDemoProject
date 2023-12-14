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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,80,209,74,195,64,16,124,78,161,255,176,244,73,193,182,239,86,5,13,88,10,82,31,42,250,40,215,235,166,30,94,110,195,238,70,9,226,191,187,137,141,90,219,227,56,184,157,157,25,102,146,43,81,42,231,17,30,144,217,9,21,58,201,41,21,97,91,179,211,64,105,56,248,24,14,178,90,66,218,194,170,17,197,210,240,24,209,183,160,76,230,152,144,131,159,253,236,252,149,97,180,185,33,85,189,142,193,131,143,78,4,158,136,95,59,199,91,116,90,51,10,156,195,34,167,178,50,187,117,136,65,155,30,48,102,235,157,85,28,222,156,34,136,218,138,7,70,183,161,20,27,88,220,5,209,11,81,54,223,43,120,46,122,189,75,72,248,14,123,96,167,147,77,167,163,251,132,57,81,220,89,140,206,250,249,10,61,165,13,44,141,120,128,93,39,210,23,228,163,188,37,233,248,17,185,25,31,69,219,88,17,21,99,115,227,54,135,220,255,102,159,223,117,245,125,237,231,155,163,246,197,156,156,238,2,49,218,63,253,70,159,117,42,157,136,189,118,237,124,1,32,98,144,127,226,1,0,0 };
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

