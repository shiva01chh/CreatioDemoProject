﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FacebookOmnichannelMessagingServiceSchema

	/// <exclude/>
	public class FacebookOmnichannelMessagingServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FacebookOmnichannelMessagingServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FacebookOmnichannelMessagingServiceSchema(FacebookOmnichannelMessagingServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("83406a83-3975-4ac6-9488-b0f07bdd8d67");
			Name = "FacebookOmnichannelMessagingService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,90,91,111,219,56,22,126,118,129,254,7,86,93,116,100,192,75,183,125,26,36,77,6,206,165,29,207,54,151,141,221,201,67,48,40,100,137,142,181,149,68,149,164,146,122,51,249,239,123,120,147,168,155,227,180,89,236,96,243,16,88,228,225,225,225,225,119,174,82,22,164,132,231,65,72,208,156,48,22,112,186,20,248,144,102,203,248,186,96,129,136,105,134,207,210,44,14,87,65,150,145,4,159,16,206,131,235,56,187,126,254,236,238,249,179,65,193,225,39,114,8,202,121,124,68,211,32,206,240,113,38,98,17,19,190,219,69,125,206,232,77,28,17,198,31,73,253,30,196,93,80,250,197,142,60,114,185,22,146,192,41,111,8,19,48,82,209,207,214,92,144,180,249,12,10,73,18,18,74,109,112,252,129,100,132,197,97,139,230,99,156,125,109,13,94,20,32,82,74,240,12,150,4,73,252,111,165,209,22,21,204,222,196,33,57,161,17,73,54,78,226,9,8,113,243,48,19,124,73,22,21,193,41,185,21,32,185,188,217,223,184,187,210,189,241,52,237,155,97,164,111,28,31,29,244,78,93,144,175,5,225,130,247,18,184,242,194,85,8,22,132,162,139,24,142,98,196,179,75,46,104,33,128,166,143,248,87,33,114,60,89,112,197,81,94,89,69,8,247,88,164,25,218,107,159,3,235,41,32,5,226,151,140,92,195,66,116,152,4,156,239,160,11,120,2,21,179,67,13,164,11,176,23,224,74,20,233,213,81,32,2,43,254,31,48,144,23,139,36,14,81,40,151,246,173,68,59,232,32,224,164,98,52,184,83,204,202,141,1,171,57,64,19,160,188,131,206,21,67,61,63,30,143,209,59,94,164,105,192,214,251,118,96,26,161,56,67,156,8,169,20,142,24,201,41,46,137,199,46,181,18,246,132,164,11,194,164,168,86,86,208,148,194,145,225,0,252,238,208,53,17,187,146,231,46,186,55,162,145,44,210,210,169,103,61,234,14,14,218,138,179,118,122,204,24,101,255,32,107,174,108,39,16,148,169,213,53,85,181,104,107,244,160,177,46,38,82,111,112,12,38,109,130,116,49,114,84,172,105,235,155,42,26,53,172,39,27,26,73,181,163,104,170,195,33,140,51,129,66,64,240,3,36,68,238,243,153,23,139,30,90,163,99,187,68,137,165,23,181,137,213,191,94,48,188,167,44,13,4,7,250,44,146,71,208,76,190,144,117,55,34,212,72,30,176,32,69,25,4,130,61,79,209,75,47,225,237,27,107,3,64,25,212,6,28,253,54,59,59,69,116,241,47,112,134,239,198,106,93,197,134,17,81,176,140,239,91,157,143,80,68,114,16,131,35,64,68,201,247,221,216,210,57,8,164,224,136,25,56,103,171,248,15,68,204,244,1,236,173,251,102,166,228,3,70,156,21,73,50,68,250,230,220,105,32,135,89,79,114,80,203,189,93,69,18,47,145,255,66,211,225,41,63,133,197,103,236,56,205,197,218,47,153,14,45,187,65,39,138,42,85,236,33,73,110,34,8,62,34,220,248,119,114,166,117,211,185,124,223,217,72,139,52,224,183,177,8,87,200,183,140,177,162,248,5,215,0,83,10,53,8,193,107,160,183,175,223,252,252,250,245,155,29,51,54,208,250,68,30,56,25,113,152,80,78,162,131,245,39,16,200,28,123,80,135,152,161,182,138,82,52,247,168,211,162,251,13,90,70,80,146,93,19,54,205,150,244,17,254,112,227,122,176,241,174,76,194,192,16,111,152,123,34,71,106,165,67,65,158,3,165,10,179,224,93,31,118,166,254,41,216,142,132,28,44,156,70,222,176,195,185,78,228,204,83,251,213,13,42,81,108,154,167,148,207,214,170,151,224,22,172,147,8,178,8,160,29,146,248,198,241,122,28,45,25,77,205,147,28,7,71,70,174,117,78,8,26,138,177,221,192,213,202,149,97,239,34,224,106,194,243,83,34,32,134,231,176,120,17,39,177,88,203,236,32,102,36,37,153,224,190,251,32,211,1,208,228,3,75,36,21,54,3,145,82,247,213,17,89,6,69,34,156,20,129,244,194,111,131,222,54,131,208,70,156,78,120,49,42,192,244,73,164,239,53,183,143,45,231,102,210,207,11,165,112,194,62,177,68,227,2,254,91,83,30,187,201,209,120,11,177,49,191,9,199,250,10,201,216,3,112,89,120,61,44,134,212,84,183,16,112,201,227,165,217,123,156,90,147,173,177,111,160,183,2,42,152,163,96,69,8,81,186,97,121,230,66,182,56,147,63,132,203,88,128,199,243,141,3,84,123,246,167,65,25,228,254,202,7,115,148,145,91,128,43,23,65,6,55,74,151,64,76,32,61,96,100,185,231,109,177,177,55,222,239,177,249,71,8,47,61,48,104,33,211,101,3,42,106,143,229,201,154,195,213,57,251,117,123,66,196,138,70,10,113,42,239,177,23,173,147,160,15,69,28,201,248,105,101,52,169,231,52,242,213,76,149,228,217,168,50,35,178,180,65,230,28,230,105,79,169,80,63,52,142,50,212,81,5,207,105,238,191,25,154,188,217,247,164,223,51,51,239,193,111,248,158,217,184,28,189,92,17,70,124,239,132,95,87,50,120,67,136,196,199,95,139,32,241,53,31,124,46,115,10,2,136,244,29,73,135,50,245,208,194,236,186,65,172,38,51,62,254,70,66,192,242,44,12,146,128,189,147,167,221,247,117,156,189,239,86,81,77,148,131,245,140,22,12,46,206,152,7,87,79,79,172,164,198,225,183,209,151,150,106,147,162,140,164,79,172,36,192,78,130,14,87,36,252,50,229,198,85,204,138,60,167,80,48,71,126,137,118,51,83,69,9,51,96,245,102,100,240,155,243,182,6,151,137,24,21,110,46,54,68,127,254,217,98,135,39,66,4,225,74,249,126,244,194,102,126,175,94,181,9,101,210,71,88,23,219,87,175,180,98,91,75,192,17,199,121,12,172,59,86,89,205,232,140,219,234,230,134,2,128,206,11,97,56,204,233,63,11,82,16,223,154,220,52,11,105,218,82,14,228,195,6,90,214,167,86,54,248,145,66,74,10,169,144,255,55,15,216,150,117,135,160,232,171,228,140,171,212,100,122,180,131,238,42,6,247,158,201,36,219,55,194,175,13,64,155,83,230,84,3,176,0,131,185,73,22,169,19,128,13,148,232,84,238,66,162,12,188,148,35,240,72,50,54,12,110,2,157,66,64,26,23,193,94,70,106,12,154,100,107,252,62,102,92,156,49,19,150,253,33,46,245,222,158,210,76,112,28,105,190,115,22,100,124,73,88,67,189,142,64,32,3,46,29,27,200,100,165,232,68,178,186,173,67,70,224,183,76,75,32,43,153,46,79,9,137,250,113,188,229,85,205,217,90,94,81,168,88,43,85,135,154,191,74,174,238,210,26,36,167,203,227,112,69,203,251,250,94,229,27,243,170,42,26,187,75,169,142,14,20,151,5,132,61,127,4,119,20,47,99,208,185,214,203,7,217,170,169,77,194,178,250,94,247,125,154,53,121,140,5,215,119,168,244,127,163,139,41,164,179,44,11,18,35,255,134,227,62,28,136,31,170,44,148,31,69,32,162,160,95,72,166,242,237,184,188,3,68,190,197,92,240,158,148,163,85,161,87,58,240,246,171,139,148,204,237,140,117,249,178,45,4,177,1,113,221,32,116,11,246,171,179,156,232,84,222,205,212,7,87,151,100,1,183,225,127,98,241,156,164,121,34,47,25,202,26,155,88,214,28,207,8,29,208,104,61,19,235,68,210,192,66,115,225,229,40,62,8,24,169,213,66,10,47,191,67,169,188,92,207,165,34,252,94,72,200,30,158,148,140,124,19,104,229,252,222,67,206,204,36,12,97,75,202,48,136,60,53,217,158,114,110,47,65,25,47,78,143,231,179,249,228,244,104,114,113,244,246,243,107,197,21,132,172,157,27,120,224,195,130,49,233,251,207,10,113,77,65,24,91,75,98,69,144,137,249,58,87,58,144,196,227,149,72,147,93,169,94,0,163,216,43,196,242,239,63,203,42,251,37,73,116,139,105,48,64,101,173,46,5,237,106,28,56,199,193,118,222,84,234,3,246,29,155,235,93,239,165,20,80,205,45,221,110,136,70,91,115,75,213,151,197,96,103,12,238,73,210,93,121,171,98,129,111,212,189,124,86,107,188,63,118,93,62,176,103,146,200,228,127,91,94,229,2,203,72,134,138,101,51,35,5,110,189,137,106,219,224,135,144,76,233,61,108,0,83,41,74,204,21,160,98,34,217,25,8,158,4,25,252,103,216,133,90,107,247,145,86,207,8,153,17,169,235,242,205,130,179,151,227,95,170,189,74,47,210,117,155,248,146,197,130,248,165,18,58,92,74,167,151,176,221,226,78,67,86,142,58,238,235,236,182,188,132,190,198,253,50,111,80,207,184,213,179,115,151,232,60,210,89,147,75,247,173,71,183,117,30,211,236,6,54,242,181,103,148,200,61,63,155,205,193,85,24,164,232,238,100,205,93,232,33,245,98,226,97,143,114,201,130,60,39,145,225,54,146,187,34,100,213,190,153,121,205,17,245,245,229,237,184,239,26,80,25,185,234,37,129,165,5,47,68,139,76,230,20,84,28,43,79,238,59,249,81,16,69,177,212,84,144,148,9,59,55,121,217,81,172,74,5,184,194,119,122,131,145,233,172,238,91,112,221,33,115,143,6,171,182,91,92,177,79,203,130,194,154,83,79,81,163,69,175,22,74,79,99,228,232,81,134,239,6,86,119,27,200,191,35,147,186,73,75,173,34,106,215,89,241,36,138,124,47,173,213,61,163,154,216,182,21,42,37,194,179,66,249,116,144,108,25,36,165,95,84,83,170,149,42,51,47,35,118,249,44,219,3,214,242,205,220,71,26,170,183,109,139,132,24,51,174,151,103,248,146,178,47,234,173,167,52,90,165,155,153,160,76,166,41,122,199,173,218,4,35,228,181,54,226,54,249,152,36,96,176,209,90,33,2,255,30,36,133,172,225,42,175,130,238,29,167,96,110,68,94,131,182,43,217,90,116,178,119,213,119,185,104,206,27,173,151,4,176,224,1,87,54,106,172,80,152,209,199,55,83,115,19,49,52,240,43,242,70,191,74,35,173,53,94,219,161,214,91,170,45,176,163,190,103,52,59,102,6,130,158,101,48,233,54,155,46,132,153,21,54,109,181,39,144,57,129,59,228,15,155,182,99,55,5,4,0,150,219,209,163,116,6,205,155,113,12,163,206,227,23,236,188,67,123,81,127,65,97,240,93,205,239,53,4,112,230,12,52,144,76,43,236,114,89,119,40,200,67,225,241,62,136,19,18,149,235,171,234,208,198,139,59,125,169,101,181,177,193,184,238,221,58,93,146,185,37,84,79,152,74,233,141,108,15,55,118,253,193,4,150,86,9,236,255,89,180,49,101,146,212,154,49,208,254,196,87,2,51,34,9,233,243,2,71,238,156,173,234,156,132,170,226,248,221,166,40,229,244,90,190,98,107,239,242,56,67,116,202,233,22,138,111,99,177,146,111,183,127,186,115,53,82,85,119,247,63,65,246,135,4,91,235,80,141,172,232,110,71,196,177,102,87,255,46,195,225,147,72,114,27,112,35,64,228,13,183,176,33,229,52,121,227,101,75,199,43,150,109,44,202,48,113,82,55,91,9,111,76,248,234,134,248,116,21,164,49,203,237,138,200,255,150,241,202,226,243,135,77,182,214,217,248,254,246,30,64,212,218,170,12,26,61,140,202,239,145,240,148,159,7,156,207,87,50,131,80,218,165,137,21,194,118,41,170,119,194,237,62,100,41,144,35,73,85,97,74,71,95,123,51,220,209,59,108,14,244,52,18,31,60,136,249,85,73,189,91,105,161,175,183,220,106,37,87,71,109,92,72,147,178,235,192,38,136,86,221,33,167,241,59,229,170,239,37,83,195,106,143,238,70,225,86,91,153,168,29,6,234,149,254,241,183,144,228,202,146,171,23,248,101,16,215,184,243,61,253,165,199,237,10,226,185,243,6,86,172,74,84,73,11,108,186,163,145,253,49,141,118,208,221,235,123,108,62,24,137,193,123,193,192,155,251,17,154,129,244,95,230,76,126,214,119,247,22,204,204,28,206,137,14,168,236,193,203,159,21,125,71,177,250,104,83,151,13,61,221,86,177,162,171,215,223,53,107,255,112,252,151,49,246,234,163,147,46,169,125,55,52,23,253,1,180,239,208,141,162,203,116,129,100,83,216,28,254,18,130,139,138,140,229,87,35,157,159,71,236,251,186,163,164,214,104,61,98,80,226,72,202,84,203,72,77,19,66,97,194,121,205,210,120,25,82,10,131,149,152,155,58,165,78,114,88,45,112,179,199,22,172,15,105,145,68,40,163,66,189,82,46,241,91,83,136,225,106,62,200,81,123,238,254,8,232,114,96,243,23,71,216,185,46,253,106,175,198,188,115,10,114,187,39,127,240,139,144,231,207,96,12,254,254,3,27,106,48,101,187,43,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateChannelAlreadyExistLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateChannelAlreadyExistLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("680c6956-b6c5-000a-f6f4-71ee1cda74aa"),
				Name = "ChannelAlreadyExist",
				CreatedInPackageId = new Guid("01343ce8-0448-497f-b2c3-9511b4580fa3"),
				CreatedInSchemaUId = new Guid("83406a83-3975-4ac6-9488-b0f07bdd8d67"),
				ModifiedInSchemaUId = new Guid("83406a83-3975-4ac6-9488-b0f07bdd8d67")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83406a83-3975-4ac6-9488-b0f07bdd8d67"));
		}

		#endregion

	}

	#endregion

}
