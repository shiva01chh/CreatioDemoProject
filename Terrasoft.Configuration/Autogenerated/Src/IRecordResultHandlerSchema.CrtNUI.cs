namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IRecordResultHandlerSchema

	/// <exclude/>
	public class IRecordResultHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IRecordResultHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IRecordResultHandlerSchema(IRecordResultHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("52df6bf9-2697-4d65-9203-47d8c0b2315b");
			Name = "IRecordResultHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,205,138,194,48,16,128,207,6,242,14,3,94,214,75,123,87,241,178,23,61,44,136,248,2,49,153,216,64,155,148,73,178,40,226,187,155,38,182,20,49,16,194,252,124,51,31,177,162,67,223,11,137,112,70,34,225,157,14,213,175,179,218,92,35,137,96,156,229,236,193,25,103,139,37,225,53,133,112,176,1,73,39,96,13,135,19,74,71,234,132,62,182,97,47,172,106,145,114,111,93,215,176,245,177,235,4,221,119,239,120,226,192,105,8,13,2,101,56,61,3,13,77,193,171,145,174,103,120,31,47,173,145,96,166,9,223,22,67,209,156,60,255,48,52,78,249,53,28,51,93,138,159,98,57,113,78,50,93,238,6,227,1,111,40,99,64,5,66,167,117,163,101,42,244,228,36,122,143,170,154,38,205,37,23,255,206,40,40,98,199,177,245,103,181,121,91,161,85,69,108,136,210,125,150,79,157,165,57,203,57,206,134,243,2,220,144,252,209,151,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("52df6bf9-2697-4d65-9203-47d8c0b2315b"));
		}

		#endregion

	}

	#endregion

}

