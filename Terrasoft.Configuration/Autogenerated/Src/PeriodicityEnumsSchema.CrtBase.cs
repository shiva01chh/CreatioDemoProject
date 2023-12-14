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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,87,93,111,219,54,20,125,118,129,254,7,193,126,113,0,211,149,68,74,164,154,109,0,37,145,217,128,21,13,154,108,121,44,84,153,113,133,218,82,64,73,27,188,194,255,125,252,80,236,68,86,186,108,46,234,62,76,176,29,139,190,247,220,115,63,112,117,82,102,107,81,223,101,185,112,174,133,148,89,93,221,54,243,164,42,111,139,101,43,179,166,168,202,151,47,62,191,124,49,106,235,162,92,58,87,155,186,17,235,243,222,189,178,95,173,68,174,141,235,249,133,40,133,44,242,189,205,67,88,41,134,207,215,235,170,212,191,168,215,68,138,165,2,114,146,85,86,215,175,157,159,171,86,214,111,229,155,162,108,27,81,155,67,107,119,215,126,88,21,185,147,235,147,39,172,52,239,29,30,47,196,106,161,0,47,101,241,71,214,8,253,147,126,223,217,91,231,183,90,72,149,118,105,211,112,222,183,143,238,207,239,205,39,162,92,88,192,221,73,135,127,41,171,59,33,155,66,232,24,134,219,46,132,101,250,107,149,103,171,226,175,236,195,74,92,53,82,87,192,176,118,12,203,209,82,52,221,183,145,20,77,43,75,167,20,127,30,250,76,47,68,243,78,212,202,49,87,39,149,204,150,98,122,54,115,198,151,170,230,213,162,200,139,102,195,202,118,93,143,103,22,107,52,62,128,168,231,38,238,252,247,108,213,138,241,217,252,186,234,160,207,76,150,163,173,254,220,254,35,249,174,214,39,160,223,69,126,102,2,79,119,76,181,183,110,100,155,43,30,79,245,108,96,174,166,189,73,121,60,40,103,93,21,122,243,227,252,216,179,59,183,97,158,193,242,141,104,62,86,95,24,220,95,122,245,116,134,74,172,29,44,177,87,175,38,147,201,204,153,216,235,254,239,163,59,103,226,220,84,242,147,93,10,201,59,15,67,24,68,198,185,107,109,47,185,121,47,220,249,191,206,108,168,244,105,97,192,51,185,249,225,162,45,22,179,195,97,250,73,167,250,184,67,211,251,250,63,24,194,103,0,237,220,212,245,89,251,104,195,233,152,71,113,232,19,151,0,206,66,23,32,223,227,32,10,8,2,148,114,150,120,204,247,18,148,142,213,248,26,14,219,217,0,130,231,115,230,33,66,0,10,99,15,160,148,39,32,246,160,7,60,130,73,128,57,36,1,101,26,161,163,191,221,126,161,118,219,110,63,62,60,59,220,151,105,182,169,223,222,222,8,241,233,169,93,121,104,241,189,239,201,171,182,92,100,155,19,108,26,27,248,232,77,89,157,136,190,13,124,44,253,235,86,212,167,225,223,69,62,54,129,27,177,40,79,149,194,46,246,209,93,248,168,118,204,137,218,208,133,62,54,5,46,139,211,36,96,3,31,75,255,42,83,52,79,180,135,186,208,223,66,242,244,30,15,255,203,157,239,74,238,236,187,243,117,165,142,210,34,169,199,144,11,252,148,4,0,81,4,1,229,73,0,34,132,41,76,16,198,40,245,180,80,177,79,196,65,173,195,17,139,72,202,33,72,16,85,90,135,121,12,16,142,25,64,24,34,200,48,97,132,26,181,100,159,74,131,16,56,166,24,243,196,7,204,13,185,114,12,66,16,145,56,1,196,139,48,241,80,64,210,216,200,165,238,193,48,44,185,24,244,2,70,85,220,144,169,76,92,28,0,2,105,2,162,56,10,210,212,15,56,194,190,198,216,109,230,225,100,8,74,32,164,16,248,136,41,245,70,149,102,139,147,128,128,148,163,36,192,48,76,41,14,13,147,110,55,14,131,80,63,112,73,144,128,84,201,61,128,2,151,3,66,57,1,36,242,83,47,165,20,186,46,210,32,118,63,13,66,192,80,13,35,9,25,8,189,132,170,148,16,2,17,134,170,34,113,144,186,138,132,75,18,215,244,165,219,16,255,69,65,118,19,40,212,26,234,253,195,163,55,147,29,23,115,94,239,132,106,189,71,123,232,189,159,206,189,167,154,24,211,115,211,53,83,118,83,53,147,181,225,109,161,212,75,95,127,3,20,39,159,22,142,16,0,0 };
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

