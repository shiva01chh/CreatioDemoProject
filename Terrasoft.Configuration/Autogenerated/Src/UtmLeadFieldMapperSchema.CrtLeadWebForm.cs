namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UtmLeadFieldMapperSchema

	/// <exclude/>
	public class UtmLeadFieldMapperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UtmLeadFieldMapperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UtmLeadFieldMapperSchema(UtmLeadFieldMapperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8ece8268-d49a-43c7-9c1e-aa79f3fd3c89");
			Name = "UtmLeadFieldMapper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe674b36-6b4e-4761-be68-f76112863a49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,193,110,226,48,16,61,131,212,127,24,165,23,144,80,114,111,33,7,216,182,139,4,43,148,182,234,97,181,7,147,76,136,181,137,157,181,29,86,168,218,127,223,137,13,33,41,148,86,205,37,242,248,205,188,55,207,99,11,86,160,46,89,140,240,132,74,49,45,83,227,207,164,72,249,166,82,204,112,41,174,250,175,87,253,94,165,185,216,192,227,78,27,44,110,223,172,9,159,231,24,215,96,237,63,160,64,197,227,19,204,130,139,63,199,96,155,75,161,127,207,98,35,21,71,77,8,194,92,43,220,80,49,152,229,76,235,27,120,54,197,2,89,114,207,49,79,150,172,44,81,89,84,16,4,48,230,34,35,58,147,200,24,98,133,233,196,155,183,96,94,16,18,238,231,55,76,89,149,155,41,23,9,113,15,204,174,68,153,14,230,179,74,27,89,180,224,195,17,252,32,55,96,2,222,41,165,55,252,69,181,202,106,157,115,162,170,133,157,209,5,55,112,90,150,210,94,173,224,99,95,100,148,97,194,80,111,43,197,183,204,160,219,183,29,233,170,40,152,218,133,135,192,83,134,48,93,45,33,163,246,32,173,203,250,13,54,104,131,75,87,10,226,186,58,104,163,106,163,167,101,241,157,18,173,156,186,177,253,218,187,253,4,35,225,80,161,160,209,248,10,109,212,101,141,142,164,215,40,18,231,68,215,150,149,146,100,151,161,49,32,95,172,209,23,68,62,160,209,96,72,233,95,92,103,82,254,6,45,43,21,227,123,34,221,185,237,213,189,184,148,71,155,1,147,176,27,104,78,199,95,48,59,49,252,146,89,141,14,20,134,155,29,8,154,160,79,137,184,179,120,55,112,33,120,245,36,125,100,208,18,77,38,147,115,238,92,188,6,62,253,236,82,187,11,113,16,178,149,60,129,102,111,48,191,19,85,129,138,173,115,28,59,141,225,193,92,135,24,193,130,107,51,222,155,69,151,190,42,4,165,135,80,212,52,238,30,232,33,208,176,67,235,107,111,250,17,150,57,189,53,131,246,88,142,26,251,81,109,121,219,255,21,219,224,179,202,45,106,88,63,30,189,222,123,213,162,15,139,69,245,52,43,84,221,130,255,206,58,238,162,221,160,141,245,251,255,1,39,71,49,215,48,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ece8268-d49a-43c7-9c1e-aa79f3fd3c89"));
		}

		#endregion

	}

	#endregion

}

