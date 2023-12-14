﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebHookEmailStatisticsSchema

	/// <exclude/>
	public class WebHookEmailStatisticsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebHookEmailStatisticsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebHookEmailStatisticsSchema(WebHookEmailStatisticsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9c505bb-f448-410f-97a3-04d9fe8ad6e6");
			Name = "WebHookEmailStatistics";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("457f57e6-ba32-4a54-a8b9-9eba8360aae2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,88,77,111,219,56,16,61,187,64,255,3,235,94,100,196,16,10,44,176,135,164,13,80,39,118,106,236,166,205,198,206,246,16,4,11,89,98,108,110,36,81,75,82,73,13,215,255,125,135,95,146,72,75,182,219,230,96,68,210,204,112,102,248,222,112,134,121,148,97,94,68,49,70,115,204,88,196,233,163,8,47,104,254,72,150,37,139,4,161,249,235,87,155,215,175,122,37,39,249,18,205,214,92,224,236,204,123,6,249,52,197,177,20,230,225,21,206,49,35,113,45,211,97,54,188,142,216,19,22,32,17,222,9,146,18,65,48,111,87,98,184,235,125,120,57,234,252,52,137,98,65,153,54,10,50,111,25,94,194,170,232,34,141,56,63,69,227,44,34,233,76,128,39,92,144,152,43,145,162,92,164,36,70,177,148,240,5,208,41,26,69,28,127,197,139,79,148,62,129,240,70,169,84,102,111,24,45,48,147,49,156,162,27,101,71,127,55,54,175,74,146,104,147,211,4,109,208,18,139,51,196,229,207,214,17,35,185,0,7,73,252,196,15,8,125,41,112,126,72,102,6,169,24,209,50,135,157,221,47,248,41,98,201,81,130,179,34,202,14,136,92,226,148,60,99,134,15,69,57,195,240,179,95,228,22,255,11,152,58,104,233,46,231,229,130,199,140,44,14,185,111,124,91,143,25,163,236,128,236,248,91,65,90,162,232,245,252,56,4,45,10,156,92,71,121,25,165,233,250,144,85,11,42,220,14,131,183,56,79,52,160,92,116,93,99,177,162,137,132,22,35,207,160,109,12,235,7,244,76,1,92,119,69,2,255,3,12,151,12,115,30,220,113,204,128,110,185,102,37,42,157,199,1,146,140,238,245,158,35,134,10,163,113,139,11,202,9,48,102,141,62,104,146,104,2,173,129,208,226,61,108,87,2,28,83,254,223,236,104,156,7,202,92,47,199,47,8,86,225,130,149,82,245,35,91,150,25,236,115,208,119,151,239,15,125,127,6,103,202,192,174,47,225,52,143,25,150,70,110,113,140,97,247,146,105,14,149,34,74,111,161,102,193,74,152,7,134,85,218,196,214,205,140,70,154,24,149,233,83,149,250,242,64,114,134,154,172,92,137,78,19,253,120,255,128,98,48,184,4,151,166,9,183,249,99,88,148,44,71,50,108,157,254,192,55,213,175,150,238,15,116,142,66,240,39,232,207,140,117,72,5,212,206,50,203,195,155,136,65,33,22,152,5,118,229,129,213,248,186,2,66,5,125,144,30,132,83,62,254,15,144,22,236,104,217,52,88,165,143,121,18,244,47,42,159,165,106,190,163,197,131,102,84,131,112,252,13,199,37,132,209,154,76,5,179,79,81,158,164,88,45,102,40,98,119,226,56,200,181,236,134,159,179,107,248,4,88,83,64,226,161,39,109,22,149,251,82,99,238,254,97,227,105,93,3,126,51,253,166,50,80,39,195,95,99,206,200,114,41,139,150,146,107,81,64,219,163,50,114,65,179,34,133,188,254,96,78,36,13,23,118,81,96,159,12,169,114,194,75,143,97,10,121,68,193,155,74,39,156,96,17,175,38,140,102,151,35,133,147,161,61,107,134,210,24,128,119,131,12,228,250,16,10,250,254,93,231,174,54,96,241,136,222,124,216,159,255,191,74,92,202,244,91,223,13,7,180,87,219,42,156,82,209,1,242,16,83,150,112,136,233,87,247,125,66,114,194,87,191,186,241,118,31,85,254,60,31,207,209,187,42,40,25,2,199,178,165,153,21,208,153,204,49,23,160,172,119,102,166,222,251,219,18,106,106,1,179,107,5,224,156,220,147,96,183,8,252,40,167,81,196,205,186,103,13,7,29,215,118,220,181,100,158,197,81,26,177,247,178,138,157,27,98,235,248,155,250,176,237,82,32,28,103,133,88,87,105,112,217,42,197,59,182,174,97,202,174,176,173,17,209,198,154,46,203,71,149,230,198,106,109,20,82,246,124,30,169,151,199,144,73,9,58,140,106,174,87,229,198,192,174,106,93,195,63,233,50,84,157,197,132,178,44,18,230,72,236,245,239,189,78,50,236,8,253,225,20,77,224,13,244,28,130,162,71,185,188,231,60,122,4,119,208,229,40,236,163,19,4,200,57,69,155,119,219,254,208,172,211,178,5,237,212,212,64,185,128,126,79,28,133,232,9,52,134,161,18,215,112,109,1,181,69,179,131,125,115,14,117,130,219,201,170,62,174,170,83,177,86,254,76,69,135,254,145,229,98,151,60,50,9,177,9,191,145,12,143,47,208,58,84,116,145,0,49,26,31,26,85,194,131,12,236,171,118,242,239,40,45,177,115,198,119,249,90,239,126,195,97,179,123,208,69,201,169,70,68,139,20,127,134,152,165,183,234,85,104,0,214,159,205,255,81,8,104,18,34,156,83,57,167,252,246,123,96,155,170,94,13,209,75,24,82,230,210,94,80,89,245,91,177,33,130,230,13,15,154,160,241,195,140,158,27,13,130,105,136,27,253,214,85,3,222,246,28,212,25,57,192,109,19,48,51,58,210,187,38,189,143,197,173,129,142,65,175,99,205,124,234,40,202,191,88,147,77,51,120,20,162,142,110,247,119,39,73,10,19,12,35,9,182,233,130,116,95,49,90,22,127,224,117,224,245,165,11,0,66,232,126,63,177,141,129,211,206,120,150,27,109,141,153,119,127,162,143,241,6,35,187,111,221,232,216,105,157,219,44,244,7,53,135,177,110,5,127,194,242,184,161,217,180,200,245,138,179,50,203,34,86,185,188,63,164,19,127,4,220,113,208,51,231,184,125,98,7,77,173,117,228,36,97,102,8,64,143,14,161,101,136,144,243,245,192,25,57,234,41,191,83,169,22,113,85,235,155,132,238,245,42,17,87,213,14,241,157,138,86,192,85,107,12,245,157,154,13,25,207,221,34,202,186,29,133,143,174,184,190,112,233,84,208,159,93,21,117,253,210,169,161,190,186,10,213,181,72,167,82,37,225,42,94,211,132,60,18,156,140,214,237,195,98,117,137,86,245,191,80,82,72,154,74,194,78,59,108,125,201,91,29,0,212,205,73,134,195,59,17,127,166,47,131,157,121,85,181,47,82,234,135,181,157,139,151,61,193,107,1,87,119,188,75,162,54,11,45,92,107,181,51,205,111,24,125,134,42,199,58,77,25,73,63,1,138,228,71,168,123,229,160,213,204,161,104,90,10,209,79,222,6,120,35,189,170,75,43,85,218,25,31,173,109,157,188,160,9,54,135,234,37,81,5,7,150,149,7,214,16,125,84,143,239,221,3,224,252,220,246,64,27,20,128,216,160,190,216,10,77,250,134,123,174,10,208,118,216,165,109,71,232,225,222,185,26,153,233,162,110,207,218,99,130,201,126,13,231,130,62,6,154,151,111,67,68,75,129,26,201,168,27,123,193,214,213,252,99,62,182,143,13,189,173,188,19,138,87,0,152,24,23,234,92,196,245,232,116,236,124,208,50,32,56,71,47,140,5,250,190,242,101,5,195,129,118,87,158,251,94,195,139,94,136,88,161,106,40,64,216,206,5,61,231,126,204,153,203,122,222,157,97,91,148,237,157,138,126,235,190,84,239,224,239,127,31,41,192,154,80,24,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9c505bb-f448-410f-97a3-04d9fe8ad6e6"));
		}

		#endregion

	}

	#endregion

}

