namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SynchronizationColumnMappingSchema

	/// <exclude/>
	public class SynchronizationColumnMappingSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SynchronizationColumnMappingSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SynchronizationColumnMappingSchema(SynchronizationColumnMappingSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ceda90a8-7b55-4117-960b-9e514c386e94");
			Name = "SynchronizationColumnMapping";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,193,110,131,48,12,134,207,69,226,29,44,245,14,247,117,218,133,109,183,238,210,189,64,22,2,141,68,156,200,78,38,209,105,239,190,52,161,12,170,169,107,78,216,248,247,255,241,19,20,70,177,19,82,193,187,34,18,108,59,95,53,22,59,221,7,18,94,91,172,94,208,107,63,30,70,148,71,178,168,79,169,91,22,95,101,81,22,155,45,169,62,150,208,12,130,249,1,174,166,26,59,4,131,123,225,156,198,62,205,215,117,13,143,28,140,17,52,62,77,117,180,243,66,35,3,175,213,32,147,28,76,214,131,198,206,146,201,80,151,85,245,98,151,11,31,131,150,32,207,40,255,144,108,50,253,140,191,87,254,104,219,248,1,175,90,13,45,231,151,215,172,169,113,176,129,98,88,19,26,198,244,170,121,118,9,115,161,97,79,103,246,44,203,20,111,81,180,187,97,241,172,216,107,92,69,112,183,207,66,123,159,89,158,130,79,49,4,197,209,206,56,17,255,187,165,219,110,127,166,219,204,98,248,125,156,188,183,10,219,156,117,170,191,243,229,89,53,83,47,158,31,15,152,150,51,146,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ceda90a8-7b55-4117-960b-9e514c386e94"));
		}

		#endregion

	}

	#endregion

}

