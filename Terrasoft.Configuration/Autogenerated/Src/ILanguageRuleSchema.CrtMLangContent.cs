namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ILanguageRuleSchema

	/// <exclude/>
	public class ILanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ILanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ILanguageRuleSchema(ILanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6e06075a-13a8-4259-bad5-f82e6f51b55b");
			Name = "ILanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a79d048a-6394-421e-9091-4cdc0081ecbf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,205,74,196,48,16,62,183,208,119,24,118,47,122,105,238,90,123,81,89,10,43,44,171,47,144,54,147,110,160,77,202,36,17,138,248,238,38,233,86,87,215,144,67,190,201,247,71,162,249,136,118,226,29,194,27,18,113,107,164,43,31,141,150,170,247,196,157,50,186,200,63,138,60,243,86,233,30,94,103,235,112,188,47,242,48,97,140,65,101,253,56,114,154,235,51,126,66,219,145,106,209,130,59,33,144,31,194,73,26,2,211,58,174,116,116,224,48,112,221,123,222,99,185,122,176,11,147,201,183,131,234,64,105,135,36,99,169,102,127,166,31,131,89,32,196,46,217,150,176,15,205,224,5,221,201,8,123,7,135,36,75,181,174,122,165,193,129,204,187,18,161,205,154,14,1,105,167,164,66,2,141,40,150,158,213,196,137,143,132,18,116,120,150,135,77,164,184,249,136,157,33,209,136,13,171,203,239,4,246,55,98,209,254,47,172,159,19,6,74,131,139,236,178,98,73,246,227,66,232,60,105,91,239,175,139,6,242,122,27,233,59,175,4,236,208,173,204,70,220,164,209,239,236,219,229,183,178,45,106,177,60,91,64,159,69,30,118,92,95,151,33,134,62,255,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6e06075a-13a8-4259-bad5-f82e6f51b55b"));
		}

		#endregion

	}

	#endregion

}

