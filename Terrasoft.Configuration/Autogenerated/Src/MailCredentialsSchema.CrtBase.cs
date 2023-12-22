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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,193,170,194,64,12,69,215,22,250,15,1,247,126,128,174,138,60,208,133,80,104,253,128,177,19,235,192,116,82,146,116,33,229,253,251,155,105,229,81,5,117,22,129,220,156,185,9,55,152,14,165,55,13,66,141,204,70,232,170,155,147,113,30,242,108,204,179,60,91,173,25,91,71,1,246,222,136,108,33,205,246,140,22,131,58,227,101,66,250,225,226,93,3,77,34,94,1,216,194,178,139,244,108,251,239,91,50,245,200,234,48,154,151,147,209,60,127,152,138,178,11,45,28,72,20,70,104,81,119,32,169,252,46,24,23,20,74,226,247,192,133,200,195,89,176,18,255,149,57,90,143,31,55,213,174,67,26,222,47,123,92,92,97,176,200,63,93,140,163,176,150,49,70,243,113,117,165,134,181,246,95,168,163,20,129,194,189,163,65,138,65,111,41,214,198,104,202,241,229,219,20,113,60,97,78,121,234,103,245,89,140,218,242,253,1,158,81,227,71,14,2,0,0 };
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

