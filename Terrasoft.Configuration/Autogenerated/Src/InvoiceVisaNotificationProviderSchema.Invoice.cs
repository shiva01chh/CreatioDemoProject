﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: InvoiceVisaNotificationProviderSchema

	/// <exclude/>
	public class InvoiceVisaNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public InvoiceVisaNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public InvoiceVisaNotificationProviderSchema(InvoiceVisaNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3aee4e03-bc67-435d-83ce-363d27a55f3b");
			Name = "InvoiceVisaNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("239e4f82-9e39-4c8d-98a1-02dd073d1a06");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,88,75,111,227,54,16,62,123,129,253,15,132,123,145,1,67,105,175,235,52,128,19,39,129,139,205,3,177,179,61,44,114,96,36,58,203,66,175,146,84,22,110,144,255,222,225,75,34,245,176,148,118,247,176,69,115,137,69,206,124,51,243,113,56,28,50,195,41,225,5,142,8,218,18,198,48,207,119,34,60,203,179,29,125,42,25,22,52,207,222,191,123,121,255,110,82,114,154,61,161,205,158,11,146,46,26,223,32,159,36,36,146,194,60,188,36,25,97,52,170,101,92,88,70,250,198,195,213,41,76,193,228,79,140,60,1,16,58,75,48,231,31,208,58,123,206,105,68,62,81,142,175,115,65,119,52,82,78,221,178,252,153,198,132,41,149,162,124,76,104,132,34,169,49,164,128,62,160,83,204,123,167,231,104,237,14,3,248,139,50,81,187,5,49,10,156,9,112,237,150,209,103,44,136,158,47,244,7,138,228,60,226,130,201,16,29,95,54,209,23,146,226,107,32,27,253,138,166,206,196,116,49,70,253,10,3,209,12,120,46,211,172,1,178,142,135,33,58,173,15,171,65,132,41,102,251,21,229,69,130,247,190,245,235,50,125,36,108,186,48,244,144,44,214,12,117,208,197,202,72,228,76,50,166,22,202,16,166,23,109,96,185,130,21,85,121,5,94,28,107,223,230,40,127,252,3,146,237,4,21,152,129,47,64,11,159,73,192,201,7,244,8,43,27,56,195,72,102,238,228,245,77,6,239,185,228,57,203,116,62,163,210,251,244,12,53,166,60,99,125,124,128,153,130,48,65,73,55,27,249,51,108,10,112,195,174,131,34,91,225,78,158,136,48,191,38,140,136,146,101,237,181,85,235,41,61,104,198,220,132,149,193,15,193,250,73,59,26,122,75,69,66,116,166,12,89,232,203,174,55,133,225,110,140,49,33,53,55,82,219,88,223,210,93,17,241,37,143,251,246,189,113,233,146,136,21,124,6,230,51,134,223,130,166,196,36,199,228,25,51,53,118,133,35,150,115,216,70,126,182,65,241,20,31,243,8,39,244,47,252,152,144,141,2,9,166,3,41,59,157,163,233,170,2,157,206,22,149,41,70,120,153,8,48,3,38,128,59,17,110,115,41,184,5,143,130,202,53,45,110,152,210,26,32,103,108,215,206,106,185,215,190,168,79,243,120,223,181,89,245,255,19,20,87,83,154,251,79,56,41,9,119,121,121,4,132,45,73,33,23,4,249,134,204,156,58,176,46,55,153,170,95,96,168,219,179,207,83,149,201,211,135,133,183,112,146,186,3,58,146,93,87,5,71,81,94,102,226,128,198,82,75,184,74,80,137,5,142,14,41,157,105,9,171,228,36,27,40,217,20,180,238,206,90,238,24,117,77,34,104,104,253,240,34,103,41,22,193,244,229,231,215,57,122,249,229,21,216,51,10,115,235,147,193,162,59,20,104,237,112,205,175,203,36,185,97,231,105,33,246,129,145,159,217,117,157,244,88,52,112,206,230,235,199,180,166,135,48,205,176,139,105,211,170,21,163,155,107,115,147,10,115,69,224,188,147,36,127,147,72,237,197,219,42,70,46,32,143,73,108,119,143,249,172,43,218,134,200,6,74,109,36,56,90,244,87,96,35,54,102,51,242,213,200,53,14,41,125,42,77,194,11,150,167,65,103,249,110,108,222,150,121,80,137,209,50,142,117,154,241,192,184,195,213,63,235,198,101,9,66,124,207,215,41,126,50,137,230,110,58,53,220,109,126,142,238,72,74,179,24,152,84,13,1,15,93,197,237,190,32,213,252,58,54,92,107,219,38,50,237,87,31,248,20,90,160,89,184,228,129,250,49,78,229,70,53,17,244,153,24,77,231,123,28,192,70,96,81,242,202,114,253,57,210,101,126,134,179,8,98,172,92,119,6,198,65,200,129,155,175,208,109,215,78,236,249,50,6,34,239,51,42,218,174,232,127,225,173,237,143,130,86,3,49,211,48,190,165,30,119,60,87,76,51,168,213,117,225,28,161,85,249,173,34,81,11,208,75,96,147,123,166,138,156,209,215,63,125,189,170,178,74,247,84,24,74,212,142,54,165,109,73,245,165,237,232,63,101,178,159,197,22,132,221,88,70,83,253,150,108,140,217,185,191,229,52,219,202,115,177,103,231,122,123,105,13,101,131,73,141,14,175,195,155,3,43,181,230,231,127,150,56,233,203,199,3,77,150,141,253,35,217,137,155,82,24,243,245,90,72,179,238,122,117,153,243,252,49,178,78,182,52,160,171,133,83,208,206,226,14,66,27,217,177,212,171,162,9,149,75,93,126,251,235,230,231,7,180,163,25,78,146,189,46,20,68,54,127,110,17,188,23,52,161,242,94,32,59,157,11,45,170,24,54,226,205,146,239,22,201,240,247,47,132,245,150,94,183,82,129,197,0,194,111,167,31,15,26,238,205,44,177,203,44,30,87,196,44,169,173,204,222,225,132,67,90,143,100,115,169,170,176,140,246,130,38,82,189,139,211,126,24,239,250,190,206,118,185,60,166,238,72,148,179,184,57,243,239,218,85,33,171,220,55,236,83,85,213,108,54,170,234,200,165,186,20,212,35,225,150,237,129,94,184,130,246,53,136,182,122,60,192,109,185,20,22,193,239,98,100,59,209,34,203,180,88,91,19,156,10,114,174,199,78,117,35,101,123,253,30,134,140,176,113,0,228,141,109,51,126,158,1,228,94,77,72,251,50,154,222,32,188,83,225,97,230,33,120,15,26,135,0,156,10,252,96,16,174,8,231,214,187,65,39,92,211,238,241,58,70,183,113,28,87,56,151,44,47,11,227,187,250,173,91,214,183,181,148,206,227,193,209,209,17,58,230,101,42,111,211,39,118,224,78,173,50,71,153,179,196,97,37,125,212,20,63,214,89,193,79,220,148,8,143,143,236,176,251,130,114,14,13,51,97,50,191,143,91,219,237,164,217,22,242,102,27,219,156,151,90,32,228,149,135,198,125,95,213,134,13,17,182,61,253,72,185,56,182,91,53,210,131,214,138,249,12,161,148,232,126,112,209,30,54,29,74,199,204,202,217,124,222,68,117,86,117,204,85,135,77,199,156,223,218,116,8,184,45,66,199,116,119,31,208,253,30,82,85,186,59,117,139,255,161,174,227,194,45,127,223,187,172,170,251,191,155,184,241,129,42,34,119,238,127,242,217,64,42,145,186,30,143,43,195,181,42,31,83,130,221,242,91,171,210,234,116,24,60,192,124,30,255,127,222,248,158,207,27,18,175,200,139,178,48,135,219,173,252,13,100,227,170,132,251,141,65,101,194,107,16,164,241,241,93,128,77,192,254,211,189,206,51,231,152,212,25,72,24,149,37,129,220,26,167,149,243,225,198,14,7,126,195,227,115,36,106,126,188,74,48,111,192,30,44,188,245,179,141,114,28,218,247,198,211,77,181,199,170,41,195,109,247,67,78,184,130,147,141,102,18,64,187,190,44,10,232,201,149,172,61,252,124,56,35,119,71,32,152,200,60,188,55,68,204,243,48,228,187,105,205,55,121,201,42,217,129,251,245,56,252,250,238,214,101,162,125,21,31,135,90,95,219,58,81,91,87,118,131,234,227,12,190,138,185,28,203,203,99,15,195,13,212,31,241,42,235,70,170,47,87,61,177,154,13,227,207,29,104,79,245,168,59,8,35,240,247,55,213,203,207,70,92,30,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateBodyTemplateLocalizableString());
			LocalizableStrings.Add(CreateTitleTemplateLocalizableString());
			LocalizableStrings.Add(CreateDateMacrosLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateBodyTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("08ed08f7-7782-4735-814d-1cd099187246"),
				Name = "BodyTemplate",
				CreatedInPackageId = new Guid("b7b94813-de23-4fcc-94bb-87dcdb99f623"),
				CreatedInSchemaUId = new Guid("3aee4e03-bc67-435d-83ce-363d27a55f3b"),
				ModifiedInSchemaUId = new Guid("3aee4e03-bc67-435d-83ce-363d27a55f3b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTitleTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("eb7c8736-95d7-455e-94d0-683e480c79c8"),
				Name = "TitleTemplate",
				CreatedInPackageId = new Guid("b7b94813-de23-4fcc-94bb-87dcdb99f623"),
				CreatedInSchemaUId = new Guid("3aee4e03-bc67-435d-83ce-363d27a55f3b"),
				ModifiedInSchemaUId = new Guid("3aee4e03-bc67-435d-83ce-363d27a55f3b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDateMacrosLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("31227caa-7aab-487b-bebf-5313afcf3030"),
				Name = "DateMacros",
				CreatedInPackageId = new Guid("f66fcce8-7173-41d7-8de1-d6e019c595fc"),
				CreatedInSchemaUId = new Guid("3aee4e03-bc67-435d-83ce-363d27a55f3b"),
				ModifiedInSchemaUId = new Guid("3aee4e03-bc67-435d-83ce-363d27a55f3b")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3aee4e03-bc67-435d-83ce-363d27a55f3b"));
		}

		#endregion

	}

	#endregion

}
