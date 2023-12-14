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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,87,223,111,219,54,16,126,118,129,254,15,132,247,34,3,129,220,189,214,191,144,184,205,96,44,75,138,58,221,30,138,162,160,165,147,77,84,34,85,146,178,163,5,249,223,119,20,41,91,162,45,59,195,48,63,137,228,221,241,248,125,223,29,105,78,51,80,57,141,128,60,130,148,84,137,68,135,115,193,19,182,46,36,213,76,240,240,142,242,152,241,53,91,112,13,107,59,247,246,205,243,219,55,189,66,225,52,89,150,74,67,54,242,198,24,35,77,33,50,198,42,252,13,56,72,22,29,217,220,49,254,243,48,217,220,63,203,4,63,189,34,161,107,62,188,165,145,22,146,129,58,88,152,121,123,26,50,241,205,91,167,68,23,116,250,69,194,26,7,100,158,82,165,222,147,191,96,181,17,226,199,117,20,137,130,235,79,82,108,89,12,178,178,28,14,135,100,204,248,6,207,165,99,17,145,72,66,50,233,47,78,123,244,135,83,116,249,250,1,18,90,164,250,134,85,120,6,186,204,65,36,65,135,207,96,240,13,125,242,98,149,50,140,110,242,233,72,135,188,39,29,33,208,255,185,74,246,112,46,100,67,83,174,241,108,159,36,219,82,13,118,61,183,3,18,153,117,162,180,52,216,45,98,224,154,233,114,158,50,252,64,202,230,34,6,132,177,95,47,44,65,110,65,218,229,69,220,31,29,71,98,92,147,207,56,188,99,25,211,232,250,235,187,119,35,151,17,240,216,38,213,206,240,150,65,26,119,165,39,129,198,130,167,37,249,162,112,95,193,185,21,24,249,94,180,198,173,68,60,108,76,206,44,130,235,156,145,239,187,142,149,11,41,86,32,202,194,104,205,36,90,49,100,45,42,81,168,34,203,168,44,167,245,196,130,51,205,104,202,254,6,69,40,225,176,67,84,12,9,88,113,34,33,122,3,232,2,224,4,212,169,31,43,129,112,191,203,208,223,102,156,83,73,51,194,177,156,39,253,54,30,253,233,35,238,98,230,12,45,110,50,28,15,43,143,42,128,147,217,233,221,3,15,237,118,240,1,49,173,160,215,243,56,64,178,79,144,242,114,30,89,220,49,7,169,177,130,59,4,224,41,179,45,64,50,169,206,210,59,212,124,136,162,93,130,214,232,99,154,144,254,147,166,5,4,94,166,87,167,133,126,69,250,253,193,5,37,180,242,189,164,3,195,129,83,28,10,193,66,76,148,21,29,161,57,235,224,214,81,211,45,227,206,5,203,203,26,116,13,76,175,83,241,100,54,179,22,65,183,201,164,210,110,215,110,62,170,131,65,69,120,79,85,219,119,215,26,134,221,26,86,154,242,248,87,189,53,116,211,75,81,200,8,148,109,181,123,212,62,242,34,3,73,87,41,140,173,118,166,164,109,111,146,59,24,133,31,179,92,151,181,105,112,137,255,63,64,111,68,103,183,114,98,157,99,215,210,112,15,59,60,237,15,40,3,55,189,107,166,129,26,60,92,174,11,158,8,211,57,155,227,186,202,182,84,26,56,48,224,103,248,89,128,210,39,105,169,215,172,79,207,102,16,223,148,104,236,209,20,206,11,41,81,244,166,196,195,123,236,29,87,45,151,7,83,199,31,240,235,145,101,16,126,209,209,189,216,57,139,133,186,198,8,91,115,33,96,51,172,253,154,205,126,255,237,214,90,192,227,122,27,1,23,181,85,138,166,166,59,138,189,153,39,19,13,115,15,184,240,156,195,18,16,75,221,233,100,151,173,227,139,149,243,13,85,224,99,173,114,188,16,192,209,18,47,139,149,91,193,184,93,213,18,90,124,221,124,208,98,212,21,14,238,92,72,126,28,53,68,247,223,161,124,77,59,61,200,211,239,77,175,46,46,108,154,15,210,38,91,211,183,63,4,102,209,174,54,167,236,11,62,255,173,0,234,136,123,60,212,158,128,221,209,210,57,6,48,203,134,101,80,183,43,155,27,173,50,189,41,143,180,122,240,152,133,141,129,213,214,44,188,101,82,225,225,221,67,47,120,50,221,229,41,244,132,239,41,127,48,107,82,218,99,9,9,218,219,135,11,117,95,164,233,131,172,154,83,48,168,161,232,29,101,233,183,26,15,98,31,82,187,225,75,83,110,237,144,103,68,102,103,189,73,255,222,51,99,39,37,243,246,145,66,232,253,205,151,72,145,85,175,31,120,210,32,57,77,253,59,49,172,3,54,175,67,167,52,115,18,153,152,63,45,103,159,190,29,55,49,82,175,136,168,27,105,149,132,67,106,127,31,171,98,229,210,121,237,147,171,133,181,125,113,237,111,123,101,121,108,190,184,142,252,61,114,250,211,35,107,75,145,170,66,35,187,68,139,163,180,205,51,98,60,172,13,141,231,255,90,147,163,51,207,157,10,100,3,237,178,200,115,33,177,135,29,178,117,87,239,10,207,176,97,138,228,117,183,57,13,245,43,46,241,103,130,207,156,17,121,177,194,172,180,137,191,127,0,216,168,113,119,219,14,0,0 };
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

