﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailFacadeSchema

	/// <exclude/>
	public class BulkEmailFacadeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailFacadeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailFacadeSchema(BulkEmailFacadeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("434e2e19-3294-47eb-b343-59b6892b92f7");
			Name = "BulkEmailFacade";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,90,91,111,219,56,22,126,246,0,253,15,28,207,98,96,99,12,37,243,176,251,208,196,46,146,212,153,241,32,233,102,227,100,231,97,177,40,20,137,78,132,72,162,75,82,185,52,240,127,223,195,171,72,74,242,165,13,186,51,211,135,182,34,15,15,191,115,120,174,52,203,184,192,108,25,39,24,93,97,74,99,70,22,60,58,33,229,34,187,173,104,204,51,82,190,249,238,229,205,119,189,138,101,229,45,154,63,51,142,139,131,224,27,232,243,28,39,130,152,69,191,224,18,211,44,105,208,156,101,229,167,122,208,221,171,40,72,217,62,67,113,215,120,116,26,39,156,208,12,179,78,138,171,152,221,139,89,152,255,129,226,91,0,135,78,242,152,177,183,232,184,202,239,167,69,156,229,192,36,78,177,36,217,219,219,67,135,172,42,138,152,62,79,244,247,121,92,198,183,152,161,4,32,198,101,138,150,148,36,152,201,189,22,132,162,27,96,131,176,224,195,34,195,97,207,97,177,172,110,242,44,65,137,216,180,185,103,239,69,238,107,177,157,102,56,79,1,220,5,205,30,98,174,64,245,150,234,3,101,37,71,31,23,49,227,66,168,163,42,205,112,153,224,179,172,200,56,26,163,159,247,247,15,90,200,63,81,254,249,55,114,115,1,167,65,82,32,251,135,161,250,1,151,169,218,212,71,0,167,206,56,173,132,94,5,14,137,94,243,85,146,4,50,12,174,25,166,176,168,84,71,143,42,239,115,136,132,217,244,122,1,209,56,32,19,199,215,91,173,7,118,65,201,18,83,14,135,221,161,158,96,143,224,243,5,221,98,126,128,152,248,107,151,157,28,5,132,214,33,7,142,74,80,52,227,49,28,5,34,11,152,199,24,37,20,47,198,125,171,168,57,7,120,202,140,104,127,111,162,108,33,178,28,93,107,177,194,180,46,70,31,153,243,117,208,118,40,30,185,247,161,14,2,148,128,198,19,159,17,122,247,14,13,252,145,49,42,241,99,59,215,224,192,135,67,137,163,199,218,24,143,209,67,156,87,216,61,222,47,85,226,191,42,92,125,177,18,221,197,224,19,206,87,171,18,61,114,239,195,87,162,203,72,41,209,27,9,148,232,50,218,160,196,128,205,118,74,156,57,26,180,155,78,31,112,201,207,200,45,48,138,208,150,218,114,214,160,143,55,45,163,173,74,115,87,181,14,142,229,110,189,86,142,74,123,173,51,129,22,157,169,54,37,174,243,235,115,204,239,72,103,116,125,32,89,138,166,79,28,22,159,67,124,23,49,255,247,140,223,137,61,102,229,130,12,102,211,178,42,48,141,111,114,124,24,156,169,34,159,160,66,175,51,81,239,33,166,50,208,205,68,228,245,193,70,39,21,165,32,137,24,21,153,150,67,38,155,165,7,222,50,49,140,159,68,112,151,41,75,37,187,103,200,173,252,112,118,82,49,78,10,77,49,125,194,73,5,115,147,193,80,204,94,215,107,67,21,169,13,32,111,225,56,185,67,3,177,147,6,13,14,216,192,223,211,3,209,181,17,66,73,115,208,156,173,177,58,200,21,221,202,49,92,163,236,45,148,9,130,152,115,184,34,71,105,58,176,116,38,245,205,138,37,161,252,156,164,56,71,177,30,147,95,174,254,141,76,128,44,197,139,184,202,249,22,39,57,172,15,194,218,164,148,223,219,38,58,174,231,180,255,62,102,92,232,213,39,155,147,138,38,248,234,121,137,173,98,147,152,97,100,228,168,231,163,105,201,51,254,252,86,17,245,28,236,160,0,67,126,252,124,150,49,238,226,141,78,224,60,57,30,56,88,71,168,13,67,93,162,105,9,123,189,27,88,122,127,176,30,213,41,201,83,76,13,42,161,149,133,28,105,81,73,184,79,116,154,81,198,255,73,223,107,221,219,125,29,217,192,191,255,243,95,163,153,94,79,184,187,39,174,218,222,21,216,151,212,128,25,214,60,122,83,198,179,2,116,146,94,146,71,118,66,170,146,55,160,90,18,169,116,200,246,146,204,112,88,233,255,172,118,82,84,150,243,90,81,187,136,40,23,118,139,24,34,255,52,135,130,46,206,179,207,248,219,73,173,230,214,68,72,27,62,20,61,197,188,162,117,80,57,120,133,48,112,137,11,242,128,7,10,91,35,30,168,217,191,84,60,48,67,219,153,148,82,192,81,110,53,210,101,80,255,127,79,233,12,116,90,134,157,98,157,65,242,154,33,111,7,79,14,33,127,133,51,91,81,66,97,222,87,75,168,182,64,112,207,108,254,132,46,15,205,165,104,157,193,173,207,146,207,115,249,241,111,81,222,14,244,68,158,124,254,16,23,216,117,217,156,36,66,59,194,63,213,2,65,0,82,170,21,144,157,40,72,55,232,159,133,100,44,122,217,95,69,146,123,127,100,25,31,116,243,213,181,102,131,145,14,56,65,5,247,59,161,247,242,206,36,186,196,76,90,206,28,106,48,144,123,36,164,19,231,4,229,152,216,114,212,46,129,131,68,22,248,176,123,131,78,161,87,132,217,66,20,108,146,16,112,86,185,13,107,189,238,229,0,228,4,66,92,69,177,82,178,188,151,137,243,0,112,4,217,89,147,65,54,141,115,102,176,173,220,83,109,116,33,230,72,111,8,201,209,73,92,66,151,72,249,169,190,159,104,150,107,42,48,23,110,64,54,241,177,248,186,58,201,152,93,123,5,162,156,226,112,220,113,119,178,75,237,179,85,180,216,54,150,123,168,219,125,20,77,208,62,250,241,199,245,52,155,36,211,105,46,216,86,30,115,119,129,46,187,161,11,117,213,101,60,127,151,22,104,212,145,163,215,100,103,97,223,223,155,245,209,81,249,60,24,90,59,80,160,93,163,116,91,151,177,221,182,163,220,20,172,27,6,234,131,176,91,137,185,72,82,126,192,143,38,216,213,110,127,216,16,73,44,24,133,109,190,214,135,9,144,198,159,16,6,173,155,157,220,11,1,176,104,217,244,135,17,181,22,22,183,5,122,43,247,188,42,6,133,184,59,40,162,102,70,208,188,90,47,5,224,31,55,146,187,53,204,8,189,23,9,39,43,160,197,227,201,7,242,56,106,9,219,125,33,190,202,201,105,127,168,143,125,61,217,123,204,18,154,45,133,54,97,197,86,141,241,200,239,56,133,63,141,90,52,50,220,230,34,177,190,6,216,116,183,7,110,157,51,107,172,226,94,133,223,97,231,198,183,227,250,73,142,44,99,26,23,168,132,56,63,238,123,150,214,159,40,31,0,110,91,112,158,109,184,22,107,233,133,235,219,177,195,61,137,98,226,92,215,72,191,118,90,143,47,232,170,221,213,30,193,200,86,212,191,84,89,58,244,14,227,47,175,223,6,40,38,126,36,32,229,44,237,79,174,203,12,156,27,101,41,216,117,182,200,48,149,128,104,38,239,183,36,30,164,169,95,249,200,192,97,225,36,144,133,98,142,208,189,207,117,61,126,115,71,35,131,180,183,252,138,62,207,49,183,249,46,185,3,129,130,134,199,159,4,24,54,216,242,59,74,30,101,209,53,125,74,176,12,9,131,254,117,41,50,12,226,4,101,82,176,250,28,211,74,13,151,241,114,73,9,228,42,145,170,250,232,39,157,218,254,102,45,1,49,185,21,122,89,15,100,37,127,194,177,66,134,228,142,244,171,168,239,69,228,166,30,32,191,184,135,244,186,50,138,91,245,138,121,162,186,183,188,59,0,15,122,224,198,45,155,239,242,245,161,91,27,138,102,236,3,225,211,98,201,221,4,93,39,96,66,167,113,114,103,146,209,149,178,114,245,43,130,97,33,106,119,107,146,46,184,176,224,176,213,4,106,129,181,46,178,168,76,195,108,133,32,142,153,65,62,16,69,190,14,6,158,255,109,27,105,156,62,174,63,153,249,254,236,7,152,109,99,67,147,137,193,185,41,36,204,129,206,85,175,140,186,200,235,52,119,246,254,155,208,223,253,50,75,24,113,184,237,198,59,134,141,38,160,147,251,121,252,116,137,57,125,54,181,205,223,149,97,40,28,173,181,146,238,197,45,192,213,102,195,80,189,186,147,116,22,148,20,127,220,180,227,92,105,109,78,235,254,61,68,51,77,108,188,31,123,205,180,0,225,48,192,179,117,68,164,114,221,118,17,209,141,130,59,68,58,125,145,216,22,236,94,47,6,221,225,228,158,33,46,94,32,136,95,87,106,51,64,210,124,191,65,204,81,109,19,155,92,81,80,225,227,29,46,213,206,40,17,117,117,86,26,112,254,59,6,96,99,214,57,22,38,155,252,95,99,54,43,19,82,44,115,204,101,223,211,136,57,230,140,117,151,233,185,173,84,136,209,235,244,41,99,220,139,23,91,248,174,68,101,234,126,81,203,11,228,137,106,24,26,250,213,194,97,249,227,152,8,164,223,78,223,211,26,97,97,162,2,184,46,151,144,28,68,173,154,246,59,73,135,149,105,236,132,226,167,134,71,231,9,120,61,35,52,114,49,248,128,119,28,224,16,53,115,72,219,151,56,33,52,109,30,137,57,203,230,143,217,245,242,32,240,35,229,231,23,132,101,250,189,135,135,36,90,234,9,29,249,109,199,42,122,205,6,49,6,232,223,143,209,190,174,124,222,133,143,90,126,106,210,107,210,183,122,209,106,77,91,168,70,131,193,174,167,66,110,203,223,249,96,232,56,78,238,111,41,36,177,84,29,183,176,81,27,203,234,215,67,59,188,22,114,183,69,111,209,172,222,65,140,116,92,197,140,208,204,239,172,47,241,167,42,163,56,125,179,219,171,163,224,29,205,199,198,203,157,157,123,109,47,103,85,229,160,21,191,9,221,238,237,144,45,68,130,251,207,181,183,67,58,158,147,142,247,24,1,209,32,144,79,187,64,200,43,210,255,243,239,119,86,77,249,230,246,231,120,205,112,187,247,82,1,138,93,30,76,237,100,208,129,27,119,218,180,92,167,114,243,146,98,214,25,110,253,104,187,165,121,55,64,132,246,217,253,38,173,61,241,214,228,210,249,58,159,19,213,123,66,113,245,69,233,225,184,86,66,21,54,249,109,117,90,103,252,236,138,226,235,203,243,215,124,200,182,86,148,118,221,104,161,36,118,23,168,126,107,183,46,151,219,212,96,50,163,243,12,69,153,147,108,217,150,56,17,0,210,205,213,185,198,34,30,61,90,222,45,111,254,90,193,216,252,131,184,72,64,6,146,196,145,6,118,253,21,184,252,52,183,249,65,98,155,39,203,49,248,243,63,190,119,67,151,177,43,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateTaskCreatedLocalizableString());
			LocalizableStrings.Add(CreateTaskCreatedDescriptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateTaskCreatedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5fcf534b-390f-49b4-9321-b7b1fc719b18"),
				Name = "TaskCreated",
				CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf"),
				CreatedInSchemaUId = new Guid("434e2e19-3294-47eb-b343-59b6892b92f7"),
				ModifiedInSchemaUId = new Guid("434e2e19-3294-47eb-b343-59b6892b92f7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTaskCreatedDescriptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("813dac6d-9db0-46f8-bb84-6dc3016f7225"),
				Name = "TaskCreatedDescription",
				CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf"),
				CreatedInSchemaUId = new Guid("434e2e19-3294-47eb-b343-59b6892b92f7"),
				ModifiedInSchemaUId = new Guid("434e2e19-3294-47eb-b343-59b6892b92f7")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("434e2e19-3294-47eb-b343-59b6892b92f7"));
		}

		#endregion

	}

	#endregion

}

