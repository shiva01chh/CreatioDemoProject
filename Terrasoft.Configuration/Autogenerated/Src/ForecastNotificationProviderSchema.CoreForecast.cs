﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastNotificationProviderSchema

	/// <exclude/>
	public class ForecastNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastNotificationProviderSchema(ForecastNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3dcbc99d-70ca-41f0-b08a-1d7398a45a96");
			Name = "ForecastNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0db428d0-fc38-40d1-af3f-5cbb75ee95a9");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,88,89,111,227,54,16,126,246,2,251,31,8,247,197,6,12,229,61,206,6,176,157,3,46,146,172,97,59,237,195,34,40,24,105,156,176,208,225,37,169,20,238,162,255,189,195,75,38,101,73,113,178,219,2,5,154,151,88,195,57,191,57,56,82,78,51,16,91,26,3,89,3,231,84,20,27,25,205,138,124,195,158,74,78,37,43,242,143,31,190,125,252,208,43,5,203,159,2,22,14,209,197,116,92,29,173,118,66,66,134,244,52,133,88,201,137,232,26,114,224,44,30,183,136,55,211,179,172,200,235,90,15,172,92,80,73,15,136,55,44,255,218,229,15,158,225,233,79,28,158,240,137,204,82,42,196,41,185,66,71,98,42,228,93,33,217,134,197,58,226,5,47,94,88,2,92,243,111,203,199,148,197,36,86,236,157,220,228,148,76,169,128,166,163,17,153,251,100,212,250,77,235,174,156,185,98,144,38,232,205,130,179,23,42,193,28,110,205,3,137,209,119,73,132,228,42,172,235,229,231,251,197,111,119,147,219,75,242,137,244,125,173,253,113,171,144,99,119,238,247,199,214,60,228,137,241,32,116,103,166,132,121,25,203,130,43,167,52,2,214,39,131,70,23,14,131,11,166,241,166,124,119,102,236,143,72,241,248,59,38,225,156,108,41,199,114,147,192,197,80,105,235,157,146,71,132,108,224,145,137,42,182,222,95,199,91,187,23,192,209,223,220,36,153,148,193,99,96,165,118,20,88,106,67,2,205,108,129,75,6,53,28,78,78,78,200,153,40,179,12,163,60,119,132,107,94,148,91,146,99,40,81,197,115,226,51,217,120,92,42,53,187,246,162,247,4,210,254,234,113,144,37,207,189,68,235,188,42,71,43,111,27,173,87,117,120,180,3,119,200,216,106,191,217,114,27,78,183,32,159,139,214,10,118,1,131,156,22,201,174,169,64,204,255,115,146,84,71,216,184,101,150,255,66,211,18,92,85,244,94,40,39,143,168,97,13,217,54,85,138,63,145,48,253,56,114,228,77,17,211,148,253,73,31,83,88,105,173,131,126,87,1,245,71,164,63,245,116,246,135,227,192,22,218,104,118,234,75,255,2,68,204,217,86,55,223,131,145,178,18,38,156,8,237,102,84,14,124,151,71,90,169,181,97,161,86,148,177,95,246,7,176,173,153,76,225,251,112,147,74,197,143,6,110,237,43,245,145,211,214,58,160,91,149,122,34,204,104,128,158,147,10,225,11,60,31,25,213,33,128,154,52,126,91,153,22,18,237,67,226,16,183,143,164,120,193,187,8,195,35,47,5,75,200,36,73,140,223,98,176,2,117,143,16,161,255,57,96,205,147,233,155,200,112,14,250,75,200,88,158,96,0,10,161,121,210,31,70,19,49,208,63,186,24,103,28,48,188,100,186,171,36,2,74,151,168,95,135,70,52,160,116,137,214,242,96,164,235,196,35,20,84,78,95,230,152,12,237,113,88,209,205,248,254,92,176,124,173,10,238,24,124,231,88,172,92,73,236,235,18,141,126,238,242,104,46,46,191,150,52,245,4,108,74,14,85,226,190,48,73,80,205,125,206,26,213,98,175,72,90,87,27,8,133,76,175,132,31,44,4,243,124,83,168,54,95,66,92,240,164,126,242,254,190,183,3,196,14,37,55,126,91,100,198,190,136,235,196,106,246,116,10,93,151,152,75,150,209,39,152,39,70,40,136,65,29,4,41,168,128,213,139,134,136,124,238,245,110,27,236,80,243,36,236,245,28,254,32,7,8,185,128,123,107,235,183,246,127,100,104,83,19,190,66,193,82,230,149,171,214,105,75,119,197,139,7,202,140,10,171,37,240,47,251,66,127,24,6,210,171,248,25,50,170,175,86,127,227,178,60,183,32,132,179,253,170,9,95,185,95,105,199,200,250,252,190,30,189,116,88,239,244,111,115,197,191,109,120,30,46,132,97,91,175,64,186,177,121,195,132,60,115,213,26,27,162,203,150,125,140,112,202,154,249,56,62,36,7,67,176,225,60,152,116,13,231,245,89,214,192,82,27,89,53,249,42,157,141,199,182,146,106,237,94,195,100,127,143,155,6,95,130,40,83,249,95,186,206,255,205,165,43,15,154,191,99,135,80,101,189,23,139,247,133,210,33,227,151,211,195,247,44,122,239,95,114,148,36,236,7,205,235,243,101,47,38,252,217,210,106,117,95,177,158,232,126,58,183,194,105,75,249,93,155,236,155,55,55,229,211,182,216,226,11,144,25,102,11,245,91,189,214,255,3,179,220,161,221,62,167,247,192,122,227,208,64,14,156,169,202,134,133,117,86,59,29,173,28,121,16,222,78,181,248,171,208,195,162,30,213,212,118,78,15,187,24,97,147,105,199,241,85,212,80,42,160,244,237,27,151,156,99,156,213,2,114,216,165,51,195,161,168,81,197,230,7,170,205,152,108,88,11,247,13,47,211,255,239,185,181,61,183,38,133,23,175,41,45,37,101,238,13,99,204,187,72,106,34,254,132,196,228,74,137,54,133,54,186,19,213,5,99,192,117,79,70,67,47,186,192,235,149,229,170,24,172,206,43,94,100,190,235,13,155,238,143,90,158,181,54,189,193,227,202,22,221,192,70,126,46,165,250,216,229,97,80,57,122,104,105,39,252,70,60,216,171,247,32,222,31,101,179,25,196,119,218,239,202,136,47,229,187,246,235,51,112,168,119,133,88,2,245,53,155,148,71,11,247,193,107,176,161,169,128,161,211,49,201,147,154,134,73,137,75,23,159,119,234,168,247,126,135,186,176,251,222,172,145,10,59,26,194,161,183,39,117,125,160,90,106,110,17,204,194,150,239,84,154,98,180,139,115,63,25,209,217,137,35,123,179,114,126,153,151,25,112,181,125,156,29,188,88,157,215,223,71,68,53,57,221,167,182,218,185,146,18,131,97,219,78,108,105,62,9,41,248,247,55,111,58,12,40,75,23,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateBodyTemplateLocalizableString());
			LocalizableStrings.Add(CreateTitleTemplateLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateBodyTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("49329916-54bf-497e-8dbc-278d7d292151"),
				Name = "BodyTemplate",
				CreatedInPackageId = new Guid("74635cde-1ca7-4f8a-932a-278c27cd4512"),
				CreatedInSchemaUId = new Guid("3dcbc99d-70ca-41f0-b08a-1d7398a45a96"),
				ModifiedInSchemaUId = new Guid("3dcbc99d-70ca-41f0-b08a-1d7398a45a96")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTitleTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d2787d49-bc16-4e5e-ad98-f14f1729ee81"),
				Name = "TitleTemplate",
				CreatedInPackageId = new Guid("74635cde-1ca7-4f8a-932a-278c27cd4512"),
				CreatedInSchemaUId = new Guid("3dcbc99d-70ca-41f0-b08a-1d7398a45a96"),
				ModifiedInSchemaUId = new Guid("3dcbc99d-70ca-41f0-b08a-1d7398a45a96")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3dcbc99d-70ca-41f0-b08a-1d7398a45a96"));
		}

		#endregion

	}

	#endregion

}
