﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SchemaDataBindingServiceSchema

	/// <exclude/>
	public class SchemaDataBindingServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SchemaDataBindingServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SchemaDataBindingServiceSchema(SchemaDataBindingServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e26d97b6-aa43-43af-9c0f-48a8116d1bc2");
			Name = "SchemaDataBindingService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,26,93,111,219,56,242,57,11,236,127,96,189,139,133,12,248,148,20,184,125,105,98,7,249,220,243,93,155,102,99,247,250,80,20,11,69,98,18,93,101,201,37,169,36,222,110,254,251,205,240,67,34,41,202,118,218,190,28,112,5,218,90,228,204,112,56,51,156,25,206,176,76,22,148,47,147,148,146,57,101,44,225,213,141,136,79,170,242,38,191,173,89,34,242,170,252,241,135,47,63,254,176,83,243,188,188,37,179,21,23,116,177,239,125,3,124,81,208,20,129,121,252,27,45,41,203,211,181,48,111,175,255,3,63,223,84,25,45,58,112,175,243,242,115,103,112,70,217,125,158,210,48,134,61,25,31,193,18,247,146,239,245,112,239,233,117,11,112,65,31,4,240,133,91,255,39,183,49,109,145,44,22,125,51,140,246,141,199,103,165,200,69,78,121,47,192,121,146,138,138,173,131,184,76,210,79,201,237,26,128,121,194,63,5,103,47,234,220,221,244,217,163,160,37,71,21,132,192,65,36,237,54,97,254,39,70,111,1,150,156,20,9,231,175,200,44,189,163,139,228,52,17,201,113,94,102,128,122,12,140,221,178,170,46,51,228,224,50,97,96,73,130,50,46,145,151,245,117,145,167,36,69,220,231,160,238,160,177,53,75,95,178,106,73,25,10,240,21,185,148,20,37,113,67,157,11,38,245,43,201,95,0,13,34,177,119,110,169,216,151,63,184,254,241,228,160,253,86,231,217,135,143,228,138,166,21,203,166,25,223,30,11,77,73,235,227,221,52,219,128,247,19,45,51,181,15,249,173,70,189,193,231,201,248,217,146,37,175,200,212,29,57,216,90,23,147,17,153,190,227,148,129,51,40,213,193,189,162,159,235,156,209,76,105,201,214,211,121,78,139,12,117,196,240,240,81,45,55,245,65,166,214,98,64,76,48,244,4,140,252,145,133,134,247,109,76,70,147,172,42,139,21,201,75,65,254,88,36,143,167,148,167,44,95,194,137,121,77,203,91,113,71,198,228,239,123,123,251,65,121,135,141,200,102,112,119,119,151,28,240,122,177,72,216,106,98,6,112,203,36,109,246,28,55,128,187,54,164,225,208,21,144,255,185,222,62,130,203,163,172,200,181,146,10,178,161,197,178,129,141,30,17,135,71,199,18,117,103,39,172,0,114,120,72,162,158,169,177,178,83,229,179,86,224,234,197,65,120,229,73,164,150,216,41,233,3,129,97,56,168,53,226,28,177,219,122,65,75,17,13,106,71,82,131,145,39,186,225,112,184,65,171,111,168,184,171,122,109,78,123,6,224,240,117,149,38,69,254,103,114,93,208,153,28,140,244,156,60,64,232,52,70,6,154,81,94,213,44,165,56,56,212,202,187,79,24,41,124,18,32,136,159,7,29,194,60,254,98,83,120,138,255,157,20,53,29,104,221,55,75,212,133,0,124,20,76,151,53,87,8,241,149,38,55,3,209,129,203,25,41,161,90,140,119,56,27,170,213,24,21,53,43,245,106,142,47,211,242,185,175,192,153,157,192,249,18,244,138,46,148,250,184,145,12,111,252,233,200,248,74,102,124,229,40,108,84,87,106,95,106,65,35,187,252,134,68,102,195,176,227,186,40,204,140,102,80,49,251,36,255,85,204,156,49,86,49,155,35,139,21,77,124,223,2,159,213,105,74,57,111,16,60,248,134,103,27,181,95,18,93,106,223,87,30,141,13,32,253,89,45,147,32,48,133,160,145,14,58,126,90,71,114,56,42,3,205,232,73,178,148,135,103,232,152,24,87,147,111,224,47,216,140,162,239,239,76,79,70,61,34,218,193,93,30,106,70,1,220,68,74,32,214,96,196,198,3,143,201,75,2,46,67,162,12,155,233,15,123,31,33,248,160,206,21,197,89,114,79,251,212,100,137,99,228,177,63,234,50,17,212,98,123,222,251,182,250,45,138,67,39,144,66,132,20,210,60,53,69,174,68,123,210,25,143,28,81,98,232,210,123,186,169,11,92,79,98,56,162,148,35,209,144,252,45,176,138,163,91,12,12,200,118,171,220,32,233,16,237,67,162,78,222,87,91,155,94,115,48,4,189,126,45,41,185,51,207,108,181,175,82,59,140,207,43,182,72,68,228,109,116,20,218,231,168,187,203,81,64,128,65,123,57,205,165,135,133,56,122,128,134,97,66,192,4,53,138,11,208,76,153,91,208,39,110,111,56,175,115,46,228,2,147,150,87,169,121,4,138,21,138,225,243,48,254,23,93,241,120,94,33,82,100,172,71,186,208,6,83,121,81,242,215,95,254,214,113,106,207,243,174,214,233,83,46,86,94,70,86,74,63,132,218,31,99,47,252,198,54,232,155,164,4,254,24,134,251,41,68,242,164,76,233,241,10,37,97,29,99,139,93,155,112,12,193,25,147,149,211,156,47,139,100,5,119,192,122,81,246,4,131,181,236,254,94,83,182,146,230,223,104,230,108,246,187,58,129,199,222,168,195,129,101,36,154,71,69,182,189,142,130,201,152,159,154,6,144,245,87,194,205,251,136,94,180,118,205,185,67,20,20,219,26,93,4,71,119,66,168,17,143,146,139,76,23,70,196,157,114,36,39,33,244,58,36,96,213,93,137,133,196,211,107,6,35,18,178,87,219,9,6,20,128,137,76,103,93,71,5,154,225,142,72,245,14,37,130,218,95,60,229,71,197,67,178,226,51,90,168,216,8,121,35,125,142,105,189,240,76,171,179,232,81,150,41,80,151,24,200,41,68,79,90,249,112,104,91,101,135,226,121,94,224,117,9,41,71,157,73,149,88,40,144,247,185,184,107,175,87,58,67,86,83,112,237,94,38,44,231,85,57,95,45,105,124,246,185,78,10,157,237,13,166,217,96,100,206,73,115,230,19,208,83,37,35,230,36,26,130,105,29,193,37,126,21,13,135,174,17,250,236,172,143,156,189,22,39,99,103,99,16,163,126,231,233,172,103,116,16,226,229,48,62,42,129,93,244,4,168,97,242,203,47,238,124,60,103,43,224,72,173,222,46,92,213,130,160,25,106,39,171,164,114,168,63,213,215,43,19,72,206,22,75,177,82,210,88,159,245,117,82,206,111,113,248,104,165,47,254,145,112,73,180,201,4,250,210,222,239,155,21,218,81,207,4,215,206,161,13,184,204,254,36,251,166,2,9,165,119,36,66,50,212,34,15,23,242,112,16,107,118,170,212,212,164,141,54,50,198,185,253,22,42,235,216,155,226,177,223,28,91,131,112,13,206,34,42,215,155,211,71,45,201,243,156,113,39,43,136,28,134,108,191,170,57,71,101,156,185,68,174,218,65,135,10,66,244,32,183,121,218,11,109,150,83,126,1,254,233,45,147,230,25,117,247,14,137,154,190,58,255,60,248,210,157,126,138,201,23,143,185,167,1,121,165,81,188,25,205,211,214,169,119,151,241,54,122,218,62,208,59,75,215,85,85,144,214,230,183,63,44,218,51,188,208,150,164,243,76,116,6,61,9,146,227,52,214,59,179,128,178,166,130,46,64,136,121,38,203,195,70,53,247,254,136,199,93,103,62,246,254,15,241,129,73,127,248,110,176,78,58,104,205,87,65,9,181,210,181,97,76,74,191,215,100,228,237,172,39,59,16,238,34,202,65,0,152,92,4,15,4,78,234,131,96,162,40,44,240,18,72,239,5,51,232,176,52,131,164,219,148,233,32,136,53,33,11,207,125,232,125,155,225,88,210,124,203,78,233,77,2,155,138,152,220,6,91,248,170,192,224,137,230,97,125,198,146,147,254,155,191,119,56,186,190,95,15,229,229,77,213,94,70,212,88,166,171,145,176,19,85,24,56,180,93,158,157,135,200,11,100,205,24,228,28,178,190,216,201,183,79,218,201,214,113,171,243,56,207,23,232,64,44,116,204,86,52,2,152,19,69,128,200,73,110,191,58,197,63,135,245,54,229,248,141,180,218,171,185,78,3,91,57,246,100,198,122,58,158,81,1,170,180,220,26,143,58,48,71,181,184,171,152,148,164,189,117,60,52,73,42,166,89,135,166,172,148,73,248,134,15,89,121,228,113,243,173,96,12,101,159,66,67,122,219,37,175,108,253,180,202,242,193,46,171,101,189,156,231,162,64,48,203,142,186,55,188,78,250,106,109,79,57,105,167,6,163,142,171,157,156,118,224,245,93,27,144,46,25,133,20,179,181,117,23,32,178,108,185,171,174,21,183,141,69,5,116,59,123,126,23,80,7,156,171,104,93,169,102,3,63,77,49,203,30,109,178,44,112,175,139,228,17,99,92,211,7,248,85,246,1,180,64,93,52,83,170,154,184,72,141,148,185,47,43,15,29,88,83,236,68,123,35,143,132,43,124,85,200,112,144,215,52,132,2,165,108,171,197,37,139,253,121,121,71,89,46,178,42,37,41,163,55,227,129,215,205,137,175,234,50,154,183,151,138,225,96,87,245,5,84,143,72,122,56,4,217,186,233,67,150,45,45,45,158,205,241,156,140,149,28,131,144,170,33,12,138,63,54,9,118,187,68,60,179,28,173,53,220,116,230,156,81,167,247,230,148,129,173,236,253,89,196,3,101,225,30,177,135,27,97,232,200,220,25,223,243,5,244,177,9,135,184,173,17,163,6,15,104,236,129,125,239,198,163,190,87,72,216,15,250,67,42,21,60,225,71,28,59,226,203,11,204,112,224,226,42,242,235,188,0,111,160,197,130,13,30,30,217,31,216,125,6,142,55,160,32,84,108,68,59,196,69,214,183,58,53,87,144,161,28,39,156,54,12,251,189,73,183,253,87,9,144,23,182,48,149,75,210,159,50,97,123,147,60,30,21,69,245,208,92,40,206,33,133,1,251,200,185,174,70,76,200,203,189,141,221,70,171,219,21,236,89,247,109,35,194,186,234,53,108,4,126,124,33,79,219,96,108,176,27,77,174,99,78,100,107,119,20,234,172,201,108,127,202,79,146,82,37,13,51,136,226,210,138,189,220,205,203,54,78,143,103,20,130,42,168,252,172,188,205,75,42,115,152,164,60,123,132,81,65,223,46,169,122,108,18,13,58,132,7,193,40,162,203,249,237,61,209,206,38,206,89,181,208,101,153,53,41,221,141,46,189,224,91,23,59,81,83,227,120,83,198,199,32,48,127,15,230,19,159,82,216,80,142,247,113,170,158,175,28,172,121,104,129,202,50,167,197,20,136,38,145,179,96,155,230,25,243,146,57,212,182,68,85,133,76,21,249,116,24,187,170,42,97,61,133,24,219,123,182,139,77,184,51,189,71,61,14,186,50,181,6,237,92,240,130,165,66,91,203,39,229,159,145,168,92,56,62,174,243,34,59,227,159,195,169,30,130,47,109,189,104,142,128,68,220,178,25,251,218,83,229,182,158,50,45,213,79,105,52,153,231,22,100,13,186,150,92,244,136,231,249,17,201,224,53,33,179,204,71,21,64,163,14,255,67,171,208,22,50,73,231,213,148,214,28,196,201,37,56,4,121,49,210,133,38,53,96,236,178,211,193,61,1,93,175,109,62,159,67,130,120,162,28,106,184,9,29,36,233,118,163,145,240,162,169,77,124,67,47,122,93,65,170,151,115,87,49,250,137,64,175,232,34,89,97,126,76,169,74,12,53,219,195,225,183,101,86,254,187,11,147,165,112,243,248,130,147,155,202,148,176,56,121,200,33,127,204,5,199,236,14,6,242,18,21,14,134,36,3,87,207,227,12,57,34,19,15,82,130,249,140,7,237,121,28,76,228,129,168,110,244,25,141,15,118,37,96,24,175,169,251,14,38,216,5,2,44,195,150,168,200,53,53,28,119,137,40,9,243,137,137,148,76,139,20,32,205,20,194,126,104,220,175,29,225,119,62,188,167,215,211,242,190,250,68,35,37,71,48,149,193,229,219,217,28,116,139,97,154,114,161,186,117,48,14,160,250,86,163,134,228,59,186,17,57,174,178,213,76,172,228,205,167,5,105,70,227,247,44,89,194,225,27,233,139,165,226,110,61,81,153,24,152,208,184,225,200,121,137,231,86,237,124,89,235,230,78,170,105,215,118,131,145,207,239,100,117,14,251,64,30,166,164,44,43,225,226,122,229,218,167,206,149,144,183,151,151,13,249,201,102,38,230,85,5,171,175,52,182,242,131,52,11,178,32,47,23,51,145,48,113,65,31,176,113,225,122,131,77,175,200,70,219,63,249,51,79,133,240,148,111,127,77,209,91,221,89,31,239,118,218,39,126,86,75,220,76,186,111,249,198,174,210,21,140,18,198,51,253,85,247,62,241,191,228,108,236,36,101,48,81,25,3,250,153,91,42,26,6,145,217,255,59,157,173,156,206,241,74,137,112,203,60,84,219,102,191,19,178,251,42,220,105,148,244,38,192,214,138,129,12,180,241,22,190,179,12,191,164,226,221,75,248,246,183,78,57,102,255,249,47,182,102,61,253,125,46,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSuccessCaptionLocalizableString());
			LocalizableStrings.Add(CreateErrorCaptionLocalizableString());
			LocalizableStrings.Add(CreateUserCannotManageSolutionMessageLocalizableString());
			LocalizableStrings.Add(CreateTooManyRecordsSelectedMessageLocalizableString());
			LocalizableStrings.Add(CreateSuccessMessageLocalizableString());
			LocalizableStrings.Add(CreateErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSuccessCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3e2995f6-745a-45d1-b12c-c302c5766e4c"),
				Name = "SuccessCaption",
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				CreatedInSchemaUId = new Guid("e26d97b6-aa43-43af-9c0f-48a8116d1bc2"),
				ModifiedInSchemaUId = new Guid("e26d97b6-aa43-43af-9c0f-48a8116d1bc2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateErrorCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("93826947-9cc6-4744-9922-7050b10f2500"),
				Name = "ErrorCaption",
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				CreatedInSchemaUId = new Guid("e26d97b6-aa43-43af-9c0f-48a8116d1bc2"),
				ModifiedInSchemaUId = new Guid("e26d97b6-aa43-43af-9c0f-48a8116d1bc2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUserCannotManageSolutionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4605ec94-c82f-4186-93c8-45d06d4ee9db"),
				Name = "UserCannotManageSolutionMessage",
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				CreatedInSchemaUId = new Guid("e26d97b6-aa43-43af-9c0f-48a8116d1bc2"),
				ModifiedInSchemaUId = new Guid("e26d97b6-aa43-43af-9c0f-48a8116d1bc2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTooManyRecordsSelectedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("91412821-a4a1-4857-b94e-49c2d8c38d0a"),
				Name = "TooManyRecordsSelectedMessage",
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				CreatedInSchemaUId = new Guid("e26d97b6-aa43-43af-9c0f-48a8116d1bc2"),
				ModifiedInSchemaUId = new Guid("e26d97b6-aa43-43af-9c0f-48a8116d1bc2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSuccessMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("40daf62c-0433-421c-ae0a-49cb1b8c71c5"),
				Name = "SuccessMessage",
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				CreatedInSchemaUId = new Guid("e26d97b6-aa43-43af-9c0f-48a8116d1bc2"),
				ModifiedInSchemaUId = new Guid("e26d97b6-aa43-43af-9c0f-48a8116d1bc2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bbb330ce-9a59-421e-8dfc-9227e3633613"),
				Name = "ErrorMessage",
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				CreatedInSchemaUId = new Guid("e26d97b6-aa43-43af-9c0f-48a8116d1bc2"),
				ModifiedInSchemaUId = new Guid("e26d97b6-aa43-43af-9c0f-48a8116d1bc2")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e26d97b6-aa43-43af-9c0f-48a8116d1bc2"));
		}

		#endregion

	}

	#endregion

}

