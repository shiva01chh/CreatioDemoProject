﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: VideoHelpUtilitiesSchema

	/// <exclude/>
	public class VideoHelpUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public VideoHelpUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public VideoHelpUtilitiesSchema(VideoHelpUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6b0f6ca2-7800-4eea-9bee-0921743e9d8c");
			Name = "VideoHelpUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,89,105,111,219,54,24,254,236,0,249,15,172,10,52,50,42,8,105,129,173,64,179,180,203,213,196,67,211,102,115,146,126,24,134,130,150,104,91,157,174,82,148,211,52,240,127,223,203,67,7,105,202,177,211,54,232,182,2,65,108,145,239,197,247,124,68,151,69,148,78,208,27,114,197,178,180,200,198,204,255,173,200,210,157,205,141,82,172,15,175,11,70,18,227,209,63,39,159,152,185,118,144,197,49,9,88,4,82,252,99,146,18,26,5,38,201,33,197,87,240,88,47,159,19,74,177,208,121,144,37,73,75,171,185,161,219,212,222,165,164,99,217,63,220,239,218,57,74,89,196,34,82,116,237,159,209,108,28,197,221,251,67,102,87,123,49,240,223,145,209,65,150,50,154,197,54,110,157,192,95,157,242,130,69,177,48,89,56,130,51,206,8,101,132,182,88,135,176,56,142,38,37,197,60,4,104,87,51,186,181,3,28,155,27,41,78,72,145,227,128,116,81,109,110,220,108,110,244,242,114,20,71,1,42,24,172,5,40,136,113,81,160,203,40,36,217,9,137,243,218,38,4,148,156,186,151,211,104,134,25,169,232,71,89,22,163,19,92,8,142,131,44,36,96,212,24,199,5,17,38,244,122,15,41,153,112,83,79,9,155,102,97,241,28,157,73,126,185,107,19,118,81,144,215,73,113,152,5,101,130,83,38,12,117,97,141,130,233,169,76,61,84,106,143,125,36,12,235,101,163,15,176,128,10,194,24,56,171,184,196,113,201,173,57,38,12,50,115,40,87,197,162,171,243,123,200,225,58,79,135,66,39,81,58,157,254,142,144,26,141,145,171,139,124,176,139,210,50,142,43,181,61,74,88,73,83,164,226,229,159,103,251,112,12,130,83,157,77,137,155,139,255,138,165,114,148,88,182,248,163,96,148,135,29,78,0,217,26,150,1,59,10,163,123,241,135,174,110,109,87,104,68,224,144,161,56,135,107,115,129,60,162,127,148,228,236,122,37,79,104,25,124,9,213,113,31,254,176,41,253,174,188,2,21,115,65,227,111,238,7,40,18,80,243,29,156,92,157,193,98,243,82,23,120,149,203,138,154,171,120,3,109,114,153,107,154,179,26,19,66,75,10,191,177,163,240,207,233,53,88,102,247,161,161,217,67,89,105,40,236,47,117,159,197,103,220,229,109,95,61,36,105,40,219,110,87,15,22,45,95,57,86,107,255,77,70,213,13,221,85,107,83,24,7,124,86,1,42,24,132,30,90,41,213,102,152,34,194,7,241,245,48,152,146,4,159,226,20,79,8,133,108,211,233,125,30,200,54,133,235,28,45,178,57,125,132,11,100,217,216,169,149,205,170,193,37,247,127,47,9,189,6,109,41,185,210,248,196,186,107,177,12,114,188,158,125,85,154,219,100,250,7,24,30,22,207,49,36,5,239,13,98,215,127,23,177,233,235,44,192,49,127,228,9,111,204,111,41,164,25,251,199,113,54,194,241,41,180,222,152,136,173,99,154,149,121,223,56,221,32,124,21,145,56,4,221,86,195,246,194,16,64,90,153,164,174,51,8,157,22,179,22,191,85,69,156,180,153,28,211,20,158,30,171,74,170,243,105,169,91,95,69,49,71,60,156,209,181,251,157,18,104,3,146,140,251,247,12,83,168,34,206,227,202,69,192,146,57,166,17,32,168,243,235,28,96,224,199,18,199,158,229,240,190,172,62,109,163,127,107,196,7,128,112,57,35,28,184,73,148,154,255,189,131,30,235,18,23,28,86,193,231,46,143,65,33,200,68,109,72,141,22,162,108,84,85,57,107,225,46,199,105,122,149,161,14,154,85,153,50,244,2,109,215,205,165,205,105,80,255,185,253,23,55,132,59,80,197,79,180,158,95,164,206,23,174,30,124,225,73,101,149,208,253,64,53,241,65,241,6,58,211,91,42,154,121,195,212,244,183,158,1,28,25,173,250,91,111,142,8,96,163,46,194,6,56,85,173,80,167,239,38,215,26,103,109,146,54,105,180,134,56,203,162,16,65,195,110,128,58,143,24,224,163,28,176,30,20,173,219,108,160,171,250,107,61,103,238,210,52,21,107,174,97,48,57,160,13,24,104,77,140,198,10,95,75,78,144,96,73,205,22,245,153,169,80,183,160,219,71,205,208,16,175,12,128,67,190,190,83,120,94,217,222,12,12,234,58,181,148,170,88,224,34,233,60,133,145,172,78,251,82,167,87,252,129,5,40,74,41,86,220,186,84,214,84,58,19,216,213,41,30,35,231,165,50,112,151,119,26,195,88,216,126,4,111,32,98,203,102,71,187,66,181,16,24,133,218,170,207,202,132,199,187,200,117,30,69,225,238,66,131,235,107,85,88,21,150,226,91,7,223,45,86,221,32,133,115,225,56,250,76,148,54,158,93,251,37,99,224,56,249,209,54,69,174,116,229,152,90,133,183,187,146,75,225,109,252,0,231,26,36,228,123,117,75,215,8,214,169,218,118,87,213,80,148,97,144,53,242,11,199,241,79,162,48,36,169,222,194,22,169,6,9,96,23,127,152,149,52,224,122,85,189,137,85,185,232,255,65,10,241,69,3,76,93,130,12,226,106,222,53,240,23,202,123,47,207,91,211,166,221,111,235,236,185,77,124,123,150,10,183,189,231,28,239,71,44,245,243,116,162,164,139,217,201,67,163,183,47,37,240,148,111,0,38,188,245,246,69,80,238,227,130,52,67,174,85,14,66,190,249,238,210,76,109,206,203,141,85,64,114,53,101,156,161,122,195,81,195,182,90,246,7,135,26,126,168,214,29,59,245,133,232,221,199,101,4,147,150,92,241,207,46,185,42,99,129,186,43,153,151,242,129,111,50,42,242,7,62,253,87,52,75,246,232,100,228,110,123,79,189,103,207,188,39,63,253,220,161,246,28,79,248,121,40,25,119,156,96,239,3,254,116,52,3,184,13,62,130,42,255,219,127,155,194,39,60,139,69,61,183,90,51,203,47,166,217,85,125,10,151,247,30,113,51,54,36,84,246,133,22,166,224,221,175,95,171,231,199,111,48,100,101,71,99,190,202,169,47,12,106,162,199,211,26,202,100,149,40,38,246,0,118,196,206,164,94,61,108,201,146,136,37,95,35,88,93,113,114,173,136,80,31,36,232,37,66,14,175,64,7,61,55,97,57,143,174,183,101,12,31,213,3,164,113,16,2,160,217,178,164,64,98,68,223,134,23,215,105,85,156,182,221,160,84,227,31,9,190,150,167,238,48,110,23,6,127,11,82,89,70,221,42,35,165,215,91,48,108,133,16,242,48,120,72,254,175,221,46,33,200,175,45,39,27,32,253,46,154,190,139,100,153,119,101,193,173,181,208,21,245,101,111,12,119,140,228,252,254,208,210,189,1,30,37,99,156,209,4,51,121,43,200,115,230,102,123,238,131,217,91,1,247,249,150,135,198,101,42,223,132,9,31,207,55,232,230,201,28,205,231,30,98,211,168,168,130,248,3,59,253,207,177,83,239,171,129,39,110,168,184,183,139,62,227,81,76,212,109,181,113,211,87,69,130,255,78,8,145,105,95,28,214,55,122,142,167,52,245,156,5,121,242,164,54,140,230,139,203,22,167,191,112,81,190,46,108,67,79,61,4,8,0,173,133,220,170,146,84,37,119,255,224,204,210,133,195,112,24,208,40,103,110,187,81,120,200,240,134,106,237,77,187,248,55,225,189,123,204,185,213,211,109,101,164,105,203,180,101,96,115,181,236,250,230,0,225,203,193,228,26,217,154,220,158,168,63,160,233,15,104,250,223,130,166,198,239,137,242,215,14,81,28,54,228,89,165,219,45,119,133,198,239,155,176,10,127,27,27,255,0,90,42,132,24,228,36,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateMenuHelpItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateMenuVideoHelpItemCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateMenuHelpItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("841fba86-d44a-471c-ba11-73e630d36541"),
				Name = "MenuHelpItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6b0f6ca2-7800-4eea-9bee-0921743e9d8c"),
				ModifiedInSchemaUId = new Guid("6b0f6ca2-7800-4eea-9bee-0921743e9d8c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMenuVideoHelpItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("841e68ac-0a14-4a2d-a12b-4ce8f956d533"),
				Name = "MenuVideoHelpItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("6b0f6ca2-7800-4eea-9bee-0921743e9d8c"),
				ModifiedInSchemaUId = new Guid("6b0f6ca2-7800-4eea-9bee-0921743e9d8c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6b0f6ca2-7800-4eea-9bee-0921743e9d8c"));
		}

		#endregion

	}

	#endregion

}
