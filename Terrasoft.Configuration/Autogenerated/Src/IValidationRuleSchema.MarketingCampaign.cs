namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IValidationRuleSchema

	/// <exclude/>
	public class IValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IValidationRuleSchema(IValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4b8f6e9b-17b0-478d-8b69-e7bce7da0263");
			Name = "IValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,193,10,194,48,12,134,207,14,246,14,57,234,197,62,128,195,131,226,193,171,136,247,108,102,179,216,181,146,164,130,136,239,110,87,84,6,162,189,53,253,254,124,63,245,216,147,92,176,33,216,19,51,74,104,117,190,14,190,181,93,100,84,27,124,89,220,203,98,98,140,129,74,98,223,35,223,150,175,251,10,133,224,138,206,30,51,8,28,29,205,223,172,25,193,151,88,59,219,128,245,74,220,14,170,237,225,147,218,165,80,66,6,199,151,36,15,82,25,69,235,65,79,4,169,97,96,232,81,4,59,2,219,166,149,217,255,81,127,187,39,162,108,125,7,155,28,189,67,71,186,128,71,89,252,246,157,168,57,103,219,159,165,121,194,164,145,189,44,15,163,47,32,137,78,43,243,126,26,216,58,4,7,47,134,166,179,69,154,37,127,174,48,62,79,76,167,40,249,137,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4b8f6e9b-17b0-478d-8b69-e7bce7da0263"));
		}

		#endregion

	}

	#endregion

}

