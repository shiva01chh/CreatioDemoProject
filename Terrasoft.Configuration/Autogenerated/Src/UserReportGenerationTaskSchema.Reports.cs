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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,81,177,110,194,48,16,157,19,137,127,56,137,5,36,68,118,210,118,97,64,44,21,42,48,85,29,76,114,73,79,77,236,232,124,30,40,234,191,215,118,82,10,21,72,93,108,233,249,189,123,239,157,181,106,209,118,170,64,216,33,179,178,166,146,249,210,232,138,106,199,74,200,232,81,122,26,165,137,179,164,107,216,30,173,96,155,143,82,143,140,25,107,255,12,203,70,89,187,128,189,69,126,193,206,176,172,80,99,47,221,41,251,17,185,175,91,100,82,13,125,170,67,131,111,30,232,220,161,161,2,138,160,189,43,133,5,220,158,152,156,226,212,223,8,70,91,97,87,136,97,159,100,19,103,247,140,193,231,158,195,100,10,161,92,242,245,63,246,205,144,226,143,25,172,28,149,224,188,112,93,78,195,168,100,1,7,101,113,18,94,231,129,183,46,103,145,58,239,135,60,251,181,15,230,201,62,202,224,113,208,231,23,137,198,168,203,190,228,117,227,13,155,14,89,8,255,244,205,178,12,30,172,107,91,197,199,167,31,96,133,98,193,48,216,112,43,13,84,162,22,170,8,25,76,21,77,65,222,149,0,105,146,248,75,8,28,67,66,125,174,218,103,63,91,100,151,30,195,218,226,10,134,46,39,47,149,60,56,230,112,187,74,143,94,131,17,75,211,111,202,233,81,94,147,2,0,0 };
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

