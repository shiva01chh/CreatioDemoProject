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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,193,110,219,48,12,61,187,64,255,129,112,47,54,80,200,247,54,41,176,118,217,118,88,155,2,105,177,195,176,131,98,51,137,6,91,50,40,217,69,80,244,223,75,73,118,144,108,105,227,139,45,138,143,124,124,143,214,178,65,219,202,18,225,9,137,164,53,43,39,238,140,94,169,117,71,210,41,163,207,207,94,207,207,146,206,42,189,62,72,33,20,51,237,148,83,104,175,79,37,136,89,143,218,249,60,206,188,32,92,115,93,184,171,165,181,87,176,64,247,75,105,141,52,111,91,67,174,211,202,109,67,250,79,101,29,114,60,128,138,162,128,137,237,154,70,210,246,102,56,255,144,186,170,145,96,101,8,246,192,128,190,43,191,66,79,49,130,139,127,208,19,139,40,107,107,160,36,92,77,211,207,153,139,91,105,49,196,14,185,165,80,248,122,191,143,92,101,139,114,131,141,124,96,125,97,10,233,30,193,52,255,195,152,182,91,214,170,132,210,171,112,90,4,184,130,15,40,112,169,215,32,209,78,216,123,116,27,83,177,180,143,100,28,150,14,171,120,223,142,71,232,21,247,144,53,244,70,85,190,247,94,215,72,35,155,13,26,134,87,14,126,5,146,164,151,4,246,72,246,188,197,184,43,60,104,80,239,155,44,157,33,47,95,48,57,30,183,226,59,186,201,177,110,59,252,77,22,250,36,137,198,151,255,42,25,109,29,117,254,248,133,214,93,195,212,178,180,179,72,124,161,121,44,134,167,151,3,97,241,124,16,207,243,235,80,247,83,238,226,171,217,125,103,195,220,1,246,54,168,139,186,138,2,127,164,118,48,52,94,134,5,83,122,131,164,92,101,202,184,37,163,229,166,231,93,83,21,70,249,231,122,33,123,254,119,50,179,252,203,116,89,96,93,33,93,66,116,224,22,121,187,49,24,206,83,91,192,209,139,37,111,131,216,97,71,16,14,147,122,167,134,223,96,10,131,153,121,76,138,9,71,77,63,61,117,140,30,6,57,230,159,119,4,32,244,84,73,4,0,0 };
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

