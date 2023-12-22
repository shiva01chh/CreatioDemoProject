﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CESMailingProviderExtensionSchema

	/// <exclude/>
	public class CESMailingProviderExtensionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CESMailingProviderExtensionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CESMailingProviderExtensionSchema(CESMailingProviderExtensionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397");
			Name = "CESMailingProviderExtension";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,27,93,111,219,56,242,57,11,236,127,96,116,139,133,188,240,41,11,220,219,37,118,145,56,78,207,119,105,155,171,211,91,224,14,247,160,200,76,34,84,150,92,146,114,226,166,254,239,55,252,20,41,81,178,156,102,209,61,160,187,219,110,68,14,135,243,205,153,33,147,199,75,76,87,113,130,209,53,38,36,166,197,45,139,38,69,126,155,222,149,36,102,105,145,255,248,195,211,143,63,28,148,52,205,239,208,124,67,25,94,30,215,190,1,62,203,112,194,129,105,244,26,231,152,164,73,3,230,50,205,63,85,131,246,94,203,101,145,251,103,44,42,162,201,116,222,11,232,77,177,192,25,237,5,250,30,24,7,146,113,11,52,193,109,227,209,249,89,235,212,52,103,41,75,219,113,70,23,113,194,10,34,33,0,230,79,4,223,1,61,104,146,197,148,254,21,113,14,226,52,131,117,87,164,88,167,11,76,166,143,12,231,84,40,2,192,143,142,142,208,9,45,151,203,152,108,198,234,91,65,82,132,57,232,130,239,185,196,236,190,88,80,116,91,16,0,199,24,37,4,223,142,130,153,194,61,193,244,116,149,234,29,130,163,49,98,5,74,226,44,3,50,138,114,129,166,75,128,67,115,76,214,41,24,198,233,213,44,210,91,31,89,123,175,202,155,44,77,16,101,32,209,4,37,156,129,110,250,15,158,4,15,21,207,32,125,22,231,12,248,190,34,233,58,102,88,206,175,228,7,74,248,60,74,115,134,222,196,121,25,103,151,233,50,101,115,6,26,196,119,27,52,66,127,57,110,66,83,70,184,0,78,193,28,215,248,188,0,70,242,57,16,88,82,128,15,98,49,26,28,43,50,64,88,146,146,26,89,82,21,111,49,24,238,162,70,145,96,242,34,197,217,226,95,113,86,98,202,39,21,87,102,61,112,190,194,132,27,1,240,37,100,164,0,140,192,4,137,147,120,197,45,17,61,161,59,204,142,17,229,127,109,189,144,239,212,110,61,64,223,226,135,118,208,58,195,219,110,57,188,145,70,212,162,28,165,118,199,171,148,197,104,199,66,211,71,156,148,12,190,63,129,168,216,69,153,139,32,17,242,31,78,206,98,138,133,181,105,232,49,16,155,47,52,108,62,64,79,130,232,117,76,96,194,197,59,66,57,126,232,220,58,28,8,219,56,104,236,2,42,180,191,70,238,166,122,89,109,195,104,94,38,9,166,220,134,156,229,209,140,170,25,185,44,189,69,225,97,203,90,205,207,1,187,39,197,131,96,96,250,152,96,97,3,161,139,245,13,128,199,119,88,209,178,21,127,19,204,74,146,215,37,113,108,169,177,166,152,179,50,251,40,253,248,53,102,230,227,130,20,203,243,155,240,3,224,1,241,229,50,106,163,210,249,28,162,215,101,186,64,152,195,207,22,182,30,110,12,78,169,1,131,54,116,49,40,202,13,120,116,129,89,114,47,246,62,11,131,217,34,24,106,236,67,41,19,64,246,159,255,106,1,29,8,8,253,51,24,31,132,75,182,169,70,206,120,92,5,17,93,167,75,12,190,77,152,127,106,154,91,88,166,143,171,84,26,202,57,200,168,26,63,199,25,68,4,178,153,39,247,120,81,102,248,60,222,208,106,150,163,249,119,145,187,240,241,230,12,179,7,140,115,193,154,53,5,95,27,17,162,2,57,180,109,136,65,243,226,145,71,19,8,132,131,148,92,80,240,22,142,233,0,53,49,106,10,59,49,106,160,14,140,202,188,204,154,14,195,178,162,31,96,2,227,178,6,194,202,234,12,170,33,250,176,90,192,122,241,161,229,172,60,14,17,249,127,109,100,157,118,9,70,87,241,228,66,58,76,56,198,196,205,212,34,208,216,152,137,169,35,143,232,35,46,28,173,88,19,82,71,156,217,203,228,179,56,226,55,28,36,172,59,78,96,248,175,204,86,243,104,41,118,160,113,235,51,64,163,158,139,40,46,182,107,226,54,40,245,242,237,240,25,60,54,188,71,152,199,187,91,176,252,232,186,144,4,132,3,15,243,154,141,253,16,236,197,97,211,179,7,47,196,41,4,131,175,225,115,215,242,103,115,201,131,212,215,240,232,198,181,138,50,119,211,104,82,18,130,115,198,157,6,126,206,192,77,112,23,235,46,86,49,251,44,212,123,137,165,22,162,247,151,202,53,73,151,19,82,228,128,136,128,120,249,185,90,9,202,23,232,125,34,240,32,209,82,233,68,177,23,171,222,83,231,107,204,192,28,3,207,14,92,213,81,103,172,224,58,38,144,67,86,135,199,243,120,53,136,77,212,146,89,205,139,158,48,215,144,83,49,198,203,142,223,245,128,105,110,131,168,254,161,242,30,61,23,93,164,132,178,112,240,66,135,83,35,245,232,14,99,154,48,185,238,10,10,177,150,53,251,90,110,45,255,249,170,195,168,202,153,122,50,35,150,81,224,230,5,226,176,149,176,245,183,77,85,103,53,28,106,71,70,173,150,97,179,64,39,217,98,160,202,178,37,70,110,65,203,24,138,94,168,2,136,130,113,199,70,181,29,34,207,194,227,6,70,7,21,224,240,96,142,128,179,153,40,203,19,124,38,89,171,136,30,216,40,213,234,26,154,104,66,48,79,246,196,144,191,44,144,224,190,154,64,9,99,87,150,170,16,0,165,215,155,21,94,76,138,172,92,230,66,201,39,82,206,227,80,46,28,244,85,164,109,39,253,52,153,37,159,133,68,236,42,85,204,240,81,144,201,79,193,101,145,196,89,250,57,190,201,176,68,79,163,39,181,106,27,137,173,130,99,179,54,171,3,171,10,171,129,164,126,252,254,86,144,143,162,127,23,65,77,88,148,36,1,184,130,128,38,149,69,7,29,29,153,96,104,209,172,43,95,185,251,90,57,94,131,46,73,57,122,245,74,162,111,206,131,64,85,26,32,197,41,26,130,113,86,163,14,162,210,173,2,27,162,219,56,163,216,85,177,216,191,151,246,222,20,139,244,54,197,11,17,115,168,58,36,102,211,188,92,194,182,64,214,137,21,140,198,40,206,50,9,104,43,110,233,160,0,174,13,84,244,219,61,38,56,124,68,163,49,122,140,76,64,58,28,193,151,14,104,46,225,146,176,232,239,69,154,135,32,95,248,207,197,30,205,49,239,149,74,148,63,5,79,143,145,138,89,91,244,103,244,84,97,221,162,35,254,169,183,220,6,131,46,99,230,61,50,144,133,174,16,38,197,98,167,29,139,240,179,170,74,18,167,221,194,73,84,22,168,232,173,121,114,196,29,55,244,148,59,131,72,186,99,104,149,43,74,138,220,201,85,146,19,205,232,244,83,25,103,161,4,142,174,98,2,38,200,48,9,45,138,6,40,166,106,123,87,196,98,40,82,205,165,57,24,96,76,78,64,2,227,176,75,68,162,11,52,199,57,56,128,108,11,210,89,126,91,112,169,53,6,67,177,27,200,61,229,117,171,61,173,179,138,117,251,220,16,249,187,172,32,107,249,131,45,105,61,166,130,70,7,218,232,202,6,213,238,103,228,255,207,18,210,201,191,225,108,37,35,184,13,28,118,97,157,170,54,140,161,164,150,247,12,142,45,171,168,137,73,11,67,219,73,203,180,74,0,64,20,255,192,252,180,48,59,169,150,29,76,68,114,82,133,172,43,87,40,182,140,172,227,89,91,131,15,93,83,163,109,196,247,59,33,116,14,219,219,175,24,44,248,44,147,230,61,253,74,123,15,223,42,208,110,86,229,208,218,149,172,116,189,151,91,89,4,237,229,86,250,60,237,146,147,167,189,163,90,174,210,0,64,128,59,64,164,195,237,240,155,125,250,72,60,30,234,72,34,147,65,39,52,182,24,187,183,85,227,28,139,204,50,4,137,215,49,141,157,120,27,37,85,229,94,9,166,174,67,237,18,171,242,43,229,193,118,245,238,180,86,221,178,186,187,200,31,234,168,226,52,40,250,245,68,210,228,35,245,172,23,109,156,190,221,35,11,199,85,165,61,173,72,53,227,43,158,173,13,124,211,106,101,93,250,176,202,86,168,39,184,84,74,233,176,127,59,217,176,35,15,15,51,99,110,35,250,36,89,168,248,19,74,107,130,12,215,9,75,146,202,203,148,178,147,198,97,5,153,203,26,180,42,242,44,123,141,54,120,227,195,214,156,78,53,22,226,147,231,27,245,56,45,78,64,101,71,231,10,10,73,112,37,178,25,21,196,195,240,140,74,8,241,29,250,169,25,170,197,50,28,109,187,130,198,77,81,100,53,156,251,113,110,50,113,181,165,21,103,83,67,244,161,127,45,196,201,183,101,150,189,131,154,120,5,85,202,0,253,252,115,203,46,209,105,190,113,14,15,16,163,148,140,61,24,233,57,45,61,64,232,129,146,23,145,145,8,209,52,108,94,81,14,145,204,161,39,197,114,21,147,148,86,221,53,149,42,207,238,242,130,224,73,12,217,178,155,117,42,142,119,201,27,152,121,143,147,116,149,2,74,10,1,150,223,75,225,69,184,51,240,182,221,7,1,196,29,239,146,189,199,171,130,166,144,217,131,187,74,190,197,29,170,188,234,22,133,154,112,12,216,66,37,139,245,101,227,80,93,232,129,78,75,190,232,148,220,129,79,229,44,12,220,3,210,92,183,180,229,43,118,68,149,178,211,187,201,84,162,182,177,74,150,212,104,82,144,69,168,249,116,3,129,139,43,50,194,51,242,156,20,37,28,58,99,244,107,135,18,214,5,200,241,178,184,155,18,82,144,253,196,14,167,95,103,222,97,159,82,25,236,176,6,146,134,213,13,35,210,13,135,164,106,215,194,106,6,26,170,84,170,155,20,156,58,117,7,217,179,117,203,105,148,57,7,157,46,82,38,156,248,2,198,20,22,85,136,87,74,51,121,171,160,19,36,194,59,15,70,48,134,101,126,48,241,112,29,125,96,201,219,226,97,104,113,6,252,216,116,42,179,240,114,215,67,33,234,142,86,159,25,242,232,221,83,65,50,135,233,93,120,42,97,39,247,113,126,135,117,179,108,212,90,209,86,235,143,123,53,50,91,252,227,216,103,39,253,148,60,143,215,216,86,244,165,90,29,12,234,72,149,78,174,241,114,149,201,156,163,7,122,41,115,173,1,165,144,154,253,52,182,224,173,65,89,112,95,20,100,25,179,176,185,251,208,21,177,194,212,234,11,205,206,154,115,193,161,193,122,218,179,168,61,250,152,115,69,247,208,239,162,93,149,109,215,19,140,121,245,188,225,57,246,188,215,83,141,63,158,77,190,140,154,25,156,107,42,75,82,199,65,203,195,22,87,42,234,249,6,74,98,150,220,163,208,138,197,230,45,136,9,121,149,14,140,181,212,153,117,98,95,187,141,216,55,13,221,166,161,59,243,21,97,35,132,85,31,220,122,122,210,89,28,123,174,203,116,90,230,187,45,115,179,85,31,72,4,103,115,22,39,80,226,254,138,126,129,127,95,193,31,94,228,66,233,107,102,208,47,114,196,246,137,221,143,152,172,151,88,245,87,116,98,96,2,33,86,60,96,227,15,222,208,67,202,238,117,77,33,94,199,73,77,160,165,116,161,202,150,13,190,163,58,194,147,21,47,191,81,14,37,248,40,208,240,193,120,106,94,233,165,170,207,30,157,28,9,80,255,74,69,68,48,214,133,159,94,38,105,76,121,14,31,223,20,37,147,111,147,80,156,36,34,21,81,79,133,104,19,187,20,63,29,95,223,99,251,117,96,195,205,249,195,64,177,71,2,213,209,80,104,190,164,40,134,138,112,41,99,21,160,214,184,132,137,56,15,2,155,79,175,148,53,215,218,209,33,187,79,233,174,166,153,140,70,242,140,16,72,79,37,151,198,166,189,109,128,25,104,19,176,105,81,240,31,189,253,167,90,31,196,244,145,90,8,38,158,222,209,51,76,170,20,220,72,135,175,110,184,190,181,61,241,176,225,146,100,219,72,123,11,6,140,229,27,25,90,103,144,243,16,188,183,193,245,234,56,221,134,135,45,229,85,21,219,107,29,154,193,160,118,172,244,125,213,184,125,134,117,239,106,39,57,253,167,30,45,187,6,87,138,182,78,109,36,93,147,35,39,89,105,149,154,74,245,161,106,31,141,109,103,245,105,186,98,74,23,134,226,137,102,23,25,141,247,154,186,2,236,88,99,107,197,243,62,65,10,180,254,6,115,103,179,80,91,73,85,209,154,34,64,98,180,159,69,88,143,33,92,125,180,86,55,237,2,70,245,98,163,175,8,190,199,194,255,131,88,216,124,196,178,71,64,236,253,208,70,248,217,31,58,32,126,179,64,53,199,204,163,3,242,204,56,133,190,124,169,94,30,169,223,141,128,250,230,112,228,253,165,137,47,95,36,81,135,141,199,74,188,209,217,144,255,247,160,215,43,232,29,28,124,15,123,223,52,236,129,93,156,234,254,189,142,92,212,248,171,119,182,87,208,123,169,66,194,79,193,238,2,66,223,28,81,196,64,126,242,50,65,93,49,252,254,86,210,241,110,32,16,250,212,0,46,97,198,179,250,218,130,255,161,133,49,139,78,197,119,173,53,147,250,218,173,255,49,247,204,183,31,238,101,191,117,141,36,67,87,243,89,66,231,59,18,99,132,85,44,92,215,110,18,245,117,139,239,146,177,235,217,71,253,38,205,185,242,210,87,139,209,117,193,175,228,66,107,127,226,254,6,86,167,244,213,73,82,191,111,164,214,59,23,77,171,60,73,28,231,33,158,188,178,214,227,145,163,238,160,24,179,255,249,31,94,128,27,75,224,58,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSaveEmailColumnsLogEventLocalizableString());
			LocalizableStrings.Add(CreateEmailColumnsEditCloudFailMessageLocalizableString());
			LocalizableStrings.Add(CreateTimeZoneLocalizableString());
			LocalizableStrings.Add(CreateDeliveryScheduleDaysLocalizableString());
			LocalizableStrings.Add(CreateExpirationDateLocalizableString());
			LocalizableStrings.Add(CreateBusinessTimeEndLocalizableString());
			LocalizableStrings.Add(CreateBusinessTimeStartLocalizableString());
			LocalizableStrings.Add(CreatePriorityLocalizableString());
			LocalizableStrings.Add(CreateUpdateScheduleSuccessMessageLocalizableString());
			LocalizableStrings.Add(CreateDelayBetweenEmailLocalizableString());
			LocalizableStrings.Add(CreateDailyLimitLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSaveEmailColumnsLogEventLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d501936a-585d-572a-6d82-2ae7f827f391"),
				Name = "SaveEmailColumnsLogEvent",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397"),
				ModifiedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmailColumnsEditCloudFailMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bd23b38f-6b69-a1ca-c05f-3a701517747b"),
				Name = "EmailColumnsEditCloudFailMessage",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397"),
				ModifiedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTimeZoneLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("05b5ade8-0127-c906-fd72-8c7ea9c2954b"),
				Name = "TimeZone",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397"),
				ModifiedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDeliveryScheduleDaysLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c05cbc66-dbe8-f5a6-8ace-d4e8bc4e76bc"),
				Name = "DeliveryScheduleDays",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397"),
				ModifiedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateExpirationDateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d61410ca-a534-93e4-cbd3-8446cf7c4fa9"),
				Name = "ExpirationDate",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397"),
				ModifiedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBusinessTimeEndLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1206f120-690d-7bc2-05ad-64060a56ea54"),
				Name = "BusinessTimeEnd",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397"),
				ModifiedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBusinessTimeStartLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0def20f6-98c9-1517-6b8d-368f53a8a454"),
				Name = "BusinessTimeStart",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397"),
				ModifiedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePriorityLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bc4124e4-133e-3759-94b4-62f61a3e472d"),
				Name = "Priority",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397"),
				ModifiedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUpdateScheduleSuccessMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("707de1ff-b743-513f-905a-ccac155de1cd"),
				Name = "UpdateScheduleSuccessMessage",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397"),
				ModifiedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDelayBetweenEmailLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("72c4c87b-64e7-8342-bb65-0ee637df0741"),
				Name = "DelayBetweenEmail",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397"),
				ModifiedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDailyLimitLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9a14e988-2680-4305-336e-64d9aaf41426"),
				Name = "DailyLimit",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397"),
				ModifiedInSchemaUId = new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f19e3e4-fb9f-4832-953c-133e7bf77397"));
		}

		#endregion

	}

	#endregion

}

