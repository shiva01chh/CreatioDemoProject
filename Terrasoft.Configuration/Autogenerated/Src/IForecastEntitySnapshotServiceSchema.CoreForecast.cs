namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastEntitySnapshotServiceSchema

	/// <exclude/>
	public class IForecastEntitySnapshotServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastEntitySnapshotServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastEntitySnapshotServiceSchema(IForecastEntitySnapshotServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3c7ea9e9-65c5-7705-1050-9886d7a946fc");
			Name = "IForecastEntitySnapshotService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,81,205,74,196,48,16,62,183,208,119,24,234,69,65,90,240,168,107,47,234,194,158,43,222,199,116,178,6,54,73,153,164,133,69,124,119,211,100,163,213,21,204,37,100,242,253,205,140,65,77,110,68,65,240,76,204,232,172,244,205,131,53,82,237,39,70,175,172,105,182,150,73,160,243,47,55,85,249,94,149,85,89,92,48,237,195,15,236,140,39,150,129,123,11,187,140,122,50,94,249,99,111,112,116,111,214,247,196,179,18,20,89,109,219,194,198,77,90,35,31,187,211,187,199,153,192,157,192,224,18,26,164,101,160,168,211,100,94,187,34,142,211,235,65,9,80,217,253,95,243,34,196,46,206,252,191,2,184,239,4,3,122,252,101,127,238,159,42,35,50,106,48,97,124,247,117,230,215,93,246,6,77,30,23,181,102,211,70,228,223,68,169,14,161,137,186,219,198,27,196,143,193,175,153,179,85,67,12,155,13,46,115,207,185,240,184,68,207,65,174,33,41,166,77,66,178,185,186,11,74,31,105,131,100,134,180,196,229,25,107,235,243,9,38,224,153,2,21,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3c7ea9e9-65c5-7705-1050-9886d7a946fc"));
		}

		#endregion

	}

	#endregion

}

