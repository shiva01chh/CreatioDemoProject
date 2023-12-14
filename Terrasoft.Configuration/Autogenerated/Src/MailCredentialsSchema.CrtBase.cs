namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailCredentialsSchema

	/// <exclude/>
	public class MailCredentialsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailCredentialsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailCredentialsSchema(MailCredentialsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9fb91463-07a1-4af3-bf11-902a4739cfa3");
			Name = "MailCredentials";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,193,10,194,48,12,134,207,14,246,14,1,239,62,128,158,134,8,122,16,6,155,15,80,215,56,11,93,51,146,236,32,226,187,219,110,34,42,168,61,4,242,231,235,159,240,7,211,161,244,166,65,168,145,217,8,157,116,177,55,206,67,158,93,243,44,207,102,115,198,214,81,128,181,55,34,75,72,179,53,163,197,160,206,120,25,145,126,56,122,215,64,147,136,79,0,150,240,218,69,122,178,125,250,150,76,61,178,58,140,230,229,104,52,205,31,166,162,236,66,11,91,18,133,43,180,168,43,144,84,110,47,140,11,10,37,241,119,224,72,228,225,32,88,137,255,203,236,172,199,159,155,106,215,33,13,223,151,61,46,174,48,88,228,77,23,227,40,172,101,140,209,252,92,93,169,97,173,253,31,106,39,69,160,112,233,104,144,98,208,115,138,181,49,154,114,252,248,54,70,28,79,152,82,30,251,73,125,23,163,150,222,29,175,132,163,156,6,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9fb91463-07a1-4af3-bf11-902a4739cfa3"));
		}

		#endregion

	}

	#endregion

}

