﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailTemplateUserTaskMessageProviderSchema

	/// <exclude/>
	public class EmailTemplateUserTaskMessageProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailTemplateUserTaskMessageProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailTemplateUserTaskMessageProviderSchema(EmailTemplateUserTaskMessageProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5fa2bb49-a5ab-417b-bd90-631fe2e088fc");
			Name = "EmailTemplateUserTaskMessageProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("da7de29a-d2b3-4248-bf8e-b7a592dc81f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,89,89,111,220,54,16,126,222,2,253,15,204,38,8,36,212,144,219,62,250,74,29,123,19,44,106,55,169,237,182,47,69,11,90,226,174,217,234,50,73,185,222,38,249,239,29,94,226,33,173,178,13,130,62,52,64,140,21,53,51,156,249,230,224,12,85,227,138,240,22,231,4,221,16,198,48,111,86,34,59,107,24,201,222,178,38,39,156,195,67,189,162,235,142,97,65,155,250,203,47,222,125,249,197,172,227,180,94,163,235,13,23,164,58,140,158,129,190,44,73,46,137,121,246,154,212,132,209,124,64,115,65,235,251,193,226,13,121,20,217,21,89,119,37,102,139,199,150,193,230,82,136,163,243,21,172,170,166,30,127,227,105,251,81,2,107,228,57,225,116,13,170,142,51,0,24,139,90,80,65,201,22,101,128,224,21,206,69,195,52,5,208,180,221,109,73,115,148,151,152,115,180,168,48,45,111,72,213,150,88,144,159,56,97,55,152,255,121,9,219,226,53,1,5,30,104,65,24,58,64,47,49,39,70,31,197,17,81,128,212,119,74,246,236,41,35,107,80,30,129,41,92,224,90,240,3,244,150,209,7,16,174,223,239,239,239,163,35,222,85,21,102,155,19,187,160,68,34,97,180,64,68,26,180,65,60,191,35,21,70,53,4,65,214,179,238,251,188,173,150,140,114,185,25,226,130,73,227,127,39,190,73,215,74,200,15,32,3,29,163,121,96,237,252,112,66,165,27,188,70,171,134,161,53,17,66,74,37,161,138,29,32,133,4,64,133,74,92,175,59,128,2,81,65,192,113,13,251,116,93,45,252,23,70,228,210,72,148,186,196,202,91,218,73,35,192,9,2,124,255,201,72,230,154,63,196,208,8,181,27,63,37,117,161,125,62,18,0,172,147,145,39,99,64,197,156,166,48,241,183,75,228,37,163,68,10,125,249,35,149,226,102,7,232,22,162,51,233,23,145,44,3,179,15,211,234,193,14,45,97,50,109,34,229,12,16,151,210,9,210,84,8,70,157,63,27,141,135,123,62,220,138,251,101,87,10,218,7,134,225,66,43,205,182,205,3,26,149,177,125,71,214,36,135,50,115,6,1,138,142,79,98,221,208,139,23,40,137,215,142,81,77,254,26,147,150,72,100,97,169,214,181,49,77,149,105,51,62,46,250,24,61,224,178,35,135,59,160,124,73,196,93,83,196,53,192,98,172,10,215,70,71,215,143,29,1,209,175,137,8,60,110,212,92,240,251,228,117,71,139,62,255,150,133,241,242,236,1,51,84,225,26,112,102,160,88,104,71,230,111,112,169,137,14,123,46,194,239,13,34,3,61,18,35,113,47,174,24,6,24,96,205,78,139,2,78,147,174,170,147,249,203,166,216,108,121,117,221,221,254,1,202,216,183,114,95,176,30,156,78,95,209,82,40,157,37,199,25,35,32,94,47,253,66,197,221,91,204,32,219,224,129,39,122,17,14,149,22,152,120,83,223,108,90,40,249,247,29,46,65,187,101,49,223,243,65,113,58,104,54,46,117,73,130,29,13,13,93,33,157,92,54,169,178,107,240,161,182,22,118,64,199,199,40,161,181,72,131,213,236,180,19,141,69,94,109,3,220,167,69,69,235,43,186,190,19,28,172,89,225,146,235,208,144,177,1,127,25,17,29,171,165,149,126,192,216,16,184,160,92,28,153,131,69,59,160,55,253,68,70,195,248,43,158,248,238,135,88,35,143,198,149,87,242,119,242,221,252,183,43,146,211,150,66,236,252,90,124,245,204,135,31,142,238,22,74,19,49,12,83,10,36,134,205,59,252,52,201,162,36,149,204,104,91,114,244,42,72,12,17,5,253,3,250,36,136,2,37,207,153,4,169,130,151,245,170,1,41,145,88,204,209,242,237,54,114,231,205,9,137,96,106,87,150,189,227,140,75,44,18,190,183,198,145,112,109,19,106,123,241,160,232,214,45,179,87,13,203,137,244,159,231,178,67,19,15,61,254,78,86,246,203,29,97,36,105,161,220,88,21,193,143,217,146,95,98,145,223,37,109,38,15,159,20,61,127,174,223,38,176,114,142,5,254,89,214,33,21,152,75,126,209,52,127,118,45,144,160,22,26,181,21,136,171,115,115,250,163,39,26,128,158,127,54,32,201,244,233,118,60,114,230,165,232,253,123,244,100,219,134,105,154,221,52,50,136,148,125,126,196,7,240,70,97,127,219,52,165,44,86,231,100,133,225,172,56,131,255,29,35,182,204,36,230,252,229,158,14,126,184,155,200,150,30,152,74,17,23,26,142,37,59,173,55,10,230,41,139,162,56,129,83,60,136,17,169,68,25,181,40,90,149,184,113,73,60,11,14,7,188,82,127,167,153,222,18,170,144,140,180,36,182,75,86,255,222,54,165,115,106,24,116,228,244,114,150,133,52,206,127,4,231,75,238,108,81,181,98,147,134,219,68,108,158,9,47,55,125,5,233,247,245,201,247,6,16,164,86,246,57,68,3,173,115,225,34,94,193,216,155,13,77,121,39,139,129,212,236,155,177,232,80,71,221,199,17,72,198,61,239,210,202,58,178,81,103,144,204,86,217,242,108,20,243,88,177,138,196,59,57,129,29,234,36,78,3,97,83,70,76,2,170,136,2,84,151,113,12,13,113,54,86,69,176,218,215,153,183,39,247,61,150,194,153,200,184,120,195,76,210,37,61,167,242,189,247,20,70,204,152,113,67,45,71,163,95,167,177,29,12,160,141,143,115,185,11,250,149,83,182,238,212,185,162,143,38,175,131,182,111,146,121,200,1,167,127,212,186,105,87,157,201,217,206,244,107,217,13,219,128,118,73,164,198,30,106,58,177,3,220,123,58,170,199,53,245,106,204,176,34,68,167,142,180,215,213,131,93,108,117,212,96,103,140,162,222,121,54,220,214,148,248,0,2,176,255,104,96,234,73,50,55,161,0,226,135,154,165,35,93,76,188,219,84,224,27,217,253,174,69,208,180,20,225,219,171,174,180,29,201,249,240,77,220,159,7,249,56,34,201,207,1,216,119,36,152,103,179,97,35,238,41,29,31,72,81,243,13,105,106,58,243,107,0,161,159,112,212,67,148,158,254,43,169,86,226,75,25,71,41,149,195,75,204,103,147,54,110,118,119,31,64,26,1,232,145,194,58,203,60,162,230,129,48,6,179,38,178,233,42,187,249,61,59,2,155,254,61,237,39,19,99,119,239,75,3,157,185,178,208,33,239,146,34,154,71,64,200,146,191,130,86,31,176,93,212,248,182,36,69,50,62,214,171,9,210,130,242,243,183,115,119,40,247,59,129,176,128,170,119,86,88,215,3,241,6,116,251,120,229,170,99,146,154,68,159,237,124,39,97,19,4,17,104,249,253,44,183,62,90,168,9,107,98,166,155,212,212,102,120,111,176,39,86,34,169,145,119,173,105,156,36,217,53,56,176,36,174,222,167,113,19,99,5,26,39,195,22,218,235,58,87,92,195,114,11,17,49,250,82,186,216,168,247,36,170,118,187,122,31,104,46,113,206,26,14,131,26,149,100,184,116,61,156,231,246,89,136,149,230,89,60,2,146,5,41,220,101,70,118,225,29,106,38,42,229,198,178,195,51,67,169,58,177,143,100,70,67,1,116,228,118,70,50,248,204,140,209,19,34,52,30,39,225,252,59,27,130,186,139,136,104,78,14,99,74,220,177,230,47,85,27,79,219,182,164,185,186,30,93,60,230,164,85,126,127,54,191,104,114,92,210,191,37,164,238,138,174,110,4,90,65,167,85,168,123,60,104,4,26,86,160,119,147,33,247,97,30,196,136,169,1,253,56,214,91,100,67,218,172,248,115,29,143,99,105,201,127,128,184,120,195,84,216,36,145,44,40,117,131,40,60,136,55,12,187,175,91,93,158,12,191,95,3,71,175,162,174,20,27,119,77,22,130,90,7,14,89,81,232,20,87,172,169,182,222,108,110,185,167,82,43,90,25,126,114,245,239,165,30,237,91,230,176,14,63,80,38,58,92,246,199,231,104,141,250,164,169,255,127,58,190,187,83,253,191,29,224,149,178,158,16,51,91,195,144,236,205,243,106,196,145,239,190,222,77,109,72,81,130,243,59,244,209,153,6,81,223,132,160,220,70,119,6,150,168,191,59,112,124,219,47,15,236,253,64,79,185,253,42,1,109,37,154,188,76,176,245,252,51,13,101,31,29,203,44,194,65,31,27,57,97,170,128,128,10,28,85,178,209,112,159,58,162,47,53,83,149,66,233,171,190,60,28,207,93,239,54,63,177,233,109,11,179,171,31,80,33,20,211,184,12,77,46,37,152,206,235,95,242,123,51,197,137,252,174,34,87,145,104,228,119,30,132,107,247,17,103,32,196,86,173,203,105,40,182,149,55,215,98,143,55,109,131,14,219,142,198,202,218,190,31,29,191,18,50,205,242,247,84,158,59,35,247,251,50,142,206,122,26,239,86,102,111,235,215,178,207,119,77,236,148,203,252,161,97,135,171,99,117,75,86,249,112,153,182,201,14,121,79,118,233,176,206,41,151,191,70,97,55,115,206,89,195,0,105,208,106,30,142,86,163,123,67,230,79,220,220,57,0,181,138,47,38,166,42,223,221,91,80,50,82,14,252,247,206,153,129,4,27,43,209,133,197,96,206,49,145,100,123,24,217,188,37,35,193,228,181,57,253,204,19,128,99,232,50,41,96,98,20,83,171,234,143,252,247,15,0,92,110,15,210,31,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateDefaultEmailSubjectLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDefaultEmailSubjectLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b78329ef-0d4b-4d4f-8ce4-0a08ce3b73df"),
				Name = "DefaultEmailSubject",
				CreatedInPackageId = new Guid("da7de29a-d2b3-4248-bf8e-b7a592dc81f6"),
				CreatedInSchemaUId = new Guid("5fa2bb49-a5ab-417b-bd90-631fe2e088fc"),
				ModifiedInSchemaUId = new Guid("5fa2bb49-a5ab-417b-bd90-631fe2e088fc")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5fa2bb49-a5ab-417b-bd90-631fe2e088fc"));
		}

		#endregion

	}

	#endregion

}

