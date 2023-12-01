﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExchangeUtilitySchema

	/// <exclude/>
	public class ExchangeUtilitySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExchangeUtilitySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExchangeUtilitySchema(ExchangeUtilitySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4078fc4b-b446-4243-a3b0-b70d4a91dd00");
			Name = "ExchangeUtility";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,26,107,111,27,55,242,179,11,244,63,176,58,160,39,1,198,58,185,143,177,45,192,207,84,105,92,27,150,125,249,80,20,7,106,151,146,216,172,150,42,201,181,163,115,253,211,14,247,147,238,47,220,12,31,187,220,151,36,59,78,155,3,46,112,96,47,57,156,25,206,123,72,102,116,193,212,146,198,140,220,48,41,169,18,83,29,157,136,108,202,103,185,164,154,139,236,219,111,30,190,253,102,39,87,60,155,145,241,74,105,182,216,175,125,3,124,154,178,24,129,85,244,150,101,76,242,184,132,153,165,98,66,211,55,111,78,196,98,33,178,232,189,152,205,96,184,156,31,101,154,205,44,169,163,37,143,240,83,78,129,31,85,130,132,156,73,214,53,30,157,30,119,78,157,211,88,11,201,219,145,158,125,138,231,52,155,177,205,228,199,171,44,46,192,75,0,63,66,14,201,5,143,165,168,96,141,62,176,201,152,201,59,14,56,163,83,170,41,172,131,149,127,145,108,6,91,38,39,41,85,234,77,129,226,86,243,148,235,149,1,217,219,219,35,7,42,95,44,168,92,13,221,55,168,70,83,158,41,146,91,64,178,96,122,46,18,69,180,32,247,66,126,36,247,92,207,75,134,144,48,147,228,114,242,43,232,71,69,30,233,94,128,117,153,79,82,30,19,165,65,5,49,137,145,157,38,55,59,15,134,163,146,107,80,181,166,153,6,206,175,36,191,163,154,217,249,165,253,32,49,206,3,78,137,226,177,212,127,18,250,92,228,89,114,38,165,144,23,76,41,106,4,214,187,153,51,162,150,44,230,83,206,18,34,12,44,185,167,138,100,66,147,41,174,32,60,35,26,161,64,133,172,183,255,12,58,215,57,82,250,207,191,255,5,63,196,254,170,253,212,71,219,161,58,231,200,134,37,107,184,62,138,193,48,212,41,203,96,251,117,217,216,57,194,21,73,204,124,68,78,230,44,254,72,98,201,96,64,115,154,42,66,65,64,90,174,8,157,129,93,60,131,78,40,155,173,36,16,61,81,54,207,147,88,251,92,180,102,131,23,148,167,199,226,83,151,157,253,36,200,2,32,38,226,147,245,17,149,199,115,50,203,121,242,76,156,93,114,107,97,191,109,175,228,237,237,232,116,157,0,54,111,248,50,142,115,41,89,22,179,117,190,37,10,40,88,157,167,73,246,87,77,38,204,122,86,111,223,185,53,203,18,235,217,221,110,110,194,132,157,174,7,38,51,128,162,34,10,2,36,89,74,97,204,54,131,212,18,21,240,97,204,169,5,29,201,104,34,178,116,21,74,29,67,237,149,69,244,19,224,129,221,248,160,100,152,82,81,11,208,254,26,246,76,224,132,24,248,66,44,58,116,27,185,108,135,91,199,232,5,99,26,41,24,191,166,234,227,75,113,124,4,9,250,14,130,249,70,150,59,0,55,152,10,64,46,153,212,144,98,183,176,149,34,63,241,50,249,147,20,42,3,38,183,218,219,8,170,8,130,255,31,200,140,233,125,242,8,187,128,207,11,154,81,68,241,150,233,247,6,89,191,231,41,245,6,235,100,126,202,166,60,227,134,11,49,69,81,227,86,86,228,126,206,33,70,196,62,229,74,22,11,9,217,200,132,94,200,86,18,19,83,42,98,154,154,212,4,164,183,98,190,40,12,206,62,105,16,38,75,156,232,86,1,23,239,17,235,168,152,129,237,101,236,126,155,149,125,164,183,83,0,194,4,205,83,93,135,31,51,29,89,37,141,141,113,168,93,210,115,36,123,187,37,153,11,186,228,126,201,205,106,201,34,11,61,216,96,10,23,182,36,233,40,13,188,10,107,53,6,1,165,213,134,250,3,242,96,182,35,153,206,165,43,149,108,37,183,66,29,31,212,113,12,251,3,19,45,31,91,41,6,210,179,127,184,170,140,156,128,171,104,86,27,237,223,42,38,193,35,50,91,216,146,188,242,185,235,189,202,165,20,227,73,158,93,55,165,76,237,117,148,128,140,148,169,38,119,118,238,168,36,172,182,239,195,214,157,151,240,97,174,63,172,175,70,49,156,148,0,253,58,151,1,123,14,101,133,43,75,124,28,14,29,175,46,236,154,45,112,117,74,148,213,190,27,230,91,21,117,99,226,239,76,42,160,89,124,255,237,213,235,87,255,24,95,189,118,116,107,232,163,91,153,58,18,183,146,247,173,248,163,115,33,23,84,247,123,115,173,151,234,205,222,222,195,171,199,189,179,15,227,189,130,24,85,139,79,96,237,21,129,12,28,5,62,37,253,64,240,17,24,195,229,81,174,231,94,197,94,199,90,124,100,25,208,14,97,111,112,204,162,105,112,122,82,81,102,69,40,6,127,168,75,131,219,241,243,72,88,170,152,39,254,4,172,208,124,132,56,107,123,146,168,204,93,82,31,189,2,63,131,102,34,241,196,67,39,172,209,94,227,111,78,68,221,6,246,100,15,243,210,71,183,80,12,91,78,183,221,177,249,168,89,236,0,52,177,236,191,30,88,153,237,96,151,154,47,178,126,207,20,14,134,35,208,126,145,32,206,144,142,99,177,231,214,68,231,82,44,236,2,224,0,243,33,4,78,76,206,37,196,8,168,201,119,130,87,241,14,162,203,6,33,8,173,131,104,164,206,126,203,105,218,142,19,128,202,37,8,238,104,124,152,51,201,214,46,113,242,9,8,216,205,70,87,84,194,56,180,180,253,80,140,3,2,237,149,149,217,126,168,91,43,83,240,58,22,231,154,141,33,31,80,121,96,213,80,11,173,237,37,22,246,38,166,91,57,88,34,93,201,166,166,92,57,236,45,108,73,218,219,27,226,44,54,118,174,156,129,142,143,97,205,170,136,3,233,200,160,102,196,32,173,97,28,130,254,216,210,216,143,199,112,176,103,0,203,117,118,119,106,120,16,15,111,100,206,14,246,98,96,99,234,225,171,236,68,228,218,66,19,128,158,130,67,88,112,1,253,167,188,231,10,177,123,116,45,38,63,17,34,37,35,5,229,248,149,71,24,150,228,170,239,109,218,126,215,242,219,119,126,7,190,201,239,119,119,180,3,242,253,247,79,90,112,157,59,115,106,95,183,182,149,168,168,126,115,214,223,84,253,157,130,153,161,204,192,144,231,82,100,252,159,80,73,77,193,211,8,13,42,79,63,179,173,65,84,125,191,55,60,130,226,12,123,23,200,62,80,210,225,241,129,221,161,54,113,6,139,58,7,186,198,94,170,170,174,20,113,119,130,39,110,35,103,139,165,94,249,162,25,35,198,81,203,54,54,4,59,171,154,183,208,141,22,66,192,130,43,12,120,79,169,27,234,85,194,83,24,173,135,225,10,63,27,99,128,165,164,10,110,3,45,219,42,223,247,49,42,158,179,36,79,25,249,85,76,158,171,227,3,197,24,38,175,233,97,175,42,94,19,104,156,250,155,250,13,81,42,172,139,101,37,248,15,199,102,140,48,28,36,212,12,174,71,178,44,187,36,88,221,177,97,211,184,133,104,90,12,234,154,45,196,29,67,12,239,196,100,203,252,216,220,193,110,165,68,9,152,171,228,79,75,100,236,212,32,193,158,154,245,245,184,6,228,179,192,78,125,117,84,229,188,193,106,147,199,10,95,219,165,22,12,218,166,23,6,147,1,3,227,202,158,104,126,189,150,243,197,76,103,93,90,11,132,67,46,125,218,34,178,37,171,213,115,89,197,30,77,42,59,21,76,57,157,158,25,148,95,214,38,159,18,226,106,229,104,17,233,26,28,191,184,45,250,16,7,130,86,100,42,100,113,172,88,11,117,95,183,109,54,76,179,51,28,29,165,233,103,71,36,98,82,155,109,181,48,145,140,146,151,74,109,13,30,183,209,119,133,145,141,10,191,93,166,130,38,138,80,173,105,60,95,64,13,161,192,61,146,149,81,62,86,143,56,13,149,108,160,184,34,203,242,20,171,222,63,209,20,16,101,213,16,16,211,166,16,37,97,94,126,84,229,64,201,72,113,91,86,72,227,7,150,46,161,199,1,150,114,44,232,39,43,146,216,99,167,96,219,33,194,22,75,179,34,46,81,42,188,40,219,210,220,234,59,124,41,203,106,231,169,206,68,131,250,70,115,26,107,42,117,80,33,113,205,22,170,171,78,250,202,130,200,54,182,19,226,40,78,11,236,89,242,29,7,140,231,121,22,247,134,24,69,103,216,58,77,225,211,236,88,207,169,246,121,202,35,163,89,163,140,63,91,83,89,26,252,235,57,2,158,193,50,47,124,251,88,79,185,118,186,187,151,12,81,153,163,223,19,195,140,58,129,158,73,247,134,239,195,211,96,98,25,85,120,239,146,233,77,108,45,132,102,85,100,215,102,236,57,216,84,245,232,254,243,138,82,92,235,133,62,66,91,253,220,34,0,13,224,224,152,170,242,200,53,176,142,33,233,178,153,93,34,242,226,238,171,162,70,135,23,167,121,166,73,67,47,118,37,78,53,197,92,178,219,184,23,201,242,52,125,169,96,210,20,226,54,121,170,83,20,118,195,102,91,85,73,152,161,14,1,180,110,190,186,235,45,42,113,115,88,174,218,50,66,253,92,55,12,53,38,87,214,143,133,90,34,12,44,81,238,112,235,43,11,125,79,175,237,193,113,151,151,217,57,151,74,155,211,20,192,1,35,141,184,5,230,135,119,85,138,192,223,83,4,182,71,98,100,154,210,217,154,170,255,105,242,95,91,235,191,232,205,72,165,208,111,51,106,211,89,212,101,3,206,100,250,18,55,205,103,153,144,236,154,207,230,90,249,169,250,109,80,43,111,155,189,234,203,153,184,125,12,84,55,242,224,112,29,161,195,179,246,63,207,192,67,166,134,118,79,204,84,197,168,245,144,197,255,187,201,23,117,19,60,188,175,92,223,4,178,95,219,79,173,117,162,47,225,41,85,81,220,144,49,157,178,99,158,37,152,204,14,110,134,205,59,60,47,28,103,85,193,181,50,46,25,225,61,186,59,145,190,199,251,13,64,249,166,10,226,54,113,67,238,104,154,251,124,108,179,43,190,119,114,119,97,126,178,178,52,66,206,250,5,101,160,132,55,30,55,254,46,45,166,58,158,147,126,121,117,192,252,95,131,18,173,36,19,91,162,56,152,195,18,10,15,199,142,195,73,159,245,205,189,225,119,253,234,66,94,190,167,139,156,80,174,153,90,138,44,0,26,20,132,119,52,24,253,189,67,247,88,9,166,254,194,226,176,202,89,228,114,127,192,66,227,124,191,235,241,215,128,252,254,59,105,64,175,121,245,132,11,28,163,59,79,90,120,157,183,211,234,126,150,22,200,228,189,152,69,102,210,95,234,254,124,86,175,175,2,115,252,5,12,201,184,195,253,28,218,111,211,157,163,248,176,207,178,79,191,70,201,27,242,240,234,177,183,91,170,212,24,137,151,186,189,108,69,65,174,187,203,241,151,56,235,84,87,185,58,53,166,186,49,251,140,236,99,199,132,75,102,78,98,109,95,20,11,41,141,209,216,167,158,186,242,104,18,227,104,45,239,224,235,175,169,72,19,123,197,11,33,110,215,227,87,140,202,120,206,236,209,21,77,33,138,228,19,79,140,195,176,33,183,48,30,82,165,50,229,169,102,205,34,206,14,135,20,240,229,146,63,111,164,100,206,153,68,138,28,59,163,184,120,41,28,102,215,142,151,199,69,40,65,179,58,55,155,121,194,89,138,243,254,222,16,205,194,222,213,87,251,199,15,108,226,131,211,250,4,21,200,113,104,95,49,19,59,100,37,109,14,61,184,13,240,254,44,144,109,200,121,78,104,144,45,81,52,78,180,127,72,178,53,87,188,44,177,226,196,228,159,229,11,80,16,40,223,55,216,121,198,127,131,144,90,62,115,82,126,198,47,38,129,189,68,4,31,25,186,3,31,23,170,185,57,103,198,112,237,142,153,59,146,115,249,110,220,189,251,53,148,94,192,48,186,115,248,123,174,244,65,115,249,16,91,185,31,140,165,26,67,181,163,8,188,57,177,89,127,15,94,92,164,233,143,153,184,207,206,11,179,33,165,5,237,134,185,0,117,127,110,189,202,90,192,230,226,121,228,244,53,73,153,191,153,39,53,157,126,102,231,218,113,176,222,41,159,34,203,134,155,116,219,233,56,124,173,176,187,125,61,254,191,114,167,184,100,146,139,100,148,93,240,44,7,190,123,195,119,98,98,94,58,74,112,143,47,118,29,84,65,227,159,125,168,110,44,37,204,230,227,223,209,180,17,246,235,155,180,79,59,94,65,30,93,176,132,227,193,30,94,68,221,115,72,48,19,35,80,24,74,182,63,16,182,58,223,242,222,1,79,118,106,252,116,222,55,129,11,157,114,179,14,76,194,185,208,174,11,63,195,64,40,45,94,244,121,87,166,246,209,82,221,29,0,71,73,243,231,222,184,25,228,127,137,110,132,125,119,249,7,92,190,214,30,119,216,209,234,32,140,193,191,255,2,200,146,138,16,55,52,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateMailboxDoesNotExistLocalizableString());
			LocalizableStrings.Add(CreateMailServerDoesNotExistLocalizableString());
			LocalizableStrings.Add(CreateSyncExchangeContactsProcessErrorExecutionLocalizableString());
			LocalizableStrings.Add(CreateLoadExchangeEmailsProcessErrorExecutionLocalizableString());
			LocalizableStrings.Add(CreateSyncExchangeActivitiesProcessErrorExecutionLocalizableString());
			LocalizableStrings.Add(CreateUserIsNotMailboxOwnerLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateMailboxDoesNotExistLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9a479e83-8977-4499-8a94-68456c37fded"),
				Name = "MailboxDoesNotExist",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("4078fc4b-b446-4243-a3b0-b70d4a91dd00"),
				ModifiedInSchemaUId = new Guid("4078fc4b-b446-4243-a3b0-b70d4a91dd00")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMailServerDoesNotExistLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0add38ac-a9e5-4583-a1a4-f59e69ed0a92"),
				Name = "MailServerDoesNotExist",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("4078fc4b-b446-4243-a3b0-b70d4a91dd00"),
				ModifiedInSchemaUId = new Guid("4078fc4b-b446-4243-a3b0-b70d4a91dd00")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSyncExchangeContactsProcessErrorExecutionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("470cd327-5781-43c4-94d6-32e662b9f90b"),
				Name = "SyncExchangeContactsProcessErrorExecution",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("4078fc4b-b446-4243-a3b0-b70d4a91dd00"),
				ModifiedInSchemaUId = new Guid("4078fc4b-b446-4243-a3b0-b70d4a91dd00")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLoadExchangeEmailsProcessErrorExecutionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2c696587-c1f3-4e34-862b-49b1d20f7de9"),
				Name = "LoadExchangeEmailsProcessErrorExecution",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("4078fc4b-b446-4243-a3b0-b70d4a91dd00"),
				ModifiedInSchemaUId = new Guid("4078fc4b-b446-4243-a3b0-b70d4a91dd00")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSyncExchangeActivitiesProcessErrorExecutionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7922088b-f33e-4f09-8fee-0315ceb7bc18"),
				Name = "SyncExchangeActivitiesProcessErrorExecution",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("4078fc4b-b446-4243-a3b0-b70d4a91dd00"),
				ModifiedInSchemaUId = new Guid("4078fc4b-b446-4243-a3b0-b70d4a91dd00")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUserIsNotMailboxOwnerLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("04c6587d-9ee6-4e21-aae9-520d2b0909ba"),
				Name = "UserIsNotMailboxOwner",
				CreatedInPackageId = new Guid("2137d3bc-8953-4060-9df8-39c52dc22e74"),
				CreatedInSchemaUId = new Guid("4078fc4b-b446-4243-a3b0-b70d4a91dd00"),
				ModifiedInSchemaUId = new Guid("4078fc4b-b446-4243-a3b0-b70d4a91dd00")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4078fc4b-b446-4243-a3b0-b70d4a91dd00"));
		}

		#endregion

	}

	#endregion

}
