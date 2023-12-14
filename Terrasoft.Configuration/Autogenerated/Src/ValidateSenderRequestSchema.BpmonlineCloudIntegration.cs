namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidateSenderRequestSchema

	/// <exclude/>
	public class ValidateSenderRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidateSenderRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidateSenderRequestSchema(ValidateSenderRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("efc01930-33c9-4ec2-8ddf-662cdd8b0a08");
			Name = "ValidateSenderRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,77,79,194,64,16,61,75,194,127,152,224,65,189,180,119,64,14,98,67,76,196,16,74,188,24,15,75,25,234,38,219,93,156,217,146,32,241,191,59,221,2,134,138,95,189,52,51,251,222,219,121,111,214,170,2,121,165,50,132,25,18,41,118,75,31,13,157,93,234,188,36,229,181,179,209,48,73,199,110,129,134,219,173,109,187,117,86,178,182,57,164,27,246,88,8,210,24,204,42,24,71,35,180,72,58,235,53,49,211,210,122,93,96,148,202,169,50,250,45,168,10,74,112,231,132,185,20,48,52,138,185,11,143,114,188,80,30,83,180,11,164,41,190,150,200,62,0,227,56,134,62,151,69,161,104,51,216,213,129,4,75,71,64,53,18,188,131,245,78,2,56,104,92,48,96,161,180,225,104,47,18,55,84,250,140,168,12,59,200,8,151,215,157,95,67,136,110,20,203,128,180,214,25,238,38,236,64,92,169,61,221,42,175,132,229,73,101,254,89,26,171,114,110,116,6,89,152,243,164,55,232,194,87,57,97,110,131,233,67,60,19,114,43,36,175,81,50,154,4,209,250,188,153,74,104,140,208,51,72,40,92,253,253,11,214,1,128,209,236,163,3,41,110,178,250,18,92,137,135,114,246,29,239,19,22,236,142,177,152,35,93,62,200,35,130,107,232,4,202,189,48,58,87,85,0,251,4,238,18,91,22,72,106,110,176,207,158,228,109,12,32,217,67,97,11,57,250,94,53,111,15,222,43,214,223,173,37,233,4,172,220,253,63,99,39,88,63,219,90,145,91,107,217,90,85,31,59,171,221,84,11,58,0,154,126,194,34,101,233,245,46,67,93,119,143,155,161,39,223,7,58,193,250,249,144,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("efc01930-33c9-4ec2-8ddf-662cdd8b0a08"));
		}

		#endregion

	}

	#endregion

}

