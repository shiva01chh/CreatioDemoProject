﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastCalculatorSchema

	/// <exclude/>
	public class ForecastCalculatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastCalculatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastCalculatorSchema(ForecastCalculatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e4445224-cbe2-4a10-94f3-11f18788f291");
			Name = "ForecastCalculator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,90,109,83,35,55,18,254,236,84,229,63,232,124,85,169,153,43,35,8,108,32,11,216,148,177,49,231,173,205,46,133,33,249,112,149,218,26,102,100,152,171,121,139,52,195,198,183,225,191,95,235,117,36,121,6,216,187,100,63,96,75,234,110,245,203,163,86,183,188,69,148,19,86,69,49,65,55,132,210,136,149,235,26,207,202,98,157,222,55,52,170,211,178,192,139,146,146,56,98,245,207,251,223,126,243,229,219,111,6,13,75,139,123,180,218,176,154,228,39,222,24,191,79,139,223,182,38,103,101,150,145,152,11,99,248,146,20,132,166,113,75,99,111,75,73,223,60,94,68,113,93,210,148,176,94,138,249,121,239,210,69,81,167,117,47,111,158,151,69,255,10,126,199,196,50,16,252,157,146,123,48,2,205,178,136,177,99,164,29,51,139,178,184,201,34,80,79,80,237,238,238,162,83,214,228,121,68,55,19,53,190,162,229,99,154,16,134,114,82,63,148,9,67,117,137,98,197,70,208,26,108,67,81,145,160,170,172,9,168,26,101,168,92,163,181,18,143,181,204,93,75,104,213,220,101,105,140,98,174,73,135,34,232,24,45,223,149,119,23,191,147,184,17,122,13,190,8,221,140,9,139,148,100,9,216,112,69,211,71,80,65,46,86,114,128,88,13,145,143,209,101,147,38,232,19,87,110,89,36,105,204,229,46,19,52,70,5,249,44,214,130,225,15,251,179,233,197,254,225,98,231,199,55,139,195,157,55,251,211,189,157,233,244,98,177,243,246,232,232,237,222,116,113,112,254,227,252,237,48,60,233,149,109,236,237,219,96,186,183,247,102,49,59,154,238,204,15,15,230,59,111,46,14,102,59,111,15,126,56,220,217,155,206,143,142,206,247,15,247,246,22,7,98,3,97,27,41,18,105,158,107,43,56,191,34,148,199,159,219,11,91,198,53,73,180,197,106,136,110,25,161,128,251,66,226,212,31,126,65,247,164,62,65,198,8,62,120,114,5,172,30,8,169,77,40,228,232,21,108,239,83,86,159,94,193,145,40,147,9,146,159,236,53,124,112,166,154,188,88,145,186,230,160,117,71,61,236,118,24,150,226,72,108,150,133,193,14,201,178,107,82,149,44,133,40,108,208,167,216,25,159,184,155,191,196,237,13,199,28,177,131,129,39,19,157,157,161,192,159,27,203,195,37,79,251,6,178,69,125,250,194,102,147,64,8,31,112,208,64,196,88,77,27,206,59,165,247,77,14,224,10,134,141,19,202,225,200,139,109,24,106,252,24,223,56,65,180,157,194,220,9,223,43,125,124,254,88,251,195,19,39,29,226,79,118,121,164,103,163,191,192,21,18,145,182,15,42,111,198,119,194,22,199,214,132,54,223,151,36,237,223,154,237,114,128,47,243,47,4,129,60,90,206,209,240,102,250,96,176,197,185,53,97,14,134,191,32,143,198,22,249,51,80,240,101,255,249,30,1,17,60,185,124,162,100,77,40,41,98,146,200,61,127,142,178,134,124,128,50,194,243,131,162,191,238,35,71,95,132,134,247,34,79,82,82,55,180,120,70,184,116,73,255,242,24,93,242,163,208,179,28,128,53,50,131,62,117,27,101,46,227,68,102,155,126,123,102,29,148,157,166,116,137,84,129,237,90,17,6,116,9,239,213,93,222,161,113,153,87,25,1,142,85,29,221,147,101,226,105,45,136,102,30,77,183,190,30,17,94,178,139,188,170,55,65,136,36,148,6,18,148,158,40,169,183,55,11,58,107,166,227,30,21,7,182,73,125,87,247,79,178,92,234,169,83,30,75,176,237,138,146,42,162,36,185,138,40,56,171,38,148,5,203,121,42,48,12,181,210,169,140,218,8,149,119,255,6,135,76,80,101,200,66,229,5,225,33,93,108,105,229,210,53,10,248,2,190,161,27,144,204,72,208,50,254,107,184,48,212,195,95,207,240,77,185,18,155,4,33,108,211,212,150,172,80,239,49,112,235,130,177,127,37,240,179,44,166,2,139,217,114,211,128,100,76,163,108,80,63,208,242,179,40,146,244,105,254,208,100,217,197,239,49,169,184,213,82,83,142,156,99,100,107,234,200,91,22,105,173,170,13,203,50,73,242,212,225,101,155,254,235,220,251,24,81,36,115,250,18,42,155,49,178,253,120,165,231,135,191,162,136,201,90,136,123,125,34,85,213,229,208,120,235,14,225,254,50,234,107,33,33,254,229,1,142,127,80,65,94,69,21,6,176,209,122,206,45,56,29,35,254,121,147,230,4,127,40,63,135,16,49,190,85,208,105,174,80,66,196,126,132,228,223,132,196,105,30,101,230,75,56,105,147,64,32,200,121,69,50,65,188,148,97,35,183,162,147,202,25,103,180,22,34,34,171,26,97,158,224,196,43,194,187,164,32,230,234,199,88,85,61,73,136,231,192,148,22,176,226,41,62,120,149,170,148,176,38,171,85,85,253,26,14,45,93,169,206,251,191,139,40,126,144,110,85,16,180,229,116,236,217,38,56,126,103,233,1,191,183,166,69,114,165,139,254,160,26,181,94,80,155,190,218,38,16,172,18,76,187,153,227,193,32,198,75,104,62,191,31,1,20,150,32,70,14,247,245,151,131,208,247,230,64,122,10,79,147,228,58,42,238,73,0,99,125,102,212,167,74,149,146,176,247,172,220,86,9,183,214,170,86,89,224,0,192,130,11,247,143,83,206,114,100,75,22,39,101,140,116,111,160,109,84,32,231,57,198,179,131,167,46,9,168,37,227,137,225,35,85,105,220,36,35,105,134,157,14,90,175,155,136,72,247,155,163,107,220,47,186,213,118,100,90,56,8,11,152,29,153,184,180,71,68,157,11,101,128,210,146,211,26,104,37,22,180,60,119,172,162,71,194,167,124,119,36,184,85,212,239,81,249,170,209,91,161,132,163,95,148,3,203,98,93,194,173,39,190,131,178,9,22,221,183,142,240,255,180,125,87,27,251,117,58,180,141,255,147,11,185,238,114,5,48,242,190,4,220,167,255,137,238,50,162,110,31,181,86,64,118,213,145,86,120,117,43,59,220,201,13,147,55,155,10,138,13,204,111,142,145,18,3,229,138,20,139,5,134,122,33,63,163,4,190,95,147,60,5,15,240,155,208,74,254,84,207,222,214,105,38,158,97,186,10,217,235,45,42,147,136,100,38,92,197,15,36,143,20,60,213,96,236,155,102,147,254,20,21,80,109,80,188,0,185,75,40,128,35,168,11,207,101,69,53,116,162,169,111,70,174,236,167,184,161,80,65,214,74,110,205,129,149,108,239,51,107,169,176,33,107,165,196,226,1,77,229,92,99,153,124,86,11,108,11,240,45,28,96,141,252,105,3,197,142,124,1,233,84,67,193,200,86,235,57,186,85,35,238,100,65,231,216,139,13,201,156,176,152,166,162,106,144,117,220,54,46,134,70,125,139,120,24,42,1,87,101,213,84,55,105,157,113,24,43,164,192,94,121,84,7,47,72,107,57,65,152,167,31,143,81,40,79,129,206,187,62,56,176,143,56,55,64,35,21,130,206,67,228,62,150,128,158,110,15,165,22,218,156,237,46,35,217,150,113,12,123,45,151,72,221,98,206,75,222,60,75,75,127,1,24,41,171,63,210,57,89,71,112,133,56,41,91,137,5,208,64,210,70,127,252,161,54,194,90,31,147,206,127,121,72,107,178,226,111,182,91,57,29,201,118,207,50,35,112,202,62,69,197,159,52,49,196,19,242,19,15,16,57,117,88,38,129,183,179,227,197,87,148,234,61,79,108,143,41,173,27,72,113,226,94,233,108,26,172,172,193,248,220,243,189,239,199,170,42,65,98,193,79,147,75,253,255,55,191,39,166,53,56,67,110,251,34,128,238,236,198,149,153,194,21,17,250,209,101,252,90,227,113,187,40,18,244,221,119,226,235,170,137,99,194,216,186,201,194,51,172,115,134,10,139,187,17,254,103,196,228,13,225,171,128,229,244,177,240,100,87,102,246,61,222,94,27,221,13,166,221,9,53,34,97,56,128,192,171,178,161,49,185,213,234,90,55,13,144,114,134,191,73,212,74,175,159,125,125,86,6,209,65,195,107,93,174,143,148,114,188,125,243,24,144,235,230,252,21,6,63,243,36,96,91,45,17,127,219,97,59,8,144,19,218,250,63,255,58,234,10,74,232,184,90,170,167,222,9,90,93,61,183,59,55,139,202,68,62,38,85,119,33,44,181,68,1,24,61,255,188,24,133,86,167,231,99,241,66,175,208,223,30,200,130,81,85,160,35,212,213,59,217,25,195,241,81,111,216,183,59,167,175,233,153,250,187,165,54,133,243,93,94,40,189,237,14,66,101,102,145,243,68,105,175,182,85,117,190,151,152,212,53,34,141,178,54,244,22,22,77,17,227,85,147,7,195,105,94,54,5,148,56,33,158,50,168,123,192,199,195,62,90,85,165,206,84,242,23,103,94,209,24,49,232,31,168,115,29,146,254,93,116,199,47,231,13,16,237,106,34,145,124,131,239,247,246,66,181,169,84,195,196,216,232,178,160,101,222,125,14,4,67,105,8,101,139,15,19,35,52,84,247,198,48,228,41,246,55,192,90,160,182,53,111,65,129,127,199,104,61,6,24,160,166,196,204,27,194,159,7,132,152,75,81,86,80,8,92,183,60,9,198,246,109,225,37,121,239,33,215,247,74,81,132,29,50,172,192,226,101,177,37,128,5,237,9,208,142,185,164,101,83,157,111,182,248,249,195,138,196,146,202,40,226,59,150,63,13,194,45,22,37,160,16,21,31,86,23,102,55,123,0,72,185,222,22,56,226,56,157,42,162,137,198,213,137,203,219,54,53,47,11,176,16,161,164,56,205,104,175,4,145,15,236,115,176,213,203,7,65,219,169,201,214,181,109,89,95,219,222,191,92,243,136,159,99,229,162,255,251,175,152,48,208,102,230,121,144,97,67,189,235,147,159,138,87,50,113,209,141,253,98,101,98,253,46,89,174,17,95,197,167,187,130,161,155,191,125,113,27,78,222,149,119,214,11,156,195,167,126,82,22,253,156,66,135,151,125,80,227,21,217,95,247,18,232,9,27,123,226,212,155,223,246,115,174,255,62,57,112,11,248,241,115,37,188,100,232,124,145,81,178,252,206,181,47,238,131,39,36,255,19,128,53,7,100,240,239,191,224,159,94,120,67,33,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateRemindingDescriptionLocalizableString());
			LocalizableStrings.Add(CreateRemindingPopupTitleLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateRemindingDescriptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("768517af-1280-4b84-9c07-a7a4f5e0cb38"),
				Name = "RemindingDescription",
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39"),
				CreatedInSchemaUId = new Guid("e4445224-cbe2-4a10-94f3-11f18788f291"),
				ModifiedInSchemaUId = new Guid("e4445224-cbe2-4a10-94f3-11f18788f291")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRemindingPopupTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c428d252-0153-46c4-898d-195396c22692"),
				Name = "RemindingPopupTitle",
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39"),
				CreatedInSchemaUId = new Guid("e4445224-cbe2-4a10-94f3-11f18788f291"),
				ModifiedInSchemaUId = new Guid("e4445224-cbe2-4a10-94f3-11f18788f291")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e4445224-cbe2-4a10-94f3-11f18788f291"));
		}

		#endregion

	}

	#endregion

}
