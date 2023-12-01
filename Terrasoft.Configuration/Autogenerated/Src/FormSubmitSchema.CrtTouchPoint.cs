namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: FormSubmit_CrtTouchPoint_TerrasoftSchema

	/// <exclude/>
	public class FormSubmit_CrtTouchPoint_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public FormSubmit_CrtTouchPoint_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FormSubmit_CrtTouchPoint_TerrasoftSchema(FormSubmit_CrtTouchPoint_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FormSubmit_CrtTouchPoint_TerrasoftSchema(FormSubmit_CrtTouchPoint_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015");
			RealUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015");
			Name = "FormSubmit_CrtTouchPoint_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("02115f37-84dc-464a-87f1-bcad70c08759");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ddeea9d7-0297-e076-a745-e13d9e5f82fa")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("2220684f-17b1-3020-5dfb-726b1bec7aae")) == null) {
				Columns.Add(CreateFormDataColumn());
			}
			if (Columns.FindByUId(new Guid("91652a8d-9a8e-d841-aa2f-e813adf5501c")) == null) {
				Columns.Add(CreatePhoneNumberColumn());
			}
			if (Columns.FindByUId(new Guid("60543d87-6b8e-10b6-70e2-6c15b85f9b01")) == null) {
				Columns.Add(CreateEmailColumn());
			}
			if (Columns.FindByUId(new Guid("9d06059b-cb2b-0b7b-600c-1e0967c538dd")) == null) {
				Columns.Add(CreateLastNameColumn());
			}
			if (Columns.FindByUId(new Guid("19c0ec89-d01e-3ae8-2b58-8e8789ef9bf0")) == null) {
				Columns.Add(CreateFirstNameColumn());
			}
			if (Columns.FindByUId(new Guid("d9109991-f009-62af-c402-94e87c06b950")) == null) {
				Columns.Add(CreateFullNameColumn());
			}
			if (Columns.FindByUId(new Guid("06de216d-2012-b890-bc88-33e56984e177")) == null) {
				Columns.Add(CreateCountryStrColumn());
			}
			if (Columns.FindByUId(new Guid("56c7be66-5860-b898-5911-e26d26c549f5")) == null) {
				Columns.Add(CreateCountryColumn());
			}
			if (Columns.FindByUId(new Guid("db8be8e6-102e-375a-8661-46f4a3d4ef5d")) == null) {
				Columns.Add(CreateAccountIndustryStrColumn());
			}
			if (Columns.FindByUId(new Guid("82e275c1-f6df-442b-5cd1-082958db2223")) == null) {
				Columns.Add(CreateAccountIndustryColumn());
			}
			if (Columns.FindByUId(new Guid("b277c977-a832-6e1a-76f9-a82464f34d8d")) == null) {
				Columns.Add(CreateJobTitleColumn());
			}
			if (Columns.FindByUId(new Guid("b550da91-2bbe-02dc-6a21-2f08ee160407")) == null) {
				Columns.Add(CreateContactDecisionRoleStrColumn());
			}
			if (Columns.FindByUId(new Guid("7ccd1763-1d18-c948-24b7-81de914679d3")) == null) {
				Columns.Add(CreateContactDecisionRoleColumn());
			}
			if (Columns.FindByUId(new Guid("39e7fd9c-181d-892f-d73d-d158228393f4")) == null) {
				Columns.Add(CreateWorkEmailColumn());
			}
			if (Columns.FindByUId(new Guid("e18e183c-9f33-00ba-27ef-874c5351b9ae")) == null) {
				Columns.Add(CreateAccountEmployeesNumberStrColumn());
			}
			if (Columns.FindByUId(new Guid("8bc0a2a8-5b9a-af2b-d14c-812917b0fa5b")) == null) {
				Columns.Add(CreateAccountEmployeesNumberColumn());
			}
			if (Columns.FindByUId(new Guid("f76fb12d-be24-1473-9580-0a7ec0863ca9")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("1fd35b2e-f581-dd53-2493-69980e8473f7")) == null) {
				Columns.Add(CreateWebsiteColumn());
			}
			if (Columns.FindByUId(new Guid("0768a9af-adb8-4d74-2d47-a3f6a5568b5e")) == null) {
				Columns.Add(CreateGenderColumn());
			}
			if (Columns.FindByUId(new Guid("072d2f20-1ead-da2a-07fd-aed691895bc7")) == null) {
				Columns.Add(CreateTimeZoneColumn());
			}
			if (Columns.FindByUId(new Guid("4a889680-5048-c0ac-afce-2e9623527c34")) == null) {
				Columns.Add(CreateTerritoryColumn());
			}
			if (Columns.FindByUId(new Guid("76426879-16d2-810f-ffe0-cb8bb21de15e")) == null) {
				Columns.Add(CreateCityStrColumn());
			}
			if (Columns.FindByUId(new Guid("ac3b7e0a-e945-fe1f-8518-3ed9538f1ed0")) == null) {
				Columns.Add(CreateCityColumn());
			}
			if (Columns.FindByUId(new Guid("5b05e9e4-777a-aab8-8e51-fca4f73768b7")) == null) {
				Columns.Add(CreateBirthDateColumn());
			}
			if (Columns.FindByUId(new Guid("3f58443b-2a56-a020-610b-f3fa42b6f165")) == null) {
				Columns.Add(CreatePasswordColumn());
			}
			if (Columns.FindByUId(new Guid("21cbd581-7d16-2b88-bbf6-498e7391ea61")) == null) {
				Columns.Add(CreateLinkedInProfileUrlColumn());
			}
			if (Columns.FindByUId(new Guid("ffee3041-b8da-713f-2dd5-b1a05b25d42a")) == null) {
				Columns.Add(CreateRegisterMethodColumn());
			}
			if (Columns.FindByUId(new Guid("a5bf46da-927f-9ee1-b237-238ab555244a")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("f6f63fd0-2a29-1a7b-6155-6955f6ebbf8b")) == null) {
				Columns.Add(CreateSourceColumn());
			}
			if (Columns.FindByUId(new Guid("770eec1e-8865-d31e-d5e9-2316e9d43ccb")) == null) {
				Columns.Add(CreateChannelColumn());
			}
			if (Columns.FindByUId(new Guid("e2030317-bd2a-4659-c644-d41e57bbc131")) == null) {
				Columns.Add(CreateUtmCampaignStrColumn());
			}
			if (Columns.FindByUId(new Guid("80af1dea-87ef-0c6a-c71c-273e668c041c")) == null) {
				Columns.Add(CreateUtmMediumStrColumn());
			}
			if (Columns.FindByUId(new Guid("19171333-92fc-63fe-6597-fbce780c10fb")) == null) {
				Columns.Add(CreateUtmSourceStrColumn());
			}
			if (Columns.FindByUId(new Guid("d2e6d144-9c60-ad54-86ba-002c482dfc29")) == null) {
				Columns.Add(CreateReferrerColumn());
			}
			if (Columns.FindByUId(new Guid("8484e41b-79f9-6d85-1e7f-76c10a1f75fc")) == null) {
				Columns.Add(CreateLandingPageURLColumn());
			}
			if (Columns.FindByUId(new Guid("41d289da-8dde-9e0c-6abd-53d4a7c70c9a")) == null) {
				Columns.Add(CreateUtmTermStrColumn());
			}
			if (Columns.FindByUId(new Guid("a64062d6-1320-fec2-41c7-a6a6be5181a0")) == null) {
				Columns.Add(CreateUtmContentStrColumn());
			}
			if (Columns.FindByUId(new Guid("5d780019-f37e-0d2a-82d3-1252c587ee91")) == null) {
				Columns.Add(CreateCustomerNeedColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ddeea9d7-0297-e076-a745-e13d9e5f82fa"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("02115f37-84dc-464a-87f1-bcad70c08759")
			};
		}

		protected virtual EntitySchemaColumn CreateFormDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("2220684f-17b1-3020-5dfb-726b1bec7aae"),
				Name = @"FormData",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("02115f37-84dc-464a-87f1-bcad70c08759"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreatePhoneNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("91652a8d-9a8e-d841-aa2f-e813adf5501c"),
				Name = @"PhoneNumber",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("60543d87-6b8e-10b6-70e2-6c15b85f9b01"),
				Name = @"Email",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateLastNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("9d06059b-cb2b-0b7b-600c-1e0967c538dd"),
				Name = @"LastName",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateFirstNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("19c0ec89-d01e-3ae8-2b58-8e8789ef9bf0"),
				Name = @"FirstName",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateFullNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d9109991-f009-62af-c402-94e87c06b950"),
				Name = @"FullName",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateCountryStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("06de216d-2012-b890-bc88-33e56984e177"),
				Name = @"CountryStr",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1")
			};
		}

		protected virtual EntitySchemaColumn CreateCountryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("56c7be66-5860-b898-5911-e26d26c549f5"),
				Name = @"Country",
				ReferenceSchemaUId = new Guid("09fce1f8-515c-4296-95cd-8cd93f79a6cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountIndustryStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("db8be8e6-102e-375a-8661-46f4a3d4ef5d"),
				Name = @"AccountIndustryStr",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountIndustryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("82e275c1-f6df-442b-5cd1-082958db2223"),
				Name = @"AccountIndustry",
				ReferenceSchemaUId = new Guid("95de3d3b-b909-40d9-a3fa-e80d38ec208e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1")
			};
		}

		protected virtual EntitySchemaColumn CreateJobTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("b277c977-a832-6e1a-76f9-a82464f34d8d"),
				Name = @"JobTitle",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateContactDecisionRoleStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("b550da91-2bbe-02dc-6a21-2f08ee160407"),
				Name = @"ContactDecisionRoleStr",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1")
			};
		}

		protected virtual EntitySchemaColumn CreateContactDecisionRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7ccd1763-1d18-c948-24b7-81de914679d3"),
				Name = @"ContactDecisionRole",
				ReferenceSchemaUId = new Guid("54aa771f-fba6-4d76-9239-bff3f00ee3e5"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1")
			};
		}

		protected virtual EntitySchemaColumn CreateWorkEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("39e7fd9c-181d-892f-d73d-d158228393f4"),
				Name = @"WorkEmail",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateAccountEmployeesNumberStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("e18e183c-9f33-00ba-27ef-874c5351b9ae"),
				Name = @"AccountEmployeesNumberStr",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountEmployeesNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8bc0a2a8-5b9a-af2b-d14c-812917b0fa5b"),
				Name = @"AccountEmployeesNumber",
				ReferenceSchemaUId = new Guid("ccf7d7bf-b4b7-4eb3-a191-3f47d6c4ee8d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("f76fb12d-be24-1473-9580-0a7ec0863ca9"),
				Name = @"Account",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1")
			};
		}

		protected virtual EntitySchemaColumn CreateWebsiteColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("1fd35b2e-f581-dd53-2493-69980e8473f7"),
				Name = @"Website",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1")
			};
		}

		protected virtual EntitySchemaColumn CreateGenderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0768a9af-adb8-4d74-2d47-a3f6a5568b5e"),
				Name = @"Gender",
				ReferenceSchemaUId = new Guid("0bc5d826-8e8f-48cd-b087-30b33d133120"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateTimeZoneColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("072d2f20-1ead-da2a-07fd-aed691895bc7"),
				Name = @"TimeZone",
				ReferenceSchemaUId = new Guid("a394a569-92d6-44d0-bdda-fa0578373b4f"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1")
			};
		}

		protected virtual EntitySchemaColumn CreateTerritoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4a889680-5048-c0ac-afce-2e9623527c34"),
				Name = @"Territory",
				ReferenceSchemaUId = new Guid("a0d1e591-78ee-44cb-9a58-39d6b59346f8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1")
			};
		}

		protected virtual EntitySchemaColumn CreateCityStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("76426879-16d2-810f-ffe0-cb8bb21de15e"),
				Name = @"CityStr",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1")
			};
		}

		protected virtual EntitySchemaColumn CreateCityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ac3b7e0a-e945-fe1f-8518-3ed9538f1ed0"),
				Name = @"City",
				ReferenceSchemaUId = new Guid("5ca90b6a-93e7-4448-befe-ab5166ec2cfe"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1")
			};
		}

		protected virtual EntitySchemaColumn CreateBirthDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("5b05e9e4-777a-aab8-8e51-fca4f73768b7"),
				Name = @"BirthDate",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreatePasswordColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("SecureText")) {
				UId = new Guid("3f58443b-2a56-a020-610b-f3fa42b6f165"),
				Name = @"Password",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1")
			};
		}

		protected virtual EntitySchemaColumn CreateLinkedInProfileUrlColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("21cbd581-7d16-2b88-bbf6-498e7391ea61"),
				Name = @"LinkedInProfileUrl",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("9582558d-150f-478d-ae8c-f0e573cdd1d1"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateRegisterMethodColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ffee3041-b8da-713f-2dd5-b1a05b25d42a"),
				Name = @"RegisterMethod",
				ReferenceSchemaUId = new Guid("39351852-e9f3-4e9a-8fe5-34fac385654e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("0e74fb48-a0ce-4417-b434-af5bdf82876e")
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("a5bf46da-927f-9ee1-b237-238ab555244a"),
				Name = @"Notes",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("0e74fb48-a0ce-4417-b434-af5bdf82876e")
			};
		}

		protected virtual EntitySchemaColumn CreateSourceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f6f63fd0-2a29-1a7b-6155-6955f6ebbf8b"),
				Name = @"Source",
				ReferenceSchemaUId = new Guid("533025a5-cb29-46d5-935a-7e12616d69b6"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("8fa2fedf-477a-49c5-b16a-2ddd6c5f7040")
			};
		}

		protected virtual EntitySchemaColumn CreateChannelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("770eec1e-8865-d31e-d5e9-2316e9d43ccb"),
				Name = @"Channel",
				ReferenceSchemaUId = new Guid("308ef8cd-4f4f-4898-9b3d-36ab9af01f5c"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("8fa2fedf-477a-49c5-b16a-2ddd6c5f7040")
			};
		}

		protected virtual EntitySchemaColumn CreateUtmCampaignStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("e2030317-bd2a-4659-c644-d41e57bbc131"),
				Name = @"UtmCampaignStr",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("8fa2fedf-477a-49c5-b16a-2ddd6c5f7040")
			};
		}

		protected virtual EntitySchemaColumn CreateUtmMediumStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("80af1dea-87ef-0c6a-c71c-273e668c041c"),
				Name = @"UtmMediumStr",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("8fa2fedf-477a-49c5-b16a-2ddd6c5f7040")
			};
		}

		protected virtual EntitySchemaColumn CreateUtmSourceStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("19171333-92fc-63fe-6597-fbce780c10fb"),
				Name = @"UtmSourceStr",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("8fa2fedf-477a-49c5-b16a-2ddd6c5f7040")
			};
		}

		protected virtual EntitySchemaColumn CreateReferrerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("d2e6d144-9c60-ad54-86ba-002c482dfc29"),
				Name = @"Referrer",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("8fa2fedf-477a-49c5-b16a-2ddd6c5f7040")
			};
		}

		protected virtual EntitySchemaColumn CreateLandingPageURLColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("8484e41b-79f9-6d85-1e7f-76c10a1f75fc"),
				Name = @"LandingPageURL",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("8fa2fedf-477a-49c5-b16a-2ddd6c5f7040")
			};
		}

		protected virtual EntitySchemaColumn CreateUtmTermStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("41d289da-8dde-9e0c-6abd-53d4a7c70c9a"),
				Name = @"UtmTermStr",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("8fa2fedf-477a-49c5-b16a-2ddd6c5f7040")
			};
		}

		protected virtual EntitySchemaColumn CreateUtmContentStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("a64062d6-1320-fec2-41c7-a6a6be5181a0"),
				Name = @"UtmContentStr",
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("8fa2fedf-477a-49c5-b16a-2ddd6c5f7040")
			};
		}

		protected virtual EntitySchemaColumn CreateCustomerNeedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5d780019-f37e-0d2a-82d3-1252c587ee91"),
				Name = @"CustomerNeed",
				ReferenceSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				ModifiedInSchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"),
				CreatedInPackageId = new Guid("b9166720-f206-4211-b646-5f108c6ce314")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FormSubmit_CrtTouchPoint_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FormSubmit_CrtTouchPointEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FormSubmit_CrtTouchPoint_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FormSubmit_CrtTouchPoint_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015"));
		}

		#endregion

	}

	#endregion

	#region Class: FormSubmit_CrtTouchPoint_Terrasoft

	/// <summary>
	/// Submitted form.
	/// </summary>
	public class FormSubmit_CrtTouchPoint_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public FormSubmit_CrtTouchPoint_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FormSubmit_CrtTouchPoint_Terrasoft";
		}

		public FormSubmit_CrtTouchPoint_Terrasoft(FormSubmit_CrtTouchPoint_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <summary>
		/// Data.
		/// </summary>
		public string FormData {
			get {
				return GetTypedColumnValue<string>("FormData");
			}
			set {
				SetColumnValue("FormData", value);
			}
		}

		/// <summary>
		/// Phone number.
		/// </summary>
		public string PhoneNumber {
			get {
				return GetTypedColumnValue<string>("PhoneNumber");
			}
			set {
				SetColumnValue("PhoneNumber", value);
			}
		}

		/// <summary>
		/// Email.
		/// </summary>
		public string Email {
			get {
				return GetTypedColumnValue<string>("Email");
			}
			set {
				SetColumnValue("Email", value);
			}
		}

		/// <summary>
		/// Last name.
		/// </summary>
		public string LastName {
			get {
				return GetTypedColumnValue<string>("LastName");
			}
			set {
				SetColumnValue("LastName", value);
			}
		}

		/// <summary>
		/// First name.
		/// </summary>
		public string FirstName {
			get {
				return GetTypedColumnValue<string>("FirstName");
			}
			set {
				SetColumnValue("FirstName", value);
			}
		}

		/// <summary>
		/// Full name.
		/// </summary>
		public string FullName {
			get {
				return GetTypedColumnValue<string>("FullName");
			}
			set {
				SetColumnValue("FullName", value);
			}
		}

		/// <summary>
		/// Country (string).
		/// </summary>
		public string CountryStr {
			get {
				return GetTypedColumnValue<string>("CountryStr");
			}
			set {
				SetColumnValue("CountryStr", value);
			}
		}

		/// <exclude/>
		public Guid CountryId {
			get {
				return GetTypedColumnValue<Guid>("CountryId");
			}
			set {
				SetColumnValue("CountryId", value);
				_country = null;
			}
		}

		/// <exclude/>
		public string CountryName {
			get {
				return GetTypedColumnValue<string>("CountryName");
			}
			set {
				SetColumnValue("CountryName", value);
				if (_country != null) {
					_country.Name = value;
				}
			}
		}

		private Country _country;
		/// <summary>
		/// Country.
		/// </summary>
		public Country Country {
			get {
				return _country ??
					(_country = LookupColumnEntities.GetEntity("Country") as Country);
			}
		}

		/// <summary>
		/// Industry (string).
		/// </summary>
		public string AccountIndustryStr {
			get {
				return GetTypedColumnValue<string>("AccountIndustryStr");
			}
			set {
				SetColumnValue("AccountIndustryStr", value);
			}
		}

		/// <exclude/>
		public Guid AccountIndustryId {
			get {
				return GetTypedColumnValue<Guid>("AccountIndustryId");
			}
			set {
				SetColumnValue("AccountIndustryId", value);
				_accountIndustry = null;
			}
		}

		/// <exclude/>
		public string AccountIndustryName {
			get {
				return GetTypedColumnValue<string>("AccountIndustryName");
			}
			set {
				SetColumnValue("AccountIndustryName", value);
				if (_accountIndustry != null) {
					_accountIndustry.Name = value;
				}
			}
		}

		private AccountIndustry _accountIndustry;
		/// <summary>
		/// Industry.
		/// </summary>
		public AccountIndustry AccountIndustry {
			get {
				return _accountIndustry ??
					(_accountIndustry = LookupColumnEntities.GetEntity("AccountIndustry") as AccountIndustry);
			}
		}

		/// <summary>
		/// Job title.
		/// </summary>
		public string JobTitle {
			get {
				return GetTypedColumnValue<string>("JobTitle");
			}
			set {
				SetColumnValue("JobTitle", value);
			}
		}

		/// <summary>
		/// Role (string).
		/// </summary>
		public string ContactDecisionRoleStr {
			get {
				return GetTypedColumnValue<string>("ContactDecisionRoleStr");
			}
			set {
				SetColumnValue("ContactDecisionRoleStr", value);
			}
		}

		/// <exclude/>
		public Guid ContactDecisionRoleId {
			get {
				return GetTypedColumnValue<Guid>("ContactDecisionRoleId");
			}
			set {
				SetColumnValue("ContactDecisionRoleId", value);
				_contactDecisionRole = null;
			}
		}

		/// <exclude/>
		public string ContactDecisionRoleName {
			get {
				return GetTypedColumnValue<string>("ContactDecisionRoleName");
			}
			set {
				SetColumnValue("ContactDecisionRoleName", value);
				if (_contactDecisionRole != null) {
					_contactDecisionRole.Name = value;
				}
			}
		}

		private ContactDecisionRole _contactDecisionRole;
		/// <summary>
		/// Role.
		/// </summary>
		public ContactDecisionRole ContactDecisionRole {
			get {
				return _contactDecisionRole ??
					(_contactDecisionRole = LookupColumnEntities.GetEntity("ContactDecisionRole") as ContactDecisionRole);
			}
		}

		/// <summary>
		/// Work email.
		/// </summary>
		public string WorkEmail {
			get {
				return GetTypedColumnValue<string>("WorkEmail");
			}
			set {
				SetColumnValue("WorkEmail", value);
			}
		}

		/// <summary>
		/// No. of employees (string).
		/// </summary>
		public string AccountEmployeesNumberStr {
			get {
				return GetTypedColumnValue<string>("AccountEmployeesNumberStr");
			}
			set {
				SetColumnValue("AccountEmployeesNumberStr", value);
			}
		}

		/// <exclude/>
		public Guid AccountEmployeesNumberId {
			get {
				return GetTypedColumnValue<Guid>("AccountEmployeesNumberId");
			}
			set {
				SetColumnValue("AccountEmployeesNumberId", value);
				_accountEmployeesNumber = null;
			}
		}

		/// <exclude/>
		public string AccountEmployeesNumberName {
			get {
				return GetTypedColumnValue<string>("AccountEmployeesNumberName");
			}
			set {
				SetColumnValue("AccountEmployeesNumberName", value);
				if (_accountEmployeesNumber != null) {
					_accountEmployeesNumber.Name = value;
				}
			}
		}

		private AccountEmployeesNumber _accountEmployeesNumber;
		/// <summary>
		/// No. of employees.
		/// </summary>
		public AccountEmployeesNumber AccountEmployeesNumber {
			get {
				return _accountEmployeesNumber ??
					(_accountEmployeesNumber = LookupColumnEntities.GetEntity("AccountEmployeesNumber") as AccountEmployeesNumber);
			}
		}

		/// <summary>
		/// Account name.
		/// </summary>
		public string Account {
			get {
				return GetTypedColumnValue<string>("Account");
			}
			set {
				SetColumnValue("Account", value);
			}
		}

		/// <summary>
		/// Website.
		/// </summary>
		public string Website {
			get {
				return GetTypedColumnValue<string>("Website");
			}
			set {
				SetColumnValue("Website", value);
			}
		}

		/// <exclude/>
		public Guid GenderId {
			get {
				return GetTypedColumnValue<Guid>("GenderId");
			}
			set {
				SetColumnValue("GenderId", value);
				_gender = null;
			}
		}

		/// <exclude/>
		public string GenderName {
			get {
				return GetTypedColumnValue<string>("GenderName");
			}
			set {
				SetColumnValue("GenderName", value);
				if (_gender != null) {
					_gender.Name = value;
				}
			}
		}

		private Gender _gender;
		/// <summary>
		/// Gender.
		/// </summary>
		public Gender Gender {
			get {
				return _gender ??
					(_gender = LookupColumnEntities.GetEntity("Gender") as Gender);
			}
		}

		/// <exclude/>
		public Guid TimeZoneId {
			get {
				return GetTypedColumnValue<Guid>("TimeZoneId");
			}
			set {
				SetColumnValue("TimeZoneId", value);
				_timeZone = null;
			}
		}

		/// <exclude/>
		public string TimeZoneName {
			get {
				return GetTypedColumnValue<string>("TimeZoneName");
			}
			set {
				SetColumnValue("TimeZoneName", value);
				if (_timeZone != null) {
					_timeZone.Name = value;
				}
			}
		}

		private TimeZone _timeZone;
		/// <summary>
		/// Time zone.
		/// </summary>
		public TimeZone TimeZone {
			get {
				return _timeZone ??
					(_timeZone = LookupColumnEntities.GetEntity("TimeZone") as TimeZone);
			}
		}

		/// <exclude/>
		public Guid TerritoryId {
			get {
				return GetTypedColumnValue<Guid>("TerritoryId");
			}
			set {
				SetColumnValue("TerritoryId", value);
				_territory = null;
			}
		}

		/// <exclude/>
		public string TerritoryName {
			get {
				return GetTypedColumnValue<string>("TerritoryName");
			}
			set {
				SetColumnValue("TerritoryName", value);
				if (_territory != null) {
					_territory.Name = value;
				}
			}
		}

		private Territory _territory;
		/// <summary>
		/// Territory.
		/// </summary>
		public Territory Territory {
			get {
				return _territory ??
					(_territory = LookupColumnEntities.GetEntity("Territory") as Territory);
			}
		}

		/// <summary>
		/// City (string).
		/// </summary>
		public string CityStr {
			get {
				return GetTypedColumnValue<string>("CityStr");
			}
			set {
				SetColumnValue("CityStr", value);
			}
		}

		/// <exclude/>
		public Guid CityId {
			get {
				return GetTypedColumnValue<Guid>("CityId");
			}
			set {
				SetColumnValue("CityId", value);
				_city = null;
			}
		}

		/// <exclude/>
		public string CityName {
			get {
				return GetTypedColumnValue<string>("CityName");
			}
			set {
				SetColumnValue("CityName", value);
				if (_city != null) {
					_city.Name = value;
				}
			}
		}

		private City _city;
		/// <summary>
		/// City.
		/// </summary>
		public City City {
			get {
				return _city ??
					(_city = LookupColumnEntities.GetEntity("City") as City);
			}
		}

		/// <summary>
		/// Birth date.
		/// </summary>
		public DateTime BirthDate {
			get {
				return GetTypedColumnValue<DateTime>("BirthDate");
			}
			set {
				SetColumnValue("BirthDate", value);
			}
		}

		/// <summary>
		/// Password.
		/// </summary>
		public string Password {
			get {
				return GetTypedColumnValue<string>("Password");
			}
			set {
				SetColumnValue("Password", value);
			}
		}

		/// <summary>
		/// LinkedIn profile.
		/// </summary>
		public string LinkedInProfileUrl {
			get {
				return GetTypedColumnValue<string>("LinkedInProfileUrl");
			}
			set {
				SetColumnValue("LinkedInProfileUrl", value);
			}
		}

		/// <exclude/>
		public Guid RegisterMethodId {
			get {
				return GetTypedColumnValue<Guid>("RegisterMethodId");
			}
			set {
				SetColumnValue("RegisterMethodId", value);
				_registerMethod = null;
			}
		}

		/// <exclude/>
		public string RegisterMethodName {
			get {
				return GetTypedColumnValue<string>("RegisterMethodName");
			}
			set {
				SetColumnValue("RegisterMethodName", value);
				if (_registerMethod != null) {
					_registerMethod.Name = value;
				}
			}
		}

		private RegisterMethod _registerMethod;
		/// <summary>
		/// Registration method.
		/// </summary>
		public RegisterMethod RegisterMethod {
			get {
				return _registerMethod ??
					(_registerMethod = LookupColumnEntities.GetEntity("RegisterMethod") as RegisterMethod);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
			}
		}

		/// <exclude/>
		public Guid SourceId {
			get {
				return GetTypedColumnValue<Guid>("SourceId");
			}
			set {
				SetColumnValue("SourceId", value);
				_source = null;
			}
		}

		/// <exclude/>
		public string SourceName {
			get {
				return GetTypedColumnValue<string>("SourceName");
			}
			set {
				SetColumnValue("SourceName", value);
				if (_source != null) {
					_source.Name = value;
				}
			}
		}

		private LeadSource _source;
		/// <summary>
		/// Source.
		/// </summary>
		public LeadSource Source {
			get {
				return _source ??
					(_source = LookupColumnEntities.GetEntity("Source") as LeadSource);
			}
		}

		/// <exclude/>
		public Guid ChannelId {
			get {
				return GetTypedColumnValue<Guid>("ChannelId");
			}
			set {
				SetColumnValue("ChannelId", value);
				_channel = null;
			}
		}

		/// <exclude/>
		public string ChannelName {
			get {
				return GetTypedColumnValue<string>("ChannelName");
			}
			set {
				SetColumnValue("ChannelName", value);
				if (_channel != null) {
					_channel.Name = value;
				}
			}
		}

		private LeadMedium _channel;
		/// <summary>
		/// Channel.
		/// </summary>
		public LeadMedium Channel {
			get {
				return _channel ??
					(_channel = LookupColumnEntities.GetEntity("Channel") as LeadMedium);
			}
		}

		/// <summary>
		/// utm_campaign.
		/// </summary>
		public string UtmCampaignStr {
			get {
				return GetTypedColumnValue<string>("UtmCampaignStr");
			}
			set {
				SetColumnValue("UtmCampaignStr", value);
			}
		}

		/// <summary>
		/// utm_medium.
		/// </summary>
		public string UtmMediumStr {
			get {
				return GetTypedColumnValue<string>("UtmMediumStr");
			}
			set {
				SetColumnValue("UtmMediumStr", value);
			}
		}

		/// <summary>
		/// utm_source.
		/// </summary>
		public string UtmSourceStr {
			get {
				return GetTypedColumnValue<string>("UtmSourceStr");
			}
			set {
				SetColumnValue("UtmSourceStr", value);
			}
		}

		/// <summary>
		/// Redirection website.
		/// </summary>
		public string Referrer {
			get {
				return GetTypedColumnValue<string>("Referrer");
			}
			set {
				SetColumnValue("Referrer", value);
			}
		}

		/// <summary>
		/// Landing page URL.
		/// </summary>
		public string LandingPageURL {
			get {
				return GetTypedColumnValue<string>("LandingPageURL");
			}
			set {
				SetColumnValue("LandingPageURL", value);
			}
		}

		/// <summary>
		/// utm_term.
		/// </summary>
		public string UtmTermStr {
			get {
				return GetTypedColumnValue<string>("UtmTermStr");
			}
			set {
				SetColumnValue("UtmTermStr", value);
			}
		}

		/// <summary>
		/// utm_content.
		/// </summary>
		public string UtmContentStr {
			get {
				return GetTypedColumnValue<string>("UtmContentStr");
			}
			set {
				SetColumnValue("UtmContentStr", value);
			}
		}

		/// <exclude/>
		public Guid CustomerNeedId {
			get {
				return GetTypedColumnValue<Guid>("CustomerNeedId");
			}
			set {
				SetColumnValue("CustomerNeedId", value);
				_customerNeed = null;
			}
		}

		/// <exclude/>
		public string CustomerNeedName {
			get {
				return GetTypedColumnValue<string>("CustomerNeedName");
			}
			set {
				SetColumnValue("CustomerNeedName", value);
				if (_customerNeed != null) {
					_customerNeed.Name = value;
				}
			}
		}

		private LeadType _customerNeed;
		/// <summary>
		/// Customer need.
		/// </summary>
		public LeadType CustomerNeed {
			get {
				return _customerNeed ??
					(_customerNeed = LookupColumnEntities.GetEntity("CustomerNeed") as LeadType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FormSubmit_CrtTouchPointEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("FormSubmit_CrtTouchPoint_TerrasoftInserting", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FormSubmit_CrtTouchPoint_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: FormSubmit_CrtTouchPointEventsProcess

	/// <exclude/>
	public partial class FormSubmit_CrtTouchPointEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : FormSubmit_CrtTouchPoint_Terrasoft
	{

		public FormSubmit_CrtTouchPointEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FormSubmit_CrtTouchPointEventsProcess";
			SchemaUId = new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5e2c524a-666f-491c-ba9f-ce03e82bb015");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_4cd86c3d5c2743c48a86099df6e7fe33;
		public ProcessFlowElement EventSubProcess3_4cd86c3d5c2743c48a86099df6e7fe33 {
			get {
				return _eventSubProcess3_4cd86c3d5c2743c48a86099df6e7fe33 ?? (_eventSubProcess3_4cd86c3d5c2743c48a86099df6e7fe33 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_4cd86c3d5c2743c48a86099df6e7fe33",
					SchemaElementUId = new Guid("4cd86c3d-5c27-43c4-8a86-099df6e7fe33"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_1152ad7743c94eeea26aa67b56e40fc6;
		public ProcessFlowElement StartMessage3_1152ad7743c94eeea26aa67b56e40fc6 {
			get {
				return _startMessage3_1152ad7743c94eeea26aa67b56e40fc6 ?? (_startMessage3_1152ad7743c94eeea26aa67b56e40fc6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_1152ad7743c94eeea26aa67b56e40fc6",
					SchemaElementUId = new Guid("1152ad77-43c9-4eee-a26a-a67b56e40fc6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_27b1dca261e944ab83d99e7d9b6f2880;
		public ProcessScriptTask ScriptTask3_27b1dca261e944ab83d99e7d9b6f2880 {
			get {
				return _scriptTask3_27b1dca261e944ab83d99e7d9b6f2880 ?? (_scriptTask3_27b1dca261e944ab83d99e7d9b6f2880 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_27b1dca261e944ab83d99e7d9b6f2880",
					SchemaElementUId = new Guid("27b1dca2-61e9-44ab-83d9-9e7d9b6f2880"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_27b1dca261e944ab83d99e7d9b6f2880Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_4cd86c3d5c2743c48a86099df6e7fe33.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_4cd86c3d5c2743c48a86099df6e7fe33 };
			FlowElements[StartMessage3_1152ad7743c94eeea26aa67b56e40fc6.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_1152ad7743c94eeea26aa67b56e40fc6 };
			FlowElements[ScriptTask3_27b1dca261e944ab83d99e7d9b6f2880.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_27b1dca261e944ab83d99e7d9b6f2880 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_4cd86c3d5c2743c48a86099df6e7fe33":
						break;
					case "StartMessage3_1152ad7743c94eeea26aa67b56e40fc6":
						e.Context.QueueTasks.Enqueue("ScriptTask3_27b1dca261e944ab83d99e7d9b6f2880");
						break;
					case "ScriptTask3_27b1dca261e944ab83d99e7d9b6f2880":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_1152ad7743c94eeea26aa67b56e40fc6");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_4cd86c3d5c2743c48a86099df6e7fe33":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_1152ad7743c94eeea26aa67b56e40fc6":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_1152ad7743c94eeea26aa67b56e40fc6";
					result = StartMessage3_1152ad7743c94eeea26aa67b56e40fc6.Execute(context);
					break;
				case "ScriptTask3_27b1dca261e944ab83d99e7d9b6f2880":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_27b1dca261e944ab83d99e7d9b6f2880";
					result = ScriptTask3_27b1dca261e944ab83d99e7d9b6f2880.Execute(context, ScriptTask3_27b1dca261e944ab83d99e7d9b6f2880Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3_27b1dca261e944ab83d99e7d9b6f2880Execute(ProcessExecutingContext context) {
			FormSubmitInserting();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "FormSubmit_CrtTouchPoint_TerrasoftInserting":
							if (ActivatedEventElements.Contains("StartMessage3_1152ad7743c94eeea26aa67b56e40fc6")) {
							context.QueueTasks.Enqueue("StartMessage3_1152ad7743c94eeea26aa67b56e40fc6");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: FormSubmit_CrtTouchPointEventsProcess

	/// <exclude/>
	public class FormSubmit_CrtTouchPointEventsProcess : FormSubmit_CrtTouchPointEventsProcess<FormSubmit_CrtTouchPoint_Terrasoft>
	{

		public FormSubmit_CrtTouchPointEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

