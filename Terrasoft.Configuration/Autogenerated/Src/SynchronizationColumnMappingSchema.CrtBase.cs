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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,193,110,131,48,12,134,207,69,226,29,44,245,14,247,117,218,133,109,183,238,210,189,64,22,2,181,68,156,40,78,38,209,105,239,190,52,161,12,170,169,107,78,216,248,247,255,241,19,18,90,177,21,82,193,187,114,78,176,233,124,213,24,234,176,15,78,120,52,84,189,144,71,63,30,70,146,71,103,8,79,169,91,22,95,101,81,22,155,173,83,125,44,161,25,4,243,3,92,77,53,102,8,154,246,194,90,164,62,205,215,117,13,143,28,180,22,110,124,154,234,104,231,5,18,3,175,213,32,147,28,116,214,3,82,103,156,206,80,151,85,245,98,151,13,31,3,74,144,103,148,127,72,54,153,126,198,223,43,127,52,109,252,128,87,84,67,203,249,229,53,107,106,28,76,112,49,172,9,141,98,122,213,60,187,132,185,208,176,119,103,246,44,203,20,111,81,180,187,97,241,172,216,35,173,34,184,219,103,161,189,207,44,79,193,167,24,130,226,104,167,173,136,255,221,184,219,110,127,166,219,204,98,248,125,156,188,183,138,218,156,117,170,191,243,229,89,53,83,111,113,126,0,241,222,16,235,154,2,0,0 };
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

