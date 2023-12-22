namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITermCalculatorSchema

	/// <exclude/>
	public class ITermCalculatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITermCalculatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITermCalculatorSchema(ITermCalculatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bf14023c-5dd2-42fc-a1c9-2ee0dcd85fa4");
			Name = "ITermCalculator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,145,207,78,3,33,16,198,207,146,240,14,147,158,244,178,60,64,215,189,212,75,175,221,190,0,226,108,67,178,252,201,12,152,52,198,119,23,90,217,182,154,168,23,9,7,134,249,126,124,243,133,204,214,31,96,60,114,66,183,150,66,10,175,29,114,212,6,97,143,68,154,195,148,186,77,240,147,61,100,210,201,6,223,141,72,175,214,96,105,59,41,222,164,184,83,74,65,207,217,57,77,199,225,179,222,97,36,100,244,137,129,207,122,72,5,0,163,103,147,103,157,2,117,141,84,87,104,204,207,179,53,96,125,17,79,117,136,109,181,217,44,80,145,84,199,111,150,167,139,38,67,40,214,49,120,70,120,41,85,183,0,234,43,209,71,77,218,65,205,252,184,226,164,41,61,21,96,53,140,245,120,134,123,117,210,92,16,194,148,201,243,176,187,241,232,85,187,175,194,250,202,222,58,188,140,212,212,181,115,191,180,23,203,135,245,31,82,113,152,115,253,129,255,76,53,222,120,252,150,170,169,127,74,245,46,69,217,215,235,3,18,160,194,14,116,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bf14023c-5dd2-42fc-a1c9-2ee0dcd85fa4"));
		}

		#endregion

	}

	#endregion

}

