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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,193,78,195,48,12,134,207,157,180,119,176,118,130,75,243,0,148,93,38,164,237,138,198,3,152,204,45,145,82,167,114,18,164,106,226,221,113,82,168,96,136,220,108,255,127,254,207,102,28,41,78,104,9,206,36,130,49,244,169,61,4,238,221,144,5,147,11,188,221,92,183,155,38,71,199,195,47,137,208,195,63,253,246,137,147,75,142,162,10,84,98,140,129,46,230,113,68,153,247,95,245,137,19,73,95,82,251,32,32,217,83,4,33,139,222,102,95,83,219,111,163,249,225,156,242,171,119,22,220,106,62,29,48,210,179,186,143,200,23,79,162,154,2,219,188,68,18,93,130,201,150,191,224,166,172,146,102,160,84,22,104,62,42,228,31,202,218,208,69,100,134,41,104,226,10,10,111,37,75,183,110,87,155,185,245,117,19,10,142,192,122,219,199,29,149,107,204,187,125,189,202,220,153,58,171,210,247,224,46,176,160,195,221,50,134,69,125,95,208,148,172,194,149,247,9,130,85,255,167,167,1,0,0 };
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

