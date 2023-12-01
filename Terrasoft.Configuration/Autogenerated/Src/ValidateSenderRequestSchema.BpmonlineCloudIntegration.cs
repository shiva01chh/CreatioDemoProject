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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,77,79,194,64,16,61,75,194,127,152,212,131,122,105,239,80,57,136,132,152,136,33,148,120,49,30,150,50,224,38,219,93,156,217,146,32,241,191,59,221,2,134,138,95,167,102,102,222,123,157,247,102,173,42,144,87,42,71,152,34,145,98,183,240,113,223,217,133,94,150,164,188,118,54,238,15,178,145,155,163,225,118,107,219,110,157,149,172,237,18,178,13,123,44,4,105,12,230,21,140,227,33,90,36,157,119,155,152,73,105,189,46,48,206,100,170,140,126,11,170,130,18,220,57,225,82,10,232,27,197,220,129,71,25,207,149,199,12,237,28,105,130,175,37,178,15,192,36,73,32,229,178,40,20,109,122,187,58,144,96,225,8,168,70,130,119,176,222,73,0,7,141,11,6,44,148,54,28,239,69,146,134,74,202,136,202,176,131,156,112,113,29,253,26,66,124,163,88,22,164,181,206,113,183,97,4,73,165,246,116,171,188,18,150,39,149,251,103,105,172,202,153,209,57,228,97,207,147,222,160,3,95,229,132,185,13,166,15,241,140,201,173,144,188,70,201,104,28,68,235,121,51,149,208,24,162,103,144,80,184,250,250,23,172,3,0,163,217,199,7,82,210,100,165,18,92,137,135,114,250,29,239,19,22,236,142,176,152,33,93,62,200,35,130,107,136,2,229,94,24,209,85,21,192,62,129,187,129,45,11,36,53,51,152,178,39,121,27,61,24,236,161,176,133,37,250,110,181,111,23,222,43,214,223,173,13,178,49,88,249,247,255,140,157,96,253,108,107,69,110,173,229,106,85,125,236,172,118,83,29,232,0,104,250,9,135,148,163,215,183,12,117,221,61,110,134,94,171,245,1,176,37,116,76,143,3,0,0 };
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

