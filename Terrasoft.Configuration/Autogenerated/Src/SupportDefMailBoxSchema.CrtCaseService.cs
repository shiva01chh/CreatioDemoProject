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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,147,205,78,235,48,16,133,215,70,226,29,70,97,83,36,148,236,185,109,23,252,138,5,18,82,46,108,145,155,76,138,165,196,142,198,118,161,92,221,119,103,98,39,165,73,41,217,205,248,204,156,153,207,142,150,13,218,86,22,8,127,145,72,90,83,185,244,218,232,74,173,61,73,167,140,62,61,249,119,122,34,188,85,122,61,146,16,254,217,229,243,173,117,216,228,232,28,71,22,22,19,225,184,97,202,234,65,202,45,184,201,25,225,154,15,224,186,150,214,94,66,238,219,214,144,187,193,234,81,170,250,202,124,4,81,150,101,48,183,190,105,36,109,151,125,252,68,102,163,74,180,208,176,16,86,230,3,42,50,13,216,48,14,216,222,100,40,206,246,170,91,191,170,85,1,69,231,120,104,8,151,240,240,195,20,162,35,177,155,246,78,97,93,242,184,79,164,54,210,97,24,82,180,49,0,66,89,26,93,111,225,217,34,241,250,26,139,110,119,120,245,163,56,238,47,206,80,151,177,107,31,15,64,140,182,142,124,225,12,117,70,97,230,168,152,210,8,137,7,173,156,146,181,250,68,208,248,14,138,139,165,230,155,53,21,107,17,161,32,172,22,201,193,98,73,182,235,48,98,20,51,173,36,217,128,230,103,178,72,198,195,39,203,110,57,40,118,137,121,22,196,161,182,7,124,96,54,155,0,25,183,60,135,128,88,76,48,241,139,58,224,38,196,255,223,225,61,162,123,51,229,55,54,33,142,130,187,71,7,54,78,26,158,210,145,151,148,254,130,137,208,121,210,118,153,143,219,164,243,108,56,217,163,194,151,218,253,54,108,59,27,54,142,170,201,159,148,178,226,69,214,30,231,177,98,57,155,128,185,128,225,58,115,164,141,42,240,182,243,77,46,122,135,244,182,105,221,246,252,24,173,64,36,230,199,16,57,183,247,125,1,118,251,131,55,35,4,0,0 };
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

