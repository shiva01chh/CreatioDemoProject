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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,75,107,132,48,20,133,215,10,254,135,139,221,180,80,20,186,108,173,208,55,174,6,58,101,246,87,115,117,210,106,34,121,12,12,67,255,123,99,124,32,76,23,165,89,153,227,185,223,61,73,174,192,142,116,143,21,193,7,41,133,90,214,38,121,146,162,230,141,85,104,184,20,201,171,84,84,161,54,187,155,40,60,69,97,96,53,23,13,108,143,218,80,231,172,109,75,213,224,211,201,27,9,82,188,186,139,66,231,186,80,212,56,21,10,97,72,213,142,127,11,197,76,218,148,159,174,102,135,173,165,71,219,126,61,48,182,233,105,236,230,107,211,52,133,76,219,174,67,117,204,167,253,194,129,90,42,64,198,134,16,14,39,21,211,96,228,160,122,54,236,185,54,82,29,65,250,38,112,24,186,76,198,100,102,167,43,120,111,203,150,87,192,23,254,223,98,6,39,31,245,44,171,23,156,245,63,217,206,195,141,74,143,10,59,16,238,165,238,99,45,176,215,123,105,226,124,142,9,179,148,165,222,248,123,221,20,39,206,223,199,143,181,249,32,57,27,50,79,191,46,103,242,118,2,63,163,193,165,203,53,20,47,194,118,238,34,202,150,178,213,29,141,213,249,124,240,43,55,7,193,247,56,11,36,216,56,14,195,214,107,110,253,0,121,60,75,166,122,2,0,0 };
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

