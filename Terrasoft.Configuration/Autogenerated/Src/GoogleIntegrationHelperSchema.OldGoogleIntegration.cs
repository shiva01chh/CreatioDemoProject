﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GoogleIntegrationHelperSchema

	/// <exclude/>
	public class GoogleIntegrationHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GoogleIntegrationHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GoogleIntegrationHelperSchema(GoogleIntegrationHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("71cbe5e4-9459-4301-8e6f-f303c81da3e3");
			Name = "GoogleIntegrationHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,90,91,111,227,182,18,126,118,129,254,7,213,231,69,6,92,97,207,121,76,154,5,146,216,201,49,144,164,105,237,237,62,20,69,193,72,180,173,174,68,122,73,202,89,183,200,127,239,240,34,137,148,72,219,241,6,40,208,125,216,72,34,57,55,206,124,156,25,154,160,18,243,13,74,113,180,192,140,33,78,151,34,185,166,100,153,175,42,134,68,78,201,183,223,252,245,237,55,131,138,231,100,21,205,119,92,224,242,188,243,14,243,139,2,167,114,50,79,110,49,193,44,79,123,115,238,114,242,185,253,104,243,42,75,74,252,35,12,135,190,39,147,171,224,208,148,136,92,228,152,251,38,220,82,186,42,240,28,179,109,158,250,103,204,105,154,163,2,70,96,236,63,12,175,64,169,104,74,170,242,44,186,199,156,163,21,94,236,54,88,141,110,170,167,34,79,35,12,131,209,140,8,188,210,246,250,25,204,9,134,192,215,52,131,121,3,105,188,193,3,37,120,44,31,230,88,8,224,199,31,168,128,71,245,233,178,18,107,12,34,167,106,245,13,202,11,156,169,1,139,38,108,72,150,203,135,41,99,148,53,163,140,160,162,253,50,175,82,208,137,195,227,139,150,30,147,76,43,224,40,115,93,32,206,207,34,109,9,139,199,255,113,177,193,204,214,44,149,51,195,19,165,106,146,111,67,24,180,22,136,8,32,254,200,242,45,18,218,76,131,141,126,137,82,57,30,113,193,180,87,144,244,145,81,41,240,3,120,224,2,151,155,66,78,186,136,134,183,127,189,123,145,195,107,70,73,254,167,98,121,79,179,170,192,102,254,240,60,72,21,68,16,40,21,202,3,118,243,116,141,75,36,169,75,170,102,104,207,226,75,240,224,45,172,243,173,174,199,124,203,115,34,162,123,244,69,219,233,26,21,96,118,196,38,48,62,201,151,75,88,252,191,255,158,27,67,185,27,210,24,14,244,2,131,74,151,13,88,142,97,148,81,82,236,162,15,28,51,80,132,232,96,139,126,175,156,247,115,119,85,103,114,231,85,249,229,96,133,133,121,26,48,44,42,230,163,9,99,47,242,255,151,87,104,161,28,200,136,163,157,201,24,185,103,220,70,14,205,41,55,110,29,113,243,229,197,71,197,242,70,203,137,130,58,221,98,225,95,17,119,197,25,245,245,53,156,183,57,19,21,200,117,71,83,84,128,91,62,1,140,24,87,118,98,218,160,196,62,89,122,36,226,161,151,198,240,20,105,124,112,114,154,76,123,40,157,36,217,2,173,190,198,68,221,229,39,201,32,113,69,134,230,29,184,233,130,210,27,196,102,100,177,198,143,136,159,186,113,7,9,158,36,231,7,194,171,205,134,50,129,51,203,115,181,183,158,38,232,17,20,79,147,20,224,98,65,63,97,2,155,115,67,43,114,162,179,133,200,248,100,10,33,144,58,128,88,149,10,202,252,24,20,56,202,226,14,52,186,8,56,174,65,7,119,177,194,40,214,65,76,64,124,31,132,122,78,149,46,193,243,35,116,188,199,98,77,179,208,65,97,36,13,227,221,1,85,204,22,233,89,201,13,101,37,18,113,224,168,30,247,169,56,128,109,68,234,123,140,215,1,140,96,196,18,102,139,152,145,196,216,203,21,107,216,35,194,19,200,28,146,95,80,81,225,225,88,147,58,183,213,34,248,185,47,78,103,243,147,143,148,125,82,249,112,2,137,28,173,88,10,243,40,3,79,28,67,102,226,247,159,225,216,146,211,107,132,45,205,179,232,122,141,211,79,141,159,199,182,154,37,34,192,129,129,142,87,72,102,142,16,171,37,102,137,154,120,175,199,248,175,58,51,125,192,226,25,68,52,153,236,111,231,13,141,170,166,12,84,12,189,228,38,39,89,195,241,106,39,31,103,89,87,227,235,138,49,216,74,249,53,153,101,192,212,24,102,100,172,151,47,163,216,34,126,17,145,170,40,106,233,7,2,210,180,103,101,218,158,117,166,95,82,188,145,15,113,40,186,199,161,196,57,113,210,91,31,46,25,203,234,176,138,22,108,7,110,165,45,116,153,166,192,194,36,129,142,153,185,61,174,253,22,140,213,49,135,29,168,198,246,137,10,40,153,220,166,248,106,167,2,105,232,240,170,81,170,199,196,136,119,225,99,157,92,67,94,39,176,145,211,149,194,50,189,135,94,114,131,69,186,190,97,180,156,92,197,93,189,111,242,66,40,82,186,98,224,176,143,163,14,4,123,72,90,22,62,110,75,189,25,75,120,63,221,233,157,32,161,2,180,198,89,115,202,180,48,38,173,114,169,202,154,126,208,248,13,189,199,19,180,142,134,56,106,169,118,183,199,24,25,200,200,90,47,131,234,182,42,137,130,149,31,244,226,247,144,28,181,203,235,205,239,198,183,131,61,22,187,32,64,124,216,100,240,12,53,44,3,228,33,25,6,111,155,145,37,141,111,43,24,116,36,156,101,227,72,125,165,69,54,119,7,108,11,85,138,32,168,39,247,82,83,239,248,217,184,41,140,52,219,141,225,59,28,105,135,145,251,38,125,93,226,96,195,2,240,78,219,36,121,68,12,130,1,220,45,238,136,55,170,215,127,92,99,134,251,20,234,225,25,159,126,134,29,143,123,244,60,138,141,34,196,141,22,218,180,90,189,100,250,5,167,21,104,54,178,191,30,80,186,174,231,254,45,90,191,132,242,0,135,220,29,93,229,111,18,67,97,28,217,31,53,74,128,97,248,136,188,204,178,198,29,203,178,34,117,237,65,153,117,72,53,10,24,45,11,73,20,164,14,104,219,34,233,119,106,38,88,255,1,14,176,31,217,180,220,72,141,26,112,148,246,72,109,182,95,121,66,248,52,169,177,162,207,172,49,190,71,132,35,78,10,173,160,135,162,115,86,200,144,152,228,106,29,98,59,179,47,227,136,62,253,1,196,222,215,134,24,212,127,7,195,135,170,124,82,9,142,50,157,249,252,50,142,218,25,117,95,101,220,181,146,157,86,152,73,179,172,166,160,255,190,180,198,31,248,68,135,48,156,224,165,229,73,188,222,206,224,124,107,114,179,3,42,118,143,145,238,85,196,93,211,188,82,46,107,142,140,22,37,161,58,112,1,212,227,222,176,42,108,120,50,45,161,6,151,144,176,151,23,218,54,80,104,236,28,206,155,180,123,253,84,97,182,147,225,99,186,163,78,84,207,127,114,0,3,243,207,6,90,123,20,186,121,165,39,76,0,121,189,121,19,80,77,160,160,41,193,41,21,41,3,140,51,126,89,60,163,29,159,99,217,94,6,190,80,221,225,118,133,66,11,57,209,5,150,238,152,231,168,238,204,144,130,7,134,164,249,237,33,157,93,113,57,37,150,239,58,50,245,215,143,185,88,55,88,206,227,58,17,43,55,136,229,92,239,100,162,128,31,204,160,88,238,245,202,118,163,223,146,175,210,71,158,100,150,231,24,247,210,187,47,39,124,104,121,27,164,7,150,65,208,254,5,179,124,185,51,65,180,64,43,157,175,172,116,59,180,249,234,102,38,2,62,24,184,252,90,124,5,218,118,250,13,148,27,40,181,184,28,153,108,127,215,44,119,112,211,163,204,235,10,160,110,243,106,127,225,227,237,250,191,162,17,98,53,9,76,106,29,202,180,247,28,6,135,235,10,183,105,112,220,217,82,195,253,209,142,104,128,172,61,114,142,10,29,7,254,246,23,27,202,135,33,227,145,237,78,202,242,63,177,123,71,20,247,235,5,39,129,106,46,42,84,249,174,220,160,78,46,77,227,100,155,103,48,102,196,239,180,154,186,190,111,9,60,16,0,202,102,149,205,37,177,250,178,56,182,197,50,14,18,193,64,186,142,226,198,251,34,252,58,103,221,211,248,13,251,109,240,26,75,2,24,120,53,193,172,225,224,173,231,189,251,2,7,102,174,139,162,6,93,106,93,2,40,3,38,85,0,52,138,212,101,160,115,149,153,204,229,89,162,11,81,137,40,250,56,238,21,7,183,54,209,91,70,171,205,208,130,136,62,75,153,207,119,114,201,127,2,20,6,61,32,246,192,214,17,177,208,216,220,92,101,213,45,110,238,36,2,169,142,183,137,174,181,246,4,35,216,249,186,157,187,200,203,38,61,81,241,99,182,163,102,18,93,104,3,198,245,228,175,223,71,163,198,29,226,162,115,173,56,37,153,189,179,177,173,211,247,61,209,70,201,4,114,145,232,125,248,178,239,117,219,127,248,234,160,142,159,183,56,43,58,141,124,181,211,166,134,236,247,138,155,157,238,236,235,207,85,51,195,223,96,118,252,235,240,241,212,111,209,59,30,232,211,175,149,141,63,231,26,231,2,205,236,65,138,56,14,93,9,159,25,211,250,0,166,78,175,159,32,101,248,116,110,209,10,221,16,247,136,245,35,199,71,51,195,75,84,21,162,94,125,148,211,184,61,240,35,46,117,198,189,43,215,81,237,86,123,253,106,111,243,213,218,171,185,64,76,244,4,110,54,169,54,137,147,74,212,177,91,155,229,192,126,155,11,148,176,179,122,46,138,29,63,10,48,119,219,8,110,67,208,215,123,212,114,236,73,21,122,135,177,71,38,221,202,121,100,120,155,211,138,123,42,46,111,187,175,95,130,237,41,215,222,174,106,128,227,169,46,28,84,137,218,235,119,181,64,158,54,191,1,146,55,91,192,11,4,212,158,215,254,58,40,156,119,183,171,1,233,129,54,160,236,187,38,142,239,114,46,126,208,180,222,71,248,11,188,193,126,25,33,248,53,221,232,174,73,67,96,65,229,130,38,228,2,125,82,103,205,175,239,126,171,235,79,171,80,55,4,150,112,254,32,9,52,202,248,186,182,200,137,87,144,182,157,161,231,37,19,168,92,69,183,30,31,132,26,189,189,30,175,167,31,104,40,29,217,41,59,88,51,156,244,83,161,6,142,142,248,181,80,155,133,158,69,214,186,238,143,135,14,252,122,36,128,84,45,69,245,214,92,57,155,78,191,251,19,146,183,187,54,238,194,113,84,30,72,224,192,89,44,57,117,27,248,44,122,130,51,37,54,75,107,207,113,21,186,112,23,122,48,229,173,101,27,183,38,5,39,119,146,118,143,212,227,238,156,215,106,113,132,55,194,55,249,239,111,54,82,207,195,168,40,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSettingsNotSetMessageLocalizableString());
			LocalizableStrings.Add(CreateAuthenticationFailedMessageLocalizableString());
			LocalizableStrings.Add(CreateTagNotSetMessageLocalizableString());
			LocalizableStrings.Add(CreateSyncDateLiesTooFarInThePastMessageLocalizableString());
			LocalizableStrings.Add(CreateUnsupportedIntegrationEntityMessageLocalizableString());
			LocalizableStrings.Add(CreateUserTokenNotFoundMessageLocalizableString());
			LocalizableStrings.Add(CreateContactsSynchronizationSummaryLocalizableString());
			LocalizableStrings.Add(CreateCalendarSynchronizationSummaryLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSettingsNotSetMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8af1d412-2338-4193-a173-1c1273ea10f6"),
				Name = "SettingsNotSetMessage",
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933"),
				CreatedInSchemaUId = new Guid("71cbe5e4-9459-4301-8e6f-f303c81da3e3"),
				ModifiedInSchemaUId = new Guid("71cbe5e4-9459-4301-8e6f-f303c81da3e3")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAuthenticationFailedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("81626be4-4db6-4582-bf57-ada1feb0eda9"),
				Name = "AuthenticationFailedMessage",
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933"),
				CreatedInSchemaUId = new Guid("71cbe5e4-9459-4301-8e6f-f303c81da3e3"),
				ModifiedInSchemaUId = new Guid("71cbe5e4-9459-4301-8e6f-f303c81da3e3")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTagNotSetMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f09871d7-f82e-4540-ba2b-276504db4043"),
				Name = "TagNotSetMessage",
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933"),
				CreatedInSchemaUId = new Guid("71cbe5e4-9459-4301-8e6f-f303c81da3e3"),
				ModifiedInSchemaUId = new Guid("71cbe5e4-9459-4301-8e6f-f303c81da3e3")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSyncDateLiesTooFarInThePastMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("673c74b7-ea04-47d8-a2ca-ab3bc5066028"),
				Name = "SyncDateLiesTooFarInThePastMessage",
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933"),
				CreatedInSchemaUId = new Guid("71cbe5e4-9459-4301-8e6f-f303c81da3e3"),
				ModifiedInSchemaUId = new Guid("71cbe5e4-9459-4301-8e6f-f303c81da3e3")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUnsupportedIntegrationEntityMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("499d0610-c3e1-4172-8095-516177e15b92"),
				Name = "UnsupportedIntegrationEntityMessage",
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933"),
				CreatedInSchemaUId = new Guid("71cbe5e4-9459-4301-8e6f-f303c81da3e3"),
				ModifiedInSchemaUId = new Guid("71cbe5e4-9459-4301-8e6f-f303c81da3e3")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUserTokenNotFoundMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0847d510-e0f9-4c91-aba1-96c7d941abae"),
				Name = "UserTokenNotFoundMessage",
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933"),
				CreatedInSchemaUId = new Guid("71cbe5e4-9459-4301-8e6f-f303c81da3e3"),
				ModifiedInSchemaUId = new Guid("71cbe5e4-9459-4301-8e6f-f303c81da3e3")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateContactsSynchronizationSummaryLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d72a4815-2dfe-4b35-9ae6-c2aa1627650e"),
				Name = "ContactsSynchronizationSummary",
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933"),
				CreatedInSchemaUId = new Guid("71cbe5e4-9459-4301-8e6f-f303c81da3e3"),
				ModifiedInSchemaUId = new Guid("71cbe5e4-9459-4301-8e6f-f303c81da3e3")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCalendarSynchronizationSummaryLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d1186314-1b03-4a01-a7f2-46d54f17b99b"),
				Name = "CalendarSynchronizationSummary",
				CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933"),
				CreatedInSchemaUId = new Guid("71cbe5e4-9459-4301-8e6f-f303c81da3e3"),
				ModifiedInSchemaUId = new Guid("71cbe5e4-9459-4301-8e6f-f303c81da3e3")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("71cbe5e4-9459-4301-8e6f-f303c81da3e3"));
		}

		#endregion

	}

	#endregion

}

