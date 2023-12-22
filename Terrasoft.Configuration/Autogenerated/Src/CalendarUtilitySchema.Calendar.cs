namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarUtilitySchema

	/// <exclude/>
	public class CalendarUtilitySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarUtilitySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarUtilitySchema(CalendarUtilitySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("79e58c22-6756-4f35-93bc-da6c46a7c24a");
			Name = "CalendarUtility";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,82,203,78,195,48,16,60,183,82,255,97,149,94,202,37,190,67,26,9,202,165,55,36,218,15,216,186,155,96,41,177,35,63,64,165,226,223,217,56,105,72,194,133,35,57,197,227,157,241,204,216,26,107,114,13,74,130,3,89,139,206,20,62,221,25,93,168,50,88,244,202,232,116,135,21,233,51,90,183,90,94,87,203,69,112,74,151,147,97,75,15,171,37,239,172,45,149,76,128,93,133,206,193,61,220,136,71,175,42,229,47,113,70,8,1,153,11,117,141,246,146,247,235,71,144,145,225,223,208,67,99,205,187,58,147,3,217,179,193,171,154,218,149,12,85,52,4,33,234,41,114,233,77,80,140,20,155,112,170,148,132,6,173,87,88,245,210,51,43,191,205,61,161,35,38,95,163,201,159,36,70,59,111,131,244,198,182,129,94,162,116,55,50,15,18,129,189,86,237,161,234,147,253,35,104,250,0,197,2,168,185,93,83,112,62,98,10,113,24,75,197,54,153,57,72,68,222,153,77,7,121,49,215,207,56,21,214,160,249,206,182,73,112,100,217,160,38,217,182,146,228,7,150,111,49,144,3,152,102,34,50,162,64,95,204,236,216,205,113,34,3,83,213,59,78,125,226,106,54,115,184,125,9,139,175,255,82,133,227,11,162,174,129,248,251,151,220,251,27,240,140,30,95,91,86,54,64,217,104,243,146,231,157,232,208,69,191,26,87,176,230,225,238,205,196,117,135,78,65,198,198,223,55,86,185,6,103,120,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("79e58c22-6756-4f35-93bc-da6c46a7c24a"));
		}

		#endregion

	}

	#endregion

}

