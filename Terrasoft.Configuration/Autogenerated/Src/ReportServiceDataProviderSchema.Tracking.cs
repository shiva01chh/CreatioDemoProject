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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,193,110,219,48,12,61,187,64,255,129,200,46,54,48,216,247,165,9,48,116,195,208,75,87,52,233,174,131,106,211,129,48,91,50,40,41,64,16,244,223,71,73,118,98,123,115,124,176,77,234,145,124,143,164,148,104,209,116,162,68,216,35,145,48,186,182,249,163,86,181,60,56,18,86,106,149,239,73,148,127,164,58,220,223,157,239,239,18,103,248,23,118,39,99,177,93,95,236,113,44,225,213,239,173,152,13,54,193,152,230,102,32,67,63,17,30,216,128,199,70,24,243,5,134,122,223,132,21,47,164,143,178,66,10,184,162,40,224,193,184,182,21,116,218,246,118,15,0,169,106,77,109,72,10,53,233,22,8,59,77,22,12,210,81,150,152,15,225,197,40,190,115,239,141,44,161,244,101,225,53,224,119,17,62,46,13,75,140,146,115,96,117,161,207,39,29,146,149,200,26,94,72,30,133,197,8,152,243,14,142,216,65,230,103,45,103,54,160,120,14,192,26,224,93,24,156,177,7,71,77,126,201,52,150,144,116,177,16,24,75,190,223,81,197,215,170,34,52,102,215,231,126,246,169,55,91,88,13,58,34,234,141,154,213,186,151,128,170,138,42,110,73,210,22,75,139,85,132,204,10,255,166,33,231,122,81,242,235,63,162,224,40,26,135,139,210,250,130,83,113,92,194,159,250,93,76,146,3,218,240,141,86,34,107,72,35,56,127,50,207,174,105,126,210,247,182,179,167,244,74,47,203,34,180,143,72,174,39,253,134,198,5,205,121,62,67,255,242,31,104,127,121,162,233,27,115,231,115,197,180,184,61,159,151,219,157,229,123,189,11,68,210,108,221,87,34,180,142,212,188,83,73,242,17,63,216,24,156,82,187,29,16,222,31,183,231,199,92,185,29,174,180,154,252,4,195,190,223,216,201,17,28,116,13,34,94,141,133,241,4,79,39,72,180,97,119,55,43,55,105,206,106,251,196,201,132,226,65,115,170,105,227,242,135,34,4,198,49,199,91,184,120,255,102,77,135,105,153,140,175,167,191,49,233,220,125,134,255,247,38,122,167,206,224,243,207,95,1,63,15,14,13,5,0,0 };
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

