﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookEntityProviderSchema

	/// <exclude/>
	public class WebhookEntityProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookEntityProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookEntityProviderSchema(WebhookEntityProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3336cfe7-b740-410f-a18b-6aa5422388d5");
			Name = "WebhookEntityProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e50fad81-60b2-4030-89a7-8b387fd6a892");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,25,219,114,219,54,246,89,153,233,63,96,181,153,14,53,213,194,157,62,117,108,75,25,71,137,83,181,118,146,169,221,245,67,38,211,129,73,72,98,66,145,10,0,218,86,93,255,251,30,224,0,36,192,139,100,119,219,238,195,250,193,18,129,115,191,31,42,103,107,46,55,44,230,228,146,11,193,100,177,80,116,86,228,139,116,89,10,166,210,34,255,234,217,253,87,207,6,165,76,243,37,185,216,74,197,215,71,141,103,128,207,50,30,107,96,73,223,240,156,139,52,110,193,156,165,249,151,250,112,38,184,38,78,79,225,163,20,252,178,88,46,51,56,175,1,222,242,91,5,228,180,52,63,202,34,111,160,251,162,10,222,119,78,95,231,42,85,41,151,189,0,167,44,86,133,64,8,128,249,167,224,75,80,130,204,50,38,229,33,185,226,215,171,162,248,108,168,108,223,139,226,38,77,184,48,128,7,7,7,228,56,205,87,160,169,74,138,152,196,130,47,38,195,121,39,194,240,96,10,24,31,94,241,5,43,51,245,50,205,19,16,36,82,219,13,47,22,81,55,202,104,244,17,80,54,229,117,150,2,109,45,76,183,44,228,144,116,19,0,236,123,35,104,165,210,105,202,179,4,116,122,47,210,27,166,56,94,110,240,129,204,205,237,57,219,108,184,152,173,88,154,147,95,23,141,147,35,75,142,231,9,82,236,35,95,40,136,4,158,224,181,177,147,44,215,107,38,182,83,119,112,185,226,164,148,32,125,92,228,57,134,13,173,128,15,124,232,141,163,70,32,92,146,34,207,182,228,23,64,156,85,120,141,199,163,29,92,173,157,72,86,44,201,45,184,205,24,233,113,60,45,234,89,177,188,50,136,173,131,30,227,56,243,74,5,177,30,215,244,206,216,111,219,227,249,235,188,92,115,193,174,51,126,60,159,149,82,21,235,75,136,9,75,250,7,150,39,25,23,211,41,249,53,174,238,236,33,153,104,226,131,156,223,62,137,82,20,141,200,100,138,177,141,113,191,133,100,85,39,89,182,3,43,26,141,142,66,79,131,181,165,18,165,198,215,254,54,49,186,195,236,243,28,50,144,101,233,111,92,18,70,180,204,41,224,179,28,234,77,177,32,10,66,225,88,114,110,19,168,47,127,48,7,122,130,196,156,108,152,96,107,146,67,45,155,12,203,32,38,134,211,174,120,59,62,48,24,232,113,204,179,78,230,81,35,222,66,218,35,114,111,92,209,0,154,52,192,142,12,80,43,138,38,198,28,205,227,6,199,145,65,126,216,157,125,32,45,228,169,174,116,143,240,8,248,92,146,66,16,169,63,181,3,76,170,147,181,201,117,18,235,100,239,75,71,52,84,187,90,180,14,208,44,75,174,236,183,65,186,32,81,171,166,144,9,152,160,204,50,103,198,193,64,112,232,6,29,213,199,218,170,201,39,66,235,24,251,236,66,71,40,4,2,181,117,26,116,177,184,97,89,201,125,123,119,218,239,44,149,74,199,46,183,205,197,216,112,227,42,242,109,33,62,75,114,155,170,213,30,35,122,73,11,249,4,45,97,74,48,244,222,234,134,172,69,60,129,86,181,165,175,215,27,181,117,32,209,104,79,29,62,231,106,85,244,214,121,164,162,35,0,58,118,185,206,53,171,8,185,94,196,43,190,102,120,12,137,162,63,156,91,172,85,241,144,206,229,25,132,107,185,209,197,130,188,32,207,135,247,246,66,19,123,152,39,67,104,74,222,137,111,206,170,221,120,186,183,185,79,181,124,231,76,193,81,130,39,178,67,198,122,228,64,71,108,45,232,216,136,252,42,53,87,96,115,107,185,49,113,70,190,197,124,115,224,100,63,40,234,107,17,156,81,110,152,128,130,46,161,163,219,216,212,97,209,165,77,20,50,132,185,163,204,149,141,219,5,204,32,44,94,145,46,31,248,90,65,205,12,181,28,249,121,229,223,4,238,169,243,74,131,117,105,163,39,61,5,193,47,127,226,219,144,142,246,29,189,44,206,138,91,40,73,163,81,77,106,128,90,211,147,36,9,48,92,42,186,92,28,64,181,85,105,110,19,170,58,246,36,249,227,50,236,17,225,193,75,119,27,188,136,241,191,9,70,159,195,149,175,58,84,159,41,214,221,4,231,167,167,7,151,143,141,161,133,29,187,193,182,75,177,117,160,21,48,10,68,167,87,48,220,242,192,188,80,147,208,190,1,211,147,124,235,75,161,11,23,230,15,125,253,165,100,153,108,187,116,108,189,232,97,225,164,190,173,171,210,152,92,24,34,179,98,13,141,58,213,27,192,60,7,179,164,44,87,51,176,11,236,12,243,101,14,233,51,99,146,143,156,202,117,92,252,204,242,37,143,66,21,43,160,61,17,113,83,164,9,185,112,53,242,223,186,41,68,214,111,175,184,140,69,186,49,158,182,81,252,238,250,211,216,86,110,107,65,247,136,230,182,135,248,128,170,219,50,252,9,80,125,141,247,22,226,31,47,139,207,60,39,159,204,135,145,11,188,86,139,65,127,230,95,74,46,213,203,34,217,126,8,137,127,68,213,149,216,186,28,42,174,63,65,196,98,239,119,164,32,212,79,171,231,200,99,67,205,255,186,9,141,93,133,127,197,20,51,119,186,220,208,234,155,243,176,39,219,69,81,138,216,77,151,212,126,226,161,75,91,52,20,109,88,62,108,86,214,32,99,79,112,139,254,64,98,237,109,168,165,119,49,71,15,113,247,173,170,28,205,97,139,234,111,118,238,19,162,16,81,175,196,191,204,19,167,213,240,4,72,107,104,82,196,113,41,4,172,10,183,171,52,227,122,162,82,218,177,122,32,64,65,113,164,160,100,72,190,177,200,207,135,181,54,135,65,235,164,94,255,63,188,247,163,166,186,119,250,192,181,251,74,207,185,148,108,201,31,134,35,111,202,217,51,47,122,83,194,254,117,237,77,56,39,162,70,143,28,197,107,47,65,58,227,36,238,81,113,133,194,31,198,91,36,244,162,140,152,250,219,110,88,233,187,108,56,117,43,31,30,7,35,127,181,228,217,60,8,67,223,38,104,32,253,152,152,137,71,11,225,38,4,18,240,115,65,214,187,76,25,220,164,90,226,58,54,59,204,32,122,154,10,169,222,9,251,198,32,186,171,10,239,29,117,123,137,142,8,61,62,7,18,144,175,191,38,119,212,136,9,87,154,155,107,5,189,34,37,200,227,191,17,202,58,113,46,223,194,40,255,78,152,121,53,10,37,29,253,1,201,86,149,72,129,217,94,188,104,200,140,116,244,88,225,48,254,209,216,42,108,193,183,215,20,241,162,192,185,126,238,56,120,24,75,110,96,169,162,176,29,64,47,209,18,70,141,128,168,245,48,136,189,25,116,225,50,8,147,26,227,234,209,235,108,93,146,48,13,236,179,141,220,221,9,129,12,17,207,150,215,71,192,99,213,241,177,136,196,66,228,35,127,120,119,45,139,140,43,30,13,191,167,223,210,239,201,239,182,174,144,84,130,143,54,130,67,65,230,9,213,239,104,180,9,176,186,225,212,112,5,251,17,110,93,250,109,0,103,9,29,154,87,94,94,98,222,164,66,193,252,80,117,99,31,253,105,237,216,56,181,183,37,251,51,23,154,180,158,136,244,232,213,191,31,184,237,83,99,118,13,215,143,38,80,173,1,48,1,155,232,122,207,82,81,1,99,215,159,146,207,222,165,94,8,186,27,127,21,245,182,68,197,85,183,177,131,52,72,229,83,162,192,179,158,177,143,234,33,189,133,8,51,26,58,46,26,166,201,208,155,198,59,23,11,61,155,183,73,92,148,215,40,87,244,237,184,45,26,61,227,249,82,173,200,191,200,119,35,215,108,7,77,97,27,43,127,224,178,110,174,227,150,194,65,186,215,99,7,212,54,111,242,144,45,247,244,14,104,218,29,237,61,33,104,225,213,190,25,8,92,105,217,185,106,54,125,25,206,116,224,200,238,149,188,139,214,7,111,210,168,221,253,209,178,63,12,165,234,1,182,134,111,204,103,126,222,185,249,55,24,121,91,115,110,236,47,107,254,184,242,127,84,60,31,87,231,170,50,249,87,21,60,75,3,185,249,187,230,223,81,161,2,230,38,117,119,230,169,150,215,223,60,65,220,230,251,64,106,146,176,6,137,2,22,227,128,237,158,165,100,236,75,255,198,185,197,76,1,110,219,220,93,56,136,247,87,153,79,235,240,244,146,17,188,34,168,204,167,105,181,42,66,176,154,155,145,205,155,212,6,225,98,126,215,177,117,123,153,255,196,21,220,153,175,166,214,48,130,254,251,19,107,135,79,246,161,126,124,244,230,211,124,77,254,164,95,243,220,91,92,155,119,85,124,236,200,83,231,55,91,203,121,21,79,245,14,223,140,179,163,190,68,190,228,235,77,166,95,85,76,26,63,128,81,31,248,156,229,176,24,10,77,117,110,127,115,121,105,182,203,168,102,30,240,112,114,216,167,73,131,27,53,63,218,114,171,105,215,207,20,131,222,250,101,41,143,67,22,227,6,135,240,13,77,0,186,227,103,16,60,13,15,205,217,179,103,255,1,145,134,33,36,221,30,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3336cfe7-b740-410f-a18b-6aa5422388d5"));
		}

		#endregion

	}

	#endregion

}

