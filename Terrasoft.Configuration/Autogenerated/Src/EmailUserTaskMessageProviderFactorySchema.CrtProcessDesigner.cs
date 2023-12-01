namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailUserTaskMessageProviderFactorySchema

	/// <exclude/>
	public class EmailUserTaskMessageProviderFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailUserTaskMessageProviderFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailUserTaskMessageProviderFactorySchema(EmailUserTaskMessageProviderFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("31e7a4a6-b0cf-4c1c-8657-06e2b3d26b6a");
			Name = "EmailUserTaskMessageProviderFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("da7de29a-d2b3-4248-bf8e-b7a592dc81f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,77,110,194,48,16,133,215,65,226,14,35,117,19,54,57,0,236,74,105,197,130,10,169,233,1,92,103,8,86,19,59,154,153,148,70,136,187,215,113,18,4,105,69,201,194,202,252,124,239,141,60,182,170,68,174,148,70,72,145,72,177,219,73,178,116,132,201,150,156,70,102,31,216,157,201,107,82,98,156,157,78,142,211,73,84,179,177,57,188,53,44,88,46,206,241,37,127,129,12,66,79,200,38,183,72,30,240,200,3,97,238,139,176,44,20,243,28,86,165,50,197,59,35,165,138,63,55,190,91,229,232,185,47,147,33,61,43,45,142,154,128,85,245,71,97,52,176,120,105,13,186,133,239,99,163,99,224,207,190,27,148,189,203,188,243,54,40,118,197,107,245,245,45,97,120,65,9,245,81,62,14,201,20,203,170,80,130,3,12,117,255,51,131,246,254,162,136,15,70,244,30,226,248,209,101,205,208,157,54,21,206,134,206,228,87,165,71,35,173,24,97,92,77,174,124,231,93,103,68,40,53,89,176,120,128,63,231,26,15,127,30,115,113,203,170,95,232,127,102,163,182,123,61,51,220,169,186,144,65,85,246,228,14,65,244,213,201,218,75,97,137,86,48,91,125,107,172,218,247,21,247,224,169,61,79,253,150,209,102,221,162,67,220,101,175,147,33,231,191,31,110,26,171,181,0,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("31e7a4a6-b0cf-4c1c-8657-06e2b3d26b6a"));
		}

		#endregion

	}

	#endregion

}

