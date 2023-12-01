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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,75,107,194,64,16,128,207,6,242,31,6,123,105,47,217,123,77,115,176,20,241,32,72,45,189,175,201,36,46,236,67,102,102,45,34,254,247,110,18,45,86,40,116,79,243,216,249,230,219,245,218,33,239,117,141,240,129,68,154,67,43,197,107,240,173,233,34,105,49,193,231,217,41,207,38,145,141,239,96,115,100,65,151,250,214,98,221,55,185,88,160,71,50,245,44,207,210,45,165,20,148,28,157,211,116,172,46,249,154,194,193,52,200,224,80,118,161,1,9,208,161,0,69,155,106,109,32,96,209,130,112,208,214,52,90,2,21,87,142,186,1,237,227,214,154,26,140,23,164,182,151,93,174,180,177,73,105,211,15,127,142,179,201,103,30,141,109,144,210,196,105,16,154,60,16,118,169,14,171,97,57,63,195,122,32,141,205,123,221,161,176,64,97,144,29,222,24,186,113,215,111,211,68,45,126,32,234,158,82,18,74,36,207,85,201,136,80,19,182,47,211,229,155,143,14,73,111,45,150,127,248,191,167,157,213,84,85,240,101,100,55,26,20,165,186,178,122,248,127,33,253,59,250,128,31,159,102,151,175,64,223,140,191,49,228,231,60,59,247,65,58,223,138,239,77,147,4,2,0,0 };
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

