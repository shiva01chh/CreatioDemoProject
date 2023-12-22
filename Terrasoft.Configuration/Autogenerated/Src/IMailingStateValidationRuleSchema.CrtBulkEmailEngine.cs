namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingStateValidationRuleSchema

	/// <exclude/>
	public class IMailingStateValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingStateValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingStateValidationRuleSchema(IMailingStateValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d21ccf92-5dc5-4e8f-9f1a-b4b1c7befaaa");
			Name = "IMailingStateValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,77,79,195,48,12,134,207,173,212,255,96,149,11,92,154,59,116,189,32,14,59,76,66,99,226,30,90,103,139,212,58,149,227,32,16,218,127,39,253,216,90,13,145,147,227,216,143,95,191,33,221,161,239,117,141,112,64,102,237,157,145,226,217,145,177,199,192,90,172,163,44,253,201,210,44,77,148,82,80,250,208,117,154,191,171,249,190,199,158,209,35,137,7,57,33,236,180,109,45,29,223,68,11,190,235,214,54,35,96,31,90,132,218,145,176,174,165,184,144,212,10,213,135,143,214,214,96,73,144,205,32,101,251,63,41,150,79,122,146,59,198,99,76,194,14,229,228,26,255,8,175,35,102,122,188,85,59,36,146,151,47,172,131,32,124,94,137,96,28,131,239,177,182,198,98,3,28,7,20,215,118,117,211,15,101,175,89,119,64,209,178,77,238,7,109,121,117,136,123,143,225,136,90,200,69,169,198,234,165,153,81,2,147,175,182,20,235,41,110,233,76,148,136,209,27,70,179,201,87,107,198,15,113,228,49,87,21,240,226,240,74,117,76,133,86,124,156,113,129,14,83,254,18,96,78,225,253,218,208,73,239,195,211,108,35,82,51,57,57,222,207,89,122,30,130,245,249,5,53,193,202,92,36,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d21ccf92-5dc5-4e8f-9f1a-b4b1c7befaaa"));
		}

		#endregion

	}

	#endregion

}

