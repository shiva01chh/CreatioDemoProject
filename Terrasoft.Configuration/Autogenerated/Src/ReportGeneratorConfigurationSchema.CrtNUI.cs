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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,193,106,195,48,12,134,207,45,244,29,4,189,142,62,192,58,118,233,70,233,45,180,221,3,168,142,154,121,56,182,145,148,67,8,123,247,41,78,24,172,27,171,15,6,253,254,252,255,178,28,177,37,201,232,8,206,196,140,146,174,186,217,165,120,245,77,199,168,62,197,213,114,88,45,23,157,248,216,192,169,23,165,118,123,83,27,31,2,185,17,150,205,158,34,177,119,198,24,181,102,106,76,133,93,64,145,71,56,82,78,172,133,64,77,124,19,99,124,238,46,193,59,112,35,126,135,94,12,229,198,119,68,197,41,19,171,39,203,169,138,205,116,62,91,238,59,95,207,142,103,106,115,64,165,67,13,3,52,164,91,144,113,251,252,205,191,70,245,218,159,220,59,181,248,118,31,63,146,75,92,255,203,189,248,50,38,228,254,73,148,109,132,15,144,46,31,54,187,231,185,185,10,217,62,68,137,229,47,151,53,197,122,122,111,169,39,245,167,88,180,113,125,1,41,206,73,160,217,1,0,0 };
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

