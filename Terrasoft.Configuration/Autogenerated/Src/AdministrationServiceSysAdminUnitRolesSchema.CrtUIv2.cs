﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AdministrationServiceSysAdminUnitRolesSchema

	/// <exclude/>
	public class AdministrationServiceSysAdminUnitRolesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AdministrationServiceSysAdminUnitRolesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AdministrationServiceSysAdminUnitRolesSchema(AdministrationServiceSysAdminUnitRolesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8aa473a9-282d-4a85-9bae-802f90a90bf3");
			Name = "AdministrationServiceSysAdminUnitRoles";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c47285fc-98fc-4d2e-95fd-3ce0c28c87e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,26,93,115,219,54,242,217,153,201,127,64,233,153,14,53,195,163,211,222,180,15,182,229,142,45,201,29,245,154,216,103,57,245,67,38,15,52,9,203,168,41,82,1,65,53,186,212,255,253,22,95,36,0,66,18,213,75,63,230,238,252,96,147,139,197,238,98,191,23,116,145,44,112,181,76,82,140,110,49,165,73,85,62,176,120,84,22,15,100,94,211,132,145,178,120,249,226,211,203,23,7,117,69,138,57,154,173,43,134,23,39,206,59,224,231,57,78,57,114,197,247,166,53,165,184,96,91,209,190,199,5,166,36,237,224,140,19,150,120,129,241,236,67,62,202,137,143,238,12,3,71,194,214,158,5,186,34,41,126,93,102,56,223,186,24,223,225,251,22,193,84,196,98,81,22,155,87,226,31,170,77,203,20,111,130,199,227,139,141,75,147,130,17,70,112,5,8,128,114,72,241,28,180,133,70,121,82,85,199,232,60,91,144,130,84,76,218,69,201,47,16,151,245,125,78,82,180,76,40,35,73,142,82,142,191,9,253,224,147,216,210,18,7,115,176,164,96,192,224,90,144,145,203,138,100,202,87,17,41,24,186,172,11,97,187,36,191,41,115,124,187,94,226,159,146,188,198,104,136,190,61,17,244,112,145,109,39,169,57,94,18,156,103,124,141,146,85,194,176,226,39,95,16,108,100,192,183,117,163,49,145,108,233,250,20,196,136,0,129,130,226,206,208,40,73,31,57,247,2,255,178,27,59,28,156,40,25,90,41,189,98,104,25,175,105,185,196,148,155,194,64,48,165,228,100,61,58,153,102,136,135,203,193,193,28,51,244,9,137,199,3,138,89,77,11,244,61,102,18,229,98,45,84,23,110,80,233,64,232,243,224,153,255,126,238,136,237,149,204,20,253,53,102,143,101,102,203,125,116,116,132,78,171,122,177,0,197,156,105,192,97,243,131,58,15,205,59,242,189,106,96,67,250,200,165,125,10,190,152,44,80,1,217,101,24,164,101,94,47,138,224,204,98,98,241,68,214,146,253,24,159,30,9,98,126,218,43,174,177,134,244,206,173,210,20,149,141,111,239,208,40,30,175,44,239,127,134,4,198,13,57,18,71,146,102,20,65,187,158,129,59,46,18,9,71,242,196,145,222,32,132,28,40,207,32,15,40,148,235,34,177,9,26,220,246,136,84,8,0,248,150,44,176,181,160,55,106,63,226,139,28,254,150,145,92,100,139,88,160,158,87,28,120,170,73,156,133,43,215,153,182,178,254,177,44,159,234,165,205,216,230,59,19,78,31,79,171,55,117,158,95,209,201,98,201,214,97,40,67,97,160,142,248,29,42,96,17,29,203,35,155,188,21,145,22,46,192,187,157,211,243,212,122,101,220,211,3,41,196,151,52,83,235,42,17,114,220,206,116,245,78,68,108,247,66,254,91,168,237,58,33,84,176,64,59,72,104,207,90,149,36,67,51,204,120,6,232,58,21,106,5,143,208,63,240,186,225,113,42,213,174,61,236,12,89,18,104,143,217,232,153,144,55,91,202,177,68,136,37,6,175,205,236,98,253,6,232,133,22,209,24,248,43,111,82,110,157,182,242,2,65,39,42,116,8,216,52,204,4,103,74,224,219,27,27,32,46,78,100,50,28,156,24,233,113,63,15,66,141,15,25,22,255,189,60,9,245,113,31,227,92,149,145,203,58,30,180,217,25,189,121,13,41,92,95,70,83,38,28,61,38,197,92,29,232,188,200,102,201,202,235,122,70,89,117,29,207,148,93,251,221,219,10,83,168,201,133,236,246,160,225,209,45,218,164,152,147,2,199,163,71,156,62,141,146,98,242,17,224,12,95,65,65,19,77,74,24,0,240,117,82,36,115,108,119,47,129,114,25,147,89,124,89,210,9,52,1,225,211,106,137,134,103,190,32,50,143,0,88,3,143,227,241,3,107,176,204,80,198,170,227,210,193,52,11,246,244,59,100,152,205,46,174,125,29,142,255,86,25,229,112,83,177,244,51,216,230,36,46,177,206,86,127,21,20,93,15,215,202,35,193,15,92,219,34,77,40,95,226,146,106,15,176,75,6,239,207,18,38,210,73,36,75,10,239,218,126,44,211,36,39,255,74,238,115,44,241,66,199,111,238,74,250,36,102,147,248,6,87,101,77,83,192,43,41,56,71,132,2,111,119,11,173,189,128,191,45,136,240,133,42,80,236,14,130,14,51,24,85,248,33,198,248,33,169,115,198,207,113,93,86,236,129,124,148,57,42,24,244,183,180,173,60,173,90,67,187,125,109,205,160,232,170,248,215,177,251,159,198,121,107,51,187,247,228,45,61,51,154,11,133,71,113,5,218,56,105,186,133,47,68,155,29,223,210,53,80,144,59,249,46,8,255,154,41,228,65,211,159,172,18,138,42,204,103,60,40,7,225,76,60,13,184,165,229,163,99,222,65,124,91,46,195,175,6,202,66,42,219,203,32,211,176,75,90,46,194,192,52,43,63,69,187,126,247,136,41,196,165,178,24,180,38,147,15,117,146,135,146,84,124,205,117,135,25,166,66,102,29,253,106,242,10,199,23,50,253,148,20,101,247,205,227,16,57,78,56,41,170,154,226,241,69,11,10,219,19,107,90,83,222,55,221,224,36,195,64,172,125,28,42,117,196,42,209,73,112,216,178,51,40,9,117,183,123,99,254,199,228,196,99,138,171,27,136,26,88,118,134,58,213,227,78,155,169,196,143,52,34,224,94,209,243,44,83,22,84,214,107,176,158,213,131,250,251,220,237,221,12,231,216,163,240,90,239,123,6,132,213,217,3,39,140,81,74,241,195,48,24,223,55,69,99,242,49,197,75,81,36,142,206,162,238,0,227,29,42,250,14,6,91,78,176,43,220,26,177,94,227,170,130,156,21,250,68,70,77,252,205,62,228,45,148,128,171,209,246,117,136,112,60,181,65,73,133,204,29,109,192,134,206,222,47,134,178,35,255,242,75,135,106,252,166,94,220,115,31,29,162,175,191,125,165,195,240,215,95,59,188,98,117,128,120,198,18,202,170,59,194,30,195,224,234,230,252,111,175,224,231,171,96,128,250,238,249,250,239,223,188,250,38,24,184,227,140,191,20,40,103,236,93,17,116,158,255,28,117,33,41,138,146,141,235,101,78,160,106,117,54,243,82,161,107,132,103,192,249,203,29,199,240,58,145,132,50,110,141,9,165,37,181,79,97,204,100,187,67,59,178,131,170,45,133,63,253,98,74,215,92,24,76,179,206,64,100,197,170,175,19,111,226,215,205,255,200,45,185,242,53,50,224,158,146,44,31,186,163,94,239,100,244,231,117,233,188,75,189,105,218,210,112,207,110,92,17,129,72,156,203,22,249,164,51,28,34,108,190,120,106,96,187,42,219,115,81,121,166,226,154,47,197,106,90,12,108,219,107,191,234,140,19,60,159,25,4,227,17,197,112,86,117,54,167,71,48,58,17,163,47,191,196,44,125,228,189,193,248,34,52,79,252,142,215,189,247,70,134,177,38,76,104,245,140,90,89,133,86,244,182,218,1,241,124,83,145,57,75,88,90,182,134,7,71,201,123,223,113,88,3,195,158,254,73,50,255,61,88,228,12,13,123,207,13,155,199,145,207,64,124,115,76,244,154,73,140,8,17,253,124,101,196,137,42,198,36,211,247,192,214,136,242,187,13,169,127,112,96,165,122,22,251,173,209,229,16,216,18,42,30,76,107,62,230,210,6,81,119,64,20,106,239,73,3,154,118,144,159,35,64,44,71,96,188,158,251,220,34,33,118,119,198,30,62,247,12,58,223,99,98,119,115,172,140,177,81,232,238,181,129,139,178,235,238,192,184,210,239,222,216,251,239,243,141,111,41,251,229,147,184,19,79,157,158,184,189,20,179,6,88,79,8,31,70,45,63,187,154,34,111,220,182,48,99,33,234,108,118,178,71,239,172,247,115,85,22,87,34,9,4,27,110,245,61,253,191,98,237,6,214,190,223,11,34,15,233,67,84,213,105,10,237,175,51,139,160,118,131,166,174,16,33,98,25,173,177,145,73,45,242,6,218,67,146,87,216,73,132,239,154,196,4,129,13,153,40,101,239,5,248,14,223,79,139,85,249,132,67,233,64,176,61,184,190,154,221,66,84,188,165,228,22,47,150,57,207,159,0,213,221,5,172,92,148,217,122,198,214,162,8,2,1,213,197,55,208,248,142,38,203,37,206,100,187,121,131,63,64,110,96,151,37,93,36,204,218,32,65,226,235,104,132,160,181,93,150,69,133,183,227,13,132,212,234,171,163,202,214,90,48,157,200,91,83,59,173,141,28,76,35,100,21,113,62,246,156,152,119,27,216,153,200,248,120,46,239,167,196,167,12,137,219,179,183,130,189,92,234,120,140,33,163,18,222,114,227,211,205,91,207,66,67,116,201,135,209,181,238,82,44,169,157,86,207,211,105,60,35,152,74,210,71,180,99,160,60,240,28,215,55,150,98,151,108,83,6,251,209,196,122,214,211,100,30,72,145,228,121,115,58,222,187,25,39,84,243,104,123,175,209,220,106,240,193,169,185,236,112,66,67,131,169,40,11,28,218,80,212,183,22,234,30,227,25,97,136,145,222,212,69,68,53,228,23,237,169,156,131,186,92,186,115,223,76,251,65,216,120,35,253,141,159,41,60,105,244,127,176,7,252,47,204,178,109,135,250,151,204,181,173,120,59,90,231,207,159,118,183,165,195,78,95,207,165,18,226,252,17,9,241,255,249,112,159,124,184,71,70,220,61,24,251,226,94,189,57,41,102,159,175,183,83,111,138,236,147,148,118,9,241,185,83,6,120,39,31,216,170,81,89,23,12,150,133,114,251,166,13,212,51,101,168,244,178,119,222,224,31,144,44,1,117,206,144,58,214,14,205,191,9,153,243,232,63,107,76,215,202,255,38,46,220,253,0,232,25,143,35,20,108,158,133,13,82,205,191,59,128,100,35,253,63,15,29,65,226,243,44,51,191,59,233,175,204,205,166,120,38,221,73,92,59,14,209,249,124,14,83,153,48,170,24,19,197,193,229,166,46,237,75,146,51,80,14,231,17,118,87,229,92,46,113,248,141,108,243,177,170,10,37,112,84,46,192,35,73,165,88,137,47,91,202,92,7,193,59,80,2,87,214,180,224,49,127,172,222,142,167,217,251,248,157,169,31,128,240,69,142,244,62,22,35,177,50,207,224,207,144,218,29,179,229,253,115,212,253,7,201,238,64,206,143,55,176,47,62,84,164,123,237,10,158,169,44,183,237,230,67,37,170,80,83,106,146,241,119,154,120,172,110,16,50,243,43,27,184,254,89,104,58,201,27,81,27,143,209,171,157,3,126,59,194,75,44,243,191,38,119,252,151,167,216,240,242,5,255,249,55,123,226,15,160,181,43,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateChiefDefaultNamePostfixLocalizableString());
			LocalizableStrings.Add(CreateCannotDuplicateSysAdminUnitRoleNameLocalizableString());
			LocalizableStrings.Add(CreateOperationExecutedWithErrorLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateChiefDefaultNamePostfixLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d17523cc-d6ef-4db5-bafd-4ef2a32a0482"),
				Name = "ChiefDefaultNamePostfix",
				CreatedInPackageId = new Guid("c47285fc-98fc-4d2e-95fd-3ce0c28c87e8"),
				CreatedInSchemaUId = new Guid("8aa473a9-282d-4a85-9bae-802f90a90bf3"),
				ModifiedInSchemaUId = new Guid("8aa473a9-282d-4a85-9bae-802f90a90bf3")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCannotDuplicateSysAdminUnitRoleNameLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2c87cce2-e317-449f-a717-b927f6641011"),
				Name = "CannotDuplicateSysAdminUnitRoleName",
				CreatedInPackageId = new Guid("f8ee2cfe-a059-4eed-92fa-2b7fd54ad54c"),
				CreatedInSchemaUId = new Guid("8aa473a9-282d-4a85-9bae-802f90a90bf3"),
				ModifiedInSchemaUId = new Guid("8aa473a9-282d-4a85-9bae-802f90a90bf3")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOperationExecutedWithErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c65c134c-f234-40e0-8cd2-519f6421b7e5"),
				Name = "OperationExecutedWithError",
				CreatedInPackageId = new Guid("f8ee2cfe-a059-4eed-92fa-2b7fd54ad54c"),
				CreatedInSchemaUId = new Guid("8aa473a9-282d-4a85-9bae-802f90a90bf3"),
				ModifiedInSchemaUId = new Guid("8aa473a9-282d-4a85-9bae-802f90a90bf3")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8aa473a9-282d-4a85-9bae-802f90a90bf3"));
		}

		#endregion

	}

	#endregion

}

