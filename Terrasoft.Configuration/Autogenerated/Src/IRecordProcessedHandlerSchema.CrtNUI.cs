namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IRecordProcessedHandlerSchema

	/// <exclude/>
	public class IRecordProcessedHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IRecordProcessedHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IRecordProcessedHandlerSchema(IRecordProcessedHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("19ec078f-2d2a-4581-b154-931f817b018f");
			Name = "IRecordProcessedHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,209,106,131,48,20,134,175,87,232,59,28,220,205,6,195,220,119,78,40,163,176,94,12,202,216,11,164,201,81,83,52,145,147,88,58,198,222,125,73,140,210,73,39,34,156,147,255,255,252,207,137,230,29,218,158,11,132,79,36,226,214,84,46,127,53,186,82,245,64,220,41,163,225,123,189,186,243,239,61,97,29,202,189,118,72,149,55,108,96,255,129,194,144,60,144,17,104,45,202,55,174,101,139,180,94,121,57,99,12,10,59,116,29,167,175,50,213,179,21,76,5,174,65,160,232,135,126,2,64,51,18,242,9,192,174,8,253,112,108,149,0,53,67,254,249,125,8,236,229,115,224,119,116,141,145,118,3,135,8,24,15,151,241,98,99,2,84,134,110,199,195,51,106,151,207,126,182,4,20,61,39,222,129,246,59,125,201,44,106,137,148,149,187,11,138,33,110,82,24,159,253,226,242,130,69,221,109,27,167,218,102,229,86,74,21,60,188,245,3,251,60,221,120,23,105,111,139,193,83,174,107,236,217,40,153,230,89,136,31,204,241,132,194,193,24,239,105,201,218,5,212,214,103,128,16,228,241,57,237,210,139,199,117,198,250,39,126,255,54,99,47,60,191,224,190,96,8,82,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19ec078f-2d2a-4581-b154-931f817b018f"));
		}

		#endregion

	}

	#endregion

}

