namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISysCultureInfoSchema

	/// <exclude/>
	public class ISysCultureInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISysCultureInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISysCultureInfoSchema(ISysCultureInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ea1fdfd0-6ef8-44d6-b478-24f2418a19b8");
			Name = "ISysCultureInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,81,77,107,195,48,12,61,39,144,255,32,232,61,185,183,99,151,28,70,46,163,176,178,187,23,203,158,33,145,131,108,195,74,217,127,159,226,172,37,99,148,18,159,236,167,247,97,73,164,70,12,147,234,17,78,200,172,130,55,177,110,61,25,103,19,171,232,60,213,39,86,20,134,124,175,202,75,85,22,41,56,178,240,118,14,17,199,67,85,10,178,99,180,82,134,142,34,178,17,179,61,116,82,111,211,16,19,99,71,198,103,218,148,62,6,215,131,187,178,254,147,138,75,38,222,12,143,236,39,228,232,48,236,225,152,213,75,189,105,26,120,10,105,28,21,159,159,175,192,242,35,232,23,67,112,26,41,58,227,144,235,155,164,89,107,94,146,211,208,105,152,123,42,10,139,241,48,95,190,55,36,144,198,175,59,230,210,164,140,67,234,27,236,87,147,134,222,15,105,36,32,89,207,157,132,16,121,222,195,74,212,102,205,171,72,54,132,190,35,203,144,250,141,169,107,213,163,216,95,73,23,218,79,69,22,245,35,254,14,73,47,251,207,239,5,253,11,102,76,206,15,223,225,153,218,190,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ea1fdfd0-6ef8-44d6-b478-24f2418a19b8"));
		}

		#endregion

	}

	#endregion

}

