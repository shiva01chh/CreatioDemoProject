namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityOwnerEventListenerSchema

	/// <exclude/>
	public class OpportunityOwnerEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityOwnerEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityOwnerEventListenerSchema(OpportunityOwnerEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("45b2d596-38cb-494e-80ad-afc0697d9ae4");
			Name = "OpportunityOwnerEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1a637eec-ed5e-4e5a-93be-edcf08166986");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,81,193,78,3,33,16,61,111,147,254,195,100,189,232,5,238,181,245,96,211,91,99,15,245,102,60,140,116,118,37,89,96,195,128,205,198,248,239,2,181,186,106,181,36,36,188,225,189,153,199,195,162,33,238,81,17,220,147,247,200,174,9,98,233,108,163,219,232,49,104,103,167,147,215,233,164,138,172,109,11,219,129,3,153,235,79,60,150,120,250,171,46,86,54,232,160,137,207,18,196,234,133,108,200,188,196,188,240,212,166,249,176,236,144,121,6,107,194,221,102,111,201,23,206,90,39,39,9,20,166,148,18,230,28,141,65,63,220,124,224,35,1,92,3,110,95,14,22,54,125,239,124,136,86,135,1,40,207,28,196,81,46,127,232,231,76,132,29,59,80,158,154,69,253,191,97,113,139,76,165,54,124,115,87,131,204,253,30,78,92,93,110,213,51,25,188,75,241,195,2,234,145,179,250,234,49,105,250,248,212,105,5,42,63,126,236,251,119,4,48,131,175,241,167,18,170,242,7,86,105,191,29,114,37,187,59,68,155,97,169,165,245,14,51,66,171,87,8,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45b2d596-38cb-494e-80ad-afc0697d9ae4"));
		}

		#endregion

	}

	#endregion

}

