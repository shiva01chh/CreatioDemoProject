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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,145,65,79,194,64,16,133,207,146,240,31,38,112,209,75,123,23,36,33,104,8,81,12,1,61,25,15,203,118,90,55,182,187,117,103,106,130,196,255,238,116,75,17,136,7,60,109,246,205,155,183,223,204,90,85,32,149,74,35,60,161,247,138,92,202,209,196,217,212,100,149,87,108,156,141,38,119,171,185,75,48,167,110,103,219,237,92,84,100,108,6,171,13,49,22,226,204,115,212,181,141,162,41,90,244,70,15,78,61,203,202,178,41,48,90,73,85,229,230,43,164,138,75,124,125,143,153,92,96,146,43,162,107,120,46,19,197,56,201,93,149,140,181,118,210,39,61,159,70,227,18,63,42,36,14,61,113,28,195,144,170,162,80,126,51,218,221,151,88,122,36,180,76,224,27,43,176,131,42,196,1,53,25,4,46,5,126,67,80,77,116,212,102,197,7,97,47,183,138,149,140,207,94,105,126,21,161,172,214,185,209,160,107,192,51,248,46,182,129,113,63,216,194,187,18,61,27,148,233,22,33,170,169,159,14,17,132,41,10,191,243,2,44,103,77,58,94,204,224,29,55,209,190,227,16,181,97,157,99,177,70,127,249,40,191,8,55,208,83,165,185,199,77,239,170,70,111,217,137,125,253,27,227,80,130,45,100,200,131,250,141,1,124,255,7,70,215,99,255,46,83,116,150,88,130,84,76,7,43,61,19,180,205,57,70,125,48,196,195,221,78,103,54,117,35,88,181,239,253,193,221,71,155,52,123,14,247,70,61,22,131,214,233,252,0,202,24,206,170,229,2,0,0 };
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

