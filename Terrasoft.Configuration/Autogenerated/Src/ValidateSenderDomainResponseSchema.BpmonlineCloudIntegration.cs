namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidateSenderDomainResponseSchema

	/// <exclude/>
	public class ValidateSenderDomainResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidateSenderDomainResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidateSenderDomainResponseSchema(ValidateSenderDomainResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("871f1b8a-e82c-41c2-a927-53b14043304e");
			Name = "ValidateSenderDomainResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,146,65,107,194,64,16,133,207,6,252,15,131,189,180,151,120,175,214,139,22,17,106,17,83,122,41,61,172,201,196,46,36,187,97,102,35,88,233,127,239,236,38,138,164,210,66,15,165,167,176,111,94,102,190,183,179,70,149,200,149,74,17,158,144,72,177,205,93,60,181,38,215,219,154,148,211,214,196,211,251,100,105,51,44,184,31,29,250,81,175,102,109,182,144,236,217,97,41,206,162,192,212,219,56,158,163,65,210,233,168,235,89,215,198,233,18,227,68,170,170,208,239,161,171,184,196,119,69,184,149,3,76,11,197,124,11,207,82,206,148,195,4,77,134,52,179,165,210,102,45,116,210,29,131,127,56,28,194,152,235,178,84,180,159,180,231,53,86,132,140,198,49,80,235,5,155,131,123,67,96,164,157,150,100,185,37,169,57,210,184,243,92,89,104,204,65,150,31,51,175,161,72,69,124,28,49,60,155,81,213,155,66,167,144,122,196,31,8,123,135,64,121,138,181,34,91,33,57,141,146,109,21,218,52,245,110,140,32,204,81,18,4,34,249,122,250,6,51,62,253,112,14,213,123,153,41,167,150,88,110,144,174,31,101,133,112,7,3,62,131,90,152,220,242,224,230,213,123,219,4,15,154,221,56,233,120,38,208,85,24,14,176,69,55,242,32,35,248,104,19,137,169,9,21,206,141,218,17,59,203,236,246,253,31,11,252,74,245,135,75,107,73,88,130,8,113,3,113,233,182,47,142,90,163,171,73,66,59,170,17,244,241,126,124,154,118,40,104,134,157,127,159,223,79,223,88,91,192,130,195,75,254,229,170,131,22,69,159,168,139,84,44,59,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("871f1b8a-e82c-41c2-a927-53b14043304e"));
		}

		#endregion

	}

	#endregion

}

