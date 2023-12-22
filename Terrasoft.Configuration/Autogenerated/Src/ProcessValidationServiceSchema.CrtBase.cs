﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProcessValidationServiceSchema

	/// <exclude/>
	public class ProcessValidationServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProcessValidationServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProcessValidationServiceSchema(ProcessValidationServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6d4963b1-ef74-48bf-bd58-4e13be43cc3d");
			Name = "ProcessValidationService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("81bfb393-8e74-4130-a152-d81d42a422b6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,87,91,111,219,54,20,126,118,129,254,7,198,1,10,25,240,232,236,181,137,61,36,89,154,185,200,13,177,187,60,4,27,64,75,76,162,85,166,20,146,242,172,181,249,239,59,148,72,93,40,202,81,90,3,65,68,242,220,207,119,120,14,25,89,83,145,16,159,162,37,229,156,136,248,65,226,211,152,61,132,143,41,39,50,140,217,251,119,223,222,191,27,164,34,100,143,104,145,9,73,215,135,214,26,232,163,136,250,138,88,224,115,202,40,15,253,22,205,69,200,158,91,155,183,41,147,225,154,226,5,176,144,40,252,47,87,216,162,130,211,77,232,211,203,56,160,209,206,67,124,71,87,187,9,142,193,202,141,165,165,238,247,122,221,117,194,105,215,62,190,225,177,79,133,112,157,131,65,149,84,56,159,76,38,232,72,164,235,53,225,217,76,175,247,243,159,254,87,126,252,98,214,251,216,240,77,106,140,247,218,45,72,149,228,196,151,127,169,189,99,145,92,81,9,250,18,112,113,21,70,161,204,110,233,115,26,114,186,166,76,10,175,190,80,241,64,83,244,10,139,162,194,122,35,24,41,37,73,186,138,66,31,249,17,17,2,105,207,255,132,220,5,121,84,181,85,232,35,58,33,130,154,213,183,220,247,150,243,53,239,27,17,104,126,219,241,192,165,168,122,60,6,33,147,148,51,18,53,45,59,125,162,254,215,27,194,1,228,112,156,187,201,41,255,136,230,103,207,41,81,206,154,173,35,39,195,204,152,222,182,189,105,124,221,246,250,2,87,204,147,22,247,81,162,244,32,6,186,166,195,237,112,230,18,209,242,254,104,146,115,117,72,201,126,88,10,167,50,229,76,204,108,86,77,110,142,115,6,141,129,85,28,71,40,15,164,240,156,225,67,219,177,59,17,40,27,169,200,130,168,65,248,128,0,151,15,148,83,230,83,45,12,216,178,81,73,49,40,116,35,201,211,188,6,225,247,178,147,151,165,81,52,66,223,191,163,235,213,63,112,45,97,155,36,211,36,45,13,15,112,106,169,208,39,158,183,197,87,96,59,154,78,81,150,127,141,208,135,15,200,219,219,226,223,137,36,80,0,41,93,102,9,21,248,108,235,211,68,122,153,181,63,194,199,44,243,148,85,90,229,158,77,97,56,109,137,154,115,52,42,12,43,236,234,131,201,125,244,7,17,79,167,170,206,119,163,212,89,97,189,64,155,184,146,251,211,16,52,102,119,192,14,42,29,157,83,105,168,58,160,231,52,109,39,234,156,28,93,80,57,176,144,8,54,61,129,65,5,70,144,91,86,137,160,2,160,191,161,3,184,39,187,41,113,221,73,157,253,82,81,19,35,221,42,109,58,173,92,59,163,76,208,159,93,150,88,32,117,217,164,67,82,250,255,183,195,194,26,120,95,250,116,131,174,11,181,103,55,232,66,234,151,121,208,128,231,43,184,108,137,241,27,193,17,70,86,71,235,106,203,178,110,217,26,181,5,246,251,235,132,22,243,87,189,195,15,238,97,160,152,179,77,252,149,122,151,84,62,197,1,100,126,120,115,189,88,14,199,232,36,14,178,133,204,34,5,64,32,187,4,119,201,35,45,119,241,29,39,73,66,131,113,158,9,213,211,169,144,159,98,190,38,178,193,80,108,225,207,34,102,99,116,11,179,33,76,117,116,55,93,62,24,152,242,172,151,35,176,167,145,68,77,72,9,239,60,13,3,84,101,100,140,46,66,33,187,58,176,21,114,83,137,170,130,61,235,172,170,45,184,252,237,67,152,195,96,218,84,36,7,85,57,107,232,50,250,175,203,110,83,243,243,98,194,1,247,85,15,210,133,95,191,142,231,11,80,182,38,151,132,65,96,248,28,198,78,227,77,113,48,51,222,214,40,208,180,16,244,69,168,193,132,177,98,128,198,13,62,77,142,63,133,44,80,60,39,25,132,203,171,34,167,43,80,197,194,165,192,68,67,251,33,36,87,211,41,12,167,49,95,210,173,74,167,114,252,34,246,243,217,123,21,209,69,78,225,89,38,65,52,226,148,251,112,26,115,16,62,6,196,117,204,125,195,177,142,216,176,37,84,24,207,174,98,64,93,202,130,51,99,6,206,111,137,225,8,47,99,173,223,186,88,122,103,39,239,223,198,132,179,154,155,165,203,142,220,53,2,110,242,164,87,83,212,39,59,112,39,206,153,144,4,90,73,71,130,54,4,26,82,13,166,77,53,184,2,233,97,221,36,247,240,138,124,243,49,109,69,166,69,108,66,185,171,192,66,182,81,241,171,151,145,93,116,69,216,240,221,19,52,76,171,174,208,116,134,246,188,196,34,29,192,179,75,61,9,171,3,69,215,105,174,87,245,215,129,110,161,73,163,23,154,164,14,90,125,47,71,176,242,174,64,247,204,251,181,38,107,144,184,251,88,46,211,16,233,22,62,120,49,93,81,251,217,48,189,125,153,48,73,66,38,42,170,113,153,152,81,41,104,25,239,8,60,204,116,149,24,223,154,58,74,89,133,40,253,79,11,52,89,237,85,31,85,121,120,173,76,215,239,68,29,226,185,3,13,45,190,162,124,14,123,117,243,183,12,157,237,70,126,175,242,214,104,129,174,7,168,53,251,189,250,104,171,204,232,156,117,115,197,151,116,189,2,116,106,72,14,213,12,48,44,154,157,49,67,223,169,138,226,176,199,83,209,14,201,155,212,7,13,236,91,134,212,107,0,57,102,175,183,228,9,53,204,251,169,164,84,88,124,253,201,210,124,115,190,37,50,97,129,113,43,36,249,251,84,195,191,127,114,28,99,220,155,76,177,107,197,149,167,142,155,184,85,123,61,172,70,63,96,99,217,14,221,96,46,59,167,1,142,250,203,241,83,255,253,15,143,0,197,175,57,20,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateProcessNotFoundErrorTextLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateProcessNotFoundErrorTextLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5619a7a6-c8c1-44e8-a135-b4972b4750d4"),
				Name = "ProcessNotFoundErrorText",
				CreatedInPackageId = new Guid("81bfb393-8e74-4130-a152-d81d42a422b6"),
				CreatedInSchemaUId = new Guid("6d4963b1-ef74-48bf-bd58-4e13be43cc3d"),
				ModifiedInSchemaUId = new Guid("6d4963b1-ef74-48bf-bd58-4e13be43cc3d")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6d4963b1-ef74-48bf-bd58-4e13be43cc3d"));
		}

		#endregion

	}

	#endregion

}

