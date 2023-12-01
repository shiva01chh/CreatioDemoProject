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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,26,109,111,219,54,250,179,7,236,63,48,62,96,144,49,71,237,118,221,174,189,52,41,92,215,110,125,72,155,161,78,186,15,119,135,66,145,104,135,157,36,122,36,229,58,43,242,223,247,240,77,34,245,98,37,183,75,215,195,229,139,99,242,225,243,254,74,58,143,50,204,55,81,140,209,57,102,44,226,116,37,194,41,205,87,100,93,176,72,16,154,127,253,213,167,175,191,26,20,156,228,107,180,188,230,2,103,71,181,239,0,159,166,56,150,192,60,124,137,115,204,72,220,128,57,37,249,175,213,162,75,43,203,104,222,190,195,112,56,17,130,145,203,66,96,222,9,50,141,178,77,68,214,121,56,219,226,92,188,138,242,36,197,172,23,186,19,224,197,243,206,173,89,46,136,32,123,88,153,71,177,160,204,131,144,235,150,230,50,190,194,89,132,142,145,207,183,191,13,71,225,240,95,24,94,131,62,209,52,141,56,255,59,42,65,68,196,196,18,254,137,210,89,138,179,74,94,117,232,193,131,7,232,41,47,178,44,98,215,39,230,59,216,82,68,36,231,40,195,226,138,38,28,173,40,67,25,172,200,85,201,96,108,80,35,46,113,35,174,144,35,172,177,135,22,235,3,7,237,166,184,76,73,140,56,142,82,156,160,88,114,216,207,32,170,132,112,237,244,60,226,120,140,22,103,185,221,156,172,4,102,203,104,139,199,64,105,224,108,188,139,82,146,68,194,135,86,228,188,149,57,1,210,228,55,31,108,74,55,215,128,238,147,210,82,165,91,240,87,17,229,2,244,251,19,35,91,192,173,247,55,250,11,138,229,62,168,133,73,53,249,210,188,129,168,1,59,230,240,65,87,65,175,240,163,35,67,25,231,137,38,222,194,9,43,164,243,72,102,148,126,13,47,90,215,189,20,130,17,146,97,58,24,188,199,109,140,190,196,226,252,122,131,131,81,40,23,164,119,14,110,246,179,52,39,56,77,186,52,243,178,32,9,122,175,93,69,5,197,181,246,221,139,69,34,181,130,63,42,136,96,248,100,58,159,254,48,121,60,57,156,79,167,79,14,31,253,248,215,71,135,147,191,77,158,28,62,126,244,195,195,135,211,199,211,233,243,239,30,13,173,114,44,114,134,163,132,230,233,53,90,204,242,34,195,44,186,76,241,83,109,133,19,244,126,43,221,224,13,21,75,204,57,240,137,19,163,7,41,30,55,196,79,9,23,229,9,80,11,114,254,134,147,36,177,218,252,9,148,73,98,178,1,31,48,88,134,227,26,244,108,71,196,156,209,172,244,221,14,56,187,127,10,106,7,178,125,96,42,4,250,128,128,83,5,55,41,18,130,243,24,91,248,10,252,166,199,175,42,35,82,1,9,26,39,86,211,230,171,117,238,22,167,233,193,12,24,55,152,201,100,216,225,34,151,148,166,104,193,29,199,21,5,127,91,228,232,248,4,249,9,47,212,123,210,117,142,81,21,177,16,17,60,132,3,62,134,69,114,23,198,156,64,170,231,70,181,0,97,193,17,228,67,46,63,203,68,152,210,245,26,179,16,45,84,122,128,202,72,87,112,20,67,66,96,120,117,60,92,148,70,220,225,184,144,85,239,84,29,24,62,56,9,75,74,110,190,44,117,210,117,18,189,143,219,55,142,156,20,208,121,184,107,93,231,131,53,22,160,114,245,239,160,139,12,122,246,12,5,157,155,199,186,8,233,218,118,13,5,94,60,237,226,229,36,208,132,6,50,10,157,164,54,97,235,66,250,87,48,44,56,102,176,145,235,118,97,56,54,240,131,11,111,125,52,26,41,209,7,92,113,223,169,31,224,13,242,65,225,37,180,126,67,139,43,236,84,61,240,193,164,72,111,99,239,127,208,203,23,4,122,37,1,71,238,98,237,115,146,225,165,37,83,201,226,45,183,90,218,63,216,190,234,90,185,3,183,111,94,127,75,39,204,86,212,65,221,38,237,38,169,227,107,24,164,43,82,95,235,134,164,35,127,108,41,148,24,176,242,140,49,202,2,85,112,34,197,199,34,25,219,180,133,229,222,57,222,9,91,252,4,187,54,255,13,182,17,147,129,188,200,87,180,38,228,169,89,53,128,3,187,174,106,87,45,53,233,226,6,36,13,236,68,177,0,112,37,47,102,99,193,151,69,28,67,77,130,189,85,148,114,108,55,102,150,71,216,40,249,213,123,55,90,161,131,142,96,10,225,67,211,11,140,32,198,2,55,224,189,224,131,40,152,237,98,188,81,12,225,157,85,193,192,17,83,34,81,244,231,148,101,17,68,95,117,224,42,130,120,136,227,130,65,17,248,120,133,117,210,147,58,213,130,233,54,177,12,146,79,15,111,170,80,197,187,113,151,154,44,131,142,245,61,123,130,56,133,234,206,202,243,170,133,144,245,90,142,13,188,236,98,164,245,184,194,253,58,202,35,29,233,129,79,212,108,140,124,47,149,233,201,219,15,134,173,199,134,214,155,221,197,176,201,159,218,150,186,175,81,31,163,90,116,28,117,201,252,22,103,116,251,165,10,124,145,203,96,228,178,229,118,58,75,217,116,240,26,245,86,1,221,14,173,187,69,61,145,233,215,91,1,228,205,177,72,115,102,21,194,176,40,88,110,22,195,121,74,63,218,179,225,217,74,54,123,251,8,6,173,220,154,172,1,204,200,6,135,159,173,44,198,167,231,39,129,43,202,249,137,157,127,120,153,107,18,156,146,140,8,101,152,225,248,95,249,112,164,227,1,130,135,193,236,236,140,55,90,28,131,219,151,198,98,13,151,88,14,204,193,78,102,210,29,12,128,42,40,71,225,100,189,6,123,0,175,65,64,198,232,195,72,110,19,244,173,67,252,91,88,237,179,132,76,150,74,231,208,188,114,1,204,47,157,70,125,145,248,78,135,13,76,185,235,246,208,10,147,81,102,9,77,74,112,104,178,180,32,230,140,145,170,22,25,90,79,242,146,160,200,114,200,65,138,208,217,229,7,216,94,36,86,141,161,108,178,29,215,117,56,182,158,219,65,59,92,110,112,76,86,215,111,232,41,141,127,121,69,164,119,245,156,208,137,22,191,133,65,3,226,133,169,15,169,234,134,46,12,111,208,136,27,40,25,109,90,144,119,178,204,25,5,53,100,178,181,210,154,189,142,183,51,89,216,33,183,54,84,5,183,13,52,238,69,89,51,185,92,104,3,239,243,141,202,216,36,87,195,150,197,6,231,124,244,225,207,210,247,181,19,59,85,23,74,11,68,55,3,85,184,184,225,244,65,197,67,104,175,37,130,93,88,147,213,48,160,57,224,77,33,1,209,46,172,230,217,5,159,253,90,128,6,83,57,3,210,64,192,234,222,137,220,154,198,218,166,149,196,55,223,116,72,97,234,219,40,60,167,50,64,172,182,200,10,5,53,109,133,147,252,58,24,149,85,217,100,17,72,59,28,18,175,54,193,105,252,219,82,45,43,95,10,90,134,176,49,26,194,168,219,102,42,85,214,109,100,88,236,91,237,61,178,49,129,138,245,186,164,165,183,67,211,5,24,30,198,45,137,176,46,68,169,172,90,189,135,128,120,231,209,10,90,73,87,125,130,15,125,138,183,56,213,157,73,95,199,224,7,196,244,42,202,215,56,209,17,200,255,11,81,113,23,23,47,61,85,223,144,193,176,234,50,37,221,49,188,216,72,94,19,240,31,173,182,131,93,248,42,226,6,76,49,173,129,63,163,255,204,178,13,120,139,195,1,255,57,98,242,226,239,127,219,121,140,16,119,115,159,57,73,133,108,186,62,175,223,184,78,96,56,248,115,236,175,137,255,63,153,95,199,163,87,226,36,193,219,218,31,215,44,15,51,17,142,228,224,165,90,33,83,43,72,222,128,211,5,215,43,172,114,250,51,87,234,126,197,149,5,76,154,8,154,178,103,40,47,210,20,193,100,38,219,138,103,208,82,182,31,49,122,213,194,149,211,171,192,153,105,186,112,242,22,199,148,37,74,86,139,226,66,206,205,237,87,182,227,26,175,123,180,106,110,245,22,121,156,22,9,6,10,130,206,89,180,86,119,59,237,253,175,161,63,118,26,74,180,149,109,25,78,234,129,37,163,192,242,43,181,176,167,136,163,131,99,165,172,82,227,166,154,11,102,238,30,52,247,10,101,141,90,213,122,56,170,25,213,17,169,25,222,197,84,199,34,123,66,23,193,81,211,67,72,30,211,172,186,12,118,60,37,92,152,173,202,101,36,167,29,138,173,225,25,55,244,87,34,105,170,193,112,127,227,182,163,149,108,183,25,231,92,107,170,169,98,161,227,124,90,112,65,179,50,250,221,236,152,55,175,231,121,243,110,197,157,233,76,163,237,103,77,231,102,95,102,208,121,26,173,219,157,76,65,148,20,205,68,49,128,38,238,96,255,115,129,219,133,250,47,36,163,189,109,112,155,124,77,9,58,172,185,27,55,230,171,218,184,80,35,216,59,44,84,226,85,5,104,145,151,4,221,240,58,104,153,196,253,49,191,86,119,52,75,94,32,84,42,241,93,64,23,165,14,239,232,46,120,62,100,141,188,147,104,249,11,111,2,71,67,191,126,221,189,50,158,146,252,23,92,35,95,94,144,253,193,242,104,92,176,187,74,250,100,199,77,33,255,164,242,217,127,89,219,247,166,50,217,108,82,24,181,189,247,230,189,111,204,40,146,79,190,254,141,188,188,14,138,182,56,233,184,98,255,231,25,147,147,251,225,247,163,127,59,247,230,42,40,206,170,23,228,160,229,90,88,167,217,198,171,84,149,65,251,175,40,189,196,234,121,168,118,190,253,241,229,21,239,70,103,82,118,18,183,185,233,189,133,231,55,95,173,193,241,29,21,53,253,125,207,245,113,233,221,253,55,192,3,113,197,232,199,166,123,237,245,152,202,145,17,43,82,172,93,199,247,21,142,96,179,244,148,234,192,126,63,249,174,205,77,108,246,108,243,18,167,127,187,187,105,187,238,112,106,211,68,43,116,109,192,189,205,17,59,212,236,135,237,171,17,110,134,191,31,159,43,185,254,146,92,238,246,73,138,154,245,253,158,214,154,144,84,255,218,229,102,31,232,165,254,185,149,211,32,121,79,106,178,51,121,131,119,98,78,24,150,27,141,135,8,213,7,31,85,233,173,196,24,90,28,137,121,182,58,240,123,48,103,171,2,85,204,254,199,233,240,190,18,150,226,234,222,60,167,124,102,172,253,250,192,65,47,123,195,218,143,142,12,133,207,232,126,116,211,83,15,91,19,157,253,69,84,155,7,246,60,78,221,111,21,178,140,125,57,118,165,155,63,100,86,93,212,185,252,225,152,158,195,17,83,131,56,135,134,121,69,81,96,198,242,4,129,34,80,245,139,169,149,250,149,206,168,222,7,201,39,218,75,140,161,222,209,13,233,107,133,90,19,143,252,217,91,87,222,185,191,158,229,30,107,136,20,232,115,215,143,90,71,172,87,253,69,181,6,127,191,3,94,215,242,153,76,43,0,0 };
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
