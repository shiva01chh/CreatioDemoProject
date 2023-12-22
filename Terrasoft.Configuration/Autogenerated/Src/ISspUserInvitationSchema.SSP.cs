namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISspUserInvitationSchema

	/// <exclude/>
	public class ISspUserInvitationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISspUserInvitationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISspUserInvitationSchema(ISspUserInvitationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c32a2df7-dfa5-4008-a507-49930a3bf59e");
			Name = "ISspUserInvitation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,148,81,107,194,48,16,199,159,21,252,14,7,190,235,251,28,3,25,34,133,33,98,231,211,216,67,76,175,46,208,38,229,46,113,136,236,187,47,105,117,234,232,108,237,250,16,154,240,203,253,239,159,75,78,139,28,185,16,18,225,21,137,4,155,212,142,158,141,78,213,214,145,176,202,232,81,28,47,7,253,195,160,223,115,172,244,22,226,61,91,204,39,131,190,95,25,18,110,61,2,145,182,72,169,15,242,0,81,204,197,154,145,34,189,83,182,12,80,146,133,219,100,74,130,58,129,181,92,47,168,244,198,227,49,60,178,203,115,65,251,167,211,194,44,23,42,3,147,66,97,200,138,12,156,223,58,250,161,199,151,56,91,10,121,86,59,14,176,69,59,1,14,195,87,153,73,125,252,229,57,44,120,251,86,72,27,37,127,8,204,157,74,206,208,127,36,64,251,211,191,109,99,225,137,78,18,190,78,211,36,87,122,173,85,131,149,107,178,181,88,168,30,144,201,144,111,4,127,123,47,185,85,192,58,217,168,254,167,82,26,167,27,124,252,66,239,51,226,111,39,106,198,22,21,121,169,200,206,133,57,38,56,39,227,138,219,134,174,201,78,98,139,70,59,193,253,93,94,86,200,46,179,225,45,154,2,143,61,162,94,97,99,76,6,177,147,18,185,125,241,103,68,134,224,243,67,101,232,219,133,111,14,62,201,134,151,94,238,104,27,63,246,221,198,113,72,159,247,44,194,189,119,254,222,3,161,52,244,87,53,74,35,17,135,163,154,74,171,118,117,135,85,141,67,212,73,213,20,195,212,175,93,126,223,96,212,177,68,108,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c32a2df7-dfa5-4008-a507-49930a3bf59e"));
		}

		#endregion

	}

	#endregion

}

