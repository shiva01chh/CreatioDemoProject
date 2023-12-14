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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,145,65,79,2,49,16,133,207,146,240,31,38,112,209,203,114,23,36,33,104,8,81,12,1,61,25,15,165,59,139,141,187,237,218,153,154,32,241,191,59,219,101,17,136,7,220,203,166,111,222,188,126,51,181,170,64,42,149,70,120,66,239,21,185,140,147,177,179,153,89,7,175,216,56,155,140,239,150,51,151,98,78,237,214,182,221,186,8,100,236,26,150,27,98,44,196,153,231,168,43,27,37,19,180,232,141,238,159,122,22,193,178,41,48,89,74,85,229,230,43,166,138,75,124,93,143,107,57,192,56,87,68,215,240,92,166,138,113,156,187,144,142,180,118,210,39,61,159,70,227,2,63,2,18,199,158,94,175,7,3,10,69,161,252,102,184,59,47,176,244,72,104,153,192,215,86,96,7,33,198,1,213,25,4,46,3,126,67,80,117,116,210,100,245,14,194,94,110,21,43,25,159,189,210,252,42,66,25,86,185,209,160,43,192,51,248,46,182,145,113,63,216,220,187,18,61,27,148,233,230,49,170,174,159,14,17,133,9,10,191,243,2,44,255,138,116,52,159,194,59,110,146,125,199,33,106,205,58,195,98,133,254,242,81,94,17,110,160,163,74,115,143,155,206,85,133,222,176,19,251,234,53,70,177,4,91,88,35,247,171,59,250,240,253,31,24,93,141,253,187,76,209,89,98,9,50,49,29,172,244,76,208,38,231,24,245,193,16,15,118,59,157,218,204,13,97,217,220,247,7,119,23,109,90,239,57,158,107,245,88,140,154,124,63,37,227,204,73,230,2,0,0 };
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

