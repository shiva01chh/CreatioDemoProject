namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountApiPredefinedFieldsResponseSchema

	/// <exclude/>
	public class AccountApiPredefinedFieldsResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountApiPredefinedFieldsResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountApiPredefinedFieldsResponseSchema(AccountApiPredefinedFieldsResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1521232e-cc77-4fda-b150-54054f3f6789");
			Name = "AccountApiPredefinedFieldsResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,65,79,194,64,16,133,207,37,225,63,76,240,162,151,246,14,132,132,96,52,26,162,40,220,140,135,101,59,173,155,180,187,205,204,22,67,136,255,221,109,187,5,90,49,218,195,38,125,59,239,205,55,179,90,228,200,133,144,8,27,36,18,108,18,27,46,140,78,84,90,146,176,202,232,112,109,164,18,217,18,69,124,143,122,56,56,12,7,65,201,74,167,240,132,159,214,232,218,241,200,70,79,142,23,235,61,91,204,93,76,150,161,172,50,56,116,86,36,37,93,141,171,186,34,76,157,10,139,76,48,143,97,46,165,41,181,157,23,106,69,24,99,162,52,198,119,10,179,152,95,29,154,115,99,237,138,162,8,166,92,230,185,160,253,204,255,223,110,158,193,126,8,11,49,178,36,181,37,132,249,234,1,200,251,32,33,147,131,104,242,129,145,118,74,98,216,102,69,103,97,69,185,205,148,4,89,17,253,3,8,198,208,89,139,211,237,138,204,78,197,72,39,232,224,80,131,247,231,61,133,190,148,206,231,110,154,178,14,195,165,162,160,13,60,38,186,158,5,146,85,88,197,214,118,95,240,86,189,136,191,221,95,143,138,238,28,163,155,247,186,202,119,100,75,213,179,245,134,133,3,164,104,39,110,109,238,248,106,27,163,142,155,222,141,224,245,190,252,23,223,175,120,237,176,236,17,61,225,82,177,157,254,92,201,236,194,154,248,18,119,143,175,81,187,162,211,206,191,111,161,167,191,220,24,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1521232e-cc77-4fda-b150-54054f3f6789"));
		}

		#endregion

	}

	#endregion

}

