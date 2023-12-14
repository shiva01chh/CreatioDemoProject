﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebHookRecipientHourlyStatisticsSchema

	/// <exclude/>
	public class WebHookRecipientHourlyStatisticsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebHookRecipientHourlyStatisticsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebHookRecipientHourlyStatisticsSchema(WebHookRecipientHourlyStatisticsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("90e3f737-db1c-45db-8f5f-c522eb9029ba");
			Name = "WebHookRecipientHourlyStatistics";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("457f57e6-ba32-4a54-a8b9-9eba8360aae2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,85,75,111,226,48,16,62,167,82,255,131,197,94,18,45,138,180,215,69,123,104,129,45,104,183,20,109,64,61,86,38,25,192,34,177,83,63,178,69,85,255,251,142,19,39,36,180,148,133,131,99,123,158,223,55,227,129,211,12,84,78,99,32,11,144,146,42,177,214,225,80,240,53,219,24,73,53,19,252,250,234,245,250,202,51,138,241,13,137,246,74,67,54,104,206,67,33,161,123,10,71,183,120,129,87,95,36,108,208,154,12,83,170,212,119,242,7,98,150,51,224,122,34,140,76,247,145,70,223,74,179,88,149,202,185,89,165,44,38,177,213,61,173,74,90,110,218,14,188,215,210,73,19,114,46,69,14,82,51,192,184,243,210,115,37,207,37,43,168,6,50,194,101,193,50,32,79,9,238,238,169,220,13,74,113,149,68,35,29,57,33,177,248,61,111,3,218,237,60,9,218,72,78,30,97,53,17,98,183,212,44,101,54,90,120,7,58,162,107,136,158,83,107,235,55,238,131,210,191,247,86,174,234,224,167,81,32,63,72,65,83,3,45,189,55,135,9,120,82,193,234,98,188,7,189,21,201,49,192,10,129,40,176,146,44,1,162,180,180,117,193,180,238,164,48,249,47,216,251,129,139,237,32,172,168,130,176,43,255,218,0,31,180,242,56,118,93,8,150,144,9,229,73,10,142,6,127,169,64,98,231,112,136,109,219,16,211,57,214,113,35,56,148,206,239,170,244,73,239,214,164,187,113,70,89,90,149,126,136,33,119,170,215,39,213,198,209,120,145,139,135,28,184,245,80,126,131,14,34,215,13,37,146,142,207,79,129,244,107,86,85,188,133,140,206,240,249,244,9,227,154,196,194,112,93,195,44,168,36,10,82,52,193,210,114,248,139,1,236,225,40,221,160,106,131,112,33,114,255,91,125,24,138,212,100,220,175,62,225,156,74,140,160,65,250,149,255,32,188,81,126,111,92,224,19,80,67,123,211,59,103,87,87,211,153,214,199,179,118,37,137,211,196,153,53,180,78,147,198,242,167,20,153,223,195,153,240,192,1,31,166,144,7,209,227,22,36,248,65,56,19,26,215,241,11,18,171,252,115,60,28,231,130,10,74,35,49,141,184,12,120,224,189,185,175,162,117,115,12,167,106,252,108,104,250,9,176,218,252,134,39,109,94,78,91,30,168,12,8,85,14,203,192,189,106,187,15,163,28,7,212,122,63,19,191,69,188,155,96,91,40,223,117,173,5,63,229,8,91,127,76,65,56,229,90,188,7,23,98,103,118,235,141,61,222,228,218,238,247,163,194,184,40,85,94,181,96,252,2,177,193,201,212,202,105,153,219,33,244,238,29,253,87,34,167,122,180,211,4,23,50,235,108,203,154,92,90,208,35,124,31,143,80,59,93,237,255,83,231,22,47,241,247,15,1,90,177,90,12,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("90e3f737-db1c-45db-8f5f-c522eb9029ba"));
		}

		#endregion

	}

	#endregion

}

