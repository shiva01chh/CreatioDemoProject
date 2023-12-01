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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,193,110,26,49,16,61,131,148,127,176,54,23,175,138,86,61,39,202,161,80,4,40,173,132,66,80,206,102,61,128,133,177,55,246,56,45,138,242,239,29,239,174,73,172,164,201,101,101,143,231,189,153,247,102,214,136,35,248,70,212,192,238,193,57,225,237,22,171,137,53,91,181,11,78,160,178,230,98,248,124,49,28,4,175,204,142,173,78,30,225,120,125,190,79,172,131,252,86,253,28,83,128,66,151,14,118,132,102,19,45,188,191,98,211,163,80,122,126,106,192,105,101,14,43,36,106,143,170,246,109,110,19,54,90,213,172,142,169,255,205,100,87,108,44,60,60,192,102,110,237,129,80,207,45,246,92,104,233,44,97,80,1,85,91,182,132,221,123,79,62,11,74,118,220,11,201,162,162,193,96,7,120,221,30,124,127,120,201,16,30,93,84,213,182,242,139,90,249,2,117,9,70,118,173,100,44,202,32,121,160,234,131,255,10,223,235,248,13,184,183,242,99,17,246,137,102,164,36,164,222,102,128,51,103,67,115,11,39,94,246,252,14,48,56,195,54,228,85,149,191,127,75,250,171,123,187,106,9,218,224,89,224,7,30,156,11,62,89,178,111,46,140,212,105,2,124,237,193,209,166,24,168,227,154,176,144,93,83,55,81,254,62,21,184,35,235,111,88,143,95,163,210,42,142,43,118,57,127,147,194,115,166,209,107,131,163,36,160,236,28,84,91,198,115,242,27,246,61,85,238,141,232,50,95,218,175,129,63,108,221,72,129,240,174,70,49,14,250,144,175,94,81,118,60,213,10,144,23,221,12,39,54,24,44,70,180,234,58,28,77,181,20,142,126,31,4,199,187,231,50,65,30,246,224,128,191,146,46,100,81,86,11,63,125,12,66,243,119,224,164,42,161,127,24,201,139,187,207,49,111,117,151,101,53,253,11,117,32,93,229,39,43,25,77,136,127,102,22,165,224,112,248,15,45,81,52,147,5,4,0,0 };
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

