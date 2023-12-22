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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,143,203,106,195,48,16,69,215,49,248,31,134,116,211,46,84,59,74,44,91,125,129,31,74,233,186,129,174,85,91,9,38,177,108,244,160,152,146,127,175,156,214,193,164,155,118,64,3,186,92,56,103,36,111,132,238,120,41,96,35,148,226,186,221,154,219,188,149,219,122,103,21,55,117,43,125,239,211,247,102,86,215,114,7,175,189,54,162,185,247,61,151,4,65,0,15,218,54,13,87,253,211,207,255,106,28,56,239,177,25,76,170,157,125,63,212,37,104,227,0,37,148,7,174,53,20,188,223,244,157,112,104,23,75,163,93,109,224,254,194,140,156,225,221,193,20,119,110,79,81,23,172,103,91,87,240,214,170,189,195,189,84,240,8,82,124,156,194,235,57,11,115,66,72,90,160,52,162,12,173,8,142,80,66,25,65,17,11,179,117,28,21,105,129,211,249,205,247,237,127,179,250,175,150,16,123,38,171,11,173,48,78,114,154,45,24,162,203,5,70,171,37,91,163,44,161,33,98,17,166,73,145,17,156,224,248,164,53,59,250,222,113,176,155,206,23,11,64,35,215,222,1,0,0 };
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

