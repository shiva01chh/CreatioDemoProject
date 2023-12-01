﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignHelperLegacySchema

	/// <exclude/>
	public class CampaignHelperLegacySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignHelperLegacySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignHelperLegacySchema(CampaignHelperLegacySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd4bdd61-4fcd-4584-8c95-224cf60157df");
			Name = "CampaignHelperLegacy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,92,75,115,219,56,18,62,123,170,246,63,160,52,23,170,86,203,76,102,14,187,149,56,222,138,31,73,52,227,215,202,202,230,144,74,165,40,18,178,145,80,164,134,32,109,107,50,254,239,219,120,3,36,248,144,237,108,178,85,155,67,108,145,141,70,119,163,251,67,55,208,114,22,173,48,93,71,49,70,115,92,20,17,205,151,101,120,144,103,75,114,89,21,81,73,242,236,47,63,124,249,203,15,59,21,37,217,37,186,216,208,18,175,158,215,62,3,125,154,226,152,17,211,240,53,206,112,65,98,67,115,144,175,86,121,102,127,46,176,251,41,60,136,86,235,136,92,214,136,194,195,125,243,224,36,42,62,227,18,126,11,223,150,36,37,37,193,212,188,180,37,135,113,71,89,89,35,96,143,213,36,23,241,21,94,69,232,133,59,117,232,190,134,161,48,248,199,2,95,130,82,232,32,141,40,125,134,20,201,27,156,174,113,113,140,47,163,120,195,233,214,213,34,37,49,138,25,89,11,213,206,23,78,105,88,130,173,202,103,232,188,32,215,81,137,197,187,181,248,128,98,246,14,209,178,224,38,198,89,114,180,138,72,58,93,173,112,66,224,125,186,249,53,95,188,46,242,106,125,10,107,7,138,140,172,87,243,130,92,94,226,2,139,49,163,231,61,156,91,71,158,23,121,140,41,85,51,12,161,237,157,204,163,6,227,127,30,149,37,46,178,78,69,62,126,249,233,174,147,191,107,117,190,96,82,246,12,126,228,203,192,37,24,15,225,37,92,225,52,47,95,229,21,72,127,27,227,53,243,113,38,104,15,201,32,81,59,25,183,178,252,17,12,41,124,200,227,80,69,21,151,121,1,174,122,206,61,82,80,188,63,91,208,60,197,37,14,70,127,15,159,254,28,254,140,254,180,169,17,161,40,203,75,68,50,84,81,140,162,44,65,55,36,77,209,2,163,2,175,242,107,156,240,87,235,56,95,49,233,11,156,226,136,98,26,142,198,31,184,138,194,247,125,94,31,188,165,176,20,121,150,9,108,96,236,173,143,19,52,85,131,142,178,75,146,129,149,156,143,99,198,125,231,25,42,175,8,13,220,161,99,196,32,105,231,78,26,249,190,18,72,54,59,31,221,199,176,12,238,131,231,214,100,109,230,127,69,112,154,208,150,128,174,73,241,177,193,190,139,243,9,46,175,242,86,214,180,4,144,142,33,188,24,0,163,215,184,220,175,210,207,60,100,222,102,180,90,208,184,32,11,44,222,246,45,199,235,138,36,104,161,134,79,19,101,158,235,168,64,149,197,172,90,200,217,32,182,240,141,156,186,190,66,124,228,14,219,25,170,85,22,136,31,225,121,84,64,48,66,176,7,79,199,138,226,85,145,175,130,145,150,250,66,76,35,92,94,209,188,187,2,32,8,70,192,190,140,226,114,154,140,198,225,148,30,253,94,69,105,48,130,65,217,104,130,236,151,114,212,203,44,169,49,190,0,99,85,212,34,81,92,26,242,157,192,8,240,118,30,38,52,212,76,228,36,150,105,147,177,127,186,249,102,141,133,160,89,32,8,118,250,140,101,204,53,82,163,245,139,154,149,172,55,210,54,142,81,26,234,216,171,58,30,163,136,74,65,184,103,239,248,22,55,188,88,227,152,44,55,167,249,113,30,127,126,67,178,146,6,99,65,94,224,178,2,184,246,141,178,35,165,213,67,143,110,9,101,59,249,12,38,88,19,12,156,135,248,167,237,141,184,133,195,99,122,228,9,0,97,1,56,168,231,0,251,190,164,240,124,86,119,75,120,2,254,167,215,102,230,247,79,247,189,237,51,98,60,127,247,50,1,8,128,157,212,51,222,125,95,95,194,54,139,244,47,99,219,200,65,75,217,220,175,247,141,167,1,47,178,36,240,104,115,81,226,245,52,145,203,34,84,31,130,69,148,15,179,23,158,114,22,140,157,53,207,22,171,62,2,45,243,34,177,86,64,44,182,222,206,129,115,125,121,187,35,75,202,232,44,168,137,253,182,81,106,190,6,190,88,114,8,46,99,185,90,70,251,109,212,181,20,213,22,104,40,223,64,21,175,230,94,211,59,106,31,128,31,92,230,197,166,91,117,157,200,75,221,221,60,207,178,132,98,230,218,214,64,248,240,41,204,30,192,7,191,4,83,93,227,58,227,227,168,202,226,171,51,190,241,12,219,33,188,122,184,57,174,203,180,137,188,50,6,233,240,136,83,30,114,12,81,187,191,57,6,144,2,17,116,108,13,137,170,84,141,105,6,214,54,174,117,192,64,137,175,3,67,69,37,150,199,225,14,46,188,148,199,152,139,33,160,161,37,28,213,16,253,250,215,156,100,1,251,143,5,7,108,173,80,106,78,80,45,122,197,144,11,61,230,76,203,96,11,105,0,86,43,82,75,54,70,14,231,126,175,171,197,244,172,202,234,163,93,135,19,50,109,141,21,210,110,62,164,104,114,55,112,215,206,223,248,195,112,247,236,207,85,173,250,227,201,147,39,104,151,86,171,85,84,108,246,212,131,67,54,55,20,20,152,66,130,31,149,172,66,98,153,21,212,0,25,171,60,68,221,1,207,114,40,56,126,175,8,224,3,223,14,80,190,4,122,83,42,132,122,130,39,245,25,118,215,76,69,94,254,189,24,185,190,60,218,155,130,45,163,44,198,138,223,46,197,192,180,192,203,23,163,218,97,130,27,82,163,39,123,225,238,19,206,217,63,81,108,124,108,239,109,70,126,175,48,34,122,39,84,179,233,67,135,78,86,98,107,25,192,134,249,64,143,84,58,57,238,224,38,104,154,140,132,23,208,189,25,166,85,90,42,242,21,46,46,193,124,80,106,241,83,34,24,166,232,172,154,76,194,215,34,207,83,144,54,59,97,99,84,162,14,107,171,20,24,132,91,198,178,78,122,48,17,94,47,72,148,154,54,180,113,65,89,146,176,140,82,138,205,110,154,68,101,244,239,40,173,48,11,31,200,246,34,64,239,70,233,23,30,122,168,12,15,166,24,142,50,70,196,222,195,112,31,215,144,101,74,210,225,246,55,236,88,2,54,93,49,114,100,111,239,107,133,191,80,149,227,132,159,170,36,21,96,81,205,28,66,225,81,73,215,31,109,15,120,3,113,156,226,226,99,135,157,213,108,116,29,190,35,229,149,193,0,27,26,39,150,165,91,233,37,108,79,84,142,214,202,87,59,222,196,90,29,135,250,172,42,215,85,105,141,17,126,6,3,106,214,149,195,196,137,94,192,151,112,113,116,139,227,138,29,98,52,22,238,8,202,147,2,31,238,155,71,193,88,185,5,155,90,140,196,129,225,33,249,239,144,37,10,128,64,75,68,223,255,242,33,228,107,202,142,74,152,80,154,207,142,118,174,128,63,247,15,147,124,239,248,143,59,27,89,197,112,27,89,189,96,121,2,104,72,53,68,254,31,21,191,49,42,186,224,118,157,3,242,124,61,100,107,7,182,161,120,129,90,161,226,127,3,39,190,118,192,223,245,133,223,65,129,33,23,167,136,152,106,23,125,202,23,34,113,193,130,45,229,222,50,228,152,28,173,197,207,239,46,72,215,26,185,70,123,23,88,111,244,107,37,182,126,221,23,12,194,94,45,39,254,61,17,33,150,107,122,72,248,71,48,202,174,56,53,159,160,124,241,9,104,246,44,57,236,96,248,36,238,18,192,45,4,125,248,42,47,86,81,25,244,223,59,136,152,11,79,241,13,251,25,168,130,187,44,54,202,121,228,97,32,59,235,79,42,136,27,125,3,21,10,77,107,10,214,195,79,138,38,85,219,233,187,208,153,12,190,152,153,216,182,120,238,200,106,68,60,206,47,161,80,90,230,210,30,163,247,238,57,121,216,185,88,31,158,161,17,250,171,20,124,4,15,208,151,159,238,208,18,194,79,121,197,151,167,119,35,163,226,96,209,85,232,1,134,148,241,21,10,204,29,8,86,191,141,107,230,119,85,58,42,138,188,120,4,157,56,31,116,115,69,82,40,182,197,2,51,180,249,36,84,5,213,180,60,90,75,101,234,242,170,200,111,6,66,200,76,228,198,176,96,132,111,45,102,163,161,42,206,244,41,197,4,77,19,86,137,177,135,191,225,13,191,145,153,153,71,60,165,248,238,192,227,129,219,178,170,29,166,29,118,233,44,49,192,80,220,48,231,96,224,93,22,200,19,68,50,64,139,109,15,41,31,116,60,105,105,45,118,230,22,169,2,142,56,71,171,117,185,153,160,191,61,245,29,241,221,243,112,181,46,168,179,237,62,198,70,106,241,128,32,75,184,166,66,104,181,193,206,248,99,123,155,53,233,50,175,153,140,18,226,44,98,154,37,248,22,216,8,126,172,88,58,43,18,146,177,179,25,118,114,241,220,55,118,54,96,240,204,30,205,146,122,73,195,4,180,52,106,72,229,112,227,123,130,95,100,205,187,33,154,195,1,18,171,95,126,14,90,36,55,60,6,251,142,37,204,196,153,85,243,186,107,173,55,204,36,189,53,135,66,172,88,247,118,212,35,89,158,220,68,148,194,7,200,23,110,32,165,51,117,9,239,3,1,231,77,222,225,5,195,233,137,98,140,35,0,124,82,226,149,174,90,204,12,60,245,35,192,25,108,88,155,141,193,159,66,195,230,91,22,4,140,130,148,244,59,5,72,125,204,214,129,145,117,155,181,227,228,65,251,170,116,194,164,149,87,9,151,98,255,239,117,28,44,15,74,215,6,156,43,247,30,93,215,145,203,176,51,232,88,136,19,40,17,31,126,85,130,239,10,235,76,133,212,139,86,246,225,244,115,15,11,231,188,124,48,183,218,41,187,98,44,242,157,78,64,52,162,55,241,208,171,150,11,135,94,177,219,57,181,105,103,152,138,181,127,111,166,254,0,220,188,195,251,97,80,240,26,12,129,16,172,80,12,176,172,55,170,18,130,37,58,168,185,5,10,210,171,188,74,19,115,116,93,230,28,155,17,230,153,203,247,6,70,143,120,30,99,109,71,29,188,236,36,238,171,100,145,46,204,53,239,203,94,202,149,155,231,230,54,112,248,157,153,117,66,99,33,158,179,19,183,164,132,181,180,64,79,254,47,230,83,178,92,177,187,118,128,204,221,225,107,183,112,6,12,171,140,220,206,201,10,131,202,43,118,18,100,85,165,121,118,141,139,242,16,118,18,70,48,207,53,89,160,158,133,111,203,248,52,191,113,216,121,59,124,186,59,138,234,198,178,251,76,12,235,142,118,141,174,118,144,86,205,89,75,4,183,223,54,247,149,157,125,24,117,34,121,28,213,69,226,246,99,184,68,141,59,54,103,173,198,226,138,82,127,118,47,63,123,187,132,90,39,113,114,65,49,135,79,217,214,43,220,122,3,85,141,112,86,167,108,231,41,187,9,56,177,207,78,15,52,84,253,154,120,30,21,151,88,245,231,28,204,13,25,191,32,230,119,198,74,102,115,163,44,238,133,231,181,214,177,214,107,97,115,47,60,111,189,74,110,104,99,29,144,106,54,226,118,150,51,57,197,183,165,218,153,251,59,76,204,229,172,208,129,59,162,123,105,61,14,79,243,18,254,231,33,69,131,182,184,179,47,138,107,67,124,40,208,184,22,214,241,215,223,93,164,73,123,55,219,183,235,132,31,178,138,197,124,25,95,17,124,205,106,131,42,43,61,91,210,192,13,245,17,247,185,175,181,55,123,206,79,133,41,92,239,150,6,9,26,23,6,131,155,230,184,41,183,133,205,87,85,22,195,239,48,82,57,45,115,86,127,183,70,75,24,134,199,120,89,158,65,178,172,34,209,211,173,193,218,53,68,64,90,221,34,38,20,69,200,85,69,1,75,87,107,24,233,103,126,170,153,159,182,51,183,67,209,9,169,7,198,187,136,49,249,251,217,26,103,251,41,68,138,214,211,237,243,28,220,3,242,58,143,188,173,98,106,158,66,235,186,117,123,73,15,235,131,52,167,88,232,208,128,5,227,96,29,184,160,61,113,166,106,57,107,152,172,170,46,226,40,141,138,93,126,218,97,103,40,60,44,108,15,22,129,210,188,239,50,247,88,82,236,11,12,254,123,146,39,44,238,147,51,182,127,55,236,80,207,140,188,67,247,55,252,134,170,185,109,185,85,165,116,85,22,154,161,101,60,206,202,9,103,31,47,203,58,227,154,47,14,247,62,182,54,194,58,178,28,54,182,211,23,97,227,199,197,228,193,23,90,78,245,152,42,60,237,56,209,176,79,203,191,83,144,166,46,74,79,143,178,106,133,139,104,145,226,93,113,194,226,83,122,50,224,172,89,33,56,84,159,252,224,44,168,213,230,36,243,178,214,197,124,215,94,98,111,35,222,100,187,247,90,99,154,129,49,35,218,234,19,186,96,254,6,27,54,23,137,185,0,136,184,2,22,66,198,111,227,63,206,87,112,254,17,254,130,254,148,173,114,172,163,36,193,235,2,199,236,216,207,253,74,141,244,54,128,65,102,103,165,180,76,230,74,177,41,55,210,1,162,20,221,34,51,16,224,112,47,76,21,14,53,207,203,40,5,44,227,248,34,112,233,232,118,205,50,126,134,134,144,252,243,170,198,251,214,101,49,86,151,164,126,84,28,63,30,32,170,47,49,240,71,91,64,34,40,99,58,113,8,235,196,137,191,154,175,15,245,243,238,46,150,214,190,62,135,137,147,92,249,25,49,154,130,7,146,210,152,246,182,216,100,38,175,242,51,101,4,219,48,92,153,77,124,79,236,202,49,239,63,68,124,29,239,29,220,236,29,91,86,181,131,223,35,120,57,134,130,75,128,14,81,82,251,54,90,216,214,105,19,118,132,60,136,84,202,33,115,61,64,157,99,53,35,223,109,20,82,159,237,117,181,206,174,254,137,204,202,76,144,202,125,144,177,238,22,240,65,184,164,18,62,132,216,45,69,5,211,188,89,47,216,120,226,244,23,13,201,175,197,40,171,123,200,131,28,170,157,104,139,108,208,24,162,54,147,19,39,190,217,108,130,177,87,55,161,183,110,41,247,48,169,229,228,190,129,231,105,4,214,77,234,115,76,41,171,201,120,47,137,143,49,111,129,85,29,46,236,74,212,120,65,248,38,162,252,230,76,167,14,122,93,197,47,98,2,171,80,242,240,183,216,9,94,118,34,161,47,33,5,187,225,152,11,19,155,175,85,163,37,255,166,229,80,144,37,15,3,87,49,217,104,79,124,189,147,159,234,99,68,241,3,210,136,46,164,105,162,192,133,57,193,22,34,136,184,103,215,93,29,45,82,66,234,9,218,34,191,124,96,30,240,109,106,171,131,70,104,15,202,11,136,39,31,112,242,107,110,63,150,90,11,67,154,11,65,145,45,48,177,249,155,240,55,188,241,69,25,127,231,9,0,57,158,245,62,138,162,152,25,122,150,223,168,42,89,55,159,221,55,59,121,205,34,197,238,4,22,151,242,148,151,227,96,99,169,16,252,128,66,65,104,8,112,129,14,247,239,123,67,53,135,185,186,60,186,51,233,153,219,130,154,232,236,75,119,152,181,233,60,127,133,203,248,74,50,17,207,56,5,15,210,37,123,215,126,123,222,117,67,174,113,198,186,60,186,223,29,17,159,156,202,126,196,247,31,144,43,185,114,42,254,199,42,54,242,143,82,80,245,183,41,26,215,212,134,168,227,75,5,245,254,93,49,204,216,248,133,156,64,54,200,137,215,254,123,22,187,130,181,103,23,206,190,167,77,110,88,138,7,252,50,139,139,67,131,154,194,102,215,209,125,234,252,5,219,177,14,247,3,201,231,188,32,204,253,4,187,137,147,225,72,126,50,216,101,76,202,80,49,89,184,217,42,60,123,79,86,165,233,87,140,34,150,254,148,25,251,99,42,43,158,33,222,167,20,120,244,168,232,143,7,123,127,178,74,92,237,78,188,154,245,132,204,53,41,74,64,88,127,204,60,36,40,228,106,217,236,62,214,131,206,227,25,142,167,109,157,81,32,109,134,237,22,239,191,145,98,212,12,254,208,212,160,102,231,38,43,198,69,101,17,31,125,0,49,164,111,34,205,227,40,37,127,240,47,169,240,191,124,178,216,168,223,152,234,33,26,26,29,234,175,185,140,246,248,31,118,225,143,121,63,134,156,129,161,148,228,220,221,131,21,255,113,193,169,4,179,11,35,75,107,104,28,123,102,240,110,30,156,21,56,236,177,154,131,239,255,129,124,161,85,152,40,82,71,22,181,30,234,157,153,212,208,52,90,219,71,199,117,50,26,126,249,233,78,36,30,144,73,185,51,152,115,244,6,119,153,241,53,216,201,94,216,218,250,135,239,242,226,51,255,139,81,225,12,211,188,42,98,204,190,128,2,123,210,196,86,211,171,131,250,254,135,152,246,154,127,167,234,69,147,212,254,218,20,219,47,36,225,11,14,223,58,27,107,31,206,112,163,74,97,145,176,88,4,209,87,151,214,196,13,15,241,82,146,77,196,151,3,125,213,202,181,22,197,255,221,87,241,212,125,8,207,224,223,127,0,52,254,190,208,90,75,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd4bdd61-4fcd-4584-8c95-224cf60157df"));
		}

		#endregion

	}

	#endregion

}
