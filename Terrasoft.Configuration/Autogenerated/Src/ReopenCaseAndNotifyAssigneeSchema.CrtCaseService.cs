﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReopenCaseAndNotifyAssigneeSchema

	/// <exclude/>
	public class ReopenCaseAndNotifyAssigneeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReopenCaseAndNotifyAssigneeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReopenCaseAndNotifyAssigneeSchema(ReopenCaseAndNotifyAssigneeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("09d5e522-4a4c-45fb-a412-d5799f195e9c");
			Name = "ReopenCaseAndNotifyAssignee";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,89,95,83,227,56,18,127,102,171,246,59,104,124,87,123,78,93,202,220,203,190,0,201,20,132,153,61,234,24,224,8,220,60,76,77,77,9,91,9,186,113,172,140,36,195,102,89,190,251,182,212,146,45,59,118,48,83,117,123,60,4,91,234,110,181,126,253,71,221,114,65,87,76,173,105,202,200,13,147,146,42,177,208,201,76,20,11,190,44,37,213,92,20,201,140,42,54,103,242,129,167,236,199,31,158,126,252,97,175,84,188,88,146,101,46,238,104,126,112,48,19,171,21,80,157,139,229,18,134,15,171,249,249,70,105,182,106,191,131,236,60,103,169,17,172,146,95,88,193,36,79,183,104,206,121,241,109,107,240,134,253,170,235,193,80,89,179,126,247,140,100,125,227,201,233,73,239,212,187,66,115,205,153,2,2,32,249,139,100,75,208,150,204,114,170,212,1,185,102,98,205,10,131,201,113,145,93,8,205,23,155,99,165,248,178,96,204,146,239,239,239,147,35,85,174,86,84,110,166,238,221,178,18,201,214,146,41,86,104,69,214,82,164,12,134,196,2,70,141,60,163,69,10,50,9,44,148,138,34,227,8,144,151,183,31,8,92,151,119,57,79,73,106,101,238,212,102,239,201,106,84,239,0,68,106,10,235,31,144,43,201,31,168,70,141,247,214,248,98,22,86,154,40,45,141,54,167,108,65,203,92,163,204,121,121,247,95,48,26,153,144,232,130,61,18,182,162,60,7,205,83,198,31,88,6,15,75,42,51,195,164,239,25,110,227,66,36,79,255,120,142,14,123,197,95,62,130,233,207,50,240,134,114,85,92,128,15,26,217,110,112,7,219,92,83,93,170,54,159,31,221,193,120,81,174,238,152,108,178,225,216,46,166,112,243,231,233,111,21,99,56,30,29,58,148,89,145,33,208,77,212,223,115,150,103,125,144,131,61,52,24,83,50,154,137,34,223,144,51,8,35,242,37,135,159,9,129,199,15,180,160,75,38,33,80,180,137,47,38,227,200,216,250,3,248,14,140,159,115,8,12,64,44,26,189,160,194,149,4,47,145,198,165,141,26,66,131,214,44,243,138,184,87,114,202,109,84,130,151,29,225,246,199,14,134,41,65,216,142,115,14,107,171,215,172,101,93,21,231,219,113,97,7,206,172,67,66,238,129,64,56,82,12,224,151,108,49,137,110,149,49,85,81,96,158,136,246,167,68,111,214,44,169,196,132,225,224,227,161,201,211,126,125,34,75,166,15,73,5,187,121,121,110,155,194,218,252,75,17,26,247,176,87,117,235,3,60,181,41,146,40,164,222,173,97,151,83,17,147,79,247,246,64,57,247,180,199,23,36,70,202,228,76,93,148,121,126,41,223,173,214,122,19,55,21,27,141,60,195,94,115,2,28,199,122,75,74,115,254,27,189,203,217,220,10,251,15,205,75,22,55,81,25,119,58,248,232,16,229,62,227,63,201,116,41,139,46,88,28,133,50,186,147,45,37,30,204,130,22,100,75,24,34,109,15,20,27,178,115,13,249,150,124,73,155,3,253,160,247,248,75,75,224,48,135,105,107,209,126,175,45,51,153,110,169,72,222,190,37,241,214,224,132,20,144,29,91,130,90,160,143,28,190,170,71,176,71,46,192,173,19,138,219,130,127,43,25,207,224,60,1,63,100,210,64,66,97,133,7,174,55,38,53,11,153,237,222,255,47,37,207,200,177,227,56,203,124,136,132,161,49,120,97,155,243,7,47,106,0,122,197,130,51,81,22,186,62,42,33,85,153,229,212,238,133,56,176,92,59,122,20,176,35,5,188,214,215,78,164,248,10,105,247,5,55,11,188,29,25,208,216,248,124,216,242,68,71,17,60,6,153,129,248,32,172,249,107,7,116,239,181,239,225,64,12,142,70,26,17,218,32,238,8,207,190,140,110,203,6,89,166,224,158,67,114,250,12,14,51,205,20,88,160,19,191,29,21,203,176,184,221,33,160,21,106,164,108,70,158,131,180,69,52,105,145,97,120,54,142,60,7,110,255,9,25,143,14,7,0,249,129,233,123,241,82,41,224,78,137,161,57,188,165,188,215,136,228,46,153,187,61,59,7,50,187,216,18,27,55,69,36,31,133,252,106,59,130,228,154,41,81,202,148,153,204,4,245,198,152,236,180,222,24,15,140,104,107,1,149,68,228,239,94,35,120,138,18,187,147,104,148,220,8,167,66,3,63,143,200,131,128,100,129,139,216,202,48,182,133,249,198,134,63,62,250,237,185,9,201,86,188,48,133,168,123,159,180,202,0,172,236,55,243,244,30,42,216,160,182,242,161,126,178,49,26,198,176,75,39,39,26,225,158,18,116,106,100,111,39,116,116,152,7,42,173,98,144,216,38,46,195,213,19,2,11,91,152,169,117,55,11,223,128,183,187,90,214,66,114,100,242,227,52,222,42,142,131,53,10,91,180,190,44,201,123,102,195,145,63,181,203,224,207,161,246,190,239,232,119,119,97,79,247,105,85,122,248,255,123,209,113,9,190,45,163,113,27,241,89,41,37,156,20,102,212,180,149,26,142,168,179,204,113,61,143,73,45,192,77,130,4,7,86,23,209,220,186,35,208,84,22,178,201,73,37,213,59,82,160,54,221,50,92,213,63,118,72,118,145,212,167,34,144,213,47,158,212,213,71,53,114,0,143,195,12,221,249,164,228,121,102,82,48,146,44,224,92,167,233,61,137,17,62,204,189,144,31,107,196,49,32,84,85,211,129,192,228,120,13,145,150,197,150,120,212,40,184,48,194,239,169,186,135,85,223,243,156,221,106,158,219,142,213,120,194,135,211,159,255,9,83,16,44,169,48,136,36,112,96,195,19,51,115,39,27,200,204,166,188,12,34,207,23,36,173,224,73,230,76,67,15,24,184,148,138,251,41,3,178,56,242,232,15,244,134,129,82,43,250,218,69,6,114,162,79,88,198,129,126,51,80,48,114,223,240,21,219,189,85,64,222,189,158,66,22,49,244,241,40,8,60,215,61,204,232,218,69,159,171,255,223,11,185,162,58,126,211,217,14,52,74,119,151,166,246,222,54,43,122,55,122,208,217,204,187,116,189,23,134,193,80,64,27,10,195,222,155,59,104,101,68,76,183,223,157,140,77,46,141,134,42,182,81,161,84,107,242,90,133,228,118,184,203,224,134,42,1,131,25,77,232,1,143,9,206,62,14,250,192,124,36,153,78,63,57,43,22,194,153,250,175,209,39,60,58,14,200,19,62,60,127,110,118,154,143,84,17,115,135,68,180,32,46,34,200,35,215,247,164,10,15,0,250,201,197,199,115,212,127,174,222,174,51,120,246,201,237,10,47,164,88,22,219,10,157,86,57,207,167,36,99,76,63,138,172,46,227,225,203,86,103,89,229,208,234,8,5,164,0,87,188,71,172,150,3,168,16,190,228,138,74,48,183,134,172,9,181,38,27,121,174,143,247,12,90,168,8,12,49,130,0,120,247,173,164,121,188,197,17,168,59,34,0,16,234,132,16,55,149,78,222,253,202,210,82,179,238,130,195,149,13,231,130,102,6,125,196,2,205,63,222,117,63,146,250,51,150,169,58,137,123,247,127,167,190,57,168,66,215,252,119,201,100,187,146,232,138,8,64,50,12,0,39,48,129,10,210,212,197,86,138,131,227,76,29,231,143,116,163,230,44,199,14,220,224,216,228,58,206,92,137,16,227,85,91,91,106,48,143,45,105,69,16,110,112,187,136,240,213,72,67,68,155,106,148,152,223,58,53,172,113,11,255,98,27,56,194,116,93,210,128,16,172,182,112,248,35,56,119,101,105,21,227,224,76,172,214,84,114,37,10,83,247,36,214,45,92,62,243,50,174,133,208,46,236,33,169,56,188,106,109,226,81,43,176,61,31,46,160,204,70,226,182,138,173,196,86,95,101,7,186,195,98,104,198,122,182,187,96,116,37,121,83,16,44,47,149,190,148,46,97,191,186,175,104,220,237,117,183,103,247,44,253,10,221,153,107,218,149,181,51,225,202,117,215,61,189,151,29,89,27,51,144,2,208,155,68,117,245,25,77,141,131,18,134,217,237,104,223,82,213,76,184,77,53,61,74,167,198,33,143,246,211,105,255,226,71,251,158,28,195,210,223,77,222,9,145,147,51,133,221,7,186,102,127,51,224,128,109,93,195,36,238,146,88,249,91,129,120,80,41,190,125,225,60,106,216,228,181,24,43,145,155,43,115,1,254,79,161,239,234,187,46,249,223,227,189,165,200,139,216,35,199,165,188,178,244,253,248,87,89,211,99,55,180,237,233,192,250,112,152,69,81,181,56,92,116,68,126,255,189,151,195,109,161,65,255,253,86,93,240,130,230,255,39,67,226,218,47,216,238,189,33,122,41,108,254,116,179,89,173,190,207,6,193,71,179,170,105,165,69,230,238,201,20,105,97,86,48,251,149,202,240,216,45,253,89,182,106,175,219,103,166,7,46,53,156,96,104,174,107,191,183,153,223,218,139,169,238,77,43,53,134,132,63,253,100,166,67,15,104,205,118,132,118,64,241,186,243,231,165,187,193,235,178,32,204,86,96,134,207,33,99,145,117,95,68,119,95,253,217,194,21,100,196,126,255,131,234,103,43,255,145,231,128,47,243,7,141,47,108,182,144,181,223,221,92,249,55,115,149,95,227,10,197,49,154,207,52,33,23,84,120,208,156,85,13,252,43,20,163,170,248,155,38,11,81,22,89,165,150,51,108,216,245,55,47,179,39,193,77,111,130,83,151,69,237,48,80,109,126,250,76,158,194,125,61,143,59,60,107,108,139,196,215,52,35,55,166,30,39,143,230,231,169,161,210,51,222,202,87,151,244,213,94,154,72,189,234,214,139,188,153,144,204,85,66,134,166,254,232,21,222,10,182,189,213,1,102,214,13,62,111,180,69,237,14,140,106,161,190,54,169,150,28,46,218,29,40,56,26,14,194,72,248,247,7,179,243,246,82,132,33,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNotifySubjectLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNotifySubjectLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d2f08d4f-1078-4db2-8912-9c582058dbcb"),
				Name = "NotifySubject",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("09d5e522-4a4c-45fb-a412-d5799f195e9c"),
				ModifiedInSchemaUId = new Guid("09d5e522-4a4c-45fb-a412-d5799f195e9c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("09d5e522-4a4c-45fb-a412-d5799f195e9c"));
		}

		#endregion

	}

	#endregion

}

