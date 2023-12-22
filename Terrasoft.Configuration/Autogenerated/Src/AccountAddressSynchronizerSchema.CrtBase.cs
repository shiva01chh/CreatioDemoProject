namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountAddressSynchronizerSchema

	/// <exclude/>
	public class AccountAddressSynchronizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountAddressSynchronizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountAddressSynchronizerSchema(AccountAddressSynchronizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("74191a0d-e4ee-4056-8a11-3e962a99a246");
			Name = "AccountAddressSynchronizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,83,193,110,219,48,12,61,187,64,255,129,72,47,14,16,56,247,164,43,208,101,65,176,67,139,0,217,62,64,149,153,68,128,45,121,148,148,34,27,250,239,163,108,57,177,3,39,27,6,204,55,146,143,239,61,146,178,22,37,218,74,72,132,111,72,36,172,217,186,108,97,244,86,237,60,9,167,140,190,191,251,117,127,151,120,171,244,14,150,218,41,119,220,28,181,220,147,209,234,103,13,152,159,202,155,163,117,88,114,123,81,160,12,37,155,173,80,35,41,121,198,116,85,8,175,229,179,90,73,161,101,0,67,30,8,119,76,7,139,66,88,59,131,103,41,141,215,238,57,207,9,173,61,219,65,170,209,211,233,20,30,173,47,75,65,199,167,24,175,201,28,84,142,22,74,116,123,147,91,216,26,2,123,234,12,14,68,195,10,162,161,133,119,229,246,109,50,107,105,167,29,222,202,191,21,74,130,12,166,110,120,130,25,124,22,22,7,221,38,97,183,231,241,120,99,142,188,52,196,67,174,107,246,122,160,86,233,186,70,250,221,34,113,187,110,246,14,190,23,78,226,225,218,209,154,104,12,179,192,157,188,177,185,244,178,161,135,156,192,40,74,143,198,80,59,254,104,124,61,160,206,27,239,49,142,131,188,52,75,158,133,181,59,166,196,60,206,209,134,96,14,124,111,62,8,124,61,191,150,199,139,135,197,21,95,234,23,81,85,124,158,39,88,161,187,5,176,105,244,150,12,162,22,166,172,4,191,232,112,118,71,140,95,254,240,162,232,100,63,193,69,38,62,25,202,130,240,80,75,58,158,215,122,7,65,16,150,216,183,195,132,33,153,253,217,246,252,116,134,126,37,227,67,167,26,223,225,86,127,156,57,217,24,79,50,18,188,242,63,205,242,163,213,122,243,58,154,52,245,47,104,157,210,157,254,33,80,111,29,131,107,170,113,31,255,213,242,242,111,44,47,255,209,50,161,243,164,7,206,53,191,242,172,99,174,155,226,76,247,251,13,220,21,136,24,66,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("74191a0d-e4ee-4056-8a11-3e962a99a246"));
		}

		#endregion

	}

	#endregion

}

