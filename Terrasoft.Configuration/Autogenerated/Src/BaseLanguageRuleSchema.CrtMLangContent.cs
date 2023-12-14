namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseLanguageRuleSchema

	/// <exclude/>
	public class BaseLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseLanguageRuleSchema(BaseLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("baa8372c-43b1-4ee1-aa11-be1c27d2f168");
			Name = "BaseLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2659875a-4670-491c-9c1f-f4641a7bae64");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,65,110,131,48,16,60,19,41,127,88,145,75,114,129,123,154,228,80,14,17,82,15,81,218,62,192,49,11,178,4,54,90,219,135,168,234,223,107,155,128,192,81,171,114,219,97,118,152,25,86,178,14,117,207,56,194,7,18,49,173,106,147,21,74,214,162,177,196,140,80,114,189,250,90,175,18,171,133,108,224,253,174,13,118,47,211,60,95,33,116,184,123,179,33,108,220,26,20,45,211,122,15,175,76,227,27,147,141,101,13,94,109,139,129,147,231,57,28,180,237,58,70,247,211,99,246,68,96,55,109,136,113,3,220,111,67,173,200,241,16,129,19,214,199,180,156,11,165,249,9,68,215,183,216,161,52,193,169,206,70,233,124,166,221,219,91,43,120,172,28,219,130,61,148,75,155,137,143,61,165,185,144,234,145,140,64,23,233,18,20,67,144,167,36,1,248,212,72,192,149,148,200,189,175,108,34,206,125,141,198,60,185,152,184,241,24,76,36,13,26,95,122,242,61,124,116,131,178,26,124,61,230,177,114,215,129,33,203,141,162,255,216,44,8,153,65,13,194,109,49,233,46,64,213,243,182,227,138,92,225,191,36,9,72,207,136,117,32,221,57,29,83,187,8,145,158,226,66,14,121,96,15,53,144,50,14,198,234,233,159,108,163,46,150,170,187,71,55,17,233,24,209,254,234,45,62,141,179,21,21,156,209,140,38,202,106,27,32,119,96,194,220,175,200,21,85,101,181,243,146,131,226,82,208,97,254,249,1,182,237,100,112,82,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("baa8372c-43b1-4ee1-aa11-be1c27d2f168"));
		}

		#endregion

	}

	#endregion

}

