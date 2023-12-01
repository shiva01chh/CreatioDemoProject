﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookAccountProviderSchema

	/// <exclude/>
	public class WebhookAccountProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookAccountProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookAccountProviderSchema(WebhookAccountProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aff03d4b-8452-40b2-88a8-6431e75b910a");
			Name = "WebhookAccountProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8e07ad5d-ca48-4dfc-8107-c7bee2abec1b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,87,77,111,227,54,16,61,59,192,254,7,194,189,200,64,32,111,175,235,47,36,222,77,97,52,77,22,235,108,123,40,138,5,45,141,108,98,37,82,75,82,118,212,32,255,189,67,145,178,37,218,178,83,20,189,89,156,15,14,223,123,51,164,57,205,64,229,52,2,242,4,82,82,37,18,29,206,5,79,216,186,144,84,51,193,195,123,202,99,198,215,108,193,53,172,237,218,187,171,151,119,87,189,66,225,50,89,150,74,67,54,242,190,49,71,154,66,100,156,85,248,11,112,144,44,58,242,185,103,252,199,97,177,185,127,150,9,126,218,34,161,107,61,188,163,145,22,146,129,58,120,152,117,123,26,50,241,221,91,167,196,16,12,250,73,194,26,63,200,60,165,74,125,32,127,192,106,35,196,247,155,40,18,5,215,159,165,216,178,24,100,229,57,28,14,201,152,241,13,158,75,199,34,34,145,132,100,210,95,156,142,232,15,167,24,242,231,71,72,104,145,234,91,86,225,25,232,50,7,145,4,29,49,131,193,95,24,147,23,171,148,97,118,83,79,71,57,228,3,233,72,129,241,47,85,177,135,115,33,27,154,114,141,103,251,44,217,150,106,176,246,220,126,144,200,216,137,210,210,96,183,136,129,107,166,203,121,202,240,7,82,54,23,49,32,140,253,218,176,4,185,5,105,205,139,184,63,58,206,196,184,38,95,240,243,158,101,76,99,232,207,239,223,143,92,69,192,99,91,84,187,194,59,6,105,220,85,158,4,26,11,158,150,228,171,194,125,5,231,86,96,228,91,209,250,110,21,226,97,99,106,102,17,220,228,140,124,219,117,88,46,148,88,129,40,11,163,53,83,104,197,144,245,168,68,161,138,44,163,178,156,214,11,11,206,52,163,41,251,27,20,161,132,195,14,81,49,36,96,199,137,132,232,13,96,8,128,19,80,167,126,172,4,194,253,46,67,127,155,113,78,37,205,8,199,118,158,244,219,120,244,167,79,184,139,89,51,180,184,197,112,60,172,34,170,4,78,102,167,119,15,60,180,219,201,7,196,140,130,94,207,227,0,201,62,65,202,235,121,100,113,199,28,164,198,14,238,16,128,167,204,182,0,201,164,58,75,239,208,243,33,138,118,9,90,99,140,25,66,250,119,154,22,16,120,149,94,159,22,250,53,233,247,7,23,148,208,170,247,146,14,12,7,78,113,40,4,11,49,81,86,116,132,230,172,131,91,71,77,183,140,59,13,150,151,53,232,26,152,94,167,226,201,108,102,61,130,110,151,73,165,221,174,221,124,84,7,131,138,240,158,170,182,239,238,53,76,187,53,172,52,229,241,175,102,107,232,150,151,162,144,17,40,59,106,247,168,125,226,69,6,146,174,82,24,91,237,76,73,219,223,20,119,112,10,63,101,185,46,107,215,224,18,255,191,129,222,136,206,105,229,196,58,199,169,165,225,1,118,120,218,239,80,6,110,121,215,44,3,53,120,184,92,23,60,17,102,114,54,191,235,46,219,82,105,224,192,132,95,224,71,1,74,159,164,165,182,217,152,158,173,32,190,45,209,217,163,41,156,23,82,162,232,77,139,135,15,56,59,174,91,33,143,166,143,63,226,175,39,150,65,248,85,71,15,98,231,60,22,234,6,51,108,205,133,128,195,176,142,107,14,251,253,111,103,107,1,143,246,54,2,46,107,171,21,77,79,119,52,123,179,78,38,26,238,30,112,225,185,128,37,32,150,186,51,200,154,109,224,171,149,243,45,85,224,99,173,114,188,16,192,209,18,47,139,149,179,96,222,174,110,9,45,190,110,61,104,49,234,26,7,119,46,36,63,206,26,98,248,175,80,190,101,156,30,228,233,207,166,55,55,23,14,205,71,105,139,173,233,219,31,2,171,104,119,155,83,246,133,152,255,214,0,117,198,61,30,106,79,192,238,200,116,142,1,172,178,225,25,212,227,202,214,70,171,74,111,203,35,173,30,34,102,97,227,195,106,107,22,222,49,169,240,240,238,161,23,60,155,233,242,28,122,194,247,148,63,152,53,41,237,177,132,4,237,237,195,133,122,40,210,244,81,86,195,41,24,212,80,244,142,170,244,71,141,7,177,15,169,221,240,181,41,183,118,202,51,34,179,171,222,162,127,239,153,111,39,37,243,246,145,66,232,253,205,151,72,145,85,175,31,120,214,32,57,77,253,59,49,172,19,54,175,67,167,52,115,18,153,152,63,45,103,159,190,29,55,49,82,175,136,168,7,105,85,132,67,106,127,31,171,98,229,202,121,235,147,171,133,181,125,113,237,111,123,101,121,108,190,184,142,226,61,114,250,211,35,111,75,145,170,82,35,187,68,139,163,178,205,51,98,60,172,29,77,228,255,218,147,163,51,207,157,10,100,3,237,178,200,115,33,113,134,29,170,117,87,239,10,207,176,97,138,228,245,180,57,13,245,27,46,241,23,130,207,156,17,121,181,194,172,180,121,117,245,15,45,62,242,121,218,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aff03d4b-8452-40b2-88a8-6431e75b910a"));
		}

		#endregion

	}

	#endregion

}

