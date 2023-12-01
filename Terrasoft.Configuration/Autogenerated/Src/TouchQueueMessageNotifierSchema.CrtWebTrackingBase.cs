namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TouchQueueMessageNotifierSchema

	/// <exclude/>
	public class TouchQueueMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TouchQueueMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TouchQueueMessageNotifierSchema(TouchQueueMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("38be02db-3e45-4885-b616-878b6f010bac");
			Name = "TouchQueueMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,77,111,219,48,12,61,39,64,255,3,225,93,82,96,136,239,205,199,97,221,80,236,208,34,107,178,31,160,200,116,162,45,150,60,82,26,16,4,253,239,163,164,184,77,140,164,24,122,48,64,241,227,241,241,81,178,85,13,114,171,52,194,10,137,20,187,218,143,239,157,173,205,38,144,242,198,217,155,225,225,102,56,8,108,236,6,150,123,246,216,76,94,207,167,37,132,226,151,200,39,194,141,148,193,253,78,49,223,193,202,5,189,253,17,48,224,35,50,171,13,62,57,111,106,131,148,146,203,178,132,41,135,166,81,180,159,31,207,169,16,188,3,27,51,247,160,214,46,120,57,11,14,252,137,64,208,100,36,104,201,105,49,35,19,66,14,59,207,227,14,179,60,1,109,195,122,103,52,232,132,123,149,15,220,193,23,197,120,153,234,224,144,232,190,13,231,44,123,10,218,59,146,25,23,169,65,206,232,79,148,71,122,75,135,90,190,41,35,130,38,172,103,197,85,62,69,57,207,148,199,175,176,101,31,119,218,42,82,13,88,217,225,172,8,140,36,141,44,234,184,182,98,62,45,83,52,37,31,37,184,218,108,244,243,172,24,206,177,110,69,155,181,104,51,234,187,15,240,114,212,5,109,149,165,57,215,105,65,206,75,50,86,23,68,50,118,139,100,124,229,116,153,57,118,185,224,254,202,189,50,21,130,136,22,151,219,177,124,146,57,97,54,135,44,218,194,25,235,185,152,124,8,242,25,27,99,43,177,150,122,139,141,234,144,163,146,174,30,37,252,219,201,251,179,61,162,223,186,234,210,250,255,131,198,67,48,21,60,160,95,134,245,47,9,125,175,70,241,242,173,20,255,62,93,79,119,211,69,233,136,51,32,244,129,108,42,30,127,107,90,191,143,79,113,240,242,33,5,164,121,214,85,167,103,254,21,89,147,105,163,249,46,149,207,93,189,107,49,255,32,158,211,211,235,81,236,69,79,121,246,244,204,222,115,103,242,13,135,255,0,169,72,244,92,156,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("38be02db-3e45-4885-b616-878b6f010bac"));
		}

		#endregion

	}

	#endregion

}

