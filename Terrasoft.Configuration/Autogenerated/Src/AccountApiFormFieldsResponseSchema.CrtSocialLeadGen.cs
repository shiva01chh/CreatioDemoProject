namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountApiFormFieldsResponseSchema

	/// <exclude/>
	public class AccountApiFormFieldsResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountApiFormFieldsResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountApiFormFieldsResponseSchema(AccountApiFormFieldsResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b2106199-c783-417b-8ee7-13bea17b63c5");
			Name = "AccountApiFormFieldsResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,84,193,78,227,48,16,61,23,137,127,176,224,178,123,105,239,128,34,85,89,177,203,138,93,194,210,27,218,131,177,167,173,165,196,206,142,29,160,170,248,119,156,196,77,147,116,218,141,80,37,114,136,148,153,231,55,111,94,198,195,52,207,192,230,92,0,155,1,34,183,102,238,198,177,209,115,181,40,144,59,101,244,248,193,8,197,211,91,224,242,59,232,211,147,245,233,201,168,176,74,47,216,111,120,113,70,87,39,126,90,163,47,155,196,195,202,58,200,60,77,154,130,40,57,236,216,31,5,84,194,99,60,234,28,97,225,163,44,78,185,181,23,108,42,132,41,180,155,230,234,218,96,118,173,32,149,246,143,23,229,207,65,133,159,76,38,236,202,22,89,198,113,21,133,239,111,179,59,230,150,220,49,9,86,160,122,66,96,211,228,134,97,56,199,230,104,50,198,107,102,102,1,159,149,128,241,134,107,210,34,203,139,167,84,9,38,74,45,7,165,176,11,214,177,194,199,93,130,230,89,73,192,173,220,209,186,146,220,239,241,135,146,18,116,69,88,231,59,101,59,217,209,134,162,225,240,85,114,64,167,192,19,37,213,185,0,120,44,125,15,217,213,151,179,242,95,158,125,253,91,165,2,191,117,88,253,42,159,97,107,182,0,119,233,205,240,175,55,154,129,107,251,2,72,115,76,171,28,201,114,14,90,214,90,235,64,136,247,195,61,79,226,210,49,237,8,63,154,204,199,189,80,178,215,133,242,115,112,35,135,152,32,234,234,51,120,117,180,19,241,22,112,76,59,10,235,76,86,146,222,23,126,180,26,88,215,25,2,116,68,147,66,131,195,124,250,23,20,236,55,234,190,133,56,186,83,191,138,212,169,60,133,120,105,252,221,254,175,103,251,224,159,121,221,62,205,193,4,65,194,92,105,144,7,124,163,64,31,119,43,111,216,170,61,71,183,155,116,65,199,232,120,159,190,158,188,229,118,5,219,160,45,72,187,85,214,93,181,54,116,212,94,215,150,146,72,239,19,138,54,108,146,104,179,82,6,209,237,172,0,146,121,7,21,17,203,99,120,61,250,250,236,175,76,227,163,131,151,113,136,154,124,103,40,41,13,187,163,27,17,227,76,214,235,205,81,29,237,6,125,172,253,188,3,138,223,93,169,68,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b2106199-c783-417b-8ee7-13bea17b63c5"));
		}

		#endregion

	}

	#endregion

}

