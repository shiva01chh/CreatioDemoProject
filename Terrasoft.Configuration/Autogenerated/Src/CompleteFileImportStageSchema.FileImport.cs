namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CompleteFileImportStageSchema

	/// <exclude/>
	public class CompleteFileImportStageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CompleteFileImportStageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CompleteFileImportStageSchema(CompleteFileImportStageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f9010370-d507-4e89-b413-ae509e726a22");
			Name = "CompleteFileImportStage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,86,93,79,219,48,20,125,14,18,255,193,43,47,169,132,210,119,160,69,80,202,84,105,3,52,198,211,52,77,38,185,41,22,137,29,249,163,91,133,248,239,187,137,147,54,73,227,52,208,135,54,177,207,61,190,247,220,15,151,211,20,84,70,67,32,63,65,74,170,68,172,131,185,224,49,91,25,73,53,19,60,184,101,9,44,211,76,72,77,142,143,222,142,143,60,163,24,95,53,224,18,206,29,235,193,45,13,181,144,12,20,34,16,115,34,97,133,164,132,204,19,170,212,25,153,139,52,75,64,195,238,144,71,77,87,80,96,39,147,9,185,96,252,5,36,211,145,8,73,40,33,158,142,174,169,106,163,71,147,89,5,87,38,77,169,220,84,239,139,127,16,26,13,36,44,143,33,49,90,18,86,152,86,38,147,154,205,175,27,136,169,73,244,53,227,17,6,227,235,77,6,34,246,151,29,135,142,79,201,29,106,71,166,132,227,15,130,28,161,140,199,191,145,56,51,207,9,195,16,242,168,93,65,147,51,210,113,14,26,231,162,111,149,187,101,144,68,168,220,131,100,107,170,173,82,94,102,95,200,210,26,62,80,137,62,105,144,234,7,100,66,49,204,192,134,252,97,206,189,243,14,142,5,215,76,99,222,230,47,134,191,170,27,170,233,131,20,107,22,129,172,152,220,136,46,190,111,66,188,154,204,205,230,218,111,112,97,101,42,45,77,94,82,87,114,101,82,224,154,60,41,144,184,206,33,204,203,181,137,32,211,25,225,240,183,203,206,31,153,134,225,232,180,197,52,182,21,235,157,0,143,172,246,229,123,153,8,116,48,3,153,11,176,77,6,25,158,141,158,45,244,185,39,87,228,242,50,63,195,243,252,62,208,212,54,152,237,190,77,240,21,244,69,143,55,51,191,79,196,113,165,196,240,10,57,8,216,197,216,3,106,71,218,199,231,140,215,109,244,185,168,157,117,124,96,123,23,177,19,210,142,215,205,229,140,214,101,50,48,86,87,173,215,224,121,181,23,195,172,84,199,14,54,199,72,107,157,74,154,45,119,106,195,93,206,69,98,82,174,174,86,43,60,142,230,46,69,52,195,10,197,177,93,108,96,16,33,40,37,228,216,26,156,145,103,156,147,126,139,108,31,77,222,200,251,7,122,184,22,213,7,175,158,74,5,177,198,203,15,229,38,45,148,90,112,147,146,226,113,25,229,149,208,181,31,56,52,60,144,154,239,160,95,132,243,66,88,11,22,109,147,99,73,253,246,28,32,217,246,17,37,43,36,190,19,154,197,155,123,94,89,250,53,72,49,144,189,27,216,49,222,163,134,197,127,5,154,228,53,183,7,126,239,240,105,239,132,1,94,177,152,248,95,118,203,193,29,64,244,136,178,88,174,10,229,73,208,70,114,235,230,123,241,189,166,178,188,244,11,40,235,109,161,10,50,243,45,157,247,233,11,228,244,16,65,123,128,35,69,45,234,82,233,166,227,129,13,118,193,35,191,106,218,46,121,251,210,51,64,233,154,200,213,252,204,255,232,152,36,177,62,185,175,146,224,41,139,104,87,193,244,152,88,103,243,178,175,153,5,101,11,96,43,163,235,203,168,65,227,30,234,37,217,80,34,215,188,28,74,115,96,190,212,154,83,104,172,10,136,62,57,95,42,243,254,17,115,73,150,28,125,197,68,151,67,112,72,174,91,211,97,47,113,182,157,118,201,239,8,185,92,107,170,80,172,213,63,255,1,120,82,232,210,107,12,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCompleteRemindingSubjectLocalizableString());
			LocalizableStrings.Add(CreateNotImportedRowsCountMessageTemplateLocalizableString());
			LocalizableStrings.Add(CreateCompleteRemindingDescriptionTemplateLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCompleteRemindingSubjectLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6f65dc87-b8f6-49d8-8bf6-3ac2dbbdbbb6"),
				Name = "CompleteRemindingSubject",
				CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab"),
				CreatedInSchemaUId = new Guid("f9010370-d507-4e89-b413-ae509e726a22"),
				ModifiedInSchemaUId = new Guid("f9010370-d507-4e89-b413-ae509e726a22")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotImportedRowsCountMessageTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("844066a9-4ae1-4da8-a4c2-43d603e52b7d"),
				Name = "NotImportedRowsCountMessageTemplate",
				CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab"),
				CreatedInSchemaUId = new Guid("f9010370-d507-4e89-b413-ae509e726a22"),
				ModifiedInSchemaUId = new Guid("f9010370-d507-4e89-b413-ae509e726a22")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCompleteRemindingDescriptionTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a5398abd-87e5-4737-9e25-5cb7b840b6bb"),
				Name = "CompleteRemindingDescriptionTemplate",
				CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab"),
				CreatedInSchemaUId = new Guid("f9010370-d507-4e89-b413-ae509e726a22"),
				ModifiedInSchemaUId = new Guid("f9010370-d507-4e89-b413-ae509e726a22")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f9010370-d507-4e89-b413-ae509e726a22"));
		}

		#endregion

	}

	#endregion

}

