namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CallMessagePublisherSchema

	/// <exclude/>
	public class CallMessagePublisherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CallMessagePublisherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CallMessagePublisherSchema(CallMessagePublisherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7614e58c-2fc5-4196-ab0f-e9195ef944f6");
			Name = "CallMessagePublisher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e1e897dc-76f3-4978-8d04-4d8824362a32");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,81,106,195,48,12,134,159,19,200,29,68,247,210,65,233,1,210,109,208,165,219,158,54,6,221,14,160,186,106,106,112,156,98,217,131,16,118,247,201,118,97,203,90,99,176,245,251,211,47,75,129,181,109,97,59,176,167,110,217,244,198,144,242,186,183,188,124,33,75,78,171,85,85,134,132,124,144,115,200,253,193,11,229,72,228,170,180,216,17,159,80,209,228,209,30,116,27,28,70,151,170,28,171,178,144,125,227,168,149,24,26,131,204,53,52,104,204,43,49,99,75,239,97,103,52,31,201,69,195,226,20,35,5,42,98,87,41,168,225,17,153,46,147,139,49,25,252,86,146,30,188,11,202,247,174,134,196,169,12,156,75,92,51,159,127,50,57,73,180,121,6,16,38,225,2,54,58,93,208,13,119,226,45,67,89,64,62,31,128,172,215,126,120,214,100,246,188,65,143,183,177,84,81,195,78,62,59,255,239,115,1,195,152,240,167,164,111,213,145,58,124,147,217,194,61,204,214,146,243,37,234,108,21,145,239,115,147,100,247,185,207,20,103,117,42,138,246,119,253,0,123,145,113,129,231,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7614e58c-2fc5-4196-ab0f-e9195ef944f6"));
		}

		#endregion

	}

	#endregion

}

