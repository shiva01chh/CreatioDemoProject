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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,144,193,110,195,32,16,68,207,177,228,127,64,57,181,23,243,1,117,125,169,212,200,215,164,106,207,196,44,214,74,102,177,22,72,101,85,249,247,66,99,167,145,205,9,150,153,157,167,33,101,193,143,170,3,241,1,204,202,59,19,170,55,71,6,251,200,42,160,163,234,0,4,233,10,250,11,206,239,142,237,9,248,130,29,148,197,79,89,236,162,71,234,197,105,242,1,236,75,89,164,137,148,82,212,62,90,171,120,106,230,247,167,26,80,167,21,94,244,120,1,18,131,34,157,125,64,1,195,84,45,46,249,96,27,227,121,192,78,32,5,96,147,241,218,53,199,188,212,113,82,103,148,77,242,42,122,27,186,77,189,77,70,197,202,10,74,205,188,238,191,111,97,173,222,55,173,206,86,131,192,194,153,101,93,85,203,63,249,191,155,33,68,38,223,180,228,131,162,68,158,196,51,69,170,243,8,62,14,161,150,139,42,219,214,191,119,232,167,67,68,45,238,8,207,169,225,221,181,44,174,185,232,199,243,11,9,204,158,144,197,1,0,0 };
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

