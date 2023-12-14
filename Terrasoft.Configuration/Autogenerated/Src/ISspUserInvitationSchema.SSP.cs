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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,148,81,107,194,48,16,199,159,21,252,14,7,190,219,247,57,6,50,68,10,67,196,206,167,177,135,152,158,46,208,38,229,46,113,136,236,187,47,105,117,206,81,109,237,250,16,154,240,203,253,239,159,75,78,139,28,185,16,18,225,21,137,4,155,141,29,61,27,189,81,91,71,194,42,163,71,73,178,24,244,15,131,126,207,177,210,91,72,246,108,49,31,15,250,126,101,72,184,245,8,196,218,34,109,124,144,7,136,19,46,86,140,20,235,157,178,101,128,146,44,220,58,83,18,212,9,172,229,122,65,165,23,69,17,60,178,203,115,65,251,167,211,194,52,23,42,3,179,129,194,144,21,25,56,191,117,244,67,71,191,113,182,20,242,172,118,28,96,139,118,12,28,134,175,50,147,250,248,139,115,88,240,246,173,144,54,78,175,8,204,156,74,207,208,127,36,64,251,211,191,109,99,238,137,78,18,190,78,147,52,87,122,165,85,131,149,75,178,181,88,168,30,144,201,144,111,4,127,123,47,185,101,192,58,217,168,254,39,82,26,167,27,124,252,65,239,51,226,111,39,106,198,22,21,121,169,200,206,133,57,38,56,35,227,138,219,134,46,201,78,98,243,70,59,193,253,93,94,150,200,46,179,225,45,154,2,143,61,162,94,97,109,76,6,137,147,18,185,125,241,167,68,134,224,243,67,101,232,219,133,111,14,62,201,134,151,94,238,104,27,63,241,221,198,113,72,159,247,44,194,189,119,254,222,3,161,52,116,173,26,165,145,152,195,81,77,164,85,187,186,195,170,198,33,234,180,106,138,97,234,215,194,247,13,31,57,79,152,100,5,0,0 };
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

