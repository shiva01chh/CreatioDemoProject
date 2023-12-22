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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,146,65,107,194,64,16,133,207,10,254,135,193,94,218,75,188,87,235,69,139,8,181,72,82,122,41,61,172,201,196,46,36,187,97,102,35,88,233,127,239,236,38,138,164,210,66,15,165,185,132,125,251,118,230,123,59,107,84,137,92,169,20,225,9,137,20,219,220,69,51,107,114,189,173,73,57,109,77,52,187,79,86,54,195,130,7,253,195,160,223,171,89,155,45,36,123,118,88,138,179,40,48,245,54,142,22,104,144,116,58,238,122,226,218,56,93,98,148,200,174,42,244,123,168,42,46,241,93,17,110,101,1,179,66,49,223,194,179,108,103,202,97,130,38,67,154,219,82,105,19,11,157,84,199,224,31,141,70,48,225,186,44,21,237,167,237,58,198,138,144,209,56,6,106,189,96,115,112,111,8,140,180,211,146,44,183,36,123,142,52,238,60,87,22,10,115,144,229,96,230,53,20,169,136,142,45,70,103,61,170,122,83,232,20,82,143,248,3,97,239,16,40,79,177,214,100,43,36,167,81,178,173,67,153,102,191,27,35,8,11,148,4,129,72,254,158,190,193,140,78,7,206,161,122,47,115,229,212,10,203,13,210,245,163,140,16,238,96,200,103,80,75,147,91,30,222,188,122,111,155,224,65,179,155,36,29,207,20,186,10,195,1,182,232,198,30,100,12,31,109,34,49,53,161,194,186,81,59,98,103,152,221,186,255,99,128,95,169,254,112,104,45,9,75,16,33,110,32,46,221,246,197,86,49,186,154,36,180,163,26,65,31,239,199,167,105,155,130,102,216,249,247,249,125,247,141,181,5,44,57,188,228,95,142,58,104,103,223,39,198,51,117,35,68,4,0,0 };
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

