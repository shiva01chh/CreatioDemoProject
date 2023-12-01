﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UserManagementServiceSchema

	/// <exclude/>
	public class UserManagementServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UserManagementServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UserManagementServiceSchema(UserManagementServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("add50ccf-eb8b-4b16-9654-d1e4927cb2e7");
			Name = "UserManagementService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("39b1aa09-c30c-47e9-9379-18a9c48e3a0f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,90,91,111,219,54,20,126,118,129,253,7,78,5,6,25,48,212,237,181,174,83,56,110,146,121,72,154,160,110,218,135,98,24,104,233,56,209,170,139,71,82,110,189,33,255,125,135,55,153,146,41,95,182,100,232,58,160,147,168,195,195,115,190,115,225,71,186,5,205,129,47,105,12,228,61,48,70,121,185,16,209,164,44,22,233,93,197,168,72,203,34,186,229,192,174,104,65,239,32,135,66,204,128,173,210,24,190,123,246,215,119,207,122,21,79,139,59,50,91,115,1,249,176,245,30,93,100,229,156,102,233,159,74,203,214,215,25,196,21,75,197,218,243,65,45,112,85,38,144,237,252,24,141,99,145,174,186,180,59,114,31,97,190,17,112,189,204,115,119,106,151,255,239,224,46,229,66,191,252,12,217,18,152,127,14,131,174,241,232,205,105,231,167,179,175,2,88,65,51,137,50,239,150,42,68,42,82,232,22,56,167,177,40,89,135,4,2,176,195,91,249,245,103,33,150,209,120,46,221,140,165,159,142,154,183,240,69,224,128,148,252,133,43,13,242,191,222,115,134,176,148,5,153,100,148,243,151,196,155,36,239,203,207,80,40,233,101,53,207,210,152,196,82,120,167,108,239,47,37,95,171,191,97,37,2,46,93,127,73,110,148,18,253,221,40,68,131,165,141,231,41,227,226,45,102,50,145,89,217,235,221,129,24,170,7,110,30,30,124,179,102,21,2,127,228,156,113,146,164,18,32,154,29,189,220,89,78,211,236,168,25,55,136,214,151,146,37,71,77,250,88,178,207,170,160,79,41,135,91,182,111,197,231,80,36,26,107,245,174,71,91,131,173,88,191,131,184,92,1,91,91,243,58,194,220,33,246,207,34,172,192,187,102,151,229,93,90,60,190,71,29,45,14,5,63,153,23,108,9,170,54,126,149,99,99,190,124,11,2,43,106,137,77,97,158,102,216,198,222,193,31,85,202,212,116,30,186,47,178,5,145,17,217,51,69,74,69,102,32,233,255,122,80,197,144,151,68,134,216,190,181,96,69,131,17,186,74,118,5,63,176,94,157,97,223,128,123,1,5,48,154,189,3,94,86,44,134,25,170,65,73,236,171,98,82,49,148,159,84,153,192,135,240,134,193,2,59,9,36,82,157,25,236,239,136,134,63,236,76,246,113,48,230,233,23,98,148,77,139,69,73,126,91,122,150,25,106,249,23,47,94,144,87,188,202,115,202,214,39,118,160,54,139,84,56,129,196,122,6,89,176,50,39,178,215,145,24,227,9,95,69,84,107,120,225,170,240,217,224,243,116,147,137,100,116,226,183,146,188,126,173,100,122,132,144,208,47,49,210,2,82,194,12,221,10,153,33,136,77,116,1,2,209,41,229,78,57,209,38,91,228,165,27,102,40,194,152,200,160,168,12,2,46,212,150,125,73,139,187,10,99,198,7,70,189,212,223,17,214,55,176,176,177,235,215,53,213,237,210,136,172,104,86,65,163,7,25,196,166,82,110,6,156,99,140,117,118,49,242,91,181,53,54,220,55,199,51,212,196,122,91,103,19,105,207,247,145,46,119,189,85,174,37,180,175,60,75,159,132,109,12,188,170,182,16,232,74,244,43,16,247,101,210,149,229,243,178,204,200,148,159,125,69,138,129,125,14,233,203,56,201,211,226,182,72,69,120,81,165,137,74,84,52,120,154,216,202,92,81,70,56,100,16,163,113,164,128,47,100,166,94,66,21,160,178,40,64,109,224,125,13,5,110,251,89,149,23,225,121,85,196,248,92,21,34,212,35,145,234,15,225,79,253,190,149,60,199,218,8,3,215,128,192,126,250,120,15,152,112,193,196,154,82,127,64,195,255,168,104,214,212,185,177,184,79,40,55,230,105,68,25,96,254,20,198,124,164,62,200,1,5,204,98,154,81,246,42,45,4,66,79,78,200,143,190,188,82,88,96,196,44,80,181,45,161,217,32,64,110,16,255,10,163,192,113,76,131,97,22,105,227,160,246,162,221,24,104,107,142,242,95,122,136,0,88,231,123,61,215,253,85,137,238,35,247,152,242,241,29,3,72,140,201,138,22,174,109,142,88,239,85,78,197,247,16,127,70,146,151,243,113,129,226,133,166,45,28,27,184,132,143,127,144,233,139,224,104,39,20,133,108,178,94,76,4,43,43,43,69,201,191,146,154,79,108,128,163,38,154,3,18,76,252,107,6,3,178,160,25,55,251,66,47,93,144,240,16,235,172,59,58,154,56,35,167,104,176,93,124,166,6,134,27,137,88,65,162,88,217,136,4,22,168,192,72,104,164,244,36,13,158,153,128,194,90,183,73,3,30,157,167,69,114,186,150,138,194,141,78,99,187,54,222,76,196,212,170,178,58,231,122,189,182,66,140,151,77,173,83,4,14,104,129,72,108,171,52,243,48,145,62,164,76,96,42,161,6,220,185,193,124,126,208,255,171,253,150,44,66,202,43,140,28,11,7,106,146,81,250,208,85,66,19,6,248,108,18,59,236,102,226,68,200,191,173,111,205,72,19,174,14,89,173,193,17,105,14,68,227,229,210,121,155,121,230,12,235,98,53,222,153,106,237,58,137,89,179,125,235,27,199,29,152,228,166,182,65,138,135,109,9,195,254,71,218,85,251,222,20,186,72,87,96,115,74,139,213,71,141,166,224,85,154,36,25,52,36,155,71,133,166,184,62,11,88,73,245,214,20,80,142,179,28,9,204,72,23,143,254,188,221,2,108,237,183,156,163,43,8,221,162,51,157,199,126,159,38,199,109,93,14,125,252,116,141,188,77,197,195,229,196,189,79,120,140,156,22,43,244,39,212,211,100,21,222,92,207,222,99,206,223,178,244,61,228,203,76,102,33,142,234,3,53,48,252,114,90,38,235,153,88,103,114,28,21,92,225,46,139,201,88,143,70,167,148,129,230,47,134,218,156,151,44,167,162,33,173,135,212,225,116,128,135,14,190,196,70,2,187,229,20,195,110,157,48,172,85,7,23,69,57,255,93,110,48,26,217,107,245,50,220,244,223,148,143,87,24,85,58,207,224,166,100,130,102,184,15,44,220,171,4,180,77,223,144,96,157,212,157,118,118,95,126,241,139,95,166,197,231,77,255,252,126,175,250,186,45,185,246,153,250,178,13,11,193,66,70,55,209,39,148,224,140,177,18,99,210,248,102,160,51,243,46,203,88,93,232,224,162,51,5,90,107,67,141,234,179,103,212,98,152,53,7,13,188,232,98,38,4,91,202,121,212,246,255,109,137,19,144,230,170,130,182,27,240,195,208,245,147,200,240,162,69,120,240,148,77,128,165,82,39,104,239,67,23,10,183,81,246,92,14,225,171,74,217,162,212,199,55,37,254,45,27,74,154,80,244,204,75,41,221,27,157,51,207,36,187,201,235,64,250,212,202,173,64,62,59,179,49,121,93,189,53,193,248,47,130,28,52,239,154,100,176,206,190,198,176,84,33,119,108,156,114,212,135,83,98,1,201,117,161,142,234,143,25,36,103,159,152,202,238,226,101,131,26,23,7,223,122,134,36,106,249,82,172,145,99,254,240,67,23,229,118,185,235,209,208,122,20,126,83,229,228,51,208,91,75,15,4,112,231,176,110,10,182,174,61,214,244,103,11,209,13,7,234,185,17,106,146,13,221,60,45,233,49,180,198,150,222,210,94,117,217,234,179,183,70,86,254,73,41,8,238,5,102,185,200,20,33,216,245,189,100,99,64,220,60,171,157,96,173,126,37,111,223,70,68,21,194,230,68,175,65,105,183,182,142,101,106,52,235,136,91,67,7,6,167,246,117,95,109,147,12,149,79,169,108,82,83,126,142,70,224,81,254,172,144,9,146,132,193,21,102,39,110,39,250,202,192,53,206,28,118,156,8,111,223,135,99,13,23,201,214,164,131,93,234,121,112,27,144,131,239,55,54,41,213,72,219,78,67,15,51,206,23,204,173,228,221,209,27,90,205,97,86,197,49,22,127,96,21,88,114,79,98,42,226,123,18,218,159,67,234,198,74,54,231,159,35,150,105,182,247,173,174,3,145,121,238,48,227,209,23,124,164,54,247,4,180,97,227,187,179,197,252,163,237,233,225,241,120,49,54,229,196,54,158,111,141,29,187,182,133,222,187,253,38,61,118,57,149,189,184,111,80,43,51,56,116,165,231,216,196,176,105,227,194,10,73,221,64,209,200,230,133,40,149,205,160,41,182,235,58,212,148,237,147,238,32,109,64,212,149,49,243,13,154,219,222,214,174,128,110,181,85,216,96,189,161,130,238,218,133,12,142,3,15,120,198,243,206,147,138,220,35,252,70,182,238,54,254,215,135,136,166,127,251,14,18,205,93,164,11,161,154,159,76,238,113,31,82,191,179,109,221,7,61,90,23,245,26,208,213,201,27,123,160,203,221,108,141,241,202,201,0,167,244,176,173,212,99,79,70,30,20,139,23,155,166,231,217,163,113,9,219,21,79,215,206,207,14,254,26,168,21,247,142,255,65,196,75,17,60,149,168,220,176,54,77,253,148,176,95,147,3,68,180,178,49,183,158,42,167,214,75,123,107,163,111,83,53,240,39,33,146,3,37,31,56,42,100,52,14,158,47,119,132,122,95,195,63,232,54,206,138,33,12,158,91,87,12,131,121,30,12,252,217,180,149,206,27,91,218,180,202,113,111,239,121,17,91,55,118,164,232,178,164,137,186,239,9,218,208,94,33,178,221,238,107,15,35,189,55,133,27,7,31,103,93,13,155,147,13,71,35,179,151,18,111,183,158,61,89,236,53,65,229,223,56,73,24,150,252,192,214,239,64,85,236,198,152,93,221,102,55,25,173,155,199,129,116,244,152,165,90,157,109,47,35,221,182,229,41,86,125,44,90,250,68,59,145,139,194,183,70,82,145,107,148,149,248,182,200,169,182,41,116,127,173,104,254,94,27,89,137,78,62,212,76,168,29,229,242,48,252,215,65,56,224,31,168,224,216,179,103,127,3,116,248,3,33,155,39,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateExistingSysAdminUnitLocalizableString());
			LocalizableStrings.Add(CreateRegistrationLinkNotSentLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateExistingSysAdminUnitLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("102df690-54a4-46b8-9589-daab69db523e"),
				Name = "ExistingSysAdminUnit",
				CreatedInPackageId = new Guid("39b1aa09-c30c-47e9-9379-18a9c48e3a0f"),
				CreatedInSchemaUId = new Guid("add50ccf-eb8b-4b16-9654-d1e4927cb2e7"),
				ModifiedInSchemaUId = new Guid("add50ccf-eb8b-4b16-9654-d1e4927cb2e7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRegistrationLinkNotSentLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6214a06b-7e7f-425d-8a74-e4db6fd7fd8c"),
				Name = "RegistrationLinkNotSent",
				CreatedInPackageId = new Guid("01d541ac-6d69-4d76-b695-beccb199abd0"),
				CreatedInSchemaUId = new Guid("add50ccf-eb8b-4b16-9654-d1e4927cb2e7"),
				ModifiedInSchemaUId = new Guid("add50ccf-eb8b-4b16-9654-d1e4927cb2e7")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("add50ccf-eb8b-4b16-9654-d1e4927cb2e7"));
		}

		#endregion

	}

	#endregion

}
