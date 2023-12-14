namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignHelperSchema

	/// <exclude/>
	public class CampaignHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignHelperSchema(CampaignHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715");
			Name = "CampaignHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("162d1c91-6a07-417c-8455-dae56dc8642f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,88,75,79,227,72,16,62,103,164,249,15,173,204,197,145,34,103,207,3,201,129,64,152,72,12,66,132,89,14,171,21,234,216,229,196,26,187,59,219,109,3,25,196,127,159,234,135,221,110,199,9,25,118,103,57,64,92,93,93,143,175,234,43,87,96,52,7,185,161,17,144,59,16,130,74,158,20,225,148,179,36,93,149,130,22,41,103,31,63,188,124,252,208,43,101,202,86,100,177,149,5,228,39,173,103,212,207,50,136,148,178,12,47,129,129,72,35,167,51,229,121,206,89,243,89,128,255,20,78,105,190,161,233,170,165,20,158,159,57,65,51,56,60,186,96,69,90,164,32,253,27,149,157,69,180,134,156,146,177,111,61,244,143,241,42,94,254,36,96,133,113,147,105,70,165,252,76,42,149,47,144,109,64,104,141,77,185,204,210,136,68,74,97,231,188,247,162,117,156,25,132,160,248,76,110,68,250,72,11,48,103,27,243,64,34,117,70,100,33,116,184,158,33,237,253,26,43,129,49,51,252,195,147,192,87,24,156,28,97,203,228,117,205,139,25,47,89,124,241,28,193,70,213,4,109,246,223,80,233,31,99,254,160,225,189,38,63,1,139,13,56,29,72,137,50,42,184,64,220,111,52,200,54,8,3,184,15,64,240,77,34,76,156,49,211,103,164,244,30,7,68,245,104,175,247,224,139,49,64,95,160,218,165,247,122,56,176,89,10,89,44,247,212,176,21,197,195,142,249,67,150,191,66,177,230,113,43,219,209,104,68,78,101,153,231,84,108,39,149,224,18,10,73,138,53,22,194,130,64,158,210,98,77,228,6,162,52,73,33,38,137,14,18,255,32,241,98,146,50,146,8,158,147,243,179,176,54,57,106,219,60,221,80,65,115,221,94,227,190,31,119,127,114,135,190,148,76,85,222,10,195,211,145,190,209,109,160,10,108,30,155,203,117,160,105,12,200,77,140,79,188,97,128,103,101,206,228,29,159,65,17,173,173,17,35,211,26,152,63,39,137,58,219,181,35,160,40,5,147,147,211,81,245,169,209,55,178,192,177,229,218,71,97,89,125,62,220,68,67,114,89,166,49,113,153,13,117,79,245,180,115,105,217,240,215,223,196,143,188,106,61,61,145,182,118,242,200,106,0,249,30,194,166,210,87,202,232,10,81,194,248,230,72,5,202,34,56,219,170,25,16,212,164,234,15,78,26,182,29,198,99,235,32,156,10,192,174,52,199,65,139,18,230,234,252,130,149,57,8,186,204,224,180,233,125,170,147,152,212,144,59,147,70,160,194,50,225,200,160,149,176,49,156,38,36,168,2,10,245,193,12,91,240,252,44,176,118,144,62,170,253,140,185,97,19,213,202,231,160,130,174,103,170,232,242,163,110,208,26,103,175,250,183,85,99,101,150,53,137,252,31,51,136,168,106,48,245,66,204,53,95,143,165,212,111,101,196,219,92,168,122,136,240,4,209,0,188,42,32,25,187,86,26,77,194,78,186,60,166,162,40,105,214,205,151,127,67,8,91,173,166,185,135,54,225,58,186,194,235,178,67,21,190,53,185,144,44,93,173,139,39,80,191,29,230,57,143,33,179,37,199,121,80,74,66,89,76,54,130,175,4,72,169,101,240,91,11,123,100,89,230,44,225,71,151,70,41,55,241,84,207,237,18,85,232,123,119,162,230,195,216,17,168,247,72,5,145,160,118,55,37,134,39,178,208,15,237,66,13,76,221,237,108,8,250,115,118,99,145,236,183,143,234,69,67,163,142,144,85,10,106,58,52,39,155,21,223,175,65,224,196,83,138,225,92,94,252,131,249,6,198,86,120,163,16,133,2,223,253,141,244,6,106,56,152,40,77,10,38,252,112,161,137,189,189,230,87,60,250,254,37,101,133,12,6,158,194,197,51,68,101,1,183,64,99,180,24,11,50,158,84,227,167,13,15,226,224,193,103,213,122,237,220,80,55,214,243,219,4,252,39,205,74,56,85,245,152,116,225,96,201,211,115,224,117,222,95,114,158,77,124,136,135,45,255,218,179,195,196,156,190,218,73,217,49,158,77,94,166,238,245,204,181,203,29,174,213,92,220,193,179,106,0,140,228,42,250,177,208,7,58,152,214,18,90,111,169,195,253,59,161,117,223,43,214,130,63,105,40,235,163,192,184,12,103,92,228,180,8,106,207,205,49,48,24,116,12,252,102,30,239,24,252,246,133,244,127,179,189,43,6,159,230,250,42,212,219,180,153,12,110,129,158,220,227,187,137,44,129,104,44,153,122,71,69,84,106,219,45,187,132,46,37,160,91,180,95,155,235,28,36,187,223,145,26,227,196,72,246,13,148,119,142,10,223,248,183,95,26,8,86,242,174,177,160,195,53,62,83,69,23,127,10,44,34,154,81,97,185,218,96,76,125,67,57,205,55,184,84,13,218,132,193,133,72,226,222,246,62,186,236,249,250,117,136,52,214,159,199,11,151,156,93,34,201,216,24,8,124,71,246,116,208,170,145,26,57,158,66,187,76,86,92,173,159,150,134,158,199,112,150,178,216,237,173,88,88,7,222,47,188,187,57,22,34,253,129,11,152,69,119,185,173,62,41,54,134,228,88,210,86,80,247,39,26,117,45,38,9,23,149,7,181,255,90,203,7,119,176,172,42,168,49,182,112,177,236,229,252,85,135,135,206,175,37,218,212,110,211,216,131,200,117,139,149,120,177,84,109,88,157,57,167,78,71,181,185,55,98,251,87,109,53,25,190,252,241,26,106,199,253,97,203,131,35,206,142,117,75,249,29,115,129,105,187,118,127,221,115,241,93,255,79,41,188,5,201,75,17,161,58,23,216,54,195,102,154,157,57,84,47,109,227,246,81,5,138,206,119,84,77,10,142,184,86,177,245,142,219,127,93,141,189,50,195,34,129,41,130,254,175,21,205,90,225,134,231,144,88,181,33,73,104,38,161,235,245,244,88,135,210,253,159,5,35,245,133,40,83,63,63,1,161,80,200,23,125,19,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCampaignNotFoundExceptionLocalizableString());
			LocalizableStrings.Add(CreateScheduleNextCampaignJobExceptionLocalizableString());
			LocalizableStrings.Add(CreateRunCampaignExceptionLocalizableString());
			LocalizableStrings.Add(CreateCampaignSchemaNotFoundExceptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCampaignNotFoundExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("eb9ddd1e-1015-403b-bb5f-a49b3fc21fce"),
				Name = "CampaignNotFoundException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715"),
				ModifiedInSchemaUId = new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateScheduleNextCampaignJobExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("83c1e6a4-4525-4ae3-8a5a-680a5e9bd043"),
				Name = "ScheduleNextCampaignJobException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715"),
				ModifiedInSchemaUId = new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRunCampaignExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("aeb33530-d65e-440a-90e2-66dde8d996b2"),
				Name = "RunCampaignException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715"),
				ModifiedInSchemaUId = new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCampaignSchemaNotFoundExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2261ae3d-11a2-4503-ad1d-3cdfc5512c8f"),
				Name = "CampaignSchemaNotFoundException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715"),
				ModifiedInSchemaUId = new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4e0c0d9a-29a7-40ca-9f1f-0b3160440715"));
		}

		#endregion

	}

	#endregion

}

