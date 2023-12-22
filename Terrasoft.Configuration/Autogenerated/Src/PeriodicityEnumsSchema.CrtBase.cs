namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PeriodicityEnumsSchema

	/// <exclude/>
	public class PeriodicityEnumsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PeriodicityEnumsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PeriodicityEnumsSchema(PeriodicityEnumsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01");
			Name = "PeriodicityEnums";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,87,93,111,219,54,20,125,118,129,254,7,193,126,113,0,211,21,37,74,162,150,109,0,37,145,217,128,21,13,154,108,121,28,84,153,113,133,218,82,64,74,27,188,194,255,125,252,80,108,71,86,186,108,30,230,62,76,176,29,139,190,247,220,115,63,112,117,82,229,107,46,31,242,130,59,183,92,136,92,214,247,205,60,173,171,251,114,217,138,188,41,235,234,245,171,207,175,95,141,90,89,86,75,231,102,35,27,190,190,236,221,43,251,213,138,23,218,88,206,175,120,197,69,89,236,109,14,97,5,31,62,95,175,235,74,255,162,94,19,193,151,10,200,73,87,185,148,223,56,63,212,173,144,239,196,219,178,106,27,46,205,161,181,123,104,63,172,202,194,41,244,201,51,86,154,247,14,143,149,124,181,80,128,215,162,252,45,111,184,254,73,191,31,236,173,243,179,228,66,165,93,217,52,156,95,219,39,247,151,143,230,19,94,45,44,224,238,164,195,191,22,245,3,23,77,201,117,12,195,109,23,194,50,253,169,46,242,85,249,71,254,97,197,111,26,161,43,96,88,59,134,229,104,201,155,238,219,72,240,166,21,149,83,241,223,143,125,166,87,188,121,207,165,114,44,212,73,45,242,37,159,94,204,156,241,181,170,121,189,40,139,178,217,208,170,93,203,241,204,98,141,198,71,16,114,110,226,206,127,201,87,45,31,95,204,111,235,14,250,194,100,57,218,234,207,237,95,146,239,106,125,6,250,93,228,23,38,240,124,199,84,123,101,35,218,66,241,120,174,103,3,115,53,237,77,202,211,65,185,232,170,208,155,31,231,187,158,221,165,13,243,2,150,111,121,243,177,254,194,224,254,216,171,167,51,84,98,237,96,137,189,121,51,153,76,102,206,196,94,143,127,159,220,57,19,231,174,22,159,236,82,72,223,195,200,247,131,216,56,119,173,237,37,55,239,133,187,252,219,153,13,149,62,43,13,120,46,54,223,94,181,229,98,118,60,76,223,235,84,159,118,104,250,88,255,131,33,124,1,208,206,77,93,159,181,143,54,156,142,89,156,132,30,118,49,96,52,116,1,242,32,3,113,128,17,32,132,209,20,82,15,166,40,27,171,241,53,28,182,179,1,4,232,49,10,17,198,0,133,9,4,40,99,41,72,160,15,1,196,17,14,34,230,227,128,80,141,208,209,223,110,191,80,187,109,183,31,15,207,142,247,101,150,111,228,187,251,59,206,63,61,183,43,143,45,190,246,61,121,211,86,139,124,115,134,77,99,3,159,188,41,235,51,209,183,129,79,165,127,219,114,121,30,254,93,228,83,19,184,227,139,234,92,41,236,98,159,220,133,143,106,199,156,169,13,93,232,83,83,96,162,60,79,2,54,240,169,244,111,114,69,243,76,123,168,11,253,95,72,158,222,227,225,127,185,243,85,201,157,125,119,254,93,169,163,180,72,6,41,114,129,151,225,0,32,130,124,64,88,26,128,24,69,196,79,81,20,161,12,106,161,98,159,136,131,90,135,33,26,227,140,249,32,69,68,105,29,10,41,192,44,162,0,69,62,242,105,132,41,38,70,45,217,167,210,32,68,148,144,40,98,169,7,168,27,50,229,24,132,32,198,73,10,48,140,35,12,81,128,179,196,200,165,238,193,48,44,185,168,15,3,74,84,220,144,170,76,220,40,0,216,39,41,136,147,56,200,50,47,96,40,242,52,198,110,51,15,39,131,81,234,251,196,7,30,162,74,189,17,165,217,146,52,192,32,99,40,13,34,63,204,72,20,26,38,221,110,28,6,33,94,224,226,32,5,153,146,123,0,5,46,3,152,48,12,112,236,101,48,35,196,119,93,164,65,236,126,26,132,240,67,53,140,56,164,32,132,41,81,41,33,4,226,200,87,21,73,130,204,85,36,92,156,186,166,47,221,134,248,39,10,178,155,64,174,214,80,239,31,30,189,153,236,184,152,115,185,19,170,114,143,118,232,189,159,206,189,167,154,24,211,115,211,53,83,118,83,53,147,181,225,109,161,212,235,240,250,19,121,61,210,50,150,16,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateHoursLocalizableString());
			LocalizableStrings.Add(CreateMinutesLocalizableString());
			LocalizableStrings.Add(CreateSundayLocalizableString());
			LocalizableStrings.Add(CreateSaturdayLocalizableString());
			LocalizableStrings.Add(CreateFridayLocalizableString());
			LocalizableStrings.Add(CreateThursdayLocalizableString());
			LocalizableStrings.Add(CreateWednesdayLocalizableString());
			LocalizableStrings.Add(CreateTuesdayLocalizableString());
			LocalizableStrings.Add(CreateMondayLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateHoursLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("12f23832-fa87-4303-aacd-c714edf36063"),
				Name = "Hours",
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"),
				ModifiedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMinutesLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("65f8dfe4-7ce0-435b-abc2-6bc7c5d56ace"),
				Name = "Minutes",
				CreatedInPackageId = new Guid("e5f52fab-ebea-4990-be49-0763f7c9fbd6"),
				CreatedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"),
				ModifiedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSundayLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a8d5eda9-2165-4a96-9e78-d74c46256197"),
				Name = "Sunday",
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"),
				ModifiedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSaturdayLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1020d386-033c-46b6-a17f-8e39fb443bc2"),
				Name = "Saturday",
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"),
				ModifiedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFridayLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bfeef8db-c2a7-438b-a423-cb94b9790dd6"),
				Name = "Friday",
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"),
				ModifiedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateThursdayLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0b2c9a60-8c38-49fa-a995-ace5363fa8d1"),
				Name = "Thursday",
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"),
				ModifiedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWednesdayLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fade33fe-e073-4386-af12-715568054744"),
				Name = "Wednesday",
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"),
				ModifiedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTuesdayLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("165ca4ef-8cfc-4d1c-874e-ed4de8b3461e"),
				Name = "Tuesday",
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"),
				ModifiedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMondayLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5664557f-389b-421d-a281-b77b0f6df8fb"),
				Name = "Monday",
				CreatedInPackageId = new Guid("f9ecdc95-9cb8-443d-ba94-66f513ca3a49"),
				CreatedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"),
				ModifiedInSchemaUId = new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5e9cfccc-3c95-437a-81fa-d9e23582df01"));
		}

		#endregion

	}

	#endregion

}

