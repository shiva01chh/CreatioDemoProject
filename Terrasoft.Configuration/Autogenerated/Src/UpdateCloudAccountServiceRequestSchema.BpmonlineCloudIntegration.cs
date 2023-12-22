namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpdateCloudAccountServiceRequestSchema

	/// <exclude/>
	public class UpdateCloudAccountServiceRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpdateCloudAccountServiceRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpdateCloudAccountServiceRequestSchema(UpdateCloudAccountServiceRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("924fae82-030c-42fa-84b9-94064bc4d89e");
			Name = "UpdateCloudAccountServiceRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,145,65,79,194,64,16,133,207,146,240,31,38,112,209,75,185,11,146,16,52,132,40,134,80,61,25,15,203,118,138,27,219,221,186,51,53,169,196,255,238,116,75,17,136,7,236,165,217,55,111,222,126,51,107,85,142,84,40,141,240,132,222,43,114,41,71,83,103,83,179,41,189,98,227,108,52,189,139,23,46,193,140,186,157,109,183,115,81,146,177,27,136,43,98,204,197,153,101,168,107,27,69,51,180,232,141,30,158,122,86,165,101,147,99,20,75,85,101,230,43,164,138,75,124,125,143,27,57,192,52,83,68,215,240,92,36,138,113,154,185,50,153,104,237,164,79,122,62,141,198,21,126,148,72,28,122,6,131,1,140,168,204,115,229,171,241,238,188,194,194,35,161,101,2,223,88,129,29,148,33,14,168,201,32,112,41,240,27,130,106,162,163,54,107,112,16,246,114,171,88,201,248,236,149,230,87,17,138,114,157,25,13,186,6,60,131,239,98,27,24,247,131,45,189,43,208,179,65,153,110,25,162,154,250,233,16,65,152,161,240,59,47,192,242,175,73,39,203,57,188,99,21,237,59,14,81,27,214,5,230,107,244,151,143,242,138,112,3,61,85,152,123,172,122,87,53,122,203,78,236,235,215,152,132,18,108,97,131,60,172,239,24,194,247,127,96,116,61,246,239,50,69,103,137,37,72,197,116,176,210,51,65,219,156,99,212,7,67,60,218,237,116,110,83,55,134,184,189,239,15,238,62,218,164,217,115,56,55,234,177,24,180,131,239,7,65,247,190,115,238,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("924fae82-030c-42fa-84b9-94064bc4d89e"));
		}

		#endregion

	}

	#endregion

}

