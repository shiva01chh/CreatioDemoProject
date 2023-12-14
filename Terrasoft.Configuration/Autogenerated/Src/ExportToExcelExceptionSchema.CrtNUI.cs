namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExportToExcelExceptionSchema

	/// <exclude/>
	public class ExportToExcelExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExportToExcelExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExportToExcelExceptionSchema(ExportToExcelExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("091dd986-6c16-40af-a793-56676e4cbe11");
			Name = "ExportToExcelException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,143,193,10,131,48,12,134,207,10,190,67,240,164,32,101,231,141,157,198,6,59,236,52,95,160,118,81,10,218,150,166,130,67,124,247,181,186,41,194,122,248,73,66,254,47,127,21,239,144,12,23,8,37,90,203,73,215,142,93,180,170,101,211,91,238,164,86,236,58,24,109,93,169,175,131,192,54,137,199,36,142,122,146,170,129,231,155,28,118,167,36,246,19,211,87,173,20,32,90,78,4,59,71,16,19,64,112,132,181,246,142,192,89,109,90,145,3,114,54,96,31,72,196,27,188,105,219,113,7,103,72,55,194,171,159,55,112,230,131,211,190,242,23,24,220,149,66,59,55,203,222,120,152,210,37,215,239,194,255,72,217,134,198,33,247,1,43,78,152,45,57,216,18,32,219,197,41,252,30,251,78,242,34,240,163,96,156,255,50,121,153,194,81,47,225,125,0,134,71,115,208,90,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("091dd986-6c16-40af-a793-56676e4cbe11"));
		}

		#endregion

	}

	#endregion

}

