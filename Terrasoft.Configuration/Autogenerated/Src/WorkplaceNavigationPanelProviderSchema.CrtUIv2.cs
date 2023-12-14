﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WorkplaceNavigationPanelProviderSchema

	/// <exclude/>
	public class WorkplaceNavigationPanelProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WorkplaceNavigationPanelProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WorkplaceNavigationPanelProviderSchema(WorkplaceNavigationPanelProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d54365bf-238e-4ba8-94d5-59127fb39714");
			Name = "WorkplaceNavigationPanelProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0b5fa047-b3f1-455e-b921-26461fc6607e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,89,109,111,219,54,16,254,236,1,251,15,140,215,15,50,230,201,192,246,97,69,28,59,136,221,180,17,214,188,160,110,214,1,69,17,40,18,109,11,147,37,143,148,146,122,153,255,251,142,239,20,69,197,233,176,0,129,37,242,120,60,222,203,115,119,84,17,111,48,221,198,9,70,31,49,33,49,45,151,85,56,47,139,101,182,170,73,92,101,101,17,94,197,15,217,138,63,94,226,162,254,254,187,167,239,191,235,213,52,43,86,104,177,163,21,222,140,157,119,88,158,231,56,97,11,104,248,14,23,152,100,73,139,230,125,86,252,101,6,87,121,121,31,231,199,199,243,114,179,129,29,223,151,171,21,12,155,121,91,52,70,97,102,230,37,193,205,183,240,109,156,84,37,201,48,245,175,183,143,182,16,98,30,38,252,84,146,63,183,57,104,9,72,129,248,243,27,188,140,235,188,154,101,69,10,203,130,106,183,197,229,50,136,52,153,209,217,77,92,224,252,134,148,15,89,138,201,96,136,174,64,223,104,130,250,135,72,251,131,47,176,209,182,190,207,179,4,37,121,76,41,58,180,4,29,163,131,18,0,207,39,126,132,222,15,4,175,96,22,116,86,208,42,46,42,122,140,110,72,246,16,87,88,204,111,197,11,74,216,60,162,21,97,250,57,203,243,179,237,150,190,35,101,189,141,82,118,14,24,249,41,134,161,254,88,178,197,69,42,56,55,183,121,155,225,60,237,218,131,224,56,45,139,124,167,182,185,203,96,215,89,156,252,185,130,141,138,20,28,170,36,176,153,152,13,207,55,219,106,55,70,94,6,209,155,140,155,52,38,187,19,65,206,84,110,59,112,4,238,55,69,119,177,56,137,26,161,156,93,111,130,10,252,136,94,198,35,24,140,109,17,34,240,90,116,151,151,171,198,104,195,141,164,187,93,224,124,11,214,186,75,58,231,154,140,27,60,222,196,85,252,1,231,48,145,222,196,43,76,225,16,121,214,226,214,65,53,110,170,157,139,204,254,39,83,46,57,58,61,69,1,127,152,176,225,203,184,128,181,4,98,184,98,17,137,137,242,243,131,110,62,24,120,188,161,215,179,253,1,104,225,160,21,132,105,135,79,220,82,76,224,228,133,208,139,251,250,132,86,184,26,163,125,115,141,114,159,117,185,193,236,220,11,144,102,22,147,104,3,207,99,15,225,133,69,119,47,233,208,19,247,4,96,47,159,122,217,18,5,71,94,158,97,68,175,234,60,191,38,220,37,131,193,64,45,233,17,92,213,164,120,70,146,94,111,47,126,230,96,152,162,186,45,178,106,145,172,241,38,70,106,137,153,0,115,72,182,77,45,132,238,90,101,177,183,128,75,17,15,235,4,207,118,12,114,130,190,116,48,230,190,151,101,90,231,184,63,144,130,120,133,68,147,30,255,189,37,249,172,206,242,84,248,129,217,80,77,250,24,15,165,184,125,159,126,97,182,125,194,176,41,63,236,116,17,211,117,48,80,34,30,86,39,215,166,227,14,145,18,77,176,69,119,180,249,62,153,242,165,115,134,174,34,107,236,216,214,39,206,186,105,192,64,129,227,36,169,25,213,25,89,213,27,144,60,232,215,9,28,167,105,148,193,80,136,220,185,70,10,241,17,98,169,181,56,156,215,132,48,157,192,104,104,134,25,109,248,177,92,112,175,13,252,225,213,194,116,177,47,11,47,158,68,164,106,68,66,57,20,193,129,19,110,117,243,136,210,205,29,162,137,67,38,12,243,12,204,193,138,150,238,187,1,115,26,28,80,108,115,247,182,97,6,62,129,186,240,212,35,218,139,128,88,165,133,253,33,0,188,196,213,186,236,204,136,237,124,131,64,132,246,104,240,174,206,82,4,255,67,133,105,5,68,251,16,224,59,137,243,236,239,248,62,199,194,107,80,18,111,109,219,201,136,98,202,244,236,37,97,108,46,214,128,50,228,106,233,219,60,245,195,166,150,79,170,25,111,226,246,229,115,107,1,192,8,16,249,192,66,18,201,162,137,31,77,140,176,136,128,17,143,31,51,249,121,188,8,72,177,68,132,199,247,229,35,56,247,64,32,198,216,3,25,109,189,105,204,145,202,24,31,90,112,209,164,231,201,213,225,33,18,173,59,40,138,143,22,67,39,22,121,45,202,43,246,240,3,166,101,77,18,160,43,137,82,150,23,142,251,45,166,52,84,98,126,204,170,28,135,191,199,121,13,25,65,0,139,125,190,251,178,204,153,235,69,244,236,33,206,114,206,65,236,16,200,95,68,155,168,192,210,229,139,81,13,29,77,120,152,10,139,45,110,116,6,149,254,9,65,110,3,188,26,118,248,191,153,129,44,53,201,170,221,121,1,157,3,14,155,2,95,23,11,186,13,168,18,166,76,241,192,103,123,171,236,123,199,35,170,25,24,188,232,157,130,125,226,148,63,210,64,9,251,62,163,213,137,118,197,41,122,84,143,20,108,10,162,232,41,88,18,94,19,192,215,217,46,208,68,204,65,244,75,120,83,210,140,107,147,121,43,240,149,112,194,181,106,248,118,22,30,80,168,133,81,177,44,131,87,253,121,89,231,41,42,202,10,45,161,28,176,133,90,66,80,50,176,68,143,89,181,70,16,204,79,207,216,43,74,247,170,82,16,38,120,136,9,212,219,20,218,31,212,42,151,187,245,166,206,97,157,225,109,73,206,227,100,221,212,4,100,32,152,163,208,38,106,173,157,23,21,88,214,144,13,229,246,10,208,165,79,136,65,159,97,31,74,192,72,102,55,94,233,7,209,7,232,22,174,161,91,120,153,193,87,220,216,74,195,226,205,47,187,178,1,115,7,25,28,83,21,29,204,21,156,250,131,121,169,36,163,81,161,143,107,120,134,191,225,221,16,45,227,156,226,65,248,105,141,9,14,188,145,232,250,10,119,22,181,111,119,141,218,237,43,90,102,230,41,230,136,218,93,26,18,238,81,31,253,40,89,246,94,245,255,171,115,169,122,88,203,173,84,76,85,121,161,21,204,93,112,163,114,213,228,64,18,179,211,152,198,128,70,58,147,9,77,77,70,158,188,214,149,217,244,154,198,172,94,36,19,151,162,18,41,233,202,164,49,59,255,49,211,138,23,13,85,60,7,254,242,115,148,26,49,100,226,179,81,165,157,251,12,3,42,114,192,64,46,223,75,93,155,48,20,200,175,110,66,104,120,150,166,129,82,173,178,76,15,6,207,154,253,114,139,102,175,48,194,11,173,60,2,61,92,60,86,211,140,165,253,100,89,67,119,242,40,220,84,138,8,108,101,224,241,168,213,212,179,100,83,197,89,65,193,77,3,139,131,9,130,246,18,166,0,139,116,136,156,147,250,26,13,126,188,110,228,250,100,34,200,96,88,244,50,244,217,168,71,141,64,198,116,6,63,162,148,170,224,231,5,97,198,148,100,8,149,150,12,179,207,89,250,197,27,57,124,186,93,255,25,94,150,247,114,83,248,170,192,133,193,60,94,210,48,64,244,222,160,88,133,24,23,252,84,247,134,183,81,243,8,23,102,220,178,184,69,29,66,199,200,125,217,41,33,236,212,21,53,218,76,38,195,137,219,66,79,81,226,54,228,170,251,254,150,230,27,88,207,118,32,85,96,75,40,196,51,226,183,119,2,125,1,86,63,115,2,79,192,168,29,46,13,32,250,91,133,150,40,195,214,89,133,117,221,18,118,224,243,158,38,100,184,66,200,37,30,113,101,192,93,252,255,82,183,134,155,226,123,224,167,67,22,13,97,162,99,211,215,9,231,5,116,154,132,37,94,187,218,115,10,60,105,59,150,162,180,247,234,11,7,79,83,249,201,33,250,198,219,6,183,172,82,94,8,173,41,20,60,182,96,141,98,169,69,207,46,119,76,98,182,214,205,98,138,185,52,52,156,145,242,145,237,206,245,204,242,12,32,169,15,237,105,5,38,76,84,67,106,229,53,129,77,9,195,43,167,15,21,131,44,0,24,141,184,226,69,167,141,27,95,116,140,94,245,71,217,102,53,194,28,86,71,235,152,174,71,0,183,60,75,142,88,63,62,122,18,124,246,253,23,137,245,92,6,229,125,79,166,210,167,35,172,28,22,65,122,250,108,23,42,40,187,187,208,222,241,127,109,98,125,71,244,97,249,156,96,152,178,92,159,15,7,7,47,2,26,153,128,163,113,243,246,127,232,230,136,255,161,123,133,191,195,95,70,52,165,167,171,149,34,54,154,218,118,82,2,219,59,80,64,159,187,20,136,186,18,152,159,145,212,153,13,23,194,11,22,60,162,107,2,160,177,225,3,84,143,112,81,121,143,208,125,93,198,243,189,72,53,77,118,212,81,178,12,117,46,245,193,157,163,66,158,128,149,85,94,169,100,235,241,149,85,224,93,85,147,93,104,125,13,77,157,229,116,38,234,30,183,181,94,236,36,184,203,253,76,129,63,69,87,24,167,139,117,249,168,22,104,161,131,206,227,12,237,34,113,32,131,77,119,223,54,115,77,167,242,133,164,109,136,190,247,92,139,116,75,21,125,163,238,245,237,93,198,216,104,112,116,24,200,245,66,110,33,100,39,71,40,67,8,173,174,137,252,82,41,245,196,143,43,16,201,84,211,19,181,171,169,76,236,141,188,53,73,235,98,70,202,47,160,217,244,57,218,169,184,130,207,157,217,241,225,64,161,234,113,182,19,171,15,159,92,186,143,123,96,119,115,118,50,87,92,215,95,159,21,45,173,183,121,150,128,55,92,234,19,82,37,93,75,236,46,169,180,25,142,60,102,56,242,109,17,158,21,118,27,223,97,15,238,160,208,135,255,250,135,186,166,115,177,165,227,2,59,188,181,22,5,45,5,25,225,108,230,90,26,153,54,237,93,143,44,7,144,163,175,255,104,126,215,177,23,252,243,79,219,230,12,214,5,254,124,53,44,84,63,134,112,78,177,179,255,107,107,255,151,108,255,250,133,219,31,121,246,183,208,161,235,123,140,185,235,183,62,197,140,70,35,116,146,21,224,22,89,149,150,9,26,241,175,81,242,3,141,237,120,157,215,144,58,213,124,203,69,22,255,182,107,174,48,101,170,208,151,99,242,182,171,1,215,44,177,127,254,242,212,93,73,236,67,168,186,193,91,228,229,152,0,243,206,239,32,240,14,163,124,2,254,254,5,34,225,129,55,129,34,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateAllAppsTitleLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateAllAppsTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("add11b6e-e1da-2fef-f81e-fe5c907fc787"),
				Name = "AllAppsTitle",
				CreatedInPackageId = new Guid("5df7d265-a1f7-4784-81fd-c9d07be16831"),
				CreatedInSchemaUId = new Guid("d54365bf-238e-4ba8-94d5-59127fb39714"),
				ModifiedInSchemaUId = new Guid("d54365bf-238e-4ba8-94d5-59127fb39714")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d54365bf-238e-4ba8-94d5-59127fb39714"));
		}

		#endregion

	}

	#endregion

}

