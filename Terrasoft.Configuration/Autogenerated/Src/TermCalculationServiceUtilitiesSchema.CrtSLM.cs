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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,148,77,143,218,48,16,134,207,68,226,63,140,196,185,217,251,178,106,85,81,169,226,80,9,1,183,170,7,99,6,100,53,177,211,177,93,137,162,254,247,142,109,242,177,89,150,108,104,155,131,99,143,227,153,199,51,111,70,139,18,109,37,36,194,22,137,132,53,7,151,47,140,62,168,163,39,225,148,209,57,219,203,133,40,164,47,226,122,131,244,83,73,156,102,231,105,54,205,38,222,42,125,132,205,201,58,44,231,189,117,190,246,218,169,18,115,62,163,68,161,126,69,7,243,120,110,70,120,228,5,44,10,97,237,35,92,188,134,88,107,252,225,209,186,248,213,3,63,240,100,125,89,10,58,189,79,6,152,133,39,141,237,59,78,242,203,23,79,15,157,35,95,63,9,39,248,74,142,132,116,223,216,80,249,93,161,36,84,130,28,83,129,12,4,87,1,38,233,138,13,235,138,76,133,124,8,25,120,21,157,164,253,62,100,75,25,137,94,34,37,166,47,88,238,144,2,81,141,244,217,171,125,77,178,228,4,46,247,112,134,176,63,57,162,155,199,137,189,76,126,135,97,32,248,125,241,87,164,12,41,119,186,29,252,102,232,54,254,88,2,235,40,232,103,205,9,231,105,212,203,150,21,52,68,50,67,189,79,69,138,235,100,237,26,39,125,201,65,79,115,182,50,218,98,45,186,23,154,251,152,100,242,78,178,142,132,210,72,112,48,4,132,44,169,224,50,168,28,132,222,131,53,133,111,44,163,228,120,69,134,53,211,235,58,132,55,8,113,221,133,28,87,13,182,98,72,255,135,198,201,80,49,110,104,114,211,79,205,61,28,181,147,255,35,138,71,190,103,201,229,181,91,37,191,219,182,15,188,189,13,117,222,207,58,211,184,214,148,180,112,157,229,60,212,145,6,90,66,67,51,250,167,220,24,79,18,235,90,220,221,28,58,89,26,135,81,152,216,25,218,164,252,11,132,209,20,59,99,10,88,114,65,154,95,253,47,40,238,106,208,11,97,113,184,57,63,19,250,85,237,71,99,150,253,1,241,15,53,0,2,8,0,0 };
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

