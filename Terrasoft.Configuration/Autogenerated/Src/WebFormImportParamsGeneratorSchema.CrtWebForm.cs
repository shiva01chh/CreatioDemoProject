﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebFormImportParamsGeneratorSchema

	/// <exclude/>
	public class WebFormImportParamsGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebFormImportParamsGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebFormImportParamsGeneratorSchema(WebFormImportParamsGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b10f75fc-128e-46b0-a8c7-79d9406fa170");
			Name = "WebFormImportParamsGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,88,91,79,227,70,20,126,14,210,254,135,33,251,226,72,145,243,14,73,170,109,8,8,21,88,212,176,219,135,213,10,13,246,73,152,214,246,100,103,198,97,211,138,255,222,51,55,223,29,66,251,2,158,241,185,127,231,230,100,52,5,185,165,17,144,7,16,130,74,190,86,225,130,103,107,182,201,5,85,140,103,225,21,100,128,143,16,255,1,79,151,92,164,43,16,59,22,193,135,147,127,62,156,12,114,201,178,13,89,237,165,130,244,188,113,14,111,88,246,163,188,92,112,1,229,233,146,37,112,157,110,185,80,45,182,5,79,18,136,180,110,105,149,179,168,42,37,77,121,86,151,26,46,51,197,20,3,137,215,248,226,163,128,13,50,147,69,66,165,60,35,206,108,171,236,158,10,154,74,231,18,23,134,126,50,153,144,169,204,211,148,138,253,220,157,145,105,141,76,132,25,46,178,213,108,160,64,72,178,241,188,161,103,157,52,120,167,18,128,38,146,147,72,192,122,54,236,139,235,175,84,66,167,81,67,50,121,167,168,30,136,194,235,67,190,59,53,219,252,41,97,17,137,116,176,14,198,234,140,244,90,60,38,7,53,161,22,157,43,5,48,151,12,146,24,145,185,23,108,135,86,27,16,6,91,123,32,2,104,204,179,100,79,190,72,16,232,102,102,83,129,60,230,181,179,133,122,240,17,178,216,74,117,103,143,61,38,143,18,121,132,218,165,147,111,253,60,100,103,160,223,92,80,69,201,218,61,160,99,205,216,126,165,9,139,53,53,217,249,167,177,150,63,24,92,95,192,154,230,137,66,138,28,110,105,70,55,32,72,220,190,27,55,93,171,123,54,34,38,88,131,134,195,100,70,90,17,64,170,126,243,102,165,129,150,180,203,188,89,151,129,150,188,8,198,172,8,135,121,241,170,255,28,138,253,189,224,91,16,186,30,53,196,92,161,185,16,123,144,221,145,92,229,44,46,192,136,157,203,27,80,231,196,60,73,80,94,89,157,175,176,170,120,56,154,245,134,73,53,213,108,54,255,52,243,156,212,207,21,97,93,178,142,242,216,228,153,125,223,236,44,230,226,10,148,36,136,143,212,255,213,51,248,142,130,22,190,192,147,137,117,137,92,88,136,153,52,229,76,119,26,178,226,248,112,188,164,146,209,23,221,129,44,127,220,244,189,58,175,148,213,1,1,253,111,138,96,187,167,129,0,149,139,236,45,149,54,3,53,54,158,143,173,73,96,156,34,167,51,146,229,73,226,107,8,171,168,87,150,45,144,28,172,76,39,244,181,130,246,113,232,185,250,177,178,72,106,43,232,125,176,189,37,162,3,175,174,90,126,236,43,101,143,81,23,83,215,93,47,46,189,189,226,149,188,7,146,14,49,255,3,12,234,226,198,178,152,69,56,15,113,41,120,121,6,132,70,32,62,76,154,25,234,230,231,193,113,56,153,19,164,150,121,20,129,148,199,3,56,141,230,56,104,96,58,137,144,127,237,249,207,9,215,22,188,48,9,99,77,178,198,41,110,104,186,97,181,0,61,113,158,144,149,21,80,109,107,30,117,233,123,220,155,49,209,137,137,123,157,196,208,190,47,21,219,76,45,43,113,174,234,24,47,133,224,226,214,146,31,99,108,95,239,188,69,168,120,239,54,176,227,56,38,92,201,130,131,47,240,169,180,163,194,52,185,107,220,26,29,13,74,252,29,164,46,166,89,127,227,9,189,192,160,24,64,35,155,120,62,248,179,94,185,161,37,177,228,181,24,28,224,113,36,245,177,100,29,52,115,16,49,43,44,105,47,33,222,93,87,133,254,58,172,113,141,186,132,155,232,45,112,163,82,80,159,115,129,3,49,226,73,158,102,119,184,219,142,73,237,202,212,166,87,92,231,13,63,197,113,144,193,75,99,116,22,168,12,50,20,135,209,168,200,182,247,182,76,103,85,13,182,204,71,125,51,214,237,25,237,76,233,89,42,118,76,168,156,38,214,239,21,168,106,115,147,133,129,23,204,236,79,88,9,83,235,243,152,240,167,63,81,194,188,182,12,233,44,232,232,142,58,236,78,96,17,253,113,115,59,117,233,132,80,1,141,158,137,15,247,95,176,199,54,85,215,18,254,6,123,89,196,174,133,11,26,129,92,231,29,111,191,186,112,158,214,196,125,67,234,239,225,242,7,134,65,6,182,239,254,66,58,40,30,248,202,8,195,168,156,57,232,195,101,186,85,94,85,99,47,90,151,203,96,35,27,46,153,144,234,179,112,145,10,98,67,132,145,212,239,108,38,84,83,193,5,198,140,135,82,102,115,66,116,166,108,53,87,171,73,234,71,6,1,108,177,164,42,56,52,25,23,94,203,59,148,254,89,24,247,130,81,169,166,78,87,207,204,222,65,84,102,91,71,30,217,255,115,178,160,82,213,205,127,224,37,121,173,129,197,197,53,26,160,203,170,95,172,43,242,102,61,226,113,137,89,86,132,222,185,87,10,254,86,128,241,93,47,252,133,199,231,213,242,243,237,165,100,59,102,243,45,107,242,237,181,215,118,99,59,156,90,223,213,135,198,148,161,34,218,254,217,208,99,54,156,235,113,101,86,92,227,208,116,98,168,74,38,235,142,52,100,109,109,211,137,127,95,153,108,124,135,223,215,44,198,245,170,92,16,236,71,191,55,190,188,10,204,111,14,251,85,244,12,41,37,80,57,120,112,117,38,94,246,165,184,122,22,252,197,192,253,73,108,242,20,249,117,142,46,127,70,176,213,209,15,74,63,71,213,157,183,42,51,92,215,75,244,63,169,40,249,235,138,202,65,168,151,27,251,166,252,90,155,117,79,172,206,244,116,29,163,195,98,236,65,250,147,204,103,181,246,173,26,199,150,67,149,225,172,183,41,87,161,141,25,220,28,250,55,209,223,95,20,75,204,207,67,186,117,227,217,54,62,83,229,193,208,234,186,227,88,174,121,22,27,97,195,49,113,13,226,240,194,216,215,245,125,37,105,227,171,49,109,173,49,165,223,167,206,183,81,99,227,110,138,104,207,180,90,237,118,164,105,53,162,227,55,251,82,239,36,198,179,189,173,95,154,187,147,147,127,1,142,99,233,130,69,20,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSchemaNotFoundErrorLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSchemaNotFoundErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("de59cc69-f933-4f42-94c8-1b1ba199a764"),
				Name = "SchemaNotFoundError",
				CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c"),
				CreatedInSchemaUId = new Guid("b10f75fc-128e-46b0-a8c7-79d9406fa170"),
				ModifiedInSchemaUId = new Guid("b10f75fc-128e-46b0-a8c7-79d9406fa170")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b10f75fc-128e-46b0-a8c7-79d9406fa170"));
		}

		#endregion

	}

	#endregion

}
