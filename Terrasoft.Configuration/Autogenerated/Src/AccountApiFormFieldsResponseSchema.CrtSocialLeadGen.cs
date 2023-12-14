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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,84,193,110,219,48,12,61,167,64,255,65,104,47,219,37,185,183,133,129,192,67,183,14,221,230,174,185,21,59,168,18,147,8,176,37,143,148,219,5,193,254,125,178,172,56,177,163,100,70,17,160,62,24,48,249,244,248,248,76,145,105,94,0,149,92,0,155,1,34,39,51,183,227,212,232,185,90,84,200,173,50,122,252,104,132,226,249,61,112,249,25,244,249,217,250,252,108,84,145,210,11,246,29,94,173,209,254,196,87,50,250,186,77,60,174,200,66,225,104,242,28,68,205,65,99,119,20,80,9,135,113,168,75,132,133,139,178,52,231,68,87,108,42,132,169,180,157,150,234,214,96,113,171,32,151,244,211,137,114,231,192,227,39,147,9,187,161,170,40,56,174,146,240,253,105,246,131,217,37,183,76,2,9,84,207,8,108,154,221,49,12,231,216,28,77,193,120,195,204,8,240,69,9,24,111,184,38,59,100,101,245,156,43,193,68,173,229,168,20,118,197,58,86,184,184,205,208,188,40,9,184,149,59,90,123,201,253,30,191,40,41,65,123,194,38,223,41,219,201,142,54,20,45,135,171,82,2,90,5,142,40,243,231,2,224,169,246,61,100,87,31,46,234,127,121,241,241,151,79,5,126,178,232,127,149,203,176,53,91,128,189,118,102,184,215,223,56,3,215,244,10,24,231,152,250,92,148,229,18,180,108,180,54,129,16,239,135,123,158,164,181,99,218,70,252,104,51,111,247,66,201,94,23,202,205,193,157,28,98,130,104,170,207,224,143,141,59,145,110,1,167,180,163,34,107,138,154,244,161,114,163,213,194,186,206,68,64,39,52,41,52,56,204,167,223,65,193,97,163,30,118,16,39,119,234,91,149,91,85,230,144,46,141,187,219,255,245,236,16,252,61,175,219,187,57,152,33,72,152,43,13,242,136,111,49,208,219,221,42,91,54,191,231,226,237,102,93,208,41,58,62,164,175,39,111,185,93,193,20,180,5,105,247,138,236,205,206,134,78,118,215,53,197,36,198,247,73,140,54,108,146,100,179,82,6,209,237,173,128,40,243,30,42,137,44,143,225,245,226,215,231,112,229,56,62,57,122,25,135,168,41,247,134,50,166,97,127,116,147,200,56,71,235,245,230,168,137,118,131,46,86,63,255,0,219,184,187,226,60,9,0,0 };
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

