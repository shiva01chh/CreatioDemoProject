namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateBasedSentSinceSyncStrategySchema

	/// <exclude/>
	public class DateBasedSentSinceSyncStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateBasedSentSinceSyncStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateBasedSentSinceSyncStrategySchema(DateBasedSentSinceSyncStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("15be1ecd-0b88-4e9e-b6d5-d613f5e51e4e");
			Name = "DateBasedSentSinceSyncStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,219,110,219,48,12,125,118,129,254,3,225,189,116,64,22,239,57,109,3,108,137,7,20,88,131,110,78,62,64,177,25,79,152,45,25,20,61,212,8,242,239,163,47,73,229,44,205,242,224,136,20,121,120,120,72,25,85,162,171,84,138,176,70,34,229,236,142,167,207,74,23,183,55,251,219,155,160,118,218,228,222,205,194,154,157,206,107,82,172,173,185,191,24,64,248,158,127,26,27,214,172,209,73,128,132,124,32,204,5,5,22,133,114,110,6,75,197,248,85,57,204,18,52,156,104,147,98,210,152,52,97,169,133,121,211,101,68,81,4,15,174,46,75,69,205,252,100,35,66,74,184,123,12,159,252,132,48,154,131,46,171,2,75,129,83,154,173,153,64,134,133,254,131,132,25,236,200,150,126,234,91,241,49,196,244,88,37,58,47,75,40,230,111,119,180,175,179,135,90,110,128,45,56,44,48,101,80,69,1,198,242,167,140,212,142,39,253,81,110,88,130,100,26,78,229,232,38,3,176,107,177,36,207,48,100,130,245,70,200,35,80,213,219,66,167,144,182,66,254,143,137,47,244,72,223,96,223,105,124,26,203,11,217,10,137,155,89,123,98,97,141,89,31,112,62,133,206,145,160,162,244,23,224,107,69,210,64,155,207,40,234,15,140,255,213,48,168,142,160,96,101,36,164,51,105,146,169,93,154,141,113,66,236,217,229,61,230,143,26,169,129,118,25,131,32,71,30,78,1,33,215,100,32,220,172,150,63,191,124,91,131,252,199,223,227,117,188,132,36,94,173,147,167,213,34,134,253,231,67,120,223,133,31,218,239,97,104,16,77,214,247,56,110,88,118,91,24,212,41,91,146,117,124,233,52,189,210,241,130,80,186,115,151,183,232,146,244,221,70,74,9,37,254,119,68,233,60,149,34,85,130,145,119,249,24,202,222,144,240,50,162,148,80,12,231,27,177,33,61,57,166,15,81,23,125,57,185,149,49,65,102,17,213,133,115,143,103,251,190,183,246,53,241,239,125,114,62,234,176,91,215,91,187,219,140,120,194,152,246,4,186,135,223,128,79,232,99,55,151,25,108,5,244,238,60,126,20,216,79,252,242,240,122,175,239,20,143,252,254,2,100,238,139,87,214,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("15be1ecd-0b88-4e9e-b6d5-d613f5e51e4e"));
		}

		#endregion

	}

	#endregion

}

