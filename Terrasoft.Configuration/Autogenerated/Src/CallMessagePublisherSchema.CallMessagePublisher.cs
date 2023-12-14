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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,81,106,195,48,12,134,159,19,200,29,68,247,210,65,233,1,210,109,176,165,219,158,54,6,221,14,160,186,106,106,112,156,34,217,131,16,118,247,201,78,97,116,173,49,216,250,253,233,151,165,40,214,183,176,25,36,80,183,108,122,231,200,4,219,123,89,190,146,39,182,102,85,149,49,35,159,196,140,210,239,131,82,76,42,87,165,199,142,228,136,134,206,30,253,222,182,145,49,185,84,229,88,149,133,238,27,166,86,99,104,28,138,212,208,160,115,111,36,130,45,125,196,173,179,114,32,78,134,197,49,69,6,76,194,174,82,80,195,19,10,93,38,23,99,54,248,171,164,61,4,142,38,244,92,67,230,204,4,156,74,92,51,159,127,9,177,38,250,105,6,16,207,194,5,172,109,190,32,15,119,234,173,67,89,192,116,62,0,249,96,195,240,98,201,237,100,141,1,111,83,169,162,134,173,126,118,254,223,231,2,134,49,227,207,89,223,152,3,117,248,174,179,133,123,152,61,106,206,183,170,179,85,66,126,78,77,146,223,77,125,230,120,82,207,69,213,210,250,5,62,22,127,204,223,1,0,0 };
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

