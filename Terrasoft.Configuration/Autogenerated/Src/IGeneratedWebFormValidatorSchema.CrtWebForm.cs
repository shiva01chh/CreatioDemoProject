namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IGeneratedWebFormValidatorSchema

	/// <exclude/>
	public class IGeneratedWebFormValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IGeneratedWebFormValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IGeneratedWebFormValidatorSchema(IGeneratedWebFormValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("61c26b2e-18c1-4d99-9cd7-da3ae5fc724c");
			Name = "IGeneratedWebFormValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("30ff16fc-9eaa-40ad-9611-33924da6f041");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,144,193,110,195,32,16,68,207,177,228,127,64,57,181,23,243,1,117,125,169,212,200,215,38,106,207,196,44,214,74,102,177,22,72,101,69,249,247,66,99,167,149,205,9,150,153,157,167,33,101,193,143,170,3,113,2,102,229,157,9,213,155,35,131,125,100,21,208,81,117,0,130,116,5,253,5,231,119,199,246,8,124,193,14,202,226,90,22,187,232,145,122,113,156,124,0,251,82,22,105,34,165,20,181,143,214,42,158,154,249,253,169,6,212,105,133,23,61,94,128,196,160,72,103,31,80,192,48,85,139,75,254,179,141,241,60,96,39,144,2,176,201,120,237,154,99,94,234,56,169,51,202,38,121,21,189,13,221,166,222,39,163,98,101,5,165,102,94,247,223,247,176,86,239,155,86,103,171,65,96,225,204,178,174,170,229,175,252,207,205,16,34,147,111,90,242,65,81,34,79,226,153,34,213,249,1,62,14,161,150,139,42,219,214,191,15,232,167,67,68,45,30,8,207,169,225,221,173,44,110,185,232,116,126,0,113,101,218,78,188,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("61c26b2e-18c1-4d99-9cd7-da3ae5fc724c"));
		}

		#endregion

	}

	#endregion

}

