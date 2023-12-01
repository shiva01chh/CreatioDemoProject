﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseVisaNotificationProviderSchema

	/// <exclude/>
	public class BaseVisaNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseVisaNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseVisaNotificationProviderSchema(BaseVisaNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7556c326-e6f0-4087-b6e8-cffd65b1e488");
			Name = "BaseVisaNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d41f9f7a-1de1-48ec-ad3c-256af8e8449d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,90,221,115,219,54,18,127,86,103,250,63,160,186,153,12,53,163,208,185,52,189,54,181,173,142,252,57,186,139,35,215,82,218,135,76,230,134,38,33,27,61,138,80,0,80,137,154,241,255,126,139,47,18,32,65,73,177,251,210,188,196,4,22,251,133,197,226,183,11,21,201,18,243,85,146,98,52,199,140,37,156,46,68,124,74,139,5,185,43,89,34,8,45,190,253,230,203,183,223,244,74,78,138,59,52,219,112,129,151,135,141,111,160,207,115,156,74,98,30,95,226,2,51,146,214,52,46,219,229,146,22,225,25,134,187,198,227,179,147,206,169,243,66,16,65,48,7,2,32,249,7,195,119,160,3,58,205,19,206,127,70,39,9,199,191,17,158,188,165,130,44,72,170,140,185,102,116,77,50,204,20,253,170,188,205,73,138,82,73,190,149,26,105,102,97,70,189,47,138,89,45,29,188,32,146,66,128,6,215,140,172,19,129,245,252,74,127,160,84,206,35,46,152,180,231,6,115,90,178,20,95,37,69,114,135,217,91,216,12,116,140,250,219,148,233,31,26,121,184,200,180,72,95,254,5,193,121,214,37,156,225,36,163,69,190,65,151,37,201,208,127,215,228,207,228,154,174,202,213,4,180,186,46,238,38,25,72,47,240,39,53,29,245,211,215,105,246,242,229,247,248,121,250,195,15,47,159,191,74,95,253,244,252,245,171,244,197,243,23,255,76,22,233,191,126,188,253,254,245,235,31,251,131,189,245,161,2,130,4,103,86,35,243,217,208,137,111,248,56,91,146,226,93,65,196,225,86,66,145,136,146,79,178,46,162,51,176,119,78,192,159,75,154,129,19,113,54,45,192,56,59,26,95,145,226,183,36,47,113,215,242,74,137,27,154,227,153,218,36,142,232,39,8,110,103,96,135,233,42,20,88,153,10,202,164,3,84,184,105,138,131,131,3,116,196,203,229,50,97,155,145,29,152,128,52,146,228,228,79,144,148,168,109,32,42,148,224,108,210,5,18,247,24,150,96,8,32,134,23,199,219,67,228,96,100,162,250,19,17,247,104,149,48,136,43,129,25,143,43,217,7,77,225,71,138,10,21,64,121,220,175,87,244,71,215,213,223,40,35,234,144,195,178,248,232,64,209,168,229,230,28,109,211,40,58,171,150,30,233,208,31,34,122,251,7,248,124,228,168,55,144,220,122,63,163,91,224,20,57,195,232,139,154,112,67,3,182,50,146,97,48,16,247,132,199,53,237,251,190,75,53,201,250,31,212,6,247,200,2,57,28,101,134,19,9,120,247,63,120,19,245,155,187,218,31,88,137,189,230,148,20,27,138,140,182,26,45,166,70,145,135,157,234,216,192,118,212,176,67,91,172,182,139,246,22,83,31,11,71,144,119,86,34,123,88,218,226,156,197,174,192,135,191,69,116,151,28,51,112,69,161,175,172,254,232,157,247,253,213,161,237,47,71,62,119,47,164,27,83,218,233,15,219,115,8,136,89,97,38,47,185,61,50,200,37,163,229,74,89,217,225,11,99,143,185,125,52,185,222,250,59,44,108,16,48,44,74,86,160,190,180,184,191,231,238,170,155,120,131,120,122,143,151,201,30,26,172,9,19,101,146,91,77,212,197,87,41,162,101,114,243,199,254,98,211,100,165,118,240,107,36,159,234,53,143,17,46,253,131,240,211,12,87,60,158,40,123,45,239,49,192,21,121,185,44,30,167,193,85,2,56,14,66,83,113,120,172,54,160,75,254,120,53,230,114,245,19,53,32,75,0,81,8,14,101,33,143,41,102,251,41,160,208,196,68,46,133,4,251,228,24,92,106,36,183,93,180,94,50,83,43,12,244,11,142,117,29,205,70,198,10,44,109,31,219,174,4,115,133,197,61,237,4,140,51,44,145,61,186,196,98,230,222,171,133,186,217,212,92,100,47,143,117,194,16,215,228,199,90,91,153,228,13,209,187,64,86,236,245,98,189,225,81,127,230,95,218,91,231,165,232,154,38,190,96,116,217,96,160,180,171,8,126,191,199,12,183,69,196,19,126,254,17,246,63,210,50,226,10,231,68,46,130,128,171,49,225,198,136,26,73,180,96,193,119,199,65,192,24,191,165,5,70,207,158,181,128,99,231,130,113,158,215,183,190,146,26,143,139,204,234,168,169,42,167,168,175,254,0,61,67,45,27,34,82,136,65,83,234,64,26,125,9,16,87,82,180,150,188,24,12,92,236,96,66,141,215,166,63,248,161,241,107,137,217,230,20,238,53,25,29,242,252,77,165,184,106,212,139,139,143,21,173,174,47,28,170,195,138,8,106,144,140,200,240,184,32,140,11,143,210,206,68,254,231,124,179,194,96,210,219,210,241,218,27,188,16,231,159,87,12,115,46,195,219,227,34,45,174,231,84,76,200,192,52,1,51,68,213,128,13,175,7,173,93,165,126,60,206,50,136,167,98,2,101,111,228,235,59,220,34,72,122,103,168,47,84,229,36,5,238,154,172,207,115,142,255,10,197,15,221,237,171,216,135,118,208,164,222,11,202,150,137,144,96,47,50,35,25,252,45,36,240,51,78,173,106,41,80,160,204,109,110,172,105,175,146,148,81,9,142,27,137,9,2,227,13,77,37,232,75,110,33,10,213,130,40,80,243,130,1,103,21,27,107,129,60,104,85,185,54,103,27,136,84,136,23,171,26,212,15,165,48,250,212,248,213,88,173,135,227,57,53,34,107,29,67,33,110,89,162,95,126,49,46,137,207,151,43,177,57,236,200,158,189,94,71,254,236,40,112,215,20,46,152,241,106,149,111,116,30,209,219,201,35,147,91,245,9,179,38,212,167,202,61,51,29,39,204,94,82,42,79,152,180,96,98,205,201,144,254,196,169,58,255,10,246,111,155,63,217,116,114,184,114,42,135,173,4,91,120,128,179,32,33,241,55,4,128,71,33,235,204,48,217,84,213,136,100,141,155,243,149,115,6,241,152,71,254,201,10,114,154,112,72,173,244,19,206,230,244,12,252,117,7,54,118,80,218,233,76,222,44,157,252,102,85,149,22,158,198,98,139,245,48,123,214,173,192,132,159,202,178,40,199,157,91,72,151,75,192,56,205,217,86,70,151,228,131,218,65,26,32,200,243,214,92,169,207,160,3,193,244,34,53,16,166,85,241,85,187,94,109,211,62,33,167,150,132,108,111,223,194,206,73,52,70,140,211,148,150,123,216,29,88,170,74,223,116,247,82,9,6,189,133,181,227,228,101,211,54,113,31,225,146,135,92,29,114,125,91,3,44,76,77,18,13,90,58,152,153,157,76,164,36,179,184,123,215,67,162,13,14,174,68,155,111,147,147,31,118,165,182,11,146,203,74,220,166,54,108,250,179,51,47,197,201,196,94,119,52,142,145,227,115,155,199,229,208,251,15,104,65,138,36,215,39,77,245,94,220,250,251,157,32,185,98,46,111,153,11,73,152,111,148,163,12,121,19,114,234,92,217,243,85,50,224,112,16,79,87,184,56,201,105,250,191,246,249,6,16,7,32,55,158,180,29,198,35,79,193,65,5,91,167,44,192,70,227,148,168,198,182,57,229,88,203,172,198,36,214,11,100,129,110,172,186,72,0,53,84,192,13,97,248,178,62,12,90,26,82,171,11,6,27,26,31,22,202,205,115,186,68,223,5,90,170,131,14,13,28,227,220,43,164,198,164,83,214,161,74,45,208,83,102,103,56,254,155,146,98,71,48,218,75,184,163,186,209,119,111,119,237,163,181,105,24,58,129,160,99,82,182,62,135,241,212,207,154,214,227,218,23,205,250,187,138,133,154,75,151,114,230,128,55,106,163,170,122,234,73,193,33,232,89,105,208,94,171,161,100,71,173,213,139,37,184,158,150,194,232,213,128,161,158,220,32,68,181,236,246,87,96,71,234,185,193,171,60,169,42,34,187,151,31,229,127,67,11,111,1,126,38,124,24,70,210,166,93,81,101,166,66,152,145,73,145,225,207,176,249,154,151,201,152,60,86,195,211,69,212,24,134,244,3,96,103,44,5,69,74,156,13,83,205,44,86,51,192,77,205,25,208,230,113,120,239,72,253,0,132,250,179,195,112,191,113,226,222,23,78,130,213,200,215,36,29,56,88,50,189,70,134,176,198,203,19,175,105,32,171,154,35,183,153,48,50,45,38,253,213,198,247,129,198,131,242,133,100,116,178,145,49,175,79,192,161,135,206,93,158,177,81,41,148,192,12,185,79,177,213,37,170,149,227,222,98,142,67,234,91,70,222,57,134,162,89,56,192,90,247,142,81,84,230,8,221,96,8,201,12,124,170,94,117,100,105,95,211,201,203,189,154,7,174,91,172,49,130,31,211,159,217,213,253,133,196,135,149,6,170,251,38,187,234,58,140,56,90,80,38,27,235,160,43,76,238,219,38,55,139,251,35,27,229,129,198,56,93,99,198,72,134,245,105,4,88,107,107,27,9,236,205,75,207,200,170,97,157,109,62,101,45,29,245,235,138,213,27,54,208,51,48,163,193,99,96,194,7,162,1,2,23,9,117,172,223,155,164,2,98,1,170,32,102,10,238,216,141,138,9,174,94,63,24,78,41,147,161,204,19,84,56,177,133,4,254,44,190,110,207,212,45,92,109,156,238,15,111,223,190,58,151,220,40,53,110,84,1,29,122,181,243,247,84,75,170,30,232,52,151,91,154,109,230,120,9,153,89,224,39,245,4,78,28,70,214,211,70,134,106,54,255,37,66,230,46,167,134,20,119,31,212,235,155,107,245,251,126,253,220,102,232,169,45,87,91,164,58,158,125,234,204,118,85,154,196,42,196,125,90,157,51,3,58,120,81,239,175,225,85,48,183,86,57,113,30,90,99,31,69,66,194,252,248,247,87,203,157,151,151,166,190,123,116,95,41,114,195,97,232,11,24,214,30,27,186,109,40,235,153,129,211,29,92,201,223,41,152,174,152,250,205,2,80,38,85,134,239,41,7,195,180,23,24,67,61,119,162,213,146,138,152,17,219,238,63,14,253,6,162,238,27,13,12,249,121,237,125,187,17,222,204,204,245,116,237,118,183,133,104,253,139,153,126,4,189,54,230,40,179,226,153,29,142,252,246,157,239,73,81,121,209,15,204,97,131,237,254,137,199,121,114,213,224,73,62,174,194,197,161,173,140,15,70,91,242,142,86,145,143,198,97,46,246,117,23,242,142,165,12,101,158,250,129,225,220,3,209,94,251,216,199,215,38,8,194,47,11,241,25,220,60,164,168,177,121,160,241,214,168,4,130,24,94,61,43,168,6,74,139,141,174,42,154,76,20,242,109,146,218,122,56,40,209,133,67,213,92,87,211,17,190,245,168,59,8,35,240,239,255,230,122,189,117,195,37,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateBodyTemplateLocalizableString());
			LocalizableStrings.Add(CreateTitleTemplateLocalizableString());
			LocalizableStrings.Add(CreateDateMacrosLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateBodyTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8abcdcb1-1a6a-41c5-a4ae-974bc9270335"),
				Name = "BodyTemplate",
				CreatedInPackageId = new Guid("d41f9f7a-1de1-48ec-ad3c-256af8e8449d"),
				CreatedInSchemaUId = new Guid("7556c326-e6f0-4087-b6e8-cffd65b1e488"),
				ModifiedInSchemaUId = new Guid("7556c326-e6f0-4087-b6e8-cffd65b1e488")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTitleTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("686797ea-86a2-4e12-a23f-8370ced1e3d9"),
				Name = "TitleTemplate",
				CreatedInPackageId = new Guid("d41f9f7a-1de1-48ec-ad3c-256af8e8449d"),
				CreatedInSchemaUId = new Guid("7556c326-e6f0-4087-b6e8-cffd65b1e488"),
				ModifiedInSchemaUId = new Guid("7556c326-e6f0-4087-b6e8-cffd65b1e488")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDateMacrosLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("17b4b5d6-00ed-4c8c-aeb9-9a84a5f4a0c7"),
				Name = "DateMacros",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("7556c326-e6f0-4087-b6e8-cffd65b1e488"),
				ModifiedInSchemaUId = new Guid("7556c326-e6f0-4087-b6e8-cffd65b1e488")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7556c326-e6f0-4087-b6e8-cffd65b1e488"));
		}

		#endregion

	}

	#endregion

}
