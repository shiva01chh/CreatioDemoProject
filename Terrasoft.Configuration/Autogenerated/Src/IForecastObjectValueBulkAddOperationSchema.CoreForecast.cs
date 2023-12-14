namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastObjectValueBulkAddOperationSchema

	/// <exclude/>
	public class IForecastObjectValueBulkAddOperationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastObjectValueBulkAddOperationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastObjectValueBulkAddOperationSchema(IForecastObjectValueBulkAddOperationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("949d29b4-32dc-fbc9-0241-7774107a898a");
			Name = "IForecastObjectValueBulkAddOperation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,77,107,132,48,16,134,207,10,254,135,193,94,90,40,10,61,182,86,232,55,158,22,186,101,239,163,25,221,180,154,72,62,22,150,165,255,189,73,212,101,97,123,40,205,201,188,190,243,204,155,100,4,14,164,71,108,8,62,72,41,212,178,53,217,147,20,45,239,172,66,195,165,200,94,165,162,6,181,217,220,36,241,33,137,35,171,185,232,96,189,215,134,6,103,237,123,106,188,79,103,111,36,72,241,230,46,137,157,235,66,81,231,84,168,132,33,213,58,254,45,84,11,105,85,127,186,154,13,246,150,30,109,255,245,192,216,106,164,169,91,168,205,243,28,10,109,135,1,213,190,156,247,71,14,180,82,1,50,230,67,56,156,84,76,131,145,94,13,108,216,114,109,164,218,131,12,77,96,231,187,204,198,108,97,231,39,240,209,214,61,111,128,31,249,127,139,25,29,66,212,179,172,65,112,214,255,100,59,15,55,41,35,42,28,64,184,151,186,79,181,192,81,111,165,73,203,37,38,44,82,145,7,227,239,117,115,156,180,124,159,62,78,205,59,201,153,207,60,255,186,92,200,235,25,252,140,6,143,93,174,161,122,17,118,112,23,81,247,84,156,220,209,84,93,46,7,191,114,115,16,125,79,179,64,130,77,227,224,183,65,243,235,7,55,132,168,27,123,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("949d29b4-32dc-fbc9-0241-7774107a898a"));
		}

		#endregion

	}

	#endregion

}

