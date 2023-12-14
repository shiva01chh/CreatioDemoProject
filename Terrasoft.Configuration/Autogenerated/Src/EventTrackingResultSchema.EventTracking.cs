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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,221,74,3,49,16,70,175,119,97,223,33,224,173,20,255,5,193,139,213,174,80,4,11,182,62,64,154,157,221,134,110,38,97,50,17,22,241,221,157,164,130,94,52,87,147,243,29,62,134,65,237,32,6,109,64,109,129,72,71,63,240,226,217,227,96,199,68,154,173,199,69,247,9,200,91,210,230,96,113,124,135,152,38,110,234,175,166,110,234,234,140,96,20,69,117,152,220,131,58,41,138,21,210,110,178,70,129,72,167,157,74,218,170,106,125,80,143,234,226,60,143,109,176,175,48,191,121,126,241,9,123,193,151,5,175,112,144,13,153,146,225,68,32,241,18,194,228,103,200,198,85,49,214,188,7,234,136,60,9,186,254,215,213,78,4,186,159,63,98,145,111,126,235,140,39,2,195,79,193,181,137,247,162,73,118,91,178,205,28,55,192,44,75,174,98,231,2,231,228,174,36,75,239,180,197,63,122,47,240,251,120,13,192,254,120,144,252,21,150,223,15,4,205,234,159,96,1,0,0 };
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

