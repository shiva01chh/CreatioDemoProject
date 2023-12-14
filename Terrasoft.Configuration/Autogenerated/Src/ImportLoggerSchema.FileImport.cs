﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportLoggerSchema

	/// <exclude/>
	public class ImportLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportLoggerSchema(ImportLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("49d90925-03e9-4c13-81c5-7b3859a39128");
			Name = "ImportLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,88,91,111,219,54,20,126,118,129,254,7,78,123,145,1,67,222,94,147,216,65,226,216,157,129,182,200,226,116,123,24,134,64,145,143,93,173,148,232,146,148,19,47,200,127,223,225,69,18,117,177,236,108,193,182,230,197,34,121,174,223,185,240,48,105,152,128,216,132,17,144,91,224,60,20,108,37,131,9,75,87,241,58,227,161,140,89,26,204,98,10,243,100,195,184,124,251,230,233,237,155,94,38,226,116,77,22,59,33,33,57,173,173,145,149,82,136,20,159,8,222,65,10,60,142,26,52,87,161,12,131,197,87,58,161,49,164,178,113,124,11,143,206,230,132,37,9,75,221,53,135,234,42,184,186,44,55,214,148,221,135,244,228,196,176,5,239,217,122,141,219,229,185,235,36,178,206,194,72,50,30,131,64,10,164,249,158,195,26,77,39,100,66,67,33,78,136,113,91,9,1,174,9,134,195,33,57,19,89,146,132,124,55,182,235,139,148,196,169,144,97,138,24,178,21,145,159,99,65,34,197,79,240,131,35,184,136,69,124,79,129,172,24,39,212,24,68,98,45,25,25,113,51,49,56,231,226,135,142,252,223,174,96,21,102,84,94,198,233,18,217,124,185,219,0,91,249,115,215,176,254,128,124,196,32,146,17,73,241,71,157,186,135,253,223,81,204,38,187,167,113,100,173,114,143,209,197,170,143,61,21,225,18,135,89,12,116,137,64,92,243,120,27,74,208,24,52,64,208,27,83,206,209,61,204,37,17,174,129,96,28,55,20,25,130,130,222,245,170,183,49,226,136,144,92,129,113,7,138,249,131,225,189,181,172,42,102,189,3,234,56,123,248,91,170,110,216,131,163,166,141,108,133,73,175,80,173,29,191,143,133,60,43,33,155,163,242,49,185,139,243,117,97,115,78,63,199,77,114,71,245,137,6,22,210,165,193,214,174,45,208,88,113,168,57,83,201,168,208,214,225,234,0,123,194,1,165,139,106,222,97,106,32,37,0,137,56,172,70,158,27,87,143,12,199,123,240,209,59,155,144,135,137,78,159,145,151,9,224,104,78,106,170,216,27,127,194,53,137,138,141,224,108,168,169,219,153,13,18,215,106,7,36,112,225,141,141,25,100,83,108,85,4,216,196,116,109,245,63,85,12,32,85,123,6,150,182,84,65,234,58,251,68,231,112,175,38,103,84,147,164,99,213,107,72,27,53,228,105,194,231,111,32,26,47,6,179,79,70,99,114,24,166,174,196,189,230,108,3,92,98,7,61,166,73,216,100,192,122,168,119,190,142,202,109,173,185,98,169,92,40,11,144,156,159,19,223,89,98,79,132,135,86,9,126,191,223,94,250,211,150,94,100,51,106,13,210,126,245,226,21,234,105,107,91,228,59,212,153,81,154,103,97,175,199,65,102,60,237,104,114,58,187,212,207,54,228,104,5,227,170,131,142,106,129,9,126,101,252,139,190,168,131,27,16,44,227,17,44,12,169,149,209,110,141,5,128,69,33,141,255,12,241,22,90,104,47,125,171,102,64,170,153,57,176,54,123,13,14,17,180,1,19,252,18,210,12,188,190,181,225,176,171,207,182,152,170,109,210,133,222,233,205,93,176,187,100,221,144,87,155,253,235,194,237,90,241,218,80,59,178,187,96,110,184,151,67,124,124,217,50,137,78,195,242,112,225,58,93,124,95,205,90,89,205,54,221,216,120,34,24,216,83,210,213,89,235,221,238,144,210,90,47,171,45,171,10,143,130,198,185,136,109,119,181,169,58,179,243,129,147,162,170,17,229,99,131,233,67,197,106,212,240,254,60,152,57,164,70,104,48,77,54,114,103,131,44,234,18,71,100,171,146,224,244,136,232,126,0,249,153,29,55,182,189,3,169,47,46,200,219,50,246,70,242,53,3,190,59,246,134,138,221,182,90,220,247,185,172,230,184,96,146,87,140,231,173,74,207,134,249,121,101,140,50,180,104,172,249,178,218,126,86,44,126,181,177,147,138,61,250,134,83,101,105,248,106,215,97,95,35,29,204,83,201,124,111,250,24,1,45,68,121,246,108,1,210,247,20,254,222,0,135,52,154,37,105,80,4,209,207,67,216,119,137,139,182,247,40,219,120,42,230,5,150,184,34,96,33,195,232,203,45,199,214,115,152,191,164,45,174,179,227,18,227,208,132,249,83,152,46,41,206,52,186,197,28,155,10,2,213,98,103,27,119,142,136,176,197,71,223,5,95,139,42,157,45,175,45,139,151,86,185,110,130,62,187,255,3,131,69,140,232,28,15,172,209,8,145,211,20,211,92,30,41,36,231,23,129,106,240,73,25,14,44,33,91,104,51,61,122,248,109,55,218,160,20,19,76,128,210,27,88,1,7,156,234,220,131,60,108,238,12,137,33,9,46,150,75,95,103,91,37,35,243,91,201,114,161,25,142,81,166,101,247,15,14,153,69,64,48,77,55,29,205,240,223,8,138,117,164,30,27,247,236,31,68,197,123,250,225,249,132,60,253,248,236,185,144,27,72,23,200,135,190,207,151,238,209,180,128,228,21,227,146,95,207,101,133,225,121,155,206,146,224,91,11,101,174,190,30,71,131,210,52,149,177,220,45,194,45,188,74,153,57,99,74,51,172,70,87,128,52,115,52,225,241,255,24,220,250,53,253,210,96,59,239,157,220,146,255,38,236,115,52,100,79,1,59,71,29,225,126,57,242,141,198,121,44,120,40,50,127,223,119,222,68,174,151,200,99,110,142,34,138,101,161,229,46,152,255,5,250,42,113,151,247,211,71,136,50,156,209,155,111,128,105,42,50,14,87,151,229,22,190,26,115,255,20,179,29,156,70,123,38,147,253,216,184,224,212,19,60,79,206,90,118,238,107,56,57,142,248,56,210,22,4,198,31,240,75,207,250,205,135,65,43,220,170,216,133,154,200,142,128,89,209,162,87,254,107,66,138,21,2,97,244,217,72,137,171,83,93,90,34,89,190,243,142,136,65,117,28,180,72,29,132,202,62,17,247,61,165,236,158,187,165,119,212,223,95,148,52,87,37,81,23,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateErrorMessageTemplateLocalizableString());
			LocalizableStrings.Add(CreateErrorRowTemplateLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateErrorMessageTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("34bc3758-0bb7-4dfe-81c4-7715e1fe3c4d"),
				Name = "ErrorMessageTemplate",
				CreatedInPackageId = new Guid("1101e5cd-b945-4f88-8001-faccb4fdb24c"),
				CreatedInSchemaUId = new Guid("49d90925-03e9-4c13-81c5-7b3859a39128"),
				ModifiedInSchemaUId = new Guid("49d90925-03e9-4c13-81c5-7b3859a39128")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateErrorRowTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a8dd96a0-8fc4-4545-9224-b9ae0b3ad9eb"),
				Name = "ErrorRowTemplate",
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8"),
				CreatedInSchemaUId = new Guid("49d90925-03e9-4c13-81c5-7b3859a39128"),
				ModifiedInSchemaUId = new Guid("49d90925-03e9-4c13-81c5-7b3859a39128")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("49d90925-03e9-4c13-81c5-7b3859a39128"));
		}

		#endregion

	}

	#endregion

}

