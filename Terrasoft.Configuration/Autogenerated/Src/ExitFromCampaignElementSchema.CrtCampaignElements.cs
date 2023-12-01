﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExitFromCampaignElementSchema

	/// <exclude/>
	public class ExitFromCampaignElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExitFromCampaignElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExitFromCampaignElementSchema(ExitFromCampaignElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("65fb0cb4-92a4-4476-9879-fac50338a30b");
			Name = "ExitFromCampaignElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("563c51a8-1ac8-4a7d-92f4-61068e6285af");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,88,221,111,219,54,16,127,118,129,254,15,7,239,161,54,230,216,107,51,120,137,147,120,104,237,56,51,176,4,65,155,180,15,197,30,24,137,178,185,73,162,64,82,73,188,52,255,251,142,95,178,100,91,182,59,228,97,11,16,91,228,29,79,199,223,239,62,72,167,36,161,50,35,1,133,27,42,4,145,60,82,221,17,79,35,54,203,5,81,140,167,175,95,61,189,126,213,200,37,75,103,240,105,33,21,77,78,86,198,168,31,199,52,208,202,178,123,65,83,42,88,176,212,41,155,77,18,158,110,150,8,90,55,223,29,145,36,35,108,86,187,176,80,232,78,83,69,69,132,123,145,181,186,215,130,163,88,203,81,227,7,65,103,232,52,140,98,34,229,0,206,31,153,154,8,158,120,123,231,49,77,104,170,140,106,175,215,131,83,153,39,9,17,139,161,27,59,57,168,57,81,64,31,131,56,15,169,132,140,8,197,2,150,145,84,73,136,208,28,4,222,63,111,167,87,50,244,117,76,37,202,46,121,72,209,183,140,10,181,104,93,33,39,112,6,205,169,244,174,92,112,18,55,59,168,222,184,149,100,70,111,22,153,86,88,46,45,102,187,87,92,125,102,146,221,197,180,3,151,84,17,111,212,217,172,154,44,11,219,127,160,249,44,191,139,89,0,129,6,164,14,15,24,192,7,34,169,159,125,159,135,140,166,1,117,210,14,76,207,31,21,77,67,130,46,20,8,54,158,12,138,75,196,49,84,148,70,104,0,215,130,221,19,69,173,60,179,3,8,180,28,164,18,154,194,122,159,55,128,116,82,107,102,109,59,218,77,137,222,124,202,163,136,61,106,91,151,252,158,250,253,52,79,156,203,184,23,235,245,134,45,136,60,80,92,232,93,24,224,172,198,106,172,152,137,49,141,72,30,43,235,146,93,6,17,254,159,74,138,126,10,26,157,53,107,240,110,246,134,221,194,108,57,116,60,91,53,235,90,109,208,153,219,104,184,177,11,26,175,245,41,152,211,132,148,100,221,9,75,73,204,254,46,16,48,80,62,111,217,211,232,5,247,98,102,48,119,72,2,41,50,123,214,148,60,23,200,194,112,106,34,5,235,19,143,246,124,193,105,207,216,217,7,162,186,16,183,47,111,27,248,26,3,204,112,38,91,118,174,3,105,30,199,246,211,1,252,63,135,104,205,108,200,2,117,195,63,210,59,150,134,205,225,152,153,202,142,78,128,226,32,204,44,72,19,60,64,173,69,249,6,88,40,183,27,197,103,212,180,65,215,28,94,155,81,81,25,157,189,151,99,174,3,75,183,79,47,114,22,118,64,127,14,161,188,183,142,165,183,218,67,170,233,1,101,183,219,88,249,238,176,242,21,145,80,49,182,162,106,83,175,90,156,48,251,236,210,110,117,190,156,104,117,229,198,149,61,70,77,201,228,10,251,45,13,183,4,222,52,68,103,88,196,168,208,81,225,136,2,98,64,169,43,39,222,44,96,25,20,130,133,212,128,6,239,205,34,56,27,174,84,98,179,195,95,139,130,98,66,93,22,0,254,206,103,186,170,124,164,36,152,175,173,26,236,88,181,202,238,142,90,92,1,103,87,37,158,196,100,6,15,115,22,204,1,121,99,1,54,10,233,122,184,67,137,201,34,50,223,72,152,105,230,48,117,83,174,106,128,251,170,27,173,118,187,232,224,205,167,95,38,231,147,195,254,241,79,7,253,201,184,127,240,243,209,97,255,224,168,223,127,119,112,116,116,248,254,221,248,237,241,241,100,212,127,110,154,166,235,67,253,142,243,120,5,98,120,130,25,85,39,32,245,199,142,8,65,39,230,60,220,51,60,144,150,80,154,3,194,152,40,2,247,36,206,53,10,28,178,2,202,253,163,228,158,235,40,201,178,120,225,13,126,214,246,90,250,73,191,8,99,80,152,47,159,22,58,139,186,27,22,56,45,147,15,13,249,192,20,114,228,38,187,163,92,232,252,50,71,21,103,166,17,160,157,45,199,131,129,213,90,207,66,103,242,130,170,15,136,185,125,183,123,43,58,135,210,191,220,32,180,93,123,176,46,122,222,35,103,151,140,236,138,201,47,130,233,40,76,16,13,8,151,132,236,219,8,30,244,114,81,109,4,106,78,203,205,64,131,252,197,170,245,134,160,116,191,223,80,109,171,148,26,125,207,80,107,105,1,236,251,42,108,86,117,157,130,133,202,14,172,134,197,186,158,178,206,10,157,29,136,72,44,105,123,247,89,4,169,209,16,18,72,233,3,38,182,3,194,228,53,211,211,65,204,211,2,152,192,6,83,161,183,13,104,65,85,46,82,57,28,105,3,225,210,180,51,85,211,136,16,93,191,112,19,190,252,238,79,76,34,48,54,139,131,154,93,96,54,80,215,246,244,73,228,37,192,224,217,226,223,96,241,223,59,38,84,41,226,25,123,113,138,16,170,214,62,167,9,248,142,131,196,119,241,189,245,160,177,119,44,200,140,6,120,30,8,192,93,129,39,49,127,240,135,166,239,165,62,151,84,96,227,78,237,165,191,246,0,122,91,85,219,116,238,244,4,212,88,88,247,213,90,217,198,219,134,253,89,12,214,5,173,170,135,80,221,151,167,233,158,8,188,222,211,32,87,165,59,45,118,17,203,155,185,246,215,92,134,125,159,90,107,64,43,69,206,106,173,56,115,182,226,142,109,59,182,164,78,83,166,152,185,172,121,59,27,54,183,230,179,171,199,46,236,214,196,59,67,233,163,69,29,87,234,11,190,124,169,251,235,244,60,205,19,42,180,39,167,27,111,167,67,71,160,27,22,23,119,89,84,78,22,65,107,194,99,108,234,211,16,15,215,87,92,157,39,25,158,195,218,240,237,27,252,70,228,132,197,165,134,213,88,48,26,135,80,74,191,242,197,255,134,235,141,172,48,216,184,157,134,200,136,78,251,238,21,125,208,223,173,182,227,173,97,203,148,213,192,207,234,180,203,255,51,40,15,189,138,251,17,67,103,121,215,60,255,184,235,103,10,191,114,191,144,106,120,80,80,193,63,122,81,1,11,202,138,231,98,157,151,216,7,59,251,188,243,232,99,103,171,147,102,14,255,254,1,49,58,39,21,106,20,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("65fb0cb4-92a4-4476-9879-fac50338a30b"));
		}

		#endregion

	}

	#endregion

}

