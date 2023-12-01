namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TimeUnitEnumSchema

	/// <exclude/>
	public class TimeUnitEnumSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TimeUnitEnumSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TimeUnitEnumSchema(TimeUnitEnumSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2edcc60c-6562-466a-beae-9495a7f738b1");
			Name = "TimeUnitEnum";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,81,77,75,3,49,16,61,239,66,255,195,128,23,5,217,245,94,43,72,21,234,65,61,88,241,32,30,178,235,180,6,243,177,204,36,194,98,251,223,157,236,87,43,40,36,100,222,203,155,153,55,137,83,22,185,81,53,194,26,137,20,251,77,40,150,222,109,244,54,146,10,218,187,98,169,12,186,119,69,60,203,191,103,121,22,89,187,45,60,181,28,208,206,103,185,48,39,132,91,17,194,173,139,150,59,166,44,75,184,228,104,173,162,246,106,192,215,95,74,27,85,25,132,160,45,66,116,58,48,108,60,65,64,178,12,181,50,117,52,125,199,177,66,121,84,162,137,149,209,53,160,244,128,181,20,120,150,124,161,147,163,236,193,59,132,5,92,156,39,112,175,93,12,216,133,43,31,169,11,110,84,219,157,47,158,62,197,253,145,100,96,38,229,128,37,65,208,94,182,172,215,199,138,189,193,128,111,7,31,28,196,106,13,181,81,204,147,159,21,154,6,105,116,245,91,89,121,111,224,142,199,199,76,242,211,240,161,15,201,221,179,164,224,12,186,244,140,48,68,114,19,13,139,197,164,45,196,31,236,118,127,223,165,89,254,189,236,71,159,167,6,251,126,194,244,129,98,169,255,195,4,133,203,243,31,49,186,47,98,23,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2edcc60c-6562-466a-beae-9495a7f738b1"));
		}

		#endregion

	}

	#endregion

}

