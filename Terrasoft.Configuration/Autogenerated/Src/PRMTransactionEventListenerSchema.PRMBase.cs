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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,84,193,138,219,48,16,61,103,97,255,97,112,15,235,64,145,239,217,56,176,27,210,109,161,219,46,77,218,30,74,15,138,61,142,85,108,201,72,114,74,88,246,223,59,146,236,16,7,39,205,33,88,79,51,111,222,188,241,88,242,26,77,195,51,132,13,106,205,141,42,44,91,42,89,136,93,171,185,21,74,222,222,188,222,222,76,90,35,228,14,214,7,99,177,190,63,158,79,83,52,94,194,217,74,90,97,5,154,255,6,176,213,30,165,189,28,247,129,103,86,233,107,76,107,27,132,208,253,59,141,59,210,15,203,138,27,51,131,151,111,207,27,205,165,33,10,66,125,161,207,130,218,145,168,125,120,146,36,48,55,109,93,115,125,88,116,231,62,0,10,165,225,110,200,112,7,232,84,31,0,189,102,214,83,36,103,28,115,131,200,43,163,32,211,88,164,209,245,206,217,35,55,232,177,195,64,97,4,137,227,251,53,114,21,175,179,18,107,254,133,230,8,41,68,67,145,209,244,55,165,53,237,182,18,25,100,206,136,107,62,192,12,46,212,39,146,87,239,210,209,213,103,180,165,202,157,175,158,60,92,158,123,232,129,143,92,230,21,154,222,174,53,223,187,185,121,215,216,49,41,57,207,154,55,92,243,26,36,181,149,70,6,101,78,38,44,188,38,8,39,54,79,124,200,120,6,70,139,77,137,222,252,222,248,217,69,235,189,176,135,194,162,246,5,30,244,206,56,195,65,72,99,185,164,213,200,148,180,92,72,167,219,150,216,23,244,45,64,206,45,31,104,233,220,86,123,42,39,114,132,189,18,57,124,149,161,239,88,109,255,96,214,247,240,30,66,237,71,164,23,12,143,197,1,167,224,150,110,50,9,215,208,232,250,116,102,1,76,33,14,79,211,64,118,239,51,158,90,170,70,98,44,77,205,148,162,249,148,83,224,88,62,123,66,187,57,52,152,47,85,213,214,242,7,175,90,156,187,236,69,28,189,156,230,71,211,192,44,10,136,207,136,83,112,9,108,85,55,164,162,147,60,25,84,210,130,222,78,13,118,4,75,65,226,95,24,137,142,71,229,126,55,168,233,195,36,209,131,157,166,201,8,49,11,15,39,12,63,133,45,79,90,26,229,239,8,223,252,255,150,182,128,29,71,214,207,10,67,204,91,183,8,132,134,93,240,231,128,14,65,143,185,223,63,180,179,223,83,101,5,0,0 };
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

