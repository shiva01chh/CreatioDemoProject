﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventAudienceRepositorySchema

	/// <exclude/>
	public class EventAudienceRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventAudienceRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventAudienceRepositorySchema(EventAudienceRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("37c91526-d31b-7c5b-4c0f-6b9ba4feb027");
			Name = "EventAudienceRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,91,109,111,227,54,18,254,236,2,253,15,172,239,208,147,177,129,146,237,225,128,67,18,167,200,38,78,155,195,38,109,215,73,251,161,40,14,138,68,39,194,202,146,87,47,121,185,52,255,253,134,28,82,28,82,148,237,108,146,237,182,251,33,107,147,156,225,112,56,47,15,135,116,30,205,121,181,136,98,206,206,120,89,70,85,49,171,195,131,34,159,165,151,77,25,213,105,145,127,249,197,253,151,95,12,154,42,205,47,217,101,86,92,68,217,246,246,65,49,159,23,121,248,182,184,188,132,230,157,182,127,122,87,213,124,238,126,7,126,89,198,99,193,172,10,191,227,57,47,211,184,51,230,109,154,127,232,52,158,241,219,186,219,120,85,242,40,177,230,165,162,11,201,250,123,194,255,84,125,221,37,239,107,15,15,223,244,118,77,242,58,173,83,94,249,6,156,54,105,56,229,229,117,26,243,147,34,225,89,120,24,213,17,40,183,46,163,184,94,139,96,114,91,243,188,18,138,51,195,229,140,119,211,248,138,207,35,54,102,150,20,33,237,4,18,32,250,91,201,47,129,1,59,200,162,170,218,102,147,107,158,215,251,77,146,242,60,230,239,248,162,168,210,186,40,239,228,208,205,205,77,182,91,53,243,121,84,222,237,169,239,199,243,69,198,231,64,83,177,131,119,231,135,172,88,112,180,139,138,205,138,146,213,87,156,113,193,146,69,138,103,168,25,109,18,78,139,230,34,75,99,22,11,25,250,69,24,220,75,49,140,200,48,75,93,54,49,244,130,228,63,74,30,56,194,149,20,69,205,65,7,81,150,254,143,87,44,98,57,191,97,41,208,71,48,9,43,102,82,210,221,138,115,22,151,124,54,30,246,8,49,220,220,67,41,195,118,154,77,119,158,221,69,84,70,115,150,131,231,140,135,77,197,75,144,51,71,251,30,238,29,52,101,41,212,33,218,89,220,118,132,187,155,146,74,50,81,218,232,17,33,56,183,88,50,123,134,17,19,238,56,24,56,131,198,206,48,97,46,131,135,79,165,44,118,147,214,87,236,34,170,227,43,86,1,75,86,241,186,89,188,164,10,59,76,62,52,188,188,123,35,36,152,130,0,195,189,67,62,75,115,88,155,20,7,86,20,41,241,132,209,242,8,62,72,130,103,219,150,13,80,95,205,108,33,70,108,27,20,153,86,129,127,7,127,178,6,195,14,218,212,116,7,255,198,243,4,125,194,118,144,31,75,225,142,194,241,193,61,202,244,58,170,57,14,88,224,23,41,148,51,207,61,187,228,245,14,123,128,9,255,181,181,181,243,136,9,86,249,223,126,190,204,134,108,245,173,242,51,181,23,142,206,157,175,106,41,149,92,207,82,91,55,82,201,221,21,137,139,151,33,91,58,247,49,140,98,56,146,141,247,196,167,147,40,143,4,221,119,92,113,8,134,132,221,112,180,179,68,134,243,60,133,253,101,105,2,227,211,89,10,60,149,138,100,244,236,211,130,218,198,239,154,52,97,255,149,35,143,147,29,34,163,236,152,96,187,50,43,80,137,16,215,26,61,0,21,169,238,65,58,99,129,238,100,95,141,217,117,148,53,92,219,228,96,208,118,169,30,164,23,134,168,255,174,176,201,19,94,95,21,73,159,65,30,242,140,139,5,241,26,63,189,227,113,186,72,69,122,145,102,26,104,65,74,8,32,101,46,227,18,14,116,220,111,132,98,133,71,101,49,87,187,112,22,149,176,246,161,238,249,229,138,151,92,117,29,39,195,81,120,92,77,62,52,81,22,0,26,105,230,121,248,163,240,123,96,92,6,106,200,104,196,162,74,205,70,157,79,139,126,93,128,174,167,209,140,43,129,166,92,128,26,86,53,23,248,105,131,129,157,75,143,43,121,213,100,181,94,74,59,32,60,43,22,129,237,141,35,84,239,117,84,178,4,53,51,94,162,27,28,44,54,208,240,156,22,77,25,243,201,237,2,38,21,64,33,196,220,127,10,107,99,227,49,179,85,163,119,25,231,10,247,243,36,24,162,110,114,195,82,77,243,192,120,86,113,31,133,64,48,0,96,122,9,81,74,29,14,223,73,101,96,87,82,104,126,164,11,150,172,184,79,110,121,220,128,102,21,163,1,234,145,189,26,119,57,13,16,5,134,211,140,243,69,240,122,171,21,250,230,42,205,56,11,40,255,61,166,186,157,13,165,88,73,106,88,168,94,45,110,50,253,41,232,246,87,168,236,234,3,200,156,55,89,166,21,42,246,143,203,86,51,226,219,111,165,245,118,152,56,134,108,33,54,21,96,54,152,214,241,80,173,11,152,135,104,183,85,120,144,241,168,12,72,199,126,146,96,31,110,230,14,117,32,232,247,45,93,217,46,172,119,114,155,86,53,192,74,112,135,58,5,123,139,136,43,142,101,16,26,136,101,32,65,143,19,170,217,59,142,245,122,244,56,55,85,93,102,249,150,223,182,58,129,126,209,161,24,72,147,116,200,31,235,244,184,186,29,175,142,64,187,68,55,71,105,6,212,149,118,254,24,69,82,246,79,173,65,169,181,245,97,52,160,241,10,149,155,112,128,182,175,166,25,51,178,7,246,156,68,11,163,240,180,168,225,175,228,95,5,126,17,236,245,182,78,166,163,201,2,6,207,238,78,139,183,69,252,254,123,240,225,42,176,237,137,142,94,110,88,168,41,158,168,93,83,43,60,158,228,205,28,78,16,23,25,223,21,201,107,79,171,240,45,8,219,117,39,219,33,137,122,42,173,24,225,0,48,10,231,245,57,24,141,154,184,200,239,163,10,186,147,148,130,177,129,234,179,66,162,107,52,85,64,133,245,198,73,197,70,89,245,227,24,81,61,251,173,174,34,113,118,165,226,143,138,44,225,37,170,68,245,206,100,151,199,90,255,56,101,183,230,106,201,182,82,181,75,201,158,164,72,140,199,82,145,82,129,248,61,144,72,107,38,91,32,106,116,116,247,244,80,143,179,209,128,15,0,74,32,65,201,74,89,208,113,181,159,221,68,119,85,27,23,224,120,204,189,153,0,217,157,221,45,248,208,159,42,166,144,69,226,43,81,145,232,166,12,177,201,106,221,231,206,49,167,85,193,114,35,156,214,17,232,28,133,80,113,75,41,22,25,80,13,106,150,176,28,252,40,166,23,146,43,89,127,22,56,20,163,5,205,112,134,212,23,37,159,150,169,116,254,201,245,174,216,217,234,72,73,188,44,193,180,138,178,18,149,147,195,58,201,173,157,209,78,130,221,160,45,183,170,199,219,169,86,188,251,164,220,0,192,46,104,9,171,0,218,51,46,238,106,254,235,111,42,82,8,235,104,97,108,93,138,234,83,75,144,104,38,99,48,252,184,16,5,185,240,252,236,232,223,50,64,200,177,129,97,178,193,182,54,8,207,240,45,207,47,235,43,219,238,68,101,46,36,18,237,170,9,246,130,206,156,107,194,185,55,77,154,41,197,0,34,11,72,216,82,33,77,101,68,215,20,17,224,145,33,161,228,36,120,120,195,157,161,68,249,28,98,37,116,203,4,191,7,237,92,27,172,159,171,28,106,234,167,125,145,230,200,25,103,152,43,102,46,35,17,9,2,42,179,30,167,233,90,169,45,184,217,237,134,179,111,26,71,217,15,186,44,8,18,186,77,194,26,48,218,247,49,145,194,56,18,218,198,209,210,44,15,59,135,119,121,52,95,55,238,84,109,4,180,34,207,27,240,128,74,198,28,95,144,196,212,166,91,191,21,14,60,95,212,2,45,195,89,122,22,65,190,106,179,156,62,195,194,65,129,38,38,147,81,53,38,52,97,11,91,20,253,187,162,168,233,105,206,156,10,54,112,128,241,64,143,35,27,33,49,0,61,184,182,138,86,238,248,8,245,11,55,212,152,243,40,10,43,66,165,160,113,108,173,119,115,218,60,44,80,169,13,11,95,18,140,188,48,28,167,80,66,90,135,5,168,189,240,199,26,97,129,160,30,204,238,131,67,22,19,7,20,45,103,243,2,176,95,214,70,142,243,24,206,228,149,169,91,28,20,77,94,7,162,18,16,37,137,200,230,240,149,238,116,179,72,34,89,242,16,234,60,151,95,58,120,3,207,114,109,2,158,242,58,24,158,64,182,153,165,60,249,33,135,52,217,73,188,96,242,252,44,157,243,240,188,142,79,139,155,145,151,244,205,29,164,85,15,177,131,216,84,41,90,180,134,109,58,182,57,218,171,213,174,57,32,168,141,20,103,68,160,19,139,245,246,118,120,141,52,179,65,71,78,162,208,145,3,78,30,113,238,69,157,227,78,227,102,132,191,164,245,21,90,128,144,243,93,113,163,77,34,208,231,20,53,208,46,214,248,236,225,144,247,218,67,252,151,49,5,87,141,34,2,200,213,137,234,27,44,53,60,137,110,127,182,74,172,74,127,94,227,233,74,177,165,213,110,209,193,57,64,93,80,136,123,28,238,149,31,147,145,55,118,44,19,65,155,156,223,128,167,205,133,188,189,252,40,43,238,154,113,172,44,152,70,38,109,136,143,178,230,23,176,97,154,145,73,126,149,89,18,177,48,100,160,105,11,77,109,100,65,211,123,7,216,18,206,123,129,205,68,151,235,13,122,60,184,226,241,251,253,242,178,17,151,176,167,128,37,130,191,15,239,197,157,87,49,11,122,174,170,70,15,161,45,48,21,104,232,155,3,75,139,128,102,106,62,135,255,44,204,167,82,0,25,239,211,214,69,81,100,12,246,73,195,91,5,139,86,34,85,5,113,43,173,190,89,81,202,235,185,192,192,95,112,35,119,148,116,179,175,176,81,88,71,46,10,74,137,185,197,16,229,149,52,119,110,47,36,145,194,153,250,136,41,170,156,112,138,134,79,66,157,171,132,29,105,75,254,250,107,246,85,119,177,107,48,192,217,71,45,163,223,127,103,143,23,104,100,22,170,225,177,240,245,238,85,141,238,110,171,4,189,216,172,15,219,45,169,129,107,33,240,97,197,121,157,102,248,4,225,48,173,196,110,72,149,244,44,0,208,169,230,18,90,71,58,185,69,93,197,118,71,175,3,178,245,139,132,137,7,80,154,85,24,140,103,21,86,129,130,208,175,5,52,151,86,156,236,170,237,58,151,187,228,34,173,168,129,136,39,122,243,212,87,38,170,135,42,152,236,145,245,97,139,232,92,191,220,138,222,93,169,4,76,25,83,20,92,23,117,148,29,96,118,163,156,66,204,236,150,46,113,208,22,54,169,91,25,108,221,37,124,218,125,20,68,120,67,111,115,158,190,79,23,42,77,132,103,209,123,238,191,64,51,228,237,238,245,150,160,229,48,77,167,214,45,129,25,161,215,221,40,240,171,177,115,137,238,169,51,42,70,182,151,233,141,34,197,217,71,84,196,68,56,88,171,38,102,106,125,166,58,38,28,137,178,25,179,147,168,124,207,213,209,11,14,9,161,161,82,167,102,83,215,36,135,62,223,137,90,9,108,93,247,61,98,58,172,13,122,103,243,148,13,61,147,185,62,239,75,69,7,144,70,106,78,238,133,176,130,27,183,200,141,158,56,205,168,246,89,213,234,210,173,216,17,253,178,224,205,157,56,162,7,52,45,35,191,17,61,132,154,102,113,124,117,39,13,149,200,190,186,171,46,225,26,26,1,222,14,249,140,88,67,123,102,115,70,145,33,230,58,124,67,191,26,88,131,198,212,33,55,136,254,236,154,49,37,143,174,59,136,74,59,130,192,254,160,51,94,182,168,69,36,26,181,211,214,37,5,79,244,173,122,209,212,146,174,27,52,72,208,62,78,68,236,178,73,53,188,51,49,48,144,47,57,228,206,245,148,150,33,200,20,50,114,170,245,249,34,30,204,213,13,120,169,92,213,129,29,246,44,48,211,82,11,60,99,88,89,17,48,173,112,251,209,20,68,69,188,107,199,238,22,72,223,115,8,13,64,32,114,189,122,101,195,161,158,43,116,186,175,132,250,241,27,90,89,233,71,231,41,21,40,87,237,107,169,223,6,108,121,54,194,167,94,85,23,74,219,80,108,97,69,93,53,178,239,237,251,128,162,39,131,145,199,8,189,6,92,17,139,197,148,165,104,137,240,175,198,216,229,81,118,105,222,55,172,13,13,86,190,201,74,192,49,50,48,104,241,220,72,89,78,5,42,247,60,218,92,231,169,158,49,219,225,222,91,151,171,121,219,36,103,136,146,100,249,147,61,245,210,104,184,183,226,109,84,135,9,234,171,218,59,109,230,23,56,184,149,65,214,69,128,66,15,145,214,138,111,165,174,211,178,134,67,36,154,236,124,81,148,181,56,249,247,67,36,88,228,6,62,176,82,130,106,171,169,77,137,118,210,62,150,178,158,91,57,144,202,11,205,72,4,32,68,173,217,247,59,213,50,7,82,156,212,251,182,67,126,209,92,30,21,229,60,18,37,131,118,201,172,106,226,24,14,235,161,82,3,79,182,217,253,214,131,208,227,253,235,135,54,51,108,223,127,3,95,72,217,99,251,254,159,15,109,125,0,5,221,32,147,183,132,238,125,70,79,233,164,245,43,215,248,7,15,44,150,72,48,152,220,198,124,33,79,137,252,182,245,89,181,184,73,89,22,101,0,237,218,199,174,202,226,134,120,213,178,7,129,210,43,108,15,96,51,80,177,222,122,141,185,214,244,10,125,213,183,196,146,29,198,159,187,95,32,2,179,47,189,159,228,12,200,68,193,114,122,175,110,223,39,83,32,217,13,214,116,231,181,89,31,68,249,63,192,13,164,220,108,65,74,248,236,226,142,229,69,141,165,127,174,151,17,50,125,119,43,109,222,24,187,48,125,83,252,50,107,230,22,76,162,9,194,185,123,118,193,189,133,91,215,243,109,235,226,118,153,127,11,37,145,156,34,30,184,185,74,242,250,254,145,210,193,19,252,254,249,28,223,46,73,174,33,55,227,98,227,245,14,2,86,98,92,84,7,182,205,150,202,29,181,36,247,111,234,163,196,124,134,48,229,53,86,140,63,174,201,90,175,65,86,88,43,76,167,23,215,107,176,79,13,139,32,146,42,80,173,25,12,173,122,230,112,207,124,102,147,233,79,140,94,194,143,62,89,24,76,149,189,195,246,197,69,9,240,221,14,132,146,138,183,155,136,239,213,105,201,245,135,18,171,89,122,200,112,115,101,0,197,59,126,95,161,248,25,64,133,174,44,59,101,105,95,41,25,169,200,187,213,245,159,53,12,76,217,237,89,138,208,32,222,144,74,165,109,140,134,208,190,58,164,91,175,91,23,44,229,252,230,215,223,216,189,59,215,195,139,68,87,244,147,63,95,116,197,42,187,142,174,248,77,233,150,4,89,217,190,34,196,58,134,254,25,199,89,21,212,244,178,86,132,87,103,93,79,136,177,248,180,223,156,201,60,210,73,36,186,236,103,33,254,80,137,229,1,114,48,235,176,118,79,104,234,217,253,167,138,194,101,235,219,106,230,53,0,41,170,171,231,160,70,151,253,164,168,234,22,27,186,197,110,58,149,93,252,33,63,222,112,202,19,186,234,77,59,189,181,111,171,248,109,205,36,171,223,132,126,105,13,124,221,159,145,104,103,93,245,216,25,11,229,45,119,83,0,233,249,185,198,128,46,180,167,102,78,175,226,74,243,243,140,165,113,202,216,64,168,236,225,143,13,173,131,158,135,13,234,103,63,207,24,207,62,242,120,171,99,12,113,56,19,83,94,20,209,253,25,66,201,75,65,51,111,16,249,72,188,246,164,91,8,138,240,236,55,132,218,245,195,131,172,200,197,85,115,84,89,111,73,31,3,25,81,70,215,115,16,87,97,253,84,196,19,49,235,73,180,248,4,136,242,89,175,161,31,127,15,173,29,125,203,118,127,235,197,162,33,95,231,58,121,64,126,107,168,43,203,226,23,134,118,152,249,152,64,170,129,42,13,166,36,138,190,118,163,232,55,158,40,250,153,71,78,27,9,170,164,248,121,34,193,40,203,252,145,250,81,232,239,143,142,171,251,224,193,207,29,60,23,190,7,195,244,180,184,236,69,113,215,137,150,176,123,30,207,2,29,252,165,157,106,53,28,161,23,86,170,205,190,195,146,109,244,223,255,1,117,204,221,33,128,70,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("37c91526-d31b-7c5b-4c0f-6b9ba4feb027"));
		}

		#endregion

	}

	#endregion

}

