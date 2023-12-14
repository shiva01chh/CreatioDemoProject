﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FirebasePushNotificationProviderSchema

	/// <exclude/>
	public class FirebasePushNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FirebasePushNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FirebasePushNotificationProviderSchema(FirebasePushNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b6e9b0f2-88c4-4b92-ae04-00d1a2d154c9");
			Name = "FirebasePushNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d653ba80-e9e2-4f78-8775-8ba14502d8a8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,89,109,115,219,184,17,254,172,155,185,255,128,50,31,74,77,100,198,151,115,218,196,182,220,177,101,251,78,215,56,113,45,185,249,224,201,100,32,18,146,113,161,72,5,0,237,168,57,255,247,238,226,133,2,223,108,231,154,212,31,76,17,88,236,62,88,60,88,236,130,25,93,50,185,162,49,35,83,38,4,149,249,92,69,163,60,155,243,69,33,168,226,121,246,227,15,95,126,252,161,87,72,158,45,200,100,45,21,91,238,213,222,163,55,76,53,218,46,138,76,241,37,139,38,76,112,154,242,255,104,93,13,169,41,251,220,28,58,202,211,148,197,40,47,163,95,88,6,10,226,141,204,34,205,103,52,221,221,29,229,203,101,158,69,175,243,197,2,154,55,253,111,216,173,130,129,56,141,223,164,111,177,214,17,189,230,217,167,77,175,63,121,84,220,222,35,88,87,123,116,124,212,217,117,2,158,80,156,201,78,129,83,26,171,92,24,9,144,121,34,216,2,38,79,70,41,149,114,151,156,114,193,102,84,178,243,66,94,191,201,21,159,243,88,59,243,92,228,55,60,97,66,143,121,246,236,25,217,151,197,114,73,197,250,192,190,187,129,100,5,35,73,230,13,37,43,59,54,114,67,159,121,99,87,197,44,229,49,137,209,252,131,214,201,46,25,119,35,235,33,119,122,43,193,111,168,98,36,6,255,43,34,149,64,31,156,142,206,62,192,160,11,152,43,172,186,96,9,25,146,160,210,16,236,221,59,120,156,221,0,177,18,35,111,184,138,42,90,154,3,227,215,134,99,71,103,23,192,125,208,203,76,255,85,73,214,89,202,222,87,140,27,95,108,6,192,179,72,21,138,232,25,246,174,144,83,48,239,21,19,106,29,6,176,167,36,93,176,15,60,9,250,90,145,115,170,197,127,102,250,199,9,249,66,22,176,123,136,196,127,119,6,70,93,25,144,37,23,237,122,78,176,171,174,163,215,187,251,234,249,116,207,4,166,9,203,42,85,115,46,105,142,51,113,253,143,155,75,76,179,60,3,249,20,212,201,54,125,35,39,48,78,228,99,20,202,34,142,193,153,109,170,38,166,235,49,90,230,148,167,133,96,109,90,78,77,215,99,180,8,77,138,58,150,215,192,195,253,6,117,14,136,121,54,224,149,171,247,132,101,137,33,108,55,123,63,21,76,42,211,93,143,0,186,225,130,173,0,20,203,192,76,51,8,8,51,60,42,71,251,65,160,119,117,76,21,133,147,0,246,80,172,186,200,99,237,107,238,232,57,59,144,214,41,16,211,118,201,185,246,131,21,104,192,212,45,199,236,134,195,17,164,242,143,44,139,54,114,21,64,117,111,171,188,125,79,76,81,73,235,114,221,103,91,26,227,242,177,214,133,23,95,90,184,108,176,92,189,55,104,218,57,216,14,199,134,134,199,226,240,87,180,134,193,15,201,184,152,149,134,239,135,40,1,83,53,36,199,92,31,231,48,98,223,56,102,96,29,116,64,52,176,54,44,117,250,223,253,143,52,39,136,235,79,114,189,238,201,111,192,248,175,116,234,44,79,214,247,30,37,95,177,158,83,174,210,71,27,86,40,220,177,209,176,235,123,217,149,121,145,117,28,158,19,236,250,94,118,121,220,216,71,214,236,56,238,216,53,29,76,237,140,223,152,200,136,2,83,190,26,85,172,189,135,82,174,208,2,2,16,10,158,178,79,204,201,253,193,53,64,26,244,219,219,217,239,144,67,71,231,84,72,22,150,146,123,70,176,144,76,0,140,204,100,217,32,174,207,20,147,134,174,33,231,86,251,151,21,137,131,208,140,124,96,102,149,45,96,54,144,157,152,221,77,130,209,36,207,210,181,131,71,74,200,123,173,98,85,20,164,134,123,175,170,92,42,240,82,188,25,60,134,218,128,124,72,225,223,144,192,207,51,154,193,54,17,56,59,44,26,192,141,65,221,193,145,243,124,208,223,187,79,51,207,0,249,146,126,214,177,125,4,108,84,96,226,213,171,87,247,14,250,165,224,9,249,48,183,22,32,51,195,83,103,140,89,111,198,110,117,111,24,60,223,57,122,241,243,139,227,147,173,159,119,158,239,108,237,60,127,181,179,117,116,114,116,180,53,122,113,178,115,250,242,100,231,229,241,223,95,104,108,85,67,154,13,151,34,181,60,0,134,2,79,5,83,133,200,136,37,75,191,244,244,85,80,136,52,120,95,205,53,106,186,14,87,252,159,108,253,72,117,84,11,215,53,118,113,228,140,169,235,60,233,34,72,121,108,194,42,153,147,51,212,126,147,107,121,152,44,121,118,153,113,72,52,29,225,117,97,181,158,196,215,108,73,137,52,143,97,157,37,145,47,229,145,96,12,187,144,102,49,59,90,191,129,18,184,73,6,109,222,18,161,119,67,5,97,242,147,93,44,95,227,191,10,38,214,161,49,110,133,27,221,80,208,22,203,204,36,24,246,247,16,213,69,135,73,98,222,195,160,98,14,251,78,121,10,85,144,68,153,16,223,71,192,36,197,76,235,59,174,174,97,103,3,110,20,9,77,35,20,174,43,42,56,68,179,233,122,5,85,231,167,130,166,3,18,88,166,5,131,22,242,245,173,61,62,39,225,88,226,110,11,107,158,118,174,254,182,144,60,27,209,56,1,104,117,171,6,214,29,97,41,148,175,223,28,129,209,215,11,174,124,32,227,236,34,79,217,174,223,84,121,121,31,249,111,40,123,31,242,114,25,199,242,24,242,68,158,197,24,35,32,236,51,159,35,155,155,14,194,234,13,134,33,64,212,186,104,88,35,184,53,89,110,29,147,199,90,170,218,214,186,246,72,71,173,247,102,228,28,74,200,16,99,26,135,65,219,123,240,216,111,192,49,3,160,239,233,211,146,18,6,24,225,138,45,17,109,109,196,21,183,234,245,230,209,160,64,10,133,113,82,184,26,150,251,255,166,105,193,108,94,120,16,122,155,36,194,141,105,103,215,51,179,2,165,232,70,252,237,59,26,163,124,116,204,102,197,226,52,23,75,170,194,224,130,197,140,223,48,72,19,182,239,156,71,112,158,149,21,199,245,179,89,255,107,150,45,212,117,52,205,39,26,71,216,111,172,172,177,103,195,160,25,229,206,196,94,207,143,97,179,60,79,137,221,77,247,4,47,244,138,223,51,97,232,56,187,108,230,165,177,210,145,139,22,147,195,75,192,30,192,12,250,198,61,209,169,200,151,97,101,103,5,253,232,80,26,81,39,244,238,154,9,8,117,56,12,136,169,55,67,104,125,173,179,146,198,238,183,227,14,179,36,116,191,223,174,88,118,148,230,241,199,18,133,111,20,215,85,47,104,105,179,213,14,210,173,223,184,65,139,234,154,34,116,98,137,226,173,248,127,152,4,215,207,109,128,60,207,133,162,105,5,195,40,205,37,51,211,239,19,42,237,66,85,184,209,92,212,232,228,51,139,11,197,38,49,77,169,216,71,82,64,70,5,48,225,188,57,89,174,32,237,172,164,87,142,72,55,57,144,231,60,151,10,75,142,176,182,191,93,5,69,116,130,94,190,217,139,39,19,226,238,41,187,104,146,112,221,151,162,114,199,201,70,197,152,213,27,12,61,27,114,54,34,184,90,100,88,197,209,51,149,194,208,98,53,109,38,139,31,146,32,97,115,90,164,42,48,251,185,59,36,85,118,42,54,61,29,214,178,176,50,50,225,200,84,203,193,240,51,10,27,251,140,67,220,172,8,215,182,62,217,34,188,239,5,172,89,49,159,51,81,141,162,70,165,11,107,135,64,165,53,240,104,181,14,221,146,240,129,29,55,32,219,3,139,192,87,234,74,81,163,117,115,131,226,112,247,166,46,118,91,53,182,185,82,184,15,27,171,226,196,236,10,85,215,214,244,89,191,246,38,144,150,105,58,89,40,254,121,213,70,191,82,222,3,235,134,122,129,172,16,28,142,100,129,183,109,102,110,151,130,135,238,9,153,41,132,211,0,234,243,36,168,28,86,100,101,201,141,5,11,28,209,176,81,111,160,126,40,191,25,48,83,37,212,176,218,177,194,94,167,29,65,101,12,227,113,159,88,128,225,6,205,192,166,178,131,210,148,85,226,221,199,149,154,106,40,142,153,172,226,240,47,241,14,66,223,126,223,99,45,186,195,99,173,19,139,236,117,95,219,65,218,184,28,116,103,106,125,240,230,76,197,140,77,159,165,230,6,248,47,224,245,34,77,75,141,206,73,51,154,76,237,201,235,110,251,166,238,32,181,154,234,170,134,195,206,219,245,63,254,32,77,193,202,149,253,6,128,166,69,2,225,79,49,157,3,91,94,28,235,150,230,193,102,142,175,142,28,220,157,91,246,213,89,104,4,250,50,251,11,221,188,93,62,6,127,30,22,23,143,195,77,175,206,32,198,217,60,119,9,132,6,138,46,164,38,78,132,144,72,244,73,82,224,37,37,120,65,66,17,8,229,50,191,129,156,39,252,242,211,93,63,24,148,176,240,6,123,189,4,218,104,8,27,44,3,207,123,165,229,106,142,107,129,104,17,135,100,68,179,191,42,116,37,228,51,162,229,126,203,134,90,196,101,178,44,13,53,10,200,83,18,152,15,4,187,4,16,254,105,128,54,128,116,198,9,75,181,154,82,119,58,105,197,118,122,126,242,20,77,138,153,145,9,183,109,40,118,145,248,128,60,223,38,255,192,127,187,149,142,71,221,65,120,245,101,174,128,93,44,113,104,237,43,185,225,66,1,105,28,110,63,112,64,180,34,126,240,112,83,179,49,164,22,181,220,180,204,55,61,189,241,111,217,108,148,114,150,185,16,255,206,189,135,155,74,170,148,129,202,52,206,19,28,59,36,238,103,116,57,61,125,185,87,23,252,149,209,196,149,61,193,97,1,51,20,246,139,42,38,67,31,217,122,136,171,109,96,246,239,29,253,171,82,43,59,91,211,140,217,145,2,41,204,125,64,23,93,173,82,75,172,103,191,203,188,172,72,123,74,172,75,146,218,117,220,88,184,92,165,57,77,108,234,236,59,48,56,127,59,153,6,141,232,11,172,7,27,241,53,9,79,62,199,108,101,10,160,77,236,216,164,243,142,253,120,118,52,169,191,139,179,102,145,205,58,6,164,44,22,122,234,90,228,183,123,93,204,125,152,59,205,75,185,242,52,12,235,65,74,31,96,137,199,7,12,168,141,43,182,90,128,238,218,230,229,68,205,38,174,223,128,113,169,213,128,71,245,109,182,206,171,220,164,205,170,248,101,81,45,101,220,212,250,122,112,181,20,106,71,248,142,10,172,54,0,148,151,92,74,146,112,1,128,210,53,65,63,23,139,107,120,178,135,191,20,35,248,92,17,154,166,249,45,75,48,64,185,66,156,156,167,12,63,84,131,211,180,42,84,81,73,50,35,132,0,246,113,125,32,242,194,97,67,65,129,155,249,147,149,160,139,37,37,183,128,22,113,38,92,226,23,79,50,154,108,255,237,167,151,222,116,42,37,162,155,85,233,109,93,32,234,232,181,171,227,165,231,227,65,61,188,153,174,202,17,227,215,221,224,243,47,100,35,67,238,58,144,194,46,81,80,136,248,72,171,7,194,99,97,87,23,179,137,223,122,186,101,225,189,154,183,49,147,205,45,156,174,100,251,45,195,43,23,30,101,177,226,18,98,223,131,250,119,185,87,245,219,97,181,10,185,39,190,155,214,106,163,110,195,191,255,2,130,117,117,138,196,34,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b6e9b0f2-88c4-4b92-ae04-00d1a2d154c9"));
		}

		#endregion

	}

	#endregion

}

