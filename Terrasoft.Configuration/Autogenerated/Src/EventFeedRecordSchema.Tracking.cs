namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventFeedRecordSchema

	/// <exclude/>
	public class EventFeedRecordSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventFeedRecordSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventFeedRecordSchema(EventFeedRecordSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("effa70fc-e7f0-40c3-a8f5-cf38bfc84003");
			Name = "EventFeedRecord";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,148,77,143,211,48,16,134,207,187,210,254,135,209,114,97,47,233,157,229,67,75,11,90,36,62,170,54,130,3,226,224,56,147,196,224,216,145,61,233,82,42,254,59,19,167,75,203,210,4,135,30,210,216,239,235,231,157,25,37,49,162,70,223,8,137,144,162,115,194,219,130,146,185,53,133,42,91,39,72,89,147,164,78,200,111,202,148,23,231,187,139,243,179,214,243,45,172,183,158,176,190,126,176,78,86,173,33,85,99,178,70,167,132,86,63,2,128,93,236,123,228,176,228,5,204,181,240,254,9,188,218,160,161,215,136,249,10,165,117,121,176,204,102,51,120,234,219,186,22,110,251,124,191,94,164,31,192,102,95,81,18,220,85,74,86,32,173,33,161,140,7,101,10,235,234,144,0,133,179,53,72,109,219,28,68,102,91,2,107,16,92,32,247,7,248,120,193,97,201,125,202,236,40,230,243,66,144,224,150,137,251,164,47,188,209,180,153,86,146,121,92,233,223,133,158,237,66,177,191,27,90,58,219,160,35,133,220,213,50,156,236,245,128,125,135,117,134,238,241,123,30,50,60,131,75,149,95,94,117,9,247,17,158,92,55,189,144,241,38,135,29,148,72,215,224,187,203,207,97,10,109,27,28,230,164,172,198,146,12,255,15,147,130,43,146,180,17,186,29,65,125,236,228,88,150,180,158,134,81,115,86,99,73,185,160,211,69,165,252,148,122,18,117,19,75,170,28,22,39,73,183,44,196,66,216,202,239,24,186,147,160,213,94,140,133,105,97,202,86,148,167,251,123,187,23,99,97,141,22,212,189,78,39,97,203,189,24,11,203,156,189,243,3,93,190,236,181,169,77,250,209,46,125,44,206,75,135,104,62,169,156,170,63,129,202,208,11,88,31,212,105,192,91,84,101,69,131,196,94,158,134,92,170,239,168,23,216,140,20,122,176,76,67,223,108,132,210,227,51,56,88,254,3,253,143,105,28,121,166,193,231,86,91,55,62,146,131,229,33,154,191,215,104,242,254,147,29,130,250,184,227,205,176,115,252,251,5,11,56,213,164,27,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("effa70fc-e7f0-40c3-a8f5-cf38bfc84003"));
		}

		#endregion

	}

	#endregion

}

