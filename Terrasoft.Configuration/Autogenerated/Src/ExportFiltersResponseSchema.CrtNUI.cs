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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,193,78,195,48,12,134,207,155,180,119,176,182,11,92,250,0,155,56,149,237,130,134,166,142,27,226,144,5,175,178,104,146,202,113,97,165,226,221,113,83,24,42,176,28,34,229,207,239,207,191,237,141,195,88,27,139,240,128,204,38,134,163,100,121,240,71,42,27,54,66,193,103,5,214,129,101,143,252,74,22,103,211,110,54,157,52,145,124,9,251,54,10,186,172,104,188,144,195,76,29,100,42,122,79,85,171,179,235,2,86,13,106,89,48,150,250,128,188,50,49,46,97,125,234,91,109,168,18,228,88,104,174,224,35,38,227,227,173,17,163,0,97,99,229,73,133,186,57,84,100,193,246,133,255,215,193,18,70,29,191,38,248,193,78,186,132,62,135,216,113,168,145,133,80,147,236,18,126,248,79,189,183,232,14,200,87,247,186,46,184,129,249,11,182,243,235,62,199,119,144,40,220,79,123,135,45,116,37,202,10,162,94,31,151,1,206,156,214,186,55,105,139,240,150,7,93,225,24,71,94,96,251,219,242,151,188,64,255,60,164,79,239,65,29,139,170,245,231,19,239,237,228,107,232,1,0,0 };
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

