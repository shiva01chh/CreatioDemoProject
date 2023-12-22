﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignJobDispatcherSchema

	/// <exclude/>
	public class CampaignJobDispatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignJobDispatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignJobDispatcherSchema(CampaignJobDispatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f553ca5f-ffc1-4cda-8cb7-8488149cbb57");
			Name = "CampaignJobDispatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,25,219,114,227,182,245,89,153,201,63,32,234,11,53,213,208,237,171,109,121,103,171,181,119,213,216,233,54,182,155,71,15,76,66,18,178,36,161,0,160,109,197,227,127,239,193,149,0,72,218,94,111,155,233,76,247,101,13,224,220,239,135,106,112,77,196,14,23,4,93,17,206,177,96,107,153,47,89,179,166,155,150,99,73,89,243,253,119,143,223,127,55,105,5,109,54,232,114,47,36,169,143,146,51,192,87,21,41,20,176,200,63,146,134,112,90,244,96,62,96,137,123,151,231,180,249,173,187,220,84,236,22,87,135,135,75,86,215,172,201,207,217,102,3,215,221,251,63,91,204,229,239,233,57,95,213,187,42,191,192,178,216,18,46,134,95,175,56,221,108,162,215,80,89,197,109,248,133,147,177,251,124,137,235,29,166,155,81,196,252,12,23,146,113,74,2,166,234,222,225,93,130,184,53,70,11,20,81,203,227,231,24,85,221,149,109,69,184,195,242,23,249,251,221,206,31,0,9,208,254,196,201,6,28,130,150,184,18,226,16,57,186,127,103,183,31,40,248,91,91,75,3,30,28,28,160,99,209,214,53,230,251,19,123,254,204,217,29,45,137,64,53,145,91,86,10,180,102,28,21,150,4,250,149,221,162,26,55,120,67,106,210,200,220,209,56,8,136,236,218,219,138,22,168,168,176,16,195,188,209,33,90,141,8,53,121,212,130,117,42,64,92,73,220,72,80,227,51,167,119,88,18,243,190,51,7,84,168,119,36,36,87,134,186,41,58,162,63,65,108,95,193,177,82,80,11,52,117,252,30,255,242,244,248,215,167,233,209,56,17,97,141,89,94,209,154,156,49,94,99,169,8,148,101,126,113,145,239,225,223,167,79,135,117,253,28,133,34,112,164,118,139,18,38,20,194,196,167,127,158,30,89,165,73,83,26,189,99,35,156,81,82,149,99,22,0,243,72,48,55,39,184,100,77,181,71,236,246,87,200,71,116,195,137,83,228,156,21,95,254,97,110,23,168,33,247,22,36,155,29,197,148,174,5,225,96,239,198,164,51,186,105,163,115,164,239,42,12,186,95,56,222,129,83,111,112,239,238,5,189,180,115,121,171,114,69,105,167,227,198,138,100,98,104,48,72,178,68,206,88,204,25,82,37,107,50,73,164,7,205,7,212,121,250,86,110,243,65,75,136,248,60,211,2,77,14,145,220,82,145,141,136,219,55,30,136,44,122,230,244,50,143,217,20,210,23,32,37,212,158,36,94,210,92,215,23,31,137,20,8,242,91,168,255,229,150,160,29,103,5,129,188,5,33,239,104,161,207,170,26,240,220,147,8,83,253,217,120,8,175,172,150,27,34,237,95,19,78,100,203,155,161,160,65,239,222,161,108,216,30,75,85,83,76,113,221,67,183,145,199,3,124,79,178,217,76,27,74,89,202,155,107,80,251,149,174,45,160,37,91,195,35,129,52,230,100,189,152,174,186,196,60,56,65,247,84,110,81,163,18,56,0,25,78,113,5,14,198,44,201,26,183,149,28,51,153,9,182,142,9,90,166,180,208,226,36,178,94,126,70,155,210,159,178,97,230,38,202,192,118,17,166,83,49,73,245,21,52,88,116,83,49,213,25,143,122,15,231,250,126,220,103,6,207,248,201,254,189,80,72,23,186,49,112,229,25,67,34,115,170,249,50,238,155,156,1,208,130,191,214,93,189,96,245,93,105,75,42,240,124,62,230,80,199,243,147,6,3,47,189,16,205,49,124,87,207,205,249,232,25,208,228,56,106,193,152,162,177,100,114,103,74,117,76,48,75,170,218,144,233,94,85,24,130,82,251,178,169,189,153,141,175,71,205,236,123,250,233,3,41,90,37,159,113,242,203,6,31,195,236,12,117,30,132,170,77,160,49,156,56,194,94,246,193,121,16,205,201,93,236,131,132,209,179,206,152,136,142,97,159,234,29,174,90,242,122,215,93,152,73,108,116,0,208,83,7,184,108,25,143,63,217,199,150,150,222,123,171,114,142,96,16,39,106,170,65,107,202,245,31,174,253,88,155,24,82,185,25,122,178,177,113,106,30,209,116,164,242,43,118,169,209,179,161,9,202,26,231,41,22,253,142,129,128,96,21,87,175,74,224,212,151,218,169,117,102,57,153,21,69,141,162,230,47,167,132,70,196,218,23,171,210,88,87,64,245,46,182,40,243,176,126,110,46,223,71,253,119,82,96,65,122,149,216,2,229,63,183,205,161,1,155,56,250,170,27,133,197,45,170,108,87,251,157,159,216,75,64,62,178,200,183,48,165,125,57,122,5,67,127,190,148,108,247,118,214,10,251,91,120,195,148,250,45,204,1,125,136,187,237,143,3,148,149,7,243,211,122,39,247,3,120,38,175,232,26,101,30,227,135,16,197,187,18,4,49,170,100,97,20,57,164,121,23,56,185,78,129,126,30,166,225,105,169,245,2,51,10,184,32,187,124,252,171,27,39,214,29,230,170,128,174,154,53,75,234,202,185,189,181,226,47,61,7,128,11,216,153,215,203,144,118,48,34,234,179,133,121,239,70,94,47,155,185,95,137,203,182,208,227,221,2,193,220,77,140,226,70,255,184,106,230,157,214,86,230,40,127,95,46,84,47,53,24,167,6,24,226,65,234,173,82,173,153,170,169,139,29,41,232,154,146,206,212,35,205,67,223,236,48,199,181,30,207,22,83,161,247,230,233,201,213,54,154,213,70,150,247,100,221,214,179,155,89,146,148,36,247,20,202,6,84,35,4,21,175,17,249,241,129,102,52,204,119,29,213,165,233,137,170,83,72,170,64,40,76,165,82,4,65,197,136,138,237,98,58,196,156,49,84,245,27,248,78,96,244,26,173,131,49,123,23,110,146,239,93,64,25,252,124,185,37,197,151,247,124,211,170,205,253,167,182,170,50,37,62,91,103,230,221,181,175,73,76,111,28,45,225,235,208,147,44,177,33,10,252,79,27,73,229,222,85,102,157,15,73,131,81,21,160,223,197,134,154,77,63,127,53,61,177,23,215,233,218,151,116,105,245,185,36,56,153,143,81,215,253,213,208,16,212,254,34,146,112,97,115,246,3,213,32,16,131,199,166,89,206,109,212,156,56,107,79,30,187,61,223,56,240,122,85,78,231,206,10,112,64,79,243,14,212,231,243,181,44,156,99,167,131,138,246,208,106,172,63,184,97,216,134,160,243,66,250,111,246,125,76,63,180,56,144,97,238,38,217,1,61,163,141,156,37,52,18,40,100,42,177,171,28,147,149,90,152,137,196,180,210,137,188,136,55,144,37,84,112,73,244,230,6,112,199,129,119,141,104,12,54,182,36,14,156,128,35,141,6,160,62,114,214,238,52,104,223,231,243,192,107,46,56,86,246,43,32,148,61,26,76,118,151,20,38,26,98,223,212,215,194,84,18,244,103,52,181,207,83,39,213,235,196,26,138,84,31,34,23,84,168,247,149,253,252,97,2,181,127,153,175,54,13,148,3,251,240,153,65,193,216,199,166,239,173,142,121,88,75,192,27,115,167,177,179,68,58,109,37,201,153,10,238,186,35,164,170,30,164,78,31,10,178,211,2,147,7,175,143,157,64,107,232,44,176,255,5,19,130,217,90,244,62,88,252,110,166,195,127,169,209,215,149,144,193,47,46,179,121,23,151,158,221,52,144,95,245,167,83,206,25,183,115,170,229,59,7,145,92,154,161,5,56,24,106,21,122,23,12,8,232,48,45,69,142,168,220,114,118,255,202,45,244,191,209,185,138,94,189,208,77,172,109,232,111,45,65,180,132,202,171,8,115,181,112,249,109,204,106,74,237,50,246,7,246,168,168,196,123,153,223,222,160,116,233,214,100,236,23,4,8,161,44,174,161,246,97,150,86,115,8,173,8,32,155,14,226,249,240,25,104,175,177,34,190,95,5,31,51,204,139,219,122,179,158,230,142,120,104,163,24,232,127,34,173,108,241,241,201,245,183,189,215,224,235,243,108,212,8,95,147,75,63,147,154,221,17,209,13,177,42,4,197,51,9,133,204,47,34,118,131,64,184,41,227,124,208,53,80,124,109,218,185,124,123,211,208,168,26,250,253,86,141,139,170,22,136,45,107,171,18,221,18,144,177,130,22,84,142,38,148,209,29,92,36,210,197,98,36,67,54,170,185,216,223,186,212,164,20,28,143,129,204,143,100,127,146,235,75,8,49,104,198,141,200,94,209,168,194,233,201,90,213,247,18,37,91,218,205,93,18,168,224,51,76,69,22,10,230,27,238,105,3,3,35,199,183,21,113,194,41,251,40,120,32,57,196,201,34,170,253,174,255,65,244,135,17,49,186,150,26,142,147,169,6,253,46,249,130,244,147,78,84,251,151,250,93,20,114,53,27,100,225,208,158,6,39,219,144,202,47,192,132,100,15,234,3,239,67,174,236,159,123,103,117,254,239,190,164,204,186,161,28,162,16,171,74,161,136,171,64,163,77,196,163,51,68,244,107,97,238,163,76,13,3,185,25,77,94,53,191,244,108,22,43,249,71,15,4,94,143,183,87,170,183,150,40,87,87,254,223,183,212,206,18,255,201,61,181,98,197,23,148,13,254,90,233,195,41,40,149,35,3,92,216,121,197,179,29,119,252,43,134,185,141,47,245,93,248,239,223,53,152,21,5,51,33,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateScheduleExceptionLocalizableString());
			LocalizableStrings.Add(CreateScheduleBySchemaUIdExceptionLocalizableString());
			LocalizableStrings.Add(CreateRemoveJobExceptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateScheduleExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f81b54a9-befa-486d-a422-6a6838791c26"),
				Name = "ScheduleException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("f553ca5f-ffc1-4cda-8cb7-8488149cbb57"),
				ModifiedInSchemaUId = new Guid("f553ca5f-ffc1-4cda-8cb7-8488149cbb57")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateScheduleBySchemaUIdExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3ab6e562-edf6-4e64-b376-58dcc6e97765"),
				Name = "ScheduleBySchemaUIdException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("f553ca5f-ffc1-4cda-8cb7-8488149cbb57"),
				ModifiedInSchemaUId = new Guid("f553ca5f-ffc1-4cda-8cb7-8488149cbb57")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRemoveJobExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1308c01a-385c-4f64-bfba-185212c2e291"),
				Name = "RemoveJobException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("f553ca5f-ffc1-4cda-8cb7-8488149cbb57"),
				ModifiedInSchemaUId = new Guid("f553ca5f-ffc1-4cda-8cb7-8488149cbb57")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f553ca5f-ffc1-4cda-8cb7-8488149cbb57"));
		}

		#endregion

	}

	#endregion

}

