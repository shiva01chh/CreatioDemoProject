namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MacrosWorkerExtendedPropertiesSchema

	/// <exclude/>
	public class MacrosWorkerExtendedPropertiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MacrosWorkerExtendedPropertiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MacrosWorkerExtendedPropertiesSchema(MacrosWorkerExtendedPropertiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("46e56cc0-b0c4-4b85-901f-98aac1edceeb");
			Name = "MacrosWorkerExtendedProperties";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,193,78,195,48,12,134,207,157,180,119,176,198,189,189,111,176,3,211,132,56,32,77,2,196,217,75,220,206,90,155,86,118,34,168,38,222,157,44,221,74,65,72,228,100,255,206,111,127,78,28,54,164,29,26,130,23,18,65,109,75,159,111,90,87,114,21,4,61,183,110,62,59,205,103,89,80,118,21,60,247,234,169,89,141,249,212,34,244,183,62,105,149,191,122,174,53,94,139,23,111,132,170,40,193,166,70,213,37,60,161,145,86,223,90,57,146,108,63,60,57,75,118,39,109,71,226,153,52,57,138,162,128,91,13,77,131,210,175,47,121,114,3,59,131,157,134,26,61,1,90,203,231,89,88,67,55,250,225,253,192,230,0,6,29,236,9,130,146,141,158,216,140,8,140,80,121,183,184,71,165,173,243,236,251,41,200,162,88,231,215,193,197,100,114,23,246,53,27,48,105,248,127,228,217,41,209,143,11,127,215,150,176,75,141,134,250,239,245,146,48,60,56,152,80,251,32,4,108,41,66,150,76,146,143,150,41,216,149,236,33,176,61,123,55,131,239,209,194,249,15,179,172,34,191,74,129,94,130,207,11,91,164,30,240,82,62,168,63,197,168,77,207,23,148,61,47,90,55,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("46e56cc0-b0c4-4b85-901f-98aac1edceeb"));
		}

		#endregion

	}

	#endregion

}

