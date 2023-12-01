﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookCleanerJobDispatcherSchema

	/// <exclude/>
	public class WebhookCleanerJobDispatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookCleanerJobDispatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookCleanerJobDispatcherSchema(WebhookCleanerJobDispatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("01d57ddf-69d7-4037-8186-1061ea1dd81b");
			Name = "WebhookCleanerJobDispatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("61c13b36-df90-4d5b-abdb-12d5efdb63fa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,87,75,83,35,57,12,62,67,213,252,7,87,230,210,169,202,118,246,12,36,83,108,8,84,182,96,96,32,179,156,157,110,117,226,165,219,110,252,72,38,75,241,223,87,182,251,77,18,152,157,189,164,98,91,150,100,233,211,39,53,167,25,168,156,70,64,230,32,37,85,34,209,225,68,240,132,45,141,164,154,9,254,233,248,229,211,241,145,81,140,47,201,195,86,105,200,78,59,235,240,154,241,231,122,115,153,138,5,77,79,78,38,34,203,4,15,175,197,114,137,219,245,249,55,67,165,254,167,94,55,237,74,104,27,223,43,53,229,154,105,6,106,175,192,67,180,130,216,164,32,119,73,60,194,34,244,238,181,222,242,0,90,227,95,101,21,144,209,65,199,194,134,56,234,64,45,159,37,44,241,128,76,82,170,212,9,65,19,43,33,158,38,41,80,14,242,79,177,184,96,24,102,141,94,73,39,62,28,14,201,153,50,89,70,229,118,92,172,239,164,88,179,24,20,201,64,175,68,172,136,22,68,21,239,32,127,139,5,161,60,38,145,213,104,114,34,210,152,108,188,17,21,150,10,135,13,141,185,89,164,44,66,121,244,231,144,59,228,132,252,65,21,124,51,96,160,117,48,32,179,243,60,159,174,129,235,107,134,137,230,214,245,163,23,231,126,245,92,244,57,7,105,83,113,66,238,156,69,127,222,125,159,219,152,113,165,41,71,172,137,4,15,1,72,36,33,25,245,102,85,178,122,195,49,217,48,189,34,28,97,73,122,133,215,202,67,166,150,34,66,146,24,18,106,82,29,86,198,154,111,47,31,95,107,46,35,160,234,157,209,152,92,120,37,213,94,120,201,120,92,173,130,189,14,244,173,141,163,47,95,222,42,40,159,120,122,32,12,95,237,227,48,4,54,165,75,41,76,126,248,17,98,141,64,68,92,16,165,165,69,42,38,233,202,222,114,106,240,17,149,151,189,194,232,103,224,177,79,79,59,87,55,30,86,152,40,201,214,84,131,63,205,253,130,184,146,218,78,68,154,66,100,33,78,174,64,23,154,31,52,213,70,129,154,11,7,160,160,79,94,92,0,214,84,18,80,207,88,43,28,54,133,2,27,138,140,34,154,228,54,248,174,64,98,217,112,175,48,108,10,220,80,78,151,22,99,189,150,141,94,255,212,105,158,189,81,118,201,82,13,114,134,124,67,18,247,151,140,156,228,17,58,16,78,36,224,19,188,200,35,226,231,142,74,12,14,46,84,224,55,177,218,115,42,153,18,124,190,205,33,188,114,242,214,250,5,164,40,119,158,224,234,130,110,85,111,64,126,47,92,176,122,253,101,21,158,199,113,224,173,54,14,113,19,163,101,50,30,188,209,210,144,194,88,219,132,186,55,120,241,112,166,206,211,13,181,4,98,67,141,209,211,210,128,191,33,65,27,201,109,80,67,12,127,55,37,157,128,122,43,175,237,52,174,5,139,201,61,100,136,154,18,23,193,149,193,61,229,2,60,139,7,132,113,141,229,211,242,184,204,40,75,72,208,57,34,103,35,140,73,113,94,56,232,157,125,117,191,23,104,117,206,16,138,152,171,232,201,253,27,145,114,51,252,174,163,175,98,99,99,101,117,5,191,117,237,158,254,239,64,250,16,132,226,10,46,191,2,163,107,80,234,86,78,159,13,77,209,254,141,136,89,194,32,190,229,136,162,42,24,31,241,198,167,6,55,126,205,157,210,145,162,148,6,85,202,247,32,186,14,194,30,129,134,95,255,25,209,157,74,105,4,105,119,41,181,121,224,131,133,224,99,22,206,133,109,84,65,185,188,20,114,74,163,85,0,238,182,165,74,255,47,244,229,26,244,91,5,244,1,214,20,26,237,65,220,160,118,198,177,81,50,29,139,104,232,41,187,148,169,89,123,134,19,144,229,82,59,8,97,79,233,91,63,240,127,129,219,176,62,169,121,188,127,250,147,38,234,166,134,234,234,254,229,108,189,105,124,135,90,83,41,164,108,115,218,211,150,220,78,110,177,232,218,244,168,183,17,242,201,205,144,182,35,245,198,101,123,139,140,148,24,112,82,29,135,103,67,119,109,183,22,108,48,210,43,152,20,23,237,142,59,108,93,220,241,126,199,121,165,235,216,30,131,162,83,182,28,27,148,253,179,52,84,114,26,142,114,22,78,51,158,136,210,103,187,70,20,119,104,103,82,31,122,116,90,34,197,233,135,137,120,198,111,24,55,26,227,54,34,1,110,247,59,227,164,77,243,95,52,53,208,65,110,77,91,245,104,54,227,88,128,107,154,150,53,176,16,34,37,76,249,97,187,240,172,174,47,75,157,25,83,9,147,112,39,112,92,64,156,19,28,219,170,108,223,248,51,59,151,72,227,223,113,15,229,84,137,212,108,137,5,219,5,101,28,125,189,135,28,41,103,34,12,215,94,123,83,83,53,83,251,167,166,91,244,245,236,192,96,57,14,154,147,202,160,27,205,199,10,22,238,216,215,108,35,254,126,187,27,223,1,225,38,69,146,107,198,99,208,14,64,171,170,119,162,188,26,180,83,177,196,1,11,199,236,5,16,248,1,145,177,176,98,220,77,102,122,133,244,27,239,27,205,246,128,208,229,142,211,116,234,149,85,147,210,155,225,74,181,71,42,76,218,129,113,203,231,34,65,28,33,157,145,192,43,43,200,204,186,219,81,86,53,107,139,141,178,7,160,133,130,253,10,254,246,132,235,64,121,90,139,119,155,127,117,11,221,179,77,38,110,92,67,106,210,227,189,195,207,81,103,8,169,231,143,221,51,192,235,79,113,241,123,159,26,53,145,101,5,90,93,82,49,134,173,47,39,255,57,101,89,193,126,91,33,63,128,251,234,146,85,133,144,133,20,79,192,237,145,37,105,245,81,78,140,4,34,225,135,238,141,247,124,243,148,95,86,147,66,110,56,110,147,156,31,253,29,166,110,185,173,66,141,95,32,65,231,22,41,172,148,9,199,28,181,139,44,40,5,124,136,231,114,91,215,190,229,201,246,4,217,181,57,229,241,1,139,100,231,181,7,28,137,208,240,59,238,190,115,251,160,225,250,110,7,37,126,183,189,137,123,199,199,255,2,28,154,144,27,228,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("01d57ddf-69d7-4037-8186-1061ea1dd81b"));
		}

		#endregion

	}

	#endregion

}
