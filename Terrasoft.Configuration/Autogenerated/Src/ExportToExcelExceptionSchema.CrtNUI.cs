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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,143,193,10,131,48,12,134,207,10,190,67,240,164,32,101,231,141,157,134,131,29,118,154,47,80,93,148,130,182,210,84,112,136,239,190,182,110,58,97,61,252,36,33,255,151,191,146,119,72,61,175,16,10,212,154,147,170,13,187,40,89,139,102,208,220,8,37,89,62,246,74,155,66,229,99,133,109,20,78,81,24,12,36,100,3,143,23,25,236,78,81,104,39,253,80,182,162,130,170,229,68,176,115,56,233,29,8,142,176,214,214,225,56,171,77,73,50,64,70,59,236,29,137,120,131,87,165,59,110,224,12,241,70,120,14,126,3,61,31,140,178,149,189,192,224,38,37,106,223,44,123,211,97,142,151,92,223,11,255,35,37,27,26,199,212,6,44,57,97,178,228,96,75,128,100,23,39,179,123,236,51,73,51,199,15,156,209,255,101,182,50,187,163,86,126,223,27,146,4,18,211,98,1,0,0 };
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

