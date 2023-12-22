namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportGeneratorConfigurationSchema

	/// <exclude/>
	public class ReportGeneratorConfigurationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportGeneratorConfigurationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportGeneratorConfigurationSchema(ReportGeneratorConfigurationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd36e74f-9114-4b76-b9c4-17f67f21a2f8");
			Name = "ReportGeneratorConfiguration";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,193,78,195,48,12,134,207,155,180,119,136,180,43,218,3,48,196,101,160,137,91,181,141,7,240,82,175,24,165,73,100,187,135,170,226,221,113,211,10,193,64,44,135,72,254,243,229,255,29,39,66,139,146,193,163,59,33,51,72,186,232,102,151,226,133,154,142,65,41,197,213,114,88,45,23,157,80,108,220,177,23,197,118,123,85,27,31,2,250,17,150,205,30,35,50,121,99,140,90,51,54,166,186,93,0,145,123,119,192,156,88,11,1,154,248,42,198,248,220,157,3,121,231,71,252,6,189,24,202,141,175,136,138,83,70,86,66,203,169,138,205,116,62,91,238,59,170,103,199,19,182,57,128,226,75,237,6,215,160,110,157,140,219,199,111,254,57,42,105,127,244,111,216,194,235,109,252,128,62,113,253,47,247,68,101,76,192,253,131,40,219,8,239,92,58,191,219,236,30,231,230,42,96,251,16,69,150,191,92,214,24,235,233,189,165,158,212,159,98,209,190,175,79,151,154,194,225,225,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd36e74f-9114-4b76-b9c4-17f67f21a2f8"));
		}

		#endregion

	}

	#endregion

}

