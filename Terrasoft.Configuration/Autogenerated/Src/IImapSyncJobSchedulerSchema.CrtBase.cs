namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImapSyncJobSchedulerSchema

	/// <exclude/>
	public class IImapSyncJobSchedulerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImapSyncJobSchedulerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImapSyncJobSchedulerSchema(IImapSyncJobSchedulerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("42c2b310-e629-40cf-90c2-3202b6197a53");
			Name = "IImapSyncJobScheduler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("80eb4b00-d20b-4335-a2cc-1f02c0e63f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,84,81,107,219,64,12,126,78,161,255,65,164,47,27,4,251,189,117,12,195,29,195,131,64,88,186,31,112,62,203,205,117,246,93,144,238,210,102,101,255,125,242,57,77,155,116,233,198,160,101,243,147,78,210,125,250,244,233,44,171,58,228,149,210,8,87,72,164,216,53,62,153,41,211,158,158,220,159,158,140,2,27,123,13,139,13,123,236,146,194,181,45,106,111,156,229,228,19,90,36,163,47,118,57,143,183,11,71,40,126,137,156,17,94,75,54,148,214,35,53,82,227,28,202,178,83,171,197,198,234,207,174,90,232,37,214,161,69,138,201,105,154,66,198,161,235,20,109,242,237,121,78,110,109,106,100,232,208,47,93,205,208,56,130,114,246,97,14,44,16,75,114,214,124,87,61,33,184,113,21,152,190,140,138,4,147,7,192,244,9,226,42,84,173,209,67,90,207,230,24,153,209,125,36,180,163,63,27,138,159,195,60,2,12,193,67,186,209,81,44,81,127,235,213,56,202,17,239,12,123,201,72,118,24,233,33,72,182,82,164,58,176,50,152,233,56,48,82,225,172,29,116,31,231,25,35,130,38,108,166,227,175,251,161,52,151,206,216,43,171,49,201,210,136,241,107,200,104,163,104,192,227,124,190,179,95,148,246,57,32,161,15,100,57,191,162,128,19,48,205,111,58,158,128,147,34,183,134,17,26,213,114,207,240,1,161,135,172,156,107,225,210,33,111,135,241,177,191,243,110,191,65,216,151,98,2,229,165,137,150,104,151,177,39,17,85,170,84,55,18,206,225,177,71,152,130,13,109,251,254,226,133,177,125,193,206,173,241,120,247,255,239,172,214,206,212,219,246,182,210,190,157,170,5,41,201,253,39,85,149,213,229,234,210,206,140,13,30,69,218,163,143,119,200,148,55,140,58,196,223,246,245,167,85,16,42,255,167,211,146,93,6,7,221,76,122,164,209,95,141,241,12,109,61,236,188,120,254,49,44,241,61,167,248,158,126,63,1,57,223,229,166,62,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("42c2b310-e629-40cf-90c2-3202b6197a53"));
		}

		#endregion

	}

	#endregion

}

