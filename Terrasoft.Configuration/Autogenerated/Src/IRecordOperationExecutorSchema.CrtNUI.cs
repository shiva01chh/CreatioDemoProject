namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IRecordOperationExecutorSchema

	/// <exclude/>
	public class IRecordOperationExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IRecordOperationExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IRecordOperationExecutorSchema(IRecordOperationExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ca04445c-be77-4cfb-a8da-af3e457c1459");
			Name = "IRecordOperationExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,81,203,106,195,48,16,60,55,144,127,88,210,75,123,145,238,137,155,75,201,33,135,146,82,242,3,138,189,114,4,149,100,86,82,168,41,249,247,232,97,155,196,165,2,33,118,53,51,154,89,25,161,209,117,162,70,56,34,145,112,86,122,246,110,141,84,109,32,225,149,53,240,187,92,60,5,167,76,251,128,32,100,59,227,149,87,232,54,203,69,132,60,19,182,9,190,55,30,73,70,193,53,236,191,176,182,212,28,58,44,82,187,31,172,131,183,148,241,156,115,168,92,208,90,80,191,29,234,137,11,86,130,63,199,99,164,2,14,92,144,113,83,214,101,163,10,191,147,233,194,233,91,213,160,38,165,255,76,164,92,17,63,249,254,64,127,182,141,91,195,103,86,40,151,115,147,185,81,20,208,205,28,38,99,152,70,210,179,137,202,231,220,170,19,36,52,152,56,245,183,149,242,168,87,219,60,198,254,79,98,86,241,140,205,212,139,85,205,248,238,203,64,72,236,215,205,16,2,77,83,114,228,250,90,126,228,161,153,123,247,235,6,106,19,6,199,250,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ca04445c-be77-4cfb-a8da-af3e457c1459"));
		}

		#endregion

	}

	#endregion

}

