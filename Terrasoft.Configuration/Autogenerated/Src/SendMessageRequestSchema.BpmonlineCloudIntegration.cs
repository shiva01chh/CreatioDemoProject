namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SendMessageRequestSchema

	/// <exclude/>
	public class SendMessageRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SendMessageRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SendMessageRequestSchema(SendMessageRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("394b7098-d52a-4248-b5d6-5a4098ccf4ac");
			Name = "SendMessageRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,147,77,79,195,48,12,134,207,32,241,31,172,113,129,75,123,103,128,4,99,66,28,6,136,237,134,208,100,90,183,179,212,52,35,118,145,96,226,191,147,164,219,216,7,26,26,189,180,118,253,186,121,94,187,53,26,146,41,102,4,35,114,14,197,22,154,244,108,93,112,217,56,84,182,117,210,235,15,7,54,167,74,142,14,103,71,135,7,141,112,93,194,240,67,148,76,119,35,78,158,154,90,217,80,50,36,199,88,241,103,236,224,171,124,221,177,163,210,7,208,171,80,228,12,134,84,231,3,18,193,146,158,232,173,33,209,88,149,166,41,156,75,99,12,186,143,203,121,28,21,80,88,7,174,173,4,181,32,94,15,108,12,229,140,74,96,218,86,201,162,69,186,209,227,92,136,176,18,11,153,163,226,162,243,39,107,114,141,66,158,226,157,179,197,249,58,144,134,110,207,55,168,232,85,234,48,211,23,159,152,54,175,21,103,144,197,83,110,99,193,25,108,247,242,178,89,228,93,218,242,232,236,148,156,50,121,111,30,99,199,246,253,166,33,49,113,75,42,224,253,144,112,215,9,1,25,228,74,86,93,216,182,161,205,188,99,213,208,50,28,77,150,214,193,205,232,97,69,248,83,23,129,7,100,94,201,157,220,251,109,129,11,232,204,53,157,211,96,192,194,129,126,56,196,28,30,22,247,25,148,164,221,112,210,46,124,237,131,148,135,177,162,31,114,88,40,176,69,156,120,88,53,174,65,212,133,39,191,18,6,117,63,218,184,55,107,162,221,164,161,126,140,186,78,58,255,126,24,246,149,254,31,49,78,13,56,39,255,211,20,76,110,63,146,29,234,221,72,81,56,230,124,157,233,182,225,188,29,225,93,254,27,210,177,135,109,119,53,198,109,118,61,25,115,171,215,55,48,85,192,198,93,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("394b7098-d52a-4248-b5d6-5a4098ccf4ac"));
		}

		#endregion

	}

	#endregion

}

