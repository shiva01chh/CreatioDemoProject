﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LDAPSysSettingsServiceSchema

	/// <exclude/>
	public class LDAPSysSettingsServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LDAPSysSettingsServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LDAPSysSettingsServiceSchema(LDAPSysSettingsServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("35a72c4e-86d2-429c-b5d6-e99674ffe850");
			Name = "LDAPSysSettingsService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f397f2af-3c2b-4e84-b720-c5ecf5003a68");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,27,217,114,219,56,242,89,83,53,255,128,48,85,179,212,150,66,231,152,153,108,156,216,83,182,37,103,53,235,107,108,103,252,144,74,165,40,18,182,185,225,33,131,160,39,218,172,255,125,187,113,144,0,47,201,142,147,84,214,15,17,9,116,55,186,27,125,161,137,164,126,66,243,185,31,80,114,74,25,243,243,236,156,123,59,89,122,30,93,20,204,231,81,150,122,123,227,173,163,147,69,126,66,57,143,210,11,248,101,215,81,64,127,252,225,211,143,63,12,138,28,134,8,204,114,154,188,172,189,3,153,56,166,1,210,200,189,215,52,165,44,10,26,48,123,81,122,213,24,84,75,236,103,33,141,123,39,189,45,32,127,45,216,236,135,59,163,179,10,192,20,52,73,76,84,115,134,209,174,113,111,188,221,57,117,18,92,210,176,136,41,171,32,46,226,108,230,199,235,235,114,49,111,47,187,184,128,225,118,10,134,222,151,2,136,141,233,100,100,146,242,136,71,52,239,4,216,245,3,158,177,14,8,208,87,67,57,136,181,23,250,115,178,81,39,165,24,1,200,135,140,94,0,107,100,39,246,243,124,157,116,153,14,64,174,173,173,145,87,121,145,36,62,91,108,170,247,135,248,39,255,21,191,164,254,100,62,32,109,82,189,27,79,15,53,249,53,131,254,91,181,56,168,144,51,16,253,29,142,109,229,243,3,202,65,208,57,104,116,22,197,17,95,28,211,171,34,98,52,161,41,207,93,243,5,13,9,68,95,130,130,80,158,26,8,135,184,200,188,152,197,81,64,2,212,72,135,66,200,58,217,246,115,90,170,103,128,174,85,233,18,252,135,251,64,123,157,28,49,180,118,169,192,134,6,181,10,219,84,210,212,159,122,19,28,121,37,57,83,99,131,185,92,141,4,200,0,201,57,67,43,64,11,56,89,164,193,52,229,192,174,31,27,210,236,72,13,57,82,200,52,184,212,48,142,52,142,193,67,154,134,82,40,245,174,36,220,141,104,28,214,197,211,171,131,236,28,244,199,168,31,102,105,188,32,217,236,223,16,84,200,251,56,11,62,28,202,231,13,146,210,191,212,132,59,124,105,98,151,104,83,212,46,101,211,244,60,59,98,217,117,20,82,70,222,231,141,177,14,100,112,90,92,241,162,125,122,47,202,249,171,215,69,20,110,2,80,148,22,31,79,138,249,60,99,156,134,91,5,191,60,93,204,233,52,204,151,232,64,236,50,43,208,39,81,19,194,104,148,34,164,1,181,155,142,59,68,16,97,47,131,22,113,64,53,194,21,165,179,47,32,12,243,87,45,154,216,84,90,27,160,140,128,3,226,238,251,169,127,65,25,98,96,196,162,204,21,251,234,148,128,93,114,170,221,48,116,34,185,27,224,139,119,228,179,156,186,206,147,157,221,237,127,252,178,245,236,209,139,241,211,23,143,126,254,121,119,252,232,197,228,249,179,71,147,103,91,207,199,79,199,191,62,127,246,203,115,103,72,192,36,193,49,148,240,122,13,65,237,70,176,113,131,255,172,100,89,166,62,213,246,189,1,117,129,214,83,153,162,200,251,194,122,127,105,168,190,6,185,83,48,6,190,94,27,149,82,94,80,174,229,101,148,23,172,65,151,252,246,27,113,235,99,27,4,212,108,211,219,101,89,242,79,206,231,24,175,232,71,48,107,165,120,33,242,32,175,150,105,210,2,143,43,168,1,125,211,111,121,251,148,95,102,157,238,87,147,114,57,159,138,47,37,253,155,166,82,111,250,195,87,51,76,145,182,208,133,127,29,113,75,140,200,245,243,205,135,45,148,218,72,189,90,211,24,166,244,104,179,40,51,152,45,236,56,184,223,86,152,68,233,155,52,226,211,176,20,245,218,103,196,175,198,113,55,209,212,39,201,156,47,94,150,16,137,116,40,244,200,54,251,145,9,123,129,245,67,226,43,231,171,144,175,10,202,22,202,179,76,192,63,112,220,85,164,71,196,49,57,212,174,138,248,32,15,170,7,42,178,34,73,15,160,228,3,90,130,166,183,21,134,114,212,149,239,199,89,198,37,109,116,253,163,58,30,216,161,135,191,146,180,68,217,141,98,136,243,57,146,82,68,118,32,52,114,58,205,15,138,56,150,179,174,35,85,120,156,197,212,209,182,220,143,46,199,207,34,126,9,168,176,36,2,185,114,80,164,95,22,229,89,138,1,193,155,92,21,126,92,147,30,39,254,68,71,112,70,228,241,208,80,69,80,86,165,165,14,64,80,169,212,170,98,117,91,55,73,145,137,206,137,91,145,241,182,210,5,168,69,251,163,109,9,21,216,219,199,239,112,33,228,75,105,92,176,39,99,164,219,216,32,203,221,149,51,25,164,237,240,183,186,47,149,206,212,147,247,197,200,28,117,78,82,224,100,195,1,61,176,197,52,116,54,79,166,99,11,255,213,154,0,91,205,235,52,74,159,159,97,117,241,154,101,197,28,220,75,21,28,106,113,211,217,226,10,170,197,217,112,119,36,174,39,45,240,144,137,89,87,83,26,214,34,180,65,206,84,250,87,115,90,212,203,36,22,245,227,55,247,217,219,59,157,224,94,25,200,168,220,173,123,246,240,131,140,235,245,240,221,25,201,13,116,163,148,15,213,145,204,171,123,191,135,123,245,53,61,223,54,203,123,245,252,186,137,174,146,67,77,199,55,6,87,40,248,175,51,240,198,105,10,10,224,134,109,10,166,243,50,235,181,59,196,120,251,132,6,5,3,141,78,82,56,230,82,111,231,146,6,31,118,252,116,242,17,198,57,61,156,83,121,122,117,29,24,148,46,35,118,13,202,69,57,97,186,64,41,182,85,85,150,65,162,44,91,53,44,50,211,0,197,193,18,82,30,101,221,18,129,71,113,137,160,222,197,177,185,195,10,154,123,141,216,37,37,220,102,57,170,215,27,84,106,84,19,21,166,6,25,83,95,182,49,232,152,198,224,4,97,47,244,57,152,187,31,92,86,50,136,105,18,25,70,146,151,108,182,133,75,59,202,150,147,30,120,173,90,66,152,185,133,101,70,217,138,248,0,78,134,112,24,209,197,166,182,89,169,29,189,23,150,114,246,105,50,131,225,195,115,65,185,90,163,177,178,192,246,118,178,34,229,184,250,227,21,22,173,52,45,144,43,50,35,83,3,122,165,155,70,125,124,75,103,186,131,35,169,61,173,25,177,224,78,249,88,185,115,141,93,86,0,122,159,235,240,98,163,169,8,101,218,156,43,207,237,13,105,42,52,166,97,36,58,117,10,123,28,9,24,16,232,149,204,165,35,117,190,46,143,115,131,79,245,216,111,240,5,198,68,110,70,21,160,12,218,164,63,94,159,82,168,56,212,110,222,40,230,240,148,239,26,103,253,202,14,208,82,30,72,137,189,93,202,131,75,60,137,140,183,221,74,148,161,97,52,10,16,78,207,99,122,110,4,225,202,81,77,24,3,192,93,157,247,165,148,250,212,85,34,223,16,26,231,148,160,120,138,140,204,253,27,22,130,24,251,233,39,181,229,94,73,121,124,80,135,28,167,6,220,52,23,29,83,186,130,59,117,200,128,11,215,152,55,146,214,114,209,199,7,53,236,113,186,12,87,51,13,136,156,21,205,165,252,107,234,118,187,181,229,139,125,161,182,215,45,63,169,244,239,62,168,157,183,49,170,77,243,93,40,103,10,70,39,169,63,139,105,232,58,213,58,147,143,65,92,132,176,144,142,70,78,189,254,172,215,156,57,197,186,97,47,11,252,184,204,48,18,30,29,243,68,204,118,120,180,82,140,167,170,67,203,224,212,164,135,110,226,218,53,167,154,57,187,164,76,219,251,16,76,69,84,92,174,164,229,149,21,154,187,130,35,12,137,159,43,78,141,4,109,73,84,166,104,25,94,202,4,221,144,222,83,149,195,49,245,67,88,61,244,185,47,31,201,70,25,139,12,210,162,200,172,128,112,123,204,154,75,175,102,171,70,151,92,70,57,65,63,2,115,0,106,37,121,109,14,158,218,5,170,130,50,112,66,43,79,246,78,51,148,204,44,78,146,40,207,45,98,150,124,1,157,3,45,107,193,58,17,108,204,121,99,58,43,46,118,51,150,248,220,117,62,61,190,33,23,146,94,152,165,127,227,146,99,2,197,173,108,3,122,224,46,214,178,50,155,42,122,42,191,232,67,214,133,74,244,144,93,44,28,43,189,152,105,232,91,229,24,205,232,45,210,132,107,70,155,229,153,2,89,13,69,112,208,46,59,77,101,137,165,184,22,115,253,14,104,185,153,36,81,6,26,199,0,82,30,87,206,161,45,118,59,94,45,97,84,233,166,149,93,237,55,70,130,51,9,244,4,217,115,31,18,80,7,150,25,107,117,170,248,236,82,234,51,206,38,178,212,179,107,125,203,85,71,178,183,96,86,128,102,219,78,200,188,103,192,215,61,93,110,81,196,105,130,94,142,191,85,18,173,249,104,95,205,214,92,232,255,169,114,67,246,190,215,202,77,116,9,150,81,234,42,65,62,175,210,251,34,149,214,110,17,199,45,168,122,120,25,186,104,188,164,139,26,182,26,93,134,60,73,252,40,174,161,138,177,101,136,71,151,89,90,231,88,140,45,67,252,61,155,157,70,60,174,227,234,225,123,45,75,173,216,87,70,21,17,114,241,96,173,192,172,246,219,159,213,167,24,229,232,249,21,6,129,61,59,143,54,187,131,43,183,27,85,7,174,145,100,74,230,237,5,141,222,97,137,215,13,108,54,238,234,115,61,45,60,237,28,75,251,134,98,245,145,161,198,225,55,99,69,170,205,110,21,12,205,157,179,186,135,117,14,110,219,71,20,117,137,209,72,108,109,116,224,170,133,189,175,19,51,79,244,221,11,169,217,195,18,102,6,173,203,244,199,220,78,148,134,131,201,173,181,247,249,14,100,116,133,212,218,206,233,36,116,31,5,139,85,169,144,37,55,44,122,191,74,154,95,85,130,44,164,206,102,23,145,198,167,21,19,85,124,225,117,54,155,104,29,4,172,226,9,116,107,220,35,128,13,150,58,86,39,1,228,74,87,12,242,75,178,89,47,229,21,98,139,17,66,134,181,45,209,88,103,105,91,221,32,109,85,5,14,94,43,129,77,71,198,170,186,96,213,101,149,13,75,17,91,89,24,41,145,165,172,119,249,108,110,220,45,88,181,240,53,159,90,11,227,91,93,212,105,216,7,163,87,224,172,188,180,144,150,111,129,245,139,84,230,159,101,59,111,203,150,189,121,117,106,240,246,140,206,166,233,117,246,129,186,82,19,120,243,231,232,240,228,20,182,106,59,11,23,39,124,17,227,23,43,0,219,167,121,14,169,170,28,245,206,152,63,159,211,240,88,114,57,34,234,65,158,108,45,28,57,228,253,14,17,91,214,164,199,52,159,67,129,72,251,97,197,197,43,125,123,195,178,13,117,109,70,147,177,157,65,197,184,150,10,90,181,13,136,82,172,233,18,76,147,146,254,208,183,154,14,68,80,111,152,197,255,29,46,131,168,128,86,107,69,221,223,199,23,193,23,136,163,111,112,1,83,17,150,100,226,246,142,82,194,219,37,87,193,222,105,90,10,94,29,165,172,16,178,105,70,20,239,95,116,65,30,108,44,187,98,86,29,187,116,187,11,118,126,34,154,25,54,233,174,64,103,175,56,178,88,16,32,195,59,113,190,241,245,57,55,118,104,104,238,92,174,111,161,226,133,197,249,188,188,148,138,117,74,249,114,200,128,176,95,196,28,210,43,240,253,71,225,51,254,159,114,182,180,4,11,95,63,77,147,132,134,17,164,148,35,150,5,224,126,80,111,187,206,113,33,210,239,52,193,59,97,142,170,171,240,183,54,161,132,111,47,113,207,50,246,65,220,71,22,135,157,81,199,119,119,99,84,193,41,162,165,228,235,149,18,122,37,217,143,82,240,140,120,97,10,130,91,136,117,36,50,173,198,77,113,90,167,191,136,80,166,7,254,157,252,250,120,180,92,202,27,18,248,28,155,16,178,173,136,1,133,26,13,103,25,136,188,106,18,106,217,150,239,205,26,240,246,23,182,86,204,48,223,36,145,205,242,76,244,238,156,231,222,147,167,222,83,242,95,149,196,73,148,67,197,35,39,137,159,134,228,175,40,142,201,12,111,120,38,217,53,21,109,209,98,30,100,9,22,72,140,198,212,207,105,238,200,36,243,229,210,227,151,206,139,61,105,238,245,125,103,197,110,100,157,203,116,168,93,49,66,150,135,36,85,169,26,211,214,153,91,148,150,43,23,139,167,108,1,162,247,22,139,245,24,92,54,115,179,162,201,133,217,199,170,23,185,2,0,147,70,90,196,177,9,55,104,2,41,101,153,183,156,140,227,140,233,216,120,60,238,75,112,130,32,40,249,68,16,116,141,38,242,77,121,72,42,119,228,110,161,160,171,191,187,218,29,148,239,215,159,218,111,205,84,23,102,58,47,212,152,154,93,66,171,118,27,215,174,255,244,66,205,27,193,45,87,155,87,99,231,251,221,141,233,36,45,18,224,125,22,171,139,86,24,212,182,174,253,40,198,33,125,151,188,218,29,244,206,150,11,244,222,52,223,195,155,238,245,59,131,189,247,252,7,230,231,92,154,95,117,118,249,86,110,239,105,250,186,42,3,162,102,39,15,191,27,25,159,46,213,127,253,145,125,170,214,222,84,235,41,92,137,166,209,203,143,156,170,231,180,169,59,156,221,119,217,128,145,39,206,176,246,93,164,229,28,173,198,204,33,24,129,191,255,1,19,29,153,180,142,54,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateImportProcessDisabledLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateImportProcessDisabledLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("485ea968-c234-4b44-a6f0-ffc9a47237b9"),
				Name = "ImportProcessDisabled",
				CreatedInPackageId = new Guid("7ac00ac8-4704-4c6a-999a-db94daccf6cd"),
				CreatedInSchemaUId = new Guid("35a72c4e-86d2-429c-b5d6-e99674ffe850"),
				ModifiedInSchemaUId = new Guid("35a72c4e-86d2-429c-b5d6-e99674ffe850")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("35a72c4e-86d2-429c-b5d6-e99674ffe850"));
		}

		#endregion

	}

	#endregion

}

