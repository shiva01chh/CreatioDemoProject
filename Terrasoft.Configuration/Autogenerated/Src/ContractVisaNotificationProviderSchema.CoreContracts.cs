﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContractVisaNotificationProviderSchema

	/// <exclude/>
	public class ContractVisaNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContractVisaNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContractVisaNotificationProviderSchema(ContractVisaNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("817a7ad5-b3e2-43e0-9db3-0b8376b57e54");
			Name = "ContractVisaNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("26258d2f-5eb6-4391-98b9-20659e44f505");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,88,73,111,227,54,20,62,123,128,249,15,130,123,145,1,67,105,175,227,52,128,19,39,129,139,201,130,216,153,30,6,57,208,18,157,176,208,86,146,242,192,13,242,223,251,184,73,36,45,89,74,27,20,104,46,17,201,183,124,124,27,223,115,142,50,204,74,20,227,96,141,41,69,172,216,242,232,162,200,183,228,185,162,136,147,34,255,252,233,245,243,167,81,197,72,254,236,144,80,28,45,206,103,245,209,106,207,56,206,96,63,77,113,44,248,88,116,141,115,76,73,60,235,96,247,121,97,13,59,63,81,252,12,220,193,69,138,24,251,18,0,20,78,81,204,191,17,134,110,11,78,182,36,150,168,238,105,177,35,9,166,146,167,172,54,41,137,131,88,176,244,114,4,95,130,115,196,112,215,241,52,88,218,219,32,253,85,234,104,128,193,213,56,202,57,128,187,167,100,135,56,86,231,165,90,4,177,56,15,24,167,226,102,54,152,85,252,130,51,116,11,246,14,126,13,198,246,201,120,54,72,192,13,2,51,81,176,112,149,229,190,152,101,50,64,72,59,130,1,140,112,209,12,209,253,130,176,50,69,123,23,193,109,149,109,48,85,66,164,157,112,158,40,83,181,216,141,86,49,47,168,48,157,116,153,182,156,114,95,159,227,194,5,145,129,5,64,78,21,190,105,80,108,254,128,104,59,11,74,68,1,14,88,135,77,192,191,27,240,111,104,111,137,8,30,189,189,79,219,35,19,182,206,115,21,205,65,229,44,39,66,210,72,107,242,142,28,109,93,214,0,53,37,166,156,224,118,91,20,59,72,21,128,97,28,33,141,45,229,142,158,49,215,95,35,138,121,69,243,22,247,74,103,8,8,254,173,125,185,226,246,189,114,221,224,29,44,123,77,120,138,85,172,244,170,232,10,176,119,93,196,206,143,65,151,242,19,234,80,91,151,251,110,48,127,41,146,174,18,160,49,93,99,190,128,101,168,151,9,124,115,146,97,29,32,35,178,13,194,149,60,138,150,236,182,74,211,59,122,153,149,124,31,214,132,19,15,187,18,20,73,42,11,235,104,135,168,148,126,131,98,90,48,72,74,55,118,161,16,243,175,69,140,82,242,23,218,164,88,233,12,199,125,25,48,14,166,227,69,45,117,60,153,213,186,40,102,85,202,65,15,136,0,63,240,104,93,8,194,53,96,110,192,43,114,141,92,113,0,157,86,222,160,85,116,111,93,6,60,47,146,125,91,226,171,255,103,65,82,31,41,55,126,67,105,133,77,198,75,176,27,144,240,97,38,153,6,99,129,104,141,51,136,83,142,109,163,228,178,14,130,166,118,72,223,199,50,31,198,79,51,199,101,194,102,71,120,132,89,109,22,20,199,69,149,243,35,28,115,69,97,51,65,73,231,112,169,35,76,23,138,194,7,7,28,38,134,13,214,201,1,22,205,171,76,8,28,58,72,175,10,154,33,30,142,95,127,126,155,6,175,191,188,129,233,52,195,212,0,210,178,58,243,64,211,55,105,208,161,81,139,179,51,162,83,166,81,221,39,83,111,219,50,117,32,185,247,19,155,83,237,251,169,52,218,180,213,48,110,58,8,174,217,251,202,76,193,33,114,113,98,242,68,47,155,58,184,194,162,239,146,41,3,111,146,90,133,230,150,90,109,142,127,104,58,239,117,83,207,217,40,186,162,69,22,182,151,125,47,79,15,244,239,10,146,4,243,36,81,129,197,66,141,135,201,127,6,199,117,5,68,108,207,150,25,122,214,209,101,167,153,220,238,208,47,140,156,166,218,140,74,170,6,173,52,118,178,141,161,53,154,68,115,22,202,143,129,60,119,178,175,32,59,172,89,173,245,64,9,43,142,120,197,106,221,205,114,40,106,118,129,242,24,238,89,163,183,54,6,202,16,27,119,63,160,9,111,96,236,217,60,201,72,254,152,19,222,6,70,252,139,238,77,231,20,30,118,22,19,37,199,85,213,5,200,1,163,251,68,197,175,106,225,16,182,26,186,188,140,116,67,183,21,125,15,80,89,188,180,0,245,233,50,214,229,82,0,148,55,145,164,102,215,167,54,117,210,165,54,187,255,216,154,199,44,233,201,48,201,163,57,229,183,176,199,144,236,252,173,32,249,90,60,119,29,217,233,100,213,18,106,3,21,28,109,176,163,187,99,222,90,178,203,63,43,148,118,198,229,177,22,204,220,255,43,222,242,187,138,107,8,141,67,132,102,219,105,173,10,29,72,154,216,10,26,79,118,237,62,41,219,114,113,191,108,77,60,212,1,178,60,230,9,145,227,113,119,133,252,254,20,108,73,142,210,116,175,170,6,22,45,157,93,39,31,57,73,137,152,29,68,27,115,165,72,165,145,53,185,95,221,237,162,25,253,254,130,105,119,145,181,235,22,168,12,193,0,135,81,200,66,15,223,196,152,118,158,39,3,75,90,99,87,47,194,183,40,101,16,222,3,237,57,151,85,89,220,247,138,164,130,189,205,170,221,98,156,89,127,153,111,11,241,36,61,224,184,160,137,127,242,239,186,80,46,10,222,71,182,161,178,130,250,125,168,124,95,137,170,9,205,78,180,166,123,176,47,76,170,93,253,159,41,35,79,48,81,87,220,72,112,123,22,209,60,28,88,75,55,81,107,125,59,121,203,169,218,59,87,237,146,233,225,59,76,164,137,53,0,160,215,186,245,254,101,14,34,247,242,64,232,23,183,233,188,132,243,64,60,77,28,9,206,47,31,199,4,88,165,248,73,75,184,193,140,25,116,189,32,108,213,246,99,59,132,215,123,156,107,57,215,180,168,74,141,93,126,171,166,244,125,13,164,245,27,195,201,201,73,112,202,170,76,76,220,103,102,227,65,122,153,5,185,229,226,168,166,62,241,201,79,85,84,176,51,59,36,162,211,19,179,109,141,234,203,75,104,143,49,21,1,126,122,144,111,103,126,15,200,252,166,213,63,23,92,64,228,212,135,246,223,4,234,84,126,144,211,231,135,140,145,61,225,60,251,143,19,94,14,158,182,73,147,35,241,45,98,170,97,195,77,106,13,203,168,134,149,13,201,38,59,147,26,86,82,39,122,111,45,106,152,202,162,172,74,157,65,247,226,27,90,57,84,199,201,177,234,35,199,179,193,37,198,152,164,187,116,52,55,183,114,80,217,4,83,34,220,138,239,53,88,9,58,90,153,237,208,173,166,238,20,201,181,91,167,158,51,167,158,216,163,81,47,159,196,21,230,102,2,251,74,24,63,53,1,30,171,77,99,51,189,140,224,5,85,115,209,236,112,91,247,232,45,39,11,43,2,157,131,186,77,107,57,171,219,172,150,51,183,183,111,33,176,59,228,150,227,246,54,216,179,79,51,33,75,199,66,251,228,77,201,117,86,212,71,58,230,218,103,230,104,1,6,38,185,16,160,32,205,203,18,90,34,73,107,124,224,138,211,116,15,24,156,29,235,159,70,61,18,72,116,105,93,209,37,203,198,104,85,84,180,166,237,155,115,134,41,104,218,231,54,29,135,35,209,48,169,77,227,220,42,245,96,116,26,38,181,121,147,215,251,82,184,248,29,134,209,28,239,208,36,56,36,186,35,151,16,106,4,221,193,77,92,137,253,191,165,216,241,34,38,145,142,104,241,196,54,115,153,139,166,153,94,108,128,253,35,140,49,146,212,245,63,29,187,108,75,170,49,160,195,150,186,248,186,103,71,250,40,181,107,111,202,29,248,251,27,234,198,122,160,55,29,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateTitleTemplateLocalizableString());
			LocalizableStrings.Add(CreateBodyTemplateLocalizableString());
			LocalizableStrings.Add(CreateDateMacrosLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateTitleTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2e5be659-37d8-4f91-a21c-c576c5bc1faa"),
				Name = "TitleTemplate",
				CreatedInPackageId = new Guid("e41d942b-483e-4e7e-a5b7-2e909b02075f"),
				CreatedInSchemaUId = new Guid("817a7ad5-b3e2-43e0-9db3-0b8376b57e54"),
				ModifiedInSchemaUId = new Guid("817a7ad5-b3e2-43e0-9db3-0b8376b57e54")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBodyTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f7a73bbe-3b62-451c-851b-7295900f0ef2"),
				Name = "BodyTemplate",
				CreatedInPackageId = new Guid("e41d942b-483e-4e7e-a5b7-2e909b02075f"),
				CreatedInSchemaUId = new Guid("817a7ad5-b3e2-43e0-9db3-0b8376b57e54"),
				ModifiedInSchemaUId = new Guid("817a7ad5-b3e2-43e0-9db3-0b8376b57e54")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDateMacrosLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("43f62c11-f604-4b44-8370-b662b18d69af"),
				Name = "DateMacros",
				CreatedInPackageId = new Guid("bbde7dd6-3050-4dbf-a52a-de1e7d1f8df9"),
				CreatedInSchemaUId = new Guid("817a7ad5-b3e2-43e0-9db3-0b8376b57e54"),
				ModifiedInSchemaUId = new Guid("817a7ad5-b3e2-43e0-9db3-0b8376b57e54")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("817a7ad5-b3e2-43e0-9db3-0b8376b57e54"));
		}

		#endregion

	}

	#endregion

}
