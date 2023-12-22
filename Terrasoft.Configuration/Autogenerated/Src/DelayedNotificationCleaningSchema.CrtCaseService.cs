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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,193,78,227,48,16,61,7,137,127,24,101,47,137,132,156,59,148,74,75,187,139,138,4,66,20,196,217,117,166,173,145,99,87,99,187,187,21,226,223,119,226,164,165,1,180,248,228,121,243,230,205,243,140,173,108,208,111,164,66,120,68,34,233,221,50,136,137,179,75,189,138,36,131,118,246,244,228,245,244,36,139,94,219,21,204,119,62,96,195,121,99,80,181,73,47,174,209,34,105,117,113,224,76,28,225,48,18,211,171,15,192,92,173,177,142,6,137,113,206,252,32,92,177,24,76,140,244,30,206,97,138,70,238,176,190,115,65,47,181,74,46,38,6,165,229,250,196,175,170,10,70,62,54,141,164,221,184,143,31,112,67,232,209,6,15,18,84,207,134,23,183,0,183,4,105,8,101,189,131,54,15,246,72,214,139,189,92,117,164,183,137,11,163,21,171,180,118,254,99,134,173,206,110,220,226,215,95,84,49,56,226,202,215,228,239,240,160,91,12,107,87,183,79,186,79,146,93,246,163,253,4,112,27,12,232,191,177,250,217,107,135,108,36,201,6,44,239,242,50,143,30,137,55,104,187,13,229,227,39,142,65,29,0,49,170,18,251,235,226,116,103,35,228,243,241,253,225,62,168,233,167,179,213,20,162,52,176,117,186,134,110,4,88,60,13,122,195,208,202,25,204,166,58,221,216,251,200,7,226,17,158,129,91,188,112,122,12,239,157,75,104,127,92,150,109,37,65,157,198,2,151,96,241,79,63,163,98,168,90,38,110,38,126,147,107,138,252,139,109,229,123,198,243,26,9,139,252,167,106,125,207,209,214,83,25,48,47,5,147,139,82,204,252,93,52,166,40,65,250,190,209,69,170,235,28,136,253,11,203,132,190,101,89,191,105,150,233,150,157,226,183,238,63,15,64,198,142,207,63,43,168,49,203,113,3,0,0 };
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

