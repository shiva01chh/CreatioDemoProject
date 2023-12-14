namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TermCalculationServiceUtilitiesSchema

	/// <exclude/>
	public class TermCalculationServiceUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TermCalculationServiceUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TermCalculationServiceUtilitiesSchema(TermCalculationServiceUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("609e8015-fad5-45e5-8005-deb9093949ca");
			Name = "TermCalculationServiceUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d862795b-510a-489d-988e-e22493fe3a79");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,148,77,111,219,48,12,134,207,9,144,255,64,32,231,185,247,166,216,48,164,192,144,195,128,32,201,173,216,65,81,152,64,168,45,121,148,52,32,11,250,223,71,73,241,71,221,52,174,179,77,7,91,162,45,242,17,249,138,90,20,104,75,33,17,54,72,36,172,217,187,108,110,244,94,29,60,9,167,140,206,216,94,204,69,46,125,30,215,107,164,95,74,226,100,124,154,140,39,227,145,183,74,31,96,125,180,14,139,89,103,157,173,188,118,170,192,140,247,40,145,171,223,209,193,44,238,155,18,30,120,1,243,92,88,123,15,103,175,33,214,10,127,122,180,46,254,117,199,3,30,172,47,10,65,199,207,201,0,211,48,210,179,121,199,73,118,254,227,225,174,181,229,233,81,56,193,71,114,36,164,251,193,134,210,111,115,37,161,20,228,152,10,100,32,184,8,48,74,71,172,89,151,100,74,228,77,200,192,203,232,36,125,239,66,54,148,145,232,45,82,98,250,142,197,22,41,16,85,72,223,188,218,85,36,11,78,224,98,7,39,8,223,71,7,116,179,56,177,231,201,75,120,244,4,191,45,254,146,148,33,229,142,215,131,95,13,221,196,31,74,96,29,5,253,172,56,225,60,141,122,217,176,130,250,72,166,168,119,169,72,113,157,172,109,227,168,43,57,232,104,206,150,70,91,172,68,247,70,115,95,147,76,62,73,214,145,80,26,9,246,134,128,144,37,21,92,6,149,131,208,59,176,38,247,181,101,144,28,47,200,176,98,122,95,135,240,1,33,174,218,144,195,170,193,86,12,233,255,82,59,233,43,198,21,77,174,187,169,185,133,163,114,242,127,68,113,207,231,44,184,188,118,163,228,179,109,250,192,199,219,80,235,253,170,51,13,107,77,73,11,151,89,78,125,29,169,167,37,212,52,131,47,229,218,120,146,88,213,226,230,230,208,202,210,48,140,220,196,206,208,36,229,95,32,12,166,216,26,147,195,130,11,82,95,245,191,160,184,169,65,207,133,197,254,230,252,74,232,23,181,31,141,60,254,0,22,241,109,248,3,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("609e8015-fad5-45e5-8005-deb9093949ca"));
		}

		#endregion

	}

	#endregion

}

