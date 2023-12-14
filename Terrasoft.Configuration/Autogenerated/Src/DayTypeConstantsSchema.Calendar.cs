namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DayTypeConstantsSchema

	/// <exclude/>
	public class DayTypeConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DayTypeConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DayTypeConstantsSchema(DayTypeConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e4a46baa-a9bf-4def-a556-bd42551ffe45");
			Name = "DayTypeConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,143,93,107,131,48,20,134,175,43,248,31,14,221,205,118,145,105,211,38,154,125,129,154,116,236,122,133,93,103,154,22,105,141,98,12,67,70,255,251,98,55,139,116,55,219,129,28,200,203,11,207,115,180,172,148,105,100,174,96,163,218,86,154,122,219,221,102,181,222,150,59,219,202,174,172,181,239,125,250,222,204,154,82,239,224,181,55,157,170,238,125,207,37,65,16,192,131,177,85,37,219,254,233,231,127,53,14,156,247,216,12,38,213,198,190,31,202,28,76,231,0,57,228,7,105,12,112,217,111,250,70,57,180,139,117,103,92,109,224,254,194,140,156,225,221,193,20,119,110,79,81,23,172,103,91,22,240,86,183,123,135,123,41,224,17,180,250,56,133,215,115,17,102,148,210,132,163,132,48,129,86,20,19,20,51,65,17,17,97,186,142,8,79,56,78,230,55,223,183,255,205,234,191,90,74,237,133,46,46,180,194,40,206,88,186,16,136,45,23,24,173,150,98,141,210,152,133,72,16,204,98,158,82,28,227,232,164,53,59,250,222,113,176,27,230,11,125,18,91,172,214,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e4a46baa-a9bf-4def-a556-bd42551ffe45"));
		}

		#endregion

	}

	#endregion

}

