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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,145,193,110,130,64,16,134,207,154,248,14,19,123,105,15,128,182,88,27,109,155,8,104,211,155,73,125,129,17,6,221,4,22,178,59,212,16,211,119,239,238,98,13,117,47,100,254,153,253,255,111,22,137,37,233,26,83,130,29,41,133,186,202,217,143,43,153,139,67,163,144,69,37,253,164,149,88,138,212,136,76,146,71,195,243,104,56,104,180,144,7,248,106,53,83,185,28,13,141,114,167,232,96,166,33,46,80,235,5,36,177,153,215,140,146,181,107,7,65,0,175,186,41,75,84,237,251,165,182,142,40,164,134,244,50,10,223,88,52,164,33,175,20,100,93,170,237,217,88,200,85,85,218,194,130,57,46,200,68,106,191,168,4,105,255,47,34,232,101,212,205,190,48,14,198,154,173,145,5,251,207,53,56,59,182,43,251,86,85,53,41,54,126,11,216,186,203,93,255,22,222,9,73,188,98,86,98,223,48,65,46,10,38,5,220,214,4,34,131,211,81,164,71,200,72,167,166,111,246,209,132,202,10,200,104,104,148,125,58,212,221,178,254,213,191,79,126,131,174,8,179,74,22,45,124,52,198,189,23,188,113,185,59,19,251,153,193,27,72,58,185,145,251,113,178,94,173,163,36,156,121,235,120,186,241,194,205,44,242,162,73,20,123,235,249,115,56,159,204,166,47,143,79,225,248,97,121,89,159,100,214,189,128,171,127,186,255,249,79,52,90,255,252,2,64,158,64,19,53,2,0,0 };
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

