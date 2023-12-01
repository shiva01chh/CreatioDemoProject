namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MandrillMailingResponseSchema

	/// <exclude/>
	public class MandrillMailingResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MandrillMailingResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MandrillMailingResponseSchema(MandrillMailingResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("300c4950-cc6e-4d74-b555-e972ea0b4444");
			Name = "MandrillMailingResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("aa578739-72a4-4d6e-8c15-4350e99d075d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,77,75,196,64,12,134,207,21,252,15,129,189,183,119,119,241,178,130,120,40,44,91,111,226,33,157,77,235,192,124,148,153,140,184,138,255,221,116,218,174,171,160,226,156,38,111,242,38,79,226,208,82,28,80,17,220,83,8,24,125,199,229,214,187,78,247,41,32,107,239,202,26,221,33,104,99,26,10,207,90,234,222,46,47,138,20,181,235,161,57,70,38,187,254,22,151,251,228,88,91,42,197,160,209,232,215,220,70,170,164,110,21,168,151,0,182,6,99,188,130,165,117,141,218,72,131,189,144,120,23,41,151,86,85,5,155,152,172,197,112,188,150,76,50,12,190,3,126,162,147,13,226,140,100,39,127,185,169,22,131,52,120,184,65,70,89,133,3,42,126,20,97,72,173,209,10,212,56,251,167,209,227,118,82,122,2,221,5,63,80,96,77,66,187,203,254,41,255,133,110,17,62,41,103,32,160,23,82,41,95,241,100,58,71,156,24,107,178,45,133,145,112,65,108,189,55,208,36,165,72,72,199,123,23,69,79,188,206,159,56,127,222,127,1,153,151,130,200,200,41,254,111,246,109,210,7,104,178,241,238,240,199,240,21,201,17,243,161,36,154,180,115,41,43,242,62,0,77,113,241,185,100,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("300c4950-cc6e-4d74-b555-e972ea0b4444"));
		}

		#endregion

	}

	#endregion

}

