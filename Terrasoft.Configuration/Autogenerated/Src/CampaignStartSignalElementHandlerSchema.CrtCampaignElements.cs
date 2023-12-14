﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignStartSignalElementHandlerSchema

	/// <exclude/>
	public class CampaignStartSignalElementHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignStartSignalElementHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignStartSignalElementHandlerSchema(CampaignStartSignalElementHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b");
			Name = "CampaignStartSignalElementHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,26,219,110,27,55,246,89,5,250,15,180,22,40,70,168,60,73,187,105,55,89,199,14,20,69,74,180,112,226,34,178,211,135,221,69,48,158,161,228,73,231,162,146,28,69,110,224,127,239,57,188,204,144,115,209,216,219,117,154,197,250,69,22,121,120,238,87,82,89,144,82,190,9,66,74,206,41,99,1,207,87,194,159,230,217,42,94,23,44,16,113,158,125,253,213,167,175,191,26,20,60,206,214,100,121,205,5,77,143,106,223,1,62,73,104,136,192,220,127,73,51,202,226,176,1,115,26,103,191,86,139,54,173,52,205,179,246,29,70,253,137,16,44,190,44,4,229,157,32,211,32,221,4,241,58,243,103,91,154,137,87,65,22,37,148,245,66,119,2,188,120,222,185,53,203,68,44,226,61,172,204,131,80,228,204,129,192,117,67,115,25,94,209,52,32,199,196,229,219,221,134,163,112,248,47,140,174,65,159,100,154,4,156,255,157,148,32,34,96,98,9,255,4,201,44,161,105,37,175,60,244,224,193,3,242,148,23,105,26,176,235,19,253,29,108,41,130,56,227,36,165,226,42,143,56,89,229,140,164,176,130,171,200,96,168,81,19,142,184,9,151,200,9,85,216,125,131,245,129,133,118,83,92,38,113,72,56,13,18,26,145,16,57,236,103,144,84,66,216,118,122,30,112,58,38,139,179,204,108,78,86,130,178,101,176,165,99,160,52,176,54,222,5,73,28,5,194,133,150,228,156,149,121,12,164,227,223,92,176,105,190,185,6,116,159,164,150,42,221,130,191,138,32,19,160,223,159,88,188,5,220,106,127,163,190,144,16,247,65,45,12,213,228,74,243,6,162,6,236,152,193,71,190,242,122,133,31,29,105,202,52,139,20,241,22,78,88,129,206,131,204,72,253,106,94,148,174,123,41,120,35,130,97,58,24,188,167,109,140,190,164,226,252,122,67,189,145,143,11,232,157,131,155,253,44,205,99,154,68,93,154,121,89,196,17,121,175,92,69,6,197,181,242,221,139,69,132,90,161,31,37,132,55,124,50,157,79,127,152,60,158,28,206,167,211,39,135,143,126,252,235,163,195,201,223,38,79,14,31,63,250,225,225,195,233,227,233,244,249,119,143,134,70,57,6,57,163,65,148,103,201,53,89,204,178,34,165,44,184,76,232,83,101,133,19,242,126,139,110,240,38,23,75,202,57,240,73,35,173,7,20,143,107,226,167,49,23,229,9,80,11,177,254,134,147,40,50,218,252,9,148,25,135,241,6,124,64,99,25,142,107,208,179,93,44,230,44,79,75,223,237,128,51,251,167,160,118,32,219,7,38,67,160,15,8,56,149,112,147,34,138,105,22,82,3,95,129,223,244,248,85,101,196,92,64,130,166,145,209,180,254,106,156,187,197,105,122,48,3,198,13,101,152,12,59,92,228,50,207,19,178,224,150,227,138,130,191,45,50,114,124,66,220,132,231,171,61,116,157,99,82,69,44,68,4,247,225,128,139,97,17,221,133,49,43,144,234,185,81,46,64,88,112,2,249,144,227,103,153,8,147,124,189,166,204,39,11,153,30,160,50,230,43,56,74,33,33,48,186,58,30,46,74,35,238,104,88,96,213,59,149,7,134,15,78,252,146,146,157,47,75,157,116,157,36,239,195,246,141,35,43,5,116,30,238,90,87,249,96,77,5,168,92,254,59,232,34,67,158,61,35,94,231,230,177,42,66,170,182,93,67,129,23,79,187,120,57,241,20,161,1,70,161,149,212,38,108,93,160,127,121,195,130,83,6,27,153,106,23,134,99,13,63,184,112,214,71,163,145,20,125,192,37,247,157,250,1,222,32,31,20,78,66,235,55,180,184,162,86,213,3,31,140,138,228,54,246,254,71,126,249,34,134,94,73,192,145,187,88,251,60,78,233,210,144,169,100,113,150,91,45,237,30,108,95,181,173,220,129,219,53,175,187,165,18,102,43,106,175,110,147,118,147,212,241,53,12,210,21,169,175,85,67,210,145,63,182,57,148,24,176,242,140,177,156,121,178,224,4,146,143,69,52,54,105,139,226,222,57,221,9,83,252,4,187,214,255,13,182,1,195,64,94,100,171,188,38,228,169,94,213,128,3,179,46,107,87,45,53,169,226,6,36,53,236,68,178,0,112,37,47,122,99,193,151,69,24,66,77,130,189,85,144,112,106,54,102,134,71,216,40,249,85,123,55,74,161,131,142,96,242,225,67,209,243,180,32,218,2,55,224,189,224,131,196,155,237,66,186,145,12,209,157,81,193,192,18,19,145,72,250,243,156,165,1,68,95,117,224,42,128,120,8,195,130,65,17,248,120,69,85,210,67,157,42,193,84,155,88,6,201,167,135,55,85,168,210,221,184,75,77,134,65,203,250,142,61,65,156,66,118,103,229,121,217,66,96,189,198,177,129,151,93,12,90,143,75,220,175,131,44,80,145,238,185,68,245,198,200,245,82,76,79,206,190,55,108,61,54,52,222,108,47,250,77,254,228,54,234,190,70,125,76,106,209,113,212,37,243,91,154,230,219,47,85,224,139,12,131,145,99,203,109,117,150,216,116,240,26,245,86,1,237,14,173,187,69,61,193,244,235,172,0,242,230,88,164,56,51,10,97,84,20,44,211,139,254,60,201,63,154,179,254,217,10,155,189,125,4,189,86,110,117,214,0,102,176,193,225,103,43,131,241,233,249,137,103,139,114,126,98,230,31,94,230,154,136,38,113,26,11,105,152,225,248,95,217,112,164,226,1,130,135,193,236,108,141,55,74,28,141,219,149,198,96,245,151,20,7,102,111,135,153,116,7,3,160,12,202,145,63,89,175,193,30,192,171,231,197,99,242,97,132,219,49,249,214,34,254,45,172,246,89,2,147,165,212,57,52,175,92,0,243,75,171,81,95,68,174,211,81,13,83,238,218,61,180,196,164,149,89,66,199,37,56,52,89,74,16,125,70,75,85,139,12,165,39,188,36,40,210,12,114,144,36,116,118,249,1,182,23,145,81,163,143,77,182,229,186,22,199,198,115,59,104,251,203,13,13,227,213,245,155,252,52,15,127,121,21,163,119,245,156,80,137,150,190,133,65,3,226,133,201,15,84,117,67,23,154,55,104,196,53,20,70,155,18,228,29,150,57,173,160,134,76,166,86,26,179,215,241,118,38,11,51,228,214,134,42,239,182,129,198,157,40,107,38,151,11,101,224,125,190,81,25,59,206,228,176,101,176,193,57,23,189,255,51,250,190,114,98,171,234,66,105,129,232,102,160,10,27,55,156,62,168,120,240,205,181,132,183,243,107,178,106,6,20,7,188,41,36,32,218,249,213,60,187,224,179,95,11,208,96,130,51,96,238,9,88,221,59,145,27,211,24,219,180,146,248,230,155,14,41,116,125,27,249,231,57,6,136,209,86,188,34,94,77,91,254,36,187,246,70,101,85,214,89,4,210,14,135,196,171,76,112,26,254,182,148,203,210,151,188,150,33,108,76,134,48,234,182,153,74,150,117,19,25,6,251,86,121,15,54,38,80,177,94,151,180,212,182,175,187,0,205,195,184,37,17,214,133,40,149,85,171,247,16,16,239,28,90,94,43,233,170,79,112,161,79,233,150,38,170,51,233,235,24,220,128,152,94,5,217,154,70,42,2,249,127,33,42,238,226,226,165,167,170,27,50,24,86,109,166,208,29,253,139,13,242,26,129,255,40,181,29,236,252,87,1,215,96,146,105,5,252,25,253,103,150,110,192,91,44,14,248,207,1,195,139,191,255,109,231,209,66,220,205,125,230,113,34,176,233,250,188,126,99,59,129,230,224,207,177,191,34,254,255,100,126,21,143,78,137,67,130,183,181,63,173,89,30,102,34,26,224,224,37,91,33,93,43,226,172,1,167,10,174,83,88,113,250,211,87,234,110,197,197,2,134,38,130,166,236,25,201,138,36,33,48,153,97,91,241,12,90,202,246,35,90,175,74,184,114,122,21,52,213,77,23,141,222,210,48,103,145,148,213,160,184,192,185,185,253,202,118,92,227,117,143,86,245,173,222,34,11,147,34,162,64,65,228,115,22,172,229,221,78,123,255,171,233,143,173,134,146,108,177,45,163,81,61,176,48,10,12,191,168,133,61,69,156,28,28,75,101,149,26,215,213,92,48,125,247,160,184,151,40,107,212,170,214,195,82,205,168,142,72,206,240,54,166,58,22,236,9,109,4,71,77,15,137,179,48,79,171,203,96,203,83,252,133,222,170,92,6,57,237,80,108,13,207,184,161,191,18,73,83,13,154,251,27,187,29,173,100,187,205,56,103,91,83,78,21,11,21,231,211,130,139,60,45,163,223,206,142,89,243,122,158,55,239,86,236,153,78,55,218,110,214,180,110,246,49,131,206,147,96,221,238,100,18,162,164,168,39,138,1,52,113,7,251,159,11,236,46,212,125,33,25,237,109,131,219,228,107,74,208,97,205,221,184,49,95,213,198,133,26,193,222,97,161,18,175,42,64,139,172,36,104,135,215,65,203,36,238,142,249,181,186,163,88,114,2,161,82,137,235,2,170,40,117,120,71,119,193,115,33,107,228,173,68,203,95,56,19,56,25,186,245,235,238,149,241,52,206,126,161,53,242,229,5,217,31,44,143,218,5,187,171,164,75,118,220,20,242,79,42,159,253,151,181,125,111,42,147,205,38,129,81,219,121,111,222,251,198,76,2,124,242,117,111,228,241,58,40,216,210,168,227,138,253,159,103,12,39,247,195,239,71,255,182,238,205,101,80,156,85,47,200,94,203,181,176,74,179,141,87,169,42,131,246,95,81,58,137,213,241,80,229,124,251,227,203,41,222,141,206,164,236,36,110,115,211,123,11,207,111,190,90,131,227,91,42,106,250,251,158,235,227,210,187,251,111,128,7,226,138,229,31,155,238,181,215,99,42,71,38,172,72,168,114,29,215,87,56,129,205,210,83,170,3,251,253,228,187,54,55,49,217,179,205,75,172,254,237,238,166,237,186,195,169,77,19,173,208,181,1,247,54,71,204,80,179,31,182,175,70,216,25,254,126,124,174,228,250,75,114,185,219,39,169,92,175,239,247,180,214,132,36,251,215,46,55,251,144,95,170,159,91,89,13,146,243,164,134,157,201,27,186,19,243,152,81,220,104,60,68,200,62,248,168,74,111,37,70,223,224,136,244,179,213,129,219,131,89,91,21,168,100,246,63,78,135,247,149,176,36,87,247,230,57,229,51,99,237,215,7,22,122,236,13,107,63,58,210,20,62,163,251,229,155,158,122,216,154,232,204,47,162,218,60,176,231,113,234,126,171,144,97,236,203,177,107,190,249,67,102,85,69,157,227,15,199,212,28,78,152,28,196,57,52,204,171,156,120,122,44,143,8,40,130,84,191,152,90,201,95,233,140,234,125,16,62,209,94,82,10,245,46,223,196,125,173,80,107,226,193,159,189,117,229,157,251,235,89,238,177,134,160,64,159,187,126,212,58,98,181,234,46,202,53,252,251,29,183,136,157,190,77,43,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNotExistingSignalEntityErrorLocalizableString());
			LocalizableStrings.Add(CreateEmptyEntityFilterWarningLocalizableString());
			LocalizableStrings.Add(CreateEmptyEntityColumnsWarningLocalizableString());
			LocalizableStrings.Add(CreateOnCopyExceptionLocalizableString());
			LocalizableStrings.Add(CreateOnFinalizeExceptionLocalizableString());
			LocalizableStrings.Add(CreateLinkedCustomElementsExceptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNotExistingSignalEntityErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ca262bdc-02c1-4c6f-8b06-4023536955e8"),
				Name = "NotExistingSignalEntityError",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b"),
				ModifiedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmptyEntityFilterWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f93cdad5-5314-4355-b8a7-65a1c2171c95"),
				Name = "EmptyEntityFilterWarning",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b"),
				ModifiedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmptyEntityColumnsWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d80e26e1-a590-4088-89f2-b131a9f1dce8"),
				Name = "EmptyEntityColumnsWarning",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b"),
				ModifiedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOnCopyExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("26f6b121-2628-4e98-9255-f69928d66fe6"),
				Name = "OnCopyException",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b"),
				ModifiedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOnFinalizeExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fa87089a-a36d-480c-97be-3fd4aa5e9335"),
				Name = "OnFinalizeException",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b"),
				ModifiedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLinkedCustomElementsExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fa959371-fb71-43a1-8b7f-27526e5c9124"),
				Name = "LinkedCustomElementsException",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b"),
				ModifiedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("498a4852-f998-420d-9a62-3cefc62a736b"));
		}

		#endregion

	}

	#endregion

}

