namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ScheduleMailingStateSchema

	/// <exclude/>
	public class ScheduleMailingStateSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ScheduleMailingStateSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ScheduleMailingStateSchema(ScheduleMailingStateSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("196c6b02-4784-4c5a-9831-b4fc6e589e4f");
			Name = "ScheduleMailingState";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,81,77,107,2,49,16,61,175,224,127,24,60,233,197,189,183,186,80,196,182,66,237,161,219,91,233,33,102,103,53,144,77,150,153,196,143,22,255,123,39,138,86,10,45,165,52,144,64,102,222,123,51,243,198,169,6,185,85,26,225,25,137,20,251,58,12,39,222,213,102,25,73,5,227,93,183,243,222,237,100,145,141,91,66,185,227,128,205,117,183,35,145,54,46,172,209,160,173,98,134,82,175,176,138,22,231,202,88,1,150,65,5,132,43,184,252,10,37,9,157,120,126,45,229,76,133,112,23,77,245,242,10,55,107,193,170,133,197,91,79,211,45,234,152,106,39,98,100,100,24,23,16,86,228,55,224,112,3,143,62,204,154,214,98,131,46,96,53,221,106,108,19,184,63,56,54,150,181,228,3,106,73,125,22,225,64,169,255,41,145,167,57,50,171,37,150,135,208,196,75,246,191,212,215,66,121,208,111,127,85,206,243,28,70,28,155,70,209,174,56,5,142,94,136,5,97,101,88,42,137,147,195,51,56,255,138,30,17,134,72,142,139,153,19,168,147,173,250,90,52,17,65,19,214,227,222,229,66,206,46,63,33,71,27,122,121,49,28,229,39,254,55,147,254,192,135,123,229,42,43,182,98,59,147,249,200,41,219,31,192,97,229,217,239,60,200,178,189,60,114,247,201,143,116,62,0,164,68,5,10,157,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("196c6b02-4784-4c5a-9831-b4fc6e589e4f"));
		}

		#endregion

	}

	#endregion

}

