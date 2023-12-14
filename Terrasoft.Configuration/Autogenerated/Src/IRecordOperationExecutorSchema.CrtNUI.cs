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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,81,203,106,195,48,16,60,55,144,127,88,210,75,123,145,238,137,155,75,201,33,135,210,80,250,3,138,189,114,4,145,100,86,82,136,9,253,247,234,97,155,196,165,2,33,118,53,51,154,89,25,161,209,117,162,70,248,70,34,225,172,244,236,221,26,169,218,64,194,43,107,224,182,92,60,5,167,76,251,128,32,100,59,227,149,87,232,54,203,69,132,60,19,182,9,190,55,30,73,70,193,53,236,191,176,182,212,124,118,88,164,118,87,172,131,183,148,241,156,115,168,92,208,90,80,191,29,234,137,11,86,130,63,197,99,164,2,14,92,144,113,83,214,101,163,10,191,147,233,194,241,172,106,80,147,210,127,38,82,174,136,159,124,127,160,63,217,198,173,225,144,21,202,229,220,100,110,20,5,116,51,135,201,24,166,145,244,108,162,242,57,183,234,4,9,13,38,78,253,109,165,60,234,213,54,143,177,255,147,152,85,60,99,51,245,98,85,51,190,251,50,16,18,251,117,51,132,64,211,148,28,185,254,41,63,242,208,204,189,180,126,1,253,3,84,139,242,1,0,0 };
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

