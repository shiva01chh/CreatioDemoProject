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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,87,93,111,219,54,20,125,118,129,254,7,193,126,113,0,211,21,37,74,164,154,109,0,37,145,217,128,21,13,154,108,121,44,84,153,113,133,218,82,64,74,27,188,194,255,125,20,169,216,137,172,116,217,92,212,125,152,96,59,22,125,239,185,231,126,224,234,164,204,214,66,221,101,185,112,174,133,148,153,170,110,235,121,82,149,183,197,178,145,89,93,84,229,203,23,159,95,190,24,53,170,40,151,206,213,70,213,98,125,222,187,215,246,171,149,200,91,99,53,191,16,165,144,69,190,183,121,8,43,197,240,249,122,93,149,237,47,250,53,145,98,169,129,156,100,149,41,245,218,249,185,106,164,122,43,223,20,101,83,11,101,14,173,221,93,243,97,85,228,78,222,158,60,97,213,242,222,225,241,66,172,22,26,240,82,22,127,100,181,104,127,106,223,119,246,214,249,77,9,169,211,46,109,26,206,251,230,209,253,249,189,249,68,148,11,11,184,59,233,240,47,101,117,39,100,93,136,54,134,225,182,11,97,153,254,90,229,217,170,248,43,251,176,18,87,181,108,43,96,88,59,134,229,104,41,234,238,219,72,138,186,145,165,83,138,63,15,125,166,23,162,126,39,148,118,204,245,73,37,179,165,152,158,205,156,241,165,174,121,181,40,242,162,222,176,178,89,171,241,204,98,141,198,7,16,106,110,226,206,127,207,86,141,24,159,205,175,171,14,250,204,100,57,218,182,159,219,127,36,223,213,250,4,244,187,200,207,76,224,233,142,233,246,170,90,54,185,230,241,84,207,6,230,106,218,155,148,199,131,114,214,85,161,55,63,206,143,61,187,115,27,230,25,44,223,136,250,99,245,133,193,253,165,87,79,103,168,196,173,131,37,246,234,213,100,50,153,57,19,123,221,255,125,116,231,76,156,155,74,126,178,75,33,121,7,177,239,7,145,113,238,90,219,75,110,222,11,119,254,175,51,27,42,125,90,24,240,76,110,126,184,104,138,197,236,112,152,126,106,83,125,220,161,233,125,253,31,12,225,51,128,118,110,250,250,220,250,180,134,211,49,143,226,208,35,46,1,156,133,46,64,30,228,32,10,8,2,148,114,150,64,230,193,4,165,99,61,190,134,195,118,54,128,0,61,206,32,34,4,160,48,134,0,165,60,1,49,244,33,128,4,147,0,115,159,4,148,181,8,29,253,237,246,11,181,219,118,251,241,225,217,225,190,76,179,141,122,123,123,35,196,167,167,118,229,161,197,247,190,39,175,154,114,145,109,78,176,105,108,224,163,55,101,117,34,250,54,240,177,244,175,27,161,78,195,191,139,124,108,2,55,98,81,158,42,133,93,236,163,187,240,81,239,152,19,181,161,11,125,108,10,92,22,167,73,192,6,62,150,254,85,166,105,158,104,15,117,161,191,133,228,233,61,30,254,151,59,223,149,220,217,119,231,235,74,29,173,69,82,200,144,11,188,148,4,0,81,228,3,202,147,0,68,8,83,63,65,24,163,20,182,66,197,62,17,7,181,14,71,44,34,41,247,65,130,168,214,58,12,50,64,56,102,0,97,31,249,12,19,70,168,81,75,246,169,52,8,129,99,138,49,79,60,192,220,144,107,199,32,4,17,137,19,64,96,132,9,68,1,73,99,35,151,186,7,195,176,228,98,62,12,24,213,113,67,166,51,113,113,0,136,79,19,16,197,81,144,166,94,192,17,246,90,140,221,102,30,78,134,160,196,247,169,15,60,196,180,122,163,90,179,197,73,64,64,202,81,18,96,63,76,41,14,13,147,110,55,14,131,80,47,112,73,144,128,84,203,61,128,2,151,3,66,57,1,36,242,82,152,82,234,187,46,106,65,236,126,26,132,240,67,61,140,36,100,32,132,9,213,41,33,4,34,236,235,138,196,65,234,106,18,46,73,92,211,151,110,67,252,23,5,217,77,160,208,107,168,247,15,79,187,153,236,184,152,115,181,19,170,106,143,246,208,123,63,157,123,79,61,49,166,231,166,107,166,236,166,106,38,107,195,219,66,233,151,190,254,6,243,33,130,252,141,16,0,0 };
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

