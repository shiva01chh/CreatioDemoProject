namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MatchesFoundUtilitiesSchema

	/// <exclude/>
	public class MatchesFoundUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MatchesFoundUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MatchesFoundUtilitiesSchema(MatchesFoundUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e78d9172-c1ff-4b6b-b8de-32a4d56c58f1");
			Name = "MatchesFoundUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,83,193,78,195,48,12,61,183,82,255,33,210,238,124,0,59,65,209,16,18,133,73,29,39,196,33,77,220,206,82,154,84,78,122,24,19,255,78,154,148,177,129,16,105,79,238,139,159,223,179,227,104,222,131,29,184,0,182,3,34,110,77,235,174,74,163,91,236,70,226,14,141,46,242,99,145,23,121,54,90,212,29,171,15,214,65,191,14,200,138,160,243,9,172,84,220,218,107,86,113,39,246,96,55,102,212,50,156,191,214,64,200,21,190,243,70,193,155,7,134,177,81,40,152,152,242,127,164,103,81,228,84,115,75,102,0,114,8,190,240,54,208,226,249,92,226,126,68,201,30,228,113,130,178,14,220,58,4,118,14,62,46,114,239,184,131,29,246,192,74,2,31,202,103,157,68,11,18,51,229,246,144,168,101,29,77,83,58,209,158,252,116,151,153,172,140,196,22,151,185,252,226,44,181,249,205,75,246,137,218,77,119,35,192,218,71,244,171,160,129,236,223,196,44,251,45,90,27,225,151,226,70,8,127,241,46,189,199,72,171,64,34,95,214,228,25,49,185,203,198,24,197,106,112,27,67,254,45,56,46,210,140,206,138,113,95,253,148,90,84,240,66,106,185,219,255,58,92,129,150,241,161,132,255,136,94,130,1,59,255,62,1,0,181,177,107,233,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e78d9172-c1ff-4b6b-b8de-32a4d56c58f1"));
		}

		#endregion

	}

	#endregion

}

