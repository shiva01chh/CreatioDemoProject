namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalConstantsSchema

	/// <exclude/>
	public class PortalConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalConstantsSchema(PortalConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0d4ff333-6c25-49dc-97f3-5f38c4c7f52d");
			Name = "PortalConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b54a206c-0c3a-4346-bc7a-d3b009155be5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,65,107,27,49,16,133,207,49,248,63,44,57,181,135,105,36,173,100,73,132,30,180,90,169,244,16,18,226,228,84,122,80,215,178,189,176,214,154,149,150,96,74,254,123,229,56,109,234,4,218,128,117,20,111,230,125,243,102,198,216,134,85,49,223,197,228,55,151,211,201,116,18,220,198,199,173,107,124,113,231,135,193,197,126,153,62,233,62,44,219,213,56,184,212,246,97,58,249,57,157,156,109,199,31,93,219,20,49,229,191,166,104,58,23,99,113,211,15,201,117,89,156,127,67,138,89,181,87,158,93,92,124,203,253,77,72,109,218,205,155,181,223,184,91,223,220,182,171,117,154,247,227,208,248,239,123,209,113,191,193,187,69,31,186,93,241,101,108,23,197,63,171,175,31,130,31,138,207,69,240,15,79,234,15,231,179,153,81,152,91,14,181,197,53,80,196,4,72,172,21,32,169,8,98,188,54,202,136,243,143,151,39,185,170,49,173,251,99,91,74,8,210,182,202,62,12,83,160,84,27,80,117,141,0,35,89,49,90,49,130,4,61,213,246,202,133,209,117,89,250,183,177,80,132,10,133,74,48,82,177,253,208,24,164,20,18,168,96,85,41,53,22,148,163,83,141,107,191,116,99,151,142,124,45,197,6,145,153,0,83,146,60,48,33,57,103,35,13,48,93,113,173,37,154,149,242,119,206,47,103,112,213,47,198,238,93,43,63,40,15,55,117,229,218,112,227,86,254,235,226,136,0,75,169,185,164,26,48,181,6,104,69,8,40,140,21,16,100,100,134,43,41,19,245,27,2,181,216,180,225,62,180,233,61,16,127,196,170,235,14,40,247,209,15,241,21,7,39,168,226,28,107,48,92,113,160,182,204,27,200,167,0,140,232,154,96,93,242,82,218,39,142,103,138,231,161,124,140,121,166,187,221,246,255,121,188,169,208,253,102,219,229,84,210,43,20,198,74,45,43,101,161,34,57,23,170,17,135,170,20,12,20,181,84,137,153,213,150,146,151,72,30,167,147,199,61,213,254,253,2,45,208,18,23,10,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0d4ff333-6c25-49dc-97f3-5f38c4c7f52d"));
		}

		#endregion

	}

	#endregion

}

