﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignSignalFragmentSyncManagerSchema

	/// <exclude/>
	public class CampaignSignalFragmentSyncManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignSignalFragmentSyncManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignSignalFragmentSyncManagerSchema(CampaignSignalFragmentSyncManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f640b49a-c5da-4d1a-b93b-a51f180dd679");
			Name = "CampaignSignalFragmentSyncManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,90,91,111,227,184,21,126,246,2,251,31,8,23,88,200,64,160,180,221,183,205,36,64,46,206,212,197,204,100,26,103,58,15,69,81,208,18,237,168,35,147,26,146,154,36,29,228,191,247,240,34,137,164,40,217,185,76,209,135,13,16,39,230,229,240,227,185,31,146,20,111,137,168,112,70,208,13,225,28,11,182,150,233,57,163,235,98,83,115,44,11,70,127,254,233,251,207,63,77,106,81,208,13,90,62,8,73,182,71,193,119,24,95,150,36,83,131,69,250,150,80,194,139,172,55,230,93,65,191,118,141,238,90,219,45,163,241,30,78,134,218,211,139,179,174,75,53,156,227,109,133,139,13,5,232,66,10,116,172,27,211,166,53,245,186,49,149,2,102,195,252,63,112,178,1,212,232,188,196,66,252,134,154,81,75,248,197,229,37,199,155,45,161,114,249,64,179,247,152,226,13,225,122,210,225,225,33,122,35,234,237,22,243,135,19,251,253,130,136,140,23,43,34,144,128,209,183,156,209,226,63,132,35,121,139,37,42,4,186,99,252,11,201,209,93,33,111,81,102,23,65,21,230,178,200,138,74,193,177,100,214,140,163,187,219,34,187,69,11,90,200,2,151,13,162,5,176,112,145,43,82,237,116,161,65,34,82,18,5,18,45,242,180,193,118,232,128,171,234,85,89,100,72,16,92,2,128,76,237,115,247,54,81,199,138,51,44,72,148,17,147,239,154,25,29,11,21,103,121,157,73,198,129,147,31,245,178,102,132,133,176,115,213,228,109,93,228,237,254,22,249,1,242,27,52,11,102,138,226,228,55,180,2,92,137,59,54,24,134,148,210,78,30,45,70,66,115,3,211,199,252,145,179,138,128,16,72,128,56,148,176,110,184,44,241,6,73,134,10,154,23,25,150,4,129,34,193,39,91,35,78,178,154,115,165,137,173,72,149,45,32,94,151,4,173,30,172,164,210,150,178,43,159,134,59,43,198,74,180,16,215,45,169,239,104,67,228,17,8,14,62,118,108,227,61,145,183,44,87,123,224,197,55,192,100,217,110,190,0,94,137,222,179,111,228,163,163,110,201,39,65,56,72,140,26,171,69,181,247,213,50,111,242,13,115,244,181,38,252,1,204,233,45,145,33,145,191,169,174,36,152,122,164,103,114,34,107,78,205,228,116,126,15,155,146,36,49,125,143,62,186,111,12,68,124,1,74,44,201,178,179,156,28,40,74,156,61,5,104,174,105,24,164,125,122,35,88,205,196,103,161,188,38,165,150,244,171,193,108,9,190,16,239,146,40,127,172,214,248,64,238,28,153,221,48,80,176,162,42,192,240,218,165,110,152,18,172,153,145,184,80,133,33,114,140,40,185,179,20,19,87,254,55,76,65,55,29,22,155,153,162,226,65,189,133,88,112,94,18,204,19,175,79,255,59,177,35,146,105,86,17,201,170,233,1,154,130,19,200,121,81,150,45,192,79,139,124,58,235,13,87,67,85,71,122,42,146,105,227,82,28,84,209,73,205,26,103,117,249,101,190,197,69,233,140,58,165,121,18,161,115,85,221,224,85,73,62,64,116,132,137,75,73,42,8,84,149,226,188,90,124,33,230,95,107,92,38,102,137,84,251,190,4,188,31,153,53,100,23,32,53,254,87,86,208,24,113,141,225,6,115,176,112,103,29,179,39,139,214,210,153,164,87,81,10,62,188,133,139,201,217,239,56,127,70,33,246,80,121,136,172,32,172,149,122,203,239,4,235,76,106,40,42,25,88,146,75,112,170,181,112,58,39,33,179,129,48,16,146,16,47,250,113,63,141,172,254,177,243,201,116,211,144,159,197,214,110,131,109,68,196,206,170,78,208,153,170,8,53,141,8,189,167,205,1,63,87,68,250,12,85,13,142,21,12,73,116,212,74,186,229,91,69,239,45,27,174,58,237,169,143,69,18,179,149,190,198,168,104,27,170,74,17,168,74,209,95,35,224,183,14,217,161,58,232,105,176,79,198,243,16,96,67,208,115,58,203,10,120,178,126,248,192,222,177,236,203,95,10,21,229,252,104,100,198,141,187,75,240,227,249,239,46,115,15,151,57,75,63,48,216,59,132,161,2,236,46,217,99,191,169,31,35,91,105,219,53,61,87,250,167,206,62,47,57,219,238,240,161,174,119,81,200,59,77,250,124,75,56,49,219,25,102,216,254,118,246,187,115,127,178,115,31,245,237,128,178,231,95,181,46,253,227,159,214,168,224,231,5,94,254,224,105,52,22,20,10,130,13,39,66,52,4,236,252,199,89,100,55,207,143,22,175,229,182,22,20,44,74,187,45,111,19,107,102,58,198,147,82,203,155,197,156,214,91,194,149,8,223,232,2,204,84,93,230,115,118,2,213,195,154,189,3,19,143,213,4,202,232,237,82,65,166,10,130,149,44,166,45,10,93,167,125,102,159,80,244,18,12,37,111,162,104,171,245,224,163,183,238,196,212,18,127,199,101,77,128,67,141,2,45,137,76,166,239,10,10,213,245,156,202,66,62,128,52,14,80,79,10,138,90,170,194,140,227,88,244,212,184,17,141,81,248,115,64,193,44,123,181,250,55,201,118,77,253,181,17,253,99,175,72,26,44,58,148,255,12,248,231,69,28,159,241,32,148,61,221,239,81,75,1,151,37,187,35,185,81,121,34,140,92,59,3,124,185,249,237,71,97,206,57,227,158,221,61,118,24,21,11,151,145,216,90,199,66,74,16,81,58,65,180,194,31,12,42,190,122,90,231,216,230,51,93,56,41,70,28,112,152,229,68,18,93,61,61,80,28,111,30,139,142,232,248,225,28,29,197,216,50,152,114,4,97,190,239,173,219,158,104,106,214,117,131,197,66,37,116,69,93,80,177,228,103,84,64,237,70,3,3,126,165,20,38,206,68,87,3,122,108,108,68,206,246,139,163,87,85,84,97,88,152,1,3,189,72,32,103,99,90,244,67,195,120,131,168,95,138,249,17,174,147,114,127,106,215,23,155,218,133,250,120,140,15,156,206,44,190,126,160,132,125,16,241,2,226,117,139,58,99,244,65,190,219,57,164,25,194,194,106,251,158,113,189,113,104,167,156,99,21,70,237,4,123,160,211,197,227,228,30,29,159,52,110,88,77,42,61,51,129,153,247,41,196,126,179,23,29,24,223,40,228,39,189,128,104,215,13,61,199,40,137,1,181,116,40,17,207,176,70,72,197,221,88,19,254,18,127,87,7,62,194,131,96,153,38,128,206,210,27,195,191,134,169,197,26,37,45,83,65,206,32,173,249,182,146,208,223,102,16,131,121,82,144,24,117,194,153,5,167,108,38,112,239,119,54,24,6,237,29,39,132,199,250,48,120,162,92,167,161,53,224,58,135,34,87,232,138,252,136,53,24,170,232,206,88,225,114,32,94,51,7,20,106,81,17,154,91,255,63,158,130,154,3,126,209,156,201,184,133,180,109,179,233,8,82,169,160,213,39,24,214,118,35,155,35,180,195,211,211,60,95,172,149,240,141,157,190,228,136,200,137,108,140,131,175,59,5,208,254,9,248,147,83,18,240,73,255,18,172,230,25,241,51,131,166,95,209,249,92,208,156,221,233,3,224,203,154,106,42,137,117,108,170,251,154,221,125,168,183,43,194,253,17,179,3,103,140,238,50,36,231,247,149,42,104,212,16,127,113,199,247,63,121,106,231,251,219,10,235,138,231,132,95,20,220,108,59,85,247,97,160,5,192,206,153,9,78,6,246,116,151,26,251,165,124,179,102,47,255,114,193,60,209,191,247,78,254,28,90,187,162,86,171,102,51,191,68,219,91,252,203,122,21,8,94,51,98,92,191,12,3,213,212,128,15,150,90,195,90,216,253,91,45,25,30,77,125,131,56,21,45,54,140,237,238,127,83,20,88,112,243,213,186,128,136,93,227,222,30,3,143,97,110,70,198,92,74,136,64,248,246,250,108,15,250,76,255,185,115,71,49,71,106,113,126,170,114,220,195,121,128,70,83,61,75,77,215,158,173,190,70,170,206,80,8,193,142,94,8,127,63,237,185,168,171,82,223,149,138,179,7,235,111,246,187,41,139,41,98,143,75,255,163,194,212,98,33,121,16,24,94,15,99,255,220,233,57,0,123,161,107,240,144,251,180,44,125,129,59,167,217,123,95,100,10,199,92,213,35,129,65,138,209,75,204,246,212,27,112,235,128,225,157,123,7,137,42,228,54,58,17,24,60,218,24,79,157,173,147,30,74,79,187,148,244,49,118,240,214,5,29,167,136,139,5,135,16,240,144,199,221,227,22,159,73,152,67,242,145,199,8,215,26,162,104,164,192,214,72,189,100,208,183,19,184,68,188,185,168,48,15,80,110,241,55,162,94,46,172,8,218,130,92,114,245,36,128,65,23,233,200,19,130,50,78,214,199,211,243,109,5,202,197,101,86,121,39,217,211,195,19,36,21,103,7,94,49,232,22,195,55,113,98,53,205,156,216,189,57,108,154,141,50,218,189,33,0,194,121,145,187,122,121,213,109,97,231,157,139,205,151,159,113,195,125,244,255,200,86,243,52,232,51,22,234,2,10,173,75,188,249,145,140,86,139,60,143,217,207,185,31,27,99,56,164,235,66,167,79,209,87,81,138,187,177,14,203,51,76,115,149,80,64,194,7,5,151,232,196,211,178,238,230,150,80,104,86,210,17,157,36,7,214,42,40,146,28,83,129,77,6,59,194,254,74,25,61,162,96,248,199,83,223,187,77,79,22,250,125,89,166,223,5,57,242,247,221,42,136,29,196,165,201,244,133,122,206,106,170,85,207,121,73,150,123,80,119,139,90,189,249,89,80,112,75,32,93,167,40,221,223,187,227,60,247,74,88,97,80,29,163,63,26,23,105,30,222,233,19,251,124,101,220,47,227,208,237,83,76,231,84,212,156,92,156,117,77,78,61,222,77,76,33,112,113,121,211,113,191,9,4,19,201,31,218,155,160,65,76,189,215,77,209,144,99,206,8,2,128,160,210,11,113,9,73,51,192,156,83,165,85,121,151,237,153,151,106,237,147,172,57,85,250,161,202,17,244,203,47,238,91,173,89,119,89,181,95,14,52,128,239,209,254,141,158,249,55,131,118,159,52,12,80,15,168,118,111,151,6,198,143,61,119,218,123,74,251,142,107,96,134,163,3,234,33,104,17,85,130,71,176,88,169,46,136,230,247,25,169,92,85,245,8,92,179,178,92,225,236,75,140,196,68,2,162,187,134,94,119,150,211,196,250,184,110,185,97,91,219,104,65,33,25,40,100,206,178,195,221,94,246,101,57,214,15,87,86,187,243,29,249,96,84,110,30,235,212,75,204,116,108,187,49,18,241,92,200,180,250,141,186,13,126,254,11,55,209,228,14,168,44,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f640b49a-c5da-4d1a-b93b-a51f180dd679"));
		}

		#endregion

	}

	#endregion

}

