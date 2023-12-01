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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,193,110,219,48,12,61,171,64,255,129,200,46,54,48,216,247,165,9,48,116,195,208,75,87,52,233,174,131,106,211,129,48,91,50,40,41,64,16,244,223,71,75,118,98,123,115,124,176,77,234,145,124,143,164,180,108,208,182,178,64,216,35,145,180,166,114,217,163,209,149,58,120,146,78,25,157,237,73,22,127,148,62,220,223,157,239,239,132,183,252,11,187,147,117,216,172,47,246,56,150,240,234,239,172,152,13,54,193,152,230,102,32,67,63,17,30,216,128,199,90,90,251,5,134,122,223,164,147,47,100,142,170,68,10,184,60,207,225,193,250,166,145,116,218,246,118,15,0,165,43,67,77,72,10,21,153,6,8,91,67,14,44,210,81,21,152,13,225,249,40,190,245,239,181,42,160,232,202,194,107,192,239,34,124,92,26,150,24,137,115,96,117,161,207,39,45,146,83,200,26,94,72,29,165,195,8,152,243,14,142,216,65,230,231,28,103,182,160,121,14,192,26,224,93,90,156,177,7,79,117,118,201,52,150,32,218,88,8,172,163,174,223,81,197,215,178,36,180,118,215,231,126,238,82,111,182,176,26,116,68,212,27,213,171,117,47,1,117,25,85,220,146,100,28,22,14,203,8,153,21,254,77,67,206,245,162,228,215,127,68,193,81,214,30,23,165,245,5,167,226,184,68,119,218,237,162,16,7,116,225,27,45,161,42,72,34,56,123,178,207,190,174,127,210,247,166,117,167,228,74,47,77,35,180,143,16,215,147,126,67,227,130,102,60,159,161,127,217,15,116,191,58,162,201,27,115,231,115,205,180,184,61,159,151,219,157,102,123,179,11,68,146,116,221,87,34,116,158,244,188,83,66,124,196,15,214,22,167,212,110,7,132,247,199,237,249,49,87,110,135,47,156,161,110,130,97,223,111,236,228,8,14,166,2,25,175,198,194,120,130,167,149,36,155,176,187,155,149,159,52,103,181,125,226,100,82,243,160,57,213,180,113,217,67,30,2,227,152,227,45,92,188,127,179,166,195,180,76,202,215,179,187,49,201,220,125,134,255,247,38,122,167,206,224,227,231,47,36,67,221,219,12,5,0,0 };
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

