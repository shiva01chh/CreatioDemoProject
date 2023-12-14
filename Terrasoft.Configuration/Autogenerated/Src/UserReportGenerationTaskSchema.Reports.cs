namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UserReportGenerationTaskSchema

	/// <exclude/>
	public class UserReportGenerationTaskSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UserReportGenerationTaskSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UserReportGenerationTaskSchema(UserReportGenerationTaskSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd121194-abe4-482b-9424-0b625f81bd05");
			Name = "UserReportGenerationTask";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,81,61,111,194,48,16,157,131,196,127,56,137,5,36,68,118,210,118,97,136,88,42,84,96,170,58,152,228,146,90,77,236,232,238,60,80,212,255,94,219,73,41,84,32,53,131,35,61,223,251,58,27,213,34,119,170,64,216,33,145,98,91,201,98,101,77,165,107,71,74,180,53,227,209,105,60,74,28,107,83,195,246,200,130,109,54,30,121,100,66,88,251,107,88,53,138,121,9,123,70,122,193,206,146,228,104,176,167,238,20,127,196,217,215,45,146,86,141,254,84,135,6,223,60,208,185,67,163,11,40,2,247,46,21,150,112,91,49,57,69,213,223,8,214,176,144,43,196,146,79,178,137,218,253,196,224,115,207,97,58,131,80,46,249,250,223,244,205,144,226,143,57,228,78,151,224,60,113,93,206,130,84,178,132,131,98,156,134,219,69,152,91,151,243,56,186,232,69,158,253,218,7,243,100,31,105,240,56,240,179,139,68,19,52,101,95,242,186,241,134,108,135,36,26,255,244,77,211,20,30,216,181,173,162,227,211,15,144,163,48,88,2,14,127,101,64,151,104,68,87,26,9,108,21,77,65,222,149,128,54,90,226,43,33,80,12,9,245,185,106,159,253,108,145,94,122,12,107,139,43,24,186,156,60,85,178,224,152,193,237,42,61,122,13,70,204,127,223,212,124,56,73,148,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd121194-abe4-482b-9424-0b625f81bd05"));
		}

		#endregion

	}

	#endregion

}

