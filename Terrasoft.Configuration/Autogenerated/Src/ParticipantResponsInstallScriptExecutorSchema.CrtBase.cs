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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,147,201,110,194,48,16,134,207,65,226,29,172,244,146,74,109,30,0,212,67,161,139,34,149,170,106,160,119,99,6,176,228,140,35,123,156,150,34,222,189,142,3,8,104,82,53,135,40,179,252,223,44,154,32,47,192,150,92,0,155,130,49,220,234,37,165,99,141,75,185,114,134,147,212,216,239,109,251,189,200,89,137,43,150,111,44,65,145,62,43,61,231,74,126,135,248,240,24,61,5,20,69,87,196,64,151,63,125,68,146,36,193,250,4,159,114,101,96,229,249,108,172,184,181,3,246,198,13,73,33,75,142,244,238,59,214,104,51,180,196,149,202,133,145,37,61,126,129,112,164,77,144,74,36,48,200,21,19,181,246,191,82,54,96,89,7,51,218,6,238,177,167,9,208,90,47,234,174,220,92,73,209,4,203,240,205,42,45,23,172,145,66,50,179,96,252,58,17,68,189,43,230,206,204,107,86,175,54,138,194,220,155,92,172,161,224,19,142,124,5,134,65,139,239,238,66,159,182,8,135,39,68,86,254,26,28,60,164,5,157,62,3,53,154,209,230,213,95,68,18,255,222,25,196,55,151,253,55,197,228,146,37,45,149,210,39,32,177,126,50,186,120,24,37,247,94,80,121,188,23,91,178,105,11,61,195,7,237,230,148,45,174,15,107,137,42,110,218,70,168,27,244,99,32,124,178,23,45,194,33,206,21,228,100,252,73,37,251,158,130,22,112,236,20,57,115,200,222,91,25,46,117,18,3,222,206,242,248,144,222,81,38,205,129,246,170,15,174,28,36,71,228,13,139,167,126,145,254,23,168,224,47,74,32,104,229,10,108,0,113,141,245,155,236,40,248,39,137,87,112,152,111,87,191,119,251,163,4,92,52,119,25,236,198,123,238,12,62,255,252,0,76,145,178,170,238,3,0,0 };
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

