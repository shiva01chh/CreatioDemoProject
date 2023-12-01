﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: HtmlEditHelperSchema

	/// <exclude/>
	public class HtmlEditHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public HtmlEditHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public HtmlEditHelperSchema(HtmlEditHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7565ccd9-18a2-45be-9c0e-14985cb04c2b");
			Name = "HtmlEditHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,25,91,111,219,186,249,217,5,250,31,56,249,193,18,166,210,237,134,97,192,220,20,167,77,147,214,195,73,218,37,233,138,161,43,14,104,137,113,132,74,162,71,82,118,125,2,255,247,125,188,73,164,36,55,39,195,121,152,81,196,34,245,221,239,159,91,147,138,138,13,201,40,186,161,156,19,193,110,37,62,101,245,109,177,110,56,145,5,171,159,62,185,127,250,100,210,136,162,94,163,235,189,144,180,90,244,206,120,249,97,112,117,67,191,203,193,229,103,186,26,220,189,229,100,7,199,238,222,23,163,170,88,125,252,13,254,187,56,246,154,211,99,247,248,172,150,133,44,168,88,76,70,32,62,45,149,144,160,191,228,172,20,99,52,66,8,252,35,208,192,140,248,188,40,233,167,77,201,72,126,84,180,115,146,73,198,149,108,79,159,0,204,166,89,149,69,134,132,4,2,25,202,74,34,4,122,47,171,242,44,47,228,123,90,110,40,7,32,229,156,201,148,211,53,240,64,31,57,131,91,165,221,223,224,185,216,18,73,53,165,201,198,28,28,173,143,100,77,205,31,141,62,89,83,105,159,38,156,202,134,215,192,71,110,148,110,224,70,124,218,112,78,235,246,251,61,169,243,146,114,68,132,38,177,208,120,7,245,247,48,202,236,58,227,197,70,94,144,26,128,121,239,52,96,191,37,28,137,0,228,68,115,1,243,213,185,53,118,28,5,68,162,68,137,18,92,45,2,93,196,240,149,47,238,148,214,185,177,159,61,91,99,94,80,121,199,242,7,44,41,36,87,142,124,71,229,207,44,35,101,241,43,89,149,244,90,95,254,147,148,13,141,63,9,202,65,238,154,102,42,10,80,19,28,83,135,95,246,145,47,33,45,19,107,20,101,19,78,69,83,74,48,134,65,192,103,213,70,238,141,46,197,45,138,255,96,175,151,226,178,41,203,15,92,191,142,199,169,58,178,19,199,91,108,129,110,52,144,95,224,8,253,113,92,50,184,143,176,214,47,90,116,126,43,5,208,169,233,14,13,72,197,6,104,50,159,79,167,211,20,77,205,199,125,7,39,52,69,159,25,255,102,74,210,233,213,139,191,254,233,47,47,254,108,209,67,227,225,22,14,95,81,193,26,158,1,55,198,193,201,41,178,8,81,152,46,81,170,148,77,218,232,176,38,133,52,190,97,86,208,196,139,15,23,63,6,112,113,36,100,38,147,241,160,209,201,107,192,231,243,57,122,41,154,170,34,124,255,202,93,244,21,119,207,206,14,145,51,135,57,71,40,180,23,10,190,188,163,15,213,242,106,47,219,2,226,65,182,34,206,251,50,190,220,16,78,42,84,131,203,79,162,208,250,209,171,94,100,143,169,51,125,57,215,20,198,9,222,89,81,162,87,3,233,126,136,71,85,5,223,95,103,119,180,34,22,215,49,77,81,223,34,61,137,126,3,225,101,14,186,45,243,255,137,100,88,178,183,172,200,209,53,217,210,215,117,190,172,193,92,114,89,65,120,62,84,19,90,23,57,3,165,232,204,83,25,249,250,167,232,93,3,76,156,228,46,183,199,226,11,181,206,214,37,67,87,213,43,250,159,134,10,169,155,147,106,102,77,13,9,113,130,158,39,97,59,104,147,162,79,28,5,193,215,15,89,147,233,168,7,137,158,13,130,85,147,245,117,116,197,159,138,10,18,180,151,247,35,128,70,64,91,208,110,65,25,243,86,215,170,147,192,96,216,213,47,165,178,173,94,129,117,21,118,112,113,162,164,208,253,7,124,40,73,157,209,55,123,69,36,14,249,36,93,53,30,146,128,186,8,117,249,135,86,245,132,63,47,104,153,91,217,93,12,224,211,178,0,61,150,111,149,236,191,168,49,130,230,58,154,158,221,118,138,168,174,253,145,193,92,149,43,237,52,45,215,63,3,79,127,9,184,124,29,88,207,242,86,143,26,65,157,59,245,70,123,141,67,75,142,41,57,22,56,211,54,64,130,114,166,129,161,32,83,200,76,109,100,243,104,5,90,214,155,70,154,43,67,188,3,193,160,124,161,115,10,98,216,188,44,153,139,136,226,87,167,147,5,254,153,214,107,121,183,104,123,172,122,245,150,72,98,187,216,106,47,233,151,1,248,215,1,207,43,74,242,216,225,166,232,121,218,18,178,40,54,50,90,62,69,181,6,22,218,121,248,156,179,202,208,137,59,146,62,66,113,27,191,227,100,115,87,100,159,100,81,234,201,21,195,180,161,177,207,25,175,136,140,129,30,190,34,59,115,74,218,96,243,38,170,29,225,181,242,237,201,15,6,149,126,21,138,62,27,164,40,241,90,188,146,241,102,191,161,103,156,51,254,56,114,231,62,106,75,212,252,205,24,100,150,155,133,96,31,17,160,220,41,41,203,21,201,190,1,151,159,34,116,219,212,154,80,12,225,117,127,56,160,40,192,183,152,226,142,237,46,12,182,25,7,1,215,164,141,57,6,22,12,0,99,107,161,52,212,48,53,228,45,232,27,246,253,77,35,37,200,138,63,124,75,81,119,187,4,249,33,44,111,181,3,180,182,61,29,146,69,39,107,48,168,226,215,121,110,37,24,8,239,35,29,41,195,25,68,139,237,13,131,36,66,97,187,10,162,92,181,183,19,221,57,240,37,221,169,111,24,124,16,0,160,0,236,138,110,84,62,49,190,215,134,132,253,195,108,40,123,101,191,151,231,1,196,43,55,227,77,84,238,156,42,135,242,70,1,191,230,235,166,2,23,196,253,1,34,237,213,245,36,9,83,209,232,165,204,106,19,242,188,189,52,123,148,122,213,43,194,169,83,47,109,235,88,210,37,108,71,17,127,36,106,149,57,101,101,83,213,199,186,196,131,136,58,210,91,204,101,62,138,112,195,36,41,149,232,166,24,216,18,228,149,135,81,44,189,123,169,102,172,53,191,160,21,152,216,171,19,10,93,199,71,139,219,121,2,27,235,40,150,113,72,85,99,32,52,104,227,46,110,236,126,165,107,75,111,220,52,64,173,127,50,31,210,200,24,32,219,218,211,178,8,230,4,253,193,40,12,87,61,13,24,81,109,158,232,137,94,5,158,71,216,92,218,9,192,56,33,245,88,89,54,126,239,125,214,231,29,50,209,48,38,29,250,93,27,171,48,234,233,225,17,66,49,244,98,243,152,24,40,131,12,219,162,154,161,195,8,113,81,217,39,231,77,225,125,49,91,51,245,18,27,193,244,104,121,104,147,88,43,4,2,246,119,128,112,196,49,24,71,148,54,47,117,133,180,99,78,164,130,45,74,60,115,140,74,160,136,145,82,80,83,163,22,65,144,141,235,230,107,22,134,222,81,112,124,108,186,237,115,9,151,170,161,247,60,66,195,48,28,176,29,30,187,109,213,191,233,77,180,182,45,249,201,226,2,66,253,116,133,175,41,47,84,239,164,177,15,146,14,210,73,1,195,121,11,11,4,229,177,171,147,71,27,137,25,207,236,112,16,221,63,63,224,194,91,62,238,95,28,18,168,189,131,185,50,29,202,153,248,131,72,187,254,62,188,209,78,199,92,156,250,239,211,214,75,35,59,213,152,7,61,212,225,82,235,232,132,46,250,63,95,107,71,86,197,43,186,46,96,120,231,111,169,36,69,9,30,53,53,207,184,245,177,75,163,255,235,145,112,211,144,142,6,152,162,102,43,10,211,10,45,20,125,146,231,179,180,27,176,60,252,123,4,193,130,14,135,100,17,117,173,89,172,108,193,55,211,222,155,166,40,115,21,149,118,137,88,225,215,155,13,173,243,248,167,168,27,27,107,74,115,80,199,232,101,55,17,160,114,246,93,226,156,102,44,167,177,122,92,83,25,207,178,70,72,86,169,146,163,247,147,89,130,115,86,225,173,14,199,47,179,49,66,51,59,146,155,31,194,198,32,218,149,100,210,70,189,154,182,78,161,157,74,170,109,252,25,182,59,182,115,74,76,14,136,66,37,67,247,110,76,125,112,62,53,104,173,13,87,178,86,230,179,76,149,92,112,163,6,243,217,158,138,153,247,202,200,172,148,87,233,10,73,87,228,4,122,184,210,87,61,209,56,241,129,131,49,80,137,121,112,79,202,200,48,154,21,91,61,25,180,173,115,167,213,250,242,120,59,95,239,197,5,203,155,146,254,210,167,58,251,250,117,225,115,101,181,122,103,127,126,35,91,170,155,138,63,172,183,194,255,70,219,195,167,207,19,55,16,177,66,17,135,64,29,48,76,145,188,43,68,226,89,165,125,28,16,98,143,33,52,192,86,152,157,156,206,250,135,131,151,29,191,199,166,101,50,102,119,5,30,227,249,37,147,90,56,187,26,60,142,240,229,17,42,142,211,239,184,55,29,19,248,232,10,245,47,42,46,217,96,139,250,135,202,215,241,21,170,87,95,70,246,165,30,68,116,248,119,221,106,234,244,10,187,163,185,30,237,134,98,245,80,159,245,184,30,249,175,132,249,60,92,213,237,93,111,159,135,91,192,135,127,240,249,47,150,59,29,95,143,27,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateWarningLocalizableString());
			LocalizableStrings.Add(CreateNewRecordNotSavedMessageLocalizableString());
			LocalizableStrings.Add(CreateFileTypeErrorLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8d082029-dbc9-4d76-82b5-33b2ca44358c"),
				Name = "Warning",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7565ccd9-18a2-45be-9c0e-14985cb04c2b"),
				ModifiedInSchemaUId = new Guid("7565ccd9-18a2-45be-9c0e-14985cb04c2b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNewRecordNotSavedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e89899be-e7fe-4fb9-bed6-832ac3e6a1f2"),
				Name = "NewRecordNotSavedMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7565ccd9-18a2-45be-9c0e-14985cb04c2b"),
				ModifiedInSchemaUId = new Guid("7565ccd9-18a2-45be-9c0e-14985cb04c2b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFileTypeErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("22e9f7cc-3b8b-4750-803d-9d8acdb561de"),
				Name = "FileTypeError",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7565ccd9-18a2-45be-9c0e-14985cb04c2b"),
				ModifiedInSchemaUId = new Guid("7565ccd9-18a2-45be-9c0e-14985cb04c2b")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7565ccd9-18a2-45be-9c0e-14985cb04c2b"));
		}

		#endregion

	}

	#endregion

}

