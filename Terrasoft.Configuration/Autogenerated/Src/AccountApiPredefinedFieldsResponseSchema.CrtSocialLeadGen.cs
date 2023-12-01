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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,65,75,195,64,16,133,207,45,244,63,12,245,162,151,228,222,150,66,169,40,74,209,106,123,19,15,219,221,73,92,72,118,195,204,166,82,138,255,221,77,178,169,38,86,52,135,133,188,157,247,230,155,89,35,114,228,66,72,132,45,18,9,182,137,139,150,214,36,58,45,73,56,109,77,180,177,82,139,108,133,66,221,162,25,13,143,163,225,160,100,109,82,120,192,119,103,77,237,184,103,107,166,167,139,205,129,29,230,62,38,203,80,86,25,28,121,43,146,150,190,198,87,93,16,166,94,133,101,38,152,39,176,144,210,150,198,45,10,189,38,84,152,104,131,234,70,99,166,248,217,163,121,55,214,174,56,142,97,198,101,158,11,58,204,195,255,245,246,17,220,155,112,160,144,37,233,29,33,44,214,119,64,193,7,9,217,28,68,147,15,140,180,215,18,163,54,43,254,22,86,148,187,76,75,144,21,209,63,128,96,2,157,181,120,221,173,201,238,181,66,250,130,30,28,107,240,254,188,95,161,79,165,247,249,155,166,172,195,112,174,104,208,6,158,18,125,207,2,201,105,172,98,107,123,40,120,169,94,36,220,30,46,199,69,119,142,241,213,107,93,21,58,178,163,234,217,122,195,194,17,82,116,83,191,54,127,124,180,141,209,168,166,119,35,4,189,47,255,197,247,43,94,59,44,7,196,64,184,210,236,102,63,87,50,63,179,38,62,199,221,227,107,212,174,232,53,255,125,2,142,111,54,220,15,3,0,0 };
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

