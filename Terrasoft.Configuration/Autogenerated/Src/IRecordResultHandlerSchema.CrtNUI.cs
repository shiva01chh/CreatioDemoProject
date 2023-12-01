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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,205,138,195,32,16,128,207,21,124,135,129,189,180,151,228,158,93,246,210,75,115,40,148,146,23,176,58,54,66,162,97,212,210,178,236,187,215,106,19,194,178,130,200,252,124,51,31,90,49,162,159,132,68,232,144,72,120,167,67,181,119,86,155,107,36,17,140,179,156,253,112,198,217,230,131,240,154,66,104,109,64,210,9,104,160,61,163,116,164,206,232,227,16,14,194,170,1,41,247,214,117,13,95,62,142,163,160,199,247,59,94,56,112,26,66,143,64,25,78,207,139,134,190,224,213,76,215,43,124,138,151,193,72,48,203,132,255,22,67,209,92,60,143,24,122,167,124,3,167,76,151,226,95,177,156,232,146,204,152,187,193,120,192,59,202,24,80,129,208,105,221,108,153,10,19,57,137,222,163,170,150,73,107,201,205,205,25,5,69,236,52,183,110,119,159,111,43,180,170,136,189,162,116,127,203,167,174,210,156,229,28,103,233,60,1,136,93,157,72,150,1,0,0 };
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

