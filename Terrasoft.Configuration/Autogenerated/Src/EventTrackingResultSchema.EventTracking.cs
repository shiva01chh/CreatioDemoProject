namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventTrackingResultSchema

	/// <exclude/>
	public class EventTrackingResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventTrackingResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventTrackingResultSchema(EventTrackingResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("994af77d-fdfe-407e-9278-b280ee07b73c");
			Name = "EventTrackingResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("47949cd8-6780-414e-8fda-4fa996b6db3c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,203,106,195,48,16,69,215,54,248,31,4,221,150,208,54,125,64,161,11,183,113,32,20,18,104,210,15,80,229,177,35,98,141,196,104,84,48,161,255,222,177,82,104,22,209,106,116,238,225,50,12,106,7,49,104,3,106,7,68,58,250,142,103,111,30,59,219,39,210,108,61,206,154,111,64,222,145,54,7,139,253,7,196,52,112,85,30,171,178,42,139,43,130,94,20,213,96,114,207,234,162,40,86,72,95,131,53,10,68,186,236,20,210,86,20,155,131,122,81,55,215,211,88,7,251,14,227,218,243,210,39,108,5,223,102,188,194,78,54,100,74,134,19,129,196,11,8,131,31,97,50,238,178,177,225,61,80,67,228,73,208,252,172,171,30,8,116,59,126,198,44,223,255,213,25,79,4,134,95,131,171,19,239,69,147,236,33,103,219,49,110,129,89,150,92,197,198,5,158,146,199,156,44,188,211,22,255,233,147,192,159,211,53,0,219,211,65,166,175,176,243,247,11,154,187,160,14,104,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("994af77d-fdfe-407e-9278-b280ee07b73c"));
		}

		#endregion

	}

	#endregion

}

