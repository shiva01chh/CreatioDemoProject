﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebHookRecipientHyperlinkStatisticsSchema

	/// <exclude/>
	public class WebHookRecipientHyperlinkStatisticsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebHookRecipientHyperlinkStatisticsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebHookRecipientHyperlinkStatisticsSchema(WebHookRecipientHyperlinkStatisticsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("98543773-5b38-4c1d-a07a-bb47185bf9ee");
			Name = "WebHookRecipientHyperlinkStatistics";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("457f57e6-ba32-4a54-a8b9-9eba8360aae2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,85,75,115,218,48,16,62,195,76,254,131,134,92,236,41,227,105,175,201,228,80,8,5,218,36,165,60,38,103,197,94,64,131,45,185,122,208,50,153,252,247,174,252,16,22,143,144,94,108,75,187,251,237,126,223,174,100,78,51,80,57,141,129,204,65,74,170,196,82,71,125,193,151,108,101,36,213,76,240,171,246,235,85,187,101,20,227,43,50,219,41,13,217,173,91,247,133,4,127,21,221,247,112,3,183,174,37,172,48,154,244,83,170,212,13,153,66,204,114,6,92,143,118,57,200,148,241,205,76,35,188,210,44,86,133,127,110,94,82,22,147,216,186,191,235,77,110,72,143,42,120,134,151,145,16,27,140,124,45,226,93,194,137,20,24,163,25,96,214,73,1,90,218,171,4,67,195,146,61,254,98,156,16,75,175,213,90,129,190,45,62,84,245,241,230,133,41,45,45,197,162,158,7,172,231,99,81,69,178,65,70,89,122,49,207,53,240,164,100,224,211,121,4,189,22,201,105,46,98,139,45,99,9,212,213,13,65,15,165,48,249,15,216,5,97,149,79,130,54,146,147,23,148,44,242,237,159,60,25,162,185,152,21,40,133,197,241,60,65,202,101,221,10,100,55,162,60,73,235,110,4,11,5,18,167,135,67,108,71,135,24,111,89,151,196,184,38,235,58,193,20,149,185,35,85,252,66,179,148,217,214,217,82,71,13,151,192,71,234,238,11,236,214,250,134,165,172,108,73,2,31,252,142,124,174,51,87,106,148,158,111,197,115,75,37,81,144,34,238,47,3,114,135,181,112,248,67,102,197,206,65,214,176,196,192,227,145,154,140,7,157,158,73,55,69,242,78,151,116,48,85,231,208,1,67,53,141,245,25,115,249,138,38,84,226,17,212,32,189,178,195,75,206,131,45,246,237,158,106,184,232,217,236,178,115,254,38,69,214,96,48,167,18,7,211,85,56,70,202,242,187,96,30,201,48,250,201,143,67,144,155,219,178,28,163,177,26,252,54,52,61,144,167,65,191,1,94,11,116,22,186,114,240,129,27,178,54,96,159,215,32,33,8,163,39,161,241,57,248,139,183,133,10,46,245,242,80,53,116,80,58,248,18,58,115,169,211,35,14,185,100,105,218,199,249,223,168,142,179,150,57,15,205,182,221,13,205,27,165,127,168,55,173,232,43,79,78,129,186,203,112,250,62,168,63,71,181,62,5,232,145,196,46,205,255,212,73,168,170,84,173,175,50,119,126,162,89,142,174,203,221,147,120,16,241,102,132,71,93,5,213,201,180,189,24,115,236,130,62,221,17,28,12,45,206,105,29,205,64,55,202,183,10,236,199,163,90,121,250,224,122,206,50,192,255,70,150,31,119,164,113,10,170,98,26,28,236,244,64,108,52,84,149,159,190,161,237,245,97,255,115,222,46,110,182,219,255,0,76,89,111,98,83,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("98543773-5b38-4c1d-a07a-bb47185bf9ee"));
		}

		#endregion

	}

	#endregion

}
