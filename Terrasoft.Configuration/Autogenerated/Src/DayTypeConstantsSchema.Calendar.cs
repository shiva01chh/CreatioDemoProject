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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,143,203,106,195,48,16,69,215,49,248,31,134,116,211,46,84,59,74,44,75,125,129,31,74,233,186,129,174,85,91,9,34,177,108,44,139,98,74,254,189,114,90,7,147,110,218,1,13,232,114,225,156,209,162,146,166,17,133,132,141,108,91,97,234,109,119,155,213,122,171,118,182,21,157,170,181,239,125,250,222,204,26,165,119,240,218,155,78,86,247,190,231,146,32,8,224,193,216,170,18,109,255,244,243,191,26,7,206,123,108,6,147,106,99,223,15,170,0,211,57,64,1,197,65,24,3,185,232,55,125,35,29,218,197,186,51,174,54,112,127,97,70,206,240,238,96,138,59,183,167,168,11,214,179,85,37,188,213,237,222,225,94,74,120,4,45,63,78,225,245,156,135,25,33,36,201,81,18,49,142,86,4,71,136,50,78,80,196,195,116,29,71,121,146,227,100,126,243,125,251,223,172,254,171,37,229,158,235,242,66,43,140,105,198,210,5,71,108,185,192,104,181,228,107,148,82,22,34,30,97,70,243,148,96,138,227,147,214,236,232,123,199,193,206,205,23,7,77,129,232,213,1,0,0 };
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

