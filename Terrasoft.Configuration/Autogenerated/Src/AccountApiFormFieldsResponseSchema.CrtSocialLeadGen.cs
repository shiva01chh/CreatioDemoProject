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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,84,193,110,219,48,12,61,167,64,255,129,104,47,219,37,185,183,133,129,192,67,183,14,221,230,174,185,21,59,168,18,147,8,176,37,79,146,219,5,193,254,125,178,172,56,177,195,100,70,17,160,62,24,48,249,244,248,248,76,17,20,43,208,150,140,35,204,208,24,102,245,220,141,83,173,230,114,81,25,230,164,86,227,71,205,37,203,239,145,137,207,168,206,207,214,231,103,163,202,74,181,128,239,248,234,180,10,39,190,90,173,174,219,196,227,202,58,44,60,77,158,35,175,57,236,216,31,69,35,185,199,120,212,165,193,133,143,66,154,51,107,175,96,202,185,174,148,155,150,242,86,155,226,86,98,46,236,79,47,202,159,195,128,159,76,38,112,99,171,162,96,102,149,196,239,79,179,31,224,150,204,129,64,203,141,124,54,8,211,236,14,76,60,7,115,163,11,96,13,51,88,52,47,146,227,120,195,53,217,33,43,171,231,92,114,224,181,150,163,82,224,10,58,86,248,184,203,140,126,145,2,205,86,238,104,29,36,247,123,252,34,133,64,21,8,155,124,167,108,39,59,218,80,180,28,190,74,137,198,73,244,68,89,56,23,1,79,181,239,49,187,250,112,81,255,203,139,143,191,66,42,242,91,103,194,175,242,25,88,195,2,221,181,55,195,191,254,210,12,76,217,87,52,52,199,52,228,72,150,75,84,162,209,218,4,98,188,31,238,121,146,214,142,41,71,248,209,102,222,238,133,20,189,46,164,159,131,59,49,196,4,222,84,159,225,31,71,59,145,110,1,167,180,163,178,78,23,53,233,67,229,71,171,133,117,157,33,64,39,52,41,54,56,204,167,223,81,193,97,163,30,118,16,39,119,234,91,149,59,89,230,152,46,181,191,219,255,245,236,16,252,61,175,219,187,57,152,25,20,56,151,10,197,17,223,40,208,219,221,42,91,182,176,231,232,118,179,46,232,20,29,31,210,215,147,183,220,174,96,27,181,69,105,247,210,186,155,157,13,157,236,174,107,75,73,164,247,9,69,27,55,73,178,89,41,131,232,246,86,0,201,188,135,74,136,229,49,188,30,125,125,14,87,166,241,201,209,203,56,68,77,185,55,148,148,134,253,209,77,136,113,38,235,245,230,168,137,118,131,62,230,159,127,229,191,168,12,59,9,0,0 };
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

