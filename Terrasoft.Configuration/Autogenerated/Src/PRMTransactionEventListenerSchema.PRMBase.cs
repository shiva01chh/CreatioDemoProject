namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PRMTransactionEventListenerSchema

	/// <exclude/>
	public class PRMTransactionEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PRMTransactionEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PRMTransactionEventListenerSchema(PRMTransactionEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d4d7f2bb-ef0a-4afa-b11f-2249cce4c609");
			Name = "PRMTransactionEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("93e06cc5-eabd-4f73-bbbe-f0e6647a43ae");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,84,193,142,155,48,16,61,103,165,253,135,17,61,44,145,42,115,207,134,72,187,81,186,173,212,109,87,77,218,30,170,30,28,24,130,43,176,145,109,82,69,171,253,247,14,54,32,136,72,154,67,132,159,103,222,188,121,195,32,121,137,166,226,9,194,14,181,230,70,101,150,173,149,204,196,161,214,220,10,37,111,111,94,111,111,102,181,17,242,0,219,147,177,88,222,247,231,97,138,198,75,56,219,72,43,172,64,243,223,0,182,57,162,180,151,227,62,240,196,42,125,141,105,107,189,16,186,127,167,241,64,250,97,93,112,99,22,240,242,237,121,167,185,52,68,65,168,43,244,89,80,59,18,181,11,143,162,8,150,166,46,75,174,79,171,246,220,5,64,166,52,220,141,25,238,0,27,213,39,64,167,153,117,20,209,25,199,210,32,242,194,40,72,52,102,113,112,189,115,246,200,13,58,236,52,82,24,64,212,240,253,154,184,10,183,73,142,37,255,66,115,132,24,130,177,200,96,254,155,210,170,122,95,136,4,146,198,136,107,62,192,2,46,212,39,146,87,231,82,239,234,51,218,92,165,141,175,142,220,95,158,123,232,128,143,92,166,5,154,206,174,45,63,54,115,115,174,177,62,41,58,207,90,86,92,243,18,36,181,21,7,6,101,74,38,172,156,38,240,39,182,140,92,200,116,6,6,171,93,142,206,252,206,248,197,69,235,157,176,135,204,162,118,5,30,244,193,52,134,131,144,198,114,73,171,145,40,105,185,144,141,110,155,99,87,208,181,0,41,183,124,164,165,117,91,29,169,156,72,17,142,74,164,240,85,250,190,67,181,255,131,73,215,195,123,240,181,31,145,94,48,236,139,3,206,161,89,186,217,204,95,67,165,203,225,204,60,24,67,232,159,230,158,236,222,101,60,213,84,141,196,88,154,154,201,69,245,41,165,192,169,124,246,132,118,119,170,48,93,171,162,46,229,15,94,212,184,108,178,87,97,240,50,204,15,230,158,89,100,16,158,17,199,208,36,176,77,89,145,138,86,242,108,84,73,11,122,59,53,216,9,44,6,137,127,97,34,58,156,148,251,221,160,166,15,147,68,7,182,154,102,19,196,204,63,12,24,126,10,155,15,90,154,228,111,9,223,220,255,158,182,128,245,35,235,102,133,62,230,173,93,4,66,253,46,184,179,71,199,160,195,134,191,127,143,85,83,28,109,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d4d7f2bb-ef0a-4afa-b11f-2249cce4c609"));
		}

		#endregion

	}

	#endregion

}

