namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadMessageListenerSchema

	/// <exclude/>
	public class LeadMessageListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadMessageListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadMessageListenerSchema(LeadMessageListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f408d242-9302-400c-8b6c-6d9552b53572");
			Name = "LeadMessageListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2b000645-6072-461d-8963-11edfee86881");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,145,77,110,194,48,16,133,215,65,226,14,22,108,232,38,7,0,117,211,168,180,72,148,86,252,28,192,56,47,193,34,177,233,56,174,138,170,222,189,99,39,84,252,69,138,148,121,126,223,204,243,196,59,109,74,177,58,186,6,245,164,223,243,177,92,131,72,58,91,52,105,102,9,255,114,235,74,215,59,130,204,89,72,215,210,237,221,93,170,174,173,185,230,50,91,85,80,141,182,198,165,47,48,32,173,174,45,115,109,62,89,235,247,140,172,225,14,82,225,162,171,41,116,233,73,134,22,253,222,79,240,37,67,66,201,165,200,42,233,220,88,204,57,217,27,156,147,37,230,154,91,242,148,104,59,248,109,165,149,80,193,117,207,36,198,226,73,58,220,160,9,79,73,146,240,158,6,77,53,170,156,39,125,144,254,146,13,98,247,100,8,147,183,231,93,125,74,197,119,109,200,171,198,18,19,49,67,107,232,242,220,73,50,218,56,16,115,166,93,149,240,23,229,3,7,221,114,208,209,181,28,115,38,175,220,196,210,113,165,118,168,229,130,119,40,30,197,224,108,72,119,62,152,220,186,151,40,64,48,10,252,155,124,109,206,225,89,222,1,167,140,45,177,153,229,236,8,134,120,77,151,134,207,85,119,210,2,11,32,207,118,80,251,231,239,136,42,188,23,75,40,75,129,228,197,32,218,126,111,151,216,105,151,123,101,237,252,249,3,16,185,176,191,187,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f408d242-9302-400c-8b6c-6d9552b53572"));
		}

		#endregion

	}

	#endregion

}

