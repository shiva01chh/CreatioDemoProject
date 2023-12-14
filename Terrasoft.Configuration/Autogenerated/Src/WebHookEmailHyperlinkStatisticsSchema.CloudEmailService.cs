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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,193,78,227,48,16,61,23,137,127,176,194,197,209,86,209,158,65,28,182,221,170,173,118,145,42,74,197,217,141,167,173,85,215,206,218,99,160,66,252,59,227,36,46,88,176,144,67,100,143,231,189,153,247,60,54,226,0,190,17,53,176,59,112,78,120,187,193,106,108,205,70,109,131,19,168,172,57,63,123,62,63,27,4,175,204,150,45,143,30,225,112,117,218,143,173,131,124,87,253,30,81,128,66,23,14,182,132,102,99,45,188,191,100,147,131,80,122,118,108,192,105,101,246,75,36,106,143,170,246,109,110,19,214,90,213,172,142,169,255,205,100,151,108,36,60,220,195,122,102,237,158,80,207,45,246,84,104,225,44,97,80,1,85,91,180,132,221,121,79,62,13,74,118,220,115,201,162,162,193,96,11,120,213,46,124,191,120,201,16,30,93,84,213,182,242,151,90,249,6,117,1,70,118,173,100,44,202,32,121,160,234,189,255,14,223,235,184,1,220,89,249,185,8,251,64,119,164,36,164,222,166,128,83,103,67,243,7,142,188,236,249,29,96,112,134,173,201,171,42,63,255,145,244,87,119,118,217,18,180,193,147,192,79,60,56,21,124,176,100,223,76,24,169,211,13,240,149,7,71,147,98,160,142,99,194,66,182,77,221,68,249,187,84,224,150,172,191,102,61,126,133,74,171,120,93,177,203,217,187,20,158,51,13,223,26,28,38,1,101,231,160,218,48,158,147,95,179,159,169,114,111,68,151,249,210,254,13,60,178,85,35,5,194,135,26,197,40,232,125,62,122,69,217,241,84,75,64,94,116,119,56,182,193,96,49,164,81,215,225,96,170,133,112,244,124,16,28,239,142,203,4,185,223,129,3,254,70,58,151,69,89,205,253,228,95,16,154,127,0,39,85,9,253,203,72,94,220,126,141,121,175,187,44,171,201,19,212,129,116,149,95,140,100,52,33,190,204,44,74,65,250,94,1,183,110,155,119,6,4,0,0 };
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

