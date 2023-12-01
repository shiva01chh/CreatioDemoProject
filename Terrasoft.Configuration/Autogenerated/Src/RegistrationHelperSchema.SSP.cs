﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RegistrationHelperSchema

	/// <exclude/>
	public class RegistrationHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RegistrationHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RegistrationHelperSchema(RegistrationHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b89037b0-503c-4008-9c75-15a8c3b23c0c");
			Name = "RegistrationHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f591b169-6459-4179-a1b5-4beab964458e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,91,89,115,219,56,18,126,214,84,205,127,224,48,47,84,141,138,121,221,154,216,74,197,177,156,104,215,78,60,150,50,121,166,40,200,198,134,135,2,144,182,181,137,255,251,118,227,34,192,75,244,149,218,108,205,76,85,18,225,104,116,55,190,62,33,101,81,74,248,54,138,137,183,36,140,69,60,223,20,225,219,60,219,208,203,146,69,5,205,179,240,130,92,82,94,200,15,239,73,178,37,236,215,95,190,253,250,203,168,228,52,187,244,22,59,94,144,244,85,237,51,144,72,18,18,227,22,222,55,23,190,35,25,97,52,110,172,121,151,228,171,40,161,255,17,167,54,102,231,31,27,67,167,52,251,218,24,92,146,219,162,26,180,5,76,83,155,108,125,38,252,39,239,154,182,53,179,88,156,183,47,98,164,107,220,165,208,185,234,248,168,115,106,150,21,180,160,132,119,46,56,137,226,34,103,29,43,206,34,154,132,11,146,173,9,131,105,88,240,130,193,245,230,153,247,54,137,56,255,195,107,187,108,88,181,45,87,9,141,61,94,192,68,236,197,184,182,117,233,232,155,88,110,168,158,145,226,42,95,3,221,115,70,175,163,130,200,217,173,252,160,201,157,230,177,184,234,85,66,22,5,67,126,223,145,162,49,24,124,226,132,129,246,50,9,29,175,116,62,78,128,152,216,154,1,158,199,30,226,115,52,98,164,40,89,230,101,228,166,121,70,224,238,15,63,231,236,139,176,3,192,59,207,75,22,195,186,156,69,151,100,226,249,77,73,253,137,56,96,228,55,232,242,208,247,126,23,92,192,95,126,248,87,148,148,196,31,227,85,140,238,90,165,23,247,185,67,145,151,36,221,38,48,115,180,3,190,10,184,197,125,34,191,43,233,218,35,41,92,169,222,58,95,171,209,88,82,152,175,181,46,174,35,230,165,167,81,118,137,180,73,86,72,148,236,188,67,161,158,179,230,76,77,65,82,4,65,38,150,235,254,69,11,216,221,66,19,140,186,120,107,214,4,190,146,198,7,77,206,108,102,149,90,244,53,85,100,45,2,65,67,188,74,178,30,165,158,194,125,29,136,195,222,20,176,250,42,5,82,83,212,113,109,140,159,176,60,213,212,3,161,185,162,58,75,112,215,123,7,182,118,25,225,101,82,40,133,182,50,16,40,129,229,149,47,226,43,16,206,35,246,135,195,26,253,208,94,122,22,101,128,71,134,218,153,103,32,104,22,3,84,62,0,210,2,87,175,39,52,49,186,69,198,56,139,103,139,63,21,99,54,193,63,75,2,247,108,51,160,118,201,29,225,156,31,131,24,52,139,81,170,130,149,196,153,125,179,94,131,39,47,211,44,80,3,23,121,94,72,50,200,34,88,124,26,177,157,92,34,184,28,143,59,246,251,199,81,17,249,238,44,8,81,16,198,113,149,166,255,150,17,41,29,76,124,166,197,213,121,196,128,44,174,10,228,32,56,239,109,196,40,248,238,229,110,11,158,242,107,25,37,13,208,41,203,173,174,121,108,169,106,3,170,195,171,3,121,213,161,136,25,161,160,42,106,117,91,6,110,191,32,219,156,83,101,91,194,171,90,102,113,112,226,172,152,6,120,37,64,10,188,75,137,139,222,176,203,18,161,18,248,238,25,96,59,181,67,213,169,27,240,248,0,47,47,208,199,123,52,51,82,104,116,26,222,230,107,224,9,255,17,58,183,35,156,148,164,167,2,134,32,151,146,20,120,4,183,70,162,84,251,9,107,8,238,83,211,23,7,172,110,24,133,75,80,43,143,104,6,244,63,139,161,192,166,164,24,183,152,202,54,185,98,171,210,76,120,154,71,107,84,150,3,207,240,19,122,0,41,201,68,31,232,16,140,140,181,105,188,187,54,24,84,60,143,140,54,180,169,195,127,8,84,61,10,124,33,12,9,142,153,5,8,85,116,123,150,68,225,50,127,3,241,117,23,140,205,170,57,87,254,75,25,142,26,191,211,172,74,95,33,192,93,113,172,5,185,147,127,137,63,239,108,15,41,119,245,184,189,247,69,154,8,129,207,8,231,224,43,100,160,55,126,79,126,236,143,42,182,71,19,190,247,109,66,157,112,161,137,57,227,237,38,209,193,14,151,127,201,251,105,95,19,52,143,110,88,128,19,60,184,78,105,186,84,51,111,50,221,33,202,32,245,168,99,27,246,221,164,247,104,27,111,151,135,155,76,73,133,87,113,242,160,140,161,145,27,40,90,66,231,110,152,135,101,11,130,110,207,59,148,160,68,89,228,72,253,202,21,178,67,237,211,235,81,223,55,43,48,230,86,243,102,248,243,21,97,196,217,55,95,251,99,8,66,194,143,7,146,110,104,156,126,80,137,49,246,34,174,184,146,236,43,39,118,124,52,187,37,113,9,58,247,214,43,243,207,150,24,203,75,70,142,143,170,33,203,181,89,254,16,108,93,226,214,209,76,40,9,131,239,194,217,160,58,200,114,143,116,227,5,191,201,237,33,174,179,93,167,209,62,99,57,83,70,32,205,108,95,206,10,26,82,202,250,144,23,179,91,112,248,190,241,133,163,226,138,229,55,194,194,52,222,62,148,73,242,145,205,210,109,177,155,221,198,100,43,4,181,79,157,120,25,44,49,36,148,27,26,9,88,0,71,138,127,129,56,19,53,14,36,247,211,64,95,178,227,195,28,239,85,193,171,35,17,182,188,128,39,99,189,61,52,48,255,143,45,107,152,216,232,94,229,235,157,89,197,203,213,191,97,99,205,0,120,185,221,230,76,238,109,194,4,211,46,126,2,108,1,88,102,25,222,202,58,240,161,4,180,171,3,44,175,86,249,173,154,246,199,222,107,169,14,216,187,224,219,133,69,191,110,62,222,31,114,101,32,121,25,67,5,187,32,69,33,42,10,216,45,148,221,188,127,69,113,65,216,53,141,137,115,5,136,57,87,160,67,37,125,40,48,96,16,248,24,252,161,188,0,62,93,212,162,200,10,0,143,197,159,132,142,131,9,98,127,176,162,187,30,82,242,160,123,193,252,205,146,93,197,229,101,110,103,231,10,185,222,55,7,51,222,157,90,124,4,120,129,229,2,54,114,100,33,65,35,104,139,127,169,113,171,156,232,207,254,165,96,175,26,70,161,4,24,228,237,235,48,26,20,173,52,190,221,189,158,11,8,201,151,136,16,181,133,34,81,26,8,200,86,123,0,103,190,38,155,8,146,23,81,99,141,109,136,54,142,250,237,80,132,169,26,74,85,24,226,42,26,121,195,3,145,204,40,228,109,172,215,144,67,241,122,40,82,92,46,118,89,172,69,108,132,165,254,88,212,144,162,25,147,70,45,218,119,2,200,2,172,45,98,198,161,58,118,160,179,28,151,68,15,96,106,29,31,252,3,92,234,26,147,233,40,225,202,189,214,70,135,39,134,60,45,182,239,115,81,38,221,211,95,169,141,78,121,10,99,231,32,18,18,163,144,5,15,167,132,187,234,148,80,6,149,196,223,159,53,189,185,141,232,57,100,122,55,57,91,63,152,176,38,96,19,39,34,80,44,56,162,33,88,229,121,114,15,154,51,189,215,38,24,91,151,44,141,164,31,9,85,61,164,238,83,95,173,242,109,234,98,244,29,169,81,16,71,242,108,248,175,38,180,246,237,203,176,102,45,53,214,53,107,187,71,225,26,20,43,96,118,86,236,0,142,191,127,119,168,215,231,127,138,200,166,155,94,213,85,236,107,103,233,120,5,252,11,67,5,111,10,124,113,209,90,153,207,50,224,132,161,64,102,29,138,132,205,185,18,24,224,90,39,14,165,210,34,211,18,25,131,122,143,65,233,51,81,68,177,213,224,28,226,189,126,237,85,140,72,7,94,17,51,215,162,142,20,117,191,104,250,221,22,106,8,59,38,242,95,159,10,154,136,54,119,184,100,59,233,173,22,91,18,211,13,141,213,138,64,179,161,239,5,33,83,39,119,40,21,111,146,109,156,167,153,105,118,220,233,28,191,210,131,168,201,93,50,33,170,184,237,242,156,125,186,85,22,140,195,101,142,106,12,6,148,111,23,100,155,68,49,177,67,230,39,118,207,42,206,201,114,99,196,43,75,107,4,39,186,203,172,187,94,182,51,95,201,68,71,79,161,215,193,246,217,186,53,203,199,172,8,2,161,226,59,240,95,212,78,122,225,79,58,120,176,156,84,26,197,44,231,181,51,143,118,5,225,210,221,129,241,225,2,191,177,69,181,230,240,117,38,60,38,160,21,138,102,76,14,4,106,143,169,80,79,196,118,32,44,212,221,211,96,150,197,249,26,243,155,79,203,147,127,224,25,202,216,37,49,157,133,192,90,141,15,165,10,167,97,40,145,184,11,205,85,197,116,139,229,189,228,17,95,152,2,89,90,84,23,98,113,219,209,181,184,243,226,168,0,147,250,230,57,128,66,66,61,160,185,206,225,222,49,157,193,238,231,224,142,78,123,105,164,7,173,252,182,189,54,218,215,196,169,53,151,58,123,163,181,236,189,165,192,171,179,237,242,171,234,55,197,156,234,21,139,51,197,123,86,96,211,159,136,166,155,99,127,47,96,141,124,148,234,122,161,18,79,92,114,242,229,203,151,222,1,47,83,108,145,78,245,0,158,226,49,11,212,26,232,242,131,56,63,52,187,95,214,183,31,108,49,91,20,47,67,135,245,206,207,20,47,16,201,233,90,243,224,165,88,221,190,217,0,205,159,170,250,223,163,34,136,108,40,40,99,223,214,22,211,20,116,42,73,28,25,75,150,56,36,221,151,64,131,200,7,116,159,108,92,182,249,11,133,63,229,214,91,86,60,75,220,63,165,217,151,70,59,229,105,66,126,139,25,74,182,156,14,94,135,21,232,247,46,105,75,252,107,231,115,206,254,7,164,174,119,56,160,106,63,202,168,114,183,99,86,6,130,214,169,57,71,159,209,179,192,117,239,2,21,54,230,28,230,68,237,9,58,186,232,94,208,237,115,116,124,193,236,218,217,52,70,142,204,211,78,67,231,61,220,88,165,107,69,189,150,102,60,6,127,206,113,0,196,147,188,204,158,58,247,180,162,126,71,2,210,9,194,174,232,62,169,82,11,171,116,50,13,147,103,59,70,116,86,135,52,234,62,38,210,71,205,33,179,187,148,244,76,141,15,245,196,16,18,224,221,172,72,119,146,51,40,239,55,192,160,63,182,186,20,205,224,124,255,176,118,231,145,132,19,251,241,238,57,130,231,200,38,26,186,77,172,125,47,229,61,6,210,145,241,180,84,167,237,77,136,238,221,143,125,142,170,136,44,116,242,210,120,191,153,91,55,55,13,20,62,58,31,112,154,28,65,250,219,28,52,239,130,143,125,237,29,89,220,183,101,61,150,126,109,131,191,235,201,106,46,68,230,201,37,215,149,195,172,18,10,15,202,63,193,142,227,21,159,45,209,145,153,48,159,218,134,223,205,28,236,215,27,154,201,137,8,44,123,66,199,160,150,215,128,8,53,164,109,35,175,208,199,62,74,148,116,50,229,79,236,246,103,229,229,122,207,111,109,153,238,225,120,113,46,160,200,195,30,253,180,20,189,61,84,95,61,33,216,182,186,79,196,72,74,51,81,197,61,63,228,224,164,234,224,199,130,46,206,175,33,31,211,205,173,199,0,79,82,122,18,208,245,48,213,13,188,142,243,59,64,215,201,173,5,184,94,221,180,130,174,149,234,19,1,142,102,215,180,144,158,198,116,36,158,27,108,243,234,204,199,1,173,34,244,112,136,209,46,26,15,1,89,7,67,93,240,234,57,187,21,96,255,235,201,181,66,108,167,88,123,49,43,250,12,18,19,55,144,74,26,236,87,158,41,129,26,245,135,116,26,152,110,118,249,83,211,247,234,223,161,82,76,127,42,203,91,245,177,127,15,38,167,88,49,234,77,248,121,72,207,161,238,70,176,116,31,216,10,51,130,213,191,17,224,182,194,52,103,118,47,226,225,213,134,247,253,187,202,3,127,96,181,97,73,170,165,121,142,114,99,192,49,63,101,5,240,255,156,250,11,71,147,150,73,65,205,139,14,107,100,221,63,107,71,19,254,16,177,189,179,97,219,79,214,121,215,82,210,36,230,157,235,128,220,70,224,207,201,116,131,223,53,121,191,92,158,235,135,44,160,170,231,6,121,176,90,46,253,144,151,159,125,79,63,131,223,6,255,238,180,54,59,173,207,211,151,36,246,66,73,167,250,241,135,245,184,219,96,209,185,183,161,125,202,218,105,127,55,43,39,238,5,168,227,30,218,187,115,104,245,191,158,154,150,250,120,88,22,232,58,103,90,43,25,126,136,107,22,39,89,233,159,58,250,185,220,121,37,163,227,197,91,42,180,1,238,181,86,137,12,204,13,137,188,220,142,199,42,135,65,219,115,58,19,63,155,195,68,35,235,43,2,123,235,204,135,185,57,133,140,134,152,157,108,180,59,104,229,26,238,97,132,45,95,97,144,117,4,234,87,125,133,193,189,229,87,222,112,15,65,158,223,53,232,166,134,235,29,76,255,96,131,78,216,91,237,100,31,205,36,45,63,196,91,60,113,218,212,160,95,253,106,75,23,139,237,109,147,142,166,203,89,171,198,122,219,44,109,63,207,180,35,244,30,159,178,55,249,82,57,92,237,167,135,173,95,215,138,173,111,124,73,107,106,124,15,204,205,235,42,43,249,66,245,119,102,237,95,122,226,175,51,205,183,168,151,219,68,13,227,15,95,235,169,135,174,99,112,185,29,77,245,97,243,2,132,132,125,205,136,105,177,167,107,25,213,34,249,226,254,210,211,250,225,101,163,83,212,254,37,14,57,234,14,226,255,48,14,255,253,23,142,106,117,234,218,62,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateLinkNotExistLocalizableString());
			LocalizableStrings.Add(CreateContactNotExistLocalizableString());
			LocalizableStrings.Add(CreateEmailTemplateNotFoundLocalizableString());
			LocalizableStrings.Add(CreateMailNotConfiguredLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateLinkNotExistLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1cc546d4-1766-4447-b854-ba8abdfa5505"),
				Name = "LinkNotExist",
				CreatedInPackageId = new Guid("f591b169-6459-4179-a1b5-4beab964458e"),
				CreatedInSchemaUId = new Guid("b89037b0-503c-4008-9c75-15a8c3b23c0c"),
				ModifiedInSchemaUId = new Guid("b89037b0-503c-4008-9c75-15a8c3b23c0c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateContactNotExistLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("715dc4a7-f55b-4858-9173-0d9dd4d4bbfd"),
				Name = "ContactNotExist",
				CreatedInPackageId = new Guid("f591b169-6459-4179-a1b5-4beab964458e"),
				CreatedInSchemaUId = new Guid("b89037b0-503c-4008-9c75-15a8c3b23c0c"),
				ModifiedInSchemaUId = new Guid("b89037b0-503c-4008-9c75-15a8c3b23c0c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmailTemplateNotFoundLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("aa9c81ba-d09d-4691-b289-a29a82d4ec93"),
				Name = "EmailTemplateNotFound",
				CreatedInPackageId = new Guid("f591b169-6459-4179-a1b5-4beab964458e"),
				CreatedInSchemaUId = new Guid("b89037b0-503c-4008-9c75-15a8c3b23c0c"),
				ModifiedInSchemaUId = new Guid("b89037b0-503c-4008-9c75-15a8c3b23c0c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMailNotConfiguredLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d57125fc-193a-4209-a077-71abf11e78e2"),
				Name = "MailNotConfigured",
				CreatedInPackageId = new Guid("f591b169-6459-4179-a1b5-4beab964458e"),
				CreatedInSchemaUId = new Guid("b89037b0-503c-4008-9c75-15a8c3b23c0c"),
				ModifiedInSchemaUId = new Guid("b89037b0-503c-4008-9c75-15a8c3b23c0c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b89037b0-503c-4008-9c75-15a8c3b23c0c"));
		}

		#endregion

	}

	#endregion

}

