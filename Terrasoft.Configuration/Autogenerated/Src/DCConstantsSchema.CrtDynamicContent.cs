namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCConstantsSchema

	/// <exclude/>
	public class DCConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCConstantsSchema(DCConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b71266ae-26dd-4d4b-bb2e-0ecca246e43c");
			Name = "DCConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ad993b20-8db8-48d6-9762-5a83fb4975c6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,145,77,110,194,48,16,133,215,32,113,135,17,221,180,139,36,208,134,82,65,91,137,252,80,117,135,84,46,48,36,19,176,148,56,209,216,41,138,80,239,94,219,161,136,226,77,52,111,198,239,125,227,72,172,72,53,152,17,108,137,25,85,93,104,63,174,101,33,246,45,163,22,181,244,147,78,98,37,50,35,106,146,122,52,60,141,134,131,86,9,185,135,175,78,105,170,150,163,161,81,238,152,246,102,26,226,18,149,90,64,18,155,121,165,81,106,229,218,65,16,192,171,106,171,10,185,123,63,215,214,17,133,84,144,157,71,225,27,203,150,20,20,53,67,222,167,218,158,141,133,130,235,202,22,22,204,113,65,46,50,251,69,22,164,252,191,136,224,42,163,105,119,165,113,48,214,218,26,89,176,255,92,131,147,99,187,176,111,184,110,136,181,241,91,192,198,93,238,251,183,240,78,72,226,149,214,44,118,173,38,40,68,169,137,65,119,13,129,200,225,120,16,217,1,114,82,153,233,155,125,20,33,91,1,53,26,26,182,79,135,170,95,214,191,248,95,147,223,160,51,97,94,203,178,131,143,214,184,95,5,175,93,238,214,196,126,230,240,6,146,142,110,228,126,156,164,171,52,74,194,153,151,198,211,181,23,174,103,145,23,77,162,216,75,231,207,225,124,50,155,190,60,62,133,227,135,229,121,125,146,121,255,2,174,254,233,255,231,63,209,104,230,252,2,176,11,162,16,44,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b71266ae-26dd-4d4b-bb2e-0ecca246e43c"));
		}

		#endregion

	}

	#endregion

}

