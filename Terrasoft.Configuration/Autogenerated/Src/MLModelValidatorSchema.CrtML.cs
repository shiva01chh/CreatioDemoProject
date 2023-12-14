﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLModelValidatorSchema

	/// <exclude/>
	public class MLModelValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLModelValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLModelValidatorSchema(MLModelValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9dcb6a93-876d-4465-bc42-68f5f836bfe1");
			Name = "MLModelValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,88,75,111,219,70,16,62,43,64,254,195,148,53,96,10,85,169,244,106,75,10,28,191,170,214,118,147,200,105,15,65,15,107,114,36,45,66,238,202,187,75,219,170,227,255,222,217,7,245,162,100,203,70,144,75,27,24,8,185,156,153,157,249,230,155,217,89,9,86,160,158,176,20,225,18,149,98,90,14,77,114,40,197,144,143,74,197,12,151,34,57,63,123,253,234,254,245,171,70,169,185,24,193,96,170,13,22,251,43,239,164,146,231,152,90,121,157,156,162,64,197,211,154,204,25,23,215,181,197,143,165,48,188,192,100,64,42,44,231,255,184,61,231,82,139,78,21,197,166,47,10,147,163,119,27,63,157,176,212,72,197,81,147,4,201,252,168,112,68,123,192,97,206,180,222,131,243,179,115,153,97,254,39,109,158,185,205,63,162,46,115,227,68,219,237,54,116,116,89,20,76,77,123,225,253,35,78,20,106,20,70,147,42,20,86,23,110,102,202,160,156,182,78,42,237,246,130,250,231,35,102,24,129,107,20,121,244,55,45,76,202,171,156,167,144,90,79,54,59,210,184,119,206,204,28,127,175,228,4,149,161,128,246,224,189,179,224,191,175,122,235,22,78,145,28,149,10,180,253,159,89,79,75,4,46,50,158,210,30,132,213,237,24,205,24,21,48,49,157,199,147,202,98,34,133,139,113,204,52,16,156,82,185,144,234,49,249,21,103,118,246,10,208,73,123,70,149,216,105,167,61,224,195,185,225,185,181,125,144,118,223,91,174,177,101,197,135,44,215,78,126,97,155,185,213,0,212,149,148,57,252,202,244,177,51,1,247,48,66,179,111,67,219,135,135,128,17,138,204,195,228,222,253,234,202,98,133,99,95,24,84,67,162,254,30,244,151,193,151,106,99,250,131,4,234,181,104,41,100,25,23,72,217,28,18,230,148,103,46,8,228,181,100,8,33,241,202,137,117,62,172,102,254,156,114,37,179,109,210,126,56,198,244,139,6,130,24,6,31,206,224,186,68,53,125,44,129,19,166,88,1,130,154,65,55,210,104,75,57,234,93,146,178,127,78,58,109,39,224,228,111,36,207,188,253,193,117,254,193,26,142,7,78,42,8,55,247,159,246,203,249,67,192,229,101,33,30,37,214,51,252,170,201,203,210,76,74,115,232,54,185,160,21,175,233,87,195,222,78,178,110,5,239,82,156,184,114,78,21,14,187,81,149,244,227,106,61,234,121,179,154,236,80,3,3,174,33,183,89,55,99,102,91,192,117,201,21,102,100,119,102,104,5,185,160,189,12,92,11,180,81,182,38,87,29,135,46,136,50,207,183,1,150,28,48,192,242,60,80,147,139,121,172,84,254,10,33,52,47,250,226,200,225,219,213,55,229,71,77,190,64,195,8,61,230,53,170,183,23,161,126,96,8,103,166,13,80,189,45,5,103,51,32,164,217,50,188,77,105,233,139,25,238,181,220,184,218,28,164,99,44,216,121,8,97,22,75,149,153,231,116,159,181,199,207,247,104,60,159,143,112,200,8,149,119,246,20,16,163,216,76,39,40,135,113,173,253,52,155,79,28,81,180,209,218,206,249,242,174,53,143,209,38,79,79,48,229,67,142,217,218,136,115,254,5,193,101,193,101,183,53,75,70,11,88,150,113,155,93,150,207,169,47,50,24,242,156,122,173,211,121,30,213,93,147,91,228,123,32,212,163,172,79,75,109,100,113,190,196,125,191,246,72,9,44,25,112,174,127,226,153,14,202,158,232,37,45,60,174,168,195,40,133,217,137,139,248,104,182,255,252,203,18,24,53,107,10,77,169,132,238,117,218,213,211,198,34,189,144,166,95,76,114,44,40,41,152,45,148,234,106,149,5,34,109,152,114,102,169,143,67,15,92,64,126,214,23,151,33,109,65,255,140,107,211,57,37,68,122,48,71,171,101,119,107,52,102,118,234,96,52,225,222,201,152,177,146,183,32,240,22,54,68,17,219,194,110,132,58,254,238,7,237,182,77,113,176,192,73,72,153,216,53,112,133,128,119,152,150,102,205,41,20,18,241,228,49,30,64,186,97,138,108,209,192,201,45,56,44,15,66,93,8,226,205,224,249,97,78,133,25,0,107,212,21,146,75,57,137,223,132,207,134,28,245,214,215,73,30,123,207,43,91,15,20,147,73,199,16,207,66,38,127,42,239,170,52,211,37,70,179,145,61,41,119,34,138,199,15,153,123,112,143,119,201,185,255,244,112,127,44,110,184,146,194,238,149,92,224,45,93,71,240,33,130,159,188,157,198,78,100,59,167,3,113,111,173,232,125,8,148,38,106,218,225,18,239,76,220,124,136,188,143,11,84,170,37,40,14,190,85,225,108,201,168,255,230,136,180,53,231,37,141,69,114,88,249,72,2,76,163,159,112,236,24,80,10,78,248,61,77,253,151,205,97,129,123,116,177,137,43,242,135,52,29,218,80,227,59,232,246,224,46,57,176,78,193,15,221,186,157,64,185,175,95,107,159,146,190,190,160,45,254,80,199,197,196,76,227,102,19,58,93,248,101,198,246,199,104,230,37,118,34,202,160,194,93,63,14,161,144,229,104,60,59,5,45,195,253,65,122,203,205,56,80,108,45,175,159,40,150,104,48,150,101,158,217,62,195,22,71,178,144,14,143,58,236,246,179,93,119,242,238,46,49,106,55,90,44,133,70,255,88,148,5,42,118,149,99,199,3,223,35,223,197,39,151,194,131,144,216,46,44,35,237,253,72,78,149,44,39,239,166,113,216,183,91,157,3,30,123,234,57,22,204,254,48,128,9,111,223,86,223,7,178,84,41,122,99,78,182,25,44,254,101,209,139,71,214,174,53,231,30,66,90,155,208,163,84,4,57,207,152,85,193,223,113,26,98,179,228,88,141,34,57,16,46,165,91,36,115,39,114,45,217,93,152,201,204,207,158,208,21,207,169,177,121,164,146,223,36,23,113,212,138,90,53,200,168,55,61,179,227,252,127,119,120,254,221,161,214,81,94,124,133,88,104,42,179,48,157,49,34,255,114,223,105,248,161,108,177,134,220,32,84,21,15,187,178,97,56,93,219,82,108,241,172,88,172,216,235,81,32,246,186,135,196,74,87,252,246,192,173,246,183,160,247,13,202,173,218,231,82,90,223,227,133,170,89,117,191,222,18,55,194,96,103,149,112,218,94,34,205,115,68,0,232,134,57,193,7,242,137,230,193,67,41,132,255,173,210,246,188,51,153,186,223,29,169,253,12,28,128,49,45,94,210,157,40,110,58,64,90,16,121,208,78,212,124,246,60,8,62,218,105,82,163,9,35,70,20,130,106,172,67,34,114,71,22,247,25,29,170,133,107,128,171,45,31,245,10,247,50,111,158,202,253,77,53,105,44,132,104,155,162,239,2,39,82,21,204,196,43,161,87,231,88,213,36,128,254,86,193,109,86,19,217,182,243,203,246,191,179,185,53,251,239,95,27,168,53,234,99,22,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateInputsFromMetadataAbsentInDatasetMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateInputsFromMetadataAbsentInDatasetMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c015c29f-6ecd-4d16-a186-bd3b4ed56d12"),
				Name = "InputsFromMetadataAbsentInDatasetMessage",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				CreatedInSchemaUId = new Guid("9dcb6a93-876d-4465-bc42-68f5f836bfe1"),
				ModifiedInSchemaUId = new Guid("9dcb6a93-876d-4465-bc42-68f5f836bfe1")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9dcb6a93-876d-4465-bc42-68f5f836bfe1"));
		}

		#endregion

	}

	#endregion

}

