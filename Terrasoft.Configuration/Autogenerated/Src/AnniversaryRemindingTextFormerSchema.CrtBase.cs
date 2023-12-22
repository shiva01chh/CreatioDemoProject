namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AnniversaryRemindingTextFormerSchema

	/// <exclude/>
	public class AnniversaryRemindingTextFormerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AnniversaryRemindingTextFormerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AnniversaryRemindingTextFormerSchema(AnniversaryRemindingTextFormerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c");
			Name = "AnniversaryRemindingTextFormer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,87,109,111,219,54,16,254,172,2,253,15,132,186,1,54,230,202,73,251,45,77,2,164,73,90,20,104,210,160,246,10,20,197,62,208,210,217,230,34,145,30,73,185,245,218,254,247,29,69,82,166,94,236,120,107,49,127,50,143,119,207,61,247,194,35,197,105,1,106,69,83,32,83,144,146,42,49,215,201,165,224,115,182,40,37,213,76,240,199,143,190,62,126,20,149,138,241,5,153,108,148,134,226,69,107,141,250,121,14,169,81,86,201,107,224,32,89,218,209,121,203,248,95,29,225,20,190,232,173,240,82,72,72,174,185,102,154,129,218,138,67,94,18,250,229,69,33,56,238,224,222,19,9,11,36,66,46,115,170,212,9,185,224,156,173,65,42,42,55,239,161,96,60,67,75,227,245,149,144,5,200,202,98,60,30,147,83,85,22,5,234,156,187,245,157,20,107,150,129,34,5,232,165,200,20,209,130,204,209,132,196,1,96,76,164,135,68,5,4,37,25,213,52,33,30,115,28,128,174,202,89,206,82,146,26,86,15,144,34,39,228,77,47,215,200,20,162,14,240,21,131,60,195,8,239,36,91,83,13,85,40,209,74,10,141,149,128,12,169,209,76,240,124,67,126,87,32,177,160,220,22,168,181,180,57,139,158,0,207,44,172,91,251,36,98,69,181,44,83,45,164,241,84,197,224,28,217,120,246,71,50,104,249,46,27,203,33,169,226,137,90,74,103,45,53,83,240,232,251,126,158,55,182,74,157,100,84,11,130,33,152,126,121,13,250,34,77,69,201,117,192,122,202,116,14,3,79,69,130,46,37,55,154,111,69,74,115,246,55,157,229,48,169,204,7,113,165,234,16,166,80,172,114,196,142,135,33,189,174,67,12,67,211,244,71,28,58,132,255,238,240,165,200,54,3,167,128,253,9,35,175,205,241,228,123,30,193,190,41,29,213,166,133,206,170,148,109,145,174,232,230,130,103,55,232,97,57,48,154,150,74,180,166,146,204,208,73,139,169,53,239,9,235,101,87,55,14,160,36,168,50,215,104,109,57,37,150,207,160,199,195,168,201,119,100,35,122,17,38,214,130,237,79,89,183,41,14,74,153,15,187,213,17,123,195,238,239,158,136,113,77,54,64,165,234,164,252,35,74,195,92,59,30,41,38,66,82,127,94,92,217,157,64,13,42,168,195,50,218,34,52,114,225,154,56,71,161,151,125,89,141,162,254,188,118,115,224,246,208,92,148,50,133,219,86,54,243,182,1,82,254,37,238,192,168,228,107,136,240,61,249,64,243,18,226,70,130,234,144,57,124,38,93,34,205,145,147,188,119,112,19,156,115,116,1,163,10,41,194,16,166,155,21,158,213,228,182,74,71,135,222,161,173,102,202,219,83,214,160,193,194,44,164,165,148,192,245,149,237,165,22,211,75,187,105,164,137,41,251,86,119,202,10,67,213,252,181,180,188,144,208,240,4,87,160,8,136,2,157,76,69,109,25,244,24,155,147,65,203,198,220,176,43,42,97,42,6,1,189,33,57,39,71,158,186,79,195,145,5,169,250,34,50,208,147,21,229,38,5,32,215,52,71,231,1,64,50,41,103,85,135,181,253,181,206,133,171,99,77,214,163,37,83,150,222,171,97,98,210,185,155,59,142,173,119,243,143,21,76,211,123,189,81,199,96,156,61,125,26,70,224,162,218,120,15,187,167,72,255,156,116,10,107,211,162,222,205,191,171,140,53,109,180,90,59,194,169,240,67,230,230,102,156,101,135,220,17,245,176,48,57,246,236,162,208,73,37,36,191,25,131,119,18,239,117,154,95,243,50,100,179,19,63,80,55,232,188,44,102,80,231,216,84,200,74,200,233,89,183,125,220,136,186,46,86,122,19,214,33,48,251,149,28,31,29,153,90,30,31,147,111,223,72,71,250,172,87,250,188,237,169,127,74,235,165,99,239,103,179,117,175,62,51,157,46,27,20,106,188,148,42,32,199,39,118,177,31,93,233,22,186,53,126,118,144,49,207,122,141,159,31,100,44,59,198,25,204,41,14,172,131,172,251,179,114,240,163,44,120,55,86,15,99,198,151,248,141,160,51,145,146,241,121,240,154,220,182,80,117,3,191,185,98,85,147,98,155,159,218,173,17,17,179,63,113,20,158,87,143,241,59,42,113,48,227,40,80,190,22,77,105,114,185,132,244,254,66,46,202,2,143,252,109,153,231,131,184,169,177,239,221,17,180,160,217,86,233,18,10,106,110,2,84,113,199,122,216,68,251,20,79,106,165,248,143,173,105,102,207,246,46,35,115,132,67,117,48,95,64,155,7,60,93,215,74,222,212,183,232,150,104,179,67,99,119,215,199,219,138,187,128,119,191,129,236,107,96,75,200,247,78,52,195,207,139,251,176,11,99,247,54,235,69,223,241,40,61,4,189,49,133,187,87,236,129,237,100,31,221,255,111,63,253,64,195,236,105,197,159,92,101,247,53,242,179,202,186,27,238,129,58,134,51,196,201,66,17,74,194,223,63,120,117,224,69,180,16,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateTitleContactTemplateLocalizableString());
			LocalizableStrings.Add(CreateBodyContactTemplateLocalizableString());
			LocalizableStrings.Add(CreateTitleAccountTemplateLocalizableString());
			LocalizableStrings.Add(CreateBodyAccountTemplateLocalizableString());
			LocalizableStrings.Add(CreatestOrdinalLocalizableString());
			LocalizableStrings.Add(CreatendOrdinalLocalizableString());
			LocalizableStrings.Add(CreaterdOrdinalLocalizableString());
			LocalizableStrings.Add(CreatethOrdinalLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateTitleContactTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2d0e61be-0a4a-45c0-ab9f-a90f92028ed7"),
				Name = "TitleContactTemplate",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c"),
				ModifiedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBodyContactTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f88c60c5-8ecc-4ec8-89f7-67590239dfb3"),
				Name = "BodyContactTemplate",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c"),
				ModifiedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTitleAccountTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("babf9ff7-7f81-4b5b-a544-3aeffb636c3b"),
				Name = "TitleAccountTemplate",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c"),
				ModifiedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBodyAccountTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("56be17f0-594f-4a21-84c0-7230a14a16ea"),
				Name = "BodyAccountTemplate",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c"),
				ModifiedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatestOrdinalLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cb7b7382-9e88-48c3-91bf-c459bf541dcf"),
				Name = "stOrdinal",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c"),
				ModifiedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatendOrdinalLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8df46a2e-db2a-408f-8b01-9c39f2d46c85"),
				Name = "ndOrdinal",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c"),
				ModifiedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreaterdOrdinalLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8a1a6be5-802f-42f1-9056-13a65c21a853"),
				Name = "rdOrdinal",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c"),
				ModifiedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatethOrdinalLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4fb54baf-e0b3-44c0-bbf6-30d79e2a859c"),
				Name = "thOrdinal",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c"),
				ModifiedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c"));
		}

		#endregion

	}

	#endregion

}

