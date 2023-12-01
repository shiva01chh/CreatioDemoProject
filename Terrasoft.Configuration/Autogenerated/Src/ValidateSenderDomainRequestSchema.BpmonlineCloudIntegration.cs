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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,77,107,194,64,16,134,207,6,252,15,131,94,218,75,114,175,109,47,42,210,131,69,76,233,69,60,172,201,36,93,72,118,211,153,137,96,165,255,189,155,141,74,20,17,236,41,153,175,119,159,121,119,141,42,145,43,149,32,124,32,145,98,155,73,56,182,38,211,121,77,74,180,53,225,120,26,207,109,138,5,247,131,125,63,232,213,172,77,14,241,142,5,203,209,69,28,46,107,35,186,196,48,70,210,170,208,63,94,193,117,185,190,33,97,238,2,24,23,138,249,9,62,93,57,85,130,49,154,20,105,98,75,165,205,18,191,107,100,241,237,81,20,193,51,215,101,169,104,247,122,136,253,40,100,150,128,218,78,16,11,219,131,16,176,87,130,212,75,133,71,137,168,163,177,154,40,81,110,57,33,149,200,218,37,170,122,83,232,4,18,175,123,147,168,183,247,84,167,45,22,100,43,36,209,232,86,89,120,149,182,126,137,237,19,51,20,6,71,205,205,87,190,16,208,105,23,160,83,116,110,101,26,41,60,141,118,113,91,222,57,150,27,164,135,119,119,79,240,2,3,63,250,150,14,30,27,254,227,2,179,90,167,48,109,43,176,135,28,101,212,28,54,130,223,123,168,206,12,228,59,152,184,227,24,159,147,177,144,123,30,171,53,116,93,229,255,51,154,230,72,155,249,255,138,236,214,121,120,143,123,199,145,38,190,6,218,220,235,169,225,26,229,208,173,209,62,1,31,183,217,243,164,207,5,193,31,19,70,221,82,89,3,0,0 };
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

