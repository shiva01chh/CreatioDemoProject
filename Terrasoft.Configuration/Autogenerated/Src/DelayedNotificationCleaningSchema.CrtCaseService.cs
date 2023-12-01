namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DelayedNotificationCleaningSchema

	/// <exclude/>
	public class DelayedNotificationCleaningSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DelayedNotificationCleaningSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DelayedNotificationCleaningSchema(DelayedNotificationCleaningSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("df08478c-376b-45c2-ab1f-44f5d2bfcce8");
			Name = "DelayedNotificationCleaning";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,193,78,227,48,16,61,7,137,127,24,101,47,137,132,156,59,148,74,208,238,162,34,129,208,118,171,61,187,206,180,53,114,236,106,108,23,42,196,191,239,196,73,11,97,17,248,228,121,243,230,205,243,140,173,108,208,111,165,66,248,131,68,210,187,85,16,19,103,87,122,29,73,6,237,236,233,201,203,233,73,22,189,182,107,152,239,125,192,134,243,198,160,106,147,94,220,160,69,210,234,226,200,153,56,194,97,36,166,215,31,128,185,218,96,29,13,18,227,156,249,65,184,102,49,152,24,233,61,156,195,20,141,220,99,125,239,130,94,105,149,92,76,12,74,203,245,137,95,85,21,140,124,108,26,73,251,113,31,255,198,45,161,71,27,60,72,80,61,27,30,221,18,220,10,164,33,148,245,30,218,60,216,119,178,94,28,228,170,119,122,219,184,52,90,177,74,107,231,11,51,108,117,118,235,150,63,159,81,197,224,136,43,95,146,191,227,131,238,48,108,92,221,62,233,33,73,118,217,143,246,19,192,109,48,160,255,198,234,255,94,59,100,43,73,54,96,121,151,151,121,244,72,188,65,219,109,40,31,47,56,6,117,4,196,168,74,236,207,139,211,157,141,144,207,199,15,199,251,160,166,159,206,78,83,136,210,192,206,233,26,186,17,96,177,24,244,134,161,149,51,152,77,117,186,177,247,145,15,196,35,60,3,183,124,228,244,24,222,58,151,208,254,184,44,219,73,130,58,141,5,46,193,226,83,63,163,98,168,90,38,110,38,126,145,107,138,252,147,109,229,7,198,223,13,18,22,249,149,106,125,207,209,214,83,25,48,47,5,147,139,82,204,252,125,52,166,40,65,250,190,209,69,170,235,28,136,195,11,203,132,190,102,89,191,105,150,233,150,157,226,215,238,63,15,64,198,248,252,3,191,50,227,124,104,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("df08478c-376b-45c2-ab1f-44f5d2bfcce8"));
		}

		#endregion

	}

	#endregion

}

