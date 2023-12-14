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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,81,193,78,3,33,16,61,111,147,254,195,100,189,232,5,238,181,245,96,211,91,99,15,245,102,60,32,157,93,73,150,97,195,128,205,198,248,239,2,181,186,106,181,36,36,188,225,189,153,199,131,148,69,238,149,70,184,71,239,21,187,38,136,165,163,198,180,209,171,96,28,77,39,175,211,73,21,217,80,11,219,129,3,218,235,79,60,150,120,252,171,46,86,20,76,48,200,103,9,98,245,130,20,50,47,49,47,60,182,105,62,44,59,197,60,131,53,170,221,102,79,232,11,103,109,146,147,4,10,83,74,9,115,142,214,42,63,220,124,224,35,1,92,3,110,95,14,4,155,190,119,62,68,50,97,0,204,51,7,113,148,203,31,250,57,35,170,142,29,104,143,205,162,254,223,176,184,85,140,165,54,124,115,87,131,204,253,30,78,92,93,110,245,51,90,117,151,226,135,5,212,35,103,245,213,99,210,244,241,169,51,26,116,126,252,216,247,239,8,96,6,95,227,79,37,84,229,15,172,210,126,59,228,138,180,59,68,155,97,169,229,245,14,199,204,80,141,9,2,0,0 };
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

