namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignQueueMonitoringJobDispatcherSchema

	/// <exclude/>
	public class CampaignQueueMonitoringJobDispatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignQueueMonitoringJobDispatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignQueueMonitoringJobDispatcherSchema(CampaignQueueMonitoringJobDispatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("47239ecf-12fc-4c08-a358-3dca5b05f858");
			Name = "CampaignQueueMonitoringJobDispatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,87,95,111,219,54,16,127,118,129,126,135,67,246,34,3,134,188,190,58,177,139,46,13,58,111,77,183,54,9,250,88,208,210,89,225,42,145,42,73,185,245,130,125,247,30,37,82,18,101,43,113,48,63,196,230,241,254,254,238,120,119,17,172,64,93,178,4,225,22,149,98,90,110,77,124,41,197,150,103,149,98,134,75,241,242,197,195,203,23,147,74,115,145,193,199,138,41,243,239,121,123,238,139,40,140,111,146,123,76,171,28,213,49,142,207,184,33,174,162,144,162,187,181,82,151,172,40,25,207,4,25,213,70,195,178,38,198,158,26,7,215,76,24,221,73,103,185,220,176,124,177,104,180,198,239,101,150,17,153,238,137,227,23,133,25,57,15,151,57,211,122,1,94,203,199,10,43,188,150,130,27,169,136,247,15,185,121,203,41,122,67,142,171,90,110,62,159,195,133,174,138,130,169,253,202,157,255,86,114,199,83,212,80,160,185,151,169,6,35,225,158,137,52,71,216,40,249,21,5,36,78,61,124,179,250,161,104,13,196,94,229,188,167,179,172,54,57,79,32,177,174,157,228,25,44,224,55,166,177,102,9,46,102,176,126,83,150,87,59,20,230,61,215,6,133,141,98,242,80,71,210,65,224,145,91,80,36,124,199,12,54,247,101,115,128,196,222,3,23,6,6,62,220,42,158,101,168,72,136,142,102,79,169,121,245,235,185,211,141,34,109,212,135,182,8,170,18,149,225,104,141,213,97,58,91,77,200,114,71,229,64,80,130,54,214,0,80,48,239,148,172,202,15,84,132,176,92,65,88,11,109,238,251,108,206,129,97,158,106,194,27,65,97,216,88,169,154,229,150,238,145,162,83,184,93,158,141,160,124,54,95,53,105,136,91,157,253,68,181,16,141,136,195,151,111,33,225,188,23,235,152,204,240,108,95,215,100,146,161,177,0,12,21,194,235,215,16,29,16,151,32,240,251,152,129,232,78,163,34,0,5,38,246,249,78,167,181,83,19,61,98,96,9,59,150,87,88,51,253,247,191,176,253,29,115,202,253,115,33,109,164,224,75,18,156,143,1,233,56,7,199,16,190,80,75,131,222,128,22,130,215,16,159,192,236,64,195,105,144,189,67,234,103,82,129,182,223,230,30,187,54,161,125,163,140,97,253,56,168,193,115,39,108,159,64,117,125,84,174,139,32,32,247,65,30,17,60,78,61,142,121,200,19,64,31,94,133,25,8,238,78,76,196,80,223,65,62,198,250,211,117,211,193,109,39,148,134,108,96,218,203,31,23,164,141,155,84,38,115,7,170,227,233,250,214,154,134,140,205,171,157,53,228,237,212,122,69,191,175,153,96,116,142,187,155,195,201,214,118,179,134,195,246,178,233,249,51,173,183,3,214,250,208,30,26,55,222,226,150,85,121,71,141,125,101,61,211,200,78,242,20,188,22,2,58,114,189,250,187,84,95,235,69,193,122,62,243,29,188,210,46,20,87,20,52,142,58,15,252,175,107,46,42,131,249,158,180,93,156,50,239,86,81,173,107,114,194,56,152,13,253,242,14,205,128,158,42,151,233,90,52,214,41,231,175,102,141,90,174,111,246,52,44,11,91,107,11,48,170,178,225,120,167,23,109,236,52,93,75,55,250,22,79,140,198,233,65,47,56,21,232,59,225,45,223,9,150,152,138,229,20,157,142,60,156,84,166,9,106,221,186,68,151,206,180,142,142,62,160,22,164,94,20,145,105,68,234,50,121,112,24,108,91,114,252,39,238,99,11,153,221,251,12,163,46,31,81,117,221,238,75,140,166,53,125,234,189,153,76,110,213,190,243,216,22,199,201,78,244,140,185,71,109,241,178,127,15,193,27,54,82,135,2,109,96,225,162,53,218,12,143,99,189,22,6,149,96,249,213,15,76,168,34,90,144,7,185,141,63,85,34,154,62,175,155,244,86,157,163,17,120,32,104,135,116,111,1,254,145,27,216,210,116,24,236,142,180,87,90,172,176,222,50,21,122,172,253,166,233,96,28,155,174,53,165,100,138,21,32,40,115,203,51,90,238,12,254,48,103,171,145,57,227,215,199,75,199,71,19,230,98,94,43,88,245,166,67,13,223,95,194,62,110,67,255,1,68,3,41,112,86,60,160,84,62,97,31,143,60,67,147,121,170,162,79,216,175,162,0,237,3,155,87,34,125,196,34,28,21,187,161,122,33,195,79,185,251,168,240,105,118,7,197,209,80,67,34,209,250,159,159,162,73,10,87,115,13,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateExecutionExceptionLocalizableString());
			LocalizableStrings.Add(CreateCreateJobErrorLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateExecutionExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fe22e7df-a5c5-4b9d-824b-76db35cfd28d"),
				Name = "ExecutionException",
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067"),
				CreatedInSchemaUId = new Guid("47239ecf-12fc-4c08-a358-3dca5b05f858"),
				ModifiedInSchemaUId = new Guid("47239ecf-12fc-4c08-a358-3dca5b05f858")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCreateJobErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("04db795e-fe79-4373-8e8e-a00606a0efa9"),
				Name = "CreateJobError",
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067"),
				CreatedInSchemaUId = new Guid("47239ecf-12fc-4c08-a358-3dca5b05f858"),
				ModifiedInSchemaUId = new Guid("47239ecf-12fc-4c08-a358-3dca5b05f858")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("47239ecf-12fc-4c08-a358-3dca5b05f858"));
		}

		#endregion

	}

	#endregion

}

