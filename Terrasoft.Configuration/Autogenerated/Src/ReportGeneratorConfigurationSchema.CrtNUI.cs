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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,193,106,195,48,12,134,207,45,244,29,12,189,142,62,192,58,118,233,70,233,45,180,221,3,168,142,154,105,56,182,145,148,67,8,123,247,41,78,24,172,27,171,15,6,253,254,252,255,178,28,161,69,201,224,209,157,145,25,36,93,117,179,75,241,74,77,199,160,148,226,106,57,172,150,139,78,40,54,238,212,139,98,187,189,169,141,15,1,253,8,203,102,143,17,153,188,49,70,173,25,27,83,221,46,128,200,163,59,98,78,172,133,0,77,124,19,99,124,238,46,129,188,243,35,126,135,94,12,229,198,119,68,197,41,35,43,161,229,84,197,102,58,159,45,247,29,213,179,227,25,219,28,64,241,80,187,193,53,168,91,39,227,246,249,155,127,141,74,218,159,252,59,182,240,118,31,63,162,79,92,255,203,189,80,25,19,112,255,36,202,54,194,7,151,46,31,54,187,231,185,185,10,216,62,68,145,229,47,151,53,198,122,122,111,169,39,245,167,88,52,91,95,204,33,70,76,216,1,0,0 };
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

