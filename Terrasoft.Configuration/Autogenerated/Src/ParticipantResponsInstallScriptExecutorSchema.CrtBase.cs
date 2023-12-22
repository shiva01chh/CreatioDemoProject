namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ParticipantResponsInstallScriptExecutorSchema

	/// <exclude/>
	public class ParticipantResponsInstallScriptExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ParticipantResponsInstallScriptExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ParticipantResponsInstallScriptExecutorSchema(ParticipantResponsInstallScriptExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("82641b93-7f38-4bdb-b4da-504eec4b810c");
			Name = "ParticipantResponsInstallScriptExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("95a133a1-cd5f-4df8-af8f-ad440775d7d1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,147,219,78,194,64,16,134,175,75,194,59,108,234,77,73,176,15,128,241,66,14,154,38,98,140,21,239,151,101,128,77,182,179,205,238,108,21,141,239,238,118,11,4,176,53,246,162,233,28,254,111,14,153,34,47,192,150,92,0,123,5,99,184,213,107,74,39,26,215,114,227,12,39,169,177,223,251,234,247,34,103,37,110,88,190,179,4,69,250,160,244,146,43,249,25,226,55,199,232,41,160,40,186,34,6,186,252,233,12,73,146,4,235,19,124,202,149,129,141,231,179,137,226,214,142,216,51,55,36,133,44,57,210,139,239,88,163,205,208,18,87,42,23,70,150,52,251,0,225,72,155,32,149,72,96,144,43,38,106,237,127,165,108,196,178,14,102,244,21,184,199,158,230,64,91,189,170,187,114,75,37,69,19,44,195,55,171,180,92,177,70,10,201,194,130,241,235,68,16,245,174,152,59,51,7,172,94,109,20,133,185,119,185,216,66,193,231,28,249,6,12,131,22,223,237,133,62,109,17,222,156,16,89,249,107,112,240,144,22,116,250,0,212,104,198,187,39,127,17,73,252,123,103,16,15,47,251,111,138,201,53,75,90,42,165,247,64,98,123,111,116,49,29,39,119,94,80,121,188,23,91,178,105,11,61,195,169,118,75,202,86,131,195,90,162,138,155,182,17,234,6,253,24,8,239,236,81,139,112,136,75,5,57,25,127,82,201,190,167,160,5,156,56,69,206,28,178,247,86,134,107,157,196,128,215,139,60,62,164,119,148,73,115,160,189,234,141,43,7,201,17,57,100,241,171,95,164,255,5,42,248,139,18,8,90,185,2,27,64,92,99,253,38,59,10,254,73,226,21,28,230,251,174,223,223,251,163,4,92,53,119,25,236,198,123,238,12,190,211,231,7,42,170,77,1,247,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("82641b93-7f38-4bdb-b4da-504eec4b810c"));
		}

		#endregion

	}

	#endregion

}

