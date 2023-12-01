namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseTimeZoneMacrosConverterSchema

	/// <exclude/>
	public class CaseTimeZoneMacrosConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseTimeZoneMacrosConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseTimeZoneMacrosConverterSchema(CaseTimeZoneMacrosConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("def50b48-4f91-4a9d-ab1b-2977e4e375ae");
			Name = "CaseTimeZoneMacrosConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,77,111,155,64,16,61,19,41,255,97,68,46,88,178,224,238,96,164,214,109,35,14,169,170,124,92,122,219,44,131,179,146,217,69,179,75,42,55,202,127,207,236,2,54,184,137,203,5,102,120,243,222,155,153,93,45,26,180,173,144,8,15,72,36,172,169,93,186,49,186,86,219,142,132,83,70,95,94,188,94,94,68,157,85,122,11,247,123,235,176,185,62,196,211,18,194,207,242,233,15,33,157,33,133,150,17,140,185,34,220,50,49,108,118,194,218,21,108,132,197,7,213,224,111,163,241,86,72,50,150,245,95,144,28,82,128,103,89,6,185,237,154,70,208,190,24,226,59,108,9,45,106,103,65,142,96,168,13,193,55,225,2,25,52,158,73,162,5,165,131,2,48,88,185,125,58,18,102,19,198,182,123,218,41,9,210,251,57,103,103,5,95,207,121,141,94,131,223,99,127,70,91,71,157,239,157,219,252,21,68,122,196,105,75,33,81,106,229,148,216,169,191,108,90,227,31,54,110,157,208,188,24,83,51,24,17,36,97,189,142,207,248,139,179,162,111,34,61,136,100,167,42,121,43,72,52,160,121,237,235,184,179,72,92,173,81,250,77,199,197,35,199,126,160,67,34,205,179,128,254,184,216,202,103,108,196,79,254,142,139,239,97,184,208,167,194,255,89,237,48,224,51,214,147,199,153,21,152,59,91,2,15,210,31,172,163,230,194,243,70,43,120,98,206,228,31,244,17,6,254,244,70,111,195,102,80,87,253,114,230,155,186,69,247,108,42,191,36,50,142,73,176,234,255,183,99,8,134,109,146,170,248,150,12,254,75,93,27,184,65,55,198,201,77,167,170,225,144,221,161,52,84,149,213,32,30,149,35,136,233,95,152,132,114,63,137,2,218,33,132,53,36,159,96,22,225,146,244,23,104,159,178,94,62,29,226,136,45,146,160,19,249,99,51,57,117,95,104,219,53,108,41,57,93,244,18,230,227,94,44,255,83,47,89,180,172,184,238,164,193,80,182,184,14,47,66,215,145,62,52,149,78,135,211,67,62,222,66,159,157,39,57,199,207,59,229,84,161,109,156,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("def50b48-4f91-4a9d-ab1b-2977e4e375ae"));
		}

		#endregion

	}

	#endregion

}

