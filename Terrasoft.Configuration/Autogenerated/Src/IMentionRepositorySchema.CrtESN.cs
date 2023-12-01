namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMentionRepositorySchema

	/// <exclude/>
	public class IMentionRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMentionRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMentionRepositorySchema(IMentionRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4e27ff36-28e0-a0f4-308c-766147bea603");
			Name = "IMentionRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f0db0304-dc6c-40c0-a3bb-97ab97632500");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,82,193,110,194,48,12,61,131,180,127,176,202,101,147,166,246,206,74,37,54,33,196,1,137,65,127,32,20,23,186,181,73,103,167,154,42,180,127,159,211,208,194,208,114,203,203,243,123,47,182,181,170,144,107,149,33,164,72,164,216,228,54,124,51,58,47,142,13,41,91,24,253,48,62,63,140,71,13,23,250,8,187,150,45,86,97,122,34,84,7,1,194,84,241,39,191,12,239,87,137,101,105,246,170,220,161,162,236,20,174,180,69,202,197,195,81,133,60,33,60,138,50,12,248,20,86,139,221,26,181,243,123,111,144,218,215,166,40,15,72,29,59,138,34,136,185,169,42,69,109,114,185,95,184,64,88,27,46,172,161,22,138,94,236,217,161,132,44,20,152,111,86,144,27,130,35,90,235,2,154,253,7,102,150,59,172,242,26,97,111,17,221,120,212,205,190,44,178,171,38,172,46,142,219,193,80,88,231,46,223,240,157,53,218,147,57,240,20,54,93,181,127,188,79,223,1,75,180,80,22,108,193,228,144,138,11,91,165,165,59,144,147,169,0,75,197,86,204,217,55,111,16,137,238,85,98,219,214,88,43,82,21,104,153,226,44,72,131,36,21,200,169,250,143,250,127,170,218,141,42,142,6,250,85,225,182,250,203,53,62,72,98,70,132,140,48,159,5,11,159,164,155,72,16,37,67,80,209,186,211,33,180,13,105,254,167,120,43,219,101,52,227,93,125,95,224,20,220,18,197,126,85,122,118,156,38,137,235,210,156,91,157,201,229,177,127,150,144,210,182,46,234,19,124,159,144,100,111,97,10,153,152,93,150,107,52,65,125,240,19,113,119,65,126,252,210,253,129,5,147,243,11,20,171,200,161,253,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4e27ff36-28e0-a0f4-308c-766147bea603"));
		}

		#endregion

	}

	#endregion

}

