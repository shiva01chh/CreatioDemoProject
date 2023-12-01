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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,65,75,3,49,16,133,207,187,208,255,48,244,164,96,219,187,85,65,23,44,5,169,135,138,30,37,205,206,214,96,54,179,204,204,42,139,248,223,205,174,141,90,91,8,129,204,151,247,30,111,130,169,81,26,99,17,30,144,217,8,85,58,45,40,84,110,219,178,81,71,97,148,127,140,242,172,21,23,182,176,238,68,177,142,220,123,180,61,148,233,2,3,178,179,243,159,63,127,109,24,227,60,146,166,221,120,103,193,122,35,2,79,196,175,67,226,45,26,109,25,5,206,97,89,80,221,196,184,141,243,78,187,4,162,178,207,206,26,118,111,70,17,68,227,23,11,140,166,164,224,59,88,222,57,209,11,81,142,185,87,240,92,37,191,75,8,248,14,123,112,240,201,102,179,241,125,192,130,200,239,34,198,103,105,190,70,75,161,132,85,20,30,176,235,64,250,130,124,84,183,34,157,60,34,119,147,163,180,175,229,81,209,119,55,166,60,212,254,15,251,252,94,87,218,215,126,191,5,106,90,204,201,233,174,16,99,124,135,223,234,243,193,101,48,137,119,60,121,254,5,96,235,5,245,225,1,0,0 };
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

