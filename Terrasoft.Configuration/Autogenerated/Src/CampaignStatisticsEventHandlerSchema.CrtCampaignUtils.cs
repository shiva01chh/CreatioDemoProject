namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignStatisticsEventHandlerSchema

	/// <exclude/>
	public class CampaignStatisticsEventHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignStatisticsEventHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignStatisticsEventHandlerSchema(CampaignStatisticsEventHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("056a2c31-7878-4573-8dca-ecafe4c5fd1b");
			Name = "CampaignStatisticsEventHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,86,75,79,219,74,20,94,187,82,255,195,40,221,216,18,50,237,182,180,149,66,26,90,36,10,168,9,237,226,234,46,134,241,137,51,170,61,227,206,3,8,21,255,189,103,30,182,243,112,128,234,74,213,101,67,60,62,175,239,251,206,153,99,65,107,208,13,101,64,230,160,20,213,114,97,242,137,20,11,94,90,69,13,151,226,229,139,95,47,95,36,86,115,81,146,217,74,27,168,143,186,231,117,23,5,249,216,24,197,175,173,1,189,215,100,66,235,134,242,82,228,211,27,16,230,51,21,69,5,106,175,245,199,227,39,3,161,1,154,188,82,80,98,173,100,82,81,173,223,146,246,229,122,18,111,119,120,120,72,222,105,91,215,84,173,62,196,103,68,107,40,23,154,212,96,150,178,208,196,72,66,153,177,180,226,247,64,88,12,69,180,65,58,180,225,76,147,194,42,87,81,247,10,92,26,157,183,241,15,215,18,52,246,186,226,140,104,160,21,20,132,185,242,186,234,102,93,196,245,58,201,112,249,199,84,195,1,57,189,16,189,183,108,54,14,166,119,192,172,83,12,153,170,185,160,6,48,255,47,15,187,231,71,10,196,129,197,190,37,151,138,223,120,27,247,190,9,15,132,185,247,8,213,227,155,86,80,247,5,156,99,163,144,247,68,224,63,185,72,31,199,144,29,237,13,218,58,206,233,117,5,195,49,159,225,125,73,21,230,228,13,66,121,36,208,154,85,118,20,137,0,81,4,46,54,137,185,84,178,1,180,6,199,140,215,236,113,251,47,161,87,246,208,56,131,10,152,33,159,192,204,165,161,213,64,61,122,34,173,48,193,46,205,136,27,177,36,185,161,10,59,197,187,34,22,184,141,113,210,43,13,10,149,19,248,27,115,103,222,54,73,112,14,42,91,139,244,196,10,150,251,112,233,232,180,24,101,241,125,126,162,100,61,68,69,71,88,107,248,125,9,10,210,81,107,234,98,228,167,122,250,19,39,32,13,57,114,116,71,7,3,170,23,158,45,161,166,249,84,24,110,86,167,69,150,17,170,99,189,94,190,36,0,201,103,13,48,190,88,157,203,51,201,126,124,230,136,60,13,250,38,10,140,85,34,2,246,71,15,251,88,252,10,20,211,21,243,37,124,146,180,250,35,26,159,173,193,64,81,249,88,20,233,200,181,184,213,142,149,200,215,147,220,116,83,150,15,100,141,88,28,144,54,242,14,121,91,68,220,72,94,144,171,166,192,223,109,192,177,45,56,8,6,30,2,40,189,1,222,120,192,61,184,63,167,193,69,81,125,161,59,177,158,41,72,31,204,250,234,99,91,7,40,91,109,125,176,123,53,116,157,62,3,236,237,57,85,101,68,49,66,227,64,254,204,94,199,100,219,160,179,33,239,49,91,114,188,173,135,252,135,225,110,69,249,34,11,190,224,80,92,136,62,68,175,255,71,68,53,231,53,228,87,134,157,203,219,61,190,199,56,46,67,222,155,116,228,19,171,20,222,168,238,52,247,43,138,25,215,41,155,51,251,31,102,53,136,16,20,10,234,228,223,185,89,134,17,117,42,125,149,183,237,204,166,89,182,97,24,86,13,68,129,31,158,123,85,174,221,171,219,139,216,31,140,155,166,194,27,184,91,196,11,169,6,247,175,116,79,178,201,59,191,118,91,235,222,156,198,1,193,253,17,38,164,179,222,216,207,201,63,23,170,64,170,222,188,126,157,253,235,103,46,44,108,63,114,23,126,201,118,163,101,212,42,254,74,158,26,198,192,214,3,150,99,216,146,164,211,59,6,141,83,149,192,93,27,45,137,43,13,63,191,52,45,33,204,213,25,187,159,249,227,111,180,178,144,238,110,224,3,50,10,85,117,33,71,49,89,210,86,115,38,203,18,123,102,170,148,84,39,82,213,212,164,49,199,1,166,239,199,108,187,43,98,24,179,84,242,54,214,191,166,238,160,96,221,167,83,37,75,36,237,17,189,160,253,56,33,166,253,58,249,11,242,237,126,18,253,255,196,220,173,241,111,75,187,53,184,225,116,243,208,159,173,255,253,6,97,205,193,139,55,12,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateOnExecutionTerminateExceptionLocalizableString());
			LocalizableStrings.Add(CreateOnStopExceptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateOnExecutionTerminateExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0197d642-0e99-4a65-b19d-c37839084917"),
				Name = "OnExecutionTerminateException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("056a2c31-7878-4573-8dca-ecafe4c5fd1b"),
				ModifiedInSchemaUId = new Guid("056a2c31-7878-4573-8dca-ecafe4c5fd1b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOnStopExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("240946f2-b208-45ac-909a-43c9b9be0ccb"),
				Name = "OnStopException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("056a2c31-7878-4573-8dca-ecafe4c5fd1b"),
				ModifiedInSchemaUId = new Guid("056a2c31-7878-4573-8dca-ecafe4c5fd1b")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("056a2c31-7878-4573-8dca-ecafe4c5fd1b"));
		}

		#endregion

	}

	#endregion

}

