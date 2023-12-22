namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AddSenderDomainsInfoRequestSchema

	/// <exclude/>
	public class AddSenderDomainsInfoRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AddSenderDomainsInfoRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AddSenderDomainsInfoRequestSchema(AddSenderDomainsInfoRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7cef863d-9684-4a82-a74b-e9746da57616");
			Name = "AddSenderDomainsInfoRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,77,79,194,64,20,60,75,194,127,120,41,23,189,180,119,62,76,20,140,241,128,33,148,155,241,176,180,175,117,147,118,183,190,183,197,32,241,191,187,221,5,172,64,32,244,210,190,233,204,244,205,108,149,40,145,43,145,32,44,144,72,176,206,76,56,214,42,147,121,77,194,72,173,194,241,83,60,213,41,22,220,237,108,186,157,110,231,166,102,169,114,136,215,108,176,12,231,181,50,178,196,48,70,146,162,144,223,78,51,112,188,30,97,110,7,24,23,130,185,15,15,105,26,163,74,145,38,186,20,82,241,139,202,244,28,63,107,100,227,232,81,20,193,144,235,178,20,180,190,223,206,78,10,153,38,32,207,4,163,65,164,41,40,252,2,118,110,144,58,187,112,231,16,29,88,12,25,81,20,172,33,33,204,70,193,197,148,225,163,96,180,105,86,50,193,237,122,1,68,141,219,219,68,24,97,85,134,68,98,222,45,80,213,203,66,38,144,184,37,207,196,131,62,28,155,90,189,175,115,223,211,140,116,133,100,36,218,178,102,206,218,191,63,44,198,1,207,104,24,108,47,220,220,205,7,182,106,56,238,193,35,43,81,212,184,31,23,167,52,127,20,23,118,138,229,18,233,246,213,254,35,48,130,192,211,131,187,38,251,46,60,27,106,254,6,31,26,54,144,163,25,52,75,13,224,231,154,237,85,243,9,157,185,231,138,244,74,218,34,175,203,114,193,225,124,178,157,160,153,79,230,155,181,8,167,82,246,236,209,251,99,116,179,71,255,131,14,107,95,191,56,45,99,243,123,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7cef863d-9684-4a82-a74b-e9746da57616"));
		}

		#endregion

	}

	#endregion

}

