namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysQueryHandleRuleListenerSchema

	/// <exclude/>
	public class SysQueryHandleRuleListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysQueryHandleRuleListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysQueryHandleRuleListenerSchema(SysQueryHandleRuleListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff");
			Name = "SysQueryHandleRuleListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("24377658-5c78-47a6-b5ee-e5beab1bcee6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,88,93,111,219,54,20,125,118,128,254,7,214,5,2,27,48,228,236,181,113,12,56,118,210,25,72,218,174,73,215,135,97,24,104,137,182,185,74,164,71,82,73,188,214,255,125,151,164,36,83,18,229,56,105,218,165,15,45,98,146,247,220,79,30,222,43,196,112,66,228,10,135,4,93,19,33,176,228,115,21,140,57,155,211,69,42,176,162,156,5,191,165,68,172,207,238,72,152,234,159,31,210,152,200,23,7,95,94,28,180,82,73,217,2,93,173,165,34,201,113,229,55,96,196,49,9,181,132,12,222,16,70,4,13,107,103,46,40,251,167,182,120,5,138,4,85,235,237,134,107,88,146,112,230,223,17,164,105,61,152,156,54,110,157,49,69,21,37,242,222,3,193,217,13,97,170,249,220,57,14,21,23,187,144,60,113,132,179,112,250,149,32,11,88,65,227,24,75,249,26,77,176,194,83,201,99,19,253,92,253,5,133,224,64,20,141,64,191,223,71,3,153,38,9,22,235,97,246,27,114,166,4,143,37,82,75,130,230,49,191,69,124,142,66,65,0,5,76,193,44,66,9,143,232,124,157,69,218,24,243,43,44,199,68,91,18,228,168,253,10,236,64,18,130,99,201,53,212,252,164,189,59,56,193,41,150,196,172,173,205,66,110,116,27,245,53,222,31,158,173,206,85,184,36,9,126,11,85,136,78,80,187,110,89,187,251,39,136,174,210,89,76,67,20,234,8,121,204,207,209,208,107,212,96,2,96,124,49,177,43,162,125,73,212,146,71,16,239,247,130,222,96,69,244,158,254,183,178,63,17,101,10,253,149,80,246,129,223,142,121,10,72,252,150,136,223,113,156,106,67,127,57,58,58,58,70,185,200,43,194,34,139,90,172,52,42,113,85,220,112,26,65,214,9,22,198,31,237,201,104,181,138,41,17,99,12,97,233,124,148,240,23,103,204,222,35,148,150,126,118,145,190,131,173,214,13,22,72,108,37,193,56,83,71,182,30,215,112,247,212,96,90,133,31,118,186,199,70,216,17,12,140,33,217,198,166,108,232,140,243,24,1,210,84,142,64,247,141,137,249,36,5,177,16,118,163,78,61,33,72,214,150,114,123,13,22,205,128,192,218,250,73,109,243,245,122,69,34,224,144,52,97,38,230,3,45,54,236,180,115,11,218,153,3,116,142,58,47,115,180,92,69,75,16,149,10,134,230,80,185,196,158,219,152,255,109,97,216,146,243,40,206,54,188,54,217,189,99,7,198,115,234,92,240,100,50,243,2,88,249,96,172,111,100,86,160,29,143,154,114,202,51,39,155,20,233,211,163,72,215,40,93,44,149,4,189,214,227,150,45,66,83,26,33,103,17,53,52,12,219,140,220,162,9,53,208,112,199,7,82,9,160,131,30,226,179,191,65,223,48,143,222,23,180,13,115,15,41,1,21,191,233,21,91,151,219,43,1,187,123,102,15,46,19,36,207,21,237,186,152,121,1,77,136,34,186,108,247,7,126,147,210,8,144,171,0,211,168,172,96,42,237,235,178,63,112,81,111,153,96,215,86,208,198,102,68,171,213,72,54,171,211,104,255,58,222,26,156,203,186,165,236,66,190,60,65,250,112,112,150,172,212,186,40,237,109,62,131,81,20,57,64,214,181,92,58,195,220,32,2,5,177,143,44,75,227,184,235,222,149,204,28,127,225,157,19,21,46,205,223,167,157,45,106,207,214,95,23,29,30,90,133,205,149,11,124,168,159,25,39,50,218,95,79,12,235,7,171,183,92,23,168,107,120,237,242,111,124,172,187,36,225,103,115,119,222,173,136,109,116,236,37,218,159,116,163,89,222,170,156,177,5,101,154,203,202,135,161,239,40,159,112,40,171,42,172,107,101,140,153,109,15,72,97,83,167,13,139,151,152,225,5,185,130,8,232,165,118,183,8,64,13,196,120,181,27,166,120,10,100,94,119,155,86,198,23,141,113,154,50,240,75,121,162,245,12,131,101,109,133,183,95,172,213,18,216,205,9,87,115,206,83,31,235,110,118,198,228,227,42,130,133,159,35,38,214,214,239,31,147,9,137,201,207,18,19,107,235,83,198,164,220,62,58,183,199,223,52,237,12,73,207,211,228,238,232,169,180,247,205,237,153,71,174,240,85,199,28,122,122,46,46,137,148,64,15,89,147,112,193,67,28,211,127,241,12,26,23,211,36,84,92,15,62,16,201,83,17,194,46,23,32,214,243,181,238,69,251,159,189,195,173,118,13,86,102,13,145,181,123,107,179,33,168,169,124,47,248,146,206,40,44,4,134,250,219,221,224,154,103,6,101,209,111,169,165,128,97,71,27,93,36,255,46,36,43,147,104,215,179,61,179,229,244,40,247,165,72,79,8,206,128,224,38,195,89,70,131,134,49,98,87,14,108,103,22,156,115,145,96,213,249,63,50,162,143,127,162,106,233,196,227,2,204,187,94,194,67,66,237,67,92,207,78,175,201,213,111,203,85,117,198,242,79,88,102,68,180,155,213,1,217,44,216,48,248,198,71,116,133,111,72,132,136,30,24,131,66,190,95,5,24,172,176,192,9,210,95,76,78,218,18,236,129,64,14,205,148,137,236,175,96,208,55,71,252,18,164,61,188,134,217,92,79,212,249,52,253,186,113,158,54,3,194,104,174,136,48,10,70,98,33,245,20,13,53,39,21,102,33,209,125,189,194,148,233,113,30,38,254,92,161,113,1,1,219,227,146,45,217,248,204,129,237,4,141,178,114,127,151,189,149,186,150,236,4,144,185,209,67,86,253,41,153,131,81,133,126,164,43,214,29,45,234,188,2,149,235,25,6,187,22,214,230,116,231,157,242,183,209,101,17,11,115,79,95,226,37,234,108,242,180,13,189,70,46,252,127,196,24,154,143,5,219,231,199,139,252,220,136,214,49,209,97,215,204,166,167,37,217,86,141,79,171,4,250,248,225,177,235,86,129,255,213,187,95,89,94,22,88,146,192,189,12,249,45,200,15,236,248,66,227,171,179,205,227,56,200,52,105,186,22,159,29,13,85,120,160,137,135,114,109,250,3,228,195,120,40,119,125,127,26,122,62,28,212,60,7,120,57,200,124,146,129,55,116,145,151,184,108,228,158,177,123,204,220,4,217,241,49,153,217,202,14,3,88,25,61,24,177,117,231,14,157,12,209,93,96,63,178,158,160,26,123,213,136,177,168,197,111,229,69,237,46,22,78,167,144,153,213,104,238,167,37,17,164,100,240,75,48,248,130,47,174,20,14,63,95,11,28,106,126,178,116,210,69,67,116,84,231,223,82,60,190,126,45,19,115,225,217,225,225,46,195,158,81,131,124,22,81,229,103,237,39,166,235,172,10,28,158,125,80,81,149,248,217,205,74,29,176,60,105,125,215,23,98,243,228,239,68,65,86,15,120,38,246,252,208,251,200,151,195,140,178,63,230,229,200,215,191,241,5,121,80,35,187,245,231,222,135,36,143,196,207,248,144,52,127,60,241,62,36,254,207,179,251,113,243,243,33,55,235,244,143,108,74,179,91,92,84,202,119,187,197,149,129,213,174,150,23,205,218,193,193,127,70,166,162,123,132,31,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCreateActiveDuplicatedRulesIsProhibitedLocalizableString());
			LocalizableStrings.Add(CreateDeleteSystemRuleIsProhibitedMessageLocalizableString());
			LocalizableStrings.Add(CreateEditSystemRuleIsProhibitedLocalizableString());
			LocalizableStrings.Add(CreateCreateSystemRuleIsProhibitedMessageLocalizableString());
			LocalizableStrings.Add(CreateCreateRuleWithMinRowCountLessThanMinValueProhibitedLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCreateActiveDuplicatedRulesIsProhibitedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b4ab4cb4-79e2-a790-cdf9-1e29d6a4693b"),
				Name = "CreateActiveDuplicatedRulesIsProhibited",
				CreatedInPackageId = new Guid("24377658-5c78-47a6-b5ee-e5beab1bcee6"),
				CreatedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff"),
				ModifiedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDeleteSystemRuleIsProhibitedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fbeac549-ba21-9164-332e-1c2b6e5a086d"),
				Name = "DeleteSystemRuleIsProhibitedMessage",
				CreatedInPackageId = new Guid("24377658-5c78-47a6-b5ee-e5beab1bcee6"),
				CreatedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff"),
				ModifiedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEditSystemRuleIsProhibitedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("654dcd12-b490-703e-31f7-66b56cd63ec4"),
				Name = "EditSystemRuleIsProhibited",
				CreatedInPackageId = new Guid("24377658-5c78-47a6-b5ee-e5beab1bcee6"),
				CreatedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff"),
				ModifiedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCreateSystemRuleIsProhibitedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3ced39a4-9f25-4e0d-ec88-30df6d43c472"),
				Name = "CreateSystemRuleIsProhibitedMessage",
				CreatedInPackageId = new Guid("24377658-5c78-47a6-b5ee-e5beab1bcee6"),
				CreatedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff"),
				ModifiedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCreateRuleWithMinRowCountLessThanMinValueProhibitedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b7776b09-484f-5813-d9b7-a509e23eff9f"),
				Name = "CreateRuleWithMinRowCountLessThanMinValueProhibited",
				CreatedInPackageId = new Guid("4e6ccfb8-9251-4fde-a337-f61d1d253a58"),
				CreatedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff"),
				ModifiedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff"));
		}

		#endregion

	}

	#endregion

}

