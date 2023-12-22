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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,77,79,194,64,16,61,75,194,127,152,224,65,189,180,119,190,14,34,33,38,98,8,37,94,140,135,165,12,184,201,118,23,103,182,36,72,252,239,78,183,80,165,226,87,47,205,204,190,247,118,222,155,181,42,67,94,171,20,97,134,68,138,221,210,71,3,103,151,122,149,147,242,218,217,104,48,76,198,110,129,134,155,141,93,179,113,150,179,182,43,72,182,236,49,19,164,49,152,22,48,142,70,104,145,116,218,169,99,166,185,245,58,195,40,145,83,101,244,107,80,21,148,224,206,9,87,82,192,192,40,230,54,60,200,241,66,121,76,208,46,144,166,248,146,35,251,0,140,227,24,186,156,103,153,162,109,127,95,7,18,44,29,1,149,72,240,14,54,123,9,224,160,113,193,128,153,210,134,163,131,72,92,83,233,50,162,50,236,32,37,92,246,90,191,134,16,93,43,150,1,105,163,83,220,79,216,130,184,80,123,188,81,94,9,203,147,74,253,147,52,214,249,220,232,20,210,48,231,73,111,208,134,175,114,194,220,5,211,85,60,19,114,107,36,175,81,50,154,4,209,242,188,158,74,104,140,208,51,72,40,92,252,253,51,150,1,128,209,236,163,138,20,215,89,93,9,46,199,170,156,125,199,251,128,5,187,99,204,230,72,151,247,242,136,160,7,173,64,185,19,70,235,170,8,224,144,192,237,208,230,25,146,154,27,236,178,39,121,27,125,24,30,160,176,131,21,250,78,49,111,7,222,10,214,223,173,13,147,9,88,185,251,127,198,78,176,126,182,181,38,183,209,178,181,162,62,118,86,186,41,22,84,1,234,126,194,34,101,233,229,46,67,93,118,143,155,161,247,233,123,7,215,16,227,76,152,3,0,0 };
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

