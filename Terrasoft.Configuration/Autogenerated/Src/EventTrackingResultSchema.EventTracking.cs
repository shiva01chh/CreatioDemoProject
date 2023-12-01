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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,193,74,3,49,16,134,207,187,176,239,16,232,85,138,90,173,32,120,88,237,10,69,176,96,235,3,164,217,217,109,232,102,18,38,19,97,17,223,221,217,180,160,135,230,52,249,254,143,159,97,80,59,136,65,27,80,59,32,210,209,119,60,127,241,216,217,62,145,102,235,113,222,124,1,242,142,180,57,90,236,63,32,166,129,171,242,187,42,171,178,152,17,244,162,168,6,147,123,84,23,69,177,66,218,15,214,40,16,233,178,83,72,91,81,108,142,234,73,93,95,77,99,29,236,27,140,239,158,95,125,194,86,240,77,198,107,236,100,67,166,100,56,17,72,188,130,48,248,17,38,227,54,27,27,62,0,53,68,158,4,45,254,117,213,3,129,110,199,207,152,229,187,115,157,241,68,96,248,57,184,58,241,65,52,201,238,115,182,29,227,22,152,101,201,117,108,92,224,41,89,230,100,229,157,182,248,71,31,4,254,156,174,1,216,158,14,50,125,133,201,251,5,106,209,67,90,95,1,0,0 };
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

