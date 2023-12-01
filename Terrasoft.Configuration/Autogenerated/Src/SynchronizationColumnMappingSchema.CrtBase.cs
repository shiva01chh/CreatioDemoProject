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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,65,110,195,32,16,69,215,65,242,29,70,202,222,222,55,85,55,110,187,75,55,233,5,40,198,14,18,12,136,129,74,78,213,187,151,128,227,218,81,149,102,199,12,243,249,143,15,200,141,36,199,133,132,119,233,61,39,219,135,186,181,216,171,33,122,30,148,197,250,5,131,10,227,97,68,113,244,22,213,41,119,43,246,85,177,138,109,182,94,14,169,132,86,115,162,7,184,154,106,173,142,6,247,220,57,133,67,158,111,154,6,30,41,26,195,253,248,52,213,201,46,112,133,4,180,86,131,200,114,48,69,15,10,123,235,77,129,186,28,213,44,206,114,241,67,43,1,226,140,242,15,201,166,208,207,248,123,25,142,182,75,23,120,85,82,119,84,54,175,89,115,227,96,163,79,97,77,104,152,210,171,231,217,37,204,133,134,130,63,179,23,89,161,120,75,162,221,13,139,103,73,65,225,42,130,187,125,22,218,251,204,202,20,124,114,29,37,37,59,227,120,122,119,235,111,187,253,153,110,59,139,225,119,57,121,111,37,118,37,235,92,127,151,207,179,106,230,30,99,63,65,154,239,154,145,2,0,0 };
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

