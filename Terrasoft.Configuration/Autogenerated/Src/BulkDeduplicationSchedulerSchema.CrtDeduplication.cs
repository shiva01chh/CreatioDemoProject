﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkDeduplicationSchedulerSchema

	/// <exclude/>
	public class BulkDeduplicationSchedulerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkDeduplicationSchedulerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkDeduplicationSchedulerSchema(BulkDeduplicationSchedulerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("81746d10-e0d6-4a26-8a1a-6730dd82ee81");
			Name = "BulkDeduplicationScheduler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,86,219,78,27,49,16,125,14,18,255,96,133,151,68,138,54,125,134,130,84,146,130,82,9,148,22,80,165,86,21,50,222,217,196,176,107,175,198,222,180,41,202,191,119,118,237,189,37,202,5,212,60,197,246,204,153,153,51,199,227,85,60,1,147,114,1,236,30,16,185,209,145,13,70,90,69,114,150,33,183,82,171,96,12,97,150,198,82,20,171,227,163,215,227,163,78,102,164,154,177,187,165,177,144,156,173,173,201,59,142,65,228,198,38,184,6,5,40,69,109,243,53,227,104,255,174,175,131,73,146,198,193,61,202,217,12,208,212,167,205,148,16,182,237,7,87,92,88,141,18,182,122,6,119,98,78,85,196,128,100,65,54,39,8,51,202,143,141,98,110,204,41,123,188,204,226,151,86,153,119,192,81,204,43,175,194,105,56,28,178,143,38,75,18,142,203,11,191,30,67,196,179,216,50,73,249,67,2,202,22,222,76,71,204,206,129,172,1,152,64,136,206,187,147,205,16,37,120,119,120,193,164,178,128,17,117,33,40,3,13,27,145,126,250,48,151,82,133,84,92,207,46,83,208,81,111,7,102,191,255,139,252,210,236,137,78,152,200,171,100,219,141,217,41,219,1,69,56,121,203,107,206,168,175,150,43,75,188,77,81,46,184,133,130,157,78,234,22,76,228,231,204,88,44,36,225,81,66,71,232,216,227,131,249,162,159,174,81,103,41,59,103,221,141,216,221,179,119,66,222,146,152,167,220,18,151,42,7,126,253,176,218,106,253,238,24,83,212,2,140,201,67,85,201,87,231,206,222,155,148,33,78,64,133,142,60,191,246,76,94,73,136,195,109,52,34,240,80,171,120,201,30,12,32,113,174,220,149,98,143,89,107,189,39,68,209,44,204,242,235,145,7,42,244,224,227,56,109,108,239,123,111,45,112,59,110,159,21,162,232,172,165,67,140,108,228,215,233,172,118,39,121,3,118,174,183,18,97,242,59,37,202,206,92,131,117,28,251,110,247,252,190,161,180,19,158,239,148,153,33,216,140,100,224,206,131,43,141,9,183,189,3,197,51,104,226,189,173,132,6,197,197,61,150,106,78,19,208,134,90,236,159,4,213,152,170,74,164,217,208,104,214,66,203,144,109,216,244,26,242,107,151,55,229,72,5,80,65,44,220,107,82,210,182,224,216,40,158,250,185,223,53,168,167,165,243,58,171,144,4,106,245,249,79,138,116,27,156,58,14,64,163,22,143,90,110,189,126,13,248,236,250,68,72,255,169,177,37,106,21,223,16,182,130,223,108,44,11,1,211,8,254,232,66,13,152,126,122,38,85,95,120,166,58,175,172,91,215,220,109,66,179,213,160,48,89,181,66,140,193,114,25,19,252,167,52,173,123,62,162,155,110,193,143,140,188,157,14,220,23,234,112,58,123,231,232,1,118,141,193,229,173,215,46,111,240,93,227,75,241,45,16,236,48,26,101,136,244,208,229,211,161,105,214,162,176,223,86,128,127,216,61,177,163,122,39,127,246,75,54,125,91,219,117,151,111,196,161,245,223,203,4,126,104,149,3,149,127,39,42,210,193,131,21,222,98,180,174,200,50,165,134,222,218,170,237,123,207,27,105,34,137,132,231,38,170,243,222,220,12,26,245,5,99,125,171,237,156,196,211,148,67,171,253,147,226,53,21,245,39,74,46,129,74,44,131,38,127,173,73,244,246,225,50,134,152,154,179,107,180,172,89,108,159,173,173,10,190,65,162,23,69,218,155,195,185,246,28,236,239,225,174,73,235,118,155,155,197,14,253,254,1,233,7,158,11,193,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("81746d10-e0d6-4a26-8a1a-6730dd82ee81"));
		}

		#endregion

	}

	#endregion

}
