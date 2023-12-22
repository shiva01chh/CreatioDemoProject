namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidateSenderDomainRequestSchema

	/// <exclude/>
	public class ValidateSenderDomainRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidateSenderDomainRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidateSenderDomainRequestSchema(ValidateSenderDomainRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3f9ce81e-a5d7-4bb1-aa16-62e6c9485129");
			Name = "ValidateSenderDomainRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,193,110,194,48,12,134,207,32,237,29,44,184,108,151,246,62,182,93,0,161,29,152,16,157,118,65,28,66,235,118,145,218,164,179,29,36,134,246,238,75,83,64,5,161,73,172,151,212,142,253,231,243,159,24,85,33,215,42,69,120,71,34,197,54,151,104,108,77,174,11,71,74,180,53,209,120,154,204,109,134,37,223,245,247,119,253,158,99,109,10,72,118,44,88,141,46,226,104,233,140,232,10,163,4,73,171,82,127,7,5,95,229,235,134,132,133,15,96,92,42,230,71,248,240,219,153,18,76,208,100,72,19,91,41,109,150,248,229,144,37,148,199,113,12,79,236,170,74,209,238,229,16,135,86,200,45,1,181,149,32,22,182,7,33,224,160,4,89,144,138,142,18,113,71,99,53,81,162,252,112,66,42,149,181,79,212,110,83,234,20,210,160,251,39,81,111,31,168,78,83,44,200,214,72,162,209,143,178,8,42,237,254,37,118,72,204,80,24,60,53,55,171,124,34,160,215,46,65,103,232,221,202,53,82,116,106,237,226,182,188,115,172,54,72,247,111,254,158,224,25,6,161,245,53,27,60,52,252,199,1,102,78,103,48,109,119,96,15,5,202,168,57,108,4,63,183,80,157,25,200,55,48,113,199,49,62,39,99,33,255,60,86,107,232,186,202,255,103,52,205,145,54,15,255,53,217,173,247,240,22,247,142,45,77,124,13,180,185,215,83,193,53,202,161,31,163,125,2,33,110,179,231,201,144,235,124,191,240,252,65,36,98,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3f9ce81e-a5d7-4bb1-aa16-62e6c9485129"));
		}

		#endregion

	}

	#endregion

}

