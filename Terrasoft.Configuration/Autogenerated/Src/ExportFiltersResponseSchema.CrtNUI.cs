namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExportFiltersResponseSchema

	/// <exclude/>
	public class ExportFiltersResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExportFiltersResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExportFiltersResponseSchema(ExportFiltersResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("83451a60-7d62-4ce4-941d-7458d5f504cd");
			Name = "ExportFiltersResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,193,78,195,48,12,134,207,155,180,119,176,182,11,92,250,0,155,56,149,113,65,67,83,199,13,113,200,130,87,89,52,73,229,184,176,82,241,238,184,41,12,10,44,135,72,249,243,251,243,111,123,227,48,214,198,34,220,35,179,137,225,32,89,30,252,129,202,134,141,80,240,89,129,117,96,217,33,191,144,197,217,180,155,77,39,77,36,95,194,174,141,130,46,43,26,47,228,48,83,7,153,138,222,82,213,234,228,58,131,85,131,90,22,140,165,62,32,175,76,140,75,88,31,251,86,55,84,9,114,44,52,87,240,17,147,241,225,218,136,81,128,176,177,242,168,66,221,236,43,178,96,251,194,255,235,96,9,163,142,159,19,124,99,39,93,66,159,66,108,57,212,200,66,168,73,182,9,63,252,167,222,27,116,123,228,139,59,93,23,92,193,252,25,219,249,101,159,227,43,72,20,238,167,189,197,22,186,18,101,5,81,175,247,243,0,103,142,107,221,155,180,69,120,205,131,174,112,140,35,47,176,249,109,249,75,94,160,127,26,210,167,247,160,142,69,213,126,158,15,220,44,25,152,240,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83451a60-7d62-4ce4-941d-7458d5f504cd"));
		}

		#endregion

	}

	#endregion

}

