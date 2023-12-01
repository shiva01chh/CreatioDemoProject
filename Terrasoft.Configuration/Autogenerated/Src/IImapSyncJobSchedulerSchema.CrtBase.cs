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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,84,81,107,219,64,12,126,78,161,255,65,164,47,43,4,251,189,117,12,197,29,195,131,64,88,186,31,112,62,203,205,117,246,93,144,238,178,101,101,255,125,242,57,77,151,172,105,75,97,99,243,147,78,210,125,250,244,233,44,171,58,228,149,210,8,55,72,164,216,53,62,153,41,211,158,158,220,159,158,140,2,27,123,11,139,13,123,236,146,194,181,45,106,111,156,229,228,3,90,36,163,47,119,57,143,183,11,71,40,126,137,156,17,222,74,54,148,214,35,53,82,227,2,202,178,83,171,197,198,234,143,174,90,232,37,214,161,69,138,201,105,154,66,198,161,235,20,109,242,237,121,78,110,109,106,100,232,208,47,93,205,208,56,130,114,118,53,7,22,136,37,57,107,190,171,158,16,220,185,10,76,95,70,69,130,201,3,96,250,11,226,42,84,173,209,67,90,207,230,24,153,209,125,36,180,163,63,27,138,95,192,60,2,12,193,67,186,209,81,44,81,127,233,213,56,202,17,191,25,246,146,145,236,48,210,67,144,108,165,72,117,96,101,48,211,113,96,164,194,89,59,232,62,206,51,70,4,77,216,76,199,159,247,67,105,46,157,177,87,86,99,146,165,17,227,105,200,104,163,104,192,227,124,190,179,159,149,246,119,64,66,31,200,114,126,67,1,39,96,154,23,58,158,128,147,34,95,13,35,52,170,229,158,225,3,66,15,89,57,215,194,181,67,222,14,227,125,127,231,221,126,131,176,47,197,4,202,107,19,45,209,46,99,79,34,170,84,169,238,36,156,195,99,143,48,5,27,218,246,252,242,153,177,125,194,206,173,241,120,247,255,239,172,214,206,212,219,246,182,210,254,61,85,11,82,146,251,79,170,42,171,203,213,165,157,25,27,60,138,180,71,31,239,144,41,111,24,117,136,191,237,159,159,86,65,168,252,107,167,37,187,12,14,186,153,244,72,163,55,141,241,12,109,61,236,188,120,254,49,44,241,61,167,248,228,251,9,204,144,97,105,53,6,0,0 };
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

