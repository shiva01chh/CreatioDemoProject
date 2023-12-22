namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SetWinnerOpportunityEventListenerSchema

	/// <exclude/>
	public class SetWinnerOpportunityEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SetWinnerOpportunityEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SetWinnerOpportunityEventListenerSchema(SetWinnerOpportunityEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("231522b7-74cb-4b33-902e-c806990f6c39");
			Name = "SetWinnerOpportunityEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,193,110,219,48,12,61,187,64,255,129,240,46,54,80,200,247,54,41,176,182,105,123,232,150,1,89,209,67,177,131,98,51,137,10,91,50,40,217,67,80,236,223,71,73,118,144,108,105,227,139,45,138,143,124,124,143,214,178,65,219,202,18,225,39,18,73,107,86,78,220,26,189,82,235,142,164,83,70,159,159,189,159,159,37,157,85,122,125,144,66,40,102,218,41,167,208,94,157,74,16,179,30,181,243,121,156,249,133,112,205,117,225,182,150,214,94,194,2,221,139,210,26,105,222,182,134,92,167,149,219,134,244,39,101,29,114,60,128,138,162,128,137,237,154,70,210,246,122,56,63,74,93,213,72,176,50,4,123,96,64,223,149,95,161,167,24,193,197,63,232,137,69,148,181,53,80,18,174,166,233,231,204,197,141,180,24,98,135,220,82,40,124,189,215,35,87,217,162,220,96,35,191,179,190,48,133,116,143,96,154,255,98,76,219,45,107,85,66,233,85,56,45,2,92,194,7,20,184,212,123,144,104,39,236,55,116,27,83,177,180,63,200,56,44,29,86,241,190,29,143,208,43,238,33,107,232,141,170,124,239,189,174,145,70,54,27,52,12,175,28,252,10,36,73,47,9,236,145,236,121,139,113,87,120,208,160,222,189,44,157,33,47,95,48,57,30,183,226,1,221,228,88,183,29,254,58,11,125,146,68,227,239,255,42,25,109,29,117,254,248,149,214,93,195,212,178,180,179,72,124,161,121,44,134,167,23,3,97,241,124,16,207,243,171,80,247,83,238,226,206,236,190,179,97,238,0,251,51,168,139,186,138,2,127,164,118,48,52,94,134,5,83,122,131,164,92,101,202,184,37,163,229,166,231,93,83,21,70,249,231,122,33,123,254,119,50,179,124,99,186,44,176,174,144,46,32,58,112,131,188,221,24,12,231,169,45,224,232,197,146,183,65,236,176,35,8,135,73,189,83,195,111,48,133,193,204,60,38,197,132,163,166,159,158,58,70,15,131,28,219,127,254,2,108,198,206,203,81,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("231522b7-74cb-4b33-902e-c806990f6c39"));
		}

		#endregion

	}

	#endregion

}

