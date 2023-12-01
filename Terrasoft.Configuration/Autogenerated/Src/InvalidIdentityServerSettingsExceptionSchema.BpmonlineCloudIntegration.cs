namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: InvalidIdentityServerSettingsExceptionSchema

	/// <exclude/>
	public class InvalidIdentityServerSettingsExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public InvalidIdentityServerSettingsExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public InvalidIdentityServerSettingsExceptionSchema(InvalidIdentityServerSettingsExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("45eac23e-2e39-4284-bb79-03c123cf30e3");
			Name = "InvalidIdentityServerSettingsException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,82,205,106,194,64,16,62,43,248,14,131,94,20,172,15,160,216,67,131,135,28,10,66,122,43,69,214,100,12,3,235,110,152,221,72,173,248,238,29,179,27,181,182,7,145,230,148,249,38,243,253,17,163,182,232,42,149,35,188,33,179,114,118,227,39,137,53,27,42,107,86,158,172,153,188,84,91,107,52,25,76,180,173,139,212,120,44,195,166,215,61,244,186,157,218,145,41,33,219,59,143,219,89,175,43,200,128,177,148,53,36,90,57,55,133,212,236,148,166,34,45,208,120,242,251,12,121,135,156,161,247,114,231,22,159,57,86,129,76,46,223,101,73,242,241,151,90,107,28,142,62,4,170,234,181,166,28,242,19,215,157,84,48,133,43,218,206,201,228,197,147,53,206,115,157,123,203,98,109,217,144,55,210,173,208,125,18,195,17,52,180,199,71,110,197,192,169,50,233,221,169,18,71,98,119,173,28,14,207,243,127,49,143,47,53,0,25,131,124,30,111,53,199,191,246,215,30,6,104,138,80,95,156,99,151,75,182,21,178,39,252,187,73,43,22,153,10,132,232,234,53,104,193,252,25,250,109,16,8,73,192,197,40,64,14,140,245,208,164,133,39,193,155,117,205,122,44,191,0,201,81,90,128,229,248,158,97,206,232,251,179,31,178,81,109,193,108,57,177,34,127,128,18,253,12,142,48,135,62,69,221,21,133,66,87,173,112,75,114,147,53,52,112,13,10,34,207,55,213,182,158,155,54,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45eac23e-2e39-4284-bb79-03c123cf30e3"));
		}

		#endregion

	}

	#endregion

}

