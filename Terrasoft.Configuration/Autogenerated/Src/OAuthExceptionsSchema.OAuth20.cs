namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OAuthExceptionsSchema

	/// <exclude/>
	public class OAuthExceptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OAuthExceptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OAuthExceptionsSchema(OAuthExceptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fc203001-613e-494f-8857-3cb5ad94462e");
			Name = "OAuthExceptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("49af2168-effb-4b7f-bce2-28e45d430d96");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,91,75,195,48,20,126,238,192,255,16,216,203,6,163,21,31,167,8,99,248,176,39,101,243,77,124,200,178,211,54,208,38,37,23,182,57,252,239,166,233,197,218,238,34,181,69,237,75,57,201,201,119,201,201,199,112,12,50,193,4,208,51,8,129,37,247,149,59,231,204,167,129,22,88,81,206,220,199,153,86,225,205,245,213,224,112,53,112,180,164,44,64,171,189,84,16,223,214,106,119,169,153,162,49,184,43,16,20,71,244,205,158,55,93,166,111,40,32,48,5,154,71,88,202,41,178,152,75,144,92,11,2,15,59,2,73,218,106,59,61,207,67,119,82,199,49,22,251,251,188,46,59,144,10,5,223,50,180,13,105,4,72,228,0,40,5,55,10,132,209,226,22,16,94,5,227,165,84,180,142,224,213,44,36,122,29,81,130,72,170,230,132,24,52,69,21,97,206,193,138,251,244,193,153,84,66,19,197,133,177,243,100,225,178,14,75,78,89,104,24,213,134,19,47,229,47,248,142,51,141,198,40,189,90,231,189,53,128,145,146,142,193,76,82,226,0,198,70,250,26,75,24,149,117,167,240,147,202,56,40,99,32,202,178,78,60,105,236,87,133,12,129,109,178,219,60,123,181,130,43,32,10,54,231,212,23,61,167,12,124,121,144,11,230,115,35,204,231,19,180,82,2,112,108,188,25,78,5,59,133,72,246,31,167,168,142,147,187,201,122,139,173,147,30,242,181,154,173,115,15,127,193,230,17,5,166,90,7,128,216,227,8,39,137,153,158,53,215,101,20,26,242,122,143,68,131,113,100,39,209,234,249,54,177,46,164,164,55,166,31,4,166,174,169,247,204,52,189,116,153,157,11,118,190,29,160,76,227,44,73,254,88,114,154,186,122,139,76,147,170,69,86,142,128,116,29,146,139,20,255,33,29,71,76,252,114,44,204,90,245,251,0,80,183,167,172,198,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fc203001-613e-494f-8857-3cb5ad94462e"));
		}

		#endregion

	}

	#endregion

}

