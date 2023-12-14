namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SupportDefMailBoxSchema

	/// <exclude/>
	public class SupportDefMailBoxSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SupportDefMailBoxSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SupportDefMailBoxSchema(SupportDefMailBoxSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6f94f800-c500-433f-bc1d-fcfd77df71cb");
			Name = "SupportDefMailBox";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,147,77,79,195,48,12,134,207,65,226,63,88,229,50,36,212,222,97,219,129,79,113,64,66,42,112,69,161,117,71,164,54,169,156,100,48,16,255,29,55,105,7,237,24,189,217,121,237,215,126,146,106,217,160,109,101,129,240,128,68,210,154,202,165,23,70,87,106,229,73,58,101,244,225,193,231,225,129,240,86,233,213,72,66,120,182,205,231,27,235,176,201,209,57,142,44,44,38,194,113,195,148,213,131,148,91,112,147,35,194,21,31,192,69,45,173,61,133,220,183,173,33,119,137,213,157,84,245,185,121,15,162,44,203,96,110,125,211,72,218,44,251,248,158,204,90,149,104,161,97,33,188,152,119,168,200,52,96,195,56,96,123,147,161,56,251,85,221,250,151,90,21,80,116,142,187,134,112,10,183,127,76,33,58,18,219,105,175,21,214,37,143,123,79,106,45,29,134,33,69,27,3,32,148,165,209,245,6,30,45,18,175,175,177,232,118,135,103,63,138,227,254,226,8,117,25,187,246,241,0,196,104,235,200,23,206,80,103,20,102,142,138,41,141,144,184,213,202,41,89,171,15,4,141,111,160,184,88,106,190,89,83,177,22,17,10,194,106,145,236,44,150,100,219,14,35,70,49,211,74,146,13,104,126,38,139,100,60,124,178,236,150,131,98,155,152,103,65,28,106,123,192,59,102,179,9,144,113,203,99,8,136,197,4,19,191,168,29,110,66,124,253,15,239,14,221,171,41,127,176,9,177,23,220,13,58,176,113,210,240,148,246,188,164,244,31,76,132,206,147,182,203,124,220,38,157,103,195,201,47,42,124,169,221,111,195,182,179,97,227,168,154,252,73,41,43,158,100,237,113,30,43,150,179,9,152,19,24,174,51,71,90,171,2,175,58,223,228,164,119,72,175,154,214,109,142,247,209,10,68,98,126,12,145,115,252,125,3,186,47,117,144,27,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6f94f800-c500-433f-bc1d-fcfd77df71cb"));
		}

		#endregion

	}

	#endregion

}

