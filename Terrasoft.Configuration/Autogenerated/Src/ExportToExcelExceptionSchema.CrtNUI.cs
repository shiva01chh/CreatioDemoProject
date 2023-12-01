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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,143,193,10,131,48,12,134,207,10,190,67,240,164,32,101,231,141,157,198,6,59,236,52,95,160,118,81,4,109,165,169,224,16,223,125,169,110,138,176,30,126,146,144,255,203,95,45,91,164,78,42,132,28,173,149,100,74,39,46,70,151,117,213,91,233,106,163,197,117,232,140,117,185,185,14,10,155,40,28,163,48,232,169,214,21,60,223,228,176,61,69,33,79,186,190,104,106,5,170,145,68,176,115,120,233,60,8,142,176,214,236,240,156,213,102,52,57,32,103,61,246,129,68,178,194,155,177,173,116,112,134,120,35,188,250,121,3,103,62,56,195,21,95,16,112,215,26,237,220,44,123,227,97,138,151,92,191,11,255,35,37,27,26,135,148,3,22,146,48,89,114,136,37,64,178,139,147,241,158,248,78,210,204,243,3,111,156,255,50,177,76,254,40,11,191,15,201,1,59,28,89,1,0,0 };
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

