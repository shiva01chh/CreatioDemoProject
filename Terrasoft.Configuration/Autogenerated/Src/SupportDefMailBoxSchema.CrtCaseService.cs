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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,147,205,78,235,48,16,133,215,174,196,59,140,194,166,72,40,217,115,219,46,248,21,11,36,164,92,216,34,55,153,20,75,137,29,141,237,66,185,186,239,206,196,78,10,73,41,203,25,159,153,57,243,217,214,178,65,219,202,2,225,47,18,73,107,42,151,94,25,93,169,141,39,233,148,209,39,179,127,39,51,225,173,210,155,145,132,240,207,62,159,239,172,195,38,71,231,56,178,176,156,8,199,13,83,86,15,82,110,193,77,78,9,55,124,0,87,181,180,246,2,114,223,182,134,220,53,86,15,82,213,151,230,61,136,178,44,131,133,245,77,35,105,183,234,227,71,50,91,85,162,133,134,133,176,54,239,80,145,105,192,6,59,96,251,33,67,113,246,173,186,245,235,90,21,80,116,19,15,7,194,5,220,255,224,66,116,36,246,110,111,21,214,37,219,125,36,181,149,14,131,73,209,198,0,8,101,105,116,189,131,39,139,196,235,107,44,186,221,225,197,143,226,184,191,56,69,93,198,174,125,60,0,49,218,58,242,133,51,212,13,10,158,163,98,74,35,36,238,181,114,74,214,234,3,65,227,27,40,46,150,154,111,214,84,172,69,132,130,176,90,38,7,139,37,217,190,195,136,81,204,180,146,100,3,154,159,201,50,25,155,79,86,221,114,80,236,19,139,44,136,67,109,15,248,96,216,124,2,100,220,242,12,2,98,49,193,196,47,234,128,155,16,255,127,135,247,128,238,213,148,95,216,132,56,10,238,14,29,216,232,52,60,165,35,47,41,253,5,19,161,243,164,237,42,31,183,73,23,217,112,242,141,10,95,106,247,109,120,236,124,216,56,170,38,63,41,101,197,179,172,61,46,98,197,106,62,1,115,14,195,117,230,72,91,85,224,77,55,55,57,239,39,164,55,77,235,118,103,199,104,5,34,49,63,134,200,185,217,236,19,35,91,88,197,26,4,0,0 };
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

