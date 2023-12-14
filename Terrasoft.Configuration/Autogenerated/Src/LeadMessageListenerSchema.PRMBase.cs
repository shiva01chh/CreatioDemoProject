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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,145,77,110,194,48,16,133,215,65,226,14,22,108,232,38,7,0,117,211,168,180,72,148,86,252,28,192,56,47,193,34,177,169,39,174,138,170,222,189,99,39,84,252,69,138,148,121,126,223,204,243,196,147,54,165,88,29,169,65,61,233,247,124,44,215,112,78,146,45,154,52,179,14,255,114,235,74,215,59,7,153,179,144,174,37,237,233,46,85,215,214,92,115,153,173,42,168,70,91,67,233,11,12,156,86,215,150,185,54,159,172,245,123,70,214,160,131,84,184,232,106,10,93,122,39,67,139,126,239,39,248,146,161,67,201,165,200,42,73,52,22,115,78,246,6,34,89,98,174,185,37,79,137,182,131,223,86,90,9,21,92,247,76,98,44,158,36,225,6,77,120,74,146,132,247,52,104,170,81,229,60,233,195,233,47,217,32,118,79,134,48,121,123,222,213,167,84,124,215,198,121,213,88,199,68,204,208,26,186,60,119,146,140,54,4,199,156,105,87,37,252,69,249,192,65,183,28,116,116,45,199,156,201,43,55,177,238,184,82,59,212,114,193,59,20,143,98,112,54,164,59,31,76,110,221,75,20,112,48,10,252,155,124,109,206,225,89,222,1,167,140,45,177,153,229,236,8,134,120,77,74,195,231,170,59,105,129,5,144,103,59,168,253,243,119,68,21,222,139,37,148,117,129,228,197,32,218,126,111,151,216,105,151,123,101,45,60,127,1,231,240,151,179,2,0,0 };
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

