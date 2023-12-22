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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,205,74,196,48,16,62,111,161,239,48,236,94,244,210,220,181,246,162,178,20,86,88,86,95,32,109,166,221,64,59,41,147,68,40,226,187,155,166,91,173,174,33,135,124,147,239,143,132,100,143,118,144,53,194,27,50,75,107,26,151,61,26,106,116,235,89,58,109,40,77,62,210,100,227,173,166,22,94,71,235,176,191,79,147,48,17,66,64,110,125,223,75,30,139,11,126,66,91,179,174,208,130,59,35,176,239,194,169,49,12,166,114,82,211,228,32,161,147,212,122,217,98,182,120,136,149,201,224,171,78,215,160,201,33,55,83,169,242,112,161,159,130,89,32,76,93,54,59,198,54,52,131,23,116,103,163,236,29,28,163,44,214,186,234,21,7,71,54,239,90,133,54,75,58,4,68,78,55,26,25,8,81,205,61,243,65,178,236,25,27,160,240,44,15,219,137,226,198,19,214,134,85,169,182,162,200,190,19,196,223,136,89,251,191,176,120,142,24,56,14,86,217,89,46,162,236,199,133,209,121,38,91,28,174,139,6,242,114,59,209,247,94,43,216,163,91,152,165,186,137,163,223,217,183,243,111,109,118,72,106,126,182,128,62,211,36,236,245,250,2,236,189,222,89,7,2,0,0 };
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

