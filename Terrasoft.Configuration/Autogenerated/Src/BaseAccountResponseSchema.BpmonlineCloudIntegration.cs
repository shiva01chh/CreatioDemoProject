namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseAccountResponseSchema

	/// <exclude/>
	public class BaseAccountResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseAccountResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseAccountResponseSchema(BaseAccountResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("70d366b9-fe0c-4c17-99b3-f6cd244e3e7c");
			Name = "BaseAccountResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,80,203,106,195,48,16,60,199,224,127,88,210,187,125,239,35,208,134,28,11,161,244,7,84,121,173,8,226,149,217,149,9,33,244,223,187,146,236,96,74,116,16,204,104,118,52,59,64,102,64,25,141,69,248,70,102,35,161,143,205,62,80,239,221,196,38,250,64,117,117,171,171,186,218,60,49,58,133,176,63,27,145,103,248,48,130,239,214,134,137,226,151,26,4,18,204,178,182,109,225,85,166,97,48,124,221,205,120,17,128,77,179,208,7,86,9,42,100,236,223,182,15,156,182,237,14,12,117,224,233,132,236,35,118,101,18,165,89,126,104,87,95,140,211,207,217,219,217,252,97,174,77,89,225,190,195,145,195,136,28,61,234,34,199,60,93,222,255,135,207,132,182,17,141,39,1,237,71,147,107,93,98,28,194,229,132,4,201,38,183,4,94,128,66,4,153,172,85,65,115,119,91,7,93,146,74,100,79,14,14,201,239,115,182,187,129,195,248,2,146,174,223,57,45,82,87,2,103,92,216,53,169,76,58,127,21,40,139,96,196,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("70d366b9-fe0c-4c17-99b3-f6cd244e3e7c"));
		}

		#endregion

	}

	#endregion

}

