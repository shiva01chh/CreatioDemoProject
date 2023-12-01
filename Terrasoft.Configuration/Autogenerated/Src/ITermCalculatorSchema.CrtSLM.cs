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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,145,207,78,3,33,16,198,207,146,240,14,147,158,244,178,60,64,215,189,212,139,215,110,95,128,226,108,67,178,252,201,12,152,52,198,119,47,180,178,181,154,168,23,9,7,134,249,126,124,243,133,204,214,31,96,60,114,66,183,150,66,10,175,29,114,212,6,97,135,68,154,195,148,186,77,240,147,61,100,210,201,6,223,141,72,175,214,96,105,59,41,222,164,184,83,74,65,207,217,57,77,199,225,163,222,98,36,100,244,137,129,47,122,72,5,0,163,103,147,103,157,2,117,141,84,159,208,152,247,179,53,96,125,17,79,117,136,231,106,179,89,160,34,169,142,223,44,207,23,77,134,80,172,99,240,140,240,82,170,110,1,212,87,162,143,154,180,131,154,249,113,197,73,83,122,42,192,106,24,235,241,2,247,234,172,185,34,132,41,147,231,97,123,227,209,171,118,95,133,245,149,157,117,120,29,169,169,107,231,126,105,47,150,15,235,63,164,226,48,231,250,3,255,153,106,188,241,248,45,85,83,255,148,234,93,138,178,203,58,1,153,243,53,201,107,2,0,0 };
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

