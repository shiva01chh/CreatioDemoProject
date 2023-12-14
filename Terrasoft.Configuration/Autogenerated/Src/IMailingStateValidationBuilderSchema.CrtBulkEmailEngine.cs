namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingStateValidationBuilderSchema

	/// <exclude/>
	public class IMailingStateValidationBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingStateValidationBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingStateValidationBuilderSchema(IMailingStateValidationBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a8d7af86-6b55-4390-b894-80b48b52f7ba");
			Name = "IMailingStateValidationBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,75,107,194,64,16,128,207,6,242,31,6,123,105,47,201,189,166,57,88,138,120,16,164,150,222,215,100,18,23,246,33,51,179,22,17,255,123,119,19,45,86,40,116,79,243,216,249,230,219,117,202,34,239,85,131,240,129,68,138,125,39,197,171,119,157,238,3,41,209,222,229,217,41,207,38,129,181,235,97,115,100,65,27,251,198,96,147,154,92,44,208,33,233,102,150,103,241,86,89,150,80,113,176,86,209,177,190,228,107,242,7,221,34,131,69,217,249,22,196,67,143,2,20,76,172,117,158,128,69,9,194,65,25,221,42,241,84,92,57,229,13,104,31,182,70,55,160,157,32,117,73,118,185,82,218,68,165,77,26,254,28,103,163,207,60,104,211,34,197,137,211,32,52,121,32,236,99,29,86,195,114,126,134,245,64,26,155,247,186,67,97,129,194,32,59,188,49,180,227,174,223,166,145,90,252,64,202,123,74,69,40,129,28,215,21,35,66,67,216,189,76,151,111,46,88,36,181,53,88,253,225,255,30,119,214,211,178,134,47,45,187,209,160,168,202,43,43,193,255,11,73,239,72,1,63,62,205,46,95,129,174,29,127,99,200,207,121,118,78,65,58,223,66,33,41,63,5,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a8d7af86-6b55-4390-b894-80b48b52f7ba"));
		}

		#endregion

	}

	#endregion

}

