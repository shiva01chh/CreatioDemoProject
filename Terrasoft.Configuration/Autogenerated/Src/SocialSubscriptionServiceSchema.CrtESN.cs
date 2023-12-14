﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SocialSubscriptionServiceSchema

	/// <exclude/>
	public class SocialSubscriptionServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SocialSubscriptionServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SocialSubscriptionServiceSchema(SocialSubscriptionServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("299fa9a5-7be2-4180-91ae-ac3ef3b3bff6");
			Name = "SocialSubscriptionService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,28,93,115,219,54,242,89,157,233,127,64,116,51,25,106,170,97,250,220,196,158,241,103,70,157,164,201,89,201,229,33,211,7,154,132,45,94,40,82,1,64,187,186,214,255,253,22,95,36,0,2,36,101,203,119,73,147,62,164,22,8,44,246,123,23,139,37,203,100,141,233,38,73,49,122,135,9,73,104,117,197,226,147,170,188,202,175,107,146,176,188,42,127,252,225,207,31,127,152,212,52,47,175,209,114,75,25,94,63,119,126,195,252,162,192,41,159,76,227,151,184,196,36,79,59,115,94,229,229,231,206,224,18,167,53,201,217,214,243,128,220,228,41,126,93,101,184,232,125,24,31,193,190,55,2,209,254,121,31,240,101,103,2,140,193,36,74,97,241,146,37,12,183,19,76,94,172,215,38,108,243,9,9,172,32,216,102,97,112,214,233,113,240,209,89,201,114,150,99,234,155,192,241,118,241,226,139,196,154,109,43,13,116,16,130,26,187,83,125,128,150,233,10,175,147,65,32,114,90,24,0,108,82,175,135,113,49,39,3,48,0,247,81,9,16,120,201,72,146,178,223,249,216,17,221,252,134,25,80,191,1,214,94,230,5,172,188,192,159,235,156,224,53,46,25,141,204,31,92,242,176,239,192,18,62,43,86,3,217,140,111,178,169,47,139,60,69,105,145,80,138,150,85,154,39,197,178,190,164,41,201,55,156,87,10,45,244,11,58,78,40,86,191,230,104,113,129,147,236,77,89,108,77,149,2,104,220,124,38,255,32,248,154,75,228,45,169,54,152,112,178,127,65,111,197,54,130,212,201,134,112,45,198,232,244,88,219,196,89,121,157,151,158,1,1,110,114,141,217,115,241,7,85,127,220,217,112,94,214,121,198,213,252,40,91,231,229,251,50,103,139,108,96,229,63,112,153,73,36,213,111,133,49,112,159,50,82,167,172,34,46,206,146,77,65,6,69,51,181,101,135,134,3,244,158,98,2,144,75,169,125,177,59,67,98,232,224,223,89,117,82,19,2,18,228,163,241,34,27,67,204,107,204,86,85,198,233,144,124,178,153,118,83,1,211,78,86,56,253,116,146,148,103,89,206,34,206,198,143,191,35,218,33,113,145,209,185,100,114,186,74,0,161,98,145,105,106,5,128,139,252,122,5,218,24,88,216,172,153,119,61,66,44,13,225,2,167,21,201,4,152,87,248,6,23,52,86,56,205,197,38,147,233,171,42,77,138,252,63,201,101,129,151,140,128,225,209,216,220,7,102,255,86,177,99,204,151,224,44,254,87,82,212,120,58,243,169,138,69,245,41,46,48,195,95,26,221,18,171,29,41,151,139,70,146,174,240,222,133,238,57,18,248,140,38,4,145,230,239,57,162,2,113,4,177,151,38,215,184,67,145,230,233,36,47,25,34,152,214,5,3,245,255,89,154,197,228,10,54,74,210,21,138,110,18,226,197,21,229,165,159,134,6,238,196,191,180,69,23,182,115,141,18,98,59,51,125,181,75,97,52,237,186,130,233,220,139,200,76,81,50,201,175,80,228,209,22,3,143,167,6,223,102,232,201,129,245,83,83,51,145,60,250,233,39,13,247,78,254,95,253,175,37,246,68,74,111,47,116,42,88,83,67,175,53,93,6,89,221,29,71,81,228,16,116,215,194,85,234,112,136,126,110,103,179,21,169,110,81,137,111,81,67,202,31,41,22,172,140,248,104,71,193,34,199,149,126,168,200,39,145,6,66,36,164,85,77,82,152,87,17,80,205,185,230,176,71,184,202,207,3,3,130,122,60,51,241,119,172,207,155,178,0,239,77,183,79,163,234,242,223,240,8,140,50,133,52,0,178,0,67,139,185,88,49,253,12,34,228,52,154,34,251,103,141,201,214,165,209,156,240,58,41,1,95,50,71,83,115,55,229,37,38,0,52,62,202,178,163,162,48,179,18,26,169,199,124,95,133,205,121,94,48,76,0,3,190,228,4,204,146,97,57,244,33,103,171,183,9,129,236,26,126,208,72,14,138,28,132,228,180,42,223,109,55,144,1,125,174,19,240,5,211,19,9,11,98,24,215,165,150,204,22,25,185,156,114,164,34,107,103,53,71,50,9,193,112,205,5,0,190,111,93,157,114,30,3,107,234,162,144,147,184,242,192,86,55,144,127,196,239,170,227,170,42,112,82,70,209,37,252,49,235,75,95,99,96,209,18,51,38,60,237,59,178,5,17,9,159,234,240,23,8,57,210,251,103,26,1,32,168,170,61,136,205,102,141,242,10,227,180,34,253,94,152,42,152,105,103,16,90,25,93,142,250,118,87,115,165,221,17,204,106,82,10,116,26,223,208,234,172,195,7,111,164,9,234,122,199,168,12,141,239,117,225,251,81,254,174,195,30,111,2,64,219,58,33,91,249,100,127,50,243,83,237,183,5,15,10,106,230,253,69,246,236,217,51,244,130,214,107,14,248,80,15,92,8,112,20,213,101,254,185,198,40,207,32,239,204,175,114,160,184,186,66,108,133,181,217,162,219,85,133,82,65,126,38,198,175,48,164,32,13,216,103,46,220,23,27,206,26,84,2,123,14,166,62,202,167,135,230,239,238,254,241,139,103,2,132,31,34,22,116,115,40,146,3,3,235,173,211,67,163,157,42,130,189,185,133,147,253,34,19,57,146,87,72,42,65,210,123,54,121,161,123,160,164,250,92,201,119,16,127,123,243,69,67,211,30,170,231,114,199,248,55,224,137,130,218,129,163,78,169,21,39,178,57,132,170,237,141,193,179,63,114,202,83,49,5,81,89,69,124,84,110,163,20,29,28,162,84,108,130,14,14,208,84,240,75,155,19,247,189,46,152,198,3,26,15,148,1,129,110,203,223,145,13,230,14,65,34,137,71,173,147,54,152,29,111,167,150,43,83,122,96,229,38,106,113,99,39,29,199,222,136,244,185,87,162,10,5,236,59,244,91,27,169,212,24,76,184,204,204,121,199,219,183,9,91,153,12,50,101,37,180,170,146,218,215,129,8,72,115,23,162,200,22,113,233,5,95,112,24,117,209,177,93,131,130,24,60,61,115,36,5,243,57,55,180,222,55,209,217,116,195,102,252,80,122,106,6,30,175,179,209,73,4,28,207,184,211,87,203,78,115,49,5,60,196,11,121,66,128,240,41,162,193,161,150,249,159,58,91,48,83,5,41,218,187,86,213,76,140,226,115,204,210,213,57,169,214,167,199,81,187,99,27,128,21,63,172,53,138,47,118,252,227,28,136,207,214,27,89,176,243,50,173,49,233,247,125,158,194,98,158,158,190,196,220,57,107,254,137,31,46,231,84,46,26,107,29,55,149,16,32,76,213,132,152,19,235,61,141,232,9,31,86,152,224,136,199,155,89,188,160,34,252,68,74,241,154,88,229,119,74,51,148,80,133,221,243,46,13,141,103,104,232,137,207,254,128,140,156,225,37,100,198,9,81,170,105,43,98,179,162,63,113,80,222,179,117,154,187,177,215,244,183,92,56,61,46,87,225,53,236,89,185,245,45,74,202,146,50,197,199,91,1,85,195,15,159,183,229,185,252,168,102,171,138,168,99,119,87,82,30,186,52,85,96,90,194,34,203,43,136,180,109,5,168,183,60,100,56,18,234,22,149,186,59,197,118,218,104,46,246,4,68,197,88,95,168,244,128,230,97,210,51,124,102,123,88,158,147,155,196,45,168,0,233,122,63,181,143,204,159,104,100,44,136,79,26,71,21,130,168,246,191,148,96,45,138,125,0,27,72,220,191,120,80,251,235,175,16,120,199,209,152,142,165,213,80,25,54,189,25,169,107,103,93,73,15,170,38,135,30,181,27,25,148,60,81,145,92,80,15,65,153,200,160,41,207,252,180,7,245,243,10,14,201,82,151,123,139,5,54,15,231,6,185,94,69,24,182,156,46,135,34,143,98,7,146,49,127,217,71,59,221,46,228,253,134,46,235,172,61,119,48,190,155,235,105,218,24,166,109,230,209,137,112,79,60,188,27,23,232,76,33,46,74,158,113,168,218,231,251,146,106,157,245,88,174,162,221,179,173,170,153,54,114,155,76,66,146,235,202,108,200,123,255,223,68,21,60,138,61,146,36,70,240,213,228,42,175,139,154,230,208,200,238,62,6,145,9,64,154,57,114,215,64,230,97,102,22,246,158,110,110,97,199,144,222,60,195,46,82,104,56,71,101,22,181,166,208,179,190,33,73,228,38,18,255,86,250,77,245,88,82,169,243,17,39,7,145,179,134,60,79,227,210,249,173,130,240,113,223,67,247,215,22,186,163,16,164,167,79,61,104,207,120,92,127,242,77,5,246,206,117,192,216,72,239,250,155,192,228,55,27,172,234,170,226,58,239,33,9,193,88,204,132,1,36,38,110,234,254,201,220,91,76,34,98,105,235,30,155,171,166,33,98,80,213,252,149,151,64,122,189,142,117,157,152,70,12,78,232,213,213,32,12,163,40,124,111,33,88,84,54,56,217,92,110,136,52,196,238,176,215,227,214,64,233,48,241,20,108,71,4,27,235,103,115,4,155,35,105,217,86,230,1,54,192,72,141,7,147,0,143,227,157,221,203,120,188,199,100,85,193,245,150,131,194,137,208,18,179,83,124,101,84,98,154,114,241,160,163,238,248,177,224,58,231,204,207,107,87,246,200,192,74,99,73,207,220,19,87,40,182,148,194,84,37,55,110,104,237,206,10,37,52,166,134,61,40,161,201,5,32,149,208,72,168,174,16,227,69,201,170,129,76,6,228,217,201,99,230,104,108,254,34,86,27,169,124,79,222,226,201,86,36,9,247,203,86,84,86,159,148,215,216,73,235,119,187,223,247,152,167,213,236,160,187,68,134,186,29,246,88,201,190,255,141,205,30,154,6,164,128,184,239,28,172,24,247,93,250,203,75,108,9,70,222,79,182,23,217,188,164,153,151,53,182,175,189,229,108,174,81,134,115,137,166,182,112,121,65,212,150,213,115,123,181,97,154,62,151,111,170,78,247,64,184,83,158,27,58,22,157,120,117,201,184,189,95,148,55,73,145,103,77,68,220,247,45,126,239,37,254,216,198,154,19,30,61,138,162,109,173,177,46,24,196,137,83,183,236,136,192,220,109,253,27,211,237,227,38,135,255,155,214,20,39,87,238,108,253,212,161,77,244,111,184,67,29,177,62,86,83,198,94,196,233,244,73,57,22,226,41,102,72,243,144,206,173,57,8,210,168,123,202,178,131,82,42,189,229,189,84,130,47,124,20,133,104,123,120,92,204,7,181,160,33,70,235,128,49,240,117,105,128,221,35,232,113,145,222,43,113,161,6,20,221,174,48,91,193,241,81,157,17,81,13,20,80,180,74,40,132,138,4,78,29,105,138,169,234,125,67,16,131,118,190,20,119,178,187,233,225,57,44,86,89,143,62,55,238,120,43,110,117,13,72,170,37,212,113,183,227,29,35,224,141,191,166,17,116,242,124,49,218,221,181,41,139,4,26,6,65,167,26,208,187,90,12,95,40,5,185,176,82,136,5,195,235,23,238,165,210,161,98,36,127,56,254,16,14,147,229,165,143,67,175,82,160,16,85,251,176,222,22,221,88,30,233,60,204,29,52,224,134,183,218,128,141,129,47,216,128,77,63,165,45,152,99,190,171,253,54,117,28,138,18,97,181,194,60,19,125,143,191,91,231,138,125,72,56,20,85,189,199,237,85,25,118,20,103,15,241,17,192,16,222,203,255,230,182,20,212,160,10,126,240,150,1,100,158,148,194,238,65,228,145,13,135,57,59,30,90,38,104,17,2,131,185,74,10,138,205,108,83,236,199,141,82,20,88,155,141,221,222,182,185,177,87,11,176,175,46,31,240,115,29,28,157,22,145,158,218,124,8,35,237,54,198,36,218,192,130,96,57,38,76,113,192,79,137,170,69,2,7,202,96,243,250,112,223,188,145,214,243,43,130,243,170,200,70,137,220,76,144,62,243,83,32,58,144,146,24,221,4,113,94,151,41,252,93,151,44,144,228,186,199,164,217,232,46,9,161,84,191,86,121,233,84,1,202,139,170,192,211,6,145,55,254,231,78,111,45,31,179,238,49,2,216,186,247,38,61,183,42,222,125,238,127,215,50,142,123,97,216,210,40,71,128,220,253,82,199,109,56,105,202,36,66,103,156,30,147,188,100,77,139,73,160,97,252,239,116,226,116,204,82,85,182,133,238,26,130,27,237,130,7,156,45,3,19,213,53,234,208,117,252,128,135,219,167,195,158,244,59,160,33,76,38,61,37,199,161,181,234,34,24,18,39,38,46,8,180,226,32,236,132,19,132,227,215,242,253,0,79,79,153,20,87,184,171,76,136,35,200,172,123,8,212,227,113,199,119,156,13,59,91,110,213,163,29,172,240,173,252,31,209,5,45,168,116,189,217,55,229,107,119,116,140,6,192,89,12,142,2,254,21,141,181,52,82,236,26,148,171,209,75,232,173,132,43,129,234,217,35,174,255,13,246,5,0,62,148,129,14,15,187,27,220,55,188,72,240,157,120,195,189,85,215,124,38,50,242,72,68,238,163,144,163,148,203,45,44,142,142,123,202,187,232,216,7,231,187,159,195,73,92,39,3,220,173,169,1,51,113,85,62,46,137,228,211,219,27,244,145,107,194,237,23,3,75,172,46,203,93,242,218,229,192,1,124,252,141,114,98,222,191,95,168,155,87,149,29,244,109,97,189,46,169,125,248,41,46,183,198,68,250,197,93,83,15,241,205,102,153,193,43,63,155,204,27,108,147,31,62,86,140,61,246,99,70,81,189,65,87,117,161,120,76,155,186,156,104,137,215,111,180,60,236,205,149,233,225,59,5,3,177,10,221,174,114,144,142,89,11,164,40,33,16,221,49,215,153,235,252,6,247,156,165,253,6,182,147,141,6,155,237,252,77,68,251,109,28,26,215,55,36,218,246,123,58,132,122,222,125,111,27,134,122,14,242,65,248,224,146,121,242,21,245,86,1,130,239,240,236,175,231,96,15,173,59,237,155,34,242,157,13,192,207,125,139,195,199,2,247,29,29,57,117,20,99,134,236,221,128,103,189,134,228,191,33,13,246,12,9,96,241,81,81,84,183,16,113,95,146,164,108,26,135,226,247,33,95,16,240,235,161,232,179,147,65,117,95,218,28,223,142,231,190,160,50,74,199,251,149,59,120,167,221,107,222,15,239,60,123,44,69,222,57,174,184,103,160,97,85,235,141,192,109,143,26,175,249,237,87,45,191,32,226,212,119,37,30,195,234,134,191,64,98,124,73,229,99,131,146,249,173,155,201,199,15,248,114,81,222,84,159,112,36,151,241,62,202,183,111,150,239,32,85,62,174,178,237,146,109,11,222,155,4,211,212,1,187,25,141,63,144,100,179,193,138,19,252,235,54,152,178,243,138,172,19,102,45,144,67,241,175,148,103,24,23,152,110,170,146,226,254,121,226,19,57,250,227,47,42,235,123,220,102,27,163,230,18,110,237,25,106,194,9,116,135,60,70,253,66,222,153,127,245,66,13,188,180,176,235,119,97,12,233,157,216,95,153,25,217,55,181,151,239,157,120,136,233,235,81,122,220,226,214,87,175,26,190,14,169,241,159,45,232,78,160,102,66,109,61,240,43,137,18,147,161,90,141,142,140,187,63,242,42,140,161,46,187,191,24,244,93,101,2,42,35,28,123,176,120,59,88,167,85,124,9,150,128,151,99,234,229,127,15,78,90,95,101,81,183,40,26,76,123,157,223,222,116,236,120,175,108,154,40,209,96,101,113,188,111,231,168,107,140,158,219,239,176,152,58,104,185,114,27,178,41,137,70,220,62,60,64,62,203,210,19,191,37,93,80,149,1,231,219,5,163,218,14,30,168,13,158,207,54,169,213,205,147,63,219,103,72,189,79,232,253,76,142,153,254,235,64,97,125,34,170,243,201,36,111,92,48,63,210,96,125,177,33,119,182,112,162,128,173,199,206,87,18,134,219,11,38,147,75,192,224,211,46,65,226,155,84,104,149,89,88,220,246,126,253,107,103,237,253,202,245,231,123,94,49,94,97,94,146,170,222,180,159,113,180,98,206,110,138,99,168,64,183,94,69,227,87,184,188,102,43,251,35,124,141,170,248,94,86,117,148,196,58,155,12,233,201,56,55,115,247,93,93,70,168,139,183,37,100,167,36,212,133,240,13,37,160,162,132,236,208,191,203,247,234,246,118,240,219,239,105,207,43,214,193,98,246,152,75,29,243,54,206,172,8,242,49,49,204,255,251,47,27,39,106,167,131,93,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSubscriptionCanNotBeCancelledLocalizableString());
			LocalizableStrings.Add(CreateSubscriptionCanNotBeDeletedLocalizableString());
			LocalizableStrings.Add(CreateSocialChannelCanNotBeReadLocalizableString());
			LocalizableStrings.Add(CreateSubscriptionCanNotBeEditedLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSubscriptionCanNotBeCancelledLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("526b6216-8676-422a-999d-366feecd8797"),
				Name = "SubscriptionCanNotBeCancelled",
				CreatedInPackageId = new Guid("1c744f6a-ce44-4682-aa73-9366af96c78f"),
				CreatedInSchemaUId = new Guid("299fa9a5-7be2-4180-91ae-ac3ef3b3bff6"),
				ModifiedInSchemaUId = new Guid("299fa9a5-7be2-4180-91ae-ac3ef3b3bff6")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSubscriptionCanNotBeDeletedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("514a578b-05b2-48fa-a5bf-5f5322cb73ee"),
				Name = "SubscriptionCanNotBeDeleted",
				CreatedInPackageId = new Guid("1c744f6a-ce44-4682-aa73-9366af96c78f"),
				CreatedInSchemaUId = new Guid("299fa9a5-7be2-4180-91ae-ac3ef3b3bff6"),
				ModifiedInSchemaUId = new Guid("299fa9a5-7be2-4180-91ae-ac3ef3b3bff6")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSocialChannelCanNotBeReadLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3b525325-fd3f-4cd7-9590-ddf7bca0f2d5"),
				Name = "SocialChannelCanNotBeRead",
				CreatedInPackageId = new Guid("1c744f6a-ce44-4682-aa73-9366af96c78f"),
				CreatedInSchemaUId = new Guid("299fa9a5-7be2-4180-91ae-ac3ef3b3bff6"),
				ModifiedInSchemaUId = new Guid("299fa9a5-7be2-4180-91ae-ac3ef3b3bff6")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSubscriptionCanNotBeEditedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("857df232-b97f-446f-8ae0-b8423e73f82e"),
				Name = "SubscriptionCanNotBeEdited",
				CreatedInPackageId = new Guid("c67513d6-3fd3-40ef-89eb-349103403312"),
				CreatedInSchemaUId = new Guid("299fa9a5-7be2-4180-91ae-ac3ef3b3bff6"),
				ModifiedInSchemaUId = new Guid("299fa9a5-7be2-4180-91ae-ac3ef3b3bff6")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("299fa9a5-7be2-4180-91ae-ac3ef3b3bff6"));
		}

		#endregion

	}

	#endregion

}

