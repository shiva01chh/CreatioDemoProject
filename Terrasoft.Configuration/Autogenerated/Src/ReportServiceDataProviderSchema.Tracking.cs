namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportServiceDataProviderSchema

	/// <exclude/>
	public class ReportServiceDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportServiceDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportServiceDataProviderSchema(ReportServiceDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4bdab04d-2ff8-4619-bc00-3e7bdcd86548");
			Name = "ReportServiceDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,193,110,219,48,12,61,187,64,255,129,200,46,54,48,200,247,165,9,48,116,195,208,75,87,52,233,174,131,106,211,129,48,91,50,40,41,64,16,244,223,71,75,118,98,123,115,124,176,77,234,145,124,143,164,180,108,208,182,178,64,216,35,145,180,166,114,226,209,232,74,29,60,73,167,140,22,123,146,197,31,165,15,247,119,231,251,187,196,91,254,133,221,201,58,108,214,23,123,28,75,120,245,119,86,204,6,155,96,76,115,51,144,161,159,8,15,108,192,99,45,173,253,2,67,189,111,210,201,23,50,71,85,34,5,92,158,231,240,96,125,211,72,58,109,123,187,7,128,210,149,161,38,36,133,138,76,3,132,173,33,7,22,233,168,10,20,67,120,62,138,111,253,123,173,10,40,186,178,240,26,240,187,8,31,151,134,37,70,201,57,176,186,208,231,147,22,201,41,100,13,47,164,142,210,97,4,204,121,7,71,236,32,243,115,142,51,91,208,60,7,96,13,240,46,45,206,216,131,167,90,92,50,141,37,36,109,44,4,214,81,215,239,168,226,107,89,18,90,187,235,115,63,119,169,55,91,88,13,58,34,234,141,234,213,186,151,128,186,140,42,110,73,50,14,11,135,101,132,204,10,255,166,33,231,122,81,242,235,63,162,224,40,107,143,139,210,250,130,83,113,92,162,59,237,118,49,73,14,232,194,55,90,137,170,32,141,96,241,100,159,125,93,255,164,239,77,235,78,233,149,94,150,69,104,31,145,92,79,250,13,141,11,42,120,62,67,255,196,15,116,191,58,162,233,27,115,231,115,205,180,184,61,159,151,219,157,137,189,217,5,34,105,182,238,43,17,58,79,122,222,169,36,249,136,31,172,45,78,169,221,14,8,239,143,219,243,99,174,220,14,95,56,67,221,4,195,190,223,216,201,17,28,76,5,50,94,141,133,241,4,79,43,73,54,97,119,55,43,63,105,206,106,251,196,201,164,230,65,115,170,105,227,196,67,30,2,227,152,227,45,92,188,127,179,166,195,180,76,198,215,179,187,49,233,220,125,134,255,247,38,122,167,206,224,27,63,127,1,159,26,78,31,21,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4bdab04d-2ff8-4619-bc00-3e7bdcd86548"));
		}

		#endregion

	}

	#endregion

}

