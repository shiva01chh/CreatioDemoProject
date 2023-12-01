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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,83,205,107,194,48,20,63,87,216,255,16,240,162,32,237,216,209,141,129,200,14,158,54,116,183,177,67,140,175,26,104,147,146,15,212,201,254,247,189,166,181,235,172,31,163,107,217,214,75,121,201,203,239,35,47,63,65,99,208,9,101,64,158,65,41,170,101,104,252,177,20,33,95,90,69,13,151,194,127,28,89,179,186,185,190,234,236,174,58,158,213,92,44,201,108,171,13,196,183,7,181,63,181,194,240,24,252,25,40,78,35,254,230,206,99,23,246,117,21,44,177,32,227,136,106,61,36,14,115,10,90,90,197,224,97,195,32,73,91,93,103,16,4,228,78,219,56,166,106,123,159,215,69,7,49,43,37,215,130,172,87,60,2,162,114,0,146,130,163,2,133,90,252,61,68,80,194,120,41,20,205,35,120,197,133,196,206,35,206,8,75,213,156,16,67,134,164,36,204,219,57,113,159,62,164,208,70,89,102,164,66,59,79,14,46,235,112,228,92,172,144,209,44,36,11,82,254,61,223,113,166,94,159,164,87,235,189,215,6,64,41,233,24,112,146,154,46,161,143,210,231,84,67,175,168,27,133,31,148,198,193,133,0,85,148,135,196,131,202,126,89,72,23,196,34,187,205,179,87,171,164,1,102,96,113,78,253,190,231,148,129,47,15,114,34,66,137,194,66,57,32,51,163,128,198,232,13,57,13,108,12,97,217,191,159,162,122,94,238,38,235,221,111,157,244,144,175,29,216,58,247,240,39,98,28,113,16,166,118,0,152,59,78,104,146,224,244,156,185,38,163,80,145,215,122,36,42,140,61,55,137,90,207,183,138,117,33,37,173,49,253,32,48,135,154,90,207,76,213,75,147,217,185,96,231,219,1,202,52,142,146,228,143,37,167,170,171,181,200,84,169,106,100,229,8,72,211,33,185,72,241,31,210,113,196,196,47,199,2,215,240,251,0,163,134,106,128,189,9,0,0 };
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

