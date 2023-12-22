namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebHookEmailHyperlinkStatisticsSchema

	/// <exclude/>
	public class WebHookEmailHyperlinkStatisticsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebHookEmailHyperlinkStatisticsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebHookEmailHyperlinkStatisticsSchema(WebHookEmailHyperlinkStatisticsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("360ea3e1-2a77-455d-9130-520eefc7c9b3");
			Name = "WebHookEmailHyperlinkStatistics";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("457f57e6-ba32-4a54-a8b9-9eba8360aae2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,193,110,26,49,16,61,19,41,255,96,109,46,94,5,173,122,78,148,67,33,8,80,91,9,133,160,156,205,122,0,11,99,111,237,113,90,20,229,223,59,222,93,19,172,164,201,30,86,246,120,222,155,121,207,99,35,14,224,27,81,3,123,4,231,132,183,27,172,198,214,108,212,54,56,129,202,154,203,139,151,203,139,65,240,202,108,217,242,232,17,14,183,167,253,216,58,200,119,213,253,136,2,20,186,114,176,37,52,27,107,225,253,13,155,28,132,210,179,99,3,78,43,179,95,34,81,123,84,181,111,115,155,176,214,170,102,117,76,253,111,38,187,97,35,225,225,9,214,51,107,247,132,122,105,177,167,66,11,103,9,131,10,168,218,162,37,236,206,123,242,105,80,178,227,158,75,22,21,13,6,91,192,219,118,225,251,197,107,134,240,232,162,170,182,149,159,212,202,23,168,43,48,178,107,37,99,81,6,201,3,85,239,253,87,248,94,199,47,192,157,149,31,139,176,207,116,71,74,66,234,109,10,56,117,54,52,63,224,200,203,158,223,1,6,103,216,154,188,170,242,243,235,164,191,122,180,203,150,160,13,158,4,126,224,193,169,224,179,37,251,102,194,72,157,110,128,175,60,56,154,20,3,117,28,19,22,178,109,234,38,202,223,165,2,15,100,253,29,235,241,43,84,90,197,235,138,93,206,206,82,120,206,52,124,107,112,152,4,148,157,131,106,195,120,78,126,199,190,165,202,189,17,93,230,107,251,55,240,135,173,26,41,16,222,213,40,70,65,239,243,209,43,202,142,167,90,2,242,162,187,195,177,13,6,139,33,141,186,14,7,83,45,132,163,231,131,224,120,119,92,38,200,211,14,28,240,55,210,185,44,202,106,238,39,191,131,208,252,29,56,169,74,232,239,70,242,226,225,115,204,185,238,178,172,38,127,161,14,164,171,252,100,36,163,9,241,101,102,81,10,158,125,255,0,87,241,64,248,14,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("360ea3e1-2a77-455d-9130-520eefc7c9b3"));
		}

		#endregion

	}

	#endregion

}

