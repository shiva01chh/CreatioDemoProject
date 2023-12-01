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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,205,74,196,48,16,62,183,208,119,24,118,47,122,105,238,90,123,81,89,10,43,44,171,47,144,54,211,110,160,77,202,36,17,138,248,238,78,211,173,174,174,33,135,124,147,239,143,196,200,1,221,40,27,132,55,36,146,206,182,62,127,180,166,213,93,32,233,181,53,89,250,145,165,73,112,218,116,240,58,57,143,195,125,150,242,68,8,1,133,11,195,32,105,42,207,248,9,93,67,186,70,7,254,132,64,161,231,83,107,9,108,237,165,54,179,131,132,94,154,46,200,14,243,213,67,92,152,140,161,238,117,3,218,120,164,118,46,85,237,207,244,35,155,49,97,238,146,108,9,59,110,6,47,232,79,86,185,59,56,68,89,172,117,213,43,14,14,100,223,181,226,54,107,58,48,50,94,183,26,9,12,162,90,122,22,163,36,57,16,182,96,248,89,30,54,51,197,79,71,108,44,169,74,109,68,153,127,39,136,191,17,139,246,127,97,249,28,49,80,28,92,100,231,133,136,178,31,23,66,31,200,184,114,127,93,148,201,235,237,76,223,5,173,96,135,126,101,86,234,38,142,126,103,223,46,191,149,108,209,168,229,217,24,125,102,41,111,94,95,203,60,60,231,254,1,0,0 };
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

