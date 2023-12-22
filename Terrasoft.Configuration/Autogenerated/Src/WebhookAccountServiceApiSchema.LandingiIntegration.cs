﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookAccountServiceApiSchema

	/// <exclude/>
	public class WebhookAccountServiceApiSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookAccountServiceApiSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookAccountServiceApiSchema(WebhookAccountServiceApiSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ce2d5686-10c2-4456-b30b-311b0024e290");
			Name = "WebhookAccountServiceApi";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8e07ad5d-ca48-4dfc-8107-c7bee2abec1b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,85,77,111,218,64,16,61,39,82,254,195,200,237,129,72,145,125,79,0,41,229,80,69,106,165,168,36,234,177,90,150,49,172,106,118,221,217,53,105,133,242,223,59,251,97,130,9,166,164,85,185,121,62,222,204,188,125,51,104,177,66,91,11,137,240,128,68,194,154,210,229,19,163,75,181,104,72,56,101,116,254,73,232,185,210,11,117,167,29,46,162,237,226,124,115,113,126,214,88,54,119,210,8,111,46,206,217,243,142,112,193,97,48,169,132,181,215,240,21,103,75,99,190,223,74,105,26,237,166,72,107,37,241,182,86,33,182,40,10,24,42,189,68,82,110,110,36,72,194,114,148,221,245,229,100,197,152,147,234,102,86,41,142,245,248,189,240,112,13,175,108,87,208,139,204,176,155,208,209,75,251,70,91,39,180,227,17,238,73,173,133,195,232,175,227,7,72,239,7,235,200,243,48,149,166,70,24,65,246,20,241,115,30,196,147,149,151,77,85,125,19,82,162,181,217,77,42,128,122,30,107,28,40,72,141,116,134,124,205,48,100,140,8,44,217,102,181,18,244,107,220,26,118,194,193,148,224,150,24,25,201,183,25,197,126,202,176,22,36,86,160,249,213,71,89,99,145,24,67,163,244,143,154,141,239,194,184,44,5,6,123,236,248,242,97,17,18,3,78,34,191,143,199,65,55,21,186,85,46,61,194,217,53,204,132,197,65,215,117,21,57,188,132,13,60,31,231,233,51,186,165,153,31,162,232,116,33,229,19,255,62,152,236,81,86,237,104,31,184,185,110,222,23,94,18,102,27,161,147,53,216,15,250,209,32,43,66,196,207,24,154,140,60,85,152,124,45,8,26,170,88,40,239,179,77,183,169,71,170,158,11,81,171,34,41,200,38,156,34,40,9,189,120,18,0,181,221,140,96,202,20,221,27,219,214,30,246,183,62,30,112,221,171,195,205,69,104,66,215,144,222,162,7,227,243,223,145,251,17,221,180,153,37,187,237,178,155,146,118,252,91,118,187,105,131,127,33,109,129,142,213,255,210,194,73,236,245,183,150,216,211,188,204,127,102,107,79,183,209,186,103,220,223,104,255,125,79,102,173,230,8,74,151,134,86,225,212,66,73,102,5,237,112,237,235,129,141,211,231,45,208,238,162,39,154,21,223,107,42,253,101,127,195,201,235,223,172,87,199,39,8,200,134,171,147,218,107,187,2,230,61,53,122,234,41,58,164,202,108,252,192,216,237,196,113,9,152,238,224,235,28,164,255,177,174,55,71,70,103,149,198,185,43,197,233,124,44,249,230,26,169,56,123,14,79,202,45,143,240,113,244,54,71,69,217,48,54,254,100,108,255,191,114,12,107,88,180,41,30,227,13,123,117,248,127,136,117,26,164,186,243,251,13,162,252,55,220,31,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ce2d5686-10c2-4456-b30b-311b0024e290"));
		}

		#endregion

	}

	#endregion

}

