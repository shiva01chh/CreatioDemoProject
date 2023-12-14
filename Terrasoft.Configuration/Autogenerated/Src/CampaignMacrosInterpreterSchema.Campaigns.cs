﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignMacrosInterpreterSchema

	/// <exclude/>
	public class CampaignMacrosInterpreterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignMacrosInterpreterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignMacrosInterpreterSchema(CampaignMacrosInterpreterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cad16678-c498-4136-8792-f9a8e171d00c");
			Name = "CampaignMacrosInterpreter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,90,235,111,219,182,22,255,236,1,251,31,24,119,24,100,192,83,182,139,1,23,88,98,23,173,147,118,198,109,155,32,113,86,224,22,197,192,200,180,195,85,18,93,138,74,227,165,254,223,119,248,146,72,61,237,98,189,192,197,242,193,136,168,195,243,252,157,115,248,80,138,19,146,109,112,68,208,130,112,142,51,182,18,225,140,165,43,186,206,57,22,148,165,223,126,243,248,237,55,131,60,163,233,26,93,111,51,65,146,147,202,51,208,199,49,137,36,113,22,190,36,41,225,52,170,209,188,140,217,45,142,233,159,138,103,237,237,43,154,126,172,13,46,200,131,40,7,93,245,146,196,229,209,162,120,120,35,104,156,53,147,113,210,54,30,158,167,130,10,74,90,39,134,47,112,36,24,215,20,64,243,132,147,53,72,67,179,24,103,217,47,104,134,147,13,166,235,244,53,142,56,203,230,169,32,124,195,9,252,42,226,227,227,99,116,154,229,73,130,249,118,106,158,207,72,22,113,122,75,50,20,73,22,72,48,68,237,52,148,40,54,8,167,75,20,177,56,79,82,116,143,227,28,104,87,140,163,200,200,66,179,171,155,51,196,110,255,128,32,32,18,147,132,164,34,11,173,184,99,71,222,187,139,219,140,197,160,78,48,252,119,248,211,207,225,79,232,51,186,201,90,99,31,90,107,178,176,102,15,40,9,81,194,203,225,232,61,48,222,228,183,49,141,140,5,29,62,24,60,42,63,148,94,3,204,8,12,234,254,130,46,57,189,199,130,232,247,27,253,0,70,195,123,148,9,46,3,161,249,93,98,1,172,82,52,65,195,119,79,30,127,220,61,121,63,60,49,76,73,186,212,124,27,132,240,92,134,77,202,81,170,106,138,106,60,212,128,67,174,220,124,154,17,80,132,147,213,100,216,106,217,240,120,26,22,12,143,171,28,79,55,152,227,4,165,144,107,147,97,158,17,14,34,82,157,49,195,233,44,231,28,2,134,228,184,180,215,188,8,79,143,213,172,102,38,130,38,228,191,44,37,23,171,85,70,4,48,177,80,144,47,208,159,240,198,155,111,194,211,170,126,112,227,41,133,124,29,199,104,97,196,205,211,21,67,190,236,17,146,245,97,48,168,112,152,84,120,156,40,162,223,45,100,23,30,15,160,246,153,42,234,93,119,84,47,57,219,16,46,83,85,98,135,9,144,67,150,157,97,181,85,10,177,21,2,187,151,100,69,83,178,116,115,108,149,167,145,78,192,123,246,129,116,69,20,220,150,243,52,155,250,92,197,118,67,92,188,156,81,245,10,102,62,62,139,41,206,198,232,5,72,88,176,185,226,191,219,73,216,156,30,91,94,26,248,198,18,116,79,185,200,113,140,74,30,167,58,15,52,147,83,157,239,211,41,24,111,77,209,113,149,236,109,253,152,76,145,114,124,74,62,245,51,210,129,28,60,202,196,210,172,194,51,72,66,25,171,240,13,251,4,137,54,70,47,137,176,99,55,34,130,81,180,83,179,118,61,57,232,69,171,47,3,231,170,40,64,79,2,151,58,222,244,33,214,158,114,6,237,21,68,86,30,31,209,26,112,134,118,93,136,169,37,85,83,140,221,220,232,208,201,20,52,47,147,90,210,225,196,49,194,163,159,181,100,207,180,51,185,158,62,69,65,123,226,185,2,160,101,70,163,147,195,3,163,193,242,43,137,33,196,191,253,171,223,9,62,61,250,61,113,158,93,227,109,10,84,232,221,71,3,218,181,198,186,199,73,27,238,141,76,36,126,221,233,193,104,164,43,83,214,196,96,162,187,173,91,141,190,166,91,108,120,213,18,100,123,29,221,145,4,107,30,111,25,255,0,250,24,237,244,83,147,163,122,57,120,15,77,174,51,175,28,215,153,17,229,58,191,129,232,55,45,46,44,166,213,92,216,86,34,94,19,113,199,150,109,43,129,10,6,106,113,52,214,84,3,168,150,101,122,201,182,133,197,169,56,245,249,76,3,163,188,55,47,172,53,179,155,134,102,166,203,118,3,122,119,190,230,189,65,105,117,172,177,201,8,146,53,188,151,151,169,225,61,6,140,11,170,103,203,132,166,87,116,125,39,50,217,133,121,78,138,114,94,51,164,161,129,216,149,196,138,77,203,144,148,61,49,208,114,230,231,105,158,16,142,111,99,114,106,45,152,241,124,121,161,58,207,76,45,108,127,147,48,153,154,85,174,122,200,172,253,247,152,155,38,237,116,219,9,106,233,105,142,74,54,184,46,211,240,5,227,231,56,186,11,204,122,122,82,244,61,186,66,102,48,84,164,232,8,100,228,113,108,213,24,12,158,45,151,90,89,45,227,21,205,132,153,49,174,41,104,68,15,76,123,28,121,152,169,18,55,121,251,158,209,37,106,146,216,233,65,227,64,19,224,158,136,213,116,118,28,158,177,156,71,164,20,11,14,119,83,39,60,127,16,28,210,170,26,241,23,156,37,114,227,230,121,242,105,184,96,215,74,126,89,44,42,236,159,22,113,121,112,66,34,21,193,114,225,4,210,181,1,146,44,193,34,240,246,2,99,244,16,170,245,149,117,186,12,229,81,213,58,185,183,17,24,182,45,255,33,219,64,113,29,149,161,53,12,64,142,122,115,82,12,207,151,178,138,88,151,203,173,65,22,246,101,225,124,105,231,215,116,128,128,106,217,160,115,35,68,90,80,80,93,228,105,48,7,110,102,117,69,214,224,1,218,82,83,202,152,21,32,226,36,203,99,225,162,96,211,40,86,55,131,22,149,90,18,65,243,150,246,95,225,116,77,230,171,55,76,156,63,64,228,179,160,89,72,163,59,58,148,111,215,104,95,39,185,134,107,117,219,171,140,145,106,43,76,149,149,118,119,248,246,142,112,162,17,221,177,74,247,128,105,145,60,50,44,108,90,152,93,74,153,27,74,77,213,92,65,203,14,238,239,244,76,205,246,125,168,183,30,86,111,55,46,129,75,56,214,172,11,136,250,245,75,79,234,194,107,61,53,190,34,98,97,91,146,83,121,66,2,110,140,196,124,233,6,146,180,40,162,49,220,170,102,77,29,135,123,47,160,219,100,126,1,164,255,46,63,30,226,32,175,203,246,35,251,232,96,104,123,88,114,11,167,97,94,172,36,140,173,93,42,186,129,49,211,23,172,244,105,96,11,177,212,52,9,65,13,227,144,129,106,253,166,65,233,223,198,240,152,99,53,80,73,119,30,216,154,59,237,54,112,227,163,199,141,67,103,110,31,222,167,101,171,255,199,93,112,72,92,40,153,8,202,78,231,10,148,59,118,172,72,22,176,79,13,231,153,221,173,23,173,206,184,93,26,68,121,86,236,230,93,163,60,133,146,26,128,77,195,234,21,253,138,177,15,249,198,184,251,243,103,212,73,252,26,146,137,238,63,3,209,76,37,189,55,216,102,163,36,252,187,237,147,10,60,103,44,38,56,221,75,7,67,123,184,26,21,62,122,29,117,0,155,118,60,183,133,127,127,180,182,174,50,187,32,235,246,45,135,153,206,193,147,194,245,238,212,240,89,186,13,202,213,154,157,237,145,40,115,46,248,25,89,97,128,82,48,114,249,121,158,92,240,237,115,246,96,13,215,38,59,205,174,219,95,85,40,253,35,124,37,141,62,208,79,13,112,255,71,184,202,216,221,231,45,115,163,209,158,212,255,7,206,226,198,138,231,57,141,151,234,176,69,174,149,175,221,49,237,129,134,237,223,192,229,108,234,125,99,223,30,168,37,198,131,219,184,7,91,57,4,174,211,60,181,191,182,166,133,143,44,51,111,221,236,46,155,7,158,214,225,21,217,196,56,34,154,78,137,209,14,115,151,4,206,2,216,70,219,103,82,218,215,92,185,93,77,247,1,133,75,111,18,75,79,115,186,190,9,159,62,163,64,208,44,205,6,121,158,189,129,129,11,254,246,142,10,114,45,175,118,27,162,80,237,82,102,238,121,178,17,219,106,15,212,130,160,221,217,146,137,150,110,237,172,178,250,110,248,232,189,47,197,14,215,195,49,154,65,22,229,92,31,55,195,94,4,115,138,83,97,6,71,59,20,220,44,102,163,97,131,23,239,125,94,93,53,168,169,192,119,123,209,53,78,158,239,235,106,135,190,255,222,125,58,154,20,68,225,107,154,54,26,95,146,87,189,88,76,5,237,46,49,207,26,162,2,41,155,75,21,121,197,193,6,130,160,141,55,190,151,66,222,241,62,44,198,239,9,23,114,108,193,110,68,20,120,252,198,45,247,11,77,152,150,152,235,141,64,217,54,122,189,175,182,39,190,231,143,228,152,70,100,120,254,49,199,113,22,148,4,53,0,183,59,94,177,217,199,233,107,171,238,168,69,124,73,80,149,94,188,249,82,87,121,109,163,215,91,183,64,237,88,188,191,47,228,196,189,124,33,9,155,77,45,222,236,97,234,30,39,253,253,247,182,151,149,155,90,117,73,171,54,167,245,139,218,43,125,147,138,160,136,168,212,208,55,119,64,26,153,75,246,132,201,143,35,246,185,216,45,234,1,228,9,74,217,167,190,107,218,114,253,227,223,143,6,35,217,124,138,60,213,131,93,119,108,214,134,88,30,186,202,155,106,12,43,4,244,168,246,189,230,104,70,253,175,130,176,83,95,40,100,27,18,209,21,45,239,178,163,114,7,175,63,29,81,59,100,4,128,238,176,220,253,190,160,186,235,31,86,46,186,205,245,112,231,55,10,197,190,124,56,189,73,233,71,9,221,165,220,79,129,162,250,195,10,27,148,226,59,22,152,45,104,68,55,88,14,234,217,117,17,54,12,90,5,251,61,76,116,224,61,188,246,94,231,5,124,247,193,204,215,57,140,113,151,69,123,31,62,182,31,15,215,79,177,228,121,90,195,86,179,235,196,174,159,73,211,225,152,115,207,161,137,14,43,12,125,159,8,168,10,150,89,188,175,56,75,42,31,72,73,220,155,184,86,192,145,184,192,217,55,33,220,43,164,106,50,248,130,221,239,183,246,78,144,217,30,169,128,242,106,22,253,239,147,67,95,55,127,97,102,28,112,245,183,103,162,120,39,149,77,247,143,222,117,162,7,205,170,162,181,155,154,22,104,119,125,7,96,246,18,0,62,88,145,227,123,76,99,105,183,135,15,139,190,79,84,220,201,34,40,79,20,229,162,223,171,135,250,184,201,114,157,67,200,228,105,171,236,252,41,51,77,240,7,23,220,146,251,202,158,78,154,149,242,65,133,222,226,186,19,174,238,89,216,112,170,203,5,202,84,189,176,42,247,192,189,136,133,202,32,199,39,108,73,98,153,56,80,124,193,125,13,125,197,130,176,56,131,245,156,218,140,82,211,145,139,179,104,119,123,221,115,173,224,21,55,13,197,190,131,94,180,247,142,221,133,113,228,92,238,22,85,191,190,55,118,143,219,107,219,117,123,79,93,110,19,106,36,206,26,175,56,145,15,212,166,122,212,120,104,238,108,186,145,218,109,111,189,237,176,115,36,217,116,38,238,251,197,59,158,172,219,59,234,232,11,122,212,31,84,99,242,239,47,210,53,125,130,186,44,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cad16678-c498-4136-8792-f9a8e171d00c"));
		}

		#endregion

	}

	#endregion

}

