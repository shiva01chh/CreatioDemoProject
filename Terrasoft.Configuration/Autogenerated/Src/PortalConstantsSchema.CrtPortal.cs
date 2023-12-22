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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,65,107,27,49,16,133,207,49,248,63,44,57,181,135,105,36,173,100,73,132,30,180,90,169,244,16,26,226,228,84,122,80,215,178,189,176,214,154,149,150,96,74,254,123,229,56,109,226,4,218,128,117,20,111,230,125,243,102,198,216,134,85,49,223,197,228,55,151,211,201,116,18,220,198,199,173,107,124,113,235,135,193,197,126,153,62,233,62,44,219,213,56,184,212,246,97,58,249,53,157,156,109,199,159,93,219,20,49,229,191,166,104,58,23,99,113,221,15,201,117,89,156,127,67,138,89,181,87,158,93,92,124,207,253,77,72,109,218,205,155,181,223,184,27,223,220,180,171,117,154,247,227,208,248,31,123,209,113,191,193,187,69,31,186,93,241,101,108,23,197,63,171,191,221,7,63,20,159,139,224,239,31,213,31,206,103,51,163,48,183,28,106,139,107,160,136,9,144,88,43,64,82,17,196,120,109,148,17,231,31,47,79,114,85,99,90,247,199,182,148,16,164,109,149,125,24,166,64,169,54,160,234,26,1,70,178,98,180,98,4,9,122,170,237,149,11,163,235,178,244,165,177,80,132,10,133,74,48,82,177,253,208,24,164,20,18,168,96,85,41,53,22,148,163,83,141,107,191,116,99,151,142,124,45,197,6,145,153,0,83,146,60,48,33,57,103,35,13,48,93,113,173,37,154,149,242,79,206,207,103,112,213,47,198,238,93,43,63,40,15,55,117,229,218,112,237,86,254,235,226,136,0,75,169,185,164,26,48,181,6,104,69,8,40,140,21,16,100,100,134,43,41,19,245,27,2,181,216,180,225,46,180,233,61,16,127,197,170,235,14,40,119,209,15,241,21,7,39,168,226,28,107,48,92,113,160,182,204,27,200,167,0,140,232,154,96,93,242,82,218,71,142,39,138,167,161,124,140,121,166,219,221,246,255,121,188,169,208,253,102,219,229,84,210,43,20,198,74,45,43,101,161,34,57,23,170,17,135,170,20,12,20,181,84,137,153,213,150,146,231,72,30,166,147,135,61,213,203,247,27,206,95,199,150,18,4,0,0 };
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

