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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,88,109,111,219,54,16,254,236,2,251,15,172,11,4,54,96,200,217,215,198,49,224,56,73,103,32,89,187,38,93,63,12,195,64,75,180,205,85,34,61,146,74,226,181,254,239,59,190,72,166,44,202,113,210,180,75,11,180,168,73,222,195,123,227,115,119,66,12,103,68,46,113,76,208,53,17,2,75,62,83,209,152,179,25,157,231,2,43,202,89,244,91,78,196,234,236,142,196,185,254,249,62,79,137,252,233,197,231,159,94,180,114,73,217,28,93,173,164,34,217,209,214,111,192,72,83,18,107,9,25,189,33,140,8,26,215,206,92,80,246,79,109,241,10,46,18,84,173,54,27,190,98,89,198,89,120,71,144,166,245,232,244,164,113,235,140,41,170,40,145,247,30,136,206,110,8,83,205,231,206,113,172,184,216,133,20,240,35,156,133,211,175,4,153,195,10,26,167,88,202,215,232,20,43,60,145,60,53,222,47,174,191,160,224,28,240,162,17,232,247,251,104,32,243,44,195,98,53,116,191,33,102,74,240,84,34,181,32,104,150,242,91,196,103,40,22,4,80,64,21,204,18,148,241,132,206,86,206,211,70,153,95,96,57,37,90,147,168,64,237,111,193,14,36,33,56,149,92,67,205,142,219,187,157,19,157,96,73,204,218,202,44,20,74,183,81,95,227,253,17,216,234,92,197,11,146,225,95,33,11,209,49,106,215,53,107,119,255,4,209,101,62,77,105,140,98,237,161,128,250,5,26,122,141,26,84,0,140,207,198,119,165,183,47,137,90,240,4,252,253,78,208,27,172,136,222,211,127,151,246,39,162,76,161,191,50,202,222,243,219,49,207,1,137,223,18,241,59,78,115,173,232,207,135,135,135,71,168,16,121,69,88,98,81,203,149,198,75,252,43,110,56,77,32,234,4,11,99,143,182,100,180,92,166,148,136,49,6,183,116,62,72,248,31,103,204,190,35,148,87,126,118,145,126,131,173,214,13,22,72,108,36,65,57,147,71,54,31,87,240,246,212,96,178,13,63,236,116,143,140,176,39,24,25,69,220,198,186,170,232,148,243,20,1,210,68,142,224,238,27,227,243,211,28,196,98,216,77,58,245,128,32,89,91,42,244,53,88,212,1,129,182,245,147,90,231,235,213,146,36,192,33,121,198,140,207,7,90,108,216,105,23,26,180,157,1,116,134,58,47,11,180,226,138,150,32,42,23,12,205,32,115,137,61,183,54,255,218,196,176,41,23,184,216,109,4,117,178,123,71,30,76,224,212,185,224,217,233,52,8,96,229,163,177,126,145,46,65,59,129,107,170,33,119,70,54,93,164,79,143,18,157,163,116,190,80,18,238,181,22,183,108,18,154,212,136,57,75,168,161,97,216,102,228,22,157,82,3,13,111,124,32,149,0,58,232,33,62,253,27,238,27,22,222,251,140,54,110,238,33,37,32,227,215,189,114,235,114,243,36,96,119,207,232,193,99,130,224,249,162,93,31,179,72,160,83,162,136,78,219,253,129,223,228,52,1,228,109,128,73,82,189,96,34,109,117,217,31,184,204,55,39,216,181,25,180,182,17,209,215,106,36,27,213,73,178,127,30,111,20,46,100,253,84,246,33,95,30,35,125,56,58,203,150,106,85,166,246,38,158,209,40,73,60,32,107,90,33,237,48,215,136,64,66,236,35,203,242,52,237,250,111,197,169,19,78,188,115,162,226,133,249,255,73,103,131,218,179,249,215,69,7,7,246,194,230,204,5,62,212,101,198,243,140,182,55,224,195,250,193,237,87,174,19,212,87,188,246,248,215,33,214,93,144,248,147,121,59,111,151,196,54,58,246,17,237,79,186,201,180,104,85,206,216,156,50,205,101,213,195,208,119,84,79,120,148,181,45,172,115,101,140,153,109,15,72,169,83,167,13,139,151,152,225,57,185,2,15,232,165,118,183,116,64,13,196,88,181,27,166,44,5,178,200,187,117,203,241,69,163,159,38,12,236,82,1,111,61,67,103,89,93,161,246,139,149,90,0,187,121,238,106,142,121,30,98,221,245,78,159,124,88,38,176,240,99,248,196,234,250,237,125,114,74,82,242,163,248,196,234,250,148,62,169,182,143,222,235,9,55,77,59,93,210,11,52,185,59,122,42,109,125,115,123,22,144,43,109,213,62,135,158,158,139,75,34,37,208,131,107,18,46,120,140,83,250,47,158,66,227,98,154,132,45,211,163,247,68,242,92,196,176,203,5,136,245,66,173,123,217,254,187,58,220,106,215,96,165,107,136,172,222,27,157,13,65,77,228,59,193,23,116,74,97,33,50,212,223,238,70,215,220,41,228,188,223,82,11,1,195,142,86,186,12,254,93,76,150,38,208,190,101,123,70,203,235,81,238,11,145,158,16,188,1,193,15,134,183,140,6,13,99,196,174,24,216,206,44,58,231,34,195,170,243,127,68,68,31,255,72,213,194,243,199,5,168,119,189,128,66,66,109,33,174,71,167,215,100,234,215,197,106,123,198,10,79,88,102,68,180,155,219,3,178,89,176,110,8,141,143,232,10,223,144,4,17,61,48,70,165,124,127,27,96,176,196,2,103,72,127,49,57,110,75,208,7,28,57,52,83,38,178,191,162,65,223,28,9,75,144,246,240,26,102,115,61,81,23,211,244,235,198,121,218,12,8,163,153,34,194,92,48,18,115,169,167,104,200,57,169,48,139,137,238,235,21,166,76,143,243,48,241,23,23,26,19,16,176,61,174,232,226,198,103,14,108,39,104,226,210,253,173,171,149,58,151,236,4,224,204,232,33,123,253,9,153,129,82,229,253,72,103,172,63,90,212,121,5,50,55,48,12,118,45,172,141,233,206,55,21,110,163,171,34,22,230,158,190,36,72,212,110,242,180,13,189,70,46,237,127,196,24,90,140,5,155,242,19,68,126,110,68,235,169,232,177,171,211,233,105,73,182,85,227,211,109,2,125,252,240,216,245,179,32,92,245,238,191,172,72,11,44,73,228,63,134,226,21,20,7,118,124,161,9,229,217,250,113,28,100,154,52,157,139,207,142,134,182,120,160,137,135,138,219,244,7,200,135,241,80,97,250,254,52,244,124,56,168,121,14,8,114,144,249,36,3,53,116,94,164,184,108,228,158,177,127,204,188,4,217,9,49,153,217,114,135,1,172,138,30,141,216,170,115,135,142,135,232,46,178,31,89,143,81,141,189,106,196,88,230,226,215,242,162,54,23,11,175,83,112,106,53,170,251,113,65,4,169,40,252,18,20,190,224,243,43,133,227,79,215,2,199,154,159,44,157,116,209,16,29,214,249,183,226,143,47,95,170,196,92,90,118,112,176,75,177,103,212,32,159,37,84,133,89,251,137,233,218,101,129,199,179,15,74,170,10,63,251,81,169,3,86,39,173,111,90,33,214,79,94,39,74,178,122,64,153,216,243,67,239,35,43,135,25,101,191,79,229,40,214,191,178,130,60,168,145,221,216,115,111,33,41,60,241,35,22,146,230,143,39,193,66,18,254,60,187,31,55,63,31,114,179,70,127,207,166,212,189,226,50,83,190,217,43,222,26,88,237,106,117,209,172,121,127,254,3,148,41,215,165,141,31,0,0 };
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

