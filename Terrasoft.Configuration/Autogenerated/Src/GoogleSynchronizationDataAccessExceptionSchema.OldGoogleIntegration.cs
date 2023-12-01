namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GoogleSynchronizationDataAccessExceptionSchema

	/// <exclude/>
	public class GoogleSynchronizationDataAccessExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GoogleSynchronizationDataAccessExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GoogleSynchronizationDataAccessExceptionSchema(GoogleSynchronizationDataAccessExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fa6fe31b-4855-4a7a-adcc-c5b7fb65f30f");
			Name = "GoogleSynchronizationDataAccessException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,146,81,75,195,48,20,133,159,91,232,127,184,108,47,45,140,246,189,234,64,166,248,42,204,63,112,151,221,214,64,155,132,36,69,235,240,191,155,38,235,218,13,31,38,106,222,114,184,231,220,239,144,8,108,201,40,100,4,47,164,53,26,89,217,124,35,69,197,235,78,163,229,82,36,241,33,137,147,56,234,12,23,53,108,123,99,169,189,241,202,82,83,237,6,96,211,160,49,37,60,73,89,55,180,237,5,123,213,82,240,15,239,126,64,139,247,140,145,49,143,239,140,84,8,116,222,162,40,224,214,116,109,139,186,95,31,239,33,0,80,113,216,59,27,160,247,1,141,70,120,211,168,20,233,124,244,23,179,0,213,237,26,206,128,13,44,87,163,64,9,51,172,40,20,157,122,73,97,172,238,152,149,218,213,123,246,11,194,196,37,253,81,32,2,166,169,186,91,156,66,211,108,81,172,243,211,196,28,120,36,190,150,53,205,224,48,216,62,127,138,224,58,184,151,251,67,144,16,8,238,223,24,172,41,27,34,162,18,118,104,40,29,181,95,161,174,166,71,249,55,234,217,14,224,66,144,158,86,126,211,103,117,57,115,214,111,73,98,31,190,140,191,7,245,92,244,154,59,95,129,36,97,87,110,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fa6fe31b-4855-4a7a-adcc-c5b7fb65f30f"));
		}

		#endregion

	}

	#endregion

}

