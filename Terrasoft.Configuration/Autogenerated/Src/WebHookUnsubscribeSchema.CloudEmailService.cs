﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebHookUnsubscribeSchema

	/// <exclude/>
	public class WebHookUnsubscribeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebHookUnsubscribeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebHookUnsubscribeSchema(WebHookUnsubscribeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b1ddfecd-6e11-4638-88ce-8129d7b2cfcd");
			Name = "WebHookUnsubscribe";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("457f57e6-ba32-4a54-a8b9-9eba8360aae2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,85,75,79,219,64,16,62,39,18,255,97,107,46,182,136,28,245,10,77,37,18,194,67,45,129,54,137,56,84,61,108,214,147,100,133,189,235,238,131,54,2,254,123,103,215,15,121,67,65,244,2,222,121,207,55,223,76,4,45,64,151,148,1,89,128,82,84,203,181,73,39,82,172,249,198,42,106,184,20,7,253,199,131,126,207,106,46,54,100,190,211,6,138,147,246,61,145,10,194,87,122,54,70,1,138,14,21,108,208,155,76,114,170,245,49,89,10,109,87,154,41,190,2,175,46,237,42,231,140,48,167,237,42,201,49,25,83,13,119,176,186,148,242,30,13,31,189,121,27,238,86,201,18,148,225,128,49,111,125,140,74,95,199,211,70,185,74,166,5,229,249,105,150,41,192,232,174,252,94,111,3,230,196,127,232,250,227,185,114,28,14,135,228,147,182,69,65,213,238,115,35,248,14,37,186,130,48,154,152,45,16,158,225,39,95,115,80,68,174,189,68,1,227,37,71,41,225,130,80,194,164,96,10,12,16,112,137,211,54,238,176,27,184,46,241,194,242,12,19,212,254,75,124,188,93,224,33,136,172,106,62,68,226,26,204,86,102,14,6,197,31,168,129,26,135,234,65,30,36,6,94,150,25,126,119,193,136,151,26,20,142,87,0,115,179,37,54,120,38,117,41,124,77,226,15,21,148,233,149,158,217,60,191,81,211,162,52,187,184,27,43,33,79,79,97,35,163,145,239,46,245,182,77,176,30,2,99,149,168,122,123,246,127,31,168,34,43,48,100,68,4,252,38,99,155,223,251,184,11,170,16,132,120,175,166,147,214,133,235,115,48,108,59,183,140,185,185,142,92,140,212,139,206,149,44,206,198,113,116,77,17,43,158,231,87,89,52,8,74,27,184,76,63,126,146,71,18,117,91,136,200,115,29,223,181,28,198,111,235,15,200,84,37,237,138,58,141,189,123,98,47,137,43,31,112,251,144,103,13,131,47,192,92,40,105,203,47,176,139,155,74,42,32,201,10,247,35,13,245,71,33,227,143,130,222,187,100,218,207,230,105,114,137,168,229,205,202,189,143,33,110,28,182,196,77,220,3,167,251,76,23,114,233,76,226,26,226,127,176,241,213,81,227,61,152,67,142,226,111,22,212,174,38,74,37,217,119,170,134,132,55,43,183,133,136,171,127,238,130,105,19,127,76,26,173,35,72,28,161,212,80,102,38,178,40,172,224,204,159,183,168,49,185,219,130,130,214,6,25,148,32,247,167,191,44,205,91,97,52,136,156,188,118,56,21,153,211,116,98,45,118,37,116,12,26,247,186,166,91,170,240,214,26,4,196,53,227,22,37,126,225,237,235,214,21,191,174,178,36,233,230,58,183,130,165,21,162,209,204,22,43,80,81,146,188,158,228,197,120,146,132,80,93,131,88,95,154,0,229,116,94,34,107,214,187,153,252,42,217,253,37,199,235,215,140,206,21,92,141,111,15,253,1,105,177,105,74,157,227,10,71,103,114,38,13,50,201,231,199,93,12,198,98,148,133,36,132,189,121,77,255,112,236,63,14,11,107,148,55,42,192,160,138,253,159,16,180,121,128,89,236,38,121,227,210,186,149,118,63,100,129,212,155,246,251,127,1,78,209,156,119,54,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b1ddfecd-6e11-4638-88ce-8129d7b2cfcd"));
		}

		#endregion

	}

	#endregion

}
