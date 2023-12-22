namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICaseRuleHandlerSchema

	/// <exclude/>
	public class ICaseRuleHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICaseRuleHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICaseRuleHandlerSchema(ICaseRuleHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("66c513b1-90ad-4e77-a206-4ecd2c1e8325");
			Name = "ICaseRuleHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,193,78,195,48,12,134,207,157,180,119,176,118,130,75,243,0,148,93,38,36,118,69,227,1,76,230,150,72,169,83,57,201,164,10,241,238,56,41,84,99,136,220,108,255,127,254,207,102,28,41,78,104,9,78,36,130,49,244,169,61,4,238,221,144,5,147,11,188,221,124,108,55,77,142,142,135,95,18,161,135,127,250,237,19,39,151,28,69,21,168,196,24,3,93,204,227,136,50,239,191,235,35,39,146,190,164,246,65,64,178,167,8,66,22,189,205,190,166,182,63,70,115,229,156,242,155,119,22,220,106,62,30,48,210,139,186,159,145,207,158,68,53,5,182,121,141,36,186,4,147,45,127,193,77,89,37,205,64,169,44,208,124,86,200,63,148,181,161,139,200,12,83,208,196,21,20,222,75,150,110,221,174,54,115,235,235,38,20,28,129,245,182,143,59,42,215,152,119,251,122,149,185,51,117,86,165,151,224,206,176,160,195,221,50,134,69,125,95,208,148,172,194,93,191,47,243,111,153,133,175,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("66c513b1-90ad-4e77-a206-4ecd2c1e8325"));
		}

		#endregion

	}

	#endregion

}

