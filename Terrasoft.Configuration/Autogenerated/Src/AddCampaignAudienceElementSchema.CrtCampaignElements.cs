﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AddCampaignAudienceElementSchema

	/// <exclude/>
	public class AddCampaignAudienceElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AddCampaignAudienceElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AddCampaignAudienceElementSchema(AddCampaignAudienceElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("18b76f07-e920-4aab-96f3-21032be51aa3");
			Name = "AddCampaignAudienceElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,90,219,111,219,182,26,127,206,128,253,15,172,15,48,200,152,167,244,156,167,161,137,83,228,218,122,104,210,46,78,215,135,97,24,24,137,142,137,200,162,75,74,73,188,162,255,251,190,143,23,137,148,37,89,237,233,182,135,46,150,200,143,191,239,126,161,114,186,98,106,77,19,70,110,152,148,84,137,69,17,159,138,124,193,239,74,73,11,46,242,239,191,251,244,253,119,123,165,226,249,29,153,111,84,193,86,7,141,223,241,27,158,127,220,122,120,195,158,138,250,161,79,124,181,18,121,251,27,239,216,248,148,174,214,148,223,229,231,25,91,177,188,80,237,59,36,171,22,118,46,56,59,233,124,117,158,23,188,224,12,137,195,146,255,72,118,7,71,147,211,140,42,245,130,28,167,169,163,125,92,166,156,229,9,179,96,244,234,253,253,125,114,168,202,213,138,202,205,145,253,125,254,196,146,178,160,183,25,35,137,221,74,152,217,67,30,151,60,89,18,154,166,138,36,34,47,104,82,40,82,136,122,29,181,103,196,142,246,190,71,124,93,222,102,60,33,9,34,235,1,70,94,144,19,170,88,243,237,69,38,30,43,232,123,159,52,252,138,219,119,82,172,153,68,41,188,128,191,249,3,45,152,89,208,100,80,63,152,243,191,24,17,11,66,9,202,19,248,188,165,5,176,5,140,168,117,198,11,242,177,100,18,72,33,183,240,210,8,221,193,57,193,165,44,253,213,46,89,48,90,148,82,243,187,205,240,222,218,64,33,28,184,250,51,9,141,193,241,133,148,54,154,170,134,53,197,197,241,37,207,127,163,89,201,14,154,84,78,7,17,65,107,223,219,187,99,133,253,107,143,47,72,52,16,192,33,121,62,118,219,246,30,168,36,15,8,4,112,25,67,13,236,27,220,100,206,138,2,228,163,226,87,172,208,144,163,247,138,73,88,150,179,4,215,76,44,165,189,209,32,232,163,9,153,211,69,227,225,248,192,18,25,44,195,75,90,44,227,75,250,20,105,240,19,96,201,146,248,108,254,39,25,104,45,31,168,19,179,85,239,252,108,205,142,229,169,177,188,30,51,212,214,222,99,133,215,66,20,100,33,178,148,73,162,192,166,86,148,228,16,200,186,76,201,56,143,42,36,90,227,133,222,54,215,187,174,96,19,153,30,145,202,141,48,30,108,188,119,63,146,145,89,63,58,232,129,99,182,249,72,172,183,87,142,254,200,179,140,220,130,29,174,214,66,22,44,37,11,41,86,131,224,118,66,251,68,192,72,15,136,194,127,62,247,128,59,21,89,185,202,201,26,212,10,34,147,164,88,122,48,152,166,250,21,64,78,13,103,239,144,234,80,36,161,152,120,250,13,132,244,170,4,50,33,178,89,58,24,208,25,91,240,28,34,17,184,184,139,210,9,205,73,42,136,132,56,46,53,219,16,176,53,14,107,110,253,112,110,133,200,200,76,93,87,187,135,34,185,42,87,183,96,203,16,88,83,186,81,32,4,208,20,3,157,129,67,36,124,77,49,125,88,225,0,30,144,76,14,217,149,20,124,151,201,99,216,171,192,92,72,6,209,57,79,54,179,252,12,15,25,138,237,34,163,119,24,224,121,158,242,4,131,105,177,164,133,85,18,225,0,118,67,22,60,43,6,201,230,53,85,23,122,237,240,211,205,114,60,223,156,232,231,201,221,206,254,101,135,189,207,57,136,8,76,19,253,98,193,141,70,208,97,134,40,95,219,162,137,22,32,115,33,211,118,75,116,41,201,172,124,205,50,8,123,228,207,133,247,171,47,212,28,231,160,7,85,80,16,128,195,118,168,24,148,27,146,45,166,35,159,230,104,255,40,6,91,180,57,24,61,255,82,36,247,100,93,202,181,80,76,245,243,18,128,11,126,212,249,17,226,102,0,155,188,124,9,153,50,120,50,5,67,125,12,246,71,99,155,78,84,27,133,169,201,152,7,3,242,197,37,43,150,34,109,214,44,78,184,115,240,231,164,32,144,88,79,193,248,65,155,51,168,73,43,79,176,193,107,150,42,179,46,210,170,115,9,13,151,206,210,137,118,30,185,229,60,46,193,99,122,87,122,183,61,225,212,133,49,195,180,165,28,102,244,177,73,161,241,25,87,144,249,225,181,123,96,130,116,52,170,144,141,220,155,11,136,61,81,85,0,188,171,35,66,181,226,195,146,73,86,47,49,240,71,227,120,166,206,63,150,52,139,12,237,24,182,66,218,0,111,136,66,70,199,150,206,94,124,156,167,64,70,66,89,198,210,183,185,166,240,74,255,146,219,52,206,224,241,13,198,159,247,69,114,37,30,99,168,73,49,168,68,63,181,72,204,157,64,149,149,138,179,128,22,233,197,243,53,75,248,98,115,37,222,128,181,190,6,29,168,200,90,140,45,60,90,183,249,22,227,108,224,65,96,110,72,211,121,169,214,96,68,0,73,215,38,176,37,229,168,12,21,233,223,68,133,239,39,206,120,18,115,4,80,112,9,198,188,176,101,25,218,204,239,127,184,85,158,98,212,188,128,194,22,92,108,151,9,53,14,238,80,103,175,42,235,85,13,53,26,12,102,115,190,181,79,69,61,176,123,13,226,13,83,234,219,88,131,35,95,91,60,34,237,18,250,184,83,195,181,122,125,102,162,93,74,36,3,244,87,43,26,93,122,123,201,144,24,145,108,123,174,141,58,67,2,133,139,11,205,128,208,18,15,110,176,237,180,174,210,107,245,221,136,38,187,108,190,215,216,91,228,96,208,116,31,216,227,237,29,178,131,152,13,114,235,166,104,133,100,26,113,168,8,203,21,147,40,152,72,98,182,145,216,106,25,153,234,134,235,16,117,123,100,196,59,142,111,196,27,136,203,14,0,170,214,43,192,212,169,40,243,162,253,108,0,21,235,215,245,206,91,175,163,26,212,189,121,135,74,145,128,151,177,212,157,248,220,188,51,45,117,212,120,125,184,13,178,234,65,81,134,166,63,239,132,13,242,184,166,249,29,107,144,117,173,167,105,6,121,30,85,252,76,122,5,64,126,106,192,119,233,94,183,209,154,136,93,56,157,250,205,242,45,4,153,251,176,207,68,240,229,58,197,200,34,106,99,54,230,102,93,231,189,126,221,236,154,73,167,115,184,192,3,141,183,23,33,39,100,43,158,181,122,123,29,184,108,136,238,142,174,154,209,241,152,64,198,51,24,45,107,93,252,196,31,120,177,52,230,143,124,93,139,71,231,15,85,189,212,189,215,218,186,179,219,189,134,129,252,56,173,141,113,187,29,223,46,152,222,240,252,158,85,238,143,209,198,37,89,27,169,236,82,83,184,217,232,236,5,60,230,53,170,160,167,80,57,177,223,198,94,210,156,222,49,237,147,51,91,211,158,108,176,183,141,186,154,94,47,54,48,245,209,90,129,191,72,251,84,228,67,176,91,96,57,102,37,63,158,162,25,92,8,153,152,137,212,198,11,11,199,25,167,42,26,25,73,184,174,114,212,74,169,179,43,222,77,222,203,124,53,229,153,114,181,33,112,87,72,91,11,107,142,185,186,18,197,85,153,101,118,163,237,109,166,40,138,216,100,233,153,91,98,222,245,160,171,79,52,75,21,242,20,181,31,225,71,100,243,188,74,96,72,0,212,103,126,27,225,55,18,89,189,55,11,196,105,199,18,211,144,164,77,120,10,80,229,233,201,166,87,17,30,30,143,220,16,122,91,146,15,247,204,0,188,252,69,64,212,11,108,60,62,134,173,23,222,147,42,37,191,205,27,47,38,100,11,115,85,195,181,137,161,21,134,181,48,52,241,15,128,94,60,106,249,94,148,185,22,172,11,20,102,114,16,190,26,187,116,29,74,103,162,221,197,179,198,243,167,181,132,72,129,91,124,151,137,209,213,128,5,175,242,179,4,223,74,224,241,140,75,235,204,103,76,37,38,20,141,141,116,12,30,95,65,165,238,168,195,8,242,37,133,143,17,99,184,191,85,188,199,45,118,50,144,150,95,130,30,171,206,38,44,208,142,127,96,131,98,163,47,235,58,213,201,170,187,184,255,175,201,32,126,207,212,38,206,221,45,83,219,174,206,122,26,241,250,201,15,83,147,187,39,177,29,19,245,43,24,23,251,49,193,119,14,43,33,219,59,177,142,170,172,111,208,121,57,9,235,86,255,232,89,190,16,81,112,88,45,143,214,134,160,206,98,190,59,70,238,196,150,204,5,182,232,143,39,226,198,214,223,254,215,201,211,100,107,146,108,157,36,28,1,77,72,107,64,68,105,5,56,158,129,83,64,224,109,8,39,192,234,75,202,206,183,152,148,66,94,130,15,67,34,181,110,5,70,64,51,254,23,22,60,115,189,168,225,97,241,7,33,239,245,149,95,124,205,148,40,33,67,205,11,33,129,128,197,63,234,190,95,210,158,215,164,175,32,14,100,96,176,206,198,13,255,22,84,172,51,158,139,8,197,82,138,71,141,178,81,19,159,72,113,207,114,104,35,233,249,83,194,214,58,138,25,22,99,200,161,43,90,68,62,167,88,226,233,53,56,114,210,117,193,46,107,208,121,172,97,13,168,2,123,6,228,77,144,253,91,249,97,201,11,54,71,217,68,54,245,85,250,248,7,5,254,21,18,55,242,50,24,91,37,253,79,139,218,154,161,153,130,81,153,44,145,32,8,228,60,79,4,38,132,248,253,205,197,207,232,77,39,155,2,226,70,80,72,160,224,159,5,94,119,186,100,201,253,188,162,83,77,137,123,156,175,62,117,203,195,154,62,132,126,213,4,109,202,199,166,235,159,109,114,186,226,137,121,124,62,255,245,235,206,175,185,212,167,180,59,118,19,20,86,82,64,231,56,93,241,252,154,223,45,245,32,113,65,51,197,130,80,62,176,224,26,62,60,21,5,236,99,105,223,101,155,62,89,249,115,102,155,197,246,143,112,6,93,221,223,224,69,128,185,147,19,210,94,9,56,26,230,166,71,50,172,55,240,54,223,109,34,60,213,183,224,120,203,194,243,170,181,236,24,78,235,39,70,16,234,200,122,119,13,0,105,197,135,251,238,189,137,4,150,61,34,30,192,170,121,26,76,134,195,182,38,24,218,52,202,220,202,32,141,10,95,110,199,20,243,226,197,118,234,169,141,161,65,116,152,89,244,102,213,103,109,89,117,110,34,140,153,146,134,5,160,73,197,4,187,159,131,160,66,220,42,150,37,206,65,98,93,46,227,134,70,97,117,16,64,30,210,51,134,181,147,207,224,110,184,33,70,179,190,174,92,227,142,42,195,105,10,153,117,202,241,42,187,192,169,130,19,124,255,105,245,135,147,146,103,105,135,59,244,218,57,154,170,251,218,195,31,218,132,78,2,221,95,150,17,246,4,109,96,171,75,64,174,32,43,188,29,76,170,145,158,190,221,177,118,245,81,151,73,143,75,150,251,8,189,59,73,132,201,3,248,216,102,226,109,209,191,225,116,231,79,186,189,189,11,199,139,209,246,173,10,193,177,133,98,113,207,158,218,181,58,239,56,143,200,115,242,195,15,254,149,108,157,208,141,61,53,103,220,110,198,83,221,125,188,149,29,229,121,231,208,187,11,205,56,204,157,106,96,245,174,134,153,101,61,23,34,105,185,206,244,85,109,26,216,153,111,78,193,139,206,79,112,156,34,31,184,44,64,6,189,3,247,32,126,118,140,145,65,169,67,175,228,78,27,183,113,70,47,157,162,53,18,235,128,182,99,170,13,69,210,239,127,84,163,72,119,48,32,194,153,20,72,167,101,158,88,253,89,84,115,56,0,249,37,20,192,168,65,178,95,181,245,154,81,252,142,234,149,160,217,215,29,141,245,157,219,105,103,174,150,192,160,253,86,202,30,250,206,143,12,254,109,189,204,114,168,104,238,48,53,252,255,252,249,154,221,193,224,183,44,183,236,56,87,57,39,34,139,12,10,121,247,125,10,70,122,19,16,192,45,119,124,10,161,159,172,49,94,233,111,146,166,163,160,149,30,29,153,142,26,41,130,41,174,42,106,88,143,221,178,122,142,15,225,93,19,217,206,6,245,87,43,213,226,48,174,236,76,12,120,223,49,215,31,18,186,41,246,142,9,67,56,13,232,40,162,158,251,97,214,124,255,16,157,157,152,19,128,219,244,182,250,179,101,62,173,74,201,206,78,234,71,81,221,79,212,27,99,176,12,89,220,72,154,43,106,87,185,190,11,96,249,159,0,86,146,57,94,217,235,156,198,144,35,100,169,250,94,15,153,109,238,237,201,102,157,62,86,17,180,215,42,123,189,243,157,118,44,30,223,248,249,46,111,101,220,9,191,1,218,93,234,64,230,193,139,168,79,219,36,175,69,150,221,210,228,190,149,168,110,99,131,139,161,158,143,9,205,211,240,161,126,230,255,247,55,233,18,180,70,242,44,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateDeletedContactFolderMessageLocalizableString());
			LocalizableStrings.Add(CreateBrokenFilterMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDeletedContactFolderMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7c3aaff6-5005-46f4-af4b-7a62dc187205"),
				Name = "DeletedContactFolderMessage",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("18b76f07-e920-4aab-96f3-21032be51aa3"),
				ModifiedInSchemaUId = new Guid("18b76f07-e920-4aab-96f3-21032be51aa3")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBrokenFilterMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("340f5bf5-75c5-49eb-a9a6-f0cdc8d03f10"),
				Name = "BrokenFilterMessage",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("18b76f07-e920-4aab-96f3-21032be51aa3"),
				ModifiedInSchemaUId = new Guid("18b76f07-e920-4aab-96f3-21032be51aa3")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("18b76f07-e920-4aab-96f3-21032be51aa3"));
		}

		#endregion

	}

	#endregion

}

