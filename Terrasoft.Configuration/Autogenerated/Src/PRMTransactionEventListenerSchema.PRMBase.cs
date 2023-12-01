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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,84,193,142,155,48,16,61,179,210,254,195,136,30,150,72,149,185,103,67,164,221,40,221,86,234,182,171,38,109,15,85,15,14,12,193,21,216,200,54,169,162,213,254,123,7,27,34,136,72,154,67,132,159,103,222,188,121,195,32,121,133,166,230,41,194,22,181,230,70,229,150,173,148,204,197,190,209,220,10,37,111,111,94,111,111,130,198,8,185,135,205,209,88,172,238,79,231,97,138,198,75,56,91,75,43,172,64,243,223,0,182,62,160,180,151,227,62,240,212,42,125,141,105,99,189,16,186,127,167,113,79,250,97,85,114,99,230,240,242,237,121,171,185,52,68,65,168,43,244,89,80,59,18,181,11,143,227,24,22,166,169,42,174,143,203,238,220,7,64,174,52,220,141,25,238,0,91,213,71,64,167,153,245,20,241,25,199,194,32,242,210,40,72,53,230,73,120,189,115,246,200,13,58,236,56,82,24,66,220,242,253,154,184,138,54,105,129,21,255,66,115,132,4,194,177,200,112,246,155,210,234,102,87,138,20,210,214,136,107,62,192,28,46,212,39,146,87,231,210,201,213,103,180,133,202,90,95,29,185,191,60,247,208,1,31,185,204,74,52,189,93,27,126,104,231,230,92,99,167,164,248,60,107,81,115,205,43,144,212,86,18,26,148,25,153,176,116,154,192,159,216,34,118,33,211,25,24,46,183,5,58,243,123,227,231,23,173,119,194,30,114,139,218,21,120,208,123,211,26,14,66,26,203,37,173,70,170,164,229,66,182,186,109,129,125,65,215,2,100,220,242,145,150,206,109,117,160,114,34,67,56,40,145,193,87,233,251,142,212,238,15,166,125,15,239,193,215,126,68,122,193,240,84,28,112,6,237,210,5,129,191,134,90,87,195,153,121,48,129,200,63,205,60,217,189,203,120,106,168,26,137,177,52,53,83,136,250,83,70,129,83,249,236,9,237,246,88,99,182,82,101,83,201,31,188,108,112,209,102,47,163,240,101,152,31,206,60,179,200,33,58,35,78,160,77,96,235,170,38,21,157,228,96,84,73,11,122,59,53,216,9,44,1,137,127,97,34,58,154,148,251,221,160,166,15,147,68,7,118,154,130,9,98,230,31,6,12,63,133,45,6,45,77,242,119,132,111,238,127,71,91,192,78,35,235,103,133,62,230,173,91,4,66,253,46,184,179,71,199,160,195,232,247,15,222,244,74,99,100,5,0,0 };
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

