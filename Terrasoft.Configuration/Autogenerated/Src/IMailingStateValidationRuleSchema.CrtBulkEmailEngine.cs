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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,77,79,195,48,12,134,207,171,212,255,96,149,11,92,154,59,108,189,32,14,59,76,66,99,226,30,90,103,139,212,58,149,227,32,16,218,127,199,109,247,81,13,145,147,227,216,143,95,191,33,219,97,236,109,141,176,67,102,27,131,147,242,57,144,243,251,196,86,124,160,60,251,201,179,60,91,24,99,96,25,83,215,89,254,174,78,247,45,246,140,17,73,34,200,1,97,99,125,235,105,255,38,86,240,221,182,190,25,1,219,212,34,212,129,132,109,45,229,153,100,102,168,62,125,180,190,6,79,130,236,6,41,235,255,73,90,62,233,89,220,49,238,53,9,27,148,67,104,226,35,188,142,152,233,241,86,237,144,88,188,124,97,157,4,225,243,66,4,23,24,98,143,181,119,30,27,96,29,80,94,218,205,77,63,44,123,203,182,3,82,203,86,69,28,180,21,213,78,247,30,195,17,117,37,151,75,51,86,95,155,25,37,49,197,106,77,90,79,186,101,112,42,17,213,27,70,183,42,102,107,234,135,4,138,88,152,10,248,234,240,76,181,166,82,43,81,103,156,161,195,148,191,4,56,165,240,126,110,232,164,247,225,233,100,35,82,51,57,57,222,143,121,118,28,2,61,191,199,111,217,252,27,2,0,0 };
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

