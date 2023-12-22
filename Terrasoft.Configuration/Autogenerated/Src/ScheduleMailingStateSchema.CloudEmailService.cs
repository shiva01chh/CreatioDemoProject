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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,81,77,107,195,48,12,61,167,208,255,32,122,106,47,205,125,107,3,163,116,91,97,221,97,217,109,236,224,58,74,98,112,236,32,217,253,216,232,127,159,210,210,174,12,54,198,152,193,6,75,239,61,73,79,78,53,200,173,210,8,207,72,164,216,151,97,60,243,174,52,85,36,21,140,119,253,222,123,191,151,68,54,174,130,124,199,1,155,235,126,79,34,109,92,89,163,65,91,197,12,185,174,177,136,22,151,202,88,1,230,65,5,132,43,184,252,10,165,19,58,241,252,90,202,153,2,225,46,154,226,229,21,110,214,130,85,43,139,183,158,230,91,212,177,171,221,17,35,35,195,52,131,80,147,223,128,195,13,60,250,176,104,90,139,13,186,128,197,124,171,177,237,192,195,209,177,177,164,37,31,80,75,234,179,8,7,234,250,159,19,121,90,34,179,170,48,63,132,102,94,178,255,165,190,22,202,131,126,251,171,114,154,166,48,225,216,52,138,118,217,41,112,244,66,44,8,181,97,169,36,78,142,207,224,244,43,122,66,24,34,57,206,22,78,160,78,182,234,75,209,68,4,77,88,78,7,151,11,57,187,252,132,28,109,24,164,217,120,146,158,248,223,76,250,3,31,238,149,43,172,216,138,237,66,230,35,167,236,112,4,135,149,39,191,243,32,73,246,242,200,221,119,126,92,158,15,0,242,151,71,165,2,0,0 };
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

